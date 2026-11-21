using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200088A RID: 2186
	public class IWindDirectionalStateGrade
	{
		// Token: 0x06002F25 RID: 12069 RVA: 0x00079AC8 File Offset: 0x00077CC8
		private IWindDirectionalStateGrade_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IWindDirectionalStateGrade 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IWindDirectionalStateGrade_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IWindDirectionalStateGrade_SetValue());
			}
			return result;
		}

		// Token: 0x06002F26 RID: 12070 RVA: 0x00079B00 File Offset: 0x00077D00
		public static IWindDirectionalStateGrade Create([Nullable(2)] IWindDirectionalStateGrade instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IWindDirectionalStateGrade
			{
				FbInstance = instance
			};
		}

		// Token: 0x06002F27 RID: 12071 RVA: 0x00079B13 File Offset: 0x00077D13
		public static IWindDirectionalStateGrade CreateFromSetValue([Nullable(2)] IWindDirectionalStateGrade_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IWindDirectionalStateGrade
			{
				PocoInterface = value
			};
		}

		// Token: 0x06002F28 RID: 12072 RVA: 0x00079B26 File Offset: 0x00077D26
		public IWindDirectionalStateGrade_SetValue ToSetValue()
		{
			return new IWindDirectionalStateGrade_SetValue
			{
				State = this.State,
				Speed = this.Speed,
				Strength = this.Strength
			};
		}

		// Token: 0x17000C46 RID: 3142
		// (get) Token: 0x06002F29 RID: 12073 RVA: 0x00079B51 File Offset: 0x00077D51
		// (set) Token: 0x06002F2A RID: 12074 RVA: 0x00079B7C File Offset: 0x00077D7C
		public virtual string State
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.State;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.State;
			}
			set
			{
				this.GetOrCreatePoco().State = value;
			}
		}

		// Token: 0x17000C47 RID: 3143
		// (get) Token: 0x06002F2B RID: 12075 RVA: 0x00079B8A File Offset: 0x00077D8A
		// (set) Token: 0x06002F2C RID: 12076 RVA: 0x00079BB9 File Offset: 0x00077DB9
		public virtual float Speed
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Speed;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.Speed;
			}
			set
			{
				this.GetOrCreatePoco().Speed = value;
			}
		}

		// Token: 0x17000C48 RID: 3144
		// (get) Token: 0x06002F2D RID: 12077 RVA: 0x00079BC7 File Offset: 0x00077DC7
		// (set) Token: 0x06002F2E RID: 12078 RVA: 0x00079BF6 File Offset: 0x00077DF6
		public virtual float Strength
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Strength;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.Strength;
			}
			set
			{
				this.GetOrCreatePoco().Strength = value;
			}
		}

		// Token: 0x04001F35 RID: 7989
		[Nullable(2)]
		protected IWindDirectionalStateGrade FbInstance;

		// Token: 0x04001F36 RID: 7990
		[Nullable(2)]
		protected IWindDirectionalStateGrade_SetValue PocoInterface;
	}
}
