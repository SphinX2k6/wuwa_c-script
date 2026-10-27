using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020051A7 RID: 20903
	public struct IEntityPackageData : IFlatbufferObject
	{
		// Token: 0x170098BB RID: 39099
		// (get) Token: 0x06021D37 RID: 138551 RVA: 0x004B13A7 File Offset: 0x004AF5A7
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06021D38 RID: 138552 RVA: 0x004B13B4 File Offset: 0x004AF5B4
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06021D39 RID: 138553 RVA: 0x004B13BC File Offset: 0x004AF5BC
		public static IEntityPackageData GetRootAsIEntityPackageData(ByteBuffer _bb)
		{
			return IEntityPackageData.GetRootAsIEntityPackageData(_bb, default(IEntityPackageData));
		}

		// Token: 0x06021D3A RID: 138554 RVA: 0x004B13D8 File Offset: 0x004AF5D8
		public static IEntityPackageData GetRootAsIEntityPackageData(ByteBuffer _bb, IEntityPackageData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06021D3B RID: 138555 RVA: 0x004B13F5 File Offset: 0x004AF5F5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06021D3C RID: 138556 RVA: 0x004B1404 File Offset: 0x004AF604
		public IEntityPackageData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170098BC RID: 39100
		// (get) Token: 0x06021D3D RID: 138557 RVA: 0x004B1414 File Offset: 0x004AF614
		public int PackagedLevelId
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

		// Token: 0x170098BD RID: 39101
		// (get) Token: 0x06021D3E RID: 138558 RVA: 0x004B1450 File Offset: 0x004AF650
		public int PackageEntityId
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

		// Token: 0x06021D3F RID: 138559 RVA: 0x004B148C File Offset: 0x004AF68C
		public IEntityPackageNode? PackageTree(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new IEntityPackageNode?(default(IEntityPackageNode).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170098BE RID: 39102
		// (get) Token: 0x06021D40 RID: 138560 RVA: 0x004B14EC File Offset: 0x004AF6EC
		public int PackageTreeLength
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x170098BF RID: 39103
		// (get) Token: 0x06021D41 RID: 138561 RVA: 0x004B1518 File Offset: 0x004AF718
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06021D42 RID: 138562 RVA: 0x004B1555 File Offset: 0x004AF755
		public static Offset<IEntityPackageData> CreateIEntityPackageData(FlatBufferBuilder builder, int PackagedLevelId = 0, int PackageEntityId = 0, VectorOffset PackageTreeOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(4);
			IEntityPackageData.AddPackageTree(builder, PackageTreeOffset);
			IEntityPackageData.AddPackageEntityId(builder, PackageEntityId);
			IEntityPackageData.AddPackagedLevelId(builder, PackagedLevelId);
			IEntityPackageData.AddNullMask(builder, NullMask);
			return IEntityPackageData.EndIEntityPackageData(builder);
		}

		// Token: 0x06021D43 RID: 138563 RVA: 0x004B1581 File Offset: 0x004AF781
		public static void StartIEntityPackageData(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06021D44 RID: 138564 RVA: 0x004B158A File Offset: 0x004AF78A
		public static void AddPackagedLevelId(FlatBufferBuilder builder, int packagedLevelId)
		{
			builder.AddInt(0, packagedLevelId, 0);
		}

		// Token: 0x06021D45 RID: 138565 RVA: 0x004B1595 File Offset: 0x004AF795
		public static void AddPackageEntityId(FlatBufferBuilder builder, int packageEntityId)
		{
			builder.AddInt(1, packageEntityId, 0);
		}

		// Token: 0x06021D46 RID: 138566 RVA: 0x004B15A0 File Offset: 0x004AF7A0
		public static void AddPackageTree(FlatBufferBuilder builder, VectorOffset packageTreeOffset)
		{
			builder.AddOffset(2, packageTreeOffset.Value, 0);
		}

		// Token: 0x06021D47 RID: 138567 RVA: 0x004B15B0 File Offset: 0x004AF7B0
		public static VectorOffset CreatePackageTreeVector(FlatBufferBuilder builder, Offset<IEntityPackageNode>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06021D48 RID: 138568 RVA: 0x004B15F0 File Offset: 0x004AF7F0
		public static VectorOffset CreatePackageTreeVectorBlock(FlatBufferBuilder builder, Offset<IEntityPackageNode>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IEntityPackageNode>>(data);
			return builder.EndVector();
		}

		// Token: 0x06021D49 RID: 138569 RVA: 0x004B160A File Offset: 0x004AF80A
		public static VectorOffset CreatePackageTreeVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IEntityPackageNode>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IEntityPackageNode>>(data);
			return builder.EndVector();
		}

		// Token: 0x06021D4A RID: 138570 RVA: 0x004B1628 File Offset: 0x004AF828
		public static VectorOffset CreatePackageTreeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IEntityPackageNode>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06021D4B RID: 138571 RVA: 0x004B1641 File Offset: 0x004AF841
		public static void StartPackageTreeVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06021D4C RID: 138572 RVA: 0x004B164C File Offset: 0x004AF84C
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x06021D4D RID: 138573 RVA: 0x004B1657 File Offset: 0x004AF857
		public static Offset<IEntityPackageData> EndIEntityPackageData(FlatBufferBuilder builder)
		{
			return new Offset<IEntityPackageData>(builder.EndTable());
		}

		// Token: 0x06021D4E RID: 138574 RVA: 0x004B1664 File Offset: 0x004AF864
		public IEntityPackageDataT UnPack()
		{
			IEntityPackageDataT entityPackageDataT = new IEntityPackageDataT();
			this.UnPackTo(entityPackageDataT);
			return entityPackageDataT;
		}

		// Token: 0x06021D4F RID: 138575 RVA: 0x004B1680 File Offset: 0x004AF880
		public void UnPackTo(IEntityPackageDataT _o)
		{
			_o.PackagedLevelId = this.PackagedLevelId;
			_o.PackageEntityId = this.PackageEntityId;
			_o.PackageTree = new List<IEntityPackageNodeT>();
			for (int i = 0; i < this.PackageTreeLength; i++)
			{
				_o.PackageTree.Add((this.PackageTree(i) != null) ? this.PackageTree(i).Value.UnPack() : null);
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06021D50 RID: 138576 RVA: 0x004B1704 File Offset: 0x004AF904
		public static Offset<IEntityPackageData> Pack(FlatBufferBuilder builder, IEntityPackageDataT _o)
		{
			if (_o == null)
			{
				return default(Offset<IEntityPackageData>);
			}
			VectorOffset packageTreeOffset = default(VectorOffset);
			if (_o.PackageTree != null)
			{
				Offset<IEntityPackageNode>[] array = new Offset<IEntityPackageNode>[_o.PackageTree.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IEntityPackageNode.Pack(builder, _o.PackageTree[i]);
				}
				packageTreeOffset = IEntityPackageData.CreatePackageTreeVector(builder, array);
			}
			return IEntityPackageData.CreateIEntityPackageData(builder, _o.PackagedLevelId, _o.PackageEntityId, packageTreeOffset, _o.NullMask);
		}

		// Token: 0x0400E287 RID: 57991
		private Table __p;
	}
}
