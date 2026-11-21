using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006A75 RID: 27253
	public class IClientSetSeasonStateConfig_UnionUnion
	{
		// Token: 0x1700C82B RID: 51243
		// (get) Token: 0x0602EC1D RID: 191517 RVA: 0x0065F529 File Offset: 0x0065D729
		// (set) Token: 0x0602EC1E RID: 191518 RVA: 0x0065F531 File Offset: 0x0065D731
		public IClientSetSeasonStateConfig_Union Type { get; set; }

		// Token: 0x1700C82C RID: 51244
		// (get) Token: 0x0602EC1F RID: 191519 RVA: 0x0065F53A File Offset: 0x0065D73A
		// (set) Token: 0x0602EC20 RID: 191520 RVA: 0x0065F542 File Offset: 0x0065D742
		public object Value { get; set; }

		// Token: 0x0602EC21 RID: 191521 RVA: 0x0065F54B File Offset: 0x0065D74B
		public IClientSetSeasonStateConfig_UnionUnion()
		{
			this.Type = IClientSetSeasonStateConfig_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0602EC22 RID: 191522 RVA: 0x0065F561 File Offset: 0x0065D761
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602EC23 RID: 191523 RVA: 0x0065F573 File Offset: 0x0065D773
		public IClientSetSeasonStateConfigT AsIClientSetSeasonStateConfig()
		{
			return this.As<IClientSetSeasonStateConfigT>();
		}

		// Token: 0x0602EC24 RID: 191524 RVA: 0x0065F57B File Offset: 0x0065D77B
		public static IClientSetSeasonStateConfig_UnionUnion FromIClientSetSeasonStateConfig(IClientSetSeasonStateConfigT _iclientsetseasonstateconfig)
		{
			return new IClientSetSeasonStateConfig_UnionUnion
			{
				Type = IClientSetSeasonStateConfig_Union.IClientSetSeasonStateConfig,
				Value = _iclientsetseasonstateconfig
			};
		}

		// Token: 0x0602EC25 RID: 191525 RVA: 0x0065F590 File Offset: 0x0065D790
		public ISwitchSeasonT AsISwitchSeason()
		{
			return this.As<ISwitchSeasonT>();
		}

		// Token: 0x0602EC26 RID: 191526 RVA: 0x0065F598 File Offset: 0x0065D798
		public static IClientSetSeasonStateConfig_UnionUnion FromISwitchSeason(ISwitchSeasonT _iswitchseason)
		{
			return new IClientSetSeasonStateConfig_UnionUnion
			{
				Type = IClientSetSeasonStateConfig_Union.ISwitchSeason,
				Value = _iswitchseason
			};
		}

		// Token: 0x0602EC27 RID: 191527 RVA: 0x0065F5AD File Offset: 0x0065D7AD
		public ILoopSeasonChangeT AsILoopSeasonChange()
		{
			return this.As<ILoopSeasonChangeT>();
		}

		// Token: 0x0602EC28 RID: 191528 RVA: 0x0065F5B5 File Offset: 0x0065D7B5
		public static IClientSetSeasonStateConfig_UnionUnion FromILoopSeasonChange(ILoopSeasonChangeT _iloopseasonchange)
		{
			return new IClientSetSeasonStateConfig_UnionUnion
			{
				Type = IClientSetSeasonStateConfig_Union.ILoopSeasonChange,
				Value = _iloopseasonchange
			};
		}

		// Token: 0x0602EC29 RID: 191529 RVA: 0x0065F5CC File Offset: 0x0065D7CC
		public static int Pack(FlatBufferBuilder builder, IClientSetSeasonStateConfig_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IClientSetSeasonStateConfig_Union.IClientSetSeasonStateConfig:
				return IClientSetSeasonStateConfig.Pack(builder, _o.AsIClientSetSeasonStateConfig()).Value;
			case IClientSetSeasonStateConfig_Union.ISwitchSeason:
				return ISwitchSeason.Pack(builder, _o.AsISwitchSeason()).Value;
			case IClientSetSeasonStateConfig_Union.ILoopSeasonChange:
				return ILoopSeasonChange.Pack(builder, _o.AsILoopSeasonChange()).Value;
			default:
				return 0;
			}
		}
	}
}
