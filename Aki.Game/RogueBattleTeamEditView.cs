using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.MapRogue;
using CSharpScript.Game.Module.RogueBattle;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Google.Protobuf.Collections;
using UnrealEngine;

// Token: 0x02002774 RID: 10100
[NullableContext(1)]
[Nullable(0)]
public class RogueBattleTeamEditView : UiTickViewBase
{
	// Token: 0x06014B45 RID: 84805 RVA: 0x0053D5AC File Offset: 0x0053B7AC
	public RogueBattleTeamEditView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06014B46 RID: 84806 RVA: 0x0053D5C0 File Offset: 0x0053B7C0
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(4, typeof(UUIText)),
			new ValueTuple<int, Type>(5, typeof(UUIItem)),
			new ValueTuple<int, Type>(6, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(7, typeof(UUIItem)),
			new ValueTuple<int, Type>(8, typeof(UUISprite)),
			new ValueTuple<int, Type>(9, typeof(UUIItem)),
			new ValueTuple<int, Type>(10, typeof(UUIItem)),
			new ValueTuple<int, Type>(11, typeof(UUIItem)),
			new ValueTuple<int, Type>(12, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(3, new Action(this.OnClickBtnConfirm)),
			new ValueTuple<int, Delegate>(6, new Action(this.OnClickBtnBuffDetail))
		};
	}

	// Token: 0x06014B47 RID: 84807 RVA: 0x0053D738 File Offset: 0x0053B938
	private void OnClickBtnBuffDetail()
	{
		MapRogueOp opData = MapRogueModel.Instance.GetOpData((int)this.OpenParam);
		if (opData == null)
		{
			return;
		}
		UiManager instance = UiManager.Instance;
		EUiViewName rogueBattleEnvironmentBuffView = EUiViewName.RogueBattleEnvironmentBuffView;
		RogueGotoLevelPlayOp rogueGotoLevelPlayOp = opData.Data.RogueGotoLevelPlayOp;
		instance.OpenView(rogueBattleEnvironmentBuffView, (rogueGotoLevelPlayOp != null) ? new int?(rogueGotoLevelPlayOp.RoomId) : null, null);
	}

	// Token: 0x06014B48 RID: 84808 RVA: 0x0053D798 File Offset: 0x0053B998
	private void OnClickBtnLink()
	{
		if (this.WaitClose)
		{
			return;
		}
		RogueBattleTeamEditData param = new RogueBattleTeamEditData(this.TabComponent.GetSelectedIndex(), new Func<List<int>, UniTask>(this.OnTeamEditConfirm));
		UiManager.Instance.OpenView(EUiViewName.RogueBattleTeamRoleSelectView, param, null);
	}

	// Token: 0x06014B49 RID: 84809 RVA: 0x0053D7DC File Offset: 0x0053B9DC
	private void OnClickSlot(int position)
	{
		if (this.WaitClose)
		{
			return;
		}
		RogueBattleTeamEditData param = new RogueBattleTeamEditData(this.TabComponent.GetSelectedIndex(), new Func<List<int>, UniTask>(this.OnTeamEditConfirm));
		UiManager.Instance.OpenView(EUiViewName.RogueBattleTeamRoleSelectView, param, null);
	}

