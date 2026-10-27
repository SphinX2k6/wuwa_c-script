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
	// Token: 0x02004741 RID: 18241
	[NullableContext(1)]
	[Nullable(0)]
	public abstract class WuWaGoRole : WuWaGoBaseUnit
	{
		// Token: 0x0602FAB7 RID: 195255 RVA: 0x00B0C5F9 File Offset: 0x00B0A7F9
		protected WuWaGoRole(EWuWaGoRoleType type, Vector coordinate, Rotator rotator) : base(coordinate, rotator)
		{
		}

		// Token: 0x0602FAB8 RID: 195256 RVA: 0x00B0C632 File Offset: 0x00B0A832
		[NullableContext(2)]
		protected override AActor GetActorRaw()
		{
			return this.ActorInner;
		}

		// Token: 0x1700771D RID: 30493
		// (get) Token: 0x0602FAB9 RID: 195257 RVA: 0x00B0C63A File Offset: 0x00B0A83A
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

		// Token: 0x1700771E RID: 30494
		// (get) Token: 0x0602FABA RID: 195258 RVA: 0x00B0C64D File Offset: 0x00B0A84D
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

		// Token: 0x0602FABB RID: 195259 RVA: 0x00B0C660 File Offset: 0x00B0A860
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

		// Token: 0x0602FABC RID: 195260 RVA: 0x00B0C685 File Offset: 0x00B0A885
		public void SetAnimRootMotionTranslationScale(float scale)
		{
			TsBaseCharacter actorInner = this.ActorInner;
			if (actorInner == null)
			{
				return;
			}
			actorInner.SetAnimRootMotionTranslationScale(scale);
		}

		// Token: 0x0602FABD RID: 195261 RVA: 0x00B0C698 File Offset: 0x00B0A898
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

		// Token: 0x0602FABE RID: 195262 RVA: 0x00B0C6CF File Offset: 0x00B0A8CF
		public bool GetActorEnableCollision()
		{
			TsBaseCharacter actorInner = this.ActorInner;
			return actorInner != null && actorInner.GetActorEnableCollision();
		}

		// Token: 0x0602FABF RID: 195263 RVA: 0x00B0C6E2 File Offset: 0x00B0A8E2
		public void SetActorEnableCollision(bool enable)
		{
			TsBaseCharacter actorInner = this.ActorInner;
			if (actorInner == null)
			{
				return;
			}
			actorInner.SetActorEnableCollision(enable);
		}

		// Token: 0x0602FAC0 RID: 195264 RVA: 0x00B0C6F5 File Offset: 0x00B0A8F5
		public void RegisterAttackHitListener(Action listener)
		{
			WuWaGoFactory.RegisterAttackHitListener(this.ActorInner, listener);
		}

		// Token: 0x0602FAC1 RID: 195265 RVA: 0x00B0C703 File Offset: 0x00B0A903
		public void UnregisterAttackHitListener()
		{
			WuWaGoFactory.UnregisterAttackHitListener(this.ActorInner);
		}

		// Token: 0x1700771F RID: 30495
		// (get) Token: 0x0602FAC2 RID: 195266 RVA: 0x00B0C710 File Offset: 0x00B0A910
		// (set) Token: 0x0602FAC3 RID: 195267 RVA: 0x00B0C718 File Offset: 0x00B0A918
		public int Hp { get; private set; } = 1;

		// Token: 0x17007720 RID: 30496
		// (get) Token: 0x0602FAC4 RID: 195268 RVA: 0x00B0C721 File Offset: 0x00B0A921
		// (set) Token: 0x0602FAC5 RID: 195269 RVA: 0x00B0C729 File Offset: 0x00B0A929
		public bool IsClimbing { get; private set; }

		// Token: 0x17007721 RID: 30497
		// (get) Token: 0x0602FAC6 RID: 195270 RVA: 0x00B0C732 File Offset: 0x00B0A932
		public bool IsDead
		{
			get
			{
				return this.Hp == 0;
			}
		}

		// Token: 0x17007722 RID: 30498
		// (get) Token: 0x0602FAC7 RID: 195271 RVA: 0x00B0C73D File Offset: 0x00B0A93D
		public bool IsMonster
		{
			get
			{
				return this.Type > EWuWaGoRoleType.AircraftSoldiers;
			}
		}

		// Token: 0x17007723 RID: 30499
		// (get) Token: 0x0602FAC8 RID: 195272 RVA: 0x00B0C748 File Offset: 0x00B0A948
		// (set) Token: 0x0602FAC9 RID: 195273 RVA: 0x00B0C750 File Offset: 0x00B0A950
		public int StandGridId { get; private set; }

		// Token: 0x0602FACA RID: 195274 RVA: 0x00B0C75C File Offset: 0x00B0A95C
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

		// Token: 0x0602FACB RID: 195275 RVA: 0x00B0C7A0 File Offset: 0x00B0A9A0
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

		// Token: 0x0602FACC RID: 195276 RVA: 0x00B0C81E File Offset: 0x00B0AA1E
		public void AddMaterialHandle(int handle)
		{
			this.MaterialHandlesInner.Add(handle);
		}

		// Token: 0x0602FACD RID: 195277 RVA: 0x00B0C82C File Offset: 0x00B0AA2C
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

		// Token: 0x0602FACE RID: 195278 RVA: 0x00B0C918 File Offset: 0x00B0AB18
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

		// Token: 0x0602FACF RID: 195279 RVA: 0x00B0C964 File Offset: 0x00B0AB64
		public UniTask PlayPetrifyDissolve()
		{
			WuWaGoRole.<PlayPetrifyDissolve>d__39 <PlayPetrifyDissolve>d__;
			<PlayPetrifyDissolve>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayPetrifyDissolve>d__.<>4__this = this;
			<PlayPetrifyDissolve>d__.<>1__state = -1;
			<PlayPetrifyDissolve>d__.<>t__builder.Start<WuWaGoRole.<PlayPetrifyDissolve>d__39>(ref <PlayPetrifyDissolve>d__);
			return <PlayPetrifyDissolve>d__.<>t__builder.Task;
		}

		// Token: 0x0602FAD0 RID: 195280 RVA: 0x00B0C9A8 File Offset: 0x00B0ABA8
		private static UniTask DelayAsync(float ms)
		{
			WuWaGoRole.<DelayAsync>d__40 <DelayAsync>d__;
			<DelayAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<DelayAsync>d__.ms = ms;
			<DelayAsync>d__.<>1__state = -1;
			<DelayAsync>d__.<>t__builder.Start<WuWaGoRole.<DelayAsync>d__40>(ref <DelayAsync>d__);
			return <DelayAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602FAD1 RID: 195281 RVA: 0x00B0C9EB File Offset: 0x00B0ABEB
		public override IRollbackCapture CaptureRollback()
		{
			return new RoleRollbackCapture<WuWaGoRole>(this);
		}

		// Token: 0x0602FAD2 RID: 195282 RVA: 0x00B0C9F4 File Offset: 0x00B0ABF4
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

		// Token: 0x0602FAD3 RID: 195283 RVA: 0x00B0CA8C File Offset: 0x00B0AC8C
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

		// Token: 0x0602FAD4 RID: 195284 RVA: 0x00B0CAB8 File Offset: 0x00B0ACB8
		public void SetIsClimbing(bool value)
		{
			if (this.IsClimbing == value)
			{
				return;
			}
			base.MarkRollbackDirty();
			this.IsClimbing = value;
		}

		// Token: 0x0602FAD5 RID: 195285 RVA: 0x00B0CAD1 File Offset: 0x00B0ACD1
		public void AddStandGridChangedListener(WuWaGoRoleStandGridChangedListener listener)
		{
			this.StandGridChangedListeners.Add(listener);
		}

		// Token: 0x0602FAD6 RID: 195286 RVA: 0x00B0CAE0 File Offset: 0x00B0ACE0
		public void RemoveStandGridChangedListener(WuWaGoRoleStandGridChangedListener listener)
		{
			this.StandGridChangedListeners.Remove(listener);
		}

		// Token: 0x0602FAD7 RID: 195287 RVA: 0x00B0CAF0 File Offset: 0x00B0ACF0
		[NullableContext(2)]
		private void NotifyStandGridChanged(WuWaGoGrid prevGrid, WuWaGoGrid currentGrid)
		{
			foreach (WuWaGoRoleStandGridChangedListener wuWaGoRoleStandGridChangedListener in this.StandGridChangedListeners)
			{
				wuWaGoRoleStandGridChangedListener(this, prevGrid, currentGrid);
			}
		}

		// Token: 0x04019BD6 RID: 105430
		private readonly HashSet<WuWaGoRoleStandGridChangedListener> StandGridChangedListeners = new HashSet<WuWaGoRoleStandGridChangedListener>();

		// Token: 0x04019BD7 RID: 105431
		private readonly List<int> MaterialHandlesInner = new List<int>();

		// Token: 0x04019BD8 RID: 105432
		private readonly Dictionary<int, double> PetrifyMaterialHandles = new Dictionary<int, double>();

		// Token: 0x04019BD9 RID: 105433
		[Nullable(2)]
		protected TsBaseCharacter ActorInner;

		// Token: 0x04019BDD RID: 105437
		public readonly EWuWaGoRoleType Type = type;
	}
}
