using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200254E RID: 9550
	[NullableContext(1)]
	[Nullable(0)]
	public class IGravityControlOption : ISystemOptionType
	{
		// Token: 0x0600D529 RID: 54569 RVA: 0x001F992B File Offset: 0x001F7B2B
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

		// Token: 0x17003C4F RID: 15439
		// (get) Token: 0x0600D52A RID: 54570 RVA: 0x001F994A File Offset: 0x001F7B4A
		public override ESystemOptionType Type
		{
			get
			{
				return (ESystemOptionType)this.Instance.Type;
			}
		}

		// Token: 0x17003C50 RID: 15440
		// (get) Token: 0x0600D52B RID: 54571 RVA: 0x001F9958 File Offset: 0x001F7B58
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

		// Token: 0x17003C51 RID: 15441
		// (get) Token: 0x0600D52C RID: 54572 RVA: 0x001F99C4 File Offset: 0x001F7BC4
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

		// Token: 0x0400750C RID: 29964
		private IGravityControlOption Instance;

		// Token: 0x0400750D RID: 29965
		private List<ISystemOption> _SystemOptionsCache;

		// Token: 0x0400750E RID: 29966
		private bool _SystemOptionsInited;
	}
}
