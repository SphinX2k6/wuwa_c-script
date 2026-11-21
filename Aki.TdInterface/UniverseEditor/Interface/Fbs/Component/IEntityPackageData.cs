using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200570C RID: 22284
	public struct IEntityPackageData : IFlatbufferObject
	{
		// Token: 0x1700A0AA RID: 41130
		// (get) Token: 0x06023C8F RID: 146575 RVA: 0x004EB40F File Offset: 0x004E960F
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06023C90 RID: 146576 RVA: 0x004EB41C File Offset: 0x004E961C
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06023C91 RID: 146577 RVA: 0x004EB424 File Offset: 0x004E9624
		public static IEntityPackageData GetRootAsIEntityPackageData(ByteBuffer _bb)
		{
			return IEntityPackageData.GetRootAsIEntityPackageData(_bb, default(IEntityPackageData));
		}

		// Token: 0x06023C92 RID: 146578 RVA: 0x004EB440 File Offset: 0x004E9640
		public static IEntityPackageData GetRootAsIEntityPackageData(ByteBuffer _bb, IEntityPackageData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06023C93 RID: 146579 RVA: 0x004EB45D File Offset: 0x004E965D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06023C94 RID: 146580 RVA: 0x004EB46C File Offset: 0x004E966C
		public IEntityPackageData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A0AB RID: 41131
		// (get) Token: 0x06023C95 RID: 146581 RVA: 0x004EB47C File Offset: 0x004E967C
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

		// Token: 0x1700A0AC RID: 41132
		// (get) Token: 0x06023C96 RID: 146582 RVA: 0x004EB4B8 File Offset: 0x004E96B8
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

		// Token: 0x06023C97 RID: 146583 RVA: 0x004EB4F4 File Offset: 0x004E96F4
		public IEntityPackageNode? PackageTree(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new IEntityPackageNode?(default(IEntityPackageNode).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700A0AD RID: 41133
		// (get) Token: 0x06023C98 RID: 146584 RVA: 0x004EB554 File Offset: 0x004E9754
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

		// Token: 0x1700A0AE RID: 41134
		// (get) Token: 0x06023C99 RID: 146585 RVA: 0x004EB580 File Offset: 0x004E9780
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

		// Token: 0x06023C9A RID: 146586 RVA: 0x004EB5BD File Offset: 0x004E97BD
		public static Offset<IEntityPackageData> CreateIEntityPackageData(FlatBufferBuilder builder, int PackagedLevelId = 0, int PackageEntityId = 0, VectorOffset PackageTreeOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(4);
			IEntityPackageData.AddPackageTree(builder, PackageTreeOffset);
			IEntityPackageData.AddPackageEntityId(builder, PackageEntityId);
			IEntityPackageData.AddPackagedLevelId(builder, PackagedLevelId);
			IEntityPackageData.AddNullMask(builder, NullMask);
			return IEntityPackageData.EndIEntityPackageData(builder);
		}

		// Token: 0x06023C9B RID: 146587 RVA: 0x004EB5E9 File Offset: 0x004E97E9
		public static void StartIEntityPackageData(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06023C9C RID: 146588 RVA: 0x004EB5F2 File Offset: 0x004E97F2
		public static void AddPackagedLevelId(FlatBufferBuilder builder, int packagedLevelId)
		{
			builder.AddInt(0, packagedLevelId, 0);
		}

		// Token: 0x06023C9D RID: 146589 RVA: 0x004EB5FD File Offset: 0x004E97FD
		public static void AddPackageEntityId(FlatBufferBuilder builder, int packageEntityId)
		{
			builder.AddInt(1, packageEntityId, 0);
		}

		// Token: 0x06023C9E RID: 146590 RVA: 0x004EB608 File Offset: 0x004E9808
		public static void AddPackageTree(FlatBufferBuilder builder, VectorOffset packageTreeOffset)
		{
			builder.AddOffset(2, packageTreeOffset.Value, 0);
		}

		// Token: 0x06023C9F RID: 146591 RVA: 0x004EB618 File Offset: 0x004E9818
		public static VectorOffset CreatePackageTreeVector(FlatBufferBuilder builder, Offset<IEntityPackageNode>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06023CA0 RID: 146592 RVA: 0x004EB658 File Offset: 0x004E9858
		public static VectorOffset CreatePackageTreeVectorBlock(FlatBufferBuilder builder, Offset<IEntityPackageNode>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IEntityPackageNode>>(data);
			return builder.EndVector();
		}

		// Token: 0x06023CA1 RID: 146593 RVA: 0x004EB672 File Offset: 0x004E9872
		public static VectorOffset CreatePackageTreeVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IEntityPackageNode>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IEntityPackageNode>>(data);
			return builder.EndVector();
		}

		// Token: 0x06023CA2 RID: 146594 RVA: 0x004EB690 File Offset: 0x004E9890
		public static VectorOffset CreatePackageTreeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IEntityPackageNode>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06023CA3 RID: 146595 RVA: 0x004EB6A9 File Offset: 0x004E98A9
		public static void StartPackageTreeVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06023CA4 RID: 146596 RVA: 0x004EB6B4 File Offset: 0x004E98B4
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x06023CA5 RID: 146597 RVA: 0x004EB6BF File Offset: 0x004E98BF
		public static Offset<IEntityPackageData> EndIEntityPackageData(FlatBufferBuilder builder)
		{
			return new Offset<IEntityPackageData>(builder.EndTable());
		}

		// Token: 0x06023CA6 RID: 146598 RVA: 0x004EB6CC File Offset: 0x004E98CC
		public IEntityPackageDataT UnPack()
		{
			IEntityPackageDataT entityPackageDataT = new IEntityPackageDataT();
			this.UnPackTo(entityPackageDataT);
			return entityPackageDataT;
		}

		// Token: 0x06023CA7 RID: 146599 RVA: 0x004EB6E8 File Offset: 0x004E98E8
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

		// Token: 0x06023CA8 RID: 146600 RVA: 0x004EB76C File Offset: 0x004E996C
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

		// Token: 0x0400EE85 RID: 61061
		private Table __p;
	}
}
