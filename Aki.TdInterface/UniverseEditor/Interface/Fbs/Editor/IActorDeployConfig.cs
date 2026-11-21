using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x02004C82 RID: 19586
	public struct IActorDeployConfig : IFlatbufferObject
	{
		// Token: 0x17008AB7 RID: 35511
		// (get) Token: 0x0601E016 RID: 122902 RVA: 0x00434C68 File Offset: 0x00432E68
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601E017 RID: 122903 RVA: 0x00434C75 File Offset: 0x00432E75
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601E018 RID: 122904 RVA: 0x00434C7C File Offset: 0x00432E7C
		public static IActorDeployConfig GetRootAsIActorDeployConfig(ByteBuffer _bb)
		{
			return IActorDeployConfig.GetRootAsIActorDeployConfig(_bb, default(IActorDeployConfig));
		}

		// Token: 0x0601E019 RID: 122905 RVA: 0x00434C98 File Offset: 0x00432E98
		public static IActorDeployConfig GetRootAsIActorDeployConfig(ByteBuffer _bb, IActorDeployConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601E01A RID: 122906 RVA: 0x00434CB5 File Offset: 0x00432EB5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601E01B RID: 122907 RVA: 0x00434CC4 File Offset: 0x00432EC4
		public IActorDeployConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008AB8 RID: 35512
		// (get) Token: 0x0601E01C RID: 122908 RVA: 0x00434CD4 File Offset: 0x00432ED4
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

		// Token: 0x0601E01D RID: 122909 RVA: 0x00434D0B File Offset: 0x00432F0B
		public Span<byte> GetFolderBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0601E01E RID: 122910 RVA: 0x00434D1A File Offset: 0x00432F1A
		public byte[] GetFolderArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x17008AB9 RID: 35513
		// (get) Token: 0x0601E01F RID: 122911 RVA: 0x00434D28 File Offset: 0x00432F28
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

		// Token: 0x0601E020 RID: 122912 RVA: 0x00434D5F File Offset: 0x00432F5F
		public Span<byte> GetSubFolderBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0601E021 RID: 122913 RVA: 0x00434D6E File Offset: 0x00432F6E
		public byte[] GetSubFolderArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x0601E022 RID: 122914 RVA: 0x00434D7C File Offset: 0x00432F7C
		public static Offset<IActorDeployConfig> CreateIActorDeployConfig(FlatBufferBuilder builder, StringOffset FolderOffset = default(StringOffset), StringOffset SubFolderOffset = default(StringOffset))
		{
			builder.StartTable(2);
			IActorDeployConfig.AddSubFolder(builder, SubFolderOffset);
			IActorDeployConfig.AddFolder(builder, FolderOffset);
			return IActorDeployConfig.EndIActorDeployConfig(builder);
		}

		// Token: 0x0601E023 RID: 122915 RVA: 0x00434D99 File Offset: 0x00432F99
		public static void StartIActorDeployConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601E024 RID: 122916 RVA: 0x00434DA2 File Offset: 0x00432FA2
		public static void AddFolder(FlatBufferBuilder builder, StringOffset folderOffset)
		{
			builder.AddOffset(0, folderOffset.Value, 0);
		}

		// Token: 0x0601E025 RID: 122917 RVA: 0x00434DB2 File Offset: 0x00432FB2
		public static void AddSubFolder(FlatBufferBuilder builder, StringOffset subFolderOffset)
		{
			builder.AddOffset(1, subFolderOffset.Value, 0);
		}

		// Token: 0x0601E026 RID: 122918 RVA: 0x00434DC2 File Offset: 0x00432FC2
		public static Offset<IActorDeployConfig> EndIActorDeployConfig(FlatBufferBuilder builder)
		{
			return new Offset<IActorDeployConfig>(builder.EndTable());
		}

		// Token: 0x0601E027 RID: 122919 RVA: 0x00434DD0 File Offset: 0x00432FD0
		public IActorDeployConfigT UnPack()
		{
			IActorDeployConfigT actorDeployConfigT = new IActorDeployConfigT();
			this.UnPackTo(actorDeployConfigT);
			return actorDeployConfigT;
		}

		// Token: 0x0601E028 RID: 122920 RVA: 0x00434DEB File Offset: 0x00432FEB
		public void UnPackTo(IActorDeployConfigT _o)
		{
			_o.Folder = this.Folder;
			_o.SubFolder = this.SubFolder;
		}

		// Token: 0x0601E029 RID: 122921 RVA: 0x00434E08 File Offset: 0x00433008
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

		// Token: 0x0400D76D RID: 55149
		private Table __p;
	}
}
