using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006305 RID: 25349
	public struct IChangeLiftTarget : IFlatbufferObject
	{
		// Token: 0x1700BD36 RID: 48438
		// (get) Token: 0x0602BD4B RID: 179531 RVA: 0x00607230 File Offset: 0x00605430
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602BD4C RID: 179532 RVA: 0x0060723D File Offset: 0x0060543D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602BD4D RID: 179533 RVA: 0x00607244 File Offset: 0x00605444
		public static IChangeLiftTarget GetRootAsIChangeLiftTarget(ByteBuffer _bb)
		{
			return IChangeLiftTarget.GetRootAsIChangeLiftTarget(_bb, default(IChangeLiftTarget));
		}

		// Token: 0x0602BD4E RID: 179534 RVA: 0x00607260 File Offset: 0x00605460
		public static IChangeLiftTarget GetRootAsIChangeLiftTarget(ByteBuffer _bb, IChangeLiftTarget obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602BD4F RID: 179535 RVA: 0x0060727D File Offset: 0x0060547D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602BD50 RID: 179536 RVA: 0x0060728C File Offset: 0x0060548C
		public IChangeLiftTarget __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BD37 RID: 48439
		// (get) Token: 0x0602BD51 RID: 179537 RVA: 0x0060729C File Offset: 0x0060549C
		public bool IsSelf
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700BD38 RID: 48440
		// (get) Token: 0x0602BD52 RID: 179538 RVA: 0x006072DC File Offset: 0x006054DC
		public TLiftMoveType MoveTypeType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return TLiftMoveType.NONE;
				}
				return (TLiftMoveType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602BD53 RID: 179539 RVA: 0x00607318 File Offset: 0x00605518
		public TTable? MoveType<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0602BD54 RID: 179540 RVA: 0x0060735C File Offset: 0x0060555C
		public ILiftMoveTypeCircular MoveTypeAsILiftMoveTypeCircular()
		{
			return this.MoveType<ILiftMoveTypeCircular>().Value;
		}

		// Token: 0x0602BD55 RID: 179541 RVA: 0x00607378 File Offset: 0x00605578
		public ILiftMoveTypeCustomSpeed MoveTypeAsILiftMoveTypeCustomSpeed()
		{
			return this.MoveType<ILiftMoveTypeCustomSpeed>().Value;
		}

		// Token: 0x0602BD56 RID: 179542 RVA: 0x00607394 File Offset: 0x00605594
		public ILiftMoveTypeDefault MoveTypeAsILiftMoveTypeDefault()
		{
			return this.MoveType<ILiftMoveTypeDefault>().Value;
		}

		// Token: 0x0602BD57 RID: 179543 RVA: 0x006073B0 File Offset: 0x006055B0
		public ILiftMoveTypeTeleport MoveTypeAsILiftMoveTypeTeleport()
		{
			return this.MoveType<ILiftMoveTypeTeleport>().Value;
		}

		// Token: 0x1700BD39 RID: 48441
		// (get) Token: 0x0602BD58 RID: 179544 RVA: 0x006073CC File Offset: 0x006055CC
		public int EntityId
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700BD3A RID: 48442
		// (get) Token: 0x0602BD59 RID: 179545 RVA: 0x0060740C File Offset: 0x0060560C
		public int Location
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700BD3B RID: 48443
		// (get) Token: 0x0602BD5A RID: 179546 RVA: 0x0060744C File Offset: 0x0060564C
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602BD5B RID: 179547 RVA: 0x00607489 File Offset: 0x00605689
		public static Offset<IChangeLiftTarget> CreateIChangeLiftTarget(FlatBufferBuilder builder, bool IsSelf = false, TLiftMoveType MoveType_type = TLiftMoveType.NONE, int MoveTypeOffset = 0, int EntityId = 0, int Location = 0, byte NullMask = 0)
		{
			builder.StartTable(6);
			IChangeLiftTarget.AddLocation(builder, Location);
			IChangeLiftTarget.AddEntityId(builder, EntityId);
			IChangeLiftTarget.AddMoveType(builder, MoveTypeOffset);
			IChangeLiftTarget.AddNullMask(builder, NullMask);
			IChangeLiftTarget.AddMoveTypeType(builder, MoveType_type);
			IChangeLiftTarget.AddIsSelf(builder, IsSelf);
			return IChangeLiftTarget.EndIChangeLiftTarget(builder);
		}

		// Token: 0x0602BD5C RID: 179548 RVA: 0x006074C5 File Offset: 0x006056C5
		public static void StartIChangeLiftTarget(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x0602BD5D RID: 179549 RVA: 0x006074CE File Offset: 0x006056CE
		public static void AddIsSelf(FlatBufferBuilder builder, bool isSelf)
		{
			builder.AddBool(0, isSelf, false);
		}

		// Token: 0x0602BD5E RID: 179550 RVA: 0x006074D9 File Offset: 0x006056D9
		public static void AddMoveTypeType(FlatBufferBuilder builder, TLiftMoveType moveTypeType)
		{
			builder.AddByte(1, (byte)moveTypeType, 0);
		}

		// Token: 0x0602BD5F RID: 179551 RVA: 0x006074E4 File Offset: 0x006056E4
		public static void AddMoveType(FlatBufferBuilder builder, int moveTypeOffset)
		{
			builder.AddOffset(2, moveTypeOffset, 0);
		}

		// Token: 0x0602BD60 RID: 179552 RVA: 0x006074EF File Offset: 0x006056EF
		public static void AddEntityId(FlatBufferBuilder builder, int entityId)
		{
			builder.AddInt(3, entityId, 0);
		}

		// Token: 0x0602BD61 RID: 179553 RVA: 0x006074FA File Offset: 0x006056FA
		public static void AddLocation(FlatBufferBuilder builder, int location)
		{
			builder.AddInt(4, location, 0);
		}

		// Token: 0x0602BD62 RID: 179554 RVA: 0x00607505 File Offset: 0x00605705
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(5, nullMask, 0);
		}

		// Token: 0x0602BD63 RID: 179555 RVA: 0x00607510 File Offset: 0x00605710
		public static Offset<IChangeLiftTarget> EndIChangeLiftTarget(FlatBufferBuilder builder)
		{
			return new Offset<IChangeLiftTarget>(builder.EndTable());
		}

		// Token: 0x0602BD64 RID: 179556 RVA: 0x00607520 File Offset: 0x00605720
		public IChangeLiftTargetT UnPack()
		{
			IChangeLiftTargetT changeLiftTargetT = new IChangeLiftTargetT();
			this.UnPackTo(changeLiftTargetT);
			return changeLiftTargetT;
		}

		// Token: 0x0602BD65 RID: 179557 RVA: 0x0060753C File Offset: 0x0060573C
		public void UnPackTo(IChangeLiftTargetT _o)
		{
			_o.IsSelf = this.IsSelf;
			_o.MoveType = new TLiftMoveTypeUnion();
			_o.MoveType.Type = this.MoveTypeType;
			switch (this.MoveTypeType)
			{
			case TLiftMoveType.ILiftMoveTypeCircular:
				_o.MoveType.Value = ((this.MoveType<ILiftMoveTypeCircular>() != null) ? this.MoveType<ILiftMoveTypeCircular>().Value.UnPack() : null);
				break;
			case TLiftMoveType.ILiftMoveTypeCustomSpeed:
				_o.MoveType.Value = ((this.MoveType<ILiftMoveTypeCustomSpeed>() != null) ? this.MoveType<ILiftMoveTypeCustomSpeed>().Value.UnPack() : null);
				break;
			case TLiftMoveType.ILiftMoveTypeDefault:
				_o.MoveType.Value = ((this.MoveType<ILiftMoveTypeDefault>() != null) ? this.MoveType<ILiftMoveTypeDefault>().Value.UnPack() : null);
				break;
			case TLiftMoveType.ILiftMoveTypeTeleport:
				_o.MoveType.Value = ((this.MoveType<ILiftMoveTypeTeleport>() != null) ? this.MoveType<ILiftMoveTypeTeleport>().Value.UnPack() : null);
				break;
			}
			_o.EntityId = this.EntityId;
			_o.Location = this.Location;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602BD66 RID: 179558 RVA: 0x0060769C File Offset: 0x0060589C
		public static Offset<IChangeLiftTarget> Pack(FlatBufferBuilder builder, IChangeLiftTargetT _o)
		{
			if (_o == null)
			{
				return default(Offset<IChangeLiftTarget>);
			}
			TLiftMoveType moveType_type = (_o.MoveType == null) ? TLiftMoveType.NONE : _o.MoveType.Type;
			int moveTypeOffset = (_o.MoveType == null) ? 0 : TLiftMoveTypeUnion.Pack(builder, _o.MoveType);
			return IChangeLiftTarget.CreateIChangeLiftTarget(builder, _o.IsSelf, moveType_type, moveTypeOffset, _o.EntityId, _o.Location, _o.NullMask);
		}

		// Token: 0x040108C3 RID: 67779
		private Table __p;
	}
}
