using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020027A5 RID: 10149
	public class ISetGlobalTimeScale : ITimeScaleType
	{
		// Token: 0x0600E0C2 RID: 57538 RVA: 0x0021110E File Offset: 0x0020F30E
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

		// Token: 0x17003E26 RID: 15910
		// (get) Token: 0x0600E0C3 RID: 57539 RVA: 0x0021112D File Offset: 0x0020F32D
		public override ETimeScaleType Type
		{
			get
			{
				return (ETimeScaleType)this.Instance.Type;
			}
		}

		// Token: 0x17003E27 RID: 15911
		// (get) Token: 0x0600E0C4 RID: 57540 RVA: 0x0021113A File Offset: 0x0020F33A
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

		// Token: 0x04007A37 RID: 31287
		private ISetGlobalTimeScale Instance;

		// Token: 0x04007A38 RID: 31288
		private ISetGlobalTimeScaleType _ConfigCache;

		// Token: 0x04007A39 RID: 31289
		private bool _ConfigInited;
	}
}
