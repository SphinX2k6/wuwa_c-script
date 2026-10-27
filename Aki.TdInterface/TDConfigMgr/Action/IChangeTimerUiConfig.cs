using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200187C RID: 6268
	[NullableContext(1)]
	[Nullable(0)]
	public class IChangeTimerUiConfig
	{
		// Token: 0x060086AF RID: 34479 RVA: 0x0013FCA4 File Offset: 0x0013DEA4
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

		// Token: 0x060086B0 RID: 34480 RVA: 0x0013FCDC File Offset: 0x0013DEDC
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

		// Token: 0x060086B1 RID: 34481 RVA: 0x0013FCEF File Offset: 0x0013DEEF
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

		// Token: 0x060086B2 RID: 34482 RVA: 0x0013FD02 File Offset: 0x0013DF02
		public IChangeTimerUiConfig_SetValue ToSetValue()
		{
			return new IChangeTimerUiConfig_SetValue
			{
				UiType = this.UiType
			};
		}

		// Token: 0x17002BF2 RID: 11250
		// (get) Token: 0x060086B3 RID: 34483 RVA: 0x0013FD15 File Offset: 0x0013DF15
		// (set) Token: 0x060086B4 RID: 34484 RVA: 0x0013FD40 File Offset: 0x0013DF40
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

		// Token: 0x040054E7 RID: 21735
		[Nullable(2)]
		protected IChangeTimerUiConfig FbInstance;

		// Token: 0x040054E8 RID: 21736
		[Nullable(2)]
		protected IChangeTimerUiConfig_SetValue PocoInterface;
	}
}
