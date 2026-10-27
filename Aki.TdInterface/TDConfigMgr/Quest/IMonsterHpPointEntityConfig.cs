using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001013 RID: 4115
	[NullableContext(1)]
	[Nullable(0)]
	public class IMonsterHpPointEntityConfig
	{
		// Token: 0x06005BDA RID: 23514 RVA: 0x000DECA4 File Offset: 0x000DCEA4
		private IMonsterHpPointEntityConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IMonsterHpPointEntityConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IMonsterHpPointEntityConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IMonsterHpPointEntityConfig_SetValue());
			}
			return result;
		}

		// Token: 0x06005BDB RID: 23515 RVA: 0x000DECDC File Offset: 0x000DCEDC
		public static IMonsterHpPointEntityConfig Create([Nullable(2)] IMonsterHpPointEntityConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMonsterHpPointEntityConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x06005BDC RID: 23516 RVA: 0x000DECEF File Offset: 0x000DCEEF
		public static IMonsterHpPointEntityConfig CreateFromSetValue([Nullable(2)] IMonsterHpPointEntityConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IMonsterHpPointEntityConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x06005BDD RID: 23517 RVA: 0x000DED02 File Offset: 0x000DCF02
		public IMonsterHpPointEntityConfig_SetValue ToSetValue()
		{
			return new IMonsterHpPointEntityConfig_SetValue
			{
				EntityId = this.EntityId,
				PointOfEveryOnePercentHp = this.PointOfEveryOnePercentHp
			};
		}

		// Token: 0x17001E52 RID: 7762
		// (get) Token: 0x06005BDE RID: 23518 RVA: 0x000DED21 File Offset: 0x000DCF21
		// (set) Token: 0x06005BDF RID: 23519 RVA: 0x000DED4C File Offset: 0x000DCF4C
		public virtual int EntityId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.EntityId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.EntityId;
			}
			set
			{
				this.GetOrCreatePoco().EntityId = value;
			}
		}

		// Token: 0x17001E53 RID: 7763
		// (get) Token: 0x06005BE0 RID: 23520 RVA: 0x000DED5A File Offset: 0x000DCF5A
		// (set) Token: 0x06005BE1 RID: 23521 RVA: 0x000DED85 File Offset: 0x000DCF85
		public virtual int PointOfEveryOnePercentHp
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.PointOfEveryOnePercentHp;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.PointOfEveryOnePercentHp;
			}
			set
			{
				this.GetOrCreatePoco().PointOfEveryOnePercentHp = value;
			}
		}

		// Token: 0x04003751 RID: 14161
		[Nullable(2)]
		protected IMonsterHpPointEntityConfig FbInstance;

		// Token: 0x04003752 RID: 14162
		[Nullable(2)]
		protected IMonsterHpPointEntityConfig_SetValue PocoInterface;
	}
}
