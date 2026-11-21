using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001F9D RID: 8093
	public class IRedNameMonsterTip : ICommonTipType
	{
		// Token: 0x0600AC0D RID: 44045 RVA: 0x001852BC File Offset: 0x001834BC
		private IRedNameMonsterTip_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IRedNameMonsterTip 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IRedNameMonsterTip_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IRedNameMonsterTip_SetValue());
			}
			return result;
		}

		// Token: 0x0600AC0E RID: 44046 RVA: 0x001852F4 File Offset: 0x001834F4
		public static IRedNameMonsterTip Create([Nullable(2)] IRedNameMonsterTip instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IRedNameMonsterTip
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600AC0F RID: 44047 RVA: 0x00185307 File Offset: 0x00183507
		public static IRedNameMonsterTip CreateFromSetValue([Nullable(2)] IRedNameMonsterTip_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IRedNameMonsterTip
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600AC10 RID: 44048 RVA: 0x0018531A File Offset: 0x0018351A
		public new IRedNameMonsterTip_SetValue ToSetValue()
		{
			return new IRedNameMonsterTip_SetValue
			{
				Type = this.Type,
				MonsterId = this.MonsterId,
				Duration = this.Duration
			};
		}

		// Token: 0x170034A9 RID: 13481
		// (get) Token: 0x0600AC11 RID: 44049 RVA: 0x00185345 File Offset: 0x00183545
		// (set) Token: 0x0600AC12 RID: 44050 RVA: 0x00185370 File Offset: 0x00183570
		public override ECommonTipType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ECommonTipType.ChallengeCondition;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x170034AA RID: 13482
		// (get) Token: 0x0600AC13 RID: 44051 RVA: 0x0018537E File Offset: 0x0018357E
		// (set) Token: 0x0600AC14 RID: 44052 RVA: 0x001853A9 File Offset: 0x001835A9
		public virtual int MonsterId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.MonsterId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.MonsterId;
			}
			set
			{
				this.GetOrCreatePoco().MonsterId = value;
			}
		}

		// Token: 0x170034AB RID: 13483
		// (get) Token: 0x0600AC15 RID: 44053 RVA: 0x001853B7 File Offset: 0x001835B7
		// (set) Token: 0x0600AC16 RID: 44054 RVA: 0x001853E6 File Offset: 0x001835E6
		public virtual float Duration
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Duration;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.Duration;
			}
			set
			{
				this.GetOrCreatePoco().Duration = value;
			}
		}

		// Token: 0x040066E8 RID: 26344
		[Nullable(2)]
		protected new IRedNameMonsterTip FbInstance;

		// Token: 0x040066E9 RID: 26345
		[Nullable(2)]
		protected new IRedNameMonsterTip_SetValue PocoInterface;
	}
}
