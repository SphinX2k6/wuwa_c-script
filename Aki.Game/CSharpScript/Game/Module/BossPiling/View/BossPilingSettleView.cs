using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.InstanceDungeon;
using CSharpScript.Game.Module.ItemReward;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.BossPiling.View
{
	// Token: 0x02005C14 RID: 23572
	[NullableContext(1)]
	[Nullable(0)]
	public class BossPilingSettleView : UiViewBase
	{
		// Token: 0x0603B909 RID: 243977 RVA: 0x00E34472 File Offset: 0x00E32672
		public BossPilingSettleView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x0603B90A RID: 243978 RVA: 0x00E3449C File Offset: 0x00E3269C
		protected unsafe override void OnRegisterComponent()
		{
			int num = 7;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(20, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603B90B RID: 243979 RVA: 0x00E345AC File Offset: 0x00E327AC
		protected override UniTask OnBeforeStartAsync()
		{
			BossPilingSettleView.<OnBeforeStartAsync>d__15 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<BossPilingSettleView.<OnBeforeStartAsync>d__15>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603B90C RID: 243980 RVA: 0x00E345EF File Offset: 0x00E327EF
		protected override void OnBeforeShow()
		{
			this.RefreshTitle();
			this.CurTeam = BossPilingController.Instance.CurTeamRole;
			this.CurTag = BossPilingController.Instance.CurTeamTag;
		}

		// Token: 0x0603B90D RID: 243981 RVA: 0x00E34618 File Offset: 0x00E32818
		private UniTask NewStateToggle()
		{
			BossPilingSettleView.<NewStateToggle>d__17 <NewStateToggle>d__;
			<NewStateToggle>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<NewStateToggle>d__.<>4__this = this;
			<NewStateToggle>d__.<>1__state = -1;
			<NewStateToggle>d__.<>t__builder.Start<BossPilingSettleView.<NewStateToggle>d__17>(ref <NewStateToggle>d__);
			return <NewStateToggle>d__.<>t__builder.Task;
		}

		// Token: 0x0603B90E RID: 243982 RVA: 0x00E3465C File Offset: 0x00E3285C
		private UniTask InitButtonAsync()
		{
			BossPilingSettleView.<InitButtonAsync>d__18 <InitButtonAsync>d__;
			<InitButtonAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitButtonAsync>d__.<>4__this = this;
			<InitButtonAsync>d__.<>1__state = -1;
			<InitButtonAsync>d__.<>t__builder.Start<BossPilingSettleView.<InitButtonAsync>d__18>(ref <InitButtonAsync>d__);
			return <InitButtonAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603B90F RID: 243983 RVA: 0x00E346A0 File Offset: 0x00E328A0
		private UniTask CreateButton(int buttonIndex, Action clickFunction)
		{
			BossPilingSettleView.<CreateButton>d__19 <CreateButton>d__;
			<CreateButton>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateButton>d__.<>4__this = this;
			<CreateButton>d__.buttonIndex = buttonIndex;
			<CreateButton>d__.clickFunction = clickFunction;
			<CreateButton>d__.<>1__state = -1;
			<CreateButton>d__.<>t__builder.Start<BossPilingSettleView.<CreateButton>d__19>(ref <CreateButton>d__);
			return <CreateButton>d__.<>t__builder.Task;
		}

		// Token: 0x0603B910 RID: 243984 RVA: 0x00E346F4 File Offset: 0x00E328F4
		private UniTask InitLevelPanelAsync()
		{
			BossPilingSettleView.<InitLevelPanelAsync>d__20 <InitLevelPanelAsync>d__;
			<InitLevelPanelAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitLevelPanelAsync>d__.<>4__this = this;
			<InitLevelPanelAsync>d__.<>1__state = -1;
			<InitLevelPanelAsync>d__.<>t__builder.Start<BossPilingSettleView.<InitLevelPanelAsync>d__20>(ref <InitLevelPanelAsync>d__);
			return <InitLevelPanelAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603B911 RID: 243985 RVA: 0x00E34738 File Offset: 0x00E32938
		private void RefreshTitle()
		{
			UUIText text = base.GetText(1);
			UUIEffectOutline uuieffectOutline = text.GetOwner().GetComponentByClass(UUIEffectOutline.StaticClass()) as UUIEffectOutline;
			string hexStr = this.IsSuccess ? "C48B29FF" : "B33100FF";
			string key = this.IsSuccess ? "BossPilingActivity_Dungeon13" : "BossPilingActivity_Dungeon09";
			string hexStr2 = this.IsSuccess ? "8C754D7F" : "6e363f";
			string hexStr3 = this.IsSuccess ? "f2efd5" : "F08086FF";
			string sequenceName = this.IsSuccess ? "Success" : "Fail";
			text.SetColor(FColor.FromHex(hexStr));
			text.ShowTextNew(key);
			text.outlineColor = FColor.FromHex(hexStr);
			base.GetTexture(2).SetColor(FColor.FromHex(hexStr2));
			uuieffectOutline.SetOutlineColor(FColor.FromHex(hexStr));
			text.SetColor(FColor.FromHex(hexStr3));
			base.PlaySequence(sequenceName, null, false);
		}

		// Token: 0x0603B912 RID: 243986 RVA: 0x00E34828 File Offset: 0x00E32A28
		private MultiTeamRoleSelectData GetSelectViewData()
		{
			RoleInstance[] roleList = RoleModel.Instance.GetRoleList();
			List<MultiTeamRoleGridData> list = new List<MultiTeamRoleGridData>();
			BossPilingLevels value = BossPilingConfig.Instance.GetLevelInfo(this.LevelId).Value;
			int fightFormationId = InstanceDungeonConfig.Instance.GetConfig(value.InstIds()[0]).Value.FightFormationId;
			FightFormation value2 = FormationConfig.Instance.GetFightFormationConfig(fightFormationId).Value;
			foreach (RoleInstance roleInstance in roleList)
			{
				if (roleInstance.GetRoleId() != 0)
				{
					MultiTeamRoleGridData item = MultiTeamRoleGridData.Phrase(roleInstance, false, value2.RecommendFormation().Contains(roleInstance.GetRoleId()), false, false);
					list.Add(item);
				}
			}
			EPlayerGender playerGender = PlayerInfoModel.Instance.GetPlayerGender();
			IEnumerable<MainRoleConfig> mainRoleByGender = RoleConfig.Instance.GetMainRoleByGender((playerGender == EPlayerGender.Male) ? LoginDefine.ELoginSex.Boy : LoginDefine.ELoginSex.Girl);
			List<int> list2 = new List<int>();
			foreach (MainRoleConfig mainRoleConfig in mainRoleByGender)
			{
				list2.Add(mainRoleConfig.Id);
			}
			List<MultiTeamRoleGridData> list3 = new List<MultiTeamRoleGridData>();
			foreach (int id in value2.TrialRoleIter())
			{
				TrialRoleInfo value3 = RoleConfig.Instance.GetTrialRoleConfigByGroupId(id).Value;
				if (!RoleModel.Instance.IsMainRole(value3.ParentId) || list2.Contains(value3.ParentId))
				{
					RoleDataBase roleDataById = RoleModel.Instance.GetRoleDataById(value3.Id, true);
					if (roleDataById != null)
					{
						list3.Add(MultiTeamRoleGridData.Phrase(roleDataById, false, false, false, false));
					}
				}
			}
			MultiTeamRoleData item2 = MultiTeamRoleData.Phrase("BossRushNormalRole", list);
			List<MultiTeamRoleData> list4 = new List<MultiTeamRoleData>();
			if (list3.Count > 0)
			{
				MultiTeamRoleData item3 = MultiTeamRoleData.Phrase("BossRushTrailRole", list3);
				list4.Add(item3);
			}
			list4.Add(item2);
			MultiTeamRoleSelectData multiTeamRoleSelectData = MultiTeamRoleSelectData.Phrase(new EFilterSortGroupId?(EFilterSortGroupId.EditFormation), 3, this.CurTeam.ToArray(), null, null, delegate(int[] idList, int[] tagConfigId)
			{
				for (int j = 0; j < idList.Length; j++)
				{
					int value4 = idList[j];
					this.CurTeam[j] = value4;
					this.CurTag[j] = tagConfigId[j];
				}
				BossPilingController.Instance.RequestChallenge(this.LevelId, idList.ToList<int>(), tagConfigId.ToList<int>(), false);
			}, null, list4, null, "", "");
			multiTeamRoleSelectData.IfCanSelectCheck = new Func<int, int[], bool>(this.IfCanSelectCheck);
			MultiTeamTagDataItem multiTeamTagData = MultiTeamTagDataItem.Phrase(this.CurTag.ToArray(), ESkillBranchCacheType.BossPiling);
			multiTeamRoleSelectData.SetMultiTeamTagData(multiTeamTagData);
			return multiTeamRoleSelectData;
		}

		// Token: 0x0603B913 RID: 243987 RVA: 0x00E34A98 File Offset: 0x00E32C98
		private bool IfCanSelectCheck(int roleConfigId, int[] selectedRoleList)
		{
			RoleConfig instance = RoleConfig.Instance;
			int? num = (instance != null) ? new int?(instance.GetBaseRoleId(roleConfigId)) : null;
			foreach (int num2 in selectedRoleList)
			{
				if (num2 != 0)
				{
					RoleConfig instance2 = RoleConfig.Instance;
					int? num3 = (instance2 != null) ? new int?(instance2.GetBaseRoleId(num2)) : null;
					int? num4 = num;
					if ((num3.GetValueOrDefault() == num4.GetValueOrDefault() & num3 != null == (num4 != null)) && roleConfigId != num2)
					{
						ScrollingTipsController.Instance.ShowTipsByTextId("BossRushSameFormation", Array.Empty<object>());
						return false;
					}
				}
			}
			return true;
		}

		// Token: 0x0603B914 RID: 243988 RVA: 0x00E34B41 File Offset: 0x00E32D41
		private void OnClickedLeft()
		{
			if (!this.IsSuccess)
			{
				UiManager.Instance.OpenView(EUiViewName.BossPilingMainView, null, null);
				return;
			}
			InstanceDungeonController.Instance.SingleInstReChallengeRequest();
		}

		// Token: 0x0603B915 RID: 243989 RVA: 0x00E34B68 File Offset: 0x00E32D68
		private void OnClickedRight()
		{
			if (this.IsSuccess)
			{
				UiManager.Instance.OpenView(EUiViewName.BossPilingMainView, null, null);
				return;
			}
			EToggleState? toggleState = this.RewardExploreToggle.GetToggleState();
			EToggleState etoggleState = EToggleState.ETT_Checked;
			if (toggleState.GetValueOrDefault() == etoggleState & toggleState != null)
			{
				UiManager.Instance.OpenView(EUiViewName.MultiTeamRoleSelectView, this.GetSelectViewData(), null);
				return;
			}
			BossPilingController.Instance.RequestChallenge(this.LevelId, this.CurTeam, this.CurTag, false);
		}

		// Token: 0x0401F03F RID: 127039
		private const string SUCCESS_OUTLINE_COLOR = "C48B29FF";

		// Token: 0x0401F040 RID: 127040
		private const string SUCCESS_TEXT_COLOR = "f2efd5";

		// Token: 0x0401F041 RID: 127041
		private const string FAIL_OUTLINE_COLOR = "B33100FF";

		// Token: 0x0401F042 RID: 127042
		private const string FAIL_TEXT_COLOR = "F08086FF";

		// Token: 0x0401F043 RID: 127043
		protected Dictionary<int, BossPilingSettleButton> ButtonMap = new Dictionary<int, BossPilingSettleButton>();

		// Token: 0x0401F044 RID: 127044
		[Nullable(2)]
		protected BossPilingSettlePanel LevelPanel;

		// Token: 0x0401F045 RID: 127045
		protected bool IsSuccess;

		// Token: 0x0401F046 RID: 127046
		protected int LevelId;

		// Token: 0x0401F047 RID: 127047
		protected List<int> CurTeam = new List<int>();

		// Token: 0x0401F048 RID: 127048
		protected List<int> CurTag = new List<int>();

		// Token: 0x0401F049 RID: 127049
		private RewardExploreToggle RewardExploreToggle;

		// Token: 0x0200BDF8 RID: 48632
		[NullableContext(0)]
		private enum EButtons
		{
			// Token: 0x0403947B RID: 234619
			LeftButton,
			// Token: 0x0403947C RID: 234620
			RightButton
		}

		// Token: 0x0200BDF9 RID: 48633
		[NullableContext(0)]
		private enum EDefine
		{
			// Token: 0x0403947E RID: 234622
			TitleItem,
			// Token: 0x0403947F RID: 234623
			TitleText,
			// Token: 0x04039480 RID: 234624
			TitleTexture,
			// Token: 0x04039481 RID: 234625
			ButtonHorizontalItem = 4,
			// Token: 0x04039482 RID: 234626
			ButtonItem,
			// Token: 0x04039483 RID: 234627
			ToggleItem,
			// Token: 0x04039484 RID: 234628
			ContentItem = 20
		}
	}
}
