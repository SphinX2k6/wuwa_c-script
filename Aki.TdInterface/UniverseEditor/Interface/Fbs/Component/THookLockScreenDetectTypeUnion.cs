using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200625F RID: 25183
	public class THookLockScreenDetectTypeUnion
	{
		// Token: 0x1700BB56 RID: 47958
		// (get) Token: 0x0602ADD7 RID: 175575 RVA: 0x005DA207 File Offset: 0x005D8407
		// (set) Token: 0x0602ADD8 RID: 175576 RVA: 0x005DA20F File Offset: 0x005D840F
		public THookLockScreenDetectType Type { get; set; }

		// Token: 0x1700BB57 RID: 47959
		// (get) Token: 0x0602ADD9 RID: 175577 RVA: 0x005DA218 File Offset: 0x005D8418
		// (set) Token: 0x0602ADDA RID: 175578 RVA: 0x005DA220 File Offset: 0x005D8420
		public object Value { get; set; }

		// Token: 0x0602ADDB RID: 175579 RVA: 0x005DA229 File Offset: 0x005D8429
		public THookLockScreenDetectTypeUnion()
		{
			this.Type = THookLockScreenDetectType.NONE;
			this.Value = null;
		}

		// Token: 0x0602ADDC RID: 175580 RVA: 0x005DA23F File Offset: 0x005D843F
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602ADDD RID: 175581 RVA: 0x005DA251 File Offset: 0x005D8451
		public IHookLockScreenDetectTypeCentralEllipseT AsIHookLockScreenDetectTypeCentralEllipse()
		{
			return this.As<IHookLockScreenDetectTypeCentralEllipseT>();
		}

		// Token: 0x0602ADDE RID: 175582 RVA: 0x005DA259 File Offset: 0x005D8459
		public static THookLockScreenDetectTypeUnion FromIHookLockScreenDetectTypeCentralEllipse(IHookLockScreenDetectTypeCentralEllipseT _ihooklockscreendetecttypecentralellipse)
		{
			return new THookLockScreenDetectTypeUnion
			{
				Type = THookLockScreenDetectType.IHookLockScreenDetectTypeCentralEllipse,
				Value = _ihooklockscreendetecttypecentralellipse
			};
		}

		// Token: 0x0602ADDF RID: 175583 RVA: 0x005DA26E File Offset: 0x005D846E
		public IHookLockScreenDetectTypeFullScreenT AsIHookLockScreenDetectTypeFullScreen()
		{
			return this.As<IHookLockScreenDetectTypeFullScreenT>();
		}

		// Token: 0x0602ADE0 RID: 175584 RVA: 0x005DA276 File Offset: 0x005D8476
		public static THookLockScreenDetectTypeUnion FromIHookLockScreenDetectTypeFullScreen(IHookLockScreenDetectTypeFullScreenT _ihooklockscreendetecttypefullscreen)
		{
			return new THookLockScreenDetectTypeUnion
			{
				Type = THookLockScreenDetectType.IHookLockScreenDetectTypeFullScreen,
				Value = _ihooklockscreendetecttypefullscreen
			};
		}

		// Token: 0x0602ADE1 RID: 175585 RVA: 0x005DA28C File Offset: 0x005D848C
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
