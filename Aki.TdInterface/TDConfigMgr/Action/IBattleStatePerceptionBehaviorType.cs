using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001806 RID: 6150
	[NullableContext(1)]
	[Nullable(0)]
	public class IBattleStatePerceptionBehaviorType
	{
		// Token: 0x06008409 RID: 33801 RVA: 0x0013AD60 File Offset: 0x00138F60
		private IBattleStatePerceptionBehaviorType_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IBattleStatePerceptionBehaviorType 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IBattleStatePerceptionBehaviorType_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IBattleStatePerceptionBehaviorType_SetValue());
			}
			return result;
		}

		// Token: 0x0600840A RID: 33802 RVA: 0x0013AD98 File Offset: 0x00138F98
		public static IBattleStatePerceptionBehaviorType Create([Nullable(2)] IBattleStatePerceptionBehaviorType instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IBattleStatePerceptionBehaviorType
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600840B RID: 33803 RVA: 0x0013ADAB File Offset: 0x00138FAB
		public static IBattleStatePerceptionBehaviorType CreateFromSetValue([Nullable(2)] IBattleStatePerceptionBehaviorType_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IBattleStatePerceptionBehaviorType
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600840C RID: 33804 RVA: 0x0013ADBE File Offset: 0x00138FBE
		public IBattleStatePerceptionBehaviorType_SetValue ToSetValue()
		{
			return new IBattleStatePerceptionBehaviorType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002B50 RID: 11088
		// (get) Token: 0x0600840D RID: 33805 RVA: 0x0013ADD1 File Offset: 0x00138FD1
		// (set) Token: 0x0600840E RID: 33806 RVA: 0x0013ADFC File Offset: 0x00138FFC
		public virtual EBattleStatePerceptionBehavior Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EBattleStatePerceptionBehavior.NotifyGatherToPlayer;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x040053A5 RID: 21413
		[Nullable(2)]
		protected IBattleStatePerceptionBehaviorType FbInstance;

		// Token: 0x040053A6 RID: 21414
		[Nullable(2)]
		protected IBattleStatePerceptionBehaviorType_SetValue PocoInterface;
	}
}
