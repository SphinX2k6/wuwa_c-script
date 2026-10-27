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
	// Token: 0x02005C39 RID: 23609
	[NullableContext(1)]
	[Nullable(0)]
	public class FlagChallengePauseView : UiViewBase
	{
		// Token: 0x0603BA6B RID: 244331 RVA: 0x00E3BF41 File Offset: 0x00E3A141
		public FlagChallengePauseView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0603BA6C RID: 244332 RVA: 0x00E3BF4C File Offset: 0x00E3A14C
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

		// Token: 0x0603BA6D RID: 244333 RVA: 0x00E3C0FC File Offset: 0x00E3A2FC
		protected override UniTask OnBeforeStartAsync()
		{
			FlagChallengePauseView.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<FlagChallengePauseView.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603BA6E RID: 244334 RVA: 0x00E3C140 File Offset: 0x00E3A340
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

		// Token: 0x0603BA6F RID: 244335 RVA: 0x00E3C2F0 File Offset: 0x00E3A4F0
		private void OnClickClose()
		{
			base.CloseMe(null);
		}

		// Token: 0x0603BA70 RID: 244336 RVA: 0x00E3C2FC File Offset: 0x00E3A4FC
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

		// Token: 0x0603BA71 RID: 244337 RVA: 0x00E3C378 File Offset: 0x00E3A578
		private void OnClickBuff()
		{
			FlagChallengeController.Instance.OpenFlagChallengeBuffView(FlagChallengeBattleModel.Instance.ActivityId, null);
		}

		// Token: 0x0603BA72 RID: 244338 RVA: 0x00E3C3A4 File Offset: 0x00E3A5A4
		private void OnClickSaveAndLeave()
		{
			ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.FlagChallengeBattleExitConfirm);
			confirmBoxDataNew.FunctionMap.Add(2, delegate
			{
				FlagChallengeBattleController.Instance.LeaveFlagChallengeInstance().Forget();
			});
			ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
		}

		// Token: 0x0603BA73 RID: 244339 RVA: 0x00E3C3F3 File Offset: 0x00E3A5F3
		private FlagChallengePauseInfoItem CreateItem()
		{
			return new FlagChallengePauseInfoItem();
		}

		// Token: 0x0401F0DD RID: 127197
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		protected GenericLayout<FlagChallengePauseInfoItem, FlagChallengePauseInfo> Layout;

		// Token: 0x0401F0DE RID: 127198
		private FlagChallengePauseButton LevelBtn;

		// Token: 0x0401F0DF RID: 127199
		private FlagChallengePauseButton BuffBtn;

		// Token: 0x0401F0E0 RID: 127200
		private FlagChallengePauseButton SaveAndLeaveBtn;

		// Token: 0x0200BE2D RID: 48685
		[NullableContext(0)]
		private enum EComponentType
		{
			// Token: 0x04039593 RID: 234899
			BackBtn,
			// Token: 0x04039594 RID: 234900
			SettingBtn,
			// Token: 0x04039595 RID: 234901
			LevelBaseInfoLayout,
			// Token: 0x04039596 RID: 234902
			BaseInfo,
			// Token: 0x04039597 RID: 234903
			NumTxt,
			// Token: 0x04039598 RID: 234904
			BuffDetailBtn,
			// Token: 0x04039599 RID: 234905
			LevelBtn,
			// Token: 0x0403959A RID: 234906
			BuffBtn,
			// Token: 0x0403959B RID: 234907
			SaveAndLeaveBtn,
			// Token: 0x0403959C RID: 234908
			PanelStar
		}
	}
}
