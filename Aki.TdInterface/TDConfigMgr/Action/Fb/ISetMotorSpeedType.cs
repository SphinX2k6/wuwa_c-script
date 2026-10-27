using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A9F RID: 10911
	public class ISetMotorSpeedType
	{
		// Token: 0x0600EF9E RID: 61342 RVA: 0x0022D3F1 File Offset: 0x0022B5F1
		[NullableContext(1)]
		public static ISetMotorSpeedType Create(ISetMotorSpeedType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISetMotorSpeedType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004C22 RID: 19490
		// (get) Token: 0x0600EF9F RID: 61343 RVA: 0x0022D410 File Offset: 0x0022B610
		public virtual EMotorSpeedType Type
		{
			get
			{
				return (EMotorSpeedType)this.Instance.Type;
			}
		}

		// Token: 0x040083CD RID: 33741
		private ISetMotorSpeedType Instance;
	}
}
