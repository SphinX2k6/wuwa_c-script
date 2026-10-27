using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000A98 RID: 2712
	public class IAreaBouns : IWorldLevelBonusType
	{
		// Token: 0x06003E5F RID: 15967 RVA: 0x0009FA43 File Offset: 0x0009DC43
		[NullableContext(1)]
		public static IAreaBouns Create(IAreaBouns? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IAreaBouns
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17000EEC RID: 3820
		// (get) Token: 0x06003E60 RID: 15968 RVA: 0x0009FA62 File Offset: 0x0009DC62
		public override EWorldLevelBonus Type
		{
			get
			{
				return (EWorldLevelBonus)this.Instance.Type;
			}
		}

		// Token: 0x040022BF RID: 8895
		private IAreaBouns Instance;
	}
}
