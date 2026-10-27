using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005C3A RID: 23610
	public class THookLockScreenDetectTypeUnion
	{
		// Token: 0x1700B204 RID: 45572
		// (get) Token: 0x060287C9 RID: 165833 RVA: 0x00591FEF File Offset: 0x005901EF
		// (set) Token: 0x060287CA RID: 165834 RVA: 0x00591FF7 File Offset: 0x005901F7
		public THookLockScreenDetectType Type { get; set; }

		// Token: 0x1700B205 RID: 45573
		// (get) Token: 0x060287CB RID: 165835 RVA: 0x00592000 File Offset: 0x00590200
		// (set) Token: 0x060287CC RID: 165836 RVA: 0x00592008 File Offset: 0x00590208
		public object Value { get; set; }

		// Token: 0x060287CD RID: 165837 RVA: 0x00592011 File Offset: 0x00590211
		public THookLockScreenDetectTypeUnion()
		{
			this.Type = THookLockScreenDetectType.NONE;
			this.Value = null;
		}

		// Token: 0x060287CE RID: 165838 RVA: 0x00592027 File Offset: 0x00590227
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060287CF RID: 165839 RVA: 0x00592039 File Offset: 0x00590239
		public IHookLockScreenDetectTypeCentralEllipseT AsIHookLockScreenDetectTypeCentralEllipse()
		{
			return this.As<IHookLockScreenDetectTypeCentralEllipseT>();
		}

		// Token: 0x060287D0 RID: 165840 RVA: 0x00592041 File Offset: 0x00590241
		public static THookLockScreenDetectTypeUnion FromIHookLockScreenDetectTypeCentralEllipse(IHookLockScreenDetectTypeCentralEllipseT _ihooklockscreendetecttypecentralellipse)
		{
			return new THookLockScreenDetectTypeUnion
			{
				Type = THookLockScreenDetectType.IHookLockScreenDetectTypeCentralEllipse,
				Value = _ihooklockscreendetecttypecentralellipse
			};
		}

		// Token: 0x060287D1 RID: 165841 RVA: 0x00592056 File Offset: 0x00590256
		public IHookLockScreenDetectTypeFullScreenT AsIHookLockScreenDetectTypeFullScreen()
		{
			return this.As<IHookLockScreenDetectTypeFullScreenT>();
		}

		// Token: 0x060287D2 RID: 165842 RVA: 0x0059205E File Offset: 0x0059025E
		public static THookLockScreenDetectTypeUnion FromIHookLockScreenDetectTypeFullScreen(IHookLockScreenDetectTypeFullScreenT _ihooklockscreendetecttypefullscreen)
		{
			return new THookLockScreenDetectTypeUnion
			{
				Type = THookLockScreenDetectType.IHookLockScreenDetectTypeFullScreen,
				Value = _ihooklockscreendetecttypefullscreen
			};
		}

		// Token: 0x060287D3 RID: 165843 RVA: 0x00592074 File Offset: 0x00590274
		public static int Pack(FlatBufferBuilder builder, THookLockScreenDetectTypeUnion _o)
		{
			THookLockScreenDetectType type = _o.Type;
			if (type == THookLockScreenDetectType.IHookLockScreenDetectTypeCentralEllipse)
			{
				return IHookLockScreenDetectTypeCentralEllipse.Pack(builder, _o.AsIHookLockScreenDetectTypeCentralEllipse()).Value;
			}
			if (type != THookLockScreenDetectType.IHookLockScreenDetectTypeFullScreen)
			{
				return 0;
			}
			return IHookLockScreenDetectTypeFullScreen.Pack(builder, _o.AsIHookLockScreenDetectTypeFullScreen()).Value;
		}
	}
}
