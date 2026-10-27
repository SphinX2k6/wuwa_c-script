using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020007E3 RID: 2019
	[NullableContext(1)]
	[Nullable(0)]
	public class IWellStreamingRenderSelfConfig
	{
		// Token: 0x06002BDF RID: 11231 RVA: 0x00072470 File Offset: 0x00070670
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

		// Token: 0x06002BE0 RID: 11232 RVA: 0x000724A8 File Offset: 0x000706A8
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

		// Token: 0x06002BE1 RID: 11233 RVA: 0x000724BB File Offset: 0x000706BB
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

		// Token: 0x06002BE2 RID: 11234 RVA: 0x000724CE File Offset: 0x000706CE
		public IWellStreamingRenderSelfConfig_SetValue ToSetValue()
		{
			return new IWellStreamingRenderSelfConfig_SetValue
			{
				RtActorRefKey = this.RtActorRefKey,
				FallbackCubeMapKey = this.FallbackCubeMapKey
			};
		}

		// Token: 0x17000B7E RID: 2942
		// (get) Token: 0x06002BE3 RID: 11235 RVA: 0x000724ED File Offset: 0x000706ED
		// (set) Token: 0x06002BE4 RID: 11236 RVA: 0x00072518 File Offset: 0x00070718
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

		// Token: 0x17000B7F RID: 2943
		// (get) Token: 0x06002BE5 RID: 11237 RVA: 0x00072526 File Offset: 0x00070726
		// (set) Token: 0x06002BE6 RID: 11238 RVA: 0x00072551 File Offset: 0x00070751
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

		// Token: 0x04001D1C RID: 7452
		[Nullable(2)]
		protected IWellStreamingRenderSelfConfig FbInstance;

		// Token: 0x04001D1D RID: 7453
		[Nullable(2)]
		protected IWellStreamingRenderSelfConfig_SetValue PocoInterface;
	}
}
