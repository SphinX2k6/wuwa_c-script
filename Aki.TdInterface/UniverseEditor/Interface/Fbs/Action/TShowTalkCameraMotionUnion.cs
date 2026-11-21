using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007FC5 RID: 32709
	public class TShowTalkCameraMotionUnion
	{
		// Token: 0x1700F2FB RID: 62203
		// (get) Token: 0x0603AE71 RID: 241265 RVA: 0x007E9CD6 File Offset: 0x007E7ED6
		// (set) Token: 0x0603AE72 RID: 241266 RVA: 0x007E9CDE File Offset: 0x007E7EDE
		public TShowTalkCameraMotion Type { get; set; }

		// Token: 0x1700F2FC RID: 62204
		// (get) Token: 0x0603AE73 RID: 241267 RVA: 0x007E9CE7 File Offset: 0x007E7EE7
		// (set) Token: 0x0603AE74 RID: 241268 RVA: 0x007E9CEF File Offset: 0x007E7EEF
		public object Value { get; set; }

		// Token: 0x0603AE75 RID: 241269 RVA: 0x007E9CF8 File Offset: 0x007E7EF8
		public TShowTalkCameraMotionUnion()
		{
			this.Type = TShowTalkCameraMotion.NONE;
			this.Value = null;
		}

		// Token: 0x0603AE76 RID: 241270 RVA: 0x007E9D0E File Offset: 0x007E7F0E
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0603AE77 RID: 241271 RVA: 0x007E9D20 File Offset: 0x007E7F20
		public IShowTalkCameraMotionPresetT AsIShowTalkCameraMotionPreset()
		{
			return this.As<IShowTalkCameraMotionPresetT>();
		}

		// Token: 0x0603AE78 RID: 241272 RVA: 0x007E9D28 File Offset: 0x007E7F28
		public static TShowTalkCameraMotionUnion FromIShowTalkCameraMotionPreset(IShowTalkCameraMotionPresetT _ishowtalkcameramotionpreset)
		{
			return new TShowTalkCameraMotionUnion
			{
				Type = TShowTalkCameraMotion.IShowTalkCameraMotionPreset,
				Value = _ishowtalkcameramotionpreset
			};
		}

		// Token: 0x0603AE79 RID: 241273 RVA: 0x007E9D3D File Offset: 0x007E7F3D
		public IShowTalkCameraMotionTweenT AsIShowTalkCameraMotionTween()
		{
			return this.As<IShowTalkCameraMotionTweenT>();
		}

		// Token: 0x0603AE7A RID: 241274 RVA: 0x007E9D45 File Offset: 0x007E7F45
		public static TShowTalkCameraMotionUnion FromIShowTalkCameraMotionTween(IShowTalkCameraMotionTweenT _ishowtalkcameramotiontween)
		{
			return new TShowTalkCameraMotionUnion
			{
				Type = TShowTalkCameraMotion.IShowTalkCameraMotionTween,
				Value = _ishowtalkcameramotiontween
			};
		}

		// Token: 0x0603AE7B RID: 241275 RVA: 0x007E9D5C File Offset: 0x007E7F5C
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
