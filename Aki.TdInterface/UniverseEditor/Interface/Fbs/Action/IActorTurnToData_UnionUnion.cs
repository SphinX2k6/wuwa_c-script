using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006761 RID: 26465
	public class IActorTurnToData_UnionUnion
	{
		// Token: 0x1700C071 RID: 49265
		// (get) Token: 0x0602CDAA RID: 183722 RVA: 0x00622535 File Offset: 0x00620735
		// (set) Token: 0x0602CDAB RID: 183723 RVA: 0x0062253D File Offset: 0x0062073D
		public IActorTurnToData_Union Type { get; set; }

		// Token: 0x1700C072 RID: 49266
		// (get) Token: 0x0602CDAC RID: 183724 RVA: 0x00622546 File Offset: 0x00620746
		// (set) Token: 0x0602CDAD RID: 183725 RVA: 0x0062254E File Offset: 0x0062074E
		public object Value { get; set; }

		// Token: 0x0602CDAE RID: 183726 RVA: 0x00622557 File Offset: 0x00620757
		public IActorTurnToData_UnionUnion()
		{
			this.Type = IActorTurnToData_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0602CDAF RID: 183727 RVA: 0x0062256D File Offset: 0x0062076D
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602CDB0 RID: 183728 RVA: 0x0062257F File Offset: 0x0062077F
		public IActorTurnToDataT AsIActorTurnToData()
		{
			return this.As<IActorTurnToDataT>();
		}

		// Token: 0x0602CDB1 RID: 183729 RVA: 0x00622587 File Offset: 0x00620787
		public static IActorTurnToData_UnionUnion FromIActorTurnToData(IActorTurnToDataT _iactorturntodata)
		{
			return new IActorTurnToData_UnionUnion
			{
				Type = IActorTurnToData_Union.IActorTurnToData,
				Value = _iactorturntodata
			};
		}

		// Token: 0x0602CDB2 RID: 183730 RVA: 0x0062259C File Offset: 0x0062079C
		public IActorTurnToTalkerDataT AsIActorTurnToTalkerData()
		{
			return this.As<IActorTurnToTalkerDataT>();
		}

		// Token: 0x0602CDB3 RID: 183731 RVA: 0x006225A4 File Offset: 0x006207A4
		public static IActorTurnToData_UnionUnion FromIActorTurnToTalkerData(IActorTurnToTalkerDataT _iactorturntotalkerdata)
		{
			return new IActorTurnToData_UnionUnion
			{
				Type = IActorTurnToData_Union.IActorTurnToTalkerData,
				Value = _iactorturntotalkerdata
			};
		}

		// Token: 0x0602CDB4 RID: 183732 RVA: 0x006225B9 File Offset: 0x006207B9
		public IActorTurnToEmptyDataT AsIActorTurnToEmptyData()
		{
			return this.As<IActorTurnToEmptyDataT>();
		}

		// Token: 0x0602CDB5 RID: 183733 RVA: 0x006225C1 File Offset: 0x006207C1
		public static IActorTurnToData_UnionUnion FromIActorTurnToEmptyData(IActorTurnToEmptyDataT _iactorturntoemptydata)
		{
			return new IActorTurnToData_UnionUnion
			{
				Type = IActorTurnToData_Union.IActorTurnToEmptyData,
				Value = _iactorturntoemptydata
			};
		}

		// Token: 0x0602CDB6 RID: 183734 RVA: 0x006225D6 File Offset: 0x006207D6
		public IActorTurnToEntityDataT AsIActorTurnToEntityData()
		{
			return this.As<IActorTurnToEntityDataT>();
		}

		// Token: 0x0602CDB7 RID: 183735 RVA: 0x006225DE File Offset: 0x006207DE
		public static IActorTurnToData_UnionUnion FromIActorTurnToEntityData(IActorTurnToEntityDataT _iactorturntoentitydata)
		{
			return new IActorTurnToData_UnionUnion
			{
				Type = IActorTurnToData_Union.IActorTurnToEntityData,
				Value = _iactorturntoentitydata
			};
		}

		// Token: 0x0602CDB8 RID: 183736 RVA: 0x006225F3 File Offset: 0x006207F3
		public IActorTurnToPositionDataT AsIActorTurnToPositionData()
		{
			return this.As<IActorTurnToPositionDataT>();
		}

		// Token: 0x0602CDB9 RID: 183737 RVA: 0x006225FB File Offset: 0x006207FB
		public static IActorTurnToData_UnionUnion FromIActorTurnToPositionData(IActorTurnToPositionDataT _iactorturntopositiondata)
		{
			return new IActorTurnToData_UnionUnion
			{
				Type = IActorTurnToData_Union.IActorTurnToPositionData,
				Value = _iactorturntopositiondata
			};
		}

		// Token: 0x0602CDBA RID: 183738 RVA: 0x00622610 File Offset: 0x00620810
		public IActorTurnToPlayerDataT AsIActorTurnToPlayerData()
		{
			return this.As<IActorTurnToPlayerDataT>();
		}

		// Token: 0x0602CDBB RID: 183739 RVA: 0x00622618 File Offset: 0x00620818
		public static IActorTurnToData_UnionUnion FromIActorTurnToPlayerData(IActorTurnToPlayerDataT _iactorturntoplayerdata)
		{
			return new IActorTurnToData_UnionUnion
			{
				Type = IActorTurnToData_Union.IActorTurnToPlayerData,
				Value = _iactorturntoplayerdata
			};
		}

		// Token: 0x0602CDBC RID: 183740 RVA: 0x00622630 File Offset: 0x00620830
		public static int Pack(FlatBufferBuilder builder, IActorTurnToData_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IActorTurnToData_Union.IActorTurnToData:
				return IActorTurnToData.Pack(builder, _o.AsIActorTurnToData()).Value;
			case IActorTurnToData_Union.IActorTurnToTalkerData:
				return IActorTurnToTalkerData.Pack(builder, _o.AsIActorTurnToTalkerData()).Value;
			case IActorTurnToData_Union.IActorTurnToEmptyData:
				return IActorTurnToEmptyData.Pack(builder, _o.AsIActorTurnToEmptyData()).Value;
			case IActorTurnToData_Union.IActorTurnToEntityData:
				return IActorTurnToEntityData.Pack(builder, _o.AsIActorTurnToEntityData()).Value;
			case IActorTurnToData_Union.IActorTurnToPositionData:
				return IActorTurnToPositionData.Pack(builder, _o.AsIActorTurnToPositionData()).Value;
			case IActorTurnToData_Union.IActorTurnToPlayerData:
				return IActorTurnToPlayerData.Pack(builder, _o.AsIActorTurnToPlayerData()).Value;
			default:
				return 0;
			}
		}
	}
}
