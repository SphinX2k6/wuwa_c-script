using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E9F RID: 3743
	public struct KurotatoWeaponBuild : IFlatbufferObject
	{
		// Token: 0x17001CCD RID: 7373
		// (get) Token: 0x0600928A RID: 37514 RVA: 0x00292CCA File Offset: 0x00290ECA
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600928B RID: 37515 RVA: 0x00292CD7 File Offset: 0x00290ED7
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600928C RID: 37516 RVA: 0x00292CE0 File Offset: 0x00290EE0
		public static KurotatoWeaponBuild GetRootAsKurotatoWeaponBuild(ByteBuffer _bb)
		{
			return KurotatoWeaponBuild.GetRootAsKurotatoWeaponBuild(_bb, default(KurotatoWeaponBuild));
		}

		// Token: 0x0600928D RID: 37517 RVA: 0x00292CFC File Offset: 0x00290EFC
		public static KurotatoWeaponBuild GetRootAsKurotatoWeaponBuild(ByteBuffer _bb, KurotatoWeaponBuild obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600928E RID: 37518 RVA: 0x00292D19 File Offset: 0x00290F19
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600928F RID: 37519 RVA: 0x00292D28 File Offset: 0x00290F28
		public KurotatoWeaponBuild __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001CCE RID: 7374
		// (get) Token: 0x06009290 RID: 37520 RVA: 0x00292D38 File Offset: 0x00290F38
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

		// Token: 0x17001CCF RID: 7375
		// (get) Token: 0x06009291 RID: 37521 RVA: 0x00292D74 File Offset: 0x00290F74
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

		// Token: 0x06009292 RID: 37522 RVA: 0x00292DAB File Offset: 0x00290FAB
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06009293 RID: 37523 RVA: 0x00292DBA File Offset: 0x00290FBA
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17001CD0 RID: 7376
		// (get) Token: 0x06009294 RID: 37524 RVA: 0x00292DD4 File Offset: 0x00290FD4
		public string Desc
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

		// Token: 0x06009295 RID: 37525 RVA: 0x00292E0B File Offset: 0x0029100B
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06009296 RID: 37526 RVA: 0x00292E1A File Offset: 0x0029101A
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17001CD1 RID: 7377
		// (get) Token: 0x06009297 RID: 37527 RVA: 0x00292E34 File Offset: 0x00291034
		public string Icon
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

		// Token: 0x06009298 RID: 37528 RVA: 0x00292E6C File Offset: 0x0029106C
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06009299 RID: 37529 RVA: 0x00292E7C File Offset: 0x0029107C
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x0600929A RID: 37530 RVA: 0x00292E94 File Offset: 0x00291094
		public int OneEffects(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001CD2 RID: 7378
		// (get) Token: 0x0600929B RID: 37531 RVA: 0x00292ED4 File Offset: 0x002910D4
		public int OneEffectsLength
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

		// Token: 0x0600929C RID: 37532 RVA: 0x00292F00 File Offset: 0x00291100
		public Span<int> GetOneEffectsBytes()
		{
			return this.__p.__vector_as_span<int>(12, 4);
		}

		// Token: 0x0600929D RID: 37533 RVA: 0x00292F10 File Offset: 0x00291110
		public int[] GetOneEffectsArray()
		{
			return this.__p.__vector_as_array<int>(12) ?? Array.Empty<int>();
		}

		// Token: 0x0600929E RID: 37534 RVA: 0x00292F28 File Offset: 0x00291128
		public int TwoEffects(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001CD3 RID: 7379
		// (get) Token: 0x0600929F RID: 37535 RVA: 0x00292F68 File Offset: 0x00291168
		public int TwoEffectsLength
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

		// Token: 0x060092A0 RID: 37536 RVA: 0x00292F94 File Offset: 0x00291194
		public Span<int> GetTwoEffectsBytes()
		{
			return this.__p.__vector_as_span<int>(14, 4);
		}

		// Token: 0x060092A1 RID: 37537 RVA: 0x00292FA4 File Offset: 0x002911A4
		public int[] GetTwoEffectsArray()
		{
			return this.__p.__vector_as_array<int>(14) ?? Array.Empty<int>();
		}

		// Token: 0x060092A2 RID: 37538 RVA: 0x00292FBC File Offset: 0x002911BC
		public int ThreeEffect(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001CD4 RID: 7380
		// (get) Token: 0x060092A3 RID: 37539 RVA: 0x00292FFC File Offset: 0x002911FC
		public int ThreeEffectLength
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

		// Token: 0x060092A4 RID: 37540 RVA: 0x00293028 File Offset: 0x00291228
		public Span<int> GetThreeEffectBytes()
		{
			return this.__p.__vector_as_span<int>(16, 4);
		}

		// Token: 0x060092A5 RID: 37541 RVA: 0x00293038 File Offset: 0x00291238
		public int[] GetThreeEffectArray()
		{
			return this.__p.__vector_as_array<int>(16) ?? Array.Empty<int>();
		}

		// Token: 0x060092A6 RID: 37542 RVA: 0x00293050 File Offset: 0x00291250
		public int FourEffect(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001CD5 RID: 7381
		// (get) Token: 0x060092A7 RID: 37543 RVA: 0x00293090 File Offset: 0x00291290
		public int FourEffectLength
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x060092A8 RID: 37544 RVA: 0x002930BC File Offset: 0x002912BC
		public Span<int> GetFourEffectBytes()
		{
			return this.__p.__vector_as_span<int>(18, 4);
		}

		// Token: 0x060092A9 RID: 37545 RVA: 0x002930CC File Offset: 0x002912CC
		public int[] GetFourEffectArray()
		{
			return this.__p.__vector_as_array<int>(18) ?? Array.Empty<int>();
		}

		// Token: 0x060092AA RID: 37546 RVA: 0x002930E4 File Offset: 0x002912E4
		public int FiveEffect(int j)
		{
			int num = this.__p.__offset(20);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001CD6 RID: 7382
		// (get) Token: 0x060092AB RID: 37547 RVA: 0x00293124 File Offset: 0x00291324
		public int FiveEffectLength
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x060092AC RID: 37548 RVA: 0x00293150 File Offset: 0x00291350
		public Span<int> GetFiveEffectBytes()
		{
			return this.__p.__vector_as_span<int>(20, 4);
		}

		// Token: 0x060092AD RID: 37549 RVA: 0x00293160 File Offset: 0x00291360
		public int[] GetFiveEffectArray()
		{
			return this.__p.__vector_as_array<int>(20) ?? Array.Empty<int>();
		}

		// Token: 0x060092AE RID: 37550 RVA: 0x00293178 File Offset: 0x00291378
		public int SixEffect(int j)
		{
			int num = this.__p.__offset(22);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001CD7 RID: 7383
		// (get) Token: 0x060092AF RID: 37551 RVA: 0x002931B8 File Offset: 0x002913B8
		public int SixEffectLength
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

		// Token: 0x060092B0 RID: 37552 RVA: 0x002931E4 File Offset: 0x002913E4
		public Span<int> GetSixEffectBytes()
		{
			return this.__p.__vector_as_span<int>(22, 4);
		}

		// Token: 0x060092B1 RID: 37553 RVA: 0x002931F4 File Offset: 0x002913F4
		public int[] GetSixEffectArray()
		{
			return this.__p.__vector_as_array<int>(22) ?? Array.Empty<int>();
		}

		// Token: 0x060092B2 RID: 37554 RVA: 0x0029320C File Offset: 0x0029140C
		[NullableContext(1)]
		public int[] FiveEffect()
		{
			return this.GetFiveEffectArray();
		}

		// Token: 0x060092B3 RID: 37555 RVA: 0x00293214 File Offset: 0x00291414
		[NullableContext(1)]
		public IEnumerable<int> FiveEffectIter()
		{
			KurotatoWeaponBuild.<FiveEffectIter>d__53 <FiveEffectIter>d__ = new KurotatoWeaponBuild.<FiveEffectIter>d__53(-2);
			<FiveEffectIter>d__.<>3__<>4__this = this;
			return <FiveEffectIter>d__;
		}

		// Token: 0x060092B4 RID: 37556 RVA: 0x00293229 File Offset: 0x00291429
		[NullableContext(1)]
		public int[] FourEffect()
		{
			return this.GetFourEffectArray();
		}

		// Token: 0x060092B5 RID: 37557 RVA: 0x00293231 File Offset: 0x00291431
		[NullableContext(1)]
		public IEnumerable<int> FourEffectIter()
		{
			KurotatoWeaponBuild.<FourEffectIter>d__55 <FourEffectIter>d__ = new KurotatoWeaponBuild.<FourEffectIter>d__55(-2);
			<FourEffectIter>d__.<>3__<>4__this = this;
			return <FourEffectIter>d__;
		}

		// Token: 0x060092B6 RID: 37558 RVA: 0x00293246 File Offset: 0x00291446
		[NullableContext(1)]
		public int[] OneEffects()
		{
			return this.GetOneEffectsArray();
		}

		// Token: 0x060092B7 RID: 37559 RVA: 0x0029324E File Offset: 0x0029144E
		[NullableContext(1)]
		public IEnumerable<int> OneEffectsIter()
		{
			KurotatoWeaponBuild.<OneEffectsIter>d__57 <OneEffectsIter>d__ = new KurotatoWeaponBuild.<OneEffectsIter>d__57(-2);
			<OneEffectsIter>d__.<>3__<>4__this = this;
			return <OneEffectsIter>d__;
		}

		// Token: 0x060092B8 RID: 37560 RVA: 0x00293263 File Offset: 0x00291463
		[NullableContext(1)]
		public int[] SixEffect()
		{
			return this.GetSixEffectArray();
		}

		// Token: 0x060092B9 RID: 37561 RVA: 0x0029326B File Offset: 0x0029146B
		[NullableContext(1)]
		public IEnumerable<int> SixEffectIter()
		{
			KurotatoWeaponBuild.<SixEffectIter>d__59 <SixEffectIter>d__ = new KurotatoWeaponBuild.<SixEffectIter>d__59(-2);
			<SixEffectIter>d__.<>3__<>4__this = this;
			return <SixEffectIter>d__;
		}

		// Token: 0x060092BA RID: 37562 RVA: 0x00293280 File Offset: 0x00291480
		[NullableContext(1)]
		public int[] ThreeEffect()
		{
			return this.GetThreeEffectArray();
		}

		// Token: 0x060092BB RID: 37563 RVA: 0x00293288 File Offset: 0x00291488
		[NullableContext(1)]
		public IEnumerable<int> ThreeEffectIter()
		{
			KurotatoWeaponBuild.<ThreeEffectIter>d__61 <ThreeEffectIter>d__ = new KurotatoWeaponBuild.<ThreeEffectIter>d__61(-2);
			<ThreeEffectIter>d__.<>3__<>4__this = this;
			return <ThreeEffectIter>d__;
		}

		// Token: 0x060092BC RID: 37564 RVA: 0x0029329D File Offset: 0x0029149D
		[NullableContext(1)]
		public int[] TwoEffects()
		{
			return this.GetTwoEffectsArray();
		}

		// Token: 0x060092BD RID: 37565 RVA: 0x002932A5 File Offset: 0x002914A5
		[NullableContext(1)]
		public IEnumerable<int> TwoEffectsIter()
		{
			KurotatoWeaponBuild.<TwoEffectsIter>d__63 <TwoEffectsIter>d__ = new KurotatoWeaponBuild.<TwoEffectsIter>d__63(-2);
			<TwoEffectsIter>d__.<>3__<>4__this = this;
			return <TwoEffectsIter>d__;
		}

		// Token: 0x04005435 RID: 21557
		private Table __p;
	}
}
