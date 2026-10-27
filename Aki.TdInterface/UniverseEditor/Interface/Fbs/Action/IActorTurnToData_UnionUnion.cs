using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020060FF RID: 24831
	public class IActorTurnToData_UnionUnion
	{
		// Token: 0x1700B706 RID: 46854
		// (get) Token: 0x0602A6C9 RID: 173769 RVA: 0x005D858D File Offset: 0x005D678D
		// (set) Token: 0x0602A6CA RID: 173770 RVA: 0x005D8595 File Offset: 0x005D6795
		public IActorTurnToData_Union Type { get; set; }

		// Token: 0x1700B707 RID: 46855
		// (get) Token: 0x0602A6CB RID: 173771 RVA: 0x005D859E File Offset: 0x005D679E
		// (set) Token: 0x0602A6CC RID: 173772 RVA: 0x005D85A6 File Offset: 0x005D67A6
		public object Value { get; set; }

		// Token: 0x0602A6CD RID: 173773 RVA: 0x005D85AF File Offset: 0x005D67AF
		public IActorTurnToData_UnionUnion()
		{
			this.Type = IActorTurnToData_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0602A6CE RID: 173774 RVA: 0x005D85C5 File Offset: 0x005D67C5
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602A6CF RID: 173775 RVA: 0x005D85D7 File Offset: 0x005D67D7
		public IActorTurnToDataT AsIActorTurnToData()
		{
			return this.As<IActorTurnToDataT>();
		}

		// Token: 0x0602A6D0 RID: 173776 RVA: 0x005D85DF File Offset: 0x005D67DF
		public static IActorTurnToData_UnionUnion FromIActorTurnToData(IActorTurnToDataT _iactorturntodata)
		{
			return new IActorTurnToData_UnionUnion
			{
				Type = IActorTurnToData_Union.IActorTurnToData,
				Value = _iactorturntodata
			};
		}

		// Token: 0x0602A6D1 RID: 173777 RVA: 0x005D85F4 File Offset: 0x005D67F4
		public IActorTurnToTalkerDataT AsIActorTurnToTalkerData()
		{
			return this.As<IActorTurnToTalkerDataT>();
		}

		// Token: 0x0602A6D2 RID: 173778 RVA: 0x005D85FC File Offset: 0x005D67FC
		public static IActorTurnToData_UnionUnion FromIActorTurnToTalkerData(IActorTurnToTalkerDataT _iactorturntotalkerdata)
		{
			return new IActorTurnToData_UnionUnion
			{
				Type = IActorTurnToData_Union.IActorTurnToTalkerData,
				Value = _iactorturntotalkerdata
			};
		}

		// Token: 0x0602A6D3 RID: 173779 RVA: 0x005D8611 File Offset: 0x005D6811
		public IActorTurnToEmptyDataT AsIActorTurnToEmptyData()
		{
			return this.As<IActorTurnToEmptyDataT>();
		}

		// Token: 0x0602A6D4 RID: 173780 RVA: 0x005D8619 File Offset: 0x005D6819
		public static IActorTurnToData_UnionUnion FromIActorTurnToEmptyData(IActorTurnToEmptyDataT _iactorturntoemptydata)
		{
			return new IActorTurnToData_UnionUnion
			{
				Type = IActorTurnToData_Union.IActorTurnToEmptyData,
				Value = _iactorturntoemptydata
			};
		}

		// Token: 0x0602A6D5 RID: 173781 RVA: 0x005D862E File Offset: 0x005D682E
		public IActorTurnToEntityDataT AsIActorTurnToEntityData()
		{
			return this.As<IActorTurnToEntityDataT>();
		}

		// Token: 0x0602A6D6 RID: 173782 RVA: 0x005D8636 File Offset: 0x005D6836
		public static IActorTurnToData_UnionUnion FromIActorTurnToEntityData(IActorTurnToEntityDataT _iactorturntoentitydata)
		{
			return new IActorTurnToData_UnionUnion
			{
				Type = IActorTurnToData_Union.IActorTurnToEntityData,
				Value = _iactorturntoentitydata
			};
		}

		// Token: 0x0602A6D7 RID: 173783 RVA: 0x005D864B File Offset: 0x005D684B
		public IActorTurnToPositionDataT AsIActorTurnToPositionData()
		{
			return this.As<IActorTurnToPositionDataT>();
		}

		// Token: 0x0602A6D8 RID: 173784 RVA: 0x005D8653 File Offset: 0x005D6853
		public static IActorTurnToData_UnionUnion FromIActorTurnToPositionData(IActorTurnToPositionDataT _iactorturntopositiondata)
		{
			return new IActorTurnToData_UnionUnion
			{
				Type = IActorTurnToData_Union.IActorTurnToPositionData,
				Value = _iactorturntopositiondata
			};
		}

		// Token: 0x0602A6D9 RID: 173785 RVA: 0x005D8668 File Offset: 0x005D6868
		public IActorTurnToPlayerDataT AsIActorTurnToPlayerData()
		{
			return this.As<IActorTurnToPlayerDataT>();
		}

		// Token: 0x0602A6DA RID: 173786 RVA: 0x005D8670 File Offset: 0x005D6870
		public static IActorTurnToData_UnionUnion FromIActorTurnToPlayerData(IActorTurnToPlayerDataT _iactorturntoplayerdata)
		{
			return new IActorTurnToData_UnionUnion
			{
				Type = IActorTurnToData_Union.IActorTurnToPlayerData,
				Value = _iactorturntoplayerdata
			};
		}

		// Token: 0x0602A6DB RID: 173787 RVA: 0x005D8688 File Offset: 0x005D6888
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
