using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000BCF RID: 3023
	public struct DangoBrawlRole : IFlatbufferObject
	{
		// Token: 0x17000B72 RID: 2930
		// (get) Token: 0x06005F16 RID: 24342 RVA: 0x0020C8D5 File Offset: 0x0020AAD5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06005F17 RID: 24343 RVA: 0x0020C8E2 File Offset: 0x0020AAE2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06005F18 RID: 24344 RVA: 0x0020C8EC File Offset: 0x0020AAEC
		public static DangoBrawlRole GetRootAsDangoBrawlRole(ByteBuffer _bb)
		{
			return DangoBrawlRole.GetRootAsDangoBrawlRole(_bb, default(DangoBrawlRole));
		}

		// Token: 0x06005F19 RID: 24345 RVA: 0x0020C908 File Offset: 0x0020AB08
		public static DangoBrawlRole GetRootAsDangoBrawlRole(ByteBuffer _bb, DangoBrawlRole obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06005F1A RID: 24346 RVA: 0x0020C925 File Offset: 0x0020AB25
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06005F1B RID: 24347 RVA: 0x0020C934 File Offset: 0x0020AB34
		public DangoBrawlRole __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000B73 RID: 2931
		// (get) Token: 0x06005F1C RID: 24348 RVA: 0x0020C944 File Offset: 0x0020AB44
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

		// Token: 0x17000B74 RID: 2932
		// (get) Token: 0x06005F1D RID: 24349 RVA: 0x0020C980 File Offset: 0x0020AB80
		public int ActivityId
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

		// Token: 0x17000B75 RID: 2933
		// (get) Token: 0x06005F1E RID: 24350 RVA: 0x0020C9BC File Offset: 0x0020ABBC
		public int OccupationId
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

		// Token: 0x17000B76 RID: 2934
		// (get) Token: 0x06005F1F RID: 24351 RVA: 0x0020C9F8 File Offset: 0x0020ABF8
		public int WobblePlateId
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

		// Token: 0x17000B77 RID: 2935
		// (get) Token: 0x06005F20 RID: 24352 RVA: 0x0020CA38 File Offset: 0x0020AC38
		public bool NoSpeItemLimit
		{
			get
			{
				int num = this.__p.__offset(12);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17000B78 RID: 2936
		// (get) Token: 0x06005F21 RID: 24353 RVA: 0x0020CA78 File Offset: 0x0020AC78
		public int Gender
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

		// Token: 0x17000B79 RID: 2937
		// (get) Token: 0x06005F22 RID: 24354 RVA: 0x0020CAB8 File Offset: 0x0020ACB8
		public int SortIndex
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

		// Token: 0x17000B7A RID: 2938
		// (get) Token: 0x06005F23 RID: 24355 RVA: 0x0020CAF8 File Offset: 0x0020ACF8
		public string Name
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

		// Token: 0x06005F24 RID: 24356 RVA: 0x0020CB30 File Offset: 0x0020AD30
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x06005F25 RID: 24357 RVA: 0x0020CB40 File Offset: 0x0020AD40
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x17000B7B RID: 2939
		// (get) Token: 0x06005F26 RID: 24358 RVA: 0x0020CB58 File Offset: 0x0020AD58
		public string Desc
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

		// Token: 0x06005F27 RID: 24359 RVA: 0x0020CB90 File Offset: 0x0020AD90
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x06005F28 RID: 24360 RVA: 0x0020CBA0 File Offset: 0x0020ADA0
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x17000B7C RID: 2940
		// (get) Token: 0x06005F29 RID: 24361 RVA: 0x0020CBB8 File Offset: 0x0020ADB8
		public string UnlockCondDesc
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

		// Token: 0x06005F2A RID: 24362 RVA: 0x0020CBF0 File Offset: 0x0020ADF0
		public Span<byte> GetUnlockCondDescBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x06005F2B RID: 24363 RVA: 0x0020CC00 File Offset: 0x0020AE00
		public byte[] GetUnlockCondDescArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x17000B7D RID: 2941
		// (get) Token: 0x06005F2C RID: 24364 RVA: 0x0020CC18 File Offset: 0x0020AE18
		public string RoleIcon
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

		// Token: 0x06005F2D RID: 24365 RVA: 0x0020CC50 File Offset: 0x0020AE50
		public Span<byte> GetRoleIconBytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x06005F2E RID: 24366 RVA: 0x0020CC60 File Offset: 0x0020AE60
		public byte[] GetRoleIconArray()
		{
			return this.__p.__vector_as_array<byte>(24) ?? Array.Empty<byte>();
		}

		// Token: 0x17000B7E RID: 2942
		// (get) Token: 0x06005F2F RID: 24367 RVA: 0x0020CC78 File Offset: 0x0020AE78
		public string RoleHoldIcon
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

		// Token: 0x06005F30 RID: 24368 RVA: 0x0020CCB0 File Offset: 0x0020AEB0
		public Span<byte> GetRoleHoldIconBytes()
		{
			return this.__p.__vector_as_span<byte>(26, 1);
		}

		// Token: 0x06005F31 RID: 24369 RVA: 0x0020CCC0 File Offset: 0x0020AEC0
		public byte[] GetRoleHoldIconArray()
		{
			return this.__p.__vector_as_array<byte>(26) ?? Array.Empty<byte>();
		}

		// Token: 0x17000B7F RID: 2943
		// (get) Token: 0x06005F32 RID: 24370 RVA: 0x0020CCD8 File Offset: 0x0020AED8
		public string RoleSelIcon
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

		// Token: 0x06005F33 RID: 24371 RVA: 0x0020CD10 File Offset: 0x0020AF10
		public Span<byte> GetRoleSelIconBytes()
		{
			return this.__p.__vector_as_span<byte>(28, 1);
		}

		// Token: 0x06005F34 RID: 24372 RVA: 0x0020CD20 File Offset: 0x0020AF20
		public byte[] GetRoleSelIconArray()
		{
			return this.__p.__vector_as_array<byte>(28) ?? Array.Empty<byte>();
		}

		// Token: 0x17000B80 RID: 2944
		// (get) Token: 0x06005F35 RID: 24373 RVA: 0x0020CD38 File Offset: 0x0020AF38
		public string RoleBigIcon
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

		// Token: 0x06005F36 RID: 24374 RVA: 0x0020CD70 File Offset: 0x0020AF70
		public Span<byte> GetRoleBigIconBytes()
		{
			return this.__p.__vector_as_span<byte>(30, 1);
		}

		// Token: 0x06005F37 RID: 24375 RVA: 0x0020CD80 File Offset: 0x0020AF80
		public byte[] GetRoleBigIconArray()
		{
			return this.__p.__vector_as_array<byte>(30) ?? Array.Empty<byte>();
		}

		// Token: 0x17000B81 RID: 2945
		// (get) Token: 0x06005F38 RID: 24376 RVA: 0x0020CD98 File Offset: 0x0020AF98
		public string RoleBuffIcon
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

		// Token: 0x06005F39 RID: 24377 RVA: 0x0020CDD0 File Offset: 0x0020AFD0
		public Span<byte> GetRoleBuffIconBytes()
		{
			return this.__p.__vector_as_span<byte>(32, 1);
		}

		// Token: 0x06005F3A RID: 24378 RVA: 0x0020CDE0 File Offset: 0x0020AFE0
		public byte[] GetRoleBuffIconArray()
		{
			return this.__p.__vector_as_array<byte>(32) ?? Array.Empty<byte>();
		}

		// Token: 0x17000B82 RID: 2946
		// (get) Token: 0x06005F3B RID: 24379 RVA: 0x0020CDF8 File Offset: 0x0020AFF8
		public string RoleUnlockIcon
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

		// Token: 0x06005F3C RID: 24380 RVA: 0x0020CE30 File Offset: 0x0020B030
		public Span<byte> GetRoleUnlockIconBytes()
		{
			return this.__p.__vector_as_span<byte>(34, 1);
		}

		// Token: 0x06005F3D RID: 24381 RVA: 0x0020CE40 File Offset: 0x0020B040
		public byte[] GetRoleUnlockIconArray()
		{
			return this.__p.__vector_as_array<byte>(34) ?? Array.Empty<byte>();
		}

		// Token: 0x17000B83 RID: 2947
		// (get) Token: 0x06005F3E RID: 24382 RVA: 0x0020CE58 File Offset: 0x0020B058
		public string BagIcon
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

		// Token: 0x06005F3F RID: 24383 RVA: 0x0020CE90 File Offset: 0x0020B090
		public Span<byte> GetBagIconBytes()
		{
			return this.__p.__vector_as_span<byte>(36, 1);
		}

		// Token: 0x06005F40 RID: 24384 RVA: 0x0020CEA0 File Offset: 0x0020B0A0
		public byte[] GetBagIconArray()
		{
			return this.__p.__vector_as_array<byte>(36) ?? Array.Empty<byte>();
		}

		// Token: 0x17000B84 RID: 2948
		// (get) Token: 0x06005F41 RID: 24385 RVA: 0x0020CEB8 File Offset: 0x0020B0B8
		public string Icon
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

		// Token: 0x06005F42 RID: 24386 RVA: 0x0020CEF0 File Offset: 0x0020B0F0
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(38, 1);
		}

		// Token: 0x06005F43 RID: 24387 RVA: 0x0020CF00 File Offset: 0x0020B100
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(38) ?? Array.Empty<byte>();
		}

		// Token: 0x17000B85 RID: 2949
		// (get) Token: 0x06005F44 RID: 24388 RVA: 0x0020CF18 File Offset: 0x0020B118
		public string LogIcon
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

		// Token: 0x06005F45 RID: 24389 RVA: 0x0020CF50 File Offset: 0x0020B150
		public Span<byte> GetLogIconBytes()
		{
			return this.__p.__vector_as_span<byte>(40, 1);
		}

		// Token: 0x06005F46 RID: 24390 RVA: 0x0020CF60 File Offset: 0x0020B160
		public byte[] GetLogIconArray()
		{
			return this.__p.__vector_as_array<byte>(40) ?? Array.Empty<byte>();
		}

		// Token: 0x17000B86 RID: 2950
		// (get) Token: 0x06005F47 RID: 24391 RVA: 0x0020CF78 File Offset: 0x0020B178
		public int QualityId
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

		// Token: 0x17000B87 RID: 2951
		// (get) Token: 0x06005F48 RID: 24392 RVA: 0x0020CFB8 File Offset: 0x0020B1B8
		public string AttributesDescription
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

		// Token: 0x06005F49 RID: 24393 RVA: 0x0020CFF0 File Offset: 0x0020B1F0
		public Span<byte> GetAttributesDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(44, 1);
		}

		// Token: 0x06005F4A RID: 24394 RVA: 0x0020D000 File Offset: 0x0020B200
		public byte[] GetAttributesDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(44) ?? Array.Empty<byte>();
		}

		// Token: 0x17000B88 RID: 2952
		// (get) Token: 0x06005F4B RID: 24395 RVA: 0x0020D018 File Offset: 0x0020B218
		public string SpineAtlasPath
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

		// Token: 0x06005F4C RID: 24396 RVA: 0x0020D050 File Offset: 0x0020B250
		public Span<byte> GetSpineAtlasPathBytes()
		{
			return this.__p.__vector_as_span<byte>(46, 1);
		}

		// Token: 0x06005F4D RID: 24397 RVA: 0x0020D060 File Offset: 0x0020B260
		public byte[] GetSpineAtlasPathArray()
		{
			return this.__p.__vector_as_array<byte>(46) ?? Array.Empty<byte>();
		}

		// Token: 0x17000B89 RID: 2953
		// (get) Token: 0x06005F4E RID: 24398 RVA: 0x0020D078 File Offset: 0x0020B278
		public string SpineSkeletonDataPath
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

		// Token: 0x06005F4F RID: 24399 RVA: 0x0020D0B0 File Offset: 0x0020B2B0
		public Span<byte> GetSpineSkeletonDataPathBytes()
		{
			return this.__p.__vector_as_span<byte>(48, 1);
		}

		// Token: 0x06005F50 RID: 24400 RVA: 0x0020D0C0 File Offset: 0x0020B2C0
		public byte[] GetSpineSkeletonDataPathArray()
		{
			return this.__p.__vector_as_array<byte>(48) ?? Array.Empty<byte>();
		}

		// Token: 0x17000B8A RID: 2954
		// (get) Token: 0x06005F51 RID: 24401 RVA: 0x0020D0D8 File Offset: 0x0020B2D8
		public string UnlockSpineAtlasPath
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

		// Token: 0x06005F52 RID: 24402 RVA: 0x0020D110 File Offset: 0x0020B310
		public Span<byte> GetUnlockSpineAtlasPathBytes()
		{
			return this.__p.__vector_as_span<byte>(50, 1);
		}

		// Token: 0x06005F53 RID: 24403 RVA: 0x0020D120 File Offset: 0x0020B320
		public byte[] GetUnlockSpineAtlasPathArray()
		{
			return this.__p.__vector_as_array<byte>(50) ?? Array.Empty<byte>();
		}

		// Token: 0x17000B8B RID: 2955
		// (get) Token: 0x06005F54 RID: 24404 RVA: 0x0020D138 File Offset: 0x0020B338
		public string UnlockSpineSkeletonDataPath
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

		// Token: 0x06005F55 RID: 24405 RVA: 0x0020D170 File Offset: 0x0020B370
		public Span<byte> GetUnlockSpineSkeletonDataPathBytes()
		{
			return this.__p.__vector_as_span<byte>(52, 1);
		}

		// Token: 0x06005F56 RID: 24406 RVA: 0x0020D180 File Offset: 0x0020B380
		public byte[] GetUnlockSpineSkeletonDataPathArray()
		{
			return this.__p.__vector_as_array<byte>(52) ?? Array.Empty<byte>();
		}

		// Token: 0x17000B8C RID: 2956
		// (get) Token: 0x06005F57 RID: 24407 RVA: 0x0020D198 File Offset: 0x0020B398
		public string UnlockSpineAnim
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

		// Token: 0x06005F58 RID: 24408 RVA: 0x0020D1D0 File Offset: 0x0020B3D0
		public Span<byte> GetUnlockSpineAnimBytes()
		{
			return this.__p.__vector_as_span<byte>(54, 1);
		}

		// Token: 0x06005F59 RID: 24409 RVA: 0x0020D1E0 File Offset: 0x0020B3E0
		public byte[] GetUnlockSpineAnimArray()
		{
			return this.__p.__vector_as_array<byte>(54) ?? Array.Empty<byte>();
		}

		// Token: 0x17000B8D RID: 2957
		// (get) Token: 0x06005F5A RID: 24410 RVA: 0x0020D1F8 File Offset: 0x0020B3F8
		public int ModelId
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

		// Token: 0x17000B8E RID: 2958
		// (get) Token: 0x06005F5B RID: 24411 RVA: 0x0020D238 File Offset: 0x0020B438
		public string BlueprintPath
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

		// Token: 0x06005F5C RID: 24412 RVA: 0x0020D270 File Offset: 0x0020B470
		public Span<byte> GetBlueprintPathBytes()
		{
			return this.__p.__vector_as_span<byte>(58, 1);
		}

		// Token: 0x06005F5D RID: 24413 RVA: 0x0020D280 File Offset: 0x0020B480
		public byte[] GetBlueprintPathArray()
		{
			return this.__p.__vector_as_array<byte>(58) ?? Array.Empty<byte>();
		}

		// Token: 0x17000B8F RID: 2959
		// (get) Token: 0x06005F5E RID: 24414 RVA: 0x0020D298 File Offset: 0x0020B498
		public string ABpPath
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

		// Token: 0x06005F5F RID: 24415 RVA: 0x0020D2D0 File Offset: 0x0020B4D0
		public Span<byte> GetABpPathBytes()
		{
			return this.__p.__vector_as_span<byte>(60, 1);
		}

		// Token: 0x06005F60 RID: 24416 RVA: 0x0020D2E0 File Offset: 0x0020B4E0
		public byte[] GetABpPathArray()
		{
			return this.__p.__vector_as_array<byte>(60) ?? Array.Empty<byte>();
		}

		// Token: 0x17000B90 RID: 2960
		// (get) Token: 0x06005F61 RID: 24417 RVA: 0x0020D2F8 File Offset: 0x0020B4F8
		public string MontageIdle
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

		// Token: 0x06005F62 RID: 24418 RVA: 0x0020D330 File Offset: 0x0020B530
		public Span<byte> GetMontageIdleBytes()
		{
			return this.__p.__vector_as_span<byte>(62, 1);
		}

		// Token: 0x06005F63 RID: 24419 RVA: 0x0020D340 File Offset: 0x0020B540
		public byte[] GetMontageIdleArray()
		{
			return this.__p.__vector_as_array<byte>(62) ?? Array.Empty<byte>();
		}

		// Token: 0x17000B91 RID: 2961
		// (get) Token: 0x06005F64 RID: 24420 RVA: 0x0020D358 File Offset: 0x0020B558
		public string MontageAttack
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

		// Token: 0x06005F65 RID: 24421 RVA: 0x0020D390 File Offset: 0x0020B590
		public Span<byte> GetMontageAttackBytes()
		{
			return this.__p.__vector_as_span<byte>(64, 1);
		}

		// Token: 0x06005F66 RID: 24422 RVA: 0x0020D3A0 File Offset: 0x0020B5A0
		public byte[] GetMontageAttackArray()
		{
			return this.__p.__vector_as_array<byte>(64) ?? Array.Empty<byte>();
		}

		// Token: 0x17000B92 RID: 2962
		// (get) Token: 0x06005F67 RID: 24423 RVA: 0x0020D3B8 File Offset: 0x0020B5B8
		public string MontageAttackLoop
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

		// Token: 0x06005F68 RID: 24424 RVA: 0x0020D3F0 File Offset: 0x0020B5F0
		public Span<byte> GetMontageAttackLoopBytes()
		{
			return this.__p.__vector_as_span<byte>(66, 1);
		}

		// Token: 0x06005F69 RID: 24425 RVA: 0x0020D400 File Offset: 0x0020B600
		public byte[] GetMontageAttackLoopArray()
		{
			return this.__p.__vector_as_array<byte>(66) ?? Array.Empty<byte>();
		}

		// Token: 0x17000B93 RID: 2963
		// (get) Token: 0x06005F6A RID: 24426 RVA: 0x0020D418 File Offset: 0x0020B618
		public string MontageAttackEnd
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

		// Token: 0x06005F6B RID: 24427 RVA: 0x0020D450 File Offset: 0x0020B650
		public Span<byte> GetMontageAttackEndBytes()
		{
			return this.__p.__vector_as_span<byte>(68, 1);
		}

		// Token: 0x06005F6C RID: 24428 RVA: 0x0020D460 File Offset: 0x0020B660
		public byte[] GetMontageAttackEndArray()
		{
			return this.__p.__vector_as_array<byte>(68) ?? Array.Empty<byte>();
		}

		// Token: 0x17000B94 RID: 2964
		// (get) Token: 0x06005F6D RID: 24429 RVA: 0x0020D478 File Offset: 0x0020B678
		public string MontageSuccess
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

		// Token: 0x06005F6E RID: 24430 RVA: 0x0020D4B0 File Offset: 0x0020B6B0
		public Span<byte> GetMontageSuccessBytes()
		{
			return this.__p.__vector_as_span<byte>(70, 1);
		}

		// Token: 0x06005F6F RID: 24431 RVA: 0x0020D4C0 File Offset: 0x0020B6C0
		public byte[] GetMontageSuccessArray()
		{
			return this.__p.__vector_as_array<byte>(70) ?? Array.Empty<byte>();
		}

		// Token: 0x17000B95 RID: 2965
		// (get) Token: 0x06005F70 RID: 24432 RVA: 0x0020D4D8 File Offset: 0x0020B6D8
		public string MontageFail
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

		// Token: 0x06005F71 RID: 24433 RVA: 0x0020D510 File Offset: 0x0020B710
		public Span<byte> GetMontageFailBytes()
		{
			return this.__p.__vector_as_span<byte>(72, 1);
		}

		// Token: 0x06005F72 RID: 24434 RVA: 0x0020D520 File Offset: 0x0020B720
		public byte[] GetMontageFailArray()
		{
			return this.__p.__vector_as_array<byte>(72) ?? Array.Empty<byte>();
		}

		// Token: 0x06005F73 RID: 24435 RVA: 0x0020D538 File Offset: 0x0020B738
		public int TrashTalkIdList(int j)
		{
			int num = this.__p.__offset(74);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000B96 RID: 2966
		// (get) Token: 0x06005F74 RID: 24436 RVA: 0x0020D578 File Offset: 0x0020B778
		public int TrashTalkIdListLength
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

		// Token: 0x06005F75 RID: 24437 RVA: 0x0020D5A4 File Offset: 0x0020B7A4
		public Span<int> GetTrashTalkIdListBytes()
		{
			return this.__p.__vector_as_span<int>(74, 4);
		}

		// Token: 0x06005F76 RID: 24438 RVA: 0x0020D5B4 File Offset: 0x0020B7B4
		public int[] GetTrashTalkIdListArray()
		{
			return this.__p.__vector_as_array<int>(74) ?? Array.Empty<int>();
		}

		// Token: 0x17000B97 RID: 2967
		// (get) Token: 0x06005F77 RID: 24439 RVA: 0x0020D5CC File Offset: 0x0020B7CC
		public string ShopIdleSpineAnim
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

		// Token: 0x06005F78 RID: 24440 RVA: 0x0020D604 File Offset: 0x0020B804
		public Span<byte> GetShopIdleSpineAnimBytes()
		{
			return this.__p.__vector_as_span<byte>(76, 1);
		}

		// Token: 0x06005F79 RID: 24441 RVA: 0x0020D614 File Offset: 0x0020B814
		public byte[] GetShopIdleSpineAnimArray()
		{
			return this.__p.__vector_as_array<byte>(76) ?? Array.Empty<byte>();
		}

		// Token: 0x06005F7A RID: 24442 RVA: 0x0020D62C File Offset: 0x0020B82C
		public int ShopTipsTalkIdList(int j)
		{
			int num = this.__p.__offset(78);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000B98 RID: 2968
		// (get) Token: 0x06005F7B RID: 24443 RVA: 0x0020D66C File Offset: 0x0020B86C
		public int ShopTipsTalkIdListLength
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

		// Token: 0x06005F7C RID: 24444 RVA: 0x0020D698 File Offset: 0x0020B898
		public Span<int> GetShopTipsTalkIdListBytes()
		{
			return this.__p.__vector_as_span<int>(78, 4);
		}

		// Token: 0x06005F7D RID: 24445 RVA: 0x0020D6A8 File Offset: 0x0020B8A8
		public int[] GetShopTipsTalkIdListArray()
		{
			return this.__p.__vector_as_array<int>(78) ?? Array.Empty<int>();
		}

		// Token: 0x17000B99 RID: 2969
		// (get) Token: 0x06005F7E RID: 24446 RVA: 0x0020D6C0 File Offset: 0x0020B8C0
		public string ShopTipsTalkSpineAnim
		{
			get
			{
				int num = this.__p.__offset(80);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06005F7F RID: 24447 RVA: 0x0020D6F8 File Offset: 0x0020B8F8
		public Span<byte> GetShopTipsTalkSpineAnimBytes()
		{
			return this.__p.__vector_as_span<byte>(80, 1);
		}

		// Token: 0x06005F80 RID: 24448 RVA: 0x0020D708 File Offset: 0x0020B908
		public byte[] GetShopTipsTalkSpineAnimArray()
		{
			return this.__p.__vector_as_array<byte>(80) ?? Array.Empty<byte>();
		}

		// Token: 0x06005F81 RID: 24449 RVA: 0x0020D720 File Offset: 0x0020B920
		public int ShopTrashTalkIdList(int j)
		{
			int num = this.__p.__offset(82);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000B9A RID: 2970
		// (get) Token: 0x06005F82 RID: 24450 RVA: 0x0020D760 File Offset: 0x0020B960
		public int ShopTrashTalkIdListLength
		{
			get
			{
				int num = this.__p.__offset(82);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06005F83 RID: 24451 RVA: 0x0020D78C File Offset: 0x0020B98C
		public Span<int> GetShopTrashTalkIdListBytes()
		{
			return this.__p.__vector_as_span<int>(82, 4);
		}

		// Token: 0x06005F84 RID: 24452 RVA: 0x0020D79C File Offset: 0x0020B99C
		public int[] GetShopTrashTalkIdListArray()
		{
			return this.__p.__vector_as_array<int>(82) ?? Array.Empty<int>();
		}

		// Token: 0x17000B9B RID: 2971
		// (get) Token: 0x06005F85 RID: 24453 RVA: 0x0020D7B4 File Offset: 0x0020B9B4
		public string ShopTrashTalkSpineAnim
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

		// Token: 0x06005F86 RID: 24454 RVA: 0x0020D7EC File Offset: 0x0020B9EC
		public Span<byte> GetShopTrashTalkSpineAnimBytes()
		{
			return this.__p.__vector_as_span<byte>(84, 1);
		}

		// Token: 0x06005F87 RID: 24455 RVA: 0x0020D7FC File Offset: 0x0020B9FC
		public byte[] GetShopTrashTalkSpineAnimArray()
		{
			return this.__p.__vector_as_array<byte>(84) ?? Array.Empty<byte>();
		}

		// Token: 0x06005F88 RID: 24456 RVA: 0x0020D814 File Offset: 0x0020BA14
		public int ShopWeaponTalkIdList(int j)
		{
			int num = this.__p.__offset(86);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000B9C RID: 2972
		// (get) Token: 0x06005F89 RID: 24457 RVA: 0x0020D854 File Offset: 0x0020BA54
		public int ShopWeaponTalkIdListLength
		{
			get
			{
				int num = this.__p.__offset(86);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06005F8A RID: 24458 RVA: 0x0020D880 File Offset: 0x0020BA80
		public Span<int> GetShopWeaponTalkIdListBytes()
		{
			return this.__p.__vector_as_span<int>(86, 4);
		}

		// Token: 0x06005F8B RID: 24459 RVA: 0x0020D890 File Offset: 0x0020BA90
		public int[] GetShopWeaponTalkIdListArray()
		{
			return this.__p.__vector_as_array<int>(86) ?? Array.Empty<int>();
		}

		// Token: 0x17000B9D RID: 2973
		// (get) Token: 0x06005F8C RID: 24460 RVA: 0x0020D8A8 File Offset: 0x0020BAA8
		public string ShopWeaponTalkSpineAnim
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

		// Token: 0x06005F8D RID: 24461 RVA: 0x0020D8E0 File Offset: 0x0020BAE0
		public Span<byte> GetShopWeaponTalkSpineAnimBytes()
		{
			return this.__p.__vector_as_span<byte>(88, 1);
		}

		// Token: 0x06005F8E RID: 24462 RVA: 0x0020D8F0 File Offset: 0x0020BAF0
		public byte[] GetShopWeaponTalkSpineAnimArray()
		{
			return this.__p.__vector_as_array<byte>(88) ?? Array.Empty<byte>();
		}

		// Token: 0x06005F8F RID: 24463 RVA: 0x0020D908 File Offset: 0x0020BB08
		public int ShopCostUpTalkIdList(int j)
		{
			int num = this.__p.__offset(90);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000B9E RID: 2974
		// (get) Token: 0x06005F90 RID: 24464 RVA: 0x0020D948 File Offset: 0x0020BB48
		public int ShopCostUpTalkIdListLength
		{
			get
			{
				int num = this.__p.__offset(90);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06005F91 RID: 24465 RVA: 0x0020D974 File Offset: 0x0020BB74
		public Span<int> GetShopCostUpTalkIdListBytes()
		{
			return this.__p.__vector_as_span<int>(90, 4);
		}

		// Token: 0x06005F92 RID: 24466 RVA: 0x0020D984 File Offset: 0x0020BB84
		public int[] GetShopCostUpTalkIdListArray()
		{
			return this.__p.__vector_as_array<int>(90) ?? Array.Empty<int>();
		}

		// Token: 0x17000B9F RID: 2975
		// (get) Token: 0x06005F93 RID: 24467 RVA: 0x0020D99C File Offset: 0x0020BB9C
		public string ShopCostUpTalkSpineAnim
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

		// Token: 0x06005F94 RID: 24468 RVA: 0x0020D9D4 File Offset: 0x0020BBD4
		public Span<byte> GetShopCostUpTalkSpineAnimBytes()
		{
			return this.__p.__vector_as_span<byte>(92, 1);
		}

		// Token: 0x06005F95 RID: 24469 RVA: 0x0020D9E4 File Offset: 0x0020BBE4
		public byte[] GetShopCostUpTalkSpineAnimArray()
		{
			return this.__p.__vector_as_array<byte>(92) ?? Array.Empty<byte>();
		}

		// Token: 0x17000BA0 RID: 2976
		// (get) Token: 0x06005F96 RID: 24470 RVA: 0x0020D9FC File Offset: 0x0020BBFC
		public string WinFlowListName
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

		// Token: 0x06005F97 RID: 24471 RVA: 0x0020DA34 File Offset: 0x0020BC34
		public Span<byte> GetWinFlowListNameBytes()
		{
			return this.__p.__vector_as_span<byte>(94, 1);
		}

		// Token: 0x06005F98 RID: 24472 RVA: 0x0020DA44 File Offset: 0x0020BC44
		public byte[] GetWinFlowListNameArray()
		{
			return this.__p.__vector_as_array<byte>(94) ?? Array.Empty<byte>();
		}

		// Token: 0x17000BA1 RID: 2977
		// (get) Token: 0x06005F99 RID: 24473 RVA: 0x0020DA5C File Offset: 0x0020BC5C
		public int WinFlowId
		{
			get
			{
				int num = this.__p.__offset(96);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000BA2 RID: 2978
		// (get) Token: 0x06005F9A RID: 24474 RVA: 0x0020DA9C File Offset: 0x0020BC9C
		public int WinStateId
		{
			get
			{
				int num = this.__p.__offset(98);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000BA3 RID: 2979
		// (get) Token: 0x06005F9B RID: 24475 RVA: 0x0020DADC File Offset: 0x0020BCDC
		public string LoseFlowListName
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

		// Token: 0x06005F9C RID: 24476 RVA: 0x0020DB14 File Offset: 0x0020BD14
		public Span<byte> GetLoseFlowListNameBytes()
		{
			return this.__p.__vector_as_span<byte>(100, 1);
		}

		// Token: 0x06005F9D RID: 24477 RVA: 0x0020DB24 File Offset: 0x0020BD24
		public byte[] GetLoseFlowListNameArray()
		{
			return this.__p.__vector_as_array<byte>(100) ?? Array.Empty<byte>();
		}

		// Token: 0x17000BA4 RID: 2980
		// (get) Token: 0x06005F9E RID: 24478 RVA: 0x0020DB3C File Offset: 0x0020BD3C
		public int LoseFlowId
		{
			get
			{
				int num = this.__p.__offset(102);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000BA5 RID: 2981
		// (get) Token: 0x06005F9F RID: 24479 RVA: 0x0020DB7C File Offset: 0x0020BD7C
		public int LoseStateId
		{
			get
			{
				int num = this.__p.__offset(104);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000BA6 RID: 2982
		// (get) Token: 0x06005FA0 RID: 24480 RVA: 0x0020DBBC File Offset: 0x0020BDBC
		public string AudioRoleSelect
		{
			get
			{
				int num = this.__p.__offset(106);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06005FA1 RID: 24481 RVA: 0x0020DBF4 File Offset: 0x0020BDF4
		public Span<byte> GetAudioRoleSelectBytes()
		{
			return this.__p.__vector_as_span<byte>(106, 1);
		}

		// Token: 0x06005FA2 RID: 24482 RVA: 0x0020DC04 File Offset: 0x0020BE04
		public byte[] GetAudioRoleSelectArray()
		{
			return this.__p.__vector_as_array<byte>(106) ?? Array.Empty<byte>();
		}

		// Token: 0x17000BA7 RID: 2983
		// (get) Token: 0x06005FA3 RID: 24483 RVA: 0x0020DC1C File Offset: 0x0020BE1C
		public string AudioAttackStart
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

		// Token: 0x06005FA4 RID: 24484 RVA: 0x0020DC54 File Offset: 0x0020BE54
		public Span<byte> GetAudioAttackStartBytes()
		{
			return this.__p.__vector_as_span<byte>(108, 1);
		}

		// Token: 0x06005FA5 RID: 24485 RVA: 0x0020DC64 File Offset: 0x0020BE64
		public byte[] GetAudioAttackStartArray()
		{
			return this.__p.__vector_as_array<byte>(108) ?? Array.Empty<byte>();
		}

		// Token: 0x17000BA8 RID: 2984
		// (get) Token: 0x06005FA6 RID: 24486 RVA: 0x0020DC7C File Offset: 0x0020BE7C
		public string AudioRoundWin
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

		// Token: 0x06005FA7 RID: 24487 RVA: 0x0020DCB4 File Offset: 0x0020BEB4
		public Span<byte> GetAudioRoundWinBytes()
		{
			return this.__p.__vector_as_span<byte>(110, 1);
		}

		// Token: 0x06005FA8 RID: 24488 RVA: 0x0020DCC4 File Offset: 0x0020BEC4
		public byte[] GetAudioRoundWinArray()
		{
			return this.__p.__vector_as_array<byte>(110) ?? Array.Empty<byte>();
		}

		// Token: 0x17000BA9 RID: 2985
		// (get) Token: 0x06005FA9 RID: 24489 RVA: 0x0020DCDC File Offset: 0x0020BEDC
		public string AudioSettleDefeated
		{
			get
			{
				int num = this.__p.__offset(112);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06005FAA RID: 24490 RVA: 0x0020DD14 File Offset: 0x0020BF14
		public Span<byte> GetAudioSettleDefeatedBytes()
		{
			return this.__p.__vector_as_span<byte>(112, 1);
		}

		// Token: 0x06005FAB RID: 24491 RVA: 0x0020DD24 File Offset: 0x0020BF24
		public byte[] GetAudioSettleDefeatedArray()
		{
			return this.__p.__vector_as_array<byte>(112) ?? Array.Empty<byte>();
		}

		// Token: 0x17000BAA RID: 2986
		// (get) Token: 0x06005FAC RID: 24492 RVA: 0x0020DD3C File Offset: 0x0020BF3C
		public string HitDAPath
		{
			get
			{
				int num = this.__p.__offset(114);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06005FAD RID: 24493 RVA: 0x0020DD74 File Offset: 0x0020BF74
		public Span<byte> GetHitDAPathBytes()
		{
			return this.__p.__vector_as_span<byte>(114, 1);
		}

		// Token: 0x06005FAE RID: 24494 RVA: 0x0020DD84 File Offset: 0x0020BF84
		public byte[] GetHitDAPathArray()
		{
			return this.__p.__vector_as_array<byte>(114) ?? Array.Empty<byte>();
		}

		// Token: 0x06005FAF RID: 24495 RVA: 0x0020DD9C File Offset: 0x0020BF9C
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用ShopCostUpTalkIdListIter()或GetShopCostUpTalkIdListBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] ShopCostUpTalkIdList()
		{
			DangoBrawlRole dangoBrawlRole = this;
			return dangoBrawlRole.GetShopCostUpTalkIdListArray() ?? Array.Empty<int>();
		}

		// Token: 0x06005FB0 RID: 24496 RVA: 0x0020DDC0 File Offset: 0x0020BFC0
		[NullableContext(1)]
		public readonly IEnumerable<int> ShopCostUpTalkIdListIter()
		{
			DangoBrawlRole.<ShopCostUpTalkIdListIter>d__212 <ShopCostUpTalkIdListIter>d__ = new DangoBrawlRole.<ShopCostUpTalkIdListIter>d__212(-2);
			<ShopCostUpTalkIdListIter>d__.<>3__<>4__this = this;
			return <ShopCostUpTalkIdListIter>d__;
		}

		// Token: 0x06005FB1 RID: 24497 RVA: 0x0020DDD8 File Offset: 0x0020BFD8
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用ShopTipsTalkIdListIter()或GetShopTipsTalkIdListBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] ShopTipsTalkIdList()
		{
			DangoBrawlRole dangoBrawlRole = this;
			return dangoBrawlRole.GetShopTipsTalkIdListArray() ?? Array.Empty<int>();
		}

		// Token: 0x06005FB2 RID: 24498 RVA: 0x0020DDFC File Offset: 0x0020BFFC
		[NullableContext(1)]
		public readonly IEnumerable<int> ShopTipsTalkIdListIter()
		{
			DangoBrawlRole.<ShopTipsTalkIdListIter>d__214 <ShopTipsTalkIdListIter>d__ = new DangoBrawlRole.<ShopTipsTalkIdListIter>d__214(-2);
			<ShopTipsTalkIdListIter>d__.<>3__<>4__this = this;
			return <ShopTipsTalkIdListIter>d__;
		}

		// Token: 0x06005FB3 RID: 24499 RVA: 0x0020DE14 File Offset: 0x0020C014
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用ShopTrashTalkIdListIter()或GetShopTrashTalkIdListBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] ShopTrashTalkIdList()
		{
			DangoBrawlRole dangoBrawlRole = this;
			return dangoBrawlRole.GetShopTrashTalkIdListArray() ?? Array.Empty<int>();
		}

		// Token: 0x06005FB4 RID: 24500 RVA: 0x0020DE38 File Offset: 0x0020C038
		[NullableContext(1)]
		public readonly IEnumerable<int> ShopTrashTalkIdListIter()
		{
			DangoBrawlRole.<ShopTrashTalkIdListIter>d__216 <ShopTrashTalkIdListIter>d__ = new DangoBrawlRole.<ShopTrashTalkIdListIter>d__216(-2);
			<ShopTrashTalkIdListIter>d__.<>3__<>4__this = this;
			return <ShopTrashTalkIdListIter>d__;
		}

		// Token: 0x06005FB5 RID: 24501 RVA: 0x0020DE50 File Offset: 0x0020C050
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用ShopWeaponTalkIdListIter()或GetShopWeaponTalkIdListBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] ShopWeaponTalkIdList()
		{
			DangoBrawlRole dangoBrawlRole = this;
			return dangoBrawlRole.GetShopWeaponTalkIdListArray() ?? Array.Empty<int>();
		}

		// Token: 0x06005FB6 RID: 24502 RVA: 0x0020DE74 File Offset: 0x0020C074
		[NullableContext(1)]
		public readonly IEnumerable<int> ShopWeaponTalkIdListIter()
		{
			DangoBrawlRole.<ShopWeaponTalkIdListIter>d__218 <ShopWeaponTalkIdListIter>d__ = new DangoBrawlRole.<ShopWeaponTalkIdListIter>d__218(-2);
			<ShopWeaponTalkIdListIter>d__.<>3__<>4__this = this;
			return <ShopWeaponTalkIdListIter>d__;
		}

		// Token: 0x06005FB7 RID: 24503 RVA: 0x0020DE8C File Offset: 0x0020C08C
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用TrashTalkIdListIter()或GetTrashTalkIdListBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] TrashTalkIdList()
		{
			DangoBrawlRole dangoBrawlRole = this;
			return dangoBrawlRole.GetTrashTalkIdListArray() ?? Array.Empty<int>();
		}

		// Token: 0x06005FB8 RID: 24504 RVA: 0x0020DEB0 File Offset: 0x0020C0B0
		[NullableContext(1)]
		public readonly IEnumerable<int> TrashTalkIdListIter()
		{
			DangoBrawlRole.<TrashTalkIdListIter>d__220 <TrashTalkIdListIter>d__ = new DangoBrawlRole.<TrashTalkIdListIter>d__220(-2);
			<TrashTalkIdListIter>d__.<>3__<>4__this = this;
			return <TrashTalkIdListIter>d__;
		}

		// Token: 0x04004BF9 RID: 19449
		private Table __p;
	}
}
