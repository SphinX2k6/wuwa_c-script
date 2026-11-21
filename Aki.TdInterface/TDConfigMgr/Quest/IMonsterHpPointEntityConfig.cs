using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x0200113F RID: 4415
	public class IMonsterHpPointEntityConfig
	{
		// Token: 0x060061BC RID: 25020 RVA: 0x000EB99C File Offset: 0x000E9B9C
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

		// Token: 0x060061BD RID: 25021 RVA: 0x000EB9D4 File Offset: 0x000E9BD4
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

		// Token: 0x060061BE RID: 25022 RVA: 0x000EB9E7 File Offset: 0x000E9BE7
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

		// Token: 0x060061BF RID: 25023 RVA: 0x000EB9FA File Offset: 0x000E9BFA
		public IMonsterHpPointEntityConfig_SetValue ToSetValue()
		{
			return new IMonsterHpPointEntityConfig_SetValue
			{
				EntityId = this.EntityId,
				PointOfEveryOnePercentHp = this.PointOfEveryOnePercentHp
			};
		}

		// Token: 0x17001FFC RID: 8188
		// (get) Token: 0x060061C0 RID: 25024 RVA: 0x000EBA19 File Offset: 0x000E9C19
		// (set) Token: 0x060061C1 RID: 25025 RVA: 0x000EBA44 File Offset: 0x000E9C44
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

		// Token: 0x17001FFD RID: 8189
		// (get) Token: 0x060061C2 RID: 25026 RVA: 0x000EBA52 File Offset: 0x000E9C52
		// (set) Token: 0x060061C3 RID: 25027 RVA: 0x000EBA7D File Offset: 0x000E9C7D
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

		// Token: 0x04003A8C RID: 14988
		[Nullable(2)]
		protected IMonsterHpPointEntityConfig FbInstance;

		// Token: 0x04003A8D RID: 14989
		[Nullable(2)]
		protected IMonsterHpPointEntityConfig_SetValue PocoInterface;
	}
}
