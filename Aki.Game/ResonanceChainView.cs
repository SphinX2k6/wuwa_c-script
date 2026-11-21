using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using AkiClient.Game.Aki.Character.Role.Common.Data.Enum;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Effect;
using CSharpScript.Game.Render;
using CSharpScript.Game.Ui;
using CSharpScript.Game.Utils;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001E15 RID: 7701
[NullableContext(2)]
[Nullable(0)]
public class ResonanceChainView : UiTabViewBase
{
	// Token: 0x06013124 RID: 78116 RVA: 0x00593ED4 File Offset: 0x005920D4
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUIItem)),
			new ValueTuple<int, Type>(5, typeof(UUIItem))
		};
	}

	// Token: 0x06013125 RID: 78117 RVA: 0x00593F70 File Offset: 0x00592170
	protected override UniTask OnBeforeStartAsync()
	{
		ResonanceChainView.<OnBeforeStartAsync>d__10 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<ResonanceChainView.<OnBeforeStartAsync>d__10>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06013126 RID: 78118 RVA: 0x00593FB4 File Offset: 0x005921B4
	private void InitData()
	{
		this.ItemParentList = new UUIItem[6];
		this.ShowingItemList = new ResonanceChainBaseItem[6];
		int num = 0;
		for (int i = 0; i < 6; i++)
		{
			this.ItemParentList[i] = base.GetItem(num + i);
		}
		this.SequencePlayer = new LevelSequencePlayer(base.GetRootItem());
		this.SequencePlayer.BindSequenceStartEvent(new TSequenceStartEvent(this.OnSequenceStart));
	}

	// Token: 0x06013127 RID: 78119 RVA: 0x00594020 File Offset: 0x00592220
	private void CreateSceneEffect()
	{
		FTransformDouble? kuroCurrentUiSceneTransform = RenderModuleController.Instance.GetKuroCurrentUiSceneTransform();
		string effectPath = EffectUtil.GetEffectPath("DA_Fx_Group_UIScene_SystemNew_Line");
		this.SceneEffectHandle = new int?(EffectSystem.Instance.SpawnEffect(GlobalData.World, kuroCurrentUiSceneTransform, effectPath, "[ResonanceChainView.CreateSceneEffect]", null, EEffectType.UiScene3D, null, null, null, false, false));
	}

	// Token: 0x06013128 RID: 78120 RVA: 0x0059406C File Offset: 0x0059226C
	private void SetEffectHidden(bool bHidden)
	{
		if (this.SceneEffectHandle == null)
		{
			return;
		}
		EffectSystem.Instance.SetEffectHidden(this.SceneEffectHandle.Value, bHidden, "[ResonanceChainView.SetEffectHidden]", false);
	}

	// Token: 0x06013129 RID: 78121 RVA: 0x00594098 File Offset: 0x00592298
	private void DestroySceneEffect()
	{
		if (this.SceneEffectHandle == null)
		{
			return;
		}
		EffectSystem.Instance.StopEffectById(this.SceneEffectHandle.Value, "[ResonanceChainView.DestroySceneEffect]", true, null);
		this.SceneEffectHandle = null;
	}

	// Token: 0x0601312A RID: 78122 RVA: 0x005940E4 File Offset: 0x005922E4
	private void ResetStates()
	{
		this.CurSelectId = -1;
	}

	// Token: 0x0601312B RID: 78123 RVA: 0x005940F0 File Offset: 0x005922F0
	protected override void AddEventListener()
	{
		EventSystem.Instance.Add(EEventName.UpdateRoleResonanceDetailView, new Action(this.OnResonanceUnlockSuccess));
		EventSystem.Instance.Add<int>(EEventName.RoleSystemChangeRole, new Action<int>(this.OnRoleChange));
		EventSystem.Instance.Add(EEventName.OnRoleInternalViewQuit, new Action(this.OnRoleInternalViewQuit));
	}

	// Token: 0x0601312C RID: 78124 RVA: 0x00594154 File Offset: 0x00592354
	protected override void RemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.UpdateRoleResonanceDetailView, new Action(this.OnResonanceUnlockSuccess));
		EventSystem.Instance.Remove(EEventName.RoleSystemChangeRole, new Action<int>(this.OnRoleChange));
		EventSystem.Instance.Remove(EEventName.OnRoleInternalViewQuit, new Action(this.OnRoleInternalViewQuit));
	}

	// Token: 0x0601312D RID: 78125 RVA: 0x005941B8 File Offset: 0x005923B8
	[NullableContext(1)]
	private void OnSequenceStart(string sequenceName)
	{
		if (sequenceName == "CamLef" || sequenceName == "CamRig")
		{
			TsUiSceneRoleActor roleSystemRoleActor = UiSceneManager.Instance.GetRoleSystemRoleActor();
			this.SequencePlayer.SetActorTag(sequenceName, RoleDefine.UI_SCENE_ROLE_TAG, roleSystemRoleActor);
			this.SequencePlayer.SetRelativeTransform(sequenceName, RenderModuleController.Instance.GetKuroCurrentUiSceneTransform().Value);
		}
	}

	// Token: 0x0601312E RID: 78126 RVA: 0x0059421C File Offset: 0x0059241C
	private void OnResonanceUnlockSuccess()
	{
		this.RefreshInfoItem();
		int num = this.RoleViewAgent.GetCurRoleResonanceGroupIndex() - 1;
		ResonanceChainBaseItem resonanceChainBaseItem = this.ShowingItemList[num];
		if (resonanceChainBaseItem == null)
		{
			return;
		}
		int curSelectRoleId = this.RoleViewAgent.GetCurSelectRoleId();
		resonanceChainBaseItem.Update(curSelectRoleId, resonanceChainBaseItem.GetResonanceId(), true);
		resonanceChainBaseItem.SetUiActive(true);
		this.ShowingItemList[num] = resonanceChainBaseItem;
		resonanceChainBaseItem.PlayActivateSequence();
		int num2 = num + 1;
		if (num2 < this.ShowingItemList.Length)
		{
			this.ShowingItemList[num2].RefreshRedDot();
			return;
		}
		ResonanceChainBaseItem[] showingItemList = this.ShowingItemList;
		for (int i = 0; i < showingItemList.Length; i++)
		{
			showingItemList[i].RefreshMaxActivateItem(true);
		}
	}

	// Token: 0x0601312F RID: 78127 RVA: 0x005942C0 File Offset: 0x005924C0
	private void OnRoleChange(int roleId)
	{
		this.PlayMontageStart();
		this.SequencePlayer.PlayOrReplaySequenceByName("Start", false, null);
		this.Refresh();
		this.ShowItems();
	}

	// Token: 0x06013130 RID: 78128 RVA: 0x005942FC File Offset: 0x005924FC
	private void OnRoleInternalViewQuit()
	{
		this.HideInfoItem();
		this.SequencePlayer.PlayOrReplaySequenceByName("CamLef", false, null);
		this.CancelToggleSelect();
	}

	// Token: 0x06013131 RID: 78129 RVA: 0x0059432F File Offset: 0x0059252F
	protected override void OnBeforeShow()
	{
		this.PlayMontageStart();
		this.Refresh();
		this.ShowItems();
		this.SetEffectHidden(false);
		EventSystem.Instance.Emit<string>(EEventName.FinishGuideStepByEvent, "ResonanceChainGuide");
	}

	// Token: 0x06013132 RID: 78130 RVA: 0x0059435F File Offset: 0x0059255F
	protected override void OnBeforeHide()
	{
		this.SetEffectHidden(true);
	}

	// Token: 0x06013133 RID: 78131 RVA: 0x00594368 File Offset: 0x00592568
	public void ShowItems()
	{
		ResonanceChainBaseItem[] showingItemList = this.ShowingItemList;
		for (int i = 0; i < showingItemList.Length; i++)
		{
			showingItemList[i].ShowItem();
		}
	}

	// Token: 0x06013134 RID: 78132 RVA: 0x00594394 File Offset: 0x00592594
	private void EnterRoleInternalView()
	{
		this.ShowInfoItem();
		this.SequencePlayer.StopSequenceByKey("CamRig", false, false);
		this.SequencePlayer.PlayLevelSequenceByName("CamRig", false, null, false);
		EventSystem.Instance.Emit(EEventName.OnRoleInternalViewEnter);
	}

	// Token: 0x06013135 RID: 78133 RVA: 0x005943E4 File Offset: 0x005925E4
	protected void PlayMontageStart()
	{
		RoleController.Instance.PlayRoleMontage(EPerformanceRoleState.Resonance, false, false, false);
	}

	// Token: 0x06013136 RID: 78134 RVA: 0x005943F4 File Offset: 0x005925F4
	private void ShowInfoItem()
	{
		ResonanceChainInfoItem infoItem = this.InfoItem;
		if (infoItem != null)
		{
			infoItem.SetUiActive(true);
		}
		this.InfoItem.ShowItem();
	}

	// Token: 0x06013137 RID: 78135 RVA: 0x00594413 File Offset: 0x00592613
	private void HideInfoItem()
	{
		ResonanceChainInfoItem infoItem = this.InfoItem;
		if (infoItem != null)
		{
			infoItem.SetUiActive(false);
		}
		this.InfoItem.HideItem();
	}

	// Token: 0x06013138 RID: 78136 RVA: 0x00594434 File Offset: 0x00592634
	[return: Nullable(new byte[]
	{
		0,
		1
	})]
	private UniTask<ResonanceChainBaseItem> InitChainItemAsync(int index)
	{
		ResonanceChainView.<InitChainItemAsync>d__29 <InitChainItemAsync>d__;
		<InitChainItemAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder<ResonanceChainBaseItem>.Create();
		<InitChainItemAsync>d__.<>4__this = this;
		<InitChainItemAsync>d__.index = index;
		<InitChainItemAsync>d__.<>1__state = -1;
		<InitChainItemAsync>d__.<>t__builder.Start<ResonanceChainView.<InitChainItemAsync>d__29>(ref <InitChainItemAsync>d__);
		return <InitChainItemAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06013139 RID: 78137 RVA: 0x00594480 File Offset: 0x00592680
	private ResonanceChainBaseItem GetItemByResonanceId(int resonanceId)
	{
		ResonantChain? roleResonanceById = RoleResonanceConfig.Instance.GetRoleResonanceById(resonanceId);
		if (roleResonanceById != null)
		{
			int num = roleResonanceById.Value.GroupIndex - 1;
			if (num >= 0 && num < 6)
			{
				return this.ShowingItemList[num];
			}
		}
		return null;
	}

	// Token: 0x0601313A RID: 78138 RVA: 0x005944C8 File Offset: 0x005926C8
	private void Refresh()
	{
		int curRoleResonanceGroupIndex = this.RoleViewAgent.GetCurRoleResonanceGroupIndex();
		List<ResonantChain> curRoleResonanceConfigList = this.RoleViewAgent.GetCurRoleResonanceConfigList();
		int curSelectRoleId = this.RoleViewAgent.GetCurSelectRoleId();
		foreach (ResonanceChainBaseItem resonanceChainBaseItem in this.ShowingItemList)
		{
			if (resonanceChainBaseItem != null)
			{
				resonanceChainBaseItem.SetUiActive(false);
			}
		}
		if (curRoleResonanceConfigList != null && curRoleResonanceConfigList.Count > 0)
		{
			foreach (ResonantChain resonantChain in curRoleResonanceConfigList)
			{
				int groupIndex = resonantChain.GroupIndex;
				int num = groupIndex - 1;
				ResonanceChainBaseItem resonanceChainBaseItem2 = this.ShowingItemList[num];
				if (num < 6)
				{
					resonanceChainBaseItem2.SetUiActive(true);
					resonanceChainBaseItem2.Update(curSelectRoleId, resonantChain.Id, groupIndex <= curRoleResonanceGroupIndex);
					this.ShowingItemList[num] = resonanceChainBaseItem2;
					resonanceChainBaseItem2.RefreshMaxActivateItem(curRoleResonanceGroupIndex == curRoleResonanceConfigList.Count);
				}
			}
		}
	}

	// Token: 0x0601313B RID: 78139 RVA: 0x005945CC File Offset: 0x005927CC
	private void OnToggleCallBack(int resonanceId)
	{
		int curSelectId = this.CurSelectId;
		ResonanceChainBaseItem resonanceChainBaseItem = null;
		if (curSelectId >= 0)
		{
			resonanceChainBaseItem = this.GetItemByResonanceId(curSelectId);
		}
		ResonanceChainBaseItem resonanceChainBaseItem2 = null;
		if (resonanceId >= 0)
		{
			this.CurSelectId = resonanceId;
			resonanceChainBaseItem2 = this.GetItemByResonanceId(resonanceId);
		}
		if (resonanceChainBaseItem != null)
		{
			resonanceChainBaseItem.SetSelectState(false);
		}
		if (resonanceChainBaseItem != null)
		{
			resonanceChainBaseItem.RefreshToggleState(false);
		}
		if (resonanceChainBaseItem2 != null)
		{
			resonanceChainBaseItem2.SetSelectState(true);
		}
		if (resonanceChainBaseItem2 != null)
		{
			resonanceChainBaseItem2.RefreshToggleState(true);
		}
		if (this.RoleViewAgent.RoleViewState == ERoleViewState.External)
		{
			this.EnterRoleInternalView();
		}
		this.RefreshInfoItem();
	}

	// Token: 0x0601313C RID: 78140 RVA: 0x00594648 File Offset: 0x00592848
	private void CancelToggleSelect()
	{
		int curSelectId = this.CurSelectId;
		ResonanceChainBaseItem resonanceChainBaseItem = null;
		if (curSelectId >= 0)
		{
			resonanceChainBaseItem = this.GetItemByResonanceId(curSelectId);
		}
		this.CurSelectId = -1;
		if (resonanceChainBaseItem != null)
		{
			resonanceChainBaseItem.SetSelectState(false);
		}
		if (resonanceChainBaseItem != null)
		{
			resonanceChainBaseItem.RefreshToggleState(true);
		}
	}

	// Token: 0x0601313D RID: 78141 RVA: 0x00594688 File Offset: 0x00592888
	private void RefreshInfoItem()
	{
		RoleDataBase curSelectRoleData = this.RoleViewAgent.GetCurSelectRoleData();
		this.InfoItem.Update(curSelectRoleData.GetDataId(), this.CurSelectId, curSelectRoleData.IsTrialRole());
	}

	// Token: 0x0601313E RID: 78142 RVA: 0x005946BE File Offset: 0x005928BE
	protected override void OnBeforeDestroy()
	{
		this.DestroySceneEffect();
		this.ShowingItemList = null;
		this.ItemParentList = null;
		this.SequencePlayer = null;
		this.ResetStates();
	}

	// Token: 0x0601313F RID: 78143 RVA: 0x005946E4 File Offset: 0x005928E4
	[NullableContext(1)]
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	public override UUIItem[] GetGuideUiItemAndUiItemForShowEx(string[] configParams)
	{
		if (configParams.Length == 0)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Guide;
			ELogAuthor author = ELogAuthor.TL;
			string message = "共鸣链聚焦引导extraParam字段配置错误";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("configParams", configParams);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return null;
		}
		UUIItem uuiitem = this.FindGuideUiItem(configParams[0]);
		if (uuiitem == null)
		{
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.Guide;
			ELogAuthor author2 = ELogAuthor.TL;
			string message2 = "共鸣链聚焦引导extraParam字段配置错误, 找不到对应的共鸣链界面UI节点";
			ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("configParams", configParams);
			instance2.Warn(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
			return null;
		}
		return new UUIItem[]
		{
			uuiitem,
			uuiitem
		};
	}

	// Token: 0x06013140 RID: 78144 RVA: 0x00594764 File Offset: 0x00592964
	[NullableContext(1)]
	[return: Nullable(2)]
	private UUIItem FindGuideUiItem(string param)
	{
		UUIItem result = null;
		int num;
		if (int.TryParse(param, out num) && num > 0)
		{
			ResonanceChainBaseItem resonanceChainBaseItem = this.ShowingItemList[--num];
			result = ((resonanceChainBaseItem != null) ? resonanceChainBaseItem.GetUiItemForGuide() : null);
		}
		else if (param == "btn")
		{
			ResonanceChainInfoItem infoItem = this.InfoItem;
			result = ((infoItem != null) ? infoItem.GetUiItemForGuide() : null);
		}
		return result;
	}

	// Token: 0x0400A3D6 RID: 41942
	private const int RESONANCE_ITEM_COUNT = 6;

	// Token: 0x0400A3D7 RID: 41943
	private RoleViewAgent RoleViewAgent;

	// Token: 0x0400A3D8 RID: 41944
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private ResonanceChainBaseItem[] ShowingItemList;

	// Token: 0x0400A3D9 RID: 41945
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private UUIItem[] ItemParentList;

	// Token: 0x0400A3DA RID: 41946
	private ResonanceChainInfoItem InfoItem;

	// Token: 0x0400A3DB RID: 41947
	private LevelSequencePlayer SequencePlayer;

	// Token: 0x0400A3DC RID: 41948
	private int CurSelectId = -1;

	// Token: 0x0400A3DD RID: 41949
	private int? SceneEffectHandle;

	// Token: 0x020080EA RID: 33002
	[NullableContext(0)]
	private enum EResonanceChainViewCom
	{
		// Token: 0x04029B07 RID: 170759
		ResonanceItem1,
		// Token: 0x04029B08 RID: 170760
		ResonanceItem2,
		// Token: 0x04029B09 RID: 170761
		ResonanceItem3,
		// Token: 0x04029B0A RID: 170762
		ResonanceItem4,
		// Token: 0x04029B0B RID: 170763
		ResonanceItem5,
		// Token: 0x04029B0C RID: 170764
		ResonanceItem6
	}
}
