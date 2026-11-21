using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x02004ADA RID: 19162
	public struct IGoToNode : IFlatbufferObject
	{
		// Token: 0x1700864E RID: 34382
		// (get) Token: 0x0601CDCA RID: 118218 RVA: 0x004104EC File Offset: 0x0040E6EC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601CDCB RID: 118219 RVA: 0x004104F9 File Offset: 0x0040E6F9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601CDCC RID: 118220 RVA: 0x00410500 File Offset: 0x0040E700
		public static IGoToNode GetRootAsIGoToNode(ByteBuffer _bb)
		{
			return IGoToNode.GetRootAsIGoToNode(_bb, default(IGoToNode));
		}

		// Token: 0x0601CDCD RID: 118221 RVA: 0x0041051C File Offset: 0x0040E71C
		public static IGoToNode GetRootAsIGoToNode(ByteBuffer _bb, IGoToNode obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601CDCE RID: 118222 RVA: 0x00410539 File Offset: 0x0040E739
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601CDCF RID: 118223 RVA: 0x00410548 File Offset: 0x0040E748
		public IGoToNode __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700864F RID: 34383
		// (get) Token: 0x0601CDD0 RID: 118224 RVA: 0x00410558 File Offset: 0x0040E758
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

		// Token: 0x17008650 RID: 34384
		// (get) Token: 0x0601CDD1 RID: 118225 RVA: 0x00410594 File Offset: 0x0040E794
		public EGoToNodeTreeType TreeType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return EGoToNodeTreeType.None;
				}
				return (EGoToNodeTreeType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17008651 RID: 34385
		// (get) Token: 0x0601CDD2 RID: 118226 RVA: 0x004105D0 File Offset: 0x0040E7D0
		public int TreeId
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

		// Token: 0x17008652 RID: 34386
		// (get) Token: 0x0601CDD3 RID: 118227 RVA: 0x0041060C File Offset: 0x0040E80C
		public int NodeId
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

		// Token: 0x0601CDD4 RID: 118228 RVA: 0x00410649 File Offset: 0x0040E849
		public static Offset<IGoToNode> CreateIGoToNode(FlatBufferBuilder builder, EGmCommand Type = EGmCommand.SkipToLevelPlayNode, EGoToNodeTreeType TreeType = EGoToNodeTreeType.None, int TreeId = 0, int NodeId = 0)
		{
			builder.StartTable(4);
			IGoToNode.AddNodeId(builder, NodeId);
			IGoToNode.AddTreeId(builder, TreeId);
			IGoToNode.AddTreeType(builder, TreeType);
			IGoToNode.AddType(builder, Type);
			return IGoToNode.EndIGoToNode(builder);
		}

		// Token: 0x0601CDD5 RID: 118229 RVA: 0x00410675 File Offset: 0x0040E875
		public static void StartIGoToNode(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0601CDD6 RID: 118230 RVA: 0x0041067E File Offset: 0x0040E87E
		public static void AddType(FlatBufferBuilder builder, EGmCommand type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601CDD7 RID: 118231 RVA: 0x00410689 File Offset: 0x0040E889
		public static void AddTreeType(FlatBufferBuilder builder, EGoToNodeTreeType treeType)
		{
			builder.AddByte(1, (byte)treeType, 0);
		}

		// Token: 0x0601CDD8 RID: 118232 RVA: 0x00410694 File Offset: 0x0040E894
		public static void AddTreeId(FlatBufferBuilder builder, int treeId)
		{
			builder.AddInt(2, treeId, 0);
		}

		// Token: 0x0601CDD9 RID: 118233 RVA: 0x0041069F File Offset: 0x0040E89F
		public static void AddNodeId(FlatBufferBuilder builder, int nodeId)
		{
			builder.AddInt(3, nodeId, 0);
		}

		// Token: 0x0601CDDA RID: 118234 RVA: 0x004106AA File Offset: 0x0040E8AA
		public static Offset<IGoToNode> EndIGoToNode(FlatBufferBuilder builder)
		{
			return new Offset<IGoToNode>(builder.EndTable());
		}

		// Token: 0x0601CDDB RID: 118235 RVA: 0x004106B8 File Offset: 0x0040E8B8
		public IGoToNodeT UnPack()
		{
			IGoToNodeT goToNodeT = new IGoToNodeT();
			this.UnPackTo(goToNodeT);
			return goToNodeT;
		}

		// Token: 0x0601CDDC RID: 118236 RVA: 0x004106D3 File Offset: 0x0040E8D3
		public void UnPackTo(IGoToNodeT _o)
		{
			_o.Type = this.Type;
			_o.TreeType = this.TreeType;
			_o.TreeId = this.TreeId;
			_o.NodeId = this.NodeId;
		}

		// Token: 0x0601CDDD RID: 118237 RVA: 0x00410708 File Offset: 0x0040E908
		public static Offset<IGoToNode> Pack(FlatBufferBuilder builder, IGoToNodeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IGoToNode>);
			}
			return IGoToNode.CreateIGoToNode(builder, _o.Type, _o.TreeType, _o.TreeId, _o.NodeId);
		}

		// Token: 0x0400D262 RID: 53858
		private Table __p;
	}
}
