using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F57 RID: 3927
	public struct MowTowerLevelsRe : IFlatbufferObject
	{
		// Token: 0x170022EA RID: 8938
		// (get) Token: 0x0600A331 RID: 41777 RVA: 0x002B6D8B File Offset: 0x002B4F8B
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600A332 RID: 41778 RVA: 0x002B6D98 File Offset: 0x002B4F98
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600A333 RID: 41779 RVA: 0x002B6DA0 File Offset: 0x002B4FA0
		public static MowTowerLevelsRe GetRootAsMowTowerLevelsRe(ByteBuffer _bb)
		{
			return MowTowerLevelsRe.GetRootAsMowTowerLevelsRe(_bb, default(MowTowerLevelsRe));
		}

		// Token: 0x0600A334 RID: 41780 RVA: 0x002B6DBC File Offset: 0x002B4FBC
		public static MowTowerLevelsRe GetRootAsMowTowerLevelsRe(ByteBuffer _bb, MowTowerLevelsRe obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600A335 RID: 41781 RVA: 0x002B6DD9 File Offset: 0x002B4FD9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600A336 RID: 41782 RVA: 0x002B6DE8 File Offset: 0x002B4FE8
		public MowTowerLevelsRe __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170022EB RID: 8939
		// (get) Token: 0x0600A337 RID: 41783 RVA: 0x002B6DF8 File Offset: 0x002B4FF8
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

		// Token: 0x170022EC RID: 8940
		// (get) Token: 0x0600A338 RID: 41784 RVA: 0x002B6E34 File Offset: 0x002B5034
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

		// Token: 0x170022ED RID: 8941
		// (get) Token: 0x0600A339 RID: 41785 RVA: 0x002B6E70 File Offset: 0x002B5070
		public int GroupId
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

		// Token: 0x0600A33A RID: 41786 RVA: 0x002B6EAC File Offset: 0x002B50AC
		public int InstIds(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170022EE RID: 8942
		// (get) Token: 0x0600A33B RID: 41787 RVA: 0x002B6EEC File Offset: 0x002B50EC
		public int InstIdsLength
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

		// Token: 0x0600A33C RID: 41788 RVA: 0x002B6F18 File Offset: 0x002B5118
		public Span<int> GetInstIdsBytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x0600A33D RID: 41789 RVA: 0x002B6F28 File Offset: 0x002B5128
		public int[] GetInstIdsArray()
		{
			return this.__p.__vector_as_array<int>(10) ?? Array.Empty<int>();
		}

		// Token: 0x170022EF RID: 8943
		// (get) Token: 0x0600A33E RID: 41790 RVA: 0x002B6F40 File Offset: 0x002B5140
		public int SortId
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

		// Token: 0x170022F0 RID: 8944
		// (get) Token: 0x0600A33F RID: 41791 RVA: 0x002B6F80 File Offset: 0x002B5180
		public int BuffCount
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

		// Token: 0x0600A340 RID: 41792 RVA: 0x002B6FC0 File Offset: 0x002B51C0
		public int OptionalBuff(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170022F1 RID: 8945
		// (get) Token: 0x0600A341 RID: 41793 RVA: 0x002B7000 File Offset: 0x002B5200
		public int OptionalBuffLength
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

		// Token: 0x0600A342 RID: 41794 RVA: 0x002B702C File Offset: 0x002B522C
		public Span<int> GetOptionalBuffBytes()
		{
			return this.__p.__vector_as_span<int>(16, 4);
		}

		// Token: 0x0600A343 RID: 41795 RVA: 0x002B703C File Offset: 0x002B523C
		public int[] GetOptionalBuffArray()
		{
			return this.__p.__vector_as_array<int>(16) ?? Array.Empty<int>();
		}

		// Token: 0x170022F2 RID: 8946
		// (get) Token: 0x0600A344 RID: 41796 RVA: 0x002B7054 File Offset: 0x002B5254
		public int OpenDay
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

		// Token: 0x170022F3 RID: 8947
		// (get) Token: 0x0600A345 RID: 41797 RVA: 0x002B7094 File Offset: 0x002B5294
		public int PreLevel
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170022F4 RID: 8948
		// (get) Token: 0x0600A346 RID: 41798 RVA: 0x002B70D4 File Offset: 0x002B52D4
		public int PassScore
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

		// Token: 0x170022F5 RID: 8949
		// (get) Token: 0x0600A347 RID: 41799 RVA: 0x002B7114 File Offset: 0x002B5314
		public string LevelRewardDesc
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

		// Token: 0x0600A348 RID: 41800 RVA: 0x002B714C File Offset: 0x002B534C
		public Span<byte> GetLevelRewardDescBytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x0600A349 RID: 41801 RVA: 0x002B715C File Offset: 0x002B535C
		public byte[] GetLevelRewardDescArray()
		{
			return this.__p.__vector_as_array<byte>(24) ?? Array.Empty<byte>();
		}

		// Token: 0x0600A34A RID: 41802 RVA: 0x002B7174 File Offset: 0x002B5374
		public int MowTowerLevel(int j)
		{
			int num = this.__p.__offset(26);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170022F6 RID: 8950
		// (get) Token: 0x0600A34B RID: 41803 RVA: 0x002B71B4 File Offset: 0x002B53B4
		public int MowTowerLevelLength
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600A34C RID: 41804 RVA: 0x002B71E0 File Offset: 0x002B53E0
		public Span<int> GetMowTowerLevelBytes()
		{
			return this.__p.__vector_as_span<int>(26, 4);
		}

		// Token: 0x0600A34D RID: 41805 RVA: 0x002B71F0 File Offset: 0x002B53F0
		public int[] GetMowTowerLevelArray()
		{
			return this.__p.__vector_as_array<int>(26) ?? Array.Empty<int>();
		}

		// Token: 0x170022F7 RID: 8951
		// (get) Token: 0x0600A34E RID: 41806 RVA: 0x002B7208 File Offset: 0x002B5408
		public string RewardName
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

		// Token: 0x0600A34F RID: 41807 RVA: 0x002B7240 File Offset: 0x002B5440
		public Span<byte> GetRewardNameBytes()
		{
			return this.__p.__vector_as_span<byte>(28, 1);
		}

		// Token: 0x0600A350 RID: 41808 RVA: 0x002B7250 File Offset: 0x002B5450
		public byte[] GetRewardNameArray()
		{
			return this.__p.__vector_as_array<byte>(28) ?? Array.Empty<byte>();
		}

		// Token: 0x170022F8 RID: 8952
		// (get) Token: 0x0600A351 RID: 41809 RVA: 0x002B7268 File Offset: 0x002B5468
		public string RewardTexture
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

		// Token: 0x0600A352 RID: 41810 RVA: 0x002B72A0 File Offset: 0x002B54A0
		public Span<byte> GetRewardTextureBytes()
		{
			return this.__p.__vector_as_span<byte>(30, 1);
		}

		// Token: 0x0600A353 RID: 41811 RVA: 0x002B72B0 File Offset: 0x002B54B0
		public byte[] GetRewardTextureArray()
		{
			return this.__p.__vector_as_array<byte>(30) ?? Array.Empty<byte>();
		}

		// Token: 0x170022F9 RID: 8953
		// (get) Token: 0x0600A354 RID: 41812 RVA: 0x002B72C8 File Offset: 0x002B54C8
		public string LevelDesc
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

		// Token: 0x0600A355 RID: 41813 RVA: 0x002B7300 File Offset: 0x002B5500
		public Span<byte> GetLevelDescBytes()
		{
			return this.__p.__vector_as_span<byte>(32, 1);
		}

		// Token: 0x0600A356 RID: 41814 RVA: 0x002B7310 File Offset: 0x002B5510
		public byte[] GetLevelDescArray()
		{
			return this.__p.__vector_as_array<byte>(32) ?? Array.Empty<byte>();
		}

		// Token: 0x170022FA RID: 8954
		// (get) Token: 0x0600A357 RID: 41815 RVA: 0x002B7328 File Offset: 0x002B5528
		public string NormalTexture
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

		// Token: 0x0600A358 RID: 41816 RVA: 0x002B7360 File Offset: 0x002B5560
		public Span<byte> GetNormalTextureBytes()
		{
			return this.__p.__vector_as_span<byte>(34, 1);
		}

		// Token: 0x0600A359 RID: 41817 RVA: 0x002B7370 File Offset: 0x002B5570
		public byte[] GetNormalTextureArray()
		{
			return this.__p.__vector_as_array<byte>(34) ?? Array.Empty<byte>();
		}

		// Token: 0x170022FB RID: 8955
		// (get) Token: 0x0600A35A RID: 41818 RVA: 0x002B7388 File Offset: 0x002B5588
		public string LockTexture
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

		// Token: 0x0600A35B RID: 41819 RVA: 0x002B73C0 File Offset: 0x002B55C0
		public Span<byte> GetLockTextureBytes()
		{
			return this.__p.__vector_as_span<byte>(36, 1);
		}

		// Token: 0x0600A35C RID: 41820 RVA: 0x002B73D0 File Offset: 0x002B55D0
		public byte[] GetLockTextureArray()
		{
			return this.__p.__vector_as_array<byte>(36) ?? Array.Empty<byte>();
		}

		// Token: 0x170022FC RID: 8956
		// (get) Token: 0x0600A35D RID: 41821 RVA: 0x002B73E8 File Offset: 0x002B55E8
		public string LevelTips
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

		// Token: 0x0600A35E RID: 41822 RVA: 0x002B7420 File Offset: 0x002B5620
		public Span<byte> GetLevelTipsBytes()
		{
			return this.__p.__vector_as_span<byte>(38, 1);
		}

		// Token: 0x0600A35F RID: 41823 RVA: 0x002B7430 File Offset: 0x002B5630
		public byte[] GetLevelTipsArray()
		{
			return this.__p.__vector_as_array<byte>(38) ?? Array.Empty<byte>();
		}

		// Token: 0x170022FD RID: 8957
		// (get) Token: 0x0600A360 RID: 41824 RVA: 0x002B7448 File Offset: 0x002B5648
		public bool IsInfinite
		{
			get
			{
				int num = this.__p.__offset(40);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170022FE RID: 8958
		// (get) Token: 0x0600A361 RID: 41825 RVA: 0x002B7488 File Offset: 0x002B5688
		public string MonsterDes
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

		// Token: 0x0600A362 RID: 41826 RVA: 0x002B74C0 File Offset: 0x002B56C0
		public Span<byte> GetMonsterDesBytes()
		{
			return this.__p.__vector_as_span<byte>(42, 1);
		}

		// Token: 0x0600A363 RID: 41827 RVA: 0x002B74D0 File Offset: 0x002B56D0
		public byte[] GetMonsterDesArray()
		{
			return this.__p.__vector_as_array<byte>(42) ?? Array.Empty<byte>();
		}

		// Token: 0x0600A364 RID: 41828 RVA: 0x002B74E8 File Offset: 0x002B56E8
		[NullableContext(1)]
		public int[] InstIds()
		{
			return this.GetInstIdsArray();
		}

		// Token: 0x0600A365 RID: 41829 RVA: 0x002B74F0 File Offset: 0x002B56F0
		[NullableContext(1)]
		public IEnumerable<int> InstIdsIter()
		{
			MowTowerLevelsRe.<InstIdsIter>d__74 <InstIdsIter>d__ = new MowTowerLevelsRe.<InstIdsIter>d__74(-2);
			<InstIdsIter>d__.<>3__<>4__this = this;
			return <InstIdsIter>d__;
		}

		// Token: 0x0600A366 RID: 41830 RVA: 0x002B7505 File Offset: 0x002B5705
		[NullableContext(1)]
		public int[] MowTowerLevel()
		{
			return this.GetMowTowerLevelArray();
		}

		// Token: 0x0600A367 RID: 41831 RVA: 0x002B750D File Offset: 0x002B570D
		[NullableContext(1)]
		public IEnumerable<int> MowTowerLevelIter()
		{
			MowTowerLevelsRe.<MowTowerLevelIter>d__76 <MowTowerLevelIter>d__ = new MowTowerLevelsRe.<MowTowerLevelIter>d__76(-2);
			<MowTowerLevelIter>d__.<>3__<>4__this = this;
			return <MowTowerLevelIter>d__;
		}

		// Token: 0x0600A368 RID: 41832 RVA: 0x002B7522 File Offset: 0x002B5722
		[NullableContext(1)]
		public int[] OptionalBuff()
		{
			return this.GetOptionalBuffArray();
		}

		// Token: 0x0600A369 RID: 41833 RVA: 0x002B752A File Offset: 0x002B572A
		[NullableContext(1)]
		public IEnumerable<int> OptionalBuffIter()
		{
			MowTowerLevelsRe.<OptionalBuffIter>d__78 <OptionalBuffIter>d__ = new MowTowerLevelsRe.<OptionalBuffIter>d__78(-2);
			<OptionalBuffIter>d__.<>3__<>4__this = this;
			return <OptionalBuffIter>d__;
		}

		// Token: 0x04005505 RID: 21765
		private Table __p;
	}
}
