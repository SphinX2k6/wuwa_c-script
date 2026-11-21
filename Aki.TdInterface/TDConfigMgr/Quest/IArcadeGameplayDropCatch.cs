using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02000FDA RID: 4058
	public class IArcadeGameplayDropCatch : IArcadeGameplayBase
	{
		// Token: 0x060058F6 RID: 22774 RVA: 0x000D9868 File Offset: 0x000D7A68
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

		// Token: 0x060058F7 RID: 22775 RVA: 0x000D98A0 File Offset: 0x000D7AA0
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

		// Token: 0x060058F8 RID: 22776 RVA: 0x000D98B3 File Offset: 0x000D7AB3
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

		// Token: 0x060058F9 RID: 22777 RVA: 0x000D98C6 File Offset: 0x000D7AC6
		public new IArcadeGameplayDropCatch_SetValue ToSetValue()
		{
			return new IArcadeGameplayDropCatch_SetValue
			{
				Type = this.Type,
				LevelId = this.LevelId
			};
		}

		// Token: 0x17001DAE RID: 7598
		// (get) Token: 0x060058FA RID: 22778 RVA: 0x000D98E5 File Offset: 0x000D7AE5
		// (set) Token: 0x060058FB RID: 22779 RVA: 0x000D9910 File Offset: 0x000D7B10
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

		// Token: 0x17001DAF RID: 7599
		// (get) Token: 0x060058FC RID: 22780 RVA: 0x000D991E File Offset: 0x000D7B1E
		// (set) Token: 0x060058FD RID: 22781 RVA: 0x000D9949 File Offset: 0x000D7B49
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

		// Token: 0x040035A3 RID: 13731
		[Nullable(2)]
		protected new IArcadeGameplayDropCatch FbInstance;

		// Token: 0x040035A4 RID: 13732
		[Nullable(2)]
		protected new IArcadeGameplayDropCatch_SetValue PocoInterface;
	}
}
