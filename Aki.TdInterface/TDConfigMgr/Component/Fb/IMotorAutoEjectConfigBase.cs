using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000B0B RID: 2827
	public class IMotorAutoEjectConfigBase
	{
		// Token: 0x06004150 RID: 16720 RVA: 0x000A7C4A File Offset: 0x000A5E4A
		[NullableContext(1)]
		public static IMotorAutoEjectConfigBase Create(IMotorAutoEjectConfigBase? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMotorAutoEjectConfigBase
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170010F7 RID: 4343
		// (get) Token: 0x06004151 RID: 16721 RVA: 0x000A7C69 File Offset: 0x000A5E69
		public virtual EMotorAutoEjectType Type
		{
			get
			{
				return (EMotorAutoEjectType)this.Instance.Type;
			}
		}

		// Token: 0x040024CC RID: 9420
		private IMotorAutoEjectConfigBase Instance;
	}
}
