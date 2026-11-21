using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x02004C95 RID: 19605
	public class IBuffDurationBase_UnionUnion
	{
		// Token: 0x17008AE8 RID: 35560
		// (get) Token: 0x0601E0F0 RID: 123120 RVA: 0x0043687D File Offset: 0x00434A7D
		// (set) Token: 0x0601E0F1 RID: 123121 RVA: 0x00436885 File Offset: 0x00434A85
		public IBuffDurationBase_Union Type { get; set; }

		// Token: 0x17008AE9 RID: 35561
		// (get) Token: 0x0601E0F2 RID: 123122 RVA: 0x0043688E File Offset: 0x00434A8E
		// (set) Token: 0x0601E0F3 RID: 123123 RVA: 0x00436896 File Offset: 0x00434A96
		public object Value { get; set; }

		// Token: 0x0601E0F4 RID: 123124 RVA: 0x0043689F File Offset: 0x00434A9F
		public IBuffDurationBase_UnionUnion()
		{
			this.Type = IBuffDurationBase_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0601E0F5 RID: 123125 RVA: 0x004368B5 File Offset: 0x00434AB5
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0601E0F6 RID: 123126 RVA: 0x004368C7 File Offset: 0x00434AC7
		public IBuffDurationBaseT AsIBuffDurationBase()
		{
			return this.As<IBuffDurationBaseT>();
		}

		// Token: 0x0601E0F7 RID: 123127 RVA: 0x004368CF File Offset: 0x00434ACF
		public static IBuffDurationBase_UnionUnion FromIBuffDurationBase(IBuffDurationBaseT _ibuffdurationbase)
		{
			return new IBuffDurationBase_UnionUnion
			{
				Type = IBuffDurationBase_Union.IBuffDurationBase,
				Value = _ibuffdurationbase
			};
		}

		// Token: 0x0601E0F8 RID: 123128 RVA: 0x004368E4 File Offset: 0x00434AE4
		public IBuffDurationInstantT AsIBuffDurationInstant()
		{
			return this.As<IBuffDurationInstantT>();
		}

		// Token: 0x0601E0F9 RID: 123129 RVA: 0x004368EC File Offset: 0x00434AEC
		public static IBuffDurationBase_UnionUnion FromIBuffDurationInstant(IBuffDurationInstantT _ibuffdurationinstant)
		{
			return new IBuffDurationBase_UnionUnion
			{
				Type = IBuffDurationBase_Union.IBuffDurationInstant,
				Value = _ibuffdurationinstant
			};
		}

		// Token: 0x0601E0FA RID: 123130 RVA: 0x00436901 File Offset: 0x00434B01
		public IBuffDurationPermanentT AsIBuffDurationPermanent()
		{
			return this.As<IBuffDurationPermanentT>();
		}

		// Token: 0x0601E0FB RID: 123131 RVA: 0x00436909 File Offset: 0x00434B09
		public static IBuffDurationBase_UnionUnion FromIBuffDurationPermanent(IBuffDurationPermanentT _ibuffdurationpermanent)
		{
			return new IBuffDurationBase_UnionUnion
			{
				Type = IBuffDurationBase_Union.IBuffDurationPermanent,
				Value = _ibuffdurationpermanent
			};
		}

		// Token: 0x0601E0FC RID: 123132 RVA: 0x0043691E File Offset: 0x00434B1E
		public IBuffHasDurationT AsIBuffHasDuration()
		{
			return this.As<IBuffHasDurationT>();
		}

		// Token: 0x0601E0FD RID: 123133 RVA: 0x00436926 File Offset: 0x00434B26
		public static IBuffDurationBase_UnionUnion FromIBuffHasDuration(IBuffHasDurationT _ibuffhasduration)
		{
			return new IBuffDurationBase_UnionUnion
			{
				Type = IBuffDurationBase_Union.IBuffHasDuration,
				Value = _ibuffhasduration
			};
		}

		// Token: 0x0601E0FE RID: 123134 RVA: 0x0043693C File Offset: 0x00434B3C
		public static int Pack(FlatBufferBuilder builder, IBuffDurationBase_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IBuffDurationBase_Union.IBuffDurationBase:
				return IBuffDurationBase.Pack(builder, _o.AsIBuffDurationBase()).Value;
			case IBuffDurationBase_Union.IBuffDurationInstant:
				return IBuffDurationInstant.Pack(builder, _o.AsIBuffDurationInstant()).Value;
			case IBuffDurationBase_Union.IBuffDurationPermanent:
				return IBuffDurationPermanent.Pack(builder, _o.AsIBuffDurationPermanent()).Value;
			case IBuffDurationBase_Union.IBuffHasDuration:
				return IBuffHasDuration.Pack(builder, _o.AsIBuffHasDuration()).Value;
			default:
				return 0;
			}
		}
	}
}
