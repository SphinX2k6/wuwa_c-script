using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002979 RID: 10617
	public class IFixedPos : ITeleportConfig
	{
		// Token: 0x0600EB8E RID: 60302 RVA: 0x0022B3B2 File Offset: 0x002295B2
		public static IFixedPos Create(IFixedPos? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFixedPos
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700454A RID: 17738
		// (get) Token: 0x0600EB8F RID: 60303 RVA: 0x0022B3D1 File Offset: 0x002295D1
		public override ETeleportType Type
		{
			get
			{
				return (ETeleportType)this.Instance.Type;
			}
		}

		// Token: 0x1700454B RID: 17739
		// (get) Token: 0x0600EB90 RID: 60304 RVA: 0x0022B3DE File Offset: 0x002295DE
		public virtual PosA TargetPos
		{
			get
			{
				if (this._TargetPosInited)
				{
					return this._TargetPosCache;
				}
				this._TargetPosInited = true;
				this._TargetPosCache = PosA.Create(this.Instance.TargetPos);
				return this._TargetPosCache;
			}
		}

		// Token: 0x040081B5 RID: 33205
		private IFixedPos Instance;

		// Token: 0x040081B6 RID: 33206
		[Nullable(2)]
		private PosA _TargetPosCache;

		// Token: 0x040081B7 RID: 33207
		private bool _TargetPosInited;
	}
}
