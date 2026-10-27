using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020017F4 RID: 6132
	[NullableContext(1)]
	[Nullable(0)]
	public class IAxisLockScreenConfig : ActionParams
	{
		// Token: 0x060083B1 RID: 33713 RVA: 0x0013A478 File Offset: 0x00138678
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

		// Token: 0x060083B2 RID: 33714 RVA: 0x0013A4B0 File Offset: 0x001386B0
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

		// Token: 0x060083B3 RID: 33715 RVA: 0x0013A4C3 File Offset: 0x001386C3
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

		// Token: 0x060083B4 RID: 33716 RVA: 0x0013A4D6 File Offset: 0x001386D6
		public IAxisLockScreenConfig_SetValue ToSetValue()
		{
			return new IAxisLockScreenConfig_SetValue
			{
				TriggerAngle = this.TriggerAngle,
				FadeInTime = this.FadeInTime,
				FadeOutTime = this.FadeOutTime
			};
		}

		// Token: 0x17002B3F RID: 11071
		// (get) Token: 0x060083B5 RID: 33717 RVA: 0x0013A501 File Offset: 0x00138701
		// (set) Token: 0x060083B6 RID: 33718 RVA: 0x0013A530 File Offset: 0x00138730
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

		// Token: 0x17002B40 RID: 11072
		// (get) Token: 0x060083B7 RID: 33719 RVA: 0x0013A53E File Offset: 0x0013873E
		// (set) Token: 0x060083B8 RID: 33720 RVA: 0x0013A56D File Offset: 0x0013876D
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

		// Token: 0x17002B41 RID: 11073
		// (get) Token: 0x060083B9 RID: 33721 RVA: 0x0013A57B File Offset: 0x0013877B
		// (set) Token: 0x060083BA RID: 33722 RVA: 0x0013A5AA File Offset: 0x001387AA
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

		// Token: 0x04005382 RID: 21378
		[Nullable(2)]
		protected new IAxisLockScreenConfig FbInstance;

		// Token: 0x04005383 RID: 21379
		[Nullable(2)]
		protected IAxisLockScreenConfig_SetValue PocoInterface;
	}
}
