using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005AE6 RID: 23270
	public struct IMismatchCastConfig : IFlatbufferObject
	{
		// Token: 0x1700A9C5 RID: 43461
		// (get) Token: 0x0602636C RID: 156524 RVA: 0x0053C909 File Offset: 0x0053AB09
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602636D RID: 156525 RVA: 0x0053C916 File Offset: 0x0053AB16
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602636E RID: 156526 RVA: 0x0053C920 File Offset: 0x0053AB20
		public static IMismatchCastConfig GetRootAsIMismatchCastConfig(ByteBuffer _bb)
		{
			return IMismatchCastConfig.GetRootAsIMismatchCastConfig(_bb, default(IMismatchCastConfig));
		}

		// Token: 0x0602636F RID: 156527 RVA: 0x0053C93C File Offset: 0x0053AB3C
		public static IMismatchCastConfig GetRootAsIMismatchCastConfig(ByteBuffer _bb, IMismatchCastConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06026370 RID: 156528 RVA: 0x0053C959 File Offset: 0x0053AB59
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06026371 RID: 156529 RVA: 0x0053C968 File Offset: 0x0053AB68
		public IMismatchCastConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x06026372 RID: 156530 RVA: 0x0053C978 File Offset: 0x0053AB78
		public IMismatchSequence? MismatchSequence(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return null;
			}
			return new IMismatchSequence?(default(IMismatchSequence).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700A9C6 RID: 43462
		// (get) Token: 0x06026373 RID: 156531 RVA: 0x0053C9D8 File Offset: 0x0053ABD8
		public int MismatchSequenceLength
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x1700A9C7 RID: 43463
		// (get) Token: 0x06026374 RID: 156532 RVA: 0x0053CA04 File Offset: 0x0053AC04
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06026375 RID: 156533 RVA: 0x0053CA40 File Offset: 0x0053AC40
		public static Offset<IMismatchCastConfig> CreateIMismatchCastConfig(FlatBufferBuilder builder, VectorOffset MismatchSequenceOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(2);
			IMismatchCastConfig.AddMismatchSequence(builder, MismatchSequenceOffset);
			IMismatchCastConfig.AddNullMask(builder, NullMask);
			return IMismatchCastConfig.EndIMismatchCastConfig(builder);
		}

		// Token: 0x06026376 RID: 156534 RVA: 0x0053CA5D File Offset: 0x0053AC5D
		public static void StartIMismatchCastConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06026377 RID: 156535 RVA: 0x0053CA66 File Offset: 0x0053AC66
		public static void AddMismatchSequence(FlatBufferBuilder builder, VectorOffset mismatchSequenceOffset)
		{
			builder.AddOffset(0, mismatchSequenceOffset.Value, 0);
		}

		// Token: 0x06026378 RID: 156536 RVA: 0x0053CA78 File Offset: 0x0053AC78
		public static VectorOffset CreateMismatchSequenceVector(FlatBufferBuilder builder, Offset<IMismatchSequence>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06026379 RID: 156537 RVA: 0x0053CAB8 File Offset: 0x0053ACB8
		public static VectorOffset CreateMismatchSequenceVectorBlock(FlatBufferBuilder builder, Offset<IMismatchSequence>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IMismatchSequence>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602637A RID: 156538 RVA: 0x0053CAD2 File Offset: 0x0053ACD2
		public static VectorOffset CreateMismatchSequenceVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IMismatchSequence>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IMismatchSequence>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602637B RID: 156539 RVA: 0x0053CAF0 File Offset: 0x0053ACF0
		public static VectorOffset CreateMismatchSequenceVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IMismatchSequence>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602637C RID: 156540 RVA: 0x0053CB09 File Offset: 0x0053AD09
		public static void StartMismatchSequenceVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602637D RID: 156541 RVA: 0x0053CB14 File Offset: 0x0053AD14
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(1, nullMask, 0);
		}

		// Token: 0x0602637E RID: 156542 RVA: 0x0053CB1F File Offset: 0x0053AD1F
		public static Offset<IMismatchCastConfig> EndIMismatchCastConfig(FlatBufferBuilder builder)
		{
			return new Offset<IMismatchCastConfig>(builder.EndTable());
		}

		// Token: 0x0602637F RID: 156543 RVA: 0x0053CB2C File Offset: 0x0053AD2C
		public IMismatchCastConfigT UnPack()
		{
			IMismatchCastConfigT mismatchCastConfigT = new IMismatchCastConfigT();
			this.UnPackTo(mismatchCastConfigT);
			return mismatchCastConfigT;
		}

		// Token: 0x06026380 RID: 156544 RVA: 0x0053CB48 File Offset: 0x0053AD48
		public void UnPackTo(IMismatchCastConfigT _o)
		{
			_o.MismatchSequence = new List<IMismatchSequenceT>();
			for (int i = 0; i < this.MismatchSequenceLength; i++)
			{
				_o.MismatchSequence.Add((this.MismatchSequence(i) != null) ? this.MismatchSequence(i).Value.UnPack() : null);
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06026381 RID: 156545 RVA: 0x0053CBB4 File Offset: 0x0053ADB4
		public static Offset<IMismatchCastConfig> Pack(FlatBufferBuilder builder, IMismatchCastConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IMismatchCastConfig>);
			}
			VectorOffset mismatchSequenceOffset = default(VectorOffset);
			if (_o.MismatchSequence != null)
			{
				Offset<IMismatchSequence>[] array = new Offset<IMismatchSequence>[_o.MismatchSequence.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IMismatchSequence.Pack(builder, _o.MismatchSequence[i]);
				}
				mismatchSequenceOffset = IMismatchCastConfig.CreateMismatchSequenceVector(builder, array);
			}
			return IMismatchCastConfig.CreateIMismatchCastConfig(builder, mismatchSequenceOffset, _o.NullMask);
		}

		// Token: 0x0400F4B3 RID: 62643
		private Table __p;
	}
}
