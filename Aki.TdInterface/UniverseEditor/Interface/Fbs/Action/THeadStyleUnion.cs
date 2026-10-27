using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020076E7 RID: 30439
	public class THeadStyleUnion
	{
		// Token: 0x1700E633 RID: 58931
		// (get) Token: 0x0603756C RID: 226668 RVA: 0x0077F016 File Offset: 0x0077D216
		// (set) Token: 0x0603756D RID: 226669 RVA: 0x0077F01E File Offset: 0x0077D21E
		public THeadStyle Type { get; set; }

		// Token: 0x1700E634 RID: 58932
		// (get) Token: 0x0603756E RID: 226670 RVA: 0x0077F027 File Offset: 0x0077D227
		// (set) Token: 0x0603756F RID: 226671 RVA: 0x0077F02F File Offset: 0x0077D22F
		public object Value { get; set; }

		// Token: 0x06037570 RID: 226672 RVA: 0x0077F038 File Offset: 0x0077D238
		public THeadStyleUnion()
		{
			this.Type = THeadStyle.NONE;
			this.Value = null;
		}

		// Token: 0x06037571 RID: 226673 RVA: 0x0077F04E File Offset: 0x0077D24E
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06037572 RID: 226674 RVA: 0x0077F060 File Offset: 0x0077D260
		public IHeadStyleMonsterDisplayT AsIHeadStyleMonsterDisplay()
		{
			return this.As<IHeadStyleMonsterDisplayT>();
		}

		// Token: 0x06037573 RID: 226675 RVA: 0x0077F068 File Offset: 0x0077D268
		public static THeadStyleUnion FromIHeadStyleMonsterDisplay(IHeadStyleMonsterDisplayT _iheadstylemonsterdisplay)
		{
			return new THeadStyleUnion
			{
				Type = THeadStyle.IHeadStyleMonsterDisplay,
				Value = _iheadstylemonsterdisplay
			};
		}

		// Token: 0x06037574 RID: 226676 RVA: 0x0077F07D File Offset: 0x0077D27D
		public IHeadStyleNormalT AsIHeadStyleNormal()
		{
			return this.As<IHeadStyleNormalT>();
		}

		// Token: 0x06037575 RID: 226677 RVA: 0x0077F085 File Offset: 0x0077D285
		public static THeadStyleUnion FromIHeadStyleNormal(IHeadStyleNormalT _iheadstylenormal)
		{
			return new THeadStyleUnion
			{
				Type = THeadStyle.IHeadStyleNormal,
				Value = _iheadstylenormal
			};
		}

		// Token: 0x06037576 RID: 226678 RVA: 0x0077F09A File Offset: 0x0077D29A
		public IHeadStyleVoiceOnlyT AsIHeadStyleVoiceOnly()
		{
			return this.As<IHeadStyleVoiceOnlyT>();
		}

		// Token: 0x06037577 RID: 226679 RVA: 0x0077F0A2 File Offset: 0x0077D2A2
		public static THeadStyleUnion FromIHeadStyleVoiceOnly(IHeadStyleVoiceOnlyT _iheadstylevoiceonly)
		{
			return new THeadStyleUnion
			{
				Type = THeadStyle.IHeadStyleVoiceOnly,
				Value = _iheadstylevoiceonly
			};
		}

		// Token: 0x06037578 RID: 226680 RVA: 0x0077F0B7 File Offset: 0x0077D2B7
		public IHeadStyleWarningT AsIHeadStyleWarning()
		{
			return this.As<IHeadStyleWarningT>();
		}

		// Token: 0x06037579 RID: 226681 RVA: 0x0077F0BF File Offset: 0x0077D2BF
		public static THeadStyleUnion FromIHeadStyleWarning(IHeadStyleWarningT _iheadstylewarning)
		{
			return new THeadStyleUnion
			{
				Type = THeadStyle.IHeadStyleWarning,
				Value = _iheadstylewarning
			};
		}

		// Token: 0x0603757A RID: 226682 RVA: 0x0077F0D4 File Offset: 0x0077D2D4
		public IHeadStyleWeakSignalT AsIHeadStyleWeakSignal()
		{
			return this.As<IHeadStyleWeakSignalT>();
		}

		// Token: 0x0603757B RID: 226683 RVA: 0x0077F0DC File Offset: 0x0077D2DC
		public static THeadStyleUnion FromIHeadStyleWeakSignal(IHeadStyleWeakSignalT _iheadstyleweaksignal)
		{
			return new THeadStyleUnion
			{
				Type = THeadStyle.IHeadStyleWeakSignal,
				Value = _iheadstyleweaksignal
			};
		}

		// Token: 0x0603757C RID: 226684 RVA: 0x0077F0F4 File Offset: 0x0077D2F4
		public static int Pack(FlatBufferBuilder builder, THeadStyleUnion _o)
		{
			switch (_o.Type)
			{
			case THeadStyle.IHeadStyleMonsterDisplay:
				return IHeadStyleMonsterDisplay.Pack(builder, _o.AsIHeadStyleMonsterDisplay()).Value;
			case THeadStyle.IHeadStyleNormal:
				return IHeadStyleNormal.Pack(builder, _o.AsIHeadStyleNormal()).Value;
			case THeadStyle.IHeadStyleVoiceOnly:
				return IHeadStyleVoiceOnly.Pack(builder, _o.AsIHeadStyleVoiceOnly()).Value;
			case THeadStyle.IHeadStyleWarning:
				return IHeadStyleWarning.Pack(builder, _o.AsIHeadStyleWarning()).Value;
			case THeadStyle.IHeadStyleWeakSignal:
				return IHeadStyleWeakSignal.Pack(builder, _o.AsIHeadStyleWeakSignal()).Value;
			default:
				return 0;
			}
		}
	}
}
