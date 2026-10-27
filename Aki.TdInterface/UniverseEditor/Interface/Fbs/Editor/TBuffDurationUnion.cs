using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x020048E8 RID: 18664
	public class TBuffDurationUnion
	{
		// Token: 0x17008772 RID: 34674
		// (get) Token: 0x0601D300 RID: 119552 RVA: 0x0041E7B8 File Offset: 0x0041C9B8
		// (set) Token: 0x0601D301 RID: 119553 RVA: 0x0041E7C0 File Offset: 0x0041C9C0
		public TBuffDuration Type { get; set; }

		// Token: 0x17008773 RID: 34675
		// (get) Token: 0x0601D302 RID: 119554 RVA: 0x0041E7C9 File Offset: 0x0041C9C9
		// (set) Token: 0x0601D303 RID: 119555 RVA: 0x0041E7D1 File Offset: 0x0041C9D1
		public object Value { get; set; }

		// Token: 0x0601D304 RID: 119556 RVA: 0x0041E7DA File Offset: 0x0041C9DA
		public TBuffDurationUnion()
		{
			this.Type = TBuffDuration.NONE;
			this.Value = null;
		}

		// Token: 0x0601D305 RID: 119557 RVA: 0x0041E7F0 File Offset: 0x0041C9F0
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0601D306 RID: 119558 RVA: 0x0041E802 File Offset: 0x0041CA02
		public IBuffDurationInstantT AsIBuffDurationInstant()
		{
			return this.As<IBuffDurationInstantT>();
		}

		// Token: 0x0601D307 RID: 119559 RVA: 0x0041E80A File Offset: 0x0041CA0A
		public static TBuffDurationUnion FromIBuffDurationInstant(IBuffDurationInstantT _ibuffdurationinstant)
		{
			return new TBuffDurationUnion
			{
				Type = TBuffDuration.IBuffDurationInstant,
				Value = _ibuffdurationinstant
			};
		}

		// Token: 0x0601D308 RID: 119560 RVA: 0x0041E81F File Offset: 0x0041CA1F
		public IBuffDurationPermanentT AsIBuffDurationPermanent()
		{
			return this.As<IBuffDurationPermanentT>();
		}

		// Token: 0x0601D309 RID: 119561 RVA: 0x0041E827 File Offset: 0x0041CA27
		public static TBuffDurationUnion FromIBuffDurationPermanent(IBuffDurationPermanentT _ibuffdurationpermanent)
		{
			return new TBuffDurationUnion
			{
				Type = TBuffDuration.IBuffDurationPermanent,
				Value = _ibuffdurationpermanent
			};
		}

		// Token: 0x0601D30A RID: 119562 RVA: 0x0041E83C File Offset: 0x0041CA3C
		public IBuffHasDurationT AsIBuffHasDuration()
		{
			return this.As<IBuffHasDurationT>();
		}

		// Token: 0x0601D30B RID: 119563 RVA: 0x0041E844 File Offset: 0x0041CA44
		public static TBuffDurationUnion FromIBuffHasDuration(IBuffHasDurationT _ibuffhasduration)
		{
			return new TBuffDurationUnion
			{
				Type = TBuffDuration.IBuffHasDuration,
				Value = _ibuffhasduration
			};
		}

		// Token: 0x0601D30C RID: 119564 RVA: 0x0041E85C File Offset: 0x0041CA5C
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
