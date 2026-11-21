using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007EEC RID: 32492
	public class TGamepadShakeConfigUnion
	{
		// Token: 0x1700F26B RID: 62059
		// (get) Token: 0x0603A9F9 RID: 240121 RVA: 0x007E2FA6 File Offset: 0x007E11A6
		// (set) Token: 0x0603A9FA RID: 240122 RVA: 0x007E2FAE File Offset: 0x007E11AE
		public TGamepadShakeConfig Type { get; set; }

		// Token: 0x1700F26C RID: 62060
		// (get) Token: 0x0603A9FB RID: 240123 RVA: 0x007E2FB7 File Offset: 0x007E11B7
		// (set) Token: 0x0603A9FC RID: 240124 RVA: 0x007E2FBF File Offset: 0x007E11BF
		public object Value { get; set; }

		// Token: 0x0603A9FD RID: 240125 RVA: 0x007E2FC8 File Offset: 0x007E11C8
		public TGamepadShakeConfigUnion()
		{
			this.Type = TGamepadShakeConfig.NONE;
			this.Value = null;
		}

		// Token: 0x0603A9FE RID: 240126 RVA: 0x007E2FDE File Offset: 0x007E11DE
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0603A9FF RID: 240127 RVA: 0x007E2FF0 File Offset: 0x007E11F0
		public IAttenuatedGamepadShakeT AsIAttenuatedGamepadShake()
		{
			return this.As<IAttenuatedGamepadShakeT>();
		}

		// Token: 0x0603AA00 RID: 240128 RVA: 0x007E2FF8 File Offset: 0x007E11F8
		public static TGamepadShakeConfigUnion FromIAttenuatedGamepadShake(IAttenuatedGamepadShakeT _iattenuatedgamepadshake)
		{
			return new TGamepadShakeConfigUnion
			{
				Type = TGamepadShakeConfig.IAttenuatedGamepadShake,
				Value = _iattenuatedgamepadshake
			};
		}

		// Token: 0x0603AA01 RID: 240129 RVA: 0x007E300D File Offset: 0x007E120D
		public IContinualGamepadShakeT AsIContinualGamepadShake()
		{
			return this.As<IContinualGamepadShakeT>();
		}

		// Token: 0x0603AA02 RID: 240130 RVA: 0x007E3015 File Offset: 0x007E1215
		public static TGamepadShakeConfigUnion FromIContinualGamepadShake(IContinualGamepadShakeT _icontinualgamepadshake)
		{
			return new TGamepadShakeConfigUnion
			{
				Type = TGamepadShakeConfig.IContinualGamepadShake,
				Value = _icontinualgamepadshake
			};
		}

		// Token: 0x0603AA03 RID: 240131 RVA: 0x007E302A File Offset: 0x007E122A
		public IMp4GamepadShakeT AsIMp4GamepadShake()
		{
			return this.As<IMp4GamepadShakeT>();
		}

		// Token: 0x0603AA04 RID: 240132 RVA: 0x007E3032 File Offset: 0x007E1232
		public static TGamepadShakeConfigUnion FromIMp4GamepadShake(IMp4GamepadShakeT _imp4gamepadshake)
		{
			return new TGamepadShakeConfigUnion
			{
				Type = TGamepadShakeConfig.IMp4GamepadShake,
				Value = _imp4gamepadshake
			};
		}

		// Token: 0x0603AA05 RID: 240133 RVA: 0x007E3047 File Offset: 0x007E1247
		public IOnetimeGamepadShakeT AsIOnetimeGamepadShake()
		{
			return this.As<IOnetimeGamepadShakeT>();
		}

		// Token: 0x0603AA06 RID: 240134 RVA: 0x007E304F File Offset: 0x007E124F
		public static TGamepadShakeConfigUnion FromIOnetimeGamepadShake(IOnetimeGamepadShakeT _ionetimegamepadshake)
		{
			return new TGamepadShakeConfigUnion
			{
				Type = TGamepadShakeConfig.IOnetimeGamepadShake,
				Value = _ionetimegamepadshake
			};
		}

		// Token: 0x0603AA07 RID: 240135 RVA: 0x007E3064 File Offset: 0x007E1264
		public static int Pack(FlatBufferBuilder builder, TGamepadShakeConfigUnion _o)
		{
			switch (_o.Type)
			{
			case TGamepadShakeConfig.IAttenuatedGamepadShake:
				return IAttenuatedGamepadShake.Pack(builder, _o.AsIAttenuatedGamepadShake()).Value;
			case TGamepadShakeConfig.IContinualGamepadShake:
				return IContinualGamepadShake.Pack(builder, _o.AsIContinualGamepadShake()).Value;
			case TGamepadShakeConfig.IMp4GamepadShake:
				return IMp4GamepadShake.Pack(builder, _o.AsIMp4GamepadShake()).Value;
			case TGamepadShakeConfig.IOnetimeGamepadShake:
				return IOnetimeGamepadShake.Pack(builder, _o.AsIOnetimeGamepadShake()).Value;
			default:
				return 0;
			}
		}
	}
}
