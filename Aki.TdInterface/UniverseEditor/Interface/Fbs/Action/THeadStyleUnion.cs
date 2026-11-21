using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007EFB RID: 32507
	public class THeadStyleUnion
	{
		// Token: 0x1700F275 RID: 62069
		// (get) Token: 0x0603AA39 RID: 240185 RVA: 0x007E3522 File Offset: 0x007E1722
		// (set) Token: 0x0603AA3A RID: 240186 RVA: 0x007E352A File Offset: 0x007E172A
		public THeadStyle Type { get; set; }

		// Token: 0x1700F276 RID: 62070
		// (get) Token: 0x0603AA3B RID: 240187 RVA: 0x007E3533 File Offset: 0x007E1733
		// (set) Token: 0x0603AA3C RID: 240188 RVA: 0x007E353B File Offset: 0x007E173B
		public object Value { get; set; }

		// Token: 0x0603AA3D RID: 240189 RVA: 0x007E3544 File Offset: 0x007E1744
		public THeadStyleUnion()
		{
			this.Type = THeadStyle.NONE;
			this.Value = null;
		}

		// Token: 0x0603AA3E RID: 240190 RVA: 0x007E355A File Offset: 0x007E175A
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0603AA3F RID: 240191 RVA: 0x007E356C File Offset: 0x007E176C
		public IHeadStyleMonsterDisplayT AsIHeadStyleMonsterDisplay()
		{
			return this.As<IHeadStyleMonsterDisplayT>();
		}

		// Token: 0x0603AA40 RID: 240192 RVA: 0x007E3574 File Offset: 0x007E1774
		public static THeadStyleUnion FromIHeadStyleMonsterDisplay(IHeadStyleMonsterDisplayT _iheadstylemonsterdisplay)
		{
			return new THeadStyleUnion
			{
				Type = THeadStyle.IHeadStyleMonsterDisplay,
				Value = _iheadstylemonsterdisplay
			};
		}

		// Token: 0x0603AA41 RID: 240193 RVA: 0x007E3589 File Offset: 0x007E1789
		public IHeadStyleNormalT AsIHeadStyleNormal()
		{
			return this.As<IHeadStyleNormalT>();
		}

		// Token: 0x0603AA42 RID: 240194 RVA: 0x007E3591 File Offset: 0x007E1791
		public static THeadStyleUnion FromIHeadStyleNormal(IHeadStyleNormalT _iheadstylenormal)
		{
			return new THeadStyleUnion
			{
				Type = THeadStyle.IHeadStyleNormal,
				Value = _iheadstylenormal
			};
		}

		// Token: 0x0603AA43 RID: 240195 RVA: 0x007E35A6 File Offset: 0x007E17A6
		public IHeadStyleVoiceOnlyT AsIHeadStyleVoiceOnly()
		{
			return this.As<IHeadStyleVoiceOnlyT>();
		}

		// Token: 0x0603AA44 RID: 240196 RVA: 0x007E35AE File Offset: 0x007E17AE
		public static THeadStyleUnion FromIHeadStyleVoiceOnly(IHeadStyleVoiceOnlyT _iheadstylevoiceonly)
		{
			return new THeadStyleUnion
			{
				Type = THeadStyle.IHeadStyleVoiceOnly,
				Value = _iheadstylevoiceonly
			};
		}

		// Token: 0x0603AA45 RID: 240197 RVA: 0x007E35C3 File Offset: 0x007E17C3
		public IHeadStyleWarningT AsIHeadStyleWarning()
		{
			return this.As<IHeadStyleWarningT>();
		}

		// Token: 0x0603AA46 RID: 240198 RVA: 0x007E35CB File Offset: 0x007E17CB
		public static THeadStyleUnion FromIHeadStyleWarning(IHeadStyleWarningT _iheadstylewarning)
		{
			return new THeadStyleUnion
			{
				Type = THeadStyle.IHeadStyleWarning,
				Value = _iheadstylewarning
			};
		}

		// Token: 0x0603AA47 RID: 240199 RVA: 0x007E35E0 File Offset: 0x007E17E0
		public IHeadStyleWeakSignalT AsIHeadStyleWeakSignal()
		{
			return this.As<IHeadStyleWeakSignalT>();
		}

		// Token: 0x0603AA48 RID: 240200 RVA: 0x007E35E8 File Offset: 0x007E17E8
		public static THeadStyleUnion FromIHeadStyleWeakSignal(IHeadStyleWeakSignalT _iheadstyleweaksignal)
		{
			return new THeadStyleUnion
			{
				Type = THeadStyle.IHeadStyleWeakSignal,
				Value = _iheadstyleweaksignal
			};
		}

		// Token: 0x0603AA49 RID: 240201 RVA: 0x007E3600 File Offset: 0x007E1800
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
