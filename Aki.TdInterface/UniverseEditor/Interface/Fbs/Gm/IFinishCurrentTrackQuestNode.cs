using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x0200464E RID: 17998
	public struct IFinishCurrentTrackQuestNode : IFlatbufferObject
	{
		// Token: 0x17007FB6 RID: 32694
		// (get) Token: 0x0601B447 RID: 111687 RVA: 0x003E1388 File Offset: 0x003DF588
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601B448 RID: 111688 RVA: 0x003E1395 File Offset: 0x003DF595
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601B449 RID: 111689 RVA: 0x003E139C File Offset: 0x003DF59C
		public static IFinishCurrentTrackQuestNode GetRootAsIFinishCurrentTrackQuestNode(ByteBuffer _bb)
		{
			return IFinishCurrentTrackQuestNode.GetRootAsIFinishCurrentTrackQuestNode(_bb, default(IFinishCurrentTrackQuestNode));
		}

		// Token: 0x0601B44A RID: 111690 RVA: 0x003E13B8 File Offset: 0x003DF5B8
		public static IFinishCurrentTrackQuestNode GetRootAsIFinishCurrentTrackQuestNode(ByteBuffer _bb, IFinishCurrentTrackQuestNode obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601B44B RID: 111691 RVA: 0x003E13D5 File Offset: 0x003DF5D5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601B44C RID: 111692 RVA: 0x003E13E4 File Offset: 0x003DF5E4
		public IFinishCurrentTrackQuestNode __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007FB7 RID: 32695
		// (get) Token: 0x0601B44D RID: 111693 RVA: 0x003E13F4 File Offset: 0x003DF5F4
		public EGmCommand Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EGmCommand.SkipToLevelPlayNode;
				}
				return (EGmCommand)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17007FB8 RID: 32696
		// (get) Token: 0x0601B44E RID: 111694 RVA: 0x003E1430 File Offset: 0x003DF630
		public int NodeId
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17007FB9 RID: 32697
		// (get) Token: 0x0601B44F RID: 111695 RVA: 0x003E146C File Offset: 0x003DF66C
		public int NodeIndex
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17007FBA RID: 32698
		// (get) Token: 0x0601B450 RID: 111696 RVA: 0x003E14A8 File Offset: 0x003DF6A8
		public bool IsComplete
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17007FBB RID: 32699
		// (get) Token: 0x0601B451 RID: 111697 RVA: 0x003E14E8 File Offset: 0x003DF6E8
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601B452 RID: 111698 RVA: 0x003E1525 File Offset: 0x003DF725
		public static Offset<IFinishCurrentTrackQuestNode> CreateIFinishCurrentTrackQuestNode(FlatBufferBuilder builder, EGmCommand Type = EGmCommand.SkipToLevelPlayNode, int NodeId = 0, int NodeIndex = 0, bool IsComplete = false, byte NullMask = 0)
		{
			builder.StartTable(5);
			IFinishCurrentTrackQuestNode.AddNodeIndex(builder, NodeIndex);
			IFinishCurrentTrackQuestNode.AddNodeId(builder, NodeId);
			IFinishCurrentTrackQuestNode.AddNullMask(builder, NullMask);
			IFinishCurrentTrackQuestNode.AddIsComplete(builder, IsComplete);
			IFinishCurrentTrackQuestNode.AddType(builder, Type);
			return IFinishCurrentTrackQuestNode.EndIFinishCurrentTrackQuestNode(builder);
		}

		// Token: 0x0601B453 RID: 111699 RVA: 0x003E1559 File Offset: 0x003DF759
		public static void StartIFinishCurrentTrackQuestNode(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x0601B454 RID: 111700 RVA: 0x003E1562 File Offset: 0x003DF762
		public static void AddType(FlatBufferBuilder builder, EGmCommand type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601B455 RID: 111701 RVA: 0x003E156D File Offset: 0x003DF76D
		public static void AddNodeId(FlatBufferBuilder builder, int nodeId)
		{
			builder.AddInt(1, nodeId, 0);
		}

		// Token: 0x0601B456 RID: 111702 RVA: 0x003E1578 File Offset: 0x003DF778
		public static void AddNodeIndex(FlatBufferBuilder builder, int nodeIndex)
		{
			builder.AddInt(2, nodeIndex, 0);
		}

		// Token: 0x0601B457 RID: 111703 RVA: 0x003E1583 File Offset: 0x003DF783
		public static void AddIsComplete(FlatBufferBuilder builder, bool isComplete)
		{
			builder.AddBool(3, isComplete, false);
		}

		// Token: 0x0601B458 RID: 111704 RVA: 0x003E158E File Offset: 0x003DF78E
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x0601B459 RID: 111705 RVA: 0x003E1599 File Offset: 0x003DF799
		public static Offset<IFinishCurrentTrackQuestNode> EndIFinishCurrentTrackQuestNode(FlatBufferBuilder builder)
		{
			return new Offset<IFinishCurrentTrackQuestNode>(builder.EndTable());
		}

		// Token: 0x0601B45A RID: 111706 RVA: 0x003E15A8 File Offset: 0x003DF7A8
		public IFinishCurrentTrackQuestNodeT UnPack()
		{
			IFinishCurrentTrackQuestNodeT finishCurrentTrackQuestNodeT = new IFinishCurrentTrackQuestNodeT();
			this.UnPackTo(finishCurrentTrackQuestNodeT);
			return finishCurrentTrackQuestNodeT;
		}

		// Token: 0x0601B45B RID: 111707 RVA: 0x003E15C3 File Offset: 0x003DF7C3
		public void UnPackTo(IFinishCurrentTrackQuestNodeT _o)
		{
			_o.Type = this.Type;
			_o.NodeId = this.NodeId;
			_o.NodeIndex = this.NodeIndex;
			_o.IsComplete = this.IsComplete;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0601B45C RID: 111708 RVA: 0x003E1604 File Offset: 0x003DF804
		public static Offset<IFinishCurrentTrackQuestNode> Pack(FlatBufferBuilder builder, IFinishCurrentTrackQuestNodeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFinishCurrentTrackQuestNode>);
			}
			return IFinishCurrentTrackQuestNode.CreateIFinishCurrentTrackQuestNode(builder, _o.Type, _o.NodeId, _o.NodeIndex, _o.IsComplete, _o.NullMask);
		}

		// Token: 0x0400C7C6 RID: 51142
		private Table __p;
	}
}
