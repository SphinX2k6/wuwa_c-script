using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200293C RID: 10556
	public class IClientEnableAllPlayerOperation : ClientSetPlayerOperationRestriction
	{
		// Token: 0x0600EA1E RID: 59934 RVA: 0x00224A0E File Offset: 0x00222C0E
		[NullableContext(1)]
		public static IClientEnableAllPlayerOperation Create(IClientEnableAllPlayerOperation? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IClientEnableAllPlayerOperation
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004968 RID: 18792
		// (get) Token: 0x0600EA1F RID: 59935 RVA: 0x00224A2D File Offset: 0x00222C2D
		public override EPlayerOperationType Type
		{
			get
			{
				return (EPlayerOperationType)this.Instance.Type;
			}
		}

		// Token: 0x0400811A RID: 33050
		private IClientEnableAllPlayerOperation Instance;
	}
}
