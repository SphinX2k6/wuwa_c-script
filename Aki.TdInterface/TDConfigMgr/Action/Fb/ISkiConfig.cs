using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020028F2 RID: 10482
	[NullableContext(1)]
	[Nullable(0)]
	public class ISkiConfig : ISportConfig
	{
		// Token: 0x0600E8DA RID: 59610 RVA: 0x002229C2 File Offset: 0x00220BC2
		public static ISkiConfig Create(ISkiConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISkiConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170048B8 RID: 18616
		// (get) Token: 0x0600E8DB RID: 59611 RVA: 0x002229E1 File Offset: 0x00220BE1
		public override ESportStateType Type
		{
			get
			{
				return (ESportStateType)this.Instance.Type;
			}
		}

		// Token: 0x170048B9 RID: 18617
		// (get) Token: 0x0600E8DC RID: 59612 RVA: 0x002229EE File Offset: 0x00220BEE
		public virtual ISkiConfigType Config
		{
			get
			{
				if (this._ConfigInited)
				{
					return this._ConfigCache;
				}
				this._ConfigInited = true;
				this._ConfigCache = ActionReadHelper.ReadISkiConfig_Config(this.Instance);
				return this._ConfigCache;
			}
		}

		// Token: 0x0400808C RID: 32908
		private ISkiConfig Instance;

		// Token: 0x0400808D RID: 32909
		private ISkiConfigType _ConfigCache;

		// Token: 0x0400808E RID: 32910
		private bool _ConfigInited;
	}
}
