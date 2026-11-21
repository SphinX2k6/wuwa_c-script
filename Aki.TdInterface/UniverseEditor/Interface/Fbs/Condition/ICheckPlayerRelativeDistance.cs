using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004FD7 RID: 20439
	public struct ICheckPlayerRelativeDistance : IFlatbufferObject
	{
		// Token: 0x1700923B RID: 37435
		// (get) Token: 0x0601FE10 RID: 130576 RVA: 0x0046D5C4 File Offset: 0x0046B7C4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601FE11 RID: 130577 RVA: 0x0046D5D1 File Offset: 0x0046B7D1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601FE12 RID: 130578 RVA: 0x0046D5D8 File Offset: 0x0046B7D8
		public static ICheckPlayerRelativeDistance GetRootAsICheckPlayerRelativeDistance(ByteBuffer _bb)
		{
			return ICheckPlayerRelativeDistance.GetRootAsICheckPlayerRelativeDistance(_bb, default(ICheckPlayerRelativeDistance));
		}

		// Token: 0x0601FE13 RID: 130579 RVA: 0x0046D5F4 File Offset: 0x0046B7F4
		public static ICheckPlayerRelativeDistance GetRootAsICheckPlayerRelativeDistance(ByteBuffer _bb, ICheckPlayerRelativeDistance obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601FE14 RID: 130580 RVA: 0x0046D611 File Offset: 0x0046B811
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601FE15 RID: 130581 RVA: 0x0046D620 File Offset: 0x0046B820
		public ICheckPlayerRelativeDistance __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700923C RID: 37436
		// (get) Token: 0x0601FE16 RID: 130582 RVA: 0x0046D630 File Offset: 0x0046B830
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

		// Token: 0x1700923D RID: 37437
		// (get) Token: 0x0601FE17 RID: 130583 RVA: 0x0046D66C File Offset: 0x0046B86C
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

		// Token: 0x0601FE18 RID: 130584 RVA: 0x0046D6A8 File Offset: 0x0046B8A8
		public IDistanceRange? ValidDistanceRanges(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new IDistanceRange?(default(IDistanceRange).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700923E RID: 37438
		// (get) Token: 0x0601FE19 RID: 130585 RVA: 0x0046D708 File Offset: 0x0046B908
		public int ValidDistanceRangesLength
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0601FE1A RID: 130586 RVA: 0x0046D733 File Offset: 0x0046B933
		public static Offset<ICheckPlayerRelativeDistance> CreateICheckPlayerRelativeDistance(FlatBufferBuilder builder, ECondition Type = ECondition.CompareVar, int TargetEntityId = 0, VectorOffset ValidDistanceRangesOffset = default(VectorOffset))
		{
			builder.StartTable(3);
			ICheckPlayerRelativeDistance.AddValidDistanceRanges(builder, ValidDistanceRangesOffset);
			ICheckPlayerRelativeDistance.AddTargetEntityId(builder, TargetEntityId);
			ICheckPlayerRelativeDistance.AddType(builder, Type);
			return ICheckPlayerRelativeDistance.EndICheckPlayerRelativeDistance(builder);
		}

		// Token: 0x0601FE1B RID: 130587 RVA: 0x0046D757 File Offset: 0x0046B957
		public static void StartICheckPlayerRelativeDistance(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601FE1C RID: 130588 RVA: 0x0046D760 File Offset: 0x0046B960
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601FE1D RID: 130589 RVA: 0x0046D76B File Offset: 0x0046B96B
		public static void AddTargetEntityId(FlatBufferBuilder builder, int targetEntityId)
		{
			builder.AddInt(1, targetEntityId, 0);
		}

		// Token: 0x0601FE1E RID: 130590 RVA: 0x0046D776 File Offset: 0x0046B976
		public static void AddValidDistanceRanges(FlatBufferBuilder builder, VectorOffset validDistanceRangesOffset)
		{
			builder.AddOffset(2, validDistanceRangesOffset.Value, 0);
		}

		// Token: 0x0601FE1F RID: 130591 RVA: 0x0046D788 File Offset: 0x0046B988
		public static VectorOffset CreateValidDistanceRangesVector(FlatBufferBuilder builder, Offset<IDistanceRange>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601FE20 RID: 130592 RVA: 0x0046D7C8 File Offset: 0x0046B9C8
		public static VectorOffset CreateValidDistanceRangesVectorBlock(FlatBufferBuilder builder, Offset<IDistanceRange>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IDistanceRange>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601FE21 RID: 130593 RVA: 0x0046D7E2 File Offset: 0x0046B9E2
		public static VectorOffset CreateValidDistanceRangesVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IDistanceRange>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IDistanceRange>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601FE22 RID: 130594 RVA: 0x0046D800 File Offset: 0x0046BA00
		public static VectorOffset CreateValidDistanceRangesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IDistanceRange>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601FE23 RID: 130595 RVA: 0x0046D819 File Offset: 0x0046BA19
		public static void StartValidDistanceRangesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601FE24 RID: 130596 RVA: 0x0046D824 File Offset: 0x0046BA24
		public static Offset<ICheckPlayerRelativeDistance> EndICheckPlayerRelativeDistance(FlatBufferBuilder builder)
		{
			return new Offset<ICheckPlayerRelativeDistance>(builder.EndTable());
		}

		// Token: 0x0601FE25 RID: 130597 RVA: 0x0046D834 File Offset: 0x0046BA34
		public ICheckPlayerRelativeDistanceT UnPack()
		{
			ICheckPlayerRelativeDistanceT checkPlayerRelativeDistanceT = new ICheckPlayerRelativeDistanceT();
			this.UnPackTo(checkPlayerRelativeDistanceT);
			return checkPlayerRelativeDistanceT;
		}

		// Token: 0x0601FE26 RID: 130598 RVA: 0x0046D850 File Offset: 0x0046BA50
		public void UnPackTo(ICheckPlayerRelativeDistanceT _o)
		{
			_o.Type = this.Type;
			_o.TargetEntityId = this.TargetEntityId;
			_o.ValidDistanceRanges = new List<IDistanceRangeT>();
			for (int i = 0; i < this.ValidDistanceRangesLength; i++)
			{
				_o.ValidDistanceRanges.Add((this.ValidDistanceRanges(i) != null) ? this.ValidDistanceRanges(i).Value.UnPack() : null);
			}
		}

		// Token: 0x0601FE27 RID: 130599 RVA: 0x0046D8C8 File Offset: 0x0046BAC8
		public static Offset<ICheckPlayerRelativeDistance> Pack(FlatBufferBuilder builder, ICheckPlayerRelativeDistanceT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckPlayerRelativeDistance>);
			}
			VectorOffset validDistanceRangesOffset = default(VectorOffset);
			if (_o.ValidDistanceRanges != null)
			{
				Offset<IDistanceRange>[] array = new Offset<IDistanceRange>[_o.ValidDistanceRanges.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IDistanceRange.Pack(builder, _o.ValidDistanceRanges[i]);
				}
				validDistanceRangesOffset = ICheckPlayerRelativeDistance.CreateValidDistanceRangesVector(builder, array);
			}
			return ICheckPlayerRelativeDistance.CreateICheckPlayerRelativeDistance(builder, _o.Type, _o.TargetEntityId, validDistanceRangesOffset);
		}

		// Token: 0x0400DE84 RID: 56964
		private Table __p;
	}
}
