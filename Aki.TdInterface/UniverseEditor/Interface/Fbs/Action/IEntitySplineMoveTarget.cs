using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020066EA RID: 26346
	public struct IEntitySplineMoveTarget : IFlatbufferObject
	{
		// Token: 0x1700C3C7 RID: 50119
		// (get) Token: 0x0602DCF3 RID: 187635 RVA: 0x00643C3B File Offset: 0x00641E3B
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602DCF4 RID: 187636 RVA: 0x00643C48 File Offset: 0x00641E48
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602DCF5 RID: 187637 RVA: 0x00643C50 File Offset: 0x00641E50
		public static IEntitySplineMoveTarget GetRootAsIEntitySplineMoveTarget(ByteBuffer _bb)
		{
			return IEntitySplineMoveTarget.GetRootAsIEntitySplineMoveTarget(_bb, default(IEntitySplineMoveTarget));
		}

		// Token: 0x0602DCF6 RID: 187638 RVA: 0x00643C6C File Offset: 0x00641E6C
		public static IEntitySplineMoveTarget GetRootAsIEntitySplineMoveTarget(ByteBuffer _bb, IEntitySplineMoveTarget obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602DCF7 RID: 187639 RVA: 0x00643C89 File Offset: 0x00641E89
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602DCF8 RID: 187640 RVA: 0x00643C98 File Offset: 0x00641E98
		public IEntitySplineMoveTarget __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C3C8 RID: 50120
		// (get) Token: 0x0602DCF9 RID: 187641 RVA: 0x00643CA8 File Offset: 0x00641EA8
		public ESplineMoveTargetType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ESplineMoveTargetType.Entity;
				}
				return (ESplineMoveTargetType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700C3C9 RID: 50121
		// (get) Token: 0x0602DCFA RID: 187642 RVA: 0x00643CE4 File Offset: 0x00641EE4
		public int EntityId
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700C3CA RID: 50122
		// (get) Token: 0x0602DCFB RID: 187643 RVA: 0x00643D20 File Offset: 0x00641F20
		public TMoveDriveMode MoveDriveModeType
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return TMoveDriveMode.NONE;
				}
				return (TMoveDriveMode)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602DCFC RID: 187644 RVA: 0x00643D5C File Offset: 0x00641F5C
		public TTable? MoveDriveMode<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0602DCFD RID: 187645 RVA: 0x00643DA4 File Offset: 0x00641FA4
		public IInputDrivenMoveDriveMode MoveDriveModeAsIInputDrivenMoveDriveMode()
		{
			return this.MoveDriveMode<IInputDrivenMoveDriveMode>().Value;
		}

		// Token: 0x0602DCFE RID: 187646 RVA: 0x00643DC0 File Offset: 0x00641FC0
		public IPositionDrivenMoveDriveMode MoveDriveModeAsIPositionDrivenMoveDriveMode()
		{
			return this.MoveDriveMode<IPositionDrivenMoveDriveMode>().Value;
		}

		// Token: 0x0602DCFF RID: 187647 RVA: 0x00643DDB File Offset: 0x00641FDB
		public static Offset<IEntitySplineMoveTarget> CreateIEntitySplineMoveTarget(FlatBufferBuilder builder, ESplineMoveTargetType Type = ESplineMoveTargetType.Entity, int EntityId = 0, TMoveDriveMode MoveDriveMode_type = TMoveDriveMode.NONE, int MoveDriveModeOffset = 0)
		{
			builder.StartTable(4);
			IEntitySplineMoveTarget.AddMoveDriveMode(builder, MoveDriveModeOffset);
			IEntitySplineMoveTarget.AddEntityId(builder, EntityId);
			IEntitySplineMoveTarget.AddMoveDriveModeType(builder, MoveDriveMode_type);
			IEntitySplineMoveTarget.AddType(builder, Type);
			return IEntitySplineMoveTarget.EndIEntitySplineMoveTarget(builder);
		}

		// Token: 0x0602DD00 RID: 187648 RVA: 0x00643E07 File Offset: 0x00642007
		public static void StartIEntitySplineMoveTarget(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0602DD01 RID: 187649 RVA: 0x00643E10 File Offset: 0x00642010
		public static void AddType(FlatBufferBuilder builder, ESplineMoveTargetType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602DD02 RID: 187650 RVA: 0x00643E1B File Offset: 0x0064201B
		public static void AddEntityId(FlatBufferBuilder builder, int entityId)
		{
			builder.AddInt(1, entityId, 0);
		}

		// Token: 0x0602DD03 RID: 187651 RVA: 0x00643E26 File Offset: 0x00642026
		public static void AddMoveDriveModeType(FlatBufferBuilder builder, TMoveDriveMode moveDriveModeType)
		{
			builder.AddByte(2, (byte)moveDriveModeType, 0);
		}

		// Token: 0x0602DD04 RID: 187652 RVA: 0x00643E31 File Offset: 0x00642031
		public static void AddMoveDriveMode(FlatBufferBuilder builder, int moveDriveModeOffset)
		{
			builder.AddOffset(3, moveDriveModeOffset, 0);
		}

		// Token: 0x0602DD05 RID: 187653 RVA: 0x00643E3C File Offset: 0x0064203C
		public static Offset<IEntitySplineMoveTarget> EndIEntitySplineMoveTarget(FlatBufferBuilder builder)
		{
			return new Offset<IEntitySplineMoveTarget>(builder.EndTable());
		}

		// Token: 0x0602DD06 RID: 187654 RVA: 0x00643E4C File Offset: 0x0064204C
		public IEntitySplineMoveTargetT UnPack()
		{
			IEntitySplineMoveTargetT entitySplineMoveTargetT = new IEntitySplineMoveTargetT();
			this.UnPackTo(entitySplineMoveTargetT);
			return entitySplineMoveTargetT;
		}

		// Token: 0x0602DD07 RID: 187655 RVA: 0x00643E68 File Offset: 0x00642068
		public void UnPackTo(IEntitySplineMoveTargetT _o)
		{
			_o.Type = this.Type;
			_o.EntityId = this.EntityId;
			_o.MoveDriveMode = new TMoveDriveModeUnion();
			_o.MoveDriveMode.Type = this.MoveDriveModeType;
			TMoveDriveMode moveDriveModeType = this.MoveDriveModeType;
			if (moveDriveModeType == TMoveDriveMode.IInputDrivenMoveDriveMode)
			{
				_o.MoveDriveMode.Value = ((this.MoveDriveMode<IInputDrivenMoveDriveMode>() != null) ? this.MoveDriveMode<IInputDrivenMoveDriveMode>().Value.UnPack() : null);
				return;
			}
			if (moveDriveModeType != TMoveDriveMode.IPositionDrivenMoveDriveMode)
			{
				return;
			}
			_o.MoveDriveMode.Value = ((this.MoveDriveMode<IPositionDrivenMoveDriveMode>() != null) ? this.MoveDriveMode<IPositionDrivenMoveDriveMode>().Value.UnPack() : null);
		}

		// Token: 0x0602DD08 RID: 187656 RVA: 0x00643F24 File Offset: 0x00642124
		public static Offset<IEntitySplineMoveTarget> Pack(FlatBufferBuilder builder, IEntitySplineMoveTargetT _o)
		{
			if (_o == null)
			{
				return default(Offset<IEntitySplineMoveTarget>);
			}
			TMoveDriveMode moveDriveMode_type = (_o.MoveDriveMode == null) ? TMoveDriveMode.NONE : _o.MoveDriveMode.Type;
			int moveDriveModeOffset = (_o.MoveDriveMode == null) ? 0 : TMoveDriveModeUnion.Pack(builder, _o.MoveDriveMode);
			return IEntitySplineMoveTarget.CreateIEntitySplineMoveTarget(builder, _o.Type, _o.EntityId, moveDriveMode_type, moveDriveModeOffset);
		}

		// Token: 0x04010DBD RID: 69053
		private Table __p;
	}
}
