using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Plot.PlotView
{
	// Token: 0x02004015 RID: 16405
	[NullableContext(2)]
	[Nullable(0)]
	public class FloatingSubtitleSpaceMarkWatcher
	{
		// Token: 0x0602985E RID: 170078 RVA: 0x00BB9018 File Offset: 0x00BB7218
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

		// Token: 0x0602985F RID: 170079 RVA: 0x00BB90AB File Offset: 0x00BB72AB
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

		// Token: 0x06029860 RID: 170080 RVA: 0x00BB90EC File Offset: 0x00BB72EC
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

		// Token: 0x04016A96 RID: 92822
		private const int POLL_INTERVAL_MS = 100;

		// Token: 0x04016A97 RID: 92823
		private Ticker Ticker;

		// Token: 0x04016A98 RID: 92824
		private UUIText Text;

		// Token: 0x04016A99 RID: 92825
		[Nullable(1)]
		private string RawText = "";

		// Token: 0x04016A9A RID: 92826
		private int LastSpaceSize;
	}
}
