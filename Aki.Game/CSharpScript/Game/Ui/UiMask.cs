using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Ui
{
	// Token: 0x02003605 RID: 13829
	[NullableContext(1)]
	[Nullable(0)]
	public class UiMask
	{
		// Token: 0x060233C2 RID: 144322 RVA: 0x00A02BF3 File Offset: 0x00A00DF3
		private void RemoveMaskTimer(MaskData maskData)
		{
			if (maskData.Timer != null)
			{
				TimerSystem.Instance.Remove(maskData.Timer);
				maskData.Timer = null;
			}
		}

		// Token: 0x060233C3 RID: 144323 RVA: 0x00A02C18 File Offset: 0x00A00E18
		[return: Nullable(2)]
		private TimerHandle CreateTimer(string maskTag, int count)
		{
			return TimerSystem.Instance.Delay(delegate(float arg)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.UiMask;
				ELogAuthor author = ELogAuthor.XXJ;
				string message = "[UiMask]超过保底时间,定时器执行逻辑,解除遮罩";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("MaskTag", maskTag);
				instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				this.ClearMaskData(maskTag);
			}, 2000f, null, null, true, 1f);
		}

		// Token: 0x060233C4 RID: 144324 RVA: 0x00A02C5C File Offset: 0x00A00E5C
		private void AddMaskTimer(MaskData maskData)
		{
			maskData.Timer = this.CreateTimer(maskData.Tag, maskData.Count);
			UiLayer.Instance.SetShowMaskLayer(maskData.Tag, true);
		}

		// Token: 0x060233C5 RID: 144325 RVA: 0x00A02C88 File Offset: 0x00A00E88
		private void AddMaskData(string maskTag)
		{
			MaskData maskData;
			if (this.MaskDataMap.TryGetValue(maskTag, out maskData))
			{
				this.RemoveMaskTimer(maskData);
				maskData.Count++;
				this.AddMaskTimer(maskData);
				return;
			}
			maskData = new MaskData
			{
				Tag = maskTag,
				Timer = null,
				Count = 1
			};
			this.MaskDataMap[maskTag] = maskData;
			this.AddMaskTimer(maskData);
		}

		// Token: 0x060233C6 RID: 144326 RVA: 0x00A02CF4 File Offset: 0x00A00EF4
		private void RemoveMaskData(string maskTag)
		{
			MaskData maskData;
			if (!this.MaskDataMap.TryGetValue(maskTag, out maskData))
			{
				return;
			}
			maskData.Count--;
			if (maskData.Count <= 0)
			{
				this.RemoveMaskTimer(maskData);
				this.ClearMaskData(maskTag);
			}
		}

		// Token: 0x060233C7 RID: 144327 RVA: 0x00A02D37 File Offset: 0x00A00F37
		private void ClearMaskData(string maskTag)
		{
			this.MaskDataMap.Remove(maskTag);
			UiLayer.Instance.SetShowMaskLayer(maskTag, false);
		}

		// Token: 0x060233C8 RID: 144328 RVA: 0x00A02D52 File Offset: 0x00A00F52
		public void SetMask(string maskTag, bool value)
		{
			if (value)
			{
				this.AddMaskData(maskTag);
				return;
			}
			this.RemoveMaskData(maskTag);
		}

		// Token: 0x04013DE2 RID: 81378
		private const int MASK_DESTROY_TIME = 2000;

		// Token: 0x04013DE3 RID: 81379
		private readonly Dictionary<string, MaskData> MaskDataMap = new Dictionary<string, MaskData>();
	}
}
