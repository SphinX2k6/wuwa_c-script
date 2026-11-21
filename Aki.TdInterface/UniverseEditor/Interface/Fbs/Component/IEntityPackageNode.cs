using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200570F RID: 22287
	public struct IEntityPackageNode : IFlatbufferObject
	{
		// Token: 0x1700A0B3 RID: 41139
		// (get) Token: 0x06023CB3 RID: 146611 RVA: 0x004EB8CB File Offset: 0x004E9ACB
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06023CB4 RID: 146612 RVA: 0x004EB8D8 File Offset: 0x004E9AD8
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06023CB5 RID: 146613 RVA: 0x004EB8E0 File Offset: 0x004E9AE0
		public static IEntityPackageNode GetRootAsIEntityPackageNode(ByteBuffer _bb)
		{
			return IEntityPackageNode.GetRootAsIEntityPackageNode(_bb, default(IEntityPackageNode));
		}

		// Token: 0x06023CB6 RID: 146614 RVA: 0x004EB8FC File Offset: 0x004E9AFC
		public static IEntityPackageNode GetRootAsIEntityPackageNode(ByteBuffer _bb, IEntityPackageNode obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06023CB7 RID: 146615 RVA: 0x004EB919 File Offset: 0x004E9B19
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06023CB8 RID: 146616 RVA: 0x004EB928 File Offset: 0x004E9B28
		public IEntityPackageNode __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A0B4 RID: 41140
		// (get) Token: 0x06023CB9 RID: 146617 RVA: 0x004EB938 File Offset: 0x004E9B38
		public int EntityId
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

		// Token: 0x06023CBA RID: 146618 RVA: 0x004EB974 File Offset: 0x004E9B74
		public IEntityPackageNode? Children(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IEntityPackageNode?(default(IEntityPackageNode).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700A0B5 RID: 41141
		// (get) Token: 0x06023CBB RID: 146619 RVA: 0x004EB9D4 File Offset: 0x004E9BD4
		public int ChildrenLength
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x1700A0B6 RID: 41142
		// (get) Token: 0x06023CBC RID: 146620 RVA: 0x004EBA00 File Offset: 0x004E9C00
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

		// Token: 0x06023CBD RID: 146621 RVA: 0x004EBA3C File Offset: 0x004E9C3C
		public static Offset<IEntityPackageNode> CreateIEntityPackageNode(FlatBufferBuilder builder, int EntityId = 0, VectorOffset ChildrenOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(3);
			IEntityPackageNode.AddChildren(builder, ChildrenOffset);
			IEntityPackageNode.AddEntityId(builder, EntityId);
			IEntityPackageNode.AddNullMask(builder, NullMask);
			return IEntityPackageNode.EndIEntityPackageNode(builder);
		}

		// Token: 0x06023CBE RID: 146622 RVA: 0x004EBA60 File Offset: 0x004E9C60
		public static void StartIEntityPackageNode(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06023CBF RID: 146623 RVA: 0x004EBA69 File Offset: 0x004E9C69
		public static void AddEntityId(FlatBufferBuilder builder, int entityId)
		{
			builder.AddInt(0, entityId, 0);
		}

		// Token: 0x06023CC0 RID: 146624 RVA: 0x004EBA74 File Offset: 0x004E9C74
		public static void AddChildren(FlatBufferBuilder builder, VectorOffset childrenOffset)
		{
			builder.AddOffset(1, childrenOffset.Value, 0);
		}

		// Token: 0x06023CC1 RID: 146625 RVA: 0x004EBA84 File Offset: 0x004E9C84
		public static VectorOffset CreateChildrenVector(FlatBufferBuilder builder, Offset<IEntityPackageNode>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06023CC2 RID: 146626 RVA: 0x004EBAC4 File Offset: 0x004E9CC4
		public static VectorOffset CreateChildrenVectorBlock(FlatBufferBuilder builder, Offset<IEntityPackageNode>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IEntityPackageNode>>(data);
			return builder.EndVector();
		}

		// Token: 0x06023CC3 RID: 146627 RVA: 0x004EBADE File Offset: 0x004E9CDE
		public static VectorOffset CreateChildrenVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IEntityPackageNode>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IEntityPackageNode>>(data);
			return builder.EndVector();
		}

		// Token: 0x06023CC4 RID: 146628 RVA: 0x004EBAFC File Offset: 0x004E9CFC
		public static VectorOffset CreateChildrenVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IEntityPackageNode>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06023CC5 RID: 146629 RVA: 0x004EBB15 File Offset: 0x004E9D15
		public static void StartChildrenVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06023CC6 RID: 146630 RVA: 0x004EBB20 File Offset: 0x004E9D20
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x06023CC7 RID: 146631 RVA: 0x004EBB2B File Offset: 0x004E9D2B
		public static Offset<IEntityPackageNode> EndIEntityPackageNode(FlatBufferBuilder builder)
		{
			return new Offset<IEntityPackageNode>(builder.EndTable());
		}

		// Token: 0x06023CC8 RID: 146632 RVA: 0x004EBB38 File Offset: 0x004E9D38
		public IEntityPackageNodeT UnPack()
		{
			IEntityPackageNodeT entityPackageNodeT = new IEntityPackageNodeT();
			this.UnPackTo(entityPackageNodeT);
			return entityPackageNodeT;
		}

		// Token: 0x06023CC9 RID: 146633 RVA: 0x004EBB54 File Offset: 0x004E9D54
		public void UnPackTo(IEntityPackageNodeT _o)
		{
			_o.EntityId = this.EntityId;
			_o.Children = new List<IEntityPackageNodeT>();
			for (int i = 0; i < this.ChildrenLength; i++)
			{
				_o.Children.Add((this.Children(i) != null) ? this.Children(i).Value.UnPack() : null);
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06023CCA RID: 146634 RVA: 0x004EBBCC File Offset: 0x004E9DCC
		public static Offset<IEntityPackageNode> Pack(FlatBufferBuilder builder, IEntityPackageNodeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IEntityPackageNode>);
			}
			VectorOffset childrenOffset = default(VectorOffset);
			if (_o.Children != null)
			{
				Offset<IEntityPackageNode>[] array = new Offset<IEntityPackageNode>[_o.Children.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IEntityPackageNode.Pack(builder, _o.Children[i]);
				}
				childrenOffset = IEntityPackageNode.CreateChildrenVector(builder, array);
			}
			return IEntityPackageNode.CreateIEntityPackageNode(builder, _o.EntityId, childrenOffset, _o.NullMask);
		}

		// Token: 0x0400EE8A RID: 61066
		private Table __p;
	}
}
