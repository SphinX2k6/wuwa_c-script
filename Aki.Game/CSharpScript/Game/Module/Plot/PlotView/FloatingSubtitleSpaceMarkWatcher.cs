using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Plot.PlotView
{
	// Token: 0x02005046 RID: 20550
	[NullableContext(2)]
	[Nullable(0)]
	public class FloatingSubtitleSpaceMarkWatcher
	{
		// Token: 0x06034982 RID: 215426 RVA: 0x00C6BF78 File Offset: 0x00C6A178
		public void Start(UUIText text)
		{
			this.Stop();
			if (!ObjectUtils.IsValid(text))
			{
				return;
			}
			string text2 = text.GetText();
			int spaceSize = FloatingSubtitleLanguageUtil.Instance.GetSpaceSize(text.GetSize());
			if (!FloatingSubtitleLanguageUtil.Instance.RefreshSpaceMark(text, text2, spaceSize))
			{
				return;
			}
			this.Text = text;
			this.RawText = text2;
			this.LastSpaceSize = spaceSize;
			this.Ticker = TickSystem.Instance.Add(new Action<float>(this.OnTick), "FloatingSubtitleSpaceMark", ETickingGroup.TG_PrePhysics, false, 0, false);
			if (this.Ticker != null)
			{
				this.Ticker.TickIntervalMs = 100;
			}
		}

		// Token: 0x06034983 RID: 215427 RVA: 0x00C6C00B File Offset: 0x00C6A20B
		public void Stop()
		{
			if (this.Ticker != null)
			{
				TickSystem.Instance.Remove(this.Ticker.Id);
				this.Ticker = null;
			}
			this.Text = null;
			this.RawText = "";
			this.LastSpaceSize = 0;
		}

		// Token: 0x06034984 RID: 215428 RVA: 0x00C6C04C File Offset: 0x00C6A24C
		private void OnTick(float delta)
		{
			UUIText text = this.Text;
			if (!ObjectUtils.IsValid(text))
			{
				this.Stop();
				return;
			}
			int spaceSize = FloatingSubtitleLanguageUtil.Instance.GetSpaceSize(text.GetSize());
			if (spaceSize <= 0 || spaceSize == this.LastSpaceSize)
			{
				return;
			}
			this.LastSpaceSize = spaceSize;
			FloatingSubtitleLanguageUtil.Instance.RefreshSpaceMark(text, this.RawText, spaceSize);
		}

		// Token: 0x0401C073 RID: 114803
		private const int POLL_INTERVAL_MS = 100;

		// Token: 0x0401C074 RID: 114804
		private Ticker Ticker;

		// Token: 0x0401C075 RID: 114805
		private UUIText Text;

		// Token: 0x0401C076 RID: 114806
		[Nullable(1)]
		private string RawText = "";

		// Token: 0x0401C077 RID: 114807
		private int LastSpaceSize;
	}
}
