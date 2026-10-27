using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using AkiClient.Game.Aki.Character.Role.Common.Data.Enum;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Effect;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Ui;
using CSharpScript.Game.Utils;
using UnrealEngine;

// Token: 0x02002783 RID: 10115
[NullableContext(1)]
[Nullable(0)]
public class RoleHandBookSelectionView : UiViewBase
{
	// Token: 0x06014C0B RID: 85003 RVA: 0x005406A6 File Offset: 0x0053E8A6
	public RoleHandBookSelectionView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06014C0C RID: 85004 RVA: 0x005406AF File Offset: 0x0053E8AF
	protected override void OnHandleLoadScene()
	{
	}

	// Token: 0x06014C0D RID: 85005 RVA: 0x005406B1 File Offset: 0x0053E8B1
	protected override void OnHandleReleaseScene()
	{
	}

	// Token: 0x06014C0E RID: 85006 RVA: 0x005406B3 File Offset: 0x0053E8B3
	protected override void OnStart()
	{
		this.RoleSelectionComponent = new RoleHandBookSelectionComponent();
		this.LoadFloorEffect();
	}

	// Token: 0x06014C0F RID: 85007 RVA: 0x005406C8 File Offset: 0x0053E8C8
	protected override void OnAfterShow()
	{
		RoleController.Instance.PlayRoleMontage(EPerformanceRoleState.Attribute, false, false, false);
		if (this.RoleSelectionComponent != null)
		{
			int curSelectRoleId = this.RoleSelectionComponent.GetCurSelectRoleId();
			this.RoleSelectionComponent.UpdateComponent(this.RoleList);
			this.RoleSelectionComponent.UpdateRoleHandBookItem(curSelectRoleId);
		}
		RoleController.Instance.ShowUiSceneActorAndShadow(true);
	}

	// Token: 0x06014C10 RID: 85008 RVA: 0x0054071F File Offset: 0x0053E91F
	protected override void OnAddEventListener()
	{
		base.OnAddEventListener();
		EventSystem.Instance.Add<int>(EEventName.RoleHandBookActive, new Action<int>(this.OnRoleHandBookActive));
		EventSystem.Instance.Add<IReadOnlyList<IProto_NormalItem>>(EEventName.OnAddCommonItemList, new Action<IReadOnlyList<IProto_NormalItem>>(this.OnAddCommonItemList));
	}

	// Token: 0x06014C11 RID: 85009 RVA: 0x0054075F File Offset: 0x0053E95F
	protected override void OnRemoveEventListener()
	{
		base.OnRemoveEventListener();
		EventSystem.Instance.Remove(EEventName.RoleHandBookActive, new Action<int>(this.OnRoleHandBookActive));
		EventSystem.Instance.Remove(EEventName.OnAddCommonItemList, new Action<IReadOnlyList<IProto_NormalItem>>(this.OnAddCommonItemList));
	}

	// Token: 0x06014C12 RID: 85010 RVA: 0x005407A0 File Offset: 0x0053E9A0
	private void OnAddCommonItemList(IReadOnlyList<IProto_NormalItem> _)
	{
		if (this.RoleSelectionComponent == null)
		{
			return;
		}
		int curSelectRoleId = this.RoleSelectionComponent.GetCurSelectRoleId();
		if (curSelectRoleId == 0)
		{
			return;
		}
		this.RoleSelectionComponent.UpdateItemByRoleId(curSelectRoleId);
	}

	// Token: 0x06014C13 RID: 85011 RVA: 0x005407D2 File Offset: 0x0053E9D2
	private void OnRoleHandBookActive(int roleId)
	{
		if (this.RoleSelectionComponent == null)
		{
			return;
		}
		RoleController.Instance.ShowUiSceneActorAndShadow(false);
		this.SetActive(false);
		this.RoleSelectionComponent.PlaySequence();
	}

