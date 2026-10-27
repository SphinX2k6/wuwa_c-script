using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.Activity.ActivityContent.RougeActivity;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Roguelike
{
	// Token: 0x02004E0A RID: 19978
	public class RoguelikeBlackFlowerInstanceItem : UiPanelBase
	{
		// Token: 0x060338B6 RID: 211126 RVA: 0x00C0C1E0 File Offset: 0x00C0A3E0
		protected unsafe override void OnRegisterComponent()
		{
			int num = 3;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIButtonComponent));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(2, new Action(this.OnClickHelp));
			this.BtnBindInfo = list2;
		}

		// Token: 0x060338B7 RID: 211127 RVA: 0x00C0C2A7 File Offset: 0x00C0A4A7
		protected override void OnBeforeShow()
		{
			this.RefreshHandle();
		}

		// Token: 0x060338B8 RID: 211128 RVA: 0x00C0C2B0 File Offset: 0x00C0A4B0
		private void OnClickHelp()
		{
			RogueParam? paramConfigBySeasonId = RoguelikeModel.Instance.GetParamConfigBySeasonId(null);
			if (paramConfigBySeasonId == null)
			{
				return;
			}
			RoguelikeBlackFlowerOpenParam roguelikeBlackFlowerOpenParam = new RoguelikeBlackFlowerOpenParam();
			roguelikeBlackFlowerOpenParam.DropId = paramConfigBySeasonId.Value.BlackFlowerDropId;
			UiManager.Instance.OpenView(EUiViewName.RoguelikeBlackFlowerPreviewView, roguelikeBlackFlowerOpenParam, null);
		}

		// Token: 0x060338B9 RID: 211129 RVA: 0x00C0C308 File Offset: 0x00C0A508
		private void RefreshHandle()
		{
			ActivityRogueData currentActivityData = ActivityRogueController.Instance.GetCurrentActivityData();
			if (currentActivityData == null)
			{
				return;
			}
			int num = currentActivityData.SeasonData.BlackFlowerMaxCount - currentActivityData.SeasonData.BlackFlowerUseCount;
			RogueSeasonData seasonData = currentActivityData.SeasonData;
			int num2 = (seasonData != null) ? seasonData.BlackFlowerMaxCount : 0;
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), "InstanceDungeon_BlackFlowerTitle", Array.Empty<object>());
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), "Rogue_MemoryPlace_Progress", new <>z__ReadOnlyArray<object>(new object[]
			{
				num.ToString(),
				num2.ToString()
			}));
		}

		// Token: 0x0200AF9D RID: 44957
		private class EItemComponentDefine
		{
			// Token: 0x04035518 RID: 218392
			public const int TxtTitle = 0;

			// Token: 0x04035519 RID: 218393
			public const int TxtContent = 1;

			// Token: 0x0403551A RID: 218394
			public const int BtnHelp = 2;
		}
	}
}
