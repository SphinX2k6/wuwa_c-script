using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020028CF RID: 10447
	[NullableContext(2)]
	[Nullable(0)]
	public class ChangePhantomFormation : ActionParams
	{
		// Token: 0x0600E808 RID: 59400 RVA: 0x00220F1A File Offset: 0x0021F11A
		[NullableContext(1)]
		public static ChangePhantomFormation Create(IChangePhantomFormation? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ChangePhantomFormation
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700482C RID: 18476
		// (get) Token: 0x0600E809 RID: 59401 RVA: 0x00220F39 File Offset: 0x0021F139
		public virtual int FormationId
		{
			get
			{
				return this.Instance.FormationId;
			}
		}

		// Token: 0x1700482D RID: 18477
		// (get) Token: 0x0600E80A RID: 59402 RVA: 0x00220F48 File Offset: 0x0021F148
		public virtual bool? RetainRole
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.RetainRole);
			}
		}

		// Token: 0x1700482E RID: 18478
		// (get) Token: 0x0600E80B RID: 59403 RVA: 0x00220F80 File Offset: 0x0021F180
		public virtual int? TeleportEntityId
		{
			get
			{
				if ((this.Instance.NullMask & 2) == 0)
				{
					return null;
				}
				return new int?(this.Instance.TeleportEntityId);
			}
		}

		// Token: 0x1700482F RID: 18479
		// (get) Token: 0x0600E80C RID: 59404 RVA: 0x00220FB8 File Offset: 0x0021F1B8
		public virtual List<long> AppendBuffIds
		{
			get
			{
				if (this._AppendBuffIdsInited)
				{
					return this._AppendBuffIdsCache;
				}
				this._AppendBuffIdsInited = true;
				if ((this.Instance.NullMask & 4) == 0)
				{
					return null;
				}
				int appendBuffIdsLength = this.Instance.AppendBuffIdsLength;
				this._AppendBuffIdsCache = new List<long>(appendBuffIdsLength);
				for (int i = 0; i < appendBuffIdsLength; i++)
				{
					this._AppendBuffIdsCache.Add(this.Instance.AppendBuffIds(i));
				}
				return this._AppendBuffIdsCache;
			}
		}

		// Token: 0x04008047 RID: 32839
		private IChangePhantomFormation Instance;

		// Token: 0x04008048 RID: 32840
		private List<long> _AppendBuffIdsCache;

		// Token: 0x04008049 RID: 32841
		private bool _AppendBuffIdsInited;
	}
}
