using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Module.FlagChallenge;
using CSharpScript.Game.Module.GenericPrompt;
using CSharpScript.Game.Module.GenericPrompt.View;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Battle
{
	// Token: 0x02005C3E RID: 23614
	public class FlagChallengePrompt : GenericPromptFloatTipsBase
	{
		// Token: 0x0603BA7C RID: 244348 RVA: 0x00E3C5EC File Offset: 0x00E3A7EC
		[NullableContext(1)]
		public FlagChallengePrompt(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0603BA7D RID: 244349 RVA: 0x00E3C5F8 File Offset: 0x00E3A7F8
		protected unsafe override void OnRegisterComponent()
		{
			int num = 7;
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
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603BA7E RID: 244350 RVA: 0x00E3C708 File Offset: 0x00E3A908
		protected unsafe override void OnStart()
		{
			base.OnStart();
			<>y__InlineArray5<FlagChallengePrompt.EComponent> <>y__InlineArray = default(<>y__InlineArray5<FlagChallengePrompt.EComponent>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<FlagChallengePrompt.EComponent>, FlagChallengePrompt.EComponent>(ref <>y__InlineArray, 0) = FlagChallengePrompt.EComponent.Area1;
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<FlagChallengePrompt.EComponent>, FlagChallengePrompt.EComponent>(ref <>y__InlineArray, 1) = FlagChallengePrompt.EComponent.Area2;
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<FlagChallengePrompt.EComponent>, FlagChallengePrompt.EComponent>(ref <>y__InlineArray, 2) = FlagChallengePrompt.EComponent.Area3;
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<FlagChallengePrompt.EComponent>, FlagChallengePrompt.EComponent>(ref <>y__InlineArray, 3) = FlagChallengePrompt.EComponent.Area4;
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<FlagChallengePrompt.EComponent>, FlagChallengePrompt.EComponent>(ref <>y__InlineArray, 4) = FlagChallengePrompt.EComponent.Area5;
			Span<FlagChallengePrompt.EComponent> span = <PrivateImplementationDetails>.InlineArrayAsSpan<<>y__InlineArray5<FlagChallengePrompt.EComponent>, FlagChallengePrompt.EComponent>(ref <>y__InlineArray, 5);
			for (int i = 0; i < span.Length; i++)
			{
				FlagChallengePrompt.EComponent name = *span[i];
				UUIItem item = base.GetItem((int)name);
				if (item != null)
				{
					item.SetUIActive(false);
				}
			}
			IPromptParamHub promptParamHub = this.OpenParam as IPromptParamHub;
			FlagChallengePromptData flagChallengePromptData = ((promptParamHub != null) ? promptParamHub.ExtraParamObj : null) as FlagChallengePromptData;
			this.ShowArea(flagChallengePromptData.AreaId);
		}

		// Token: 0x0603BA7F RID: 244351 RVA: 0x00E3C7B8 File Offset: 0x00E3A9B8
		private void ShowArea(EMoraleAreaType areaId)
		{
			FlagChallengePrompt.EComponent? ecomponent = null;
			int areaIndex = 0;
			switch (areaId)
			{
			case EMoraleAreaType.MoraleArea1:
				ecomponent = new FlagChallengePrompt.EComponent?(FlagChallengePrompt.EComponent.Area1);
				areaIndex = 1;
				break;
			case EMoraleAreaType.MoraleArea2:
				ecomponent = new FlagChallengePrompt.EComponent?(FlagChallengePrompt.EComponent.Area2);
				areaIndex = 2;
				break;
			case EMoraleAreaType.MoraleArea3:
				ecomponent = new FlagChallengePrompt.EComponent?(FlagChallengePrompt.EComponent.Area3);
				areaIndex = 3;
				break;
			case EMoraleAreaType.MoraleArea4:
				ecomponent = new FlagChallengePrompt.EComponent?(FlagChallengePrompt.EComponent.Area4);
				areaIndex = 4;
				break;
			case EMoraleAreaType.MoraleArea5:
				ecomponent = new FlagChallengePrompt.EComponent?(FlagChallengePrompt.EComponent.Area5);
				areaIndex = 5;
				break;
			}
			UUIItem item = base.GetItem((int)ecomponent.Value);
			if (item != null)
			{
				item.SetUIActive(true);
			}
			FlagChallengeBattleModel instance = FlagChallengeBattleModel.Instance;
			if (areaIndex != 0 && instance.IsInFlagChallengeDungeon)
			{
				FlagChallengeData flagChallengeData = FlagChallengeModel.Instance.GetFlagChallengeData(instance.ActivityId);
				if (flagChallengeData != null)
				{
					List<FlagChallengeAreaData> levelAreaDataList = flagChallengeData.GetLevelAreaDataList(instance.LevelId);
					FlagChallengeAreaData flagChallengeAreaData = (levelAreaDataList != null) ? levelAreaDataList.Find((FlagChallengeAreaData v) => v.Config.UiPos == areaIndex) : null;
					if (flagChallengeAreaData != null)
					{
						instance.AreaId = flagChallengeAreaData.Id;
					}
				}
			}
		}

		// Token: 0x0200BE32 RID: 48690
		private enum EComponent
		{
			// Token: 0x040395AC RID: 234924
			MainText,
			// Token: 0x040395AD RID: 234925
			SubText,
			// Token: 0x040395AE RID: 234926
			Area1,
			// Token: 0x040395AF RID: 234927
			Area2,
			// Token: 0x040395B0 RID: 234928
			Area3,
			// Token: 0x040395B1 RID: 234929
			Area4,
			// Token: 0x040395B2 RID: 234930
			Area5
		}
	}
}
