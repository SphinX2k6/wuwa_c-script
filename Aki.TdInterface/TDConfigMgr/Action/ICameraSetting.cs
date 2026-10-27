using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001850 RID: 6224
	[NullableContext(1)]
	[Nullable(0)]
	public class ICameraSetting
	{
		// Token: 0x060085B7 RID: 34231 RVA: 0x0013DFF4 File Offset: 0x0013C1F4
		private ICameraSetting_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ICameraSetting 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ICameraSetting_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ICameraSetting_SetValue());
			}
			return result;
		}

		// Token: 0x060085B8 RID: 34232 RVA: 0x0013E02C File Offset: 0x0013C22C
		public static ICameraSetting Create([Nullable(2)] ICameraSetting instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICameraSetting
			{
				FbInstance = instance
			};
		}

		// Token: 0x060085B9 RID: 34233 RVA: 0x0013E03F File Offset: 0x0013C23F
		public static ICameraSetting CreateFromSetValue([Nullable(2)] ICameraSetting_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ICameraSetting
			{
				PocoInterface = value
			};
		}

		// Token: 0x060085BA RID: 34234 RVA: 0x0013E054 File Offset: 0x0013C254
		public ICameraSetting_SetValue ToSetValue()
		{
			return new ICameraSetting_SetValue
			{
				Aperture = this.Aperture,
				FocalLength = this.FocalLength,
				FocusDistance = this.FocusDistance,
				FocalRegion = this.FocalRegion,
				Fov = this.Fov
			};
		}

		// Token: 0x17002BB8 RID: 11192
		// (get) Token: 0x060085BB RID: 34235 RVA: 0x0013E0A2 File Offset: 0x0013C2A2
		// (set) Token: 0x060085BC RID: 34236 RVA: 0x0013E0D1 File Offset: 0x0013C2D1
		public virtual float Aperture
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Aperture;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.Aperture;
			}
			set
			{
				this.GetOrCreatePoco().Aperture = value;
			}
		}

		// Token: 0x17002BB9 RID: 11193
		// (get) Token: 0x060085BD RID: 34237 RVA: 0x0013E0DF File Offset: 0x0013C2DF
		// (set) Token: 0x060085BE RID: 34238 RVA: 0x0013E10E File Offset: 0x0013C30E
		public virtual float FocalLength
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.FocalLength;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.FocalLength;
			}
			set
			{
				this.GetOrCreatePoco().FocalLength = value;
			}
		}

		// Token: 0x17002BBA RID: 11194
		// (get) Token: 0x060085BF RID: 34239 RVA: 0x0013E11C File Offset: 0x0013C31C
		// (set) Token: 0x060085C0 RID: 34240 RVA: 0x0013E14B File Offset: 0x0013C34B
		public virtual float FocusDistance
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.FocusDistance;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.FocusDistance;
			}
			set
			{
				this.GetOrCreatePoco().FocusDistance = value;
			}
		}

		// Token: 0x17002BBB RID: 11195
		// (get) Token: 0x060085C1 RID: 34241 RVA: 0x0013E159 File Offset: 0x0013C359
		// (set) Token: 0x060085C2 RID: 34242 RVA: 0x0013E188 File Offset: 0x0013C388
		public virtual float FocalRegion
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.FocalRegion;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.FocalRegion;
			}
			set
			{
				this.GetOrCreatePoco().FocalRegion = value;
			}
		}

		// Token: 0x17002BBC RID: 11196
		// (get) Token: 0x060085C3 RID: 34243 RVA: 0x0013E198 File Offset: 0x0013C398
		// (set) Token: 0x060085C4 RID: 34244 RVA: 0x0013E1D2 File Offset: 0x0013C3D2
		public virtual float? Fov
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Fov;
				}
				ICameraSetting_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Fov;
			}
			set
			{
				this.GetOrCreatePoco().Fov = value;
			}
		}

		// Token: 0x04005473 RID: 21619
		[Nullable(2)]
		protected ICameraSetting FbInstance;

		// Token: 0x04005474 RID: 21620
		[Nullable(2)]
		protected ICameraSetting_SetValue PocoInterface;
	}
}
