using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002903 RID: 10499
	public class SetEntityVisible : ActionParams
	{
		// Token: 0x0600E98F RID: 59791 RVA: 0x00227C5C File Offset: 0x00225E5C
		public static SetEntityVisible Create(ISetEntityVisible? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new SetEntityVisible
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004437 RID: 17463
		// (get) Token: 0x0600E990 RID: 59792 RVA: 0x00227C7C File Offset: 0x00225E7C
		public virtual List<int> EntityIds
		{
			get
			{
				if (this._EntityIdsInited)
				{
					return this._EntityIdsCache;
				}
				this._EntityIdsInited = true;
				int entityIdsLength = this.Instance.EntityIdsLength;
				this._EntityIdsCache = new List<int>(entityIdsLength);
				for (int i = 0; i < entityIdsLength; i++)
				{
					this._EntityIdsCache.Add(this.Instance.EntityIds(i));
				}
				return this._EntityIdsCache;
			}
		}

		// Token: 0x17004438 RID: 17464
		// (get) Token: 0x0600E991 RID: 59793 RVA: 0x00227CE0 File Offset: 0x00225EE0
		public virtual bool Visible
		{
			get
			{
				return this.Instance.Visible;
			}
		}

		// Token: 0x17004439 RID: 17465
		// (get) Token: 0x0600E992 RID: 59794 RVA: 0x00227CF0 File Offset: 0x00225EF0
		public virtual bool? PerformDestroy
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.PerformDestroy);
			}
		}

		// Token: 0x040080B9 RID: 32953
		private ISetEntityVisible Instance;

		// Token: 0x040080BA RID: 32954
		private List<int> _EntityIdsCache;

		// Token: 0x040080BB RID: 32955
		private bool _EntityIdsInited;
	}
}
