using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200465B RID: 18011
	public struct ITrackHandBookBoardConfig : IFlatbufferObject
	{
		// Token: 0x17007E22 RID: 32290
		// (get) Token: 0x0601A674 RID: 108148 RVA: 0x003C2375 File Offset: 0x003C0575
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601A675 RID: 108149 RVA: 0x003C2382 File Offset: 0x003C0582
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601A676 RID: 108150 RVA: 0x003C238C File Offset: 0x003C058C
		public static ITrackHandBookBoardConfig GetRootAsITrackHandBookBoardConfig(ByteBuffer _bb)
		{
			return ITrackHandBookBoardConfig.GetRootAsITrackHandBookBoardConfig(_bb, default(ITrackHandBookBoardConfig));
		}

		// Token: 0x0601A677 RID: 108151 RVA: 0x003C23A8 File Offset: 0x003C05A8
		public static ITrackHandBookBoardConfig GetRootAsITrackHandBookBoardConfig(ByteBuffer _bb, ITrackHandBookBoardConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601A678 RID: 108152 RVA: 0x003C23C5 File Offset: 0x003C05C5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601A679 RID: 108153 RVA: 0x003C23D4 File Offset: 0x003C05D4
		public ITrackHandBookBoardConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007E23 RID: 32291
		// (get) Token: 0x0601A67A RID: 108154 RVA: 0x003C23E4 File Offset: 0x003C05E4
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

		// Token: 0x0601A67B RID: 108155 RVA: 0x003C2420 File Offset: 0x003C0620
		public static Offset<ITrackHandBookBoardConfig> CreateITrackHandBookBoardConfig(FlatBufferBuilder builder, int Id = 0)
		{
			builder.StartTable(1);
			ITrackHandBookBoardConfig.AddId(builder, Id);
			return ITrackHandBookBoardConfig.EndITrackHandBookBoardConfig(builder);
		}

		// Token: 0x0601A67C RID: 108156 RVA: 0x003C2436 File Offset: 0x003C0636
		public static void StartITrackHandBookBoardConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601A67D RID: 108157 RVA: 0x003C243F File Offset: 0x003C063F
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(0, id, 0);
		}

		// Token: 0x0601A67E RID: 108158 RVA: 0x003C244A File Offset: 0x003C064A
		public static Offset<ITrackHandBookBoardConfig> EndITrackHandBookBoardConfig(FlatBufferBuilder builder)
		{
			return new Offset<ITrackHandBookBoardConfig>(builder.EndTable());
		}

		// Token: 0x0601A67F RID: 108159 RVA: 0x003C2458 File Offset: 0x003C0658
		public ITrackHandBookBoardConfigT UnPack()
		{
			ITrackHandBookBoardConfigT trackHandBookBoardConfigT = new ITrackHandBookBoardConfigT();
			this.UnPackTo(trackHandBookBoardConfigT);
			return trackHandBookBoardConfigT;
		}

		// Token: 0x0601A680 RID: 108160 RVA: 0x003C2473 File Offset: 0x003C0673
		public void UnPackTo(ITrackHandBookBoardConfigT _o)
		{
			_o.Id = this.Id;
		}

		// Token: 0x0601A681 RID: 108161 RVA: 0x003C2484 File Offset: 0x003C0684
		public static Offset<ITrackHandBookBoardConfig> Pack(FlatBufferBuilder builder, ITrackHandBookBoardConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITrackHandBookBoardConfig>);
			}
			return ITrackHandBookBoardConfig.CreateITrackHandBookBoardConfig(builder, _o.Id);
		}

		// Token: 0x0400C872 RID: 51314
		private Table __p;
	}
}
