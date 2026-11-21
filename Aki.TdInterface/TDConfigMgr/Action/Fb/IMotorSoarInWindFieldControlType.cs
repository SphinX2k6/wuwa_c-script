using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002DA1 RID: 11681
	public class IMotorSoarInWindFieldControlType
	{
		// Token: 0x0600FE8F RID: 65167 RVA: 0x0024B7C6 File Offset: 0x002499C6
		public static IMotorSoarInWindFieldControlType Create(IMotorSoarInWindFieldControlType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMotorSoarInWindFieldControlType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004FFB RID: 20475
		// (get) Token: 0x0600FE90 RID: 65168 RVA: 0x0024B7E5 File Offset: 0x002499E5
		public virtual EMotorSoarInWindFieldControlType Type
		{
			get
			{
				return (EMotorSoarInWindFieldControlType)this.Instance.Type;
			}
		}

		// Token: 0x04008AF7 RID: 35575
		private IMotorSoarInWindFieldControlType Instance;
	}
}
