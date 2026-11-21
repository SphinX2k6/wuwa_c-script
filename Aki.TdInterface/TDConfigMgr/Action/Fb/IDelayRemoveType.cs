using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002CD5 RID: 11477
	public class IDelayRemoveType
	{
		// Token: 0x0600FB83 RID: 64387 RVA: 0x00246D64 File Offset: 0x00244F64
		public static IDelayRemoveType Create(IDelayRemoveType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IDelayRemoveType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004E87 RID: 20103
		// (get) Token: 0x0600FB84 RID: 64388 RVA: 0x00246D83 File Offset: 0x00244F83
		public virtual EDelayRemoveType Type
		{
			get
			{
				return (EDelayRemoveType)this.Instance.Type;
			}
		}

		// Token: 0x0400896D RID: 35181
		private IDelayRemoveType Instance;
	}
}
