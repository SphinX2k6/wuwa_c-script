using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001A9D RID: 6813
	[NullableContext(1)]
	[Nullable(0)]
	public class IFlowTemplateInitialLookAt
	{
		// Token: 0x06009222 RID: 37410 RVA: 0x00153E50 File Offset: 0x00152050
		private IFlowTemplateInitialLookAt_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IFlowTemplateInitialLookAt 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IFlowTemplateInitialLookAt_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IFlowTemplateInitialLookAt_SetValue());
			}
			return result;
		}

		// Token: 0x06009223 RID: 37411 RVA: 0x00153E88 File Offset: 0x00152088
		public static IFlowTemplateInitialLookAt Create([Nullable(2)] IFlowTemplateInitialLookAt instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFlowTemplateInitialLookAt
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009224 RID: 37412 RVA: 0x00153E9B File Offset: 0x0015209B
		public static IFlowTemplateInitialLookAt CreateFromSetValue([Nullable(2)] IFlowTemplateInitialLookAt_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IFlowTemplateInitialLookAt
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009225 RID: 37413 RVA: 0x00153EAE File Offset: 0x001520AE
		public IFlowTemplateInitialLookAt_SetValue ToSetValue()
		{
			return new IFlowTemplateInitialLookAt_SetValue
			{
				ActorIndex = this.ActorIndex,
				Target = this.Target
			};
		}

		// Token: 0x17002E7B RID: 11899
		// (get) Token: 0x06009226 RID: 37414 RVA: 0x00153ECD File Offset: 0x001520CD
		// (set) Token: 0x06009227 RID: 37415 RVA: 0x00153EF8 File Offset: 0x001520F8
		public virtual int ActorIndex
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ActorIndex;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.ActorIndex;
			}
			set
			{
				this.GetOrCreatePoco().ActorIndex = value;
			}
		}

		// Token: 0x17002E7C RID: 11900
		// (get) Token: 0x06009228 RID: 37416 RVA: 0x00153F06 File Offset: 0x00152106
		// (set) Token: 0x06009229 RID: 37417 RVA: 0x00153F2D File Offset: 0x0015212D
		public virtual IActorLookAtData Target
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Target;
				}
				IFlowTemplateInitialLookAt_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Target;
			}
			set
			{
				this.GetOrCreatePoco().Target = value;
			}
		}

		// Token: 0x04005A06 RID: 23046
		[Nullable(2)]
		protected IFlowTemplateInitialLookAt FbInstance;

		// Token: 0x04005A07 RID: 23047
		[Nullable(2)]
		protected IFlowTemplateInitialLookAt_SetValue PocoInterface;
	}
}
