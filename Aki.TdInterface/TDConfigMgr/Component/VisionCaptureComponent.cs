using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000981 RID: 2433
	public class VisionCaptureComponent : IComponentBase
	{
		// Token: 0x060036AB RID: 13995 RVA: 0x0008B170 File Offset: 0x00089370
		private VisionCaptureComponent_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("VisionCaptureComponent 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			VisionCaptureComponent_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new VisionCaptureComponent_SetValue());
			}
			return result;
		}

		// Token: 0x060036AC RID: 13996 RVA: 0x0008B1A8 File Offset: 0x000893A8
		public static VisionCaptureComponent Create([Nullable(2)] VisionCaptureComponent instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new VisionCaptureComponent
			{
				FbInstance = instance
			};
		}

		// Token: 0x060036AD RID: 13997 RVA: 0x0008B1BB File Offset: 0x000893BB
		public static VisionCaptureComponent CreateFromSetValue([Nullable(2)] VisionCaptureComponent_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new VisionCaptureComponent
			{
				PocoInterface = value
			};
		}

		// Token: 0x060036AE RID: 13998 RVA: 0x0008B1CE File Offset: 0x000893CE
		public new VisionCaptureComponent_SetValue ToSetValue()
		{
			return new VisionCaptureComponent_SetValue
			{
				Disabled = this.Disabled,
				EdIsLocked = this.EdIsLocked,
				VisionCaptureId = this.VisionCaptureId,
				VisionCaptureProb = this.VisionCaptureProb
			};
		}

		// Token: 0x17000E9B RID: 3739
		// (get) Token: 0x060036AF RID: 13999 RVA: 0x0008B208 File Offset: 0x00089408
		// (set) Token: 0x060036B0 RID: 14000 RVA: 0x0008B242 File Offset: 0x00089442
		public override bool? Disabled
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Disabled;
				}
				VisionCaptureComponent_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Disabled;
			}
			set
			{
				this.GetOrCreatePoco().Disabled = value;
			}
		}

		// Token: 0x17000E9C RID: 3740
		// (get) Token: 0x060036B1 RID: 14001 RVA: 0x0008B250 File Offset: 0x00089450
		// (set) Token: 0x060036B2 RID: 14002 RVA: 0x0008B27A File Offset: 0x0008947A
		public override bool? EdIsLocked
		{
			get
			{
				if (this.PocoInterface != null)
				{
					return this.PocoInterface.EdIsLocked;
				}
				return null;
			}
			set
			{
				this.GetOrCreatePoco().EdIsLocked = value;
			}
		}

		// Token: 0x17000E9D RID: 3741
		// (get) Token: 0x060036B3 RID: 14003 RVA: 0x0008B288 File Offset: 0x00089488
		// (set) Token: 0x060036B4 RID: 14004 RVA: 0x0008B2B3 File Offset: 0x000894B3
		public virtual int VisionCaptureId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.VisionCaptureId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.VisionCaptureId;
			}
			set
			{
				this.GetOrCreatePoco().VisionCaptureId = value;
			}
		}

		// Token: 0x17000E9E RID: 3742
		// (get) Token: 0x060036B5 RID: 14005 RVA: 0x0008B2C4 File Offset: 0x000894C4
		// (set) Token: 0x060036B6 RID: 14006 RVA: 0x0008B2FE File Offset: 0x000894FE
		public virtual int? VisionCaptureProb
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.VisionCaptureProb;
				}
				VisionCaptureComponent_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.VisionCaptureProb;
			}
			set
			{
				this.GetOrCreatePoco().VisionCaptureProb = value;
			}
		}

		// Token: 0x040023CB RID: 9163
		[Nullable(2)]
		protected new VisionCaptureComponent FbInstance;

		// Token: 0x040023CC RID: 9164
		[Nullable(2)]
		protected new VisionCaptureComponent_SetValue PocoInterface;
	}
}
