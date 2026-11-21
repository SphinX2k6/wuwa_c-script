using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F38 RID: 3896
	public struct MotorFightWaveGroup : IFlatbufferObject
	{
		// Token: 0x170021B5 RID: 8629
		// (get) Token: 0x06009FD2 RID: 40914 RVA: 0x002AF97D File Offset: 0x002ADB7D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06009FD3 RID: 40915 RVA: 0x002AF98A File Offset: 0x002ADB8A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06009FD4 RID: 40916 RVA: 0x002AF994 File Offset: 0x002ADB94
		public static MotorFightWaveGroup GetRootAsMotorFightWaveGroup(ByteBuffer _bb)
		{
			return MotorFightWaveGroup.GetRootAsMotorFightWaveGroup(_bb, default(MotorFightWaveGroup));
		}

		// Token: 0x06009FD5 RID: 40917 RVA: 0x002AF9B0 File Offset: 0x002ADBB0
		public static MotorFightWaveGroup GetRootAsMotorFightWaveGroup(ByteBuffer _bb, MotorFightWaveGroup obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06009FD6 RID: 40918 RVA: 0x002AF9CD File Offset: 0x002ADBCD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06009FD7 RID: 40919 RVA: 0x002AF9DC File Offset: 0x002ADBDC
		public MotorFightWaveGroup __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170021B6 RID: 8630
		// (get) Token: 0x06009FD8 RID: 40920 RVA: 0x002AF9EC File Offset: 0x002ADBEC
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

		// Token: 0x06009FD9 RID: 40921 RVA: 0x002AFA28 File Offset: 0x002ADC28
		public int WaveIds(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170021B7 RID: 8631
		// (get) Token: 0x06009FDA RID: 40922 RVA: 0x002AFA68 File Offset: 0x002ADC68
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

		// Token: 0x06009FDB RID: 40923 RVA: 0x002AFA93 File Offset: 0x002ADC93
		public Span<int> GetWaveIdsBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x06009FDC RID: 40924 RVA: 0x002AFAA2 File Offset: 0x002ADCA2
		public int[] GetWaveIdsArray()
		{
			return this.__p.__vector_as_array<int>(6) ?? Array.Empty<int>();
		}

		// Token: 0x170021B8 RID: 8632
		// (get) Token: 0x06009FDD RID: 40925 RVA: 0x002AFABC File Offset: 0x002ADCBC
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

		// Token: 0x170021B9 RID: 8633
		// (get) Token: 0x06009FDE RID: 40926 RVA: 0x002AFAF8 File Offset: 0x002ADCF8
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

		// Token: 0x170021BA RID: 8634
		// (get) Token: 0x06009FDF RID: 40927 RVA: 0x002AFB3C File Offset: 0x002ADD3C
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

		// Token: 0x170021BB RID: 8635
		// (get) Token: 0x06009FE0 RID: 40928 RVA: 0x002AFB80 File Offset: 0x002ADD80
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

		// Token: 0x06009FE1 RID: 40929 RVA: 0x002AFBC4 File Offset: 0x002ADDC4
		public int AttrRate(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170021BC RID: 8636
		// (get) Token: 0x06009FE2 RID: 40930 RVA: 0x002AFC04 File Offset: 0x002ADE04
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

		// Token: 0x06009FE3 RID: 40931 RVA: 0x002AFC30 File Offset: 0x002ADE30
		public Span<int> GetAttrRateBytes()
		{
			return this.__p.__vector_as_span<int>(16, 4);
		}

		// Token: 0x06009FE4 RID: 40932 RVA: 0x002AFC40 File Offset: 0x002ADE40
		public int[] GetAttrRateArray()
		{
			return this.__p.__vector_as_array<int>(16) ?? Array.Empty<int>();
		}

		// Token: 0x06009FE5 RID: 40933 RVA: 0x002AFC58 File Offset: 0x002ADE58
		public int DamageIds(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170021BD RID: 8637
		// (get) Token: 0x06009FE6 RID: 40934 RVA: 0x002AFC98 File Offset: 0x002ADE98
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

		// Token: 0x06009FE7 RID: 40935 RVA: 0x002AFCC4 File Offset: 0x002ADEC4
		public Span<int> GetDamageIdsBytes()
		{
			return this.__p.__vector_as_span<int>(18, 4);
		}

		// Token: 0x06009FE8 RID: 40936 RVA: 0x002AFCD4 File Offset: 0x002ADED4
		public int[] GetDamageIdsArray()
		{
			return this.__p.__vector_as_array<int>(18) ?? Array.Empty<int>();
		}

		// Token: 0x170021BE RID: 8638
		// (get) Token: 0x06009FE9 RID: 40937 RVA: 0x002AFCEC File Offset: 0x002ADEEC
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

		// Token: 0x06009FEA RID: 40938 RVA: 0x002AFD2D File Offset: 0x002ADF2D
		[NullableContext(1)]
		public int[] AttrRate()
		{
			return this.GetAttrRateArray();
		}

		// Token: 0x06009FEB RID: 40939 RVA: 0x002AFD35 File Offset: 0x002ADF35
		[NullableContext(1)]
		public IEnumerable<int> AttrRateIter()
		{
			MotorFightWaveGroup.<AttrRateIter>d__36 <AttrRateIter>d__ = new MotorFightWaveGroup.<AttrRateIter>d__36(-2);
			<AttrRateIter>d__.<>3__<>4__this = this;
			return <AttrRateIter>d__;
		}

		// Token: 0x06009FEC RID: 40940 RVA: 0x002AFD4A File Offset: 0x002ADF4A
		[NullableContext(1)]
		public int[] DamageIds()
		{
			return this.GetDamageIdsArray();
		}

		// Token: 0x06009FED RID: 40941 RVA: 0x002AFD52 File Offset: 0x002ADF52
		[NullableContext(1)]
		public IEnumerable<int> DamageIdsIter()
		{
			MotorFightWaveGroup.<DamageIdsIter>d__38 <DamageIdsIter>d__ = new MotorFightWaveGroup.<DamageIdsIter>d__38(-2);
			<DamageIdsIter>d__.<>3__<>4__this = this;
			return <DamageIdsIter>d__;
		}

		// Token: 0x06009FEE RID: 40942 RVA: 0x002AFD67 File Offset: 0x002ADF67
		[NullableContext(1)]
		public int[] WaveIds()
		{
			return this.GetWaveIdsArray();
		}

		// Token: 0x06009FEF RID: 40943 RVA: 0x002AFD6F File Offset: 0x002ADF6F
		[NullableContext(1)]
		public IEnumerable<int> WaveIdsIter()
		{
			MotorFightWaveGroup.<WaveIdsIter>d__40 <WaveIdsIter>d__ = new MotorFightWaveGroup.<WaveIdsIter>d__40(-2);
			<WaveIdsIter>d__.<>3__<>4__this = this;
			return <WaveIdsIter>d__;
		}

		// Token: 0x040054E1 RID: 21729
		private Table __p;
	}
}
