using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000A5E RID: 2654
	[NullableContext(1)]
	[Nullable(0)]
	public class ICylinder
	{
		// Token: 0x06003D1C RID: 15644 RVA: 0x0009D18F File Offset: 0x0009B38F
		public static ICylinder Create(ICylinder? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICylinder
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17000E1D RID: 3613
		// (get) Token: 0x06003D1D RID: 15645 RVA: 0x0009D1AE File Offset: 0x0009B3AE
		public virtual bool IsUse
		{
			get
			{
				return this.Instance.IsUse;
			}
		}

		// Token: 0x17000E1E RID: 3614
		// (get) Token: 0x06003D1E RID: 15646 RVA: 0x0009D1BB File Offset: 0x0009B3BB
		public virtual int Radius
		{
			get
			{
				return this.Instance.Radius;
			}
		}

		// Token: 0x17000E1F RID: 3615
		// (get) Token: 0x06003D1F RID: 15647 RVA: 0x0009D1C8 File Offset: 0x0009B3C8
		public virtual int Height
		{
			get
			{
				return this.Instance.Height;
			}
		}

		// Token: 0x17000E20 RID: 3616
		// (get) Token: 0x06003D20 RID: 15648 RVA: 0x0009D1D5 File Offset: 0x0009B3D5
		public virtual PosA CylinderPos
		{
			get
			{
				if (this._CylinderPosInited)
				{
					return this._CylinderPosCache;
				}
				this._CylinderPosInited = true;
				this._CylinderPosCache = PosA.Create(this.Instance.CylinderPos);
				return this._CylinderPosCache;
			}
		}

		// Token: 0x0400220B RID: 8715
		private ICylinder Instance;

		// Token: 0x0400220C RID: 8716
		[Nullable(2)]
		private PosA _CylinderPosCache;

		// Token: 0x0400220D RID: 8717
		private bool _CylinderPosInited;
	}
}
