using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02006057 RID: 24663
	public class ITeleCtrlTriggerConfig_UnionUnion
	{
		// Token: 0x1700B714 RID: 46868
		// (get) Token: 0x06029A4E RID: 170574 RVA: 0x005AF725 File Offset: 0x005AD925
		// (set) Token: 0x06029A4F RID: 170575 RVA: 0x005AF72D File Offset: 0x005AD92D
		public ITeleCtrlTriggerConfig_Union Type { get; set; }

		// Token: 0x1700B715 RID: 46869
		// (get) Token: 0x06029A50 RID: 170576 RVA: 0x005AF736 File Offset: 0x005AD936
		// (set) Token: 0x06029A51 RID: 170577 RVA: 0x005AF73E File Offset: 0x005AD93E
		public object Value { get; set; }

		// Token: 0x06029A52 RID: 170578 RVA: 0x005AF747 File Offset: 0x005AD947
		public ITeleCtrlTriggerConfig_UnionUnion()
		{
			this.Type = ITeleCtrlTriggerConfig_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06029A53 RID: 170579 RVA: 0x005AF75D File Offset: 0x005AD95D
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06029A54 RID: 170580 RVA: 0x005AF76F File Offset: 0x005AD96F
		public ITeleCtrlTriggerConfigT AsITeleCtrlTriggerConfig()
		{
			return this.As<ITeleCtrlTriggerConfigT>();
		}

		// Token: 0x06029A55 RID: 170581 RVA: 0x005AF777 File Offset: 0x005AD977
		public static ITeleCtrlTriggerConfig_UnionUnion FromITeleCtrlTriggerConfig(ITeleCtrlTriggerConfigT _itelectrltriggerconfig)
		{
			return new ITeleCtrlTriggerConfig_UnionUnion
			{
				Type = ITeleCtrlTriggerConfig_Union.ITeleCtrlTriggerConfig,
				Value = _itelectrltriggerconfig
			};
		}

		// Token: 0x06029A56 RID: 170582 RVA: 0x005AF78C File Offset: 0x005AD98C
		public IMechascoutJavelinTriggerConfigT AsIMechascoutJavelinTriggerConfig()
		{
			return this.As<IMechascoutJavelinTriggerConfigT>();
		}

		// Token: 0x06029A57 RID: 170583 RVA: 0x005AF794 File Offset: 0x005AD994
		public static ITeleCtrlTriggerConfig_UnionUnion FromIMechascoutJavelinTriggerConfig(IMechascoutJavelinTriggerConfigT _imechascoutjavelintriggerconfig)
		{
			return new ITeleCtrlTriggerConfig_UnionUnion
			{
				Type = ITeleCtrlTriggerConfig_Union.IMechascoutJavelinTriggerConfig,
				Value = _imechascoutjavelintriggerconfig
			};
		}

		// Token: 0x06029A58 RID: 170584 RVA: 0x005AF7A9 File Offset: 0x005AD9A9
		public IMechascoutExplosiveBarrelTriggerConfigT AsIMechascoutExplosiveBarrelTriggerConfig()
		{
			return this.As<IMechascoutExplosiveBarrelTriggerConfigT>();
		}

		// Token: 0x06029A59 RID: 170585 RVA: 0x005AF7B1 File Offset: 0x005AD9B1
		public static ITeleCtrlTriggerConfig_UnionUnion FromIMechascoutExplosiveBarrelTriggerConfig(IMechascoutExplosiveBarrelTriggerConfigT _imechascoutexplosivebarreltriggerconfig)
		{
			return new ITeleCtrlTriggerConfig_UnionUnion
			{
				Type = ITeleCtrlTriggerConfig_Union.IMechascoutExplosiveBarrelTriggerConfig,
				Value = _imechascoutexplosivebarreltriggerconfig
			};
		}

		// Token: 0x06029A5A RID: 170586 RVA: 0x005AF7C8 File Offset: 0x005AD9C8
		public static int Pack(FlatBufferBuilder builder, ITeleCtrlTriggerConfig_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case ITeleCtrlTriggerConfig_Union.ITeleCtrlTriggerConfig:
				return ITeleCtrlTriggerConfig.Pack(builder, _o.AsITeleCtrlTriggerConfig()).Value;
			case ITeleCtrlTriggerConfig_Union.IMechascoutJavelinTriggerConfig:
				return IMechascoutJavelinTriggerConfig.Pack(builder, _o.AsIMechascoutJavelinTriggerConfig()).Value;
			case ITeleCtrlTriggerConfig_Union.IMechascoutExplosiveBarrelTriggerConfig:
				return IMechascoutExplosiveBarrelTriggerConfig.Pack(builder, _o.AsIMechascoutExplosiveBarrelTriggerConfig()).Value;
			default:
				return 0;
			}
		}
	}
}
