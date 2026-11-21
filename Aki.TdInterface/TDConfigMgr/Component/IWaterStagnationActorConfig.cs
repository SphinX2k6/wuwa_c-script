using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000872 RID: 2162
	public class IWaterStagnationActorConfig
	{
		// Token: 0x06002E89 RID: 11913 RVA: 0x00078530 File Offset: 0x00076730
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

		// Token: 0x06002E8A RID: 11914 RVA: 0x00078568 File Offset: 0x00076768
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

		// Token: 0x06002E8B RID: 11915 RVA: 0x0007857B File Offset: 0x0007677B
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

		// Token: 0x06002E8C RID: 11916 RVA: 0x0007858E File Offset: 0x0007678E
		public IWaterStagnationActorConfig_SetValue ToSetValue()
		{
			return new IWaterStagnationActorConfig_SetValue
			{
				SeqRefEntity = this.SeqRefEntity
			};
		}

		// Token: 0x17000C1C RID: 3100
		// (get) Token: 0x06002E8D RID: 11917 RVA: 0x000785A1 File Offset: 0x000767A1
		// (set) Token: 0x06002E8E RID: 11918 RVA: 0x000785CC File Offset: 0x000767CC
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

		// Token: 0x04001ED5 RID: 7893
		[Nullable(2)]
		protected IWaterStagnationActorConfig FbInstance;

		// Token: 0x04001ED6 RID: 7894
		[Nullable(2)]
		protected IWaterStagnationActorConfig_SetValue PocoInterface;
	}
}
