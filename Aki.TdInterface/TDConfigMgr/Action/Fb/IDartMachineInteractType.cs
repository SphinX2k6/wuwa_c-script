using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002871 RID: 10353
	[NullableContext(1)]
	[Nullable(0)]
	public class IDartMachineInteractType : IDartInteractTypeBase
	{
		// Token: 0x0600E566 RID: 58726 RVA: 0x0021BA6A File Offset: 0x00219C6A
		public static IDartMachineInteractType Create(IDartMachineInteractType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IDartMachineInteractType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004646 RID: 17990
		// (get) Token: 0x0600E567 RID: 58727 RVA: 0x0021BA89 File Offset: 0x00219C89
		public override EDartInteractType Type
		{
			get
			{
				return (EDartInteractType)this.Instance.Type;
			}
		}

		// Token: 0x17004647 RID: 17991
		// (get) Token: 0x0600E568 RID: 58728 RVA: 0x0021BA98 File Offset: 0x00219C98
		public virtual List<int> CanInviteCompetitorIds
		{
			get
			{
				if (this._CanInviteCompetitorIdsInited)
				{
					return this._CanInviteCompetitorIdsCache;
				}
				this._CanInviteCompetitorIdsInited = true;
				int canInviteCompetitorIdsLength = this.Instance.CanInviteCompetitorIdsLength;
				this._CanInviteCompetitorIdsCache = new List<int>(canInviteCompetitorIdsLength);
				for (int i = 0; i < canInviteCompetitorIdsLength; i++)
				{
					this._CanInviteCompetitorIdsCache.Add(this.Instance.CanInviteCompetitorIds(i));
				}
				return this._CanInviteCompetitorIdsCache;
			}
		}

		// Token: 0x17004648 RID: 17992
		// (get) Token: 0x0600E569 RID: 58729 RVA: 0x0021BAFC File Offset: 0x00219CFC
		public virtual int? ChampionId
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new int?(this.Instance.ChampionId);
			}
		}

		// Token: 0x04007ED7 RID: 32471
		private IDartMachineInteractType Instance;

		// Token: 0x04007ED8 RID: 32472
		private List<int> _CanInviteCompetitorIdsCache;

		// Token: 0x04007ED9 RID: 32473
		private bool _CanInviteCompetitorIdsInited;
	}
}
