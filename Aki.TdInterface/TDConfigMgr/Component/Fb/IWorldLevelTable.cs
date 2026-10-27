using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000A99 RID: 2713
	public class IWorldLevelTable : IWorldLevelBonusType
	{
		// Token: 0x06003E62 RID: 15970 RVA: 0x0009FA77 File Offset: 0x0009DC77
		[NullableContext(1)]
		public static IWorldLevelTable Create(IWorldLevelTable? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IWorldLevelTable
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17000EED RID: 3821
		// (get) Token: 0x06003E63 RID: 15971 RVA: 0x0009FA96 File Offset: 0x0009DC96
		public override EWorldLevelBonus Type
		{
			get
			{
				return (EWorldLevelBonus)this.Instance.Type;
			}
		}

		// Token: 0x17000EEE RID: 3822
		// (get) Token: 0x06003E64 RID: 15972 RVA: 0x0009FAA4 File Offset: 0x0009DCA4
		public virtual int? WorldLevelBonusId
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new int?(this.Instance.WorldLevelBonusId);
			}
		}

		// Token: 0x040022C0 RID: 8896
		private IWorldLevelTable Instance;
	}
}
