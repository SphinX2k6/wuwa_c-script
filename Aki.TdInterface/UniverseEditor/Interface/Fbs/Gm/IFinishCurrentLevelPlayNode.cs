using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x0200464B RID: 17995
	public struct IFinishCurrentLevelPlayNode : IFlatbufferObject
	{
		// Token: 0x17007FA9 RID: 32681
		// (get) Token: 0x0601B421 RID: 111649 RVA: 0x003E0F45 File Offset: 0x003DF145
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601B422 RID: 111650 RVA: 0x003E0F52 File Offset: 0x003DF152
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601B423 RID: 111651 RVA: 0x003E0F5C File Offset: 0x003DF15C
		public static IFinishCurrentLevelPlayNode GetRootAsIFinishCurrentLevelPlayNode(ByteBuffer _bb)
		{
			return IFinishCurrentLevelPlayNode.GetRootAsIFinishCurrentLevelPlayNode(_bb, default(IFinishCurrentLevelPlayNode));
		}

		// Token: 0x0601B424 RID: 111652 RVA: 0x003E0F78 File Offset: 0x003DF178
		public static IFinishCurrentLevelPlayNode GetRootAsIFinishCurrentLevelPlayNode(ByteBuffer _bb, IFinishCurrentLevelPlayNode obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601B425 RID: 111653 RVA: 0x003E0F95 File Offset: 0x003DF195
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601B426 RID: 111654 RVA: 0x003E0FA4 File Offset: 0x003DF1A4
		public IFinishCurrentLevelPlayNode __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007FAA RID: 32682
		// (get) Token: 0x0601B427 RID: 111655 RVA: 0x003E0FB4 File Offset: 0x003DF1B4
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

		// Token: 0x17007FAB RID: 32683
		// (get) Token: 0x0601B428 RID: 111656 RVA: 0x003E0FF0 File Offset: 0x003DF1F0
		public int LevelPlayId
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

		// Token: 0x17007FAC RID: 32684
		// (get) Token: 0x0601B429 RID: 111657 RVA: 0x003E102C File Offset: 0x003DF22C
		public int NodeId
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

		// Token: 0x17007FAD RID: 32685
		// (get) Token: 0x0601B42A RID: 111658 RVA: 0x003E1068 File Offset: 0x003DF268
		public int NodeIndex
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17007FAE RID: 32686
		// (get) Token: 0x0601B42B RID: 111659 RVA: 0x003E10A8 File Offset: 0x003DF2A8
		public bool IsComplete
		{
			get
			{
				int num = this.__p.__offset(12);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17007FAF RID: 32687
		// (get) Token: 0x0601B42C RID: 111660 RVA: 0x003E10E8 File Offset: 0x003DF2E8
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601B42D RID: 111661 RVA: 0x003E1125 File Offset: 0x003DF325
		public static Offset<IFinishCurrentLevelPlayNode> CreateIFinishCurrentLevelPlayNode(FlatBufferBuilder builder, EGmCommand Type = EGmCommand.SkipToLevelPlayNode, int LevelPlayId = 0, int NodeId = 0, int NodeIndex = 0, bool IsComplete = false, byte NullMask = 0)
		{
			builder.StartTable(6);
			IFinishCurrentLevelPlayNode.AddNodeIndex(builder, NodeIndex);
			IFinishCurrentLevelPlayNode.AddNodeId(builder, NodeId);
			IFinishCurrentLevelPlayNode.AddLevelPlayId(builder, LevelPlayId);
			IFinishCurrentLevelPlayNode.AddNullMask(builder, NullMask);
			IFinishCurrentLevelPlayNode.AddIsComplete(builder, IsComplete);
			IFinishCurrentLevelPlayNode.AddType(builder, Type);
			return IFinishCurrentLevelPlayNode.EndIFinishCurrentLevelPlayNode(builder);
		}

		// Token: 0x0601B42E RID: 111662 RVA: 0x003E1161 File Offset: 0x003DF361
		public static void StartIFinishCurrentLevelPlayNode(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x0601B42F RID: 111663 RVA: 0x003E116A File Offset: 0x003DF36A
		public static void AddType(FlatBufferBuilder builder, EGmCommand type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601B430 RID: 111664 RVA: 0x003E1175 File Offset: 0x003DF375
		public static void AddLevelPlayId(FlatBufferBuilder builder, int levelPlayId)
		{
			builder.AddInt(1, levelPlayId, 0);
		}

		// Token: 0x0601B431 RID: 111665 RVA: 0x003E1180 File Offset: 0x003DF380
		public static void AddNodeId(FlatBufferBuilder builder, int nodeId)
		{
			builder.AddInt(2, nodeId, 0);
		}

		// Token: 0x0601B432 RID: 111666 RVA: 0x003E118B File Offset: 0x003DF38B
		public static void AddNodeIndex(FlatBufferBuilder builder, int nodeIndex)
		{
			builder.AddInt(3, nodeIndex, 0);
		}

		// Token: 0x0601B433 RID: 111667 RVA: 0x003E1196 File Offset: 0x003DF396
		public static void AddIsComplete(FlatBufferBuilder builder, bool isComplete)
		{
			builder.AddBool(4, isComplete, false);
		}

		// Token: 0x0601B434 RID: 111668 RVA: 0x003E11A1 File Offset: 0x003DF3A1
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(5, nullMask, 0);
		}

		// Token: 0x0601B435 RID: 111669 RVA: 0x003E11AC File Offset: 0x003DF3AC
		public static Offset<IFinishCurrentLevelPlayNode> EndIFinishCurrentLevelPlayNode(FlatBufferBuilder builder)
		{
			return new Offset<IFinishCurrentLevelPlayNode>(builder.EndTable());
		}

		// Token: 0x0601B436 RID: 111670 RVA: 0x003E11BC File Offset: 0x003DF3BC
		public IFinishCurrentLevelPlayNodeT UnPack()
		{
			IFinishCurrentLevelPlayNodeT finishCurrentLevelPlayNodeT = new IFinishCurrentLevelPlayNodeT();
			this.UnPackTo(finishCurrentLevelPlayNodeT);
			return finishCurrentLevelPlayNodeT;
		}

		// Token: 0x0601B437 RID: 111671 RVA: 0x003E11D8 File Offset: 0x003DF3D8
		public void UnPackTo(IFinishCurrentLevelPlayNodeT _o)
		{
			_o.Type = this.Type;
			_o.LevelPlayId = this.LevelPlayId;
			_o.NodeId = this.NodeId;
			_o.NodeIndex = this.NodeIndex;
			_o.IsComplete = this.IsComplete;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0601B438 RID: 111672 RVA: 0x003E1230 File Offset: 0x003DF430
		public static Offset<IFinishCurrentLevelPlayNode> Pack(FlatBufferBuilder builder, IFinishCurrentLevelPlayNodeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFinishCurrentLevelPlayNode>);
			}
			return IFinishCurrentLevelPlayNode.CreateIFinishCurrentLevelPlayNode(builder, _o.Type, _o.LevelPlayId, _o.NodeId, _o.NodeIndex, _o.IsComplete, _o.NullMask);
		}

		// Token: 0x0400C7BF RID: 51135
		private Table __p;
	}
}
