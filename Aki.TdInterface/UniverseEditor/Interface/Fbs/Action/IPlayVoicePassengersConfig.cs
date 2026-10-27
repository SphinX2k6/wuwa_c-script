using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006D44 RID: 27972
	public struct IPlayVoicePassengersConfig : IFlatbufferObject
	{
		// Token: 0x1700D099 RID: 53401
		// (get) Token: 0x06031623 RID: 202275 RVA: 0x006B2886 File Offset: 0x006B0A86
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06031624 RID: 202276 RVA: 0x006B2893 File Offset: 0x006B0A93
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06031625 RID: 202277 RVA: 0x006B289C File Offset: 0x006B0A9C
		public static IPlayVoicePassengersConfig GetRootAsIPlayVoicePassengersConfig(ByteBuffer _bb)
		{
			return IPlayVoicePassengersConfig.GetRootAsIPlayVoicePassengersConfig(_bb, default(IPlayVoicePassengersConfig));
		}

		// Token: 0x06031626 RID: 202278 RVA: 0x006B28B8 File Offset: 0x006B0AB8
		public static IPlayVoicePassengersConfig GetRootAsIPlayVoicePassengersConfig(ByteBuffer _bb, IPlayVoicePassengersConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06031627 RID: 202279 RVA: 0x006B28D5 File Offset: 0x006B0AD5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06031628 RID: 202280 RVA: 0x006B28E4 File Offset: 0x006B0AE4
		public IPlayVoicePassengersConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x06031629 RID: 202281 RVA: 0x006B28F4 File Offset: 0x006B0AF4
		public int Passengers(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700D09A RID: 53402
		// (get) Token: 0x0603162A RID: 202282 RVA: 0x006B2934 File Offset: 0x006B0B34
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

		// Token: 0x0603162B RID: 202283 RVA: 0x006B295F File Offset: 0x006B0B5F
		public Span<int> GetPassengersBytes()
		{
			return this.__p.__vector_as_span<int>(4, 4);
		}

		// Token: 0x0603162C RID: 202284 RVA: 0x006B296E File Offset: 0x006B0B6E
		public int[] GetPassengersArray()
		{
			return this.__p.__vector_as_array<int>(4);
		}

		// Token: 0x1700D09B RID: 53403
		// (get) Token: 0x0603162D RID: 202285 RVA: 0x006B297C File Offset: 0x006B0B7C
		public bool MatchNone
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700D09C RID: 53404
		// (get) Token: 0x0603162E RID: 202286 RVA: 0x006B29BC File Offset: 0x006B0BBC
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

		// Token: 0x0603162F RID: 202287 RVA: 0x006B29F8 File Offset: 0x006B0BF8
		public static Offset<IPlayVoicePassengersConfig> CreateIPlayVoicePassengersConfig(FlatBufferBuilder builder, VectorOffset PassengersOffset = default(VectorOffset), bool MatchNone = false, byte NullMask = 0)
		{
			builder.StartTable(3);
			IPlayVoicePassengersConfig.AddPassengers(builder, PassengersOffset);
			IPlayVoicePassengersConfig.AddNullMask(builder, NullMask);
			IPlayVoicePassengersConfig.AddMatchNone(builder, MatchNone);
			return IPlayVoicePassengersConfig.EndIPlayVoicePassengersConfig(builder);
		}

		// Token: 0x06031630 RID: 202288 RVA: 0x006B2A1C File Offset: 0x006B0C1C
		public static void StartIPlayVoicePassengersConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06031631 RID: 202289 RVA: 0x006B2A25 File Offset: 0x006B0C25
		public static void AddPassengers(FlatBufferBuilder builder, VectorOffset passengersOffset)
		{
			builder.AddOffset(0, passengersOffset.Value, 0);
		}

		// Token: 0x06031632 RID: 202290 RVA: 0x006B2A38 File Offset: 0x006B0C38
		public static VectorOffset CreatePassengersVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06031633 RID: 202291 RVA: 0x006B2A6F File Offset: 0x006B0C6F
		public static VectorOffset CreatePassengersVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06031634 RID: 202292 RVA: 0x006B2A89 File Offset: 0x006B0C89
		public static VectorOffset CreatePassengersVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06031635 RID: 202293 RVA: 0x006B2AA7 File Offset: 0x006B0CA7
		public static VectorOffset CreatePassengersVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06031636 RID: 202294 RVA: 0x006B2AC0 File Offset: 0x006B0CC0
		public static void StartPassengersVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06031637 RID: 202295 RVA: 0x006B2ACB File Offset: 0x006B0CCB
		public static void AddMatchNone(FlatBufferBuilder builder, bool matchNone)
		{
			builder.AddBool(1, matchNone, false);
		}

		// Token: 0x06031638 RID: 202296 RVA: 0x006B2AD6 File Offset: 0x006B0CD6
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x06031639 RID: 202297 RVA: 0x006B2AE1 File Offset: 0x006B0CE1
		public static Offset<IPlayVoicePassengersConfig> EndIPlayVoicePassengersConfig(FlatBufferBuilder builder)
		{
			return new Offset<IPlayVoicePassengersConfig>(builder.EndTable());
		}

		// Token: 0x0603163A RID: 202298 RVA: 0x006B2AF0 File Offset: 0x006B0CF0
		public IPlayVoicePassengersConfigT UnPack()
		{
			IPlayVoicePassengersConfigT playVoicePassengersConfigT = new IPlayVoicePassengersConfigT();
			this.UnPackTo(playVoicePassengersConfigT);
			return playVoicePassengersConfigT;
		}

		// Token: 0x0603163B RID: 202299 RVA: 0x006B2B0C File Offset: 0x006B0D0C
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

		// Token: 0x0603163C RID: 202300 RVA: 0x006B2B60 File Offset: 0x006B0D60
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

		// Token: 0x040116F2 RID: 71410
		private Table __p;
	}
}
