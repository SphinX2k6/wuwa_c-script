using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002AAF RID: 10927
	public class IMotorSoarInWindFieldExitWindField : IMotorSoarInWindFieldControlType
	{
		// Token: 0x0600EFE5 RID: 61413 RVA: 0x0022DBBE File Offset: 0x0022BDBE
		[NullableContext(1)]
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

		// Token: 0x17004C49 RID: 19529
		// (get) Token: 0x0600EFE6 RID: 61414 RVA: 0x0022DBDD File Offset: 0x0022BDDD
		public override EMotorSoarInWindFieldControlType Type
		{
			get
			{
				return (EMotorSoarInWindFieldControlType)this.Instance.Type;
			}
		}

		// Token: 0x040083F9 RID: 33785
		private IMotorSoarInWindFieldExitWindField Instance;
	}
}
