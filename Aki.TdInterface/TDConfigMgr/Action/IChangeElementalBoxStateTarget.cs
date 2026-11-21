using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020019F3 RID: 6643
	public class IChangeElementalBoxStateTarget
	{
		// Token: 0x06008D65 RID: 36197 RVA: 0x0014E810 File Offset: 0x0014CA10
		private IChangeElementalBoxStateTarget_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IChangeElementalBoxStateTarget 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IChangeElementalBoxStateTarget_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IChangeElementalBoxStateTarget_SetValue());
			}
			return result;
		}

		// Token: 0x06008D66 RID: 36198 RVA: 0x0014E848 File Offset: 0x0014CA48
		public static IChangeElementalBoxStateTarget Create([Nullable(2)] IChangeElementalBoxStateTarget instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IChangeElementalBoxStateTarget
			{
				FbInstance = instance
			};
		}

		// Token: 0x06008D67 RID: 36199 RVA: 0x0014E85B File Offset: 0x0014CA5B
		public static IChangeElementalBoxStateTarget CreateFromSetValue([Nullable(2)] IChangeElementalBoxStateTarget_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IChangeElementalBoxStateTarget
			{
				PocoInterface = value
			};
		}

		// Token: 0x06008D68 RID: 36200 RVA: 0x0014E86E File Offset: 0x0014CA6E
		public IChangeElementalBoxStateTarget_SetValue ToSetValue()
		{
			return new IChangeElementalBoxStateTarget_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002DD2 RID: 11730
		// (get) Token: 0x06008D69 RID: 36201 RVA: 0x0014E881 File Offset: 0x0014CA81
		// (set) Token: 0x06008D6A RID: 36202 RVA: 0x0014E8AC File Offset: 0x0014CAAC
		public virtual EChangeElementalBoxStateTargetType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EChangeElementalBoxStateTargetType.Player;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04005901 RID: 22785
		[Nullable(2)]
		protected IChangeElementalBoxStateTarget FbInstance;

		// Token: 0x04005902 RID: 22786
		[Nullable(2)]
		protected IChangeElementalBoxStateTarget_SetValue PocoInterface;
	}
}
