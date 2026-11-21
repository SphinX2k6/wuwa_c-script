using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200036E RID: 878
	public class IEntityMatchConfig
	{
		// Token: 0x06001112 RID: 4370 RVA: 0x0003AA7C File Offset: 0x00038C7C
		private IEntityMatchConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IEntityMatchConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IEntityMatchConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IEntityMatchConfig_SetValue());
			}
			return result;
		}

		// Token: 0x06001113 RID: 4371 RVA: 0x0003AAB4 File Offset: 0x00038CB4
		public static IEntityMatchConfig Create([Nullable(2)] IEntityMatchConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IEntityMatchConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x06001114 RID: 4372 RVA: 0x0003AAC7 File Offset: 0x00038CC7
		public static IEntityMatchConfig CreateFromSetValue([Nullable(2)] IEntityMatchConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IEntityMatchConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x06001115 RID: 4373 RVA: 0x0003AADA File Offset: 0x00038CDA
		public IEntityMatchConfig_SetValue ToSetValue()
		{
			return new IEntityMatchConfig_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170004E0 RID: 1248
		// (get) Token: 0x06001116 RID: 4374 RVA: 0x0003AAED File Offset: 0x00038CED
		// (set) Token: 0x06001117 RID: 4375 RVA: 0x0003AB18 File Offset: 0x00038D18
		public virtual EEntityMatchType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EEntityMatchType.Player;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04000E66 RID: 3686
		[Nullable(2)]
		protected IEntityMatchConfig FbInstance;

		// Token: 0x04000E67 RID: 3687
		[Nullable(2)]
		protected IEntityMatchConfig_SetValue PocoInterface;
	}
}
