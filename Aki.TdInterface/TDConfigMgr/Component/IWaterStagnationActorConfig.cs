using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020007CF RID: 1999
	[NullableContext(1)]
	[Nullable(0)]
	public class IWaterStagnationActorConfig
	{
		// Token: 0x06002B59 RID: 11097 RVA: 0x000711CC File Offset: 0x0006F3CC
		private IWaterStagnationActorConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IWaterStagnationActorConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IWaterStagnationActorConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IWaterStagnationActorConfig_SetValue());
			}
			return result;
		}

		// Token: 0x06002B5A RID: 11098 RVA: 0x00071204 File Offset: 0x0006F404
		public static IWaterStagnationActorConfig Create([Nullable(2)] IWaterStagnationActorConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IWaterStagnationActorConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x06002B5B RID: 11099 RVA: 0x00071217 File Offset: 0x0006F417
		public static IWaterStagnationActorConfig CreateFromSetValue([Nullable(2)] IWaterStagnationActorConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IWaterStagnationActorConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x06002B5C RID: 11100 RVA: 0x0007122A File Offset: 0x0006F42A
		public IWaterStagnationActorConfig_SetValue ToSetValue()
		{
			return new IWaterStagnationActorConfig_SetValue
			{
				SeqRefEntity = this.SeqRefEntity
			};
		}

		// Token: 0x17000B59 RID: 2905
		// (get) Token: 0x06002B5D RID: 11101 RVA: 0x0007123D File Offset: 0x0006F43D
		// (set) Token: 0x06002B5E RID: 11102 RVA: 0x00071268 File Offset: 0x0006F468
		public virtual int SeqRefEntity
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.SeqRefEntity;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.SeqRefEntity;
			}
			set
			{
				this.GetOrCreatePoco().SeqRefEntity = value;
			}
		}

		// Token: 0x04001CC9 RID: 7369
		[Nullable(2)]
		protected IWaterStagnationActorConfig FbInstance;

		// Token: 0x04001CCA RID: 7370
		[Nullable(2)]
		protected IWaterStagnationActorConfig_SetValue PocoInterface;
	}
}
