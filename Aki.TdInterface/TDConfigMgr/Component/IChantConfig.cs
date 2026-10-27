using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200022D RID: 557
	[NullableContext(1)]
	[Nullable(0)]
	public class IChantConfig
	{
		// Token: 0x060009B6 RID: 2486 RVA: 0x00029C08 File Offset: 0x00027E08
		private IChantConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IChantConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IChantConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IChantConfig_SetValue());
			}
			return result;
		}

		// Token: 0x060009B7 RID: 2487 RVA: 0x00029C40 File Offset: 0x00027E40
		public static IChantConfig Create([Nullable(2)] IChantConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IChantConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x060009B8 RID: 2488 RVA: 0x00029C53 File Offset: 0x00027E53
		public static IChantConfig CreateFromSetValue([Nullable(2)] IChantConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IChantConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x060009B9 RID: 2489 RVA: 0x00029C66 File Offset: 0x00027E66
		public IChantConfig_SetValue ToSetValue()
		{
			return new IChantConfig_SetValue
			{
				ChantTime = this.ChantTime,
				ChantCameraShake = this.ChantCameraShake,
				ChantCameraStateTag = this.ChantCameraStateTag
			};
		}

		// Token: 0x170002F5 RID: 757
		// (get) Token: 0x060009BA RID: 2490 RVA: 0x00029C91 File Offset: 0x00027E91
		// (set) Token: 0x060009BB RID: 2491 RVA: 0x00029CBC File Offset: 0x00027EBC
		public virtual int ChantTime
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ChantTime;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.ChantTime;
			}
			set
			{
				this.GetOrCreatePoco().ChantTime = value;
			}
		}

		// Token: 0x170002F6 RID: 758
		// (get) Token: 0x060009BC RID: 2492 RVA: 0x00029CCA File Offset: 0x00027ECA
		// (set) Token: 0x060009BD RID: 2493 RVA: 0x00029CF5 File Offset: 0x00027EF5
		public virtual string ChantCameraShake
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ChantCameraShake;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.ChantCameraShake;
			}
			set
			{
				this.GetOrCreatePoco().ChantCameraShake = value;
			}
		}

		// Token: 0x170002F7 RID: 759
		// (get) Token: 0x060009BE RID: 2494 RVA: 0x00029D03 File Offset: 0x00027F03
		// (set) Token: 0x060009BF RID: 2495 RVA: 0x00029D2E File Offset: 0x00027F2E
		public virtual string ChantCameraStateTag
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ChantCameraStateTag;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.ChantCameraStateTag;
			}
			set
			{
				this.GetOrCreatePoco().ChantCameraStateTag = value;
			}
		}

		// Token: 0x040009F7 RID: 2551
		[Nullable(2)]
		protected IChantConfig FbInstance;

		// Token: 0x040009F8 RID: 2552
		[Nullable(2)]
		protected IChantConfig_SetValue PocoInterface;
	}
}
