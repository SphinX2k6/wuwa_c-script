using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02000EC4 RID: 3780
	[NullableContext(1)]
	[Nullable(0)]
	public class IArcadeGameplayDropCatch : IArcadeGameplayBase
	{
		// Token: 0x0600537A RID: 21370 RVA: 0x000CD6C0 File Offset: 0x000CB8C0
		private IArcadeGameplayDropCatch_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IArcadeGameplayDropCatch 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IArcadeGameplayDropCatch_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IArcadeGameplayDropCatch_SetValue());
			}
			return result;
		}

		// Token: 0x0600537B RID: 21371 RVA: 0x000CD6F8 File Offset: 0x000CB8F8
		public static IArcadeGameplayDropCatch Create([Nullable(2)] IArcadeGameplayDropCatch instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IArcadeGameplayDropCatch
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600537C RID: 21372 RVA: 0x000CD70B File Offset: 0x000CB90B
		public static IArcadeGameplayDropCatch CreateFromSetValue([Nullable(2)] IArcadeGameplayDropCatch_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IArcadeGameplayDropCatch
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600537D RID: 21373 RVA: 0x000CD71E File Offset: 0x000CB91E
		public new IArcadeGameplayDropCatch_SetValue ToSetValue()
		{
			return new IArcadeGameplayDropCatch_SetValue
			{
				Type = this.Type,
				LevelId = this.LevelId
			};
		}

		// Token: 0x17001C16 RID: 7190
		// (get) Token: 0x0600537E RID: 21374 RVA: 0x000CD73D File Offset: 0x000CB93D
		// (set) Token: 0x0600537F RID: 21375 RVA: 0x000CD768 File Offset: 0x000CB968
		public override EArcadeGameplayType Type
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

		// Token: 0x17001C17 RID: 7191
		// (get) Token: 0x06005380 RID: 21376 RVA: 0x000CD776 File Offset: 0x000CB976
		// (set) Token: 0x06005381 RID: 21377 RVA: 0x000CD7A1 File Offset: 0x000CB9A1
		public virtual int LevelId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.LevelId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.LevelId;
			}
			set
			{
				this.GetOrCreatePoco().LevelId = value;
			}
		}

		// Token: 0x04003296 RID: 12950
		[Nullable(2)]
		protected new IArcadeGameplayDropCatch FbInstance;

		// Token: 0x04003297 RID: 12951
		[Nullable(2)]
		protected new IArcadeGameplayDropCatch_SetValue PocoInterface;
	}
}
