using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020025F7 RID: 9719
	[NullableContext(1)]
	[Nullable(0)]
	public class MoveToPosA : ActionParams
	{
		// Token: 0x0600DA62 RID: 55906 RVA: 0x00208BAA File Offset: 0x00206DAA
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

		// Token: 0x17004036 RID: 16438
		// (get) Token: 0x0600DA63 RID: 55907 RVA: 0x00208BC9 File Offset: 0x00206DC9
		public virtual float Timeout
		{
			get
			{
				return this.Instance.Timeout;
			}
		}

		// Token: 0x17004037 RID: 16439
		// (get) Token: 0x0600DA64 RID: 55908 RVA: 0x00208BD6 File Offset: 0x00206DD6
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

		// Token: 0x0400793F RID: 31039
		private IMoveToPosA Instance;

		// Token: 0x04007940 RID: 31040
		[Nullable(2)]
		private PosA _PosCache;

		// Token: 0x04007941 RID: 31041
		private bool _PosInited;
	}
}
