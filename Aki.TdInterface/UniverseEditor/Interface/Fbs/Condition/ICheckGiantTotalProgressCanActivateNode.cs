using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004EFF RID: 20223
	public struct ICheckGiantTotalProgressCanActivateNode : IFlatbufferObject
	{
		// Token: 0x1700906A RID: 36970
		// (get) Token: 0x0601F695 RID: 128661 RVA: 0x00460198 File Offset: 0x0045E398
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601F696 RID: 128662 RVA: 0x004601A5 File Offset: 0x0045E3A5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601F697 RID: 128663 RVA: 0x004601AC File Offset: 0x0045E3AC
		public static ICheckGiantTotalProgressCanActivateNode GetRootAsICheckGiantTotalProgressCanActivateNode(ByteBuffer _bb)
		{
			return ICheckGiantTotalProgressCanActivateNode.GetRootAsICheckGiantTotalProgressCanActivateNode(_bb, default(ICheckGiantTotalProgressCanActivateNode));
		}

		// Token: 0x0601F698 RID: 128664 RVA: 0x004601C8 File Offset: 0x0045E3C8
		public static ICheckGiantTotalProgressCanActivateNode GetRootAsICheckGiantTotalProgressCanActivateNode(ByteBuffer _bb, ICheckGiantTotalProgressCanActivateNode obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601F699 RID: 128665 RVA: 0x004601E5 File Offset: 0x0045E3E5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601F69A RID: 128666 RVA: 0x004601F4 File Offset: 0x0045E3F4
		public ICheckGiantTotalProgressCanActivateNode __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700906B RID: 36971
		// (get) Token: 0x0601F69B RID: 128667 RVA: 0x00460204 File Offset: 0x0045E404
		public ECondition Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECondition.CompareVar;
				}
				return (ECondition)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700906C RID: 36972
		// (get) Token: 0x0601F69C RID: 128668 RVA: 0x00460240 File Offset: 0x0045E440
		public bool HasActivateNode
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0601F69D RID: 128669 RVA: 0x0046027F File Offset: 0x0045E47F
		public static Offset<ICheckGiantTotalProgressCanActivateNode> CreateICheckGiantTotalProgressCanActivateNode(FlatBufferBuilder builder, ECondition Type = ECondition.CompareVar, bool HasActivateNode = false)
		{
			builder.StartTable(2);
			ICheckGiantTotalProgressCanActivateNode.AddHasActivateNode(builder, HasActivateNode);
			ICheckGiantTotalProgressCanActivateNode.AddType(builder, Type);
			return ICheckGiantTotalProgressCanActivateNode.EndICheckGiantTotalProgressCanActivateNode(builder);
		}

		// Token: 0x0601F69E RID: 128670 RVA: 0x0046029C File Offset: 0x0045E49C
		public static void StartICheckGiantTotalProgressCanActivateNode(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601F69F RID: 128671 RVA: 0x004602A5 File Offset: 0x0045E4A5
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601F6A0 RID: 128672 RVA: 0x004602B0 File Offset: 0x0045E4B0
		public static void AddHasActivateNode(FlatBufferBuilder builder, bool hasActivateNode)
		{
			builder.AddBool(1, hasActivateNode, false);
		}

		// Token: 0x0601F6A1 RID: 128673 RVA: 0x004602BB File Offset: 0x0045E4BB
		public static Offset<ICheckGiantTotalProgressCanActivateNode> EndICheckGiantTotalProgressCanActivateNode(FlatBufferBuilder builder)
		{
			return new Offset<ICheckGiantTotalProgressCanActivateNode>(builder.EndTable());
		}

		// Token: 0x0601F6A2 RID: 128674 RVA: 0x004602C8 File Offset: 0x0045E4C8
		public ICheckGiantTotalProgressCanActivateNodeT UnPack()
		{
			ICheckGiantTotalProgressCanActivateNodeT checkGiantTotalProgressCanActivateNodeT = new ICheckGiantTotalProgressCanActivateNodeT();
			this.UnPackTo(checkGiantTotalProgressCanActivateNodeT);
			return checkGiantTotalProgressCanActivateNodeT;
		}

		// Token: 0x0601F6A3 RID: 128675 RVA: 0x004602E3 File Offset: 0x0045E4E3
		public void UnPackTo(ICheckGiantTotalProgressCanActivateNodeT _o)
		{
			_o.Type = this.Type;
			_o.HasActivateNode = this.HasActivateNode;
		}

		// Token: 0x0601F6A4 RID: 128676 RVA: 0x00460300 File Offset: 0x0045E500
		public static Offset<ICheckGiantTotalProgressCanActivateNode> Pack(FlatBufferBuilder builder, ICheckGiantTotalProgressCanActivateNodeT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckGiantTotalProgressCanActivateNode>);
			}
			return ICheckGiantTotalProgressCanActivateNode.CreateICheckGiantTotalProgressCanActivateNode(builder, _o.Type, _o.HasActivateNode);
		}

		// Token: 0x0400DD69 RID: 56681
		private Table __p;
	}
}
