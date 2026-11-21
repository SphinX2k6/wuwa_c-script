using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020074BF RID: 29887
	public struct IPlayVoicePassengersConfig : IFlatbufferObject
	{
		// Token: 0x1700DBE1 RID: 56289
		// (get) Token: 0x0603461F RID: 214559 RVA: 0x0070DF6E File Offset: 0x0070C16E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06034620 RID: 214560 RVA: 0x0070DF7B File Offset: 0x0070C17B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06034621 RID: 214561 RVA: 0x0070DF84 File Offset: 0x0070C184
		public static IPlayVoicePassengersConfig GetRootAsIPlayVoicePassengersConfig(ByteBuffer _bb)
		{
			return IPlayVoicePassengersConfig.GetRootAsIPlayVoicePassengersConfig(_bb, default(IPlayVoicePassengersConfig));
		}

		// Token: 0x06034622 RID: 214562 RVA: 0x0070DFA0 File Offset: 0x0070C1A0
		public static IPlayVoicePassengersConfig GetRootAsIPlayVoicePassengersConfig(ByteBuffer _bb, IPlayVoicePassengersConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06034623 RID: 214563 RVA: 0x0070DFBD File Offset: 0x0070C1BD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06034624 RID: 214564 RVA: 0x0070DFCC File Offset: 0x0070C1CC
		public IPlayVoicePassengersConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x06034625 RID: 214565 RVA: 0x0070DFDC File Offset: 0x0070C1DC
		public int Passengers(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700DBE2 RID: 56290
		// (get) Token: 0x06034626 RID: 214566 RVA: 0x0070E01C File Offset: 0x0070C21C
		public int PassengersLength
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

		// Token: 0x06034627 RID: 214567 RVA: 0x0070E047 File Offset: 0x0070C247
		public Span<int> GetPassengersBytes()
		{
			return this.__p.__vector_as_span<int>(4, 4);
		}

		// Token: 0x06034628 RID: 214568 RVA: 0x0070E056 File Offset: 0x0070C256
		public int[] GetPassengersArray()
		{
			return this.__p.__vector_as_array<int>(4);
		}

		// Token: 0x1700DBE3 RID: 56291
		// (get) Token: 0x06034629 RID: 214569 RVA: 0x0070E064 File Offset: 0x0070C264
		public bool MatchNone
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700DBE4 RID: 56292
		// (get) Token: 0x0603462A RID: 214570 RVA: 0x0070E0A4 File Offset: 0x0070C2A4
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0603462B RID: 214571 RVA: 0x0070E0E0 File Offset: 0x0070C2E0
		public static Offset<IPlayVoicePassengersConfig> CreateIPlayVoicePassengersConfig(FlatBufferBuilder builder, VectorOffset PassengersOffset = default(VectorOffset), bool MatchNone = false, byte NullMask = 0)
		{
			builder.StartTable(3);
			IPlayVoicePassengersConfig.AddPassengers(builder, PassengersOffset);
			IPlayVoicePassengersConfig.AddNullMask(builder, NullMask);
			IPlayVoicePassengersConfig.AddMatchNone(builder, MatchNone);
			return IPlayVoicePassengersConfig.EndIPlayVoicePassengersConfig(builder);
		}

		// Token: 0x0603462C RID: 214572 RVA: 0x0070E104 File Offset: 0x0070C304
		public static void StartIPlayVoicePassengersConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0603462D RID: 214573 RVA: 0x0070E10D File Offset: 0x0070C30D
		public static void AddPassengers(FlatBufferBuilder builder, VectorOffset passengersOffset)
		{
			builder.AddOffset(0, passengersOffset.Value, 0);
		}

		// Token: 0x0603462E RID: 214574 RVA: 0x0070E120 File Offset: 0x0070C320
		public static VectorOffset CreatePassengersVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0603462F RID: 214575 RVA: 0x0070E157 File Offset: 0x0070C357
		public static VectorOffset CreatePassengersVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06034630 RID: 214576 RVA: 0x0070E171 File Offset: 0x0070C371
		public static VectorOffset CreatePassengersVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06034631 RID: 214577 RVA: 0x0070E18F File Offset: 0x0070C38F
		public static VectorOffset CreatePassengersVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06034632 RID: 214578 RVA: 0x0070E1A8 File Offset: 0x0070C3A8
		public static void StartPassengersVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06034633 RID: 214579 RVA: 0x0070E1B3 File Offset: 0x0070C3B3
		public static void AddMatchNone(FlatBufferBuilder builder, bool matchNone)
		{
			builder.AddBool(1, matchNone, false);
		}

		// Token: 0x06034634 RID: 214580 RVA: 0x0070E1BE File Offset: 0x0070C3BE
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x06034635 RID: 214581 RVA: 0x0070E1C9 File Offset: 0x0070C3C9
		public static Offset<IPlayVoicePassengersConfig> EndIPlayVoicePassengersConfig(FlatBufferBuilder builder)
		{
			return new Offset<IPlayVoicePassengersConfig>(builder.EndTable());
		}

		// Token: 0x06034636 RID: 214582 RVA: 0x0070E1D8 File Offset: 0x0070C3D8
		public IPlayVoicePassengersConfigT UnPack()
		{
			IPlayVoicePassengersConfigT playVoicePassengersConfigT = new IPlayVoicePassengersConfigT();
			this.UnPackTo(playVoicePassengersConfigT);
			return playVoicePassengersConfigT;
		}

		// Token: 0x06034637 RID: 214583 RVA: 0x0070E1F4 File Offset: 0x0070C3F4
		public void UnPackTo(IPlayVoicePassengersConfigT _o)
		{
			_o.Passengers = new List<int>();
			for (int i = 0; i < this.PassengersLength; i++)
			{
				_o.Passengers.Add(this.Passengers(i));
			}
			_o.MatchNone = this.MatchNone;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06034638 RID: 214584 RVA: 0x0070E248 File Offset: 0x0070C448
		public static Offset<IPlayVoicePassengersConfig> Pack(FlatBufferBuilder builder, IPlayVoicePassengersConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPlayVoicePassengersConfig>);
			}
			VectorOffset passengersOffset = default(VectorOffset);
			if (_o.Passengers != null)
			{
				int[] data = _o.Passengers.ToArray();
				passengersOffset = IPlayVoicePassengersConfig.CreatePassengersVector(builder, data);
			}
			return IPlayVoicePassengersConfig.CreateIPlayVoicePassengersConfig(builder, passengersOffset, _o.MatchNone, _o.NullMask);
		}

		// Token: 0x0401266E RID: 75374
		private Table __p;
	}
}
