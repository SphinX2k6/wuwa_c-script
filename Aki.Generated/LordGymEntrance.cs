using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000EC5 RID: 3781
	public struct LordGymEntrance : IFlatbufferObject
	{
		// Token: 0x17001DF3 RID: 7667
		// (get) Token: 0x0600960C RID: 38412 RVA: 0x0029A229 File Offset: 0x00298429
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600960D RID: 38413 RVA: 0x0029A236 File Offset: 0x00298436
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600960E RID: 38414 RVA: 0x0029A240 File Offset: 0x00298440
		public static LordGymEntrance GetRootAsLordGymEntrance(ByteBuffer _bb)
		{
			return LordGymEntrance.GetRootAsLordGymEntrance(_bb, default(LordGymEntrance));
		}

		// Token: 0x0600960F RID: 38415 RVA: 0x0029A25C File Offset: 0x0029845C
		public static LordGymEntrance GetRootAsLordGymEntrance(ByteBuffer _bb, LordGymEntrance obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06009610 RID: 38416 RVA: 0x0029A279 File Offset: 0x00298479
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06009611 RID: 38417 RVA: 0x0029A288 File Offset: 0x00298488
		public LordGymEntrance __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001DF4 RID: 7668
		// (get) Token: 0x06009612 RID: 38418 RVA: 0x0029A298 File Offset: 0x00298498
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

		// Token: 0x17001DF5 RID: 7669
		// (get) Token: 0x06009613 RID: 38419 RVA: 0x0029A2D4 File Offset: 0x002984D4
		public int MarkId
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

		// Token: 0x06009614 RID: 38420 RVA: 0x0029A310 File Offset: 0x00298510
		public int LordGymList(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001DF6 RID: 7670
		// (get) Token: 0x06009615 RID: 38421 RVA: 0x0029A350 File Offset: 0x00298550
		public int LordGymListLength
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

		// Token: 0x06009616 RID: 38422 RVA: 0x0029A37B File Offset: 0x0029857B
		public Span<int> GetLordGymListBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x06009617 RID: 38423 RVA: 0x0029A38A File Offset: 0x0029858A
		public int[] GetLordGymListArray()
		{
			return this.__p.__vector_as_array<int>(8) ?? Array.Empty<int>();
		}

		// Token: 0x17001DF7 RID: 7671
		// (get) Token: 0x06009618 RID: 38424 RVA: 0x0029A3A4 File Offset: 0x002985A4
		public string EntranceTitle
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

		// Token: 0x06009619 RID: 38425 RVA: 0x0029A3DC File Offset: 0x002985DC
		public Span<byte> GetEntranceTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600961A RID: 38426 RVA: 0x0029A3EC File Offset: 0x002985EC
		public byte[] GetEntranceTitleArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17001DF8 RID: 7672
		// (get) Token: 0x0600961B RID: 38427 RVA: 0x0029A404 File Offset: 0x00298604
		public string EntranceDescription
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

		// Token: 0x0600961C RID: 38428 RVA: 0x0029A43C File Offset: 0x0029863C
		public Span<byte> GetEntranceDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600961D RID: 38429 RVA: 0x0029A44C File Offset: 0x0029864C
		public byte[] GetEntranceDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17001DF9 RID: 7673
		// (get) Token: 0x0600961E RID: 38430 RVA: 0x0029A464 File Offset: 0x00298664
		public int MeshId
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

		// Token: 0x0600961F RID: 38431 RVA: 0x0029A4A4 File Offset: 0x002986A4
		public float Zoom(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return 0f;
			}
			return this.__p.bb.GetFloat(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001DFA RID: 7674
		// (get) Token: 0x06009620 RID: 38432 RVA: 0x0029A4E8 File Offset: 0x002986E8
		public int ZoomLength
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

		// Token: 0x06009621 RID: 38433 RVA: 0x0029A514 File Offset: 0x00298714
		public Span<float> GetZoomBytes()
		{
			return this.__p.__vector_as_span<float>(16, 4);
		}

		// Token: 0x06009622 RID: 38434 RVA: 0x0029A524 File Offset: 0x00298724
		public float[] GetZoomArray()
		{
			return this.__p.__vector_as_array<float>(16) ?? Array.Empty<float>();
		}

		// Token: 0x06009623 RID: 38435 RVA: 0x0029A53C File Offset: 0x0029873C
		public float Location(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return 0f;
			}
			return this.__p.bb.GetFloat(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001DFB RID: 7675
		// (get) Token: 0x06009624 RID: 38436 RVA: 0x0029A580 File Offset: 0x00298780
		public int LocationLength
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

		// Token: 0x06009625 RID: 38437 RVA: 0x0029A5AC File Offset: 0x002987AC
		public Span<float> GetLocationBytes()
		{
			return this.__p.__vector_as_span<float>(18, 4);
		}

		// Token: 0x06009626 RID: 38438 RVA: 0x0029A5BC File Offset: 0x002987BC
		public float[] GetLocationArray()
		{
			return this.__p.__vector_as_array<float>(18) ?? Array.Empty<float>();
		}

		// Token: 0x06009627 RID: 38439 RVA: 0x0029A5D4 File Offset: 0x002987D4
		public float Rotator(int j)
		{
			int num = this.__p.__offset(20);
			if (num == 0)
			{
				return 0f;
			}
			return this.__p.bb.GetFloat(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001DFC RID: 7676
		// (get) Token: 0x06009628 RID: 38440 RVA: 0x0029A618 File Offset: 0x00298818
		public int RotatorLength
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

		// Token: 0x06009629 RID: 38441 RVA: 0x0029A644 File Offset: 0x00298844
		public Span<float> GetRotatorBytes()
		{
			return this.__p.__vector_as_span<float>(20, 4);
		}

		// Token: 0x0600962A RID: 38442 RVA: 0x0029A654 File Offset: 0x00298854
		public float[] GetRotatorArray()
		{
			return this.__p.__vector_as_array<float>(20) ?? Array.Empty<float>();
		}

		// Token: 0x17001DFD RID: 7677
		// (get) Token: 0x0600962B RID: 38443 RVA: 0x0029A66C File Offset: 0x0029886C
		public string LordChangeMaterialController
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600962C RID: 38444 RVA: 0x0029A6A4 File Offset: 0x002988A4
		public Span<byte> GetLordChangeMaterialControllerBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x0600962D RID: 38445 RVA: 0x0029A6B4 File Offset: 0x002988B4
		public byte[] GetLordChangeMaterialControllerArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x17001DFE RID: 7678
		// (get) Token: 0x0600962E RID: 38446 RVA: 0x0029A6CC File Offset: 0x002988CC
		public string LordStartMaterialController
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600962F RID: 38447 RVA: 0x0029A704 File Offset: 0x00298904
		public Span<byte> GetLordStartMaterialControllerBytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x06009630 RID: 38448 RVA: 0x0029A714 File Offset: 0x00298914
		public byte[] GetLordStartMaterialControllerArray()
		{
			return this.__p.__vector_as_array<byte>(24) ?? Array.Empty<byte>();
		}

		// Token: 0x17001DFF RID: 7679
		// (get) Token: 0x06009631 RID: 38449 RVA: 0x0029A72C File Offset: 0x0029892C
		public string LordIdleMaterialController
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06009632 RID: 38450 RVA: 0x0029A764 File Offset: 0x00298964
		public Span<byte> GetLordIdleMaterialControllerBytes()
		{
			return this.__p.__vector_as_span<byte>(26, 1);
		}

		// Token: 0x06009633 RID: 38451 RVA: 0x0029A774 File Offset: 0x00298974
		public byte[] GetLordIdleMaterialControllerArray()
		{
			return this.__p.__vector_as_array<byte>(26) ?? Array.Empty<byte>();
		}

		// Token: 0x17001E00 RID: 7680
		// (get) Token: 0x06009634 RID: 38452 RVA: 0x0029A78C File Offset: 0x0029898C
		public bool IsGroup
		{
			get
			{
				int num = this.__p.__offset(28);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17001E01 RID: 7681
		// (get) Token: 0x06009635 RID: 38453 RVA: 0x0029A7CC File Offset: 0x002989CC
		public string LordUISceneEffect
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

		// Token: 0x06009636 RID: 38454 RVA: 0x0029A804 File Offset: 0x00298A04
		public Span<byte> GetLordUISceneEffectBytes()
		{
			return this.__p.__vector_as_span<byte>(30, 1);
		}

		// Token: 0x06009637 RID: 38455 RVA: 0x0029A814 File Offset: 0x00298A14
		public byte[] GetLordUISceneEffectArray()
		{
			return this.__p.__vector_as_array<byte>(30) ?? Array.Empty<byte>();
		}

		// Token: 0x17001E02 RID: 7682
		// (get) Token: 0x06009638 RID: 38456 RVA: 0x0029A82C File Offset: 0x00298A2C
		public string StandAnim
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

		// Token: 0x06009639 RID: 38457 RVA: 0x0029A864 File Offset: 0x00298A64
		public Span<byte> GetStandAnimBytes()
		{
			return this.__p.__vector_as_span<byte>(32, 1);
		}

		// Token: 0x0600963A RID: 38458 RVA: 0x0029A874 File Offset: 0x00298A74
		public byte[] GetStandAnimArray()
		{
			return this.__p.__vector_as_array<byte>(32) ?? Array.Empty<byte>();
		}

		// Token: 0x17001E03 RID: 7683
		// (get) Token: 0x0600963B RID: 38459 RVA: 0x0029A88C File Offset: 0x00298A8C
		public bool IsDebug
		{
			get
			{
				int num = this.__p.__offset(34);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0600963C RID: 38460 RVA: 0x0029A8CC File Offset: 0x00298ACC
		[NullableContext(1)]
		public float[] Location()
		{
			return this.GetLocationArray();
		}

		// Token: 0x0600963D RID: 38461 RVA: 0x0029A8D4 File Offset: 0x00298AD4
		[NullableContext(1)]
		public IEnumerable<float> LocationIter()
		{
			LordGymEntrance.<LocationIter>d__67 <LocationIter>d__ = new LordGymEntrance.<LocationIter>d__67(-2);
			<LocationIter>d__.<>3__<>4__this = this;
			return <LocationIter>d__;
		}

		// Token: 0x0600963E RID: 38462 RVA: 0x0029A8E9 File Offset: 0x00298AE9
		[NullableContext(1)]
		public int[] LordGymList()
		{
			return this.GetLordGymListArray();
		}

		// Token: 0x0600963F RID: 38463 RVA: 0x0029A8F1 File Offset: 0x00298AF1
		[NullableContext(1)]
		public IEnumerable<int> LordGymListIter()
		{
			LordGymEntrance.<LordGymListIter>d__69 <LordGymListIter>d__ = new LordGymEntrance.<LordGymListIter>d__69(-2);
			<LordGymListIter>d__.<>3__<>4__this = this;
			return <LordGymListIter>d__;
		}

		// Token: 0x06009640 RID: 38464 RVA: 0x0029A906 File Offset: 0x00298B06
		[NullableContext(1)]
		public float[] Rotator()
		{
			return this.GetRotatorArray();
		}

		// Token: 0x06009641 RID: 38465 RVA: 0x0029A90E File Offset: 0x00298B0E
		[NullableContext(1)]
		public IEnumerable<float> RotatorIter()
		{
			LordGymEntrance.<RotatorIter>d__71 <RotatorIter>d__ = new LordGymEntrance.<RotatorIter>d__71(-2);
			<RotatorIter>d__.<>3__<>4__this = this;
			return <RotatorIter>d__;
		}

		// Token: 0x06009642 RID: 38466 RVA: 0x0029A923 File Offset: 0x00298B23
		[NullableContext(1)]
		public float[] Zoom()
		{
			return this.GetZoomArray();
		}

		// Token: 0x06009643 RID: 38467 RVA: 0x0029A92B File Offset: 0x00298B2B
		[NullableContext(1)]
		public IEnumerable<float> ZoomIter()
		{
			LordGymEntrance.<ZoomIter>d__73 <ZoomIter>d__ = new LordGymEntrance.<ZoomIter>d__73(-2);
			<ZoomIter>d__.<>3__<>4__this = this;
			return <ZoomIter>d__;
		}

		// Token: 0x04005461 RID: 21601
		private Table __p;
	}
}
