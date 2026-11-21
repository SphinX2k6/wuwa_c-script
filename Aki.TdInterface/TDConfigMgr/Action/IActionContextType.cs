using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020018D7 RID: 6359
	public class IActionContextType
	{
		// Token: 0x06008569 RID: 34153 RVA: 0x0013E05C File Offset: 0x0013C25C
		private IActionContextType_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IActionContextType 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IActionContextType_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IActionContextType_SetValue());
			}
			return result;
		}

		// Token: 0x0600856A RID: 34154 RVA: 0x0013E094 File Offset: 0x0013C294
		public static IActionContextType Create([Nullable(2)] IActionContextType instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IActionContextType
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600856B RID: 34155 RVA: 0x0013E0A7 File Offset: 0x0013C2A7
		public static IActionContextType CreateFromSetValue([Nullable(2)] IActionContextType_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IActionContextType
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600856C RID: 34156 RVA: 0x0013E0BA File Offset: 0x0013C2BA
		public IActionContextType_SetValue ToSetValue()
		{
			return new IActionContextType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002B7E RID: 11134
		// (get) Token: 0x0600856D RID: 34157 RVA: 0x0013E0CD File Offset: 0x0013C2CD
		// (set) Token: 0x0600856E RID: 34158 RVA: 0x0013E0F8 File Offset: 0x0013C2F8
		public virtual TActionContextType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return TActionContextType.commonBt;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x040054C3 RID: 21699
		[Nullable(2)]
		protected IActionContextType FbInstance;

		// Token: 0x040054C4 RID: 21700
		[Nullable(2)]
		protected IActionContextType_SetValue PocoInterface;
	}
}
