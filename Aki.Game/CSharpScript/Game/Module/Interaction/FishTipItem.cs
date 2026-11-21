using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Activity.ActivityContent.Fishing;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Interaction
{
	// Token: 0x0200482B RID: 18475
	public class FishTipItem : UiPanelBase
	{
		// Token: 0x0602E6C6 RID: 190150 RVA: 0x00CF42F8 File Offset: 0x00CF24F8
		protected unsafe override void OnRegisterComponent()
		{
			int num = 4;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0602E6C7 RID: 190151 RVA: 0x00CF43A4 File Offset: 0x00CF25A4
		public void RefreshByFishingPoint(int pbDataId)
		{
			FishingPoint? fishingPointConfigByEntityId = FishingConfig.Instance.GetFishingPointConfigByEntityId(pbDataId);
			if (fishingPointConfigByEntityId == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Interaction;
				ELogAuthor author = ELogAuthor.YSQ;
				string message = "找不到捕捞点配置";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("实体配置Id", pbDataId);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			FishingPointData fishingPointDataByPbEntityId = FishingModel.Instance.GetFishingPointDataByPbEntityId(pbDataId);
			int showItem = fishingPointConfigByEntityId.Value.ShowItem;
			FishingItem? fishingItem;
			string name = (FishingConfig.Instance.GetFishingItemConfig(showItem) != null) ? fishingItem.GetValueOrDefault().Name : null;
			bool showFishIcon = FishingQuestModel.Instance.IsAcceptedEntrustItem(showItem);
			this.RefreshView(name, showFishIcon, fishingPointConfigByEntityId.Value.UnlockTech, (fishingPointDataByPbEntityId != null) ? new int?(fishingPointDataByPbEntityId.CurrentCount) : null, (fishingPointDataByPbEntityId != null) ? new int?(fishingPointDataByPbEntityId.MaxCount) : null);
		}

		// Token: 0x0602E6C8 RID: 190152 RVA: 0x00CF4498 File Offset: 0x00CF2698
		public void RefreshByDynamicFishingPoint(long creatureDataId)
		{
			TempFishingPointData tempFishingPointDataByCreatureDataId = FishingModel.Instance.GetTempFishingPointDataByCreatureDataId(creatureDataId);
			if (tempFishingPointDataByCreatureDataId == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Interaction;
				ELogAuthor author = ELogAuthor.LYY;
				string message = "找不到临时捕捞点配置";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("CreatureDataId", creatureDataId);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			this.RefreshView("Fishing_TemporaryPoint", false, -1, new int?(tempFishingPointDataByCreatureDataId.CurrentCount), new int?(tempFishingPointDataByCreatureDataId.MaxCount));
		}

		// Token: 0x0602E6C9 RID: 190153 RVA: 0x00CF4508 File Offset: 0x00CF2708
		[NullableContext(2)]
		private void RefreshView(string name, bool showFishIcon, int unlockTech, int? currentCount = 0, int? maxCount = 0)
		{
			if (name != null)
			{
				LguiUtil.Instance.SetLocalTextNew(base.GetText(0), name, Array.Empty<object>());
			}
			UUIItem item = base.GetItem(3);
			if (item != null)
			{
				item.SetUIActive(showFishIcon);
			}
			UUIItem item2 = base.GetItem(2);
			UUIText text = base.GetText(1);
			bool flag = true;
			if (unlockTech > 0)
			{
				FishingTech fishingTechById = FishingConfig.Instance.GetFishingTechById(unlockTech);
				flag = FishingModel.Instance.GetFishingTechUnlock(fishingTechById.Id);
			}
			if (flag)
			{
				if (item2 != null)
				{
					item2.SetUIActive(false);
				}
				if (text != null)
				{
					text.SetUIActive(true);
				}
				if (text != null)
				{
					UUIText uuitext = text;
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(24, 2);
					defaultInterpolatedStringHandler.AppendLiteral("<color=#ffe65a>");
					defaultInterpolatedStringHandler.AppendFormatted<int?>(currentCount);
					defaultInterpolatedStringHandler.AppendLiteral("</color>/");
					defaultInterpolatedStringHandler.AppendFormatted<int?>(maxCount);
					uuitext.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
					return;
				}
			}
			else
			{
				if (item2 != null)
				{
					item2.SetUIActive(true);
				}
				if (text != null)
				{
					text.SetUIActive(false);
				}
			}
		}

		// Token: 0x04018B80 RID: 101248
		[Nullable(1)]
		private const string DYNAMIC_FISHING_POINT_NAME = "Fishing_TemporaryPoint";

		// Token: 0x0200A48E RID: 42126
		public enum EChildType
		{
			// Token: 0x04032FD1 RID: 208849
			NameText,
			// Token: 0x04032FD2 RID: 208850
			CountText,
			// Token: 0x04032FD3 RID: 208851
			LockItem,
			// Token: 0x04032FD4 RID: 208852
			FishIcon
		}
	}
}
