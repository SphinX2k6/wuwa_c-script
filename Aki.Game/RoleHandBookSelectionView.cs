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

// Token: 0x02001C6E RID: 7278
[NullableContext(1)]
[Nullable(0)]
public class RoleHandBookSelectionView : UiViewBase
{
	// Token: 0x060120EE RID: 73966 RVA: 0x0054F52A File Offset: 0x0054D72A
	public RoleHandBookSelectionView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x060120EF RID: 73967 RVA: 0x0054F533 File Offset: 0x0054D733
	protected override void OnHandleLoadScene()
	{
	}

	// Token: 0x060120F0 RID: 73968 RVA: 0x0054F535 File Offset: 0x0054D735
	protected override void OnHandleReleaseScene()
	{
	}

	// Token: 0x060120F1 RID: 73969 RVA: 0x0054F537 File Offset: 0x0054D737
	protected override void OnStart()
	{
		this.RoleSelectionComponent = new RoleHandBookSelectionComponent();
		this.LoadFloorEffect();
	}

	// Token: 0x060120F2 RID: 73970 RVA: 0x0054F54C File Offset: 0x0054D74C
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

	// Token: 0x060120F3 RID: 73971 RVA: 0x0054F5A3 File Offset: 0x0054D7A3
	protected override void OnAddEventListener()
	{
		base.OnAddEventListener();
		EventSystem.Instance.Add<int>(EEventName.RoleHandBookActive, new Action<int>(this.OnRoleHandBookActive));
		EventSystem.Instance.Add<IReadOnlyList<IProto_NormalItem>>(EEventName.OnAddCommonItemList, new Action<IReadOnlyList<IProto_NormalItem>>(this.OnAddCommonItemList));
	}

	// Token: 0x060120F4 RID: 73972 RVA: 0x0054F5E3 File Offset: 0x0054D7E3
	protected override void OnRemoveEventListener()
	{
		base.OnRemoveEventListener();
		EventSystem.Instance.Remove(EEventName.RoleHandBookActive, new Action<int>(this.OnRoleHandBookActive));
		EventSystem.Instance.Remove(EEventName.OnAddCommonItemList, new Action<IReadOnlyList<IProto_NormalItem>>(this.OnAddCommonItemList));
	}

	// Token: 0x060120F5 RID: 73973 RVA: 0x0054F624 File Offset: 0x0054D824
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

	// Token: 0x060120F6 RID: 73974 RVA: 0x0054F656 File Offset: 0x0054D856
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

	// Token: 0x060120F7 RID: 73975 RVA: 0x0054F680 File Offset: 0x0054D880
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

	// Token: 0x060120F8 RID: 73976 RVA: 0x0054F71C File Offset: 0x0054D91C
	protected void LoadFloorEffect()
	{
		AActor actorByTag = UiSceneManager.Instance.GetActorByTag("RoleFloorCase");
		if (actorByTag != null)
		{
			this.FloorEffect = EffectUtil.SpawnUiEffect("RoleSystemFloorEffect", "[RoleHandBookSelectionView.LoadFloorEffect]", new FTransformDouble?(actorByTag.D_GetTransform()), new EffectContext(null, actorByTag, false)).Value;
		}
	}

	// Token: 0x060120F9 RID: 73977 RVA: 0x0054F774 File Offset: 0x0054D974
	protected override void OnAfterHide()
	{
		if (EffectSystem.Instance.IsValid(this.FloorEffect))
		{
			EffectSystem.Instance.StopEffectById(this.FloorEffect, "[RoleHandBookSelectionView.OnHide]", false, null);
		}
	}

	// Token: 0x060120FA RID: 73978 RVA: 0x0054F7B4 File Offset: 0x0054D9B4
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

	// Token: 0x060120FB RID: 73979 RVA: 0x0054F804 File Offset: 0x0054DA04
	protected override void OnBeforeCreate()
	{
		this.UiSceneRoleActor = UiSceneManager.Instance.InitRoleSystemRoleActor(EUiModelUseWay.RoleInRoleView);
	}

	// Token: 0x060120FC RID: 73980 RVA: 0x0054F818 File Offset: 0x0054DA18
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

	// Token: 0x04009D63 RID: 40291
	public const string ROLE_HAND_BOOK_BLENDNAME = "10061";

	// Token: 0x04009D64 RID: 40292
	[Nullable(2)]
	protected RoleHandBookSelectionComponent RoleSelectionComponent;

	// Token: 0x04009D65 RID: 40293
	private int FloorEffect;

	// Token: 0x04009D66 RID: 40294
	[Nullable(new byte[]
	{
		2,
		1
	})]
	protected RoleDataBase[] RoleList;

	// Token: 0x04009D67 RID: 40295
	[Nullable(2)]
	private TsUiSceneRoleActor UiSceneRoleActor;
}
