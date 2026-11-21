using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.FlagChallenge;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Battle
{
	// Token: 0x02004C19 RID: 19481
	[NullableContext(1)]
	[Nullable(0)]
	public class FlagChallengePauseView : UiViewBase
	{
		// Token: 0x060309B6 RID: 199094 RVA: 0x00D8C2B1 File Offset: 0x00D8A4B1
		public FlagChallengePauseView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x060309B7 RID: 199095 RVA: 0x00D8C2BC File Offset: 0x00D8A4BC
		protected unsafe override void OnRegisterComponent()
		{
			int num = 10;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIHorizontalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnClickClose));
			this.BtnBindInfo = list2;
		}

		// Token: 0x060309B8 RID: 199096 RVA: 0x00D8C46C File Offset: 0x00D8A66C
		protected override UniTask OnBeforeStartAsync()
		{
			FlagChallengePauseView.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<FlagChallengePauseView.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060309B9 RID: 199097 RVA: 0x00D8C4B0 File Offset: 0x00D8A6B0
		protected override void OnStart()
		{
			base.GetButton(1).RootUIComp.Get().SetUIActive(false);
			this.Layout = new GenericLayout<FlagChallengePauseInfoItem, FlagChallengePauseInfo>(base.GetHorizontalLayout(2), new Func<FlagChallengePauseInfoItem>(this.CreateItem), base.GetItem(3).GetOwner() as AUIBaseActor, false, true);
			FlagChallengeBattleModel instance = FlagChallengeBattleModel.Instance;
			List<FlagChallengePauseInfo> list = new List<FlagChallengePauseInfo>();
			int levelId = instance.LevelId;
			FlagChallengeLevel? levelConfig = FlagChallengeConfig.Instance.GetLevelConfig(levelId);
			list.Add(new FlagChallengePauseInfo
			{
				IconPath = "/Game/Aki/UI/UIResources/UiActivity/Atlas/Activity26/TowerDefense/FightResult/SP_ResultDataIcon1.SP_ResultDataIcon1",
				TitleKey = "Morale_32_Pause_CurrentLevel",
				Content = ConfigMultiTextLang.GetLocalTextNew(levelConfig.Value.Name, null),
				ShowLine = true
			});
			int activityId = instance.ActivityId;
			FlagChallengeData flagChallengeData = FlagChallengeModel.Instance.GetFlagChallengeData(activityId);
			FlagChallengeLevelData levelData = flagChallengeData.GetLevelData(levelId);
			int num = 0;
			int num2 = 0;
			foreach (FlagChallengeStrongholdData flagChallengeStrongholdData in flagChallengeData.GetLevelStrongholdDataList(levelData.Id))
			{
				if (flagChallengeStrongholdData.GetStrongholdType() == EFlagChallengeStrongholdType.Boss)
				{
					num++;
					if (flagChallengeStrongholdData.IsPass)
					{
						num2++;
					}
				}
			}
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
			defaultInterpolatedStringHandler.AppendFormatted<int>(num2);
			defaultInterpolatedStringHandler.AppendLiteral("/");
			defaultInterpolatedStringHandler.AppendFormatted<int>(num);
			string content = defaultInterpolatedStringHandler.ToStringAndClear();
			list.Add(new FlagChallengePauseInfo
			{
				IconPath = "/Game/Aki/UI/UIResources/UiActivity/Atlas/Activity26/TowerDefense/FightResult/SP_ResultDataIcon2.SP_ResultDataIcon2",
				TitleKey = "Morale_32_Pause_CurrenBossProgress",
				Content = content,
				ShowLine = false
			});
			this.Layout.RefreshByData(list, null, false);
		}

		// Token: 0x060309BA RID: 199098 RVA: 0x00D8C660 File Offset: 0x00D8A860
		private void OnClickClose()
		{
			base.CloseMe(null);
		}

		// Token: 0x060309BB RID: 199099 RVA: 0x00D8C66C File Offset: 0x00D8A86C
		private void OnClickLevel()
		{
			int activityId = FlagChallengeBattleModel.Instance.ActivityId;
			int levelId = FlagChallengeBattleModel.Instance.LevelId;
			int areaId = FlagChallengeBattleModel.Instance.AreaId;
			FlagChallengeData flagChallengeData = FlagChallengeModel.Instance.GetFlagChallengeData(activityId);
			int levelRecommendStrongholdId = FlagChallengeModel.Instance.GetLevelRecommendStrongholdId(activityId, levelId, new int[]
			{
				areaId
			});
			FlagChallengeStrongholdData strongholdData = flagChallengeData.GetStrongholdData(levelRecommendStrongholdId);
			FlagChallengeController.Instance.OpenFlagChallengeAreaDetailView(activityId, levelId, strongholdData.StrongholdConfig.AreaId, new int?(levelRecommendStrongholdId));
		}

		// Token: 0x060309BC RID: 199100 RVA: 0x00D8C6E8 File Offset: 0x00D8A8E8
		private void OnClickBuff()
		{
			FlagChallengeController.Instance.OpenFlagChallengeBuffView(FlagChallengeBattleModel.Instance.ActivityId, null);
		}

		// Token: 0x060309BD RID: 199101 RVA: 0x00D8C714 File Offset: 0x00D8A914
		private void OnClickSaveAndLeave()
		{
			ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.FlagChallengeBattleExitConfirm);
			confirmBoxDataNew.FunctionMap.Add(2, delegate
			{
				FlagChallengeBattleController.Instance.LeaveFlagChallengeInstance().Forget();
			});
			ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
		}

		// Token: 0x060309BE RID: 199102 RVA: 0x00D8C763 File Offset: 0x00D8A963
		private FlagChallengePauseInfoItem CreateItem()
		{
			return new FlagChallengePauseInfoItem();
		}

		// Token: 0x04019B8E RID: 105358
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		protected GenericLayout<FlagChallengePauseInfoItem, FlagChallengePauseInfo> Layout;

		// Token: 0x04019B8F RID: 105359
		private FlagChallengePauseButton LevelBtn;

		// Token: 0x04019B90 RID: 105360
		private FlagChallengePauseButton BuffBtn;

		// Token: 0x04019B91 RID: 105361
		private FlagChallengePauseButton SaveAndLeaveBtn;

		// Token: 0x0200A835 RID: 43061
		[NullableContext(0)]
		private enum EComponentType
		{
			// Token: 0x04033F56 RID: 212822
			BackBtn,
			// Token: 0x04033F57 RID: 212823
			SettingBtn,
			// Token: 0x04033F58 RID: 212824
			LevelBaseInfoLayout,
			// Token: 0x04033F59 RID: 212825
			BaseInfo,
			// Token: 0x04033F5A RID: 212826
			NumTxt,
			// Token: 0x04033F5B RID: 212827
			BuffDetailBtn,
			// Token: 0x04033F5C RID: 212828
			LevelBtn,
			// Token: 0x04033F5D RID: 212829
			BuffBtn,
			// Token: 0x04033F5E RID: 212830
			SaveAndLeaveBtn,
			// Token: 0x04033F5F RID: 212831
			PanelStar
		}
	}
}
