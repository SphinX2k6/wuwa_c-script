using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x020012EE RID: 4846
	[NullableContext(1)]
	[Nullable(0)]
	public class IFlipperSystemConfig : IEnableSystemConfig
	{
		// Token: 0x06006E9F RID: 28319 RVA: 0x0010B3C8 File Offset: 0x001095C8
		public static IFlipperSystemConfig Create(IFlipperSystemConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFlipperSystemConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17002296 RID: 8854
		// (get) Token: 0x06006EA0 RID: 28320 RVA: 0x0010B3E7 File Offset: 0x001095E7
		public override EEnableSystemType Type
		{
			get
			{
				return (EEnableSystemType)this.Instance.Type;
			}
		}

		// Token: 0x17002297 RID: 8855
		// (get) Token: 0x06006EA1 RID: 28321 RVA: 0x0010B3F4 File Offset: 0x001095F4
		public virtual List<IFlipperSystemVar> Vars
		{
			get
			{
				if (this._VarsInited)
				{
					return this._VarsCache;
				}
				this._VarsInited = true;
				int varsLength = this.Instance.VarsLength;
				this._VarsCache = new List<IFlipperSystemVar>(varsLength);
				for (int i = 0; i < varsLength; i++)
				{
					this._VarsCache.Add(IFlipperSystemVar.Create(this.Instance.Vars(i)));
				}
				return this._VarsCache;
			}
		}

		// Token: 0x04003F66 RID: 16230
		private IFlipperSystemConfig Instance;

		// Token: 0x04003F67 RID: 16231
		private List<IFlipperSystemVar> _VarsCache;

		// Token: 0x04003F68 RID: 16232
		private bool _VarsInited;
	}
}
