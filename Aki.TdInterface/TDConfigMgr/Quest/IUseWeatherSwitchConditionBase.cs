using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020011F6 RID: 4598
	[NullableContext(1)]
	[Nullable(0)]
	public class IUseWeatherSwitchConditionBase
	{
		// Token: 0x06006864 RID: 26724 RVA: 0x000F9538 File Offset: 0x000F7738
		private IUseWeatherSwitchConditionBase_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IUseWeatherSwitchConditionBase 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IUseWeatherSwitchConditionBase_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IUseWeatherSwitchConditionBase_SetValue());
			}
			return result;
		}

		// Token: 0x06006865 RID: 26725 RVA: 0x000F9570 File Offset: 0x000F7770
		public static IUseWeatherSwitchConditionBase Create([Nullable(2)] IUseWeatherSwitchConditionBase instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IUseWeatherSwitchConditionBase
			{
				FbInstance = instance
			};
		}

		// Token: 0x06006866 RID: 26726 RVA: 0x000F9583 File Offset: 0x000F7783
		public static IUseWeatherSwitchConditionBase CreateFromSetValue([Nullable(2)] IUseWeatherSwitchConditionBase_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IUseWeatherSwitchConditionBase
			{
				PocoInterface = value
			};
		}

		// Token: 0x06006867 RID: 26727 RVA: 0x000F9596 File Offset: 0x000F7796
		public IUseWeatherSwitchConditionBase_SetValue ToSetValue()
		{
			return new IUseWeatherSwitchConditionBase_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170021C6 RID: 8646
		// (get) Token: 0x06006868 RID: 26728 RVA: 0x000F95A9 File Offset: 0x000F77A9
		// (set) Token: 0x06006869 RID: 26729 RVA: 0x000F95D4 File Offset: 0x000F77D4
		public virtual EUseWeatherSwitchCheckType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EUseWeatherSwitchCheckType.SpecifiedWeather;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04003E85 RID: 16005
		[Nullable(2)]
		protected IUseWeatherSwitchConditionBase FbInstance;

		// Token: 0x04003E86 RID: 16006
		[Nullable(2)]
		protected IUseWeatherSwitchConditionBase_SetValue PocoInterface;
	}
}
