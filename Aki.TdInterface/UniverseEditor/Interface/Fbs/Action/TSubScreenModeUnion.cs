using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007FE9 RID: 32745
	public class TSubScreenModeUnion
	{
		// Token: 0x1700F313 RID: 62227
		// (get) Token: 0x0603AF1B RID: 241435 RVA: 0x007EAC56 File Offset: 0x007E8E56
		// (set) Token: 0x0603AF1C RID: 241436 RVA: 0x007EAC5E File Offset: 0x007E8E5E
		public TSubScreenMode Type { get; set; }

		// Token: 0x1700F314 RID: 62228
		// (get) Token: 0x0603AF1D RID: 241437 RVA: 0x007EAC67 File Offset: 0x007E8E67
		// (set) Token: 0x0603AF1E RID: 241438 RVA: 0x007EAC6F File Offset: 0x007E8E6F
		public object Value { get; set; }

		// Token: 0x0603AF1F RID: 241439 RVA: 0x007EAC78 File Offset: 0x007E8E78
		public TSubScreenModeUnion()
		{
			this.Type = TSubScreenMode.NONE;
			this.Value = null;
		}

		// Token: 0x0603AF20 RID: 241440 RVA: 0x007EAC8E File Offset: 0x007E8E8E
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0603AF21 RID: 241441 RVA: 0x007EACA0 File Offset: 0x007E8EA0
		public ISubScreenModeAdjustT AsISubScreenModeAdjust()
		{
			return this.As<ISubScreenModeAdjustT>();
		}

		// Token: 0x0603AF22 RID: 241442 RVA: 0x007EACA8 File Offset: 0x007E8EA8
		public static TSubScreenModeUnion FromISubScreenModeAdjust(ISubScreenModeAdjustT _isubscreenmodeadjust)
		{
			return new TSubScreenModeUnion
			{
				Type = TSubScreenMode.ISubScreenModeAdjust,
				Value = _isubscreenmodeadjust
			};
		}

		// Token: 0x0603AF23 RID: 241443 RVA: 0x007EACBD File Offset: 0x007E8EBD
		public ISubScreenModeExitT AsISubScreenModeExit()
		{
			return this.As<ISubScreenModeExitT>();
		}

		// Token: 0x0603AF24 RID: 241444 RVA: 0x007EACC5 File Offset: 0x007E8EC5
		public static TSubScreenModeUnion FromISubScreenModeExit(ISubScreenModeExitT _isubscreenmodeexit)
		{
			return new TSubScreenModeUnion
			{
				Type = TSubScreenMode.ISubScreenModeExit,
				Value = _isubscreenmodeexit
			};
		}

		// Token: 0x0603AF25 RID: 241445 RVA: 0x007EACDA File Offset: 0x007E8EDA
		public ISubScreenModeInitT AsISubScreenModeInit()
		{
			return this.As<ISubScreenModeInitT>();
		}

		// Token: 0x0603AF26 RID: 241446 RVA: 0x007EACE2 File Offset: 0x007E8EE2
		public static TSubScreenModeUnion FromISubScreenModeInit(ISubScreenModeInitT _isubscreenmodeinit)
		{
			return new TSubScreenModeUnion
			{
				Type = TSubScreenMode.ISubScreenModeInit,
				Value = _isubscreenmodeinit
			};
		}

		// Token: 0x0603AF27 RID: 241447 RVA: 0x007EACF8 File Offset: 0x007E8EF8
		public static int Pack(FlatBufferBuilder builder, TSubScreenModeUnion _o)
		{
			switch (_o.Type)
			{
			case TSubScreenMode.ISubScreenModeAdjust:
				return ISubScreenModeAdjust.Pack(builder, _o.AsISubScreenModeAdjust()).Value;
			case TSubScreenMode.ISubScreenModeExit:
				return ISubScreenModeExit.Pack(builder, _o.AsISubScreenModeExit()).Value;
			case TSubScreenMode.ISubScreenModeInit:
				return ISubScreenModeInit.Pack(builder, _o.AsISubScreenModeInit()).Value;
			default:
				return 0;
			}
		}
	}
}
