using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200077F RID: 1919
	[NullableContext(1)]
	[Nullable(0)]
	public class ITimeScaleConfig
	{
		// Token: 0x060029A2 RID: 10658 RVA: 0x0006DCC8 File Offset: 0x0006BEC8
		private ITimeScaleConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ITimeScaleConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ITimeScaleConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ITimeScaleConfig_SetValue());
			}
			return result;
		}

		// Token: 0x060029A3 RID: 10659 RVA: 0x0006DD00 File Offset: 0x0006BF00
		public static ITimeScaleConfig Create([Nullable(2)] ITimeScaleConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITimeScaleConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x060029A4 RID: 10660 RVA: 0x0006DD13 File Offset: 0x0006BF13
		public static ITimeScaleConfig CreateFromSetValue([Nullable(2)] ITimeScaleConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ITimeScaleConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x060029A5 RID: 10661 RVA: 0x0006DD26 File Offset: 0x0006BF26
		public ITimeScaleConfig_SetValue ToSetValue()
		{
			return new ITimeScaleConfig_SetValue
			{
				IgnoreGlobalTimeScale = this.IgnoreGlobalTimeScale
			};
		}

		// Token: 0x17000AF4 RID: 2804
		// (get) Token: 0x060029A6 RID: 10662 RVA: 0x0006DD39 File Offset: 0x0006BF39
		// (set) Token: 0x060029A7 RID: 10663 RVA: 0x0006DD64 File Offset: 0x0006BF64
		public virtual bool IgnoreGlobalTimeScale
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IgnoreGlobalTimeScale;
				}
				return this.PocoInterface != null && this.PocoInterface.IgnoreGlobalTimeScale;
			}
			set
			{
				this.GetOrCreatePoco().IgnoreGlobalTimeScale = value;
			}
		}

		// Token: 0x04001BEB RID: 7147
		[Nullable(2)]
		protected ITimeScaleConfig FbInstance;

		// Token: 0x04001BEC RID: 7148
		[Nullable(2)]
		protected ITimeScaleConfig_SetValue PocoInterface;
	}
}
