using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000B12 RID: 2834
	public class IMotorInteractConstraintType
	{
		// Token: 0x06004177 RID: 16759 RVA: 0x000A8129 File Offset: 0x000A6329
		[NullableContext(1)]
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

		// Token: 0x17001110 RID: 4368
		// (get) Token: 0x06004178 RID: 16760 RVA: 0x000A8148 File Offset: 0x000A6348
		public virtual EMotorInteractConstraintType Type
		{
			get
			{
				return (EMotorInteractConstraintType)this.Instance.Type;
			}
		}

		// Token: 0x040024E3 RID: 9443
		private IMotorInteractConstraintType Instance;
	}
}
