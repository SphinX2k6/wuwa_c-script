using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Ui
{
	// Token: 0x0200462F RID: 17967
	[NullableContext(1)]
	[Nullable(0)]
	public class UiComponentsTween
	{
		// Token: 0x0602E47A RID: 189562 RVA: 0x00AB2E17 File Offset: 0x00AB1017
		public UiComponentsTween(UUIItem rootItem)
		{
			this.RootItem = rootItem;
		}

		// Token: 0x0602E47B RID: 189563 RVA: 0x00AB2E28 File Offset: 0x00AB1028
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

		// Token: 0x0602E47C RID: 189564 RVA: 0x00AB2F1C File Offset: 0x00AB111C
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

		// Token: 0x0602E47D RID: 189565 RVA: 0x00AB2FBE File Offset: 0x00AB11BE
		public void SetUiComponentsTweenData(UUIViewTweenParams tweenParams)
		{
			if (tweenParams == null)
			{
				return;
			}
			this.UiComponentsTweenData = new UiComponentsTweenData(tweenParams.GetTweenAlpha(), tweenParams.GetTweenSize(), tweenParams.GetTweenTime());
		}

		// Token: 0x0602E47E RID: 189566 RVA: 0x00AB2FE1 File Offset: 0x00AB11E1
		public void PlayStartTween()
		{
			this.CollectUnSafeItem();
			this.PlayViewTween(false);
		}

		// Token: 0x0602E47F RID: 189567 RVA: 0x00AB2FF0 File Offset: 0x00AB11F0
		public void PlayCloseTween()
		{
			this.PlayViewTween(true);
		}

		// Token: 0x0602E480 RID: 189568 RVA: 0x00AB2FF9 File Offset: 0x00AB11F9
		public void Destroy()
		{
			this.UiComponentsTweenData = null;
			this.RootItem = null;
			this.UnSafeItemList = null;
		}

		// Token: 0x04018D68 RID: 101736
		private UiComponentsTweenData UiComponentsTweenData;

		// Token: 0x04018D69 RID: 101737
		private UUIItem RootItem;

		// Token: 0x04018D6A RID: 101738
		private List<UUIItem> UnSafeItemList;
	}
}
