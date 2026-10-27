using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000FC4 RID: 4036
	public struct RhythmShipLevel : IFlatbufferObject
	{
		// Token: 0x17002E43 RID: 11843
		// (get) Token: 0x0600BC9C RID: 48284 RVA: 0x002DF67D File Offset: 0x002DD87D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600BC9D RID: 48285 RVA: 0x002DF68A File Offset: 0x002DD88A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600BC9E RID: 48286 RVA: 0x002DF694 File Offset: 0x002DD894
		public static RhythmShipLevel GetRootAsRhythmShipLevel(ByteBuffer _bb)
		{
			return RhythmShipLevel.GetRootAsRhythmShipLevel(_bb, default(RhythmShipLevel));
		}

		// Token: 0x0600BC9F RID: 48287 RVA: 0x002DF6B0 File Offset: 0x002DD8B0
		public static RhythmShipLevel GetRootAsRhythmShipLevel(ByteBuffer _bb, RhythmShipLevel obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600BCA0 RID: 48288 RVA: 0x002DF6CD File Offset: 0x002DD8CD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600BCA1 RID: 48289 RVA: 0x002DF6DC File Offset: 0x002DD8DC
		public RhythmShipLevel __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002E44 RID: 11844
		// (get) Token: 0x0600BCA2 RID: 48290 RVA: 0x002DF6EC File Offset: 0x002DD8EC
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

		// Token: 0x17002E45 RID: 11845
		// (get) Token: 0x0600BCA3 RID: 48291 RVA: 0x002DF728 File Offset: 0x002DD928
		public int Planet
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

		// Token: 0x17002E46 RID: 11846
		// (get) Token: 0x0600BCA4 RID: 48292 RVA: 0x002DF764 File Offset: 0x002DD964
		public bool BanRole
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17002E47 RID: 11847
		// (get) Token: 0x0600BCA5 RID: 48293 RVA: 0x002DF7A4 File Offset: 0x002DD9A4
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

		// Token: 0x0600BCA6 RID: 48294 RVA: 0x002DF7DC File Offset: 0x002DD9DC
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600BCA7 RID: 48295 RVA: 0x002DF7EC File Offset: 0x002DD9EC
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17002E48 RID: 11848
		// (get) Token: 0x0600BCA8 RID: 48296 RVA: 0x002DF804 File Offset: 0x002DDA04
		public string Music
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

		// Token: 0x0600BCA9 RID: 48297 RVA: 0x002DF83C File Offset: 0x002DDA3C
		public Span<byte> GetMusicBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600BCAA RID: 48298 RVA: 0x002DF84C File Offset: 0x002DDA4C
		public byte[] GetMusicArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17002E49 RID: 11849
		// (get) Token: 0x0600BCAB RID: 48299 RVA: 0x002DF864 File Offset: 0x002DDA64
		public string PreMusic
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

		// Token: 0x0600BCAC RID: 48300 RVA: 0x002DF89C File Offset: 0x002DDA9C
		public Span<byte> GetPreMusicBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600BCAD RID: 48301 RVA: 0x002DF8AC File Offset: 0x002DDAAC
		public byte[] GetPreMusicArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17002E4A RID: 11850
		// (get) Token: 0x0600BCAE RID: 48302 RVA: 0x002DF8C4 File Offset: 0x002DDAC4
		public string IconTexture
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600BCAF RID: 48303 RVA: 0x002DF8FC File Offset: 0x002DDAFC
		public Span<byte> GetIconTextureBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600BCB0 RID: 48304 RVA: 0x002DF90C File Offset: 0x002DDB0C
		public byte[] GetIconTextureArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x17002E4B RID: 11851
		// (get) Token: 0x0600BCB1 RID: 48305 RVA: 0x002DF924 File Offset: 0x002DDB24
		public string DesName
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600BCB2 RID: 48306 RVA: 0x002DF95C File Offset: 0x002DDB5C
		public Span<byte> GetDesNameBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0600BCB3 RID: 48307 RVA: 0x002DF96C File Offset: 0x002DDB6C
		public byte[] GetDesNameArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x17002E4C RID: 11852
		// (get) Token: 0x0600BCB4 RID: 48308 RVA: 0x002DF984 File Offset: 0x002DDB84
		public string DesTexture
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

		// Token: 0x0600BCB5 RID: 48309 RVA: 0x002DF9BC File Offset: 0x002DDBBC
		public Span<byte> GetDesTextureBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x0600BCB6 RID: 48310 RVA: 0x002DF9CC File Offset: 0x002DDBCC
		public byte[] GetDesTextureArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x17002E4D RID: 11853
		// (get) Token: 0x0600BCB7 RID: 48311 RVA: 0x002DF9E4 File Offset: 0x002DDBE4
		public string BgmEvent
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

		// Token: 0x0600BCB8 RID: 48312 RVA: 0x002DFA1C File Offset: 0x002DDC1C
		public Span<byte> GetBgmEventBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x0600BCB9 RID: 48313 RVA: 0x002DFA2C File Offset: 0x002DDC2C
		public byte[] GetBgmEventArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x17002E4E RID: 11854
		// (get) Token: 0x0600BCBA RID: 48314 RVA: 0x002DFA44 File Offset: 0x002DDC44
		public int SortNumber
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

		// Token: 0x17002E4F RID: 11855
		// (get) Token: 0x0600BCBB RID: 48315 RVA: 0x002DFA84 File Offset: 0x002DDC84
		public string TimeText
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

		// Token: 0x0600BCBC RID: 48316 RVA: 0x002DFABC File Offset: 0x002DDCBC
		public Span<byte> GetTimeTextBytes()
		{
			return this.__p.__vector_as_span<byte>(26, 1);
		}

		// Token: 0x0600BCBD RID: 48317 RVA: 0x002DFACC File Offset: 0x002DDCCC
		public byte[] GetTimeTextArray()
		{
			return this.__p.__vector_as_array<byte>(26) ?? Array.Empty<byte>();
		}

		// Token: 0x17002E50 RID: 11856
		// (get) Token: 0x0600BCBE RID: 48318 RVA: 0x002DFAE4 File Offset: 0x002DDCE4
		public int Time
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

		// Token: 0x17002E51 RID: 11857
		// (get) Token: 0x0600BCBF RID: 48319 RVA: 0x002DFB24 File Offset: 0x002DDD24
		public int PreQuest
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

		// Token: 0x0600BCC0 RID: 48320 RVA: 0x002DFB64 File Offset: 0x002DDD64
		public int PreQuestArray(int j)
		{
			int num = this.__p.__offset(32);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002E52 RID: 11858
		// (get) Token: 0x0600BCC1 RID: 48321 RVA: 0x002DFBA4 File Offset: 0x002DDDA4
		public int PreQuestArrayLength
		{
			get
			{
				int num = this.__p.__offset(32);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600BCC2 RID: 48322 RVA: 0x002DFBD0 File Offset: 0x002DDDD0
		public Span<int> GetPreQuestArrayBytes()
		{
			return this.__p.__vector_as_span<int>(32, 4);
		}

		// Token: 0x0600BCC3 RID: 48323 RVA: 0x002DFBE0 File Offset: 0x002DDDE0
		public int[] GetPreQuestArrayArray()
		{
			return this.__p.__vector_as_array<int>(32) ?? Array.Empty<int>();
		}

		// Token: 0x0600BCC4 RID: 48324 RVA: 0x002DFBF8 File Offset: 0x002DDDF8
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用PreQuestArrayIter()或GetPreQuestArrayBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] PreQuestArray()
		{
			RhythmShipLevel rhythmShipLevel = this;
			return rhythmShipLevel.GetPreQuestArrayArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600BCC5 RID: 48325 RVA: 0x002DFC1C File Offset: 0x002DDE1C
		[NullableContext(1)]
		public readonly IEnumerable<int> PreQuestArrayIter()
		{
			RhythmShipLevel.<PreQuestArrayIter>d__58 <PreQuestArrayIter>d__ = new RhythmShipLevel.<PreQuestArrayIter>d__58(-2);
			<PreQuestArrayIter>d__.<>3__<>4__this = this;
			return <PreQuestArrayIter>d__;
		}

		// Token: 0x0400509E RID: 20638
		private Table __p;
	}
}
