using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using UnrealEngine;

// Token: 0x020013F4 RID: 5108
[NullableContext(2)]
[Nullable(0)]
public class ManipulateAimHandle : HudUnitHandleBase
{
	// Token: 0x0600CA73 RID: 51827 RVA: 0x003C32D0 File Offset: 0x003C14D0
	protected override void OnDestroyed()
	{
		this.DestroyManipulateAimUnit();
		this.ManipulateAimUnit = null;
		this.TargetActorComponent = null;
		this.TargetSkeletalMesh = null;
		this.HasTargetSocketName = false;
	}

	// Token: 0x0600CA74 RID: 51828 RVA: 0x003C32F4 File Offset: 0x003C14F4
	protected override void OnTick(float delta)
	{
		this.RefreshScreenPosition();
	}

	// Token: 0x0600CA75 RID: 51829 RVA: 0x003C32FC File Offset: 0x003C14FC
	protected override void OnAddEvents()
	{
		EventSystem.Instance.Add<bool, Entity, bool>(EEventName.OnManipulateSwitchToNewTarget, new Action<bool, Entity, bool>(this.OnSwitchToNewTarget));
		EventSystem.Instance.Add<float, string>(EEventName.OnManipulateStartChanting, new Action<float, string>(this.OnManipulateStart));
		EventSystem.Instance.Add<Entity, CharacterPart>(EEventName.ManipulateStartLockCastTarget, new Action<Entity, CharacterPart>(this.OnManipulateStartLockCastTarget));
		EventSystem.Instance.Add(EEventName.ManipulateEndLockCastTarget, new Action(this.OnManipulateEndLockCastTarget));
		EventSystem.Instance.Add(EEventName.HiddenManipulateUI, new Action(this.OnManipulateEnded));
	}

	// Token: 0x0600CA76 RID: 51830 RVA: 0x003C3398 File Offset: 0x003C1598
	protected override void OnRemoveEvents()
	{
		EventSystem.Instance.Remove<bool, Entity, bool>(EEventName.OnManipulateSwitchToNewTarget, new Action<bool, Entity, bool>(this.OnSwitchToNewTarget));
		EventSystem.Instance.Remove<float, string>(EEventName.OnManipulateStartChanting, new Action<float, string>(this.OnManipulateStart));
		EventSystem.Instance.Remove<Entity, CharacterPart>(EEventName.ManipulateStartLockCastTarget, new Action<Entity, CharacterPart>(this.OnManipulateStartLockCastTarget));
		EventSystem.Instance.Remove(EEventName.ManipulateEndLockCastTarget, new Action(this.OnManipulateEndLockCastTarget));
		EventSystem.Instance.Remove(EEventName.HiddenManipulateUI, new Action(this.OnManipulateEnded));
	}

	// Token: 0x0600CA77 RID: 51831 RVA: 0x003C3431 File Offset: 0x003C1631
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

	// Token: 0x0600CA78 RID: 51832 RVA: 0x003C3450 File Offset: 0x003C1650
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

	// Token: 0x0600CA79 RID: 51833 RVA: 0x003C34B0 File Offset: 0x003C16B0
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

	// Token: 0x0600CA7A RID: 51834 RVA: 0x003C355D File Offset: 0x003C175D
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

	// Token: 0x0600CA7B RID: 51835 RVA: 0x003C3585 File Offset: 0x003C1785
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

	// Token: 0x0600CA7C RID: 51836 RVA: 0x003C35B4 File Offset: 0x003C17B4
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

	// Token: 0x0600CA7D RID: 51837 RVA: 0x003C360D File Offset: 0x003C180D
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

	// Token: 0x0600CA7E RID: 51838 RVA: 0x003C3640 File Offset: 0x003C1840
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

	// Token: 0x0600CA7F RID: 51839 RVA: 0x003C36D4 File Offset: 0x003C18D4
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

	// Token: 0x0600CA80 RID: 51840 RVA: 0x003C3700 File Offset: 0x003C1900
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

	// Token: 0x040072E3 RID: 29411
	private ManipulateAimUnit ManipulateAimUnit;

	// Token: 0x040072E4 RID: 29412
	private CharacterActorComponent TargetActorComponent;

	// Token: 0x040072E5 RID: 29413
	private USkeletalMeshComponent TargetSkeletalMesh;

	// Token: 0x040072E6 RID: 29414
	private FName? TargetSocketName;

	// Token: 0x040072E7 RID: 29415
	private bool HasTargetSocketName;

	// Token: 0x040072E8 RID: 29416
	private bool TargetIsWeakness;

	// Token: 0x040072E9 RID: 29417
	private string ResId;
}
