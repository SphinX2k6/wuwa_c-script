using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020011CE RID: 4558
	public struct Slide : IFlatbufferObject
	{
		// Token: 0x1700387E RID: 14462
		// (get) Token: 0x0600DECB RID: 57035 RVA: 0x0033ABC0 File Offset: 0x00338DC0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600DECC RID: 57036 RVA: 0x0033ABCD File Offset: 0x00338DCD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600DECD RID: 57037 RVA: 0x0033ABD4 File Offset: 0x00338DD4
		public static Slide GetRootAsSlide(ByteBuffer _bb)
		{
			return Slide.GetRootAsSlide(_bb, default(Slide));
		}

		// Token: 0x0600DECE RID: 57038 RVA: 0x0033ABF0 File Offset: 0x00338DF0
		public static Slide GetRootAsSlide(ByteBuffer _bb, Slide obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600DECF RID: 57039 RVA: 0x0033AC0D File Offset: 0x00338E0D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600DED0 RID: 57040 RVA: 0x0033AC1C File Offset: 0x00338E1C
		public Slide __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700387F RID: 14463
		// (get) Token: 0x0600DED1 RID: 57041 RVA: 0x0033AC2C File Offset: 0x00338E2C
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

		// Token: 0x0600DED2 RID: 57042 RVA: 0x0033AC63 File Offset: 0x00338E63
		public Span<byte> GetIdBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0600DED3 RID: 57043 RVA: 0x0033AC72 File Offset: 0x00338E72
		public byte[] GetIdArray()
		{
			return this.__p.__vector_as_array<byte>(4) ?? Array.Empty<byte>();
		}

		// Token: 0x0600DED4 RID: 57044 RVA: 0x0033AC8C File Offset: 0x00338E8C
		public DicIntFloat? FallingLateralFrictions(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new DicIntFloat?(default(DicIntFloat).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17003880 RID: 14464
		// (get) Token: 0x0600DED5 RID: 57045 RVA: 0x0033ACEC File Offset: 0x00338EEC
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

		// Token: 0x17003881 RID: 14465
		// (get) Token: 0x0600DED6 RID: 57046 RVA: 0x0033AD18 File Offset: 0x00338F18
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

		// Token: 0x17003882 RID: 14466
		// (get) Token: 0x0600DED7 RID: 57047 RVA: 0x0033AD58 File Offset: 0x00338F58
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

		// Token: 0x17003883 RID: 14467
		// (get) Token: 0x0600DED8 RID: 57048 RVA: 0x0033AD9C File Offset: 0x00338F9C
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

		// Token: 0x17003884 RID: 14468
		// (get) Token: 0x0600DED9 RID: 57049 RVA: 0x0033ADE0 File Offset: 0x00338FE0
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

		// Token: 0x17003885 RID: 14469
		// (get) Token: 0x0600DEDA RID: 57050 RVA: 0x0033AE24 File Offset: 0x00339024
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

		// Token: 0x17003886 RID: 14470
		// (get) Token: 0x0600DEDB RID: 57051 RVA: 0x0033AE68 File Offset: 0x00339068
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

		// Token: 0x17003887 RID: 14471
		// (get) Token: 0x0600DEDC RID: 57052 RVA: 0x0033AEC8 File Offset: 0x003390C8
		public bool Ski
		{
			get
			{
				int num = this.__p.__offset(20);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17003888 RID: 14472
		// (get) Token: 0x0600DEDD RID: 57053 RVA: 0x0033AF08 File Offset: 0x00339108
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

		// Token: 0x17003889 RID: 14473
		// (get) Token: 0x0600DEDE RID: 57054 RVA: 0x0033AF4C File Offset: 0x0033914C
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

		// Token: 0x1700388A RID: 14474
		// (get) Token: 0x0600DEDF RID: 57055 RVA: 0x0033AF90 File Offset: 0x00339190
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

		// Token: 0x1700388B RID: 14475
		// (get) Token: 0x0600DEE0 RID: 57056 RVA: 0x0033AFD4 File Offset: 0x003391D4
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

		// Token: 0x1700388C RID: 14476
		// (get) Token: 0x0600DEE1 RID: 57057 RVA: 0x0033B018 File Offset: 0x00339218
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

		// Token: 0x1700388D RID: 14477
		// (get) Token: 0x0600DEE2 RID: 57058 RVA: 0x0033B078 File Offset: 0x00339278
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

		// Token: 0x0600DEE3 RID: 57059 RVA: 0x0033B0B0 File Offset: 0x003392B0
		public Span<byte> GetSpeedReduceCurveBytes()
		{
			return this.__p.__vector_as_span<byte>(32, 1);
		}

		// Token: 0x0600DEE4 RID: 57060 RVA: 0x0033B0C0 File Offset: 0x003392C0
		public byte[] GetSpeedReduceCurveArray()
		{
			return this.__p.__vector_as_array<byte>(32) ?? Array.Empty<byte>();
		}

		// Token: 0x0600DEE5 RID: 57061 RVA: 0x0033B0D8 File Offset: 0x003392D8
		[NullableContext(1)]
		public Dictionary<int, float> FallingLateralFrictions()
		{
			return this.FallingLateralFrictionsIter().ToDictionary((DicIntFloat element) => element.Key, (DicIntFloat element) => element.Value);
		}

		// Token: 0x0600DEE6 RID: 57062 RVA: 0x0033B12E File Offset: 0x0033932E
		[NullableContext(1)]
		public IEnumerable<DicIntFloat> FallingLateralFrictionsIter()
		{
			Slide.<FallingLateralFrictionsIter>d__44 <FallingLateralFrictionsIter>d__ = new Slide.<FallingLateralFrictionsIter>d__44(-2);
			<FallingLateralFrictionsIter>d__.<>3__<>4__this = this;
			return <FallingLateralFrictionsIter>d__;
		}

		// Token: 0x0600DEE7 RID: 57063 RVA: 0x0033B144 File Offset: 0x00339344
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

		// Token: 0x0600DEE8 RID: 57064 RVA: 0x0033B178 File Offset: 0x00339378
		private void EnsureFallingLateralFrictionsCacheIfNeeded()
		{
			if (this.FallingLateralFrictionsCache != null)
			{
				return;
			}
			this.FallingLateralFrictionsCache = this.FallingLateralFrictionsIter().ToFrozenDictionary((DicIntFloat kvp) => kvp.Key, (DicIntFloat kvp) => kvp.Value, null);
		}

		// Token: 0x0600DEE9 RID: 57065 RVA: 0x0033B1DE File Offset: 0x003393DE
		[NullableContext(1)]
		public FrozenDictionary<int, float> GetFallingLateralFrictionsFrozenDict()
		{
			this.EnsureFallingLateralFrictionsCacheIfNeeded();
			return this.FallingLateralFrictionsCache;
		}

		// Token: 0x04005804 RID: 22532
		private Table __p;

		// Token: 0x04005805 RID: 22533
		[Nullable(2)]
		private FrozenDictionary<int, float> FallingLateralFrictionsCache;
	}
}
