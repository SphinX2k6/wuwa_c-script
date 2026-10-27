using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020025F9 RID: 9721
	[NullableContext(1)]
	[Nullable(0)]
	public class SetPosA : ActionParams
	{
		// Token: 0x0600DA69 RID: 55913 RVA: 0x00208C46 File Offset: 0x00206E46
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

		// Token: 0x17004039 RID: 16441
		// (get) Token: 0x0600DA6A RID: 55914 RVA: 0x00208C65 File Offset: 0x00206E65
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

		// Token: 0x04007943 RID: 31043
		private ISetPosA Instance;

		// Token: 0x04007944 RID: 31044
		[Nullable(2)]
		private PosA _PosCache;

		// Token: 0x04007945 RID: 31045
		private bool _PosInited;
	}
}
