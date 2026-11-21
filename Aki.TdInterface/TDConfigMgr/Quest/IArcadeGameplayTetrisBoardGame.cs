using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02000FDC RID: 4060
	public class IArcadeGameplayTetrisBoardGame : IArcadeGameplayBase
	{
		// Token: 0x06005900 RID: 22784 RVA: 0x000D9968 File Offset: 0x000D7B68
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

		// Token: 0x06005901 RID: 22785 RVA: 0x000D99A0 File Offset: 0x000D7BA0
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

		// Token: 0x06005902 RID: 22786 RVA: 0x000D99B3 File Offset: 0x000D7BB3
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

		// Token: 0x06005903 RID: 22787 RVA: 0x000D99C6 File Offset: 0x000D7BC6
		public new IArcadeGameplayTetrisBoardGame_SetValue ToSetValue()
		{
			return new IArcadeGameplayTetrisBoardGame_SetValue
			{
				Type = this.Type,
				LevelId = this.LevelId
			};
		}

		// Token: 0x17001DB0 RID: 7600
		// (get) Token: 0x06005904 RID: 22788 RVA: 0x000D99E5 File Offset: 0x000D7BE5
		// (set) Token: 0x06005905 RID: 22789 RVA: 0x000D9A10 File Offset: 0x000D7C10
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

		// Token: 0x17001DB1 RID: 7601
		// (get) Token: 0x06005906 RID: 22790 RVA: 0x000D9A1E File Offset: 0x000D7C1E
		// (set) Token: 0x06005907 RID: 22791 RVA: 0x000D9A49 File Offset: 0x000D7C49
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

		// Token: 0x040035A7 RID: 13735
		[Nullable(2)]
		protected new IArcadeGameplayTetrisBoardGame FbInstance;

		// Token: 0x040035A8 RID: 13736
		[Nullable(2)]
		protected new IArcadeGameplayTetrisBoardGame_SetValue PocoInterface;
	}
}
