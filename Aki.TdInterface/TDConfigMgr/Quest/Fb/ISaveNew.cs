using System;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x020015A2 RID: 5538
	public class ISaveNew : ISaveConfigType
	{
		// Token: 0x06007CE3 RID: 31971 RVA: 0x00128CB9 File Offset: 0x00126EB9
		public static ISaveNew Create(ISaveNew? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISaveNew
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17002941 RID: 10561
		// (get) Token: 0x06007CE4 RID: 31972 RVA: 0x00128CD8 File Offset: 0x00126ED8
		public override ESaveConfig Type
		{
			get
			{
				return (ESaveConfig)this.Instance.Type;
			}
		}

		// Token: 0x04004828 RID: 18472
		private ISaveNew Instance;
	}
}
