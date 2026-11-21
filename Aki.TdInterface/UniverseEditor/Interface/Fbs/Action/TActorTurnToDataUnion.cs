using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007E47 RID: 32327
	public class TActorTurnToDataUnion
	{
		// Token: 0x1700F1F7 RID: 61943
		// (get) Token: 0x0603A681 RID: 239233 RVA: 0x007DD7A8 File Offset: 0x007DB9A8
		// (set) Token: 0x0603A682 RID: 239234 RVA: 0x007DD7B0 File Offset: 0x007DB9B0
		public TActorTurnToData Type { get; set; }

		// Token: 0x1700F1F8 RID: 61944
		// (get) Token: 0x0603A683 RID: 239235 RVA: 0x007DD7B9 File Offset: 0x007DB9B9
		// (set) Token: 0x0603A684 RID: 239236 RVA: 0x007DD7C1 File Offset: 0x007DB9C1
		public object Value { get; set; }

		// Token: 0x0603A685 RID: 239237 RVA: 0x007DD7CA File Offset: 0x007DB9CA
		public TActorTurnToDataUnion()
		{
			this.Type = TActorTurnToData.NONE;
			this.Value = null;
		}

		// Token: 0x0603A686 RID: 239238 RVA: 0x007DD7E0 File Offset: 0x007DB9E0
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0603A687 RID: 239239 RVA: 0x007DD7F2 File Offset: 0x007DB9F2
		public IActorTurnToEmptyDataT AsIActorTurnToEmptyData()
		{
			return this.As<IActorTurnToEmptyDataT>();
		}

		// Token: 0x0603A688 RID: 239240 RVA: 0x007DD7FA File Offset: 0x007DB9FA
		public static TActorTurnToDataUnion FromIActorTurnToEmptyData(IActorTurnToEmptyDataT _iactorturntoemptydata)
		{
			return new TActorTurnToDataUnion
			{
				Type = TActorTurnToData.IActorTurnToEmptyData,
				Value = _iactorturntoemptydata
			};
		}

		// Token: 0x0603A689 RID: 239241 RVA: 0x007DD80F File Offset: 0x007DBA0F
		public IActorTurnToEntityDataT AsIActorTurnToEntityData()
		{
			return this.As<IActorTurnToEntityDataT>();
		}

		// Token: 0x0603A68A RID: 239242 RVA: 0x007DD817 File Offset: 0x007DBA17
		public static TActorTurnToDataUnion FromIActorTurnToEntityData(IActorTurnToEntityDataT _iactorturntoentitydata)
		{
			return new TActorTurnToDataUnion
			{
				Type = TActorTurnToData.IActorTurnToEntityData,
				Value = _iactorturntoentitydata
			};
		}

		// Token: 0x0603A68B RID: 239243 RVA: 0x007DD82C File Offset: 0x007DBA2C
		public IActorTurnToPlayerDataT AsIActorTurnToPlayerData()
		{
			return this.As<IActorTurnToPlayerDataT>();
		}

		// Token: 0x0603A68C RID: 239244 RVA: 0x007DD834 File Offset: 0x007DBA34
		public static TActorTurnToDataUnion FromIActorTurnToPlayerData(IActorTurnToPlayerDataT _iactorturntoplayerdata)
		{
			return new TActorTurnToDataUnion
			{
				Type = TActorTurnToData.IActorTurnToPlayerData,
				Value = _iactorturntoplayerdata
			};
		}

		// Token: 0x0603A68D RID: 239245 RVA: 0x007DD849 File Offset: 0x007DBA49
		public IActorTurnToPositionDataT AsIActorTurnToPositionData()
		{
			return this.As<IActorTurnToPositionDataT>();
		}

		// Token: 0x0603A68E RID: 239246 RVA: 0x007DD851 File Offset: 0x007DBA51
		public static TActorTurnToDataUnion FromIActorTurnToPositionData(IActorTurnToPositionDataT _iactorturntopositiondata)
		{
			return new TActorTurnToDataUnion
			{
				Type = TActorTurnToData.IActorTurnToPositionData,
				Value = _iactorturntopositiondata
			};
		}

		// Token: 0x0603A68F RID: 239247 RVA: 0x007DD866 File Offset: 0x007DBA66
		public IActorTurnToTalkerDataT AsIActorTurnToTalkerData()
		{
			return this.As<IActorTurnToTalkerDataT>();
		}

		// Token: 0x0603A690 RID: 239248 RVA: 0x007DD86E File Offset: 0x007DBA6E
		public static TActorTurnToDataUnion FromIActorTurnToTalkerData(IActorTurnToTalkerDataT _iactorturntotalkerdata)
		{
			return new TActorTurnToDataUnion
			{
				Type = TActorTurnToData.IActorTurnToTalkerData,
				Value = _iactorturntotalkerdata
			};
		}

		// Token: 0x0603A691 RID: 239249 RVA: 0x007DD884 File Offset: 0x007DBA84
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
