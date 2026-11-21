using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001645 RID: 5701
	public class ChangeTimer : ActionParams
	{
		// Token: 0x060080A9 RID: 32937 RVA: 0x0013220C File Offset: 0x0013040C
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

		// Token: 0x060080AA RID: 32938 RVA: 0x00132244 File Offset: 0x00130444
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

		// Token: 0x060080AB RID: 32939 RVA: 0x00132257 File Offset: 0x00130457
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

		// Token: 0x060080AC RID: 32940 RVA: 0x0013226A File Offset: 0x0013046A
		public ChangeTimer_SetValue ToSetValue()
		{
			return new ChangeTimer_SetValue
			{
				TimerType = this.TimerType,
				ChangeType = this.ChangeType
			};
		}

		// Token: 0x17002AAC RID: 10924
		// (get) Token: 0x060080AD RID: 32941 RVA: 0x00132289 File Offset: 0x00130489
		// (set) Token: 0x060080AE RID: 32942 RVA: 0x001322B4 File Offset: 0x001304B4
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

		// Token: 0x17002AAD RID: 10925
		// (get) Token: 0x060080AF RID: 32943 RVA: 0x001322C2 File Offset: 0x001304C2
		// (set) Token: 0x060080B0 RID: 32944 RVA: 0x001322E9 File Offset: 0x001304E9
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

		// Token: 0x04004A42 RID: 19010
		[Nullable(2)]
		protected new ChangeTimer FbInstance;

		// Token: 0x04004A43 RID: 19011
		[Nullable(2)]
		protected ChangeTimer_SetValue PocoInterface;
	}
}
