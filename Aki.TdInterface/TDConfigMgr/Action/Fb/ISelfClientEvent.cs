using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A3F RID: 10815
	public class ISelfClientEvent : IClientEventTarget
	{
		// Token: 0x0600EE24 RID: 60964 RVA: 0x0022AF61 File Offset: 0x00229161
		[NullableContext(1)]
		public static ISelfClientEvent Create(ISelfClientEvent? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISelfClientEvent
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004B68 RID: 19304
		// (get) Token: 0x0600EE25 RID: 60965 RVA: 0x0022AF80 File Offset: 0x00229180
		public override EClientEventTarget Type
		{
			get
			{
				return (EClientEventTarget)this.Instance.Type;
			}
		}

		// Token: 0x0400830D RID: 33549
		private ISelfClientEvent Instance;
	}
}
