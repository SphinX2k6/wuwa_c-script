using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200673A RID: 26426
	public class IActorLookAtData_UnionUnion
	{
		// Token: 0x1700C01B RID: 49179
		// (get) Token: 0x0602CC4F RID: 183375 RVA: 0x0061FE89 File Offset: 0x0061E089
		// (set) Token: 0x0602CC50 RID: 183376 RVA: 0x0061FE91 File Offset: 0x0061E091
		public IActorLookAtData_Union Type { get; set; }

		// Token: 0x1700C01C RID: 49180
		// (get) Token: 0x0602CC51 RID: 183377 RVA: 0x0061FE9A File Offset: 0x0061E09A
		// (set) Token: 0x0602CC52 RID: 183378 RVA: 0x0061FEA2 File Offset: 0x0061E0A2
		public object Value { get; set; }

		// Token: 0x0602CC53 RID: 183379 RVA: 0x0061FEAB File Offset: 0x0061E0AB
		public IActorLookAtData_UnionUnion()
		{
			this.Type = IActorLookAtData_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0602CC54 RID: 183380 RVA: 0x0061FEC1 File Offset: 0x0061E0C1
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602CC55 RID: 183381 RVA: 0x0061FED3 File Offset: 0x0061E0D3
		public IActorLookAtDataT AsIActorLookAtData()
		{
			return this.As<IActorLookAtDataT>();
		}

		// Token: 0x0602CC56 RID: 183382 RVA: 0x0061FEDB File Offset: 0x0061E0DB
		public static IActorLookAtData_UnionUnion FromIActorLookAtData(IActorLookAtDataT _iactorlookatdata)
		{
			return new IActorLookAtData_UnionUnion
			{
				Type = IActorLookAtData_Union.IActorLookAtData,
				Value = _iactorlookatdata
			};
		}

		// Token: 0x0602CC57 RID: 183383 RVA: 0x0061FEF0 File Offset: 0x0061E0F0
		public IActorLookAtLockableT AsIActorLookAtLockable()
		{
			return this.As<IActorLookAtLockableT>();
		}

		// Token: 0x0602CC58 RID: 183384 RVA: 0x0061FEF8 File Offset: 0x0061E0F8
		public static IActorLookAtData_UnionUnion FromIActorLookAtLockable(IActorLookAtLockableT _iactorlookatlockable)
		{
			return new IActorLookAtData_UnionUnion
			{
				Type = IActorLookAtData_Union.IActorLookAtLockable,
				Value = _iactorlookatlockable
			};
		}

		// Token: 0x0602CC59 RID: 183385 RVA: 0x0061FF0D File Offset: 0x0061E10D
		public IActorLookAtTalkerDataT AsIActorLookAtTalkerData()
		{
			return this.As<IActorLookAtTalkerDataT>();
		}

		// Token: 0x0602CC5A RID: 183386 RVA: 0x0061FF15 File Offset: 0x0061E115
		public static IActorLookAtData_UnionUnion FromIActorLookAtTalkerData(IActorLookAtTalkerDataT _iactorlookattalkerdata)
		{
			return new IActorLookAtData_UnionUnion
			{
				Type = IActorLookAtData_Union.IActorLookAtTalkerData,
				Value = _iactorlookattalkerdata
			};
		}

		// Token: 0x0602CC5B RID: 183387 RVA: 0x0061FF2A File Offset: 0x0061E12A
		public IActorLookAtEmptyDataT AsIActorLookAtEmptyData()
		{
			return this.As<IActorLookAtEmptyDataT>();
		}

		// Token: 0x0602CC5C RID: 183388 RVA: 0x0061FF32 File Offset: 0x0061E132
		public static IActorLookAtData_UnionUnion FromIActorLookAtEmptyData(IActorLookAtEmptyDataT _iactorlookatemptydata)
		{
			return new IActorLookAtData_UnionUnion
			{
				Type = IActorLookAtData_Union.IActorLookAtEmptyData,
				Value = _iactorlookatemptydata
			};
		}

		// Token: 0x0602CC5D RID: 183389 RVA: 0x0061FF47 File Offset: 0x0061E147
		public IActorLookAtEntityDataT AsIActorLookAtEntityData()
		{
			return this.As<IActorLookAtEntityDataT>();
		}

		// Token: 0x0602CC5E RID: 183390 RVA: 0x0061FF4F File Offset: 0x0061E14F
		public static IActorLookAtData_UnionUnion FromIActorLookAtEntityData(IActorLookAtEntityDataT _iactorlookatentitydata)
		{
			return new IActorLookAtData_UnionUnion
			{
				Type = IActorLookAtData_Union.IActorLookAtEntityData,
				Value = _iactorlookatentitydata
			};
		}

		// Token: 0x0602CC5F RID: 183391 RVA: 0x0061FF64 File Offset: 0x0061E164
		public IActorLookAtPositionDataT AsIActorLookAtPositionData()
		{
			return this.As<IActorLookAtPositionDataT>();
		}

		// Token: 0x0602CC60 RID: 183392 RVA: 0x0061FF6C File Offset: 0x0061E16C
		public static IActorLookAtData_UnionUnion FromIActorLookAtPositionData(IActorLookAtPositionDataT _iactorlookatpositiondata)
		{
			return new IActorLookAtData_UnionUnion
			{
				Type = IActorLookAtData_Union.IActorLookAtPositionData,
				Value = _iactorlookatpositiondata
			};
		}

		// Token: 0x0602CC61 RID: 183393 RVA: 0x0061FF81 File Offset: 0x0061E181
		public IActorLookAtPlayerDataT AsIActorLookAtPlayerData()
		{
			return this.As<IActorLookAtPlayerDataT>();
		}

		// Token: 0x0602CC62 RID: 183394 RVA: 0x0061FF89 File Offset: 0x0061E189
		public static IActorLookAtData_UnionUnion FromIActorLookAtPlayerData(IActorLookAtPlayerDataT _iactorlookatplayerdata)
		{
			return new IActorLookAtData_UnionUnion
			{
				Type = IActorLookAtData_Union.IActorLookAtPlayerData,
				Value = _iactorlookatplayerdata
			};
		}

		// Token: 0x0602CC63 RID: 183395 RVA: 0x0061FF9E File Offset: 0x0061E19E
		public IActorLookAtOtherActorT AsIActorLookAtOtherActor()
		{
			return this.As<IActorLookAtOtherActorT>();
		}

		// Token: 0x0602CC64 RID: 183396 RVA: 0x0061FFA6 File Offset: 0x0061E1A6
		public static IActorLookAtData_UnionUnion FromIActorLookAtOtherActor(IActorLookAtOtherActorT _iactorlookatotheractor)
		{
			return new IActorLookAtData_UnionUnion
			{
				Type = IActorLookAtData_Union.IActorLookAtOtherActor,
				Value = _iactorlookatotheractor
			};
		}

		// Token: 0x0602CC65 RID: 183397 RVA: 0x0061FFBB File Offset: 0x0061E1BB
		public IActorLookAtUnLockT AsIActorLookAtUnLock()
		{
			return this.As<IActorLookAtUnLockT>();
		}

		// Token: 0x0602CC66 RID: 183398 RVA: 0x0061FFC3 File Offset: 0x0061E1C3
		public static IActorLookAtData_UnionUnion FromIActorLookAtUnLock(IActorLookAtUnLockT _iactorlookatunlock)
		{
			return new IActorLookAtData_UnionUnion
			{
				Type = IActorLookAtData_Union.IActorLookAtUnLock,
				Value = _iactorlookatunlock
			};
		}

		// Token: 0x0602CC67 RID: 183399 RVA: 0x0061FFDC File Offset: 0x0061E1DC
		public static int Pack(FlatBufferBuilder builder, IActorLookAtData_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IActorLookAtData_Union.IActorLookAtData:
				return IActorLookAtData.Pack(builder, _o.AsIActorLookAtData()).Value;
			case IActorLookAtData_Union.IActorLookAtLockable:
				return IActorLookAtLockable.Pack(builder, _o.AsIActorLookAtLockable()).Value;
			case IActorLookAtData_Union.IActorLookAtTalkerData:
				return IActorLookAtTalkerData.Pack(builder, _o.AsIActorLookAtTalkerData()).Value;
			case IActorLookAtData_Union.IActorLookAtEmptyData:
				return IActorLookAtEmptyData.Pack(builder, _o.AsIActorLookAtEmptyData()).Value;
			case IActorLookAtData_Union.IActorLookAtEntityData:
				return IActorLookAtEntityData.Pack(builder, _o.AsIActorLookAtEntityData()).Value;
			case IActorLookAtData_Union.IActorLookAtPositionData:
				return IActorLookAtPositionData.Pack(builder, _o.AsIActorLookAtPositionData()).Value;
			case IActorLookAtData_Union.IActorLookAtPlayerData:
				return IActorLookAtPlayerData.Pack(builder, _o.AsIActorLookAtPlayerData()).Value;
			case IActorLookAtData_Union.IActorLookAtOtherActor:
				return IActorLookAtOtherActor.Pack(builder, _o.AsIActorLookAtOtherActor()).Value;
			case IActorLookAtData_Union.IActorLookAtUnLock:
				return IActorLookAtUnLock.Pack(builder, _o.AsIActorLookAtUnLock()).Value;
			default:
				return 0;
			}
		}
	}
}
