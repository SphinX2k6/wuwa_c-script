using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200278A RID: 10122
	public class IHideWorldMonsterAndMonsterTreasure : IHideRangeType
	{
		// Token: 0x0600E15E RID: 57694 RVA: 0x00214D5F File Offset: 0x00212F5F
		[NullableContext(1)]
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

		// Token: 0x1700440C RID: 17420
		// (get) Token: 0x0600E15F RID: 57695 RVA: 0x00214D7E File Offset: 0x00212F7E
		public override EHideType Type
		{
			get
			{
				return (EHideType)this.Instance.Type;
			}
		}

		// Token: 0x04007CEE RID: 31982
		private IHideWorldMonsterAndMonsterTreasure Instance;
	}
}
