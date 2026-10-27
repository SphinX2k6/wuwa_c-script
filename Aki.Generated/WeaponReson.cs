using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200119A RID: 4506
	public struct WeaponReson : IFlatbufferObject
	{
		// Token: 0x17003E08 RID: 15880
		// (get) Token: 0x0600E81C RID: 59420 RVA: 0x003431DD File Offset: 0x003413DD
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600E81D RID: 59421 RVA: 0x003431EA File Offset: 0x003413EA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600E81E RID: 59422 RVA: 0x003431F4 File Offset: 0x003413F4
		public static WeaponReson GetRootAsWeaponReson(ByteBuffer _bb)
		{
			return WeaponReson.GetRootAsWeaponReson(_bb, default(WeaponReson));
		}

		// Token: 0x0600E81F RID: 59423 RVA: 0x00343210 File Offset: 0x00341410
		public static WeaponReson GetRootAsWeaponReson(ByteBuffer _bb, WeaponReson obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600E820 RID: 59424 RVA: 0x0034322D File Offset: 0x0034142D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600E821 RID: 59425 RVA: 0x0034323C File Offset: 0x0034143C
		public WeaponReson __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003E09 RID: 15881
		// (get) Token: 0x0600E822 RID: 59426 RVA: 0x0034324C File Offset: 0x0034144C
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

		// Token: 0x17003E0A RID: 15882
		// (get) Token: 0x0600E823 RID: 59427 RVA: 0x00343288 File Offset: 0x00341488
		public int ResonId
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

		// Token: 0x17003E0B RID: 15883
		// (get) Token: 0x0600E824 RID: 59428 RVA: 0x003432C4 File Offset: 0x003414C4
		public int Level
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

		// Token: 0x17003E0C RID: 15884
		// (get) Token: 0x0600E825 RID: 59429 RVA: 0x00343300 File Offset: 0x00341500
		public string Name
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

		// Token: 0x0600E826 RID: 59430 RVA: 0x00343338 File Offset: 0x00341538
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600E827 RID: 59431 RVA: 0x00343348 File Offset: 0x00341548
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x0600E828 RID: 59432 RVA: 0x00343360 File Offset: 0x00341560
		public long Effect(int j)
		{
			int num = this.__p.__offset(12);
			return (long)((num != 0) ? this.__p.bb.GetDouble(this.__p.__vector(num) + j * 8) : 0.0);
		}

		// Token: 0x17003E0D RID: 15885
		// (get) Token: 0x0600E829 RID: 59433 RVA: 0x003433AC File Offset: 0x003415AC
		public int EffectLength
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

		// Token: 0x0600E82A RID: 59434 RVA: 0x003433D8 File Offset: 0x003415D8
		public Span<long> GetEffectBytes()
		{
			return MemoryMarshal.Cast<double, long>(this.__p.__vector_as_span<double>(12, 8));
		}

		// Token: 0x0600E82B RID: 59435 RVA: 0x003433ED File Offset: 0x003415ED
		public long[] GetEffectArray()
		{
			return Array.ConvertAll<double, long>(this.__p.__vector_as_array<double>(12) ?? Array.Empty<double>(), (double x) => (long)x);
		}

		// Token: 0x17003E0E RID: 15886
		// (get) Token: 0x0600E82C RID: 59436 RVA: 0x0034342C File Offset: 0x0034162C
		public int Consume
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

		// Token: 0x17003E0F RID: 15887
		// (get) Token: 0x0600E82D RID: 59437 RVA: 0x0034346C File Offset: 0x0034166C
		public int GoldConsume
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

		// Token: 0x17003E10 RID: 15888
		// (get) Token: 0x0600E82E RID: 59438 RVA: 0x003434AC File Offset: 0x003416AC
		public int MaterialPlaceType
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

		// Token: 0x0600E82F RID: 59439 RVA: 0x003434EC File Offset: 0x003416EC
		public int AlternativeConsume(int j)
		{
			int num = this.__p.__offset(20);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003E11 RID: 15889
		// (get) Token: 0x0600E830 RID: 59440 RVA: 0x0034352C File Offset: 0x0034172C
		public int AlternativeConsumeLength
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

		// Token: 0x0600E831 RID: 59441 RVA: 0x00343558 File Offset: 0x00341758
		public Span<int> GetAlternativeConsumeBytes()
		{
			return this.__p.__vector_as_span<int>(20, 4);
		}

		// Token: 0x0600E832 RID: 59442 RVA: 0x00343568 File Offset: 0x00341768
		public int[] GetAlternativeConsumeArray()
		{
			return this.__p.__vector_as_array<int>(20) ?? Array.Empty<int>();
		}

		// Token: 0x0600E833 RID: 59443 RVA: 0x00343580 File Offset: 0x00341780
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用AlternativeConsumeIter()或GetAlternativeConsumeBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] AlternativeConsume()
		{
			WeaponReson weaponReson = this;
			return weaponReson.GetAlternativeConsumeArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600E834 RID: 59444 RVA: 0x003435A4 File Offset: 0x003417A4
		[NullableContext(1)]
		public readonly IEnumerable<int> AlternativeConsumeIter()
		{
			WeaponReson.<AlternativeConsumeIter>d__35 <AlternativeConsumeIter>d__ = new WeaponReson.<AlternativeConsumeIter>d__35(-2);
			<AlternativeConsumeIter>d__.<>3__<>4__this = this;
			return <AlternativeConsumeIter>d__;
		}

		// Token: 0x0600E835 RID: 59445 RVA: 0x003435BC File Offset: 0x003417BC
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用EffectIter()或GetEffectBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly long[] Effect()
		{
			WeaponReson weaponReson = this;
			return weaponReson.GetEffectArray() ?? Array.Empty<long>();
		}

		// Token: 0x0600E836 RID: 59446 RVA: 0x003435E0 File Offset: 0x003417E0
		[NullableContext(1)]
		public readonly IEnumerable<long> EffectIter()
		{
			WeaponReson.<EffectIter>d__37 <EffectIter>d__ = new WeaponReson.<EffectIter>d__37(-2);
			<EffectIter>d__.<>3__<>4__this = this;
			return <EffectIter>d__;
		}

		// Token: 0x040052E5 RID: 21221
		private Table __p;
	}
}
