using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002990 RID: 10640
	[NullableContext(1)]
	[Nullable(0)]
	public class PerformerAiMoveTo : ActionParams
	{
		// Token: 0x0600EB94 RID: 60308 RVA: 0x00227393 File Offset: 0x00225593
		public static PerformerAiMoveTo Create(IPerformerAiMoveTo? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new PerformerAiMoveTo
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004A36 RID: 18998
		// (get) Token: 0x0600EB95 RID: 60309 RVA: 0x002273B2 File Offset: 0x002255B2
		public virtual IPerformerAiMoveConfig Config
		{
			get
			{
				if (this._ConfigInited)
				{
					return this._ConfigCache;
				}
				this._ConfigInited = true;
				this._ConfigCache = ActionReadHelper.ReadPerformerAiMoveTo_Config(this.Instance);
				return this._ConfigCache;
			}
		}

		// Token: 0x17004A37 RID: 18999
		// (get) Token: 0x0600EB96 RID: 60310 RVA: 0x002273E4 File Offset: 0x002255E4
		public virtual float? StopDistance
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new float?(this.Instance.StopDistance);
			}
		}

		// Token: 0x040081BC RID: 33212
		private IPerformerAiMoveTo Instance;

		// Token: 0x040081BD RID: 33213
		private IPerformerAiMoveConfig _ConfigCache;

		// Token: 0x040081BE RID: 33214
		private bool _ConfigInited;
	}
}
