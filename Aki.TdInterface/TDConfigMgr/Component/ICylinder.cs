using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020002A5 RID: 677
	[NullableContext(1)]
	[Nullable(0)]
	public class ICylinder
	{
		// Token: 0x06000CA3 RID: 3235 RVA: 0x00030860 File Offset: 0x0002EA60
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

		// Token: 0x06000CA4 RID: 3236 RVA: 0x00030898 File Offset: 0x0002EA98
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

		// Token: 0x06000CA5 RID: 3237 RVA: 0x000308AB File Offset: 0x0002EAAB
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

		// Token: 0x06000CA6 RID: 3238 RVA: 0x000308BE File Offset: 0x0002EABE
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

		// Token: 0x170003B7 RID: 951
		// (get) Token: 0x06000CA7 RID: 3239 RVA: 0x000308F5 File Offset: 0x0002EAF5
		// (set) Token: 0x06000CA8 RID: 3240 RVA: 0x00030920 File Offset: 0x0002EB20
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

		// Token: 0x170003B8 RID: 952
		// (get) Token: 0x06000CA9 RID: 3241 RVA: 0x0003092E File Offset: 0x0002EB2E
		// (set) Token: 0x06000CAA RID: 3242 RVA: 0x00030959 File Offset: 0x0002EB59
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

		// Token: 0x170003B9 RID: 953
		// (get) Token: 0x06000CAB RID: 3243 RVA: 0x00030967 File Offset: 0x0002EB67
		// (set) Token: 0x06000CAC RID: 3244 RVA: 0x00030992 File Offset: 0x0002EB92
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

		// Token: 0x170003BA RID: 954
		// (get) Token: 0x06000CAD RID: 3245 RVA: 0x000309A0 File Offset: 0x0002EBA0
		// (set) Token: 0x06000CAE RID: 3246 RVA: 0x00030A01 File Offset: 0x0002EC01
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

		// Token: 0x04000BC2 RID: 3010
		[Nullable(2)]
		protected ICylinder FbInstance;

		// Token: 0x04000BC3 RID: 3011
		[Nullable(2)]
		protected ICylinder_SetValue PocoInterface;

		// Token: 0x04000BC4 RID: 3012
		private PosA _CylinderPosCache;

		// Token: 0x04000BC5 RID: 3013
		private bool _CylinderPosInited;
	}
}
