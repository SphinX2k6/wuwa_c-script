using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007157 RID: 29015
	public struct ILog : IFlatbufferObject
	{
		// Token: 0x1700D454 RID: 54356
		// (get) Token: 0x06032676 RID: 206454 RVA: 0x006D0112 File Offset: 0x006CE312
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06032677 RID: 206455 RVA: 0x006D011F File Offset: 0x006CE31F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06032678 RID: 206456 RVA: 0x006D0128 File Offset: 0x006CE328
		public static ILog GetRootAsILog(ByteBuffer _bb)
		{
			return ILog.GetRootAsILog(_bb, default(ILog));
		}

		// Token: 0x06032679 RID: 206457 RVA: 0x006D0144 File Offset: 0x006CE344
		public static ILog GetRootAsILog(ByteBuffer _bb, ILog obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603267A RID: 206458 RVA: 0x006D0161 File Offset: 0x006CE361
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603267B RID: 206459 RVA: 0x006D0170 File Offset: 0x006CE370
		public ILog __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D455 RID: 54357
		// (get) Token: 0x0603267C RID: 206460 RVA: 0x006D0180 File Offset: 0x006CE380
		public string Level
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0603267D RID: 206461 RVA: 0x006D01B7 File Offset: 0x006CE3B7
		public Span<byte> GetLevelBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0603267E RID: 206462 RVA: 0x006D01C6 File Offset: 0x006CE3C6
		public byte[] GetLevelArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x1700D456 RID: 54358
		// (get) Token: 0x0603267F RID: 206463 RVA: 0x006D01D4 File Offset: 0x006CE3D4
		public string Content
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06032680 RID: 206464 RVA: 0x006D020B File Offset: 0x006CE40B
		public Span<byte> GetContentBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06032681 RID: 206465 RVA: 0x006D021A File Offset: 0x006CE41A
		public byte[] GetContentArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x06032682 RID: 206466 RVA: 0x006D0228 File Offset: 0x006CE428
		public static Offset<ILog> CreateILog(FlatBufferBuilder builder, StringOffset LevelOffset = default(StringOffset), StringOffset ContentOffset = default(StringOffset))
		{
			builder.StartTable(2);
			ILog.AddContent(builder, ContentOffset);
			ILog.AddLevel(builder, LevelOffset);
			return ILog.EndILog(builder);
		}

		// Token: 0x06032683 RID: 206467 RVA: 0x006D0245 File Offset: 0x006CE445
		public static void StartILog(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06032684 RID: 206468 RVA: 0x006D024E File Offset: 0x006CE44E
		public static void AddLevel(FlatBufferBuilder builder, StringOffset levelOffset)
		{
			builder.AddOffset(0, levelOffset.Value, 0);
		}

		// Token: 0x06032685 RID: 206469 RVA: 0x006D025E File Offset: 0x006CE45E
		public static void AddContent(FlatBufferBuilder builder, StringOffset contentOffset)
		{
			builder.AddOffset(1, contentOffset.Value, 0);
		}

		// Token: 0x06032686 RID: 206470 RVA: 0x006D026E File Offset: 0x006CE46E
		public static Offset<ILog> EndILog(FlatBufferBuilder builder)
		{
			return new Offset<ILog>(builder.EndTable());
		}

		// Token: 0x06032687 RID: 206471 RVA: 0x006D027C File Offset: 0x006CE47C
		public ILogT UnPack()
		{
			ILogT logT = new ILogT();
			this.UnPackTo(logT);
			return logT;
		}

		// Token: 0x06032688 RID: 206472 RVA: 0x006D0297 File Offset: 0x006CE497
		public void UnPackTo(ILogT _o)
		{
			_o.Level = this.Level;
			_o.Content = this.Content;
		}

		// Token: 0x06032689 RID: 206473 RVA: 0x006D02B4 File Offset: 0x006CE4B4
		public static Offset<ILog> Pack(FlatBufferBuilder builder, ILogT _o)
		{
			if (_o == null)
			{
				return default(Offset<ILog>);
			}
			StringOffset levelOffset = (_o.Level == null) ? default(StringOffset) : builder.CreateString(_o.Level);
			StringOffset contentOffset = (_o.Content == null) ? default(StringOffset) : builder.CreateString(_o.Content);
			return ILog.CreateILog(builder, levelOffset, contentOffset);
		}

		// Token: 0x0401213C RID: 74044
		private Table __p;
	}
}
