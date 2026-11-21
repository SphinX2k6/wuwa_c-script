using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02005176 RID: 20854
	public class IPhotographCameraCheckType_UnionUnion
	{
		// Token: 0x17009562 RID: 38242
		// (get) Token: 0x06020CEF RID: 134383 RVA: 0x0048ABC5 File Offset: 0x00488DC5
		// (set) Token: 0x06020CF0 RID: 134384 RVA: 0x0048ABCD File Offset: 0x00488DCD
		public IPhotographCameraCheckType_Union Type { get; set; }

		// Token: 0x17009563 RID: 38243
		// (get) Token: 0x06020CF1 RID: 134385 RVA: 0x0048ABD6 File Offset: 0x00488DD6
		// (set) Token: 0x06020CF2 RID: 134386 RVA: 0x0048ABDE File Offset: 0x00488DDE
		public object Value { get; set; }

		// Token: 0x06020CF3 RID: 134387 RVA: 0x0048ABE7 File Offset: 0x00488DE7
		public IPhotographCameraCheckType_UnionUnion()
		{
			this.Type = IPhotographCameraCheckType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06020CF4 RID: 134388 RVA: 0x0048ABFD File Offset: 0x00488DFD
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06020CF5 RID: 134389 RVA: 0x0048AC0F File Offset: 0x00488E0F
		public IPhotographCameraCheckTypeT AsIPhotographCameraCheckType()
		{
			return this.As<IPhotographCameraCheckTypeT>();
		}

		// Token: 0x06020CF6 RID: 134390 RVA: 0x0048AC17 File Offset: 0x00488E17
		public static IPhotographCameraCheckType_UnionUnion FromIPhotographCameraCheckType(IPhotographCameraCheckTypeT _iphotographcamerachecktype)
		{
			return new IPhotographCameraCheckType_UnionUnion
			{
				Type = IPhotographCameraCheckType_Union.IPhotographCameraCheckType,
				Value = _iphotographcamerachecktype
			};
		}

		// Token: 0x06020CF7 RID: 134391 RVA: 0x0048AC2C File Offset: 0x00488E2C
		public IPhotographCameraCheckTemplateT AsIPhotographCameraCheckTemplate()
		{
			return this.As<IPhotographCameraCheckTemplateT>();
		}

		// Token: 0x06020CF8 RID: 134392 RVA: 0x0048AC34 File Offset: 0x00488E34
		public static IPhotographCameraCheckType_UnionUnion FromIPhotographCameraCheckTemplate(IPhotographCameraCheckTemplateT _iphotographcamerachecktemplate)
		{
			return new IPhotographCameraCheckType_UnionUnion
			{
				Type = IPhotographCameraCheckType_Union.IPhotographCameraCheckTemplate,
				Value = _iphotographcamerachecktemplate
			};
		}

		// Token: 0x06020CF9 RID: 134393 RVA: 0x0048AC49 File Offset: 0x00488E49
		public IPhotographCameraCheckAspectRatioTypeT AsIPhotographCameraCheckAspectRatioType()
		{
			return this.As<IPhotographCameraCheckAspectRatioTypeT>();
		}

		// Token: 0x06020CFA RID: 134394 RVA: 0x0048AC51 File Offset: 0x00488E51
		public static IPhotographCameraCheckType_UnionUnion FromIPhotographCameraCheckAspectRatioType(IPhotographCameraCheckAspectRatioTypeT _iphotographcameracheckaspectratiotype)
		{
			return new IPhotographCameraCheckType_UnionUnion
			{
				Type = IPhotographCameraCheckType_Union.IPhotographCameraCheckAspectRatioType,
				Value = _iphotographcameracheckaspectratiotype
			};
		}

		// Token: 0x06020CFB RID: 134395 RVA: 0x0048AC66 File Offset: 0x00488E66
		public IPhotographCameraCheckBlurIntensityT AsIPhotographCameraCheckBlurIntensity()
		{
			return this.As<IPhotographCameraCheckBlurIntensityT>();
		}

		// Token: 0x06020CFC RID: 134396 RVA: 0x0048AC6E File Offset: 0x00488E6E
		public static IPhotographCameraCheckType_UnionUnion FromIPhotographCameraCheckBlurIntensity(IPhotographCameraCheckBlurIntensityT _iphotographcameracheckblurintensity)
		{
			return new IPhotographCameraCheckType_UnionUnion
			{
				Type = IPhotographCameraCheckType_Union.IPhotographCameraCheckBlurIntensity,
				Value = _iphotographcameracheckblurintensity
			};
		}

		// Token: 0x06020CFD RID: 134397 RVA: 0x0048AC84 File Offset: 0x00488E84
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
