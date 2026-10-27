using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x02004651 RID: 18001
	public struct IFinishCurTrackDungeonNode : IFlatbufferObject
	{
		// Token: 0x17007FC1 RID: 32705
		// (get) Token: 0x0601B469 RID: 111721 RVA: 0x003E1730 File Offset: 0x003DF930
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601B46A RID: 111722 RVA: 0x003E173D File Offset: 0x003DF93D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601B46B RID: 111723 RVA: 0x003E1744 File Offset: 0x003DF944
		public static IFinishCurTrackDungeonNode GetRootAsIFinishCurTrackDungeonNode(ByteBuffer _bb)
		{
			return IFinishCurTrackDungeonNode.GetRootAsIFinishCurTrackDungeonNode(_bb, default(IFinishCurTrackDungeonNode));
		}

		// Token: 0x0601B46C RID: 111724 RVA: 0x003E1760 File Offset: 0x003DF960
		public static IFinishCurTrackDungeonNode GetRootAsIFinishCurTrackDungeonNode(ByteBuffer _bb, IFinishCurTrackDungeonNode obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601B46D RID: 111725 RVA: 0x003E177D File Offset: 0x003DF97D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601B46E RID: 111726 RVA: 0x003E178C File Offset: 0x003DF98C
		public IFinishCurTrackDungeonNode __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007FC2 RID: 32706
		// (get) Token: 0x0601B46F RID: 111727 RVA: 0x003E179C File Offset: 0x003DF99C
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

		// Token: 0x17007FC3 RID: 32707
		// (get) Token: 0x0601B470 RID: 111728 RVA: 0x003E17D8 File Offset: 0x003DF9D8
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

		// Token: 0x17007FC4 RID: 32708
		// (get) Token: 0x0601B471 RID: 111729 RVA: 0x003E1814 File Offset: 0x003DFA14
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

		// Token: 0x17007FC5 RID: 32709
		// (get) Token: 0x0601B472 RID: 111730 RVA: 0x003E1850 File Offset: 0x003DFA50
		public bool IsComplete
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17007FC6 RID: 32710
		// (get) Token: 0x0601B473 RID: 111731 RVA: 0x003E1890 File Offset: 0x003DFA90
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

		// Token: 0x0601B474 RID: 111732 RVA: 0x003E18CD File Offset: 0x003DFACD
		public static Offset<IFinishCurTrackDungeonNode> CreateIFinishCurTrackDungeonNode(FlatBufferBuilder builder, EGmCommand Type = EGmCommand.SkipToLevelPlayNode, int NodeId = 0, int NodeIndex = 0, bool IsComplete = false, byte NullMask = 0)
		{
			builder.StartTable(5);
			IFinishCurTrackDungeonNode.AddNodeIndex(builder, NodeIndex);
			IFinishCurTrackDungeonNode.AddNodeId(builder, NodeId);
			IFinishCurTrackDungeonNode.AddNullMask(builder, NullMask);
			IFinishCurTrackDungeonNode.AddIsComplete(builder, IsComplete);
			IFinishCurTrackDungeonNode.AddType(builder, Type);
			return IFinishCurTrackDungeonNode.EndIFinishCurTrackDungeonNode(builder);
		}

		// Token: 0x0601B475 RID: 111733 RVA: 0x003E1901 File Offset: 0x003DFB01
		public static void StartIFinishCurTrackDungeonNode(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x0601B476 RID: 111734 RVA: 0x003E190A File Offset: 0x003DFB0A
		public static void AddType(FlatBufferBuilder builder, EGmCommand type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601B477 RID: 111735 RVA: 0x003E1915 File Offset: 0x003DFB15
		public static void AddNodeId(FlatBufferBuilder builder, int nodeId)
		{
			builder.AddInt(1, nodeId, 0);
		}

		// Token: 0x0601B478 RID: 111736 RVA: 0x003E1920 File Offset: 0x003DFB20
		public static void AddNodeIndex(FlatBufferBuilder builder, int nodeIndex)
		{
			builder.AddInt(2, nodeIndex, 0);
		}

		// Token: 0x0601B479 RID: 111737 RVA: 0x003E192B File Offset: 0x003DFB2B
		public static void AddIsComplete(FlatBufferBuilder builder, bool isComplete)
		{
			builder.AddBool(3, isComplete, false);
		}

		// Token: 0x0601B47A RID: 111738 RVA: 0x003E1936 File Offset: 0x003DFB36
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x0601B47B RID: 111739 RVA: 0x003E1941 File Offset: 0x003DFB41
		public static Offset<IFinishCurTrackDungeonNode> EndIFinishCurTrackDungeonNode(FlatBufferBuilder builder)
		{
			return new Offset<IFinishCurTrackDungeonNode>(builder.EndTable());
		}

		// Token: 0x0601B47C RID: 111740 RVA: 0x003E1950 File Offset: 0x003DFB50
		public IFinishCurTrackDungeonNodeT UnPack()
		{
			IFinishCurTrackDungeonNodeT finishCurTrackDungeonNodeT = new IFinishCurTrackDungeonNodeT();
			this.UnPackTo(finishCurTrackDungeonNodeT);
			return finishCurTrackDungeonNodeT;
		}

		// Token: 0x0601B47D RID: 111741 RVA: 0x003E196B File Offset: 0x003DFB6B
		public void UnPackTo(IFinishCurTrackDungeonNodeT _o)
		{
			_o.Type = this.Type;
			_o.NodeId = this.NodeId;
			_o.NodeIndex = this.NodeIndex;
			_o.IsComplete = this.IsComplete;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0601B47E RID: 111742 RVA: 0x003E19AC File Offset: 0x003DFBAC
		public static Offset<IFinishCurTrackDungeonNode> Pack(FlatBufferBuilder builder, IFinishCurTrackDungeonNodeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFinishCurTrackDungeonNode>);
			}
			return IFinishCurTrackDungeonNode.CreateIFinishCurTrackDungeonNode(builder, _o.Type, _o.NodeId, _o.NodeIndex, _o.IsComplete, _o.NullMask);
		}

		// Token: 0x0400C7CC RID: 51148
		private Table __p;
	}
}
