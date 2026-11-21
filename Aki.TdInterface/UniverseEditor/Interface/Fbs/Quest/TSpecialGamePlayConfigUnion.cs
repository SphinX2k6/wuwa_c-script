using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004777 RID: 18295
	public class TSpecialGamePlayConfigUnion
	{
		// Token: 0x17007FA5 RID: 32677
		// (get) Token: 0x0601AF11 RID: 110353 RVA: 0x003D1FE3 File Offset: 0x003D01E3
		// (set) Token: 0x0601AF12 RID: 110354 RVA: 0x003D1FEB File Offset: 0x003D01EB
		public TSpecialGamePlayConfig Type { get; set; }

		// Token: 0x17007FA6 RID: 32678
		// (get) Token: 0x0601AF13 RID: 110355 RVA: 0x003D1FF4 File Offset: 0x003D01F4
		// (set) Token: 0x0601AF14 RID: 110356 RVA: 0x003D1FFC File Offset: 0x003D01FC
		public object Value { get; set; }

		// Token: 0x0601AF15 RID: 110357 RVA: 0x003D2005 File Offset: 0x003D0205
		public TSpecialGamePlayConfigUnion()
		{
			this.Type = TSpecialGamePlayConfig.NONE;
			this.Value = null;
		}

		// Token: 0x0601AF16 RID: 110358 RVA: 0x003D201B File Offset: 0x003D021B
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0601AF17 RID: 110359 RVA: 0x003D202D File Offset: 0x003D022D
		public IEavesdropGamePlayConfigT AsIEavesdropGamePlayConfig()
		{
			return this.As<IEavesdropGamePlayConfigT>();
		}

		// Token: 0x0601AF18 RID: 110360 RVA: 0x003D2035 File Offset: 0x003D0235
		public static TSpecialGamePlayConfigUnion FromIEavesdropGamePlayConfig(IEavesdropGamePlayConfigT _ieavesdropgameplayconfig)
		{
			return new TSpecialGamePlayConfigUnion
			{
				Type = TSpecialGamePlayConfig.IEavesdropGamePlayConfig,
				Value = _ieavesdropgameplayconfig
			};
		}

		// Token: 0x0601AF19 RID: 110361 RVA: 0x003D204A File Offset: 0x003D024A
		public IFirstPersonTurretGamePlayConfigT AsIFirstPersonTurretGamePlayConfig()
		{
			return this.As<IFirstPersonTurretGamePlayConfigT>();
		}

		// Token: 0x0601AF1A RID: 110362 RVA: 0x003D2052 File Offset: 0x003D0252
		public static TSpecialGamePlayConfigUnion FromIFirstPersonTurretGamePlayConfig(IFirstPersonTurretGamePlayConfigT _ifirstpersonturretgameplayconfig)
		{
			return new TSpecialGamePlayConfigUnion
			{
				Type = TSpecialGamePlayConfig.IFirstPersonTurretGamePlayConfig,
				Value = _ifirstpersonturretgameplayconfig
			};
		}

		// Token: 0x0601AF1B RID: 110363 RVA: 0x003D2067 File Offset: 0x003D0267
		public IFreezeOnSightGamePlayConfigT AsIFreezeOnSightGamePlayConfig()
		{
			return this.As<IFreezeOnSightGamePlayConfigT>();
		}

		// Token: 0x0601AF1C RID: 110364 RVA: 0x003D206F File Offset: 0x003D026F
		public static TSpecialGamePlayConfigUnion FromIFreezeOnSightGamePlayConfig(IFreezeOnSightGamePlayConfigT _ifreezeonsightgameplayconfig)
		{
			return new TSpecialGamePlayConfigUnion
			{
				Type = TSpecialGamePlayConfig.IFreezeOnSightGamePlayConfig,
				Value = _ifreezeonsightgameplayconfig
			};
		}

		// Token: 0x0601AF1D RID: 110365 RVA: 0x003D2084 File Offset: 0x003D0284
		public IStalkingGamePlayConfigT AsIStalkingGamePlayConfig()
		{
			return this.As<IStalkingGamePlayConfigT>();
		}

		// Token: 0x0601AF1E RID: 110366 RVA: 0x003D208C File Offset: 0x003D028C
		public static TSpecialGamePlayConfigUnion FromIStalkingGamePlayConfig(IStalkingGamePlayConfigT _istalkinggameplayconfig)
		{
			return new TSpecialGamePlayConfigUnion
			{
				Type = TSpecialGamePlayConfig.IStalkingGamePlayConfig,
				Value = _istalkinggameplayconfig
			};
		}

		// Token: 0x0601AF1F RID: 110367 RVA: 0x003D20A4 File Offset: 0x003D02A4
		public static int Pack(FlatBufferBuilder builder, TSpecialGamePlayConfigUnion _o)
		{
			switch (_o.Type)
			{
			case TSpecialGamePlayConfig.IEavesdropGamePlayConfig:
				return IEavesdropGamePlayConfig.Pack(builder, _o.AsIEavesdropGamePlayConfig()).Value;
			case TSpecialGamePlayConfig.IFirstPersonTurretGamePlayConfig:
				return IFirstPersonTurretGamePlayConfig.Pack(builder, _o.AsIFirstPersonTurretGamePlayConfig()).Value;
			case TSpecialGamePlayConfig.IFreezeOnSightGamePlayConfig:
				return IFreezeOnSightGamePlayConfig.Pack(builder, _o.AsIFreezeOnSightGamePlayConfig()).Value;
			case TSpecialGamePlayConfig.IStalkingGamePlayConfig:
				return IStalkingGamePlayConfig.Pack(builder, _o.AsIStalkingGamePlayConfig()).Value;
			default:
				return 0;
			}
		}
	}
}
