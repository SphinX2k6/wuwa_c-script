using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020071C4 RID: 29124
	public class IStateProgramSpecialProcessBase_UnionUnion
	{
		// Token: 0x1700D868 RID: 55400
		// (get) Token: 0x06033AA6 RID: 211622 RVA: 0x006F52B5 File Offset: 0x006F34B5
		// (set) Token: 0x06033AA7 RID: 211623 RVA: 0x006F52BD File Offset: 0x006F34BD
		public IStateProgramSpecialProcessBase_Union Type { get; set; }

		// Token: 0x1700D869 RID: 55401
		// (get) Token: 0x06033AA8 RID: 211624 RVA: 0x006F52C6 File Offset: 0x006F34C6
		// (set) Token: 0x06033AA9 RID: 211625 RVA: 0x006F52CE File Offset: 0x006F34CE
		public object Value { get; set; }

		// Token: 0x06033AAA RID: 211626 RVA: 0x006F52D7 File Offset: 0x006F34D7
		public IStateProgramSpecialProcessBase_UnionUnion()
		{
			this.Type = IStateProgramSpecialProcessBase_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06033AAB RID: 211627 RVA: 0x006F52ED File Offset: 0x006F34ED
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06033AAC RID: 211628 RVA: 0x006F52FF File Offset: 0x006F34FF
		public IStateProgramSpecialProcessBaseT AsIStateProgramSpecialProcessBase()
		{
			return this.As<IStateProgramSpecialProcessBaseT>();
		}

		// Token: 0x06033AAD RID: 211629 RVA: 0x006F5307 File Offset: 0x006F3507
		public static IStateProgramSpecialProcessBase_UnionUnion FromIStateProgramSpecialProcessBase(IStateProgramSpecialProcessBaseT _istateprogramspecialprocessbase)
		{
			return new IStateProgramSpecialProcessBase_UnionUnion
			{
				Type = IStateProgramSpecialProcessBase_Union.IStateProgramSpecialProcessBase,
				Value = _istateprogramspecialprocessbase
			};
		}

		// Token: 0x06033AAE RID: 211630 RVA: 0x006F531C File Offset: 0x006F351C
		public IStateProgramSpecialProcessChangeTeamOptimizationT AsIStateProgramSpecialProcessChangeTeamOptimization()
		{
			return this.As<IStateProgramSpecialProcessChangeTeamOptimizationT>();
		}

		// Token: 0x06033AAF RID: 211631 RVA: 0x006F5324 File Offset: 0x006F3524
		public static IStateProgramSpecialProcessBase_UnionUnion FromIStateProgramSpecialProcessChangeTeamOptimization(IStateProgramSpecialProcessChangeTeamOptimizationT _istateprogramspecialprocesschangeteamoptimization)
		{
			return new IStateProgramSpecialProcessBase_UnionUnion
			{
				Type = IStateProgramSpecialProcessBase_Union.IStateProgramSpecialProcessChangeTeamOptimization,
				Value = _istateprogramspecialprocesschangeteamoptimization
			};
		}

		// Token: 0x06033AB0 RID: 211632 RVA: 0x006F533C File Offset: 0x006F353C
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
