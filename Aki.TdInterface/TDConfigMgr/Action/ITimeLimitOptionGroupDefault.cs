using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002209 RID: 8713
	public class ITimeLimitOptionGroupDefault : ITimeLimitOptionGroupBaseStyle
	{
		// Token: 0x0600BDF0 RID: 48624 RVA: 0x001B7040 File Offset: 0x001B5240
		private ITimeLimitOptionGroupDefault_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ITimeLimitOptionGroupDefault 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ITimeLimitOptionGroupDefault_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ITimeLimitOptionGroupDefault_SetValue());
			}
			return result;
		}

		// Token: 0x0600BDF1 RID: 48625 RVA: 0x001B7078 File Offset: 0x001B5278
		public static ITimeLimitOptionGroupDefault Create([Nullable(2)] ITimeLimitOptionGroupDefault instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITimeLimitOptionGroupDefault
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600BDF2 RID: 48626 RVA: 0x001B708B File Offset: 0x001B528B
		public static ITimeLimitOptionGroupDefault CreateFromSetValue([Nullable(2)] ITimeLimitOptionGroupDefault_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ITimeLimitOptionGroupDefault
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600BDF3 RID: 48627 RVA: 0x001B709E File Offset: 0x001B529E
		public new ITimeLimitOptionGroupDefault_SetValue ToSetValue()
		{
			return new ITimeLimitOptionGroupDefault_SetValue
			{
				Type = this.Type,
				TimeoutOptionIndex = this.TimeoutOptionIndex,
				TimeLimit = this.TimeLimit
			};
		}

		// Token: 0x170039FA RID: 14842
		// (get) Token: 0x0600BDF4 RID: 48628 RVA: 0x001B70C9 File Offset: 0x001B52C9
		// (set) Token: 0x0600BDF5 RID: 48629 RVA: 0x001B70F4 File Offset: 0x001B52F4
		public override ETimeLimitOptionGroupStyle Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ETimeLimitOptionGroupStyle.Default;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x170039FB RID: 14843
		// (get) Token: 0x0600BDF6 RID: 48630 RVA: 0x001B7102 File Offset: 0x001B5302
		// (set) Token: 0x0600BDF7 RID: 48631 RVA: 0x001B712D File Offset: 0x001B532D
		public virtual int TimeoutOptionIndex
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TimeoutOptionIndex;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.TimeoutOptionIndex;
			}
			set
			{
				this.GetOrCreatePoco().TimeoutOptionIndex = value;
			}
		}

		// Token: 0x170039FC RID: 14844
		// (get) Token: 0x0600BDF8 RID: 48632 RVA: 0x001B713B File Offset: 0x001B533B
		// (set) Token: 0x0600BDF9 RID: 48633 RVA: 0x001B716A File Offset: 0x001B536A
		public virtual float TimeLimit
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TimeLimit;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.TimeLimit;
			}
			set
			{
				this.GetOrCreatePoco().TimeLimit = value;
			}
		}

		// Token: 0x040071FD RID: 29181
		[Nullable(2)]
		protected new ITimeLimitOptionGroupDefault FbInstance;

		// Token: 0x040071FE RID: 29182
		[Nullable(2)]
		protected new ITimeLimitOptionGroupDefault_SetValue PocoInterface;
	}
}
