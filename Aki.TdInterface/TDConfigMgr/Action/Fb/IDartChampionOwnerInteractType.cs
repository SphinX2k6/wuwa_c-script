using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002872 RID: 10354
	public class IDartChampionOwnerInteractType : IDartInteractTypeBase
	{
		// Token: 0x0600E56B RID: 58731 RVA: 0x0021BB3A File Offset: 0x00219D3A
		[NullableContext(1)]
		public static IDartChampionOwnerInteractType Create(IDartChampionOwnerInteractType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IDartChampionOwnerInteractType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004649 RID: 17993
		// (get) Token: 0x0600E56C RID: 58732 RVA: 0x0021BB59 File Offset: 0x00219D59
		public override EDartInteractType Type
		{
			get
			{
				return (EDartInteractType)this.Instance.Type;
			}
		}

		// Token: 0x1700464A RID: 17994
		// (get) Token: 0x0600E56D RID: 58733 RVA: 0x0021BB66 File Offset: 0x00219D66
		public virtual int CompetitorId
		{
			get
			{
				return this.Instance.CompetitorId;
			}
		}

		// Token: 0x04007EDA RID: 32474
		private IDartChampionOwnerInteractType Instance;
	}
}
