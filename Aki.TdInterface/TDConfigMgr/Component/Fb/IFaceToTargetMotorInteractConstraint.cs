using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000B13 RID: 2835
	[NullableContext(1)]
	[Nullable(0)]
	public class IFaceToTargetMotorInteractConstraint : IMotorInteractConstraintType
	{
		// Token: 0x0600417A RID: 16762 RVA: 0x000A815D File Offset: 0x000A635D
		public static IFaceToTargetMotorInteractConstraint Create(IFaceToTargetMotorInteractConstraint? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFaceToTargetMotorInteractConstraint
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001111 RID: 4369
		// (get) Token: 0x0600417B RID: 16763 RVA: 0x000A817C File Offset: 0x000A637C
		public override EMotorInteractConstraintType Type
		{
			get
			{
				return (EMotorInteractConstraintType)this.Instance.Type;
			}
		}

		// Token: 0x17001112 RID: 4370
		// (get) Token: 0x0600417C RID: 16764 RVA: 0x000A8189 File Offset: 0x000A6389
		public virtual ITargetEntityType Target
		{
			get
			{
				if (this._TargetInited)
				{
					return this._TargetCache;
				}
				this._TargetInited = true;
				this._TargetCache = ComponentReadHelper.ReadIFaceToTargetMotorInteractConstraint_Target(this.Instance);
				return this._TargetCache;
			}
		}

		// Token: 0x17001113 RID: 4371
		// (get) Token: 0x0600417D RID: 16765 RVA: 0x000A81B8 File Offset: 0x000A63B8
		public virtual float Angle
		{
			get
			{
				return this.Instance.Angle;
			}
		}

		// Token: 0x040024E4 RID: 9444
		private IFaceToTargetMotorInteractConstraint Instance;

		// Token: 0x040024E5 RID: 9445
		private ITargetEntityType _TargetCache;

		// Token: 0x040024E6 RID: 9446
		private bool _TargetInited;
	}
}
