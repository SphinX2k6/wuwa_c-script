using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200113F RID: 4415
	public struct RoleQualityInfo : IFlatbufferObject
	{
		// Token: 0x17003368 RID: 13160
		// (get) Token: 0x0600D01B RID: 53275 RVA: 0x003191FD File Offset: 0x003173FD
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600D01C RID: 53276 RVA: 0x0031920A File Offset: 0x0031740A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600D01D RID: 53277 RVA: 0x00319214 File Offset: 0x00317414
		public static RoleQualityInfo GetRootAsRoleQualityInfo(ByteBuffer _bb)
		{
			return RoleQualityInfo.GetRootAsRoleQualityInfo(_bb, default(RoleQualityInfo));
		}

		// Token: 0x0600D01E RID: 53278 RVA: 0x00319230 File Offset: 0x00317430
		public static RoleQualityInfo GetRootAsRoleQualityInfo(ByteBuffer _bb, RoleQualityInfo obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600D01F RID: 53279 RVA: 0x0031924D File Offset: 0x0031744D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600D020 RID: 53280 RVA: 0x0031925C File Offset: 0x0031745C
		public RoleQualityInfo __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003369 RID: 13161
		// (get) Token: 0x0600D021 RID: 53281 RVA: 0x0031926C File Offset: 0x0031746C
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

		// Token: 0x1700336A RID: 13162
		// (get) Token: 0x0600D022 RID: 53282 RVA: 0x003192A8 File Offset: 0x003174A8
		public string Name
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600D023 RID: 53283 RVA: 0x003192DF File Offset: 0x003174DF
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600D024 RID: 53284 RVA: 0x003192EE File Offset: 0x003174EE
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x1700336B RID: 13163
		// (get) Token: 0x0600D025 RID: 53285 RVA: 0x00319308 File Offset: 0x00317508
		public string Icon
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

		// Token: 0x0600D026 RID: 53286 RVA: 0x0031933F File Offset: 0x0031753F
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600D027 RID: 53287 RVA: 0x0031934E File Offset: 0x0031754E
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x1700336C RID: 13164
		// (get) Token: 0x0600D028 RID: 53288 RVA: 0x00319368 File Offset: 0x00317568
		public string QualityColor
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

		// Token: 0x0600D029 RID: 53289 RVA: 0x003193A0 File Offset: 0x003175A0
		public Span<byte> GetQualityColorBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600D02A RID: 53290 RVA: 0x003193B0 File Offset: 0x003175B0
		public byte[] GetQualityColorArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x1700336D RID: 13165
		// (get) Token: 0x0600D02B RID: 53291 RVA: 0x003193C8 File Offset: 0x003175C8
		public string Image
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

		// Token: 0x0600D02C RID: 53292 RVA: 0x00319400 File Offset: 0x00317600
		public Span<byte> GetImageBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600D02D RID: 53293 RVA: 0x00319410 File Offset: 0x00317610
		public byte[] GetImageArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x1700336E RID: 13166
		// (get) Token: 0x0600D02E RID: 53294 RVA: 0x00319428 File Offset: 0x00317628
		public string GachaQualityImage
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

		// Token: 0x0600D02F RID: 53295 RVA: 0x00319460 File Offset: 0x00317660
		public Span<byte> GetGachaQualityImageBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600D030 RID: 53296 RVA: 0x00319470 File Offset: 0x00317670
		public byte[] GetGachaQualityImageArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x0600D031 RID: 53297 RVA: 0x00319488 File Offset: 0x00317688
		public DicIntInt? SpiloverCompensate(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700336F RID: 13167
		// (get) Token: 0x0600D032 RID: 53298 RVA: 0x003194EC File Offset: 0x003176EC
		public int SpiloverCompensateLength
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

		// Token: 0x0600D033 RID: 53299 RVA: 0x00319518 File Offset: 0x00317718
		[NullableContext(1)]
		public Dictionary<int, int> SpiloverCompensate()
		{
			return this.SpiloverCompensateIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x0600D034 RID: 53300 RVA: 0x0031956E File Offset: 0x0031776E
		[NullableContext(1)]
		public IEnumerable<DicIntInt> SpiloverCompensateIter()
		{
			RoleQualityInfo.<SpiloverCompensateIter>d__34 <SpiloverCompensateIter>d__ = new RoleQualityInfo.<SpiloverCompensateIter>d__34(-2);
			<SpiloverCompensateIter>d__.<>3__<>4__this = this;
			return <SpiloverCompensateIter>d__;
		}

		// Token: 0x0600D035 RID: 53301 RVA: 0x00319584 File Offset: 0x00317784
		public int? GetSpiloverCompensate(int key)
		{
			this.EnsureSpiloverCompensateCacheIfNeeded();
			int value;
			if (!this.SpiloverCompensateCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x0600D036 RID: 53302 RVA: 0x003195B8 File Offset: 0x003177B8
		private void EnsureSpiloverCompensateCacheIfNeeded()
		{
			if (this.SpiloverCompensateCache != null)
			{
				return;
			}
			this.SpiloverCompensateCache = this.SpiloverCompensateIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x0600D037 RID: 53303 RVA: 0x0031961E File Offset: 0x0031781E
		[NullableContext(1)]
		public FrozenDictionary<int, int> GetSpiloverCompensateFrozenDict()
		{
			this.EnsureSpiloverCompensateCacheIfNeeded();
			return this.SpiloverCompensateCache;
		}

		// Token: 0x04005740 RID: 22336
		private Table __p;

		// Token: 0x04005741 RID: 22337
		[Nullable(2)]
		private FrozenDictionary<int, int> SpiloverCompensateCache;
	}
}
