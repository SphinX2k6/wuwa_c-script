using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020028B7 RID: 10423
	public class MoveToPosA : ActionParams
	{
		// Token: 0x0600E82F RID: 59439 RVA: 0x002252FE File Offset: 0x002234FE
		public static MoveToPosA Create(IMoveToPosA? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new MoveToPosA
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700436F RID: 17263
		// (get) Token: 0x0600E830 RID: 59440 RVA: 0x0022531D File Offset: 0x0022351D
		public virtual float Timeout
		{
			get
			{
				return this.Instance.Timeout;
			}
		}

		// Token: 0x17004370 RID: 17264
		// (get) Token: 0x0600E831 RID: 59441 RVA: 0x0022532A File Offset: 0x0022352A
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

		// Token: 0x04007FD9 RID: 32729
		private IMoveToPosA Instance;

		// Token: 0x04007FDA RID: 32730
		[Nullable(2)]
		private PosA _PosCache;

		// Token: 0x04007FDB RID: 32731
		private bool _PosInited;
	}
}
