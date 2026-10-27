using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000CCE RID: 3278
	public struct FormationProperty : IFlatbufferObject
	{
		// Token: 0x17001416 RID: 5142
		// (get) Token: 0x060076A3 RID: 30371 RVA: 0x002429E9 File Offset: 0x00240BE9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060076A4 RID: 30372 RVA: 0x002429F6 File Offset: 0x00240BF6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060076A5 RID: 30373 RVA: 0x00242A00 File Offset: 0x00240C00
		public static FormationProperty GetRootAsFormationProperty(ByteBuffer _bb)
		{
			return FormationProperty.GetRootAsFormationProperty(_bb, default(FormationProperty));
		}

		// Token: 0x060076A6 RID: 30374 RVA: 0x00242A1C File Offset: 0x00240C1C
		public static FormationProperty GetRootAsFormationProperty(ByteBuffer _bb, FormationProperty obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060076A7 RID: 30375 RVA: 0x00242A39 File Offset: 0x00240C39
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060076A8 RID: 30376 RVA: 0x00242A48 File Offset: 0x00240C48
		public FormationProperty __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001417 RID: 5143
		// (get) Token: 0x060076A9 RID: 30377 RVA: 0x00242A58 File Offset: 0x00240C58
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

		// Token: 0x17001418 RID: 5144
		// (get) Token: 0x060076AA RID: 30378 RVA: 0x00242A94 File Offset: 0x00240C94
		public int InitValue
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

		// Token: 0x17001419 RID: 5145
		// (get) Token: 0x060076AB RID: 30379 RVA: 0x00242AD0 File Offset: 0x00240CD0
		public int InitRecoveryRate
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return -500;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700141A RID: 5146
		// (get) Token: 0x060076AC RID: 30380 RVA: 0x00242B10 File Offset: 0x00240D10
		public int InitMax
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 10000;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060076AD RID: 30381 RVA: 0x00242B54 File Offset: 0x00240D54
		public string MarkTag(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700141B RID: 5147
		// (get) Token: 0x060076AE RID: 30382 RVA: 0x00242B90 File Offset: 0x00240D90
		public int MarkTagLength
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x060076AF RID: 30383 RVA: 0x00242BBC File Offset: 0x00240DBC
		public string ResistTag(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700141C RID: 5148
		// (get) Token: 0x060076B0 RID: 30384 RVA: 0x00242BF8 File Offset: 0x00240DF8
		public int ResistTagLength
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

		// Token: 0x1700141D RID: 5149
		// (get) Token: 0x060076B1 RID: 30385 RVA: 0x00242C24 File Offset: 0x00240E24
		public FloatRange? TriggerRange1
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return null;
				}
				return new FloatRange?(default(FloatRange).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700141E RID: 5150
		// (get) Token: 0x060076B2 RID: 30386 RVA: 0x00242C84 File Offset: 0x00240E84
		public int TriggerType1
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

		// Token: 0x1700141F RID: 5151
		// (get) Token: 0x060076B3 RID: 30387 RVA: 0x00242CC4 File Offset: 0x00240EC4
		public int TriggerEffect1
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

		// Token: 0x060076B4 RID: 30388 RVA: 0x00242D04 File Offset: 0x00240F04
		public long TriggerEffectParams1(int j)
		{
			int num = this.__p.__offset(22);
			return (long)((num != 0) ? this.__p.bb.GetDouble(this.__p.__vector(num) + j * 8) : 0.0);
		}

		// Token: 0x17001420 RID: 5152
		// (get) Token: 0x060076B5 RID: 30389 RVA: 0x00242D50 File Offset: 0x00240F50
		public int TriggerEffectParams1Length
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x060076B6 RID: 30390 RVA: 0x00242D7C File Offset: 0x00240F7C
		public Span<long> GetTriggerEffectParams1Bytes()
		{
			return MemoryMarshal.Cast<double, long>(this.__p.__vector_as_span<double>(22, 8));
		}

		// Token: 0x060076B7 RID: 30391 RVA: 0x00242D91 File Offset: 0x00240F91
		public long[] GetTriggerEffectParams1Array()
		{
			return Array.ConvertAll<double, long>(this.__p.__vector_as_array<double>(22) ?? Array.Empty<double>(), (double x) => (long)x);
		}

		// Token: 0x17001421 RID: 5153
		// (get) Token: 0x060076B8 RID: 30392 RVA: 0x00242DD0 File Offset: 0x00240FD0
		public FloatRange? TriggerRange2
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return null;
				}
				return new FloatRange?(default(FloatRange).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17001422 RID: 5154
		// (get) Token: 0x060076B9 RID: 30393 RVA: 0x00242E30 File Offset: 0x00241030
		public int TriggerType2
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

		// Token: 0x17001423 RID: 5155
		// (get) Token: 0x060076BA RID: 30394 RVA: 0x00242E70 File Offset: 0x00241070
		public int TriggerEffect2
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

		// Token: 0x060076BB RID: 30395 RVA: 0x00242EB0 File Offset: 0x002410B0
		public long TriggerEffectParams2(int j)
		{
			int num = this.__p.__offset(30);
			return (long)((num != 0) ? this.__p.bb.GetDouble(this.__p.__vector(num) + j * 8) : 0.0);
		}

		// Token: 0x17001424 RID: 5156
		// (get) Token: 0x060076BC RID: 30396 RVA: 0x00242EFC File Offset: 0x002410FC
		public int TriggerEffectParams2Length
		{
			get
			{
				int num = this.__p.__offset(30);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x060076BD RID: 30397 RVA: 0x00242F28 File Offset: 0x00241128
		public Span<long> GetTriggerEffectParams2Bytes()
		{
			return MemoryMarshal.Cast<double, long>(this.__p.__vector_as_span<double>(30, 8));
		}

		// Token: 0x060076BE RID: 30398 RVA: 0x00242F3D File Offset: 0x0024113D
		public long[] GetTriggerEffectParams2Array()
		{
			return Array.ConvertAll<double, long>(this.__p.__vector_as_array<double>(30) ?? Array.Empty<double>(), (double x) => (long)x);
		}

		// Token: 0x17001425 RID: 5157
		// (get) Token: 0x060076BF RID: 30399 RVA: 0x00242F7C File Offset: 0x0024117C
		public FloatRange? TriggerRange3
		{
			get
			{
				int num = this.__p.__offset(32);
				if (num == 0)
				{
					return null;
				}
				return new FloatRange?(default(FloatRange).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17001426 RID: 5158
		// (get) Token: 0x060076C0 RID: 30400 RVA: 0x00242FDC File Offset: 0x002411DC
		public int TriggerType3
		{
			get
			{
				int num = this.__p.__offset(34);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001427 RID: 5159
		// (get) Token: 0x060076C1 RID: 30401 RVA: 0x0024301C File Offset: 0x0024121C
		public int TriggerEffect3
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

		// Token: 0x060076C2 RID: 30402 RVA: 0x0024305C File Offset: 0x0024125C
		public long TriggerEffectParams3(int j)
		{
			int num = this.__p.__offset(38);
			return (long)((num != 0) ? this.__p.bb.GetDouble(this.__p.__vector(num) + j * 8) : 0.0);
		}

		// Token: 0x17001428 RID: 5160
		// (get) Token: 0x060076C3 RID: 30403 RVA: 0x002430A8 File Offset: 0x002412A8
		public int TriggerEffectParams3Length
		{
			get
			{
				int num = this.__p.__offset(38);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x060076C4 RID: 30404 RVA: 0x002430D4 File Offset: 0x002412D4
		public Span<long> GetTriggerEffectParams3Bytes()
		{
			return MemoryMarshal.Cast<double, long>(this.__p.__vector_as_span<double>(38, 8));
		}

		// Token: 0x060076C5 RID: 30405 RVA: 0x002430E9 File Offset: 0x002412E9
		public long[] GetTriggerEffectParams3Array()
		{
			return Array.ConvertAll<double, long>(this.__p.__vector_as_array<double>(38) ?? Array.Empty<double>(), (double x) => (long)x);
		}

		// Token: 0x17001429 RID: 5161
		// (get) Token: 0x060076C6 RID: 30406 RVA: 0x00243128 File Offset: 0x00241328
		public int Condition
		{
			get
			{
				int num = this.__p.__offset(40);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700142A RID: 5162
		// (get) Token: 0x060076C7 RID: 30407 RVA: 0x00243168 File Offset: 0x00241368
		public string Name
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

		// Token: 0x060076C8 RID: 30408 RVA: 0x002431A0 File Offset: 0x002413A0
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(42, 1);
		}

		// Token: 0x060076C9 RID: 30409 RVA: 0x002431B0 File Offset: 0x002413B0
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(42) ?? Array.Empty<byte>();
		}

		// Token: 0x1700142B RID: 5163
		// (get) Token: 0x060076CA RID: 30410 RVA: 0x002431C8 File Offset: 0x002413C8
		public string Icon
		{
			get
			{
				int num = this.__p.__offset(44);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060076CB RID: 30411 RVA: 0x00243200 File Offset: 0x00241400
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(44, 1);
		}

		// Token: 0x060076CC RID: 30412 RVA: 0x00243210 File Offset: 0x00241410
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(44) ?? Array.Empty<byte>();
		}

		// Token: 0x1700142C RID: 5164
		// (get) Token: 0x060076CD RID: 30413 RVA: 0x00243228 File Offset: 0x00241428
		public string Dec
		{
			get
			{
				int num = this.__p.__offset(46);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060076CE RID: 30414 RVA: 0x00243260 File Offset: 0x00241460
		public Span<byte> GetDecBytes()
		{
			return this.__p.__vector_as_span<byte>(46, 1);
		}

		// Token: 0x060076CF RID: 30415 RVA: 0x00243270 File Offset: 0x00241470
		public byte[] GetDecArray()
		{
			return this.__p.__vector_as_array<byte>(46) ?? Array.Empty<byte>();
		}

		// Token: 0x1700142D RID: 5165
		// (get) Token: 0x060076D0 RID: 30416 RVA: 0x00243288 File Offset: 0x00241488
		public int Priority
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

		// Token: 0x060076D1 RID: 30417 RVA: 0x002432C5 File Offset: 0x002414C5
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用MarkTagIter()或GetMarkTagBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] MarkTag()
		{
			return this.MarkTagIter().ToArray<string>();
		}

		// Token: 0x060076D2 RID: 30418 RVA: 0x002432D2 File Offset: 0x002414D2
		[NullableContext(1)]
		public readonly IEnumerable<string> MarkTagIter()
		{
			FormationProperty.<MarkTagIter>d__72 <MarkTagIter>d__ = new FormationProperty.<MarkTagIter>d__72(-2);
			<MarkTagIter>d__.<>3__<>4__this = this;
			return <MarkTagIter>d__;
		}

		// Token: 0x060076D3 RID: 30419 RVA: 0x002432E7 File Offset: 0x002414E7
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用ResistTagIter()或GetResistTagBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] ResistTag()
		{
			return this.ResistTagIter().ToArray<string>();
		}

		// Token: 0x060076D4 RID: 30420 RVA: 0x002432F4 File Offset: 0x002414F4
		[NullableContext(1)]
		public readonly IEnumerable<string> ResistTagIter()
		{
			FormationProperty.<ResistTagIter>d__74 <ResistTagIter>d__ = new FormationProperty.<ResistTagIter>d__74(-2);
			<ResistTagIter>d__.<>3__<>4__this = this;
			return <ResistTagIter>d__;
		}

		// Token: 0x060076D5 RID: 30421 RVA: 0x0024330C File Offset: 0x0024150C
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用TriggerEffectParams1Iter()或GetTriggerEffectParams1Bytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly long[] TriggerEffectParams1()
		{
			FormationProperty formationProperty = this;
			return formationProperty.GetTriggerEffectParams1Array() ?? Array.Empty<long>();
		}

		// Token: 0x060076D6 RID: 30422 RVA: 0x00243330 File Offset: 0x00241530
		[NullableContext(1)]
		public readonly IEnumerable<long> TriggerEffectParams1Iter()
		{
			FormationProperty.<TriggerEffectParams1Iter>d__76 <TriggerEffectParams1Iter>d__ = new FormationProperty.<TriggerEffectParams1Iter>d__76(-2);
			<TriggerEffectParams1Iter>d__.<>3__<>4__this = this;
			return <TriggerEffectParams1Iter>d__;
		}

		// Token: 0x060076D7 RID: 30423 RVA: 0x00243348 File Offset: 0x00241548
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用TriggerEffectParams2Iter()或GetTriggerEffectParams2Bytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly long[] TriggerEffectParams2()
		{
			FormationProperty formationProperty = this;
			return formationProperty.GetTriggerEffectParams2Array() ?? Array.Empty<long>();
		}

		// Token: 0x060076D8 RID: 30424 RVA: 0x0024336C File Offset: 0x0024156C
		[NullableContext(1)]
		public readonly IEnumerable<long> TriggerEffectParams2Iter()
		{
			FormationProperty.<TriggerEffectParams2Iter>d__78 <TriggerEffectParams2Iter>d__ = new FormationProperty.<TriggerEffectParams2Iter>d__78(-2);
			<TriggerEffectParams2Iter>d__.<>3__<>4__this = this;
			return <TriggerEffectParams2Iter>d__;
		}

		// Token: 0x060076D9 RID: 30425 RVA: 0x00243384 File Offset: 0x00241584
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用TriggerEffectParams3Iter()或GetTriggerEffectParams3Bytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly long[] TriggerEffectParams3()
		{
			FormationProperty formationProperty = this;
			return formationProperty.GetTriggerEffectParams3Array() ?? Array.Empty<long>();
		}

		// Token: 0x060076DA RID: 30426 RVA: 0x002433A8 File Offset: 0x002415A8
		[NullableContext(1)]
		public readonly IEnumerable<long> TriggerEffectParams3Iter()
		{
			FormationProperty.<TriggerEffectParams3Iter>d__80 <TriggerEffectParams3Iter>d__ = new FormationProperty.<TriggerEffectParams3Iter>d__80(-2);
			<TriggerEffectParams3Iter>d__.<>3__<>4__this = this;
			return <TriggerEffectParams3Iter>d__;
		}

		// Token: 0x04004D3E RID: 19774
		private Table __p;
	}
}
