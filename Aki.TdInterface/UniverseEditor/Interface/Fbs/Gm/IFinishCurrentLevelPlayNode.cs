using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x02004AB3 RID: 19123
	public struct IFinishCurrentLevelPlayNode : IFlatbufferObject
	{
		// Token: 0x170085EA RID: 34282
		// (get) Token: 0x0601CBF6 RID: 117750 RVA: 0x0040D1E1 File Offset: 0x0040B3E1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601CBF7 RID: 117751 RVA: 0x0040D1EE File Offset: 0x0040B3EE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601CBF8 RID: 117752 RVA: 0x0040D1F8 File Offset: 0x0040B3F8
		public static IFinishCurrentLevelPlayNode GetRootAsIFinishCurrentLevelPlayNode(ByteBuffer _bb)
		{
			return IFinishCurrentLevelPlayNode.GetRootAsIFinishCurrentLevelPlayNode(_bb, default(IFinishCurrentLevelPlayNode));
		}

		// Token: 0x0601CBF9 RID: 117753 RVA: 0x0040D214 File Offset: 0x0040B414
		public static IFinishCurrentLevelPlayNode GetRootAsIFinishCurrentLevelPlayNode(ByteBuffer _bb, IFinishCurrentLevelPlayNode obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601CBFA RID: 117754 RVA: 0x0040D231 File Offset: 0x0040B431
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601CBFB RID: 117755 RVA: 0x0040D240 File Offset: 0x0040B440
		public IFinishCurrentLevelPlayNode __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170085EB RID: 34283
		// (get) Token: 0x0601CBFC RID: 117756 RVA: 0x0040D250 File Offset: 0x0040B450
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

		// Token: 0x170085EC RID: 34284
		// (get) Token: 0x0601CBFD RID: 117757 RVA: 0x0040D28C File Offset: 0x0040B48C
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

		// Token: 0x170085ED RID: 34285
		// (get) Token: 0x0601CBFE RID: 117758 RVA: 0x0040D2C8 File Offset: 0x0040B4C8
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

		// Token: 0x170085EE RID: 34286
		// (get) Token: 0x0601CBFF RID: 117759 RVA: 0x0040D304 File Offset: 0x0040B504
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

		// Token: 0x170085EF RID: 34287
		// (get) Token: 0x0601CC00 RID: 117760 RVA: 0x0040D344 File Offset: 0x0040B544
		public bool IsComplete
		{
			get
			{
				int num = this.__p.__offset(12);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170085F0 RID: 34288
		// (get) Token: 0x0601CC01 RID: 117761 RVA: 0x0040D384 File Offset: 0x0040B584
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

		// Token: 0x0601CC02 RID: 117762 RVA: 0x0040D3C1 File Offset: 0x0040B5C1
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

		// Token: 0x0601CC03 RID: 117763 RVA: 0x0040D3FD File Offset: 0x0040B5FD
		public static void StartIFinishCurrentLevelPlayNode(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x0601CC04 RID: 117764 RVA: 0x0040D406 File Offset: 0x0040B606
		public static void AddType(FlatBufferBuilder builder, EGmCommand type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601CC05 RID: 117765 RVA: 0x0040D411 File Offset: 0x0040B611
		public static void AddLevelPlayId(FlatBufferBuilder builder, int levelPlayId)
		{
			builder.AddInt(1, levelPlayId, 0);
		}

		// Token: 0x0601CC06 RID: 117766 RVA: 0x0040D41C File Offset: 0x0040B61C
		public static void AddNodeId(FlatBufferBuilder builder, int nodeId)
		{
			builder.AddInt(2, nodeId, 0);
		}

		// Token: 0x0601CC07 RID: 117767 RVA: 0x0040D427 File Offset: 0x0040B627
		public static void AddNodeIndex(FlatBufferBuilder builder, int nodeIndex)
		{
			builder.AddInt(3, nodeIndex, 0);
		}

		// Token: 0x0601CC08 RID: 117768 RVA: 0x0040D432 File Offset: 0x0040B632
		public static void AddIsComplete(FlatBufferBuilder builder, bool isComplete)
		{
			builder.AddBool(4, isComplete, false);
		}

		// Token: 0x0601CC09 RID: 117769 RVA: 0x0040D43D File Offset: 0x0040B63D
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(5, nullMask, 0);
		}

		// Token: 0x0601CC0A RID: 117770 RVA: 0x0040D448 File Offset: 0x0040B648
		public static Offset<IFinishCurrentLevelPlayNode> EndIFinishCurrentLevelPlayNode(FlatBufferBuilder builder)
		{
			return new Offset<IFinishCurrentLevelPlayNode>(builder.EndTable());
		}

		// Token: 0x0601CC0B RID: 117771 RVA: 0x0040D458 File Offset: 0x0040B658
		public IFinishCurrentLevelPlayNodeT UnPack()
		{
			IFinishCurrentLevelPlayNodeT finishCurrentLevelPlayNodeT = new IFinishCurrentLevelPlayNodeT();
			this.UnPackTo(finishCurrentLevelPlayNodeT);
			return finishCurrentLevelPlayNodeT;
		}

		// Token: 0x0601CC0C RID: 117772 RVA: 0x0040D474 File Offset: 0x0040B674
		public void UnPackTo(IFinishCurrentLevelPlayNodeT _o)
		{
			_o.Type = this.Type;
			_o.LevelPlayId = this.LevelPlayId;
			_o.NodeId = this.NodeId;
			_o.NodeIndex = this.NodeIndex;
			_o.IsComplete = this.IsComplete;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0601CC0D RID: 117773 RVA: 0x0040D4CC File Offset: 0x0040B6CC
		public static Offset<IFinishCurrentLevelPlayNode> Pack(FlatBufferBuilder builder, IFinishCurrentLevelPlayNodeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFinishCurrentLevelPlayNode>);
			}
			return IFinishCurrentLevelPlayNode.CreateIFinishCurrentLevelPlayNode(builder, _o.Type, _o.LevelPlayId, _o.NodeId, _o.NodeIndex, _o.IsComplete, _o.NullMask);
		}

		// Token: 0x0400D1EE RID: 53742
		private Table __p;
	}
}
