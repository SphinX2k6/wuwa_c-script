using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001C8A RID: 7306
	[NullableContext(2)]
	[Nullable(0)]
	public class IOnetimeGamepadShake : IGamepadShakeConfig
	{
		// Token: 0x06009CB5 RID: 40117 RVA: 0x001674B0 File Offset: 0x001656B0
		[NullableContext(1)]
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

		// Token: 0x06009CB6 RID: 40118 RVA: 0x001674E8 File Offset: 0x001656E8
		[NullableContext(1)]
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

		// Token: 0x06009CB7 RID: 40119 RVA: 0x001674FB File Offset: 0x001656FB
		[NullableContext(1)]
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

		// Token: 0x06009CB8 RID: 40120 RVA: 0x0016750E File Offset: 0x0016570E
		[NullableContext(1)]
		public new IOnetimeGamepadShake_SetValue ToSetValue()
		{
			return new IOnetimeGamepadShake_SetValue
			{
				Type = this.Type,
				IsIgnoreTimeDilation = this.IsIgnoreTimeDilation,
				GamepadShakeTag = this.GamepadShakeTag
			};
		}

		// Token: 0x170030E2 RID: 12514
		// (get) Token: 0x06009CB9 RID: 40121 RVA: 0x00167539 File Offset: 0x00165739
		// (set) Token: 0x06009CBA RID: 40122 RVA: 0x00167564 File Offset: 0x00165764
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

		// Token: 0x170030E3 RID: 12515
		// (get) Token: 0x06009CBB RID: 40123 RVA: 0x00167574 File Offset: 0x00165774
		// (set) Token: 0x06009CBC RID: 40124 RVA: 0x001675AE File Offset: 0x001657AE
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

		// Token: 0x170030E4 RID: 12516
		// (get) Token: 0x06009CBD RID: 40125 RVA: 0x001675BC File Offset: 0x001657BC
		// (set) Token: 0x06009CBE RID: 40126 RVA: 0x001675E3 File Offset: 0x001657E3
		public virtual string GamepadShakeTag
		{
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
			set
			{
				this.GetOrCreatePoco().GamepadShakeTag = value;
			}
		}

		// Token: 0x04005EFD RID: 24317
		protected new IOnetimeGamepadShake FbInstance;

		// Token: 0x04005EFE RID: 24318
		protected new IOnetimeGamepadShake_SetValue PocoInterface;
	}
}
