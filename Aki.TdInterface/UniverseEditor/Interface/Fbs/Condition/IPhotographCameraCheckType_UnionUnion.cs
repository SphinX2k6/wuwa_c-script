using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004C7D RID: 19581
	public class IPhotographCameraCheckType_UnionUnion
	{
		// Token: 0x17008E34 RID: 36404
		// (get) Token: 0x0601F0CD RID: 127181 RVA: 0x00457075 File Offset: 0x00455275
		// (set) Token: 0x0601F0CE RID: 127182 RVA: 0x0045707D File Offset: 0x0045527D
		public IPhotographCameraCheckType_Union Type { get; set; }

		// Token: 0x17008E35 RID: 36405
		// (get) Token: 0x0601F0CF RID: 127183 RVA: 0x00457086 File Offset: 0x00455286
		// (set) Token: 0x0601F0D0 RID: 127184 RVA: 0x0045708E File Offset: 0x0045528E
		public object Value { get; set; }

		// Token: 0x0601F0D1 RID: 127185 RVA: 0x00457097 File Offset: 0x00455297
		public IPhotographCameraCheckType_UnionUnion()
		{
			this.Type = IPhotographCameraCheckType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0601F0D2 RID: 127186 RVA: 0x004570AD File Offset: 0x004552AD
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0601F0D3 RID: 127187 RVA: 0x004570BF File Offset: 0x004552BF
		public IPhotographCameraCheckTypeT AsIPhotographCameraCheckType()
		{
			return this.As<IPhotographCameraCheckTypeT>();
		}

		// Token: 0x0601F0D4 RID: 127188 RVA: 0x004570C7 File Offset: 0x004552C7
		public static IPhotographCameraCheckType_UnionUnion FromIPhotographCameraCheckType(IPhotographCameraCheckTypeT _iphotographcamerachecktype)
		{
			return new IPhotographCameraCheckType_UnionUnion
			{
				Type = IPhotographCameraCheckType_Union.IPhotographCameraCheckType,
				Value = _iphotographcamerachecktype
			};
		}

		// Token: 0x0601F0D5 RID: 127189 RVA: 0x004570DC File Offset: 0x004552DC
		public IPhotographCameraCheckTemplateT AsIPhotographCameraCheckTemplate()
		{
			return this.As<IPhotographCameraCheckTemplateT>();
		}

		// Token: 0x0601F0D6 RID: 127190 RVA: 0x004570E4 File Offset: 0x004552E4
		public static IPhotographCameraCheckType_UnionUnion FromIPhotographCameraCheckTemplate(IPhotographCameraCheckTemplateT _iphotographcamerachecktemplate)
		{
			return new IPhotographCameraCheckType_UnionUnion
			{
				Type = IPhotographCameraCheckType_Union.IPhotographCameraCheckTemplate,
				Value = _iphotographcamerachecktemplate
			};
		}

		// Token: 0x0601F0D7 RID: 127191 RVA: 0x004570F9 File Offset: 0x004552F9
		public IPhotographCameraCheckAspectRatioTypeT AsIPhotographCameraCheckAspectRatioType()
		{
			return this.As<IPhotographCameraCheckAspectRatioTypeT>();
		}

		// Token: 0x0601F0D8 RID: 127192 RVA: 0x00457101 File Offset: 0x00455301
		public static IPhotographCameraCheckType_UnionUnion FromIPhotographCameraCheckAspectRatioType(IPhotographCameraCheckAspectRatioTypeT _iphotographcameracheckaspectratiotype)
		{
			return new IPhotographCameraCheckType_UnionUnion
			{
				Type = IPhotographCameraCheckType_Union.IPhotographCameraCheckAspectRatioType,
				Value = _iphotographcameracheckaspectratiotype
			};
		}

		// Token: 0x0601F0D9 RID: 127193 RVA: 0x00457116 File Offset: 0x00455316
		public IPhotographCameraCheckBlurIntensityT AsIPhotographCameraCheckBlurIntensity()
		{
			return this.As<IPhotographCameraCheckBlurIntensityT>();
		}

		// Token: 0x0601F0DA RID: 127194 RVA: 0x0045711E File Offset: 0x0045531E
		public static IPhotographCameraCheckType_UnionUnion FromIPhotographCameraCheckBlurIntensity(IPhotographCameraCheckBlurIntensityT _iphotographcameracheckblurintensity)
		{
			return new IPhotographCameraCheckType_UnionUnion
			{
				Type = IPhotographCameraCheckType_Union.IPhotographCameraCheckBlurIntensity,
				Value = _iphotographcameracheckblurintensity
			};
		}

		// Token: 0x0601F0DB RID: 127195 RVA: 0x00457134 File Offset: 0x00455334
		public static int Pack(FlatBufferBuilder builder, IPhotographCameraCheckType_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IPhotographCameraCheckType_Union.IPhotographCameraCheckType:
				return IPhotographCameraCheckType.Pack(builder, _o.AsIPhotographCameraCheckType()).Value;
			case IPhotographCameraCheckType_Union.IPhotographCameraCheckTemplate:
				return IPhotographCameraCheckTemplate.Pack(builder, _o.AsIPhotographCameraCheckTemplate()).Value;
			case IPhotographCameraCheckType_Union.IPhotographCameraCheckAspectRatioType:
				return IPhotographCameraCheckAspectRatioType.Pack(builder, _o.AsIPhotographCameraCheckAspectRatioType()).Value;
			case IPhotographCameraCheckType_Union.IPhotographCameraCheckBlurIntensity:
				return IPhotographCameraCheckBlurIntensity.Pack(builder, _o.AsIPhotographCameraCheckBlurIntensity()).Value;
			default:
				return 0;
			}
		}
	}
}
