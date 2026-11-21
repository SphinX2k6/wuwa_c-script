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

// Token: 0x02001C5F RID: 7263
[NullableContext(1)]
[Nullable(0)]
public class RogueBattleTeamEditView : UiTickViewBase
{
	// Token: 0x06012028 RID: 73768 RVA: 0x0054C3BC File Offset: 0x0054A5BC
	public RogueBattleTeamEditView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06012029 RID: 73769 RVA: 0x0054C3D0 File Offset: 0x0054A5D0
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

	// Token: 0x0601202A RID: 73770 RVA: 0x0054C548 File Offset: 0x0054A748
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

	// Token: 0x0601202B RID: 73771 RVA: 0x0054C5A8 File Offset: 0x0054A7A8
	private void OnClickBtnLink()
	{
		if (this.WaitClose)
		{
			return;
		}
		RogueBattleTeamEditData param = new RogueBattleTeamEditData(this.TabComponent.GetSelectedIndex(), new Func<List<int>, UniTask>(this.OnTeamEditConfirm));
		UiManager.Instance.OpenView(EUiViewName.RogueBattleTeamRoleSelectView, param, null);
	}

	// Token: 0x0601202C RID: 73772 RVA: 0x0054C5EC File Offset: 0x0054A7EC
	private void OnClickSlot(int position)
	{
		if (this.WaitClose)
		{
			return;
		}
		RogueBattleTeamEditData param = new RogueBattleTeamEditData(this.TabComponent.GetSelectedIndex(), new Func<List<int>, UniTask>(this.OnTeamEditConfirm));
		UiManager.Instance.OpenView(EUiViewName.RogueBattleTeamRoleSelectView, param, null);
	}

	// Token: 0x0601202D RID: 73773 RVA: 0x0054C630 File Offset: 0x0054A830
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

	// Token: 0x0601202E RID: 73774 RVA: 0x0054C706 File Offset: 0x0054A906
	private bool CheckCanOpenFetter()
	{
		return !this.WaitClose;
	}

	// Token: 0x0601202F RID: 73775 RVA: 0x0054C714 File Offset: 0x0054A914
	private CommonTabData GetCommonData(int index)
	{
		string resourceId = FormationDefine.FormationIndexSprites[index];
		CommonTabData commonTabData = new CommonTabData(UiResourceConfig.Instance.GetResourcePath(resourceId), new CommonTabTitleData("RogueRes_TeamName", Array.Empty<object>()), null);
		commonTabData.SetSmallIcon(UiResourceConfig.Instance.GetResourcePath("SP_TeamTitle"));
		return commonTabData;
	}

	// Token: 0x06012030 RID: 73776 RVA: 0x0054C760 File Offset: 0x0054A960
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

	// Token: 0x06012031 RID: 73777 RVA: 0x0054C7DC File Offset: 0x0054A9DC
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

	// Token: 0x06012032 RID: 73778 RVA: 0x0054C828 File Offset: 0x0054AA28
	protected override UniTask OnBeforeStartAsync()
	{
		RogueBattleTeamEditView.<OnBeforeStartAsync>d__16 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<RogueBattleTeamEditView.<OnBeforeStartAsync>d__16>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06012033 RID: 73779 RVA: 0x0054C86B File Offset: 0x0054AA6B
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

	// Token: 0x06012034 RID: 73780 RVA: 0x0054C8A0 File Offset: 0x0054AAA0
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

	// Token: 0x06012035 RID: 73781 RVA: 0x0054C8F8 File Offset: 0x0054AAF8
	private void RefreshView()
	{
		this.RefreshLinkItem();
		this.RefreshConfirmButton();
		this.RefreshBuffDetailButton();
	}

	// Token: 0x06012036 RID: 73782 RVA: 0x0054C90C File Offset: 0x0054AB0C
	private void RefreshLinkItem()
	{
		RogueBattleLinkItem linkItem = this.LinkItem;
		if (linkItem == null)
		{
			return;
		}
		linkItem.RefreshLinkInfo(this.TabComponent.GetSelectedIndex());
	}

	// Token: 0x06012037 RID: 73783 RVA: 0x0054C92C File Offset: 0x0054AB2C
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

	// Token: 0x06012038 RID: 73784 RVA: 0x0054C9CC File Offset: 0x0054ABCC
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

	// Token: 0x06012039 RID: 73785 RVA: 0x0054CA44 File Offset: 0x0054AC44
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

	// Token: 0x0601203A RID: 73786 RVA: 0x0054CA70 File Offset: 0x0054AC70
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

	// Token: 0x04009D16 RID: 40214
	[Nullable(2)]
	private RogueBattleLinkItem LinkItem;

	// Token: 0x04009D17 RID: 40215
	[Nullable(2)]
	private MapRoguePanelFetter PanelFetter;

	// Token: 0x04009D18 RID: 40216
	private List<RogueBattleTeamEditSlot> RoleSlotList = new List<RogueBattleTeamEditSlot>();

	// Token: 0x04009D19 RID: 40217
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private TabComponentWithCaptionItem<RogueBattleTeamEditTab> TabComponent;

	// Token: 0x04009D1A RID: 40218
	private bool WaitClose;

	// Token: 0x04009D1B RID: 40219
	[Nullable(2)]
	private LevelSequencePlayer ProgressLevelSequencePlayer;

	// Token: 0x02007F5E RID: 32606
	[CompilerGenerated]
	private static class <>O
	{
		// Token: 0x04029381 RID: 168833
		[Nullable(new byte[]
		{
			0,
			2
		})]
		public static Action<ULGUIPointerEventData, int, int, int> <0>__OnFormationRoleViewPointDown;

		// Token: 0x04029382 RID: 168834
		[Nullable(0)]
		public static Action <1>__OnFormationRoleViewStartDrag;

		// Token: 0x04029383 RID: 168835
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public static Action<UUIItem, int, int, int> <2>__OnFormationRoleViewGamePadDown;

		// Token: 0x04029384 RID: 168836
		[Nullable(new byte[]
		{
			0,
			2
		})]
		public static Action<ULGUIPointerEventData> <3>__OnFormationRoleViewMoveDrag;

		// Token: 0x04029385 RID: 168837
		[Nullable(0)]
		public static Action<bool> <4>__OnFormationRoleViewEndDrag;
	}
}
