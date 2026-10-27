using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020041F0 RID: 16880
	public struct ITrackCustomBoardOnBtLogicNode : IFlatbufferObject
	{
		// Token: 0x170077CB RID: 30667
		// (get) Token: 0x06018E64 RID: 101988 RVA: 0x003953C5 File Offset: 0x003935C5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06018E65 RID: 101989 RVA: 0x003953D2 File Offset: 0x003935D2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06018E66 RID: 101990 RVA: 0x003953DC File Offset: 0x003935DC
		public static ITrackCustomBoardOnBtLogicNode GetRootAsITrackCustomBoardOnBtLogicNode(ByteBuffer _bb)
		{
			return ITrackCustomBoardOnBtLogicNode.GetRootAsITrackCustomBoardOnBtLogicNode(_bb, default(ITrackCustomBoardOnBtLogicNode));
		}

		// Token: 0x06018E67 RID: 101991 RVA: 0x003953F8 File Offset: 0x003935F8
		public static ITrackCustomBoardOnBtLogicNode GetRootAsITrackCustomBoardOnBtLogicNode(ByteBuffer _bb, ITrackCustomBoardOnBtLogicNode obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06018E68 RID: 101992 RVA: 0x00395415 File Offset: 0x00393615
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06018E69 RID: 101993 RVA: 0x00395424 File Offset: 0x00393624
		public ITrackCustomBoardOnBtLogicNode __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170077CC RID: 30668
		// (get) Token: 0x06018E6A RID: 101994 RVA: 0x00395434 File Offset: 0x00393634
		public IFastReturnMapPos? FastReturnMapPos
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return new IFastReturnMapPos?(default(IFastReturnMapPos).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x170077CD RID: 30669
		// (get) Token: 0x06018E6B RID: 101995 RVA: 0x00395494 File Offset: 0x00393694
		public ISheriffAnomalyProgressBoardConfig? SheriffAnomalyProgressBoard
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new ISheriffAnomalyProgressBoardConfig?(default(ISheriffAnomalyProgressBoardConfig).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x170077CE RID: 30670
		// (get) Token: 0x06018E6C RID: 101996 RVA: 0x003954F4 File Offset: 0x003936F4
		public ISheriffMainBoardConfig? SheriffMainBoard
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return new ISheriffMainBoardConfig?(default(ISheriffMainBoardConfig).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x170077CF RID: 30671
		// (get) Token: 0x06018E6D RID: 101997 RVA: 0x00395554 File Offset: 0x00393754
		public ISheriffClueDetailBoardConfig? SheriffClueDetailBoard
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return new ISheriffClueDetailBoardConfig?(default(ISheriffClueDetailBoardConfig).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x06018E6E RID: 101998 RVA: 0x003955B2 File Offset: 0x003937B2
		public static Offset<ITrackCustomBoardOnBtLogicNode> CreateITrackCustomBoardOnBtLogicNode(FlatBufferBuilder builder, Offset<IFastReturnMapPos> FastReturnMapPosOffset = default(Offset<IFastReturnMapPos>), Offset<ISheriffAnomalyProgressBoardConfig> SheriffAnomalyProgressBoardOffset = default(Offset<ISheriffAnomalyProgressBoardConfig>), Offset<ISheriffMainBoardConfig> SheriffMainBoardOffset = default(Offset<ISheriffMainBoardConfig>), Offset<ISheriffClueDetailBoardConfig> SheriffClueDetailBoardOffset = default(Offset<ISheriffClueDetailBoardConfig>))
		{
			builder.StartTable(4);
			ITrackCustomBoardOnBtLogicNode.AddSheriffClueDetailBoard(builder, SheriffClueDetailBoardOffset);
			ITrackCustomBoardOnBtLogicNode.AddSheriffMainBoard(builder, SheriffMainBoardOffset);
			ITrackCustomBoardOnBtLogicNode.AddSheriffAnomalyProgressBoard(builder, SheriffAnomalyProgressBoardOffset);
			ITrackCustomBoardOnBtLogicNode.AddFastReturnMapPos(builder, FastReturnMapPosOffset);
			return ITrackCustomBoardOnBtLogicNode.EndITrackCustomBoardOnBtLogicNode(builder);
		}

		// Token: 0x06018E6F RID: 101999 RVA: 0x003955DE File Offset: 0x003937DE
		public static void StartITrackCustomBoardOnBtLogicNode(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06018E70 RID: 102000 RVA: 0x003955E7 File Offset: 0x003937E7
		public static void AddFastReturnMapPos(FlatBufferBuilder builder, Offset<IFastReturnMapPos> fastReturnMapPosOffset)
		{
			builder.AddOffset(0, fastReturnMapPosOffset.Value, 0);
		}

		// Token: 0x06018E71 RID: 102001 RVA: 0x003955F7 File Offset: 0x003937F7
		public static void AddSheriffAnomalyProgressBoard(FlatBufferBuilder builder, Offset<ISheriffAnomalyProgressBoardConfig> sheriffAnomalyProgressBoardOffset)
		{
			builder.AddOffset(1, sheriffAnomalyProgressBoardOffset.Value, 0);
		}

		// Token: 0x06018E72 RID: 102002 RVA: 0x00395607 File Offset: 0x00393807
		public static void AddSheriffMainBoard(FlatBufferBuilder builder, Offset<ISheriffMainBoardConfig> sheriffMainBoardOffset)
		{
			builder.AddOffset(2, sheriffMainBoardOffset.Value, 0);
		}

		// Token: 0x06018E73 RID: 102003 RVA: 0x00395617 File Offset: 0x00393817
		public static void AddSheriffClueDetailBoard(FlatBufferBuilder builder, Offset<ISheriffClueDetailBoardConfig> sheriffClueDetailBoardOffset)
		{
			builder.AddOffset(3, sheriffClueDetailBoardOffset.Value, 0);
		}

		// Token: 0x06018E74 RID: 102004 RVA: 0x00395627 File Offset: 0x00393827
		public static Offset<ITrackCustomBoardOnBtLogicNode> EndITrackCustomBoardOnBtLogicNode(FlatBufferBuilder builder)
		{
			return new Offset<ITrackCustomBoardOnBtLogicNode>(builder.EndTable());
		}

		// Token: 0x06018E75 RID: 102005 RVA: 0x00395634 File Offset: 0x00393834
		public ITrackCustomBoardOnBtLogicNodeT UnPack()
		{
			ITrackCustomBoardOnBtLogicNodeT trackCustomBoardOnBtLogicNodeT = new ITrackCustomBoardOnBtLogicNodeT();
			this.UnPackTo(trackCustomBoardOnBtLogicNodeT);
			return trackCustomBoardOnBtLogicNodeT;
		}

		// Token: 0x06018E76 RID: 102006 RVA: 0x00395650 File Offset: 0x00393850
		public void UnPackTo(ITrackCustomBoardOnBtLogicNodeT _o)
		{
			_o.FastReturnMapPos = ((this.FastReturnMapPos != null) ? this.FastReturnMapPos.Value.UnPack() : null);
			_o.SheriffAnomalyProgressBoard = ((this.SheriffAnomalyProgressBoard != null) ? this.SheriffAnomalyProgressBoard.Value.UnPack() : null);
			_o.SheriffMainBoard = ((this.SheriffMainBoard != null) ? this.SheriffMainBoard.Value.UnPack() : null);
			_o.SheriffClueDetailBoard = ((this.SheriffClueDetailBoard != null) ? this.SheriffClueDetailBoard.Value.UnPack() : null);
		}

		// Token: 0x06018E77 RID: 102007 RVA: 0x00395720 File Offset: 0x00393920
		public static Offset<ITrackCustomBoardOnBtLogicNode> Pack(FlatBufferBuilder builder, ITrackCustomBoardOnBtLogicNodeT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITrackCustomBoardOnBtLogicNode>);
			}
			Offset<IFastReturnMapPos> fastReturnMapPosOffset = (_o.FastReturnMapPos == null) ? default(Offset<IFastReturnMapPos>) : IFastReturnMapPos.Pack(builder, _o.FastReturnMapPos);
			Offset<ISheriffAnomalyProgressBoardConfig> sheriffAnomalyProgressBoardOffset = (_o.SheriffAnomalyProgressBoard == null) ? default(Offset<ISheriffAnomalyProgressBoardConfig>) : ISheriffAnomalyProgressBoardConfig.Pack(builder, _o.SheriffAnomalyProgressBoard);
			Offset<ISheriffMainBoardConfig> sheriffMainBoardOffset = (_o.SheriffMainBoard == null) ? default(Offset<ISheriffMainBoardConfig>) : ISheriffMainBoardConfig.Pack(builder, _o.SheriffMainBoard);
			Offset<ISheriffClueDetailBoardConfig> sheriffClueDetailBoardOffset = (_o.SheriffClueDetailBoard == null) ? default(Offset<ISheriffClueDetailBoardConfig>) : ISheriffClueDetailBoardConfig.Pack(builder, _o.SheriffClueDetailBoard);
			return ITrackCustomBoardOnBtLogicNode.CreateITrackCustomBoardOnBtLogicNode(builder, fastReturnMapPosOffset, sheriffAnomalyProgressBoardOffset, sheriffMainBoardOffset, sheriffClueDetailBoardOffset);
		}

		// Token: 0x0400BE4B RID: 48715
		private Table __p;
	}
}
