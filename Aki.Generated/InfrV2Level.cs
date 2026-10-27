using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D6A RID: 3434
	public struct InfrV2Level : IFlatbufferObject
	{
		// Token: 0x17001921 RID: 6433
		// (get) Token: 0x060083E1 RID: 33761 RVA: 0x0025FF96 File Offset: 0x0025E196
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060083E2 RID: 33762 RVA: 0x0025FFA3 File Offset: 0x0025E1A3
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060083E3 RID: 33763 RVA: 0x0025FFAC File Offset: 0x0025E1AC
		public static InfrV2Level GetRootAsInfrV2Level(ByteBuffer _bb)
		{
			return InfrV2Level.GetRootAsInfrV2Level(_bb, default(InfrV2Level));
		}

		// Token: 0x060083E4 RID: 33764 RVA: 0x0025FFC8 File Offset: 0x0025E1C8
		public static InfrV2Level GetRootAsInfrV2Level(ByteBuffer _bb, InfrV2Level obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060083E5 RID: 33765 RVA: 0x0025FFE5 File Offset: 0x0025E1E5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060083E6 RID: 33766 RVA: 0x0025FFF4 File Offset: 0x0025E1F4
		public InfrV2Level __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001922 RID: 6434
		// (get) Token: 0x060083E7 RID: 33767 RVA: 0x00260004 File Offset: 0x0025E204
		public int Level
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

		// Token: 0x17001923 RID: 6435
		// (get) Token: 0x060083E8 RID: 33768 RVA: 0x00260040 File Offset: 0x0025E240
		public int ConditionId
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

		// Token: 0x060083E9 RID: 33769 RVA: 0x0026007C File Offset: 0x0025E27C
		public DicIntInt? Requirement(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17001924 RID: 6436
		// (get) Token: 0x060083EA RID: 33770 RVA: 0x002600DC File Offset: 0x0025E2DC
		public int RequirementLength
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

		// Token: 0x17001925 RID: 6437
		// (get) Token: 0x060083EB RID: 33771 RVA: 0x00260108 File Offset: 0x0025E308
		public string Description
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

		// Token: 0x060083EC RID: 33772 RVA: 0x00260140 File Offset: 0x0025E340
		public Span<byte> GetDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x060083ED RID: 33773 RVA: 0x00260150 File Offset: 0x0025E350
		public byte[] GetDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17001926 RID: 6438
		// (get) Token: 0x060083EE RID: 33774 RVA: 0x00260168 File Offset: 0x0025E368
		public string Name
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

		// Token: 0x060083EF RID: 33775 RVA: 0x002601A0 File Offset: 0x0025E3A0
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x060083F0 RID: 33776 RVA: 0x002601B0 File Offset: 0x0025E3B0
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17001927 RID: 6439
		// (get) Token: 0x060083F1 RID: 33777 RVA: 0x002601C8 File Offset: 0x0025E3C8
		public string InfoPicturePath
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

		// Token: 0x060083F2 RID: 33778 RVA: 0x00260200 File Offset: 0x0025E400
		public Span<byte> GetInfoPicturePathBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x060083F3 RID: 33779 RVA: 0x00260210 File Offset: 0x0025E410
		public byte[] GetInfoPicturePathArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17001928 RID: 6440
		// (get) Token: 0x060083F4 RID: 33780 RVA: 0x00260228 File Offset: 0x0025E428
		public string BuildSuccessDes
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

		// Token: 0x060083F5 RID: 33781 RVA: 0x00260260 File Offset: 0x0025E460
		public Span<byte> GetBuildSuccessDesBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x060083F6 RID: 33782 RVA: 0x00260270 File Offset: 0x0025E470
		public byte[] GetBuildSuccessDesArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x17001929 RID: 6441
		// (get) Token: 0x060083F7 RID: 33783 RVA: 0x00260288 File Offset: 0x0025E488
		public int JumpId
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

		// Token: 0x060083F8 RID: 33784 RVA: 0x002602C8 File Offset: 0x0025E4C8
		[NullableContext(1)]
		[Obsolete("已废弃，请使用RequirementFrozenDict()缓存字典，遍历请使用RequirementIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, int> Requirement()
		{
			return this.RequirementIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x060083F9 RID: 33785 RVA: 0x0026031E File Offset: 0x0025E51E
		[NullableContext(1)]
		public readonly IEnumerable<DicIntInt> RequirementIter()
		{
			InfrV2Level.<RequirementIter>d__34 <RequirementIter>d__ = new InfrV2Level.<RequirementIter>d__34(-2);
			<RequirementIter>d__.<>3__<>4__this = this;
			return <RequirementIter>d__;
		}

		// Token: 0x060083FA RID: 33786 RVA: 0x00260334 File Offset: 0x0025E534
		public int? GetRequirement(int key)
		{
			this.EnsureRequirementCacheIfNeeded();
			int value;
			if (!this.RequirementCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x060083FB RID: 33787 RVA: 0x00260368 File Offset: 0x0025E568
		private void EnsureRequirementCacheIfNeeded()
		{
			if (this.RequirementCache != null)
			{
				return;
			}
			this.RequirementCache = this.RequirementIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x060083FC RID: 33788 RVA: 0x002603CE File Offset: 0x0025E5CE
		[NullableContext(2)]
		public FrozenDictionary<int, int> GetRequirementFrozenDict(int key)
		{
			this.EnsureRequirementCacheIfNeeded();
			return this.RequirementCache;
		}

		// Token: 0x04004DEC RID: 19948
		private Table __p;

		// Token: 0x04004DED RID: 19949
		[Nullable(2)]
		private FrozenDictionary<int, int> RequirementCache;
	}
}
