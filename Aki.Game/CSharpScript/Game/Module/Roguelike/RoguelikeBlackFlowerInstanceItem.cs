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
	// Token: 0x02003DD3 RID: 15827
	public class RoguelikeBlackFlowerInstanceItem : UiPanelBase
	{
		// Token: 0x06028721 RID: 165665 RVA: 0x00B556EC File Offset: 0x00B538EC
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

		// Token: 0x06028722 RID: 165666 RVA: 0x00B557B3 File Offset: 0x00B539B3
		protected override void OnBeforeShow()
		{
			this.RefreshHandle();
		}

		// Token: 0x06028723 RID: 165667 RVA: 0x00B557BC File Offset: 0x00B539BC
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

		// Token: 0x06028724 RID: 165668 RVA: 0x00B55814 File Offset: 0x00B53A14
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

		// Token: 0x020099D2 RID: 39378
		private class EItemComponentDefine
		{
			// Token: 0x0402FF4B RID: 196427
			public const int TxtTitle = 0;

			// Token: 0x0402FF4C RID: 196428
			public const int TxtContent = 1;

			// Token: 0x0402FF4D RID: 196429
			public const int BtnHelp = 2;
		}
	}
}
