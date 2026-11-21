using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Camera;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.LevelGamePlay;
using Cysharp.Threading.Tasks;
using UnrealEngine;

// Token: 0x020013F1 RID: 5105
[NullableContext(1)]
[Nullable(0)]
public class LockExecutionHandle : HudUnitHandleBase
{
	// Token: 0x0600CA40 RID: 51776 RVA: 0x003C2824 File Offset: 0x003C0A24
	protected override void OnInitialize()
	{
		this.MinDistanceSquare = (double)ConfigCommonParamById.GetIntConfig("LockExecutionShowDistance").Value;
	}

	// Token: 0x0600CA41 RID: 51777 RVA: 0x003C284A File Offset: 0x003C0A4A
	protected override void OnAddEvents()
	{
		EventSystem.Instance.Add<bool, int, ECustomOptionType?>(EEventName.OnEnterOrExitExecutionRange, new Action<bool, int, ECustomOptionType?>(this.OnEnterOrExitExecutionRange));
	}

	// Token: 0x0600CA42 RID: 51778 RVA: 0x003C2868 File Offset: 0x003C0A68
	protected override void OnRemoveEvents()
	{
		EventSystem.Instance.Remove<bool, int, ECustomOptionType?>(EEventName.OnEnterOrExitExecutionRange, new Action<bool, int, ECustomOptionType?>(this.OnEnterOrExitExecutionRange));
	}

	// Token: 0x0600CA43 RID: 51779 RVA: 0x003C2886 File Offset: 0x003C0A86
	private void OnEnterOrExitExecutionRange(bool isEnter, int entityId, ECustomOptionType? optionType)
	{
		if (isEnter && optionType.GetValueOrDefault() == ECustomOptionType.Execution)
		{
			this.OnShowExecutionUi(entityId);
			return;
		}
		this.OnHideExecutionUi(entityId);
	}

	// Token: 0x0600CA44 RID: 51780 RVA: 0x003C28A4 File Offset: 0x003C0AA4
	private void OnShowExecutionUi(int entityId)
	{
		EntityHandle entityHandle = this.EntityHandle;
		if (entityHandle != null && entityHandle.Id == entityId)
		{
			return;
		}
		EntityHandle entityById = CreatureModel.Instance.GetEntityById(entityId);
		if (entityById == null)
		{
			this.OnRemove();
			return;
		}
		this.RemoveEntityEvents();
		this.EntityHandle = entityById;
		this.OnAdd();
	}

	// Token: 0x0600CA45 RID: 51781 RVA: 0x003C28F2 File Offset: 0x003C0AF2
	private void OnHideExecutionUi(int entityId)
	{
		EntityHandle entityHandle = this.EntityHandle;
		if (entityHandle == null || entityHandle.Id != entityId)
		{
			return;
		}
		this.OnRemove();
	}

	// Token: 0x0600CA46 RID: 51782 RVA: 0x003C2915 File Offset: 0x003C0B15
	private void OnAdd()
	{
		this.AddEntityEvents();
		this.TryActivate();
	}

	// Token: 0x0600CA47 RID: 51783 RVA: 0x003C2923 File Offset: 0x003C0B23
	private void OnRemove()
	{
		this.RemoveEntityEvents();
		this.IsActive = false;
		this.TryDeactivate();
		this.EntityHandle = null;
	}

	// Token: 0x0600CA48 RID: 51784 RVA: 0x003C293F File Offset: 0x003C0B3F
	private void AddEntityEvents()
	{
		if (this.EntityHandle == null)
		{
			return;
		}
		EventSystem.Instance.AddWithTarget<ERemoveEntityType, EntityHandle>(this.EntityHandle, EEventName.RemoveEntity, new Action<ERemoveEntityType, EntityHandle>(this.OnRemoveEntity));
	}

	// Token: 0x0600CA49 RID: 51785 RVA: 0x003C296C File Offset: 0x003C0B6C
	private void RemoveEntityEvents()
	{
		if (this.EntityHandle == null)
		{
			return;
		}
		EventSystem.Instance.RemoveWithTarget<ERemoveEntityType, EntityHandle>(this.EntityHandle, EEventName.RemoveEntity, new Action<ERemoveEntityType, EntityHandle>(this.OnRemoveEntity));
	}

	// Token: 0x0600CA4A RID: 51786 RVA: 0x003C2999 File Offset: 0x003C0B99
	private void OnRemoveEntity(ERemoveEntityType removeType, EntityHandle handle)
	{
		if (this.EntityHandle == null)
		{
			return;
		}
		this.OnRemove();
	}

