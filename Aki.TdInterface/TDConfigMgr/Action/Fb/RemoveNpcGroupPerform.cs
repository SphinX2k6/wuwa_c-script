using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A63 RID: 10851
	[NullableContext(1)]
	[Nullable(0)]
	public class RemoveNpcGroupPerform : ActionParams
	{
		// Token: 0x0600EEAE RID: 61102 RVA: 0x0022BA96 File Offset: 0x00229C96
		public static RemoveNpcGroupPerform Create(IRemoveNpcGroupPerform? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new RemoveNpcGroupPerform
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004BAA RID: 19370
		// (get) Token: 0x0600EEAF RID: 61103 RVA: 0x0022BAB5 File Offset: 0x00229CB5
		public virtual string Key
		{
			get
			{
				return this.Instance.Key;
			}
		}

		// Token: 0x0400834D RID: 33613
		private IRemoveNpcGroupPerform Instance;
	}
}
