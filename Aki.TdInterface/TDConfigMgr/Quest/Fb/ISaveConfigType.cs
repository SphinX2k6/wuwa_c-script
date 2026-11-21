using System;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x020015A1 RID: 5537
	public class ISaveConfigType
	{
		// Token: 0x06007CE0 RID: 31968 RVA: 0x00128C85 File Offset: 0x00126E85
		public static ISaveConfigType Create(ISaveConfigType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISaveConfigType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17002940 RID: 10560
		// (get) Token: 0x06007CE1 RID: 31969 RVA: 0x00128CA4 File Offset: 0x00126EA4
		public virtual ESaveConfig Type
		{
			get
			{
				return (ESaveConfig)this.Instance.Type;
			}
		}

		// Token: 0x04004827 RID: 18471
		private ISaveConfigType Instance;
	}
}
