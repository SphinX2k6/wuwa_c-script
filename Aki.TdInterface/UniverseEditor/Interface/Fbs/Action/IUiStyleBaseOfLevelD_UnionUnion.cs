using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007CA5 RID: 31909
	public class IUiStyleBaseOfLevelD_UnionUnion
	{
		// Token: 0x1700EEDF RID: 61151
		// (get) Token: 0x060398E9 RID: 235753 RVA: 0x007C486D File Offset: 0x007C2A6D
		// (set) Token: 0x060398EA RID: 235754 RVA: 0x007C4875 File Offset: 0x007C2A75
		public IUiStyleBaseOfLevelD_Union Type { get; set; }

		// Token: 0x1700EEE0 RID: 61152
		// (get) Token: 0x060398EB RID: 235755 RVA: 0x007C487E File Offset: 0x007C2A7E
		// (set) Token: 0x060398EC RID: 235756 RVA: 0x007C4886 File Offset: 0x007C2A86
		public object Value { get; set; }

		// Token: 0x060398ED RID: 235757 RVA: 0x007C488F File Offset: 0x007C2A8F
		public IUiStyleBaseOfLevelD_UnionUnion()
		{
			this.Type = IUiStyleBaseOfLevelD_Union.NONE;
			this.Value = null;
		}

		// Token: 0x060398EE RID: 235758 RVA: 0x007C48A5 File Offset: 0x007C2AA5
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060398EF RID: 235759 RVA: 0x007C48B7 File Offset: 0x007C2AB7
		public IUiStyleBaseOfLevelDT AsIUiStyleBaseOfLevelD()
		{
			return this.As<IUiStyleBaseOfLevelDT>();
		}

		// Token: 0x060398F0 RID: 235760 RVA: 0x007C48BF File Offset: 0x007C2ABF
		public static IUiStyleBaseOfLevelD_UnionUnion FromIUiStyleBaseOfLevelD(IUiStyleBaseOfLevelDT _iuistylebaseofleveld)
		{
			return new IUiStyleBaseOfLevelD_UnionUnion
			{
				Type = IUiStyleBaseOfLevelD_Union.IUiStyleBaseOfLevelD,
				Value = _iuistylebaseofleveld
			};
		}

		// Token: 0x060398F1 RID: 235761 RVA: 0x007C48D4 File Offset: 0x007C2AD4
		public IUiStyleGiantSubtitleOfLevelDT AsIUiStyleGiantSubtitleOfLevelD()
		{
			return this.As<IUiStyleGiantSubtitleOfLevelDT>();
		}

		// Token: 0x060398F2 RID: 235762 RVA: 0x007C48DC File Offset: 0x007C2ADC
		public static IUiStyleBaseOfLevelD_UnionUnion FromIUiStyleGiantSubtitleOfLevelD(IUiStyleGiantSubtitleOfLevelDT _iuistylegiantsubtitleofleveld)
		{
			return new IUiStyleBaseOfLevelD_UnionUnion
			{
				Type = IUiStyleBaseOfLevelD_Union.IUiStyleGiantSubtitleOfLevelD,
				Value = _iuistylegiantsubtitleofleveld
			};
		}

		// Token: 0x060398F3 RID: 235763 RVA: 0x007C48F1 File Offset: 0x007C2AF1
		public IUiStylePlayPianoOfLevelDT AsIUiStylePlayPianoOfLevelD()
		{
			return this.As<IUiStylePlayPianoOfLevelDT>();
		}

		// Token: 0x060398F4 RID: 235764 RVA: 0x007C48F9 File Offset: 0x007C2AF9
		public static IUiStyleBaseOfLevelD_UnionUnion FromIUiStylePlayPianoOfLevelD(IUiStylePlayPianoOfLevelDT _iuistyleplaypianoofleveld)
		{
			return new IUiStyleBaseOfLevelD_UnionUnion
			{
				Type = IUiStyleBaseOfLevelD_Union.IUiStylePlayPianoOfLevelD,
				Value = _iuistyleplaypianoofleveld
			};
		}

		// Token: 0x060398F5 RID: 235765 RVA: 0x007C4910 File Offset: 0x007C2B10
		public static int Pack(FlatBufferBuilder builder, IUiStyleBaseOfLevelD_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IUiStyleBaseOfLevelD_Union.IUiStyleBaseOfLevelD:
				return IUiStyleBaseOfLevelD.Pack(builder, _o.AsIUiStyleBaseOfLevelD()).Value;
			case IUiStyleBaseOfLevelD_Union.IUiStyleGiantSubtitleOfLevelD:
				return IUiStyleGiantSubtitleOfLevelD.Pack(builder, _o.AsIUiStyleGiantSubtitleOfLevelD()).Value;
			case IUiStyleBaseOfLevelD_Union.IUiStylePlayPianoOfLevelD:
				return IUiStylePlayPianoOfLevelD.Pack(builder, _o.AsIUiStylePlayPianoOfLevelD()).Value;
			default:
				return 0;
			}
		}
	}
}
