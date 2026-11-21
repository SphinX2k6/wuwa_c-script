using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006F8D RID: 28557
	public class IHeadStyle_UnionUnion
	{
		// Token: 0x1700D121 RID: 53537
		// (get) Token: 0x060316C8 RID: 202440 RVA: 0x006B3661 File Offset: 0x006B1861
		// (set) Token: 0x060316C9 RID: 202441 RVA: 0x006B3669 File Offset: 0x006B1869
		public IHeadStyle_Union Type { get; set; }

		// Token: 0x1700D122 RID: 53538
		// (get) Token: 0x060316CA RID: 202442 RVA: 0x006B3672 File Offset: 0x006B1872
		// (set) Token: 0x060316CB RID: 202443 RVA: 0x006B367A File Offset: 0x006B187A
		public object Value { get; set; }

		// Token: 0x060316CC RID: 202444 RVA: 0x006B3683 File Offset: 0x006B1883
		public IHeadStyle_UnionUnion()
		{
			this.Type = IHeadStyle_Union.NONE;
			this.Value = null;
		}

		// Token: 0x060316CD RID: 202445 RVA: 0x006B3699 File Offset: 0x006B1899
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060316CE RID: 202446 RVA: 0x006B36AB File Offset: 0x006B18AB
		public IHeadStyleT AsIHeadStyle()
		{
			return this.As<IHeadStyleT>();
		}

		// Token: 0x060316CF RID: 202447 RVA: 0x006B36B3 File Offset: 0x006B18B3
		public static IHeadStyle_UnionUnion FromIHeadStyle(IHeadStyleT _iheadstyle)
		{
			return new IHeadStyle_UnionUnion
			{
				Type = IHeadStyle_Union.IHeadStyle,
				Value = _iheadstyle
			};
		}

		// Token: 0x060316D0 RID: 202448 RVA: 0x006B36C8 File Offset: 0x006B18C8
		public IHeadStyleNormalT AsIHeadStyleNormal()
		{
			return this.As<IHeadStyleNormalT>();
		}

		// Token: 0x060316D1 RID: 202449 RVA: 0x006B36D0 File Offset: 0x006B18D0
		public static IHeadStyle_UnionUnion FromIHeadStyleNormal(IHeadStyleNormalT _iheadstylenormal)
		{
			return new IHeadStyle_UnionUnion
			{
				Type = IHeadStyle_Union.IHeadStyleNormal,
				Value = _iheadstylenormal
			};
		}

		// Token: 0x060316D2 RID: 202450 RVA: 0x006B36E5 File Offset: 0x006B18E5
		public IHeadStyleVoiceOnlyT AsIHeadStyleVoiceOnly()
		{
			return this.As<IHeadStyleVoiceOnlyT>();
		}

		// Token: 0x060316D3 RID: 202451 RVA: 0x006B36ED File Offset: 0x006B18ED
		public static IHeadStyle_UnionUnion FromIHeadStyleVoiceOnly(IHeadStyleVoiceOnlyT _iheadstylevoiceonly)
		{
			return new IHeadStyle_UnionUnion
			{
				Type = IHeadStyle_Union.IHeadStyleVoiceOnly,
				Value = _iheadstylevoiceonly
			};
		}

		// Token: 0x060316D4 RID: 202452 RVA: 0x006B3702 File Offset: 0x006B1902
		public IHeadStyleWeakSignalT AsIHeadStyleWeakSignal()
		{
			return this.As<IHeadStyleWeakSignalT>();
		}

		// Token: 0x060316D5 RID: 202453 RVA: 0x006B370A File Offset: 0x006B190A
		public static IHeadStyle_UnionUnion FromIHeadStyleWeakSignal(IHeadStyleWeakSignalT _iheadstyleweaksignal)
		{
			return new IHeadStyle_UnionUnion
			{
				Type = IHeadStyle_Union.IHeadStyleWeakSignal,
				Value = _iheadstyleweaksignal
			};
		}

		// Token: 0x060316D6 RID: 202454 RVA: 0x006B371F File Offset: 0x006B191F
		public IHeadStyleWarningT AsIHeadStyleWarning()
		{
			return this.As<IHeadStyleWarningT>();
		}

		// Token: 0x060316D7 RID: 202455 RVA: 0x006B3727 File Offset: 0x006B1927
		public static IHeadStyle_UnionUnion FromIHeadStyleWarning(IHeadStyleWarningT _iheadstylewarning)
		{
			return new IHeadStyle_UnionUnion
			{
				Type = IHeadStyle_Union.IHeadStyleWarning,
				Value = _iheadstylewarning
			};
		}

		// Token: 0x060316D8 RID: 202456 RVA: 0x006B373C File Offset: 0x006B193C
		public IHeadStyleMonsterDisplayT AsIHeadStyleMonsterDisplay()
		{
			return this.As<IHeadStyleMonsterDisplayT>();
		}

		// Token: 0x060316D9 RID: 202457 RVA: 0x006B3744 File Offset: 0x006B1944
		public static IHeadStyle_UnionUnion FromIHeadStyleMonsterDisplay(IHeadStyleMonsterDisplayT _iheadstylemonsterdisplay)
		{
			return new IHeadStyle_UnionUnion
			{
				Type = IHeadStyle_Union.IHeadStyleMonsterDisplay,
				Value = _iheadstylemonsterdisplay
			};
		}

		// Token: 0x060316DA RID: 202458 RVA: 0x006B375C File Offset: 0x006B195C
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
