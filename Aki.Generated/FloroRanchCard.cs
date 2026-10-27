using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000CA3 RID: 3235
	public struct FloroRanchCard : IFlatbufferObject
	{
		// Token: 0x170012AE RID: 4782
		// (get) Token: 0x0600729F RID: 29343 RVA: 0x00239640 File Offset: 0x00237840
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060072A0 RID: 29344 RVA: 0x0023964D File Offset: 0x0023784D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060072A1 RID: 29345 RVA: 0x00239654 File Offset: 0x00237854
		public static FloroRanchCard GetRootAsFloroRanchCard(ByteBuffer _bb)
		{
			return FloroRanchCard.GetRootAsFloroRanchCard(_bb, default(FloroRanchCard));
		}

		// Token: 0x060072A2 RID: 29346 RVA: 0x00239670 File Offset: 0x00237870
		public static FloroRanchCard GetRootAsFloroRanchCard(ByteBuffer _bb, FloroRanchCard obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060072A3 RID: 29347 RVA: 0x0023968D File Offset: 0x0023788D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060072A4 RID: 29348 RVA: 0x0023969C File Offset: 0x0023789C
		public FloroRanchCard __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170012AF RID: 4783
		// (get) Token: 0x060072A5 RID: 29349 RVA: 0x002396AC File Offset: 0x002378AC
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

		// Token: 0x170012B0 RID: 4784
		// (get) Token: 0x060072A6 RID: 29350 RVA: 0x002396E8 File Offset: 0x002378E8
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

		// Token: 0x060072A7 RID: 29351 RVA: 0x0023971F File Offset: 0x0023791F
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x060072A8 RID: 29352 RVA: 0x0023972E File Offset: 0x0023792E
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x170012B1 RID: 4785
		// (get) Token: 0x060072A9 RID: 29353 RVA: 0x00239748 File Offset: 0x00237948
		public int Race
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

		// Token: 0x170012B2 RID: 4786
		// (get) Token: 0x060072AA RID: 29354 RVA: 0x00239784 File Offset: 0x00237984
		public int RarityId
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

		// Token: 0x170012B3 RID: 4787
		// (get) Token: 0x060072AB RID: 29355 RVA: 0x002397C4 File Offset: 0x002379C4
		public int Salary
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

		// Token: 0x170012B4 RID: 4788
		// (get) Token: 0x060072AC RID: 29356 RVA: 0x00239804 File Offset: 0x00237A04
		public int Price
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

		// Token: 0x170012B5 RID: 4789
		// (get) Token: 0x060072AD RID: 29357 RVA: 0x00239844 File Offset: 0x00237A44
		public int Tag
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170012B6 RID: 4790
		// (get) Token: 0x060072AE RID: 29358 RVA: 0x00239884 File Offset: 0x00237A84
		public bool EnableEvolve
		{
			get
			{
				int num = this.__p.__offset(18);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170012B7 RID: 4791
		// (get) Token: 0x060072AF RID: 29359 RVA: 0x002398C4 File Offset: 0x00237AC4
		public int EvolveExp
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

		// Token: 0x170012B8 RID: 4792
		// (get) Token: 0x060072B0 RID: 29360 RVA: 0x00239904 File Offset: 0x00237B04
		public int MaxEvolveLv
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return 999;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060072B1 RID: 29361 RVA: 0x00239948 File Offset: 0x00237B48
		public int Label(int j)
		{
			int num = this.__p.__offset(24);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170012B9 RID: 4793
		// (get) Token: 0x060072B2 RID: 29362 RVA: 0x00239988 File Offset: 0x00237B88
		public int LabelLength
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x060072B3 RID: 29363 RVA: 0x002399B4 File Offset: 0x00237BB4
		public Span<int> GetLabelBytes()
		{
			return this.__p.__vector_as_span<int>(24, 4);
		}

		// Token: 0x060072B4 RID: 29364 RVA: 0x002399C4 File Offset: 0x00237BC4
		public int[] GetLabelArray()
		{
			return this.__p.__vector_as_array<int>(24) ?? Array.Empty<int>();
		}

		// Token: 0x060072B5 RID: 29365 RVA: 0x002399DC File Offset: 0x00237BDC
		public int BornBuffList(int j)
		{
			int num = this.__p.__offset(26);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170012BA RID: 4794
		// (get) Token: 0x060072B6 RID: 29366 RVA: 0x00239A1C File Offset: 0x00237C1C
		public int BornBuffListLength
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

		// Token: 0x060072B7 RID: 29367 RVA: 0x00239A48 File Offset: 0x00237C48
		public Span<int> GetBornBuffListBytes()
		{
			return this.__p.__vector_as_span<int>(26, 4);
		}

		// Token: 0x060072B8 RID: 29368 RVA: 0x00239A58 File Offset: 0x00237C58
		public int[] GetBornBuffListArray()
		{
			return this.__p.__vector_as_array<int>(26) ?? Array.Empty<int>();
		}

		// Token: 0x170012BB RID: 4795
		// (get) Token: 0x060072B9 RID: 29369 RVA: 0x00239A70 File Offset: 0x00237C70
		public int EvolveItemOffsetY
		{
			get
			{
				int num = this.__p.__offset(28);
				if (num == 0)
				{
					return 200;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170012BC RID: 4796
		// (get) Token: 0x060072BA RID: 29370 RVA: 0x00239AB4 File Offset: 0x00237CB4
		public string Spine
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

		// Token: 0x060072BB RID: 29371 RVA: 0x00239AEC File Offset: 0x00237CEC
		public Span<byte> GetSpineBytes()
		{
			return this.__p.__vector_as_span<byte>(30, 1);
		}

		// Token: 0x060072BC RID: 29372 RVA: 0x00239AFC File Offset: 0x00237CFC
		public byte[] GetSpineArray()
		{
			return this.__p.__vector_as_array<byte>(30) ?? Array.Empty<byte>();
		}

		// Token: 0x170012BD RID: 4797
		// (get) Token: 0x060072BD RID: 29373 RVA: 0x00239B14 File Offset: 0x00237D14
		public string SpineSkeletonData
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

		// Token: 0x060072BE RID: 29374 RVA: 0x00239B4C File Offset: 0x00237D4C
		public Span<byte> GetSpineSkeletonDataBytes()
		{
			return this.__p.__vector_as_span<byte>(32, 1);
		}

		// Token: 0x060072BF RID: 29375 RVA: 0x00239B5C File Offset: 0x00237D5C
		public byte[] GetSpineSkeletonDataArray()
		{
			return this.__p.__vector_as_array<byte>(32) ?? Array.Empty<byte>();
		}

		// Token: 0x170012BE RID: 4798
		// (get) Token: 0x060072C0 RID: 29376 RVA: 0x00239B74 File Offset: 0x00237D74
		public string Icon
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

		// Token: 0x060072C1 RID: 29377 RVA: 0x00239BAC File Offset: 0x00237DAC
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(34, 1);
		}

		// Token: 0x060072C2 RID: 29378 RVA: 0x00239BBC File Offset: 0x00237DBC
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(34) ?? Array.Empty<byte>();
		}

		// Token: 0x170012BF RID: 4799
		// (get) Token: 0x060072C3 RID: 29379 RVA: 0x00239BD4 File Offset: 0x00237DD4
		public int Cost
		{
			get
			{
				int num = this.__p.__offset(36);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170012C0 RID: 4800
		// (get) Token: 0x060072C4 RID: 29380 RVA: 0x00239C14 File Offset: 0x00237E14
		public bool EnableGacha
		{
			get
			{
				int num = this.__p.__offset(38);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170012C1 RID: 4801
		// (get) Token: 0x060072C5 RID: 29381 RVA: 0x00239C54 File Offset: 0x00237E54
		public bool Illustration
		{
			get
			{
				int num = this.__p.__offset(40);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170012C2 RID: 4802
		// (get) Token: 0x060072C6 RID: 29382 RVA: 0x00239C94 File Offset: 0x00237E94
		public string Video
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

		// Token: 0x060072C7 RID: 29383 RVA: 0x00239CCC File Offset: 0x00237ECC
		public Span<byte> GetVideoBytes()
		{
			return this.__p.__vector_as_span<byte>(42, 1);
		}

		// Token: 0x060072C8 RID: 29384 RVA: 0x00239CDC File Offset: 0x00237EDC
		public byte[] GetVideoArray()
		{
			return this.__p.__vector_as_array<byte>(42) ?? Array.Empty<byte>();
		}

		// Token: 0x170012C3 RID: 4803
		// (get) Token: 0x060072C9 RID: 29385 RVA: 0x00239CF4 File Offset: 0x00237EF4
		public int Towards
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

		// Token: 0x170012C4 RID: 4804
		// (get) Token: 0x060072CA RID: 29386 RVA: 0x00239D34 File Offset: 0x00237F34
		public bool IsSpecial
		{
			get
			{
				int num = this.__p.__offset(46);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170012C5 RID: 4805
		// (get) Token: 0x060072CB RID: 29387 RVA: 0x00239D74 File Offset: 0x00237F74
		public int SpeicalEffectshow
		{
			get
			{
				int num = this.__p.__offset(48);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060072CC RID: 29388 RVA: 0x00239DB4 File Offset: 0x00237FB4
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用BornBuffListIter()或GetBornBuffListBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] BornBuffList()
		{
			FloroRanchCard floroRanchCard = this;
			return floroRanchCard.GetBornBuffListArray() ?? Array.Empty<int>();
		}

		// Token: 0x060072CD RID: 29389 RVA: 0x00239DD8 File Offset: 0x00237FD8
		[NullableContext(1)]
		public readonly IEnumerable<int> BornBuffListIter()
		{
			FloroRanchCard.<BornBuffListIter>d__71 <BornBuffListIter>d__ = new FloroRanchCard.<BornBuffListIter>d__71(-2);
			<BornBuffListIter>d__.<>3__<>4__this = this;
			return <BornBuffListIter>d__;
		}

		// Token: 0x060072CE RID: 29390 RVA: 0x00239DF0 File Offset: 0x00237FF0
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用LabelIter()或GetLabelBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] Label()
		{
			FloroRanchCard floroRanchCard = this;
			return floroRanchCard.GetLabelArray() ?? Array.Empty<int>();
		}

		// Token: 0x060072CF RID: 29391 RVA: 0x00239E14 File Offset: 0x00238014
		[NullableContext(1)]
		public readonly IEnumerable<int> LabelIter()
		{
			FloroRanchCard.<LabelIter>d__73 <LabelIter>d__ = new FloroRanchCard.<LabelIter>d__73(-2);
			<LabelIter>d__.<>3__<>4__this = this;
			return <LabelIter>d__;
		}

		// Token: 0x04004D04 RID: 19716
		private Table __p;
	}
}
