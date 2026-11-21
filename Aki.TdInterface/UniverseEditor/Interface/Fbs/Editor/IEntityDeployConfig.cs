using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x02004CDC RID: 19676
	public struct IEntityDeployConfig : IFlatbufferObject
	{
		// Token: 0x17008C87 RID: 35975
		// (get) Token: 0x0601E631 RID: 124465 RVA: 0x00441F90 File Offset: 0x00440190
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601E632 RID: 124466 RVA: 0x00441F9D File Offset: 0x0044019D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601E633 RID: 124467 RVA: 0x00441FA4 File Offset: 0x004401A4
		public static IEntityDeployConfig GetRootAsIEntityDeployConfig(ByteBuffer _bb)
		{
			return IEntityDeployConfig.GetRootAsIEntityDeployConfig(_bb, default(IEntityDeployConfig));
		}

		// Token: 0x0601E634 RID: 124468 RVA: 0x00441FC0 File Offset: 0x004401C0
		public static IEntityDeployConfig GetRootAsIEntityDeployConfig(ByteBuffer _bb, IEntityDeployConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601E635 RID: 124469 RVA: 0x00441FDD File Offset: 0x004401DD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601E636 RID: 124470 RVA: 0x00441FEC File Offset: 0x004401EC
		public IEntityDeployConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008C88 RID: 35976
		// (get) Token: 0x0601E637 RID: 124471 RVA: 0x00441FFC File Offset: 0x004401FC
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

		// Token: 0x0601E638 RID: 124472 RVA: 0x00442033 File Offset: 0x00440233
		public Span<byte> GetFolderBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0601E639 RID: 124473 RVA: 0x00442042 File Offset: 0x00440242
		public byte[] GetFolderArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x17008C89 RID: 35977
		// (get) Token: 0x0601E63A RID: 124474 RVA: 0x00442050 File Offset: 0x00440250
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

		// Token: 0x0601E63B RID: 124475 RVA: 0x00442087 File Offset: 0x00440287
		public Span<byte> GetSubFolderBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0601E63C RID: 124476 RVA: 0x00442096 File Offset: 0x00440296
		public byte[] GetSubFolderArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x0601E63D RID: 124477 RVA: 0x004420A4 File Offset: 0x004402A4
		public static Offset<IEntityDeployConfig> CreateIEntityDeployConfig(FlatBufferBuilder builder, StringOffset FolderOffset = default(StringOffset), StringOffset SubFolderOffset = default(StringOffset))
		{
			builder.StartTable(2);
			IEntityDeployConfig.AddSubFolder(builder, SubFolderOffset);
			IEntityDeployConfig.AddFolder(builder, FolderOffset);
			return IEntityDeployConfig.EndIEntityDeployConfig(builder);
		}

		// Token: 0x0601E63E RID: 124478 RVA: 0x004420C1 File Offset: 0x004402C1
		public static void StartIEntityDeployConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601E63F RID: 124479 RVA: 0x004420CA File Offset: 0x004402CA
		public static void AddFolder(FlatBufferBuilder builder, StringOffset folderOffset)
		{
			builder.AddOffset(0, folderOffset.Value, 0);
		}

		// Token: 0x0601E640 RID: 124480 RVA: 0x004420DA File Offset: 0x004402DA
		public static void AddSubFolder(FlatBufferBuilder builder, StringOffset subFolderOffset)
		{
			builder.AddOffset(1, subFolderOffset.Value, 0);
		}

		// Token: 0x0601E641 RID: 124481 RVA: 0x004420EA File Offset: 0x004402EA
		public static Offset<IEntityDeployConfig> EndIEntityDeployConfig(FlatBufferBuilder builder)
		{
			return new Offset<IEntityDeployConfig>(builder.EndTable());
		}

		// Token: 0x0601E642 RID: 124482 RVA: 0x004420F8 File Offset: 0x004402F8
		public IEntityDeployConfigT UnPack()
		{
			IEntityDeployConfigT entityDeployConfigT = new IEntityDeployConfigT();
			this.UnPackTo(entityDeployConfigT);
			return entityDeployConfigT;
		}

		// Token: 0x0601E643 RID: 124483 RVA: 0x00442113 File Offset: 0x00440313
		public void UnPackTo(IEntityDeployConfigT _o)
		{
			_o.Folder = this.Folder;
			_o.SubFolder = this.SubFolder;
		}

		// Token: 0x0601E644 RID: 124484 RVA: 0x00442130 File Offset: 0x00440330
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

		// Token: 0x0400D870 RID: 55408
		private Table __p;
	}
}
