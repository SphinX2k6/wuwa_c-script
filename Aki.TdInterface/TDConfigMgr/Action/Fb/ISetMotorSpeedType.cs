using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002D93 RID: 11667
	public class ISetMotorSpeedType
	{
		// Token: 0x0600FE54 RID: 65108 RVA: 0x0024B0FD File Offset: 0x002492FD
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

		// Token: 0x17004FDC RID: 20444
		// (get) Token: 0x0600FE55 RID: 65109 RVA: 0x0024B11C File Offset: 0x0024931C
		public virtual EMotorSpeedType Type
		{
			get
			{
				return (EMotorSpeedType)this.Instance.Type;
			}
		}

		// Token: 0x04008AD1 RID: 35537
		private ISetMotorSpeedType Instance;
	}
}
