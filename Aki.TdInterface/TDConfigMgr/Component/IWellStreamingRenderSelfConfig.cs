using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000886 RID: 2182
	public class IWellStreamingRenderSelfConfig
	{
		// Token: 0x06002F0F RID: 12047 RVA: 0x000797D4 File Offset: 0x000779D4
		private IWellStreamingRenderSelfConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IWellStreamingRenderSelfConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IWellStreamingRenderSelfConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IWellStreamingRenderSelfConfig_SetValue());
			}
			return result;
		}

		// Token: 0x06002F10 RID: 12048 RVA: 0x0007980C File Offset: 0x00077A0C
		public static IWellStreamingRenderSelfConfig Create([Nullable(2)] IWellStreamingRenderSelfConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IWellStreamingRenderSelfConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x06002F11 RID: 12049 RVA: 0x0007981F File Offset: 0x00077A1F
		public static IWellStreamingRenderSelfConfig CreateFromSetValue([Nullable(2)] IWellStreamingRenderSelfConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IWellStreamingRenderSelfConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x06002F12 RID: 12050 RVA: 0x00079832 File Offset: 0x00077A32
		public IWellStreamingRenderSelfConfig_SetValue ToSetValue()
		{
			return new IWellStreamingRenderSelfConfig_SetValue
			{
				RtActorRefKey = this.RtActorRefKey,
				FallbackCubeMapKey = this.FallbackCubeMapKey
			};
		}

		// Token: 0x17000C41 RID: 3137
		// (get) Token: 0x06002F13 RID: 12051 RVA: 0x00079851 File Offset: 0x00077A51
		// (set) Token: 0x06002F14 RID: 12052 RVA: 0x0007987C File Offset: 0x00077A7C
		public virtual string RtActorRefKey
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.RtActorRefKey;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.RtActorRefKey;
			}
			set
			{
				this.GetOrCreatePoco().RtActorRefKey = value;
			}
		}

		// Token: 0x17000C42 RID: 3138
		// (get) Token: 0x06002F15 RID: 12053 RVA: 0x0007988A File Offset: 0x00077A8A
		// (set) Token: 0x06002F16 RID: 12054 RVA: 0x000798B5 File Offset: 0x00077AB5
		public virtual string FallbackCubeMapKey
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.FallbackCubeMapKey;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.FallbackCubeMapKey;
			}
			set
			{
				this.GetOrCreatePoco().FallbackCubeMapKey = value;
			}
		}

		// Token: 0x04001F28 RID: 7976
		[Nullable(2)]
		protected IWellStreamingRenderSelfConfig FbInstance;

		// Token: 0x04001F29 RID: 7977
		[Nullable(2)]
		protected IWellStreamingRenderSelfConfig_SetValue PocoInterface;
	}
}
