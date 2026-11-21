using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020027F3 RID: 10227
	public class ISystemOptionType
	{
		// Token: 0x0600E27C RID: 57980 RVA: 0x00215149 File Offset: 0x00213349
		public static ISystemOptionType Create(ISystemOptionType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISystemOptionType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003F44 RID: 16196
		// (get) Token: 0x0600E27D RID: 57981 RVA: 0x00215168 File Offset: 0x00213368
		public virtual ESystemOptionType Type
		{
			get
			{
				return (ESystemOptionType)this.Instance.Type;
			}
		}

		// Token: 0x17003F45 RID: 16197
		// (get) Token: 0x0600E27E RID: 57982 RVA: 0x00215178 File Offset: 0x00213378
		public virtual List<ISystemOption> SystemOptions
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

		// Token: 0x17003F46 RID: 16198
		// (get) Token: 0x0600E27F RID: 57983 RVA: 0x002151E4 File Offset: 0x002133E4
		public virtual bool? KeepPreTalkItem
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

		// Token: 0x04007B5B RID: 31579
		private ISystemOptionType Instance;

		// Token: 0x04007B5C RID: 31580
		private List<ISystemOption> _SystemOptionsCache;

		// Token: 0x04007B5D RID: 31581
		private bool _SystemOptionsInited;
	}
}
