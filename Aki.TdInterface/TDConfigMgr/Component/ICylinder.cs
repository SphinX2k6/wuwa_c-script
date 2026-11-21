using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020002EA RID: 746
	public class ICylinder
	{
		// Token: 0x06000DC7 RID: 3527 RVA: 0x00033650 File Offset: 0x00031850
		private ICylinder_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ICylinder 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ICylinder_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ICylinder_SetValue());
			}
			return result;
		}

		// Token: 0x06000DC8 RID: 3528 RVA: 0x00033688 File Offset: 0x00031888
		public static ICylinder Create([Nullable(2)] ICylinder instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICylinder
			{
				FbInstance = instance
			};
		}

		// Token: 0x06000DC9 RID: 3529 RVA: 0x0003369B File Offset: 0x0003189B
		public static ICylinder CreateFromSetValue([Nullable(2)] ICylinder_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ICylinder
			{
				PocoInterface = value
			};
		}

		// Token: 0x06000DCA RID: 3530 RVA: 0x000336AE File Offset: 0x000318AE
		public ICylinder_SetValue ToSetValue()
		{
			return new ICylinder_SetValue
			{
				IsUse = this.IsUse,
				Radius = this.Radius,
				Height = this.Height,
				CylinderPos = this.CylinderPos
			};
		}

		// Token: 0x17000401 RID: 1025
		// (get) Token: 0x06000DCB RID: 3531 RVA: 0x000336E5 File Offset: 0x000318E5
		// (set) Token: 0x06000DCC RID: 3532 RVA: 0x00033710 File Offset: 0x00031910
		public virtual bool IsUse
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IsUse;
				}
				return this.PocoInterface != null && this.PocoInterface.IsUse;
			}
			set
			{
				this.GetOrCreatePoco().IsUse = value;
			}
		}

		// Token: 0x17000402 RID: 1026
		// (get) Token: 0x06000DCD RID: 3533 RVA: 0x0003371E File Offset: 0x0003191E
		// (set) Token: 0x06000DCE RID: 3534 RVA: 0x00033749 File Offset: 0x00031949
		public virtual int Radius
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Radius;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.Radius;
			}
			set
			{
				this.GetOrCreatePoco().Radius = value;
			}
		}

		// Token: 0x17000403 RID: 1027
		// (get) Token: 0x06000DCF RID: 3535 RVA: 0x00033757 File Offset: 0x00031957
		// (set) Token: 0x06000DD0 RID: 3536 RVA: 0x00033782 File Offset: 0x00031982
		public virtual int Height
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Height;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.Height;
			}
			set
			{
				this.GetOrCreatePoco().Height = value;
			}
		}

		// Token: 0x17000404 RID: 1028
		// (get) Token: 0x06000DD1 RID: 3537 RVA: 0x00033790 File Offset: 0x00031990
		// (set) Token: 0x06000DD2 RID: 3538 RVA: 0x000337F1 File Offset: 0x000319F1
		public virtual PosA CylinderPos
		{
			get
			{
				if (this._CylinderPosInited)
				{
					return this._CylinderPosCache;
				}
				this._CylinderPosInited = true;
				if (this.FbInstance != null)
				{
					this._CylinderPosCache = PosA.Create(this.FbInstance.CylinderPos);
				}
				else
				{
					ICylinder_SetValue pocoInterface = this.PocoInterface;
					this._CylinderPosCache = ((pocoInterface != null) ? pocoInterface.CylinderPos : null);
				}
				return this._CylinderPosCache;
			}
			set
			{
				this.GetOrCreatePoco().CylinderPos = value;
				this._CylinderPosInited = false;
			}
		}

		// Token: 0x04000CA7 RID: 3239
		[Nullable(2)]
		protected ICylinder FbInstance;

		// Token: 0x04000CA8 RID: 3240
		[Nullable(2)]
		protected ICylinder_SetValue PocoInterface;

		// Token: 0x04000CA9 RID: 3241
		private PosA _CylinderPosCache;

		// Token: 0x04000CAA RID: 3242
		private bool _CylinderPosInited;
	}
}
