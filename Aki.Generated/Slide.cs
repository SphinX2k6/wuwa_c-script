using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020010D3 RID: 4307
	public struct Slide : IFlatbufferObject
	{
		// Token: 0x1700376D RID: 14189
		// (get) Token: 0x0600D6EE RID: 55022 RVA: 0x0031BCA4 File Offset: 0x00319EA4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600D6EF RID: 55023 RVA: 0x0031BCB1 File Offset: 0x00319EB1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600D6F0 RID: 55024 RVA: 0x0031BCB8 File Offset: 0x00319EB8
		public static Slide GetRootAsSlide(ByteBuffer _bb)
		{
			return Slide.GetRootAsSlide(_bb, default(Slide));
		}

		// Token: 0x0600D6F1 RID: 55025 RVA: 0x0031BCD4 File Offset: 0x00319ED4
		public static Slide GetRootAsSlide(ByteBuffer _bb, Slide obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600D6F2 RID: 55026 RVA: 0x0031BCF1 File Offset: 0x00319EF1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600D6F3 RID: 55027 RVA: 0x0031BD00 File Offset: 0x00319F00
		public Slide __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700376E RID: 14190
		// (get) Token: 0x0600D6F4 RID: 55028 RVA: 0x0031BD10 File Offset: 0x00319F10
		public string Id
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600D6F5 RID: 55029 RVA: 0x0031BD47 File Offset: 0x00319F47
		public Span<byte> GetIdBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0600D6F6 RID: 55030 RVA: 0x0031BD56 File Offset: 0x00319F56
		public byte[] GetIdArray()
		{
			return this.__p.__vector_as_array<byte>(4) ?? Array.Empty<byte>();
		}

		// Token: 0x0600D6F7 RID: 55031 RVA: 0x0031BD70 File Offset: 0x00319F70
		public DicIntFloat? FallingLateralFrictions(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new DicIntFloat?(default(DicIntFloat).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700376F RID: 14191
		// (get) Token: 0x0600D6F8 RID: 55032 RVA: 0x0031BDD0 File Offset: 0x00319FD0
		public int FallingLateralFrictionsLength
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

		// Token: 0x17003770 RID: 14192
		// (get) Token: 0x0600D6F9 RID: 55033 RVA: 0x0031BDFC File Offset: 0x00319FFC
		public float SlideFriction
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 2f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17003771 RID: 14193
		// (get) Token: 0x0600D6FA RID: 55034 RVA: 0x0031BE3C File Offset: 0x0031A03C
		public float SlideAccel
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 1f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17003772 RID: 14194
		// (get) Token: 0x0600D6FB RID: 55035 RVA: 0x0031BE80 File Offset: 0x0031A080
		public float SlideAccelUp
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 1f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17003773 RID: 14195
		// (get) Token: 0x0600D6FC RID: 55036 RVA: 0x0031BEC4 File Offset: 0x0031A0C4
		public float SlideAccelDown
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 1f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17003774 RID: 14196
		// (get) Token: 0x0600D6FD RID: 55037 RVA: 0x0031BF08 File Offset: 0x0031A108
		public float MaxSlideHorizontalSeed
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 500f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17003775 RID: 14197
		// (get) Token: 0x0600D6FE RID: 55038 RVA: 0x0031BF4C File Offset: 0x0031A14C
		public FloatRange? SlideModeSwitchRange
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return null;
				}
				return new FloatRange?(default(FloatRange).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17003776 RID: 14198
		// (get) Token: 0x0600D6FF RID: 55039 RVA: 0x0031BFAC File Offset: 0x0031A1AC
		public bool Ski
		{
			get
			{
				int num = this.__p.__offset(20);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17003777 RID: 14199
		// (get) Token: 0x0600D700 RID: 55040 RVA: 0x0031BFEC File Offset: 0x0031A1EC
		public float SkiMaxSpHor
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return 2000f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17003778 RID: 14200
		// (get) Token: 0x0600D701 RID: 55041 RVA: 0x0031C030 File Offset: 0x0031A230
		public float SkiMaxSpVer
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return 2000f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17003779 RID: 14201
		// (get) Token: 0x0600D702 RID: 55042 RVA: 0x0031C074 File Offset: 0x0031A274
		public float JumpRate
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return 1f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700377A RID: 14202
		// (get) Token: 0x0600D703 RID: 55043 RVA: 0x0031C0B8 File Offset: 0x0031A2B8
		public float TurnSpeed
		{
			get
			{
				int num = this.__p.__offset(28);
				if (num == 0)
				{
					return 720f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700377B RID: 14203
		// (get) Token: 0x0600D704 RID: 55044 RVA: 0x0031C0FC File Offset: 0x0031A2FC
		public FloatRange? SkiHorizontalInputSpeedThreshold
		{
			get
			{
				int num = this.__p.__offset(30);
				if (num == 0)
				{
					return null;
				}
				return new FloatRange?(default(FloatRange).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700377C RID: 14204
		// (get) Token: 0x0600D705 RID: 55045 RVA: 0x0031C15C File Offset: 0x0031A35C
		public string SpeedReduceCurve
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

		// Token: 0x0600D706 RID: 55046 RVA: 0x0031C194 File Offset: 0x0031A394
		public Span<byte> GetSpeedReduceCurveBytes()
		{
			return this.__p.__vector_as_span<byte>(32, 1);
		}

		// Token: 0x0600D707 RID: 55047 RVA: 0x0031C1A4 File Offset: 0x0031A3A4
		public byte[] GetSpeedReduceCurveArray()
		{
			return this.__p.__vector_as_array<byte>(32) ?? Array.Empty<byte>();
		}

		// Token: 0x0600D708 RID: 55048 RVA: 0x0031C1BC File Offset: 0x0031A3BC
		[NullableContext(1)]
		[Obsolete("已废弃，请使用FallingLateralFrictionsFrozenDict()缓存字典，遍历请使用FallingLateralFrictionsIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, float> FallingLateralFrictions()
		{
			return this.FallingLateralFrictionsIter().ToDictionary((DicIntFloat element) => element.Key, (DicIntFloat element) => element.Value);
		}

		// Token: 0x0600D709 RID: 55049 RVA: 0x0031C212 File Offset: 0x0031A412
		[NullableContext(1)]
		public readonly IEnumerable<DicIntFloat> FallingLateralFrictionsIter()
		{
			Slide.<FallingLateralFrictionsIter>d__44 <FallingLateralFrictionsIter>d__ = new Slide.<FallingLateralFrictionsIter>d__44(-2);
			<FallingLateralFrictionsIter>d__.<>3__<>4__this = this;
			return <FallingLateralFrictionsIter>d__;
		}

		// Token: 0x0600D70A RID: 55050 RVA: 0x0031C228 File Offset: 0x0031A428
		public float? GetFallingLateralFrictions(int key)
		{
			this.EnsureFallingLateralFrictionsCacheIfNeeded();
			float value;
			if (!this.FallingLateralFrictionsCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new float?(value);
		}

		// Token: 0x0600D70B RID: 55051 RVA: 0x0031C25C File Offset: 0x0031A45C
		private void EnsureFallingLateralFrictionsCacheIfNeeded()
		{
			if (this.FallingLateralFrictionsCache != null)
			{
				return;
			}
			this.FallingLateralFrictionsCache = this.FallingLateralFrictionsIter().ToFrozenDictionary((DicIntFloat kvp) => kvp.Key, (DicIntFloat kvp) => kvp.Value, null);
		}

		// Token: 0x0600D70C RID: 55052 RVA: 0x0031C2C2 File Offset: 0x0031A4C2
		[NullableContext(2)]
		public FrozenDictionary<int, float> GetFallingLateralFrictionsFrozenDict(int key)
		{
			this.EnsureFallingLateralFrictionsCacheIfNeeded();
			return this.FallingLateralFrictionsCache;
		}

		// Token: 0x04005205 RID: 20997
		private Table __p;

		// Token: 0x04005206 RID: 20998
		[Nullable(2)]
		private FrozenDictionary<int, float> FallingLateralFrictionsCache;
	}
}
