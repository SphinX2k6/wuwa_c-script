using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200197D RID: 6525
	public class IAxisLockScreenConfig : ActionParams
	{
		// Token: 0x06008ACD RID: 35533 RVA: 0x00149B60 File Offset: 0x00147D60
		private IAxisLockScreenConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IAxisLockScreenConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IAxisLockScreenConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IAxisLockScreenConfig_SetValue());
			}
			return result;
		}

		// Token: 0x06008ACE RID: 35534 RVA: 0x00149B98 File Offset: 0x00147D98
		public static IAxisLockScreenConfig Create([Nullable(2)] IAxisLockScreenConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IAxisLockScreenConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x06008ACF RID: 35535 RVA: 0x00149BAB File Offset: 0x00147DAB
		public static IAxisLockScreenConfig CreateFromSetValue([Nullable(2)] IAxisLockScreenConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IAxisLockScreenConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x06008AD0 RID: 35536 RVA: 0x00149BBE File Offset: 0x00147DBE
		public IAxisLockScreenConfig_SetValue ToSetValue()
		{
			return new IAxisLockScreenConfig_SetValue
			{
				TriggerAngle = this.TriggerAngle,
				FadeInTime = this.FadeInTime,
				FadeOutTime = this.FadeOutTime
			};
		}

		// Token: 0x17002D37 RID: 11575
		// (get) Token: 0x06008AD1 RID: 35537 RVA: 0x00149BE9 File Offset: 0x00147DE9
		// (set) Token: 0x06008AD2 RID: 35538 RVA: 0x00149C18 File Offset: 0x00147E18
		public virtual float TriggerAngle
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TriggerAngle;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.TriggerAngle;
			}
			set
			{
				this.GetOrCreatePoco().TriggerAngle = value;
			}
		}

		// Token: 0x17002D38 RID: 11576
		// (get) Token: 0x06008AD3 RID: 35539 RVA: 0x00149C26 File Offset: 0x00147E26
		// (set) Token: 0x06008AD4 RID: 35540 RVA: 0x00149C55 File Offset: 0x00147E55
		public virtual float FadeInTime
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.FadeInTime;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.FadeInTime;
			}
			set
			{
				this.GetOrCreatePoco().FadeInTime = value;
			}
		}

		// Token: 0x17002D39 RID: 11577
		// (get) Token: 0x06008AD5 RID: 35541 RVA: 0x00149C63 File Offset: 0x00147E63
		// (set) Token: 0x06008AD6 RID: 35542 RVA: 0x00149C92 File Offset: 0x00147E92
		public virtual float FadeOutTime
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.FadeOutTime;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.FadeOutTime;
			}
			set
			{
				this.GetOrCreatePoco().FadeOutTime = value;
			}
		}

		// Token: 0x040057CA RID: 22474
		[Nullable(2)]
		protected new IAxisLockScreenConfig FbInstance;

		// Token: 0x040057CB RID: 22475
		[Nullable(2)]
		protected IAxisLockScreenConfig_SetValue PocoInterface;
	}
}
