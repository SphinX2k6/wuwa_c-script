using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007639 RID: 30265
	public class TActorTurnToDataUnion
	{
		// Token: 0x1700E5B9 RID: 58809
		// (get) Token: 0x060371DC RID: 225756 RVA: 0x007796AC File Offset: 0x007778AC
		// (set) Token: 0x060371DD RID: 225757 RVA: 0x007796B4 File Offset: 0x007778B4
		public TActorTurnToData Type { get; set; }

		// Token: 0x1700E5BA RID: 58810
		// (get) Token: 0x060371DE RID: 225758 RVA: 0x007796BD File Offset: 0x007778BD
		// (set) Token: 0x060371DF RID: 225759 RVA: 0x007796C5 File Offset: 0x007778C5
		public object Value { get; set; }

		// Token: 0x060371E0 RID: 225760 RVA: 0x007796CE File Offset: 0x007778CE
		public TActorTurnToDataUnion()
		{
			this.Type = TActorTurnToData.NONE;
			this.Value = null;
		}

		// Token: 0x060371E1 RID: 225761 RVA: 0x007796E4 File Offset: 0x007778E4
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060371E2 RID: 225762 RVA: 0x007796F6 File Offset: 0x007778F6
		public IActorTurnToEmptyDataT AsIActorTurnToEmptyData()
		{
			return this.As<IActorTurnToEmptyDataT>();
		}

		// Token: 0x060371E3 RID: 225763 RVA: 0x007796FE File Offset: 0x007778FE
		public static TActorTurnToDataUnion FromIActorTurnToEmptyData(IActorTurnToEmptyDataT _iactorturntoemptydata)
		{
			return new TActorTurnToDataUnion
			{
				Type = TActorTurnToData.IActorTurnToEmptyData,
				Value = _iactorturntoemptydata
			};
		}

		// Token: 0x060371E4 RID: 225764 RVA: 0x00779713 File Offset: 0x00777913
		public IActorTurnToEntityDataT AsIActorTurnToEntityData()
		{
			return this.As<IActorTurnToEntityDataT>();
		}

		// Token: 0x060371E5 RID: 225765 RVA: 0x0077971B File Offset: 0x0077791B
		public static TActorTurnToDataUnion FromIActorTurnToEntityData(IActorTurnToEntityDataT _iactorturntoentitydata)
		{
			return new TActorTurnToDataUnion
			{
				Type = TActorTurnToData.IActorTurnToEntityData,
				Value = _iactorturntoentitydata
			};
		}

		// Token: 0x060371E6 RID: 225766 RVA: 0x00779730 File Offset: 0x00777930
		public IActorTurnToPlayerDataT AsIActorTurnToPlayerData()
		{
			return this.As<IActorTurnToPlayerDataT>();
		}

		// Token: 0x060371E7 RID: 225767 RVA: 0x00779738 File Offset: 0x00777938
		public static TActorTurnToDataUnion FromIActorTurnToPlayerData(IActorTurnToPlayerDataT _iactorturntoplayerdata)
		{
			return new TActorTurnToDataUnion
			{
				Type = TActorTurnToData.IActorTurnToPlayerData,
				Value = _iactorturntoplayerdata
			};
		}

		// Token: 0x060371E8 RID: 225768 RVA: 0x0077974D File Offset: 0x0077794D
		public IActorTurnToPositionDataT AsIActorTurnToPositionData()
		{
			return this.As<IActorTurnToPositionDataT>();
		}

		// Token: 0x060371E9 RID: 225769 RVA: 0x00779755 File Offset: 0x00777955
		public static TActorTurnToDataUnion FromIActorTurnToPositionData(IActorTurnToPositionDataT _iactorturntopositiondata)
		{
			return new TActorTurnToDataUnion
			{
				Type = TActorTurnToData.IActorTurnToPositionData,
				Value = _iactorturntopositiondata
			};
		}

		// Token: 0x060371EA RID: 225770 RVA: 0x0077976A File Offset: 0x0077796A
		public IActorTurnToTalkerDataT AsIActorTurnToTalkerData()
		{
			return this.As<IActorTurnToTalkerDataT>();
		}

		// Token: 0x060371EB RID: 225771 RVA: 0x00779772 File Offset: 0x00777972
		public static TActorTurnToDataUnion FromIActorTurnToTalkerData(IActorTurnToTalkerDataT _iactorturntotalkerdata)
		{
			return new TActorTurnToDataUnion
			{
				Type = TActorTurnToData.IActorTurnToTalkerData,
				Value = _iactorturntotalkerdata
			};
		}

		// Token: 0x060371EC RID: 225772 RVA: 0x00779788 File Offset: 0x00777988
		public static int Pack(FlatBufferBuilder builder, TActorTurnToDataUnion _o)
		{
			switch (_o.Type)
			{
			case TActorTurnToData.IActorTurnToEmptyData:
				return IActorTurnToEmptyData.Pack(builder, _o.AsIActorTurnToEmptyData()).Value;
			case TActorTurnToData.IActorTurnToEntityData:
				return IActorTurnToEntityData.Pack(builder, _o.AsIActorTurnToEntityData()).Value;
			case TActorTurnToData.IActorTurnToPlayerData:
				return IActorTurnToPlayerData.Pack(builder, _o.AsIActorTurnToPlayerData()).Value;
			case TActorTurnToData.IActorTurnToPositionData:
				return IActorTurnToPositionData.Pack(builder, _o.AsIActorTurnToPositionData()).Value;
			case TActorTurnToData.IActorTurnToTalkerData:
				return IActorTurnToTalkerData.Pack(builder, _o.AsIActorTurnToTalkerData()).Value;
			default:
				return 0;
			}
		}
	}
}
