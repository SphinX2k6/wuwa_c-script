using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020027F6 RID: 10230
	public class IGravityControlOption : ISystemOptionType
	{
		// Token: 0x0600E28D RID: 57997 RVA: 0x002153EB File Offset: 0x002135EB
		public static IGravityControlOption Create(IGravityControlOption? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IGravityControlOption
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003F4F RID: 16207
		// (get) Token: 0x0600E28E RID: 57998 RVA: 0x0021540A File Offset: 0x0021360A
		public override ESystemOptionType Type
		{
			get
			{
				return (ESystemOptionType)this.Instance.Type;
			}
		}

		// Token: 0x17003F50 RID: 16208
		// (get) Token: 0x0600E28F RID: 57999 RVA: 0x00215418 File Offset: 0x00213618
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

		// Token: 0x17003F51 RID: 16209
		// (get) Token: 0x0600E290 RID: 58000 RVA: 0x00215484 File Offset: 0x00213684
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

		// Token: 0x04007B64 RID: 31588
		private IGravityControlOption Instance;

		// Token: 0x04007B65 RID: 31589
		private List<ISystemOption> _SystemOptionsCache;

		// Token: 0x04007B66 RID: 31590
		private bool _SystemOptionsInited;
	}
}
