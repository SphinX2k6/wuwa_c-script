using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200292E RID: 10542
	public class RecoverDurability : ActionParams
	{
		// Token: 0x0600E9EB RID: 59883 RVA: 0x002245B7 File Offset: 0x002227B7
		[NullableContext(1)]
		public static RecoverDurability Create(IRecoverDurability? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new RecoverDurability
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004951 RID: 18769
		// (get) Token: 0x0600E9EC RID: 59884 RVA: 0x002245D6 File Offset: 0x002227D6
		public virtual int EntityId
		{
			get
			{
				return this.Instance.EntityId;
			}
		}

		// Token: 0x04008108 RID: 33032
		private IRecoverDurability Instance;
	}
}
