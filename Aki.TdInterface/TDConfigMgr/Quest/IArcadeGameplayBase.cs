using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02000EC2 RID: 3778
	[NullableContext(1)]
	[Nullable(0)]
	public class IArcadeGameplayBase
	{
		// Token: 0x06005372 RID: 21362 RVA: 0x000CD604 File Offset: 0x000CB804
		private IArcadeGameplayBase_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IArcadeGameplayBase 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IArcadeGameplayBase_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IArcadeGameplayBase_SetValue());
			}
			return result;
		}

		// Token: 0x06005373 RID: 21363 RVA: 0x000CD63C File Offset: 0x000CB83C
		public static IArcadeGameplayBase Create([Nullable(2)] IArcadeGameplayBase instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IArcadeGameplayBase
			{
				FbInstance = instance
			};
		}

		// Token: 0x06005374 RID: 21364 RVA: 0x000CD64F File Offset: 0x000CB84F
		public static IArcadeGameplayBase CreateFromSetValue([Nullable(2)] IArcadeGameplayBase_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IArcadeGameplayBase
			{
				PocoInterface = value
			};
		}

		// Token: 0x06005375 RID: 21365 RVA: 0x000CD662 File Offset: 0x000CB862
		public IArcadeGameplayBase_SetValue ToSetValue()
		{
			return new IArcadeGameplayBase_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17001C15 RID: 7189
		// (get) Token: 0x06005376 RID: 21366 RVA: 0x000CD675 File Offset: 0x000CB875
		// (set) Token: 0x06005377 RID: 21367 RVA: 0x000CD6A0 File Offset: 0x000CB8A0
		public virtual EArcadeGameplayType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EArcadeGameplayType.DropCatch;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04003293 RID: 12947
		[Nullable(2)]
		protected IArcadeGameplayBase FbInstance;

		// Token: 0x04003294 RID: 12948
		[Nullable(2)]
		protected IArcadeGameplayBase_SetValue PocoInterface;
	}
}
