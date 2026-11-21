using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02000FD8 RID: 4056
	public class IArcadeGameplayBase
	{
		// Token: 0x060058EE RID: 22766 RVA: 0x000D97AC File Offset: 0x000D79AC
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

		// Token: 0x060058EF RID: 22767 RVA: 0x000D97E4 File Offset: 0x000D79E4
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

		// Token: 0x060058F0 RID: 22768 RVA: 0x000D97F7 File Offset: 0x000D79F7
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

		// Token: 0x060058F1 RID: 22769 RVA: 0x000D980A File Offset: 0x000D7A0A
		public IArcadeGameplayBase_SetValue ToSetValue()
		{
			return new IArcadeGameplayBase_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17001DAD RID: 7597
		// (get) Token: 0x060058F2 RID: 22770 RVA: 0x000D981D File Offset: 0x000D7A1D
		// (set) Token: 0x060058F3 RID: 22771 RVA: 0x000D9848 File Offset: 0x000D7A48
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

		// Token: 0x040035A0 RID: 13728
		[Nullable(2)]
		protected IArcadeGameplayBase FbInstance;

		// Token: 0x040035A1 RID: 13729
		[Nullable(2)]
		protected IArcadeGameplayBase_SetValue PocoInterface;
	}
}
