using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000BE0 RID: 3040
	public class IMotorInteractConstraintType
	{
		// Token: 0x060045CD RID: 17869 RVA: 0x000B2155 File Offset: 0x000B0355
		public static IMotorInteractConstraintType Create(IMotorInteractConstraintType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMotorInteractConstraintType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001208 RID: 4616
		// (get) Token: 0x060045CE RID: 17870 RVA: 0x000B2174 File Offset: 0x000B0374
		public virtual EMotorInteractConstraintType Type
		{
			get
			{
				return (EMotorInteractConstraintType)this.Instance.Type;
			}
		}

		// Token: 0x04002727 RID: 10023
		private IMotorInteractConstraintType Instance;
	}
}
