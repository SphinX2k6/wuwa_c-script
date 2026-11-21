using System;
using System.Collections.Generic;
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
	// Token: 0x02004BF4 RID: 19444
	[NullableContext(1)]
	[Nullable(0)]
	public class BossPilingSettleView : UiViewBase
	{
		// Token: 0x06030854 RID: 198740 RVA: 0x00D847BA File Offset: 0x00D829BA
		public BossPilingSettleView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x06030855 RID: 198741 RVA: 0x00D847E4 File Offset: 0x00D829E4
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

		// Token: 0x06030856 RID: 198742 RVA: 0x00D848F4 File Offset: 0x00D82AF4
		protected override UniTask OnBeforeStartAsync()
		{
			BossPilingSettleView.<OnBeforeStartAsync>d__15 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<BossPilingSettleView.<OnBeforeStartAsync>d__15>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06030857 RID: 198743 RVA: 0x00D84937 File Offset: 0x00D82B37
		protected override void OnBeforeShow()
		{
			this.RefreshTitle();
			this.CurTeam = BossPilingController.Instance.CurTeamRole;
			this.CurTag = BossPilingController.Instance.CurTeamTag;
		}

		// Token: 0x06030858 RID: 198744 RVA: 0x00D84960 File Offset: 0x00D82B60
		private UniTask NewStateToggle()
		{
			BossPilingSettleView.<NewStateToggle>d__17 <NewStateToggle>d__;
			<NewStateToggle>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<NewStateToggle>d__.<>4__this = this;
			<NewStateToggle>d__.<>1__state = -1;
			<NewStateToggle>d__.<>t__builder.Start<BossPilingSettleView.<NewStateToggle>d__17>(ref <NewStateToggle>d__);
			return <NewStateToggle>d__.<>t__builder.Task;
		}

		// Token: 0x06030859 RID: 198745 RVA: 0x00D849A4 File Offset: 0x00D82BA4
		private UniTask InitButtonAsync()
		{
			BossPilingSettleView.<InitButtonAsync>d__18 <InitButtonAsync>d__;
			<InitButtonAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitButtonAsync>d__.<>4__this = this;
			<InitButtonAsync>d__.<>1__state = -1;
			<InitButtonAsync>d__.<>t__builder.Start<BossPilingSettleView.<InitButtonAsync>d__18>(ref <InitButtonAsync>d__);
			return <InitButtonAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603085A RID: 198746 RVA: 0x00D849E8 File Offset: 0x00D82BE8
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

		// Token: 0x0603085B RID: 198747 RVA: 0x00D84A3C File Offset: 0x00D82C3C
		private UniTask InitLevelPanelAsync()
		{
			BossPilingSettleView.<InitLevelPanelAsync>d__20 <InitLevelPanelAsync>d__;
			<InitLevelPanelAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitLevelPanelAsync>d__.<>4__this = this;
			<InitLevelPanelAsync>d__.<>1__state = -1;
			<InitLevelPanelAsync>d__.<>t__builder.Start<BossPilingSettleView.<InitLevelPanelAsync>d__20>(ref <InitLevelPanelAsync>d__);
			return <InitLevelPanelAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603085C RID: 198748 RVA: 0x00D84A80 File Offset: 0x00D82C80
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

		// Token: 0x0603085D RID: 198749 RVA: 0x00D84B70 File Offset: 0x00D82D70
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
					MultiTeamRoleGridData item = MultiTeamRoleGridData.Phrase(roleInstance, false, Array.IndexOf<int>(value2.RecommendFormation(), roleInstance.GetRoleId()) >= 0, false, false, null, false, false, false);
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
						list3.Add(MultiTeamRoleGridData.Phrase(roleDataById, false, false, false, false, null, false, false, false));
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
				BossPilingController.Instance.RequestChallenge(this.LevelId, new List<int>(idList), new List<int>(tagConfigId), false);
			}, null, list4, null, "", "");
			multiTeamRoleSelectData.IfCanSelectCheck = new Func<int, int[], bool>(this.IfCanSelectCheck);
			MultiTeamTagDataItem multiTeamTagData = MultiTeamTagDataItem.Phrase(this.CurTag.ToArray(), ESkillBranchCacheType.BossPiling);
			multiTeamRoleSelectData.SetMultiTeamTagData(multiTeamTagData);
			return multiTeamRoleSelectData;
		}

		// Token: 0x0603085E RID: 198750 RVA: 0x00D84DF0 File Offset: 0x00D82FF0
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

		// Token: 0x0603085F RID: 198751 RVA: 0x00D84E99 File Offset: 0x00D83099
		private void OnClickedLeft()
		{
			if (!this.IsSuccess)
			{
				UiManager.Instance.OpenView(EUiViewName.BossPilingMainView, null, null);
				return;
			}
			InstanceDungeonController.Instance.SingleInstReChallengeRequest(false);
		}

		// Token: 0x06030860 RID: 198752 RVA: 0x00D84EC4 File Offset: 0x00D830C4
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

		// Token: 0x04019AF0 RID: 105200
		private const string SUCCESS_OUTLINE_COLOR = "C48B29FF";

		// Token: 0x04019AF1 RID: 105201
		private const string SUCCESS_TEXT_COLOR = "f2efd5";

		// Token: 0x04019AF2 RID: 105202
		private const string FAIL_OUTLINE_COLOR = "B33100FF";

		// Token: 0x04019AF3 RID: 105203
		private const string FAIL_TEXT_COLOR = "F08086FF";

		// Token: 0x04019AF4 RID: 105204
		protected Dictionary<int, BossPilingSettleButton> ButtonMap = new Dictionary<int, BossPilingSettleButton>();

		// Token: 0x04019AF5 RID: 105205
		[Nullable(2)]
		protected BossPilingSettlePanel LevelPanel;

		// Token: 0x04019AF6 RID: 105206
		protected bool IsSuccess;

		// Token: 0x04019AF7 RID: 105207
		protected int LevelId;

		// Token: 0x04019AF8 RID: 105208
		protected List<int> CurTeam = new List<int>();

		// Token: 0x04019AF9 RID: 105209
		protected List<int> CurTag = new List<int>();

		// Token: 0x04019AFA RID: 105210
		private RewardExploreToggle RewardExploreToggle;

		// Token: 0x0200A800 RID: 43008
		[NullableContext(0)]
		private enum EButtons
		{
			// Token: 0x04033E3E RID: 212542
			LeftButton,
			// Token: 0x04033E3F RID: 212543
			RightButton
		}

		// Token: 0x0200A801 RID: 43009
		[NullableContext(0)]
		private enum EDefine
		{
			// Token: 0x04033E41 RID: 212545
			TitleItem,
			// Token: 0x04033E42 RID: 212546
			TitleText,
			// Token: 0x04033E43 RID: 212547
			TitleTexture,
			// Token: 0x04033E44 RID: 212548
			ButtonHorizontalItem = 4,
			// Token: 0x04033E45 RID: 212549
			ButtonItem,
			// Token: 0x04033E46 RID: 212550
			ToggleItem,
			// Token: 0x04033E47 RID: 212551
			ContentItem = 20
		}
	}
}
