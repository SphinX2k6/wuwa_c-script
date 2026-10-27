using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002ABD RID: 10941
	public class TriggerSystemRandomPlot : ActionParams
	{
		// Token: 0x0600F021 RID: 61473 RVA: 0x0022E168 File Offset: 0x0022C368
		[NullableContext(1)]
		public static TriggerSystemRandomPlot Create(ITriggerSystemRandomPlot? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new TriggerSystemRandomPlot
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004C69 RID: 19561
		// (get) Token: 0x0600F022 RID: 61474 RVA: 0x0022E187 File Offset: 0x0022C387
		public virtual int Id
		{
			get
			{
				return this.Instance.Id;
			}
		}

		// Token: 0x04008417 RID: 33815
		private ITriggerSystemRandomPlot Instance;
	}
}
