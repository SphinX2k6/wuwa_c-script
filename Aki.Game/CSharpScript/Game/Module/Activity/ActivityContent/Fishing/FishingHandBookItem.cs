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
	// Token: 0x02005591 RID: 21905
	public class FishingHandBookItem : GridProxyAbstract<int>
	{
		// Token: 0x06036484 RID: 222340 RVA: 0x00F237C0 File Offset: 0x00F219C0
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

		// Token: 0x06036485 RID: 222341 RVA: 0x00F238EC File Offset: 0x00F21AEC
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

		// Token: 0x06036486 RID: 222342 RVA: 0x00F23A74 File Offset: 0x00F21C74
		public override void Clear()
		{
			EventSystem.Instance.Emit<string>(EEventName.FinishGuideStepByEvent, "FishingHandBookItem");
		}

		// Token: 0x06036487 RID: 222343 RVA: 0x00F23A8B File Offset: 0x00F21C8B
		private void OnClickToggle(EToggleState toggleState)
		{
			Action<int, UUIExtendToggle, int> onClickToggleCallBack = this.OnClickToggleCallBack;
			if (onClickToggleCallBack == null)
			{
				return;
			}
			onClickToggleCallBack(this.ItemId, base.GetExtendToggle(0), base.GridIndex);
		}

		// Token: 0x06036488 RID: 222344 RVA: 0x00F23AB0 File Offset: 0x00F21CB0
		public override void OnSelected(bool fireEvent)
		{
			base.GetItem(3).SetUIActive(false);
			if (!fireEvent)
			{
				return;
			}
			base.GetExtendToggle(0).SetToggleState(EToggleState.ETT_Checked, true, false, false);
		}

		// Token: 0x06036489 RID: 222345 RVA: 0x00F23AD4 File Offset: 0x00F21CD4
		private void SetTextureMaterialActive(bool value)
		{
			if (value)
			{
				base.GetTexture(4).SetCustomMaterialScalarParameter(FishingDefine.materialProgressName, 1f);
				return;
			}
			base.GetTexture(4).SetCustomMaterialScalarParameter(FishingDefine.materialProgressName, 0f);
		}

		// Token: 0x0401CA6E RID: 117358
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Action<int, UUIExtendToggle, int> OnClickToggleCallBack;

		// Token: 0x0401CA6F RID: 117359
		private int ItemId;

		// Token: 0x0200B205 RID: 45573
		private class EComponentDefine
		{
			// Token: 0x0403705E RID: 225374
			public const int Toggle = 0;

			// Token: 0x0403705F RID: 225375
			public const int ItemSmallItem = 1;

			// Token: 0x04037060 RID: 225376
			public const int NameText = 2;

			// Token: 0x04037061 RID: 225377
			public const int NewItem = 3;

			// Token: 0x04037062 RID: 225378
			public const int FishItemTexture = 4;

			// Token: 0x04037063 RID: 225379
			public const int QualitySprite = 5;
		}
	}
}
