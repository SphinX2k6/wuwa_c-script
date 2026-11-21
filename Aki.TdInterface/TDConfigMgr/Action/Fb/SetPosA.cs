using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020028B9 RID: 10425
	public class SetPosA : ActionParams
	{
		// Token: 0x0600E836 RID: 59446 RVA: 0x0022539A File Offset: 0x0022359A
		public static SetPosA Create(ISetPosA? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new SetPosA
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004372 RID: 17266
		// (get) Token: 0x0600E837 RID: 59447 RVA: 0x002253B9 File Offset: 0x002235B9
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

		// Token: 0x04007FDD RID: 32733
		private ISetPosA Instance;

		// Token: 0x04007FDE RID: 32734
		[Nullable(2)]
		private PosA _PosCache;

		// Token: 0x04007FDF RID: 32735
		private bool _PosInited;
	}
}
