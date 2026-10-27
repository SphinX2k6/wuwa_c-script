using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x02004877 RID: 18551
	public struct IEntityDeployConfig : IFlatbufferObject
	{
		// Token: 0x1700863F RID: 34367
		// (get) Token: 0x0601CE44 RID: 118340 RVA: 0x004157F4 File Offset: 0x004139F4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601CE45 RID: 118341 RVA: 0x00415801 File Offset: 0x00413A01
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601CE46 RID: 118342 RVA: 0x00415808 File Offset: 0x00413A08
		public static IEntityDeployConfig GetRootAsIEntityDeployConfig(ByteBuffer _bb)
		{
			return IEntityDeployConfig.GetRootAsIEntityDeployConfig(_bb, default(IEntityDeployConfig));
		}

		// Token: 0x0601CE47 RID: 118343 RVA: 0x00415824 File Offset: 0x00413A24
		public static IEntityDeployConfig GetRootAsIEntityDeployConfig(ByteBuffer _bb, IEntityDeployConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601CE48 RID: 118344 RVA: 0x00415841 File Offset: 0x00413A41
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601CE49 RID: 118345 RVA: 0x00415850 File Offset: 0x00413A50
		public IEntityDeployConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008640 RID: 34368
		// (get) Token: 0x0601CE4A RID: 118346 RVA: 0x00415860 File Offset: 0x00413A60
		public string Folder
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601CE4B RID: 118347 RVA: 0x00415897 File Offset: 0x00413A97
		public Span<byte> GetFolderBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0601CE4C RID: 118348 RVA: 0x004158A6 File Offset: 0x00413AA6
		public byte[] GetFolderArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x17008641 RID: 34369
		// (get) Token: 0x0601CE4D RID: 118349 RVA: 0x004158B4 File Offset: 0x00413AB4
		public string SubFolder
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601CE4E RID: 118350 RVA: 0x004158EB File Offset: 0x00413AEB
		public Span<byte> GetSubFolderBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0601CE4F RID: 118351 RVA: 0x004158FA File Offset: 0x00413AFA
		public byte[] GetSubFolderArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x0601CE50 RID: 118352 RVA: 0x00415908 File Offset: 0x00413B08
		public static Offset<IEntityDeployConfig> CreateIEntityDeployConfig(FlatBufferBuilder builder, StringOffset FolderOffset = default(StringOffset), StringOffset SubFolderOffset = default(StringOffset))
		{
			builder.StartTable(2);
			IEntityDeployConfig.AddSubFolder(builder, SubFolderOffset);
			IEntityDeployConfig.AddFolder(builder, FolderOffset);
			return IEntityDeployConfig.EndIEntityDeployConfig(builder);
		}

		// Token: 0x0601CE51 RID: 118353 RVA: 0x00415925 File Offset: 0x00413B25
		public static void StartIEntityDeployConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601CE52 RID: 118354 RVA: 0x0041592E File Offset: 0x00413B2E
		public static void AddFolder(FlatBufferBuilder builder, StringOffset folderOffset)
		{
			builder.AddOffset(0, folderOffset.Value, 0);
		}

		// Token: 0x0601CE53 RID: 118355 RVA: 0x0041593E File Offset: 0x00413B3E
		public static void AddSubFolder(FlatBufferBuilder builder, StringOffset subFolderOffset)
		{
			builder.AddOffset(1, subFolderOffset.Value, 0);
		}

		// Token: 0x0601CE54 RID: 118356 RVA: 0x0041594E File Offset: 0x00413B4E
		public static Offset<IEntityDeployConfig> EndIEntityDeployConfig(FlatBufferBuilder builder)
		{
			return new Offset<IEntityDeployConfig>(builder.EndTable());
		}

		// Token: 0x0601CE55 RID: 118357 RVA: 0x0041595C File Offset: 0x00413B5C
		public IEntityDeployConfigT UnPack()
		{
			IEntityDeployConfigT entityDeployConfigT = new IEntityDeployConfigT();
			this.UnPackTo(entityDeployConfigT);
			return entityDeployConfigT;
		}

		// Token: 0x0601CE56 RID: 118358 RVA: 0x00415977 File Offset: 0x00413B77
		public void UnPackTo(IEntityDeployConfigT _o)
		{
			_o.Folder = this.Folder;
			_o.SubFolder = this.SubFolder;
		}

		// Token: 0x0601CE57 RID: 118359 RVA: 0x00415994 File Offset: 0x00413B94
		public static Offset<IEntityDeployConfig> Pack(FlatBufferBuilder builder, IEntityDeployConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IEntityDeployConfig>);
			}
			StringOffset folderOffset = (_o.Folder == null) ? default(StringOffset) : builder.CreateString(_o.Folder);
			StringOffset subFolderOffset = (_o.SubFolder == null) ? default(StringOffset) : builder.CreateString(_o.SubFolder);
			return IEntityDeployConfig.CreateIEntityDeployConfig(builder, folderOffset, subFolderOffset);
		}

		// Token: 0x0400CE37 RID: 52791
		private Table __p;
	}
}
