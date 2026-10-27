using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002111 RID: 8465
	[NullableContext(1)]
	[Nullable(0)]
	public class PlayerLookTowards : ActionParams
	{
		// Token: 0x0600BA34 RID: 47668 RVA: 0x001AE450 File Offset: 0x001AC650
		private PlayerLookTowards_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("PlayerLookTowards 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			PlayerLookTowards_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new PlayerLookTowards_SetValue());
			}
			return result;
		}

		// Token: 0x0600BA35 RID: 47669 RVA: 0x001AE488 File Offset: 0x001AC688
		public static PlayerLookTowards Create([Nullable(2)] PlayerLookTowards instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new PlayerLookTowards
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600BA36 RID: 47670 RVA: 0x001AE49B File Offset: 0x001AC69B
		public static PlayerLookTowards CreateFromSetValue([Nullable(2)] PlayerLookTowards_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new PlayerLookTowards
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600BA37 RID: 47671 RVA: 0x001AE4AE File Offset: 0x001AC6AE
		public PlayerLookTowards_SetValue ToSetValue()
		{
			return new PlayerLookTowards_SetValue
			{
				Target = this.Target
			};
		}

		// Token: 0x170038DA RID: 14554
		// (get) Token: 0x0600BA38 RID: 47672 RVA: 0x001AE4C1 File Offset: 0x001AC6C1
		// (set) Token: 0x0600BA39 RID: 47673 RVA: 0x001AE4E8 File Offset: 0x001AC6E8
		public virtual ICharacterLookAtData Target
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Target;
				}
				PlayerLookTowards_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Target;
			}
			set
			{
				this.GetOrCreatePoco().Target = value;
			}
		}

		// Token: 0x04006F75 RID: 28533
		[Nullable(2)]
		protected new PlayerLookTowards FbInstance;

		// Token: 0x04006F76 RID: 28534
		[Nullable(2)]
		protected PlayerLookTowards_SetValue PocoInterface;
	}
}
