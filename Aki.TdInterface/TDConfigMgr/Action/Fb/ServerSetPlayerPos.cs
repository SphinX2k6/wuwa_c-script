using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002781 RID: 10113
	public class ServerSetPlayerPos : ActionParams
	{
		// Token: 0x0600E006 RID: 57350 RVA: 0x0020F944 File Offset: 0x0020DB44
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

		// Token: 0x17003DB2 RID: 15794
		// (get) Token: 0x0600E007 RID: 57351 RVA: 0x0020F963 File Offset: 0x0020DB63
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

		// Token: 0x040079DD RID: 31197
		private IServerSetPlayerPos Instance;

		// Token: 0x040079DE RID: 31198
		[Nullable(2)]
		private PosA _PosCache;

		// Token: 0x040079DF RID: 31199
		private bool _PosInited;
	}
}
