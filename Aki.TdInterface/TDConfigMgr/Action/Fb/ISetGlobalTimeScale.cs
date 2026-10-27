using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020024FF RID: 9471
	[NullableContext(1)]
	[Nullable(0)]
	public class ISetGlobalTimeScale : ITimeScaleType
	{
		// Token: 0x0600D366 RID: 54118 RVA: 0x001F5716 File Offset: 0x001F3916
		public static ISetGlobalTimeScale Create(ISetGlobalTimeScale? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISetGlobalTimeScale
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003B2A RID: 15146
		// (get) Token: 0x0600D367 RID: 54119 RVA: 0x001F5735 File Offset: 0x001F3935
		public override ETimeScaleType Type
		{
			get
			{
				return (ETimeScaleType)this.Instance.Type;
			}
		}

		// Token: 0x17003B2B RID: 15147
		// (get) Token: 0x0600D368 RID: 54120 RVA: 0x001F5742 File Offset: 0x001F3942
		public virtual ISetGlobalTimeScaleType Config
		{
			get
			{
				if (this._ConfigInited)
				{
					return this._ConfigCache;
				}
				this._ConfigInited = true;
				this._ConfigCache = ActionReadHelper.ReadISetGlobalTimeScale_Config(this.Instance);
				return this._ConfigCache;
			}
		}

		// Token: 0x040073E5 RID: 29669
		private ISetGlobalTimeScale Instance;

		// Token: 0x040073E6 RID: 29670
		private ISetGlobalTimeScaleType _ConfigCache;

		// Token: 0x040073E7 RID: 29671
		private bool _ConfigInited;
	}
}
