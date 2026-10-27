using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005D9E RID: 23966
	public class IEaseCurveType_UnionUnion
	{
		// Token: 0x1700B379 RID: 45945
		// (get) Token: 0x06029034 RID: 167988 RVA: 0x005A1EA1 File Offset: 0x005A00A1
		// (set) Token: 0x06029035 RID: 167989 RVA: 0x005A1EA9 File Offset: 0x005A00A9
		public IEaseCurveType_Union Type { get; set; }

		// Token: 0x1700B37A RID: 45946
		// (get) Token: 0x06029036 RID: 167990 RVA: 0x005A1EB2 File Offset: 0x005A00B2
		// (set) Token: 0x06029037 RID: 167991 RVA: 0x005A1EBA File Offset: 0x005A00BA
		public object Value { get; set; }

		// Token: 0x06029038 RID: 167992 RVA: 0x005A1EC3 File Offset: 0x005A00C3
		public IEaseCurveType_UnionUnion()
		{
			this.Type = IEaseCurveType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06029039 RID: 167993 RVA: 0x005A1ED9 File Offset: 0x005A00D9
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602903A RID: 167994 RVA: 0x005A1EEB File Offset: 0x005A00EB
		public IEaseCurveTypeT AsIEaseCurveType()
		{
			return this.As<IEaseCurveTypeT>();
		}

		// Token: 0x0602903B RID: 167995 RVA: 0x005A1EF3 File Offset: 0x005A00F3
		public static IEaseCurveType_UnionUnion FromIEaseCurveType(IEaseCurveTypeT _ieasecurvetype)
		{
			return new IEaseCurveType_UnionUnion
			{
				Type = IEaseCurveType_Union.IEaseCurveType,
				Value = _ieasecurvetype
			};
		}

		// Token: 0x0602903C RID: 167996 RVA: 0x005A1F08 File Offset: 0x005A0108
		public IEaseCurvePresetT AsIEaseCurvePreset()
		{
			return this.As<IEaseCurvePresetT>();
		}

		// Token: 0x0602903D RID: 167997 RVA: 0x005A1F10 File Offset: 0x005A0110
		public static IEaseCurveType_UnionUnion FromIEaseCurvePreset(IEaseCurvePresetT _ieasecurvepreset)
		{
			return new IEaseCurveType_UnionUnion
			{
				Type = IEaseCurveType_Union.IEaseCurvePreset,
				Value = _ieasecurvepreset
			};
		}

		// Token: 0x0602903E RID: 167998 RVA: 0x005A1F25 File Offset: 0x005A0125
		public IEaseCurveCustomT AsIEaseCurveCustom()
		{
			return this.As<IEaseCurveCustomT>();
		}

		// Token: 0x0602903F RID: 167999 RVA: 0x005A1F2D File Offset: 0x005A012D
		public static IEaseCurveType_UnionUnion FromIEaseCurveCustom(IEaseCurveCustomT _ieasecurvecustom)
		{
			return new IEaseCurveType_UnionUnion
			{
				Type = IEaseCurveType_Union.IEaseCurveCustom,
				Value = _ieasecurvecustom
			};
		}

		// Token: 0x06029040 RID: 168000 RVA: 0x005A1F44 File Offset: 0x005A0144
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
