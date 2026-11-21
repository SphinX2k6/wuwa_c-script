using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004FD4 RID: 20436
	public struct ICheckPlayerRelativeAngle : IFlatbufferObject
	{
		// Token: 0x1700922E RID: 37422
		// (get) Token: 0x0601FDE4 RID: 130532 RVA: 0x0046CF60 File Offset: 0x0046B160
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601FDE5 RID: 130533 RVA: 0x0046CF6D File Offset: 0x0046B16D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601FDE6 RID: 130534 RVA: 0x0046CF74 File Offset: 0x0046B174
		public static ICheckPlayerRelativeAngle GetRootAsICheckPlayerRelativeAngle(ByteBuffer _bb)
		{
			return ICheckPlayerRelativeAngle.GetRootAsICheckPlayerRelativeAngle(_bb, default(ICheckPlayerRelativeAngle));
		}

		// Token: 0x0601FDE7 RID: 130535 RVA: 0x0046CF90 File Offset: 0x0046B190
		public static ICheckPlayerRelativeAngle GetRootAsICheckPlayerRelativeAngle(ByteBuffer _bb, ICheckPlayerRelativeAngle obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601FDE8 RID: 130536 RVA: 0x0046CFAD File Offset: 0x0046B1AD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601FDE9 RID: 130537 RVA: 0x0046CFBC File Offset: 0x0046B1BC
		public ICheckPlayerRelativeAngle __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700922F RID: 37423
		// (get) Token: 0x0601FDEA RID: 130538 RVA: 0x0046CFCC File Offset: 0x0046B1CC
		public ECondition Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECondition.CompareVar;
				}
				return (ECondition)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17009230 RID: 37424
		// (get) Token: 0x0601FDEB RID: 130539 RVA: 0x0046D008 File Offset: 0x0046B208
		public int TargetEntityId
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

		// Token: 0x17009231 RID: 37425
		// (get) Token: 0x0601FDEC RID: 130540 RVA: 0x0046D044 File Offset: 0x0046B244
		public IVectorInfo? BaseVector
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

		// Token: 0x17009232 RID: 37426
		// (get) Token: 0x0601FDED RID: 130541 RVA: 0x0046D0A4 File Offset: 0x0046B2A4
		public EVectorSpace BaseVectorSpace
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return EVectorSpace.World;
				}
				return (EVectorSpace)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601FDEE RID: 130542 RVA: 0x0046D0E4 File Offset: 0x0046B2E4
		public IAngleRange? ValidAngleRanges(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new IAngleRange?(default(IAngleRange).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17009233 RID: 37427
		// (get) Token: 0x0601FDEF RID: 130543 RVA: 0x0046D148 File Offset: 0x0046B348
		public int ValidAngleRangesLength
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x17009234 RID: 37428
		// (get) Token: 0x0601FDF0 RID: 130544 RVA: 0x0046D174 File Offset: 0x0046B374
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

		// Token: 0x0601FDF1 RID: 130545 RVA: 0x0046D1B1 File Offset: 0x0046B3B1
		public static Offset<ICheckPlayerRelativeAngle> CreateICheckPlayerRelativeAngle(FlatBufferBuilder builder, ECondition Type = ECondition.CompareVar, int TargetEntityId = 0, Offset<IVectorInfo> BaseVectorOffset = default(Offset<IVectorInfo>), EVectorSpace BaseVectorSpace = EVectorSpace.World, VectorOffset ValidAngleRangesOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(6);
			ICheckPlayerRelativeAngle.AddValidAngleRanges(builder, ValidAngleRangesOffset);
			ICheckPlayerRelativeAngle.AddBaseVector(builder, BaseVectorOffset);
			ICheckPlayerRelativeAngle.AddTargetEntityId(builder, TargetEntityId);
			ICheckPlayerRelativeAngle.AddNullMask(builder, NullMask);
			ICheckPlayerRelativeAngle.AddBaseVectorSpace(builder, BaseVectorSpace);
			ICheckPlayerRelativeAngle.AddType(builder, Type);
			return ICheckPlayerRelativeAngle.EndICheckPlayerRelativeAngle(builder);
		}

		// Token: 0x0601FDF2 RID: 130546 RVA: 0x0046D1ED File Offset: 0x0046B3ED
		public static void StartICheckPlayerRelativeAngle(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x0601FDF3 RID: 130547 RVA: 0x0046D1F6 File Offset: 0x0046B3F6
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601FDF4 RID: 130548 RVA: 0x0046D201 File Offset: 0x0046B401
		public static void AddTargetEntityId(FlatBufferBuilder builder, int targetEntityId)
		{
			builder.AddInt(1, targetEntityId, 0);
		}

		// Token: 0x0601FDF5 RID: 130549 RVA: 0x0046D20C File Offset: 0x0046B40C
		public static void AddBaseVector(FlatBufferBuilder builder, Offset<IVectorInfo> baseVectorOffset)
		{
			builder.AddOffset(2, baseVectorOffset.Value, 0);
		}

		// Token: 0x0601FDF6 RID: 130550 RVA: 0x0046D21C File Offset: 0x0046B41C
		public static void AddBaseVectorSpace(FlatBufferBuilder builder, EVectorSpace baseVectorSpace)
		{
			builder.AddByte(3, (byte)baseVectorSpace, 0);
		}

		// Token: 0x0601FDF7 RID: 130551 RVA: 0x0046D227 File Offset: 0x0046B427
		public static void AddValidAngleRanges(FlatBufferBuilder builder, VectorOffset validAngleRangesOffset)
		{
			builder.AddOffset(4, validAngleRangesOffset.Value, 0);
		}

		// Token: 0x0601FDF8 RID: 130552 RVA: 0x0046D238 File Offset: 0x0046B438
		public static VectorOffset CreateValidAngleRangesVector(FlatBufferBuilder builder, Offset<IAngleRange>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601FDF9 RID: 130553 RVA: 0x0046D278 File Offset: 0x0046B478
		public static VectorOffset CreateValidAngleRangesVectorBlock(FlatBufferBuilder builder, Offset<IAngleRange>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IAngleRange>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601FDFA RID: 130554 RVA: 0x0046D292 File Offset: 0x0046B492
		public static VectorOffset CreateValidAngleRangesVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IAngleRange>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IAngleRange>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601FDFB RID: 130555 RVA: 0x0046D2B0 File Offset: 0x0046B4B0
		public static VectorOffset CreateValidAngleRangesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IAngleRange>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601FDFC RID: 130556 RVA: 0x0046D2C9 File Offset: 0x0046B4C9
		public static void StartValidAngleRangesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601FDFD RID: 130557 RVA: 0x0046D2D4 File Offset: 0x0046B4D4
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(5, nullMask, 0);
		}

		// Token: 0x0601FDFE RID: 130558 RVA: 0x0046D2DF File Offset: 0x0046B4DF
		public static Offset<ICheckPlayerRelativeAngle> EndICheckPlayerRelativeAngle(FlatBufferBuilder builder)
		{
			return new Offset<ICheckPlayerRelativeAngle>(builder.EndTable());
		}

		// Token: 0x0601FDFF RID: 130559 RVA: 0x0046D2EC File Offset: 0x0046B4EC
		public ICheckPlayerRelativeAngleT UnPack()
		{
			ICheckPlayerRelativeAngleT checkPlayerRelativeAngleT = new ICheckPlayerRelativeAngleT();
			this.UnPackTo(checkPlayerRelativeAngleT);
			return checkPlayerRelativeAngleT;
		}

		// Token: 0x0601FE00 RID: 130560 RVA: 0x0046D308 File Offset: 0x0046B508
		public void UnPackTo(ICheckPlayerRelativeAngleT _o)
		{
			_o.Type = this.Type;
			_o.TargetEntityId = this.TargetEntityId;
			_o.BaseVector = ((this.BaseVector != null) ? this.BaseVector.Value.UnPack() : null);
			_o.BaseVectorSpace = this.BaseVectorSpace;
			_o.ValidAngleRanges = new List<IAngleRangeT>();
			for (int i = 0; i < this.ValidAngleRangesLength; i++)
			{
				_o.ValidAngleRanges.Add((this.ValidAngleRanges(i) != null) ? this.ValidAngleRanges(i).Value.UnPack() : null);
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0601FE01 RID: 130561 RVA: 0x0046D3C8 File Offset: 0x0046B5C8
		public static Offset<ICheckPlayerRelativeAngle> Pack(FlatBufferBuilder builder, ICheckPlayerRelativeAngleT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckPlayerRelativeAngle>);
			}
			Offset<IVectorInfo> baseVectorOffset = (_o.BaseVector == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.BaseVector);
			VectorOffset validAngleRangesOffset = default(VectorOffset);
			if (_o.ValidAngleRanges != null)
			{
				Offset<IAngleRange>[] array = new Offset<IAngleRange>[_o.ValidAngleRanges.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IAngleRange.Pack(builder, _o.ValidAngleRanges[i]);
				}
				validAngleRangesOffset = ICheckPlayerRelativeAngle.CreateValidAngleRangesVector(builder, array);
			}
			return ICheckPlayerRelativeAngle.CreateICheckPlayerRelativeAngle(builder, _o.Type, _o.TargetEntityId, baseVectorOffset, _o.BaseVectorSpace, validAngleRangesOffset, _o.NullMask);
		}

		// Token: 0x0400DE7D RID: 56957
		private Table __p;
	}
}
