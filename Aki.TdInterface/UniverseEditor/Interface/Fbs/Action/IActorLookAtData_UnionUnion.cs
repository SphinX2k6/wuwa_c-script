using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020060D8 RID: 24792
	public class IActorLookAtData_UnionUnion
	{
		// Token: 0x1700B6B0 RID: 46768
		// (get) Token: 0x0602A56E RID: 173422 RVA: 0x005D5EE1 File Offset: 0x005D40E1
		// (set) Token: 0x0602A56F RID: 173423 RVA: 0x005D5EE9 File Offset: 0x005D40E9
		public IActorLookAtData_Union Type { get; set; }

		// Token: 0x1700B6B1 RID: 46769
		// (get) Token: 0x0602A570 RID: 173424 RVA: 0x005D5EF2 File Offset: 0x005D40F2
		// (set) Token: 0x0602A571 RID: 173425 RVA: 0x005D5EFA File Offset: 0x005D40FA
		public object Value { get; set; }

		// Token: 0x0602A572 RID: 173426 RVA: 0x005D5F03 File Offset: 0x005D4103
		public IActorLookAtData_UnionUnion()
		{
			this.Type = IActorLookAtData_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0602A573 RID: 173427 RVA: 0x005D5F19 File Offset: 0x005D4119
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602A574 RID: 173428 RVA: 0x005D5F2B File Offset: 0x005D412B
		public IActorLookAtDataT AsIActorLookAtData()
		{
			return this.As<IActorLookAtDataT>();
		}

		// Token: 0x0602A575 RID: 173429 RVA: 0x005D5F33 File Offset: 0x005D4133
		public static IActorLookAtData_UnionUnion FromIActorLookAtData(IActorLookAtDataT _iactorlookatdata)
		{
			return new IActorLookAtData_UnionUnion
			{
				Type = IActorLookAtData_Union.IActorLookAtData,
				Value = _iactorlookatdata
			};
		}

		// Token: 0x0602A576 RID: 173430 RVA: 0x005D5F48 File Offset: 0x005D4148
		public IActorLookAtLockableT AsIActorLookAtLockable()
		{
			return this.As<IActorLookAtLockableT>();
		}

		// Token: 0x0602A577 RID: 173431 RVA: 0x005D5F50 File Offset: 0x005D4150
		public static IActorLookAtData_UnionUnion FromIActorLookAtLockable(IActorLookAtLockableT _iactorlookatlockable)
		{
			return new IActorLookAtData_UnionUnion
			{
				Type = IActorLookAtData_Union.IActorLookAtLockable,
				Value = _iactorlookatlockable
			};
		}

		// Token: 0x0602A578 RID: 173432 RVA: 0x005D5F65 File Offset: 0x005D4165
		public IActorLookAtTalkerDataT AsIActorLookAtTalkerData()
		{
			return this.As<IActorLookAtTalkerDataT>();
		}

		// Token: 0x0602A579 RID: 173433 RVA: 0x005D5F6D File Offset: 0x005D416D
		public static IActorLookAtData_UnionUnion FromIActorLookAtTalkerData(IActorLookAtTalkerDataT _iactorlookattalkerdata)
		{
			return new IActorLookAtData_UnionUnion
			{
				Type = IActorLookAtData_Union.IActorLookAtTalkerData,
				Value = _iactorlookattalkerdata
			};
		}

		// Token: 0x0602A57A RID: 173434 RVA: 0x005D5F82 File Offset: 0x005D4182
		public IActorLookAtEmptyDataT AsIActorLookAtEmptyData()
		{
			return this.As<IActorLookAtEmptyDataT>();
		}

		// Token: 0x0602A57B RID: 173435 RVA: 0x005D5F8A File Offset: 0x005D418A
		public static IActorLookAtData_UnionUnion FromIActorLookAtEmptyData(IActorLookAtEmptyDataT _iactorlookatemptydata)
		{
			return new IActorLookAtData_UnionUnion
			{
				Type = IActorLookAtData_Union.IActorLookAtEmptyData,
				Value = _iactorlookatemptydata
			};
		}

		// Token: 0x0602A57C RID: 173436 RVA: 0x005D5F9F File Offset: 0x005D419F
		public IActorLookAtEntityDataT AsIActorLookAtEntityData()
		{
			return this.As<IActorLookAtEntityDataT>();
		}

		// Token: 0x0602A57D RID: 173437 RVA: 0x005D5FA7 File Offset: 0x005D41A7
		public static IActorLookAtData_UnionUnion FromIActorLookAtEntityData(IActorLookAtEntityDataT _iactorlookatentitydata)
		{
			return new IActorLookAtData_UnionUnion
			{
				Type = IActorLookAtData_Union.IActorLookAtEntityData,
				Value = _iactorlookatentitydata
			};
		}

		// Token: 0x0602A57E RID: 173438 RVA: 0x005D5FBC File Offset: 0x005D41BC
		public IActorLookAtPositionDataT AsIActorLookAtPositionData()
		{
			return this.As<IActorLookAtPositionDataT>();
		}

		// Token: 0x0602A57F RID: 173439 RVA: 0x005D5FC4 File Offset: 0x005D41C4
		public static IActorLookAtData_UnionUnion FromIActorLookAtPositionData(IActorLookAtPositionDataT _iactorlookatpositiondata)
		{
			return new IActorLookAtData_UnionUnion
			{
				Type = IActorLookAtData_Union.IActorLookAtPositionData,
				Value = _iactorlookatpositiondata
			};
		}

		// Token: 0x0602A580 RID: 173440 RVA: 0x005D5FD9 File Offset: 0x005D41D9
		public IActorLookAtPlayerDataT AsIActorLookAtPlayerData()
		{
			return this.As<IActorLookAtPlayerDataT>();
		}

		// Token: 0x0602A581 RID: 173441 RVA: 0x005D5FE1 File Offset: 0x005D41E1
		public static IActorLookAtData_UnionUnion FromIActorLookAtPlayerData(IActorLookAtPlayerDataT _iactorlookatplayerdata)
		{
			return new IActorLookAtData_UnionUnion
			{
				Type = IActorLookAtData_Union.IActorLookAtPlayerData,
				Value = _iactorlookatplayerdata
			};
		}

		// Token: 0x0602A582 RID: 173442 RVA: 0x005D5FF6 File Offset: 0x005D41F6
		public IActorLookAtOtherActorT AsIActorLookAtOtherActor()
		{
			return this.As<IActorLookAtOtherActorT>();
		}

		// Token: 0x0602A583 RID: 173443 RVA: 0x005D5FFE File Offset: 0x005D41FE
		public static IActorLookAtData_UnionUnion FromIActorLookAtOtherActor(IActorLookAtOtherActorT _iactorlookatotheractor)
		{
			return new IActorLookAtData_UnionUnion
			{
				Type = IActorLookAtData_Union.IActorLookAtOtherActor,
				Value = _iactorlookatotheractor
			};
		}

		// Token: 0x0602A584 RID: 173444 RVA: 0x005D6013 File Offset: 0x005D4213
		public IActorLookAtUnLockT AsIActorLookAtUnLock()
		{
			return this.As<IActorLookAtUnLockT>();
		}

		// Token: 0x0602A585 RID: 173445 RVA: 0x005D601B File Offset: 0x005D421B
		public static IActorLookAtData_UnionUnion FromIActorLookAtUnLock(IActorLookAtUnLockT _iactorlookatunlock)
		{
			return new IActorLookAtData_UnionUnion
			{
				Type = IActorLookAtData_Union.IActorLookAtUnLock,
				Value = _iactorlookatunlock
			};
		}

		// Token: 0x0602A586 RID: 173446 RVA: 0x005D6034 File Offset: 0x005D4234
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
