using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000D4E RID: 3406
	[NullableContext(2)]
	[Nullable(0)]
	public class IPassengerTeleportConfig
	{
		// Token: 0x06004D9F RID: 19871 RVA: 0x000C0F30 File Offset: 0x000BF130
		[NullableContext(1)]
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

		// Token: 0x170018C0 RID: 6336
		// (get) Token: 0x06004DA0 RID: 19872 RVA: 0x000C0F4F File Offset: 0x000BF14F
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

		// Token: 0x04002C7B RID: 11387
		private IPassengerTeleportConfig Instance;

		// Token: 0x04002C7C RID: 11388
		private PosA _PosACache;

		// Token: 0x04002C7D RID: 11389
		private bool _PosAInited;
	}
}
