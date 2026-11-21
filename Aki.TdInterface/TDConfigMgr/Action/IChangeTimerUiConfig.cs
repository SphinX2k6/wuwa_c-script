using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001A07 RID: 6663
	public class IChangeTimerUiConfig
	{
		// Token: 0x06008DD7 RID: 36311 RVA: 0x0014F4D8 File Offset: 0x0014D6D8
		private IChangeTimerUiConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IChangeTimerUiConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IChangeTimerUiConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IChangeTimerUiConfig_SetValue());
			}
			return result;
		}

		// Token: 0x06008DD8 RID: 36312 RVA: 0x0014F510 File Offset: 0x0014D710
		public static IChangeTimerUiConfig Create([Nullable(2)] IChangeTimerUiConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IChangeTimerUiConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x06008DD9 RID: 36313 RVA: 0x0014F523 File Offset: 0x0014D723
		public static IChangeTimerUiConfig CreateFromSetValue([Nullable(2)] IChangeTimerUiConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IChangeTimerUiConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x06008DDA RID: 36314 RVA: 0x0014F536 File Offset: 0x0014D736
		public IChangeTimerUiConfig_SetValue ToSetValue()
		{
			return new IChangeTimerUiConfig_SetValue
			{
				UiType = this.UiType
			};
		}

		// Token: 0x17002DED RID: 11757
		// (get) Token: 0x06008DDB RID: 36315 RVA: 0x0014F549 File Offset: 0x0014D749
		// (set) Token: 0x06008DDC RID: 36316 RVA: 0x0014F574 File Offset: 0x0014D774
		public virtual EChangeTimerUiType UiType
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.UiType;
				}
				if (this.PocoInterface == null)
				{
					return (EChangeTimerUiType)0;
				}
				return this.PocoInterface.UiType;
			}
			set
			{
				this.GetOrCreatePoco().UiType = value;
			}
		}

		// Token: 0x04005934 RID: 22836
		[Nullable(2)]
		protected IChangeTimerUiConfig FbInstance;

		// Token: 0x04005935 RID: 22837
		[Nullable(2)]
		protected IChangeTimerUiConfig_SetValue PocoInterface;
	}
}
