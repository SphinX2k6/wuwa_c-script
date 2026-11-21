using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F7C RID: 3964
	public struct NewTowerWave : IFlatbufferObject
	{
		// Token: 0x1700240E RID: 9230
		// (get) Token: 0x0600A664 RID: 42596 RVA: 0x002BDA01 File Offset: 0x002BBC01
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600A665 RID: 42597 RVA: 0x002BDA0E File Offset: 0x002BBC0E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600A666 RID: 42598 RVA: 0x002BDA18 File Offset: 0x002BBC18
		public static NewTowerWave GetRootAsNewTowerWave(ByteBuffer _bb)
		{
			return NewTowerWave.GetRootAsNewTowerWave(_bb, default(NewTowerWave));
		}

		// Token: 0x0600A667 RID: 42599 RVA: 0x002BDA34 File Offset: 0x002BBC34
		public static NewTowerWave GetRootAsNewTowerWave(ByteBuffer _bb, NewTowerWave obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600A668 RID: 42600 RVA: 0x002BDA51 File Offset: 0x002BBC51
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600A669 RID: 42601 RVA: 0x002BDA60 File Offset: 0x002BBC60
		public NewTowerWave __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700240F RID: 9231
		// (get) Token: 0x0600A66A RID: 42602 RVA: 0x002BDA70 File Offset: 0x002BBC70
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

		// Token: 0x17002410 RID: 9232
		// (get) Token: 0x0600A66B RID: 42603 RVA: 0x002BDAAC File Offset: 0x002BBCAC
		public int Level
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

		// Token: 0x17002411 RID: 9233
		// (get) Token: 0x0600A66C RID: 42604 RVA: 0x002BDAE8 File Offset: 0x002BBCE8
		public int Round
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

		// Token: 0x17002412 RID: 9234
		// (get) Token: 0x0600A66D RID: 42605 RVA: 0x002BDB24 File Offset: 0x002BBD24
		public int Wave
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

		// Token: 0x17002413 RID: 9235
		// (get) Token: 0x0600A66E RID: 42606 RVA: 0x002BDB64 File Offset: 0x002BBD64
		public bool IsShowInView
		{
			get
			{
				int num = this.__p.__offset(12);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17002414 RID: 9236
		// (get) Token: 0x0600A66F RID: 42607 RVA: 0x002BDBA4 File Offset: 0x002BBDA4
		public int RecommendId
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

		// Token: 0x17002415 RID: 9237
		// (get) Token: 0x0600A670 RID: 42608 RVA: 0x002BDBE4 File Offset: 0x002BBDE4
		public int KillScore
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 100;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17002416 RID: 9238
		// (get) Token: 0x0600A671 RID: 42609 RVA: 0x002BDC24 File Offset: 0x002BBE24
		public int MonsterLevel
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

		// Token: 0x17002417 RID: 9239
		// (get) Token: 0x0600A672 RID: 42610 RVA: 0x002BDC64 File Offset: 0x002BBE64
		public int DamegaRate
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 1000000;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17002418 RID: 9240
		// (get) Token: 0x0600A673 RID: 42611 RVA: 0x002BDCA8 File Offset: 0x002BBEA8
		public int MonsterId
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17002419 RID: 9241
		// (get) Token: 0x0600A674 RID: 42612 RVA: 0x002BDCE8 File Offset: 0x002BBEE8
		public string Icon
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

		// Token: 0x0600A675 RID: 42613 RVA: 0x002BDD20 File Offset: 0x002BBF20
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x0600A676 RID: 42614 RVA: 0x002BDD30 File Offset: 0x002BBF30
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(24) ?? Array.Empty<byte>();
		}

		// Token: 0x1700241A RID: 9242
		// (get) Token: 0x0600A677 RID: 42615 RVA: 0x002BDD48 File Offset: 0x002BBF48
		public string Name
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

		// Token: 0x0600A678 RID: 42616 RVA: 0x002BDD80 File Offset: 0x002BBF80
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(26, 1);
		}

		// Token: 0x0600A679 RID: 42617 RVA: 0x002BDD90 File Offset: 0x002BBF90
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(26) ?? Array.Empty<byte>();
		}

		// Token: 0x1700241B RID: 9243
		// (get) Token: 0x0600A67A RID: 42618 RVA: 0x002BDDA8 File Offset: 0x002BBFA8
		public string Desc
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

		// Token: 0x0600A67B RID: 42619 RVA: 0x002BDDE0 File Offset: 0x002BBFE0
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(28, 1);
		}

		// Token: 0x0600A67C RID: 42620 RVA: 0x002BDDF0 File Offset: 0x002BBFF0
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(28) ?? Array.Empty<byte>();
		}

		// Token: 0x1700241C RID: 9244
		// (get) Token: 0x0600A67D RID: 42621 RVA: 0x002BDE08 File Offset: 0x002BC008
		public string SmallIcon
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

		// Token: 0x0600A67E RID: 42622 RVA: 0x002BDE40 File Offset: 0x002BC040
		public Span<byte> GetSmallIconBytes()
		{
			return this.__p.__vector_as_span<byte>(30, 1);
		}

		// Token: 0x0600A67F RID: 42623 RVA: 0x002BDE50 File Offset: 0x002BC050
		public byte[] GetSmallIconArray()
		{
			return this.__p.__vector_as_array<byte>(30) ?? Array.Empty<byte>();
		}

		// Token: 0x0600A680 RID: 42624 RVA: 0x002BDE68 File Offset: 0x002BC068
		public string BigIcon(int j)
		{
			int num = this.__p.__offset(32);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700241D RID: 9245
		// (get) Token: 0x0600A681 RID: 42625 RVA: 0x002BDEA4 File Offset: 0x002BC0A4
		public int BigIconLength
		{
			get
			{
				int num = this.__p.__offset(32);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600A682 RID: 42626 RVA: 0x002BDED0 File Offset: 0x002BC0D0
		public int TagIdList(int j)
		{
			int num = this.__p.__offset(34);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700241E RID: 9246
		// (get) Token: 0x0600A683 RID: 42627 RVA: 0x002BDF10 File Offset: 0x002BC110
		public int TagIdListLength
		{
			get
			{
				int num = this.__p.__offset(34);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600A684 RID: 42628 RVA: 0x002BDF3C File Offset: 0x002BC13C
		public Span<int> GetTagIdListBytes()
		{
			return this.__p.__vector_as_span<int>(34, 4);
		}

		// Token: 0x0600A685 RID: 42629 RVA: 0x002BDF4C File Offset: 0x002BC14C
		public int[] GetTagIdListArray()
		{
			return this.__p.__vector_as_array<int>(34) ?? Array.Empty<int>();
		}

		// Token: 0x1700241F RID: 9247
		// (get) Token: 0x0600A686 RID: 42630 RVA: 0x002BDF64 File Offset: 0x002BC164
		public string SmallIconInModeView
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

		// Token: 0x0600A687 RID: 42631 RVA: 0x002BDF9C File Offset: 0x002BC19C
		public Span<byte> GetSmallIconInModeViewBytes()
		{
			return this.__p.__vector_as_span<byte>(36, 1);
		}

		// Token: 0x0600A688 RID: 42632 RVA: 0x002BDFAC File Offset: 0x002BC1AC
		public byte[] GetSmallIconInModeViewArray()
		{
			return this.__p.__vector_as_array<byte>(36) ?? Array.Empty<byte>();
		}

		// Token: 0x17002420 RID: 9248
		// (get) Token: 0x0600A689 RID: 42633 RVA: 0x002BDFC4 File Offset: 0x002BC1C4
		public string BigIconInModeView
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

		// Token: 0x0600A68A RID: 42634 RVA: 0x002BDFFC File Offset: 0x002BC1FC
		public Span<byte> GetBigIconInModeViewBytes()
		{
			return this.__p.__vector_as_span<byte>(38, 1);
		}

		// Token: 0x0600A68B RID: 42635 RVA: 0x002BE00C File Offset: 0x002BC20C
		public byte[] GetBigIconInModeViewArray()
		{
			return this.__p.__vector_as_array<byte>(38) ?? Array.Empty<byte>();
		}

		// Token: 0x17002421 RID: 9249
		// (get) Token: 0x0600A68C RID: 42636 RVA: 0x002BE024 File Offset: 0x002BC224
		public string SmallIconHandBook
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

		// Token: 0x0600A68D RID: 42637 RVA: 0x002BE05C File Offset: 0x002BC25C
		public Span<byte> GetSmallIconHandBookBytes()
		{
			return this.__p.__vector_as_span<byte>(40, 1);
		}

		// Token: 0x0600A68E RID: 42638 RVA: 0x002BE06C File Offset: 0x002BC26C
		public byte[] GetSmallIconHandBookArray()
		{
			return this.__p.__vector_as_array<byte>(40) ?? Array.Empty<byte>();
		}

		// Token: 0x17002422 RID: 9250
		// (get) Token: 0x0600A68F RID: 42639 RVA: 0x002BE084 File Offset: 0x002BC284
		public string MonsterPortrait
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

		// Token: 0x0600A690 RID: 42640 RVA: 0x002BE0BC File Offset: 0x002BC2BC
		public Span<byte> GetMonsterPortraitBytes()
		{
			return this.__p.__vector_as_span<byte>(42, 1);
		}

		// Token: 0x0600A691 RID: 42641 RVA: 0x002BE0CC File Offset: 0x002BC2CC
		public byte[] GetMonsterPortraitArray()
		{
			return this.__p.__vector_as_array<byte>(42) ?? Array.Empty<byte>();
		}

		// Token: 0x17002423 RID: 9251
		// (get) Token: 0x0600A692 RID: 42642 RVA: 0x002BE0E4 File Offset: 0x002BC2E4
		public int ElementId
		{
			get
			{
				int num = this.__p.__offset(44);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600A693 RID: 42643 RVA: 0x002BE124 File Offset: 0x002BC324
		public int ShowBuffIds(int j)
		{
			int num = this.__p.__offset(46);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002424 RID: 9252
		// (get) Token: 0x0600A694 RID: 42644 RVA: 0x002BE164 File Offset: 0x002BC364
		public int ShowBuffIdsLength
		{
			get
			{
				int num = this.__p.__offset(46);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600A695 RID: 42645 RVA: 0x002BE190 File Offset: 0x002BC390
		public Span<int> GetShowBuffIdsBytes()
		{
			return this.__p.__vector_as_span<int>(46, 4);
		}

		// Token: 0x0600A696 RID: 42646 RVA: 0x002BE1A0 File Offset: 0x002BC3A0
		public int[] GetShowBuffIdsArray()
		{
			return this.__p.__vector_as_array<int>(46) ?? Array.Empty<int>();
		}

		// Token: 0x0600A697 RID: 42647 RVA: 0x002BE1B8 File Offset: 0x002BC3B8
		public DicIntIntArray? HandBookBuff(int j)
		{
			int num = this.__p.__offset(48);
			if (num == 0)
			{
				return null;
			}
			return new DicIntIntArray?(default(DicIntIntArray).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17002425 RID: 9253
		// (get) Token: 0x0600A698 RID: 42648 RVA: 0x002BE21C File Offset: 0x002BC41C
		public int HandBookBuffLength
		{
			get
			{
				int num = this.__p.__offset(48);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600A699 RID: 42649 RVA: 0x002BE248 File Offset: 0x002BC448
		public int RecommendTeamFeature(int j)
		{
			int num = this.__p.__offset(50);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002426 RID: 9254
		// (get) Token: 0x0600A69A RID: 42650 RVA: 0x002BE288 File Offset: 0x002BC488
		public int RecommendTeamFeatureLength
		{
			get
			{
				int num = this.__p.__offset(50);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600A69B RID: 42651 RVA: 0x002BE2B4 File Offset: 0x002BC4B4
		public Span<int> GetRecommendTeamFeatureBytes()
		{
			return this.__p.__vector_as_span<int>(50, 4);
		}

		// Token: 0x0600A69C RID: 42652 RVA: 0x002BE2C4 File Offset: 0x002BC4C4
		public int[] GetRecommendTeamFeatureArray()
		{
			return this.__p.__vector_as_array<int>(50) ?? Array.Empty<int>();
		}

		// Token: 0x17002427 RID: 9255
		// (get) Token: 0x0600A69D RID: 42653 RVA: 0x002BE2DC File Offset: 0x002BC4DC
		public float DamegaRateShow
		{
			get
			{
				int num = this.__p.__offset(52);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600A69E RID: 42654 RVA: 0x002BE31D File Offset: 0x002BC51D
		[NullableContext(1)]
		public string[] BigIcon()
		{
			return this.BigIconIter().ToArray<string>();
		}

		// Token: 0x0600A69F RID: 42655 RVA: 0x002BE32A File Offset: 0x002BC52A
		[NullableContext(1)]
		public IEnumerable<string> BigIconIter()
		{
			NewTowerWave.<BigIconIter>d__86 <BigIconIter>d__ = new NewTowerWave.<BigIconIter>d__86(-2);
			<BigIconIter>d__.<>3__<>4__this = this;
			return <BigIconIter>d__;
		}

		// Token: 0x0600A6A0 RID: 42656 RVA: 0x002BE340 File Offset: 0x002BC540
		[NullableContext(1)]
		public Dictionary<int, IntArray> HandBookBuff()
		{
			return this.HandBookBuffIter().ToDictionary((DicIntIntArray element) => element.Key, (DicIntIntArray element) => element.Value.Value);
		}

		// Token: 0x0600A6A1 RID: 42657 RVA: 0x002BE396 File Offset: 0x002BC596
		[NullableContext(1)]
		public IEnumerable<DicIntIntArray> HandBookBuffIter()
		{
			NewTowerWave.<HandBookBuffIter>d__88 <HandBookBuffIter>d__ = new NewTowerWave.<HandBookBuffIter>d__88(-2);
			<HandBookBuffIter>d__.<>3__<>4__this = this;
			return <HandBookBuffIter>d__;
		}

		// Token: 0x0600A6A2 RID: 42658 RVA: 0x002BE3AB File Offset: 0x002BC5AB
		[NullableContext(1)]
		public int[] RecommendTeamFeature()
		{
			return this.GetRecommendTeamFeatureArray();
		}

		// Token: 0x0600A6A3 RID: 42659 RVA: 0x002BE3B3 File Offset: 0x002BC5B3
		[NullableContext(1)]
		public IEnumerable<int> RecommendTeamFeatureIter()
		{
			NewTowerWave.<RecommendTeamFeatureIter>d__90 <RecommendTeamFeatureIter>d__ = new NewTowerWave.<RecommendTeamFeatureIter>d__90(-2);
			<RecommendTeamFeatureIter>d__.<>3__<>4__this = this;
			return <RecommendTeamFeatureIter>d__;
		}

		// Token: 0x0600A6A4 RID: 42660 RVA: 0x002BE3C8 File Offset: 0x002BC5C8
		[NullableContext(1)]
		public int[] ShowBuffIds()
		{
			return this.GetShowBuffIdsArray();
		}

		// Token: 0x0600A6A5 RID: 42661 RVA: 0x002BE3D0 File Offset: 0x002BC5D0
		[NullableContext(1)]
		public IEnumerable<int> ShowBuffIdsIter()
		{
			NewTowerWave.<ShowBuffIdsIter>d__92 <ShowBuffIdsIter>d__ = new NewTowerWave.<ShowBuffIdsIter>d__92(-2);
			<ShowBuffIdsIter>d__.<>3__<>4__this = this;
			return <ShowBuffIdsIter>d__;
		}

		// Token: 0x0600A6A6 RID: 42662 RVA: 0x002BE3E5 File Offset: 0x002BC5E5
		[NullableContext(1)]
		public int[] TagIdList()
		{
			return this.GetTagIdListArray();
		}

		// Token: 0x0600A6A7 RID: 42663 RVA: 0x002BE3ED File Offset: 0x002BC5ED
		[NullableContext(1)]
		public IEnumerable<int> TagIdListIter()
		{
			NewTowerWave.<TagIdListIter>d__94 <TagIdListIter>d__ = new NewTowerWave.<TagIdListIter>d__94(-2);
			<TagIdListIter>d__.<>3__<>4__this = this;
			return <TagIdListIter>d__;
		}

		// Token: 0x0600A6A8 RID: 42664 RVA: 0x002BE404 File Offset: 0x002BC604
		public IntArray? GetHandBookBuff(int key)
		{
			this.EnsureHandBookBuffCacheIfNeeded();
			IntArray value;
			if (!this.HandBookBuffCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new IntArray?(value);
		}

		// Token: 0x0600A6A9 RID: 42665 RVA: 0x002BE438 File Offset: 0x002BC638
		private void EnsureHandBookBuffCacheIfNeeded()
		{
			if (this.HandBookBuffCache != null)
			{
				return;
			}
			this.HandBookBuffCache = this.HandBookBuffIter().ToFrozenDictionary((DicIntIntArray kvp) => kvp.Key, (DicIntIntArray kvp) => kvp.Value.Value, null);
		}

		// Token: 0x0600A6AA RID: 42666 RVA: 0x002BE49E File Offset: 0x002BC69E
		[NullableContext(1)]
		public FrozenDictionary<int, IntArray> GetHandBookBuffFrozenDict()
		{
			this.EnsureHandBookBuffCacheIfNeeded();
			return this.HandBookBuffCache;
		}

		// Token: 0x0400552F RID: 21807
		private Table __p;

		// Token: 0x04005530 RID: 21808
		[Nullable(2)]
		private FrozenDictionary<int, IntArray> HandBookBuffCache;
	}
}
