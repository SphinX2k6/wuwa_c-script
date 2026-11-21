using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006F12 RID: 28434
	public class IGamepadShakeConfig_UnionUnion
	{
		// Token: 0x1700D07E RID: 53374
		// (get) Token: 0x06031341 RID: 201537 RVA: 0x006AAEE5 File Offset: 0x006A90E5
		// (set) Token: 0x06031342 RID: 201538 RVA: 0x006AAEED File Offset: 0x006A90ED
		public IGamepadShakeConfig_Union Type { get; set; }

		// Token: 0x1700D07F RID: 53375
		// (get) Token: 0x06031343 RID: 201539 RVA: 0x006AAEF6 File Offset: 0x006A90F6
		// (set) Token: 0x06031344 RID: 201540 RVA: 0x006AAEFE File Offset: 0x006A90FE
		public object Value { get; set; }

		// Token: 0x06031345 RID: 201541 RVA: 0x006AAF07 File Offset: 0x006A9107
		public IGamepadShakeConfig_UnionUnion()
		{
			this.Type = IGamepadShakeConfig_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06031346 RID: 201542 RVA: 0x006AAF1D File Offset: 0x006A911D
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06031347 RID: 201543 RVA: 0x006AAF2F File Offset: 0x006A912F
		public IGamepadShakeConfigT AsIGamepadShakeConfig()
		{
			return this.As<IGamepadShakeConfigT>();
		}

		// Token: 0x06031348 RID: 201544 RVA: 0x006AAF37 File Offset: 0x006A9137
		public static IGamepadShakeConfig_UnionUnion FromIGamepadShakeConfig(IGamepadShakeConfigT _igamepadshakeconfig)
		{
			return new IGamepadShakeConfig_UnionUnion
			{
				Type = IGamepadShakeConfig_Union.IGamepadShakeConfig,
				Value = _igamepadshakeconfig
			};
		}

		// Token: 0x06031349 RID: 201545 RVA: 0x006AAF4C File Offset: 0x006A914C
		public IOnetimeGamepadShakeT AsIOnetimeGamepadShake()
		{
			return this.As<IOnetimeGamepadShakeT>();
		}

		// Token: 0x0603134A RID: 201546 RVA: 0x006AAF54 File Offset: 0x006A9154
		public static IGamepadShakeConfig_UnionUnion FromIOnetimeGamepadShake(IOnetimeGamepadShakeT _ionetimegamepadshake)
		{
			return new IGamepadShakeConfig_UnionUnion
			{
				Type = IGamepadShakeConfig_Union.IOnetimeGamepadShake,
				Value = _ionetimegamepadshake
			};
		}

		// Token: 0x0603134B RID: 201547 RVA: 0x006AAF69 File Offset: 0x006A9169
		public IContinualGamepadShakeT AsIContinualGamepadShake()
		{
			return this.As<IContinualGamepadShakeT>();
		}

		// Token: 0x0603134C RID: 201548 RVA: 0x006AAF71 File Offset: 0x006A9171
		public static IGamepadShakeConfig_UnionUnion FromIContinualGamepadShake(IContinualGamepadShakeT _icontinualgamepadshake)
		{
			return new IGamepadShakeConfig_UnionUnion
			{
				Type = IGamepadShakeConfig_Union.IContinualGamepadShake,
				Value = _icontinualgamepadshake
			};
		}

		// Token: 0x0603134D RID: 201549 RVA: 0x006AAF86 File Offset: 0x006A9186
		public IAttenuatedGamepadShakeT AsIAttenuatedGamepadShake()
		{
			return this.As<IAttenuatedGamepadShakeT>();
		}

		// Token: 0x0603134E RID: 201550 RVA: 0x006AAF8E File Offset: 0x006A918E
		public static IGamepadShakeConfig_UnionUnion FromIAttenuatedGamepadShake(IAttenuatedGamepadShakeT _iattenuatedgamepadshake)
		{
			return new IGamepadShakeConfig_UnionUnion
			{
				Type = IGamepadShakeConfig_Union.IAttenuatedGamepadShake,
				Value = _iattenuatedgamepadshake
			};
		}

		// Token: 0x0603134F RID: 201551 RVA: 0x006AAFA3 File Offset: 0x006A91A3
		public IMp4GamepadShakeT AsIMp4GamepadShake()
		{
			return this.As<IMp4GamepadShakeT>();
		}

		// Token: 0x06031350 RID: 201552 RVA: 0x006AAFAB File Offset: 0x006A91AB
		public static IGamepadShakeConfig_UnionUnion FromIMp4GamepadShake(IMp4GamepadShakeT _imp4gamepadshake)
		{
			return new IGamepadShakeConfig_UnionUnion
			{
				Type = IGamepadShakeConfig_Union.IMp4GamepadShake,
				Value = _imp4gamepadshake
			};
		}

		// Token: 0x06031351 RID: 201553 RVA: 0x006AAFC0 File Offset: 0x006A91C0
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
