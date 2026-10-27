using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002AA9 RID: 10921
	public class IMotorParamsChangeConfig
	{
		// Token: 0x0600EFC6 RID: 61382 RVA: 0x0022D882 File Offset: 0x0022BA82
		[NullableContext(1)]
		public static IMotorParamsChangeConfig Create(IMotorParamsChangeConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMotorParamsChangeConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004C36 RID: 19510
		// (get) Token: 0x0600EFC7 RID: 61383 RVA: 0x0022D8A1 File Offset: 0x0022BAA1
		public virtual EMotorParamsChangeType Type
		{
			get
			{
				return (EMotorParamsChangeType)this.Instance.Type;
			}
		}

		// Token: 0x040083EB RID: 33771
		private IMotorParamsChangeConfig Instance;
	}
}
