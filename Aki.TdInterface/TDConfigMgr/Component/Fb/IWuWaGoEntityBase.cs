using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000E06 RID: 3590
	public class IWuWaGoEntityBase
	{
		// Token: 0x06005147 RID: 20807 RVA: 0x000C88CD File Offset: 0x000C6ACD
		[NullableContext(1)]
		public static IWuWaGoEntityBase Create(IWuWaGoEntityBase? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IWuWaGoEntityBase
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001AF8 RID: 6904
		// (get) Token: 0x06005148 RID: 20808 RVA: 0x000C88EC File Offset: 0x000C6AEC
		public virtual EWuWaGoEntityType Type
		{
			get
			{
				return (EWuWaGoEntityType)this.Instance.Type;
			}
		}

		// Token: 0x04002EC7 RID: 11975
		private IWuWaGoEntityBase Instance;
	}
}
