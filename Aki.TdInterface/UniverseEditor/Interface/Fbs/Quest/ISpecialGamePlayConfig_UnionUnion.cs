using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200457B RID: 17787
	public class ISpecialGamePlayConfig_UnionUnion
	{
		// Token: 0x17007C4A RID: 31818
		// (get) Token: 0x06019E73 RID: 106099 RVA: 0x003B1BD5 File Offset: 0x003AFDD5
		// (set) Token: 0x06019E74 RID: 106100 RVA: 0x003B1BDD File Offset: 0x003AFDDD
		public ISpecialGamePlayConfig_Union Type { get; set; }

		// Token: 0x17007C4B RID: 31819
		// (get) Token: 0x06019E75 RID: 106101 RVA: 0x003B1BE6 File Offset: 0x003AFDE6
		// (set) Token: 0x06019E76 RID: 106102 RVA: 0x003B1BEE File Offset: 0x003AFDEE
		public object Value { get; set; }

		// Token: 0x06019E77 RID: 106103 RVA: 0x003B1BF7 File Offset: 0x003AFDF7
		public ISpecialGamePlayConfig_UnionUnion()
		{
			this.Type = ISpecialGamePlayConfig_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06019E78 RID: 106104 RVA: 0x003B1C0D File Offset: 0x003AFE0D
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06019E79 RID: 106105 RVA: 0x003B1C1F File Offset: 0x003AFE1F
		public ISpecialGamePlayConfigT AsISpecialGamePlayConfig()
		{
			return this.As<ISpecialGamePlayConfigT>();
		}

		// Token: 0x06019E7A RID: 106106 RVA: 0x003B1C27 File Offset: 0x003AFE27
		public static ISpecialGamePlayConfig_UnionUnion FromISpecialGamePlayConfig(ISpecialGamePlayConfigT _ispecialgameplayconfig)
		{
			return new ISpecialGamePlayConfig_UnionUnion
			{
				Type = ISpecialGamePlayConfig_Union.ISpecialGamePlayConfig,
				Value = _ispecialgameplayconfig
			};
		}

		// Token: 0x06019E7B RID: 106107 RVA: 0x003B1C3C File Offset: 0x003AFE3C
		public IStalkingGamePlayConfigT AsIStalkingGamePlayConfig()
		{
			return this.As<IStalkingGamePlayConfigT>();
		}

		// Token: 0x06019E7C RID: 106108 RVA: 0x003B1C44 File Offset: 0x003AFE44
		public static ISpecialGamePlayConfig_UnionUnion FromIStalkingGamePlayConfig(IStalkingGamePlayConfigT _istalkinggameplayconfig)
		{
			return new ISpecialGamePlayConfig_UnionUnion
			{
				Type = ISpecialGamePlayConfig_Union.IStalkingGamePlayConfig,
				Value = _istalkinggameplayconfig
			};
		}

		// Token: 0x06019E7D RID: 106109 RVA: 0x003B1C59 File Offset: 0x003AFE59
		public IFreezeOnSightGamePlayConfigT AsIFreezeOnSightGamePlayConfig()
		{
			return this.As<IFreezeOnSightGamePlayConfigT>();
		}

		// Token: 0x06019E7E RID: 106110 RVA: 0x003B1C61 File Offset: 0x003AFE61
		public static ISpecialGamePlayConfig_UnionUnion FromIFreezeOnSightGamePlayConfig(IFreezeOnSightGamePlayConfigT _ifreezeonsightgameplayconfig)
		{
			return new ISpecialGamePlayConfig_UnionUnion
			{
				Type = ISpecialGamePlayConfig_Union.IFreezeOnSightGamePlayConfig,
				Value = _ifreezeonsightgameplayconfig
			};
		}

		// Token: 0x06019E7F RID: 106111 RVA: 0x003B1C76 File Offset: 0x003AFE76
		public IFirstPersonTurretGamePlayConfigT AsIFirstPersonTurretGamePlayConfig()
		{
			return this.As<IFirstPersonTurretGamePlayConfigT>();
		}

		// Token: 0x06019E80 RID: 106112 RVA: 0x003B1C7E File Offset: 0x003AFE7E
		public static ISpecialGamePlayConfig_UnionUnion FromIFirstPersonTurretGamePlayConfig(IFirstPersonTurretGamePlayConfigT _ifirstpersonturretgameplayconfig)
		{
			return new ISpecialGamePlayConfig_UnionUnion
			{
				Type = ISpecialGamePlayConfig_Union.IFirstPersonTurretGamePlayConfig,
				Value = _ifirstpersonturretgameplayconfig
			};
		}

		// Token: 0x06019E81 RID: 106113 RVA: 0x003B1C93 File Offset: 0x003AFE93
		public IEavesdropGamePlayConfigT AsIEavesdropGamePlayConfig()
		{
			return this.As<IEavesdropGamePlayConfigT>();
		}

		// Token: 0x06019E82 RID: 106114 RVA: 0x003B1C9B File Offset: 0x003AFE9B
		public static ISpecialGamePlayConfig_UnionUnion FromIEavesdropGamePlayConfig(IEavesdropGamePlayConfigT _ieavesdropgameplayconfig)
		{
			return new ISpecialGamePlayConfig_UnionUnion
			{
				Type = ISpecialGamePlayConfig_Union.IEavesdropGamePlayConfig,
				Value = _ieavesdropgameplayconfig
			};
		}

		// Token: 0x06019E83 RID: 106115 RVA: 0x003B1CB0 File Offset: 0x003AFEB0
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
