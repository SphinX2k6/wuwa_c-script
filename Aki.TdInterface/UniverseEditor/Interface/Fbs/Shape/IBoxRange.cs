using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Shape
{
	// Token: 0x02003FFB RID: 16379
	public struct IBoxRange : IFlatbufferObject
	{
		// Token: 0x17006EF1 RID: 28401
		// (get) Token: 0x06016695 RID: 91797 RVA: 0x003356C8 File Offset: 0x003338C8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06016696 RID: 91798 RVA: 0x003356D5 File Offset: 0x003338D5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06016697 RID: 91799 RVA: 0x003356DC File Offset: 0x003338DC
		public static IBoxRange GetRootAsIBoxRange(ByteBuffer _bb)
		{
			return IBoxRange.GetRootAsIBoxRange(_bb, default(IBoxRange));
		}

		// Token: 0x06016698 RID: 91800 RVA: 0x003356F8 File Offset: 0x003338F8
		public static IBoxRange GetRootAsIBoxRange(ByteBuffer _bb, IBoxRange obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06016699 RID: 91801 RVA: 0x00335715 File Offset: 0x00333915
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601669A RID: 91802 RVA: 0x00335724 File Offset: 0x00333924
		public IBoxRange __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006EF2 RID: 28402
		// (get) Token: 0x0601669B RID: 91803 RVA: 0x00335734 File Offset: 0x00333934
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

		// Token: 0x17006EF3 RID: 28403
		// (get) Token: 0x0601669C RID: 91804 RVA: 0x00335770 File Offset: 0x00333970
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

		// Token: 0x17006EF4 RID: 28404
		// (get) Token: 0x0601669D RID: 91805 RVA: 0x003357D0 File Offset: 0x003339D0
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

		// Token: 0x17006EF5 RID: 28405
		// (get) Token: 0x0601669E RID: 91806 RVA: 0x00335830 File Offset: 0x00333A30
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

		// Token: 0x0601669F RID: 91807 RVA: 0x0033588E File Offset: 0x00333A8E
		public static Offset<IBoxRange> CreateIBoxRange(FlatBufferBuilder builder, ERangeType Type = ERangeType.CircleRange, Offset<IVectorInfo> PosOffset = default(Offset<IVectorInfo>), Offset<IVectorInfo> SizeOffset = default(Offset<IVectorInfo>), Offset<IVectorInfo> RotatorOffset = default(Offset<IVectorInfo>))
		{
			builder.StartTable(4);
			IBoxRange.AddRotator(builder, RotatorOffset);
			IBoxRange.AddSize(builder, SizeOffset);
			IBoxRange.AddPos(builder, PosOffset);
			IBoxRange.AddType(builder, Type);
			return IBoxRange.EndIBoxRange(builder);
		}

		// Token: 0x060166A0 RID: 91808 RVA: 0x003358BA File Offset: 0x00333ABA
		public static void StartIBoxRange(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x060166A1 RID: 91809 RVA: 0x003358C3 File Offset: 0x00333AC3
		public static void AddType(FlatBufferBuilder builder, ERangeType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060166A2 RID: 91810 RVA: 0x003358CE File Offset: 0x00333ACE
		public static void AddPos(FlatBufferBuilder builder, Offset<IVectorInfo> posOffset)
		{
			builder.AddOffset(1, posOffset.Value, 0);
		}

		// Token: 0x060166A3 RID: 91811 RVA: 0x003358DE File Offset: 0x00333ADE
		public static void AddSize(FlatBufferBuilder builder, Offset<IVectorInfo> sizeOffset)
		{
			builder.AddOffset(2, sizeOffset.Value, 0);
		}

		// Token: 0x060166A4 RID: 91812 RVA: 0x003358EE File Offset: 0x00333AEE
		public static void AddRotator(FlatBufferBuilder builder, Offset<IVectorInfo> rotatorOffset)
		{
			builder.AddOffset(3, rotatorOffset.Value, 0);
		}

		// Token: 0x060166A5 RID: 91813 RVA: 0x003358FE File Offset: 0x00333AFE
		public static Offset<IBoxRange> EndIBoxRange(FlatBufferBuilder builder)
		{
			return new Offset<IBoxRange>(builder.EndTable());
		}

		// Token: 0x060166A6 RID: 91814 RVA: 0x0033590C File Offset: 0x00333B0C
		public IBoxRangeT UnPack()
		{
			IBoxRangeT boxRangeT = new IBoxRangeT();
			this.UnPackTo(boxRangeT);
			return boxRangeT;
		}

		// Token: 0x060166A7 RID: 91815 RVA: 0x00335928 File Offset: 0x00333B28
		public void UnPackTo(IBoxRangeT _o)
		{
			_o.Type = this.Type;
			_o.Pos = ((this.Pos != null) ? this.Pos.Value.UnPack() : null);
			_o.Size = ((this.Size != null) ? this.Size.Value.UnPack() : null);
			_o.Rotator = ((this.Rotator != null) ? this.Rotator.Value.UnPack() : null);
		}

		// Token: 0x060166A8 RID: 91816 RVA: 0x003359D0 File Offset: 0x00333BD0
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

		// Token: 0x0400BB41 RID: 47937
		private Table __p;
	}
}
