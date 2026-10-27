using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006D02 RID: 27906
	public struct IPlayerMoveToPoint : IFlatbufferObject
	{
		// Token: 0x1700CFD0 RID: 53200
		// (get) Token: 0x06031354 RID: 201556 RVA: 0x006ACF09 File Offset: 0x006AB109
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06031355 RID: 201557 RVA: 0x006ACF16 File Offset: 0x006AB116
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06031356 RID: 201558 RVA: 0x006ACF20 File Offset: 0x006AB120
		public static IPlayerMoveToPoint GetRootAsIPlayerMoveToPoint(ByteBuffer _bb)
		{
			return IPlayerMoveToPoint.GetRootAsIPlayerMoveToPoint(_bb, default(IPlayerMoveToPoint));
		}

		// Token: 0x06031357 RID: 201559 RVA: 0x006ACF3C File Offset: 0x006AB13C
		public static IPlayerMoveToPoint GetRootAsIPlayerMoveToPoint(ByteBuffer _bb, IPlayerMoveToPoint obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06031358 RID: 201560 RVA: 0x006ACF59 File Offset: 0x006AB159
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06031359 RID: 201561 RVA: 0x006ACF68 File Offset: 0x006AB168
		public IPlayerMoveToPoint __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CFD1 RID: 53201
		// (get) Token: 0x0603135A RID: 201562 RVA: 0x006ACF78 File Offset: 0x006AB178
		public IVectorInfo? Pos
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return new IVectorInfo?(default(IVectorInfo).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700CFD2 RID: 53202
		// (get) Token: 0x0603135B RID: 201563 RVA: 0x006ACFD8 File Offset: 0x006AB1D8
		public EMoveToPointType MoveType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return EMoveToPointType.Straight;
				}
				return (EMoveToPointType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700CFD3 RID: 53203
		// (get) Token: 0x0603135C RID: 201564 RVA: 0x006AD014 File Offset: 0x006AB214
		public bool IsExact
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700CFD4 RID: 53204
		// (get) Token: 0x0603135D RID: 201565 RVA: 0x006AD054 File Offset: 0x006AB254
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0603135E RID: 201566 RVA: 0x006AD091 File Offset: 0x006AB291
		public static Offset<IPlayerMoveToPoint> CreateIPlayerMoveToPoint(FlatBufferBuilder builder, Offset<IVectorInfo> PosOffset = default(Offset<IVectorInfo>), EMoveToPointType MoveType = EMoveToPointType.Straight, bool IsExact = false, byte NullMask = 0)
		{
			builder.StartTable(4);
			IPlayerMoveToPoint.AddPos(builder, PosOffset);
			IPlayerMoveToPoint.AddNullMask(builder, NullMask);
			IPlayerMoveToPoint.AddIsExact(builder, IsExact);
			IPlayerMoveToPoint.AddMoveType(builder, MoveType);
			return IPlayerMoveToPoint.EndIPlayerMoveToPoint(builder);
		}

		// Token: 0x0603135F RID: 201567 RVA: 0x006AD0BD File Offset: 0x006AB2BD
		public static void StartIPlayerMoveToPoint(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06031360 RID: 201568 RVA: 0x006AD0C6 File Offset: 0x006AB2C6
		public static void AddPos(FlatBufferBuilder builder, Offset<IVectorInfo> posOffset)
		{
			builder.AddOffset(0, posOffset.Value, 0);
		}

		// Token: 0x06031361 RID: 201569 RVA: 0x006AD0D6 File Offset: 0x006AB2D6
		public static void AddMoveType(FlatBufferBuilder builder, EMoveToPointType moveType)
		{
			builder.AddByte(1, (byte)moveType, 0);
		}

		// Token: 0x06031362 RID: 201570 RVA: 0x006AD0E1 File Offset: 0x006AB2E1
		public static void AddIsExact(FlatBufferBuilder builder, bool isExact)
		{
			builder.AddBool(2, isExact, false);
		}

		// Token: 0x06031363 RID: 201571 RVA: 0x006AD0EC File Offset: 0x006AB2EC
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x06031364 RID: 201572 RVA: 0x006AD0F7 File Offset: 0x006AB2F7
		public static Offset<IPlayerMoveToPoint> EndIPlayerMoveToPoint(FlatBufferBuilder builder)
		{
			return new Offset<IPlayerMoveToPoint>(builder.EndTable());
		}

		// Token: 0x06031365 RID: 201573 RVA: 0x006AD104 File Offset: 0x006AB304
		public IPlayerMoveToPointT UnPack()
		{
			IPlayerMoveToPointT playerMoveToPointT = new IPlayerMoveToPointT();
			this.UnPackTo(playerMoveToPointT);
			return playerMoveToPointT;
		}

		// Token: 0x06031366 RID: 201574 RVA: 0x006AD120 File Offset: 0x006AB320
		public void UnPackTo(IPlayerMoveToPointT _o)
		{
			_o.Pos = ((this.Pos != null) ? this.Pos.Value.UnPack() : null);
			_o.MoveType = this.MoveType;
			_o.IsExact = this.IsExact;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06031367 RID: 201575 RVA: 0x006AD180 File Offset: 0x006AB380
		public static Offset<IPlayerMoveToPoint> Pack(FlatBufferBuilder builder, IPlayerMoveToPointT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPlayerMoveToPoint>);
			}
			Offset<IVectorInfo> posOffset = (_o.Pos == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.Pos);
			return IPlayerMoveToPoint.CreateIPlayerMoveToPoint(builder, posOffset, _o.MoveType, _o.IsExact, _o.NullMask);
		}

		// Token: 0x0401167E RID: 71294
		private Table __p;
	}
}
