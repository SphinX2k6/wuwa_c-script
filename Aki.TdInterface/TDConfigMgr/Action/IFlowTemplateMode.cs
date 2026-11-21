using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001C38 RID: 7224
	public class IFlowTemplateMode
	{
		// Token: 0x060099AC RID: 39340 RVA: 0x00164138 File Offset: 0x00162338
		private IFlowTemplateMode_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IFlowTemplateMode 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IFlowTemplateMode_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IFlowTemplateMode_SetValue());
			}
			return result;
		}

		// Token: 0x060099AD RID: 39341 RVA: 0x00164170 File Offset: 0x00162370
		public static IFlowTemplateMode Create([Nullable(2)] IFlowTemplateMode instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFlowTemplateMode
			{
				FbInstance = instance
			};
		}

		// Token: 0x060099AE RID: 39342 RVA: 0x00164183 File Offset: 0x00162383
		public static IFlowTemplateMode CreateFromSetValue([Nullable(2)] IFlowTemplateMode_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IFlowTemplateMode
			{
				PocoInterface = value
			};
		}

		// Token: 0x060099AF RID: 39343 RVA: 0x00164196 File Offset: 0x00162396
		public IFlowTemplateMode_SetValue ToSetValue()
		{
			return new IFlowTemplateMode_SetValue
			{
				Id = this.Id,
				CameraId = this.CameraId
			};
		}

		// Token: 0x1700308F RID: 12431
		// (get) Token: 0x060099B0 RID: 39344 RVA: 0x001641B5 File Offset: 0x001623B5
		// (set) Token: 0x060099B1 RID: 39345 RVA: 0x001641E0 File Offset: 0x001623E0
		public virtual int Id
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Id;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.Id;
			}
			set
			{
				this.GetOrCreatePoco().Id = value;
			}
		}

		// Token: 0x17003090 RID: 12432
		// (get) Token: 0x060099B2 RID: 39346 RVA: 0x001641EE File Offset: 0x001623EE
		// (set) Token: 0x060099B3 RID: 39347 RVA: 0x00164219 File Offset: 0x00162419
		public virtual int CameraId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.CameraId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.CameraId;
			}
			set
			{
				this.GetOrCreatePoco().CameraId = value;
			}
		}

		// Token: 0x04005E7A RID: 24186
		[Nullable(2)]
		protected IFlowTemplateMode FbInstance;

		// Token: 0x04005E7B RID: 24187
		[Nullable(2)]
		protected IFlowTemplateMode_SetValue PocoInterface;
	}
}
