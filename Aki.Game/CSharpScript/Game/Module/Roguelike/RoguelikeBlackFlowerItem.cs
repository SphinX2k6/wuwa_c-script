using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.Activity.ActivityContent.RougeActivity;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Roguelike
{
	// Token: 0x02004E09 RID: 19977
	public class RoguelikeBlackFlowerItem : UiPanelBase
	{
		// Token: 0x060338B1 RID: 211121 RVA: 0x00C0C010 File Offset: 0x00C0A210
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

		// Token: 0x060338B2 RID: 211122 RVA: 0x00C0C0D7 File Offset: 0x00C0A2D7
		protected override void OnBeforeShow()
		{
			this.RefreshHandle();
		}

		// Token: 0x060338B3 RID: 211123 RVA: 0x00C0C0E0 File Offset: 0x00C0A2E0
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

		// Token: 0x060338B4 RID: 211124 RVA: 0x00C0C138 File Offset: 0x00C0A338
		private void RefreshHandle()
		{
			ActivityRogueData currentActivityData = ActivityRogueController.Instance.GetCurrentActivityData();
			if (currentActivityData == null)
			{
				return;
			}
			int value = currentActivityData.SeasonData.BlackFlowerMaxCount - currentActivityData.SeasonData.BlackFlowerUseCount;
			UUIText text = base.GetText(0);
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 1);
			defaultInterpolatedStringHandler.AppendFormatted<int>(value);
			defaultInterpolatedStringHandler.AppendLiteral("/");
			text.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
			RogueSeasonData seasonData = currentActivityData.SeasonData;
			int value2 = (seasonData != null) ? seasonData.BlackFlowerMaxCount : 0;
			UUIText text2 = base.GetText(1);
			defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(0, 1);
			defaultInterpolatedStringHandler.AppendFormatted<int>(value2);
			text2.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
		}

		// Token: 0x0200AF9C RID: 44956
		private class EComponentDefine
		{
			// Token: 0x04035515 RID: 218389
			public const int TxtRemainNum = 0;

			// Token: 0x04035516 RID: 218390
			public const int TxtMaxNum = 1;

			// Token: 0x04035517 RID: 218391
			public const int BtnHelp = 2;
		}
	}
}
