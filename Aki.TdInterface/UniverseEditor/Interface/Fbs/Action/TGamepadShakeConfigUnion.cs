using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020076DB RID: 30427
	public class TGamepadShakeConfigUnion
	{
		// Token: 0x1700E62B RID: 58923
		// (get) Token: 0x06037538 RID: 226616 RVA: 0x0077EB96 File Offset: 0x0077CD96
		// (set) Token: 0x06037539 RID: 226617 RVA: 0x0077EB9E File Offset: 0x0077CD9E
		public TGamepadShakeConfig Type { get; set; }

		// Token: 0x1700E62C RID: 58924
		// (get) Token: 0x0603753A RID: 226618 RVA: 0x0077EBA7 File Offset: 0x0077CDA7
		// (set) Token: 0x0603753B RID: 226619 RVA: 0x0077EBAF File Offset: 0x0077CDAF
		public object Value { get; set; }

		// Token: 0x0603753C RID: 226620 RVA: 0x0077EBB8 File Offset: 0x0077CDB8
		public TGamepadShakeConfigUnion()
		{
			this.Type = TGamepadShakeConfig.NONE;
			this.Value = null;
		}

		// Token: 0x0603753D RID: 226621 RVA: 0x0077EBCE File Offset: 0x0077CDCE
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0603753E RID: 226622 RVA: 0x0077EBE0 File Offset: 0x0077CDE0
		public IAttenuatedGamepadShakeT AsIAttenuatedGamepadShake()
		{
			return this.As<IAttenuatedGamepadShakeT>();
		}

		// Token: 0x0603753F RID: 226623 RVA: 0x0077EBE8 File Offset: 0x0077CDE8
		public static TGamepadShakeConfigUnion FromIAttenuatedGamepadShake(IAttenuatedGamepadShakeT _iattenuatedgamepadshake)
		{
			return new TGamepadShakeConfigUnion
			{
				Type = TGamepadShakeConfig.IAttenuatedGamepadShake,
				Value = _iattenuatedgamepadshake
			};
		}

		// Token: 0x06037540 RID: 226624 RVA: 0x0077EBFD File Offset: 0x0077CDFD
		public IContinualGamepadShakeT AsIContinualGamepadShake()
		{
			return this.As<IContinualGamepadShakeT>();
		}

		// Token: 0x06037541 RID: 226625 RVA: 0x0077EC05 File Offset: 0x0077CE05
		public static TGamepadShakeConfigUnion FromIContinualGamepadShake(IContinualGamepadShakeT _icontinualgamepadshake)
		{
			return new TGamepadShakeConfigUnion
			{
				Type = TGamepadShakeConfig.IContinualGamepadShake,
				Value = _icontinualgamepadshake
			};
		}

		// Token: 0x06037542 RID: 226626 RVA: 0x0077EC1A File Offset: 0x0077CE1A
		public IMp4GamepadShakeT AsIMp4GamepadShake()
		{
			return this.As<IMp4GamepadShakeT>();
		}

		// Token: 0x06037543 RID: 226627 RVA: 0x0077EC22 File Offset: 0x0077CE22
		public static TGamepadShakeConfigUnion FromIMp4GamepadShake(IMp4GamepadShakeT _imp4gamepadshake)
		{
			return new TGamepadShakeConfigUnion
			{
				Type = TGamepadShakeConfig.IMp4GamepadShake,
				Value = _imp4gamepadshake
			};
		}

		// Token: 0x06037544 RID: 226628 RVA: 0x0077EC37 File Offset: 0x0077CE37
		public IOnetimeGamepadShakeT AsIOnetimeGamepadShake()
		{
			return this.As<IOnetimeGamepadShakeT>();
		}

		// Token: 0x06037545 RID: 226629 RVA: 0x0077EC3F File Offset: 0x0077CE3F
		public static TGamepadShakeConfigUnion FromIOnetimeGamepadShake(IOnetimeGamepadShakeT _ionetimegamepadshake)
		{
			return new TGamepadShakeConfigUnion
			{
				Type = TGamepadShakeConfig.IOnetimeGamepadShake,
				Value = _ionetimegamepadshake
			};
		}

		// Token: 0x06037546 RID: 226630 RVA: 0x0077EC54 File Offset: 0x0077CE54
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
