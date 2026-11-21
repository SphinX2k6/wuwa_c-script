using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000E48 RID: 3656
	[NullableContext(2)]
	[Nullable(0)]
	public class IPassengerTeleportConfig
	{
		// Token: 0x060052BB RID: 21179 RVA: 0x000CC674 File Offset: 0x000CA874
		[NullableContext(0)]
		public static IPassengerTeleportConfig Create(IPassengerTeleportConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPassengerTeleportConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001A26 RID: 6694
		// (get) Token: 0x060052BC RID: 21180 RVA: 0x000CC693 File Offset: 0x000CA893
		public virtual PosA PosA
		{
			get
			{
				if (this._PosAInited)
				{
					return this._PosACache;
				}
				this._PosAInited = true;
				this._PosACache = PosA.Create(this.Instance.PosA);
				return this._PosACache;
			}
		}

		// Token: 0x04002F3B RID: 12091
		private IPassengerTeleportConfig Instance;

		// Token: 0x04002F3C RID: 12092
		private PosA _PosACache;

		// Token: 0x04002F3D RID: 12093
		private bool _PosAInited;
	}
}
