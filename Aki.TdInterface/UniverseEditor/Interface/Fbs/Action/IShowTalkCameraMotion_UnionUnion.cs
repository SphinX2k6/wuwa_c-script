using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020078C4 RID: 30916
	public class IShowTalkCameraMotion_UnionUnion
	{
		// Token: 0x1700E2E2 RID: 58082
		// (get) Token: 0x060366D7 RID: 222935 RVA: 0x00749DF2 File Offset: 0x00747FF2
		// (set) Token: 0x060366D8 RID: 222936 RVA: 0x00749DFA File Offset: 0x00747FFA
		public IShowTalkCameraMotion_Union Type { get; set; }

		// Token: 0x1700E2E3 RID: 58083
		// (get) Token: 0x060366D9 RID: 222937 RVA: 0x00749E03 File Offset: 0x00748003
		// (set) Token: 0x060366DA RID: 222938 RVA: 0x00749E0B File Offset: 0x0074800B
		public object Value { get; set; }

		// Token: 0x060366DB RID: 222939 RVA: 0x00749E14 File Offset: 0x00748014
		public IShowTalkCameraMotion_UnionUnion()
		{
			this.Type = IShowTalkCameraMotion_Union.NONE;
			this.Value = null;
		}

		// Token: 0x060366DC RID: 222940 RVA: 0x00749E2A File Offset: 0x0074802A
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060366DD RID: 222941 RVA: 0x00749E3C File Offset: 0x0074803C
		public IShowTalkCameraMotionT AsIShowTalkCameraMotion()
		{
			return this.As<IShowTalkCameraMotionT>();
		}

		// Token: 0x060366DE RID: 222942 RVA: 0x00749E44 File Offset: 0x00748044
		public static IShowTalkCameraMotion_UnionUnion FromIShowTalkCameraMotion(IShowTalkCameraMotionT _ishowtalkcameramotion)
		{
			return new IShowTalkCameraMotion_UnionUnion
			{
				Type = IShowTalkCameraMotion_Union.IShowTalkCameraMotion,
				Value = _ishowtalkcameramotion
			};
		}

		// Token: 0x060366DF RID: 222943 RVA: 0x00749E59 File Offset: 0x00748059
		public IShowTalkCameraMotionPresetT AsIShowTalkCameraMotionPreset()
		{
			return this.As<IShowTalkCameraMotionPresetT>();
		}

		// Token: 0x060366E0 RID: 222944 RVA: 0x00749E61 File Offset: 0x00748061
		public static IShowTalkCameraMotion_UnionUnion FromIShowTalkCameraMotionPreset(IShowTalkCameraMotionPresetT _ishowtalkcameramotionpreset)
		{
			return new IShowTalkCameraMotion_UnionUnion
			{
				Type = IShowTalkCameraMotion_Union.IShowTalkCameraMotionPreset,
				Value = _ishowtalkcameramotionpreset
			};
		}

		// Token: 0x060366E1 RID: 222945 RVA: 0x00749E76 File Offset: 0x00748076
		public IShowTalkCameraMotionTweenT AsIShowTalkCameraMotionTween()
		{
			return this.As<IShowTalkCameraMotionTweenT>();
		}

		// Token: 0x060366E2 RID: 222946 RVA: 0x00749E7E File Offset: 0x0074807E
		public static IShowTalkCameraMotion_UnionUnion FromIShowTalkCameraMotionTween(IShowTalkCameraMotionTweenT _ishowtalkcameramotiontween)
		{
			return new IShowTalkCameraMotion_UnionUnion
			{
				Type = IShowTalkCameraMotion_Union.IShowTalkCameraMotionTween,
				Value = _ishowtalkcameramotiontween
			};
		}

		// Token: 0x060366E3 RID: 222947 RVA: 0x00749E94 File Offset: 0x00748094
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
