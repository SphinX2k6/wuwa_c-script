using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001E8B RID: 7819
	public class INumberVar
	{
		// Token: 0x0600A63B RID: 42555 RVA: 0x0017AC60 File Offset: 0x00178E60
		private INumberVar_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("INumberVar 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			INumberVar_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new INumberVar_SetValue());
			}
			return result;
		}

		// Token: 0x0600A63C RID: 42556 RVA: 0x0017AC98 File Offset: 0x00178E98
		public static INumberVar Create([Nullable(2)] INumberVar instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new INumberVar
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A63D RID: 42557 RVA: 0x0017ACAB File Offset: 0x00178EAB
		public static INumberVar CreateFromSetValue([Nullable(2)] INumberVar_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new INumberVar
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A63E RID: 42558 RVA: 0x0017ACBE File Offset: 0x00178EBE
		public INumberVar_SetValue ToSetValue()
		{
			return new INumberVar_SetValue
			{
				Name = this.Name,
				Value = this.Value
			};
		}

		// Token: 0x1700335B RID: 13147
		// (get) Token: 0x0600A63F RID: 42559 RVA: 0x0017ACDD File Offset: 0x00178EDD
		// (set) Token: 0x0600A640 RID: 42560 RVA: 0x0017AD08 File Offset: 0x00178F08
		public virtual string Name
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Name;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.Name;
			}
			set
			{
				this.GetOrCreatePoco().Name = value;
			}
		}

		// Token: 0x1700335C RID: 13148
		// (get) Token: 0x0600A641 RID: 42561 RVA: 0x0017AD16 File Offset: 0x00178F16
		// (set) Token: 0x0600A642 RID: 42562 RVA: 0x0017AD45 File Offset: 0x00178F45
		public virtual float Value
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Value;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.Value;
			}
			set
			{
				this.GetOrCreatePoco().Value = value;
			}
		}

		// Token: 0x04006446 RID: 25670
		[Nullable(2)]
		protected INumberVar FbInstance;

		// Token: 0x04006447 RID: 25671
		[Nullable(2)]
		protected INumberVar_SetValue PocoInterface;
	}
}
