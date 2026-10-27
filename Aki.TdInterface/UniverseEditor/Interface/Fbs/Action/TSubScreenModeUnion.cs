using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020077B1 RID: 30641
	public class TSubScreenModeUnion
	{
		// Token: 0x1700E6B9 RID: 59065
		// (get) Token: 0x0603799A RID: 227738 RVA: 0x00785686 File Offset: 0x00783886
		// (set) Token: 0x0603799B RID: 227739 RVA: 0x0078568E File Offset: 0x0078388E
		public TSubScreenMode Type { get; set; }

		// Token: 0x1700E6BA RID: 59066
		// (get) Token: 0x0603799C RID: 227740 RVA: 0x00785697 File Offset: 0x00783897
		// (set) Token: 0x0603799D RID: 227741 RVA: 0x0078569F File Offset: 0x0078389F
		public object Value { get; set; }

		// Token: 0x0603799E RID: 227742 RVA: 0x007856A8 File Offset: 0x007838A8
		public TSubScreenModeUnion()
		{
			this.Type = TSubScreenMode.NONE;
			this.Value = null;
		}

		// Token: 0x0603799F RID: 227743 RVA: 0x007856BE File Offset: 0x007838BE
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060379A0 RID: 227744 RVA: 0x007856D0 File Offset: 0x007838D0
		public ISubScreenModeAdjustT AsISubScreenModeAdjust()
		{
			return this.As<ISubScreenModeAdjustT>();
		}

		// Token: 0x060379A1 RID: 227745 RVA: 0x007856D8 File Offset: 0x007838D8
		public static TSubScreenModeUnion FromISubScreenModeAdjust(ISubScreenModeAdjustT _isubscreenmodeadjust)
		{
			return new TSubScreenModeUnion
			{
				Type = TSubScreenMode.ISubScreenModeAdjust,
				Value = _isubscreenmodeadjust
			};
		}

		// Token: 0x060379A2 RID: 227746 RVA: 0x007856ED File Offset: 0x007838ED
		public ISubScreenModeExitT AsISubScreenModeExit()
		{
			return this.As<ISubScreenModeExitT>();
		}

		// Token: 0x060379A3 RID: 227747 RVA: 0x007856F5 File Offset: 0x007838F5
		public static TSubScreenModeUnion FromISubScreenModeExit(ISubScreenModeExitT _isubscreenmodeexit)
		{
			return new TSubScreenModeUnion
			{
				Type = TSubScreenMode.ISubScreenModeExit,
				Value = _isubscreenmodeexit
			};
		}

		// Token: 0x060379A4 RID: 227748 RVA: 0x0078570A File Offset: 0x0078390A
		public ISubScreenModeInitT AsISubScreenModeInit()
		{
			return this.As<ISubScreenModeInitT>();
		}

		// Token: 0x060379A5 RID: 227749 RVA: 0x00785712 File Offset: 0x00783912
		public static TSubScreenModeUnion FromISubScreenModeInit(ISubScreenModeInitT _isubscreenmodeinit)
		{
			return new TSubScreenModeUnion
			{
				Type = TSubScreenMode.ISubScreenModeInit,
				Value = _isubscreenmodeinit
			};
		}

		// Token: 0x060379A6 RID: 227750 RVA: 0x00785728 File Offset: 0x00783928
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
