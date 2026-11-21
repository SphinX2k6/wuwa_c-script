using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006F6B RID: 28523
	public struct IHandBookRollbackEmojiOption : IFlatbufferObject
	{
		// Token: 0x1700D0F5 RID: 53493
		// (get) Token: 0x060315E0 RID: 202208 RVA: 0x006B205C File Offset: 0x006B025C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060315E1 RID: 202209 RVA: 0x006B2069 File Offset: 0x006B0269
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060315E2 RID: 202210 RVA: 0x006B2070 File Offset: 0x006B0270
		public static IHandBookRollbackEmojiOption GetRootAsIHandBookRollbackEmojiOption(ByteBuffer _bb)
		{
			return IHandBookRollbackEmojiOption.GetRootAsIHandBookRollbackEmojiOption(_bb, default(IHandBookRollbackEmojiOption));
		}

		// Token: 0x060315E3 RID: 202211 RVA: 0x006B208C File Offset: 0x006B028C
		public static IHandBookRollbackEmojiOption GetRootAsIHandBookRollbackEmojiOption(ByteBuffer _bb, IHandBookRollbackEmojiOption obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060315E4 RID: 202212 RVA: 0x006B20A9 File Offset: 0x006B02A9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060315E5 RID: 202213 RVA: 0x006B20B8 File Offset: 0x006B02B8
		public IHandBookRollbackEmojiOption __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D0F6 RID: 53494
		// (get) Token: 0x060315E6 RID: 202214 RVA: 0x006B20C8 File Offset: 0x006B02C8
		public EHandBookProgressType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EHandBookProgressType.GrantEmoji;
				}
				return (EHandBookProgressType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060315E7 RID: 202215 RVA: 0x006B2104 File Offset: 0x006B0304
		public int EmojiIds(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700D0F7 RID: 53495
		// (get) Token: 0x060315E8 RID: 202216 RVA: 0x006B2144 File Offset: 0x006B0344
		public int EmojiIdsLength
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x060315E9 RID: 202217 RVA: 0x006B216F File Offset: 0x006B036F
		public Span<int> GetEmojiIdsBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x060315EA RID: 202218 RVA: 0x006B217E File Offset: 0x006B037E
		public int[] GetEmojiIdsArray()
		{
			return this.__p.__vector_as_array<int>(6);
		}

		// Token: 0x060315EB RID: 202219 RVA: 0x006B218C File Offset: 0x006B038C
		public static Offset<IHandBookRollbackEmojiOption> CreateIHandBookRollbackEmojiOption(FlatBufferBuilder builder, EHandBookProgressType Type = EHandBookProgressType.GrantEmoji, VectorOffset EmojiIdsOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			IHandBookRollbackEmojiOption.AddEmojiIds(builder, EmojiIdsOffset);
			IHandBookRollbackEmojiOption.AddType(builder, Type);
			return IHandBookRollbackEmojiOption.EndIHandBookRollbackEmojiOption(builder);
		}

		// Token: 0x060315EC RID: 202220 RVA: 0x006B21A9 File Offset: 0x006B03A9
		public static void StartIHandBookRollbackEmojiOption(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060315ED RID: 202221 RVA: 0x006B21B2 File Offset: 0x006B03B2
		public static void AddType(FlatBufferBuilder builder, EHandBookProgressType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060315EE RID: 202222 RVA: 0x006B21BD File Offset: 0x006B03BD
		public static void AddEmojiIds(FlatBufferBuilder builder, VectorOffset emojiIdsOffset)
		{
			builder.AddOffset(1, emojiIdsOffset.Value, 0);
		}

		// Token: 0x060315EF RID: 202223 RVA: 0x006B21D0 File Offset: 0x006B03D0
		public static VectorOffset CreateEmojiIdsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x060315F0 RID: 202224 RVA: 0x006B2207 File Offset: 0x006B0407
		public static VectorOffset CreateEmojiIdsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x060315F1 RID: 202225 RVA: 0x006B2221 File Offset: 0x006B0421
		public static VectorOffset CreateEmojiIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x060315F2 RID: 202226 RVA: 0x006B223F File Offset: 0x006B043F
		public static VectorOffset CreateEmojiIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060315F3 RID: 202227 RVA: 0x006B2258 File Offset: 0x006B0458
		public static void StartEmojiIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060315F4 RID: 202228 RVA: 0x006B2263 File Offset: 0x006B0463
		public static Offset<IHandBookRollbackEmojiOption> EndIHandBookRollbackEmojiOption(FlatBufferBuilder builder)
		{
			return new Offset<IHandBookRollbackEmojiOption>(builder.EndTable());
		}

		// Token: 0x060315F5 RID: 202229 RVA: 0x006B2270 File Offset: 0x006B0470
		public IHandBookRollbackEmojiOptionT UnPack()
		{
			IHandBookRollbackEmojiOptionT handBookRollbackEmojiOptionT = new IHandBookRollbackEmojiOptionT();
			this.UnPackTo(handBookRollbackEmojiOptionT);
			return handBookRollbackEmojiOptionT;
		}

		// Token: 0x060315F6 RID: 202230 RVA: 0x006B228C File Offset: 0x006B048C
		public void UnPackTo(IHandBookRollbackEmojiOptionT _o)
		{
			_o.Type = this.Type;
			_o.EmojiIds = new List<int>();
			for (int i = 0; i < this.EmojiIdsLength; i++)
			{
				_o.EmojiIds.Add(this.EmojiIds(i));
			}
		}

		// Token: 0x060315F7 RID: 202231 RVA: 0x006B22D4 File Offset: 0x006B04D4
		public static Offset<IHandBookRollbackEmojiOption> Pack(FlatBufferBuilder builder, IHandBookRollbackEmojiOptionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IHandBookRollbackEmojiOption>);
			}
			VectorOffset emojiIdsOffset = default(VectorOffset);
			if (_o.EmojiIds != null)
			{
				int[] data = _o.EmojiIds.ToArray();
				emojiIdsOffset = IHandBookRollbackEmojiOption.CreateEmojiIdsVector(builder, data);
			}
			return IHandBookRollbackEmojiOption.CreateIHandBookRollbackEmojiOption(builder, _o.Type, emojiIdsOffset);
		}

		// Token: 0x04011E7C RID: 73340
		private Table __p;
	}
}
