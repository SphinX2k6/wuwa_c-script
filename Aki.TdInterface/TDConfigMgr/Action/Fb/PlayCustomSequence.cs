using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020025D7 RID: 9687
	[NullableContext(1)]
	[Nullable(0)]
	public class PlayCustomSequence : ActionParams
	{
		// Token: 0x0600D9C5 RID: 55749 RVA: 0x002079E7 File Offset: 0x00205BE7
		public static PlayCustomSequence Create(IPlayCustomSequence? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new PlayCustomSequence
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003FD9 RID: 16345
		// (get) Token: 0x0600D9C6 RID: 55750 RVA: 0x00207A06 File Offset: 0x00205C06
		public virtual int CustomSeqId
		{
			get
			{
				return this.Instance.CustomSeqId;
			}
		}

		// Token: 0x17003FDA RID: 16346
		// (get) Token: 0x0600D9C7 RID: 55751 RVA: 0x00207A14 File Offset: 0x00205C14
		public virtual List<int> WhoIds
		{
			get
			{
				if (this._WhoIdsInited)
				{
					return this._WhoIdsCache;
				}
				this._WhoIdsInited = true;
				int whoIdsLength = this.Instance.WhoIdsLength;
				this._WhoIdsCache = new List<int>(whoIdsLength);
				for (int i = 0; i < whoIdsLength; i++)
				{
					this._WhoIdsCache.Add(this.Instance.WhoIds(i));
				}
				return this._WhoIdsCache;
			}
		}

		// Token: 0x17003FDB RID: 16347
		// (get) Token: 0x0600D9C8 RID: 55752 RVA: 0x00207A78 File Offset: 0x00205C78
		public virtual bool? ResetCamera
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.ResetCamera);
			}
		}

		// Token: 0x040078F1 RID: 30961
		private IPlayCustomSequence Instance;

		// Token: 0x040078F2 RID: 30962
		private List<int> _WhoIdsCache;

		// Token: 0x040078F3 RID: 30963
		private bool _WhoIdsInited;
	}
}
