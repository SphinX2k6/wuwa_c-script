using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020068DD RID: 26845
	public class IHeadStyle_UnionUnion
	{
		// Token: 0x1700C727 RID: 50983
		// (get) Token: 0x0602ED16 RID: 191766 RVA: 0x00663519 File Offset: 0x00661719
		// (set) Token: 0x0602ED17 RID: 191767 RVA: 0x00663521 File Offset: 0x00661721
		public IHeadStyle_Union Type { get; set; }

		// Token: 0x1700C728 RID: 50984
		// (get) Token: 0x0602ED18 RID: 191768 RVA: 0x0066352A File Offset: 0x0066172A
		// (set) Token: 0x0602ED19 RID: 191769 RVA: 0x00663532 File Offset: 0x00661732
		public object Value { get; set; }

		// Token: 0x0602ED1A RID: 191770 RVA: 0x0066353B File Offset: 0x0066173B
		public IHeadStyle_UnionUnion()
		{
			this.Type = IHeadStyle_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0602ED1B RID: 191771 RVA: 0x00663551 File Offset: 0x00661751
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602ED1C RID: 191772 RVA: 0x00663563 File Offset: 0x00661763
		public IHeadStyleT AsIHeadStyle()
		{
			return this.As<IHeadStyleT>();
		}

		// Token: 0x0602ED1D RID: 191773 RVA: 0x0066356B File Offset: 0x0066176B
		public static IHeadStyle_UnionUnion FromIHeadStyle(IHeadStyleT _iheadstyle)
		{
			return new IHeadStyle_UnionUnion
			{
				Type = IHeadStyle_Union.IHeadStyle,
				Value = _iheadstyle
			};
		}

		// Token: 0x0602ED1E RID: 191774 RVA: 0x00663580 File Offset: 0x00661780
		public IHeadStyleNormalT AsIHeadStyleNormal()
		{
			return this.As<IHeadStyleNormalT>();
		}

		// Token: 0x0602ED1F RID: 191775 RVA: 0x00663588 File Offset: 0x00661788
		public static IHeadStyle_UnionUnion FromIHeadStyleNormal(IHeadStyleNormalT _iheadstylenormal)
		{
			return new IHeadStyle_UnionUnion
			{
				Type = IHeadStyle_Union.IHeadStyleNormal,
				Value = _iheadstylenormal
			};
		}

		// Token: 0x0602ED20 RID: 191776 RVA: 0x0066359D File Offset: 0x0066179D
		public IHeadStyleVoiceOnlyT AsIHeadStyleVoiceOnly()
		{
			return this.As<IHeadStyleVoiceOnlyT>();
		}

		// Token: 0x0602ED21 RID: 191777 RVA: 0x006635A5 File Offset: 0x006617A5
		public static IHeadStyle_UnionUnion FromIHeadStyleVoiceOnly(IHeadStyleVoiceOnlyT _iheadstylevoiceonly)
		{
			return new IHeadStyle_UnionUnion
			{
				Type = IHeadStyle_Union.IHeadStyleVoiceOnly,
				Value = _iheadstylevoiceonly
			};
		}

		// Token: 0x0602ED22 RID: 191778 RVA: 0x006635BA File Offset: 0x006617BA
		public IHeadStyleWeakSignalT AsIHeadStyleWeakSignal()
		{
			return this.As<IHeadStyleWeakSignalT>();
		}

		// Token: 0x0602ED23 RID: 191779 RVA: 0x006635C2 File Offset: 0x006617C2
		public static IHeadStyle_UnionUnion FromIHeadStyleWeakSignal(IHeadStyleWeakSignalT _iheadstyleweaksignal)
		{
			return new IHeadStyle_UnionUnion
			{
				Type = IHeadStyle_Union.IHeadStyleWeakSignal,
				Value = _iheadstyleweaksignal
			};
		}

		// Token: 0x0602ED24 RID: 191780 RVA: 0x006635D7 File Offset: 0x006617D7
		public IHeadStyleWarningT AsIHeadStyleWarning()
		{
			return this.As<IHeadStyleWarningT>();
		}

		// Token: 0x0602ED25 RID: 191781 RVA: 0x006635DF File Offset: 0x006617DF
		public static IHeadStyle_UnionUnion FromIHeadStyleWarning(IHeadStyleWarningT _iheadstylewarning)
		{
			return new IHeadStyle_UnionUnion
			{
				Type = IHeadStyle_Union.IHeadStyleWarning,
				Value = _iheadstylewarning
			};
		}

		// Token: 0x0602ED26 RID: 191782 RVA: 0x006635F4 File Offset: 0x006617F4
		public IHeadStyleMonsterDisplayT AsIHeadStyleMonsterDisplay()
		{
			return this.As<IHeadStyleMonsterDisplayT>();
		}

		// Token: 0x0602ED27 RID: 191783 RVA: 0x006635FC File Offset: 0x006617FC
		public static IHeadStyle_UnionUnion FromIHeadStyleMonsterDisplay(IHeadStyleMonsterDisplayT _iheadstylemonsterdisplay)
		{
			return new IHeadStyle_UnionUnion
			{
				Type = IHeadStyle_Union.IHeadStyleMonsterDisplay,
				Value = _iheadstylemonsterdisplay
			};
		}

		// Token: 0x0602ED28 RID: 191784 RVA: 0x00663614 File Offset: 0x00661814
		public static int Pack(FlatBufferBuilder builder, IHeadStyle_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IHeadStyle_Union.IHeadStyle:
				return IHeadStyle.Pack(builder, _o.AsIHeadStyle()).Value;
			case IHeadStyle_Union.IHeadStyleNormal:
				return IHeadStyleNormal.Pack(builder, _o.AsIHeadStyleNormal()).Value;
			case IHeadStyle_Union.IHeadStyleVoiceOnly:
				return IHeadStyleVoiceOnly.Pack(builder, _o.AsIHeadStyleVoiceOnly()).Value;
			case IHeadStyle_Union.IHeadStyleWeakSignal:
				return IHeadStyleWeakSignal.Pack(builder, _o.AsIHeadStyleWeakSignal()).Value;
			case IHeadStyle_Union.IHeadStyleWarning:
				return IHeadStyleWarning.Pack(builder, _o.AsIHeadStyleWarning()).Value;
			case IHeadStyle_Union.IHeadStyleMonsterDisplay:
				return IHeadStyleMonsterDisplay.Pack(builder, _o.AsIHeadStyleMonsterDisplay()).Value;
			default:
				return 0;
			}
		}
	}
}
