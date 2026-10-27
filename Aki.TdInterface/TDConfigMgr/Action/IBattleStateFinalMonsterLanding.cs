using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001800 RID: 6144
	[NullableContext(1)]
	[Nullable(0)]
	public class IBattleStateFinalMonsterLanding : ISetBattleTagType
	{
		// Token: 0x060083F1 RID: 33777 RVA: 0x0013AB2C File Offset: 0x00138D2C
		private IBattleStateFinalMonsterLanding_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IBattleStateFinalMonsterLanding 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IBattleStateFinalMonsterLanding_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IBattleStateFinalMonsterLanding_SetValue());
			}
			return result;
		}

		// Token: 0x060083F2 RID: 33778 RVA: 0x0013AB64 File Offset: 0x00138D64
		public static IBattleStateFinalMonsterLanding Create([Nullable(2)] IBattleStateFinalMonsterLanding instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IBattleStateFinalMonsterLanding
			{
				FbInstance = instance
			};
		}

		// Token: 0x060083F3 RID: 33779 RVA: 0x0013AB77 File Offset: 0x00138D77
		public static IBattleStateFinalMonsterLanding CreateFromSetValue([Nullable(2)] IBattleStateFinalMonsterLanding_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IBattleStateFinalMonsterLanding
			{
				PocoInterface = value
			};
		}

		// Token: 0x060083F4 RID: 33780 RVA: 0x0013AB8A File Offset: 0x00138D8A
		public new IBattleStateFinalMonsterLanding_SetValue ToSetValue()
		{
			return new IBattleStateFinalMonsterLanding_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002B4D RID: 11085
		// (get) Token: 0x060083F5 RID: 33781 RVA: 0x0013AB9D File Offset: 0x00138D9D
		// (set) Token: 0x060083F6 RID: 33782 RVA: 0x0013ABC8 File Offset: 0x00138DC8
		public override ESetBattleTagType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ESetBattleTagType.BattleMonsterLanding;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x0400539C RID: 21404
		[Nullable(2)]
		protected new IBattleStateFinalMonsterLanding FbInstance;

		// Token: 0x0400539D RID: 21405
		[Nullable(2)]
		protected new IBattleStateFinalMonsterLanding_SetValue PocoInterface;
	}
}
