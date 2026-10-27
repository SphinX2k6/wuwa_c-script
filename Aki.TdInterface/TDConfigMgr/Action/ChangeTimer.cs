using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020014EC RID: 5356
	[NullableContext(1)]
	[Nullable(0)]
	public class ChangeTimer : ActionParams
	{
		// Token: 0x060079DC RID: 31196 RVA: 0x001235D4 File Offset: 0x001217D4
		private ChangeTimer_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ChangeTimer 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ChangeTimer_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ChangeTimer_SetValue());
			}
			return result;
		}

		// Token: 0x060079DD RID: 31197 RVA: 0x0012360C File Offset: 0x0012180C
		public static ChangeTimer Create([Nullable(2)] ChangeTimer instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ChangeTimer
			{
				FbInstance = instance
			};
		}

		// Token: 0x060079DE RID: 31198 RVA: 0x0012361F File Offset: 0x0012181F
		public static ChangeTimer CreateFromSetValue([Nullable(2)] ChangeTimer_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ChangeTimer
			{
				PocoInterface = value
			};
		}

		// Token: 0x060079DF RID: 31199 RVA: 0x00123632 File Offset: 0x00121832
		public ChangeTimer_SetValue ToSetValue()
		{
			return new ChangeTimer_SetValue
			{
				TimerType = this.TimerType,
				ChangeType = this.ChangeType
			};
		}

		// Token: 0x170028C2 RID: 10434
		// (get) Token: 0x060079E0 RID: 31200 RVA: 0x00123651 File Offset: 0x00121851
		// (set) Token: 0x060079E1 RID: 31201 RVA: 0x0012367C File Offset: 0x0012187C
		public virtual ETimerType TimerType
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TimerType;
				}
				if (this.PocoInterface == null)
				{
					return ETimerType.CountDownChallenge;
				}
				return this.PocoInterface.TimerType;
			}
			set
			{
				this.GetOrCreatePoco().TimerType = value;
			}
		}

		// Token: 0x170028C3 RID: 10435
		// (get) Token: 0x060079E2 RID: 31202 RVA: 0x0012368A File Offset: 0x0012188A
		// (set) Token: 0x060079E3 RID: 31203 RVA: 0x001236B1 File Offset: 0x001218B1
		public virtual IChangeTimerType ChangeType
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ChangeType;
				}
				ChangeTimer_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.ChangeType;
			}
			set
			{
				this.GetOrCreatePoco().ChangeType = value;
			}
		}

		// Token: 0x040046A7 RID: 18087
		[Nullable(2)]
		protected new ChangeTimer FbInstance;

		// Token: 0x040046A8 RID: 18088
		[Nullable(2)]
		protected ChangeTimer_SetValue PocoInterface;
	}
}
