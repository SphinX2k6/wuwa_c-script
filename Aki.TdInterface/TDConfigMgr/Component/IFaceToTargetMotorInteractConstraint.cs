using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020003B1 RID: 945
	public class IFaceToTargetMotorInteractConstraint : IMotorInteractConstraintType
	{
		// Token: 0x06001293 RID: 4755 RVA: 0x0003DEB0 File Offset: 0x0003C0B0
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

		// Token: 0x06001294 RID: 4756 RVA: 0x0003DEE8 File Offset: 0x0003C0E8
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

		// Token: 0x06001295 RID: 4757 RVA: 0x0003DEFB File Offset: 0x0003C0FB
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

		// Token: 0x06001296 RID: 4758 RVA: 0x0003DF0E File Offset: 0x0003C10E
		public new IFaceToTargetMotorInteractConstraint_SetValue ToSetValue()
		{
			return new IFaceToTargetMotorInteractConstraint_SetValue
			{
				Type = this.Type,
				Target = this.Target,
				Angle = this.Angle
			};
		}

		// Token: 0x1700053D RID: 1341
		// (get) Token: 0x06001297 RID: 4759 RVA: 0x0003DF39 File Offset: 0x0003C139
		// (set) Token: 0x06001298 RID: 4760 RVA: 0x0003DF64 File Offset: 0x0003C164
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

		// Token: 0x1700053E RID: 1342
		// (get) Token: 0x06001299 RID: 4761 RVA: 0x0003DF72 File Offset: 0x0003C172
		// (set) Token: 0x0600129A RID: 4762 RVA: 0x0003DF99 File Offset: 0x0003C199
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

		// Token: 0x1700053F RID: 1343
		// (get) Token: 0x0600129B RID: 4763 RVA: 0x0003DFA7 File Offset: 0x0003C1A7
		// (set) Token: 0x0600129C RID: 4764 RVA: 0x0003DFD6 File Offset: 0x0003C1D6
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

		// Token: 0x04000F3F RID: 3903
		[Nullable(2)]
		protected new IFaceToTargetMotorInteractConstraint FbInstance;

		// Token: 0x04000F40 RID: 3904
		[Nullable(2)]
		protected new IFaceToTargetMotorInteractConstraint_SetValue PocoInterface;
	}
}
