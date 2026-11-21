using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006E9F RID: 28319
	public struct IFlowSelectedNode : IFlatbufferObject
	{
		// Token: 0x1700CFB7 RID: 53175
		// (get) Token: 0x06030FC2 RID: 200642 RVA: 0x006A5154 File Offset: 0x006A3354
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06030FC3 RID: 200643 RVA: 0x006A5161 File Offset: 0x006A3361
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06030FC4 RID: 200644 RVA: 0x006A5168 File Offset: 0x006A3368
		public static IFlowSelectedNode GetRootAsIFlowSelectedNode(ByteBuffer _bb)
		{
			return IFlowSelectedNode.GetRootAsIFlowSelectedNode(_bb, default(IFlowSelectedNode));
		}

		// Token: 0x06030FC5 RID: 200645 RVA: 0x006A5184 File Offset: 0x006A3384
		public static IFlowSelectedNode GetRootAsIFlowSelectedNode(ByteBuffer _bb, IFlowSelectedNode obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06030FC6 RID: 200646 RVA: 0x006A51A1 File Offset: 0x006A33A1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06030FC7 RID: 200647 RVA: 0x006A51B0 File Offset: 0x006A33B0
		public IFlowSelectedNode __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CFB8 RID: 53176
		// (get) Token: 0x06030FC8 RID: 200648 RVA: 0x006A51C0 File Offset: 0x006A33C0
		public int FlowId
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

		// Token: 0x1700CFB9 RID: 53177
		// (get) Token: 0x06030FC9 RID: 200649 RVA: 0x006A51FC File Offset: 0x006A33FC
		public int StateId
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

		// Token: 0x1700CFBA RID: 53178
		// (get) Token: 0x06030FCA RID: 200650 RVA: 0x006A5238 File Offset: 0x006A3438
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06030FCB RID: 200651 RVA: 0x006A5274 File Offset: 0x006A3474
		public static Offset<IFlowSelectedNode> CreateIFlowSelectedNode(FlatBufferBuilder builder, int FlowId = 0, int StateId = 0, byte NullMask = 0)
		{
			builder.StartTable(3);
			IFlowSelectedNode.AddStateId(builder, StateId);
			IFlowSelectedNode.AddFlowId(builder, FlowId);
			IFlowSelectedNode.AddNullMask(builder, NullMask);
			return IFlowSelectedNode.EndIFlowSelectedNode(builder);
		}

		// Token: 0x06030FCC RID: 200652 RVA: 0x006A5298 File Offset: 0x006A3498
		public static void StartIFlowSelectedNode(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06030FCD RID: 200653 RVA: 0x006A52A1 File Offset: 0x006A34A1
		public static void AddFlowId(FlatBufferBuilder builder, int flowId)
		{
			builder.AddInt(0, flowId, 0);
		}

		// Token: 0x06030FCE RID: 200654 RVA: 0x006A52AC File Offset: 0x006A34AC
		public static void AddStateId(FlatBufferBuilder builder, int stateId)
		{
			builder.AddInt(1, stateId, 0);
		}

		// Token: 0x06030FCF RID: 200655 RVA: 0x006A52B7 File Offset: 0x006A34B7
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x06030FD0 RID: 200656 RVA: 0x006A52C2 File Offset: 0x006A34C2
		public static Offset<IFlowSelectedNode> EndIFlowSelectedNode(FlatBufferBuilder builder)
		{
			return new Offset<IFlowSelectedNode>(builder.EndTable());
		}

		// Token: 0x06030FD1 RID: 200657 RVA: 0x006A52D0 File Offset: 0x006A34D0
		public IFlowSelectedNodeT UnPack()
		{
			IFlowSelectedNodeT flowSelectedNodeT = new IFlowSelectedNodeT();
			this.UnPackTo(flowSelectedNodeT);
			return flowSelectedNodeT;
		}

		// Token: 0x06030FD2 RID: 200658 RVA: 0x006A52EB File Offset: 0x006A34EB
		public void UnPackTo(IFlowSelectedNodeT _o)
		{
			_o.FlowId = this.FlowId;
			_o.StateId = this.StateId;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06030FD3 RID: 200659 RVA: 0x006A5314 File Offset: 0x006A3514
		public static Offset<IFlowSelectedNode> Pack(FlatBufferBuilder builder, IFlowSelectedNodeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFlowSelectedNode>);
			}
			return IFlowSelectedNode.CreateIFlowSelectedNode(builder, _o.FlowId, _o.StateId, _o.NullMask);
		}

		// Token: 0x04011D90 RID: 73104
		private Table __p;
	}
}
