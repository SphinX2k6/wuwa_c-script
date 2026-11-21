using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F3F RID: 3903
	public struct MotorLinkageQuest : IFlatbufferObject
	{
		// Token: 0x17002203 RID: 8707
		// (get) Token: 0x0600A0BC RID: 41148 RVA: 0x002B1775 File Offset: 0x002AF975
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600A0BD RID: 41149 RVA: 0x002B1782 File Offset: 0x002AF982
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600A0BE RID: 41150 RVA: 0x002B178C File Offset: 0x002AF98C
		public static MotorLinkageQuest GetRootAsMotorLinkageQuest(ByteBuffer _bb)
		{
			return MotorLinkageQuest.GetRootAsMotorLinkageQuest(_bb, default(MotorLinkageQuest));
		}

		// Token: 0x0600A0BF RID: 41151 RVA: 0x002B17A8 File Offset: 0x002AF9A8
		public static MotorLinkageQuest GetRootAsMotorLinkageQuest(ByteBuffer _bb, MotorLinkageQuest obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600A0C0 RID: 41152 RVA: 0x002B17C5 File Offset: 0x002AF9C5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600A0C1 RID: 41153 RVA: 0x002B17D4 File Offset: 0x002AF9D4
		public MotorLinkageQuest __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002204 RID: 8708
		// (get) Token: 0x0600A0C2 RID: 41154 RVA: 0x002B17E4 File Offset: 0x002AF9E4
		public int TaskId
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

		// Token: 0x17002205 RID: 8709
		// (get) Token: 0x0600A0C3 RID: 41155 RVA: 0x002B1820 File Offset: 0x002AFA20
		public int Ip
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

		// Token: 0x17002206 RID: 8710
		// (get) Token: 0x0600A0C4 RID: 41156 RVA: 0x002B185C File Offset: 0x002AFA5C
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

		// Token: 0x17002207 RID: 8711
		// (get) Token: 0x0600A0C5 RID: 41157 RVA: 0x002B1898 File Offset: 0x002AFA98
		public string TaskName
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

		// Token: 0x0600A0C6 RID: 41158 RVA: 0x002B18D0 File Offset: 0x002AFAD0
		public Span<byte> GetTaskNameBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600A0C7 RID: 41159 RVA: 0x002B18E0 File Offset: 0x002AFAE0
		public byte[] GetTaskNameArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17002208 RID: 8712
		// (get) Token: 0x0600A0C8 RID: 41160 RVA: 0x002B18F8 File Offset: 0x002AFAF8
		public int AccessId
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

		// Token: 0x0600A0C9 RID: 41161 RVA: 0x002B1938 File Offset: 0x002AFB38
		public DicIntInt? RewardInfo(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17002209 RID: 8713
		// (get) Token: 0x0600A0CA RID: 41162 RVA: 0x002B199C File Offset: 0x002AFB9C
		public int RewardInfoLength
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

		// Token: 0x1700220A RID: 8714
		// (get) Token: 0x0600A0CB RID: 41163 RVA: 0x002B19C8 File Offset: 0x002AFBC8
		public bool HasSticker
		{
			get
			{
				int num = this.__p.__offset(16);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700220B RID: 8715
		// (get) Token: 0x0600A0CC RID: 41164 RVA: 0x002B1A08 File Offset: 0x002AFC08
		public string StickerIcon
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

		// Token: 0x0600A0CD RID: 41165 RVA: 0x002B1A40 File Offset: 0x002AFC40
		public Span<byte> GetStickerIconBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0600A0CE RID: 41166 RVA: 0x002B1A50 File Offset: 0x002AFC50
		public byte[] GetStickerIconArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x0600A0CF RID: 41167 RVA: 0x002B1A68 File Offset: 0x002AFC68
		[NullableContext(1)]
		public Dictionary<int, int> RewardInfo()
		{
			return this.RewardInfoIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x0600A0D0 RID: 41168 RVA: 0x002B1ABE File Offset: 0x002AFCBE
		[NullableContext(1)]
		public IEnumerable<DicIntInt> RewardInfoIter()
		{
			MotorLinkageQuest.<RewardInfoIter>d__30 <RewardInfoIter>d__ = new MotorLinkageQuest.<RewardInfoIter>d__30(-2);
			<RewardInfoIter>d__.<>3__<>4__this = this;
			return <RewardInfoIter>d__;
		}

		// Token: 0x0600A0D1 RID: 41169 RVA: 0x002B1AD4 File Offset: 0x002AFCD4
		public int? GetRewardInfo(int key)
		{
			this.EnsureRewardInfoCacheIfNeeded();
			int value;
			if (!this.RewardInfoCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x0600A0D2 RID: 41170 RVA: 0x002B1B08 File Offset: 0x002AFD08
		private void EnsureRewardInfoCacheIfNeeded()
		{
			if (this.RewardInfoCache != null)
			{
				return;
			}
			this.RewardInfoCache = this.RewardInfoIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x0600A0D3 RID: 41171 RVA: 0x002B1B6E File Offset: 0x002AFD6E
		[NullableContext(1)]
		public FrozenDictionary<int, int> GetRewardInfoFrozenDict()
		{
			this.EnsureRewardInfoCacheIfNeeded();
			return this.RewardInfoCache;
		}

		// Token: 0x040054E8 RID: 21736
		private Table __p;

		// Token: 0x040054E9 RID: 21737
		[Nullable(2)]
		private FrozenDictionary<int, int> RewardInfoCache;
	}
}
