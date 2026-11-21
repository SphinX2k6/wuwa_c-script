using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002DA3 RID: 11683
	public class IMotorSoarInWindFieldExitWindField : IMotorSoarInWindFieldControlType
	{
		// Token: 0x0600FE9B RID: 65179 RVA: 0x0024B8CA File Offset: 0x00249ACA
		public static IMotorSoarInWindFieldExitWindField Create(IMotorSoarInWindFieldExitWindField? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMotorSoarInWindFieldExitWindField
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17005003 RID: 20483
		// (get) Token: 0x0600FE9C RID: 65180 RVA: 0x0024B8E9 File Offset: 0x00249AE9
		public override EMotorSoarInWindFieldControlType Type
		{
			get
			{
				return (EMotorSoarInWindFieldControlType)this.Instance.Type;
			}
		}

		// Token: 0x04008AFD RID: 35581
		private IMotorSoarInWindFieldExitWindField Instance;
	}
}
