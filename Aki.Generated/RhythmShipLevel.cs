using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020010AC RID: 4268
	public struct RhythmShipLevel : IFlatbufferObject
	{
		// Token: 0x17002EBE RID: 11966
		// (get) Token: 0x0600C2E6 RID: 49894 RVA: 0x002FBD1D File Offset: 0x002F9F1D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600C2E7 RID: 49895 RVA: 0x002FBD2A File Offset: 0x002F9F2A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600C2E8 RID: 49896 RVA: 0x002FBD34 File Offset: 0x002F9F34
		public static RhythmShipLevel GetRootAsRhythmShipLevel(ByteBuffer _bb)
		{
			return RhythmShipLevel.GetRootAsRhythmShipLevel(_bb, default(RhythmShipLevel));
		}

		// Token: 0x0600C2E9 RID: 49897 RVA: 0x002FBD50 File Offset: 0x002F9F50
		public static RhythmShipLevel GetRootAsRhythmShipLevel(ByteBuffer _bb, RhythmShipLevel obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600C2EA RID: 49898 RVA: 0x002FBD6D File Offset: 0x002F9F6D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600C2EB RID: 49899 RVA: 0x002FBD7C File Offset: 0x002F9F7C
		public RhythmShipLevel __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002EBF RID: 11967
		// (get) Token: 0x0600C2EC RID: 49900 RVA: 0x002FBD8C File Offset: 0x002F9F8C
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

		// Token: 0x17002EC0 RID: 11968
		// (get) Token: 0x0600C2ED RID: 49901 RVA: 0x002FBDC8 File Offset: 0x002F9FC8
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

		// Token: 0x17002EC1 RID: 11969
		// (get) Token: 0x0600C2EE RID: 49902 RVA: 0x002FBE04 File Offset: 0x002FA004
		public bool BanRole
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17002EC2 RID: 11970
		// (get) Token: 0x0600C2EF RID: 49903 RVA: 0x002FBE44 File Offset: 0x002FA044
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

		// Token: 0x0600C2F0 RID: 49904 RVA: 0x002FBE7C File Offset: 0x002FA07C
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600C2F1 RID: 49905 RVA: 0x002FBE8C File Offset: 0x002FA08C
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17002EC3 RID: 11971
		// (get) Token: 0x0600C2F2 RID: 49906 RVA: 0x002FBEA4 File Offset: 0x002FA0A4
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

		// Token: 0x0600C2F3 RID: 49907 RVA: 0x002FBEDC File Offset: 0x002FA0DC
		public Span<byte> GetMusicBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600C2F4 RID: 49908 RVA: 0x002FBEEC File Offset: 0x002FA0EC
		public byte[] GetMusicArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17002EC4 RID: 11972
		// (get) Token: 0x0600C2F5 RID: 49909 RVA: 0x002FBF04 File Offset: 0x002FA104
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

		// Token: 0x0600C2F6 RID: 49910 RVA: 0x002FBF3C File Offset: 0x002FA13C
		public Span<byte> GetPreMusicBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600C2F7 RID: 49911 RVA: 0x002FBF4C File Offset: 0x002FA14C
		public byte[] GetPreMusicArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17002EC5 RID: 11973
		// (get) Token: 0x0600C2F8 RID: 49912 RVA: 0x002FBF64 File Offset: 0x002FA164
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

		// Token: 0x0600C2F9 RID: 49913 RVA: 0x002FBF9C File Offset: 0x002FA19C
		public Span<byte> GetIconTextureBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600C2FA RID: 49914 RVA: 0x002FBFAC File Offset: 0x002FA1AC
		public byte[] GetIconTextureArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x17002EC6 RID: 11974
		// (get) Token: 0x0600C2FB RID: 49915 RVA: 0x002FBFC4 File Offset: 0x002FA1C4
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

		// Token: 0x0600C2FC RID: 49916 RVA: 0x002FBFFC File Offset: 0x002FA1FC
		public Span<byte> GetDesNameBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0600C2FD RID: 49917 RVA: 0x002FC00C File Offset: 0x002FA20C
		public byte[] GetDesNameArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x17002EC7 RID: 11975
		// (get) Token: 0x0600C2FE RID: 49918 RVA: 0x002FC024 File Offset: 0x002FA224
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

		// Token: 0x0600C2FF RID: 49919 RVA: 0x002FC05C File Offset: 0x002FA25C
		public Span<byte> GetDesTextureBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x0600C300 RID: 49920 RVA: 0x002FC06C File Offset: 0x002FA26C
		public byte[] GetDesTextureArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x17002EC8 RID: 11976
		// (get) Token: 0x0600C301 RID: 49921 RVA: 0x002FC084 File Offset: 0x002FA284
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

		// Token: 0x0600C302 RID: 49922 RVA: 0x002FC0BC File Offset: 0x002FA2BC
		public Span<byte> GetBgmEventBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x0600C303 RID: 49923 RVA: 0x002FC0CC File Offset: 0x002FA2CC
		public byte[] GetBgmEventArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x17002EC9 RID: 11977
		// (get) Token: 0x0600C304 RID: 49924 RVA: 0x002FC0E4 File Offset: 0x002FA2E4
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

		// Token: 0x17002ECA RID: 11978
		// (get) Token: 0x0600C305 RID: 49925 RVA: 0x002FC124 File Offset: 0x002FA324
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

		// Token: 0x0600C306 RID: 49926 RVA: 0x002FC15C File Offset: 0x002FA35C
		public Span<byte> GetTimeTextBytes()
		{
			return this.__p.__vector_as_span<byte>(26, 1);
		}

		// Token: 0x0600C307 RID: 49927 RVA: 0x002FC16C File Offset: 0x002FA36C
		public byte[] GetTimeTextArray()
		{
			return this.__p.__vector_as_array<byte>(26) ?? Array.Empty<byte>();
		}

		// Token: 0x17002ECB RID: 11979
		// (get) Token: 0x0600C308 RID: 49928 RVA: 0x002FC184 File Offset: 0x002FA384
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

		// Token: 0x17002ECC RID: 11980
		// (get) Token: 0x0600C309 RID: 49929 RVA: 0x002FC1C4 File Offset: 0x002FA3C4
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

		// Token: 0x0600C30A RID: 49930 RVA: 0x002FC204 File Offset: 0x002FA404
		public int PreQuestArray(int j)
		{
			int num = this.__p.__offset(32);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002ECD RID: 11981
		// (get) Token: 0x0600C30B RID: 49931 RVA: 0x002FC244 File Offset: 0x002FA444
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

		// Token: 0x0600C30C RID: 49932 RVA: 0x002FC270 File Offset: 0x002FA470
		public Span<int> GetPreQuestArrayBytes()
		{
			return this.__p.__vector_as_span<int>(32, 4);
		}

		// Token: 0x0600C30D RID: 49933 RVA: 0x002FC280 File Offset: 0x002FA480
		public int[] GetPreQuestArrayArray()
		{
			return this.__p.__vector_as_array<int>(32) ?? Array.Empty<int>();
		}

		// Token: 0x0600C30E RID: 49934 RVA: 0x002FC298 File Offset: 0x002FA498
		[NullableContext(1)]
		public int[] PreQuestArray()
		{
			return this.GetPreQuestArrayArray();
		}

		// Token: 0x0600C30F RID: 49935 RVA: 0x002FC2A0 File Offset: 0x002FA4A0
		[NullableContext(1)]
		public IEnumerable<int> PreQuestArrayIter()
		{
			RhythmShipLevel.<PreQuestArrayIter>d__58 <PreQuestArrayIter>d__ = new RhythmShipLevel.<PreQuestArrayIter>d__58(-2);
			<PreQuestArrayIter>d__.<>3__<>4__this = this;
			return <PreQuestArrayIter>d__;
		}

		// Token: 0x04005686 RID: 22150
		private Table __p;
	}
}
