using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component;
using AkiClient.Game.Aki.Data.Gameplay.WuWaGo;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.WuwaGo.Model.Role
{
	// Token: 0x02003672 RID: 13938
	[NullableContext(1)]
	[Nullable(0)]
	public abstract class WuWaGoRole : WuWaGoBaseUnit
	{
		// Token: 0x06024281 RID: 148097 RVA: 0x00A3C5C5 File Offset: 0x00A3A7C5
		protected WuWaGoRole(EWuWaGoRoleType type, Vector coordinate, Rotator rotator) : base(coordinate, rotator)
		{
		}

		// Token: 0x06024282 RID: 148098 RVA: 0x00A3C5FE File Offset: 0x00A3A7FE
		[NullableContext(2)]
		protected override AActor GetActorRaw()
		{
			return this.ActorInner;
		}

		// Token: 0x170049D9 RID: 18905
		// (get) Token: 0x06024283 RID: 148099 RVA: 0x00A3C606 File Offset: 0x00A3A806
		[Nullable(2)]
		public USkeletalMeshComponent Mesh
		{
			[NullableContext(2)]
			get
			{
				TsBaseCharacter actorInner = this.ActorInner;
				if (actorInner == null)
				{
					return null;
				}
				return actorInner.Mesh;
			}
		}

		// Token: 0x170049DA RID: 18906
		// (get) Token: 0x06024284 RID: 148100 RVA: 0x00A3C619 File Offset: 0x00A3A819
		[Nullable(2)]
		public UCharacterMovementComponent CharacterMovement
		{
			[NullableContext(2)]
			get
			{
				TsBaseCharacter actorInner = this.ActorInner;
				if (actorInner == null)
				{
					return null;
				}
				return actorInner.CharacterMovement;
			}
		}

		// Token: 0x06024285 RID: 148101 RVA: 0x00A3C62C File Offset: 0x00A3A82C
		[NullableContext(2)]
		public UKuroAnimInstanceChar GetAnimInstance()
		{
			TsBaseCharacter actorInner = this.ActorInner;
			object obj;
			if (actorInner == null)
			{
				obj = null;
			}
			else
			{
				USkeletalMeshComponent mesh = actorInner.Mesh;
				obj = ((mesh != null) ? mesh.GetAnimInstance() : null);
			}
			return obj as UKuroAnimInstanceChar;
		}

		// Token: 0x06024286 RID: 148102 RVA: 0x00A3C651 File Offset: 0x00A3A851
		public void SetAnimRootMotionTranslationScale(float scale)
		{
			TsBaseCharacter actorInner = this.ActorInner;
			if (actorInner == null)
			{
				return;
			}
			actorInner.SetAnimRootMotionTranslationScale(scale);
		}

		// Token: 0x06024287 RID: 148103 RVA: 0x00A3C664 File Offset: 0x00A3A864
		public float GetCapsuleHalfHeight()
		{
			TsBaseCharacter actorInner = this.ActorInner;
			UCapsuleComponent ucapsuleComponent = (actorInner != null) ? actorInner.CapsuleComponent : null;
			if (ucapsuleComponent == null || !ucapsuleComponent.IsValid())
			{
				return 0f;
			}
			return ucapsuleComponent.GetScaledCapsuleHalfHeight();
		}

		// Token: 0x06024288 RID: 148104 RVA: 0x00A3C69B File Offset: 0x00A3A89B
		public bool GetActorEnableCollision()
		{
			TsBaseCharacter actorInner = this.ActorInner;
			return actorInner != null && actorInner.GetActorEnableCollision();
		}

		// Token: 0x06024289 RID: 148105 RVA: 0x00A3C6AE File Offset: 0x00A3A8AE
		public void SetActorEnableCollision(bool enable)
		{
			TsBaseCharacter actorInner = this.ActorInner;
			if (actorInner == null)
			{
				return;
			}
			actorInner.SetActorEnableCollision(enable);
		}

		// Token: 0x0602428A RID: 148106 RVA: 0x00A3C6C1 File Offset: 0x00A3A8C1
		public void RegisterAttackHitListener(Action listener)
		{
			WuWaGoFactory.RegisterAttackHitListener(this.ActorInner, listener);
		}

		// Token: 0x0602428B RID: 148107 RVA: 0x00A3C6CF File Offset: 0x00A3A8CF
		public void UnregisterAttackHitListener()
		{
			WuWaGoFactory.UnregisterAttackHitListener(this.ActorInner);
		}

		// Token: 0x170049DB RID: 18907
		// (get) Token: 0x0602428C RID: 148108 RVA: 0x00A3C6DC File Offset: 0x00A3A8DC
		// (set) Token: 0x0602428D RID: 148109 RVA: 0x00A3C6E4 File Offset: 0x00A3A8E4
		public int Hp { get; private set; } = 1;

		// Token: 0x170049DC RID: 18908
		// (get) Token: 0x0602428E RID: 148110 RVA: 0x00A3C6ED File Offset: 0x00A3A8ED
		// (set) Token: 0x0602428F RID: 148111 RVA: 0x00A3C6F5 File Offset: 0x00A3A8F5
		public bool IsClimbing { get; private set; }

		// Token: 0x170049DD RID: 18909
		// (get) Token: 0x06024290 RID: 148112 RVA: 0x00A3C6FE File Offset: 0x00A3A8FE
		public bool IsDead
		{
			get
			{
				return this.Hp == 0;
			}
		}

		// Token: 0x170049DE RID: 18910
		// (get) Token: 0x06024291 RID: 148113 RVA: 0x00A3C709 File Offset: 0x00A3A909
		public bool IsMonster
		{
			get
			{
				return this.Type > EWuWaGoRoleType.AircraftSoldiers;
			}
		}

		// Token: 0x170049DF RID: 18911
		// (get) Token: 0x06024292 RID: 148114 RVA: 0x00A3C714 File Offset: 0x00A3A914
		// (set) Token: 0x06024293 RID: 148115 RVA: 0x00A3C71C File Offset: 0x00A3A91C
		public int StandGridId { get; private set; }

		// Token: 0x06024294 RID: 148116 RVA: 0x00A3C728 File Offset: 0x00A3A928
		[NullableContext(0)]
		public UniTask<bool> Create()
		{
			WuWaGoRole.<Create>d__34 <Create>d__;
			<Create>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<Create>d__.<>4__this = this;
			<Create>d__.<>1__state = -1;
			<Create>d__.<>t__builder.Start<WuWaGoRole.<Create>d__34>(ref <Create>d__);
			return <Create>d__.<>t__builder.Task;
		}

		// Token: 0x06024295 RID: 148117 RVA: 0x00A3C76C File Offset: 0x00A3A96C
		public void Destroy()
		{
			this.ClearMaterialHandles();
			WuWaGoGrid gridById = WuWaGoModel.Instance.GetGridById(this.StandGridId);
			if (gridById != null)
			{
				gridById.SetOccupiedUnit(null);
			}
			this.StandGridId = 0;
			this.NotifyStandGridChanged(gridById, null);
			TsBaseCharacter actorInner = this.ActorInner;
			if (actorInner != null && actorInner.IsValid())
			{
				WuWaGoFactory.DestroyRole(this.ActorInner);
			}
			this.ActorInner = null;
			this.StandGridChangedListeners.Clear();
			this.Hp = 1;
		}

		// Token: 0x06024296 RID: 148118 RVA: 0x00A3C7EA File Offset: 0x00A3A9EA
		public void AddMaterialHandle(int handle)
		{
			this.MaterialHandlesInner.Add(handle);
		}

		// Token: 0x06024297 RID: 148119 RVA: 0x00A3C7F8 File Offset: 0x00A3A9F8
		public void ClearMaterialHandles()
		{
			if (this.MaterialHandlesInner.Count == 0)
			{
				return;
			}
			TsBaseCharacter actorInner = this.ActorInner;
			CharRenderingComponent charRenderingComponent = (actorInner != null) ? actorInner.CharRenderingComponent : null;
			if (charRenderingComponent != null && charRenderingComponent.IsValid())
			{
				foreach (int handle in this.MaterialHandlesInner)
				{
					charRenderingComponent.RemoveMaterialControllerData(handle);
				}
				foreach (KeyValuePair<int, double> keyValuePair in this.PetrifyMaterialHandles)
				{
					int num;
					double num2;
					keyValuePair.Deconstruct(out num, out num2);
					int handle2 = num;
					charRenderingComponent.RemoveMaterialControllerData(handle2);
				}
			}
			this.MaterialHandlesInner.Clear();
			this.PetrifyMaterialHandles.Clear();
		}

		// Token: 0x06024298 RID: 148120 RVA: 0x00A3C8E4 File Offset: 0x00A3AAE4
		public UniTask ApplyPetrifyMaterial(BP_WuWaGo_C setting)
		{
			WuWaGoRole.<ApplyPetrifyMaterial>d__38 <ApplyPetrifyMaterial>d__;
			<ApplyPetrifyMaterial>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ApplyPetrifyMaterial>d__.<>4__this = this;
			<ApplyPetrifyMaterial>d__.setting = setting;
			<ApplyPetrifyMaterial>d__.<>1__state = -1;
			<ApplyPetrifyMaterial>d__.<>t__builder.Start<WuWaGoRole.<ApplyPetrifyMaterial>d__38>(ref <ApplyPetrifyMaterial>d__);
			return <ApplyPetrifyMaterial>d__.<>t__builder.Task;
		}

		// Token: 0x06024299 RID: 148121 RVA: 0x00A3C930 File Offset: 0x00A3AB30
		public UniTask PlayPetrifyDissolve()
		{
			WuWaGoRole.<PlayPetrifyDissolve>d__39 <PlayPetrifyDissolve>d__;
			<PlayPetrifyDissolve>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayPetrifyDissolve>d__.<>4__this = this;
			<PlayPetrifyDissolve>d__.<>1__state = -1;
			<PlayPetrifyDissolve>d__.<>t__builder.Start<WuWaGoRole.<PlayPetrifyDissolve>d__39>(ref <PlayPetrifyDissolve>d__);
			return <PlayPetrifyDissolve>d__.<>t__builder.Task;
		}

		// Token: 0x0602429A RID: 148122 RVA: 0x00A3C974 File Offset: 0x00A3AB74
		private static UniTask DelayAsync(float ms)
		{
			WuWaGoRole.<DelayAsync>d__40 <DelayAsync>d__;
			<DelayAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<DelayAsync>d__.ms = ms;
			<DelayAsync>d__.<>1__state = -1;
			<DelayAsync>d__.<>t__builder.Start<WuWaGoRole.<DelayAsync>d__40>(ref <DelayAsync>d__);
			return <DelayAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602429B RID: 148123 RVA: 0x00A3C9B7 File Offset: 0x00A3ABB7
		public override IRollbackCapture CaptureRollback()
		{
			return new RoleRollbackCapture<WuWaGoRole>(this);
		}

		// Token: 0x0602429C RID: 148124 RVA: 0x00A3C9C0 File Offset: 0x00A3ABC0
		[NullableContext(2)]
		public void SetStandGrid(WuWaGoGrid grid, WuWaGoGrid prevGrid = null)
		{
			WuWaGoGrid wuWaGoGrid = prevGrid ?? WuWaGoModel.Instance.GetGridById(this.StandGridId);
			int num = (grid != null) ? grid.Id : 0;
			if (this.StandGridId != num)
			{
				base.MarkRollbackDirty();
			}
			if (wuWaGoGrid != null && wuWaGoGrid != grid && wuWaGoGrid.OccupiedUnitId == this.Id)
			{
				wuWaGoGrid.SetOccupiedUnit(null);
			}
			this.StandGridId = num;
			if (grid != null)
			{
				base.SetCoordinate(grid.Coordinate);
				grid.SetOccupiedUnit(new int?(this.Id));
			}
			if (wuWaGoGrid != grid)
			{
				this.NotifyStandGridChanged(wuWaGoGrid, grid);
			}
		}

		// Token: 0x0602429D RID: 148125 RVA: 0x00A3CA58 File Offset: 0x00A3AC58
		public void SetHp(int value)
		{
			int num = Math.Max(0, value);
			if (this.Hp == num)
			{
				return;
			}
			base.MarkRollbackDirty();
			this.Hp = num;
		}

		// Token: 0x0602429E RID: 148126 RVA: 0x00A3CA84 File Offset: 0x00A3AC84
		public void SetIsClimbing(bool value)
		{
			if (this.IsClimbing == value)
			{
				return;
			}
			base.MarkRollbackDirty();
			this.IsClimbing = value;
		}

		// Token: 0x0602429F RID: 148127 RVA: 0x00A3CA9D File Offset: 0x00A3AC9D
		public void AddStandGridChangedListener(WuWaGoRoleStandGridChangedListener listener)
		{
			this.StandGridChangedListeners.Add(listener);
		}

		// Token: 0x060242A0 RID: 148128 RVA: 0x00A3CAAC File Offset: 0x00A3ACAC
		public void RemoveStandGridChangedListener(WuWaGoRoleStandGridChangedListener listener)
		{
			this.StandGridChangedListeners.Remove(listener);
		}

		// Token: 0x060242A1 RID: 148129 RVA: 0x00A3CABC File Offset: 0x00A3ACBC
		[NullableContext(2)]
		private void NotifyStandGridChanged(WuWaGoGrid prevGrid, WuWaGoGrid currentGrid)
		{
			foreach (WuWaGoRoleStandGridChangedListener wuWaGoRoleStandGridChangedListener in this.StandGridChangedListeners)
			{
				wuWaGoRoleStandGridChangedListener(this, prevGrid, currentGrid);
			}
		}

		// Token: 0x04014286 RID: 82566
		private readonly HashSet<WuWaGoRoleStandGridChangedListener> StandGridChangedListeners = new HashSet<WuWaGoRoleStandGridChangedListener>();

		// Token: 0x04014287 RID: 82567
		private readonly List<int> MaterialHandlesInner = new List<int>();

		// Token: 0x04014288 RID: 82568
		private readonly Dictionary<int, double> PetrifyMaterialHandles = new Dictionary<int, double>();

		// Token: 0x04014289 RID: 82569
		[Nullable(2)]
		protected TsBaseCharacter ActorInner;

		// Token: 0x0401428D RID: 82573
		public readonly EWuWaGoRoleType Type = type;
	}
}
