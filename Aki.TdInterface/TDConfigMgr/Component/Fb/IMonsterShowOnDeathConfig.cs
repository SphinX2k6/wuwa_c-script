using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000C16 RID: 3094
	public class IMonsterShowOnDeathConfig
	{
		// Token: 0x060046FD RID: 18173 RVA: 0x000B2F04 File Offset: 0x000B1104
		[NullableContext(1)]
		public static IMonsterShowOnDeathConfig Create(IMonsterShowOnDeathConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMonsterShowOnDeathConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700148E RID: 5262
		// (get) Token: 0x060046FE RID: 18174 RVA: 0x000B2F23 File Offset: 0x000B1123
		public virtual EMonsterShowOnDeathType Type
		{
			get
			{
				return (EMonsterShowOnDeathType)this.Instance.Type;
			}
		}

		// Token: 0x0400284F RID: 10319
		private IMonsterShowOnDeathConfig Instance;
	}
}
