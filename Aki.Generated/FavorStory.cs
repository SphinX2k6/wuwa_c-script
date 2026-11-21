using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D46 RID: 3398
	public struct FavorStory : IFlatbufferObject
	{
		// Token: 0x170010D6 RID: 4310
		// (get) Token: 0x06007320 RID: 29472 RVA: 0x0024B2B4 File Offset: 0x002494B4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06007321 RID: 29473 RVA: 0x0024B2C1 File Offset: 0x002494C1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06007322 RID: 29474 RVA: 0x0024B2C8 File Offset: 0x002494C8
		public static FavorStory GetRootAsFavorStory(ByteBuffer _bb)
		{
			return FavorStory.GetRootAsFavorStory(_bb, default(FavorStory));
		}

		// Token: 0x06007323 RID: 29475 RVA: 0x0024B2E4 File Offset: 0x002494E4
		public static FavorStory GetRootAsFavorStory(ByteBuffer _bb, FavorStory obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06007324 RID: 29476 RVA: 0x0024B301 File Offset: 0x00249501
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06007325 RID: 29477 RVA: 0x0024B310 File Offset: 0x00249510
		public FavorStory __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170010D7 RID: 4311
		// (get) Token: 0x06007326 RID: 29478 RVA: 0x0024B320 File Offset: 0x00249520
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

		// Token: 0x170010D8 RID: 4312
		// (get) Token: 0x06007327 RID: 29479 RVA: 0x0024B35C File Offset: 0x0024955C
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

		// Token: 0x170010D9 RID: 4313
		// (get) Token: 0x06007328 RID: 29480 RVA: 0x0024B398 File Offset: 0x00249598
		public int Sort
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

		// Token: 0x170010DA RID: 4314
		// (get) Token: 0x06007329 RID: 29481 RVA: 0x0024B3D4 File Offset: 0x002495D4
		public string Title
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

		// Token: 0x0600732A RID: 29482 RVA: 0x0024B40C File Offset: 0x0024960C
		public Span<byte> GetTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600732B RID: 29483 RVA: 0x0024B41C File Offset: 0x0024961C
		public byte[] GetTitleArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x170010DB RID: 4315
		// (get) Token: 0x0600732C RID: 29484 RVA: 0x0024B434 File Offset: 0x00249634
		public string Content
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

		// Token: 0x0600732D RID: 29485 RVA: 0x0024B46C File Offset: 0x0024966C
		public Span<byte> GetContentBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600732E RID: 29486 RVA: 0x0024B47C File Offset: 0x0024967C
		public byte[] GetContentArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x170010DC RID: 4316
		// (get) Token: 0x0600732F RID: 29487 RVA: 0x0024B494 File Offset: 0x00249694
		public int CondGroupId
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170010DD RID: 4317
		// (get) Token: 0x06007330 RID: 29488 RVA: 0x0024B4D4 File Offset: 0x002496D4
		public int Type
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170010DE RID: 4318
		// (get) Token: 0x06007331 RID: 29489 RVA: 0x0024B514 File Offset: 0x00249714
		public string MotionImg
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06007332 RID: 29490 RVA: 0x0024B54C File Offset: 0x0024974C
		public Span<byte> GetMotionImgBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x06007333 RID: 29491 RVA: 0x0024B55C File Offset: 0x0024975C
		public byte[] GetMotionImgArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x170010DF RID: 4319
		// (get) Token: 0x06007334 RID: 29492 RVA: 0x0024B574 File Offset: 0x00249774
		public string AniBlueprint
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06007335 RID: 29493 RVA: 0x0024B5AC File Offset: 0x002497AC
		public Span<byte> GetAniBlueprintBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x06007336 RID: 29494 RVA: 0x0024B5BC File Offset: 0x002497BC
		public byte[] GetAniBlueprintArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x170010E0 RID: 4320
		// (get) Token: 0x06007337 RID: 29495 RVA: 0x0024B5D4 File Offset: 0x002497D4
		public string AniMontage
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06007338 RID: 29496 RVA: 0x0024B60C File Offset: 0x0024980C
		public Span<byte> GetAniMontageBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x06007339 RID: 29497 RVA: 0x0024B61C File Offset: 0x0024981C
		public byte[] GetAniMontageArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x04005291 RID: 21137
		private Table __p;
	}
}
