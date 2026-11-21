using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007999 RID: 31129
	public class IStateProgramSpecialProcessBase_UnionUnion
	{
		// Token: 0x1700E461 RID: 58465
		// (get) Token: 0x06036DA8 RID: 224680 RVA: 0x00756615 File Offset: 0x00754815
		// (set) Token: 0x06036DA9 RID: 224681 RVA: 0x0075661D File Offset: 0x0075481D
		public IStateProgramSpecialProcessBase_Union Type { get; set; }

		// Token: 0x1700E462 RID: 58466
		// (get) Token: 0x06036DAA RID: 224682 RVA: 0x00756626 File Offset: 0x00754826
		// (set) Token: 0x06036DAB RID: 224683 RVA: 0x0075662E File Offset: 0x0075482E
		public object Value { get; set; }

		// Token: 0x06036DAC RID: 224684 RVA: 0x00756637 File Offset: 0x00754837
		public IStateProgramSpecialProcessBase_UnionUnion()
		{
			this.Type = IStateProgramSpecialProcessBase_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06036DAD RID: 224685 RVA: 0x0075664D File Offset: 0x0075484D
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06036DAE RID: 224686 RVA: 0x0075665F File Offset: 0x0075485F
		public IStateProgramSpecialProcessBaseT AsIStateProgramSpecialProcessBase()
		{
			return this.As<IStateProgramSpecialProcessBaseT>();
		}

		// Token: 0x06036DAF RID: 224687 RVA: 0x00756667 File Offset: 0x00754867
		public static IStateProgramSpecialProcessBase_UnionUnion FromIStateProgramSpecialProcessBase(IStateProgramSpecialProcessBaseT _istateprogramspecialprocessbase)
		{
			return new IStateProgramSpecialProcessBase_UnionUnion
			{
				Type = IStateProgramSpecialProcessBase_Union.IStateProgramSpecialProcessBase,
				Value = _istateprogramspecialprocessbase
			};
		}

		// Token: 0x06036DB0 RID: 224688 RVA: 0x0075667C File Offset: 0x0075487C
		public IStateProgramSpecialProcessChangeTeamOptimizationT AsIStateProgramSpecialProcessChangeTeamOptimization()
		{
			return this.As<IStateProgramSpecialProcessChangeTeamOptimizationT>();
		}

		// Token: 0x06036DB1 RID: 224689 RVA: 0x00756684 File Offset: 0x00754884
		public static IStateProgramSpecialProcessBase_UnionUnion FromIStateProgramSpecialProcessChangeTeamOptimization(IStateProgramSpecialProcessChangeTeamOptimizationT _istateprogramspecialprocesschangeteamoptimization)
		{
			return new IStateProgramSpecialProcessBase_UnionUnion
			{
				Type = IStateProgramSpecialProcessBase_Union.IStateProgramSpecialProcessChangeTeamOptimization,
				Value = _istateprogramspecialprocesschangeteamoptimization
			};
		}

		// Token: 0x06036DB2 RID: 224690 RVA: 0x0075669C File Offset: 0x0075489C
		public static int Pack(FlatBufferBuilder builder, IStateProgramSpecialProcessBase_UnionUnion _o)
		{
			IStateProgramSpecialProcessBase_Union type = _o.Type;
			if (type == IStateProgramSpecialProcessBase_Union.IStateProgramSpecialProcessBase)
			{
				return IStateProgramSpecialProcessBase.Pack(builder, _o.AsIStateProgramSpecialProcessBase()).Value;
			}
			if (type != IStateProgramSpecialProcessBase_Union.IStateProgramSpecialProcessChangeTeamOptimization)
			{
				return 0;
			}
			return IStateProgramSpecialProcessChangeTeamOptimization.Pack(builder, _o.AsIStateProgramSpecialProcessChangeTeamOptimization()).Value;
		}
	}
}
