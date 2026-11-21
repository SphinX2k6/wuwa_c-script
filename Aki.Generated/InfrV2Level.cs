using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E4F RID: 3663
	public struct InfrV2Level : IFlatbufferObject
	{
		// Token: 0x17001984 RID: 6532
		// (get) Token: 0x060089FB RID: 35323 RVA: 0x0027E5CE File Offset: 0x0027C7CE
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060089FC RID: 35324 RVA: 0x0027E5DB File Offset: 0x0027C7DB
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060089FD RID: 35325 RVA: 0x0027E5E4 File Offset: 0x0027C7E4
		public static InfrV2Level GetRootAsInfrV2Level(ByteBuffer _bb)
		{
			return InfrV2Level.GetRootAsInfrV2Level(_bb, default(InfrV2Level));
		}

		// Token: 0x060089FE RID: 35326 RVA: 0x0027E600 File Offset: 0x0027C800
		public static InfrV2Level GetRootAsInfrV2Level(ByteBuffer _bb, InfrV2Level obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060089FF RID: 35327 RVA: 0x0027E61D File Offset: 0x0027C81D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06008A00 RID: 35328 RVA: 0x0027E62C File Offset: 0x0027C82C
		public InfrV2Level __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001985 RID: 6533
		// (get) Token: 0x06008A01 RID: 35329 RVA: 0x0027E63C File Offset: 0x0027C83C
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

		// Token: 0x17001986 RID: 6534
		// (get) Token: 0x06008A02 RID: 35330 RVA: 0x0027E678 File Offset: 0x0027C878
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

		// Token: 0x06008A03 RID: 35331 RVA: 0x0027E6B4 File Offset: 0x0027C8B4
		public DicIntInt? Requirement(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17001987 RID: 6535
		// (get) Token: 0x06008A04 RID: 35332 RVA: 0x0027E714 File Offset: 0x0027C914
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

		// Token: 0x17001988 RID: 6536
		// (get) Token: 0x06008A05 RID: 35333 RVA: 0x0027E740 File Offset: 0x0027C940
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

		// Token: 0x06008A06 RID: 35334 RVA: 0x0027E778 File Offset: 0x0027C978
		public Span<byte> GetDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06008A07 RID: 35335 RVA: 0x0027E788 File Offset: 0x0027C988
		public byte[] GetDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17001989 RID: 6537
		// (get) Token: 0x06008A08 RID: 35336 RVA: 0x0027E7A0 File Offset: 0x0027C9A0
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

		// Token: 0x06008A09 RID: 35337 RVA: 0x0027E7D8 File Offset: 0x0027C9D8
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06008A0A RID: 35338 RVA: 0x0027E7E8 File Offset: 0x0027C9E8
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x1700198A RID: 6538
		// (get) Token: 0x06008A0B RID: 35339 RVA: 0x0027E800 File Offset: 0x0027CA00
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

		// Token: 0x06008A0C RID: 35340 RVA: 0x0027E838 File Offset: 0x0027CA38
		public Span<byte> GetInfoPicturePathBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x06008A0D RID: 35341 RVA: 0x0027E848 File Offset: 0x0027CA48
		public byte[] GetInfoPicturePathArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x1700198B RID: 6539
		// (get) Token: 0x06008A0E RID: 35342 RVA: 0x0027E860 File Offset: 0x0027CA60
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

		// Token: 0x06008A0F RID: 35343 RVA: 0x0027E898 File Offset: 0x0027CA98
		public Span<byte> GetBuildSuccessDesBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x06008A10 RID: 35344 RVA: 0x0027E8A8 File Offset: 0x0027CAA8
		public byte[] GetBuildSuccessDesArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x1700198C RID: 6540
		// (get) Token: 0x06008A11 RID: 35345 RVA: 0x0027E8C0 File Offset: 0x0027CAC0
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

		// Token: 0x06008A12 RID: 35346 RVA: 0x0027E900 File Offset: 0x0027CB00
		[NullableContext(1)]
		public Dictionary<int, int> Requirement()
		{
			return this.RequirementIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x06008A13 RID: 35347 RVA: 0x0027E956 File Offset: 0x0027CB56
		[NullableContext(1)]
		public IEnumerable<DicIntInt> RequirementIter()
		{
			InfrV2Level.<RequirementIter>d__34 <RequirementIter>d__ = new InfrV2Level.<RequirementIter>d__34(-2);
			<RequirementIter>d__.<>3__<>4__this = this;
			return <RequirementIter>d__;
		}

		// Token: 0x06008A14 RID: 35348 RVA: 0x0027E96C File Offset: 0x0027CB6C
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

		// Token: 0x06008A15 RID: 35349 RVA: 0x0027E9A0 File Offset: 0x0027CBA0
		private void EnsureRequirementCacheIfNeeded()
		{
			if (this.RequirementCache != null)
			{
				return;
			}
			this.RequirementCache = this.RequirementIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x06008A16 RID: 35350 RVA: 0x0027EA06 File Offset: 0x0027CC06
		[NullableContext(1)]
		public FrozenDictionary<int, int> GetRequirementFrozenDict()
		{
			this.EnsureRequirementCacheIfNeeded();
			return this.RequirementCache;
		}

		// Token: 0x040053D1 RID: 21457
		private Table __p;

		// Token: 0x040053D2 RID: 21458
		[Nullable(2)]
		private FrozenDictionary<int, int> RequirementCache;
	}
}
