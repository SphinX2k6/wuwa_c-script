using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Core.Common;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001143 RID: 4419
	[GeneratePropertyAccessMethod(false, false, "string")]
	[Obfuscation]
	public struct RoleSkin : IFlatbufferObject
	{
		// Token: 0x17003385 RID: 13189
		// (get) Token: 0x0600D076 RID: 53366 RVA: 0x00319DF1 File Offset: 0x00317FF1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600D077 RID: 53367 RVA: 0x00319DFE File Offset: 0x00317FFE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600D078 RID: 53368 RVA: 0x00319E08 File Offset: 0x00318008
		public static RoleSkin GetRootAsRoleSkin(ByteBuffer _bb)
		{
			return RoleSkin.GetRootAsRoleSkin(_bb, default(RoleSkin));
		}

		// Token: 0x0600D079 RID: 53369 RVA: 0x00319E24 File Offset: 0x00318024
		public static RoleSkin GetRootAsRoleSkin(ByteBuffer _bb, RoleSkin obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600D07A RID: 53370 RVA: 0x00319E41 File Offset: 0x00318041
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600D07B RID: 53371 RVA: 0x00319E50 File Offset: 0x00318050
		public RoleSkin __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003386 RID: 13190
		// (get) Token: 0x0600D07C RID: 53372 RVA: 0x00319E60 File Offset: 0x00318060
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

		// Token: 0x17003387 RID: 13191
		// (get) Token: 0x0600D07D RID: 53373 RVA: 0x00319E9C File Offset: 0x0031809C
		public int RoleId
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

		// Token: 0x17003388 RID: 13192
		// (get) Token: 0x0600D07E RID: 53374 RVA: 0x00319ED8 File Offset: 0x003180D8
		public int GroupId
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

		// Token: 0x17003389 RID: 13193
		// (get) Token: 0x0600D07F RID: 53375 RVA: 0x00319F14 File Offset: 0x00318114
		public int SuitWeaponSkinId
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

		// Token: 0x1700338A RID: 13194
		// (get) Token: 0x0600D080 RID: 53376 RVA: 0x00319F54 File Offset: 0x00318154
		public int HeadId
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700338B RID: 13195
		// (get) Token: 0x0600D081 RID: 53377 RVA: 0x00319F94 File Offset: 0x00318194
		public int QualityId
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

		// Token: 0x1700338C RID: 13196
		// (get) Token: 0x0600D082 RID: 53378 RVA: 0x00319FD4 File Offset: 0x003181D4
		public string Name
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

		// Token: 0x0600D083 RID: 53379 RVA: 0x0031A00C File Offset: 0x0031820C
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600D084 RID: 53380 RVA: 0x0031A01C File Offset: 0x0031821C
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x1700338D RID: 13197
		// (get) Token: 0x0600D085 RID: 53381 RVA: 0x0031A034 File Offset: 0x00318234
		public string TitleName
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

		// Token: 0x0600D086 RID: 53382 RVA: 0x0031A06C File Offset: 0x0031826C
		public Span<byte> GetTitleNameBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0600D087 RID: 53383 RVA: 0x0031A07C File Offset: 0x0031827C
		public byte[] GetTitleNameArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x1700338E RID: 13198
		// (get) Token: 0x0600D088 RID: 53384 RVA: 0x0031A094 File Offset: 0x00318294
		public string SubDecName
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

		// Token: 0x0600D089 RID: 53385 RVA: 0x0031A0CC File Offset: 0x003182CC
		public Span<byte> GetSubDecNameBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x0600D08A RID: 53386 RVA: 0x0031A0DC File Offset: 0x003182DC
		public byte[] GetSubDecNameArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x1700338F RID: 13199
		// (get) Token: 0x0600D08B RID: 53387 RVA: 0x0031A0F4 File Offset: 0x003182F4
		public string TypeDescription
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

		// Token: 0x0600D08C RID: 53388 RVA: 0x0031A12C File Offset: 0x0031832C
		public Span<byte> GetTypeDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x0600D08D RID: 53389 RVA: 0x0031A13C File Offset: 0x0031833C
		public byte[] GetTypeDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x17003390 RID: 13200
		// (get) Token: 0x0600D08E RID: 53390 RVA: 0x0031A154 File Offset: 0x00318354
		public string AttributesDescription
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

		// Token: 0x0600D08F RID: 53391 RVA: 0x0031A18C File Offset: 0x0031838C
		public Span<byte> GetAttributesDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x0600D090 RID: 53392 RVA: 0x0031A19C File Offset: 0x0031839C
		public byte[] GetAttributesDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(24) ?? Array.Empty<byte>();
		}

		// Token: 0x17003391 RID: 13201
		// (get) Token: 0x0600D091 RID: 53393 RVA: 0x0031A1B4 File Offset: 0x003183B4
		public string BgDescription
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

		// Token: 0x0600D092 RID: 53394 RVA: 0x0031A1EC File Offset: 0x003183EC
		public Span<byte> GetBgDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(26, 1);
		}

		// Token: 0x0600D093 RID: 53395 RVA: 0x0031A1FC File Offset: 0x003183FC
		public byte[] GetBgDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(26) ?? Array.Empty<byte>();
		}

		// Token: 0x17003392 RID: 13202
		// (get) Token: 0x0600D094 RID: 53396 RVA: 0x0031A214 File Offset: 0x00318414
		public string IconMiddle
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

		// Token: 0x0600D095 RID: 53397 RVA: 0x0031A24C File Offset: 0x0031844C
		public Span<byte> GetIconMiddleBytes()
		{
			return this.__p.__vector_as_span<byte>(28, 1);
		}

		// Token: 0x0600D096 RID: 53398 RVA: 0x0031A25C File Offset: 0x0031845C
		public byte[] GetIconMiddleArray()
		{
			return this.__p.__vector_as_array<byte>(28) ?? Array.Empty<byte>();
		}

		// Token: 0x17003393 RID: 13203
		// (get) Token: 0x0600D097 RID: 53399 RVA: 0x0031A274 File Offset: 0x00318474
		public string IconSmall
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

		// Token: 0x0600D098 RID: 53400 RVA: 0x0031A2AC File Offset: 0x003184AC
		public Span<byte> GetIconSmallBytes()
		{
			return this.__p.__vector_as_span<byte>(30, 1);
		}

		// Token: 0x0600D099 RID: 53401 RVA: 0x0031A2BC File Offset: 0x003184BC
		public byte[] GetIconSmallArray()
		{
			return this.__p.__vector_as_array<byte>(30) ?? Array.Empty<byte>();
		}

		// Token: 0x0600D09A RID: 53402 RVA: 0x0031A2D4 File Offset: 0x003184D4
		public int ItemAccess(int j)
		{
			int num = this.__p.__offset(32);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003394 RID: 13204
		// (get) Token: 0x0600D09B RID: 53403 RVA: 0x0031A314 File Offset: 0x00318514
		public int ItemAccessLength
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

		// Token: 0x0600D09C RID: 53404 RVA: 0x0031A340 File Offset: 0x00318540
		public Span<int> GetItemAccessBytes()
		{
			return this.__p.__vector_as_span<int>(32, 4);
		}

		// Token: 0x0600D09D RID: 53405 RVA: 0x0031A350 File Offset: 0x00318550
		public int[] GetItemAccessArray()
		{
			return this.__p.__vector_as_array<int>(32) ?? Array.Empty<int>();
		}

		// Token: 0x17003395 RID: 13205
		// (get) Token: 0x0600D09E RID: 53406 RVA: 0x0031A368 File Offset: 0x00318568
		public int SortIndex
		{
			get
			{
				int num = this.__p.__offset(34);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17003396 RID: 13206
		// (get) Token: 0x0600D09F RID: 53407 RVA: 0x0031A3A8 File Offset: 0x003185A8
		public int RedDotDisableRule
		{
			get
			{
				int num = this.__p.__offset(36);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17003397 RID: 13207
		// (get) Token: 0x0600D0A0 RID: 53408 RVA: 0x0031A3E8 File Offset: 0x003185E8
		public bool ShowInBag
		{
			get
			{
				int num = this.__p.__offset(38);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17003398 RID: 13208
		// (get) Token: 0x0600D0A1 RID: 53409 RVA: 0x0031A428 File Offset: 0x00318628
		public string ObtainedShowDescription
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

		// Token: 0x0600D0A2 RID: 53410 RVA: 0x0031A460 File Offset: 0x00318660
		public Span<byte> GetObtainedShowDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(40, 1);
		}

		// Token: 0x0600D0A3 RID: 53411 RVA: 0x0031A470 File Offset: 0x00318670
		public byte[] GetObtainedShowDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(40) ?? Array.Empty<byte>();
		}

		// Token: 0x17003399 RID: 13209
		// (get) Token: 0x0600D0A4 RID: 53412 RVA: 0x0031A488 File Offset: 0x00318688
		public string Icon
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

		// Token: 0x0600D0A5 RID: 53413 RVA: 0x0031A4C0 File Offset: 0x003186C0
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(42, 1);
		}

		// Token: 0x0600D0A6 RID: 53414 RVA: 0x0031A4D0 File Offset: 0x003186D0
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(42) ?? Array.Empty<byte>();
		}

		// Token: 0x1700339A RID: 13210
		// (get) Token: 0x0600D0A7 RID: 53415 RVA: 0x0031A4E8 File Offset: 0x003186E8
		public string FunctionDesc
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

		// Token: 0x0600D0A8 RID: 53416 RVA: 0x0031A520 File Offset: 0x00318720
		public Span<byte> GetFunctionDescBytes()
		{
			return this.__p.__vector_as_span<byte>(44, 1);
		}

		// Token: 0x0600D0A9 RID: 53417 RVA: 0x0031A530 File Offset: 0x00318730
		public byte[] GetFunctionDescArray()
		{
			return this.__p.__vector_as_array<byte>(44) ?? Array.Empty<byte>();
		}

		// Token: 0x1700339B RID: 13211
		// (get) Token: 0x0600D0AA RID: 53418 RVA: 0x0031A548 File Offset: 0x00318748
		public string FirstObtainDesc
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

		// Token: 0x0600D0AB RID: 53419 RVA: 0x0031A580 File Offset: 0x00318780
		public Span<byte> GetFirstObtainDescBytes()
		{
			return this.__p.__vector_as_span<byte>(46, 1);
		}

		// Token: 0x0600D0AC RID: 53420 RVA: 0x0031A590 File Offset: 0x00318790
		public byte[] GetFirstObtainDescArray()
		{
			return this.__p.__vector_as_array<byte>(46) ?? Array.Empty<byte>();
		}

		// Token: 0x1700339C RID: 13212
		// (get) Token: 0x0600D0AD RID: 53421 RVA: 0x0031A5A8 File Offset: 0x003187A8
		public int Quality
		{
			get
			{
				int num = this.__p.__offset(48);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700339D RID: 13213
		// (get) Token: 0x0600D0AE RID: 53422 RVA: 0x0031A5E8 File Offset: 0x003187E8
		public string Tag
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

		// Token: 0x0600D0AF RID: 53423 RVA: 0x0031A620 File Offset: 0x00318820
		public Span<byte> GetTagBytes()
		{
			return this.__p.__vector_as_span<byte>(50, 1);
		}

		// Token: 0x0600D0B0 RID: 53424 RVA: 0x0031A630 File Offset: 0x00318830
		public byte[] GetTagArray()
		{
			return this.__p.__vector_as_array<byte>(50) ?? Array.Empty<byte>();
		}

		// Token: 0x1700339E RID: 13214
		// (get) Token: 0x0600D0B1 RID: 53425 RVA: 0x0031A648 File Offset: 0x00318848
		public string RoleHeadIconCircle
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

		// Token: 0x0600D0B2 RID: 53426 RVA: 0x0031A680 File Offset: 0x00318880
		public Span<byte> GetRoleHeadIconCircleBytes()
		{
			return this.__p.__vector_as_span<byte>(52, 1);
		}

		// Token: 0x0600D0B3 RID: 53427 RVA: 0x0031A690 File Offset: 0x00318890
		public byte[] GetRoleHeadIconCircleArray()
		{
			return this.__p.__vector_as_array<byte>(52) ?? Array.Empty<byte>();
		}

		// Token: 0x1700339F RID: 13215
		// (get) Token: 0x0600D0B4 RID: 53428 RVA: 0x0031A6A8 File Offset: 0x003188A8
		public string RoleHeadIconLarge
		{
			get
			{
				int num = this.__p.__offset(54);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600D0B5 RID: 53429 RVA: 0x0031A6E0 File Offset: 0x003188E0
		public Span<byte> GetRoleHeadIconLargeBytes()
		{
			return this.__p.__vector_as_span<byte>(54, 1);
		}

		// Token: 0x0600D0B6 RID: 53430 RVA: 0x0031A6F0 File Offset: 0x003188F0
		public byte[] GetRoleHeadIconLargeArray()
		{
			return this.__p.__vector_as_array<byte>(54) ?? Array.Empty<byte>();
		}

		// Token: 0x170033A0 RID: 13216
		// (get) Token: 0x0600D0B7 RID: 53431 RVA: 0x0031A708 File Offset: 0x00318908
		public string RoleHeadIconBig
		{
			get
			{
				int num = this.__p.__offset(56);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600D0B8 RID: 53432 RVA: 0x0031A740 File Offset: 0x00318940
		public Span<byte> GetRoleHeadIconBigBytes()
		{
			return this.__p.__vector_as_span<byte>(56, 1);
		}

		// Token: 0x0600D0B9 RID: 53433 RVA: 0x0031A750 File Offset: 0x00318950
		public byte[] GetRoleHeadIconBigArray()
		{
			return this.__p.__vector_as_array<byte>(56) ?? Array.Empty<byte>();
		}

		// Token: 0x170033A1 RID: 13217
		// (get) Token: 0x0600D0BA RID: 53434 RVA: 0x0031A768 File Offset: 0x00318968
		public string Card
		{
			get
			{
				int num = this.__p.__offset(58);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600D0BB RID: 53435 RVA: 0x0031A7A0 File Offset: 0x003189A0
		public Span<byte> GetCardBytes()
		{
			return this.__p.__vector_as_span<byte>(58, 1);
		}

		// Token: 0x0600D0BC RID: 53436 RVA: 0x0031A7B0 File Offset: 0x003189B0
		public byte[] GetCardArray()
		{
			return this.__p.__vector_as_array<byte>(58) ?? Array.Empty<byte>();
		}

		// Token: 0x170033A2 RID: 13218
		// (get) Token: 0x0600D0BD RID: 53437 RVA: 0x0031A7C8 File Offset: 0x003189C8
		public string RoleHeadIcon
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

		// Token: 0x0600D0BE RID: 53438 RVA: 0x0031A800 File Offset: 0x00318A00
		public Span<byte> GetRoleHeadIconBytes()
		{
			return this.__p.__vector_as_span<byte>(60, 1);
		}

		// Token: 0x0600D0BF RID: 53439 RVA: 0x0031A810 File Offset: 0x00318A10
		public byte[] GetRoleHeadIconArray()
		{
			return this.__p.__vector_as_array<byte>(60) ?? Array.Empty<byte>();
		}

		// Token: 0x170033A3 RID: 13219
		// (get) Token: 0x0600D0C0 RID: 53440 RVA: 0x0031A828 File Offset: 0x00318A28
		public string PreviewRoleCard
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

		// Token: 0x0600D0C1 RID: 53441 RVA: 0x0031A860 File Offset: 0x00318A60
		public Span<byte> GetPreviewRoleCardBytes()
		{
			return this.__p.__vector_as_span<byte>(62, 1);
		}

		// Token: 0x0600D0C2 RID: 53442 RVA: 0x0031A870 File Offset: 0x00318A70
		public byte[] GetPreviewRoleCardArray()
		{
			return this.__p.__vector_as_array<byte>(62) ?? Array.Empty<byte>();
		}

		// Token: 0x170033A4 RID: 13220
		// (get) Token: 0x0600D0C3 RID: 53443 RVA: 0x0031A888 File Offset: 0x00318A88
		public string BuyShopPreviewRoleCard
		{
			get
			{
				int num = this.__p.__offset(64);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600D0C4 RID: 53444 RVA: 0x0031A8C0 File Offset: 0x00318AC0
		public Span<byte> GetBuyShopPreviewRoleCardBytes()
		{
			return this.__p.__vector_as_span<byte>(64, 1);
		}

		// Token: 0x0600D0C5 RID: 53445 RVA: 0x0031A8D0 File Offset: 0x00318AD0
		public byte[] GetBuyShopPreviewRoleCardArray()
		{
			return this.__p.__vector_as_array<byte>(64) ?? Array.Empty<byte>();
		}

		// Token: 0x170033A5 RID: 13221
		// (get) Token: 0x0600D0C6 RID: 53446 RVA: 0x0031A8E8 File Offset: 0x00318AE8
		public string FormationRoleCard
		{
			get
			{
				int num = this.__p.__offset(66);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600D0C7 RID: 53447 RVA: 0x0031A920 File Offset: 0x00318B20
		public Span<byte> GetFormationRoleCardBytes()
		{
			return this.__p.__vector_as_span<byte>(66, 1);
		}

		// Token: 0x0600D0C8 RID: 53448 RVA: 0x0031A930 File Offset: 0x00318B30
		public byte[] GetFormationRoleCardArray()
		{
			return this.__p.__vector_as_array<byte>(66) ?? Array.Empty<byte>();
		}

		// Token: 0x170033A6 RID: 13222
		// (get) Token: 0x0600D0C9 RID: 53449 RVA: 0x0031A948 File Offset: 0x00318B48
		public string RoleStand
		{
			get
			{
				int num = this.__p.__offset(68);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600D0CA RID: 53450 RVA: 0x0031A980 File Offset: 0x00318B80
		public Span<byte> GetRoleStandBytes()
		{
			return this.__p.__vector_as_span<byte>(68, 1);
		}

		// Token: 0x0600D0CB RID: 53451 RVA: 0x0031A990 File Offset: 0x00318B90
		public byte[] GetRoleStandArray()
		{
			return this.__p.__vector_as_array<byte>(68) ?? Array.Empty<byte>();
		}

		// Token: 0x170033A7 RID: 13223
		// (get) Token: 0x0600D0CC RID: 53452 RVA: 0x0031A9A8 File Offset: 0x00318BA8
		public string SuitWeaponSkinColor
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

		// Token: 0x0600D0CD RID: 53453 RVA: 0x0031A9E0 File Offset: 0x00318BE0
		public Span<byte> GetSuitWeaponSkinColorBytes()
		{
			return this.__p.__vector_as_span<byte>(70, 1);
		}

		// Token: 0x0600D0CE RID: 53454 RVA: 0x0031A9F0 File Offset: 0x00318BF0
		public byte[] GetSuitWeaponSkinColorArray()
		{
			return this.__p.__vector_as_array<byte>(70) ?? Array.Empty<byte>();
		}

		// Token: 0x170033A8 RID: 13224
		// (get) Token: 0x0600D0CF RID: 53455 RVA: 0x0031AA08 File Offset: 0x00318C08
		public string RoleObtainColor1
		{
			get
			{
				int num = this.__p.__offset(72);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600D0D0 RID: 53456 RVA: 0x0031AA40 File Offset: 0x00318C40
		public Span<byte> GetRoleObtainColor1Bytes()
		{
			return this.__p.__vector_as_span<byte>(72, 1);
		}

		// Token: 0x0600D0D1 RID: 53457 RVA: 0x0031AA50 File Offset: 0x00318C50
		public byte[] GetRoleObtainColor1Array()
		{
			return this.__p.__vector_as_array<byte>(72) ?? Array.Empty<byte>();
		}

		// Token: 0x170033A9 RID: 13225
		// (get) Token: 0x0600D0D2 RID: 53458 RVA: 0x0031AA68 File Offset: 0x00318C68
		public string RoleObtainColor2
		{
			get
			{
				int num = this.__p.__offset(74);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600D0D3 RID: 53459 RVA: 0x0031AAA0 File Offset: 0x00318CA0
		public Span<byte> GetRoleObtainColor2Bytes()
		{
			return this.__p.__vector_as_span<byte>(74, 1);
		}

		// Token: 0x0600D0D4 RID: 53460 RVA: 0x0031AAB0 File Offset: 0x00318CB0
		public byte[] GetRoleObtainColor2Array()
		{
			return this.__p.__vector_as_array<byte>(74) ?? Array.Empty<byte>();
		}

		// Token: 0x170033AA RID: 13226
		// (get) Token: 0x0600D0D5 RID: 53461 RVA: 0x0031AAC8 File Offset: 0x00318CC8
		public string RolePortrait
		{
			get
			{
				int num = this.__p.__offset(76);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600D0D6 RID: 53462 RVA: 0x0031AB00 File Offset: 0x00318D00
		public Span<byte> GetRolePortraitBytes()
		{
			return this.__p.__vector_as_span<byte>(76, 1);
		}

		// Token: 0x0600D0D7 RID: 53463 RVA: 0x0031AB10 File Offset: 0x00318D10
		public byte[] GetRolePortraitArray()
		{
			return this.__p.__vector_as_array<byte>(76) ?? Array.Empty<byte>();
		}

		// Token: 0x170033AB RID: 13227
		// (get) Token: 0x0600D0D8 RID: 53464 RVA: 0x0031AB28 File Offset: 0x00318D28
		public int MeshId
		{
			get
			{
				int num = this.__p.__offset(78);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170033AC RID: 13228
		// (get) Token: 0x0600D0D9 RID: 53465 RVA: 0x0031AB68 File Offset: 0x00318D68
		public int UiMeshId
		{
			get
			{
				int num = this.__p.__offset(80);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170033AD RID: 13229
		// (get) Token: 0x0600D0DA RID: 53466 RVA: 0x0031ABA8 File Offset: 0x00318DA8
		public string RoleBody
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

		// Token: 0x0600D0DB RID: 53467 RVA: 0x0031ABE0 File Offset: 0x00318DE0
		public Span<byte> GetRoleBodyBytes()
		{
			return this.__p.__vector_as_span<byte>(82, 1);
		}

		// Token: 0x0600D0DC RID: 53468 RVA: 0x0031ABF0 File Offset: 0x00318DF0
		public byte[] GetRoleBodyArray()
		{
			return this.__p.__vector_as_array<byte>(82) ?? Array.Empty<byte>();
		}

		// Token: 0x170033AE RID: 13230
		// (get) Token: 0x0600D0DD RID: 53469 RVA: 0x0031AC08 File Offset: 0x00318E08
		public string UiScenePerformanceABP
		{
			get
			{
				int num = this.__p.__offset(84);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600D0DE RID: 53470 RVA: 0x0031AC40 File Offset: 0x00318E40
		public Span<byte> GetUiScenePerformanceABPBytes()
		{
			return this.__p.__vector_as_span<byte>(84, 1);
		}

		// Token: 0x0600D0DF RID: 53471 RVA: 0x0031AC50 File Offset: 0x00318E50
		public byte[] GetUiScenePerformanceABPArray()
		{
			return this.__p.__vector_as_array<byte>(84) ?? Array.Empty<byte>();
		}

		// Token: 0x170033AF RID: 13231
		// (get) Token: 0x0600D0E0 RID: 53472 RVA: 0x0031AC68 File Offset: 0x00318E68
		public string UiTeamABP
		{
			get
			{
				int num = this.__p.__offset(86);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600D0E1 RID: 53473 RVA: 0x0031ACA0 File Offset: 0x00318EA0
		public Span<byte> GetUiTeamABPBytes()
		{
			return this.__p.__vector_as_span<byte>(86, 1);
		}

		// Token: 0x0600D0E2 RID: 53474 RVA: 0x0031ACB0 File Offset: 0x00318EB0
		public byte[] GetUiTeamABPArray()
		{
			return this.__p.__vector_as_array<byte>(86) ?? Array.Empty<byte>();
		}

		// Token: 0x170033B0 RID: 13232
		// (get) Token: 0x0600D0E3 RID: 53475 RVA: 0x0031ACC8 File Offset: 0x00318EC8
		public string FootStepState
		{
			get
			{
				int num = this.__p.__offset(88);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600D0E4 RID: 53476 RVA: 0x0031AD00 File Offset: 0x00318F00
		public Span<byte> GetFootStepStateBytes()
		{
			return this.__p.__vector_as_span<byte>(88, 1);
		}

		// Token: 0x0600D0E5 RID: 53477 RVA: 0x0031AD10 File Offset: 0x00318F10
		public byte[] GetFootStepStateArray()
		{
			return this.__p.__vector_as_array<byte>(88) ?? Array.Empty<byte>();
		}

		// Token: 0x170033B1 RID: 13233
		// (get) Token: 0x0600D0E6 RID: 53478 RVA: 0x0031AD28 File Offset: 0x00318F28
		public string PayShopPreviewRoleTexturePath
		{
			get
			{
				int num = this.__p.__offset(90);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600D0E7 RID: 53479 RVA: 0x0031AD60 File Offset: 0x00318F60
		public Span<byte> GetPayShopPreviewRoleTexturePathBytes()
		{
			return this.__p.__vector_as_span<byte>(90, 1);
		}

		// Token: 0x0600D0E8 RID: 53480 RVA: 0x0031AD70 File Offset: 0x00318F70
		public byte[] GetPayShopPreviewRoleTexturePathArray()
		{
			return this.__p.__vector_as_array<byte>(90) ?? Array.Empty<byte>();
		}

		// Token: 0x170033B2 RID: 13234
		// (get) Token: 0x0600D0E9 RID: 53481 RVA: 0x0031AD88 File Offset: 0x00318F88
		public string PayShopPreviewRoleTextureBgPath
		{
			get
			{
				int num = this.__p.__offset(92);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600D0EA RID: 53482 RVA: 0x0031ADC0 File Offset: 0x00318FC0
		public Span<byte> GetPayShopPreviewRoleTextureBgPathBytes()
		{
			return this.__p.__vector_as_span<byte>(92, 1);
		}

		// Token: 0x0600D0EB RID: 53483 RVA: 0x0031ADD0 File Offset: 0x00318FD0
		public byte[] GetPayShopPreviewRoleTextureBgPathArray()
		{
			return this.__p.__vector_as_array<byte>(92) ?? Array.Empty<byte>();
		}

		// Token: 0x170033B3 RID: 13235
		// (get) Token: 0x0600D0EC RID: 53484 RVA: 0x0031ADE8 File Offset: 0x00318FE8
		public string PayShopPreviewWeaponTexturePath
		{
			get
			{
				int num = this.__p.__offset(94);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600D0ED RID: 53485 RVA: 0x0031AE20 File Offset: 0x00319020
		public Span<byte> GetPayShopPreviewWeaponTexturePathBytes()
		{
			return this.__p.__vector_as_span<byte>(94, 1);
		}

		// Token: 0x0600D0EE RID: 53486 RVA: 0x0031AE30 File Offset: 0x00319030
		public byte[] GetPayShopPreviewWeaponTexturePathArray()
		{
			return this.__p.__vector_as_array<byte>(94) ?? Array.Empty<byte>();
		}

		// Token: 0x170033B4 RID: 13236
		// (get) Token: 0x0600D0EF RID: 53487 RVA: 0x0031AE48 File Offset: 0x00319048
		public string PayShopPreviewBuyRoleTexturePath
		{
			get
			{
				int num = this.__p.__offset(96);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600D0F0 RID: 53488 RVA: 0x0031AE80 File Offset: 0x00319080
		public Span<byte> GetPayShopPreviewBuyRoleTexturePathBytes()
		{
			return this.__p.__vector_as_span<byte>(96, 1);
		}

		// Token: 0x0600D0F1 RID: 53489 RVA: 0x0031AE90 File Offset: 0x00319090
		public byte[] GetPayShopPreviewBuyRoleTexturePathArray()
		{
			return this.__p.__vector_as_array<byte>(96) ?? Array.Empty<byte>();
		}

		// Token: 0x170033B5 RID: 13237
		// (get) Token: 0x0600D0F2 RID: 53490 RVA: 0x0031AEA8 File Offset: 0x003190A8
		public string PayShopPreviewBuyRoleSuitWeaponTexturePath
		{
			get
			{
				int num = this.__p.__offset(98);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600D0F3 RID: 53491 RVA: 0x0031AEE0 File Offset: 0x003190E0
		public Span<byte> GetPayShopPreviewBuyRoleSuitWeaponTexturePathBytes()
		{
			return this.__p.__vector_as_span<byte>(98, 1);
		}

		// Token: 0x0600D0F4 RID: 53492 RVA: 0x0031AEF0 File Offset: 0x003190F0
		public byte[] GetPayShopPreviewBuyRoleSuitWeaponTexturePathArray()
		{
			return this.__p.__vector_as_array<byte>(98) ?? Array.Empty<byte>();
		}

		// Token: 0x170033B6 RID: 13238
		// (get) Token: 0x0600D0F5 RID: 53493 RVA: 0x0031AF08 File Offset: 0x00319108
		public string ShareTexturePath
		{
			get
			{
				int num = this.__p.__offset(100);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600D0F6 RID: 53494 RVA: 0x0031AF40 File Offset: 0x00319140
		public Span<byte> GetShareTexturePathBytes()
		{
			return this.__p.__vector_as_span<byte>(100, 1);
		}

		// Token: 0x0600D0F7 RID: 53495 RVA: 0x0031AF50 File Offset: 0x00319150
		public byte[] GetShareTexturePathArray()
		{
			return this.__p.__vector_as_array<byte>(100) ?? Array.Empty<byte>();
		}

		// Token: 0x170033B7 RID: 13239
		// (get) Token: 0x0600D0F8 RID: 53496 RVA: 0x0031AF68 File Offset: 0x00319168
		public string SpineSkeletonData
		{
			get
			{
				int num = this.__p.__offset(102);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600D0F9 RID: 53497 RVA: 0x0031AFA0 File Offset: 0x003191A0
		public Span<byte> GetSpineSkeletonDataBytes()
		{
			return this.__p.__vector_as_span<byte>(102, 1);
		}

		// Token: 0x0600D0FA RID: 53498 RVA: 0x0031AFB0 File Offset: 0x003191B0
		public byte[] GetSpineSkeletonDataArray()
		{
			return this.__p.__vector_as_array<byte>(102) ?? Array.Empty<byte>();
		}

		// Token: 0x170033B8 RID: 13240
		// (get) Token: 0x0600D0FB RID: 53499 RVA: 0x0031AFC8 File Offset: 0x003191C8
		public string SmallSpineAtlas
		{
			get
			{
				int num = this.__p.__offset(104);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600D0FC RID: 53500 RVA: 0x0031B000 File Offset: 0x00319200
		public Span<byte> GetSmallSpineAtlasBytes()
		{
			return this.__p.__vector_as_span<byte>(104, 1);
		}

		// Token: 0x0600D0FD RID: 53501 RVA: 0x0031B010 File Offset: 0x00319210
		public byte[] GetSmallSpineAtlasArray()
		{
			return this.__p.__vector_as_array<byte>(104) ?? Array.Empty<byte>();
		}

		// Token: 0x0600D0FE RID: 53502 RVA: 0x0031B028 File Offset: 0x00319228
		public long SkinBuff(int j)
		{
			int num = this.__p.__offset(106);
			return (long)((num != 0) ? this.__p.bb.GetDouble(this.__p.__vector(num) + j * 8) : 0.0);
		}

		// Token: 0x170033B9 RID: 13241
		// (get) Token: 0x0600D0FF RID: 53503 RVA: 0x0031B074 File Offset: 0x00319274
		public int SkinBuffLength
		{
			get
			{
				int num = this.__p.__offset(106);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600D100 RID: 53504 RVA: 0x0031B0A0 File Offset: 0x003192A0
		public Span<long> GetSkinBuffBytes()
		{
			return MemoryMarshal.Cast<double, long>(this.__p.__vector_as_span<double>(106, 8));
		}

		// Token: 0x0600D101 RID: 53505 RVA: 0x0031B0B5 File Offset: 0x003192B5
		public long[] GetSkinBuffArray()
		{
			return Array.ConvertAll<double, long>(this.__p.__vector_as_array<double>(106) ?? Array.Empty<double>(), (double x) => (long)x);
		}

		// Token: 0x170033BA RID: 13242
		// (get) Token: 0x0600D102 RID: 53506 RVA: 0x0031B0F4 File Offset: 0x003192F4
		public string FormationSpineSkeletonData
		{
			get
			{
				int num = this.__p.__offset(108);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600D103 RID: 53507 RVA: 0x0031B12C File Offset: 0x0031932C
		public Span<byte> GetFormationSpineSkeletonDataBytes()
		{
			return this.__p.__vector_as_span<byte>(108, 1);
		}

		// Token: 0x0600D104 RID: 53508 RVA: 0x0031B13C File Offset: 0x0031933C
		public byte[] GetFormationSpineSkeletonDataArray()
		{
			return this.__p.__vector_as_array<byte>(108) ?? Array.Empty<byte>();
		}

		// Token: 0x170033BB RID: 13243
		// (get) Token: 0x0600D105 RID: 53509 RVA: 0x0031B154 File Offset: 0x00319354
		public string FormationSpineAtlas
		{
			get
			{
				int num = this.__p.__offset(110);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600D106 RID: 53510 RVA: 0x0031B18C File Offset: 0x0031938C
		public Span<byte> GetFormationSpineAtlasBytes()
		{
			return this.__p.__vector_as_span<byte>(110, 1);
		}

		// Token: 0x0600D107 RID: 53511 RVA: 0x0031B19C File Offset: 0x0031939C
		public byte[] GetFormationSpineAtlasArray()
		{
			return this.__p.__vector_as_array<byte>(110) ?? Array.Empty<byte>();
		}

		// Token: 0x0600D108 RID: 53512 RVA: 0x0031B1B4 File Offset: 0x003193B4
		public float SpineParam(int j)
		{
			int num = this.__p.__offset(112);
			if (num == 0)
			{
				return 0f;
			}
			return this.__p.bb.GetFloat(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170033BC RID: 13244
		// (get) Token: 0x0600D109 RID: 53513 RVA: 0x0031B1F8 File Offset: 0x003193F8
		public int SpineParamLength
		{
			get
			{
				int num = this.__p.__offset(112);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600D10A RID: 53514 RVA: 0x0031B224 File Offset: 0x00319424
		public Span<float> GetSpineParamBytes()
		{
			return this.__p.__vector_as_span<float>(112, 4);
		}

		// Token: 0x0600D10B RID: 53515 RVA: 0x0031B234 File Offset: 0x00319434
		public float[] GetSpineParamArray()
		{
			return this.__p.__vector_as_array<float>(112) ?? Array.Empty<float>();
		}

		// Token: 0x170033BD RID: 13245
		// (get) Token: 0x0600D10C RID: 53516 RVA: 0x0031B24C File Offset: 0x0031944C
		public Vector? FormationOffset
		{
			get
			{
				int num = this.__p.__offset(114);
				if (num == 0)
				{
					return null;
				}
				return new Vector?(default(Vector).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x0600D10D RID: 53517 RVA: 0x0031B2AC File Offset: 0x003194AC
		public DicStringString? UiCameraSettingOverrides(int j)
		{
			int num = this.__p.__offset(116);
			if (num == 0)
			{
				return null;
			}
			return new DicStringString?(default(DicStringString).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170033BE RID: 13246
		// (get) Token: 0x0600D10E RID: 53518 RVA: 0x0031B310 File Offset: 0x00319510
		public int UiCameraSettingOverridesLength
		{
			get
			{
				int num = this.__p.__offset(116);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600D10F RID: 53519 RVA: 0x0031B33C File Offset: 0x0031953C
		public string UiModelEquipTags(int j)
		{
			int num = this.__p.__offset(118);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170033BF RID: 13247
		// (get) Token: 0x0600D110 RID: 53520 RVA: 0x0031B378 File Offset: 0x00319578
		public int UiModelEquipTagsLength
		{
			get
			{
				int num = this.__p.__offset(118);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600D111 RID: 53521 RVA: 0x0031B3A4 File Offset: 0x003195A4
		public int SpinePreviewBoundary(int j)
		{
			int num = this.__p.__offset(120);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170033C0 RID: 13248
		// (get) Token: 0x0600D112 RID: 53522 RVA: 0x0031B3E4 File Offset: 0x003195E4
		public int SpinePreviewBoundaryLength
		{
			get
			{
				int num = this.__p.__offset(120);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600D113 RID: 53523 RVA: 0x0031B410 File Offset: 0x00319610
		public Span<int> GetSpinePreviewBoundaryBytes()
		{
			return this.__p.__vector_as_span<int>(120, 4);
		}

		// Token: 0x0600D114 RID: 53524 RVA: 0x0031B420 File Offset: 0x00319620
		public int[] GetSpinePreviewBoundaryArray()
		{
			return this.__p.__vector_as_array<int>(120) ?? Array.Empty<int>();
		}

		// Token: 0x0600D115 RID: 53525 RVA: 0x0031B438 File Offset: 0x00319638
		public bool TryGetMember(string key, out string value)
		{
			if (key != null)
			{
				int length = key.Length;
				switch (length)
				{
				case 3:
					if (key == "Tag")
					{
						value = this.Tag;
						return true;
					}
					break;
				case 4:
				{
					char c = key[0];
					if (c != 'C')
					{
						if (c != 'I')
						{
							if (c == 'N')
							{
								if (key == "Name")
								{
									value = this.Name;
									return true;
								}
							}
						}
						else if (key == "Icon")
						{
							value = this.Icon;
							return true;
						}
					}
					else if (key == "Card")
					{
						value = this.Card;
						return true;
					}
					break;
				}
				case 5:
				case 6:
				case 7:
				case 11:
				case 14:
				case 20:
				case 24:
				case 25:
				case 27:
				case 28:
				case 30:
					break;
				case 8:
					if (key == "RoleBody")
					{
						value = this.RoleBody;
						return true;
					}
					break;
				case 9:
				{
					char c = key[0];
					if (c != 'I')
					{
						switch (c)
						{
						case 'R':
							if (key == "RoleStand")
							{
								value = this.RoleStand;
								return true;
							}
							break;
						case 'T':
							if (key == "TitleName")
							{
								value = this.TitleName;
								return true;
							}
							break;
						case 'U':
							if (key == "UiTeamABP")
							{
								value = this.UiTeamABP;
								return true;
							}
							break;
						}
					}
					else if (key == "IconSmall")
					{
						value = this.IconSmall;
						return true;
					}
					break;
				}
				case 10:
				{
					char c = key[0];
					if (c != 'I')
					{
						if (c == 'S')
						{
							if (key == "SubDecName")
							{
								value = this.SubDecName;
								return true;
							}
						}
					}
					else if (key == "IconMiddle")
					{
						value = this.IconMiddle;
						return true;
					}
					break;
				}
				case 12:
				{
					char c = key[4];
					if (c != 'H')
					{
						if (c != 'P')
						{
							if (c == 't')
							{
								if (key == "FunctionDesc")
								{
									value = this.FunctionDesc;
									return true;
								}
							}
						}
						else if (key == "RolePortrait")
						{
							value = this.RolePortrait;
							return true;
						}
					}
					else if (key == "RoleHeadIcon")
					{
						value = this.RoleHeadIcon;
						return true;
					}
					break;
				}
				case 13:
				{
					char c = key[0];
					if (c != 'B')
					{
						if (c == 'F')
						{
							if (key == "FootStepState")
							{
								value = this.FootStepState;
								return true;
							}
						}
					}
					else if (key == "BgDescription")
					{
						value = this.BgDescription;
						return true;
					}
					break;
				}
				case 15:
				{
					char c = key[0];
					if (c != 'F')
					{
						switch (c)
						{
						case 'P':
							if (key == "PreviewRoleCard")
							{
								value = this.PreviewRoleCard;
								return true;
							}
							break;
						case 'R':
							if (key == "RoleHeadIconBig")
							{
								value = this.RoleHeadIconBig;
								return true;
							}
							break;
						case 'S':
							if (key == "SmallSpineAtlas")
							{
								value = this.SmallSpineAtlas;
								return true;
							}
							break;
						case 'T':
							if (key == "TypeDescription")
							{
								value = this.TypeDescription;
								return true;
							}
							break;
						}
					}
					else if (key == "FirstObtainDesc")
					{
						value = this.FirstObtainDesc;
						return true;
					}
					break;
				}
				case 16:
				{
					char c = key[15];
					if (c != '1')
					{
						if (c != '2')
						{
							if (c == 'h')
							{
								if (key == "ShareTexturePath")
								{
									value = this.ShareTexturePath;
									return true;
								}
							}
						}
						else if (key == "RoleObtainColor2")
						{
							value = this.RoleObtainColor2;
							return true;
						}
					}
					else if (key == "RoleObtainColor1")
					{
						value = this.RoleObtainColor1;
						return true;
					}
					break;
				}
				case 17:
				{
					char c = key[0];
					if (c != 'F')
					{
						if (c != 'R')
						{
							if (c == 'S')
							{
								if (key == "SpineSkeletonData")
								{
									value = this.SpineSkeletonData;
									return true;
								}
							}
						}
						else if (key == "RoleHeadIconLarge")
						{
							value = this.RoleHeadIconLarge;
							return true;
						}
					}
					else if (key == "FormationRoleCard")
					{
						value = this.FormationRoleCard;
						return true;
					}
					break;
				}
				case 18:
					if (key == "RoleHeadIconCircle")
					{
						value = this.RoleHeadIconCircle;
						return true;
					}
					break;
				case 19:
				{
					char c = key[0];
					if (c != 'F')
					{
						if (c == 'S')
						{
							if (key == "SuitWeaponSkinColor")
							{
								value = this.SuitWeaponSkinColor;
								return true;
							}
						}
					}
					else if (key == "FormationSpineAtlas")
					{
						value = this.FormationSpineAtlas;
						return true;
					}
					break;
				}
				case 21:
				{
					char c = key[0];
					if (c != 'A')
					{
						if (c == 'U')
						{
							if (key == "UiScenePerformanceABP")
							{
								value = this.UiScenePerformanceABP;
								return true;
							}
						}
					}
					else if (key == "AttributesDescription")
					{
						value = this.AttributesDescription;
						return true;
					}
					break;
				}
				case 22:
					if (key == "BuyShopPreviewRoleCard")
					{
						value = this.BuyShopPreviewRoleCard;
						return true;
					}
					break;
				case 23:
					if (key == "ObtainedShowDescription")
					{
						value = this.ObtainedShowDescription;
						return true;
					}
					break;
				case 26:
					if (key == "FormationSpineSkeletonData")
					{
						value = this.FormationSpineSkeletonData;
						return true;
					}
					break;
				case 29:
					if (key == "PayShopPreviewRoleTexturePath")
					{
						value = this.PayShopPreviewRoleTexturePath;
						return true;
					}
					break;
				case 31:
				{
					char c = key[14];
					if (c != 'R')
					{
						if (c == 'W')
						{
							if (key == "PayShopPreviewWeaponTexturePath")
							{
								value = this.PayShopPreviewWeaponTexturePath;
								return true;
							}
						}
					}
					else if (key == "PayShopPreviewRoleTextureBgPath")
					{
						value = this.PayShopPreviewRoleTextureBgPath;
						return true;
					}
					break;
				}
				case 32:
					if (key == "PayShopPreviewBuyRoleTexturePath")
					{
						value = this.PayShopPreviewBuyRoleTexturePath;
						return true;
					}
					break;
				default:
					if (length == 42)
					{
						if (key == "PayShopPreviewBuyRoleSuitWeaponTexturePath")
						{
							value = this.PayShopPreviewBuyRoleSuitWeaponTexturePath;
							return true;
						}
					}
					break;
				}
			}
			value = null;
			return false;
		}

		// Token: 0x0600D116 RID: 53526 RVA: 0x0031BB42 File Offset: 0x00319D42
		[NullableContext(1)]
		public int[] ItemAccess()
		{
			return this.GetItemAccessArray();
		}

		// Token: 0x0600D117 RID: 53527 RVA: 0x0031BB4A File Offset: 0x00319D4A
		[NullableContext(1)]
		public IEnumerable<int> ItemAccessIter()
		{
			RoleSkin.<ItemAccessIter>d__222 <ItemAccessIter>d__ = new RoleSkin.<ItemAccessIter>d__222(-2);
			<ItemAccessIter>d__.<>3__<>4__this = this;
			return <ItemAccessIter>d__;
		}

		// Token: 0x0600D118 RID: 53528 RVA: 0x0031BB5F File Offset: 0x00319D5F
		[NullableContext(1)]
		public long[] SkinBuff()
		{
			return this.GetSkinBuffArray();
		}

		// Token: 0x0600D119 RID: 53529 RVA: 0x0031BB67 File Offset: 0x00319D67
		[NullableContext(1)]
		public IEnumerable<long> SkinBuffIter()
		{
			RoleSkin.<SkinBuffIter>d__224 <SkinBuffIter>d__ = new RoleSkin.<SkinBuffIter>d__224(-2);
			<SkinBuffIter>d__.<>3__<>4__this = this;
			return <SkinBuffIter>d__;
		}

		// Token: 0x0600D11A RID: 53530 RVA: 0x0031BB7C File Offset: 0x00319D7C
		[NullableContext(1)]
		public float[] SpineParam()
		{
			return this.GetSpineParamArray();
		}

		// Token: 0x0600D11B RID: 53531 RVA: 0x0031BB84 File Offset: 0x00319D84
		[NullableContext(1)]
		public IEnumerable<float> SpineParamIter()
		{
			RoleSkin.<SpineParamIter>d__226 <SpineParamIter>d__ = new RoleSkin.<SpineParamIter>d__226(-2);
			<SpineParamIter>d__.<>3__<>4__this = this;
			return <SpineParamIter>d__;
		}

		// Token: 0x0600D11C RID: 53532 RVA: 0x0031BB99 File Offset: 0x00319D99
		[NullableContext(1)]
		public int[] SpinePreviewBoundary()
		{
			return this.GetSpinePreviewBoundaryArray();
		}

		// Token: 0x0600D11D RID: 53533 RVA: 0x0031BBA1 File Offset: 0x00319DA1
		[NullableContext(1)]
		public IEnumerable<int> SpinePreviewBoundaryIter()
		{
			RoleSkin.<SpinePreviewBoundaryIter>d__228 <SpinePreviewBoundaryIter>d__ = new RoleSkin.<SpinePreviewBoundaryIter>d__228(-2);
			<SpinePreviewBoundaryIter>d__.<>3__<>4__this = this;
			return <SpinePreviewBoundaryIter>d__;
		}

		// Token: 0x0600D11E RID: 53534 RVA: 0x0031BBB8 File Offset: 0x00319DB8
		[NullableContext(1)]
		public Dictionary<string, string> UiCameraSettingOverrides()
		{
			return this.UiCameraSettingOverridesIter().ToDictionary((DicStringString element) => element.Key, (DicStringString element) => element.Value);
		}

		// Token: 0x0600D11F RID: 53535 RVA: 0x0031BC0E File Offset: 0x00319E0E
		[NullableContext(1)]
		public IEnumerable<DicStringString> UiCameraSettingOverridesIter()
		{
			RoleSkin.<UiCameraSettingOverridesIter>d__230 <UiCameraSettingOverridesIter>d__ = new RoleSkin.<UiCameraSettingOverridesIter>d__230(-2);
			<UiCameraSettingOverridesIter>d__.<>3__<>4__this = this;
			return <UiCameraSettingOverridesIter>d__;
		}

		// Token: 0x0600D120 RID: 53536 RVA: 0x0031BC23 File Offset: 0x00319E23
		[NullableContext(1)]
		public string[] UiModelEquipTags()
		{
			return this.UiModelEquipTagsIter().ToArray<string>();
		}

		// Token: 0x0600D121 RID: 53537 RVA: 0x0031BC30 File Offset: 0x00319E30
		[NullableContext(1)]
		public IEnumerable<string> UiModelEquipTagsIter()
		{
			RoleSkin.<UiModelEquipTagsIter>d__232 <UiModelEquipTagsIter>d__ = new RoleSkin.<UiModelEquipTagsIter>d__232(-2);
			<UiModelEquipTagsIter>d__.<>3__<>4__this = this;
			return <UiModelEquipTagsIter>d__;
		}

		// Token: 0x0600D122 RID: 53538 RVA: 0x0031BC48 File Offset: 0x00319E48
		[NullableContext(1)]
		[return: Nullable(2)]
		public string GetUiCameraSettingOverrides(string key)
		{
			this.EnsureUiCameraSettingOverridesCacheIfNeeded();
			string result;
			if (!this.UiCameraSettingOverridesCache.TryGetValue(key, out result))
			{
				return null;
			}
			return result;
		}

		// Token: 0x0600D123 RID: 53539 RVA: 0x0031BC70 File Offset: 0x00319E70
		private void EnsureUiCameraSettingOverridesCacheIfNeeded()
		{
			if (this.UiCameraSettingOverridesCache != null)
			{
				return;
			}
			this.UiCameraSettingOverridesCache = this.UiCameraSettingOverridesIter().ToFrozenDictionary((DicStringString kvp) => kvp.Key, (DicStringString kvp) => kvp.Value, null);
		}

		// Token: 0x0600D124 RID: 53540 RVA: 0x0031BCD6 File Offset: 0x00319ED6
		[NullableContext(1)]
		public FrozenDictionary<string, string> GetUiCameraSettingOverridesFrozenDict()
		{
			this.EnsureUiCameraSettingOverridesCacheIfNeeded();
			return this.UiCameraSettingOverridesCache;
		}

		// Token: 0x04005745 RID: 22341
		private Table __p;

		// Token: 0x04005746 RID: 22342
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private FrozenDictionary<string, string> UiCameraSettingOverridesCache;
	}
}
