using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000729 RID: 1833
	[NullableContext(1)]
	[Nullable(0)]
	public class IStreamingSourceConfig
	{
		// Token: 0x06002797 RID: 10135 RVA: 0x00069504 File Offset: 0x00067704
		private IStreamingSourceConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IStreamingSourceConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IStreamingSourceConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IStreamingSourceConfig_SetValue());
			}
			return result;
		}

		// Token: 0x06002798 RID: 10136 RVA: 0x0006953C File Offset: 0x0006773C
		public static IStreamingSourceConfig Create([Nullable(2)] IStreamingSourceConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IStreamingSourceConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x06002799 RID: 10137 RVA: 0x0006954F File Offset: 0x0006774F
		public static IStreamingSourceConfig CreateFromSetValue([Nullable(2)] IStreamingSourceConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IStreamingSourceConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600279A RID: 10138 RVA: 0x00069562 File Offset: 0x00067762
		public IStreamingSourceConfig_SetValue ToSetValue()
		{
			return new IStreamingSourceConfig_SetValue
			{
				StreamingSourceTargetEntityId = this.StreamingSourceTargetEntityId,
				IsNoRenderStreaming = this.IsNoRenderStreaming
			};
		}

		// Token: 0x17000A6E RID: 2670
		// (get) Token: 0x0600279B RID: 10139 RVA: 0x00069581 File Offset: 0x00067781
		// (set) Token: 0x0600279C RID: 10140 RVA: 0x000695AC File Offset: 0x000677AC
		public virtual int StreamingSourceTargetEntityId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.StreamingSourceTargetEntityId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.StreamingSourceTargetEntityId;
			}
			set
			{
				this.GetOrCreatePoco().StreamingSourceTargetEntityId = value;
			}
		}

		// Token: 0x17000A6F RID: 2671
		// (get) Token: 0x0600279D RID: 10141 RVA: 0x000695BC File Offset: 0x000677BC
		// (set) Token: 0x0600279E RID: 10142 RVA: 0x000695F6 File Offset: 0x000677F6
		public virtual bool? IsNoRenderStreaming
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IsNoRenderStreaming;
				}
				IStreamingSourceConfig_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.IsNoRenderStreaming;
			}
			set
			{
				this.GetOrCreatePoco().IsNoRenderStreaming = value;
			}
		}

		// Token: 0x04001AB8 RID: 6840
		[Nullable(2)]
		protected IStreamingSourceConfig FbInstance;

		// Token: 0x04001AB9 RID: 6841
		[Nullable(2)]
		protected IStreamingSourceConfig_SetValue PocoInterface;
	}
}
