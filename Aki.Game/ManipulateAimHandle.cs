using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using UnrealEngine;

// Token: 0x02001F32 RID: 7986
[NullableContext(2)]
[Nullable(0)]
public class ManipulateAimHandle : HudUnitHandleBase
{
	// Token: 0x0600F654 RID: 63060 RVA: 0x003B77E4 File Offset: 0x003B59E4
	protected override void OnDestroyed()
	{
		this.DestroyManipulateAimUnit();
		this.ManipulateAimUnit = null;
		this.TargetActorComponent = null;
		this.TargetSkeletalMesh = null;
		this.HasTargetSocketName = false;
	}

	// Token: 0x0600F655 RID: 63061 RVA: 0x003B7808 File Offset: 0x003B5A08
	protected override void OnTick(float delta)
	{
		this.RefreshScreenPosition();
	}

	// Token: 0x0600F656 RID: 63062 RVA: 0x003B7810 File Offset: 0x003B5A10
	protected override void OnAddEvents()
	{
		EventSystem.Instance.Add<bool, Entity, bool>(EEventName.OnManipulateSwitchToNewTarget, new Action<bool, Entity, bool>(this.OnSwitchToNewTarget));
		EventSystem.Instance.Add<float, string>(EEventName.OnManipulateStartChanting, new Action<float, string>(this.OnManipulateStart));
		EventSystem.Instance.Add<Entity, CharacterPart>(EEventName.ManipulateStartLockCastTarget, new Action<Entity, CharacterPart>(this.OnManipulateStartLockCastTarget));
		EventSystem.Instance.Add(EEventName.ManipulateEndLockCastTarget, new Action(this.OnManipulateEndLockCastTarget));
		EventSystem.Instance.Add(EEventName.HiddenManipulateUI, new Action(this.OnManipulateEnded));
	}

	// Token: 0x0600F657 RID: 63063 RVA: 0x003B78AC File Offset: 0x003B5AAC
	protected override void OnRemoveEvents()
	{
		EventSystem.Instance.Remove<bool, Entity, bool>(EEventName.OnManipulateSwitchToNewTarget, new Action<bool, Entity, bool>(this.OnSwitchToNewTarget));
		EventSystem.Instance.Remove<float, string>(EEventName.OnManipulateStartChanting, new Action<float, string>(this.OnManipulateStart));
		EventSystem.Instance.Remove<Entity, CharacterPart>(EEventName.ManipulateStartLockCastTarget, new Action<Entity, CharacterPart>(this.OnManipulateStartLockCastTarget));
		EventSystem.Instance.Remove(EEventName.ManipulateEndLockCastTarget, new Action(this.OnManipulateEndLockCastTarget));
		EventSystem.Instance.Remove(EEventName.HiddenManipulateUI, new Action(this.OnManipulateEnded));
	}

	// Token: 0x0600F658 RID: 63064 RVA: 0x003B7945 File Offset: 0x003B5B45
	private void OnSwitchToNewTarget(bool isActive, Entity entity, bool isCastTarget)
	{
		if (isActive)
		{
			return;
		}
		if (this.TargetActorComponent != null)
		{
			return;
		}
		ManipulateAimUnit manipulateAimUnit = this.ManipulateAimUnit;
		if (manipulateAimUnit == null)
		{
			return;
		}
		manipulateAimUnit.PlayCloseAnim();
	}

	// Token: 0x0600F659 RID: 63065 RVA: 0x003B7964 File Offset: 0x003B5B64
	[NullableContext(1)]
	private void OnManipulateStart(float time, string resId)
	{
		this.ResId = resId;
		if (this.ManipulateAimUnit == null)
		{
			this.NewManipulateAimUnit();
			return;
		}
		if (this.ManipulateAimUnit.ResourceId != this.ResId)
		{
			this.DestroyManipulateAimUnit();
			this.NewManipulateAimUnit();
			return;
		}
		this.RefreshScreenPosition();
		this.RefreshWeakness();
		this.ManipulateAimUnit.PlayStartAnim();
	}

	// Token: 0x0600F65A RID: 63066 RVA: 0x003B79C4 File Offset: 0x003B5BC4
	[NullableContext(1)]
	private void OnManipulateStartLockCastTarget(Entity lockEntity, CharacterPart lockPart)
	{
		if (lockEntity == null)
		{
			return;
		}
		this.TargetActorComponent = lockEntity.GetComponent<CharacterActorComponent>();
		CharacterActorComponent targetActorComponent = this.TargetActorComponent;
		this.TargetSkeletalMesh = ((targetActorComponent != null) ? targetActorComponent.Actor.Mesh : null);
		this.TargetSocketName = ((lockPart != null) ? lockPart.PartSocketName : null);
		this.HasTargetSocketName = true;
		this.TargetIsWeakness = (lockPart != null && lockPart.IsWeakness);
		if (this.ManipulateAimUnit == null)
		{
			this.NewManipulateAimUnit();
			return;
		}
		if (this.ManipulateAimUnit.ResourceId != this.ResId)
		{
			this.DestroyManipulateAimUnit();
			this.NewManipulateAimUnit();
			return;
		}
		this.RefreshScreenPosition();
		this.RefreshWeakness();
	}

	// Token: 0x0600F65B RID: 63067 RVA: 0x003B7A71 File Offset: 0x003B5C71
	private void OnManipulateEndLockCastTarget()
	{
		this.TargetActorComponent = null;
		this.TargetSkeletalMesh = null;
		this.HasTargetSocketName = false;
		ManipulateAimUnit manipulateAimUnit = this.ManipulateAimUnit;
		if (manipulateAimUnit == null)
		{
			return;
		}
		manipulateAimUnit.SetTargetAimVisible(false);
	}

