using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002AB9 RID: 10937
	public class IDeadeyeFadeOutConfig
	{
		// Token: 0x0600F009 RID: 61449 RVA: 0x0022DE89 File Offset: 0x0022C089
		[NullableContext(1)]
		public static IDeadeyeFadeOutConfig Create(IDeadeyeFadeOutConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IDeadeyeFadeOutConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004C59 RID: 19545
		// (get) Token: 0x0600F00A RID: 61450 RVA: 0x0022DEA8 File Offset: 0x0022C0A8
		public virtual float TransitionTime
		{
			get
			{
				return this.Instance.TransitionTime;
			}
		}

		// Token: 0x04008407 RID: 33799
		private IDeadeyeFadeOutConfig Instance;
	}
}
