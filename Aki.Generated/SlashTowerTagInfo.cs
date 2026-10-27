using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020010D2 RID: 4306
	public struct SlashTowerTagInfo : IFlatbufferObject
	{
		// Token: 0x17003767 RID: 14183
		// (get) Token: 0x0600D6DB RID: 55003 RVA: 0x0031BA79 File Offset: 0x00319C79
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600D6DC RID: 55004 RVA: 0x0031BA86 File Offset: 0x00319C86
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600D6DD RID: 55005 RVA: 0x0031BA90 File Offset: 0x00319C90
		public static SlashTowerTagInfo GetRootAsSlashTowerTagInfo(ByteBuffer _bb)
		{
			return SlashTowerTagInfo.GetRootAsSlashTowerTagInfo(_bb, default(SlashTowerTagInfo));
		}

		// Token: 0x0600D6DE RID: 55006 RVA: 0x0031BAAC File Offset: 0x00319CAC
		public static SlashTowerTagInfo GetRootAsSlashTowerTagInfo(ByteBuffer _bb, SlashTowerTagInfo obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600D6DF RID: 55007 RVA: 0x0031BAC9 File Offset: 0x00319CC9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600D6E0 RID: 55008 RVA: 0x0031BAD8 File Offset: 0x00319CD8
		public SlashTowerTagInfo __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003768 RID: 14184
		// (get) Token: 0x0600D6E1 RID: 55009 RVA: 0x0031BAE8 File Offset: 0x00319CE8
		public int Id
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

		// Token: 0x17003769 RID: 14185
		// (get) Token: 0x0600D6E2 RID: 55010 RVA: 0x0031BB24 File Offset: 0x00319D24
		public string Name
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

		// Token: 0x0600D6E3 RID: 55011 RVA: 0x0031BB5B File Offset: 0x00319D5B
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600D6E4 RID: 55012 RVA: 0x0031BB6A File Offset: 0x00319D6A
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x1700376A RID: 14186
		// (get) Token: 0x0600D6E5 RID: 55013 RVA: 0x0031BB84 File Offset: 0x00319D84
		public string Desc
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600D6E6 RID: 55014 RVA: 0x0031BBBB File Offset: 0x00319DBB
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600D6E7 RID: 55015 RVA: 0x0031BBCA File Offset: 0x00319DCA
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x1700376B RID: 14187
		// (get) Token: 0x0600D6E8 RID: 55016 RVA: 0x0031BBE4 File Offset: 0x00319DE4
		public string Path
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600D6E9 RID: 55017 RVA: 0x0031BC1C File Offset: 0x00319E1C
		public Span<byte> GetPathBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600D6EA RID: 55018 RVA: 0x0031BC2C File Offset: 0x00319E2C
		public byte[] GetPathArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x1700376C RID: 14188
		// (get) Token: 0x0600D6EB RID: 55019 RVA: 0x0031BC44 File Offset: 0x00319E44
		public string Color
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600D6EC RID: 55020 RVA: 0x0031BC7C File Offset: 0x00319E7C
		public Span<byte> GetColorBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600D6ED RID: 55021 RVA: 0x0031BC8C File Offset: 0x00319E8C
		public byte[] GetColorArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x04005204 RID: 20996
		private Table __p;
	}
}
