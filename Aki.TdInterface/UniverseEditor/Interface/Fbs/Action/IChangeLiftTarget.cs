using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006976 RID: 26998
	public struct IChangeLiftTarget : IFlatbufferObject
	{
		// Token: 0x1700C6C0 RID: 50880
		// (get) Token: 0x0602E4B4 RID: 189620 RVA: 0x0065223C File Offset: 0x0065043C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602E4B5 RID: 189621 RVA: 0x00652249 File Offset: 0x00650449
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602E4B6 RID: 189622 RVA: 0x00652250 File Offset: 0x00650450
		public static IChangeLiftTarget GetRootAsIChangeLiftTarget(ByteBuffer _bb)
		{
			return IChangeLiftTarget.GetRootAsIChangeLiftTarget(_bb, default(IChangeLiftTarget));
		}

		// Token: 0x0602E4B7 RID: 189623 RVA: 0x0065226C File Offset: 0x0065046C
		public static IChangeLiftTarget GetRootAsIChangeLiftTarget(ByteBuffer _bb, IChangeLiftTarget obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602E4B8 RID: 189624 RVA: 0x00652289 File Offset: 0x00650489
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602E4B9 RID: 189625 RVA: 0x00652298 File Offset: 0x00650498
		public IChangeLiftTarget __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C6C1 RID: 50881
		// (get) Token: 0x0602E4BA RID: 189626 RVA: 0x006522A8 File Offset: 0x006504A8
		public bool IsSelf
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700C6C2 RID: 50882
		// (get) Token: 0x0602E4BB RID: 189627 RVA: 0x006522E8 File Offset: 0x006504E8
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

		// Token: 0x0602E4BC RID: 189628 RVA: 0x00652324 File Offset: 0x00650524
		public TTable? MoveType<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0602E4BD RID: 189629 RVA: 0x00652368 File Offset: 0x00650568
		public ILiftMoveTypeCircular MoveTypeAsILiftMoveTypeCircular()
		{
			return this.MoveType<ILiftMoveTypeCircular>().Value;
		}

		// Token: 0x0602E4BE RID: 189630 RVA: 0x00652384 File Offset: 0x00650584
		public ILiftMoveTypeCustomSpeed MoveTypeAsILiftMoveTypeCustomSpeed()
		{
			return this.MoveType<ILiftMoveTypeCustomSpeed>().Value;
		}

		// Token: 0x0602E4BF RID: 189631 RVA: 0x006523A0 File Offset: 0x006505A0
		public ILiftMoveTypeDefault MoveTypeAsILiftMoveTypeDefault()
		{
			return this.MoveType<ILiftMoveTypeDefault>().Value;
		}

		// Token: 0x0602E4C0 RID: 189632 RVA: 0x006523BC File Offset: 0x006505BC
		public ILiftMoveTypeTeleport MoveTypeAsILiftMoveTypeTeleport()
		{
			return this.MoveType<ILiftMoveTypeTeleport>().Value;
		}

		// Token: 0x1700C6C3 RID: 50883
		// (get) Token: 0x0602E4C1 RID: 189633 RVA: 0x006523D8 File Offset: 0x006505D8
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

		// Token: 0x1700C6C4 RID: 50884
		// (get) Token: 0x0602E4C2 RID: 189634 RVA: 0x00652418 File Offset: 0x00650618
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

		// Token: 0x1700C6C5 RID: 50885
		// (get) Token: 0x0602E4C3 RID: 189635 RVA: 0x00652458 File Offset: 0x00650658
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

		// Token: 0x0602E4C4 RID: 189636 RVA: 0x00652495 File Offset: 0x00650695
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

		// Token: 0x0602E4C5 RID: 189637 RVA: 0x006524D1 File Offset: 0x006506D1
		public static void StartIChangeLiftTarget(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x0602E4C6 RID: 189638 RVA: 0x006524DA File Offset: 0x006506DA
		public static void AddIsSelf(FlatBufferBuilder builder, bool isSelf)
		{
			builder.AddBool(0, isSelf, false);
		}

		// Token: 0x0602E4C7 RID: 189639 RVA: 0x006524E5 File Offset: 0x006506E5
		public static void AddMoveTypeType(FlatBufferBuilder builder, TLiftMoveType moveTypeType)
		{
			builder.AddByte(1, (byte)moveTypeType, 0);
		}

		// Token: 0x0602E4C8 RID: 189640 RVA: 0x006524F0 File Offset: 0x006506F0
		public static void AddMoveType(FlatBufferBuilder builder, int moveTypeOffset)
		{
			builder.AddOffset(2, moveTypeOffset, 0);
		}

		// Token: 0x0602E4C9 RID: 189641 RVA: 0x006524FB File Offset: 0x006506FB
		public static void AddEntityId(FlatBufferBuilder builder, int entityId)
		{
			builder.AddInt(3, entityId, 0);
		}

		// Token: 0x0602E4CA RID: 189642 RVA: 0x00652506 File Offset: 0x00650706
		public static void AddLocation(FlatBufferBuilder builder, int location)
		{
			builder.AddInt(4, location, 0);
		}

		// Token: 0x0602E4CB RID: 189643 RVA: 0x00652511 File Offset: 0x00650711
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(5, nullMask, 0);
		}

		// Token: 0x0602E4CC RID: 189644 RVA: 0x0065251C File Offset: 0x0065071C
		public static Offset<IChangeLiftTarget> EndIChangeLiftTarget(FlatBufferBuilder builder)
		{
			return new Offset<IChangeLiftTarget>(builder.EndTable());
		}

		// Token: 0x0602E4CD RID: 189645 RVA: 0x0065252C File Offset: 0x0065072C
		public IChangeLiftTargetT UnPack()
		{
			IChangeLiftTargetT changeLiftTargetT = new IChangeLiftTargetT();
			this.UnPackTo(changeLiftTargetT);
			return changeLiftTargetT;
		}

		// Token: 0x0602E4CE RID: 189646 RVA: 0x00652548 File Offset: 0x00650748
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

		// Token: 0x0602E4CF RID: 189647 RVA: 0x006526A8 File Offset: 0x006508A8
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

		// Token: 0x040116D9 RID: 71385
		private Table __p;
	}
}
