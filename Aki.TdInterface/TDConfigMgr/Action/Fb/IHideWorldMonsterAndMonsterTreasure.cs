using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A5C RID: 10844
	public class IHideWorldMonsterAndMonsterTreasure : IHideRangeType
	{
		// Token: 0x0600EF7C RID: 61308 RVA: 0x00231AF3 File Offset: 0x0022FCF3
		public static IHideWorldMonsterAndMonsterTreasure Create(IHideWorldMonsterAndMonsterTreasure? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IHideWorldMonsterAndMonsterTreasure
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004772 RID: 18290
		// (get) Token: 0x0600EF7D RID: 61309 RVA: 0x00231B12 File Offset: 0x0022FD12
		public override EHideType Type
		{
			get
			{
				return (EHideType)this.Instance.Type;
			}
		}

		// Token: 0x040083A4 RID: 33700
		private IHideWorldMonsterAndMonsterTreasure Instance;
	}
}
