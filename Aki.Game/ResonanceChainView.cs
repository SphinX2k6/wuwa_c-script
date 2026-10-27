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

// Token: 0x0200289A RID: 10394
[NullableContext(2)]
[Nullable(0)]
public class ResonanceChainView : UiTabViewBase
{
	// Token: 0x06015724 RID: 87844 RVA: 0x0056908C File Offset: 0x0056728C
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

	// Token: 0x06015725 RID: 87845 RVA: 0x00569128 File Offset: 0x00567328
	protected override UniTask OnBeforeStartAsync()
	{
		ResonanceChainView.<OnBeforeStartAsync>d__10 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<ResonanceChainView.<OnBeforeStartAsync>d__10>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06015726 RID: 87846 RVA: 0x0056916C File Offset: 0x0056736C
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

	// Token: 0x06015727 RID: 87847 RVA: 0x005691D8 File Offset: 0x005673D8
	private void CreateSceneEffect()
	{
		FTransformDouble? kuroCurrentUiSceneTransform = RenderModuleController.Instance.GetKuroCurrentUiSceneTransform();
		string effectPath = EffectUtil.GetEffectPath("DA_Fx_Group_UIScene_SystemNew_Line");
		this.SceneEffectHandle = new int?(EffectSystem.Instance.SpawnEffect(GlobalData.World, kuroCurrentUiSceneTransform, effectPath, "[ResonanceChainView.CreateSceneEffect]", null, EEffectType.UiScene3D, null, null, null, false, false));
	}

	// Token: 0x06015728 RID: 87848 RVA: 0x00569224 File Offset: 0x00567424
	private void SetEffectHidden(bool bHidden)
	{
		if (this.SceneEffectHandle == null)
		{
			return;
		}
		EffectSystem.Instance.SetEffectHidden(this.SceneEffectHandle.Value, bHidden, "[ResonanceChainView.SetEffectHidden]", false);
	}

	// Token: 0x06015729 RID: 87849 RVA: 0x00569250 File Offset: 0x00567450
	private void DestroySceneEffect()
	{
		if (this.SceneEffectHandle == null)
		{
			return;
		}
		EffectSystem.Instance.StopEffectById(this.SceneEffectHandle.Value, "[ResonanceChainView.DestroySceneEffect]", true, null);
		this.SceneEffectHandle = null;
	}

	// Token: 0x0601572A RID: 87850 RVA: 0x0056929C File Offset: 0x0056749C
	private void ResetStates()
	{
		this.CurSelectId = -1;
	}

	// Token: 0x0601572B RID: 87851 RVA: 0x005692A8 File Offset: 0x005674A8
	protected override void AddEventListener()
	{
		EventSystem.Instance.Add(EEventName.UpdateRoleResonanceDetailView, new Action(this.OnResonanceUnlockSuccess));
		EventSystem.Instance.Add<int>(EEventName.RoleSystemChangeRole, new Action<int>(this.OnRoleChange));
		EventSystem.Instance.Add(EEventName.OnRoleInternalViewQuit, new Action(this.OnRoleInternalViewQuit));
	}

	// Token: 0x0601572C RID: 87852 RVA: 0x0056930C File Offset: 0x0056750C
	protected override void RemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.UpdateRoleResonanceDetailView, new Action(this.OnResonanceUnlockSuccess));
		EventSystem.Instance.Remove(EEventName.RoleSystemChangeRole, new Action<int>(this.OnRoleChange));
		EventSystem.Instance.Remove(EEventName.OnRoleInternalViewQuit, new Action(this.OnRoleInternalViewQuit));
	}

	// Token: 0x0601572D RID: 87853 RVA: 0x00569370 File Offset: 0x00567570
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

	// Token: 0x0601572E RID: 87854 RVA: 0x005693D4 File Offset: 0x005675D4
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

	// Token: 0x0601572F RID: 87855 RVA: 0x00569478 File Offset: 0x00567678
	private void OnRoleChange(int roleId)
	{
		this.PlayMontageStart();
		this.SequencePlayer.PlayOrReplaySequenceByName("Start", false, null);
		this.Refresh();
		this.ShowItems();
	}

	// Token: 0x06015730 RID: 87856 RVA: 0x005694B4 File Offset: 0x005676B4
	private void OnRoleInternalViewQuit()
	{
		this.HideInfoItem();
		this.SequencePlayer.PlayOrReplaySequenceByName("CamLef", false, null);
		this.CancelToggleSelect();
	}

	// Token: 0x06015731 RID: 87857 RVA: 0x005694E7 File Offset: 0x005676E7
	protected override void OnBeforeShow()
	{
		this.PlayMontageStart();
		this.Refresh();
		this.ShowItems();
		this.SetEffectHidden(false);
		EventSystem.Instance.Emit<string>(EEventName.FinishGuideStepByEvent, "ResonanceChainGuide");
	}

	// Token: 0x06015732 RID: 87858 RVA: 0x00569517 File Offset: 0x00567717
	protected override void OnBeforeHide()
	{
		this.SetEffectHidden(true);
	}

	// Token: 0x06015733 RID: 87859 RVA: 0x00569520 File Offset: 0x00567720
	public void ShowItems()
	{
		ResonanceChainBaseItem[] showingItemList = this.ShowingItemList;
		for (int i = 0; i < showingItemList.Length; i++)
		{
			showingItemList[i].ShowItem();
		}
	}

	// Token: 0x06015734 RID: 87860 RVA: 0x0056954C File Offset: 0x0056774C
	private void EnterRoleInternalView()
	{
		this.ShowInfoItem();
		this.SequencePlayer.StopSequenceByKey("CamRig", false, false);
		this.SequencePlayer.PlayLevelSequenceByName("CamRig", false, null, false);
		EventSystem.Instance.Emit(EEventName.OnRoleInternalViewEnter);
	}

	// Token: 0x06015735 RID: 87861 RVA: 0x0056959C File Offset: 0x0056779C
	protected void PlayMontageStart()
	{
		RoleController.Instance.PlayRoleMontage(EPerformanceRoleState.Resonance, false, false, false);
	}

	// Token: 0x06015736 RID: 87862 RVA: 0x005695AC File Offset: 0x005677AC
	private void ShowInfoItem()
	{
		ResonanceChainInfoItem infoItem = this.InfoItem;
		if (infoItem != null)
		{
			infoItem.SetUiActive(true);
		}
		this.InfoItem.ShowItem();
	}

	// Token: 0x06015737 RID: 87863 RVA: 0x005695CB File Offset: 0x005677CB
	private void HideInfoItem()
	{
		ResonanceChainInfoItem infoItem = this.InfoItem;
		if (infoItem != null)
		{
			infoItem.SetUiActive(false);
		}
		this.InfoItem.HideItem();
	}

	// Token: 0x06015738 RID: 87864 RVA: 0x005695EC File Offset: 0x005677EC
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

	// Token: 0x06015739 RID: 87865 RVA: 0x00569638 File Offset: 0x00567838
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

	// Token: 0x0601573A RID: 87866 RVA: 0x00569680 File Offset: 0x00567880
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

	// Token: 0x0601573B RID: 87867 RVA: 0x00569784 File Offset: 0x00567984
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

	// Token: 0x0601573C RID: 87868 RVA: 0x00569800 File Offset: 0x00567A00
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

	// Token: 0x0601573D RID: 87869 RVA: 0x00569840 File Offset: 0x00567A40
	private void RefreshInfoItem()
	{
		RoleDataBase curSelectRoleData = this.RoleViewAgent.GetCurSelectRoleData();
		this.InfoItem.Update(curSelectRoleData.GetDataId(), this.CurSelectId, curSelectRoleData.IsTrialRole());
	}

	// Token: 0x0601573E RID: 87870 RVA: 0x00569876 File Offset: 0x00567A76
	protected override void OnBeforeDestroy()
	{
		this.DestroySceneEffect();
		this.ShowingItemList = null;
		this.ItemParentList = null;
		this.SequencePlayer = null;
		this.ResetStates();
	}

	// Token: 0x0601573F RID: 87871 RVA: 0x0056989C File Offset: 0x00567A9C
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

	// Token: 0x06015740 RID: 87872 RVA: 0x0056991C File Offset: 0x00567B1C
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

	// Token: 0x04009FED RID: 40941
	private const int RESONANCE_ITEM_COUNT = 6;

	// Token: 0x04009FEE RID: 40942
	private RoleViewAgent RoleViewAgent;

	// Token: 0x04009FEF RID: 40943
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private ResonanceChainBaseItem[] ShowingItemList;

	// Token: 0x04009FF0 RID: 40944
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private UUIItem[] ItemParentList;

	// Token: 0x04009FF1 RID: 40945
	private ResonanceChainInfoItem InfoItem;

	// Token: 0x04009FF2 RID: 40946
	private LevelSequencePlayer SequencePlayer;

	// Token: 0x04009FF3 RID: 40947
	private int CurSelectId = -1;

	// Token: 0x04009FF4 RID: 40948
	private int? SceneEffectHandle;

	// Token: 0x02008EA3 RID: 36515
	[NullableContext(0)]
	private enum EResonanceChainViewCom
	{
		// Token: 0x0402E40A RID: 189450
		ResonanceItem1,
		// Token: 0x0402E40B RID: 189451
		ResonanceItem2,
		// Token: 0x0402E40C RID: 189452
		ResonanceItem3,
		// Token: 0x0402E40D RID: 189453
		ResonanceItem4,
		// Token: 0x0402E40E RID: 189454
		ResonanceItem5,
		// Token: 0x0402E40F RID: 189455
		ResonanceItem6
	}
}