	// Token: 0x0600F65C RID: 63068 RVA: 0x003B7A99 File Offset: 0x003B5C99
	private void OnManipulateEnded()
	{
		this.TargetActorComponent = null;
		this.TargetSkeletalMesh = null;
		this.HasTargetSocketName = false;
		this.ResId = null;
		ManipulateAimUnit manipulateAimUnit = this.ManipulateAimUnit;
		if (manipulateAimUnit == null)
		{
			return;
		}
		manipulateAimUnit.PlayCloseAnim();
	}

	// Token: 0x0600F65D RID: 63069 RVA: 0x003B7AC8 File Offset: 0x003B5CC8
	private void NewManipulateAimUnit()
	{
		if (string.IsNullOrEmpty(this.ResId))
		{
			return;
		}
		base.NewHudUnitWithReturn<ManipulateAimUnit>(typeof(ManipulateAimUnit), this.ResId, out this.ManipulateAimUnit, true, delegate(ManipulateAimUnit _)
		{
			string resId = this.ResId;
			ManipulateAimUnit manipulateAimUnit = this.ManipulateAimUnit;
			if (resId != ((manipulateAimUnit != null) ? manipulateAimUnit.ResourceId : null))
			{
				this.DestroyManipulateAimUnit();
				return;
			}
			ManipulateAimUnit manipulateAimUnit2 = this.ManipulateAimUnit;
			if (manipulateAimUnit2 != null)
			{
				manipulateAimUnit2.SetCloseAnimCallback(new Action(this.DestroyManipulateAimUnit));
			}
			this.RefreshScreenPosition();
			this.RefreshWeakness();
		}, false);
		EventSystem.Instance.Emit<bool, ECameraAimVisibleReason, string, string>(EEventName.SetCameraAimVisible, false, ECameraAimVisibleReason.InManipulate, null, null);
	}

	// Token: 0x0600F65E RID: 63070 RVA: 0x003B7B21 File Offset: 0x003B5D21
	private void DestroyManipulateAimUnit()
	{
		if (this.ManipulateAimUnit == null)
		{
			return;
		}
		base.DestroyHudUnit(this.ManipulateAimUnit);
		this.ManipulateAimUnit = null;
		EventSystem.Instance.Emit<bool, ECameraAimVisibleReason, string, string>(EEventName.SetCameraAimVisible, true, ECameraAimVisibleReason.InManipulate, null, null);
	}

	// Token: 0x0600F65F RID: 63071 RVA: 0x003B7B54 File Offset: 0x003B5D54
	private void RefreshScreenPosition()
	{
		if (this.ManipulateAimUnit == null)
		{
			return;
		}
		if (this.ManipulateAimUnit.InAsyncLoading())
		{
			return;
		}
		FVectorDouble? targetLocation = this.GetTargetLocation();
		if (targetLocation == null)
		{
			this.ManipulateAimUnit.SetTargetAimVisible(false);
			return;
		}
		FVector2D? fvector2D = base.ProjectWorldToScreen(targetLocation.Value);
		if (fvector2D == null)
		{
			this.ManipulateAimUnit.SetTargetAimVisible(false);
			return;
		}
		this.ManipulateAimUnit.SetTargetItemOffset(fvector2D.Value.X, fvector2D.Value.Y);
		this.ManipulateAimUnit.SetTargetAimVisible(true);
	}

	// Token: 0x0600F660 RID: 63072 RVA: 0x003B7BE8 File Offset: 0x003B5DE8
	private void RefreshWeakness()
	{
		if (this.ManipulateAimUnit == null)
		{
			return;
		}
		if (this.ManipulateAimUnit.InAsyncLoading())
		{
			return;
		}
		this.ManipulateAimUnit.SetIsWeakness(this.TargetIsWeakness);
	}

	// Token: 0x0600F661 RID: 63073 RVA: 0x003B7C14 File Offset: 0x003B5E14
	private FVectorDouble? GetTargetLocation()
	{
		if (this.TargetActorComponent == null)
		{
			return null;
		}
		if (this.TargetSkeletalMesh == null || !this.HasTargetSocketName)
		{
			return new FVectorDouble?(this.TargetActorComponent.ActorLocation);
		}
		FName inSocketName = this.TargetSocketName ?? FNameUtil.EMPTY;
		if (!this.TargetSkeletalMesh.DoesSocketExist(inSocketName))
		{
			return new FVectorDouble?(this.TargetActorComponent.ActorLocation);
		}
		return new FVectorDouble?(this.TargetSkeletalMesh.D_GetSocketLocation(inSocketName));
	}

	// Token: 0x04007202 RID: 29186
	private ManipulateAimUnit ManipulateAimUnit;

	// Token: 0x04007203 RID: 29187
	private CharacterActorComponent TargetActorComponent;

	// Token: 0x04007204 RID: 29188
	private USkeletalMeshComponent TargetSkeletalMesh;

	// Token: 0x04007205 RID: 29189
	private FName? TargetSocketName;

	// Token: 0x04007206 RID: 29190
	private bool HasTargetSocketName;

	// Token: 0x04007207 RID: 29191
	private bool TargetIsWeakness;

	// Token: 0x04007208 RID: 29192
	private string ResId;
}
