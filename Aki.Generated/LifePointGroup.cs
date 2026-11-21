using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000EAD RID: 3757
	public struct LifePointGroup : IFlatbufferObject
	{
		// Token: 0x17001D42 RID: 7490
		// (get) Token: 0x0600940A RID: 37898 RVA: 0x00295BE2 File Offset: 0x00293DE2
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600940B RID: 37899 RVA: 0x00295BEF File Offset: 0x00293DEF
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600940C RID: 37900 RVA: 0x00295BF8 File Offset: 0x00293DF8
		public static LifePointGroup GetRootAsLifePointGroup(ByteBuffer _bb)
		{
			return LifePointGroup.GetRootAsLifePointGroup(_bb, default(LifePointGroup));
		}

		// Token: 0x0600940D RID: 37901 RVA: 0x00295C14 File Offset: 0x00293E14
		public static LifePointGroup GetRootAsLifePointGroup(ByteBuffer _bb, LifePointGroup obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600940E RID: 37902 RVA: 0x00295C31 File Offset: 0x00293E31
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600940F RID: 37903 RVA: 0x00295C40 File Offset: 0x00293E40
		public LifePointGroup __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001D43 RID: 7491
		// (get) Token: 0x06009410 RID: 37904 RVA: 0x00295C50 File Offset: 0x00293E50
		public int GroupId
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

		// Token: 0x06009411 RID: 37905 RVA: 0x00295C8C File Offset: 0x00293E8C
		public int ChallengeList(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001D44 RID: 7492
		// (get) Token: 0x06009412 RID: 37906 RVA: 0x00295CCC File Offset: 0x00293ECC
		public int ChallengeListLength
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06009413 RID: 37907 RVA: 0x00295CF7 File Offset: 0x00293EF7
		public Span<int> GetChallengeListBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x06009414 RID: 37908 RVA: 0x00295D06 File Offset: 0x00293F06
		public int[] GetChallengeListArray()
		{
			return this.__p.__vector_as_array<int>(6) ?? Array.Empty<int>();
		}

		// Token: 0x17001D45 RID: 7493
		// (get) Token: 0x06009415 RID: 37909 RVA: 0x00295D20 File Offset: 0x00293F20
		public string LockEntracneGroupNumResource
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

		// Token: 0x06009416 RID: 37910 RVA: 0x00295D57 File Offset: 0x00293F57
		public Span<byte> GetLockEntracneGroupNumResourceBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06009417 RID: 37911 RVA: 0x00295D66 File Offset: 0x00293F66
		public byte[] GetLockEntracneGroupNumResourceArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17001D46 RID: 7494
		// (get) Token: 0x06009418 RID: 37912 RVA: 0x00295D80 File Offset: 0x00293F80
		public string EntracneGroupNumResource
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

		// Token: 0x06009419 RID: 37913 RVA: 0x00295DB8 File Offset: 0x00293FB8
		public Span<byte> GetEntracneGroupNumResourceBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600941A RID: 37914 RVA: 0x00295DC8 File Offset: 0x00293FC8
		public byte[] GetEntracneGroupNumResourceArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17001D47 RID: 7495
		// (get) Token: 0x0600941B RID: 37915 RVA: 0x00295DE0 File Offset: 0x00293FE0
		public string HighlightEntranceResource
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

		// Token: 0x0600941C RID: 37916 RVA: 0x00295E18 File Offset: 0x00294018
		public Span<byte> GetHighlightEntranceResourceBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600941D RID: 37917 RVA: 0x00295E28 File Offset: 0x00294028
		public byte[] GetHighlightEntranceResourceArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17001D48 RID: 7496
		// (get) Token: 0x0600941E RID: 37918 RVA: 0x00295E40 File Offset: 0x00294040
		public string LockHighlightEntranceResource
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

		// Token: 0x0600941F RID: 37919 RVA: 0x00295E78 File Offset: 0x00294078
		public Span<byte> GetLockHighlightEntranceResourceBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x06009420 RID: 37920 RVA: 0x00295E88 File Offset: 0x00294088
		public byte[] GetLockHighlightEntranceResourceArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17001D49 RID: 7497
		// (get) Token: 0x06009421 RID: 37921 RVA: 0x00295EA0 File Offset: 0x002940A0
		public string LevelNumResource
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

		// Token: 0x06009422 RID: 37922 RVA: 0x00295ED8 File Offset: 0x002940D8
		public Span<byte> GetLevelNumResourceBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x06009423 RID: 37923 RVA: 0x00295EE8 File Offset: 0x002940E8
		public byte[] GetLevelNumResourceArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x17001D4A RID: 7498
		// (get) Token: 0x06009424 RID: 37924 RVA: 0x00295F00 File Offset: 0x00294100
		public string Name
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

		// Token: 0x06009425 RID: 37925 RVA: 0x00295F38 File Offset: 0x00294138
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x06009426 RID: 37926 RVA: 0x00295F48 File Offset: 0x00294148
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x06009427 RID: 37927 RVA: 0x00295F60 File Offset: 0x00294160
		[NullableContext(1)]
		public int[] ChallengeList()
		{
			return this.GetChallengeListArray();
		}

		// Token: 0x06009428 RID: 37928 RVA: 0x00295F68 File Offset: 0x00294168
		[NullableContext(1)]
		public IEnumerable<int> ChallengeListIter()
		{
			LifePointGroup.<ChallengeListIter>d__40 <ChallengeListIter>d__ = new LifePointGroup.<ChallengeListIter>d__40(-2);
			<ChallengeListIter>d__.<>3__<>4__this = this;
			return <ChallengeListIter>d__;
		}

		// Token: 0x04005443 RID: 21571
		private Table __p;
	}
}
