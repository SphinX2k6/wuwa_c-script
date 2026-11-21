using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004649 RID: 17993
	public struct ITrackCustomBoardOnBtLogicNode : IFlatbufferObject
	{
		// Token: 0x17007DF9 RID: 32249
		// (get) Token: 0x0601A5BE RID: 107966 RVA: 0x003C0927 File Offset: 0x003BEB27
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601A5BF RID: 107967 RVA: 0x003C0934 File Offset: 0x003BEB34
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601A5C0 RID: 107968 RVA: 0x003C093C File Offset: 0x003BEB3C
		public static ITrackCustomBoardOnBtLogicNode GetRootAsITrackCustomBoardOnBtLogicNode(ByteBuffer _bb)
		{
			return ITrackCustomBoardOnBtLogicNode.GetRootAsITrackCustomBoardOnBtLogicNode(_bb, default(ITrackCustomBoardOnBtLogicNode));
		}

		// Token: 0x0601A5C1 RID: 107969 RVA: 0x003C0958 File Offset: 0x003BEB58
		public static ITrackCustomBoardOnBtLogicNode GetRootAsITrackCustomBoardOnBtLogicNode(ByteBuffer _bb, ITrackCustomBoardOnBtLogicNode obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601A5C2 RID: 107970 RVA: 0x003C0975 File Offset: 0x003BEB75
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601A5C3 RID: 107971 RVA: 0x003C0984 File Offset: 0x003BEB84
		public ITrackCustomBoardOnBtLogicNode __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007DFA RID: 32250
		// (get) Token: 0x0601A5C4 RID: 107972 RVA: 0x003C0994 File Offset: 0x003BEB94
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

		// Token: 0x17007DFB RID: 32251
		// (get) Token: 0x0601A5C5 RID: 107973 RVA: 0x003C09F4 File Offset: 0x003BEBF4
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

		// Token: 0x17007DFC RID: 32252
		// (get) Token: 0x0601A5C6 RID: 107974 RVA: 0x003C0A54 File Offset: 0x003BEC54
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

		// Token: 0x17007DFD RID: 32253
		// (get) Token: 0x0601A5C7 RID: 107975 RVA: 0x003C0AB4 File Offset: 0x003BECB4
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

		// Token: 0x0601A5C8 RID: 107976 RVA: 0x003C0B12 File Offset: 0x003BED12
		public static Offset<ITrackCustomBoardOnBtLogicNode> CreateITrackCustomBoardOnBtLogicNode(FlatBufferBuilder builder, Offset<IFastReturnMapPos> FastReturnMapPosOffset = default(Offset<IFastReturnMapPos>), Offset<ISheriffAnomalyProgressBoardConfig> SheriffAnomalyProgressBoardOffset = default(Offset<ISheriffAnomalyProgressBoardConfig>), Offset<ISheriffMainBoardConfig> SheriffMainBoardOffset = default(Offset<ISheriffMainBoardConfig>), Offset<ISheriffClueDetailBoardConfig> SheriffClueDetailBoardOffset = default(Offset<ISheriffClueDetailBoardConfig>))
		{
			builder.StartTable(4);
			ITrackCustomBoardOnBtLogicNode.AddSheriffClueDetailBoard(builder, SheriffClueDetailBoardOffset);
			ITrackCustomBoardOnBtLogicNode.AddSheriffMainBoard(builder, SheriffMainBoardOffset);
			ITrackCustomBoardOnBtLogicNode.AddSheriffAnomalyProgressBoard(builder, SheriffAnomalyProgressBoardOffset);
			ITrackCustomBoardOnBtLogicNode.AddFastReturnMapPos(builder, FastReturnMapPosOffset);
			return ITrackCustomBoardOnBtLogicNode.EndITrackCustomBoardOnBtLogicNode(builder);
		}

		// Token: 0x0601A5C9 RID: 107977 RVA: 0x003C0B3E File Offset: 0x003BED3E
		public static void StartITrackCustomBoardOnBtLogicNode(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0601A5CA RID: 107978 RVA: 0x003C0B47 File Offset: 0x003BED47
		public static void AddFastReturnMapPos(FlatBufferBuilder builder, Offset<IFastReturnMapPos> fastReturnMapPosOffset)
		{
			builder.AddOffset(0, fastReturnMapPosOffset.Value, 0);
		}

		// Token: 0x0601A5CB RID: 107979 RVA: 0x003C0B57 File Offset: 0x003BED57
		public static void AddSheriffAnomalyProgressBoard(FlatBufferBuilder builder, Offset<ISheriffAnomalyProgressBoardConfig> sheriffAnomalyProgressBoardOffset)
		{
			builder.AddOffset(1, sheriffAnomalyProgressBoardOffset.Value, 0);
		}

		// Token: 0x0601A5CC RID: 107980 RVA: 0x003C0B67 File Offset: 0x003BED67
		public static void AddSheriffMainBoard(FlatBufferBuilder builder, Offset<ISheriffMainBoardConfig> sheriffMainBoardOffset)
		{
			builder.AddOffset(2, sheriffMainBoardOffset.Value, 0);
		}

		// Token: 0x0601A5CD RID: 107981 RVA: 0x003C0B77 File Offset: 0x003BED77
		public static void AddSheriffClueDetailBoard(FlatBufferBuilder builder, Offset<ISheriffClueDetailBoardConfig> sheriffClueDetailBoardOffset)
		{
			builder.AddOffset(3, sheriffClueDetailBoardOffset.Value, 0);
		}

		// Token: 0x0601A5CE RID: 107982 RVA: 0x003C0B87 File Offset: 0x003BED87
		public static Offset<ITrackCustomBoardOnBtLogicNode> EndITrackCustomBoardOnBtLogicNode(FlatBufferBuilder builder)
		{
			return new Offset<ITrackCustomBoardOnBtLogicNode>(builder.EndTable());
		}

		// Token: 0x0601A5CF RID: 107983 RVA: 0x003C0B94 File Offset: 0x003BED94
		public ITrackCustomBoardOnBtLogicNodeT UnPack()
		{
			ITrackCustomBoardOnBtLogicNodeT trackCustomBoardOnBtLogicNodeT = new ITrackCustomBoardOnBtLogicNodeT();
			this.UnPackTo(trackCustomBoardOnBtLogicNodeT);
			return trackCustomBoardOnBtLogicNodeT;
		}

		// Token: 0x0601A5D0 RID: 107984 RVA: 0x003C0BB0 File Offset: 0x003BEDB0
		public void UnPackTo(ITrackCustomBoardOnBtLogicNodeT _o)
		{
			_o.FastReturnMapPos = ((this.FastReturnMapPos != null) ? this.FastReturnMapPos.Value.UnPack() : null);
			_o.SheriffAnomalyProgressBoard = ((this.SheriffAnomalyProgressBoard != null) ? this.SheriffAnomalyProgressBoard.Value.UnPack() : null);
			_o.SheriffMainBoard = ((this.SheriffMainBoard != null) ? this.SheriffMainBoard.Value.UnPack() : null);
			_o.SheriffClueDetailBoard = ((this.SheriffClueDetailBoard != null) ? this.SheriffClueDetailBoard.Value.UnPack() : null);
		}

		// Token: 0x0601A5D1 RID: 107985 RVA: 0x003C0C80 File Offset: 0x003BEE80
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

		// Token: 0x0400C856 RID: 51286
		private Table __p;
	}
}
