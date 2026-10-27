using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200046A RID: 1130
	[NullableContext(1)]
	[Nullable(0)]
	public class IInitStateDigital : IInitState
	{
		// Token: 0x060016C9 RID: 5833 RVA: 0x00045D10 File Offset: 0x00043F10
		private IInitStateDigital_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IInitStateDigital 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IInitStateDigital_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IInitStateDigital_SetValue());
			}
			return result;
		}

		// Token: 0x060016CA RID: 5834 RVA: 0x00045D48 File Offset: 0x00043F48
		public static IInitStateDigital Create([Nullable(2)] IInitStateDigital instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IInitStateDigital
			{
				FbInstance = instance
			};
		}

		// Token: 0x060016CB RID: 5835 RVA: 0x00045D5B File Offset: 0x00043F5B
		public static IInitStateDigital CreateFromSetValue([Nullable(2)] IInitStateDigital_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IInitStateDigital
			{
				PocoInterface = value
			};
		}

		// Token: 0x060016CC RID: 5836 RVA: 0x00045D6E File Offset: 0x00043F6E
		public new IInitStateDigital_SetValue ToSetValue()
		{
			return new IInitStateDigital_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17000623 RID: 1571
		// (get) Token: 0x060016CD RID: 5837 RVA: 0x00045D81 File Offset: 0x00043F81
		// (set) Token: 0x060016CE RID: 5838 RVA: 0x00045DAC File Offset: 0x00043FAC
		public override EInitStateType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EInitStateType.Birth;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04001144 RID: 4420
		[Nullable(2)]
		protected new IInitStateDigital FbInstance;

		// Token: 0x04001145 RID: 4421
		[Nullable(2)]
		protected new IInitStateDigital_SetValue PocoInterface;
	}
}
