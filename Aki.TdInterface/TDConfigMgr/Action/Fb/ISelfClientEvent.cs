using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002D2C RID: 11564
	public class ISelfClientEvent : IClientEventTarget
	{
		// Token: 0x0600FCBC RID: 64700 RVA: 0x00248915 File Offset: 0x00246B15
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

		// Token: 0x17004F12 RID: 20242
		// (get) Token: 0x0600FCBD RID: 64701 RVA: 0x00248934 File Offset: 0x00246B34
		public override EClientEventTarget Type
		{
			get
			{
				return (EClientEventTarget)this.Instance.Type;
			}
		}

		// Token: 0x04008A00 RID: 35328
		private ISelfClientEvent Instance;
	}
}
