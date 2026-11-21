using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C21 RID: 3105
	public struct BossPilingLevels : IFlatbufferObject
	{
		// Token: 0x170005D1 RID: 1489
		// (get) Token: 0x06005426 RID: 21542 RVA: 0x002062C6 File Offset: 0x002044C6
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06005427 RID: 21543 RVA: 0x002062D3 File Offset: 0x002044D3
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06005428 RID: 21544 RVA: 0x002062DC File Offset: 0x002044DC
		public static BossPilingLevels GetRootAsBossPilingLevels(ByteBuffer _bb)
		{
			return BossPilingLevels.GetRootAsBossPilingLevels(_bb, default(BossPilingLevels));
		}

		// Token: 0x06005429 RID: 21545 RVA: 0x002062F8 File Offset: 0x002044F8
		public static BossPilingLevels GetRootAsBossPilingLevels(ByteBuffer _bb, BossPilingLevels obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600542A RID: 21546 RVA: 0x00206315 File Offset: 0x00204515
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600542B RID: 21547 RVA: 0x00206324 File Offset: 0x00204524
		public BossPilingLevels __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170005D2 RID: 1490
		// (get) Token: 0x0600542C RID: 21548 RVA: 0x00206334 File Offset: 0x00204534
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

		// Token: 0x170005D3 RID: 1491
		// (get) Token: 0x0600542D RID: 21549 RVA: 0x00206370 File Offset: 0x00204570
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

		// Token: 0x0600542E RID: 21550 RVA: 0x002063AC File Offset: 0x002045AC
		public int InstIds(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170005D4 RID: 1492
		// (get) Token: 0x0600542F RID: 21551 RVA: 0x002063EC File Offset: 0x002045EC
		public int InstIdsLength
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06005430 RID: 21552 RVA: 0x00206417 File Offset: 0x00204617
		public Span<int> GetInstIdsBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x06005431 RID: 21553 RVA: 0x00206426 File Offset: 0x00204626
		public int[] GetInstIdsArray()
		{
			return this.__p.__vector_as_array<int>(8) ?? Array.Empty<int>();
		}

		// Token: 0x06005432 RID: 21554 RVA: 0x00206440 File Offset: 0x00204640
		public int RareBuffGroup(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170005D5 RID: 1493
		// (get) Token: 0x06005433 RID: 21555 RVA: 0x00206480 File Offset: 0x00204680
		public int RareBuffGroupLength
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06005434 RID: 21556 RVA: 0x002064AC File Offset: 0x002046AC
		public Span<int> GetRareBuffGroupBytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x06005435 RID: 21557 RVA: 0x002064BC File Offset: 0x002046BC
		public int[] GetRareBuffGroupArray()
		{
			return this.__p.__vector_as_array<int>(10) ?? Array.Empty<int>();
		}

		// Token: 0x06005436 RID: 21558 RVA: 0x002064D4 File Offset: 0x002046D4
		public int BuffGroup(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170005D6 RID: 1494
		// (get) Token: 0x06005437 RID: 21559 RVA: 0x00206514 File Offset: 0x00204714
		public int BuffGroupLength
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06005438 RID: 21560 RVA: 0x00206540 File Offset: 0x00204740
		public Span<int> GetBuffGroupBytes()
		{
			return this.__p.__vector_as_span<int>(12, 4);
		}

		// Token: 0x06005439 RID: 21561 RVA: 0x00206550 File Offset: 0x00204750
		public int[] GetBuffGroupArray()
		{
			return this.__p.__vector_as_array<int>(12) ?? Array.Empty<int>();
		}

		// Token: 0x0600543A RID: 21562 RVA: 0x00206568 File Offset: 0x00204768
		public int BuffShow(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170005D7 RID: 1495
		// (get) Token: 0x0600543B RID: 21563 RVA: 0x002065A8 File Offset: 0x002047A8
		public int BuffShowLength
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

		// Token: 0x0600543C RID: 21564 RVA: 0x002065D4 File Offset: 0x002047D4
		public Span<int> GetBuffShowBytes()
		{
			return this.__p.__vector_as_span<int>(14, 4);
		}

		// Token: 0x0600543D RID: 21565 RVA: 0x002065E4 File Offset: 0x002047E4
		public int[] GetBuffShowArray()
		{
			return this.__p.__vector_as_array<int>(14) ?? Array.Empty<int>();
		}

		// Token: 0x0600543E RID: 21566 RVA: 0x002065FC File Offset: 0x002047FC
		public int RecommendFetter(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170005D8 RID: 1496
		// (get) Token: 0x0600543F RID: 21567 RVA: 0x0020663C File Offset: 0x0020483C
		public int RecommendFetterLength
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06005440 RID: 21568 RVA: 0x00206668 File Offset: 0x00204868
		public Span<int> GetRecommendFetterBytes()
		{
			return this.__p.__vector_as_span<int>(16, 4);
		}

		// Token: 0x06005441 RID: 21569 RVA: 0x00206678 File Offset: 0x00204878
		public int[] GetRecommendFetterArray()
		{
			return this.__p.__vector_as_array<int>(16) ?? Array.Empty<int>();
		}

		// Token: 0x170005D9 RID: 1497
		// (get) Token: 0x06005442 RID: 21570 RVA: 0x00206690 File Offset: 0x00204890
		public int RecommendLevel
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

		// Token: 0x06005443 RID: 21571 RVA: 0x002066D0 File Offset: 0x002048D0
		public int Achievement(int j)
		{
			int num = this.__p.__offset(20);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170005DA RID: 1498
		// (get) Token: 0x06005444 RID: 21572 RVA: 0x00206710 File Offset: 0x00204910
		public int AchievementLength
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06005445 RID: 21573 RVA: 0x0020673C File Offset: 0x0020493C
		public Span<int> GetAchievementBytes()
		{
			return this.__p.__vector_as_span<int>(20, 4);
		}

		// Token: 0x06005446 RID: 21574 RVA: 0x0020674C File Offset: 0x0020494C
		public int[] GetAchievementArray()
		{
			return this.__p.__vector_as_array<int>(20) ?? Array.Empty<int>();
		}

		// Token: 0x170005DB RID: 1499
		// (get) Token: 0x06005447 RID: 21575 RVA: 0x00206764 File Offset: 0x00204964
		public string LevelName
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

		// Token: 0x06005448 RID: 21576 RVA: 0x0020679C File Offset: 0x0020499C
		public Span<byte> GetLevelNameBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x06005449 RID: 21577 RVA: 0x002067AC File Offset: 0x002049AC
		public byte[] GetLevelNameArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x170005DC RID: 1500
		// (get) Token: 0x0600544A RID: 21578 RVA: 0x002067C4 File Offset: 0x002049C4
		public string Bg
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600544B RID: 21579 RVA: 0x002067FC File Offset: 0x002049FC
		public Span<byte> GetBgBytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x0600544C RID: 21580 RVA: 0x0020680C File Offset: 0x00204A0C
		public byte[] GetBgArray()
		{
			return this.__p.__vector_as_array<byte>(24) ?? Array.Empty<byte>();
		}

		// Token: 0x170005DD RID: 1501
		// (get) Token: 0x0600544D RID: 21581 RVA: 0x00206824 File Offset: 0x00204A24
		public string ToggleLock
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600544E RID: 21582 RVA: 0x0020685C File Offset: 0x00204A5C
		public Span<byte> GetToggleLockBytes()
		{
			return this.__p.__vector_as_span<byte>(26, 1);
		}

		// Token: 0x0600544F RID: 21583 RVA: 0x0020686C File Offset: 0x00204A6C
		public byte[] GetToggleLockArray()
		{
			return this.__p.__vector_as_array<byte>(26) ?? Array.Empty<byte>();
		}

		// Token: 0x170005DE RID: 1502
		// (get) Token: 0x06005450 RID: 21584 RVA: 0x00206884 File Offset: 0x00204A84
		public string ToggleUnlock
		{
			get
			{
				int num = this.__p.__offset(28);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06005451 RID: 21585 RVA: 0x002068BC File Offset: 0x00204ABC
		public Span<byte> GetToggleUnlockBytes()
		{
			return this.__p.__vector_as_span<byte>(28, 1);
		}

		// Token: 0x06005452 RID: 21586 RVA: 0x002068CC File Offset: 0x00204ACC
		public byte[] GetToggleUnlockArray()
		{
			return this.__p.__vector_as_array<byte>(28) ?? Array.Empty<byte>();
		}

		// Token: 0x170005DF RID: 1503
		// (get) Token: 0x06005453 RID: 21587 RVA: 0x002068E4 File Offset: 0x00204AE4
		public string TaskIndexTex
		{
			get
			{
				int num = this.__p.__offset(30);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06005454 RID: 21588 RVA: 0x0020691C File Offset: 0x00204B1C
		public Span<byte> GetTaskIndexTexBytes()
		{
			return this.__p.__vector_as_span<byte>(30, 1);
		}

		// Token: 0x06005455 RID: 21589 RVA: 0x0020692C File Offset: 0x00204B2C
		public byte[] GetTaskIndexTexArray()
		{
			return this.__p.__vector_as_array<byte>(30) ?? Array.Empty<byte>();
		}

		// Token: 0x170005E0 RID: 1504
		// (get) Token: 0x06005456 RID: 21590 RVA: 0x00206944 File Offset: 0x00204B44
		public string LevelMechanism1
		{
			get
			{
				int num = this.__p.__offset(32);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06005457 RID: 21591 RVA: 0x0020697C File Offset: 0x00204B7C
		public Span<byte> GetLevelMechanism1Bytes()
		{
			return this.__p.__vector_as_span<byte>(32, 1);
		}

		// Token: 0x06005458 RID: 21592 RVA: 0x0020698C File Offset: 0x00204B8C
		public byte[] GetLevelMechanism1Array()
		{
			return this.__p.__vector_as_array<byte>(32) ?? Array.Empty<byte>();
		}

		// Token: 0x170005E1 RID: 1505
		// (get) Token: 0x06005459 RID: 21593 RVA: 0x002069A4 File Offset: 0x00204BA4
		public string LevelMechanism2
		{
			get
			{
				int num = this.__p.__offset(34);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600545A RID: 21594 RVA: 0x002069DC File Offset: 0x00204BDC
		public Span<byte> GetLevelMechanism2Bytes()
		{
			return this.__p.__vector_as_span<byte>(34, 1);
		}

		// Token: 0x0600545B RID: 21595 RVA: 0x002069EC File Offset: 0x00204BEC
		public byte[] GetLevelMechanism2Array()
		{
			return this.__p.__vector_as_array<byte>(34) ?? Array.Empty<byte>();
		}

		// Token: 0x170005E2 RID: 1506
		// (get) Token: 0x0600545C RID: 21596 RVA: 0x00206A04 File Offset: 0x00204C04
		public string LevelMonsterDesc1
		{
			get
			{
				int num = this.__p.__offset(36);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600545D RID: 21597 RVA: 0x00206A3C File Offset: 0x00204C3C
		public Span<byte> GetLevelMonsterDesc1Bytes()
		{
			return this.__p.__vector_as_span<byte>(36, 1);
		}

		// Token: 0x0600545E RID: 21598 RVA: 0x00206A4C File Offset: 0x00204C4C
		public byte[] GetLevelMonsterDesc1Array()
		{
			return this.__p.__vector_as_array<byte>(36) ?? Array.Empty<byte>();
		}

		// Token: 0x170005E3 RID: 1507
		// (get) Token: 0x0600545F RID: 21599 RVA: 0x00206A64 File Offset: 0x00204C64
		public string LevelDesc1
		{
			get
			{
				int num = this.__p.__offset(38);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06005460 RID: 21600 RVA: 0x00206A9C File Offset: 0x00204C9C
		public Span<byte> GetLevelDesc1Bytes()
		{
			return this.__p.__vector_as_span<byte>(38, 1);
		}

		// Token: 0x06005461 RID: 21601 RVA: 0x00206AAC File Offset: 0x00204CAC
		public byte[] GetLevelDesc1Array()
		{
			return this.__p.__vector_as_array<byte>(38) ?? Array.Empty<byte>();
		}

		// Token: 0x170005E4 RID: 1508
		// (get) Token: 0x06005462 RID: 21602 RVA: 0x00206AC4 File Offset: 0x00204CC4
		public string LevelMonsterDesc2
		{
			get
			{
				int num = this.__p.__offset(40);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06005463 RID: 21603 RVA: 0x00206AFC File Offset: 0x00204CFC
		public Span<byte> GetLevelMonsterDesc2Bytes()
		{
			return this.__p.__vector_as_span<byte>(40, 1);
		}

		// Token: 0x06005464 RID: 21604 RVA: 0x00206B0C File Offset: 0x00204D0C
		public byte[] GetLevelMonsterDesc2Array()
		{
			return this.__p.__vector_as_array<byte>(40) ?? Array.Empty<byte>();
		}

		// Token: 0x170005E5 RID: 1509
		// (get) Token: 0x06005465 RID: 21605 RVA: 0x00206B24 File Offset: 0x00204D24
		public string LevelDesc2
		{
			get
			{
				int num = this.__p.__offset(42);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06005466 RID: 21606 RVA: 0x00206B5C File Offset: 0x00204D5C
		public Span<byte> GetLevelDesc2Bytes()
		{
			return this.__p.__vector_as_span<byte>(42, 1);
		}

		// Token: 0x06005467 RID: 21607 RVA: 0x00206B6C File Offset: 0x00204D6C
		public byte[] GetLevelDesc2Array()
		{
			return this.__p.__vector_as_array<byte>(42) ?? Array.Empty<byte>();
		}

		// Token: 0x06005468 RID: 21608 RVA: 0x00206B84 File Offset: 0x00204D84
		[NullableContext(1)]
		public int[] Achievement()
		{
			return this.GetAchievementArray();
		}

		// Token: 0x06005469 RID: 21609 RVA: 0x00206B8C File Offset: 0x00204D8C
		[NullableContext(1)]
		public IEnumerable<int> AchievementIter()
		{
			BossPilingLevels.<AchievementIter>d__89 <AchievementIter>d__ = new BossPilingLevels.<AchievementIter>d__89(-2);
			<AchievementIter>d__.<>3__<>4__this = this;
			return <AchievementIter>d__;
		}

		// Token: 0x0600546A RID: 21610 RVA: 0x00206BA1 File Offset: 0x00204DA1
		[NullableContext(1)]
		public int[] BuffGroup()
		{
			return this.GetBuffGroupArray();
		}

		// Token: 0x0600546B RID: 21611 RVA: 0x00206BA9 File Offset: 0x00204DA9
		[NullableContext(1)]
		public IEnumerable<int> BuffGroupIter()
		{
			BossPilingLevels.<BuffGroupIter>d__91 <BuffGroupIter>d__ = new BossPilingLevels.<BuffGroupIter>d__91(-2);
			<BuffGroupIter>d__.<>3__<>4__this = this;
			return <BuffGroupIter>d__;
		}

		// Token: 0x0600546C RID: 21612 RVA: 0x00206BBE File Offset: 0x00204DBE
		[NullableContext(1)]
		public int[] BuffShow()
		{
			return this.GetBuffShowArray();
		}

		// Token: 0x0600546D RID: 21613 RVA: 0x00206BC6 File Offset: 0x00204DC6
		[NullableContext(1)]
		public IEnumerable<int> BuffShowIter()
		{
			BossPilingLevels.<BuffShowIter>d__93 <BuffShowIter>d__ = new BossPilingLevels.<BuffShowIter>d__93(-2);
			<BuffShowIter>d__.<>3__<>4__this = this;
			return <BuffShowIter>d__;
		}

		// Token: 0x0600546E RID: 21614 RVA: 0x00206BDB File Offset: 0x00204DDB
		[NullableContext(1)]
		public int[] InstIds()
		{
			return this.GetInstIdsArray();
		}

		// Token: 0x0600546F RID: 21615 RVA: 0x00206BE3 File Offset: 0x00204DE3
		[NullableContext(1)]
		public IEnumerable<int> InstIdsIter()
		{
			BossPilingLevels.<InstIdsIter>d__95 <InstIdsIter>d__ = new BossPilingLevels.<InstIdsIter>d__95(-2);
			<InstIdsIter>d__.<>3__<>4__this = this;
			return <InstIdsIter>d__;
		}

		// Token: 0x06005470 RID: 21616 RVA: 0x00206BF8 File Offset: 0x00204DF8
		[NullableContext(1)]
		public int[] RareBuffGroup()
		{
			return this.GetRareBuffGroupArray();
		}

		// Token: 0x06005471 RID: 21617 RVA: 0x00206C00 File Offset: 0x00204E00
		[NullableContext(1)]
		public IEnumerable<int> RareBuffGroupIter()
		{
			BossPilingLevels.<RareBuffGroupIter>d__97 <RareBuffGroupIter>d__ = new BossPilingLevels.<RareBuffGroupIter>d__97(-2);
			<RareBuffGroupIter>d__.<>3__<>4__this = this;
			return <RareBuffGroupIter>d__;
		}

		// Token: 0x06005472 RID: 21618 RVA: 0x00206C15 File Offset: 0x00204E15
		[NullableContext(1)]
		public int[] RecommendFetter()
		{
			return this.GetRecommendFetterArray();
		}

		// Token: 0x06005473 RID: 21619 RVA: 0x00206C1D File Offset: 0x00204E1D
		[NullableContext(1)]
		public IEnumerable<int> RecommendFetterIter()
		{
			BossPilingLevels.<RecommendFetterIter>d__99 <RecommendFetterIter>d__ = new BossPilingLevels.<RecommendFetterIter>d__99(-2);
			<RecommendFetterIter>d__.<>3__<>4__this = this;
			return <RecommendFetterIter>d__;
		}

		// Token: 0x0400511C RID: 20764
		private Table __p;
	}
}
