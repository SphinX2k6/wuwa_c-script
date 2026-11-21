using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020007CA RID: 1994
	public class IStreamingSourceConfig
	{
		// Token: 0x06002ABB RID: 10939 RVA: 0x000706AC File Offset: 0x0006E8AC
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

		// Token: 0x06002ABC RID: 10940 RVA: 0x000706E4 File Offset: 0x0006E8E4
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

		// Token: 0x06002ABD RID: 10941 RVA: 0x000706F7 File Offset: 0x0006E8F7
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

		// Token: 0x06002ABE RID: 10942 RVA: 0x0007070A File Offset: 0x0006E90A
		public IStreamingSourceConfig_SetValue ToSetValue()
		{
			return new IStreamingSourceConfig_SetValue
			{
				StreamingSourceTargetEntityId = this.StreamingSourceTargetEntityId,
				IsNoRenderStreaming = this.IsNoRenderStreaming
			};
		}

		// Token: 0x17000B2E RID: 2862
		// (get) Token: 0x06002ABF RID: 10943 RVA: 0x00070729 File Offset: 0x0006E929
		// (set) Token: 0x06002AC0 RID: 10944 RVA: 0x00070754 File Offset: 0x0006E954
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

		// Token: 0x17000B2F RID: 2863
		// (get) Token: 0x06002AC1 RID: 10945 RVA: 0x00070764 File Offset: 0x0006E964
		// (set) Token: 0x06002AC2 RID: 10946 RVA: 0x0007079E File Offset: 0x0006E99E
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

		// Token: 0x04001CBD RID: 7357
		[Nullable(2)]
		protected IStreamingSourceConfig FbInstance;

		// Token: 0x04001CBE RID: 7358
		[Nullable(2)]
		protected IStreamingSourceConfig_SetValue PocoInterface;
	}
}
