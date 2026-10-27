using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000368 RID: 872
	[NullableContext(1)]
	[Nullable(0)]
	public class IFaceToTargetMotorInteractConstraint : IMotorInteractConstraintType
	{
		// Token: 0x0600114F RID: 4431 RVA: 0x0003ABCC File Offset: 0x00038DCC
		private IFaceToTargetMotorInteractConstraint_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IFaceToTargetMotorInteractConstraint 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IFaceToTargetMotorInteractConstraint_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IFaceToTargetMotorInteractConstraint_SetValue());
			}
			return result;
		}

		// Token: 0x06001150 RID: 4432 RVA: 0x0003AC04 File Offset: 0x00038E04
		public static IFaceToTargetMotorInteractConstraint Create([Nullable(2)] IFaceToTargetMotorInteractConstraint instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFaceToTargetMotorInteractConstraint
			{
				FbInstance = instance
			};
		}

		// Token: 0x06001151 RID: 4433 RVA: 0x0003AC17 File Offset: 0x00038E17
		public static IFaceToTargetMotorInteractConstraint CreateFromSetValue([Nullable(2)] IFaceToTargetMotorInteractConstraint_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IFaceToTargetMotorInteractConstraint
			{
				PocoInterface = value
			};
		}

		// Token: 0x06001152 RID: 4434 RVA: 0x0003AC2A File Offset: 0x00038E2A
		public new IFaceToTargetMotorInteractConstraint_SetValue ToSetValue()
		{
			return new IFaceToTargetMotorInteractConstraint_SetValue
			{
				Type = this.Type,
				Target = this.Target,
				Angle = this.Angle
			};
		}

		// Token: 0x170004E9 RID: 1257
		// (get) Token: 0x06001153 RID: 4435 RVA: 0x0003AC55 File Offset: 0x00038E55
		// (set) Token: 0x06001154 RID: 4436 RVA: 0x0003AC80 File Offset: 0x00038E80
		public override EMotorInteractConstraintType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EMotorInteractConstraintType.FaceToTarget;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x170004EA RID: 1258
		// (get) Token: 0x06001155 RID: 4437 RVA: 0x0003AC8E File Offset: 0x00038E8E
		// (set) Token: 0x06001156 RID: 4438 RVA: 0x0003ACB5 File Offset: 0x00038EB5
		public virtual ITargetEntityType Target
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Target;
				}
				IFaceToTargetMotorInteractConstraint_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Target;
			}
			set
			{
				this.GetOrCreatePoco().Target = value;
			}
		}

		// Token: 0x170004EB RID: 1259
		// (get) Token: 0x06001157 RID: 4439 RVA: 0x0003ACC3 File Offset: 0x00038EC3
		// (set) Token: 0x06001158 RID: 4440 RVA: 0x0003ACF2 File Offset: 0x00038EF2
		public virtual float Angle
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Angle;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.Angle;
			}
			set
			{
				this.GetOrCreatePoco().Angle = value;
			}
		}

		// Token: 0x04000E48 RID: 3656
		[Nullable(2)]
		protected new IFaceToTargetMotorInteractConstraint FbInstance;

		// Token: 0x04000E49 RID: 3657
		[Nullable(2)]
		protected new IFaceToTargetMotorInteractConstraint_SetValue PocoInterface;
	}
}
