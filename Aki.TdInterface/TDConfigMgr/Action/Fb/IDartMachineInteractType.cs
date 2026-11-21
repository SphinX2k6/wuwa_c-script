using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002B47 RID: 11079
	public class IDartMachineInteractType : IDartInteractTypeBase
	{
		// Token: 0x0600F396 RID: 62358 RVA: 0x00238986 File Offset: 0x00236B86
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

		// Token: 0x170049B6 RID: 18870
		// (get) Token: 0x0600F397 RID: 62359 RVA: 0x002389A5 File Offset: 0x00236BA5
		public override EDartInteractType Type
		{
			get
			{
				return (EDartInteractType)this.Instance.Type;
			}
		}

		// Token: 0x170049B7 RID: 18871
		// (get) Token: 0x0600F398 RID: 62360 RVA: 0x002389B4 File Offset: 0x00236BB4
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

		// Token: 0x170049B8 RID: 18872
		// (get) Token: 0x0600F399 RID: 62361 RVA: 0x00238A18 File Offset: 0x00236C18
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

		// Token: 0x04008597 RID: 34199
		private IDartMachineInteractType Instance;

		// Token: 0x04008598 RID: 34200
		private List<int> _CanInviteCompetitorIdsCache;

		// Token: 0x04008599 RID: 34201
		private bool _CanInviteCompetitorIdsInited;
	}
}
