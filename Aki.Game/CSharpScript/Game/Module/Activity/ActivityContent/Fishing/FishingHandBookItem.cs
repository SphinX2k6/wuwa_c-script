using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Item;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Fishing
{
	// Token: 0x02006613 RID: 26131
	public class FishingHandBookItem : GridProxyAbstract<int>
	{
		// Token: 0x060417BF RID: 268223 RVA: 0x00FDC734 File Offset: 0x00FDA934
		protected unsafe override void OnRegisterComponent()
		{
			int num = 6;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIExtendToggle));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUISprite));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnClickToggle));
			this.BtnBindInfo = list2;
		}

		// Token: 0x060417C0 RID: 268224 RVA: 0x00FDC860 File Offset: 0x00FDAA60
		public override void Refresh(int data, bool isSelected, int gridIndex)
		{
			this.ItemId = data;
			FishingItem? fishingItemConfig = FishingConfig.Instance.GetFishingItemConfig(this.ItemId);
			if (fishingItemConfig == null)
			{
				return;
			}
			IFishingHandBook fishingHandBook;
			bool flag = !FishingModel.Instance.FishingItemHandBookDataMap.TryGetValue(this.ItemId, out fishingHandBook);
			string text = flag ? ConfigMultiTextLang.GetLocalTextNew("FishingLockItemName", null) : ConfigMultiTextLang.GetLocalTextNew(fishingItemConfig.Value.Name, null);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(2), "Fishing_ArchiveTitle", new <>z__ReadOnlyArray<object>(new object[]
			{
				fishingItemConfig.Value.IllustratedNum.ToString(),
				text
			}));
			base.SetTextureByPath(fishingItemConfig.Value.Icon, base.GetTexture(4), null, null);
			this.SetTextureMaterialActive(!flag);
			base.GetExtendToggle(0).SetToggleState(isSelected ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, false, false, false);
			int quality = fishingItemConfig.Value.Quality;
			QualityInfo? qualityInfo;
			string path = (ItemConfig.Instance.GetQualityConfig(quality) != null) ? qualityInfo.GetValueOrDefault().BackgroundSprite : null;
			this.SetSpriteByPath(path, base.GetSprite(5), false, null, null);
			bool flag2 = NewFlagModel.Instance.HasNewFlag(ELocalStoragePlayerKey.FishingHandBookItemRecord, this.ItemId);
			if (!flag)
			{
				base.GetItem(3).SetUIActive(!flag2);
				return;
			}
			base.GetItem(3).SetUIActive(false);
		}

		// Token: 0x060417C1 RID: 268225 RVA: 0x00FDC9E8 File Offset: 0x00FDABE8
		public override void Clear()
		{
			EventSystem.Instance.Emit<string>(EEventName.FinishGuideStepByEvent, "FishingHandBookItem");
		}

		// Token: 0x060417C2 RID: 268226 RVA: 0x00FDC9FF File Offset: 0x00FDABFF
		private void OnClickToggle(EToggleState toggleState)
		{
			Action<int, UUIExtendToggle, int> onClickToggleCallBack = this.OnClickToggleCallBack;
			if (onClickToggleCallBack == null)
			{
				return;
			}
			onClickToggleCallBack(this.ItemId, base.GetExtendToggle(0), base.GridIndex);
		}

		// Token: 0x060417C3 RID: 268227 RVA: 0x00FDCA24 File Offset: 0x00FDAC24
		public override void OnSelected(bool fireEvent)
		{
			base.GetItem(3).SetUIActive(false);
			if (!fireEvent)
			{
				return;
			}
			base.GetExtendToggle(0).SetToggleState(EToggleState.ETT_Checked, true, false, false);
		}

		// Token: 0x060417C4 RID: 268228 RVA: 0x00FDCA48 File Offset: 0x00FDAC48
		private void SetTextureMaterialActive(bool value)
		{
			if (value)
			{
				base.GetTexture(4).SetCustomMaterialScalarParameter(FishingDefine.materialProgressName, 1f);
				return;
			}
			base.GetTexture(4).SetCustomMaterialScalarParameter(FishingDefine.materialProgressName, 0f);
		}

		// Token: 0x0402213D RID: 139581
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Action<int, UUIExtendToggle, int> OnClickToggleCallBack;

		// Token: 0x0402213E RID: 139582
		private int ItemId;

		// Token: 0x0200C822 RID: 51234
		private class EComponentDefine
		{
			// Token: 0x0403C716 RID: 247574
			public const int Toggle = 0;

			// Token: 0x0403C717 RID: 247575
			public const int ItemSmallItem = 1;

			// Token: 0x0403C718 RID: 247576
			public const int NameText = 2;

			// Token: 0x0403C719 RID: 247577
			public const int NewItem = 3;

			// Token: 0x0403C71A RID: 247578
			public const int FishItemTexture = 4;

			// Token: 0x0403C71B RID: 247579
			public const int QualitySprite = 5;
		}
	}
}
