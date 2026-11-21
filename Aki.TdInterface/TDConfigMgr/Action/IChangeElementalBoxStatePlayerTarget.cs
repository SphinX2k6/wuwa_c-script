using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020019F1 RID: 6641
	public class IChangeElementalBoxStatePlayerTarget : IChangeElementalBoxStateTarget
	{
		// Token: 0x06008D5D RID: 36189 RVA: 0x0014E754 File Offset: 0x0014C954
		private IChangeElementalBoxStatePlayerTarget_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IChangeElementalBoxStatePlayerTarget 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IChangeElementalBoxStatePlayerTarget_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IChangeElementalBoxStatePlayerTarget_SetValue());
			}
			return result;
		}

		// Token: 0x06008D5E RID: 36190 RVA: 0x0014E78C File Offset: 0x0014C98C
		public static IChangeElementalBoxStatePlayerTarget Create([Nullable(2)] IChangeElementalBoxStatePlayerTarget instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IChangeElementalBoxStatePlayerTarget
			{
				FbInstance = instance
			};
		}

		// Token: 0x06008D5F RID: 36191 RVA: 0x0014E79F File Offset: 0x0014C99F
		public static IChangeElementalBoxStatePlayerTarget CreateFromSetValue([Nullable(2)] IChangeElementalBoxStatePlayerTarget_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IChangeElementalBoxStatePlayerTarget
			{
				PocoInterface = value
			};
		}

		// Token: 0x06008D60 RID: 36192 RVA: 0x0014E7B2 File Offset: 0x0014C9B2
		public new IChangeElementalBoxStatePlayerTarget_SetValue ToSetValue()
		{
			return new IChangeElementalBoxStatePlayerTarget_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002DD1 RID: 11729
		// (get) Token: 0x06008D61 RID: 36193 RVA: 0x0014E7C5 File Offset: 0x0014C9C5
		// (set) Token: 0x06008D62 RID: 36194 RVA: 0x0014E7F0 File Offset: 0x0014C9F0
		public override EChangeElementalBoxStateTargetType Type
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

		// Token: 0x040058FE RID: 22782
		[Nullable(2)]
		protected new IChangeElementalBoxStatePlayerTarget FbInstance;

		// Token: 0x040058FF RID: 22783
		[Nullable(2)]
		protected new IChangeElementalBoxStatePlayerTarget_SetValue PocoInterface;
	}
}
