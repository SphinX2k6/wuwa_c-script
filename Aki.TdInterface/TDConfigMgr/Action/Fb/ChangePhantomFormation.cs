using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002BA4 RID: 11172
	[NullableContext(2)]
	[Nullable(0)]
	public class ChangePhantomFormation : ActionParams
	{
		// Token: 0x0600F637 RID: 63031 RVA: 0x0023DE9A File Offset: 0x0023C09A
		[NullableContext(0)]
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

		// Token: 0x17004B9D RID: 19357
		// (get) Token: 0x0600F638 RID: 63032 RVA: 0x0023DEB9 File Offset: 0x0023C0B9
		public virtual int FormationId
		{
			get
			{
				return this.Instance.FormationId;
			}
		}

		// Token: 0x17004B9E RID: 19358
		// (get) Token: 0x0600F639 RID: 63033 RVA: 0x0023DEC8 File Offset: 0x0023C0C8
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

		// Token: 0x17004B9F RID: 19359
		// (get) Token: 0x0600F63A RID: 63034 RVA: 0x0023DF00 File Offset: 0x0023C100
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

		// Token: 0x17004BA0 RID: 19360
		// (get) Token: 0x0600F63B RID: 63035 RVA: 0x0023DF38 File Offset: 0x0023C138
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

		// Token: 0x04008706 RID: 34566
		private IChangePhantomFormation Instance;

		// Token: 0x04008707 RID: 34567
		private List<long> _AppendBuffIdsCache;

		// Token: 0x04008708 RID: 34568
		private bool _AppendBuffIdsInited;
	}
}
