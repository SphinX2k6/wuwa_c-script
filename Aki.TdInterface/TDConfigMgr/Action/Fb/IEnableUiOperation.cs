using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002951 RID: 10577
	public class IEnableUiOperation : IUiOperationType
	{
		// Token: 0x0600EA86 RID: 60038 RVA: 0x0022573E File Offset: 0x0022393E
		[NullableContext(1)]
		public static IEnableUiOperation Create(IEnableUiOperation? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IEnableUiOperation
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170049A6 RID: 18854
		// (get) Token: 0x0600EA87 RID: 60039 RVA: 0x0022575D File Offset: 0x0022395D
		public override EUiOperationType Type
		{
			get
			{
				return (EUiOperationType)this.Instance.Type;
			}
		}

		// Token: 0x04008141 RID: 33089
		private IEnableUiOperation Instance;
	}
}
