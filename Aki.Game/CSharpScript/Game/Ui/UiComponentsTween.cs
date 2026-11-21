using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Ui
{
	// Token: 0x02003559 RID: 13657
	[NullableContext(1)]
	[Nullable(0)]
	public class UiComponentsTween
	{
		// Token: 0x06022B8D RID: 142221 RVA: 0x009DFBA7 File Offset: 0x009DDDA7
		public UiComponentsTween(UUIItem rootItem)
		{
			this.RootItem = rootItem;
		}

		// Token: 0x06022B8E RID: 142222 RVA: 0x009DFBB8 File Offset: 0x009DDDB8
		private void PlayViewTween(bool reverse = false)
		{
			float time = this.UiComponentsTweenData.Time;
			float targetAlpha = this.UiComponentsTweenData.TargetAlpha;
			float startValue = reverse ? targetAlpha : 1f;
			float endValue = reverse ? 1f : targetAlpha;
			foreach (UUIItem uuiitem in this.UnSafeItemList)
			{
				uuiitem.PlayUIItemAlphaTween(startValue, endValue, time);
			}
			float targetSize = this.UiComponentsTweenData.TargetSize;
			float startValue2 = reverse ? targetSize : 1f;
			float endValue2 = reverse ? 1f : targetSize;
			foreach (UUIItem uuiitem2 in this.UnSafeItemList)
			{
				uuiitem2.PlayUIItemScaleTween(startValue2, endValue2, time);
			}
		}

		// Token: 0x06022B8F RID: 142223 RVA: 0x009DFCAC File Offset: 0x009DDEAC
		protected void CollectUnSafeItem()
		{
			if (this.UnSafeItemList != null)
			{
				return;
			}
			this.UnSafeItemList = new List<UUIItem>();
			bool flag = false;
			TArray<UUIItem> attachUIChildren = this.RootItem.GetAttachUIChildren();
			int i = 0;
			int num = attachUIChildren.Num();
			while (i < num)
			{
				UUIItem uuiitem = attachUIChildren.Get(i);
				if (flag)
				{
					goto IL_61;
				}
				AActor owner = uuiitem.GetOwner();
				if (!(((owner != null) ? owner.GetComponentByClass(UUISafeZone.StaticClass()) : null) is UUIItem))
				{
					goto IL_61;
				}
				flag = true;
				IL_6E:
				i++;
				continue;
				IL_61:
				this.UnSafeItemList.Add(uuiitem);
				goto IL_6E;
			}
			if (!flag)
			{
				this.UnSafeItemList.Clear();
				this.UnSafeItemList.Add(this.RootItem);
			}
		}

		// Token: 0x06022B90 RID: 142224 RVA: 0x009DFD4E File Offset: 0x009DDF4E
		public void SetUiComponentsTweenData(UUIViewTweenParams tweenParams)
		{
			if (tweenParams == null)
			{
				return;
			}
			this.UiComponentsTweenData = new UiComponentsTweenData(tweenParams.GetTweenAlpha(), tweenParams.GetTweenSize(), tweenParams.GetTweenTime());
		}

		// Token: 0x06022B91 RID: 142225 RVA: 0x009DFD71 File Offset: 0x009DDF71
		public void PlayStartTween()
		{
			this.CollectUnSafeItem();
			this.PlayViewTween(false);
		}

		// Token: 0x06022B92 RID: 142226 RVA: 0x009DFD80 File Offset: 0x009DDF80
		public void PlayCloseTween()
		{
			this.PlayViewTween(true);
		}

		// Token: 0x06022B93 RID: 142227 RVA: 0x009DFD89 File Offset: 0x009DDF89
		public void Destroy()
		{
			this.UiComponentsTweenData = null;
			this.RootItem = null;
			this.UnSafeItemList = null;
		}

		// Token: 0x040133B5 RID: 78773
		private UiComponentsTweenData UiComponentsTweenData;

		// Token: 0x040133B6 RID: 78774
		private UUIItem RootItem;

		// Token: 0x040133B7 RID: 78775
		private List<UUIItem> UnSafeItemList;
	}
}
