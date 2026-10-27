using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020024DC RID: 9436
	[NullableContext(1)]
	[Nullable(0)]
	public class ServerSetPlayerPos : ActionParams
	{
		// Token: 0x0600D2B1 RID: 53937 RVA: 0x001F40E8 File Offset: 0x001F22E8
		public static ServerSetPlayerPos Create(IServerSetPlayerPos? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ServerSetPlayerPos
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003ABB RID: 15035
		// (get) Token: 0x0600D2B2 RID: 53938 RVA: 0x001F4107 File Offset: 0x001F2307
		public virtual PosA Pos
		{
			get
			{
				if (this._PosInited)
				{
					return this._PosCache;
				}
				this._PosInited = true;
				this._PosCache = PosA.Create(this.Instance.Pos);
				return this._PosCache;
			}
		}

		// Token: 0x04007390 RID: 29584
		private IServerSetPlayerPos Instance;

		// Token: 0x04007391 RID: 29585
		[Nullable(2)]
		private PosA _PosCache;

		// Token: 0x04007392 RID: 29586
		private bool _PosInited;
	}
}
