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
	// Token: 0x02004C1E RID: 19486
	public class FlagChallengePrompt : GenericPromptFloatTipsBase
	{
		// Token: 0x060309C7 RID: 199111 RVA: 0x00D8C95C File Offset: 0x00D8AB5C
		[NullableContext(1)]
		public FlagChallengePrompt(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x060309C8 RID: 199112 RVA: 0x00D8C968 File Offset: 0x00D8AB68
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

		// Token: 0x060309C9 RID: 199113 RVA: 0x00D8CA78 File Offset: 0x00D8AC78
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

		// Token: 0x060309CA RID: 199114 RVA: 0x00D8CB28 File Offset: 0x00D8AD28
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

		// Token: 0x0200A83A RID: 43066
		private enum EComponent
		{
			// Token: 0x04033F6F RID: 212847
			MainText,
			// Token: 0x04033F70 RID: 212848
			SubText,
			// Token: 0x04033F71 RID: 212849
			Area1,
			// Token: 0x04033F72 RID: 212850
			Area2,
			// Token: 0x04033F73 RID: 212851
			Area3,
			// Token: 0x04033F74 RID: 212852
			Area4,
			// Token: 0x04033F75 RID: 212853
			Area5
		}
	}
}