	// Token: 0x0600CA4B RID: 51787 RVA: 0x003C29AA File Offset: 0x003C0BAA
	protected override void OnTick(float delta)
	{
		if (this.IsLoading)
		{
			return;
		}
		if (this.LockExecutionUnit == null)
		{
			return;
		}
		this.RefreshActiveAndPosition();
		if (this.IsActive)
		{
			this.LockExecutionUnit.TryShow();
			return;
		}
		this.LockExecutionUnit.TryHide(true);
	}

	// Token: 0x0600CA4C RID: 51788 RVA: 0x003C29E4 File Offset: 0x003C0BE4
	private void RefreshActiveAndPosition()
	{
		EntityHandle entityHandle = this.EntityHandle;
		if (entityHandle == null || !entityHandle.Valid)
		{
			this.IsActive = false;
			return;
		}
		FVectorDouble? worldLocation = this.GetWorldLocation();
		if (worldLocation == null)
		{
			this.IsActive = false;
			return;
		}
		global::Vector cameraLocation = CameraController.Instance.MainModel.CameraLocation;
		if (Math.Pow(cameraLocation.X - worldLocation.Value.X, 2.0) + Math.Pow(cameraLocation.Y - worldLocation.Value.Y, 2.0) + Math.Pow(cameraLocation.Z - worldLocation.Value.Z, 2.0) < this.MinDistanceSquare)
		{
			this.IsActive = false;
			return;
		}
		if (!HudUnitUtils.PositionUtil.ProjectWorldToScreen(worldLocation.Value, this.ScreenPos))
		{
			this.IsActive = false;
			return;
		}
		this.IsActive = true;
		this.LockExecutionUnit.GetRootItem().SetAnchorOffset(this.ScreenPos.ToUeVector2D(false));
	}

	// Token: 0x0600CA4D RID: 51789 RVA: 0x003C2AF1 File Offset: 0x003C0CF1
	private void TryActivate()
	{
		if (this.LockExecutionUnit == null)
		{
			this.Activate();
			return;
		}
		this.RefreshActiveAndPosition();
		if (this.IsActive)
		{
			this.LockExecutionUnit.TryShow();
			return;
		}
		this.LockExecutionUnit.TryHide(true);
	}

	// Token: 0x0600CA4E RID: 51790 RVA: 0x003C2B28 File Offset: 0x003C0D28
	private void Activate()
	{
		if (this.IsLoading)
		{
			return;
		}
		this.IsLoading = true;
		base.NewHudUnit<LockExecutionUnit>(typeof(LockExecutionUnit), "UiItem_PutDeath", false, false).ContinueWith(delegate(LockExecutionUnit lockExecutionUnit)
		{
			if (lockExecutionUnit == null || this.IsDestroyed)
			{
				return;
			}
			this.IsLoading = false;
			this.LockExecutionUnit = lockExecutionUnit;
			this.RefreshActiveAndPosition();
			if (this.IsActive)
			{
				this.LockExecutionUnit.TryShow();
				return;
			}
			this.LockExecutionUnit.TryHide(false);
		});
	}

	// Token: 0x0600CA4F RID: 51791 RVA: 0x003C2B63 File Offset: 0x003C0D63
	private void TryDeactivate()
	{
		if (this.LockExecutionUnit == null)
		{
			return;
		}
		this.LockExecutionUnit.TryHide(true);
	}

	// Token: 0x0600CA50 RID: 51792 RVA: 0x003C2B7C File Offset: 0x003C0D7C
	private FVectorDouble? GetWorldLocation()
	{
		AActor owner = this.EntityHandle.Entity.GetComponent<BaseActorComponent>().Owner;
		if (!(owner is TsBaseCharacter))
		{
			return null;
		}
		return new FVectorDouble?((owner as TsBaseCharacter).Mesh.D_GetSocketLocation(LockExecutionHandle._hitCaseSocket));
	}

	// Token: 0x040072CD RID: 29389
	private static readonly FName _hitCaseSocket = new FName("HitCase");

	// Token: 0x040072CE RID: 29390
	private readonly Vector2D ScreenPos = new Vector2D();

	// Token: 0x040072CF RID: 29391
	[Nullable(2)]
	private LockExecutionUnit LockExecutionUnit;

	// Token: 0x040072D0 RID: 29392
	[Nullable(2)]
	private EntityHandle EntityHandle;

	// Token: 0x040072D1 RID: 29393
	private bool IsLoading;

	// Token: 0x040072D2 RID: 29394
	private bool IsActive;

	// Token: 0x040072D3 RID: 29395
	private double MinDistanceSquare;
}
