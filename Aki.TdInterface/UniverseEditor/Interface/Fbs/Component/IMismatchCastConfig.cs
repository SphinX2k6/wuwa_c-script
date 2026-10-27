using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005554 RID: 21844
	public struct IMismatchCastConfig : IFlatbufferObject
	{
		// Token: 0x1700A151 RID: 41297
		// (get) Token: 0x060241D1 RID: 147921 RVA: 0x004FD221 File Offset: 0x004FB421
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060241D2 RID: 147922 RVA: 0x004FD22E File Offset: 0x004FB42E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060241D3 RID: 147923 RVA: 0x004FD238 File Offset: 0x004FB438
		public static IMismatchCastConfig GetRootAsIMismatchCastConfig(ByteBuffer _bb)
		{
			return IMismatchCastConfig.GetRootAsIMismatchCastConfig(_bb, default(IMismatchCastConfig));
		}

		// Token: 0x060241D4 RID: 147924 RVA: 0x004FD254 File Offset: 0x004FB454
		public static IMismatchCastConfig GetRootAsIMismatchCastConfig(ByteBuffer _bb, IMismatchCastConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060241D5 RID: 147925 RVA: 0x004FD271 File Offset: 0x004FB471
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060241D6 RID: 147926 RVA: 0x004FD280 File Offset: 0x004FB480
		public IMismatchCastConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x060241D7 RID: 147927 RVA: 0x004FD290 File Offset: 0x004FB490
		public IMismatchSequence? MismatchSequence(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return null;
			}
			return new IMismatchSequence?(default(IMismatchSequence).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700A152 RID: 41298
		// (get) Token: 0x060241D8 RID: 147928 RVA: 0x004FD2F0 File Offset: 0x004FB4F0
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

		// Token: 0x1700A153 RID: 41299
		// (get) Token: 0x060241D9 RID: 147929 RVA: 0x004FD31C File Offset: 0x004FB51C
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

		// Token: 0x060241DA RID: 147930 RVA: 0x004FD358 File Offset: 0x004FB558
		public static Offset<IMismatchCastConfig> CreateIMismatchCastConfig(FlatBufferBuilder builder, VectorOffset MismatchSequenceOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(2);
			IMismatchCastConfig.AddMismatchSequence(builder, MismatchSequenceOffset);
			IMismatchCastConfig.AddNullMask(builder, NullMask);
			return IMismatchCastConfig.EndIMismatchCastConfig(builder);
		}

		// Token: 0x060241DB RID: 147931 RVA: 0x004FD375 File Offset: 0x004FB575
		public static void StartIMismatchCastConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060241DC RID: 147932 RVA: 0x004FD37E File Offset: 0x004FB57E
		public static void AddMismatchSequence(FlatBufferBuilder builder, VectorOffset mismatchSequenceOffset)
		{
			builder.AddOffset(0, mismatchSequenceOffset.Value, 0);
		}

		// Token: 0x060241DD RID: 147933 RVA: 0x004FD390 File Offset: 0x004FB590
		public static VectorOffset CreateMismatchSequenceVector(FlatBufferBuilder builder, Offset<IMismatchSequence>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x060241DE RID: 147934 RVA: 0x004FD3D0 File Offset: 0x004FB5D0
		public static VectorOffset CreateMismatchSequenceVectorBlock(FlatBufferBuilder builder, Offset<IMismatchSequence>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IMismatchSequence>>(data);
			return builder.EndVector();
		}

		// Token: 0x060241DF RID: 147935 RVA: 0x004FD3EA File Offset: 0x004FB5EA
		public static VectorOffset CreateMismatchSequenceVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IMismatchSequence>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IMismatchSequence>>(data);
			return builder.EndVector();
		}

		// Token: 0x060241E0 RID: 147936 RVA: 0x004FD408 File Offset: 0x004FB608
		public static VectorOffset CreateMismatchSequenceVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IMismatchSequence>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060241E1 RID: 147937 RVA: 0x004FD421 File Offset: 0x004FB621
		public static void StartMismatchSequenceVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060241E2 RID: 147938 RVA: 0x004FD42C File Offset: 0x004FB62C
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(1, nullMask, 0);
		}

		// Token: 0x060241E3 RID: 147939 RVA: 0x004FD437 File Offset: 0x004FB637
		public static Offset<IMismatchCastConfig> EndIMismatchCastConfig(FlatBufferBuilder builder)
		{
			return new Offset<IMismatchCastConfig>(builder.EndTable());
		}

		// Token: 0x060241E4 RID: 147940 RVA: 0x004FD444 File Offset: 0x004FB644
		public IMismatchCastConfigT UnPack()
		{
			IMismatchCastConfigT mismatchCastConfigT = new IMismatchCastConfigT();
			this.UnPackTo(mismatchCastConfigT);
			return mismatchCastConfigT;
		}

		// Token: 0x060241E5 RID: 147941 RVA: 0x004FD460 File Offset: 0x004FB660
		public void UnPackTo(IMismatchCastConfigT _o)
		{
			_o.MismatchSequence = new List<IMismatchSequenceT>();
			for (int i = 0; i < this.MismatchSequenceLength; i++)
			{
				_o.MismatchSequence.Add((this.MismatchSequence(i) != null) ? this.MismatchSequence(i).Value.UnPack() : null);
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x060241E6 RID: 147942 RVA: 0x004FD4CC File Offset: 0x004FB6CC
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

		// Token: 0x0400E862 RID: 59490
		private Table __p;
	}
}
