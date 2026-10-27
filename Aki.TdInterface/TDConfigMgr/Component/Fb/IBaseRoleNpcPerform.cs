using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000BCE RID: 3022
	public class IBaseRoleNpcPerform : ISpecialNpcPerformType
	{
		// Token: 0x06004578 RID: 17784 RVA: 0x000AFEB1 File Offset: 0x000AE0B1
		[NullableContext(1)]
		public static IBaseRoleNpcPerform Create(IBaseRoleNpcPerform? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IBaseRoleNpcPerform
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001399 RID: 5017
		// (get) Token: 0x06004579 RID: 17785 RVA: 0x000AFED0 File Offset: 0x000AE0D0
		public override ESpecialNpcType Type
		{
			get
			{
				return (ESpecialNpcType)this.Instance.Type;
			}
		}

		// Token: 0x04002785 RID: 10117
		private IBaseRoleNpcPerform Instance;
	}
}
