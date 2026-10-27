using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E13 RID: 3603
	public struct MonsterDisplay : IFlatbufferObject
	{
		// Token: 0x17001F57 RID: 8023
		// (get) Token: 0x060094D4 RID: 38100 RVA: 0x0028714C File Offset: 0x0028534C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060094D5 RID: 38101 RVA: 0x00287159 File Offset: 0x00285359
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060094D6 RID: 38102 RVA: 0x00287160 File Offset: 0x00285360
		public static MonsterDisplay GetRootAsMonsterDisplay(ByteBuffer _bb)
		{
			return MonsterDisplay.GetRootAsMonsterDisplay(_bb, default(MonsterDisplay));
		}

		// Token: 0x060094D7 RID: 38103 RVA: 0x0028717C File Offset: 0x0028537C
		public static MonsterDisplay GetRootAsMonsterDisplay(ByteBuffer _bb, MonsterDisplay obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060094D8 RID: 38104 RVA: 0x00287199 File Offset: 0x00285399
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060094D9 RID: 38105 RVA: 0x002871A8 File Offset: 0x002853A8
		public MonsterDisplay __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001F58 RID: 8024
		// (get) Token: 0x060094DA RID: 38106 RVA: 0x002871B8 File Offset: 0x002853B8
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

		// Token: 0x17001F59 RID: 8025
		// (get) Token: 0x060094DB RID: 38107 RVA: 0x002871F4 File Offset: 0x002853F4
		public int NameStringKey
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

		// Token: 0x17001F5A RID: 8026
		// (get) Token: 0x060094DC RID: 38108 RVA: 0x00287230 File Offset: 0x00285430
		public int Name
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

		// Token: 0x17001F5B RID: 8027
		// (get) Token: 0x060094DD RID: 38109 RVA: 0x0028726C File Offset: 0x0028546C
		public int IntroduceStringKey
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001F5C RID: 8028
		// (get) Token: 0x060094DE RID: 38110 RVA: 0x002872AC File Offset: 0x002854AC
		public int Introduce
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

		// Token: 0x17001F5D RID: 8029
		// (get) Token: 0x060094DF RID: 38111 RVA: 0x002872EC File Offset: 0x002854EC
		public string MonsterPileIconAsset
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

		// Token: 0x060094E0 RID: 38112 RVA: 0x00287324 File Offset: 0x00285524
		public Span<byte> GetMonsterPileIconAssetBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x060094E1 RID: 38113 RVA: 0x00287334 File Offset: 0x00285534
		public byte[] GetMonsterPileIconAssetArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x04004EB8 RID: 20152
		private Table __p;
	}
}
