using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001D67 RID: 7527
	public class ILiveParamConfig
	{
		// Token: 0x06009FD9 RID: 40921 RVA: 0x0016EE4C File Offset: 0x0016D04C
		private ILiveParamConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ILiveParamConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ILiveParamConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ILiveParamConfig_SetValue());
			}
			return result;
		}

		// Token: 0x06009FDA RID: 40922 RVA: 0x0016EE84 File Offset: 0x0016D084
		public static ILiveParamConfig Create([Nullable(2)] ILiveParamConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ILiveParamConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009FDB RID: 40923 RVA: 0x0016EE97 File Offset: 0x0016D097
		public static ILiveParamConfig CreateFromSetValue([Nullable(2)] ILiveParamConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ILiveParamConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009FDC RID: 40924 RVA: 0x0016EEAA File Offset: 0x0016D0AA
		public ILiveParamConfig_SetValue ToSetValue()
		{
			return new ILiveParamConfig_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170031E0 RID: 12768
		// (get) Token: 0x06009FDD RID: 40925 RVA: 0x0016EEBD File Offset: 0x0016D0BD
		// (set) Token: 0x06009FDE RID: 40926 RVA: 0x0016EEE8 File Offset: 0x0016D0E8
		public virtual ELiveParamType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ELiveParamType.Heat;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x0400613D RID: 24893
		[Nullable(2)]
		protected ILiveParamConfig FbInstance;

		// Token: 0x0400613E RID: 24894
		[Nullable(2)]
		protected ILiveParamConfig_SetValue PocoInterface;
	}
}