	// Token: 0x06014B4A RID: 84810 RVA: 0x0053D820 File Offset: 0x0053BA20
	private void OnClickBtnConfirm()
	{
		RogueBattleTeamEditView.<>c__DisplayClass11_0 CS$<>8__locals1 = new RogueBattleTeamEditView.<>c__DisplayClass11_0();
		CS$<>8__locals1.<>4__this = this;
		CS$<>8__locals1.gameInfo = MapRogueModel.Instance.GameInfo;
		RogueResFormation formationDataByIndex = RogueBattleModel.Instance.GetFormationDataByIndex(this.TabComponent.GetSelectedIndex());
		if (!CS$<>8__locals1.gameInfo.NotTipsInactiveLink && formationDataByIndex.LinkId == 0 && RogueBattleModel.Instance.IsAnyBondLinkCanActivate())
		{
			ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.RogueResInactiveLinkConfirm);
			confirmBoxDataNew.HasToggle = true;
			confirmBoxDataNew.ToggleTextKey = "RogueRes_LvlHint_Desc";
			confirmBoxDataNew.FunctionMap.Add(1, new Action(this.OnClickBtnLink));
			confirmBoxDataNew.FunctionMap.Add(2, new Action(CS$<>8__locals1.<OnClickBtnConfirm>g__Confirm|0));
			confirmBoxDataNew.SetToggleFunction(delegate(bool isSelectOn)
			{
				CS$<>8__locals1.gameInfo.NotTipsInactiveLink = isSelectOn;
			});
			ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
			return;
		}
		CS$<>8__locals1.<OnClickBtnConfirm>g__Confirm|0();
	}

	// Token: 0x06014B4B RID: 84811 RVA: 0x0053D8F6 File Offset: 0x0053BAF6
	private bool CheckCanOpenFetter()
	{
		return !this.WaitClose;
	}

	// Token: 0x06014B4C RID: 84812 RVA: 0x0053D904 File Offset: 0x0053BB04
	private CommonTabData GetCommonData(int index)
	{
		string resourceId = FormationDefine.FormationIndexSprites[index];
		CommonTabData commonTabData = new CommonTabData(UiResourceConfig.Instance.GetResourcePath(resourceId), new CommonTabTitleData("RogueRes_TeamName", Array.Empty<object>()), null);
		commonTabData.SetSmallIcon(UiResourceConfig.Instance.GetResourcePath("SP_TeamTitle"));
		return commonTabData;
	}

	// Token: 0x06014B4D RID: 84813 RVA: 0x0053D950 File Offset: 0x0053BB50
	private void OnClickTab(int index)
	{
		RogueResFormation formationDataByIndex = RogueBattleModel.Instance.GetFormationDataByIndex(index);
		if (formationDataByIndex != null)
		{
			for (int i = 0; i < this.RoleSlotList.Count; i++)
			{
				if (i >= formationDataByIndex.RoleId.Count)
				{
					this.RoleSlotList[i].UpdateRoleInfo(0, index);
				}
				else
				{
					this.RoleSlotList[i].UpdateRoleInfo(formationDataByIndex.RoleId[i], index);
				}
			}
		}
		this.RefreshView();
	}

	// Token: 0x06014B4E RID: 84814 RVA: 0x0053D9CC File Offset: 0x0053BBCC
	private UniTask OnTeamEditConfirm(List<int> roleIdList)
	{
		RogueBattleTeamEditView.<OnTeamEditConfirm>d__15 <OnTeamEditConfirm>d__;
		<OnTeamEditConfirm>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnTeamEditConfirm>d__.<>4__this = this;
		<OnTeamEditConfirm>d__.roleIdList = roleIdList;
		<OnTeamEditConfirm>d__.<>1__state = -1;
		<OnTeamEditConfirm>d__.<>t__builder.Start<RogueBattleTeamEditView.<OnTeamEditConfirm>d__15>(ref <OnTeamEditConfirm>d__);
		return <OnTeamEditConfirm>d__.<>t__builder.Task;
	}

	// Token: 0x06014B4F RID: 84815 RVA: 0x0053DA18 File Offset: 0x0053BC18
	protected override UniTask OnBeforeStartAsync()
	{
		RogueBattleTeamEditView.<OnBeforeStartAsync>d__16 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<RogueBattleTeamEditView.<OnBeforeStartAsync>d__16>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06014B50 RID: 84816 RVA: 0x0053DA5B File Offset: 0x0053BC5B
	protected override void OnBeforeDestroy()
	{
		LevelSequencePlayer progressLevelSequencePlayer = this.ProgressLevelSequencePlayer;
		if (progressLevelSequencePlayer != null)
		{
			progressLevelSequencePlayer.StopPlayingSequence(false, true);
		}
		LevelSequencePlayer progressLevelSequencePlayer2 = this.ProgressLevelSequencePlayer;
		if (progressLevelSequencePlayer2 != null)
		{
			progressLevelSequencePlayer2.Clear();
		}
		this.ProgressLevelSequencePlayer = null;
		FormationViewDragController.ClearDragData(null);
	}

	// Token: 0x06014B51 RID: 84817 RVA: 0x0053DA90 File Offset: 0x0053BC90
	protected override void OnTick(float delta)
	{
		foreach (RogueBattleTeamEditSlot rogueBattleTeamEditSlot in this.RoleSlotList)
		{
			if (rogueBattleTeamEditSlot != null)
			{
				rogueBattleTeamEditSlot.OnTick(delta);
			}
		}
	}

	// Token: 0x06014B52 RID: 84818 RVA: 0x0053DAE8 File Offset: 0x0053BCE8
	private void RefreshView()
	{
		this.RefreshLinkItem();
		this.RefreshConfirmButton();
		this.RefreshBuffDetailButton();
	}

	// Token: 0x06014B53 RID: 84819 RVA: 0x0053DAFC File Offset: 0x0053BCFC
	private void RefreshLinkItem()
	{
		RogueBattleLinkItem linkItem = this.LinkItem;
		if (linkItem == null)
		{
			return;
		}
		linkItem.RefreshLinkInfo(this.TabComponent.GetSelectedIndex());
	}

	// Token: 0x06014B54 RID: 84820 RVA: 0x0053DB1C File Offset: 0x0053BD1C
	private void RefreshBuffDetailButton()
	{
		MapRogueOp opData = MapRogueModel.Instance.GetOpData((int)this.OpenParam);
		if (opData == null)
		{
			return;
		}
		RogueResRoomPool? roomPoolConfig = RogueBattleConfig.Instance.GetRoomPoolConfig(opData.Data.RogueGotoLevelPlayOp.RoomId);
		bool uiactive = roomPoolConfig == null || roomPoolConfig.GetValueOrDefault().EnvDescLength != 0 || roomPoolConfig == null || roomPoolConfig.GetValueOrDefault().MonsterDescLength != 0;
		base.GetButton(6).RootUIComp.Get().SetUIActive(uiactive);
	}

	// Token: 0x06014B55 RID: 84821 RVA: 0x0053DBBC File Offset: 0x0053BDBC
	private void RefreshConfirmButton()
	{
		RogueResFormation formationDataByIndex = RogueBattleModel.Instance.GetFormationDataByIndex(this.TabComponent.GetSelectedIndex());
		bool flag = true;
		if (formationDataByIndex != null)
		{
			using (IEnumerator<int> enumerator = formationDataByIndex.RoleId.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current != 0)
					{
						flag = false;
						break;
					}
				}
			}
		}
		base.GetButton(3).SetSelfInteractive(!flag);
	}

	// Token: 0x06014B56 RID: 84822 RVA: 0x0053DC34 File Offset: 0x0053BE34
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	public override UUIItem[] GetGuideUiItemAndUiItemForShowEx(string[] configParams)
	{
		if (configParams.Length == 0)
		{
			return null;
		}
		if (!(configParams[0] == "FirstFetter"))
		{
			return null;
		}
		MapRoguePanelFetter panelFetter = this.PanelFetter;
		if (panelFetter == null)
		{
			return null;
		}
		return panelFetter.GetGuideUiItemAndUiItemForShowEx(configParams);
	}

	// Token: 0x06014B57 RID: 84823 RVA: 0x0053DC60 File Offset: 0x0053BE60
	private void ExchangeRoleCallBack(int position1, int position2, int roleId1, int roleId2)
	{
		int selectedIndex = this.TabComponent.GetSelectedIndex();
		RogueResFormation formationDataByIndex = RogueBattleModel.Instance.GetFormationDataByIndex(selectedIndex);
		List<int> list = new List<int>();
		RepeatedField<int> roleId3 = formationDataByIndex.RoleId;
		for (int i = 1; i < 4; i++)
		{
			int item = (roleId3.Count >= i) ? roleId3[i - 1] : 0;
			if (i == position1)
			{
				item = roleId1;
			}
			if (i == position2)
			{
				item = roleId2;
			}
			list.Add(item);
		}
		RogueBattleController.Instance.ChangeFormationAllListRequest(selectedIndex, list).Forget();
		this.RoleSlotList[position1 - 1].UpdateRoleInfo(roleId1, selectedIndex);
		this.RoleSlotList[position2 - 1].UpdateRoleInfo(roleId2, selectedIndex);
	}

	// Token: 0x04009BBE RID: 39870
	[Nullable(2)]
	private RogueBattleLinkItem LinkItem;

	// Token: 0x04009BBF RID: 39871
	[Nullable(2)]
	private MapRoguePanelFetter PanelFetter;

	// Token: 0x04009BC0 RID: 39872
	private List<RogueBattleTeamEditSlot> RoleSlotList = new List<RogueBattleTeamEditSlot>();

	// Token: 0x04009BC1 RID: 39873
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private TabComponentWithCaptionItem<RogueBattleTeamEditTab> TabComponent;

	// Token: 0x04009BC2 RID: 39874
	private bool WaitClose;

	// Token: 0x04009BC3 RID: 39875
	[Nullable(2)]
	private LevelSequencePlayer ProgressLevelSequencePlayer;

	// Token: 0x02008DD7 RID: 36311
	[CompilerGenerated]
	private static class <>O
	{
		// Token: 0x0402E06D RID: 188525
		[Nullable(new byte[]
		{
			0,
			2
		})]
		public static Action<ULGUIPointerEventData, int, int, int> <0>__OnFormationRoleViewPointDown;

		// Token: 0x0402E06E RID: 188526
		[Nullable(0)]
		public static Action <1>__OnFormationRoleViewStartDrag;

		// Token: 0x0402E06F RID: 188527
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public static Action<UUIItem, int, int, int> <2>__OnFormationRoleViewGamePadDown;

		// Token: 0x0402E070 RID: 188528
		[Nullable(new byte[]
		{
			0,
			2
		})]
		public static Action<ULGUIPointerEventData> <3>__OnFormationRoleViewMoveDrag;

		// Token: 0x0402E071 RID: 188529
		[Nullable(0)]
		public static Action<bool> <4>__OnFormationRoleViewEndDrag;
	}
}
