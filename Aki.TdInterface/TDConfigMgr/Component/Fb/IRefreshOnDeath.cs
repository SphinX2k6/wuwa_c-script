using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000AAA RID: 2730
	public class IRefreshOnDeath : IRefreshConditionBase
	{
		// Token: 0x06003EFB RID: 16123 RVA: 0x000A1242 File Offset: 0x0009F442
		[NullableContext(1)]
		public static IRefreshOnDeath Create(IRefreshOnDeath? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IRefreshOnDeath
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17000F64 RID: 3940
		// (get) Token: 0x06003EFC RID: 16124 RVA: 0x000A1261 File Offset: 0x0009F461
		public override ERewardDropType Type
		{
			get
			{
				return (ERewardDropType)this.Instance.Type;
			}
		}

		// Token: 0x040022FB RID: 8955
		private IRefreshOnDeath Instance;
	}
}
