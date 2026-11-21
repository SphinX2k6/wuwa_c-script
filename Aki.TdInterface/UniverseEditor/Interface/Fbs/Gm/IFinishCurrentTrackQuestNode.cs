using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x02004AB6 RID: 19126
	public struct IFinishCurrentTrackQuestNode : IFlatbufferObject
	{
		// Token: 0x170085F7 RID: 34295
		// (get) Token: 0x0601CC1C RID: 117788 RVA: 0x0040D624 File Offset: 0x0040B824
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601CC1D RID: 117789 RVA: 0x0040D631 File Offset: 0x0040B831
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601CC1E RID: 117790 RVA: 0x0040D638 File Offset: 0x0040B838
		public static IFinishCurrentTrackQuestNode GetRootAsIFinishCurrentTrackQuestNode(ByteBuffer _bb)
		{
			return IFinishCurrentTrackQuestNode.GetRootAsIFinishCurrentTrackQuestNode(_bb, default(IFinishCurrentTrackQuestNode));
		}

		// Token: 0x0601CC1F RID: 117791 RVA: 0x0040D654 File Offset: 0x0040B854
		public static IFinishCurrentTrackQuestNode GetRootAsIFinishCurrentTrackQuestNode(ByteBuffer _bb, IFinishCurrentTrackQuestNode obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601CC20 RID: 117792 RVA: 0x0040D671 File Offset: 0x0040B871
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601CC21 RID: 117793 RVA: 0x0040D680 File Offset: 0x0040B880
		public IFinishCurrentTrackQuestNode __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170085F8 RID: 34296
		// (get) Token: 0x0601CC22 RID: 117794 RVA: 0x0040D690 File Offset: 0x0040B890
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

		// Token: 0x170085F9 RID: 34297
		// (get) Token: 0x0601CC23 RID: 117795 RVA: 0x0040D6CC File Offset: 0x0040B8CC
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

		// Token: 0x170085FA RID: 34298
		// (get) Token: 0x0601CC24 RID: 117796 RVA: 0x0040D708 File Offset: 0x0040B908
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

		// Token: 0x170085FB RID: 34299
		// (get) Token: 0x0601CC25 RID: 117797 RVA: 0x0040D744 File Offset: 0x0040B944
		public bool IsComplete
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170085FC RID: 34300
		// (get) Token: 0x0601CC26 RID: 117798 RVA: 0x0040D784 File Offset: 0x0040B984
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

		// Token: 0x0601CC27 RID: 117799 RVA: 0x0040D7C1 File Offset: 0x0040B9C1
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

		// Token: 0x0601CC28 RID: 117800 RVA: 0x0040D7F5 File Offset: 0x0040B9F5
		public static void StartIFinishCurrentTrackQuestNode(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x0601CC29 RID: 117801 RVA: 0x0040D7FE File Offset: 0x0040B9FE
		public static void AddType(FlatBufferBuilder builder, EGmCommand type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601CC2A RID: 117802 RVA: 0x0040D809 File Offset: 0x0040BA09
		public static void AddNodeId(FlatBufferBuilder builder, int nodeId)
		{
			builder.AddInt(1, nodeId, 0);
		}

		// Token: 0x0601CC2B RID: 117803 RVA: 0x0040D814 File Offset: 0x0040BA14
		public static void AddNodeIndex(FlatBufferBuilder builder, int nodeIndex)
		{
			builder.AddInt(2, nodeIndex, 0);
		}

		// Token: 0x0601CC2C RID: 117804 RVA: 0x0040D81F File Offset: 0x0040BA1F
		public static void AddIsComplete(FlatBufferBuilder builder, bool isComplete)
		{
			builder.AddBool(3, isComplete, false);
		}

		// Token: 0x0601CC2D RID: 117805 RVA: 0x0040D82A File Offset: 0x0040BA2A
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x0601CC2E RID: 117806 RVA: 0x0040D835 File Offset: 0x0040BA35
		public static Offset<IFinishCurrentTrackQuestNode> EndIFinishCurrentTrackQuestNode(FlatBufferBuilder builder)
		{
			return new Offset<IFinishCurrentTrackQuestNode>(builder.EndTable());
		}

		// Token: 0x0601CC2F RID: 117807 RVA: 0x0040D844 File Offset: 0x0040BA44
		public IFinishCurrentTrackQuestNodeT UnPack()
		{
			IFinishCurrentTrackQuestNodeT finishCurrentTrackQuestNodeT = new IFinishCurrentTrackQuestNodeT();
			this.UnPackTo(finishCurrentTrackQuestNodeT);
			return finishCurrentTrackQuestNodeT;
		}

		// Token: 0x0601CC30 RID: 117808 RVA: 0x0040D85F File Offset: 0x0040BA5F
		public void UnPackTo(IFinishCurrentTrackQuestNodeT _o)
		{
			_o.Type = this.Type;
			_o.NodeId = this.NodeId;
			_o.NodeIndex = this.NodeIndex;
			_o.IsComplete = this.IsComplete;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0601CC31 RID: 117809 RVA: 0x0040D8A0 File Offset: 0x0040BAA0
		public static Offset<IFinishCurrentTrackQuestNode> Pack(FlatBufferBuilder builder, IFinishCurrentTrackQuestNodeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFinishCurrentTrackQuestNode>);
			}
			return IFinishCurrentTrackQuestNode.CreateIFinishCurrentTrackQuestNode(builder, _o.Type, _o.NodeId, _o.NodeIndex, _o.IsComplete, _o.NullMask);
		}

		// Token: 0x0400D1F5 RID: 53749
		private Table __p;
	}
}
