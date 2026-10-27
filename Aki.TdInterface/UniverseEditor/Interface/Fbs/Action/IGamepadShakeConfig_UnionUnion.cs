using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006871 RID: 26737
	public class IGamepadShakeConfig_UnionUnion
	{
		// Token: 0x1700C698 RID: 50840
		// (get) Token: 0x0602EA07 RID: 190983 RVA: 0x0065BE65 File Offset: 0x0065A065
		// (set) Token: 0x0602EA08 RID: 190984 RVA: 0x0065BE6D File Offset: 0x0065A06D
		public IGamepadShakeConfig_Union Type { get; set; }

		// Token: 0x1700C699 RID: 50841
		// (get) Token: 0x0602EA09 RID: 190985 RVA: 0x0065BE76 File Offset: 0x0065A076
		// (set) Token: 0x0602EA0A RID: 190986 RVA: 0x0065BE7E File Offset: 0x0065A07E
		public object Value { get; set; }

		// Token: 0x0602EA0B RID: 190987 RVA: 0x0065BE87 File Offset: 0x0065A087
		public IGamepadShakeConfig_UnionUnion()
		{
			this.Type = IGamepadShakeConfig_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0602EA0C RID: 190988 RVA: 0x0065BE9D File Offset: 0x0065A09D
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602EA0D RID: 190989 RVA: 0x0065BEAF File Offset: 0x0065A0AF
		public IGamepadShakeConfigT AsIGamepadShakeConfig()
		{
			return this.As<IGamepadShakeConfigT>();
		}

		// Token: 0x0602EA0E RID: 190990 RVA: 0x0065BEB7 File Offset: 0x0065A0B7
		public static IGamepadShakeConfig_UnionUnion FromIGamepadShakeConfig(IGamepadShakeConfigT _igamepadshakeconfig)
		{
			return new IGamepadShakeConfig_UnionUnion
			{
				Type = IGamepadShakeConfig_Union.IGamepadShakeConfig,
				Value = _igamepadshakeconfig
			};
		}

		// Token: 0x0602EA0F RID: 190991 RVA: 0x0065BECC File Offset: 0x0065A0CC
		public IOnetimeGamepadShakeT AsIOnetimeGamepadShake()
		{
			return this.As<IOnetimeGamepadShakeT>();
		}

		// Token: 0x0602EA10 RID: 190992 RVA: 0x0065BED4 File Offset: 0x0065A0D4
		public static IGamepadShakeConfig_UnionUnion FromIOnetimeGamepadShake(IOnetimeGamepadShakeT _ionetimegamepadshake)
		{
			return new IGamepadShakeConfig_UnionUnion
			{
				Type = IGamepadShakeConfig_Union.IOnetimeGamepadShake,
				Value = _ionetimegamepadshake
			};
		}

		// Token: 0x0602EA11 RID: 190993 RVA: 0x0065BEE9 File Offset: 0x0065A0E9
		public IContinualGamepadShakeT AsIContinualGamepadShake()
		{
			return this.As<IContinualGamepadShakeT>();
		}

		// Token: 0x0602EA12 RID: 190994 RVA: 0x0065BEF1 File Offset: 0x0065A0F1
		public static IGamepadShakeConfig_UnionUnion FromIContinualGamepadShake(IContinualGamepadShakeT _icontinualgamepadshake)
		{
			return new IGamepadShakeConfig_UnionUnion
			{
				Type = IGamepadShakeConfig_Union.IContinualGamepadShake,
				Value = _icontinualgamepadshake
			};
		}

		// Token: 0x0602EA13 RID: 190995 RVA: 0x0065BF06 File Offset: 0x0065A106
		public IAttenuatedGamepadShakeT AsIAttenuatedGamepadShake()
		{
			return this.As<IAttenuatedGamepadShakeT>();
		}

		// Token: 0x0602EA14 RID: 190996 RVA: 0x0065BF0E File Offset: 0x0065A10E
		public static IGamepadShakeConfig_UnionUnion FromIAttenuatedGamepadShake(IAttenuatedGamepadShakeT _iattenuatedgamepadshake)
		{
			return new IGamepadShakeConfig_UnionUnion
			{
				Type = IGamepadShakeConfig_Union.IAttenuatedGamepadShake,
				Value = _iattenuatedgamepadshake
			};
		}

		// Token: 0x0602EA15 RID: 190997 RVA: 0x0065BF23 File Offset: 0x0065A123
		public IMp4GamepadShakeT AsIMp4GamepadShake()
		{
			return this.As<IMp4GamepadShakeT>();
		}

		// Token: 0x0602EA16 RID: 190998 RVA: 0x0065BF2B File Offset: 0x0065A12B
		public static IGamepadShakeConfig_UnionUnion FromIMp4GamepadShake(IMp4GamepadShakeT _imp4gamepadshake)
		{
			return new IGamepadShakeConfig_UnionUnion
			{
				Type = IGamepadShakeConfig_Union.IMp4GamepadShake,
				Value = _imp4gamepadshake
			};
		}

		// Token: 0x0602EA17 RID: 190999 RVA: 0x0065BF40 File Offset: 0x0065A140
		public static int Pack(FlatBufferBuilder builder, IGamepadShakeConfig_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IGamepadShakeConfig_Union.IGamepadShakeConfig:
				return IGamepadShakeConfig.Pack(builder, _o.AsIGamepadShakeConfig()).Value;
			case IGamepadShakeConfig_Union.IOnetimeGamepadShake:
				return IOnetimeGamepadShake.Pack(builder, _o.AsIOnetimeGamepadShake()).Value;
			case IGamepadShakeConfig_Union.IContinualGamepadShake:
				return IContinualGamepadShake.Pack(builder, _o.AsIContinualGamepadShake()).Value;
			case IGamepadShakeConfig_Union.IAttenuatedGamepadShake:
				return IAttenuatedGamepadShake.Pack(builder, _o.AsIAttenuatedGamepadShake()).Value;
			case IGamepadShakeConfig_Union.IMp4GamepadShake:
				return IMp4GamepadShake.Pack(builder, _o.AsIMp4GamepadShake()).Value;
			default:
				return 0;
			}
		}
	}
}
