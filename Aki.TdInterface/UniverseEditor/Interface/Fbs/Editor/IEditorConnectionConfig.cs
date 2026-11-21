using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x02004CC4 RID: 19652
	public struct IEditorConnectionConfig : IFlatbufferObject
	{
		// Token: 0x17008BAE RID: 35758
		// (get) Token: 0x0601E3BD RID: 123837 RVA: 0x0043C84C File Offset: 0x0043AA4C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601E3BE RID: 123838 RVA: 0x0043C859 File Offset: 0x0043AA59
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601E3BF RID: 123839 RVA: 0x0043C860 File Offset: 0x0043AA60
		public static IEditorConnectionConfig GetRootAsIEditorConnectionConfig(ByteBuffer _bb)
		{
			return IEditorConnectionConfig.GetRootAsIEditorConnectionConfig(_bb, default(IEditorConnectionConfig));
		}

		// Token: 0x0601E3C0 RID: 123840 RVA: 0x0043C87C File Offset: 0x0043AA7C
		public static IEditorConnectionConfig GetRootAsIEditorConnectionConfig(ByteBuffer _bb, IEditorConnectionConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601E3C1 RID: 123841 RVA: 0x0043C899 File Offset: 0x0043AA99
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601E3C2 RID: 123842 RVA: 0x0043C8A8 File Offset: 0x0043AAA8
		public IEditorConnectionConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x0601E3C3 RID: 123843 RVA: 0x0043C8B8 File Offset: 0x0043AAB8
		public IConnectionGroup? ConnectionGroups(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return null;
			}
			return new IConnectionGroup?(default(IConnectionGroup).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17008BAF RID: 35759
		// (get) Token: 0x0601E3C4 RID: 123844 RVA: 0x0043C918 File Offset: 0x0043AB18
		public int ConnectionGroupsLength
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0601E3C5 RID: 123845 RVA: 0x0043C943 File Offset: 0x0043AB43
		public static Offset<IEditorConnectionConfig> CreateIEditorConnectionConfig(FlatBufferBuilder builder, VectorOffset ConnectionGroupsOffset = default(VectorOffset))
		{
			builder.StartTable(1);
			IEditorConnectionConfig.AddConnectionGroups(builder, ConnectionGroupsOffset);
			return IEditorConnectionConfig.EndIEditorConnectionConfig(builder);
		}

		// Token: 0x0601E3C6 RID: 123846 RVA: 0x0043C959 File Offset: 0x0043AB59
		public static void StartIEditorConnectionConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601E3C7 RID: 123847 RVA: 0x0043C962 File Offset: 0x0043AB62
		public static void AddConnectionGroups(FlatBufferBuilder builder, VectorOffset connectionGroupsOffset)
		{
			builder.AddOffset(0, connectionGroupsOffset.Value, 0);
		}

		// Token: 0x0601E3C8 RID: 123848 RVA: 0x0043C974 File Offset: 0x0043AB74
		public static VectorOffset CreateConnectionGroupsVector(FlatBufferBuilder builder, Offset<IConnectionGroup>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601E3C9 RID: 123849 RVA: 0x0043C9B4 File Offset: 0x0043ABB4
		public static VectorOffset CreateConnectionGroupsVectorBlock(FlatBufferBuilder builder, Offset<IConnectionGroup>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IConnectionGroup>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601E3CA RID: 123850 RVA: 0x0043C9CE File Offset: 0x0043ABCE
		public static VectorOffset CreateConnectionGroupsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IConnectionGroup>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IConnectionGroup>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601E3CB RID: 123851 RVA: 0x0043C9EC File Offset: 0x0043ABEC
		public static VectorOffset CreateConnectionGroupsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IConnectionGroup>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601E3CC RID: 123852 RVA: 0x0043CA05 File Offset: 0x0043AC05
		public static void StartConnectionGroupsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601E3CD RID: 123853 RVA: 0x0043CA10 File Offset: 0x0043AC10
		public static Offset<IEditorConnectionConfig> EndIEditorConnectionConfig(FlatBufferBuilder builder)
		{
			return new Offset<IEditorConnectionConfig>(builder.EndTable());
		}

		// Token: 0x0601E3CE RID: 123854 RVA: 0x0043CA20 File Offset: 0x0043AC20
		public IEditorConnectionConfigT UnPack()
		{
			IEditorConnectionConfigT editorConnectionConfigT = new IEditorConnectionConfigT();
			this.UnPackTo(editorConnectionConfigT);
			return editorConnectionConfigT;
		}

		// Token: 0x0601E3CF RID: 123855 RVA: 0x0043CA3C File Offset: 0x0043AC3C
		public void UnPackTo(IEditorConnectionConfigT _o)
		{
			_o.ConnectionGroups = new List<IConnectionGroupT>();
			for (int i = 0; i < this.ConnectionGroupsLength; i++)
			{
				_o.ConnectionGroups.Add((this.ConnectionGroups(i) != null) ? this.ConnectionGroups(i).Value.UnPack() : null);
			}
		}

		// Token: 0x0601E3D0 RID: 123856 RVA: 0x0043CA9C File Offset: 0x0043AC9C
		public static Offset<IEditorConnectionConfig> Pack(FlatBufferBuilder builder, IEditorConnectionConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IEditorConnectionConfig>);
			}
			VectorOffset connectionGroupsOffset = default(VectorOffset);
			if (_o.ConnectionGroups != null)
			{
				Offset<IConnectionGroup>[] array = new Offset<IConnectionGroup>[_o.ConnectionGroups.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IConnectionGroup.Pack(builder, _o.ConnectionGroups[i]);
				}
				connectionGroupsOffset = IEditorConnectionConfig.CreateConnectionGroupsVector(builder, array);
			}
			return IEditorConnectionConfig.CreateIEditorConnectionConfig(builder, connectionGroupsOffset);
		}

		// Token: 0x0400D800 RID: 55296
		private Table __p;
	}
}
