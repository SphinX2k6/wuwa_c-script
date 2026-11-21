using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002D9D RID: 11677
	public class IMotorParamsChangeConfig
	{
		// Token: 0x0600FE7C RID: 65148 RVA: 0x0024B58E File Offset: 0x0024978E
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

		// Token: 0x17004FF0 RID: 20464
		// (get) Token: 0x0600FE7D RID: 65149 RVA: 0x0024B5AD File Offset: 0x002497AD
		public virtual EMotorParamsChangeType Type
		{
			get
			{
				return (EMotorParamsChangeType)this.Instance.Type;
			}
		}

		// Token: 0x04008AEF RID: 35567
		private IMotorParamsChangeConfig Instance;
	}
}
