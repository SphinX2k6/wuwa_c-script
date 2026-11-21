using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006F5F RID: 28511
	public struct IHandBookGrantEmojiOption : IFlatbufferObject
	{
		// Token: 0x1700D0E8 RID: 53480
		// (get) Token: 0x0603158C RID: 202124 RVA: 0x006B1776 File Offset: 0x006AF976
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603158D RID: 202125 RVA: 0x006B1783 File Offset: 0x006AF983
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603158E RID: 202126 RVA: 0x006B178C File Offset: 0x006AF98C
		public static IHandBookGrantEmojiOption GetRootAsIHandBookGrantEmojiOption(ByteBuffer _bb)
		{
			return IHandBookGrantEmojiOption.GetRootAsIHandBookGrantEmojiOption(_bb, default(IHandBookGrantEmojiOption));
		}

		// Token: 0x0603158F RID: 202127 RVA: 0x006B17A8 File Offset: 0x006AF9A8
		public static IHandBookGrantEmojiOption GetRootAsIHandBookGrantEmojiOption(ByteBuffer _bb, IHandBookGrantEmojiOption obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06031590 RID: 202128 RVA: 0x006B17C5 File Offset: 0x006AF9C5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06031591 RID: 202129 RVA: 0x006B17D4 File Offset: 0x006AF9D4
		public IHandBookGrantEmojiOption __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D0E9 RID: 53481
		// (get) Token: 0x06031592 RID: 202130 RVA: 0x006B17E4 File Offset: 0x006AF9E4
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

		// Token: 0x06031593 RID: 202131 RVA: 0x006B1820 File Offset: 0x006AFA20
		public int EmojiIds(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700D0EA RID: 53482
		// (get) Token: 0x06031594 RID: 202132 RVA: 0x006B1860 File Offset: 0x006AFA60
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

		// Token: 0x06031595 RID: 202133 RVA: 0x006B188B File Offset: 0x006AFA8B
		public Span<int> GetEmojiIdsBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x06031596 RID: 202134 RVA: 0x006B189A File Offset: 0x006AFA9A
		public int[] GetEmojiIdsArray()
		{
			return this.__p.__vector_as_array<int>(6);
		}

		// Token: 0x06031597 RID: 202135 RVA: 0x006B18A8 File Offset: 0x006AFAA8
		public static Offset<IHandBookGrantEmojiOption> CreateIHandBookGrantEmojiOption(FlatBufferBuilder builder, EHandBookProgressType Type = EHandBookProgressType.GrantEmoji, VectorOffset EmojiIdsOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			IHandBookGrantEmojiOption.AddEmojiIds(builder, EmojiIdsOffset);
			IHandBookGrantEmojiOption.AddType(builder, Type);
			return IHandBookGrantEmojiOption.EndIHandBookGrantEmojiOption(builder);
		}

		// Token: 0x06031598 RID: 202136 RVA: 0x006B18C5 File Offset: 0x006AFAC5
		public static void StartIHandBookGrantEmojiOption(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06031599 RID: 202137 RVA: 0x006B18CE File Offset: 0x006AFACE
		public static void AddType(FlatBufferBuilder builder, EHandBookProgressType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0603159A RID: 202138 RVA: 0x006B18D9 File Offset: 0x006AFAD9
		public static void AddEmojiIds(FlatBufferBuilder builder, VectorOffset emojiIdsOffset)
		{
			builder.AddOffset(1, emojiIdsOffset.Value, 0);
		}

		// Token: 0x0603159B RID: 202139 RVA: 0x006B18EC File Offset: 0x006AFAEC
		public static VectorOffset CreateEmojiIdsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0603159C RID: 202140 RVA: 0x006B1923 File Offset: 0x006AFB23
		public static VectorOffset CreateEmojiIdsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0603159D RID: 202141 RVA: 0x006B193D File Offset: 0x006AFB3D
		public static VectorOffset CreateEmojiIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0603159E RID: 202142 RVA: 0x006B195B File Offset: 0x006AFB5B
		public static VectorOffset CreateEmojiIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0603159F RID: 202143 RVA: 0x006B1974 File Offset: 0x006AFB74
		public static void StartEmojiIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060315A0 RID: 202144 RVA: 0x006B197F File Offset: 0x006AFB7F
		public static Offset<IHandBookGrantEmojiOption> EndIHandBookGrantEmojiOption(FlatBufferBuilder builder)
		{
			return new Offset<IHandBookGrantEmojiOption>(builder.EndTable());
		}

		// Token: 0x060315A1 RID: 202145 RVA: 0x006B198C File Offset: 0x006AFB8C
		public IHandBookGrantEmojiOptionT UnPack()
		{
			IHandBookGrantEmojiOptionT handBookGrantEmojiOptionT = new IHandBookGrantEmojiOptionT();
			this.UnPackTo(handBookGrantEmojiOptionT);
			return handBookGrantEmojiOptionT;
		}

		// Token: 0x060315A2 RID: 202146 RVA: 0x006B19A8 File Offset: 0x006AFBA8
		public void UnPackTo(IHandBookGrantEmojiOptionT _o)
		{
			_o.Type = this.Type;
			_o.EmojiIds = new List<int>();
			for (int i = 0; i < this.EmojiIdsLength; i++)
			{
				_o.EmojiIds.Add(this.EmojiIds(i));
			}
		}

		// Token: 0x060315A3 RID: 202147 RVA: 0x006B19F0 File Offset: 0x006AFBF0
		public static Offset<IHandBookGrantEmojiOption> Pack(FlatBufferBuilder builder, IHandBookGrantEmojiOptionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IHandBookGrantEmojiOption>);
			}
			VectorOffset emojiIdsOffset = default(VectorOffset);
			if (_o.EmojiIds != null)
			{
				int[] data = _o.EmojiIds.ToArray();
				emojiIdsOffset = IHandBookGrantEmojiOption.CreateEmojiIdsVector(builder, data);
			}
			return IHandBookGrantEmojiOption.CreateIHandBookGrantEmojiOption(builder, _o.Type, emojiIdsOffset);
		}

		// Token: 0x04011E6E RID: 73326
		private Table __p;
	}
}
