using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02000EC6 RID: 3782
	[NullableContext(1)]
	[Nullable(0)]
	public class IArcadeGameplayTetrisBoardGame : IArcadeGameplayBase
	{
		// Token: 0x06005384 RID: 21380 RVA: 0x000CD7C0 File Offset: 0x000CB9C0
		private IArcadeGameplayTetrisBoardGame_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IArcadeGameplayTetrisBoardGame 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IArcadeGameplayTetrisBoardGame_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IArcadeGameplayTetrisBoardGame_SetValue());
			}
			return result;
		}

		// Token: 0x06005385 RID: 21381 RVA: 0x000CD7F8 File Offset: 0x000CB9F8
		public static IArcadeGameplayTetrisBoardGame Create([Nullable(2)] IArcadeGameplayTetrisBoardGame instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IArcadeGameplayTetrisBoardGame
			{
				FbInstance = instance
			};
		}

		// Token: 0x06005386 RID: 21382 RVA: 0x000CD80B File Offset: 0x000CBA0B
		public static IArcadeGameplayTetrisBoardGame CreateFromSetValue([Nullable(2)] IArcadeGameplayTetrisBoardGame_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IArcadeGameplayTetrisBoardGame
			{
				PocoInterface = value
			};
		}

		// Token: 0x06005387 RID: 21383 RVA: 0x000CD81E File Offset: 0x000CBA1E
		public new IArcadeGameplayTetrisBoardGame_SetValue ToSetValue()
		{
			return new IArcadeGameplayTetrisBoardGame_SetValue
			{
				Type = this.Type,
				LevelId = this.LevelId
			};
		}

		// Token: 0x17001C18 RID: 7192
		// (get) Token: 0x06005388 RID: 21384 RVA: 0x000CD83D File Offset: 0x000CBA3D
		// (set) Token: 0x06005389 RID: 21385 RVA: 0x000CD868 File Offset: 0x000CBA68
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

		// Token: 0x17001C19 RID: 7193
		// (get) Token: 0x0600538A RID: 21386 RVA: 0x000CD876 File Offset: 0x000CBA76
		// (set) Token: 0x0600538B RID: 21387 RVA: 0x000CD8A1 File Offset: 0x000CBAA1
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

		// Token: 0x0400329A RID: 12954
		[Nullable(2)]
		protected new IArcadeGameplayTetrisBoardGame FbInstance;

		// Token: 0x0400329B RID: 12955
		[Nullable(2)]
		protected new IArcadeGameplayTetrisBoardGame_SetValue PocoInterface;
	}
}
