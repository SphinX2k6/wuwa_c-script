using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001145 RID: 4421
	public class IMonsterPointEntityConfig
	{
		// Token: 0x060061D8 RID: 25048 RVA: 0x000EBC54 File Offset: 0x000E9E54
		private IMonsterPointEntityConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IMonsterPointEntityConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IMonsterPointEntityConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IMonsterPointEntityConfig_SetValue());
			}
			return result;
		}

		// Token: 0x060061D9 RID: 25049 RVA: 0x000EBC8C File Offset: 0x000E9E8C
		public static IMonsterPointEntityConfig Create([Nullable(2)] IMonsterPointEntityConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMonsterPointEntityConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x060061DA RID: 25050 RVA: 0x000EBC9F File Offset: 0x000E9E9F
		public static IMonsterPointEntityConfig CreateFromSetValue([Nullable(2)] IMonsterPointEntityConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IMonsterPointEntityConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x060061DB RID: 25051 RVA: 0x000EBCB2 File Offset: 0x000E9EB2
		public IMonsterPointEntityConfig_SetValue ToSetValue()
		{
			return new IMonsterPointEntityConfig_SetValue
			{
				EntityId = this.EntityId,
				Point = this.Point
			};
		}

		// Token: 0x17002001 RID: 8193
		// (get) Token: 0x060061DC RID: 25052 RVA: 0x000EBCD1 File Offset: 0x000E9ED1
		// (set) Token: 0x060061DD RID: 25053 RVA: 0x000EBCFC File Offset: 0x000E9EFC
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

		// Token: 0x17002002 RID: 8194
		// (get) Token: 0x060061DE RID: 25054 RVA: 0x000EBD0A File Offset: 0x000E9F0A
		// (set) Token: 0x060061DF RID: 25055 RVA: 0x000EBD35 File Offset: 0x000E9F35
		public virtual int Point
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Point;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.Point;
			}
			set
			{
				this.GetOrCreatePoco().Point = value;
			}
		}

		// Token: 0x04003A97 RID: 14999
		[Nullable(2)]
		protected IMonsterPointEntityConfig FbInstance;

		// Token: 0x04003A98 RID: 15000
		[Nullable(2)]
		protected IMonsterPointEntityConfig_SetValue PocoInterface;
	}
}
