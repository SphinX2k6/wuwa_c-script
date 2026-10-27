using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001866 RID: 6246
	[NullableContext(1)]
	[Nullable(0)]
	public class IChangeElementalBoxStatePlayerTarget : IChangeElementalBoxStateTarget
	{
		// Token: 0x06008635 RID: 34357 RVA: 0x0013EF20 File Offset: 0x0013D120
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

		// Token: 0x06008636 RID: 34358 RVA: 0x0013EF58 File Offset: 0x0013D158
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

		// Token: 0x06008637 RID: 34359 RVA: 0x0013EF6B File Offset: 0x0013D16B
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

		// Token: 0x06008638 RID: 34360 RVA: 0x0013EF7E File Offset: 0x0013D17E
		public new IChangeElementalBoxStatePlayerTarget_SetValue ToSetValue()
		{
			return new IChangeElementalBoxStatePlayerTarget_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002BD6 RID: 11222
		// (get) Token: 0x06008639 RID: 34361 RVA: 0x0013EF91 File Offset: 0x0013D191
		// (set) Token: 0x0600863A RID: 34362 RVA: 0x0013EFBC File Offset: 0x0013D1BC
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

		// Token: 0x040054B1 RID: 21681
		[Nullable(2)]
		protected new IChangeElementalBoxStatePlayerTarget FbInstance;

		// Token: 0x040054B2 RID: 21682
		[Nullable(2)]
		protected new IChangeElementalBoxStatePlayerTarget_SetValue PocoInterface;
	}
}
