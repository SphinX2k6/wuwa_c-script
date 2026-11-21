using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200198F RID: 6543
	public class IBattleStatePerceptionBehaviorType
	{
		// Token: 0x06008B25 RID: 35621 RVA: 0x0014A448 File Offset: 0x00148648
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

		// Token: 0x06008B26 RID: 35622 RVA: 0x0014A480 File Offset: 0x00148680
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

		// Token: 0x06008B27 RID: 35623 RVA: 0x0014A493 File Offset: 0x00148693
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

		// Token: 0x06008B28 RID: 35624 RVA: 0x0014A4A6 File Offset: 0x001486A6
		public IBattleStatePerceptionBehaviorType_SetValue ToSetValue()
		{
			return new IBattleStatePerceptionBehaviorType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002D48 RID: 11592
		// (get) Token: 0x06008B29 RID: 35625 RVA: 0x0014A4B9 File Offset: 0x001486B9
		// (set) Token: 0x06008B2A RID: 35626 RVA: 0x0014A4E4 File Offset: 0x001486E4
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

		// Token: 0x040057ED RID: 22509
		[Nullable(2)]
		protected IBattleStatePerceptionBehaviorType FbInstance;

		// Token: 0x040057EE RID: 22510
		[Nullable(2)]
		protected IBattleStatePerceptionBehaviorType_SetValue PocoInterface;
	}
}
