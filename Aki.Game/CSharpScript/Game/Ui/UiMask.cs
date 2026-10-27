using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Ui
{
	// Token: 0x020046D5 RID: 18133
	[NullableContext(1)]
	[Nullable(0)]
	public class UiMask
	{
		// Token: 0x0602EC88 RID: 191624 RVA: 0x00AD514F File Offset: 0x00AD334F
		private void RemoveMaskTimer(MaskData maskData)
		{
			if (maskData.Timer != null)
			{
				TimerSystem.Instance.Remove(maskData.Timer);
				maskData.Timer = null;
			}
		}

		// Token: 0x0602EC89 RID: 191625 RVA: 0x00AD5174 File Offset: 0x00AD3374
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

		// Token: 0x0602EC8A RID: 191626 RVA: 0x00AD51B8 File Offset: 0x00AD33B8
		private void AddMaskTimer(MaskData maskData)
		{
			maskData.Timer = this.CreateTimer(maskData.Tag, maskData.Count);
			UiLayer.Instance.SetShowMaskLayer(maskData.Tag, true);
		}

		// Token: 0x0602EC8B RID: 191627 RVA: 0x00AD51E4 File Offset: 0x00AD33E4
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

		// Token: 0x0602EC8C RID: 191628 RVA: 0x00AD5250 File Offset: 0x00AD3450
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

		// Token: 0x0602EC8D RID: 191629 RVA: 0x00AD5293 File Offset: 0x00AD3493
		private void ClearMaskData(string maskTag)
		{
			this.MaskDataMap.Remove(maskTag);
			UiLayer.Instance.SetShowMaskLayer(maskTag, false);
		}

		// Token: 0x0602EC8E RID: 191630 RVA: 0x00AD52AE File Offset: 0x00AD34AE
		public void SetMask(string maskTag, bool value)
		{
			if (value)
			{
				this.AddMaskData(maskTag);
				return;
			}
			this.RemoveMaskData(maskTag);
		}

		// Token: 0x04019744 RID: 104260
		private const int MASK_DESTROY_TIME = 2000;

		// Token: 0x04019745 RID: 104261
		private readonly Dictionary<string, MaskData> MaskDataMap = new Dictionary<string, MaskData>();
	}
}
