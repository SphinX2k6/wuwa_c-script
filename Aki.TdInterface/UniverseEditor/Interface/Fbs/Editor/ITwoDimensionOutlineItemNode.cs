using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x020048B6 RID: 18614
	public struct ITwoDimensionOutlineItemNode : IFlatbufferObject
	{
		// Token: 0x17008700 RID: 34560
		// (get) Token: 0x0601D11A RID: 119066 RVA: 0x0041AD2A File Offset: 0x00418F2A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601D11B RID: 119067 RVA: 0x0041AD37 File Offset: 0x00418F37
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601D11C RID: 119068 RVA: 0x0041AD40 File Offset: 0x00418F40
		public static ITwoDimensionOutlineItemNode GetRootAsITwoDimensionOutlineItemNode(ByteBuffer _bb)
		{
			return ITwoDimensionOutlineItemNode.GetRootAsITwoDimensionOutlineItemNode(_bb, default(ITwoDimensionOutlineItemNode));
		}

		// Token: 0x0601D11D RID: 119069 RVA: 0x0041AD5C File Offset: 0x00418F5C
		public static ITwoDimensionOutlineItemNode GetRootAsITwoDimensionOutlineItemNode(ByteBuffer _bb, ITwoDimensionOutlineItemNode obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601D11E RID: 119070 RVA: 0x0041AD79 File Offset: 0x00418F79
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601D11F RID: 119071 RVA: 0x0041AD88 File Offset: 0x00418F88
		public ITwoDimensionOutlineItemNode __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008701 RID: 34561
		// (get) Token: 0x0601D120 RID: 119072 RVA: 0x0041AD98 File Offset: 0x00418F98
		public ETwoDimensionOutlineNodeType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ETwoDimensionOutlineNodeType.Folder;
				}
				return (ETwoDimensionOutlineNodeType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17008702 RID: 34562
		// (get) Token: 0x0601D121 RID: 119073 RVA: 0x0041ADD4 File Offset: 0x00418FD4
		public int Id
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

		// Token: 0x0601D122 RID: 119074 RVA: 0x0041AE10 File Offset: 0x00419010
		public static Offset<ITwoDimensionOutlineItemNode> CreateITwoDimensionOutlineItemNode(FlatBufferBuilder builder, ETwoDimensionOutlineNodeType Type = ETwoDimensionOutlineNodeType.Folder, int Id = 0)
		{
			builder.StartTable(2);
			ITwoDimensionOutlineItemNode.AddId(builder, Id);
			ITwoDimensionOutlineItemNode.AddType(builder, Type);
			return ITwoDimensionOutlineItemNode.EndITwoDimensionOutlineItemNode(builder);
		}

		// Token: 0x0601D123 RID: 119075 RVA: 0x0041AE2D File Offset: 0x0041902D
		public static void StartITwoDimensionOutlineItemNode(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601D124 RID: 119076 RVA: 0x0041AE36 File Offset: 0x00419036
		public static void AddType(FlatBufferBuilder builder, ETwoDimensionOutlineNodeType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601D125 RID: 119077 RVA: 0x0041AE41 File Offset: 0x00419041
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(1, id, 0);
		}

		// Token: 0x0601D126 RID: 119078 RVA: 0x0041AE4C File Offset: 0x0041904C
		public static Offset<ITwoDimensionOutlineItemNode> EndITwoDimensionOutlineItemNode(FlatBufferBuilder builder)
		{
			return new Offset<ITwoDimensionOutlineItemNode>(builder.EndTable());
		}

		// Token: 0x0601D127 RID: 119079 RVA: 0x0041AE5C File Offset: 0x0041905C
		public ITwoDimensionOutlineItemNodeT UnPack()
		{
			ITwoDimensionOutlineItemNodeT twoDimensionOutlineItemNodeT = new ITwoDimensionOutlineItemNodeT();
			this.UnPackTo(twoDimensionOutlineItemNodeT);
			return twoDimensionOutlineItemNodeT;
		}

		// Token: 0x0601D128 RID: 119080 RVA: 0x0041AE77 File Offset: 0x00419077
		public void UnPackTo(ITwoDimensionOutlineItemNodeT _o)
		{
			_o.Type = this.Type;
			_o.Id = this.Id;
		}

		// Token: 0x0601D129 RID: 119081 RVA: 0x0041AE94 File Offset: 0x00419094
		public static Offset<ITwoDimensionOutlineItemNode> Pack(FlatBufferBuilder builder, ITwoDimensionOutlineItemNodeT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITwoDimensionOutlineItemNode>);
			}
			return ITwoDimensionOutlineItemNode.CreateITwoDimensionOutlineItemNode(builder, _o.Type, _o.Id);
		}

		// Token: 0x0400CEAC RID: 52908
		private Table __p;
	}
}