	// Token: 0x06014C14 RID: 85012 RVA: 0x005407FC File Offset: 0x0053E9FC
	protected void InitRoleList()
	{
		List<RoleInfo> list = ConfigCommon.ToList<RoleInfo>(RoleConfig.Instance.GetRoleListByType(ERoleType.Common));
		list.Sort((RoleInfo aRoleConfig, RoleInfo bRoleConfig) => aRoleConfig.Id - bRoleConfig.Id);
		int count = list.Count;
		this.RoleList = new RoleDataBase[count];
		int num = 0;
		for (int i = 0; i < count; i++)
		{
			RoleInfo roleInfo = list[i];
			if (roleInfo.PartyId != 9)
			{
				RoleDataBase roleDataById = RoleModel.Instance.GetRoleDataById(roleInfo.Id, true);
				this.RoleList[num] = roleDataById;
				num++;
			}
		}
	}

	// Token: 0x06014C15 RID: 85013 RVA: 0x00540898 File Offset: 0x0053EA98
	protected void LoadFloorEffect()
	{
		AActor actorByTag = UiSceneManager.Instance.GetActorByTag("RoleFloorCase");
		if (actorByTag != null)
		{
			this.FloorEffect = EffectUtil.SpawnUiEffect("RoleSystemFloorEffect", "[RoleHandBookSelectionView.LoadFloorEffect]", new FTransformDouble?(actorByTag.D_GetTransform()), new EffectContext(null, actorByTag, false)).Value;
		}
	}

	// Token: 0x06014C16 RID: 85014 RVA: 0x005408F0 File Offset: 0x0053EAF0
	protected override void OnAfterHide()
	{
		if (EffectSystem.Instance.IsValid(this.FloorEffect))
		{
			EffectSystem.Instance.StopEffectById(this.FloorEffect, "[RoleHandBookSelectionView.OnHide]", false, null);
		}
	}

	// Token: 0x06014C17 RID: 85015 RVA: 0x00540930 File Offset: 0x0053EB30
	protected void RoleSelectionSelectedEvent(int roleId)
	{
		int? curSelectMainRoleId = RoleModel.Instance.GetCurSelectMainRoleId();
		if (!(curSelectMainRoleId.GetValueOrDefault() == roleId & curSelectMainRoleId != null))
		{
			RoleController.Instance.PlayRoleMontage(EPerformanceRoleState.Attribute, false, false, false);
			if (this.RoleSelectionComponent != null)
			{
				this.RoleSelectionComponent.UpdateRoleHandBookItem(roleId);
			}
		}
	}

	// Token: 0x06014C18 RID: 85016 RVA: 0x00540980 File Offset: 0x0053EB80
	protected override void OnBeforeCreate()
	{
		this.UiSceneRoleActor = UiSceneManager.Instance.InitRoleSystemRoleActor(EUiModelUseWay.RoleInRoleView);
	}

	// Token: 0x06014C19 RID: 85017 RVA: 0x00540994 File Offset: 0x0053EB94
	protected override void OnBeforeDestroy()
	{
		UiSceneManager.Instance.DestroyRoleSystemRoleActor(this.UiSceneRoleActor);
		if (EffectSystem.Instance.IsValid(this.FloorEffect))
		{
			EffectSystem.Instance.StopEffectById(this.FloorEffect, "[RoleHandBookSelectionView.OnDestroy]", true, null);
			this.FloorEffect = 0;
		}
		this.RoleList = null;
	}

	// Token: 0x04009C0B RID: 39947
	public const string ROLE_HAND_BOOK_BLENDNAME = "10061";

	// Token: 0x04009C0C RID: 39948
	[Nullable(2)]
	protected RoleHandBookSelectionComponent RoleSelectionComponent;

	// Token: 0x04009C0D RID: 39949
	private int FloorEffect;

	// Token: 0x04009C0E RID: 39950
	[Nullable(new byte[]
	{
		2,
		1
	})]
	protected RoleDataBase[] RoleList;

	// Token: 0x04009C0F RID: 39951
	[Nullable(2)]
	private TsUiSceneRoleActor UiSceneRoleActor;
}
