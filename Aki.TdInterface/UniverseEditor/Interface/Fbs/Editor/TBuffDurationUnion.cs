using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x02004D4D RID: 19789
	public class TBuffDurationUnion
	{
		// Token: 0x17008DBA RID: 36282
		// (get) Token: 0x0601EAED RID: 125677 RVA: 0x0044AF54 File Offset: 0x00449154
		// (set) Token: 0x0601EAEE RID: 125678 RVA: 0x0044AF5C File Offset: 0x0044915C
		public TBuffDuration Type { get; set; }

		// Token: 0x17008DBB RID: 36283
		// (get) Token: 0x0601EAEF RID: 125679 RVA: 0x0044AF65 File Offset: 0x00449165
		// (set) Token: 0x0601EAF0 RID: 125680 RVA: 0x0044AF6D File Offset: 0x0044916D
		public object Value { get; set; }

		// Token: 0x0601EAF1 RID: 125681 RVA: 0x0044AF76 File Offset: 0x00449176
		public TBuffDurationUnion()
		{
			this.Type = TBuffDuration.NONE;
			this.Value = null;
		}

		// Token: 0x0601EAF2 RID: 125682 RVA: 0x0044AF8C File Offset: 0x0044918C
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0601EAF3 RID: 125683 RVA: 0x0044AF9E File Offset: 0x0044919E
		public IBuffDurationInstantT AsIBuffDurationInstant()
		{
			return this.As<IBuffDurationInstantT>();
		}

		// Token: 0x0601EAF4 RID: 125684 RVA: 0x0044AFA6 File Offset: 0x004491A6
		public static TBuffDurationUnion FromIBuffDurationInstant(IBuffDurationInstantT _ibuffdurationinstant)
		{
			return new TBuffDurationUnion
			{
				Type = TBuffDuration.IBuffDurationInstant,
				Value = _ibuffdurationinstant
			};
		}

		// Token: 0x0601EAF5 RID: 125685 RVA: 0x0044AFBB File Offset: 0x004491BB
		public IBuffDurationPermanentT AsIBuffDurationPermanent()
		{
			return this.As<IBuffDurationPermanentT>();
		}

		// Token: 0x0601EAF6 RID: 125686 RVA: 0x0044AFC3 File Offset: 0x004491C3
		public static TBuffDurationUnion FromIBuffDurationPermanent(IBuffDurationPermanentT _ibuffdurationpermanent)
		{
			return new TBuffDurationUnion
			{
				Type = TBuffDuration.IBuffDurationPermanent,
				Value = _ibuffdurationpermanent
			};
		}

		// Token: 0x0601EAF7 RID: 125687 RVA: 0x0044AFD8 File Offset: 0x004491D8
		public IBuffHasDurationT AsIBuffHasDuration()
		{
			return this.As<IBuffHasDurationT>();
		}

		// Token: 0x0601EAF8 RID: 125688 RVA: 0x0044AFE0 File Offset: 0x004491E0
		public static TBuffDurationUnion FromIBuffHasDuration(IBuffHasDurationT _ibuffhasduration)
		{
			return new TBuffDurationUnion
			{
				Type = TBuffDuration.IBuffHasDuration,
				Value = _ibuffhasduration
			};
		}

		// Token: 0x0601EAF9 RID: 125689 RVA: 0x0044AFF8 File Offset: 0x004491F8
		public static int Pack(FlatBufferBuilder builder, TBuffDurationUnion _o)
		{
			switch (_o.Type)
			{
			case TBuffDuration.IBuffDurationInstant:
				return IBuffDurationInstant.Pack(builder, _o.AsIBuffDurationInstant()).Value;
			case TBuffDuration.IBuffDurationPermanent:
				return IBuffDurationPermanent.Pack(builder, _o.AsIBuffDurationPermanent()).Value;
			case TBuffDuration.IBuffHasDuration:
				return IBuffHasDuration.Pack(builder, _o.AsIBuffHasDuration()).Value;
			default:
				return 0;
			}
		}
	}
}
