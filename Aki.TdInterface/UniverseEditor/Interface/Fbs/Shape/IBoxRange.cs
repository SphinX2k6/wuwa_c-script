using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Shape
{
	// Token: 0x02003BEF RID: 15343
	public struct IBoxRange : IFlatbufferObject
	{
		// Token: 0x17006949 RID: 26953
		// (get) Token: 0x0601519F RID: 86431 RVA: 0x0030EB40 File Offset: 0x0030CD40
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060151A0 RID: 86432 RVA: 0x0030EB4D File Offset: 0x0030CD4D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060151A1 RID: 86433 RVA: 0x0030EB54 File Offset: 0x0030CD54
		public static IBoxRange GetRootAsIBoxRange(ByteBuffer _bb)
		{
			return IBoxRange.GetRootAsIBoxRange(_bb, default(IBoxRange));
		}

		// Token: 0x060151A2 RID: 86434 RVA: 0x0030EB70 File Offset: 0x0030CD70
		public static IBoxRange GetRootAsIBoxRange(ByteBuffer _bb, IBoxRange obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060151A3 RID: 86435 RVA: 0x0030EB8D File Offset: 0x0030CD8D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060151A4 RID: 86436 RVA: 0x0030EB9C File Offset: 0x0030CD9C
		public IBoxRange __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700694A RID: 26954
		// (get) Token: 0x060151A5 RID: 86437 RVA: 0x0030EBAC File Offset: 0x0030CDAC
		public ERangeType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ERangeType.CircleRange;
				}
				return (ERangeType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700694B RID: 26955
		// (get) Token: 0x060151A6 RID: 86438 RVA: 0x0030EBE8 File Offset: 0x0030CDE8
		public IVectorInfo? Pos
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IVectorInfo?(default(IVectorInfo).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700694C RID: 26956
		// (get) Token: 0x060151A7 RID: 86439 RVA: 0x0030EC48 File Offset: 0x0030CE48
		public IVectorInfo? Size
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return new IVectorInfo?(default(IVectorInfo).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700694D RID: 26957
		// (get) Token: 0x060151A8 RID: 86440 RVA: 0x0030ECA8 File Offset: 0x0030CEA8
		public IVectorInfo? Rotator
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return new IVectorInfo?(default(IVectorInfo).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x060151A9 RID: 86441 RVA: 0x0030ED06 File Offset: 0x0030CF06
		public static Offset<IBoxRange> CreateIBoxRange(FlatBufferBuilder builder, ERangeType Type = ERangeType.CircleRange, Offset<IVectorInfo> PosOffset = default(Offset<IVectorInfo>), Offset<IVectorInfo> SizeOffset = default(Offset<IVectorInfo>), Offset<IVectorInfo> RotatorOffset = default(Offset<IVectorInfo>))
		{
			builder.StartTable(4);
			IBoxRange.AddRotator(builder, RotatorOffset);
			IBoxRange.AddSize(builder, SizeOffset);
			IBoxRange.AddPos(builder, PosOffset);
			IBoxRange.AddType(builder, Type);
			return IBoxRange.EndIBoxRange(builder);
		}

		// Token: 0x060151AA RID: 86442 RVA: 0x0030ED32 File Offset: 0x0030CF32
		public static void StartIBoxRange(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x060151AB RID: 86443 RVA: 0x0030ED3B File Offset: 0x0030CF3B
		public static void AddType(FlatBufferBuilder builder, ERangeType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060151AC RID: 86444 RVA: 0x0030ED46 File Offset: 0x0030CF46
		public static void AddPos(FlatBufferBuilder builder, Offset<IVectorInfo> posOffset)
		{
			builder.AddOffset(1, posOffset.Value, 0);
		}

		// Token: 0x060151AD RID: 86445 RVA: 0x0030ED56 File Offset: 0x0030CF56
		public static void AddSize(FlatBufferBuilder builder, Offset<IVectorInfo> sizeOffset)
		{
			builder.AddOffset(2, sizeOffset.Value, 0);
		}

		// Token: 0x060151AE RID: 86446 RVA: 0x0030ED66 File Offset: 0x0030CF66
		public static void AddRotator(FlatBufferBuilder builder, Offset<IVectorInfo> rotatorOffset)
		{
			builder.AddOffset(3, rotatorOffset.Value, 0);
		}

		// Token: 0x060151AF RID: 86447 RVA: 0x0030ED76 File Offset: 0x0030CF76
		public static Offset<IBoxRange> EndIBoxRange(FlatBufferBuilder builder)
		{
			return new Offset<IBoxRange>(builder.EndTable());
		}

		// Token: 0x060151B0 RID: 86448 RVA: 0x0030ED84 File Offset: 0x0030CF84
		public IBoxRangeT UnPack()
		{
			IBoxRangeT boxRangeT = new IBoxRangeT();
			this.UnPackTo(boxRangeT);
			return boxRangeT;
		}

		// Token: 0x060151B1 RID: 86449 RVA: 0x0030EDA0 File Offset: 0x0030CFA0
		public void UnPackTo(IBoxRangeT _o)
		{
			_o.Type = this.Type;
			_o.Pos = ((this.Pos != null) ? this.Pos.Value.UnPack() : null);
			_o.Size = ((this.Size != null) ? this.Size.Value.UnPack() : null);
			_o.Rotator = ((this.Rotator != null) ? this.Rotator.Value.UnPack() : null);
		}

		// Token: 0x060151B2 RID: 86450 RVA: 0x0030EE48 File Offset: 0x0030D048
		public static Offset<IBoxRange> Pack(FlatBufferBuilder builder, IBoxRangeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IBoxRange>);
			}
			Offset<IVectorInfo> posOffset = (_o.Pos == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.Pos);
			Offset<IVectorInfo> sizeOffset = (_o.Size == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.Size);
			Offset<IVectorInfo> rotatorOffset = (_o.Rotator == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.Rotator);
			return IBoxRange.CreateIBoxRange(builder, _o.Type, posOffset, sizeOffset, rotatorOffset);
		}

		// Token: 0x0400B1B6 RID: 45494
		private Table __p;
	}
}
