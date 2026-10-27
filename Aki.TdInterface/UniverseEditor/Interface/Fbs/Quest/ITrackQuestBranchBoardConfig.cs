using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004208 RID: 16904
	public struct ITrackQuestBranchBoardConfig : IFlatbufferObject
	{
		// Token: 0x1700780E RID: 30734
		// (get) Token: 0x06018F7E RID: 102270 RVA: 0x00397FF6 File Offset: 0x003961F6
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06018F7F RID: 102271 RVA: 0x00398003 File Offset: 0x00396203
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06018F80 RID: 102272 RVA: 0x0039800C File Offset: 0x0039620C
		public static ITrackQuestBranchBoardConfig GetRootAsITrackQuestBranchBoardConfig(ByteBuffer _bb)
		{
			return ITrackQuestBranchBoardConfig.GetRootAsITrackQuestBranchBoardConfig(_bb, default(ITrackQuestBranchBoardConfig));
		}

		// Token: 0x06018F81 RID: 102273 RVA: 0x00398028 File Offset: 0x00396228
		public static ITrackQuestBranchBoardConfig GetRootAsITrackQuestBranchBoardConfig(ByteBuffer _bb, ITrackQuestBranchBoardConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06018F82 RID: 102274 RVA: 0x00398045 File Offset: 0x00396245
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06018F83 RID: 102275 RVA: 0x00398054 File Offset: 0x00396254
		public ITrackQuestBranchBoardConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700780F RID: 30735
		// (get) Token: 0x06018F84 RID: 102276 RVA: 0x00398064 File Offset: 0x00396264
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

		// Token: 0x17007810 RID: 30736
		// (get) Token: 0x06018F85 RID: 102277 RVA: 0x003980A0 File Offset: 0x003962A0
		public bool EnableAnimation
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17007811 RID: 30737
		// (get) Token: 0x06018F86 RID: 102278 RVA: 0x003980E0 File Offset: 0x003962E0
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

		// Token: 0x06018F87 RID: 102279 RVA: 0x0039811C File Offset: 0x0039631C
		public static Offset<ITrackQuestBranchBoardConfig> CreateITrackQuestBranchBoardConfig(FlatBufferBuilder builder, int Id = 0, bool EnableAnimation = false, byte NullMask = 0)
		{
			builder.StartTable(3);
			ITrackQuestBranchBoardConfig.AddId(builder, Id);
			ITrackQuestBranchBoardConfig.AddNullMask(builder, NullMask);
			ITrackQuestBranchBoardConfig.AddEnableAnimation(builder, EnableAnimation);
			return ITrackQuestBranchBoardConfig.EndITrackQuestBranchBoardConfig(builder);
		}

		// Token: 0x06018F88 RID: 102280 RVA: 0x00398140 File Offset: 0x00396340
		public static void StartITrackQuestBranchBoardConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06018F89 RID: 102281 RVA: 0x00398149 File Offset: 0x00396349
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(0, id, 0);
		}

		// Token: 0x06018F8A RID: 102282 RVA: 0x00398154 File Offset: 0x00396354
		public static void AddEnableAnimation(FlatBufferBuilder builder, bool enableAnimation)
		{
			builder.AddBool(1, enableAnimation, false);
		}

		// Token: 0x06018F8B RID: 102283 RVA: 0x0039815F File Offset: 0x0039635F
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x06018F8C RID: 102284 RVA: 0x0039816A File Offset: 0x0039636A
		public static Offset<ITrackQuestBranchBoardConfig> EndITrackQuestBranchBoardConfig(FlatBufferBuilder builder)
		{
			return new Offset<ITrackQuestBranchBoardConfig>(builder.EndTable());
		}

		// Token: 0x06018F8D RID: 102285 RVA: 0x00398178 File Offset: 0x00396378
		public ITrackQuestBranchBoardConfigT UnPack()
		{
			ITrackQuestBranchBoardConfigT trackQuestBranchBoardConfigT = new ITrackQuestBranchBoardConfigT();
			this.UnPackTo(trackQuestBranchBoardConfigT);
			return trackQuestBranchBoardConfigT;
		}

		// Token: 0x06018F8E RID: 102286 RVA: 0x00398193 File Offset: 0x00396393
		public void UnPackTo(ITrackQuestBranchBoardConfigT _o)
		{
			_o.Id = this.Id;
			_o.EnableAnimation = this.EnableAnimation;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06018F8F RID: 102287 RVA: 0x003981BC File Offset: 0x003963BC
		public static Offset<ITrackQuestBranchBoardConfig> Pack(FlatBufferBuilder builder, ITrackQuestBranchBoardConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITrackQuestBranchBoardConfig>);
			}
			return ITrackQuestBranchBoardConfig.CreateITrackQuestBranchBoardConfig(builder, _o.Id, _o.EnableAnimation, _o.NullMask);
		}

		// Token: 0x0400BE75 RID: 48757
		private Table __p;
	}
}
