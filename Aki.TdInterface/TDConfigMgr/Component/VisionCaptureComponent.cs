using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020008DC RID: 2268
	[NullableContext(1)]
	[Nullable(0)]
	public class VisionCaptureComponent : IComponentBase
	{
		// Token: 0x06003363 RID: 13155 RVA: 0x00083B34 File Offset: 0x00081D34
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

		// Token: 0x06003364 RID: 13156 RVA: 0x00083B6C File Offset: 0x00081D6C
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

		// Token: 0x06003365 RID: 13157 RVA: 0x00083B7F File Offset: 0x00081D7F
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

		// Token: 0x06003366 RID: 13158 RVA: 0x00083B92 File Offset: 0x00081D92
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

		// Token: 0x17000DCF RID: 3535
		// (get) Token: 0x06003367 RID: 13159 RVA: 0x00083BCC File Offset: 0x00081DCC
		// (set) Token: 0x06003368 RID: 13160 RVA: 0x00083C06 File Offset: 0x00081E06
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

		// Token: 0x17000DD0 RID: 3536
		// (get) Token: 0x06003369 RID: 13161 RVA: 0x00083C14 File Offset: 0x00081E14
		// (set) Token: 0x0600336A RID: 13162 RVA: 0x00083C3E File Offset: 0x00081E3E
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

		// Token: 0x17000DD1 RID: 3537
		// (get) Token: 0x0600336B RID: 13163 RVA: 0x00083C4C File Offset: 0x00081E4C
		// (set) Token: 0x0600336C RID: 13164 RVA: 0x00083C77 File Offset: 0x00081E77
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

		// Token: 0x17000DD2 RID: 3538
		// (get) Token: 0x0600336D RID: 13165 RVA: 0x00083C88 File Offset: 0x00081E88
		// (set) Token: 0x0600336E RID: 13166 RVA: 0x00083CC2 File Offset: 0x00081EC2
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

		// Token: 0x040021B4 RID: 8628
		[Nullable(2)]
		protected new VisionCaptureComponent FbInstance;

		// Token: 0x040021B5 RID: 8629
		[Nullable(2)]
		protected new VisionCaptureComponent_SetValue PocoInterface;
	}
}
