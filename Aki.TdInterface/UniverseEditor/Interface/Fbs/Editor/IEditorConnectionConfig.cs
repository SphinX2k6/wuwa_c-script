using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x0200485C RID: 18524
	public struct IEditorConnectionConfig : IFlatbufferObject
	{
		// Token: 0x1700855F RID: 34143
		// (get) Token: 0x0601CBB6 RID: 117686 RVA: 0x0040FD9D File Offset: 0x0040DF9D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601CBB7 RID: 117687 RVA: 0x0040FDAA File Offset: 0x0040DFAA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601CBB8 RID: 117688 RVA: 0x0040FDB4 File Offset: 0x0040DFB4
		public static IEditorConnectionConfig GetRootAsIEditorConnectionConfig(ByteBuffer _bb)
		{
			return IEditorConnectionConfig.GetRootAsIEditorConnectionConfig(_bb, default(IEditorConnectionConfig));
		}

		// Token: 0x0601CBB9 RID: 117689 RVA: 0x0040FDD0 File Offset: 0x0040DFD0
		public static IEditorConnectionConfig GetRootAsIEditorConnectionConfig(ByteBuffer _bb, IEditorConnectionConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601CBBA RID: 117690 RVA: 0x0040FDED File Offset: 0x0040DFED
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601CBBB RID: 117691 RVA: 0x0040FDFC File Offset: 0x0040DFFC
		public IEditorConnectionConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x0601CBBC RID: 117692 RVA: 0x0040FE0C File Offset: 0x0040E00C
		public IConnectionGroup? ConnectionGroups(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return null;
			}
			return new IConnectionGroup?(default(IConnectionGroup).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17008560 RID: 34144
		// (get) Token: 0x0601CBBD RID: 117693 RVA: 0x0040FE6C File Offset: 0x0040E06C
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

		// Token: 0x0601CBBE RID: 117694 RVA: 0x0040FE97 File Offset: 0x0040E097
		public static Offset<IEditorConnectionConfig> CreateIEditorConnectionConfig(FlatBufferBuilder builder, VectorOffset ConnectionGroupsOffset = default(VectorOffset))
		{
			builder.StartTable(1);
			IEditorConnectionConfig.AddConnectionGroups(builder, ConnectionGroupsOffset);
			return IEditorConnectionConfig.EndIEditorConnectionConfig(builder);
		}

		// Token: 0x0601CBBF RID: 117695 RVA: 0x0040FEAD File Offset: 0x0040E0AD
		public static void StartIEditorConnectionConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601CBC0 RID: 117696 RVA: 0x0040FEB6 File Offset: 0x0040E0B6
		public static void AddConnectionGroups(FlatBufferBuilder builder, VectorOffset connectionGroupsOffset)
		{
			builder.AddOffset(0, connectionGroupsOffset.Value, 0);
		}

		// Token: 0x0601CBC1 RID: 117697 RVA: 0x0040FEC8 File Offset: 0x0040E0C8
		public static VectorOffset CreateConnectionGroupsVector(FlatBufferBuilder builder, Offset<IConnectionGroup>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601CBC2 RID: 117698 RVA: 0x0040FF08 File Offset: 0x0040E108
		public static VectorOffset CreateConnectionGroupsVectorBlock(FlatBufferBuilder builder, Offset<IConnectionGroup>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IConnectionGroup>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601CBC3 RID: 117699 RVA: 0x0040FF22 File Offset: 0x0040E122
		public static VectorOffset CreateConnectionGroupsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IConnectionGroup>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IConnectionGroup>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601CBC4 RID: 117700 RVA: 0x0040FF40 File Offset: 0x0040E140
		public static VectorOffset CreateConnectionGroupsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IConnectionGroup>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601CBC5 RID: 117701 RVA: 0x0040FF59 File Offset: 0x0040E159
		public static void StartConnectionGroupsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601CBC6 RID: 117702 RVA: 0x0040FF64 File Offset: 0x0040E164
		public static Offset<IEditorConnectionConfig> EndIEditorConnectionConfig(FlatBufferBuilder builder)
		{
			return new Offset<IEditorConnectionConfig>(builder.EndTable());
		}

		// Token: 0x0601CBC7 RID: 117703 RVA: 0x0040FF74 File Offset: 0x0040E174
		public IEditorConnectionConfigT UnPack()
		{
			IEditorConnectionConfigT editorConnectionConfigT = new IEditorConnectionConfigT();
			this.UnPackTo(editorConnectionConfigT);
			return editorConnectionConfigT;
		}

		// Token: 0x0601CBC8 RID: 117704 RVA: 0x0040FF90 File Offset: 0x0040E190
		public void UnPackTo(IEditorConnectionConfigT _o)
		{
			_o.ConnectionGroups = new List<IConnectionGroupT>();
			for (int i = 0; i < this.ConnectionGroupsLength; i++)
			{
				_o.ConnectionGroups.Add((this.ConnectionGroups(i) != null) ? this.ConnectionGroups(i).Value.UnPack() : null);
			}
		}

		// Token: 0x0601CBC9 RID: 117705 RVA: 0x0040FFF0 File Offset: 0x0040E1F0
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

		// Token: 0x0400CDC3 RID: 52675
		private Table __p;
	}
}
