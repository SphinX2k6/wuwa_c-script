using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x02004D1B RID: 19739
	public struct ITwoDimensionOutlineItemNode : IFlatbufferObject
	{
		// Token: 0x17008D48 RID: 36168
		// (get) Token: 0x0601E907 RID: 125191 RVA: 0x004474C6 File Offset: 0x004456C6
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601E908 RID: 125192 RVA: 0x004474D3 File Offset: 0x004456D3
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601E909 RID: 125193 RVA: 0x004474DC File Offset: 0x004456DC
		public static ITwoDimensionOutlineItemNode GetRootAsITwoDimensionOutlineItemNode(ByteBuffer _bb)
		{
			return ITwoDimensionOutlineItemNode.GetRootAsITwoDimensionOutlineItemNode(_bb, default(ITwoDimensionOutlineItemNode));
		}

		// Token: 0x0601E90A RID: 125194 RVA: 0x004474F8 File Offset: 0x004456F8
		public static ITwoDimensionOutlineItemNode GetRootAsITwoDimensionOutlineItemNode(ByteBuffer _bb, ITwoDimensionOutlineItemNode obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601E90B RID: 125195 RVA: 0x00447515 File Offset: 0x00445715
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601E90C RID: 125196 RVA: 0x00447524 File Offset: 0x00445724
		public ITwoDimensionOutlineItemNode __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008D49 RID: 36169
		// (get) Token: 0x0601E90D RID: 125197 RVA: 0x00447534 File Offset: 0x00445734
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

		// Token: 0x17008D4A RID: 36170
		// (get) Token: 0x0601E90E RID: 125198 RVA: 0x00447570 File Offset: 0x00445770
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

		// Token: 0x0601E90F RID: 125199 RVA: 0x004475AC File Offset: 0x004457AC
		public static Offset<ITwoDimensionOutlineItemNode> CreateITwoDimensionOutlineItemNode(FlatBufferBuilder builder, ETwoDimensionOutlineNodeType Type = ETwoDimensionOutlineNodeType.Folder, int Id = 0)
		{
			builder.StartTable(2);
			ITwoDimensionOutlineItemNode.AddId(builder, Id);
			ITwoDimensionOutlineItemNode.AddType(builder, Type);
			return ITwoDimensionOutlineItemNode.EndITwoDimensionOutlineItemNode(builder);
		}

		// Token: 0x0601E910 RID: 125200 RVA: 0x004475C9 File Offset: 0x004457C9
		public static void StartITwoDimensionOutlineItemNode(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601E911 RID: 125201 RVA: 0x004475D2 File Offset: 0x004457D2
		public static void AddType(FlatBufferBuilder builder, ETwoDimensionOutlineNodeType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601E912 RID: 125202 RVA: 0x004475DD File Offset: 0x004457DD
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(1, id, 0);
		}

		// Token: 0x0601E913 RID: 125203 RVA: 0x004475E8 File Offset: 0x004457E8
		public static Offset<ITwoDimensionOutlineItemNode> EndITwoDimensionOutlineItemNode(FlatBufferBuilder builder)
		{
			return new Offset<ITwoDimensionOutlineItemNode>(builder.EndTable());
		}

		// Token: 0x0601E914 RID: 125204 RVA: 0x004475F8 File Offset: 0x004457F8
		public ITwoDimensionOutlineItemNodeT UnPack()
		{
			ITwoDimensionOutlineItemNodeT twoDimensionOutlineItemNodeT = new ITwoDimensionOutlineItemNodeT();
			this.UnPackTo(twoDimensionOutlineItemNodeT);
			return twoDimensionOutlineItemNodeT;
		}

		// Token: 0x0601E915 RID: 125205 RVA: 0x00447613 File Offset: 0x00445813
		public void UnPackTo(ITwoDimensionOutlineItemNodeT _o)
		{
			_o.Type = this.Type;
			_o.Id = this.Id;
		}

		// Token: 0x0601E916 RID: 125206 RVA: 0x00447630 File Offset: 0x00445830
		public static Offset<ITwoDimensionOutlineItemNode> Pack(FlatBufferBuilder builder, ITwoDimensionOutlineItemNodeT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITwoDimensionOutlineItemNode>);
			}
			return ITwoDimensionOutlineItemNode.CreateITwoDimensionOutlineItemNode(builder, _o.Type, _o.Id);
		}

		// Token: 0x0400D8E5 RID: 55525
		private Table __p;
	}
}
