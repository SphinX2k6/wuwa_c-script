using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005E7C RID: 24188
	public class TEaseCurveTypeUnion
	{
		// Token: 0x1700B4CF RID: 46287
		// (get) Token: 0x060296F4 RID: 169716 RVA: 0x005ADB92 File Offset: 0x005ABD92
		// (set) Token: 0x060296F5 RID: 169717 RVA: 0x005ADB9A File Offset: 0x005ABD9A
		public TEaseCurveType Type { get; set; }

		// Token: 0x1700B4D0 RID: 46288
		// (get) Token: 0x060296F6 RID: 169718 RVA: 0x005ADBA3 File Offset: 0x005ABDA3
		// (set) Token: 0x060296F7 RID: 169719 RVA: 0x005ADBAB File Offset: 0x005ABDAB
		public object Value { get; set; }

		// Token: 0x060296F8 RID: 169720 RVA: 0x005ADBB4 File Offset: 0x005ABDB4
		public TEaseCurveTypeUnion()
		{
			this.Type = TEaseCurveType.NONE;
			this.Value = null;
		}

		// Token: 0x060296F9 RID: 169721 RVA: 0x005ADBCA File Offset: 0x005ABDCA
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060296FA RID: 169722 RVA: 0x005ADBDC File Offset: 0x005ABDDC
		public IEaseCurveCustomT AsIEaseCurveCustom()
		{
			return this.As<IEaseCurveCustomT>();
		}

		// Token: 0x060296FB RID: 169723 RVA: 0x005ADBE4 File Offset: 0x005ABDE4
		public static TEaseCurveTypeUnion FromIEaseCurveCustom(IEaseCurveCustomT _ieasecurvecustom)
		{
			return new TEaseCurveTypeUnion
			{
				Type = TEaseCurveType.IEaseCurveCustom,
				Value = _ieasecurvecustom
			};
		}

		// Token: 0x060296FC RID: 169724 RVA: 0x005ADBF9 File Offset: 0x005ABDF9
		public IEaseCurvePresetT AsIEaseCurvePreset()
		{
			return this.As<IEaseCurvePresetT>();
		}

		// Token: 0x060296FD RID: 169725 RVA: 0x005ADC01 File Offset: 0x005ABE01
		public static TEaseCurveTypeUnion FromIEaseCurvePreset(IEaseCurvePresetT _ieasecurvepreset)
		{
			return new TEaseCurveTypeUnion
			{
				Type = TEaseCurveType.IEaseCurvePreset,
				Value = _ieasecurvepreset
			};
		}

		// Token: 0x060296FE RID: 169726 RVA: 0x005ADC18 File Offset: 0x005ABE18
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
