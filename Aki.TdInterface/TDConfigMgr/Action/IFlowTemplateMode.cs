using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001A9F RID: 6815
	[NullableContext(1)]
	[Nullable(0)]
	public class IFlowTemplateMode
	{
		// Token: 0x0600922C RID: 37420 RVA: 0x00153F4C File Offset: 0x0015214C
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

		// Token: 0x0600922D RID: 37421 RVA: 0x00153F84 File Offset: 0x00152184
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

		// Token: 0x0600922E RID: 37422 RVA: 0x00153F97 File Offset: 0x00152197
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

		// Token: 0x0600922F RID: 37423 RVA: 0x00153FAA File Offset: 0x001521AA
		public IFlowTemplateMode_SetValue ToSetValue()
		{
			return new IFlowTemplateMode_SetValue
			{
				Id = this.Id,
				CameraId = this.CameraId
			};
		}

		// Token: 0x17002E7D RID: 11901
		// (get) Token: 0x06009230 RID: 37424 RVA: 0x00153FC9 File Offset: 0x001521C9
		// (set) Token: 0x06009231 RID: 37425 RVA: 0x00153FF4 File Offset: 0x001521F4
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

		// Token: 0x17002E7E RID: 11902
		// (get) Token: 0x06009232 RID: 37426 RVA: 0x00154002 File Offset: 0x00152202
		// (set) Token: 0x06009233 RID: 37427 RVA: 0x0015402D File Offset: 0x0015222D
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

		// Token: 0x04005A0A RID: 23050
		[Nullable(2)]
		protected IFlowTemplateMode FbInstance;

		// Token: 0x04005A0B RID: 23051
		[Nullable(2)]
		protected IFlowTemplateMode_SetValue PocoInterface;
	}
}
