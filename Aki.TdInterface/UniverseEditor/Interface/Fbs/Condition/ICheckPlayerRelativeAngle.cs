using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004AF9 RID: 19193
	public struct ICheckPlayerRelativeAngle : IFlatbufferObject
	{
		// Token: 0x17008B2D RID: 35629
		// (get) Token: 0x0601E2A3 RID: 123555 RVA: 0x0043AEB4 File Offset: 0x004390B4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601E2A4 RID: 123556 RVA: 0x0043AEC1 File Offset: 0x004390C1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601E2A5 RID: 123557 RVA: 0x0043AEC8 File Offset: 0x004390C8
		public static ICheckPlayerRelativeAngle GetRootAsICheckPlayerRelativeAngle(ByteBuffer _bb)
		{
			return ICheckPlayerRelativeAngle.GetRootAsICheckPlayerRelativeAngle(_bb, default(ICheckPlayerRelativeAngle));
		}

		// Token: 0x0601E2A6 RID: 123558 RVA: 0x0043AEE4 File Offset: 0x004390E4
		public static ICheckPlayerRelativeAngle GetRootAsICheckPlayerRelativeAngle(ByteBuffer _bb, ICheckPlayerRelativeAngle obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601E2A7 RID: 123559 RVA: 0x0043AF01 File Offset: 0x00439101
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601E2A8 RID: 123560 RVA: 0x0043AF10 File Offset: 0x00439110
		public ICheckPlayerRelativeAngle __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008B2E RID: 35630
		// (get) Token: 0x0601E2A9 RID: 123561 RVA: 0x0043AF20 File Offset: 0x00439120
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

		// Token: 0x17008B2F RID: 35631
		// (get) Token: 0x0601E2AA RID: 123562 RVA: 0x0043AF5C File Offset: 0x0043915C
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

		// Token: 0x17008B30 RID: 35632
		// (get) Token: 0x0601E2AB RID: 123563 RVA: 0x0043AF98 File Offset: 0x00439198
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

		// Token: 0x17008B31 RID: 35633
		// (get) Token: 0x0601E2AC RID: 123564 RVA: 0x0043AFF8 File Offset: 0x004391F8
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

		// Token: 0x0601E2AD RID: 123565 RVA: 0x0043B038 File Offset: 0x00439238
		public IAngleRange? ValidAngleRanges(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new IAngleRange?(default(IAngleRange).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17008B32 RID: 35634
		// (get) Token: 0x0601E2AE RID: 123566 RVA: 0x0043B09C File Offset: 0x0043929C
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

		// Token: 0x17008B33 RID: 35635
		// (get) Token: 0x0601E2AF RID: 123567 RVA: 0x0043B0C8 File Offset: 0x004392C8
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

		// Token: 0x0601E2B0 RID: 123568 RVA: 0x0043B105 File Offset: 0x00439305
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

		// Token: 0x0601E2B1 RID: 123569 RVA: 0x0043B141 File Offset: 0x00439341
		public static void StartICheckPlayerRelativeAngle(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x0601E2B2 RID: 123570 RVA: 0x0043B14A File Offset: 0x0043934A
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601E2B3 RID: 123571 RVA: 0x0043B155 File Offset: 0x00439355
		public static void AddTargetEntityId(FlatBufferBuilder builder, int targetEntityId)
		{
			builder.AddInt(1, targetEntityId, 0);
		}

		// Token: 0x0601E2B4 RID: 123572 RVA: 0x0043B160 File Offset: 0x00439360
		public static void AddBaseVector(FlatBufferBuilder builder, Offset<IVectorInfo> baseVectorOffset)
		{
			builder.AddOffset(2, baseVectorOffset.Value, 0);
		}

		// Token: 0x0601E2B5 RID: 123573 RVA: 0x0043B170 File Offset: 0x00439370
		public static void AddBaseVectorSpace(FlatBufferBuilder builder, EVectorSpace baseVectorSpace)
		{
			builder.AddByte(3, (byte)baseVectorSpace, 0);
		}

		// Token: 0x0601E2B6 RID: 123574 RVA: 0x0043B17B File Offset: 0x0043937B
		public static void AddValidAngleRanges(FlatBufferBuilder builder, VectorOffset validAngleRangesOffset)
		{
			builder.AddOffset(4, validAngleRangesOffset.Value, 0);
		}

		// Token: 0x0601E2B7 RID: 123575 RVA: 0x0043B18C File Offset: 0x0043938C
		public static VectorOffset CreateValidAngleRangesVector(FlatBufferBuilder builder, Offset<IAngleRange>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601E2B8 RID: 123576 RVA: 0x0043B1CC File Offset: 0x004393CC
		public static VectorOffset CreateValidAngleRangesVectorBlock(FlatBufferBuilder builder, Offset<IAngleRange>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IAngleRange>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601E2B9 RID: 123577 RVA: 0x0043B1E6 File Offset: 0x004393E6
		public static VectorOffset CreateValidAngleRangesVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IAngleRange>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IAngleRange>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601E2BA RID: 123578 RVA: 0x0043B204 File Offset: 0x00439404
		public static VectorOffset CreateValidAngleRangesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IAngleRange>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601E2BB RID: 123579 RVA: 0x0043B21D File Offset: 0x0043941D
		public static void StartValidAngleRangesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601E2BC RID: 123580 RVA: 0x0043B228 File Offset: 0x00439428
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(5, nullMask, 0);
		}

		// Token: 0x0601E2BD RID: 123581 RVA: 0x0043B233 File Offset: 0x00439433
		public static Offset<ICheckPlayerRelativeAngle> EndICheckPlayerRelativeAngle(FlatBufferBuilder builder)
		{
			return new Offset<ICheckPlayerRelativeAngle>(builder.EndTable());
		}

		// Token: 0x0601E2BE RID: 123582 RVA: 0x0043B240 File Offset: 0x00439440
		public ICheckPlayerRelativeAngleT UnPack()
		{
			ICheckPlayerRelativeAngleT checkPlayerRelativeAngleT = new ICheckPlayerRelativeAngleT();
			this.UnPackTo(checkPlayerRelativeAngleT);
			return checkPlayerRelativeAngleT;
		}

		// Token: 0x0601E2BF RID: 123583 RVA: 0x0043B25C File Offset: 0x0043945C
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

		// Token: 0x0601E2C0 RID: 123584 RVA: 0x0043B31C File Offset: 0x0043951C
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

		// Token: 0x0400D38C RID: 54156
		private Table __p;
	}
}
