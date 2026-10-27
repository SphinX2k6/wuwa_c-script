using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007636 RID: 30262
	public class TActorLookAtDataUnion
	{
		// Token: 0x1700E5B7 RID: 58807
		// (get) Token: 0x060371C6 RID: 225734 RVA: 0x0077945E File Offset: 0x0077765E
		// (set) Token: 0x060371C7 RID: 225735 RVA: 0x00779466 File Offset: 0x00777666
		public TActorLookAtData Type { get; set; }

		// Token: 0x1700E5B8 RID: 58808
		// (get) Token: 0x060371C8 RID: 225736 RVA: 0x0077946F File Offset: 0x0077766F
		// (set) Token: 0x060371C9 RID: 225737 RVA: 0x00779477 File Offset: 0x00777677
		public object Value { get; set; }

		// Token: 0x060371CA RID: 225738 RVA: 0x00779480 File Offset: 0x00777680
		public TActorLookAtDataUnion()
		{
			this.Type = TActorLookAtData.NONE;
			this.Value = null;
		}

		// Token: 0x060371CB RID: 225739 RVA: 0x00779496 File Offset: 0x00777696
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060371CC RID: 225740 RVA: 0x007794A8 File Offset: 0x007776A8
		public IActorLookAtEmptyDataT AsIActorLookAtEmptyData()
		{
			return this.As<IActorLookAtEmptyDataT>();
		}

		// Token: 0x060371CD RID: 225741 RVA: 0x007794B0 File Offset: 0x007776B0
		public static TActorLookAtDataUnion FromIActorLookAtEmptyData(IActorLookAtEmptyDataT _iactorlookatemptydata)
		{
			return new TActorLookAtDataUnion
			{
				Type = TActorLookAtData.IActorLookAtEmptyData,
				Value = _iactorlookatemptydata
			};
		}

		// Token: 0x060371CE RID: 225742 RVA: 0x007794C5 File Offset: 0x007776C5
		public IActorLookAtEntityDataT AsIActorLookAtEntityData()
		{
			return this.As<IActorLookAtEntityDataT>();
		}

		// Token: 0x060371CF RID: 225743 RVA: 0x007794CD File Offset: 0x007776CD
		public static TActorLookAtDataUnion FromIActorLookAtEntityData(IActorLookAtEntityDataT _iactorlookatentitydata)
		{
			return new TActorLookAtDataUnion
			{
				Type = TActorLookAtData.IActorLookAtEntityData,
				Value = _iactorlookatentitydata
			};
		}

		// Token: 0x060371D0 RID: 225744 RVA: 0x007794E2 File Offset: 0x007776E2
		public IActorLookAtOtherActorT AsIActorLookAtOtherActor()
		{
			return this.As<IActorLookAtOtherActorT>();
		}

		// Token: 0x060371D1 RID: 225745 RVA: 0x007794EA File Offset: 0x007776EA
		public static TActorLookAtDataUnion FromIActorLookAtOtherActor(IActorLookAtOtherActorT _iactorlookatotheractor)
		{
			return new TActorLookAtDataUnion
			{
				Type = TActorLookAtData.IActorLookAtOtherActor,
				Value = _iactorlookatotheractor
			};
		}

		// Token: 0x060371D2 RID: 225746 RVA: 0x007794FF File Offset: 0x007776FF
		public IActorLookAtPlayerDataT AsIActorLookAtPlayerData()
		{
			return this.As<IActorLookAtPlayerDataT>();
		}

		// Token: 0x060371D3 RID: 225747 RVA: 0x00779507 File Offset: 0x00777707
		public static TActorLookAtDataUnion FromIActorLookAtPlayerData(IActorLookAtPlayerDataT _iactorlookatplayerdata)
		{
			return new TActorLookAtDataUnion
			{
				Type = TActorLookAtData.IActorLookAtPlayerData,
				Value = _iactorlookatplayerdata
			};
		}

		// Token: 0x060371D4 RID: 225748 RVA: 0x0077951C File Offset: 0x0077771C
		public IActorLookAtPositionDataT AsIActorLookAtPositionData()
		{
			return this.As<IActorLookAtPositionDataT>();
		}

		// Token: 0x060371D5 RID: 225749 RVA: 0x00779524 File Offset: 0x00777724
		public static TActorLookAtDataUnion FromIActorLookAtPositionData(IActorLookAtPositionDataT _iactorlookatpositiondata)
		{
			return new TActorLookAtDataUnion
			{
				Type = TActorLookAtData.IActorLookAtPositionData,
				Value = _iactorlookatpositiondata
			};
		}

		// Token: 0x060371D6 RID: 225750 RVA: 0x00779539 File Offset: 0x00777739
		public IActorLookAtTalkerDataT AsIActorLookAtTalkerData()
		{
			return this.As<IActorLookAtTalkerDataT>();
		}

		// Token: 0x060371D7 RID: 225751 RVA: 0x00779541 File Offset: 0x00777741
		public static TActorLookAtDataUnion FromIActorLookAtTalkerData(IActorLookAtTalkerDataT _iactorlookattalkerdata)
		{
			return new TActorLookAtDataUnion
			{
				Type = TActorLookAtData.IActorLookAtTalkerData,
				Value = _iactorlookattalkerdata
			};
		}

		// Token: 0x060371D8 RID: 225752 RVA: 0x00779556 File Offset: 0x00777756
		public IActorLookAtUnLockT AsIActorLookAtUnLock()
		{
			return this.As<IActorLookAtUnLockT>();
		}

		// Token: 0x060371D9 RID: 225753 RVA: 0x0077955E File Offset: 0x0077775E
		public static TActorLookAtDataUnion FromIActorLookAtUnLock(IActorLookAtUnLockT _iactorlookatunlock)
		{
			return new TActorLookAtDataUnion
			{
				Type = TActorLookAtData.IActorLookAtUnLock,
				Value = _iactorlookatunlock
			};
		}

		// Token: 0x060371DA RID: 225754 RVA: 0x00779574 File Offset: 0x00777774
		public static int Pack(FlatBufferBuilder builder, TActorLookAtDataUnion _o)
		{
			switch (_o.Type)
			{
			case TActorLookAtData.IActorLookAtEmptyData:
				return IActorLookAtEmptyData.Pack(builder, _o.AsIActorLookAtEmptyData()).Value;
			case TActorLookAtData.IActorLookAtEntityData:
				return IActorLookAtEntityData.Pack(builder, _o.AsIActorLookAtEntityData()).Value;
			case TActorLookAtData.IActorLookAtOtherActor:
				return IActorLookAtOtherActor.Pack(builder, _o.AsIActorLookAtOtherActor()).Value;
			case TActorLookAtData.IActorLookAtPlayerData:
				return IActorLookAtPlayerData.Pack(builder, _o.AsIActorLookAtPlayerData()).Value;
			case TActorLookAtData.IActorLookAtPositionData:
				return IActorLookAtPositionData.Pack(builder, _o.AsIActorLookAtPositionData()).Value;
			case TActorLookAtData.IActorLookAtTalkerData:
				return IActorLookAtTalkerData.Pack(builder, _o.AsIActorLookAtTalkerData()).Value;
			case TActorLookAtData.IActorLookAtUnLock:
				return IActorLookAtUnLock.Pack(builder, _o.AsIActorLookAtUnLock()).Value;
			default:
				return 0;
			}
		}
	}
}
