using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Fishing
{
	// Token: 0x0200660B RID: 26123
	public class FishingDockReputationItem : UiPanelBase
	{
		// Token: 0x06041774 RID: 268148 RVA: 0x00FDA924 File Offset: 0x00FD8B24
		protected unsafe override void OnRegisterComponent()
		{
			int num = 4;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIButtonComponent));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(3, new Action(this.OnClickHelpBtn));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06041775 RID: 268149 RVA: 0x00FDAA0C File Offset: 0x00FD8C0C
		protected override void OnStart()
		{
			this.RefreshItem();
		}

		// Token: 0x06041776 RID: 268150 RVA: 0x00FDAA14 File Offset: 0x00FD8C14
		public void RefreshItem()
		{
			int fishingReputationItemId = FishingModel.Instance.FishingReputationItemId;
			int num = InventoryModel.Instance.GetCommonItemCount(fishingReputationItemId, 0);
			int fishingReputationLevelByItemCount = FishingModel.Instance.GetFishingReputationLevelByItemCount(num);
			int configMaxFishingReputationLevel = FishingModel.Instance.GetConfigMaxFishingReputationLevel();
			float num2 = 0f;
			if (fishingReputationLevelByItemCount >= configMaxFishingReputationLevel)
			{
				FishingReputation fishingReputationByLevel = FishingConfig.Instance.GetFishingReputationByLevel(configMaxFishingReputationLevel - 1);
				num2 = (float)(FishingConfig.Instance.GetFishingReputationByLevel(configMaxFishingReputationLevel).Exp - fishingReputationByLevel.Exp);
				num -= fishingReputationByLevel.Exp;
			}
			else if (fishingReputationLevelByItemCount >= 1)
			{
				FishingReputation fishingReputationByLevel2 = FishingConfig.Instance.GetFishingReputationByLevel(fishingReputationLevelByItemCount);
				num2 = (float)(FishingConfig.Instance.GetFishingReputationByLevel(fishingReputationLevelByItemCount + 1).Exp - fishingReputationByLevel2.Exp);
				num -= fishingReputationByLevel2.Exp;
			}
			float num3 = (float)num / num2;
			base.GetTexture(0).SetFillAmount((num3 < 1f) ? num3 : 1f);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), "PrefabTextItem_3692737534_Text", new <>z__ReadOnlySingleElementList<object>(fishingReputationLevelByItemCount));
			base.GetText(2).SetText(num.ToString() + "/" + num2.ToString(), true);
		}

		// Token: 0x06041777 RID: 268151 RVA: 0x00FDAB3C File Offset: 0x00FD8D3C
		private void OnClickHelpBtn()
		{
			HelpController.Instance.OpenHelpById(188);
		}

		// Token: 0x0200C816 RID: 51222
		private class EComponentDefine
		{
			// Token: 0x0403C6C5 RID: 247493
			public const int BarTexture = 0;

			// Token: 0x0403C6C6 RID: 247494
			public const int LevelText = 1;

			// Token: 0x0403C6C7 RID: 247495
			public const int ItemNumberText = 2;

			// Token: 0x0403C6C8 RID: 247496
			public const int HelpBtn = 3;
		}
	}
}
