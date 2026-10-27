using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001019 RID: 4121
	[NullableContext(1)]
	[Nullable(0)]
	public class IMonsterPointEntityConfig
	{
		// Token: 0x06005BF6 RID: 23542 RVA: 0x000DEF5C File Offset: 0x000DD15C
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

		// Token: 0x06005BF7 RID: 23543 RVA: 0x000DEF94 File Offset: 0x000DD194
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

		// Token: 0x06005BF8 RID: 23544 RVA: 0x000DEFA7 File Offset: 0x000DD1A7
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

		// Token: 0x06005BF9 RID: 23545 RVA: 0x000DEFBA File Offset: 0x000DD1BA
		public IMonsterPointEntityConfig_SetValue ToSetValue()
		{
			return new IMonsterPointEntityConfig_SetValue
			{
				EntityId = this.EntityId,
				Point = this.Point
			};
		}

		// Token: 0x17001E57 RID: 7767
		// (get) Token: 0x06005BFA RID: 23546 RVA: 0x000DEFD9 File Offset: 0x000DD1D9
		// (set) Token: 0x06005BFB RID: 23547 RVA: 0x000DF004 File Offset: 0x000DD204
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

		// Token: 0x17001E58 RID: 7768
		// (get) Token: 0x06005BFC RID: 23548 RVA: 0x000DF012 File Offset: 0x000DD212
		// (set) Token: 0x06005BFD RID: 23549 RVA: 0x000DF03D File Offset: 0x000DD23D
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

		// Token: 0x0400375C RID: 14172
		[Nullable(2)]
		protected IMonsterPointEntityConfig FbInstance;

		// Token: 0x0400375D RID: 14173
		[Nullable(2)]
		protected IMonsterPointEntityConfig_SetValue PocoInterface;
	}
}
