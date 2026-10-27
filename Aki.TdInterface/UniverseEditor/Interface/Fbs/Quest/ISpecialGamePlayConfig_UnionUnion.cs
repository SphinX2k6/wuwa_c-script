using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200413A RID: 16698
	public class ISpecialGamePlayConfig_UnionUnion
	{
		// Token: 0x17007644 RID: 30276
		// (get) Token: 0x060187D0 RID: 100304 RVA: 0x00387BCD File Offset: 0x00385DCD
		// (set) Token: 0x060187D1 RID: 100305 RVA: 0x00387BD5 File Offset: 0x00385DD5
		public ISpecialGamePlayConfig_Union Type { get; set; }

		// Token: 0x17007645 RID: 30277
		// (get) Token: 0x060187D2 RID: 100306 RVA: 0x00387BDE File Offset: 0x00385DDE
		// (set) Token: 0x060187D3 RID: 100307 RVA: 0x00387BE6 File Offset: 0x00385DE6
		public object Value { get; set; }

		// Token: 0x060187D4 RID: 100308 RVA: 0x00387BEF File Offset: 0x00385DEF
		public ISpecialGamePlayConfig_UnionUnion()
		{
			this.Type = ISpecialGamePlayConfig_Union.NONE;
			this.Value = null;
		}

		// Token: 0x060187D5 RID: 100309 RVA: 0x00387C05 File Offset: 0x00385E05
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060187D6 RID: 100310 RVA: 0x00387C17 File Offset: 0x00385E17
		public ISpecialGamePlayConfigT AsISpecialGamePlayConfig()
		{
			return this.As<ISpecialGamePlayConfigT>();
		}

		// Token: 0x060187D7 RID: 100311 RVA: 0x00387C1F File Offset: 0x00385E1F
		public static ISpecialGamePlayConfig_UnionUnion FromISpecialGamePlayConfig(ISpecialGamePlayConfigT _ispecialgameplayconfig)
		{
			return new ISpecialGamePlayConfig_UnionUnion
			{
				Type = ISpecialGamePlayConfig_Union.ISpecialGamePlayConfig,
				Value = _ispecialgameplayconfig
			};
		}

		// Token: 0x060187D8 RID: 100312 RVA: 0x00387C34 File Offset: 0x00385E34
		public IStalkingGamePlayConfigT AsIStalkingGamePlayConfig()
		{
			return this.As<IStalkingGamePlayConfigT>();
		}

		// Token: 0x060187D9 RID: 100313 RVA: 0x00387C3C File Offset: 0x00385E3C
		public static ISpecialGamePlayConfig_UnionUnion FromIStalkingGamePlayConfig(IStalkingGamePlayConfigT _istalkinggameplayconfig)
		{
			return new ISpecialGamePlayConfig_UnionUnion
			{
				Type = ISpecialGamePlayConfig_Union.IStalkingGamePlayConfig,
				Value = _istalkinggameplayconfig
			};
		}

		// Token: 0x060187DA RID: 100314 RVA: 0x00387C51 File Offset: 0x00385E51
		public IFreezeOnSightGamePlayConfigT AsIFreezeOnSightGamePlayConfig()
		{
			return this.As<IFreezeOnSightGamePlayConfigT>();
		}

		// Token: 0x060187DB RID: 100315 RVA: 0x00387C59 File Offset: 0x00385E59
		public static ISpecialGamePlayConfig_UnionUnion FromIFreezeOnSightGamePlayConfig(IFreezeOnSightGamePlayConfigT _ifreezeonsightgameplayconfig)
		{
			return new ISpecialGamePlayConfig_UnionUnion
			{
				Type = ISpecialGamePlayConfig_Union.IFreezeOnSightGamePlayConfig,
				Value = _ifreezeonsightgameplayconfig
			};
		}

		// Token: 0x060187DC RID: 100316 RVA: 0x00387C6E File Offset: 0x00385E6E
		public IFirstPersonTurretGamePlayConfigT AsIFirstPersonTurretGamePlayConfig()
		{
			return this.As<IFirstPersonTurretGamePlayConfigT>();
		}

		// Token: 0x060187DD RID: 100317 RVA: 0x00387C76 File Offset: 0x00385E76
		public static ISpecialGamePlayConfig_UnionUnion FromIFirstPersonTurretGamePlayConfig(IFirstPersonTurretGamePlayConfigT _ifirstpersonturretgameplayconfig)
		{
			return new ISpecialGamePlayConfig_UnionUnion
			{
				Type = ISpecialGamePlayConfig_Union.IFirstPersonTurretGamePlayConfig,
				Value = _ifirstpersonturretgameplayconfig
			};
		}

		// Token: 0x060187DE RID: 100318 RVA: 0x00387C8B File Offset: 0x00385E8B
		public IEavesdropGamePlayConfigT AsIEavesdropGamePlayConfig()
		{
			return this.As<IEavesdropGamePlayConfigT>();
		}

		// Token: 0x060187DF RID: 100319 RVA: 0x00387C93 File Offset: 0x00385E93
		public static ISpecialGamePlayConfig_UnionUnion FromIEavesdropGamePlayConfig(IEavesdropGamePlayConfigT _ieavesdropgameplayconfig)
		{
			return new ISpecialGamePlayConfig_UnionUnion
			{
				Type = ISpecialGamePlayConfig_Union.IEavesdropGamePlayConfig,
				Value = _ieavesdropgameplayconfig
			};
		}

		// Token: 0x060187E0 RID: 100320 RVA: 0x00387CA8 File Offset: 0x00385EA8
		public static int Pack(FlatBufferBuilder builder, ISpecialGamePlayConfig_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case ISpecialGamePlayConfig_Union.ISpecialGamePlayConfig:
				return ISpecialGamePlayConfig.Pack(builder, _o.AsISpecialGamePlayConfig()).Value;
			case ISpecialGamePlayConfig_Union.IStalkingGamePlayConfig:
				return IStalkingGamePlayConfig.Pack(builder, _o.AsIStalkingGamePlayConfig()).Value;
			case ISpecialGamePlayConfig_Union.IFreezeOnSightGamePlayConfig:
				return IFreezeOnSightGamePlayConfig.Pack(builder, _o.AsIFreezeOnSightGamePlayConfig()).Value;
			case ISpecialGamePlayConfig_Union.IFirstPersonTurretGamePlayConfig:
				return IFirstPersonTurretGamePlayConfig.Pack(builder, _o.AsIFirstPersonTurretGamePlayConfig()).Value;
			case ISpecialGamePlayConfig_Union.IEavesdropGamePlayConfig:
				return IEavesdropGamePlayConfig.Pack(builder, _o.AsIEavesdropGamePlayConfig()).Value;
			default:
				return 0;
			}
		}
	}
}
