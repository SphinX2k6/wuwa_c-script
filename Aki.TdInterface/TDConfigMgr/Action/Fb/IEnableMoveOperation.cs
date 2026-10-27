using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002940 RID: 10560
	public class IEnableMoveOperation : IMoveOperationType
	{
		// Token: 0x0600EA30 RID: 59952 RVA: 0x00224C01 File Offset: 0x00222E01
		[NullableContext(1)]
		public static IEnableMoveOperation Create(IEnableMoveOperation? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IEnableMoveOperation
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004972 RID: 18802
		// (get) Token: 0x0600EA31 RID: 59953 RVA: 0x00224C20 File Offset: 0x00222E20
		public override EMoveOperationType Type
		{
			get
			{
				return (EMoveOperationType)this.Instance.Type;
			}
		}

		// Token: 0x04008128 RID: 33064
		private IEnableMoveOperation Instance;
	}
}
