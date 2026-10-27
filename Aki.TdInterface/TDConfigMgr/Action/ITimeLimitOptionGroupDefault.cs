using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001FC4 RID: 8132
	[NullableContext(1)]
	[Nullable(0)]
	public class ITimeLimitOptionGroupDefault : ITimeLimitOptionGroupBaseStyle
	{
		// Token: 0x0600B2E2 RID: 45794 RVA: 0x001A0B90 File Offset: 0x0019ED90
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

		// Token: 0x0600B2E3 RID: 45795 RVA: 0x001A0BC8 File Offset: 0x0019EDC8
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

		// Token: 0x0600B2E4 RID: 45796 RVA: 0x001A0BDB File Offset: 0x0019EDDB
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

		// Token: 0x0600B2E5 RID: 45797 RVA: 0x001A0BEE File Offset: 0x0019EDEE
		public new ITimeLimitOptionGroupDefault_SetValue ToSetValue()
		{
			return new ITimeLimitOptionGroupDefault_SetValue
			{
				Type = this.Type,
				TimeoutOptionIndex = this.TimeoutOptionIndex,
				TimeLimit = this.TimeLimit
			};
		}

		// Token: 0x17003723 RID: 14115
		// (get) Token: 0x0600B2E6 RID: 45798 RVA: 0x001A0C19 File Offset: 0x0019EE19
		// (set) Token: 0x0600B2E7 RID: 45799 RVA: 0x001A0C44 File Offset: 0x0019EE44
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

		// Token: 0x17003724 RID: 14116
		// (get) Token: 0x0600B2E8 RID: 45800 RVA: 0x001A0C52 File Offset: 0x0019EE52
		// (set) Token: 0x0600B2E9 RID: 45801 RVA: 0x001A0C7D File Offset: 0x0019EE7D
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

		// Token: 0x17003725 RID: 14117
		// (get) Token: 0x0600B2EA RID: 45802 RVA: 0x001A0C8B File Offset: 0x0019EE8B
		// (set) Token: 0x0600B2EB RID: 45803 RVA: 0x001A0CBA File Offset: 0x0019EEBA
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

		// Token: 0x04006BFE RID: 27646
		[Nullable(2)]
		protected new ITimeLimitOptionGroupDefault FbInstance;

		// Token: 0x04006BFF RID: 27647
		[Nullable(2)]
		protected new ITimeLimitOptionGroupDefault_SetValue PocoInterface;
	}
}
