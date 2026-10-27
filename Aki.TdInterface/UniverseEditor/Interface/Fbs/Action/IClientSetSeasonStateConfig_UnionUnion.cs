using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020063F5 RID: 25589
	public class IClientSetSeasonStateConfig_UnionUnion
	{
		// Token: 0x1700BE91 RID: 48785
		// (get) Token: 0x0602C447 RID: 181319 RVA: 0x0061369D File Offset: 0x0061189D
		// (set) Token: 0x0602C448 RID: 181320 RVA: 0x006136A5 File Offset: 0x006118A5
		public IClientSetSeasonStateConfig_Union Type { get; set; }

		// Token: 0x1700BE92 RID: 48786
		// (get) Token: 0x0602C449 RID: 181321 RVA: 0x006136AE File Offset: 0x006118AE
		// (set) Token: 0x0602C44A RID: 181322 RVA: 0x006136B6 File Offset: 0x006118B6
		public object Value { get; set; }

		// Token: 0x0602C44B RID: 181323 RVA: 0x006136BF File Offset: 0x006118BF
		public IClientSetSeasonStateConfig_UnionUnion()
		{
			this.Type = IClientSetSeasonStateConfig_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0602C44C RID: 181324 RVA: 0x006136D5 File Offset: 0x006118D5
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602C44D RID: 181325 RVA: 0x006136E7 File Offset: 0x006118E7
		public IClientSetSeasonStateConfigT AsIClientSetSeasonStateConfig()
		{
			return this.As<IClientSetSeasonStateConfigT>();
		}

		// Token: 0x0602C44E RID: 181326 RVA: 0x006136EF File Offset: 0x006118EF
		public static IClientSetSeasonStateConfig_UnionUnion FromIClientSetSeasonStateConfig(IClientSetSeasonStateConfigT _iclientsetseasonstateconfig)
		{
			return new IClientSetSeasonStateConfig_UnionUnion
			{
				Type = IClientSetSeasonStateConfig_Union.IClientSetSeasonStateConfig,
				Value = _iclientsetseasonstateconfig
			};
		}

		// Token: 0x0602C44F RID: 181327 RVA: 0x00613704 File Offset: 0x00611904
		public ISwitchSeasonT AsISwitchSeason()
		{
			return this.As<ISwitchSeasonT>();
		}

		// Token: 0x0602C450 RID: 181328 RVA: 0x0061370C File Offset: 0x0061190C
		public static IClientSetSeasonStateConfig_UnionUnion FromISwitchSeason(ISwitchSeasonT _iswitchseason)
		{
			return new IClientSetSeasonStateConfig_UnionUnion
			{
				Type = IClientSetSeasonStateConfig_Union.ISwitchSeason,
				Value = _iswitchseason
			};
		}

		// Token: 0x0602C451 RID: 181329 RVA: 0x00613721 File Offset: 0x00611921
		public ILoopSeasonChangeT AsILoopSeasonChange()
		{
			return this.As<ILoopSeasonChangeT>();
		}

		// Token: 0x0602C452 RID: 181330 RVA: 0x00613729 File Offset: 0x00611929
		public static IClientSetSeasonStateConfig_UnionUnion FromILoopSeasonChange(ILoopSeasonChangeT _iloopseasonchange)
		{
			return new IClientSetSeasonStateConfig_UnionUnion
			{
				Type = IClientSetSeasonStateConfig_Union.ILoopSeasonChange,
				Value = _iloopseasonchange
			};
		}

		// Token: 0x0602C453 RID: 181331 RVA: 0x00613740 File Offset: 0x00611940
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
