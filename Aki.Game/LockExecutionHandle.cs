using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Camera;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.LevelGamePlay;
using Cysharp.Threading.Tasks;
using UnrealEngine;

// Token: 0x02001F2F RID: 7983
[NullableContext(1)]
[Nullable(0)]
public class LockExecutionHandle : HudUnitHandleBase
{
	// Token: 0x0600F621 RID: 63009 RVA: 0x003B6D38 File Offset: 0x003B4F38
	protected override void OnInitialize()
	{
		this.MinDistanceSquare = (double)ConfigCommonParamById.GetIntConfig("LockExecutionShowDistance").Value;
	}

	// Token: 0x0600F622 RID: 63010 RVA: 0x003B6D5E File Offset: 0x003B4F5E
	protected override void OnAddEvents()
	{
		EventSystem.Instance.Add<bool, int, ECustomOptionType?>(EEventName.OnEnterOrExitExecutionRange, new Action<bool, int, ECustomOptionType?>(this.OnEnterOrExitExecutionRange));
	}

	// Token: 0x0600F623 RID: 63011 RVA: 0x003B6D7C File Offset: 0x003B4F7C
	protected override void OnRemoveEvents()
	{
		EventSystem.Instance.Remove<bool, int, ECustomOptionType?>(EEventName.OnEnterOrExitExecutionRange, new Action<bool, int, ECustomOptionType?>(this.OnEnterOrExitExecutionRange));
	}

	// Token: 0x0600F624 RID: 63012 RVA: 0x003B6D9A File Offset: 0x003B4F9A
	private void OnEnterOrExitExecutionRange(bool isEnter, int entityId, ECustomOptionType? optionType)
	{
		if (isEnter && optionType.GetValueOrDefault() == ECustomOptionType.Execution)
		{
			this.OnShowExecutionUi(entityId);
			return;
		}
		this.OnHideExecutionUi(entityId);
	}

	// Token: 0x0600F625 RID: 63013 RVA: 0x003B6DB8 File Offset: 0x003B4FB8
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

	// Token: 0x0600F626 RID: 63014 RVA: 0x003B6E06 File Offset: 0x003B5006
	private void OnHideExecutionUi(int entityId)
	{
		EntityHandle entityHandle = this.EntityHandle;
		if (entityHandle == null || entityHandle.Id != entityId)
		{
			return;
		}
		this.OnRemove();
	}

	// Token: 0x0600F627 RID: 63015 RVA: 0x003B6E29 File Offset: 0x003B5029
	private void OnAdd()
	{
		this.AddEntityEvents();
		this.TryActivate();
	}

	// Token: 0x0600F628 RID: 63016 RVA: 0x003B6E37 File Offset: 0x003B5037
	private void OnRemove()
	{
		this.RemoveEntityEvents();
		this.IsActive = false;
		this.TryDeactivate();
		this.EntityHandle = null;
	}

	// Token: 0x0600F629 RID: 63017 RVA: 0x003B6E53 File Offset: 0x003B5053
	private void AddEntityEvents()
	{
		if (this.EntityHandle == null)
		{
			return;
		}
		EventSystem.Instance.AddWithTarget<ERemoveEntityType, EntityHandle>(this.EntityHandle, EEventName.RemoveEntity, new Action<ERemoveEntityType, EntityHandle>(this.OnRemoveEntity));
	}

	// Token: 0x0600F62A RID: 63018 RVA: 0x003B6E80 File Offset: 0x003B5080
	private void RemoveEntityEvents()
	{
		if (this.EntityHandle == null)
		{
			return;
		}
		EventSystem.Instance.RemoveWithTarget<ERemoveEntityType, EntityHandle>(this.EntityHandle, EEventName.RemoveEntity, new Action<ERemoveEntityType, EntityHandle>(this.OnRemoveEntity));
	}

	// Token: 0x0600F62B RID: 63019 RVA: 0x003B6EAD File Offset: 0x003B50AD
	private void OnRemoveEntity(ERemoveEntityType removeType, EntityHandle handle)
	{
		if (this.EntityHandle == null)
		{
			return;
		}
		this.OnRemove();
	}

	// Token: 0x0600F62C RID: 63020 RVA: 0x003B6EBE File Offset: 0x003B50BE
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

	// Token: 0x0600F62D RID: 63021 RVA: 0x003B6EF8 File Offset: 0x003B50F8
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

	// Token: 0x0600F62E RID: 63022 RVA: 0x003B7005 File Offset: 0x003B5205
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

	// Token: 0x0600F62F RID: 63023 RVA: 0x003B703C File Offset: 0x003B523C
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

	// Token: 0x0600F630 RID: 63024 RVA: 0x003B7077 File Offset: 0x003B5277
	private void TryDeactivate()
	{
		if (this.LockExecutionUnit == null)
		{
			return;
		}
		this.LockExecutionUnit.TryHide(true);
	}

	// Token: 0x0600F631 RID: 63025 RVA: 0x003B7090 File Offset: 0x003B5290
	private FVectorDouble? GetWorldLocation()
	{
		AActor owner = this.EntityHandle.Entity.GetComponent<BaseActorComponent>().Owner;
		if (!(owner is TsBaseCharacter))
		{
			return null;
		}
		return new FVectorDouble?((owner as TsBaseCharacter).Mesh.D_GetSocketLocation(LockExecutionHandle._hitCaseSocket));
	}

	// Token: 0x040071EC RID: 29164
	private static readonly FName _hitCaseSocket = new FName("HitCase");

	// Token: 0x040071ED RID: 29165
	private readonly Vector2D ScreenPos = new Vector2D();

	// Token: 0x040071EE RID: 29166
	[Nullable(2)]
	private LockExecutionUnit LockExecutionUnit;

	// Token: 0x040071EF RID: 29167
	[Nullable(2)]
	private EntityHandle EntityHandle;

	// Token: 0x040071F0 RID: 29168
	private bool IsLoading;

	// Token: 0x040071F1 RID: 29169
	private bool IsActive;

	// Token: 0x040071F2 RID: 29170
	private double MinDistanceSquare;
}
