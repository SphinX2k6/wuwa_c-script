using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.LineCross
{
	// Token: 0x0200655C RID: 25948
	internal class LineCrossClawItem : UiPanelBase
	{
		// Token: 0x0604106C RID: 266348 RVA: 0x00FC2928 File Offset: 0x00FC0B28
		protected unsafe override void OnRegisterComponent()
		{
			int num = 6;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUISprite));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0604106D RID: 266349 RVA: 0x00FC2A18 File Offset: 0x00FC0C18
		public void Refresh(bool ifHidden, ELineCrossGroupState state)
		{
			string resourceId;
			string resourceId2;
			switch (state)
			{
			case ELineCrossGroupState.Normal:
				this.RefreshNormal();
				resourceId = "T_CrosslineCraw1";
				resourceId2 = "T_CrosslineCraw";
				break;
			case ELineCrossGroupState.Passed:
				this.RefreshClear();
				resourceId = "T_CrosslineCraw1";
				resourceId2 = "T_CrosslineCraw";
				break;
			case ELineCrossGroupState.Lock:
				this.RefreshLock();
				resourceId = "T_CrosslineCrawLine";
				resourceId2 = "T_CrosslineCraw";
				break;
			default:
				this.RefreshNormal();
				resourceId = "T_CrosslineCraw1";
				resourceId2 = "T_CrosslineCraw";
				break;
			}
			if (ifHidden)
			{
				resourceId = "T_CrosslineCrawLineMystery";
				resourceId2 = "T_CrosslineCrawLineMystery";
			}
			string resourcePath = UiResourceConfig.Instance.GetResourcePath(resourceId);
			string resourcePath2 = UiResourceConfig.Instance.GetResourcePath(resourceId2);
			base.SetTextureByPath(resourcePath, base.GetTexture(2), null, null);
			base.SetTextureByPath(resourcePath2, base.GetTexture(3), null, null);
		}

		// Token: 0x0604106E RID: 266350 RVA: 0x00FC2AEC File Offset: 0x00FC0CEC
		private void RefreshNormal()
		{
			base.GetTexture(0).SetColor(FColor.FromHex("764372"));
			base.GetTexture(1).SetColor(FColor.FromHex("444dba"));
			base.GetTexture(2).SetColor(FColor.FromHex("c594ff"));
			base.GetTexture(3).SetColor(FColor.FromHex("c594ff"));
			base.GetSprite(4).SetColor(FColor.FromHex("582e8c"));
			base.GetSprite(5).SetColor(FColor.FromHex("582e8c"));
			base.GetSprite(4).SetUIActive(true);
			base.GetSprite(5).SetUIActive(true);
		}

		// Token: 0x0604106F RID: 266351 RVA: 0x00FC2B98 File Offset: 0x00FC0D98
		private void RefreshClear()
		{
			base.GetTexture(0).SetColor(FColor.FromHex("764372"));
			base.GetTexture(1).SetColor(FColor.FromHex("6dac75"));
			base.GetTexture(2).SetColor(FColor.FromHex("b2ffbf"));
			base.GetTexture(3).SetColor(FColor.FromHex("b2ffbf"));
			base.GetSprite(4).SetColor(FColor.FromHex("45945b"));
			base.GetSprite(5).SetColor(FColor.FromHex("45945b"));
			base.GetSprite(4).SetUIActive(true);
			base.GetSprite(5).SetUIActive(true);
		}

		// Token: 0x06041070 RID: 266352 RVA: 0x00FC2C44 File Offset: 0x00FC0E44
		private void RefreshLock()
		{
			base.GetTexture(0).SetColor(FColor.FromHex("4e4e4e"));
			base.GetTexture(1).SetColor(FColor.FromHex("5d6161"));
			base.GetTexture(2).SetColor(FColor.FromHex("c65959"));
			base.GetTexture(3).SetColor(FColor.FromHex("c65959"));
			base.GetSprite(4).SetUIActive(false);
			base.GetSprite(5).SetUIActive(false);
		}

		// Token: 0x0200C755 RID: 51029
		private class EComponent
		{
			// Token: 0x0403C38D RID: 246669
			public const int TextureDesc1 = 0;

			// Token: 0x0403C38E RID: 246670
			public const int TextureDesc2 = 1;

			// Token: 0x0403C38F RID: 246671
			public const int ClawTexture1 = 2;

			// Token: 0x0403C390 RID: 246672
			public const int ClawTexture2 = 3;

			// Token: 0x0403C391 RID: 246673
			public const int SpriteDesc3 = 4;

			// Token: 0x0403C392 RID: 246674
			public const int SpriteDesc4 = 5;
		}
	}
}
