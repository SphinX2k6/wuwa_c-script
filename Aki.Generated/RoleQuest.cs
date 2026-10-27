using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001058 RID: 4184
	public struct RoleQuest : IFlatbufferObject
	{
		// Token: 0x170032F4 RID: 13044
		// (get) Token: 0x0600C9E8 RID: 51688 RVA: 0x002FD938 File Offset: 0x002FBB38
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600C9E9 RID: 51689 RVA: 0x002FD945 File Offset: 0x002FBB45
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600C9EA RID: 51690 RVA: 0x002FD94C File Offset: 0x002FBB4C
		public static RoleQuest GetRootAsRoleQuest(ByteBuffer _bb)
		{
			return RoleQuest.GetRootAsRoleQuest(_bb, default(RoleQuest));
		}

		// Token: 0x0600C9EB RID: 51691 RVA: 0x002FD968 File Offset: 0x002FBB68
		public static RoleQuest GetRootAsRoleQuest(ByteBuffer _bb, RoleQuest obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600C9EC RID: 51692 RVA: 0x002FD985 File Offset: 0x002FBB85
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600C9ED RID: 51693 RVA: 0x002FD994 File Offset: 0x002FBB94
		public RoleQuest __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170032F5 RID: 13045
		// (get) Token: 0x0600C9EE RID: 51694 RVA: 0x002FD9A4 File Offset: 0x002FBBA4
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

		// Token: 0x170032F6 RID: 13046
		// (get) Token: 0x0600C9EF RID: 51695 RVA: 0x002FD9E0 File Offset: 0x002FBBE0
		public int RoleId
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

		// Token: 0x170032F7 RID: 13047
		// (get) Token: 0x0600C9F0 RID: 51696 RVA: 0x002FDA1C File Offset: 0x002FBC1C
		public string Region
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

		// Token: 0x0600C9F1 RID: 51697 RVA: 0x002FDA53 File Offset: 0x002FBC53
		public Span<byte> GetRegionBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600C9F2 RID: 51698 RVA: 0x002FDA62 File Offset: 0x002FBC62
		public byte[] GetRegionArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x170032F8 RID: 13048
		// (get) Token: 0x0600C9F3 RID: 51699 RVA: 0x002FDA7C File Offset: 0x002FBC7C
		public bool IsShow
		{
			get
			{
				int num = this.__p.__offset(10);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170032F9 RID: 13049
		// (get) Token: 0x0600C9F4 RID: 51700 RVA: 0x002FDABC File Offset: 0x002FBCBC
		public int QuestId
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170032FA RID: 13050
		// (get) Token: 0x0600C9F5 RID: 51701 RVA: 0x002FDAFC File Offset: 0x002FBCFC
		public string QuestName
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600C9F6 RID: 51702 RVA: 0x002FDB34 File Offset: 0x002FBD34
		public Span<byte> GetQuestNameBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600C9F7 RID: 51703 RVA: 0x002FDB44 File Offset: 0x002FBD44
		public byte[] GetQuestNameArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x170032FB RID: 13051
		// (get) Token: 0x0600C9F8 RID: 51704 RVA: 0x002FDB5C File Offset: 0x002FBD5C
		public string Chapter
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600C9F9 RID: 51705 RVA: 0x002FDB94 File Offset: 0x002FBD94
		public Span<byte> GetChapterBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600C9FA RID: 51706 RVA: 0x002FDBA4 File Offset: 0x002FBDA4
		public byte[] GetChapterArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x170032FC RID: 13052
		// (get) Token: 0x0600C9FB RID: 51707 RVA: 0x002FDBBC File Offset: 0x002FBDBC
		public int Consume
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0400515A RID: 20826
		private Table __p;
	}
}
