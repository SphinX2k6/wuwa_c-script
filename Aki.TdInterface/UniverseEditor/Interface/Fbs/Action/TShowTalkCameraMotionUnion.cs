using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200778D RID: 30605
	public class TShowTalkCameraMotionUnion
	{
		// Token: 0x1700E6A1 RID: 59041
		// (get) Token: 0x060378F6 RID: 227574 RVA: 0x007847D6 File Offset: 0x007829D6
		// (set) Token: 0x060378F7 RID: 227575 RVA: 0x007847DE File Offset: 0x007829DE
		public TShowTalkCameraMotion Type { get; set; }

		// Token: 0x1700E6A2 RID: 59042
		// (get) Token: 0x060378F8 RID: 227576 RVA: 0x007847E7 File Offset: 0x007829E7
		// (set) Token: 0x060378F9 RID: 227577 RVA: 0x007847EF File Offset: 0x007829EF
		public object Value { get; set; }

		// Token: 0x060378FA RID: 227578 RVA: 0x007847F8 File Offset: 0x007829F8
		public TShowTalkCameraMotionUnion()
		{
			this.Type = TShowTalkCameraMotion.NONE;
			this.Value = null;
		}

		// Token: 0x060378FB RID: 227579 RVA: 0x0078480E File Offset: 0x00782A0E
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060378FC RID: 227580 RVA: 0x00784820 File Offset: 0x00782A20
		public IShowTalkCameraMotionPresetT AsIShowTalkCameraMotionPreset()
		{
			return this.As<IShowTalkCameraMotionPresetT>();
		}

		// Token: 0x060378FD RID: 227581 RVA: 0x00784828 File Offset: 0x00782A28
		public static TShowTalkCameraMotionUnion FromIShowTalkCameraMotionPreset(IShowTalkCameraMotionPresetT _ishowtalkcameramotionpreset)
		{
			return new TShowTalkCameraMotionUnion
			{
				Type = TShowTalkCameraMotion.IShowTalkCameraMotionPreset,
				Value = _ishowtalkcameramotionpreset
			};
		}

		// Token: 0x060378FE RID: 227582 RVA: 0x0078483D File Offset: 0x00782A3D
		public IShowTalkCameraMotionTweenT AsIShowTalkCameraMotionTween()
		{
			return this.As<IShowTalkCameraMotionTweenT>();
		}

		// Token: 0x060378FF RID: 227583 RVA: 0x00784845 File Offset: 0x00782A45
		public static TShowTalkCameraMotionUnion FromIShowTalkCameraMotionTween(IShowTalkCameraMotionTweenT _ishowtalkcameramotiontween)
		{
			return new TShowTalkCameraMotionUnion
			{
				Type = TShowTalkCameraMotion.IShowTalkCameraMotionTween,
				Value = _ishowtalkcameramotiontween
			};
		}

		// Token: 0x06037900 RID: 227584 RVA: 0x0078485C File Offset: 0x00782A5C
		public static int Pack(FlatBufferBuilder builder, TShowTalkCameraMotionUnion _o)
		{
			TShowTalkCameraMotion type = _o.Type;
			if (type == TShowTalkCameraMotion.IShowTalkCameraMotionPreset)
			{
				return IShowTalkCameraMotionPreset.Pack(builder, _o.AsIShowTalkCameraMotionPreset()).Value;
			}
			if (type != TShowTalkCameraMotion.IShowTalkCameraMotionTween)
			{
				return 0;
			}
			return IShowTalkCameraMotionTween.Pack(builder, _o.AsIShowTalkCameraMotionTween()).Value;
		}
	}
}
