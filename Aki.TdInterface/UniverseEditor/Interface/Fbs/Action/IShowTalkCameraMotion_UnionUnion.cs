using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020070F8 RID: 28920
	public class IShowTalkCameraMotion_UnionUnion
	{
		// Token: 0x1700D6FF RID: 55039
		// (get) Token: 0x06033435 RID: 209973 RVA: 0x006E97E6 File Offset: 0x006E79E6
		// (set) Token: 0x06033436 RID: 209974 RVA: 0x006E97EE File Offset: 0x006E79EE
		public IShowTalkCameraMotion_Union Type { get; set; }

		// Token: 0x1700D700 RID: 55040
		// (get) Token: 0x06033437 RID: 209975 RVA: 0x006E97F7 File Offset: 0x006E79F7
		// (set) Token: 0x06033438 RID: 209976 RVA: 0x006E97FF File Offset: 0x006E79FF
		public object Value { get; set; }

		// Token: 0x06033439 RID: 209977 RVA: 0x006E9808 File Offset: 0x006E7A08
		public IShowTalkCameraMotion_UnionUnion()
		{
			this.Type = IShowTalkCameraMotion_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0603343A RID: 209978 RVA: 0x006E981E File Offset: 0x006E7A1E
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0603343B RID: 209979 RVA: 0x006E9830 File Offset: 0x006E7A30
		public IShowTalkCameraMotionT AsIShowTalkCameraMotion()
		{
			return this.As<IShowTalkCameraMotionT>();
		}

		// Token: 0x0603343C RID: 209980 RVA: 0x006E9838 File Offset: 0x006E7A38
		public static IShowTalkCameraMotion_UnionUnion FromIShowTalkCameraMotion(IShowTalkCameraMotionT _ishowtalkcameramotion)
		{
			return new IShowTalkCameraMotion_UnionUnion
			{
				Type = IShowTalkCameraMotion_Union.IShowTalkCameraMotion,
				Value = _ishowtalkcameramotion
			};
		}

		// Token: 0x0603343D RID: 209981 RVA: 0x006E984D File Offset: 0x006E7A4D
		public IShowTalkCameraMotionPresetT AsIShowTalkCameraMotionPreset()
		{
			return this.As<IShowTalkCameraMotionPresetT>();
		}

		// Token: 0x0603343E RID: 209982 RVA: 0x006E9855 File Offset: 0x006E7A55
		public static IShowTalkCameraMotion_UnionUnion FromIShowTalkCameraMotionPreset(IShowTalkCameraMotionPresetT _ishowtalkcameramotionpreset)
		{
			return new IShowTalkCameraMotion_UnionUnion
			{
				Type = IShowTalkCameraMotion_Union.IShowTalkCameraMotionPreset,
				Value = _ishowtalkcameramotionpreset
			};
		}

		// Token: 0x0603343F RID: 209983 RVA: 0x006E986A File Offset: 0x006E7A6A
		public IShowTalkCameraMotionTweenT AsIShowTalkCameraMotionTween()
		{
			return this.As<IShowTalkCameraMotionTweenT>();
		}

		// Token: 0x06033440 RID: 209984 RVA: 0x006E9872 File Offset: 0x006E7A72
		public static IShowTalkCameraMotion_UnionUnion FromIShowTalkCameraMotionTween(IShowTalkCameraMotionTweenT _ishowtalkcameramotiontween)
		{
			return new IShowTalkCameraMotion_UnionUnion
			{
				Type = IShowTalkCameraMotion_Union.IShowTalkCameraMotionTween,
				Value = _ishowtalkcameramotiontween
			};
		}

		// Token: 0x06033441 RID: 209985 RVA: 0x006E9888 File Offset: 0x006E7A88
		public static int Pack(FlatBufferBuilder builder, IShowTalkCameraMotion_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IShowTalkCameraMotion_Union.IShowTalkCameraMotion:
				return IShowTalkCameraMotion.Pack(builder, _o.AsIShowTalkCameraMotion()).Value;
			case IShowTalkCameraMotion_Union.IShowTalkCameraMotionPreset:
				return IShowTalkCameraMotionPreset.Pack(builder, _o.AsIShowTalkCameraMotionPreset()).Value;
			case IShowTalkCameraMotion_Union.IShowTalkCameraMotionTween:
				return IShowTalkCameraMotionTween.Pack(builder, _o.AsIShowTalkCameraMotionTween()).Value;
			default:
				return 0;
			}
		}
	}
}
