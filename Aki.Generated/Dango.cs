using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C9D RID: 3229
	public struct Dango : IFlatbufferObject
	{
		// Token: 0x17000AAF RID: 2735
		// (get) Token: 0x06006237 RID: 25143 RVA: 0x00225E35 File Offset: 0x00224035
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06006238 RID: 25144 RVA: 0x00225E42 File Offset: 0x00224042
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06006239 RID: 25145 RVA: 0x00225E4C File Offset: 0x0022404C
		public static Dango GetRootAsDango(ByteBuffer _bb)
		{
			return Dango.GetRootAsDango(_bb, default(Dango));
		}

		// Token: 0x0600623A RID: 25146 RVA: 0x00225E68 File Offset: 0x00224068
		public static Dango GetRootAsDango(ByteBuffer _bb, Dango obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600623B RID: 25147 RVA: 0x00225E85 File Offset: 0x00224085
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600623C RID: 25148 RVA: 0x00225E94 File Offset: 0x00224094
		public Dango __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000AB0 RID: 2736
		// (get) Token: 0x0600623D RID: 25149 RVA: 0x00225EA4 File Offset: 0x002240A4
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

		// Token: 0x17000AB1 RID: 2737
		// (get) Token: 0x0600623E RID: 25150 RVA: 0x00225EE0 File Offset: 0x002240E0
		public int Type
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

		// Token: 0x17000AB2 RID: 2738
		// (get) Token: 0x0600623F RID: 25151 RVA: 0x00225F1C File Offset: 0x0022411C
		public int TemplateId
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

		// Token: 0x17000AB3 RID: 2739
		// (get) Token: 0x06006240 RID: 25152 RVA: 0x00225F58 File Offset: 0x00224158
		public int ModelId
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

		// Token: 0x06006241 RID: 25153 RVA: 0x00225F98 File Offset: 0x00224198
		public int ActivityId(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000AB4 RID: 2740
		// (get) Token: 0x06006242 RID: 25154 RVA: 0x00225FD8 File Offset: 0x002241D8
		public int ActivityIdLength
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

		// Token: 0x06006243 RID: 25155 RVA: 0x00226004 File Offset: 0x00224204
		public Span<int> GetActivityIdBytes()
		{
			return this.__p.__vector_as_span<int>(12, 4);
		}

		// Token: 0x06006244 RID: 25156 RVA: 0x00226014 File Offset: 0x00224214
		public int[] GetActivityIdArray()
		{
			return this.__p.__vector_as_array<int>(12) ?? Array.Empty<int>();
		}

		// Token: 0x17000AB5 RID: 2741
		// (get) Token: 0x06006245 RID: 25157 RVA: 0x0022602C File Offset: 0x0022422C
		public string Name
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

		// Token: 0x06006246 RID: 25158 RVA: 0x00226064 File Offset: 0x00224264
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x06006247 RID: 25159 RVA: 0x00226074 File Offset: 0x00224274
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17000AB6 RID: 2742
		// (get) Token: 0x06006248 RID: 25160 RVA: 0x0022608C File Offset: 0x0022428C
		public int DiceId
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

		// Token: 0x17000AB7 RID: 2743
		// (get) Token: 0x06006249 RID: 25161 RVA: 0x002260CC File Offset: 0x002242CC
		public int SkillId
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

		// Token: 0x17000AB8 RID: 2744
		// (get) Token: 0x0600624A RID: 25162 RVA: 0x0022610C File Offset: 0x0022430C
		public string Icon
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600624B RID: 25163 RVA: 0x00226144 File Offset: 0x00224344
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x0600624C RID: 25164 RVA: 0x00226154 File Offset: 0x00224354
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x17000AB9 RID: 2745
		// (get) Token: 0x0600624D RID: 25165 RVA: 0x0022616C File Offset: 0x0022436C
		public string IconDamage
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

		// Token: 0x0600624E RID: 25166 RVA: 0x002261A4 File Offset: 0x002243A4
		public Span<byte> GetIconDamageBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x0600624F RID: 25167 RVA: 0x002261B4 File Offset: 0x002243B4
		public byte[] GetIconDamageArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x17000ABA RID: 2746
		// (get) Token: 0x06006250 RID: 25168 RVA: 0x002261CC File Offset: 0x002243CC
		public string IconAttack
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

		// Token: 0x06006251 RID: 25169 RVA: 0x00226204 File Offset: 0x00224404
		public Span<byte> GetIconAttackBytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x06006252 RID: 25170 RVA: 0x00226214 File Offset: 0x00224414
		public byte[] GetIconAttackArray()
		{
			return this.__p.__vector_as_array<byte>(24) ?? Array.Empty<byte>();
		}

		// Token: 0x17000ABB RID: 2747
		// (get) Token: 0x06006253 RID: 25171 RVA: 0x0022622C File Offset: 0x0022442C
		public string IconSmall
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

		// Token: 0x06006254 RID: 25172 RVA: 0x00226264 File Offset: 0x00224464
		public Span<byte> GetIconSmallBytes()
		{
			return this.__p.__vector_as_span<byte>(26, 1);
		}

		// Token: 0x06006255 RID: 25173 RVA: 0x00226274 File Offset: 0x00224474
		public byte[] GetIconSmallArray()
		{
			return this.__p.__vector_as_array<byte>(26) ?? Array.Empty<byte>();
		}

		// Token: 0x17000ABC RID: 2748
		// (get) Token: 0x06006256 RID: 25174 RVA: 0x0022628C File Offset: 0x0022448C
		public string IconDamageSmall
		{
			get
			{
				int num = this.__p.__offset(28);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06006257 RID: 25175 RVA: 0x002262C4 File Offset: 0x002244C4
		public Span<byte> GetIconDamageSmallBytes()
		{
			return this.__p.__vector_as_span<byte>(28, 1);
		}

		// Token: 0x06006258 RID: 25176 RVA: 0x002262D4 File Offset: 0x002244D4
		public byte[] GetIconDamageSmallArray()
		{
			return this.__p.__vector_as_array<byte>(28) ?? Array.Empty<byte>();
		}

		// Token: 0x17000ABD RID: 2749
		// (get) Token: 0x06006259 RID: 25177 RVA: 0x002262EC File Offset: 0x002244EC
		public string IconAttackSmall
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

		// Token: 0x0600625A RID: 25178 RVA: 0x00226324 File Offset: 0x00224524
		public Span<byte> GetIconAttackSmallBytes()
		{
			return this.__p.__vector_as_span<byte>(30, 1);
		}

		// Token: 0x0600625B RID: 25179 RVA: 0x00226334 File Offset: 0x00224534
		public byte[] GetIconAttackSmallArray()
		{
			return this.__p.__vector_as_array<byte>(30) ?? Array.Empty<byte>();
		}

		// Token: 0x17000ABE RID: 2750
		// (get) Token: 0x0600625C RID: 25180 RVA: 0x0022634C File Offset: 0x0022454C
		public string IconLarge
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

		// Token: 0x0600625D RID: 25181 RVA: 0x00226384 File Offset: 0x00224584
		public Span<byte> GetIconLargeBytes()
		{
			return this.__p.__vector_as_span<byte>(32, 1);
		}

		// Token: 0x0600625E RID: 25182 RVA: 0x00226394 File Offset: 0x00224594
		public byte[] GetIconLargeArray()
		{
			return this.__p.__vector_as_array<byte>(32) ?? Array.Empty<byte>();
		}

		// Token: 0x17000ABF RID: 2751
		// (get) Token: 0x0600625F RID: 25183 RVA: 0x002263AC File Offset: 0x002245AC
		public string IconDamageLarge
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

		// Token: 0x06006260 RID: 25184 RVA: 0x002263E4 File Offset: 0x002245E4
		public Span<byte> GetIconDamageLargeBytes()
		{
			return this.__p.__vector_as_span<byte>(34, 1);
		}

		// Token: 0x06006261 RID: 25185 RVA: 0x002263F4 File Offset: 0x002245F4
		public byte[] GetIconDamageLargeArray()
		{
			return this.__p.__vector_as_array<byte>(34) ?? Array.Empty<byte>();
		}

		// Token: 0x17000AC0 RID: 2752
		// (get) Token: 0x06006262 RID: 25186 RVA: 0x0022640C File Offset: 0x0022460C
		public string IconAttackLarge
		{
			get
			{
				int num = this.__p.__offset(36);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06006263 RID: 25187 RVA: 0x00226444 File Offset: 0x00224644
		public Span<byte> GetIconAttackLargeBytes()
		{
			return this.__p.__vector_as_span<byte>(36, 1);
		}

		// Token: 0x06006264 RID: 25188 RVA: 0x00226454 File Offset: 0x00224654
		public byte[] GetIconAttackLargeArray()
		{
			return this.__p.__vector_as_array<byte>(36) ?? Array.Empty<byte>();
		}

		// Token: 0x17000AC1 RID: 2753
		// (get) Token: 0x06006265 RID: 25189 RVA: 0x0022646C File Offset: 0x0022466C
		public string Dialog
		{
			get
			{
				int num = this.__p.__offset(38);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06006266 RID: 25190 RVA: 0x002264A4 File Offset: 0x002246A4
		public Span<byte> GetDialogBytes()
		{
			return this.__p.__vector_as_span<byte>(38, 1);
		}

		// Token: 0x06006267 RID: 25191 RVA: 0x002264B4 File Offset: 0x002246B4
		public byte[] GetDialogArray()
		{
			return this.__p.__vector_as_array<byte>(38) ?? Array.Empty<byte>();
		}

		// Token: 0x17000AC2 RID: 2754
		// (get) Token: 0x06006268 RID: 25192 RVA: 0x002264CC File Offset: 0x002246CC
		public string CheerAudio
		{
			get
			{
				int num = this.__p.__offset(40);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06006269 RID: 25193 RVA: 0x00226504 File Offset: 0x00224704
		public Span<byte> GetCheerAudioBytes()
		{
			return this.__p.__vector_as_span<byte>(40, 1);
		}

		// Token: 0x0600626A RID: 25194 RVA: 0x00226514 File Offset: 0x00224714
		public byte[] GetCheerAudioArray()
		{
			return this.__p.__vector_as_array<byte>(40) ?? Array.Empty<byte>();
		}

		// Token: 0x17000AC3 RID: 2755
		// (get) Token: 0x0600626B RID: 25195 RVA: 0x0022652C File Offset: 0x0022472C
		public string DeathAudio
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

		// Token: 0x0600626C RID: 25196 RVA: 0x00226564 File Offset: 0x00224764
		public Span<byte> GetDeathAudioBytes()
		{
			return this.__p.__vector_as_span<byte>(42, 1);
		}

		// Token: 0x0600626D RID: 25197 RVA: 0x00226574 File Offset: 0x00224774
		public byte[] GetDeathAudioArray()
		{
			return this.__p.__vector_as_array<byte>(42) ?? Array.Empty<byte>();
		}

		// Token: 0x17000AC4 RID: 2756
		// (get) Token: 0x0600626E RID: 25198 RVA: 0x0022658C File Offset: 0x0022478C
		public string Audio
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

		// Token: 0x0600626F RID: 25199 RVA: 0x002265C4 File Offset: 0x002247C4
		public Span<byte> GetAudioBytes()
		{
			return this.__p.__vector_as_span<byte>(44, 1);
		}

		// Token: 0x06006270 RID: 25200 RVA: 0x002265D4 File Offset: 0x002247D4
		public byte[] GetAudioArray()
		{
			return this.__p.__vector_as_array<byte>(44) ?? Array.Empty<byte>();
		}

		// Token: 0x17000AC5 RID: 2757
		// (get) Token: 0x06006271 RID: 25201 RVA: 0x002265EC File Offset: 0x002247EC
		public int ModelHeight
		{
			get
			{
				int num = this.__p.__offset(46);
				if (num == 0)
				{
					return 70;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06006272 RID: 25202 RVA: 0x0022662A File Offset: 0x0022482A
		[NullableContext(1)]
		public int[] ActivityId()
		{
			return this.GetActivityIdArray();
		}

		// Token: 0x06006273 RID: 25203 RVA: 0x00226632 File Offset: 0x00224832
		[NullableContext(1)]
		public IEnumerable<int> ActivityIdIter()
		{
			Dango.<ActivityIdIter>d__84 <ActivityIdIter>d__ = new Dango.<ActivityIdIter>d__84(-2);
			<ActivityIdIter>d__.<>3__<>4__this = this;
			return <ActivityIdIter>d__;
		}

		// Token: 0x040051C3 RID: 20931
		private Table __p;
	}
}
