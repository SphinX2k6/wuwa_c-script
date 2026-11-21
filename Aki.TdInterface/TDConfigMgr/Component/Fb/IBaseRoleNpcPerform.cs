using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000C9C RID: 3228
	public class IBaseRoleNpcPerform : ISpecialNpcPerformType
	{
		// Token: 0x060049D1 RID: 18897 RVA: 0x000B9F75 File Offset: 0x000B8175
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

		// Token: 0x17001494 RID: 5268
		// (get) Token: 0x060049D2 RID: 18898 RVA: 0x000B9F94 File Offset: 0x000B8194
		public override ESpecialNpcType Type
		{
			get
			{
				return (ESpecialNpcType)this.Instance.Type;
			}
		}

		// Token: 0x040029CD RID: 10701
		private IBaseRoleNpcPerform Instance;
	}
}
