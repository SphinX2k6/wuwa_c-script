using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020026B6 RID: 9910
	[NullableContext(1)]
	[Nullable(0)]
	public class IFixedPos : ITeleportConfig
	{
		// Token: 0x0600DDB7 RID: 56759 RVA: 0x0020EC12 File Offset: 0x0020CE12
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

		// Token: 0x1700420D RID: 16909
		// (get) Token: 0x0600DDB8 RID: 56760 RVA: 0x0020EC31 File Offset: 0x0020CE31
		public override ETeleportType Type
		{
			get
			{
				return (ETeleportType)this.Instance.Type;
			}
		}

		// Token: 0x1700420E RID: 16910
		// (get) Token: 0x0600DDB9 RID: 56761 RVA: 0x0020EC3E File Offset: 0x0020CE3E
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

		// Token: 0x04007B18 RID: 31512
		private IFixedPos Instance;

		// Token: 0x04007B19 RID: 31513
		[Nullable(2)]
		private PosA _TargetPosCache;

		// Token: 0x04007B1A RID: 31514
		private bool _TargetPosInited;
	}
}
