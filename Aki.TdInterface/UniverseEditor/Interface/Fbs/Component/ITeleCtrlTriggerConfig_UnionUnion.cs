using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005A4A RID: 23114
	public class ITeleCtrlTriggerConfig_UnionUnion
	{
		// Token: 0x1700ADDC RID: 44508
		// (get) Token: 0x060274D6 RID: 160982 RVA: 0x00568719 File Offset: 0x00566919
		// (set) Token: 0x060274D7 RID: 160983 RVA: 0x00568721 File Offset: 0x00566921
		public ITeleCtrlTriggerConfig_Union Type { get; set; }

		// Token: 0x1700ADDD RID: 44509
		// (get) Token: 0x060274D8 RID: 160984 RVA: 0x0056872A File Offset: 0x0056692A
		// (set) Token: 0x060274D9 RID: 160985 RVA: 0x00568732 File Offset: 0x00566932
		public object Value { get; set; }

		// Token: 0x060274DA RID: 160986 RVA: 0x0056873B File Offset: 0x0056693B
		public ITeleCtrlTriggerConfig_UnionUnion()
		{
			this.Type = ITeleCtrlTriggerConfig_Union.NONE;
			this.Value = null;
		}

		// Token: 0x060274DB RID: 160987 RVA: 0x00568751 File Offset: 0x00566951
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060274DC RID: 160988 RVA: 0x00568763 File Offset: 0x00566963
		public ITeleCtrlTriggerConfigT AsITeleCtrlTriggerConfig()
		{
			return this.As<ITeleCtrlTriggerConfigT>();
		}

		// Token: 0x060274DD RID: 160989 RVA: 0x0056876B File Offset: 0x0056696B
		public static ITeleCtrlTriggerConfig_UnionUnion FromITeleCtrlTriggerConfig(ITeleCtrlTriggerConfigT _itelectrltriggerconfig)
		{
			return new ITeleCtrlTriggerConfig_UnionUnion
			{
				Type = ITeleCtrlTriggerConfig_Union.ITeleCtrlTriggerConfig,
				Value = _itelectrltriggerconfig
			};
		}

		// Token: 0x060274DE RID: 160990 RVA: 0x00568780 File Offset: 0x00566980
		public IMechascoutJavelinTriggerConfigT AsIMechascoutJavelinTriggerConfig()
		{
			return this.As<IMechascoutJavelinTriggerConfigT>();
		}

		// Token: 0x060274DF RID: 160991 RVA: 0x00568788 File Offset: 0x00566988
		public static ITeleCtrlTriggerConfig_UnionUnion FromIMechascoutJavelinTriggerConfig(IMechascoutJavelinTriggerConfigT _imechascoutjavelintriggerconfig)
		{
			return new ITeleCtrlTriggerConfig_UnionUnion
			{
				Type = ITeleCtrlTriggerConfig_Union.IMechascoutJavelinTriggerConfig,
				Value = _imechascoutjavelintriggerconfig
			};
		}

		// Token: 0x060274E0 RID: 160992 RVA: 0x0056879D File Offset: 0x0056699D
		public IMechascoutExplosiveBarrelTriggerConfigT AsIMechascoutExplosiveBarrelTriggerConfig()
		{
			return this.As<IMechascoutExplosiveBarrelTriggerConfigT>();
		}

		// Token: 0x060274E1 RID: 160993 RVA: 0x005687A5 File Offset: 0x005669A5
		public static ITeleCtrlTriggerConfig_UnionUnion FromIMechascoutExplosiveBarrelTriggerConfig(IMechascoutExplosiveBarrelTriggerConfigT _imechascoutexplosivebarreltriggerconfig)
		{
			return new ITeleCtrlTriggerConfig_UnionUnion
			{
				Type = ITeleCtrlTriggerConfig_Union.IMechascoutExplosiveBarrelTriggerConfig,
				Value = _imechascoutexplosivebarreltriggerconfig
			};
		}

		// Token: 0x060274E2 RID: 160994 RVA: 0x005687BC File Offset: 0x005669BC
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
