using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020068C5 RID: 26821
	public class IHandInHandInitiatorType_UnionUnion
	{
		// Token: 0x1700C70A RID: 50954
		// (get) Token: 0x0602EC7E RID: 191614 RVA: 0x006627F1 File Offset: 0x006609F1
		// (set) Token: 0x0602EC7F RID: 191615 RVA: 0x006627F9 File Offset: 0x006609F9
		public IHandInHandInitiatorType_Union Type { get; set; }

		// Token: 0x1700C70B RID: 50955
		// (get) Token: 0x0602EC80 RID: 191616 RVA: 0x00662802 File Offset: 0x00660A02
		// (set) Token: 0x0602EC81 RID: 191617 RVA: 0x0066280A File Offset: 0x00660A0A
		public object Value { get; set; }

		// Token: 0x0602EC82 RID: 191618 RVA: 0x00662813 File Offset: 0x00660A13
		public IHandInHandInitiatorType_UnionUnion()
		{
			this.Type = IHandInHandInitiatorType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0602EC83 RID: 191619 RVA: 0x00662829 File Offset: 0x00660A29
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602EC84 RID: 191620 RVA: 0x0066283B File Offset: 0x00660A3B
		public IHandInHandInitiatorTypeT AsIHandInHandInitiatorType()
		{
			return this.As<IHandInHandInitiatorTypeT>();
		}

		// Token: 0x0602EC85 RID: 191621 RVA: 0x00662843 File Offset: 0x00660A43
		public static IHandInHandInitiatorType_UnionUnion FromIHandInHandInitiatorType(IHandInHandInitiatorTypeT _ihandinhandinitiatortype)
		{
			return new IHandInHandInitiatorType_UnionUnion
			{
				Type = IHandInHandInitiatorType_Union.IHandInHandInitiatorType,
				Value = _ihandinhandinitiatortype
			};
		}

		// Token: 0x0602EC86 RID: 191622 RVA: 0x00662858 File Offset: 0x00660A58
		public IPlayerHandInHandInitiatorT AsIPlayerHandInHandInitiator()
		{
			return this.As<IPlayerHandInHandInitiatorT>();
		}

		// Token: 0x0602EC87 RID: 191623 RVA: 0x00662860 File Offset: 0x00660A60
		public static IHandInHandInitiatorType_UnionUnion FromIPlayerHandInHandInitiator(IPlayerHandInHandInitiatorT _iplayerhandinhandinitiator)
		{
			return new IHandInHandInitiatorType_UnionUnion
			{
				Type = IHandInHandInitiatorType_Union.IPlayerHandInHandInitiator,
				Value = _iplayerhandinhandinitiator
			};
		}

		// Token: 0x0602EC88 RID: 191624 RVA: 0x00662875 File Offset: 0x00660A75
		public IEntityHandInHandInitiatorT AsIEntityHandInHandInitiator()
		{
			return this.As<IEntityHandInHandInitiatorT>();
		}

		// Token: 0x0602EC89 RID: 191625 RVA: 0x0066287D File Offset: 0x00660A7D
		public static IHandInHandInitiatorType_UnionUnion FromIEntityHandInHandInitiator(IEntityHandInHandInitiatorT _ientityhandinhandinitiator)
		{
			return new IHandInHandInitiatorType_UnionUnion
			{
				Type = IHandInHandInitiatorType_Union.IEntityHandInHandInitiator,
				Value = _ientityhandinhandinitiator
			};
		}

		// Token: 0x0602EC8A RID: 191626 RVA: 0x00662894 File Offset: 0x00660A94
		public static int Pack(FlatBufferBuilder builder, IHandInHandInitiatorType_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IHandInHandInitiatorType_Union.IHandInHandInitiatorType:
				return IHandInHandInitiatorType.Pack(builder, _o.AsIHandInHandInitiatorType()).Value;
			case IHandInHandInitiatorType_Union.IPlayerHandInHandInitiator:
				return IPlayerHandInHandInitiator.Pack(builder, _o.AsIPlayerHandInHandInitiator()).Value;
			case IHandInHandInitiatorType_Union.IEntityHandInHandInitiator:
				return IEntityHandInHandInitiator.Pack(builder, _o.AsIEntityHandInHandInitiator()).Value;
			default:
				return 0;
			}
		}
	}
}
