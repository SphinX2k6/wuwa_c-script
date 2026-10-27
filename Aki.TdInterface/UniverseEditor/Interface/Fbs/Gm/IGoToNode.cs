using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x02004672 RID: 18034
	public struct IGoToNode : IFlatbufferObject
	{
		// Token: 0x1700800D RID: 32781
		// (get) Token: 0x0601B5F5 RID: 112117 RVA: 0x003E4250 File Offset: 0x003E2450
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601B5F6 RID: 112118 RVA: 0x003E425D File Offset: 0x003E245D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601B5F7 RID: 112119 RVA: 0x003E4264 File Offset: 0x003E2464
		public static IGoToNode GetRootAsIGoToNode(ByteBuffer _bb)
		{
			return IGoToNode.GetRootAsIGoToNode(_bb, default(IGoToNode));
		}

		// Token: 0x0601B5F8 RID: 112120 RVA: 0x003E4280 File Offset: 0x003E2480
		public static IGoToNode GetRootAsIGoToNode(ByteBuffer _bb, IGoToNode obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601B5F9 RID: 112121 RVA: 0x003E429D File Offset: 0x003E249D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601B5FA RID: 112122 RVA: 0x003E42AC File Offset: 0x003E24AC
		public IGoToNode __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700800E RID: 32782
		// (get) Token: 0x0601B5FB RID: 112123 RVA: 0x003E42BC File Offset: 0x003E24BC
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

		// Token: 0x1700800F RID: 32783
		// (get) Token: 0x0601B5FC RID: 112124 RVA: 0x003E42F8 File Offset: 0x003E24F8
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

		// Token: 0x17008010 RID: 32784
		// (get) Token: 0x0601B5FD RID: 112125 RVA: 0x003E4334 File Offset: 0x003E2534
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

		// Token: 0x17008011 RID: 32785
		// (get) Token: 0x0601B5FE RID: 112126 RVA: 0x003E4370 File Offset: 0x003E2570
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

		// Token: 0x0601B5FF RID: 112127 RVA: 0x003E43AD File Offset: 0x003E25AD
		public static Offset<IGoToNode> CreateIGoToNode(FlatBufferBuilder builder, EGmCommand Type = EGmCommand.SkipToLevelPlayNode, EGoToNodeTreeType TreeType = EGoToNodeTreeType.None, int TreeId = 0, int NodeId = 0)
		{
			builder.StartTable(4);
			IGoToNode.AddNodeId(builder, NodeId);
			IGoToNode.AddTreeId(builder, TreeId);
			IGoToNode.AddTreeType(builder, TreeType);
			IGoToNode.AddType(builder, Type);
			return IGoToNode.EndIGoToNode(builder);
		}

		// Token: 0x0601B600 RID: 112128 RVA: 0x003E43D9 File Offset: 0x003E25D9
		public static void StartIGoToNode(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0601B601 RID: 112129 RVA: 0x003E43E2 File Offset: 0x003E25E2
		public static void AddType(FlatBufferBuilder builder, EGmCommand type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601B602 RID: 112130 RVA: 0x003E43ED File Offset: 0x003E25ED
		public static void AddTreeType(FlatBufferBuilder builder, EGoToNodeTreeType treeType)
		{
			builder.AddByte(1, (byte)treeType, 0);
		}

		// Token: 0x0601B603 RID: 112131 RVA: 0x003E43F8 File Offset: 0x003E25F8
		public static void AddTreeId(FlatBufferBuilder builder, int treeId)
		{
			builder.AddInt(2, treeId, 0);
		}

		// Token: 0x0601B604 RID: 112132 RVA: 0x003E4403 File Offset: 0x003E2603
		public static void AddNodeId(FlatBufferBuilder builder, int nodeId)
		{
			builder.AddInt(3, nodeId, 0);
		}

		// Token: 0x0601B605 RID: 112133 RVA: 0x003E440E File Offset: 0x003E260E
		public static Offset<IGoToNode> EndIGoToNode(FlatBufferBuilder builder)
		{
			return new Offset<IGoToNode>(builder.EndTable());
		}

		// Token: 0x0601B606 RID: 112134 RVA: 0x003E441C File Offset: 0x003E261C
		public IGoToNodeT UnPack()
		{
			IGoToNodeT goToNodeT = new IGoToNodeT();
			this.UnPackTo(goToNodeT);
			return goToNodeT;
		}

		// Token: 0x0601B607 RID: 112135 RVA: 0x003E4437 File Offset: 0x003E2637
		public void UnPackTo(IGoToNodeT _o)
		{
			_o.Type = this.Type;
			_o.TreeType = this.TreeType;
			_o.TreeId = this.TreeId;
			_o.NodeId = this.NodeId;
		}

		// Token: 0x0601B608 RID: 112136 RVA: 0x003E446C File Offset: 0x003E266C
		public static Offset<IGoToNode> Pack(FlatBufferBuilder builder, IGoToNodeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IGoToNode>);
			}
			return IGoToNode.CreateIGoToNode(builder, _o.Type, _o.TreeType, _o.TreeId, _o.NodeId);
		}

		// Token: 0x0400C833 RID: 51251
		private Table __p;
	}
}
