using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004664 RID: 18020
	public struct ITrackQuestBranchBoardConfig : IFlatbufferObject
	{
		// Token: 0x17007E3F RID: 32319
		// (get) Token: 0x0601A6EA RID: 108266 RVA: 0x003C36CE File Offset: 0x003C18CE
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601A6EB RID: 108267 RVA: 0x003C36DB File Offset: 0x003C18DB
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601A6EC RID: 108268 RVA: 0x003C36E4 File Offset: 0x003C18E4
		public static ITrackQuestBranchBoardConfig GetRootAsITrackQuestBranchBoardConfig(ByteBuffer _bb)
		{
			return ITrackQuestBranchBoardConfig.GetRootAsITrackQuestBranchBoardConfig(_bb, default(ITrackQuestBranchBoardConfig));
		}

		// Token: 0x0601A6ED RID: 108269 RVA: 0x003C3700 File Offset: 0x003C1900
		public static ITrackQuestBranchBoardConfig GetRootAsITrackQuestBranchBoardConfig(ByteBuffer _bb, ITrackQuestBranchBoardConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601A6EE RID: 108270 RVA: 0x003C371D File Offset: 0x003C191D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601A6EF RID: 108271 RVA: 0x003C372C File Offset: 0x003C192C
		public ITrackQuestBranchBoardConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007E40 RID: 32320
		// (get) Token: 0x0601A6F0 RID: 108272 RVA: 0x003C373C File Offset: 0x003C193C
		public int Id
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17007E41 RID: 32321
		// (get) Token: 0x0601A6F1 RID: 108273 RVA: 0x003C3778 File Offset: 0x003C1978
		public bool EnableAnimation
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17007E42 RID: 32322
		// (get) Token: 0x0601A6F2 RID: 108274 RVA: 0x003C37B8 File Offset: 0x003C19B8
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

		// Token: 0x0601A6F3 RID: 108275 RVA: 0x003C37F4 File Offset: 0x003C19F4
		public static Offset<ITrackQuestBranchBoardConfig> CreateITrackQuestBranchBoardConfig(FlatBufferBuilder builder, int Id = 0, bool EnableAnimation = false, byte NullMask = 0)
		{
			builder.StartTable(3);
			ITrackQuestBranchBoardConfig.AddId(builder, Id);
			ITrackQuestBranchBoardConfig.AddNullMask(builder, NullMask);
			ITrackQuestBranchBoardConfig.AddEnableAnimation(builder, EnableAnimation);
			return ITrackQuestBranchBoardConfig.EndITrackQuestBranchBoardConfig(builder);
		}

		// Token: 0x0601A6F4 RID: 108276 RVA: 0x003C3818 File Offset: 0x003C1A18
		public static void StartITrackQuestBranchBoardConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601A6F5 RID: 108277 RVA: 0x003C3821 File Offset: 0x003C1A21
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(0, id, 0);
		}

		// Token: 0x0601A6F6 RID: 108278 RVA: 0x003C382C File Offset: 0x003C1A2C
		public static void AddEnableAnimation(FlatBufferBuilder builder, bool enableAnimation)
		{
			builder.AddBool(1, enableAnimation, false);
		}

		// Token: 0x0601A6F7 RID: 108279 RVA: 0x003C3837 File Offset: 0x003C1A37
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x0601A6F8 RID: 108280 RVA: 0x003C3842 File Offset: 0x003C1A42
		public static Offset<ITrackQuestBranchBoardConfig> EndITrackQuestBranchBoardConfig(FlatBufferBuilder builder)
		{
			return new Offset<ITrackQuestBranchBoardConfig>(builder.EndTable());
		}

		// Token: 0x0601A6F9 RID: 108281 RVA: 0x003C3850 File Offset: 0x003C1A50
		public ITrackQuestBranchBoardConfigT UnPack()
		{
			ITrackQuestBranchBoardConfigT trackQuestBranchBoardConfigT = new ITrackQuestBranchBoardConfigT();
			this.UnPackTo(trackQuestBranchBoardConfigT);
			return trackQuestBranchBoardConfigT;
		}

		// Token: 0x0601A6FA RID: 108282 RVA: 0x003C386B File Offset: 0x003C1A6B
		public void UnPackTo(ITrackQuestBranchBoardConfigT _o)
		{
			_o.Id = this.Id;
			_o.EnableAnimation = this.EnableAnimation;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0601A6FB RID: 108283 RVA: 0x003C3894 File Offset: 0x003C1A94
		public static Offset<ITrackQuestBranchBoardConfig> Pack(FlatBufferBuilder builder, ITrackQuestBranchBoardConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITrackQuestBranchBoardConfig>);
			}
			return ITrackQuestBranchBoardConfig.CreateITrackQuestBranchBoardConfig(builder, _o.Id, _o.EnableAnimation, _o.NullMask);
		}

		// Token: 0x0400C882 RID: 51330
		private Table __p;
	}
}
