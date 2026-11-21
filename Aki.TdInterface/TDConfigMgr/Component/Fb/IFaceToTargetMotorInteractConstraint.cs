using System;
using Aki.TDConfigMgr.Action;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000BE1 RID: 3041
	public class IFaceToTargetMotorInteractConstraint : IMotorInteractConstraintType
	{
		// Token: 0x060045D0 RID: 17872 RVA: 0x000B2189 File Offset: 0x000B0389
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

		// Token: 0x17001209 RID: 4617
		// (get) Token: 0x060045D1 RID: 17873 RVA: 0x000B21A8 File Offset: 0x000B03A8
		public override EMotorInteractConstraintType Type
		{
			get
			{
				return (EMotorInteractConstraintType)this.Instance.Type;
			}
		}

		// Token: 0x1700120A RID: 4618
		// (get) Token: 0x060045D2 RID: 17874 RVA: 0x000B21B5 File Offset: 0x000B03B5
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

		// Token: 0x1700120B RID: 4619
		// (get) Token: 0x060045D3 RID: 17875 RVA: 0x000B21E4 File Offset: 0x000B03E4
		public virtual float Angle
		{
			get
			{
				return this.Instance.Angle;
			}
		}

		// Token: 0x04002728 RID: 10024
		private IFaceToTargetMotorInteractConstraint Instance;

		// Token: 0x04002729 RID: 10025
		private ITargetEntityType _TargetCache;

		// Token: 0x0400272A RID: 10026
		private bool _TargetInited;
	}
}
