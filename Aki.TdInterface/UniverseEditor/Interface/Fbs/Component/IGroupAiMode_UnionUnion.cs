using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200533C RID: 21308
	public class IGroupAiMode_UnionUnion
	{
		// Token: 0x17009C83 RID: 40067
		// (get) Token: 0x06022D72 RID: 142706 RVA: 0x004D3B41 File Offset: 0x004D1D41
		// (set) Token: 0x06022D73 RID: 142707 RVA: 0x004D3B49 File Offset: 0x004D1D49
		public IGroupAiMode_Union Type { get; set; }

		// Token: 0x17009C84 RID: 40068
		// (get) Token: 0x06022D74 RID: 142708 RVA: 0x004D3B52 File Offset: 0x004D1D52
		// (set) Token: 0x06022D75 RID: 142709 RVA: 0x004D3B5A File Offset: 0x004D1D5A
		public object Value { get; set; }

		// Token: 0x06022D76 RID: 142710 RVA: 0x004D3B63 File Offset: 0x004D1D63
		public IGroupAiMode_UnionUnion()
		{
			this.Type = IGroupAiMode_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06022D77 RID: 142711 RVA: 0x004D3B79 File Offset: 0x004D1D79
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06022D78 RID: 142712 RVA: 0x004D3B8B File Offset: 0x004D1D8B
		public IGroupAiModeT AsIGroupAiMode()
		{
			return this.As<IGroupAiModeT>();
		}

		// Token: 0x06022D79 RID: 142713 RVA: 0x004D3B93 File Offset: 0x004D1D93
		public static IGroupAiMode_UnionUnion FromIGroupAiMode(IGroupAiModeT _igroupaimode)
		{
			return new IGroupAiMode_UnionUnion
			{
				Type = IGroupAiMode_Union.IGroupAiMode,
				Value = _igroupaimode
			};
		}

		// Token: 0x06022D7A RID: 142714 RVA: 0x004D3BA8 File Offset: 0x004D1DA8
		public IGroupAiModeDefaultT AsIGroupAiModeDefault()
		{
			return this.As<IGroupAiModeDefaultT>();
		}

		// Token: 0x06022D7B RID: 142715 RVA: 0x004D3BB0 File Offset: 0x004D1DB0
		public static IGroupAiMode_UnionUnion FromIGroupAiModeDefault(IGroupAiModeDefaultT _igroupaimodedefault)
		{
			return new IGroupAiMode_UnionUnion
			{
				Type = IGroupAiMode_Union.IGroupAiModeDefault,
				Value = _igroupaimodedefault
			};
		}

		// Token: 0x06022D7C RID: 142716 RVA: 0x004D3BC5 File Offset: 0x004D1DC5
		public IGroupAiPatrolT AsIGroupAiPatrol()
		{
			return this.As<IGroupAiPatrolT>();
		}

		// Token: 0x06022D7D RID: 142717 RVA: 0x004D3BCD File Offset: 0x004D1DCD
		public static IGroupAiMode_UnionUnion FromIGroupAiPatrol(IGroupAiPatrolT _igroupaipatrol)
		{
			return new IGroupAiMode_UnionUnion
			{
				Type = IGroupAiMode_Union.IGroupAiPatrol,
				Value = _igroupaipatrol
			};
		}

		// Token: 0x06022D7E RID: 142718 RVA: 0x004D3BE2 File Offset: 0x004D1DE2
		public IGroupAiMonsterEcologyT AsIGroupAiMonsterEcology()
		{
			return this.As<IGroupAiMonsterEcologyT>();
		}

		// Token: 0x06022D7F RID: 142719 RVA: 0x004D3BEA File Offset: 0x004D1DEA
		public static IGroupAiMode_UnionUnion FromIGroupAiMonsterEcology(IGroupAiMonsterEcologyT _igroupaimonsterecology)
		{
			return new IGroupAiMode_UnionUnion
			{
				Type = IGroupAiMode_Union.IGroupAiMonsterEcology,
				Value = _igroupaimonsterecology
			};
		}

		// Token: 0x06022D80 RID: 142720 RVA: 0x004D3C00 File Offset: 0x004D1E00
		public static int Pack(FlatBufferBuilder builder, IGroupAiMode_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IGroupAiMode_Union.IGroupAiMode:
				return IGroupAiMode.Pack(builder, _o.AsIGroupAiMode()).Value;
			case IGroupAiMode_Union.IGroupAiModeDefault:
				return IGroupAiModeDefault.Pack(builder, _o.AsIGroupAiModeDefault()).Value;
			case IGroupAiMode_Union.IGroupAiPatrol:
				return IGroupAiPatrol.Pack(builder, _o.AsIGroupAiPatrol()).Value;
			case IGroupAiMode_Union.IGroupAiMonsterEcology:
				return IGroupAiMonsterEcology.Pack(builder, _o.AsIGroupAiMonsterEcology()).Value;
			default:
				return 0;
			}
		}
	}
}
