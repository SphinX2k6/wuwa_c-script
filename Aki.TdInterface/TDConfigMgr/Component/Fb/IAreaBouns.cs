using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000B62 RID: 2914
	public class IAreaBouns : IWorldLevelBonusType
	{
		// Token: 0x06004288 RID: 17032 RVA: 0x000A8FFB File Offset: 0x000A71FB
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

		// Token: 0x17000FBF RID: 4031
		// (get) Token: 0x06004289 RID: 17033 RVA: 0x000A901A File Offset: 0x000A721A
		public override EWorldLevelBonus Type
		{
			get
			{
				return (EWorldLevelBonus)this.Instance.Type;
			}
		}

		// Token: 0x040024DB RID: 9435
		private IAreaBouns Instance;
	}
}
