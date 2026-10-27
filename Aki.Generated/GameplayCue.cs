using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000CEA RID: 3306
	public struct GameplayCue : IFlatbufferObject
	{
		// Token: 0x170014FC RID: 5372
		// (get) Token: 0x06007900 RID: 30976 RVA: 0x00247C38 File Offset: 0x00245E38
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06007901 RID: 30977 RVA: 0x00247C45 File Offset: 0x00245E45
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06007902 RID: 30978 RVA: 0x00247C4C File Offset: 0x00245E4C
		public static GameplayCue GetRootAsGameplayCue(ByteBuffer _bb)
		{
			return GameplayCue.GetRootAsGameplayCue(_bb, default(GameplayCue));
		}

		// Token: 0x06007903 RID: 30979 RVA: 0x00247C68 File Offset: 0x00245E68
		public static GameplayCue GetRootAsGameplayCue(ByteBuffer _bb, GameplayCue obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06007904 RID: 30980 RVA: 0x00247C85 File Offset: 0x00245E85
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06007905 RID: 30981 RVA: 0x00247C94 File Offset: 0x00245E94
		public GameplayCue __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170014FD RID: 5373
		// (get) Token: 0x06007906 RID: 30982 RVA: 0x00247CA4 File Offset: 0x00245EA4
		public long Id
		{
			get
			{
				int num = this.__p.__offset(4);
				return (long)((num != 0) ? this.__p.bb.GetDouble(num + this.__p.bb_pos) : 0.0);
			}
		}

		// Token: 0x170014FE RID: 5374
		// (get) Token: 0x06007907 RID: 30983 RVA: 0x00247CEC File Offset: 0x00245EEC
		public string Path
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

		// Token: 0x06007908 RID: 30984 RVA: 0x00247D23 File Offset: 0x00245F23
		public Span<byte> GetPathBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06007909 RID: 30985 RVA: 0x00247D32 File Offset: 0x00245F32
		public byte[] GetPathArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x170014FF RID: 5375
		// (get) Token: 0x0600790A RID: 30986 RVA: 0x00247D4C File Offset: 0x00245F4C
		public int CueType
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001500 RID: 5376
		// (get) Token: 0x0600790B RID: 30987 RVA: 0x00247D88 File Offset: 0x00245F88
		public int Comp
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

		// Token: 0x17001501 RID: 5377
		// (get) Token: 0x0600790C RID: 30988 RVA: 0x00247DC8 File Offset: 0x00245FC8
		public string CompName
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

		// Token: 0x0600790D RID: 30989 RVA: 0x00247E00 File Offset: 0x00246000
		public Span<byte> GetCompNameBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600790E RID: 30990 RVA: 0x00247E10 File Offset: 0x00246010
		public byte[] GetCompNameArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17001502 RID: 5378
		// (get) Token: 0x0600790F RID: 30991 RVA: 0x00247E28 File Offset: 0x00246028
		public string Socket
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

		// Token: 0x06007910 RID: 30992 RVA: 0x00247E60 File Offset: 0x00246060
		public Span<byte> GetSocketBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x06007911 RID: 30993 RVA: 0x00247E70 File Offset: 0x00246070
		public byte[] GetSocketArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17001503 RID: 5379
		// (get) Token: 0x06007912 RID: 30994 RVA: 0x00247E88 File Offset: 0x00246088
		public Vector? Location
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return null;
				}
				return new Vector?(default(Vector).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17001504 RID: 5380
		// (get) Token: 0x06007913 RID: 30995 RVA: 0x00247EE8 File Offset: 0x002460E8
		public Vector? Rotation
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return null;
				}
				return new Vector?(default(Vector).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17001505 RID: 5381
		// (get) Token: 0x06007914 RID: 30996 RVA: 0x00247F48 File Offset: 0x00246148
		public Vector? Scale
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return null;
				}
				return new Vector?(default(Vector).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17001506 RID: 5382
		// (get) Token: 0x06007915 RID: 30997 RVA: 0x00247FA8 File Offset: 0x002461A8
		public int LocRule
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

		// Token: 0x17001507 RID: 5383
		// (get) Token: 0x06007916 RID: 30998 RVA: 0x00247FE8 File Offset: 0x002461E8
		public int RotaRule
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001508 RID: 5384
		// (get) Token: 0x06007917 RID: 30999 RVA: 0x00248028 File Offset: 0x00246228
		public int SclRule
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001509 RID: 5385
		// (get) Token: 0x06007918 RID: 31000 RVA: 0x00248068 File Offset: 0x00246268
		public int EndRule
		{
			get
			{
				int num = this.__p.__offset(28);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700150A RID: 5386
		// (get) Token: 0x06007919 RID: 31001 RVA: 0x002480A8 File Offset: 0x002462A8
		public int Magni
		{
			get
			{
				int num = this.__p.__offset(30);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700150B RID: 5387
		// (get) Token: 0x0600791A RID: 31002 RVA: 0x002480E8 File Offset: 0x002462E8
		public int AttrId
		{
			get
			{
				int num = this.__p.__offset(32);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700150C RID: 5388
		// (get) Token: 0x0600791B RID: 31003 RVA: 0x00248128 File Offset: 0x00246328
		public string Tag
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

		// Token: 0x0600791C RID: 31004 RVA: 0x00248160 File Offset: 0x00246360
		public Span<byte> GetTagBytes()
		{
			return this.__p.__vector_as_span<byte>(34, 1);
		}

		// Token: 0x0600791D RID: 31005 RVA: 0x00248170 File Offset: 0x00246370
		public byte[] GetTagArray()
		{
			return this.__p.__vector_as_array<byte>(34) ?? Array.Empty<byte>();
		}

		// Token: 0x1700150D RID: 5389
		// (get) Token: 0x0600791E RID: 31006 RVA: 0x00248188 File Offset: 0x00246388
		public int Max
		{
			get
			{
				int num = this.__p.__offset(36);
				if (num == 0)
				{
					return 10000;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700150E RID: 5390
		// (get) Token: 0x0600791F RID: 31007 RVA: 0x002481CC File Offset: 0x002463CC
		public int Min
		{
			get
			{
				int num = this.__p.__offset(38);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700150F RID: 5391
		// (get) Token: 0x06007920 RID: 31008 RVA: 0x0024820C File Offset: 0x0024640C
		public bool BListenAttr
		{
			get
			{
				int num = this.__p.__offset(40);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17001510 RID: 5392
		// (get) Token: 0x06007921 RID: 31009 RVA: 0x0024824C File Offset: 0x0024644C
		public bool BSoftFollow
		{
			get
			{
				int num = this.__p.__offset(42);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17001511 RID: 5393
		// (get) Token: 0x06007922 RID: 31010 RVA: 0x0024828C File Offset: 0x0024648C
		public bool BLockRevolution
		{
			get
			{
				int num = this.__p.__offset(44);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17001512 RID: 5394
		// (get) Token: 0x06007923 RID: 31011 RVA: 0x002482CC File Offset: 0x002464CC
		public Vector? LockRotation
		{
			get
			{
				int num = this.__p.__offset(46);
				if (num == 0)
				{
					return null;
				}
				return new Vector?(default(Vector).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17001513 RID: 5395
		// (get) Token: 0x06007924 RID: 31012 RVA: 0x0024832C File Offset: 0x0024652C
		public bool LockCamera
		{
			get
			{
				int num = this.__p.__offset(48);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17001514 RID: 5396
		// (get) Token: 0x06007925 RID: 31013 RVA: 0x0024836C File Offset: 0x0024656C
		public int InterpSpeed
		{
			get
			{
				int num = this.__p.__offset(50);
				if (num == 0)
				{
					return 5;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001515 RID: 5397
		// (get) Token: 0x06007926 RID: 31014 RVA: 0x002483AC File Offset: 0x002465AC
		public int FarthestDistance
		{
			get
			{
				int num = this.__p.__offset(52);
				if (num == 0)
				{
					return 100;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001516 RID: 5398
		// (get) Token: 0x06007927 RID: 31015 RVA: 0x002483EC File Offset: 0x002465EC
		public Vector? FaultTolerance
		{
			get
			{
				int num = this.__p.__offset(54);
				if (num == 0)
				{
					return null;
				}
				return new Vector?(default(Vector).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x06007928 RID: 31016 RVA: 0x0024844C File Offset: 0x0024664C
		public float TargetScaleUp(int j)
		{
			int num = this.__p.__offset(56);
			if (num == 0)
			{
				return 0f;
			}
			return this.__p.bb.GetFloat(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001517 RID: 5399
		// (get) Token: 0x06007929 RID: 31017 RVA: 0x00248490 File Offset: 0x00246690
		public int TargetScaleUpLength
		{
			get
			{
				int num = this.__p.__offset(56);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600792A RID: 31018 RVA: 0x002484BC File Offset: 0x002466BC
		public Span<float> GetTargetScaleUpBytes()
		{
			return this.__p.__vector_as_span<float>(56, 4);
		}

		// Token: 0x0600792B RID: 31019 RVA: 0x002484CC File Offset: 0x002466CC
		public float[] GetTargetScaleUpArray()
		{
			return this.__p.__vector_as_array<float>(56) ?? Array.Empty<float>();
		}

		// Token: 0x0600792C RID: 31020 RVA: 0x002484E4 File Offset: 0x002466E4
		public string Resources(int j)
		{
			int num = this.__p.__offset(58);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001518 RID: 5400
		// (get) Token: 0x0600792D RID: 31021 RVA: 0x00248520 File Offset: 0x00246720
		public int ResourcesLength
		{
			get
			{
				int num = this.__p.__offset(58);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600792E RID: 31022 RVA: 0x0024854C File Offset: 0x0024674C
		public string Parameters(int j)
		{
			int num = this.__p.__offset(60);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001519 RID: 5401
		// (get) Token: 0x0600792F RID: 31023 RVA: 0x00248588 File Offset: 0x00246788
		public int ParametersLength
		{
			get
			{
				int num = this.__p.__offset(60);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x1700151A RID: 5402
		// (get) Token: 0x06007930 RID: 31024 RVA: 0x002485B4 File Offset: 0x002467B4
		public int Group
		{
			get
			{
				int num = this.__p.__offset(62);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700151B RID: 5403
		// (get) Token: 0x06007931 RID: 31025 RVA: 0x002485F4 File Offset: 0x002467F4
		public int Priority
		{
			get
			{
				int num = this.__p.__offset(64);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700151C RID: 5404
		// (get) Token: 0x06007932 RID: 31026 RVA: 0x00248634 File Offset: 0x00246834
		public int HideRule
		{
			get
			{
				int num = this.__p.__offset(66);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06007933 RID: 31027 RVA: 0x00248671 File Offset: 0x00246871
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用ParametersIter()或GetParametersBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] Parameters()
		{
			return this.ParametersIter().ToArray<string>();
		}

		// Token: 0x06007934 RID: 31028 RVA: 0x0024867E File Offset: 0x0024687E
		[NullableContext(1)]
		public readonly IEnumerable<string> ParametersIter()
		{
			GameplayCue.<ParametersIter>d__86 <ParametersIter>d__ = new GameplayCue.<ParametersIter>d__86(-2);
			<ParametersIter>d__.<>3__<>4__this = this;
			return <ParametersIter>d__;
		}

		// Token: 0x06007935 RID: 31029 RVA: 0x00248693 File Offset: 0x00246893
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用ResourcesIter()或GetResourcesBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] Resources()
		{
			return this.ResourcesIter().ToArray<string>();
		}

		// Token: 0x06007936 RID: 31030 RVA: 0x002486A0 File Offset: 0x002468A0
		[NullableContext(1)]
		public readonly IEnumerable<string> ResourcesIter()
		{
			GameplayCue.<ResourcesIter>d__88 <ResourcesIter>d__ = new GameplayCue.<ResourcesIter>d__88(-2);
			<ResourcesIter>d__.<>3__<>4__this = this;
			return <ResourcesIter>d__;
		}

		// Token: 0x06007937 RID: 31031 RVA: 0x002486B8 File Offset: 0x002468B8
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用TargetScaleUpIter()或GetTargetScaleUpBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly float[] TargetScaleUp()
		{
			GameplayCue gameplayCue = this;
			return gameplayCue.GetTargetScaleUpArray() ?? Array.Empty<float>();
		}

		// Token: 0x06007938 RID: 31032 RVA: 0x002486DC File Offset: 0x002468DC
		[NullableContext(1)]
		public readonly IEnumerable<float> TargetScaleUpIter()
		{
			GameplayCue.<TargetScaleUpIter>d__90 <TargetScaleUpIter>d__ = new GameplayCue.<TargetScaleUpIter>d__90(-2);
			<TargetScaleUpIter>d__.<>3__<>4__this = this;
			return <TargetScaleUpIter>d__;
		}

		// Token: 0x04004D5B RID: 19803
		private Table __p;
	}
}
