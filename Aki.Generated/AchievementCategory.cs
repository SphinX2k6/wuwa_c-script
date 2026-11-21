using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B92 RID: 2962
	public struct AchievementCategory : IFlatbufferObject
	{
		// Token: 0x170000E9 RID: 233
		// (get) Token: 0x0600476C RID: 18284 RVA: 0x001E9120 File Offset: 0x001E7320
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600476D RID: 18285 RVA: 0x001E912D File Offset: 0x001E732D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600476E RID: 18286 RVA: 0x001E9134 File Offset: 0x001E7334
		public static AchievementCategory GetRootAsAchievementCategory(ByteBuffer _bb)
		{
			return AchievementCategory.GetRootAsAchievementCategory(_bb, default(AchievementCategory));
		}

		// Token: 0x0600476F RID: 18287 RVA: 0x001E9150 File Offset: 0x001E7350
		public static AchievementCategory GetRootAsAchievementCategory(ByteBuffer _bb, AchievementCategory obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06004770 RID: 18288 RVA: 0x001E916D File Offset: 0x001E736D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06004771 RID: 18289 RVA: 0x001E917C File Offset: 0x001E737C
		public AchievementCategory __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170000EA RID: 234
		// (get) Token: 0x06004772 RID: 18290 RVA: 0x001E918C File Offset: 0x001E738C
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
		// (get) Token: 0x06004773 RID: 18291 RVA: 0x001E91C8 File Offset: 0x001E73C8
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

		// Token: 0x06004774 RID: 18292 RVA: 0x001E91FF File Offset: 0x001E73FF
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06004775 RID: 18293 RVA: 0x001E920E File Offset: 0x001E740E
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x170000EC RID: 236
		// (get) Token: 0x06004776 RID: 18294 RVA: 0x001E9228 File Offset: 0x001E7428
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
		// (get) Token: 0x06004777 RID: 18295 RVA: 0x001E9264 File Offset: 0x001E7464
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

		// Token: 0x06004778 RID: 18296 RVA: 0x001E929C File Offset: 0x001E749C
		public Span<byte> GetSpritePathBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06004779 RID: 18297 RVA: 0x001E92AC File Offset: 0x001E74AC
		public byte[] GetSpritePathArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x170000EE RID: 238
		// (get) Token: 0x0600477A RID: 18298 RVA: 0x001E92C4 File Offset: 0x001E74C4
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

		// Token: 0x0600477B RID: 18299 RVA: 0x001E92FC File Offset: 0x001E74FC
		public Span<byte> GetTexturePathBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600477C RID: 18300 RVA: 0x001E930C File Offset: 0x001E750C
		public byte[] GetTexturePathArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x0400506A RID: 20586
		private Table __p;
	}
}
