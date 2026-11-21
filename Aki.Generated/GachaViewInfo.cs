using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000DC9 RID: 3529
	public struct GachaViewInfo : IFlatbufferObject
	{
		// Token: 0x17001522 RID: 5410
		// (get) Token: 0x06007E74 RID: 32372 RVA: 0x0026531E File Offset: 0x0026351E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06007E75 RID: 32373 RVA: 0x0026532B File Offset: 0x0026352B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06007E76 RID: 32374 RVA: 0x00265334 File Offset: 0x00263534
		public static GachaViewInfo GetRootAsGachaViewInfo(ByteBuffer _bb)
		{
			return GachaViewInfo.GetRootAsGachaViewInfo(_bb, default(GachaViewInfo));
		}

		// Token: 0x06007E77 RID: 32375 RVA: 0x00265350 File Offset: 0x00263550
		public static GachaViewInfo GetRootAsGachaViewInfo(ByteBuffer _bb, GachaViewInfo obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06007E78 RID: 32376 RVA: 0x0026536D File Offset: 0x0026356D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06007E79 RID: 32377 RVA: 0x0026537C File Offset: 0x0026357C
		public GachaViewInfo __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001523 RID: 5411
		// (get) Token: 0x06007E7A RID: 32378 RVA: 0x0026538C File Offset: 0x0026358C
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

		// Token: 0x17001524 RID: 5412
		// (get) Token: 0x06007E7B RID: 32379 RVA: 0x002653C8 File Offset: 0x002635C8
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

		// Token: 0x17001525 RID: 5413
		// (get) Token: 0x06007E7C RID: 32380 RVA: 0x00265404 File Offset: 0x00263604
		public string SummaryTitle
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

		// Token: 0x06007E7D RID: 32381 RVA: 0x0026543B File Offset: 0x0026363B
		public Span<byte> GetSummaryTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06007E7E RID: 32382 RVA: 0x0026544A File Offset: 0x0026364A
		public byte[] GetSummaryTitleArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17001526 RID: 5414
		// (get) Token: 0x06007E7F RID: 32383 RVA: 0x00265464 File Offset: 0x00263664
		public string SummaryDescribe
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

		// Token: 0x06007E80 RID: 32384 RVA: 0x0026549C File Offset: 0x0026369C
		public Span<byte> GetSummaryDescribeBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06007E81 RID: 32385 RVA: 0x002654AC File Offset: 0x002636AC
		public byte[] GetSummaryDescribeArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17001527 RID: 5415
		// (get) Token: 0x06007E82 RID: 32386 RVA: 0x002654C4 File Offset: 0x002636C4
		public string ThemeColor
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

		// Token: 0x06007E83 RID: 32387 RVA: 0x002654FC File Offset: 0x002636FC
		public Span<byte> GetThemeColorBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06007E84 RID: 32388 RVA: 0x0026550C File Offset: 0x0026370C
		public byte[] GetThemeColorArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17001528 RID: 5416
		// (get) Token: 0x06007E85 RID: 32389 RVA: 0x00265524 File Offset: 0x00263724
		public Vector? EffectLocation
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return null;
				}
				return new Vector?(default(Vector).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17001529 RID: 5417
		// (get) Token: 0x06007E86 RID: 32390 RVA: 0x00265584 File Offset: 0x00263784
		public string EffectPath
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

		// Token: 0x06007E87 RID: 32391 RVA: 0x002655BC File Offset: 0x002637BC
		public Span<byte> GetEffectPathBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x06007E88 RID: 32392 RVA: 0x002655CC File Offset: 0x002637CC
		public byte[] GetEffectPathArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x1700152A RID: 5418
		// (get) Token: 0x06007E89 RID: 32393 RVA: 0x002655E4 File Offset: 0x002637E4
		public string TextTexture
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

		// Token: 0x06007E8A RID: 32394 RVA: 0x0026561C File Offset: 0x0026381C
		public Span<byte> GetTextTextureBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x06007E8B RID: 32395 RVA: 0x0026562C File Offset: 0x0026382C
		public byte[] GetTextTextureArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x1700152B RID: 5419
		// (get) Token: 0x06007E8C RID: 32396 RVA: 0x00265644 File Offset: 0x00263844
		public string ContentTexturePath
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

		// Token: 0x06007E8D RID: 32397 RVA: 0x0026567C File Offset: 0x0026387C
		public Span<byte> GetContentTexturePathBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x06007E8E RID: 32398 RVA: 0x0026568C File Offset: 0x0026388C
		public byte[] GetContentTexturePathArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x1700152C RID: 5420
		// (get) Token: 0x06007E8F RID: 32399 RVA: 0x002656A4 File Offset: 0x002638A4
		public string ContentTextureBgPath
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

		// Token: 0x06007E90 RID: 32400 RVA: 0x002656DC File Offset: 0x002638DC
		public Span<byte> GetContentTextureBgPathBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x06007E91 RID: 32401 RVA: 0x002656EC File Offset: 0x002638EC
		public byte[] GetContentTextureBgPathArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x1700152D RID: 5421
		// (get) Token: 0x06007E92 RID: 32402 RVA: 0x00265704 File Offset: 0x00263904
		public string UnderBgTexturePath
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

		// Token: 0x06007E93 RID: 32403 RVA: 0x0026573C File Offset: 0x0026393C
		public Span<byte> GetUnderBgTexturePathBytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x06007E94 RID: 32404 RVA: 0x0026574C File Offset: 0x0026394C
		public byte[] GetUnderBgTexturePathArray()
		{
			return this.__p.__vector_as_array<byte>(24) ?? Array.Empty<byte>();
		}

		// Token: 0x1700152E RID: 5422
		// (get) Token: 0x06007E95 RID: 32405 RVA: 0x00265764 File Offset: 0x00263964
		public string TagNotSelectedSpritePath
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

		// Token: 0x06007E96 RID: 32406 RVA: 0x0026579C File Offset: 0x0026399C
		public Span<byte> GetTagNotSelectedSpritePathBytes()
		{
			return this.__p.__vector_as_span<byte>(26, 1);
		}

		// Token: 0x06007E97 RID: 32407 RVA: 0x002657AC File Offset: 0x002639AC
		public byte[] GetTagNotSelectedSpritePathArray()
		{
			return this.__p.__vector_as_array<byte>(26) ?? Array.Empty<byte>();
		}

		// Token: 0x1700152F RID: 5423
		// (get) Token: 0x06007E98 RID: 32408 RVA: 0x002657C4 File Offset: 0x002639C4
		public string TagSelectedSpritePath
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

		// Token: 0x06007E99 RID: 32409 RVA: 0x002657FC File Offset: 0x002639FC
		public Span<byte> GetTagSelectedSpritePathBytes()
		{
			return this.__p.__vector_as_span<byte>(28, 1);
		}

		// Token: 0x06007E9A RID: 32410 RVA: 0x0026580C File Offset: 0x00263A0C
		public byte[] GetTagSelectedSpritePathArray()
		{
			return this.__p.__vector_as_array<byte>(28) ?? Array.Empty<byte>();
		}

		// Token: 0x17001530 RID: 5424
		// (get) Token: 0x06007E9B RID: 32411 RVA: 0x00265824 File Offset: 0x00263A24
		public string WeaponPrefabPath
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

		// Token: 0x06007E9C RID: 32412 RVA: 0x0026585C File Offset: 0x00263A5C
		public Span<byte> GetWeaponPrefabPathBytes()
		{
			return this.__p.__vector_as_span<byte>(30, 1);
		}

		// Token: 0x06007E9D RID: 32413 RVA: 0x0026586C File Offset: 0x00263A6C
		public byte[] GetWeaponPrefabPathArray()
		{
			return this.__p.__vector_as_array<byte>(30) ?? Array.Empty<byte>();
		}

		// Token: 0x17001531 RID: 5425
		// (get) Token: 0x06007E9E RID: 32414 RVA: 0x00265884 File Offset: 0x00263A84
		public string SpinePrefabResource
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

		// Token: 0x06007E9F RID: 32415 RVA: 0x002658BC File Offset: 0x00263ABC
		public Span<byte> GetSpinePrefabResourceBytes()
		{
			return this.__p.__vector_as_span<byte>(32, 1);
		}

		// Token: 0x06007EA0 RID: 32416 RVA: 0x002658CC File Offset: 0x00263ACC
		public byte[] GetSpinePrefabResourceArray()
		{
			return this.__p.__vector_as_array<byte>(32) ?? Array.Empty<byte>();
		}

		// Token: 0x06007EA1 RID: 32417 RVA: 0x002658E4 File Offset: 0x00263AE4
		public int UpList(int j)
		{
			int num = this.__p.__offset(34);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001532 RID: 5426
		// (get) Token: 0x06007EA2 RID: 32418 RVA: 0x00265924 File Offset: 0x00263B24
		public int UpListLength
		{
			get
			{
				int num = this.__p.__offset(34);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06007EA3 RID: 32419 RVA: 0x00265950 File Offset: 0x00263B50
		public Span<int> GetUpListBytes()
		{
			return this.__p.__vector_as_span<int>(34, 4);
		}

		// Token: 0x06007EA4 RID: 32420 RVA: 0x00265960 File Offset: 0x00263B60
		public int[] GetUpListArray()
		{
			return this.__p.__vector_as_array<int>(34) ?? Array.Empty<int>();
		}

		// Token: 0x06007EA5 RID: 32421 RVA: 0x00265978 File Offset: 0x00263B78
		public int ShowIdList(int j)
		{
			int num = this.__p.__offset(36);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001533 RID: 5427
		// (get) Token: 0x06007EA6 RID: 32422 RVA: 0x002659B8 File Offset: 0x00263BB8
		public int ShowIdListLength
		{
			get
			{
				int num = this.__p.__offset(36);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06007EA7 RID: 32423 RVA: 0x002659E4 File Offset: 0x00263BE4
		public Span<int> GetShowIdListBytes()
		{
			return this.__p.__vector_as_span<int>(36, 4);
		}

		// Token: 0x06007EA8 RID: 32424 RVA: 0x002659F4 File Offset: 0x00263BF4
		public int[] GetShowIdListArray()
		{
			return this.__p.__vector_as_array<int>(36) ?? Array.Empty<int>();
		}

		// Token: 0x06007EA9 RID: 32425 RVA: 0x00265A0C File Offset: 0x00263C0C
		public int PreviewIdList(int j)
		{
			int num = this.__p.__offset(38);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001534 RID: 5428
		// (get) Token: 0x06007EAA RID: 32426 RVA: 0x00265A4C File Offset: 0x00263C4C
		public int PreviewIdListLength
		{
			get
			{
				int num = this.__p.__offset(38);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06007EAB RID: 32427 RVA: 0x00265A78 File Offset: 0x00263C78
		public Span<int> GetPreviewIdListBytes()
		{
			return this.__p.__vector_as_span<int>(38, 4);
		}

		// Token: 0x06007EAC RID: 32428 RVA: 0x00265A88 File Offset: 0x00263C88
		public int[] GetPreviewIdListArray()
		{
			return this.__p.__vector_as_array<int>(38) ?? Array.Empty<int>();
		}

		// Token: 0x17001535 RID: 5429
		// (get) Token: 0x06007EAD RID: 32429 RVA: 0x00265AA0 File Offset: 0x00263CA0
		public int TrialActivityId
		{
			get
			{
				int num = this.__p.__offset(40);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001536 RID: 5430
		// (get) Token: 0x06007EAE RID: 32430 RVA: 0x00265AE0 File Offset: 0x00263CE0
		public int TrialRoleId
		{
			get
			{
				int num = this.__p.__offset(42);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001537 RID: 5431
		// (get) Token: 0x06007EAF RID: 32431 RVA: 0x00265B20 File Offset: 0x00263D20
		public int JumpId
		{
			get
			{
				int num = this.__p.__offset(44);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06007EB0 RID: 32432 RVA: 0x00265B5D File Offset: 0x00263D5D
		[NullableContext(1)]
		public int[] PreviewIdList()
		{
			return this.GetPreviewIdListArray();
		}

		// Token: 0x06007EB1 RID: 32433 RVA: 0x00265B65 File Offset: 0x00263D65
		[NullableContext(1)]
		public IEnumerable<int> PreviewIdListIter()
		{
			GachaViewInfo.<PreviewIdListIter>d__84 <PreviewIdListIter>d__ = new GachaViewInfo.<PreviewIdListIter>d__84(-2);
			<PreviewIdListIter>d__.<>3__<>4__this = this;
			return <PreviewIdListIter>d__;
		}

		// Token: 0x06007EB2 RID: 32434 RVA: 0x00265B7A File Offset: 0x00263D7A
		[NullableContext(1)]
		public int[] ShowIdList()
		{
			return this.GetShowIdListArray();
		}

		// Token: 0x06007EB3 RID: 32435 RVA: 0x00265B82 File Offset: 0x00263D82
		[NullableContext(1)]
		public IEnumerable<int> ShowIdListIter()
		{
			GachaViewInfo.<ShowIdListIter>d__86 <ShowIdListIter>d__ = new GachaViewInfo.<ShowIdListIter>d__86(-2);
			<ShowIdListIter>d__.<>3__<>4__this = this;
			return <ShowIdListIter>d__;
		}

		// Token: 0x06007EB4 RID: 32436 RVA: 0x00265B97 File Offset: 0x00263D97
		[NullableContext(1)]
		public int[] UpList()
		{
			return this.GetUpListArray();
		}

		// Token: 0x06007EB5 RID: 32437 RVA: 0x00265B9F File Offset: 0x00263D9F
		[NullableContext(1)]
		public IEnumerable<int> UpListIter()
		{
			GachaViewInfo.<UpListIter>d__88 <UpListIter>d__ = new GachaViewInfo.<UpListIter>d__88(-2);
			<UpListIter>d__.<>3__<>4__this = this;
			return <UpListIter>d__;
		}

		// Token: 0x0400533A RID: 21306
		private Table __p;
	}
}
