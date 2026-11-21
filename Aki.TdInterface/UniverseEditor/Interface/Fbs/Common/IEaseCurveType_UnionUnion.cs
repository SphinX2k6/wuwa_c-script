using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x020063DB RID: 25563
	public class IEaseCurveType_UnionUnion
	{
		// Token: 0x1700BCDF RID: 48351
		// (get) Token: 0x0602B6BE RID: 177854 RVA: 0x005EABD1 File Offset: 0x005E8DD1
		// (set) Token: 0x0602B6BF RID: 177855 RVA: 0x005EABD9 File Offset: 0x005E8DD9
		public IEaseCurveType_Union Type { get; set; }

		// Token: 0x1700BCE0 RID: 48352
		// (get) Token: 0x0602B6C0 RID: 177856 RVA: 0x005EABE2 File Offset: 0x005E8DE2
		// (set) Token: 0x0602B6C1 RID: 177857 RVA: 0x005EABEA File Offset: 0x005E8DEA
		public object Value { get; set; }

		// Token: 0x0602B6C2 RID: 177858 RVA: 0x005EABF3 File Offset: 0x005E8DF3
		public IEaseCurveType_UnionUnion()
		{
			this.Type = IEaseCurveType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0602B6C3 RID: 177859 RVA: 0x005EAC09 File Offset: 0x005E8E09
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602B6C4 RID: 177860 RVA: 0x005EAC1B File Offset: 0x005E8E1B
		public IEaseCurveTypeT AsIEaseCurveType()
		{
			return this.As<IEaseCurveTypeT>();
		}

		// Token: 0x0602B6C5 RID: 177861 RVA: 0x005EAC23 File Offset: 0x005E8E23
		public static IEaseCurveType_UnionUnion FromIEaseCurveType(IEaseCurveTypeT _ieasecurvetype)
		{
			return new IEaseCurveType_UnionUnion
			{
				Type = IEaseCurveType_Union.IEaseCurveType,
				Value = _ieasecurvetype
			};
		}

		// Token: 0x0602B6C6 RID: 177862 RVA: 0x005EAC38 File Offset: 0x005E8E38
		public IEaseCurvePresetT AsIEaseCurvePreset()
		{
			return this.As<IEaseCurvePresetT>();
		}

		// Token: 0x0602B6C7 RID: 177863 RVA: 0x005EAC40 File Offset: 0x005E8E40
		public static IEaseCurveType_UnionUnion FromIEaseCurvePreset(IEaseCurvePresetT _ieasecurvepreset)
		{
			return new IEaseCurveType_UnionUnion
			{
				Type = IEaseCurveType_Union.IEaseCurvePreset,
				Value = _ieasecurvepreset
			};
		}

		// Token: 0x0602B6C8 RID: 177864 RVA: 0x005EAC55 File Offset: 0x005E8E55
		public IEaseCurveCustomT AsIEaseCurveCustom()
		{
			return this.As<IEaseCurveCustomT>();
		}

		// Token: 0x0602B6C9 RID: 177865 RVA: 0x005EAC5D File Offset: 0x005E8E5D
		public static IEaseCurveType_UnionUnion FromIEaseCurveCustom(IEaseCurveCustomT _ieasecurvecustom)
		{
			return new IEaseCurveType_UnionUnion
			{
				Type = IEaseCurveType_Union.IEaseCurveCustom,
				Value = _ieasecurvecustom
			};
		}

		// Token: 0x0602B6CA RID: 177866 RVA: 0x005EAC74 File Offset: 0x005E8E74
		public static int Pack(FlatBufferBuilder builder, IEaseCurveType_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IEaseCurveType_Union.IEaseCurveType:
				return IEaseCurveType.Pack(builder, _o.AsIEaseCurveType()).Value;
			case IEaseCurveType_Union.IEaseCurvePreset:
				return IEaseCurvePreset.Pack(builder, _o.AsIEaseCurvePreset()).Value;
			case IEaseCurveType_Union.IEaseCurveCustom:
				return IEaseCurveCustom.Pack(builder, _o.AsIEaseCurveCustom()).Value;
			default:
				return 0;
			}
		}
	}
}
