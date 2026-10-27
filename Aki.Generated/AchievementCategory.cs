using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000ABD RID: 2749
	public struct AchievementCategory : IFlatbufferObject
	{
		// Token: 0x170000E9 RID: 233
		// (get) Token: 0x0600426E RID: 17006 RVA: 0x001C9EDC File Offset: 0x001C80DC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600426F RID: 17007 RVA: 0x001C9EE9 File Offset: 0x001C80E9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06004270 RID: 17008 RVA: 0x001C9EF0 File Offset: 0x001C80F0
		public static AchievementCategory GetRootAsAchievementCategory(ByteBuffer _bb)
		{
			return AchievementCategory.GetRootAsAchievementCategory(_bb, default(AchievementCategory));
		}

		// Token: 0x06004271 RID: 17009 RVA: 0x001C9F0C File Offset: 0x001C810C
		public static AchievementCategory GetRootAsAchievementCategory(ByteBuffer _bb, AchievementCategory obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06004272 RID: 17010 RVA: 0x001C9F29 File Offset: 0x001C8129
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06004273 RID: 17011 RVA: 0x001C9F38 File Offset: 0x001C8138
		public AchievementCategory __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170000EA RID: 234
		// (get) Token: 0x06004274 RID: 17012 RVA: 0x001C9F48 File Offset: 0x001C8148
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

		// Token: 0x170000EB RID: 235
		// (get) Token: 0x06004275 RID: 17013 RVA: 0x001C9F84 File Offset: 0x001C8184
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

		// Token: 0x06004276 RID: 17014 RVA: 0x001C9FBB File Offset: 0x001C81BB
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06004277 RID: 17015 RVA: 0x001C9FCA File Offset: 0x001C81CA
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x170000EC RID: 236
		// (get) Token: 0x06004278 RID: 17016 RVA: 0x001C9FE4 File Offset: 0x001C81E4
		public int FunctionType
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170000ED RID: 237
		// (get) Token: 0x06004279 RID: 17017 RVA: 0x001CA020 File Offset: 0x001C8220
		public string SpritePath
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

		// Token: 0x0600427A RID: 17018 RVA: 0x001CA058 File Offset: 0x001C8258
		public Span<byte> GetSpritePathBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600427B RID: 17019 RVA: 0x001CA068 File Offset: 0x001C8268
		public byte[] GetSpritePathArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x170000EE RID: 238
		// (get) Token: 0x0600427C RID: 17020 RVA: 0x001CA080 File Offset: 0x001C8280
		public string TexturePath
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

		// Token: 0x0600427D RID: 17021 RVA: 0x001CA0B8 File Offset: 0x001C82B8
		public Span<byte> GetTexturePathBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600427E RID: 17022 RVA: 0x001CA0C8 File Offset: 0x001C82C8
		public byte[] GetTexturePathArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x04004A97 RID: 19095
		private Table __p;
	}
}
