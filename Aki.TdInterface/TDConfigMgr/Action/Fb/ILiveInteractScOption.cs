using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020027F7 RID: 10231
	public class ILiveInteractScOption : ISystemOptionType
	{
		// Token: 0x0600E292 RID: 58002 RVA: 0x002154C2 File Offset: 0x002136C2
		public static ILiveInteractScOption Create(ILiveInteractScOption? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ILiveInteractScOption
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003F52 RID: 16210
		// (get) Token: 0x0600E293 RID: 58003 RVA: 0x002154E1 File Offset: 0x002136E1
		public override ESystemOptionType Type
		{
			get
			{
				return (ESystemOptionType)this.Instance.Type;
			}
		}

		// Token: 0x17003F53 RID: 16211
		// (get) Token: 0x0600E294 RID: 58004 RVA: 0x002154F0 File Offset: 0x002136F0
		public override List<ISystemOption> SystemOptions
		{
			get
			{
				if (this._SystemOptionsInited)
				{
					return this._SystemOptionsCache;
				}
				this._SystemOptionsInited = true;
				int systemOptionsLength = this.Instance.SystemOptionsLength;
				this._SystemOptionsCache = new List<ISystemOption>(systemOptionsLength);
				for (int i = 0; i < systemOptionsLength; i++)
				{
					this._SystemOptionsCache.Add(ISystemOption.Create(this.Instance.SystemOptions(i)));
				}
				return this._SystemOptionsCache;
			}
		}

		// Token: 0x17003F54 RID: 16212
		// (get) Token: 0x0600E295 RID: 58005 RVA: 0x0021555C File Offset: 0x0021375C
		public override bool? KeepPreTalkItem
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.KeepPreTalkItem);
			}
		}

		// Token: 0x17003F55 RID: 16213
		// (get) Token: 0x0600E296 RID: 58006 RVA: 0x00215594 File Offset: 0x00213794
		public virtual List<int> ScIds
		{
			get
			{
				if (this._ScIdsInited)
				{
					return this._ScIdsCache;
				}
				this._ScIdsInited = true;
				int scIdsLength = this.Instance.ScIdsLength;
				this._ScIdsCache = new List<int>(scIdsLength);
				for (int i = 0; i < scIdsLength; i++)
				{
					this._ScIdsCache.Add(this.Instance.ScIds(i));
				}
				return this._ScIdsCache;
			}
		}

		// Token: 0x04007B67 RID: 31591
		private ILiveInteractScOption Instance;

		// Token: 0x04007B68 RID: 31592
		private List<ISystemOption> _SystemOptionsCache;

		// Token: 0x04007B69 RID: 31593
		private bool _SystemOptionsInited;

		// Token: 0x04007B6A RID: 31594
		private List<int> _ScIdsCache;

		// Token: 0x04007B6B RID: 31595
		private bool _ScIdsInited;
	}
}
