using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000254 RID: 596
	public class IChantConfig
	{
		// Token: 0x06000A2A RID: 2602 RVA: 0x0002B3C8 File Offset: 0x000295C8
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

		// Token: 0x06000A2B RID: 2603 RVA: 0x0002B400 File Offset: 0x00029600
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

		// Token: 0x06000A2C RID: 2604 RVA: 0x0002B413 File Offset: 0x00029613
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

		// Token: 0x06000A2D RID: 2605 RVA: 0x0002B426 File Offset: 0x00029626
		public IChantConfig_SetValue ToSetValue()
		{
			return new IChantConfig_SetValue
			{
				ChantTime = this.ChantTime,
				ChantCameraShake = this.ChantCameraShake,
				ChantCameraStateTag = this.ChantCameraStateTag
			};
		}

		// Token: 0x17000314 RID: 788
		// (get) Token: 0x06000A2E RID: 2606 RVA: 0x0002B451 File Offset: 0x00029651
		// (set) Token: 0x06000A2F RID: 2607 RVA: 0x0002B47C File Offset: 0x0002967C
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

		// Token: 0x17000315 RID: 789
		// (get) Token: 0x06000A30 RID: 2608 RVA: 0x0002B48A File Offset: 0x0002968A
		// (set) Token: 0x06000A31 RID: 2609 RVA: 0x0002B4B5 File Offset: 0x000296B5
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

		// Token: 0x17000316 RID: 790
		// (get) Token: 0x06000A32 RID: 2610 RVA: 0x0002B4C3 File Offset: 0x000296C3
		// (set) Token: 0x06000A33 RID: 2611 RVA: 0x0002B4EE File Offset: 0x000296EE
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

		// Token: 0x04000A81 RID: 2689
		[Nullable(2)]
		protected IChantConfig FbInstance;

		// Token: 0x04000A82 RID: 2690
		[Nullable(2)]
		protected IChantConfig_SetValue PocoInterface;
	}
}
