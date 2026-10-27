using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000AC1 RID: 2753
	public struct Activity : IFlatbufferObject
	{
		// Token: 0x1700010B RID: 267
		// (get) Token: 0x060042D2 RID: 17106 RVA: 0x001CAD3A File Offset: 0x001C8F3A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060042D3 RID: 17107 RVA: 0x001CAD47 File Offset: 0x001C8F47
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060042D4 RID: 17108 RVA: 0x001CAD50 File Offset: 0x001C8F50
		public static Activity GetRootAsActivity(ByteBuffer _bb)
		{
			return Activity.GetRootAsActivity(_bb, default(Activity));
		}

		// Token: 0x060042D5 RID: 17109 RVA: 0x001CAD6C File Offset: 0x001C8F6C
		public static Activity GetRootAsActivity(ByteBuffer _bb, Activity obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060042D6 RID: 17110 RVA: 0x001CAD89 File Offset: 0x001C8F89
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060042D7 RID: 17111 RVA: 0x001CAD98 File Offset: 0x001C8F98
		public Activity __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700010C RID: 268
		// (get) Token: 0x060042D8 RID: 17112 RVA: 0x001CADA8 File Offset: 0x001C8FA8
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

		// Token: 0x1700010D RID: 269
		// (get) Token: 0x060042D9 RID: 17113 RVA: 0x001CADE4 File Offset: 0x001C8FE4
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

		// Token: 0x1700010E RID: 270
		// (get) Token: 0x060042DA RID: 17114 RVA: 0x001CAE20 File Offset: 0x001C9020
		public int OpenType
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

		// Token: 0x1700010F RID: 271
		// (get) Token: 0x060042DB RID: 17115 RVA: 0x001CAE5C File Offset: 0x001C905C
		public int Sort
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 10;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000110 RID: 272
		// (get) Token: 0x060042DC RID: 17116 RVA: 0x001CAE9C File Offset: 0x001C909C
		public int PermanentSort
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return -1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000111 RID: 273
		// (get) Token: 0x060042DD RID: 17117 RVA: 0x001CAEDC File Offset: 0x001C90DC
		public int TimeIsDisplay
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

		// Token: 0x17000112 RID: 274
		// (get) Token: 0x060042DE RID: 17118 RVA: 0x001CAF1C File Offset: 0x001C911C
		public bool ShowPermanentTips
		{
			get
			{
				int num = this.__p.__offset(16);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17000113 RID: 275
		// (get) Token: 0x060042DF RID: 17119 RVA: 0x001CAF5C File Offset: 0x001C915C
		public bool ShowTabTime
		{
			get
			{
				int num = this.__p.__offset(18);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17000114 RID: 276
		// (get) Token: 0x060042E0 RID: 17120 RVA: 0x001CAF9C File Offset: 0x001C919C
		public bool ShowTabFinish
		{
			get
			{
				int num = this.__p.__offset(20);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17000115 RID: 277
		// (get) Token: 0x060042E1 RID: 17121 RVA: 0x001CAFDC File Offset: 0x001C91DC
		public bool SinkTabFinish
		{
			get
			{
				int num = this.__p.__offset(22);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17000116 RID: 278
		// (get) Token: 0x060042E2 RID: 17122 RVA: 0x001CB01C File Offset: 0x001C921C
		public int PreConditionGroupId
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

		// Token: 0x17000117 RID: 279
		// (get) Token: 0x060042E3 RID: 17123 RVA: 0x001CB05C File Offset: 0x001C925C
		public int PreOpenCondition
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

		// Token: 0x17000118 RID: 280
		// (get) Token: 0x060042E4 RID: 17124 RVA: 0x001CB09C File Offset: 0x001C929C
		public string PreOpenText
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

		// Token: 0x060042E5 RID: 17125 RVA: 0x001CB0D4 File Offset: 0x001C92D4
		public Span<byte> GetPreOpenTextBytes()
		{
			return this.__p.__vector_as_span<byte>(28, 1);
		}

		// Token: 0x060042E6 RID: 17126 RVA: 0x001CB0E4 File Offset: 0x001C92E4
		public byte[] GetPreOpenTextArray()
		{
			return this.__p.__vector_as_array<byte>(28) ?? Array.Empty<byte>();
		}

		// Token: 0x17000119 RID: 281
		// (get) Token: 0x060042E7 RID: 17127 RVA: 0x001CB0FC File Offset: 0x001C92FC
		public bool ShowUnlockTip
		{
			get
			{
				int num = this.__p.__offset(30);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x060042E8 RID: 17128 RVA: 0x001CB13C File Offset: 0x001C933C
		public int PreShowGuideQuest(int j)
		{
			int num = this.__p.__offset(32);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700011A RID: 282
		// (get) Token: 0x060042E9 RID: 17129 RVA: 0x001CB17C File Offset: 0x001C937C
		public int PreShowGuideQuestLength
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

		// Token: 0x060042EA RID: 17130 RVA: 0x001CB1A8 File Offset: 0x001C93A8
		public Span<int> GetPreShowGuideQuestBytes()
		{
			return this.__p.__vector_as_span<int>(32, 4);
		}

		// Token: 0x060042EB RID: 17131 RVA: 0x001CB1B8 File Offset: 0x001C93B8
		public int[] GetPreShowGuideQuestArray()
		{
			return this.__p.__vector_as_array<int>(32) ?? Array.Empty<int>();
		}

		// Token: 0x1700011B RID: 283
		// (get) Token: 0x060042EC RID: 17132 RVA: 0x001CB1D0 File Offset: 0x001C93D0
		public bool IfShowQuestLeftTime
		{
			get
			{
				int num = this.__p.__offset(34);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700011C RID: 284
		// (get) Token: 0x060042ED RID: 17133 RVA: 0x001CB210 File Offset: 0x001C9410
		public bool CloseGiveUpGuideQuest
		{
			get
			{
				int num = this.__p.__offset(36);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700011D RID: 285
		// (get) Token: 0x060042EE RID: 17134 RVA: 0x001CB250 File Offset: 0x001C9450
		public string TabResource
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

		// Token: 0x060042EF RID: 17135 RVA: 0x001CB288 File Offset: 0x001C9488
		public Span<byte> GetTabResourceBytes()
		{
			return this.__p.__vector_as_span<byte>(38, 1);
		}

		// Token: 0x060042F0 RID: 17136 RVA: 0x001CB298 File Offset: 0x001C9498
		public byte[] GetTabResourceArray()
		{
			return this.__p.__vector_as_array<byte>(38) ?? Array.Empty<byte>();
		}

		// Token: 0x1700011E RID: 286
		// (get) Token: 0x060042F1 RID: 17137 RVA: 0x001CB2B0 File Offset: 0x001C94B0
		public string TabResource2
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

		// Token: 0x060042F2 RID: 17138 RVA: 0x001CB2E8 File Offset: 0x001C94E8
		public Span<byte> GetTabResource2Bytes()
		{
			return this.__p.__vector_as_span<byte>(40, 1);
		}

		// Token: 0x060042F3 RID: 17139 RVA: 0x001CB2F8 File Offset: 0x001C94F8
		public byte[] GetTabResource2Array()
		{
			return this.__p.__vector_as_array<byte>(40) ?? Array.Empty<byte>();
		}

		// Token: 0x060042F4 RID: 17140 RVA: 0x001CB310 File Offset: 0x001C9510
		public string TabTexture(int j)
		{
			int num = this.__p.__offset(42);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700011F RID: 287
		// (get) Token: 0x060042F5 RID: 17141 RVA: 0x001CB34C File Offset: 0x001C954C
		public int TabTextureLength
		{
			get
			{
				int num = this.__p.__offset(42);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x17000120 RID: 288
		// (get) Token: 0x060042F6 RID: 17142 RVA: 0x001CB378 File Offset: 0x001C9578
		public string Name
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

		// Token: 0x060042F7 RID: 17143 RVA: 0x001CB3B0 File Offset: 0x001C95B0
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(44, 1);
		}

		// Token: 0x060042F8 RID: 17144 RVA: 0x001CB3C0 File Offset: 0x001C95C0
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(44) ?? Array.Empty<byte>();
		}

		// Token: 0x17000121 RID: 289
		// (get) Token: 0x060042F9 RID: 17145 RVA: 0x001CB3D8 File Offset: 0x001C95D8
		public string Title
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

		// Token: 0x060042FA RID: 17146 RVA: 0x001CB410 File Offset: 0x001C9610
		public Span<byte> GetTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(46, 1);
		}

		// Token: 0x060042FB RID: 17147 RVA: 0x001CB420 File Offset: 0x001C9620
		public byte[] GetTitleArray()
		{
			return this.__p.__vector_as_array<byte>(46) ?? Array.Empty<byte>();
		}

		// Token: 0x17000122 RID: 290
		// (get) Token: 0x060042FC RID: 17148 RVA: 0x001CB438 File Offset: 0x001C9638
		public string DescTheme
		{
			get
			{
				int num = this.__p.__offset(48);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060042FD RID: 17149 RVA: 0x001CB470 File Offset: 0x001C9670
		public Span<byte> GetDescThemeBytes()
		{
			return this.__p.__vector_as_span<byte>(48, 1);
		}

		// Token: 0x060042FE RID: 17150 RVA: 0x001CB480 File Offset: 0x001C9680
		public byte[] GetDescThemeArray()
		{
			return this.__p.__vector_as_array<byte>(48) ?? Array.Empty<byte>();
		}

		// Token: 0x17000123 RID: 291
		// (get) Token: 0x060042FF RID: 17151 RVA: 0x001CB498 File Offset: 0x001C9698
		public string Desc
		{
			get
			{
				int num = this.__p.__offset(50);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06004300 RID: 17152 RVA: 0x001CB4D0 File Offset: 0x001C96D0
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(50, 1);
		}

		// Token: 0x06004301 RID: 17153 RVA: 0x001CB4E0 File Offset: 0x001C96E0
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(50) ?? Array.Empty<byte>();
		}

		// Token: 0x17000124 RID: 292
		// (get) Token: 0x06004302 RID: 17154 RVA: 0x001CB4F8 File Offset: 0x001C96F8
		public string BgResource
		{
			get
			{
				int num = this.__p.__offset(52);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06004303 RID: 17155 RVA: 0x001CB530 File Offset: 0x001C9730
		public Span<byte> GetBgResourceBytes()
		{
			return this.__p.__vector_as_span<byte>(52, 1);
		}

		// Token: 0x06004304 RID: 17156 RVA: 0x001CB540 File Offset: 0x001C9740
		public byte[] GetBgResourceArray()
		{
			return this.__p.__vector_as_array<byte>(52) ?? Array.Empty<byte>();
		}

		// Token: 0x17000125 RID: 293
		// (get) Token: 0x06004305 RID: 17157 RVA: 0x001CB558 File Offset: 0x001C9758
		public int PreviewDrop
		{
			get
			{
				int num = this.__p.__offset(54);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000126 RID: 294
		// (get) Token: 0x06004306 RID: 17158 RVA: 0x001CB598 File Offset: 0x001C9798
		public int PermanentPreviewDrop
		{
			get
			{
				int num = this.__p.__offset(56);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000127 RID: 295
		// (get) Token: 0x06004307 RID: 17159 RVA: 0x001CB5D8 File Offset: 0x001C97D8
		public int HelpId
		{
			get
			{
				int num = this.__p.__offset(58);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000128 RID: 296
		// (get) Token: 0x06004308 RID: 17160 RVA: 0x001CB618 File Offset: 0x001C9818
		public string DescThemeIcon
		{
			get
			{
				int num = this.__p.__offset(60);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06004309 RID: 17161 RVA: 0x001CB650 File Offset: 0x001C9850
		public Span<byte> GetDescThemeIconBytes()
		{
			return this.__p.__vector_as_span<byte>(60, 1);
		}

		// Token: 0x0600430A RID: 17162 RVA: 0x001CB660 File Offset: 0x001C9860
		public byte[] GetDescThemeIconArray()
		{
			return this.__p.__vector_as_array<byte>(60) ?? Array.Empty<byte>();
		}

		// Token: 0x17000129 RID: 297
		// (get) Token: 0x0600430B RID: 17163 RVA: 0x001CB678 File Offset: 0x001C9878
		public string TabTagIcon
		{
			get
			{
				int num = this.__p.__offset(62);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600430C RID: 17164 RVA: 0x001CB6B0 File Offset: 0x001C98B0
		public Span<byte> GetTabTagIconBytes()
		{
			return this.__p.__vector_as_span<byte>(62, 1);
		}

		// Token: 0x0600430D RID: 17165 RVA: 0x001CB6C0 File Offset: 0x001C98C0
		public byte[] GetTabTagIconArray()
		{
			return this.__p.__vector_as_array<byte>(62) ?? Array.Empty<byte>();
		}

		// Token: 0x1700012A RID: 298
		// (get) Token: 0x0600430E RID: 17166 RVA: 0x001CB6D8 File Offset: 0x001C98D8
		public int FilterTabType
		{
			get
			{
				int num = this.__p.__offset(64);
				if (num == 0)
				{
					return 1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700012B RID: 299
		// (get) Token: 0x0600430F RID: 17167 RVA: 0x001CB718 File Offset: 0x001C9918
		public int PermanentFilterType
		{
			get
			{
				int num = this.__p.__offset(66);
				if (num == 0)
				{
					return 1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700012C RID: 300
		// (get) Token: 0x06004310 RID: 17168 RVA: 0x001CB758 File Offset: 0x001C9958
		public bool IsTabEffectNotice
		{
			get
			{
				int num = this.__p.__offset(68);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700012D RID: 301
		// (get) Token: 0x06004311 RID: 17169 RVA: 0x001CB798 File Offset: 0x001C9998
		public string TypePicIcon
		{
			get
			{
				int num = this.__p.__offset(70);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06004312 RID: 17170 RVA: 0x001CB7D0 File Offset: 0x001C99D0
		public Span<byte> GetTypePicIconBytes()
		{
			return this.__p.__vector_as_span<byte>(70, 1);
		}

		// Token: 0x06004313 RID: 17171 RVA: 0x001CB7E0 File Offset: 0x001C99E0
		public byte[] GetTypePicIconArray()
		{
			return this.__p.__vector_as_array<byte>(70) ?? Array.Empty<byte>();
		}

		// Token: 0x1700012E RID: 302
		// (get) Token: 0x06004314 RID: 17172 RVA: 0x001CB7F8 File Offset: 0x001C99F8
		public int ShowTabTypeId
		{
			get
			{
				int num = this.__p.__offset(72);
				if (num == 0)
				{
					return 7;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06004315 RID: 17173 RVA: 0x001CB838 File Offset: 0x001C9A38
		public int ShowActTypeIds(int j)
		{
			int num = this.__p.__offset(74);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700012F RID: 303
		// (get) Token: 0x06004316 RID: 17174 RVA: 0x001CB878 File Offset: 0x001C9A78
		public int ShowActTypeIdsLength
		{
			get
			{
				int num = this.__p.__offset(74);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06004317 RID: 17175 RVA: 0x001CB8A4 File Offset: 0x001C9AA4
		public Span<int> GetShowActTypeIdsBytes()
		{
			return this.__p.__vector_as_span<int>(74, 4);
		}

		// Token: 0x06004318 RID: 17176 RVA: 0x001CB8B4 File Offset: 0x001C9AB4
		public int[] GetShowActTypeIdsArray()
		{
			return this.__p.__vector_as_array<int>(74) ?? Array.Empty<int>();
		}

		// Token: 0x17000130 RID: 304
		// (get) Token: 0x06004319 RID: 17177 RVA: 0x001CB8CC File Offset: 0x001C9ACC
		public int TimeShowId
		{
			get
			{
				int num = this.__p.__offset(76);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600431A RID: 17178 RVA: 0x001CB90C File Offset: 0x001C9B0C
		public int AreaList(int j)
		{
			int num = this.__p.__offset(78);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000131 RID: 305
		// (get) Token: 0x0600431B RID: 17179 RVA: 0x001CB94C File Offset: 0x001C9B4C
		public int AreaListLength
		{
			get
			{
				int num = this.__p.__offset(78);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600431C RID: 17180 RVA: 0x001CB978 File Offset: 0x001C9B78
		public Span<int> GetAreaListBytes()
		{
			return this.__p.__vector_as_span<int>(78, 4);
		}

		// Token: 0x0600431D RID: 17181 RVA: 0x001CB988 File Offset: 0x001C9B88
		public int[] GetAreaListArray()
		{
			return this.__p.__vector_as_array<int>(78) ?? Array.Empty<int>();
		}

		// Token: 0x0600431E RID: 17182 RVA: 0x001CB9A0 File Offset: 0x001C9BA0
		public int DownLoadSubPackageList(int j)
		{
			int num = this.__p.__offset(80);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000132 RID: 306
		// (get) Token: 0x0600431F RID: 17183 RVA: 0x001CB9E0 File Offset: 0x001C9BE0
		public int DownLoadSubPackageListLength
		{
			get
			{
				int num = this.__p.__offset(80);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06004320 RID: 17184 RVA: 0x001CBA0C File Offset: 0x001C9C0C
		public Span<int> GetDownLoadSubPackageListBytes()
		{
			return this.__p.__vector_as_span<int>(80, 4);
		}

		// Token: 0x06004321 RID: 17185 RVA: 0x001CBA1C File Offset: 0x001C9C1C
		public int[] GetDownLoadSubPackageListArray()
		{
			return this.__p.__vector_as_array<int>(80) ?? Array.Empty<int>();
		}

		// Token: 0x17000133 RID: 307
		// (get) Token: 0x06004322 RID: 17186 RVA: 0x001CBA34 File Offset: 0x001C9C34
		public string AreaTips
		{
			get
			{
				int num = this.__p.__offset(82);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06004323 RID: 17187 RVA: 0x001CBA6C File Offset: 0x001C9C6C
		public Span<byte> GetAreaTipsBytes()
		{
			return this.__p.__vector_as_span<byte>(82, 1);
		}

		// Token: 0x06004324 RID: 17188 RVA: 0x001CBA7C File Offset: 0x001C9C7C
		public byte[] GetAreaTipsArray()
		{
			return this.__p.__vector_as_array<byte>(82) ?? Array.Empty<byte>();
		}

		// Token: 0x17000134 RID: 308
		// (get) Token: 0x06004325 RID: 17189 RVA: 0x001CBA94 File Offset: 0x001C9C94
		public bool HideTabSidebar
		{
			get
			{
				int num = this.__p.__offset(84);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17000135 RID: 309
		// (get) Token: 0x06004326 RID: 17190 RVA: 0x001CBAD4 File Offset: 0x001C9CD4
		public int CaptionDecoFunc
		{
			get
			{
				int num = this.__p.__offset(86);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000136 RID: 310
		// (get) Token: 0x06004327 RID: 17191 RVA: 0x001CBB14 File Offset: 0x001C9D14
		public bool HideActivity
		{
			get
			{
				int num = this.__p.__offset(88);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x06004328 RID: 17192 RVA: 0x001CBB54 File Offset: 0x001C9D54
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用AreaListIter()或GetAreaListBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] AreaList()
		{
			Activity activity = this;
			return activity.GetAreaListArray() ?? Array.Empty<int>();
		}

		// Token: 0x06004329 RID: 17193 RVA: 0x001CBB78 File Offset: 0x001C9D78
		[NullableContext(1)]
		public readonly IEnumerable<int> AreaListIter()
		{
			Activity.<AreaListIter>d__132 <AreaListIter>d__ = new Activity.<AreaListIter>d__132(-2);
			<AreaListIter>d__.<>3__<>4__this = this;
			return <AreaListIter>d__;
		}

		// Token: 0x0600432A RID: 17194 RVA: 0x001CBB90 File Offset: 0x001C9D90
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用DownLoadSubPackageListIter()或GetDownLoadSubPackageListBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] DownLoadSubPackageList()
		{
			Activity activity = this;
			return activity.GetDownLoadSubPackageListArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600432B RID: 17195 RVA: 0x001CBBB4 File Offset: 0x001C9DB4
		[NullableContext(1)]
		public readonly IEnumerable<int> DownLoadSubPackageListIter()
		{
			Activity.<DownLoadSubPackageListIter>d__134 <DownLoadSubPackageListIter>d__ = new Activity.<DownLoadSubPackageListIter>d__134(-2);
			<DownLoadSubPackageListIter>d__.<>3__<>4__this = this;
			return <DownLoadSubPackageListIter>d__;
		}

		// Token: 0x0600432C RID: 17196 RVA: 0x001CBBCC File Offset: 0x001C9DCC
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用PreShowGuideQuestIter()或GetPreShowGuideQuestBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] PreShowGuideQuest()
		{
			Activity activity = this;
			return activity.GetPreShowGuideQuestArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600432D RID: 17197 RVA: 0x001CBBF0 File Offset: 0x001C9DF0
		[NullableContext(1)]
		public readonly IEnumerable<int> PreShowGuideQuestIter()
		{
			Activity.<PreShowGuideQuestIter>d__136 <PreShowGuideQuestIter>d__ = new Activity.<PreShowGuideQuestIter>d__136(-2);
			<PreShowGuideQuestIter>d__.<>3__<>4__this = this;
			return <PreShowGuideQuestIter>d__;
		}

		// Token: 0x0600432E RID: 17198 RVA: 0x001CBC08 File Offset: 0x001C9E08
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用ShowActTypeIdsIter()或GetShowActTypeIdsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] ShowActTypeIds()
		{
			Activity activity = this;
			return activity.GetShowActTypeIdsArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600432F RID: 17199 RVA: 0x001CBC2C File Offset: 0x001C9E2C
		[NullableContext(1)]
		public readonly IEnumerable<int> ShowActTypeIdsIter()
		{
			Activity.<ShowActTypeIdsIter>d__138 <ShowActTypeIdsIter>d__ = new Activity.<ShowActTypeIdsIter>d__138(-2);
			<ShowActTypeIdsIter>d__.<>3__<>4__this = this;
			return <ShowActTypeIdsIter>d__;
		}

		// Token: 0x06004330 RID: 17200 RVA: 0x001CBC41 File Offset: 0x001C9E41
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用TabTextureIter()或GetTabTextureBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] TabTexture()
		{
			return this.TabTextureIter().ToArray<string>();
		}

		// Token: 0x06004331 RID: 17201 RVA: 0x001CBC4E File Offset: 0x001C9E4E
		[NullableContext(1)]
		public readonly IEnumerable<string> TabTextureIter()
		{
			Activity.<TabTextureIter>d__140 <TabTextureIter>d__ = new Activity.<TabTextureIter>d__140(-2);
			<TabTextureIter>d__.<>3__<>4__this = this;
			return <TabTextureIter>d__;
		}

		// Token: 0x04004A9D RID: 19101
		private Table __p;
	}
}
