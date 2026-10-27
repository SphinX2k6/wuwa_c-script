using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002AAD RID: 10925
	public class IMotorSoarInWindFieldControlType
	{
		// Token: 0x0600EFD9 RID: 61401 RVA: 0x0022DABA File Offset: 0x0022BCBA
		[NullableContext(1)]
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

		// Token: 0x17004C41 RID: 19521
		// (get) Token: 0x0600EFDA RID: 61402 RVA: 0x0022DAD9 File Offset: 0x0022BCD9
		public virtual EMotorSoarInWindFieldControlType Type
		{
			get
			{
				return (EMotorSoarInWindFieldControlType)this.Instance.Type;
			}
		}

		// Token: 0x040083F3 RID: 33779
		private IMotorSoarInWindFieldControlType Instance;
	}
}
