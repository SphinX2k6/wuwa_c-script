using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Utils;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.NewWorld.Vehicle.Common
{
	// Token: 0x020061D4 RID: 25044
	[NullableContext(1)]
	[Nullable(0)]
	public class VehicleActionComponent : EntityComponent
	{
		// Token: 0x17007164 RID: 29028
		// (get) Token: 0x0603C1A2 RID: 246178 RVA: 0x0111B5D5 File Offset: 0x011197D5
		public override Type[] Dependencies
		{
			get
			{
				return new Type[]
				{
					typeof(VehicleCatapultComponent),
					typeof(VehicleSkillComponent),
					typeof(VehicleActorComponent)
				};
			}
		}

		// Token: 0x0603C1A3 RID: 246179 RVA: 0x0111B604 File Offset: 0x01119804
		protected override bool OnStart()
		{
			this.VehicleCatapultComponent = base.Entity.GetComponent<VehicleCatapultComponent>();
			this.VehicleSkillComponent = base.Entity.GetComponent<VehicleSkillComponent>();
			this.VehicleActorComponent = base.Entity.GetComponent<VehicleActorComponent>();
			return true;
		}

		// Token: 0x0603C1A4 RID: 246180 RVA: 0x0111B63C File Offset: 0x0111983C
		[NullableContext(0)]
		public UniTask<bool> StartBounce([Nullable(1)] BounceParam param)
		{
			VehicleActionComponent.<StartBounce>d__14 <StartBounce>d__;
			<StartBounce>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<StartBounce>d__.<>4__this = this;
			<StartBounce>d__.param = param;
			<StartBounce>d__.<>1__state = -1;
			<StartBounce>d__.<>t__builder.Start<VehicleActionComponent.<StartBounce>d__14>(ref <StartBounce>d__);
			return <StartBounce>d__.<>t__builder.Task;
		}

		// Token: 0x0603C1A5 RID: 246181 RVA: 0x0111B688 File Offset: 0x01119888
		[return: Nullable(0)]
		public UniTask<bool> StartCatapultToTarget(Vector targetLocation, Vector locationOffset, float heightOffset, float gravityMagnitude = 1960f, bool preciseMode = true, int skillId = 0)
		{
			VehicleActionComponent.<StartCatapultToTarget>d__15 <StartCatapultToTarget>d__;
			<StartCatapultToTarget>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<StartCatapultToTarget>d__.<>4__this = this;
			<StartCatapultToTarget>d__.targetLocation = targetLocation;
			<StartCatapultToTarget>d__.locationOffset = locationOffset;
			<StartCatapultToTarget>d__.heightOffset = heightOffset;
			<StartCatapultToTarget>d__.gravityMagnitude = gravityMagnitude;
			<StartCatapultToTarget>d__.preciseMode = preciseMode;
			<StartCatapultToTarget>d__.skillId = skillId;
			<StartCatapultToTarget>d__.<>1__state = -1;
			<StartCatapultToTarget>d__.<>t__builder.Start<VehicleActionComponent.<StartCatapultToTarget>d__15>(ref <StartCatapultToTarget>d__);
			return <StartCatapultToTarget>d__.<>t__builder.Task;
		}

		// Token: 0x0603C1A6 RID: 246182 RVA: 0x0111B700 File Offset: 0x01119900
		[return: Nullable(0)]
		public UniTask<bool> StartCatapult(Entity catapultEntity, IMotorCatapultParam config, int skillId = 0)
		{
			VehicleActionComponent.<StartCatapult>d__16 <StartCatapult>d__;
			<StartCatapult>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<StartCatapult>d__.<>4__this = this;
			<StartCatapult>d__.catapultEntity = catapultEntity;
			<StartCatapult>d__.config = config;
			<StartCatapult>d__.skillId = skillId;
			<StartCatapult>d__.<>1__state = -1;
			<StartCatapult>d__.<>t__builder.Start<VehicleActionComponent.<StartCatapult>d__16>(ref <StartCatapult>d__);
			return <StartCatapult>d__.<>t__builder.Task;
		}

		// Token: 0x0603C1A7 RID: 246183 RVA: 0x0111B75C File Offset: 0x0111995C
		public override bool ClearComponent(EntityComponent componentTemplate)
		{
			if (!base.ClearComponent(componentTemplate))
			{
				return false;
			}
			VehicleActionComponent vehicleActionComponent = (VehicleActionComponent)componentTemplate;
			if (vehicleActionComponent.VehicleCatapultComponent == null)
			{
				this.VehicleCatapultComponent = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.VehicleCatapultComponent), "VehicleCatapultComponent"))
			{
				return false;
			}
			if (vehicleActionComponent.VehicleSkillComponent == null)
			{
				this.VehicleSkillComponent = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.VehicleSkillComponent), "VehicleSkillComponent"))
			{
				return false;
			}
			if (vehicleActionComponent.VehicleActorComponent == null)
			{
				this.VehicleActorComponent = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.VehicleActorComponent), "VehicleActorComponent"))
			{
				return false;
			}
			return true;
		}

		// Token: 0x17007165 RID: 29029
		// (get) Token: 0x0603C1A8 RID: 246184 RVA: 0x0111B7FD File Offset: 0x011199FD
		public override bool NeedStartInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x0401FCD3 RID: 130259
		[Nullable(2)]
		private VehicleCatapultComponent VehicleCatapultComponent;

		// Token: 0x0401FCD4 RID: 130260
		[Nullable(2)]
		private VehicleSkillComponent VehicleSkillComponent;

		// Token: 0x0401FCD5 RID: 130261
		[Nullable(2)]
		private VehicleActorComponent VehicleActorComponent;

		// Token: 0x0401FCD6 RID: 130262
		private const float DEFAULT_CATAPULT_TIME = 0.6f;

		// Token: 0x0401FCD7 RID: 130263
		private const float DEFAULT_CATAPULT_GRAVITY = 1960f;

		// Token: 0x0401FCD8 RID: 130264
		[StaticVariableRuleIgnore]
		private static readonly Vector TmpVector = Vector.Create();

		// Token: 0x0401FCD9 RID: 130265
		[StaticVariableRuleIgnore]
		private static readonly Vector TmpVector2 = Vector.Create();

		// Token: 0x0401FCDA RID: 130266
		[StaticVariableRuleIgnore]
		private static readonly Vector TmpVector3 = Vector.Create();

		// Token: 0x0401FCDB RID: 130267
		[StaticVariableRuleIgnore]
		private static readonly Rotator TmpRotator = Rotator.Create();

		// Token: 0x0401FCDC RID: 130268
		[StaticVariableRuleIgnore]
		private static readonly Quat TmpQuat = Quat.Create(0.0, 0.0, 0.0, 1.0);

		// Token: 0x0401FCDD RID: 130269
		[StaticVariableRuleIgnore]
		private static readonly CatapultToTargetResult CatapultResult = new CatapultToTargetResult();
	}
}
