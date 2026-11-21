using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x020064BF RID: 25791
	public class TEaseCurveTypeUnion
	{
		// Token: 0x1700BE3A RID: 48698
		// (get) Token: 0x0602BD9C RID: 179612 RVA: 0x005F6B36 File Offset: 0x005F4D36
		// (set) Token: 0x0602BD9D RID: 179613 RVA: 0x005F6B3E File Offset: 0x005F4D3E
		public TEaseCurveType Type { get; set; }

		// Token: 0x1700BE3B RID: 48699
		// (get) Token: 0x0602BD9E RID: 179614 RVA: 0x005F6B47 File Offset: 0x005F4D47
		// (set) Token: 0x0602BD9F RID: 179615 RVA: 0x005F6B4F File Offset: 0x005F4D4F
		public object Value { get; set; }

		// Token: 0x0602BDA0 RID: 179616 RVA: 0x005F6B58 File Offset: 0x005F4D58
		public TEaseCurveTypeUnion()
		{
			this.Type = TEaseCurveType.NONE;
			this.Value = null;
		}

		// Token: 0x0602BDA1 RID: 179617 RVA: 0x005F6B6E File Offset: 0x005F4D6E
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602BDA2 RID: 179618 RVA: 0x005F6B80 File Offset: 0x005F4D80
		public IEaseCurveCustomT AsIEaseCurveCustom()
		{
			return this.As<IEaseCurveCustomT>();
		}

		// Token: 0x0602BDA3 RID: 179619 RVA: 0x005F6B88 File Offset: 0x005F4D88
		public static TEaseCurveTypeUnion FromIEaseCurveCustom(IEaseCurveCustomT _ieasecurvecustom)
		{
			return new TEaseCurveTypeUnion
			{
				Type = TEaseCurveType.IEaseCurveCustom,
				Value = _ieasecurvecustom
			};
		}

		// Token: 0x0602BDA4 RID: 179620 RVA: 0x005F6B9D File Offset: 0x005F4D9D
		public IEaseCurvePresetT AsIEaseCurvePreset()
		{
			return this.As<IEaseCurvePresetT>();
		}

		// Token: 0x0602BDA5 RID: 179621 RVA: 0x005F6BA5 File Offset: 0x005F4DA5
		public static TEaseCurveTypeUnion FromIEaseCurvePreset(IEaseCurvePresetT _ieasecurvepreset)
		{
			return new TEaseCurveTypeUnion
			{
				Type = TEaseCurveType.IEaseCurvePreset,
				Value = _ieasecurvepreset
			};
		}

		// Token: 0x0602BDA6 RID: 179622 RVA: 0x005F6BBC File Offset: 0x005F4DBC
		public static int Pack(FlatBufferBuilder builder, TEaseCurveTypeUnion _o)
		{
			TEaseCurveType type = _o.Type;
			if (type == TEaseCurveType.IEaseCurveCustom)
			{
				return IEaseCurveCustom.Pack(builder, _o.AsIEaseCurveCustom()).Value;
			}
			if (type != TEaseCurveType.IEaseCurvePreset)
			{
				return 0;
			}
			return IEaseCurvePreset.Pack(builder, _o.AsIEaseCurvePreset()).Value;
		}
	}
}
