using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000AD9 RID: 2777
	public class IAkEventTypeConfig
	{
		// Token: 0x06003FFA RID: 16378 RVA: 0x000A3866 File Offset: 0x000A1A66
		[NullableContext(1)]
		public static IAkEventTypeConfig Create(IAkEventTypeConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IAkEventTypeConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001005 RID: 4101
		// (get) Token: 0x06003FFB RID: 16379 RVA: 0x000A3885 File Offset: 0x000A1A85
		public virtual EAkEventType Type
		{
			get
			{
				return (EAkEventType)this.Instance.Type;
			}
		}

		// Token: 0x0400239E RID: 9118
		private IAkEventTypeConfig Instance;
	}
}
