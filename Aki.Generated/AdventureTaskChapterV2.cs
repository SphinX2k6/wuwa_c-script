using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000AD5 RID: 2773
	public struct AdventureTaskChapterV2 : IFlatbufferObject
	{
		// Token: 0x170001B0 RID: 432
		// (get) Token: 0x0600447F RID: 17535 RVA: 0x001CE8C5 File Offset: 0x001CCAC5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06004480 RID: 17536 RVA: 0x001CE8D2 File Offset: 0x001CCAD2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06004481 RID: 17537 RVA: 0x001CE8DC File Offset: 0x001CCADC
		public static AdventureTaskChapterV2 GetRootAsAdventureTaskChapterV2(ByteBuffer _bb)
		{
			return AdventureTaskChapterV2.GetRootAsAdventureTaskChapterV2(_bb, default(AdventureTaskChapterV2));
		}

		// Token: 0x06004482 RID: 17538 RVA: 0x001CE8F8 File Offset: 0x001CCAF8
		public static AdventureTaskChapterV2 GetRootAsAdventureTaskChapterV2(ByteBuffer _bb, AdventureTaskChapterV2 obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06004483 RID: 17539 RVA: 0x001CE915 File Offset: 0x001CCB15
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06004484 RID: 17540 RVA: 0x001CE924 File Offset: 0x001CCB24
		public AdventureTaskChapterV2 __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170001B1 RID: 433
		// (get) Token: 0x06004485 RID: 17541 RVA: 0x001CE934 File Offset: 0x001CCB34
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

		// Token: 0x170001B2 RID: 434
		// (get) Token: 0x06004486 RID: 17542 RVA: 0x001CE970 File Offset: 0x001CCB70
		public int ActivityId
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

		// Token: 0x170001B3 RID: 435
		// (get) Token: 0x06004487 RID: 17543 RVA: 0x001CE9AC File Offset: 0x001CCBAC
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

		// Token: 0x170001B4 RID: 436
		// (get) Token: 0x06004488 RID: 17544 RVA: 0x001CE9E8 File Offset: 0x001CCBE8
		public string Name
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

		// Token: 0x06004489 RID: 17545 RVA: 0x001CEA20 File Offset: 0x001CCC20
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600448A RID: 17546 RVA: 0x001CEA30 File Offset: 0x001CCC30
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x170001B5 RID: 437
		// (get) Token: 0x0600448B RID: 17547 RVA: 0x001CEA48 File Offset: 0x001CCC48
		public int DropId
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

		// Token: 0x0600448C RID: 17548 RVA: 0x001CEA88 File Offset: 0x001CCC88
		public int Roles(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170001B6 RID: 438
		// (get) Token: 0x0600448D RID: 17549 RVA: 0x001CEAC8 File Offset: 0x001CCCC8
		public int RolesLength
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600448E RID: 17550 RVA: 0x001CEAF4 File Offset: 0x001CCCF4
		public Span<int> GetRolesBytes()
		{
			return this.__p.__vector_as_span<int>(14, 4);
		}

		// Token: 0x0600448F RID: 17551 RVA: 0x001CEB04 File Offset: 0x001CCD04
		public int[] GetRolesArray()
		{
			return this.__p.__vector_as_array<int>(14) ?? Array.Empty<int>();
		}

		// Token: 0x170001B7 RID: 439
		// (get) Token: 0x06004490 RID: 17552 RVA: 0x001CEB1C File Offset: 0x001CCD1C
		public int LevelUnlockCount
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

		// Token: 0x170001B8 RID: 440
		// (get) Token: 0x06004491 RID: 17553 RVA: 0x001CEB5C File Offset: 0x001CCD5C
		public int RewardUnlockCount
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170001B9 RID: 441
		// (get) Token: 0x06004492 RID: 17554 RVA: 0x001CEB9C File Offset: 0x001CCD9C
		public string LockedDesc
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

		// Token: 0x06004493 RID: 17555 RVA: 0x001CEBD4 File Offset: 0x001CCDD4
		public Span<byte> GetLockedDescBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x06004494 RID: 17556 RVA: 0x001CEBE4 File Offset: 0x001CCDE4
		public byte[] GetLockedDescArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x170001BA RID: 442
		// (get) Token: 0x06004495 RID: 17557 RVA: 0x001CEBFC File Offset: 0x001CCDFC
		public string ChapterTitle
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

		// Token: 0x06004496 RID: 17558 RVA: 0x001CEC34 File Offset: 0x001CCE34
		public Span<byte> GetChapterTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x06004497 RID: 17559 RVA: 0x001CEC44 File Offset: 0x001CCE44
		public byte[] GetChapterTitleArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x06004498 RID: 17560 RVA: 0x001CEC5C File Offset: 0x001CCE5C
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用RolesIter()或GetRolesBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] Roles()
		{
			AdventureTaskChapterV2 adventureTaskChapterV = this;
			return adventureTaskChapterV.GetRolesArray() ?? Array.Empty<int>();
		}

		// Token: 0x06004499 RID: 17561 RVA: 0x001CEC80 File Offset: 0x001CCE80
		[NullableContext(1)]
		public readonly IEnumerable<int> RolesIter()
		{
			AdventureTaskChapterV2.<RolesIter>d__38 <RolesIter>d__ = new AdventureTaskChapterV2.<RolesIter>d__38(-2);
			<RolesIter>d__.<>3__<>4__this = this;
			return <RolesIter>d__;
		}

		// Token: 0x04004AB3 RID: 19123
		private Table __p;
	}
}
