using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007E44 RID: 32324
	public class TActorLookAtDataUnion
	{
		// Token: 0x1700F1F5 RID: 61941
		// (get) Token: 0x0603A66B RID: 239211 RVA: 0x007DD55A File Offset: 0x007DB75A
		// (set) Token: 0x0603A66C RID: 239212 RVA: 0x007DD562 File Offset: 0x007DB762
		public TActorLookAtData Type { get; set; }

		// Token: 0x1700F1F6 RID: 61942
		// (get) Token: 0x0603A66D RID: 239213 RVA: 0x007DD56B File Offset: 0x007DB76B
		// (set) Token: 0x0603A66E RID: 239214 RVA: 0x007DD573 File Offset: 0x007DB773
		public object Value { get; set; }

		// Token: 0x0603A66F RID: 239215 RVA: 0x007DD57C File Offset: 0x007DB77C
		public TActorLookAtDataUnion()
		{
			this.Type = TActorLookAtData.NONE;
			this.Value = null;
		}

		// Token: 0x0603A670 RID: 239216 RVA: 0x007DD592 File Offset: 0x007DB792
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0603A671 RID: 239217 RVA: 0x007DD5A4 File Offset: 0x007DB7A4
		public IActorLookAtEmptyDataT AsIActorLookAtEmptyData()
		{
			return this.As<IActorLookAtEmptyDataT>();
		}

		// Token: 0x0603A672 RID: 239218 RVA: 0x007DD5AC File Offset: 0x007DB7AC
		public static TActorLookAtDataUnion FromIActorLookAtEmptyData(IActorLookAtEmptyDataT _iactorlookatemptydata)
		{
			return new TActorLookAtDataUnion
			{
				Type = TActorLookAtData.IActorLookAtEmptyData,
				Value = _iactorlookatemptydata
			};
		}

		// Token: 0x0603A673 RID: 239219 RVA: 0x007DD5C1 File Offset: 0x007DB7C1
		public IActorLookAtEntityDataT AsIActorLookAtEntityData()
		{
			return this.As<IActorLookAtEntityDataT>();
		}

		// Token: 0x0603A674 RID: 239220 RVA: 0x007DD5C9 File Offset: 0x007DB7C9
		public static TActorLookAtDataUnion FromIActorLookAtEntityData(IActorLookAtEntityDataT _iactorlookatentitydata)
		{
			return new TActorLookAtDataUnion
			{
				Type = TActorLookAtData.IActorLookAtEntityData,
				Value = _iactorlookatentitydata
			};
		}

		// Token: 0x0603A675 RID: 239221 RVA: 0x007DD5DE File Offset: 0x007DB7DE
		public IActorLookAtOtherActorT AsIActorLookAtOtherActor()
		{
			return this.As<IActorLookAtOtherActorT>();
		}

		// Token: 0x0603A676 RID: 239222 RVA: 0x007DD5E6 File Offset: 0x007DB7E6
		public static TActorLookAtDataUnion FromIActorLookAtOtherActor(IActorLookAtOtherActorT _iactorlookatotheractor)
		{
			return new TActorLookAtDataUnion
			{
				Type = TActorLookAtData.IActorLookAtOtherActor,
				Value = _iactorlookatotheractor
			};
		}

		// Token: 0x0603A677 RID: 239223 RVA: 0x007DD5FB File Offset: 0x007DB7FB
		public IActorLookAtPlayerDataT AsIActorLookAtPlayerData()
		{
			return this.As<IActorLookAtPlayerDataT>();
		}

		// Token: 0x0603A678 RID: 239224 RVA: 0x007DD603 File Offset: 0x007DB803
		public static TActorLookAtDataUnion FromIActorLookAtPlayerData(IActorLookAtPlayerDataT _iactorlookatplayerdata)
		{
			return new TActorLookAtDataUnion
			{
				Type = TActorLookAtData.IActorLookAtPlayerData,
				Value = _iactorlookatplayerdata
			};
		}

		// Token: 0x0603A679 RID: 239225 RVA: 0x007DD618 File Offset: 0x007DB818
		public IActorLookAtPositionDataT AsIActorLookAtPositionData()
		{
			return this.As<IActorLookAtPositionDataT>();
		}

		// Token: 0x0603A67A RID: 239226 RVA: 0x007DD620 File Offset: 0x007DB820
		public static TActorLookAtDataUnion FromIActorLookAtPositionData(IActorLookAtPositionDataT _iactorlookatpositiondata)
		{
			return new TActorLookAtDataUnion
			{
				Type = TActorLookAtData.IActorLookAtPositionData,
				Value = _iactorlookatpositiondata
			};
		}

		// Token: 0x0603A67B RID: 239227 RVA: 0x007DD635 File Offset: 0x007DB835
		public IActorLookAtTalkerDataT AsIActorLookAtTalkerData()
		{
			return this.As<IActorLookAtTalkerDataT>();
		}

		// Token: 0x0603A67C RID: 239228 RVA: 0x007DD63D File Offset: 0x007DB83D
		public static TActorLookAtDataUnion FromIActorLookAtTalkerData(IActorLookAtTalkerDataT _iactorlookattalkerdata)
		{
			return new TActorLookAtDataUnion
			{
				Type = TActorLookAtData.IActorLookAtTalkerData,
				Value = _iactorlookattalkerdata
			};
		}

		// Token: 0x0603A67D RID: 239229 RVA: 0x007DD652 File Offset: 0x007DB852
		public IActorLookAtUnLockT AsIActorLookAtUnLock()
		{
			return this.As<IActorLookAtUnLockT>();
		}

		// Token: 0x0603A67E RID: 239230 RVA: 0x007DD65A File Offset: 0x007DB85A
		public static TActorLookAtDataUnion FromIActorLookAtUnLock(IActorLookAtUnLockT _iactorlookatunlock)
		{
			return new TActorLookAtDataUnion
			{
				Type = TActorLookAtData.IActorLookAtUnLock,
				Value = _iactorlookatunlock
			};
		}

		// Token: 0x0603A67F RID: 239231 RVA: 0x007DD670 File Offset: 0x007DB870
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
