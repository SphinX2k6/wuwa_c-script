using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x0200144A RID: 5194
	public class ISaveNew : ISaveConfigType
	{
		// Token: 0x0600761B RID: 30235 RVA: 0x0011A1E5 File Offset: 0x001183E5
		[NullableContext(1)]
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

		// Token: 0x1700275A RID: 10074
		// (get) Token: 0x0600761C RID: 30236 RVA: 0x0011A204 File Offset: 0x00118404
		public override ESaveConfig Type
		{
			get
			{
				return (ESaveConfig)this.Instance.Type;
			}
		}

		// Token: 0x04004492 RID: 17554
		private ISaveNew Instance;
	}
}
