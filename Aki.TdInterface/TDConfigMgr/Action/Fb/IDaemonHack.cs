using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002B14 RID: 11028
	public class IDaemonHack : IUiGame
	{
		// Token: 0x0600F29A RID: 62106 RVA: 0x00236E72 File Offset: 0x00235072
		public static IDaemonHack Create(IDaemonHack? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IDaemonHack
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004920 RID: 18720
		// (get) Token: 0x0600F29B RID: 62107 RVA: 0x00236E91 File Offset: 0x00235091
		public override ESimpleGameplayType Type
		{
			get
			{
				return (ESimpleGameplayType)this.Instance.Type;
			}
		}

		// Token: 0x17004921 RID: 18721
		// (get) Token: 0x0600F29C RID: 62108 RVA: 0x00236EA0 File Offset: 0x002350A0
		public virtual List<int> Ids
		{
			get
			{
				if (this._IdsInited)
				{
					return this._IdsCache;
				}
				this._IdsInited = true;
				int idsLength = this.Instance.IdsLength;
				this._IdsCache = new List<int>(idsLength);
				for (int i = 0; i < idsLength; i++)
				{
					this._IdsCache.Add(this.Instance.Ids(i));
				}
				return this._IdsCache;
			}
		}

		// Token: 0x17004922 RID: 18722
		// (get) Token: 0x0600F29D RID: 62109 RVA: 0x00236F04 File Offset: 0x00235104
		public virtual bool? FinishOnClose
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.FinishOnClose);
			}
		}

		// Token: 0x04008524 RID: 34084
		private IDaemonHack Instance;

		// Token: 0x04008525 RID: 34085
		private List<int> _IdsCache;

		// Token: 0x04008526 RID: 34086
		private bool _IdsInited;
	}
}
