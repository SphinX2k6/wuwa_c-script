using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E53 RID: 3667
	public struct MotorFightWaveGroup : IFlatbufferObject
	{
		// Token: 0x17002150 RID: 8528
		// (get) Token: 0x060099B2 RID: 39346 RVA: 0x00291E65 File Offset: 0x00290065
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060099B3 RID: 39347 RVA: 0x00291E72 File Offset: 0x00290072
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060099B4 RID: 39348 RVA: 0x00291E7C File Offset: 0x0029007C
		public static MotorFightWaveGroup GetRootAsMotorFightWaveGroup(ByteBuffer _bb)
		{
			return MotorFightWaveGroup.GetRootAsMotorFightWaveGroup(_bb, default(MotorFightWaveGroup));
		}

		// Token: 0x060099B5 RID: 39349 RVA: 0x00291E98 File Offset: 0x00290098
		public static MotorFightWaveGroup GetRootAsMotorFightWaveGroup(ByteBuffer _bb, MotorFightWaveGroup obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060099B6 RID: 39350 RVA: 0x00291EB5 File Offset: 0x002900B5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060099B7 RID: 39351 RVA: 0x00291EC4 File Offset: 0x002900C4
		public MotorFightWaveGroup __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002151 RID: 8529
		// (get) Token: 0x060099B8 RID: 39352 RVA: 0x00291ED4 File Offset: 0x002900D4
		public int GroupId
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

		// Token: 0x060099B9 RID: 39353 RVA: 0x00291F10 File Offset: 0x00290110
		public int WaveIds(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002152 RID: 8530
		// (get) Token: 0x060099BA RID: 39354 RVA: 0x00291F50 File Offset: 0x00290150
		public int WaveIdsLength
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

		// Token: 0x060099BB RID: 39355 RVA: 0x00291F7B File Offset: 0x0029017B
		public Span<int> GetWaveIdsBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x060099BC RID: 39356 RVA: 0x00291F8A File Offset: 0x0029018A
		public int[] GetWaveIdsArray()
		{
			return this.__p.__vector_as_array<int>(6) ?? Array.Empty<int>();
		}

		// Token: 0x17002153 RID: 8531
		// (get) Token: 0x060099BD RID: 39357 RVA: 0x00291FA4 File Offset: 0x002901A4
		public int GroupType
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

		// Token: 0x17002154 RID: 8532
		// (get) Token: 0x060099BE RID: 39358 RVA: 0x00291FE0 File Offset: 0x002901E0
		public int GroupLength
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 30000;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17002155 RID: 8533
		// (get) Token: 0x060099BF RID: 39359 RVA: 0x00292024 File Offset: 0x00290224
		public int BossFightTime
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 30000;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17002156 RID: 8534
		// (get) Token: 0x060099C0 RID: 39360 RVA: 0x00292068 File Offset: 0x00290268
		public int BossFightDistance
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 3000;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060099C1 RID: 39361 RVA: 0x002920AC File Offset: 0x002902AC
		public int AttrRate(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002157 RID: 8535
		// (get) Token: 0x060099C2 RID: 39362 RVA: 0x002920EC File Offset: 0x002902EC
		public int AttrRateLength
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

		// Token: 0x060099C3 RID: 39363 RVA: 0x00292118 File Offset: 0x00290318
		public Span<int> GetAttrRateBytes()
		{
			return this.__p.__vector_as_span<int>(16, 4);
		}

		// Token: 0x060099C4 RID: 39364 RVA: 0x00292128 File Offset: 0x00290328
		public int[] GetAttrRateArray()
		{
			return this.__p.__vector_as_array<int>(16) ?? Array.Empty<int>();
		}

		// Token: 0x060099C5 RID: 39365 RVA: 0x00292140 File Offset: 0x00290340
		public int DamageIds(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002158 RID: 8536
		// (get) Token: 0x060099C6 RID: 39366 RVA: 0x00292180 File Offset: 0x00290380
		public int DamageIdsLength
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

		// Token: 0x060099C7 RID: 39367 RVA: 0x002921AC File Offset: 0x002903AC
		public Span<int> GetDamageIdsBytes()
		{
			return this.__p.__vector_as_span<int>(18, 4);
		}

		// Token: 0x060099C8 RID: 39368 RVA: 0x002921BC File Offset: 0x002903BC
		public int[] GetDamageIdsArray()
		{
			return this.__p.__vector_as_array<int>(18) ?? Array.Empty<int>();
		}

		// Token: 0x17002159 RID: 8537
		// (get) Token: 0x060099C9 RID: 39369 RVA: 0x002921D4 File Offset: 0x002903D4
		public int Amplify
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 10000;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060099CA RID: 39370 RVA: 0x00292218 File Offset: 0x00290418
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用AttrRateIter()或GetAttrRateBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] AttrRate()
		{
			MotorFightWaveGroup motorFightWaveGroup = this;
			return motorFightWaveGroup.GetAttrRateArray() ?? Array.Empty<int>();
		}

		// Token: 0x060099CB RID: 39371 RVA: 0x0029223C File Offset: 0x0029043C
		[NullableContext(1)]
		public readonly IEnumerable<int> AttrRateIter()
		{
			MotorFightWaveGroup.<AttrRateIter>d__36 <AttrRateIter>d__ = new MotorFightWaveGroup.<AttrRateIter>d__36(-2);
			<AttrRateIter>d__.<>3__<>4__this = this;
			return <AttrRateIter>d__;
		}

		// Token: 0x060099CC RID: 39372 RVA: 0x00292254 File Offset: 0x00290454
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用DamageIdsIter()或GetDamageIdsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] DamageIds()
		{
			MotorFightWaveGroup motorFightWaveGroup = this;
			return motorFightWaveGroup.GetDamageIdsArray() ?? Array.Empty<int>();
		}

		// Token: 0x060099CD RID: 39373 RVA: 0x00292278 File Offset: 0x00290478
		[NullableContext(1)]
		public readonly IEnumerable<int> DamageIdsIter()
		{
			MotorFightWaveGroup.<DamageIdsIter>d__38 <DamageIdsIter>d__ = new MotorFightWaveGroup.<DamageIdsIter>d__38(-2);
			<DamageIdsIter>d__.<>3__<>4__this = this;
			return <DamageIdsIter>d__;
		}

		// Token: 0x060099CE RID: 39374 RVA: 0x00292290 File Offset: 0x00290490
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用WaveIdsIter()或GetWaveIdsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] WaveIds()
		{
			MotorFightWaveGroup motorFightWaveGroup = this;
			return motorFightWaveGroup.GetWaveIdsArray() ?? Array.Empty<int>();
		}

		// Token: 0x060099CF RID: 39375 RVA: 0x002922B4 File Offset: 0x002904B4
		[NullableContext(1)]
		public readonly IEnumerable<int> WaveIdsIter()
		{
			MotorFightWaveGroup.<WaveIdsIter>d__40 <WaveIdsIter>d__ = new MotorFightWaveGroup.<WaveIdsIter>d__40(-2);
			<WaveIdsIter>d__.<>3__<>4__this = this;
			return <WaveIdsIter>d__;
		}

		// Token: 0x04004EFC RID: 20220
		private Table __p;
	}
}
