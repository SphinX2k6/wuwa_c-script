using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001E8F RID: 7823
	public class IOnetimeGamepadShake : IGamepadShakeConfig
	{
		// Token: 0x0600A64F RID: 42575 RVA: 0x0017AEA4 File Offset: 0x001790A4
		private IOnetimeGamepadShake_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IOnetimeGamepadShake 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IOnetimeGamepadShake_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IOnetimeGamepadShake_SetValue());
			}
			return result;
		}

		// Token: 0x0600A650 RID: 42576 RVA: 0x0017AEDC File Offset: 0x001790DC
		public static IOnetimeGamepadShake Create([Nullable(2)] IOnetimeGamepadShake instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IOnetimeGamepadShake
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A651 RID: 42577 RVA: 0x0017AEEF File Offset: 0x001790EF
		public static IOnetimeGamepadShake CreateFromSetValue([Nullable(2)] IOnetimeGamepadShake_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IOnetimeGamepadShake
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A652 RID: 42578 RVA: 0x0017AF02 File Offset: 0x00179102
		public new IOnetimeGamepadShake_SetValue ToSetValue()
		{
			return new IOnetimeGamepadShake_SetValue
			{
				Type = this.Type,
				IsIgnoreTimeDilation = this.IsIgnoreTimeDilation,
				GamepadShakeTag = this.GamepadShakeTag
			};
		}

		// Token: 0x1700335F RID: 13151
		// (get) Token: 0x0600A653 RID: 42579 RVA: 0x0017AF2D File Offset: 0x0017912D
		// (set) Token: 0x0600A654 RID: 42580 RVA: 0x0017AF58 File Offset: 0x00179158
		public override EGamepadShakeType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EGamepadShakeType.Onetime;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17003360 RID: 13152
		// (get) Token: 0x0600A655 RID: 42581 RVA: 0x0017AF68 File Offset: 0x00179168
		// (set) Token: 0x0600A656 RID: 42582 RVA: 0x0017AFA2 File Offset: 0x001791A2
		public virtual bool? IsIgnoreTimeDilation
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IsIgnoreTimeDilation;
				}
				IOnetimeGamepadShake_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.IsIgnoreTimeDilation;
			}
			set
			{
				this.GetOrCreatePoco().IsIgnoreTimeDilation = value;
			}
		}

		// Token: 0x17003361 RID: 13153
		// (get) Token: 0x0600A657 RID: 42583 RVA: 0x0017AFB0 File Offset: 0x001791B0
		// (set) Token: 0x0600A658 RID: 42584 RVA: 0x0017AFD7 File Offset: 0x001791D7
		[Nullable(2)]
		public virtual string GamepadShakeTag
		{
			[NullableContext(2)]
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.GamepadShakeTag;
				}
				IOnetimeGamepadShake_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.GamepadShakeTag;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().GamepadShakeTag = value;
			}
		}

		// Token: 0x04006450 RID: 25680
		[Nullable(2)]
		protected new IOnetimeGamepadShake FbInstance;

		// Token: 0x04006451 RID: 25681
		[Nullable(2)]
		protected new IOnetimeGamepadShake_SetValue PocoInterface;
	}
}
