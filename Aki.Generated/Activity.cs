using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B96 RID: 2966
	public struct Activity : IFlatbufferObject
	{
		// Token: 0x1700010B RID: 267
		// (get) Token: 0x060047D0 RID: 18384 RVA: 0x001E9F7E File Offset: 0x001E817E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060047D1 RID: 18385 RVA: 0x001E9F8B File Offset: 0x001E818B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060047D2 RID: 18386 RVA: 0x001E9F94 File Offset: 0x001E8194
		public static Activity GetRootAsActivity(ByteBuffer _bb)
		{
			return Activity.GetRootAsActivity(_bb, default(Activity));
		}

		// Token: 0x060047D3 RID: 18387 RVA: 0x001E9FB0 File Offset: 0x001E81B0
		public static Activity GetRootAsActivity(ByteBuffer _bb, Activity obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060047D4 RID: 18388 RVA: 0x001E9FCD File Offset: 0x001E81CD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060047D5 RID: 18389 RVA: 0x001E9FDC File Offset: 0x001E81DC
		public Activity __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700010C RID: 268
		// (get) Token: 0x060047D6 RID: 18390 RVA: 0x001E9FEC File Offset: 0x001E81EC
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
		// (get) Token: 0x060047D7 RID: 18391 RVA: 0x001EA028 File Offset: 0x001E8228
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
		// (get) Token: 0x060047D8 RID: 18392 RVA: 0x001EA064 File Offset: 0x001E8264
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
		// (get) Token: 0x060047D9 RID: 18393 RVA: 0x001EA0A0 File Offset: 0x001E82A0
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
		// (get) Token: 0x060047DA RID: 18394 RVA: 0x001EA0E0 File Offset: 0x001E82E0
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
		// (get) Token: 0x060047DB RID: 18395 RVA: 0x001EA120 File Offset: 0x001E8320
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
		// (get) Token: 0x060047DC RID: 18396 RVA: 0x001EA160 File Offset: 0x001E8360
		public bool ShowPermanentTips
		{
			get
			{
				int num = this.__p.__offset(16);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17000113 RID: 275
		// (get) Token: 0x060047DD RID: 18397 RVA: 0x001EA1A0 File Offset: 0x001E83A0
		public bool ShowTabTime
		{
			get
			{
				int num = this.__p.__offset(18);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17000114 RID: 276
		// (get) Token: 0x060047DE RID: 18398 RVA: 0x001EA1E0 File Offset: 0x001E83E0
		public bool ShowTabFinish
		{
			get
			{
				int num = this.__p.__offset(20);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17000115 RID: 277
		// (get) Token: 0x060047DF RID: 18399 RVA: 0x001EA220 File Offset: 0x001E8420
		public bool SinkTabFinish
		{
			get
			{
				int num = this.__p.__offset(22);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17000116 RID: 278
		// (get) Token: 0x060047E0 RID: 18400 RVA: 0x001EA260 File Offset: 0x001E8460
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
		// (get) Token: 0x060047E1 RID: 18401 RVA: 0x001EA2A0 File Offset: 0x001E84A0
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
		// (get) Token: 0x060047E2 RID: 18402 RVA: 0x001EA2E0 File Offset: 0x001E84E0
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

		// Token: 0x060047E3 RID: 18403 RVA: 0x001EA318 File Offset: 0x001E8518
		public Span<byte> GetPreOpenTextBytes()
		{
			return this.__p.__vector_as_span<byte>(28, 1);
		}

		// Token: 0x060047E4 RID: 18404 RVA: 0x001EA328 File Offset: 0x001E8528
		public byte[] GetPreOpenTextArray()
		{
			return this.__p.__vector_as_array<byte>(28) ?? Array.Empty<byte>();
		}

		// Token: 0x17000119 RID: 281
		// (get) Token: 0x060047E5 RID: 18405 RVA: 0x001EA340 File Offset: 0x001E8540
		public bool ShowUnlockTip
		{
			get
			{
				int num = this.__p.__offset(30);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x060047E6 RID: 18406 RVA: 0x001EA380 File Offset: 0x001E8580
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
		// (get) Token: 0x060047E7 RID: 18407 RVA: 0x001EA3C0 File Offset: 0x001E85C0
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

		// Token: 0x060047E8 RID: 18408 RVA: 0x001EA3EC File Offset: 0x001E85EC
		public Span<int> GetPreShowGuideQuestBytes()
		{
			return this.__p.__vector_as_span<int>(32, 4);
		}

		// Token: 0x060047E9 RID: 18409 RVA: 0x001EA3FC File Offset: 0x001E85FC
		public int[] GetPreShowGuideQuestArray()
		{
			return this.__p.__vector_as_array<int>(32) ?? Array.Empty<int>();
		}

		// Token: 0x1700011B RID: 283
		// (get) Token: 0x060047EA RID: 18410 RVA: 0x001EA414 File Offset: 0x001E8614
		public bool IfShowQuestLeftTime
		{
			get
			{
				int num = this.__p.__offset(34);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700011C RID: 284
		// (get) Token: 0x060047EB RID: 18411 RVA: 0x001EA454 File Offset: 0x001E8654
		public bool CloseGiveUpGuideQuest
		{
			get
			{
				int num = this.__p.__offset(36);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700011D RID: 285
		// (get) Token: 0x060047EC RID: 18412 RVA: 0x001EA494 File Offset: 0x001E8694
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

		// Token: 0x060047ED RID: 18413 RVA: 0x001EA4CC File Offset: 0x001E86CC
		public Span<byte> GetTabResourceBytes()
		{
			return this.__p.__vector_as_span<byte>(38, 1);
		}

		// Token: 0x060047EE RID: 18414 RVA: 0x001EA4DC File Offset: 0x001E86DC
		public byte[] GetTabResourceArray()
		{
			return this.__p.__vector_as_array<byte>(38) ?? Array.Empty<byte>();
		}

		// Token: 0x1700011E RID: 286
		// (get) Token: 0x060047EF RID: 18415 RVA: 0x001EA4F4 File Offset: 0x001E86F4
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

		// Token: 0x060047F0 RID: 18416 RVA: 0x001EA52C File Offset: 0x001E872C
		public Span<byte> GetTabResource2Bytes()
		{
			return this.__p.__vector_as_span<byte>(40, 1);
		}

		// Token: 0x060047F1 RID: 18417 RVA: 0x001EA53C File Offset: 0x001E873C
		public byte[] GetTabResource2Array()
		{
			return this.__p.__vector_as_array<byte>(40) ?? Array.Empty<byte>();
		}

		// Token: 0x060047F2 RID: 18418 RVA: 0x001EA554 File Offset: 0x001E8754
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
		// (get) Token: 0x060047F3 RID: 18419 RVA: 0x001EA590 File Offset: 0x001E8790
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
		// (get) Token: 0x060047F4 RID: 18420 RVA: 0x001EA5BC File Offset: 0x001E87BC
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

		// Token: 0x060047F5 RID: 18421 RVA: 0x001EA5F4 File Offset: 0x001E87F4
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(44, 1);
		}

		// Token: 0x060047F6 RID: 18422 RVA: 0x001EA604 File Offset: 0x001E8804
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(44) ?? Array.Empty<byte>();
		}

		// Token: 0x17000121 RID: 289
		// (get) Token: 0x060047F7 RID: 18423 RVA: 0x001EA61C File Offset: 0x001E881C
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

		// Token: 0x060047F8 RID: 18424 RVA: 0x001EA654 File Offset: 0x001E8854
		public Span<byte> GetTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(46, 1);
		}

		// Token: 0x060047F9 RID: 18425 RVA: 0x001EA664 File Offset: 0x001E8864
		public byte[] GetTitleArray()
		{
			return this.__p.__vector_as_array<byte>(46) ?? Array.Empty<byte>();
		}

		// Token: 0x17000122 RID: 290
		// (get) Token: 0x060047FA RID: 18426 RVA: 0x001EA67C File Offset: 0x001E887C
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

		// Token: 0x060047FB RID: 18427 RVA: 0x001EA6B4 File Offset: 0x001E88B4
		public Span<byte> GetDescThemeBytes()
		{
			return this.__p.__vector_as_span<byte>(48, 1);
		}

		// Token: 0x060047FC RID: 18428 RVA: 0x001EA6C4 File Offset: 0x001E88C4
		public byte[] GetDescThemeArray()
		{
			return this.__p.__vector_as_array<byte>(48) ?? Array.Empty<byte>();
		}

		// Token: 0x17000123 RID: 291
		// (get) Token: 0x060047FD RID: 18429 RVA: 0x001EA6DC File Offset: 0x001E88DC
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

		// Token: 0x060047FE RID: 18430 RVA: 0x001EA714 File Offset: 0x001E8914
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(50, 1);
		}

		// Token: 0x060047FF RID: 18431 RVA: 0x001EA724 File Offset: 0x001E8924
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(50) ?? Array.Empty<byte>();
		}

		// Token: 0x17000124 RID: 292
		// (get) Token: 0x06004800 RID: 18432 RVA: 0x001EA73C File Offset: 0x001E893C
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

		// Token: 0x06004801 RID: 18433 RVA: 0x001EA774 File Offset: 0x001E8974
		public Span<byte> GetBgResourceBytes()
		{
			return this.__p.__vector_as_span<byte>(52, 1);
		}

		// Token: 0x06004802 RID: 18434 RVA: 0x001EA784 File Offset: 0x001E8984
		public byte[] GetBgResourceArray()
		{
			return this.__p.__vector_as_array<byte>(52) ?? Array.Empty<byte>();
		}

		// Token: 0x17000125 RID: 293
		// (get) Token: 0x06004803 RID: 18435 RVA: 0x001EA79C File Offset: 0x001E899C
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
		// (get) Token: 0x06004804 RID: 18436 RVA: 0x001EA7DC File Offset: 0x001E89DC
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
		// (get) Token: 0x06004805 RID: 18437 RVA: 0x001EA81C File Offset: 0x001E8A1C
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
		// (get) Token: 0x06004806 RID: 18438 RVA: 0x001EA85C File Offset: 0x001E8A5C
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

		// Token: 0x06004807 RID: 18439 RVA: 0x001EA894 File Offset: 0x001E8A94
		public Span<byte> GetDescThemeIconBytes()
		{
			return this.__p.__vector_as_span<byte>(60, 1);
		}

		// Token: 0x06004808 RID: 18440 RVA: 0x001EA8A4 File Offset: 0x001E8AA4
		public byte[] GetDescThemeIconArray()
		{
			return this.__p.__vector_as_array<byte>(60) ?? Array.Empty<byte>();
		}

		// Token: 0x17000129 RID: 297
		// (get) Token: 0x06004809 RID: 18441 RVA: 0x001EA8BC File Offset: 0x001E8ABC
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

		// Token: 0x0600480A RID: 18442 RVA: 0x001EA8F4 File Offset: 0x001E8AF4
		public Span<byte> GetTabTagIconBytes()
		{
			return this.__p.__vector_as_span<byte>(62, 1);
		}

		// Token: 0x0600480B RID: 18443 RVA: 0x001EA904 File Offset: 0x001E8B04
		public byte[] GetTabTagIconArray()
		{
			return this.__p.__vector_as_array<byte>(62) ?? Array.Empty<byte>();
		}

		// Token: 0x1700012A RID: 298
		// (get) Token: 0x0600480C RID: 18444 RVA: 0x001EA91C File Offset: 0x001E8B1C
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
		// (get) Token: 0x0600480D RID: 18445 RVA: 0x001EA95C File Offset: 0x001E8B5C
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
		// (get) Token: 0x0600480E RID: 18446 RVA: 0x001EA99C File Offset: 0x001E8B9C
		public bool IsTabEffectNotice
		{
			get
			{
				int num = this.__p.__offset(68);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700012D RID: 301
		// (get) Token: 0x0600480F RID: 18447 RVA: 0x001EA9DC File Offset: 0x001E8BDC
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

		// Token: 0x06004810 RID: 18448 RVA: 0x001EAA14 File Offset: 0x001E8C14
		public Span<byte> GetTypePicIconBytes()
		{
			return this.__p.__vector_as_span<byte>(70, 1);
		}

		// Token: 0x06004811 RID: 18449 RVA: 0x001EAA24 File Offset: 0x001E8C24
		public byte[] GetTypePicIconArray()
		{
			return this.__p.__vector_as_array<byte>(70) ?? Array.Empty<byte>();
		}

		// Token: 0x1700012E RID: 302
		// (get) Token: 0x06004812 RID: 18450 RVA: 0x001EAA3C File Offset: 0x001E8C3C
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

		// Token: 0x06004813 RID: 18451 RVA: 0x001EAA7C File Offset: 0x001E8C7C
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
		// (get) Token: 0x06004814 RID: 18452 RVA: 0x001EAABC File Offset: 0x001E8CBC
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

		// Token: 0x06004815 RID: 18453 RVA: 0x001EAAE8 File Offset: 0x001E8CE8
		public Span<int> GetShowActTypeIdsBytes()
		{
			return this.__p.__vector_as_span<int>(74, 4);
		}

		// Token: 0x06004816 RID: 18454 RVA: 0x001EAAF8 File Offset: 0x001E8CF8
		public int[] GetShowActTypeIdsArray()
		{
			return this.__p.__vector_as_array<int>(74) ?? Array.Empty<int>();
		}

		// Token: 0x17000130 RID: 304
		// (get) Token: 0x06004817 RID: 18455 RVA: 0x001EAB10 File Offset: 0x001E8D10
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

		// Token: 0x06004818 RID: 18456 RVA: 0x001EAB50 File Offset: 0x001E8D50
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
		// (get) Token: 0x06004819 RID: 18457 RVA: 0x001EAB90 File Offset: 0x001E8D90
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

		// Token: 0x0600481A RID: 18458 RVA: 0x001EABBC File Offset: 0x001E8DBC
		public Span<int> GetAreaListBytes()
		{
			return this.__p.__vector_as_span<int>(78, 4);
		}

		// Token: 0x0600481B RID: 18459 RVA: 0x001EABCC File Offset: 0x001E8DCC
		public int[] GetAreaListArray()
		{
			return this.__p.__vector_as_array<int>(78) ?? Array.Empty<int>();
		}

		// Token: 0x0600481C RID: 18460 RVA: 0x001EABE4 File Offset: 0x001E8DE4
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
		// (get) Token: 0x0600481D RID: 18461 RVA: 0x001EAC24 File Offset: 0x001E8E24
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

		// Token: 0x0600481E RID: 18462 RVA: 0x001EAC50 File Offset: 0x001E8E50
		public Span<int> GetDownLoadSubPackageListBytes()
		{
			return this.__p.__vector_as_span<int>(80, 4);
		}

		// Token: 0x0600481F RID: 18463 RVA: 0x001EAC60 File Offset: 0x001E8E60
		public int[] GetDownLoadSubPackageListArray()
		{
			return this.__p.__vector_as_array<int>(80) ?? Array.Empty<int>();
		}

		// Token: 0x17000133 RID: 307
		// (get) Token: 0x06004820 RID: 18464 RVA: 0x001EAC78 File Offset: 0x001E8E78
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

		// Token: 0x06004821 RID: 18465 RVA: 0x001EACB0 File Offset: 0x001E8EB0
		public Span<byte> GetAreaTipsBytes()
		{
			return this.__p.__vector_as_span<byte>(82, 1);
		}

		// Token: 0x06004822 RID: 18466 RVA: 0x001EACC0 File Offset: 0x001E8EC0
		public byte[] GetAreaTipsArray()
		{
			return this.__p.__vector_as_array<byte>(82) ?? Array.Empty<byte>();
		}

		// Token: 0x17000134 RID: 308
		// (get) Token: 0x06004823 RID: 18467 RVA: 0x001EACD8 File Offset: 0x001E8ED8
		public bool HideTabSidebar
		{
			get
			{
				int num = this.__p.__offset(84);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17000135 RID: 309
		// (get) Token: 0x06004824 RID: 18468 RVA: 0x001EAD18 File Offset: 0x001E8F18
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
		// (get) Token: 0x06004825 RID: 18469 RVA: 0x001EAD58 File Offset: 0x001E8F58
		public bool HideActivity
		{
			get
			{
				int num = this.__p.__offset(88);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x06004826 RID: 18470 RVA: 0x001EAD98 File Offset: 0x001E8F98
		[NullableContext(1)]
		public int[] AreaList()
		{
			return this.GetAreaListArray();
		}

		// Token: 0x06004827 RID: 18471 RVA: 0x001EADA0 File Offset: 0x001E8FA0
		[NullableContext(1)]
		public IEnumerable<int> AreaListIter()
		{
			Activity.<AreaListIter>d__132 <AreaListIter>d__ = new Activity.<AreaListIter>d__132(-2);
			<AreaListIter>d__.<>3__<>4__this = this;
			return <AreaListIter>d__;
		}

		// Token: 0x06004828 RID: 18472 RVA: 0x001EADB5 File Offset: 0x001E8FB5
		[NullableContext(1)]
		public int[] DownLoadSubPackageList()
		{
			return this.GetDownLoadSubPackageListArray();
		}

		// Token: 0x06004829 RID: 18473 RVA: 0x001EADBD File Offset: 0x001E8FBD
		[NullableContext(1)]
		public IEnumerable<int> DownLoadSubPackageListIter()
		{
			Activity.<DownLoadSubPackageListIter>d__134 <DownLoadSubPackageListIter>d__ = new Activity.<DownLoadSubPackageListIter>d__134(-2);
			<DownLoadSubPackageListIter>d__.<>3__<>4__this = this;
			return <DownLoadSubPackageListIter>d__;
		}

		// Token: 0x0600482A RID: 18474 RVA: 0x001EADD2 File Offset: 0x001E8FD2
		[NullableContext(1)]
		public int[] PreShowGuideQuest()
		{
			return this.GetPreShowGuideQuestArray();
		}

		// Token: 0x0600482B RID: 18475 RVA: 0x001EADDA File Offset: 0x001E8FDA
		[NullableContext(1)]
		public IEnumerable<int> PreShowGuideQuestIter()
		{
			Activity.<PreShowGuideQuestIter>d__136 <PreShowGuideQuestIter>d__ = new Activity.<PreShowGuideQuestIter>d__136(-2);
			<PreShowGuideQuestIter>d__.<>3__<>4__this = this;
			return <PreShowGuideQuestIter>d__;
		}

		// Token: 0x0600482C RID: 18476 RVA: 0x001EADEF File Offset: 0x001E8FEF
		[NullableContext(1)]
		public int[] ShowActTypeIds()
		{
			return this.GetShowActTypeIdsArray();
		}

		// Token: 0x0600482D RID: 18477 RVA: 0x001EADF7 File Offset: 0x001E8FF7
		[NullableContext(1)]
		public IEnumerable<int> ShowActTypeIdsIter()
		{
			Activity.<ShowActTypeIdsIter>d__138 <ShowActTypeIdsIter>d__ = new Activity.<ShowActTypeIdsIter>d__138(-2);
			<ShowActTypeIdsIter>d__.<>3__<>4__this = this;
			return <ShowActTypeIdsIter>d__;
		}

		// Token: 0x0600482E RID: 18478 RVA: 0x001EAE0C File Offset: 0x001E900C
		[NullableContext(1)]
		public string[] TabTexture()
		{
			return this.TabTextureIter().ToArray<string>();
		}

		// Token: 0x0600482F RID: 18479 RVA: 0x001EAE19 File Offset: 0x001E9019
		[NullableContext(1)]
		public IEnumerable<string> TabTextureIter()
		{
			Activity.<TabTextureIter>d__140 <TabTextureIter>d__ = new Activity.<TabTextureIter>d__140(-2);
			<TabTextureIter>d__.<>3__<>4__this = this;
			return <TabTextureIter>d__;
		}

		// Token: 0x04005070 RID: 20592
		private Table __p;
	}
}
