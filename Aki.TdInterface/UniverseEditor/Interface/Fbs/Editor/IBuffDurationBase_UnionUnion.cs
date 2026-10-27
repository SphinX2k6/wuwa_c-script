using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x0200482D RID: 18477
	public class IBuffDurationBase_UnionUnion
	{
		// Token: 0x1700849D RID: 33949
		// (get) Token: 0x0601C8F3 RID: 116979 RVA: 0x00409F2D File Offset: 0x0040812D
		// (set) Token: 0x0601C8F4 RID: 116980 RVA: 0x00409F35 File Offset: 0x00408135
		public IBuffDurationBase_Union Type { get; set; }

		// Token: 0x1700849E RID: 33950
		// (get) Token: 0x0601C8F5 RID: 116981 RVA: 0x00409F3E File Offset: 0x0040813E
		// (set) Token: 0x0601C8F6 RID: 116982 RVA: 0x00409F46 File Offset: 0x00408146
		public object Value { get; set; }

		// Token: 0x0601C8F7 RID: 116983 RVA: 0x00409F4F File Offset: 0x0040814F
		public IBuffDurationBase_UnionUnion()
		{
			this.Type = IBuffDurationBase_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0601C8F8 RID: 116984 RVA: 0x00409F65 File Offset: 0x00408165
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0601C8F9 RID: 116985 RVA: 0x00409F77 File Offset: 0x00408177
		public IBuffDurationBaseT AsIBuffDurationBase()
		{
			return this.As<IBuffDurationBaseT>();
		}

		// Token: 0x0601C8FA RID: 116986 RVA: 0x00409F7F File Offset: 0x0040817F
		public static IBuffDurationBase_UnionUnion FromIBuffDurationBase(IBuffDurationBaseT _ibuffdurationbase)
		{
			return new IBuffDurationBase_UnionUnion
			{
				Type = IBuffDurationBase_Union.IBuffDurationBase,
				Value = _ibuffdurationbase
			};
		}

		// Token: 0x0601C8FB RID: 116987 RVA: 0x00409F94 File Offset: 0x00408194
		public IBuffDurationInstantT AsIBuffDurationInstant()
		{
			return this.As<IBuffDurationInstantT>();
		}

		// Token: 0x0601C8FC RID: 116988 RVA: 0x00409F9C File Offset: 0x0040819C
		public static IBuffDurationBase_UnionUnion FromIBuffDurationInstant(IBuffDurationInstantT _ibuffdurationinstant)
		{
			return new IBuffDurationBase_UnionUnion
			{
				Type = IBuffDurationBase_Union.IBuffDurationInstant,
				Value = _ibuffdurationinstant
			};
		}

		// Token: 0x0601C8FD RID: 116989 RVA: 0x00409FB1 File Offset: 0x004081B1
		public IBuffDurationPermanentT AsIBuffDurationPermanent()
		{
			return this.As<IBuffDurationPermanentT>();
		}

		// Token: 0x0601C8FE RID: 116990 RVA: 0x00409FB9 File Offset: 0x004081B9
		public static IBuffDurationBase_UnionUnion FromIBuffDurationPermanent(IBuffDurationPermanentT _ibuffdurationpermanent)
		{
			return new IBuffDurationBase_UnionUnion
			{
				Type = IBuffDurationBase_Union.IBuffDurationPermanent,
				Value = _ibuffdurationpermanent
			};
		}

		// Token: 0x0601C8FF RID: 116991 RVA: 0x00409FCE File Offset: 0x004081CE
		public IBuffHasDurationT AsIBuffHasDuration()
		{
			return this.As<IBuffHasDurationT>();
		}

		// Token: 0x0601C900 RID: 116992 RVA: 0x00409FD6 File Offset: 0x004081D6
		public static IBuffDurationBase_UnionUnion FromIBuffHasDuration(IBuffHasDurationT _ibuffhasduration)
		{
			return new IBuffDurationBase_UnionUnion
			{
				Type = IBuffDurationBase_Union.IBuffHasDuration,
				Value = _ibuffhasduration
			};
		}

		// Token: 0x0601C901 RID: 116993 RVA: 0x00409FEC File Offset: 0x004081EC
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
