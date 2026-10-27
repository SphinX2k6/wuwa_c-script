using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x0200481A RID: 18458
	public struct IActorDeployConfig : IFlatbufferObject
	{
		// Token: 0x1700846C RID: 33900
		// (get) Token: 0x0601C819 RID: 116761 RVA: 0x00408318 File Offset: 0x00406518
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601C81A RID: 116762 RVA: 0x00408325 File Offset: 0x00406525
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601C81B RID: 116763 RVA: 0x0040832C File Offset: 0x0040652C
		public static IActorDeployConfig GetRootAsIActorDeployConfig(ByteBuffer _bb)
		{
			return IActorDeployConfig.GetRootAsIActorDeployConfig(_bb, default(IActorDeployConfig));
		}

		// Token: 0x0601C81C RID: 116764 RVA: 0x00408348 File Offset: 0x00406548
		public static IActorDeployConfig GetRootAsIActorDeployConfig(ByteBuffer _bb, IActorDeployConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601C81D RID: 116765 RVA: 0x00408365 File Offset: 0x00406565
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601C81E RID: 116766 RVA: 0x00408374 File Offset: 0x00406574
		public IActorDeployConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700846D RID: 33901
		// (get) Token: 0x0601C81F RID: 116767 RVA: 0x00408384 File Offset: 0x00406584
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

		// Token: 0x0601C820 RID: 116768 RVA: 0x004083BB File Offset: 0x004065BB
		public Span<byte> GetFolderBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0601C821 RID: 116769 RVA: 0x004083CA File Offset: 0x004065CA
		public byte[] GetFolderArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x1700846E RID: 33902
		// (get) Token: 0x0601C822 RID: 116770 RVA: 0x004083D8 File Offset: 0x004065D8
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

		// Token: 0x0601C823 RID: 116771 RVA: 0x0040840F File Offset: 0x0040660F
		public Span<byte> GetSubFolderBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0601C824 RID: 116772 RVA: 0x0040841E File Offset: 0x0040661E
		public byte[] GetSubFolderArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x0601C825 RID: 116773 RVA: 0x0040842C File Offset: 0x0040662C
		public static Offset<IActorDeployConfig> CreateIActorDeployConfig(FlatBufferBuilder builder, StringOffset FolderOffset = default(StringOffset), StringOffset SubFolderOffset = default(StringOffset))
		{
			builder.StartTable(2);
			IActorDeployConfig.AddSubFolder(builder, SubFolderOffset);
			IActorDeployConfig.AddFolder(builder, FolderOffset);
			return IActorDeployConfig.EndIActorDeployConfig(builder);
		}

		// Token: 0x0601C826 RID: 116774 RVA: 0x00408449 File Offset: 0x00406649
		public static void StartIActorDeployConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601C827 RID: 116775 RVA: 0x00408452 File Offset: 0x00406652
		public static void AddFolder(FlatBufferBuilder builder, StringOffset folderOffset)
		{
			builder.AddOffset(0, folderOffset.Value, 0);
		}

		// Token: 0x0601C828 RID: 116776 RVA: 0x00408462 File Offset: 0x00406662
		public static void AddSubFolder(FlatBufferBuilder builder, StringOffset subFolderOffset)
		{
			builder.AddOffset(1, subFolderOffset.Value, 0);
		}

		// Token: 0x0601C829 RID: 116777 RVA: 0x00408472 File Offset: 0x00406672
		public static Offset<IActorDeployConfig> EndIActorDeployConfig(FlatBufferBuilder builder)
		{
			return new Offset<IActorDeployConfig>(builder.EndTable());
		}

		// Token: 0x0601C82A RID: 116778 RVA: 0x00408480 File Offset: 0x00406680
		public IActorDeployConfigT UnPack()
		{
			IActorDeployConfigT actorDeployConfigT = new IActorDeployConfigT();
			this.UnPackTo(actorDeployConfigT);
			return actorDeployConfigT;
		}

		// Token: 0x0601C82B RID: 116779 RVA: 0x0040849B File Offset: 0x0040669B
		public void UnPackTo(IActorDeployConfigT _o)
		{
			_o.Folder = this.Folder;
			_o.SubFolder = this.SubFolder;
		}

		// Token: 0x0601C82C RID: 116780 RVA: 0x004084B8 File Offset: 0x004066B8
		public static Offset<IActorDeployConfig> Pack(FlatBufferBuilder builder, IActorDeployConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IActorDeployConfig>);
			}
			StringOffset folderOffset = (_o.Folder == null) ? default(StringOffset) : builder.CreateString(_o.Folder);
			StringOffset subFolderOffset = (_o.SubFolder == null) ? default(StringOffset) : builder.CreateString(_o.SubFolder);
			return IActorDeployConfig.CreateIActorDeployConfig(builder, folderOffset, subFolderOffset);
		}

		// Token: 0x0400CD32 RID: 52530
		private Table __p;
	}
}
