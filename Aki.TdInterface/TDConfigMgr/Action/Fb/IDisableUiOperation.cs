using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002952 RID: 10578
	public class IDisableUiOperation : IUiOperationType
	{
		// Token: 0x0600EA89 RID: 60041 RVA: 0x00225772 File Offset: 0x00223972
		[NullableContext(1)]
		public static IDisableUiOperation Create(IDisableUiOperation? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IDisableUiOperation
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170049A7 RID: 18855
		// (get) Token: 0x0600EA8A RID: 60042 RVA: 0x00225791 File Offset: 0x00223991
		public override EUiOperationType Type
		{
			get
			{
				return (EUiOperationType)this.Instance.Type;
			}
		}

		// Token: 0x04008142 RID: 33090
		private IDisableUiOperation Instance;
	}
}
