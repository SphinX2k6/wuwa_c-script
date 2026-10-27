using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020051AA RID: 20906
	public struct IEntityPackageNode : IFlatbufferObject
	{
		// Token: 0x170098C4 RID: 39108
		// (get) Token: 0x06021D5B RID: 138587 RVA: 0x004B1863 File Offset: 0x004AFA63
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06021D5C RID: 138588 RVA: 0x004B1870 File Offset: 0x004AFA70
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06021D5D RID: 138589 RVA: 0x004B1878 File Offset: 0x004AFA78
		public static IEntityPackageNode GetRootAsIEntityPackageNode(ByteBuffer _bb)
		{
			return IEntityPackageNode.GetRootAsIEntityPackageNode(_bb, default(IEntityPackageNode));
		}

		// Token: 0x06021D5E RID: 138590 RVA: 0x004B1894 File Offset: 0x004AFA94
		public static IEntityPackageNode GetRootAsIEntityPackageNode(ByteBuffer _bb, IEntityPackageNode obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06021D5F RID: 138591 RVA: 0x004B18B1 File Offset: 0x004AFAB1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06021D60 RID: 138592 RVA: 0x004B18C0 File Offset: 0x004AFAC0
		public IEntityPackageNode __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170098C5 RID: 39109
		// (get) Token: 0x06021D61 RID: 138593 RVA: 0x004B18D0 File Offset: 0x004AFAD0
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

		// Token: 0x06021D62 RID: 138594 RVA: 0x004B190C File Offset: 0x004AFB0C
		public IEntityPackageNode? Children(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IEntityPackageNode?(default(IEntityPackageNode).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170098C6 RID: 39110
		// (get) Token: 0x06021D63 RID: 138595 RVA: 0x004B196C File Offset: 0x004AFB6C
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

		// Token: 0x170098C7 RID: 39111
		// (get) Token: 0x06021D64 RID: 138596 RVA: 0x004B1998 File Offset: 0x004AFB98
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

		// Token: 0x06021D65 RID: 138597 RVA: 0x004B19D4 File Offset: 0x004AFBD4
		public static Offset<IEntityPackageNode> CreateIEntityPackageNode(FlatBufferBuilder builder, int EntityId = 0, VectorOffset ChildrenOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(3);
			IEntityPackageNode.AddChildren(builder, ChildrenOffset);
			IEntityPackageNode.AddEntityId(builder, EntityId);
			IEntityPackageNode.AddNullMask(builder, NullMask);
			return IEntityPackageNode.EndIEntityPackageNode(builder);
		}

		// Token: 0x06021D66 RID: 138598 RVA: 0x004B19F8 File Offset: 0x004AFBF8
		public static void StartIEntityPackageNode(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06021D67 RID: 138599 RVA: 0x004B1A01 File Offset: 0x004AFC01
		public static void AddEntityId(FlatBufferBuilder builder, int entityId)
		{
			builder.AddInt(0, entityId, 0);
		}

		// Token: 0x06021D68 RID: 138600 RVA: 0x004B1A0C File Offset: 0x004AFC0C
		public static void AddChildren(FlatBufferBuilder builder, VectorOffset childrenOffset)
		{
			builder.AddOffset(1, childrenOffset.Value, 0);
		}

		// Token: 0x06021D69 RID: 138601 RVA: 0x004B1A1C File Offset: 0x004AFC1C
		public static VectorOffset CreateChildrenVector(FlatBufferBuilder builder, Offset<IEntityPackageNode>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06021D6A RID: 138602 RVA: 0x004B1A5C File Offset: 0x004AFC5C
		public static VectorOffset CreateChildrenVectorBlock(FlatBufferBuilder builder, Offset<IEntityPackageNode>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IEntityPackageNode>>(data);
			return builder.EndVector();
		}

		// Token: 0x06021D6B RID: 138603 RVA: 0x004B1A76 File Offset: 0x004AFC76
		public static VectorOffset CreateChildrenVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IEntityPackageNode>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IEntityPackageNode>>(data);
			return builder.EndVector();
		}

		// Token: 0x06021D6C RID: 138604 RVA: 0x004B1A94 File Offset: 0x004AFC94
		public static VectorOffset CreateChildrenVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IEntityPackageNode>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06021D6D RID: 138605 RVA: 0x004B1AAD File Offset: 0x004AFCAD
		public static void StartChildrenVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06021D6E RID: 138606 RVA: 0x004B1AB8 File Offset: 0x004AFCB8
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x06021D6F RID: 138607 RVA: 0x004B1AC3 File Offset: 0x004AFCC3
		public static Offset<IEntityPackageNode> EndIEntityPackageNode(FlatBufferBuilder builder)
		{
			return new Offset<IEntityPackageNode>(builder.EndTable());
		}

		// Token: 0x06021D70 RID: 138608 RVA: 0x004B1AD0 File Offset: 0x004AFCD0
		public IEntityPackageNodeT UnPack()
		{
			IEntityPackageNodeT entityPackageNodeT = new IEntityPackageNodeT();
			this.UnPackTo(entityPackageNodeT);
			return entityPackageNodeT;
		}

		// Token: 0x06021D71 RID: 138609 RVA: 0x004B1AEC File Offset: 0x004AFCEC
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

		// Token: 0x06021D72 RID: 138610 RVA: 0x004B1B64 File Offset: 0x004AFD64
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

		// Token: 0x0400E28C RID: 57996
		private Table __p;
	}
}
