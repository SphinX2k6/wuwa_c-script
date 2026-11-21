using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x0200524B RID: 21067
	public class TPhotographCameraCheckTypeUnion
	{
		// Token: 0x17009688 RID: 38536
		// (get) Token: 0x060212C3 RID: 135875 RVA: 0x0049440A File Offset: 0x0049260A
		// (set) Token: 0x060212C4 RID: 135876 RVA: 0x00494412 File Offset: 0x00492612
		public TPhotographCameraCheckType Type { get; set; }

		// Token: 0x17009689 RID: 38537
		// (get) Token: 0x060212C5 RID: 135877 RVA: 0x0049441B File Offset: 0x0049261B
		// (set) Token: 0x060212C6 RID: 135878 RVA: 0x00494423 File Offset: 0x00492623
		public object Value { get; set; }

		// Token: 0x060212C7 RID: 135879 RVA: 0x0049442C File Offset: 0x0049262C
		public TPhotographCameraCheckTypeUnion()
		{
			this.Type = TPhotographCameraCheckType.NONE;
			this.Value = null;
		}

		// Token: 0x060212C8 RID: 135880 RVA: 0x00494442 File Offset: 0x00492642
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060212C9 RID: 135881 RVA: 0x00494454 File Offset: 0x00492654
		public IPhotographCameraCheckAspectRatioTypeT AsIPhotographCameraCheckAspectRatioType()
		{
			return this.As<IPhotographCameraCheckAspectRatioTypeT>();
		}

		// Token: 0x060212CA RID: 135882 RVA: 0x0049445C File Offset: 0x0049265C
		public static TPhotographCameraCheckTypeUnion FromIPhotographCameraCheckAspectRatioType(IPhotographCameraCheckAspectRatioTypeT _iphotographcameracheckaspectratiotype)
		{
			return new TPhotographCameraCheckTypeUnion
			{
				Type = TPhotographCameraCheckType.IPhotographCameraCheckAspectRatioType,
				Value = _iphotographcameracheckaspectratiotype
			};
		}

		// Token: 0x060212CB RID: 135883 RVA: 0x00494471 File Offset: 0x00492671
		public IPhotographCameraCheckBlurIntensityT AsIPhotographCameraCheckBlurIntensity()
		{
			return this.As<IPhotographCameraCheckBlurIntensityT>();
		}

		// Token: 0x060212CC RID: 135884 RVA: 0x00494479 File Offset: 0x00492679
		public static TPhotographCameraCheckTypeUnion FromIPhotographCameraCheckBlurIntensity(IPhotographCameraCheckBlurIntensityT _iphotographcameracheckblurintensity)
		{
			return new TPhotographCameraCheckTypeUnion
			{
				Type = TPhotographCameraCheckType.IPhotographCameraCheckBlurIntensity,
				Value = _iphotographcameracheckblurintensity
			};
		}

		// Token: 0x060212CD RID: 135885 RVA: 0x0049448E File Offset: 0x0049268E
		public IPhotographCameraCheckTemplateT AsIPhotographCameraCheckTemplate()
		{
			return this.As<IPhotographCameraCheckTemplateT>();
		}

		// Token: 0x060212CE RID: 135886 RVA: 0x00494496 File Offset: 0x00492696
		public static TPhotographCameraCheckTypeUnion FromIPhotographCameraCheckTemplate(IPhotographCameraCheckTemplateT _iphotographcamerachecktemplate)
		{
			return new TPhotographCameraCheckTypeUnion
			{
				Type = TPhotographCameraCheckType.IPhotographCameraCheckTemplate,
				Value = _iphotographcamerachecktemplate
			};
		}

		// Token: 0x060212CF RID: 135887 RVA: 0x004944AC File Offset: 0x004926AC
		public static int Pack(FlatBufferBuilder builder, TPhotographCameraCheckTypeUnion _o)
		{
			switch (_o.Type)
			{
			case TPhotographCameraCheckType.IPhotographCameraCheckAspectRatioType:
				return IPhotographCameraCheckAspectRatioType.Pack(builder, _o.AsIPhotographCameraCheckAspectRatioType()).Value;
			case TPhotographCameraCheckType.IPhotographCameraCheckBlurIntensity:
				return IPhotographCameraCheckBlurIntensity.Pack(builder, _o.AsIPhotographCameraCheckBlurIntensity()).Value;
			case TPhotographCameraCheckType.IPhotographCameraCheckTemplate:
				return IPhotographCameraCheckTemplate.Pack(builder, _o.AsIPhotographCameraCheckTemplate()).Value;
			default:
				return 0;
			}
		}
	}
}
