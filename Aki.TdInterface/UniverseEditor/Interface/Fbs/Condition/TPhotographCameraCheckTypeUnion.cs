using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004D4F RID: 19791
	public class TPhotographCameraCheckTypeUnion
	{
		// Token: 0x17008F4F RID: 36687
		// (get) Token: 0x0601F67A RID: 128634 RVA: 0x00460436 File Offset: 0x0045E636
		// (set) Token: 0x0601F67B RID: 128635 RVA: 0x0046043E File Offset: 0x0045E63E
		public TPhotographCameraCheckType Type { get; set; }

		// Token: 0x17008F50 RID: 36688
		// (get) Token: 0x0601F67C RID: 128636 RVA: 0x00460447 File Offset: 0x0045E647
		// (set) Token: 0x0601F67D RID: 128637 RVA: 0x0046044F File Offset: 0x0045E64F
		public object Value { get; set; }

		// Token: 0x0601F67E RID: 128638 RVA: 0x00460458 File Offset: 0x0045E658
		public TPhotographCameraCheckTypeUnion()
		{
			this.Type = TPhotographCameraCheckType.NONE;
			this.Value = null;
		}

		// Token: 0x0601F67F RID: 128639 RVA: 0x0046046E File Offset: 0x0045E66E
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0601F680 RID: 128640 RVA: 0x00460480 File Offset: 0x0045E680
		public IPhotographCameraCheckAspectRatioTypeT AsIPhotographCameraCheckAspectRatioType()
		{
			return this.As<IPhotographCameraCheckAspectRatioTypeT>();
		}

		// Token: 0x0601F681 RID: 128641 RVA: 0x00460488 File Offset: 0x0045E688
		public static TPhotographCameraCheckTypeUnion FromIPhotographCameraCheckAspectRatioType(IPhotographCameraCheckAspectRatioTypeT _iphotographcameracheckaspectratiotype)
		{
			return new TPhotographCameraCheckTypeUnion
			{
				Type = TPhotographCameraCheckType.IPhotographCameraCheckAspectRatioType,
				Value = _iphotographcameracheckaspectratiotype
			};
		}

		// Token: 0x0601F682 RID: 128642 RVA: 0x0046049D File Offset: 0x0045E69D
		public IPhotographCameraCheckBlurIntensityT AsIPhotographCameraCheckBlurIntensity()
		{
			return this.As<IPhotographCameraCheckBlurIntensityT>();
		}

		// Token: 0x0601F683 RID: 128643 RVA: 0x004604A5 File Offset: 0x0045E6A5
		public static TPhotographCameraCheckTypeUnion FromIPhotographCameraCheckBlurIntensity(IPhotographCameraCheckBlurIntensityT _iphotographcameracheckblurintensity)
		{
			return new TPhotographCameraCheckTypeUnion
			{
				Type = TPhotographCameraCheckType.IPhotographCameraCheckBlurIntensity,
				Value = _iphotographcameracheckblurintensity
			};
		}

		// Token: 0x0601F684 RID: 128644 RVA: 0x004604BA File Offset: 0x0045E6BA
		public IPhotographCameraCheckTemplateT AsIPhotographCameraCheckTemplate()
		{
			return this.As<IPhotographCameraCheckTemplateT>();
		}

		// Token: 0x0601F685 RID: 128645 RVA: 0x004604C2 File Offset: 0x0045E6C2
		public static TPhotographCameraCheckTypeUnion FromIPhotographCameraCheckTemplate(IPhotographCameraCheckTemplateT _iphotographcamerachecktemplate)
		{
			return new TPhotographCameraCheckTypeUnion
			{
				Type = TPhotographCameraCheckType.IPhotographCameraCheckTemplate,
				Value = _iphotographcamerachecktemplate
			};
		}

		// Token: 0x0601F686 RID: 128646 RVA: 0x004604D8 File Offset: 0x0045E6D8
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
