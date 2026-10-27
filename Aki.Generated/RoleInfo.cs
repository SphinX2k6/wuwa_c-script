using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001050 RID: 4176
	public struct RoleInfo : IFlatbufferObject
	{
		// Token: 0x17003280 RID: 12928
		// (get) Token: 0x0600C8CB RID: 51403 RVA: 0x002FAD42 File Offset: 0x002F8F42
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600C8CC RID: 51404 RVA: 0x002FAD4F File Offset: 0x002F8F4F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600C8CD RID: 51405 RVA: 0x002FAD58 File Offset: 0x002F8F58
		public static RoleInfo GetRootAsRoleInfo(ByteBuffer _bb)
		{
			return RoleInfo.GetRootAsRoleInfo(_bb, default(RoleInfo));
		}

		// Token: 0x0600C8CE RID: 51406 RVA: 0x002FAD74 File Offset: 0x002F8F74
		public static RoleInfo GetRootAsRoleInfo(ByteBuffer _bb, RoleInfo obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600C8CF RID: 51407 RVA: 0x002FAD91 File Offset: 0x002F8F91
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600C8D0 RID: 51408 RVA: 0x002FADA0 File Offset: 0x002F8FA0
		public RoleInfo __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003281 RID: 12929
		// (get) Token: 0x0600C8D1 RID: 51409 RVA: 0x002FADB0 File Offset: 0x002F8FB0
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

		// Token: 0x17003282 RID: 12930
		// (get) Token: 0x0600C8D2 RID: 51410 RVA: 0x002FADEC File Offset: 0x002F8FEC
		public int QualityId
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

		// Token: 0x17003283 RID: 12931
		// (get) Token: 0x0600C8D3 RID: 51411 RVA: 0x002FAE28 File Offset: 0x002F9028
		public int RoleType
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

		// Token: 0x17003284 RID: 12932
		// (get) Token: 0x0600C8D4 RID: 51412 RVA: 0x002FAE64 File Offset: 0x002F9064
		public bool IsTrial
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17003285 RID: 12933
		// (get) Token: 0x0600C8D5 RID: 51413 RVA: 0x002FAEA4 File Offset: 0x002F90A4
		public string Name
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

		// Token: 0x0600C8D6 RID: 51414 RVA: 0x002FAEDC File Offset: 0x002F90DC
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600C8D7 RID: 51415 RVA: 0x002FAEEC File Offset: 0x002F90EC
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17003286 RID: 12934
		// (get) Token: 0x0600C8D8 RID: 51416 RVA: 0x002FAF04 File Offset: 0x002F9104
		public string NickName
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

		// Token: 0x0600C8D9 RID: 51417 RVA: 0x002FAF3C File Offset: 0x002F913C
		public Span<byte> GetNickNameBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600C8DA RID: 51418 RVA: 0x002FAF4C File Offset: 0x002F914C
		public byte[] GetNickNameArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17003287 RID: 12935
		// (get) Token: 0x0600C8DB RID: 51419 RVA: 0x002FAF64 File Offset: 0x002F9164
		public string Introduction
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

		// Token: 0x0600C8DC RID: 51420 RVA: 0x002FAF9C File Offset: 0x002F919C
		public Span<byte> GetIntroductionBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600C8DD RID: 51421 RVA: 0x002FAFAC File Offset: 0x002F91AC
		public byte[] GetIntroductionArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x0600C8DE RID: 51422 RVA: 0x002FAFC4 File Offset: 0x002F91C4
		public int Tag(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003288 RID: 12936
		// (get) Token: 0x0600C8DF RID: 51423 RVA: 0x002FB004 File Offset: 0x002F9204
		public int TagLength
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

		// Token: 0x0600C8E0 RID: 51424 RVA: 0x002FB030 File Offset: 0x002F9230
		public Span<int> GetTagBytes()
		{
			return this.__p.__vector_as_span<int>(18, 4);
		}

		// Token: 0x0600C8E1 RID: 51425 RVA: 0x002FB040 File Offset: 0x002F9240
		public int[] GetTagArray()
		{
			return this.__p.__vector_as_array<int>(18) ?? Array.Empty<int>();
		}

		// Token: 0x17003289 RID: 12937
		// (get) Token: 0x0600C8E2 RID: 51426 RVA: 0x002FB058 File Offset: 0x002F9258
		public int ParentId
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700328A RID: 12938
		// (get) Token: 0x0600C8E3 RID: 51427 RVA: 0x002FB098 File Offset: 0x002F9298
		public int Priority
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700328B RID: 12939
		// (get) Token: 0x0600C8E4 RID: 51428 RVA: 0x002FB0D8 File Offset: 0x002F92D8
		public int PropertyId
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

		// Token: 0x0600C8E5 RID: 51429 RVA: 0x002FB118 File Offset: 0x002F9318
		public int ShowProperty(int j)
		{
			int num = this.__p.__offset(26);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700328C RID: 12940
		// (get) Token: 0x0600C8E6 RID: 51430 RVA: 0x002FB158 File Offset: 0x002F9358
		public int ShowPropertyLength
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600C8E7 RID: 51431 RVA: 0x002FB184 File Offset: 0x002F9384
		public Span<int> GetShowPropertyBytes()
		{
			return this.__p.__vector_as_span<int>(26, 4);
		}

		// Token: 0x0600C8E8 RID: 51432 RVA: 0x002FB194 File Offset: 0x002F9394
		public int[] GetShowPropertyArray()
		{
			return this.__p.__vector_as_array<int>(26) ?? Array.Empty<int>();
		}

		// Token: 0x1700328D RID: 12941
		// (get) Token: 0x0600C8E9 RID: 51433 RVA: 0x002FB1AC File Offset: 0x002F93AC
		public int ElementId
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

		// Token: 0x1700328E RID: 12942
		// (get) Token: 0x0600C8EA RID: 51434 RVA: 0x002FB1EC File Offset: 0x002F93EC
		public int SkinId
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

		// Token: 0x1700328F RID: 12943
		// (get) Token: 0x0600C8EB RID: 51435 RVA: 0x002FB22C File Offset: 0x002F942C
		public string RoleHeadIconCircle
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

		// Token: 0x0600C8EC RID: 51436 RVA: 0x002FB264 File Offset: 0x002F9464
		public Span<byte> GetRoleHeadIconCircleBytes()
		{
			return this.__p.__vector_as_span<byte>(32, 1);
		}

		// Token: 0x0600C8ED RID: 51437 RVA: 0x002FB274 File Offset: 0x002F9474
		public byte[] GetRoleHeadIconCircleArray()
		{
			return this.__p.__vector_as_array<byte>(32) ?? Array.Empty<byte>();
		}

		// Token: 0x17003290 RID: 12944
		// (get) Token: 0x0600C8EE RID: 51438 RVA: 0x002FB28C File Offset: 0x002F948C
		public string RoleHeadIconLarge
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

		// Token: 0x0600C8EF RID: 51439 RVA: 0x002FB2C4 File Offset: 0x002F94C4
		public Span<byte> GetRoleHeadIconLargeBytes()
		{
			return this.__p.__vector_as_span<byte>(34, 1);
		}

		// Token: 0x0600C8F0 RID: 51440 RVA: 0x002FB2D4 File Offset: 0x002F94D4
		public byte[] GetRoleHeadIconLargeArray()
		{
			return this.__p.__vector_as_array<byte>(34) ?? Array.Empty<byte>();
		}

		// Token: 0x17003291 RID: 12945
		// (get) Token: 0x0600C8F1 RID: 51441 RVA: 0x002FB2EC File Offset: 0x002F94EC
		public string RoleHeadIconBig
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

		// Token: 0x0600C8F2 RID: 51442 RVA: 0x002FB324 File Offset: 0x002F9524
		public Span<byte> GetRoleHeadIconBigBytes()
		{
			return this.__p.__vector_as_span<byte>(36, 1);
		}

		// Token: 0x0600C8F3 RID: 51443 RVA: 0x002FB334 File Offset: 0x002F9534
		public byte[] GetRoleHeadIconBigArray()
		{
			return this.__p.__vector_as_array<byte>(36) ?? Array.Empty<byte>();
		}

		// Token: 0x17003292 RID: 12946
		// (get) Token: 0x0600C8F4 RID: 51444 RVA: 0x002FB34C File Offset: 0x002F954C
		public string Card
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

		// Token: 0x0600C8F5 RID: 51445 RVA: 0x002FB384 File Offset: 0x002F9584
		public Span<byte> GetCardBytes()
		{
			return this.__p.__vector_as_span<byte>(38, 1);
		}

		// Token: 0x0600C8F6 RID: 51446 RVA: 0x002FB394 File Offset: 0x002F9594
		public byte[] GetCardArray()
		{
			return this.__p.__vector_as_array<byte>(38) ?? Array.Empty<byte>();
		}

		// Token: 0x17003293 RID: 12947
		// (get) Token: 0x0600C8F7 RID: 51447 RVA: 0x002FB3AC File Offset: 0x002F95AC
		public string RoleHeadIcon
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

		// Token: 0x0600C8F8 RID: 51448 RVA: 0x002FB3E4 File Offset: 0x002F95E4
		public Span<byte> GetRoleHeadIconBytes()
		{
			return this.__p.__vector_as_span<byte>(40, 1);
		}

		// Token: 0x0600C8F9 RID: 51449 RVA: 0x002FB3F4 File Offset: 0x002F95F4
		public byte[] GetRoleHeadIconArray()
		{
			return this.__p.__vector_as_array<byte>(40) ?? Array.Empty<byte>();
		}

		// Token: 0x17003294 RID: 12948
		// (get) Token: 0x0600C8FA RID: 51450 RVA: 0x002FB40C File Offset: 0x002F960C
		public string FormationRoleCard
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

		// Token: 0x0600C8FB RID: 51451 RVA: 0x002FB444 File Offset: 0x002F9644
		public Span<byte> GetFormationRoleCardBytes()
		{
			return this.__p.__vector_as_span<byte>(42, 1);
		}

		// Token: 0x0600C8FC RID: 51452 RVA: 0x002FB454 File Offset: 0x002F9654
		public byte[] GetFormationRoleCardArray()
		{
			return this.__p.__vector_as_array<byte>(42) ?? Array.Empty<byte>();
		}

		// Token: 0x17003295 RID: 12949
		// (get) Token: 0x0600C8FD RID: 51453 RVA: 0x002FB46C File Offset: 0x002F966C
		public string RoleStand
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

		// Token: 0x0600C8FE RID: 51454 RVA: 0x002FB4A4 File Offset: 0x002F96A4
		public Span<byte> GetRoleStandBytes()
		{
			return this.__p.__vector_as_span<byte>(44, 1);
		}

		// Token: 0x0600C8FF RID: 51455 RVA: 0x002FB4B4 File Offset: 0x002F96B4
		public byte[] GetRoleStandArray()
		{
			return this.__p.__vector_as_array<byte>(44) ?? Array.Empty<byte>();
		}

		// Token: 0x17003296 RID: 12950
		// (get) Token: 0x0600C900 RID: 51456 RVA: 0x002FB4CC File Offset: 0x002F96CC
		public string RolePortrait
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

		// Token: 0x0600C901 RID: 51457 RVA: 0x002FB504 File Offset: 0x002F9704
		public Span<byte> GetRolePortraitBytes()
		{
			return this.__p.__vector_as_span<byte>(46, 1);
		}

		// Token: 0x0600C902 RID: 51458 RVA: 0x002FB514 File Offset: 0x002F9714
		public byte[] GetRolePortraitArray()
		{
			return this.__p.__vector_as_array<byte>(46) ?? Array.Empty<byte>();
		}

		// Token: 0x0600C903 RID: 51459 RVA: 0x002FB52C File Offset: 0x002F972C
		public DicIntInt? SpilloverItem(int j)
		{
			int num = this.__p.__offset(48);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17003297 RID: 12951
		// (get) Token: 0x0600C904 RID: 51460 RVA: 0x002FB590 File Offset: 0x002F9790
		public int SpilloverItemLength
		{
			get
			{
				int num = this.__p.__offset(48);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x17003298 RID: 12952
		// (get) Token: 0x0600C905 RID: 51461 RVA: 0x002FB5BC File Offset: 0x002F97BC
		public int MeshId
		{
			get
			{
				int num = this.__p.__offset(50);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17003299 RID: 12953
		// (get) Token: 0x0600C906 RID: 51462 RVA: 0x002FB5FC File Offset: 0x002F97FC
		public int UiMeshId
		{
			get
			{
				int num = this.__p.__offset(52);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700329A RID: 12954
		// (get) Token: 0x0600C907 RID: 51463 RVA: 0x002FB63C File Offset: 0x002F983C
		public string RoleBody
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

		// Token: 0x0600C908 RID: 51464 RVA: 0x002FB674 File Offset: 0x002F9874
		public Span<byte> GetRoleBodyBytes()
		{
			return this.__p.__vector_as_span<byte>(54, 1);
		}

		// Token: 0x0600C909 RID: 51465 RVA: 0x002FB684 File Offset: 0x002F9884
		public byte[] GetRoleBodyArray()
		{
			return this.__p.__vector_as_array<byte>(54) ?? Array.Empty<byte>();
		}

		// Token: 0x1700329B RID: 12955
		// (get) Token: 0x0600C90A RID: 51466 RVA: 0x002FB69C File Offset: 0x002F989C
		public int BreachModel
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

		// Token: 0x1700329C RID: 12956
		// (get) Token: 0x0600C90B RID: 51467 RVA: 0x002FB6DC File Offset: 0x002F98DC
		public int SpecialEnergyBarId
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

		// Token: 0x1700329D RID: 12957
		// (get) Token: 0x0600C90C RID: 51468 RVA: 0x002FB71C File Offset: 0x002F991C
		public string CameraConfig
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

		// Token: 0x0600C90D RID: 51469 RVA: 0x002FB754 File Offset: 0x002F9954
		public Span<byte> GetCameraConfigBytes()
		{
			return this.__p.__vector_as_span<byte>(60, 1);
		}

		// Token: 0x0600C90E RID: 51470 RVA: 0x002FB764 File Offset: 0x002F9964
		public byte[] GetCameraConfigArray()
		{
			return this.__p.__vector_as_array<byte>(60) ?? Array.Empty<byte>();
		}

		// Token: 0x1700329E RID: 12958
		// (get) Token: 0x0600C90F RID: 51471 RVA: 0x002FB77C File Offset: 0x002F997C
		public float CameraFloatHeight
		{
			get
			{
				int num = this.__p.__offset(62);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700329F RID: 12959
		// (get) Token: 0x0600C910 RID: 51472 RVA: 0x002FB7C0 File Offset: 0x002F99C0
		public int EntityProperty
		{
			get
			{
				int num = this.__p.__offset(64);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170032A0 RID: 12960
		// (get) Token: 0x0600C911 RID: 51473 RVA: 0x002FB800 File Offset: 0x002F9A00
		public int MaxLevel
		{
			get
			{
				int num = this.__p.__offset(66);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170032A1 RID: 12961
		// (get) Token: 0x0600C912 RID: 51474 RVA: 0x002FB840 File Offset: 0x002F9A40
		public int LevelConsumeId
		{
			get
			{
				int num = this.__p.__offset(68);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170032A2 RID: 12962
		// (get) Token: 0x0600C913 RID: 51475 RVA: 0x002FB880 File Offset: 0x002F9A80
		public int BreachId
		{
			get
			{
				int num = this.__p.__offset(70);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170032A3 RID: 12963
		// (get) Token: 0x0600C914 RID: 51476 RVA: 0x002FB8C0 File Offset: 0x002F9AC0
		public int SkillId
		{
			get
			{
				int num = this.__p.__offset(72);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170032A4 RID: 12964
		// (get) Token: 0x0600C915 RID: 51477 RVA: 0x002FB900 File Offset: 0x002F9B00
		public int SkillTreeGroupId
		{
			get
			{
				int num = this.__p.__offset(74);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170032A5 RID: 12965
		// (get) Token: 0x0600C916 RID: 51478 RVA: 0x002FB940 File Offset: 0x002F9B40
		public int ResonanceId
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

		// Token: 0x170032A6 RID: 12966
		// (get) Token: 0x0600C917 RID: 51479 RVA: 0x002FB980 File Offset: 0x002F9B80
		public int ResonantChainGroupId
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

		// Token: 0x0600C918 RID: 51480 RVA: 0x002FB9C0 File Offset: 0x002F9BC0
		public int SkillBranchIds(int j)
		{
			int num = this.__p.__offset(80);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170032A7 RID: 12967
		// (get) Token: 0x0600C919 RID: 51481 RVA: 0x002FBA00 File Offset: 0x002F9C00
		public int SkillBranchIdsLength
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

		// Token: 0x0600C91A RID: 51482 RVA: 0x002FBA2C File Offset: 0x002F9C2C
		public Span<int> GetSkillBranchIdsBytes()
		{
			return this.__p.__vector_as_span<int>(80, 4);
		}

		// Token: 0x0600C91B RID: 51483 RVA: 0x002FBA3C File Offset: 0x002F9C3C
		public int[] GetSkillBranchIdsArray()
		{
			return this.__p.__vector_as_array<int>(80) ?? Array.Empty<int>();
		}

		// Token: 0x170032A8 RID: 12968
		// (get) Token: 0x0600C91C RID: 51484 RVA: 0x002FBA54 File Offset: 0x002F9C54
		public int DefaultSkillBranchId
		{
			get
			{
				int num = this.__p.__offset(82);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170032A9 RID: 12969
		// (get) Token: 0x0600C91D RID: 51485 RVA: 0x002FBA94 File Offset: 0x002F9C94
		public bool IsShow
		{
			get
			{
				int num = this.__p.__offset(84);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0600C91E RID: 51486 RVA: 0x002FBAD4 File Offset: 0x002F9CD4
		public DicIntInt? ExchangeConsume(int j)
		{
			int num = this.__p.__offset(86);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170032AA RID: 12970
		// (get) Token: 0x0600C91F RID: 51487 RVA: 0x002FBB38 File Offset: 0x002F9D38
		public int ExchangeConsumeLength
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

		// Token: 0x170032AB RID: 12971
		// (get) Token: 0x0600C920 RID: 51488 RVA: 0x002FBB64 File Offset: 0x002F9D64
		public int InitWeaponItemId
		{
			get
			{
				int num = this.__p.__offset(88);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170032AC RID: 12972
		// (get) Token: 0x0600C921 RID: 51489 RVA: 0x002FBBA4 File Offset: 0x002F9DA4
		public int WeaponType
		{
			get
			{
				int num = this.__p.__offset(90);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170032AD RID: 12973
		// (get) Token: 0x0600C922 RID: 51490 RVA: 0x002FBBE4 File Offset: 0x002F9DE4
		public string SkillDAPath
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

		// Token: 0x0600C923 RID: 51491 RVA: 0x002FBC1C File Offset: 0x002F9E1C
		public Span<byte> GetSkillDAPathBytes()
		{
			return this.__p.__vector_as_span<byte>(92, 1);
		}

		// Token: 0x0600C924 RID: 51492 RVA: 0x002FBC2C File Offset: 0x002F9E2C
		public byte[] GetSkillDAPathArray()
		{
			return this.__p.__vector_as_array<byte>(92) ?? Array.Empty<byte>();
		}

		// Token: 0x170032AE RID: 12974
		// (get) Token: 0x0600C925 RID: 51493 RVA: 0x002FBC44 File Offset: 0x002F9E44
		public string SkillLockDAPath
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

		// Token: 0x0600C926 RID: 51494 RVA: 0x002FBC7C File Offset: 0x002F9E7C
		public Span<byte> GetSkillLockDAPathBytes()
		{
			return this.__p.__vector_as_span<byte>(94, 1);
		}

		// Token: 0x0600C927 RID: 51495 RVA: 0x002FBC8C File Offset: 0x002F9E8C
		public byte[] GetSkillLockDAPathArray()
		{
			return this.__p.__vector_as_array<byte>(94) ?? Array.Empty<byte>();
		}

		// Token: 0x170032AF RID: 12975
		// (get) Token: 0x0600C928 RID: 51496 RVA: 0x002FBCA4 File Offset: 0x002F9EA4
		public string UiScenePerformanceABP
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

		// Token: 0x0600C929 RID: 51497 RVA: 0x002FBCDC File Offset: 0x002F9EDC
		public Span<byte> GetUiScenePerformanceABPBytes()
		{
			return this.__p.__vector_as_span<byte>(96, 1);
		}

		// Token: 0x0600C92A RID: 51498 RVA: 0x002FBCEC File Offset: 0x002F9EEC
		public byte[] GetUiScenePerformanceABPArray()
		{
			return this.__p.__vector_as_array<byte>(96) ?? Array.Empty<byte>();
		}

		// Token: 0x170032B0 RID: 12976
		// (get) Token: 0x0600C92B RID: 51499 RVA: 0x002FBD04 File Offset: 0x002F9F04
		public int LockOnDefaultId
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

		// Token: 0x170032B1 RID: 12977
		// (get) Token: 0x0600C92C RID: 51500 RVA: 0x002FBD44 File Offset: 0x002F9F44
		public int LockOnLookOnId
		{
			get
			{
				int num = this.__p.__offset(100);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170032B2 RID: 12978
		// (get) Token: 0x0600C92D RID: 51501 RVA: 0x002FBD84 File Offset: 0x002F9F84
		public string SkillEffectDA
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

		// Token: 0x0600C92E RID: 51502 RVA: 0x002FBDBC File Offset: 0x002F9FBC
		public Span<byte> GetSkillEffectDABytes()
		{
			return this.__p.__vector_as_span<byte>(102, 1);
		}

		// Token: 0x0600C92F RID: 51503 RVA: 0x002FBDCC File Offset: 0x002F9FCC
		public byte[] GetSkillEffectDAArray()
		{
			return this.__p.__vector_as_array<byte>(102) ?? Array.Empty<byte>();
		}

		// Token: 0x170032B3 RID: 12979
		// (get) Token: 0x0600C930 RID: 51504 RVA: 0x002FBDE4 File Offset: 0x002F9FE4
		public string FootStepState
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

		// Token: 0x0600C931 RID: 51505 RVA: 0x002FBE1C File Offset: 0x002FA01C
		public Span<byte> GetFootStepStateBytes()
		{
			return this.__p.__vector_as_span<byte>(104, 1);
		}

		// Token: 0x0600C932 RID: 51506 RVA: 0x002FBE2C File Offset: 0x002FA02C
		public byte[] GetFootStepStateArray()
		{
			return this.__p.__vector_as_array<byte>(104) ?? Array.Empty<byte>();
		}

		// Token: 0x170032B4 RID: 12980
		// (get) Token: 0x0600C933 RID: 51507 RVA: 0x002FBE44 File Offset: 0x002FA044
		public int PartyId
		{
			get
			{
				int num = this.__p.__offset(106);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170032B5 RID: 12981
		// (get) Token: 0x0600C934 RID: 51508 RVA: 0x002FBE84 File Offset: 0x002FA084
		public string AttributesDescription
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

		// Token: 0x0600C935 RID: 51509 RVA: 0x002FBEBC File Offset: 0x002FA0BC
		public Span<byte> GetAttributesDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(108, 1);
		}

		// Token: 0x0600C936 RID: 51510 RVA: 0x002FBECC File Offset: 0x002FA0CC
		public byte[] GetAttributesDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(108) ?? Array.Empty<byte>();
		}

		// Token: 0x170032B6 RID: 12982
		// (get) Token: 0x0600C937 RID: 51511 RVA: 0x002FBEE4 File Offset: 0x002FA0E4
		public string Icon
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

		// Token: 0x0600C938 RID: 51512 RVA: 0x002FBF1C File Offset: 0x002FA11C
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(110, 1);
		}

		// Token: 0x0600C939 RID: 51513 RVA: 0x002FBF2C File Offset: 0x002FA12C
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(110) ?? Array.Empty<byte>();
		}

		// Token: 0x170032B7 RID: 12983
		// (get) Token: 0x0600C93A RID: 51514 RVA: 0x002FBF44 File Offset: 0x002FA144
		public int ItemQualityId
		{
			get
			{
				int num = this.__p.__offset(112);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170032B8 RID: 12984
		// (get) Token: 0x0600C93B RID: 51515 RVA: 0x002FBF84 File Offset: 0x002FA184
		public string ObtainedShowDescription
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

		// Token: 0x0600C93C RID: 51516 RVA: 0x002FBFBC File Offset: 0x002FA1BC
		public Span<byte> GetObtainedShowDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(114, 1);
		}

		// Token: 0x0600C93D RID: 51517 RVA: 0x002FBFCC File Offset: 0x002FA1CC
		public byte[] GetObtainedShowDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(114) ?? Array.Empty<byte>();
		}

		// Token: 0x170032B9 RID: 12985
		// (get) Token: 0x0600C93E RID: 51518 RVA: 0x002FBFE4 File Offset: 0x002FA1E4
		public int NumLimit
		{
			get
			{
				int num = this.__p.__offset(116);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170032BA RID: 12986
		// (get) Token: 0x0600C93F RID: 51519 RVA: 0x002FC024 File Offset: 0x002FA224
		public bool ShowInBag
		{
			get
			{
				int num = this.__p.__offset(118);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0600C940 RID: 51520 RVA: 0x002FC064 File Offset: 0x002FA264
		public float WeaponScale(int j)
		{
			int num = this.__p.__offset(120);
			if (num == 0)
			{
				return 0f;
			}
			return this.__p.bb.GetFloat(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170032BB RID: 12987
		// (get) Token: 0x0600C941 RID: 51521 RVA: 0x002FC0A8 File Offset: 0x002FA2A8
		public int WeaponScaleLength
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

		// Token: 0x0600C942 RID: 51522 RVA: 0x002FC0D4 File Offset: 0x002FA2D4
		public Span<float> GetWeaponScaleBytes()
		{
			return this.__p.__vector_as_span<float>(120, 4);
		}

		// Token: 0x0600C943 RID: 51523 RVA: 0x002FC0E4 File Offset: 0x002FA2E4
		public float[] GetWeaponScaleArray()
		{
			return this.__p.__vector_as_array<float>(120) ?? Array.Empty<float>();
		}

		// Token: 0x170032BC RID: 12988
		// (get) Token: 0x0600C944 RID: 51524 RVA: 0x002FC0FC File Offset: 0x002FA2FC
		public bool Intervene
		{
			get
			{
				int num = this.__p.__offset(122);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170032BD RID: 12989
		// (get) Token: 0x0600C945 RID: 51525 RVA: 0x002FC13C File Offset: 0x002FA33C
		public string CharacterVoice
		{
			get
			{
				int num = this.__p.__offset(124);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600C946 RID: 51526 RVA: 0x002FC174 File Offset: 0x002FA374
		public Span<byte> GetCharacterVoiceBytes()
		{
			return this.__p.__vector_as_span<byte>(124, 1);
		}

		// Token: 0x0600C947 RID: 51527 RVA: 0x002FC184 File Offset: 0x002FA384
		public byte[] GetCharacterVoiceArray()
		{
			return this.__p.__vector_as_array<byte>(124) ?? Array.Empty<byte>();
		}

		// Token: 0x170032BE RID: 12990
		// (get) Token: 0x0600C948 RID: 51528 RVA: 0x002FC19C File Offset: 0x002FA39C
		public int TrialRole
		{
			get
			{
				int num = this.__p.__offset(126);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170032BF RID: 12991
		// (get) Token: 0x0600C949 RID: 51529 RVA: 0x002FC1DC File Offset: 0x002FA3DC
		public bool IsAim
		{
			get
			{
				int num = this.__p.__offset(128);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170032C0 RID: 12992
		// (get) Token: 0x0600C94A RID: 51530 RVA: 0x002FC220 File Offset: 0x002FA420
		public int RoleGuide
		{
			get
			{
				int num = this.__p.__offset(130);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170032C1 RID: 12993
		// (get) Token: 0x0600C94B RID: 51531 RVA: 0x002FC260 File Offset: 0x002FA460
		public int RedDotDisableRule
		{
			get
			{
				int num = this.__p.__offset(132);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600C94C RID: 51532 RVA: 0x002FC2A0 File Offset: 0x002FA4A0
		public string SkinDamage(int j)
		{
			int num = this.__p.__offset(134);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170032C2 RID: 12994
		// (get) Token: 0x0600C94D RID: 51533 RVA: 0x002FC2E0 File Offset: 0x002FA4E0
		public int SkinDamageLength
		{
			get
			{
				int num = this.__p.__offset(134);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x170032C3 RID: 12995
		// (get) Token: 0x0600C94E RID: 51534 RVA: 0x002FC310 File Offset: 0x002FA510
		public bool HideHuLu
		{
			get
			{
				int num = this.__p.__offset(136);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170032C4 RID: 12996
		// (get) Token: 0x0600C94F RID: 51535 RVA: 0x002FC354 File Offset: 0x002FA554
		public bool EnableOperateSelfBgm
		{
			get
			{
				int num = this.__p.__offset(138);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170032C5 RID: 12997
		// (get) Token: 0x0600C950 RID: 51536 RVA: 0x002FC398 File Offset: 0x002FA598
		public string FormationSpineSkeletonData
		{
			get
			{
				int num = this.__p.__offset(140);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600C951 RID: 51537 RVA: 0x002FC3D3 File Offset: 0x002FA5D3
		public Span<byte> GetFormationSpineSkeletonDataBytes()
		{
			return this.__p.__vector_as_span<byte>(140, 1);
		}

		// Token: 0x0600C952 RID: 51538 RVA: 0x002FC3E6 File Offset: 0x002FA5E6
		public byte[] GetFormationSpineSkeletonDataArray()
		{
			return this.__p.__vector_as_array<byte>(140) ?? Array.Empty<byte>();
		}

		// Token: 0x170032C6 RID: 12998
		// (get) Token: 0x0600C953 RID: 51539 RVA: 0x002FC404 File Offset: 0x002FA604
		public string FormationSpineAtlas
		{
			get
			{
				int num = this.__p.__offset(142);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600C954 RID: 51540 RVA: 0x002FC43F File Offset: 0x002FA63F
		public Span<byte> GetFormationSpineAtlasBytes()
		{
			return this.__p.__vector_as_span<byte>(142, 1);
		}

		// Token: 0x0600C955 RID: 51541 RVA: 0x002FC452 File Offset: 0x002FA652
		public byte[] GetFormationSpineAtlasArray()
		{
			return this.__p.__vector_as_array<byte>(142) ?? Array.Empty<byte>();
		}

		// Token: 0x0600C956 RID: 51542 RVA: 0x002FC470 File Offset: 0x002FA670
		public DicIntInt? SpiloverCompensate(int j)
		{
			int num = this.__p.__offset(144);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170032C7 RID: 12999
		// (get) Token: 0x0600C957 RID: 51543 RVA: 0x002FC4D4 File Offset: 0x002FA6D4
		public int SpiloverCompensateLength
		{
			get
			{
				int num = this.__p.__offset(144);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x170032C8 RID: 13000
		// (get) Token: 0x0600C958 RID: 51544 RVA: 0x002FC504 File Offset: 0x002FA704
		public bool InstantAttributeBlend
		{
			get
			{
				int num = this.__p.__offset(146);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0600C959 RID: 51545 RVA: 0x002FC548 File Offset: 0x002FA748
		[NullableContext(1)]
		[Obsolete("已废弃，请使用ExchangeConsumeFrozenDict()缓存字典，遍历请使用ExchangeConsumeIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, int> ExchangeConsume()
		{
			return this.ExchangeConsumeIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x0600C95A RID: 51546 RVA: 0x002FC59E File Offset: 0x002FA79E
		[NullableContext(1)]
		public readonly IEnumerable<DicIntInt> ExchangeConsumeIter()
		{
			RoleInfo.<ExchangeConsumeIter>d__217 <ExchangeConsumeIter>d__ = new RoleInfo.<ExchangeConsumeIter>d__217(-2);
			<ExchangeConsumeIter>d__.<>3__<>4__this = this;
			return <ExchangeConsumeIter>d__;
		}

		// Token: 0x0600C95B RID: 51547 RVA: 0x002FC5B4 File Offset: 0x002FA7B4
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用ShowPropertyIter()或GetShowPropertyBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] ShowProperty()
		{
			RoleInfo roleInfo = this;
			return roleInfo.GetShowPropertyArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600C95C RID: 51548 RVA: 0x002FC5D8 File Offset: 0x002FA7D8
		[NullableContext(1)]
		public readonly IEnumerable<int> ShowPropertyIter()
		{
			RoleInfo.<ShowPropertyIter>d__219 <ShowPropertyIter>d__ = new RoleInfo.<ShowPropertyIter>d__219(-2);
			<ShowPropertyIter>d__.<>3__<>4__this = this;
			return <ShowPropertyIter>d__;
		}

		// Token: 0x0600C95D RID: 51549 RVA: 0x002FC5F0 File Offset: 0x002FA7F0
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用SkillBranchIdsIter()或GetSkillBranchIdsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] SkillBranchIds()
		{
			RoleInfo roleInfo = this;
			return roleInfo.GetSkillBranchIdsArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600C95E RID: 51550 RVA: 0x002FC614 File Offset: 0x002FA814
		[NullableContext(1)]
		public readonly IEnumerable<int> SkillBranchIdsIter()
		{
			RoleInfo.<SkillBranchIdsIter>d__221 <SkillBranchIdsIter>d__ = new RoleInfo.<SkillBranchIdsIter>d__221(-2);
			<SkillBranchIdsIter>d__.<>3__<>4__this = this;
			return <SkillBranchIdsIter>d__;
		}

		// Token: 0x0600C95F RID: 51551 RVA: 0x002FC629 File Offset: 0x002FA829
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用SkinDamageIter()或GetSkinDamageBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] SkinDamage()
		{
			return this.SkinDamageIter().ToArray<string>();
		}

		// Token: 0x0600C960 RID: 51552 RVA: 0x002FC636 File Offset: 0x002FA836
		[NullableContext(1)]
		public readonly IEnumerable<string> SkinDamageIter()
		{
			RoleInfo.<SkinDamageIter>d__223 <SkinDamageIter>d__ = new RoleInfo.<SkinDamageIter>d__223(-2);
			<SkinDamageIter>d__.<>3__<>4__this = this;
			return <SkinDamageIter>d__;
		}

		// Token: 0x0600C961 RID: 51553 RVA: 0x002FC64C File Offset: 0x002FA84C
		[NullableContext(1)]
		[Obsolete("已废弃，请使用SpilloverItemFrozenDict()缓存字典，遍历请使用SpilloverItemIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, int> SpilloverItem()
		{
			return this.SpilloverItemIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x0600C962 RID: 51554 RVA: 0x002FC6A2 File Offset: 0x002FA8A2
		[NullableContext(1)]
		public readonly IEnumerable<DicIntInt> SpilloverItemIter()
		{
			RoleInfo.<SpilloverItemIter>d__225 <SpilloverItemIter>d__ = new RoleInfo.<SpilloverItemIter>d__225(-2);
			<SpilloverItemIter>d__.<>3__<>4__this = this;
			return <SpilloverItemIter>d__;
		}

		// Token: 0x0600C963 RID: 51555 RVA: 0x002FC6B8 File Offset: 0x002FA8B8
		[NullableContext(1)]
		[Obsolete("已废弃，请使用SpiloverCompensateFrozenDict()缓存字典，遍历请使用SpiloverCompensateIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, int> SpiloverCompensate()
		{
			return this.SpiloverCompensateIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x0600C964 RID: 51556 RVA: 0x002FC70E File Offset: 0x002FA90E
		[NullableContext(1)]
		public readonly IEnumerable<DicIntInt> SpiloverCompensateIter()
		{
			RoleInfo.<SpiloverCompensateIter>d__227 <SpiloverCompensateIter>d__ = new RoleInfo.<SpiloverCompensateIter>d__227(-2);
			<SpiloverCompensateIter>d__.<>3__<>4__this = this;
			return <SpiloverCompensateIter>d__;
		}

		// Token: 0x0600C965 RID: 51557 RVA: 0x002FC724 File Offset: 0x002FA924
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用TagIter()或GetTagBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] Tag()
		{
			RoleInfo roleInfo = this;
			return roleInfo.GetTagArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600C966 RID: 51558 RVA: 0x002FC748 File Offset: 0x002FA948
		[NullableContext(1)]
		public readonly IEnumerable<int> TagIter()
		{
			RoleInfo.<TagIter>d__229 <TagIter>d__ = new RoleInfo.<TagIter>d__229(-2);
			<TagIter>d__.<>3__<>4__this = this;
			return <TagIter>d__;
		}

		// Token: 0x0600C967 RID: 51559 RVA: 0x002FC760 File Offset: 0x002FA960
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用WeaponScaleIter()或GetWeaponScaleBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly float[] WeaponScale()
		{
			RoleInfo roleInfo = this;
			return roleInfo.GetWeaponScaleArray() ?? Array.Empty<float>();
		}

		// Token: 0x0600C968 RID: 51560 RVA: 0x002FC784 File Offset: 0x002FA984
		[NullableContext(1)]
		public readonly IEnumerable<float> WeaponScaleIter()
		{
			RoleInfo.<WeaponScaleIter>d__231 <WeaponScaleIter>d__ = new RoleInfo.<WeaponScaleIter>d__231(-2);
			<WeaponScaleIter>d__.<>3__<>4__this = this;
			return <WeaponScaleIter>d__;
		}

		// Token: 0x0600C969 RID: 51561 RVA: 0x002FC79C File Offset: 0x002FA99C
		public int? GetExchangeConsume(int key)
		{
			this.EnsureExchangeConsumeCacheIfNeeded();
			int value;
			if (!this.ExchangeConsumeCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x0600C96A RID: 51562 RVA: 0x002FC7D0 File Offset: 0x002FA9D0
		public int? GetSpilloverItem(int key)
		{
			this.EnsureSpilloverItemCacheIfNeeded();
			int value;
			if (!this.SpilloverItemCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x0600C96B RID: 51563 RVA: 0x002FC804 File Offset: 0x002FAA04
		public int? GetSpiloverCompensate(int key)
		{
			this.EnsureSpiloverCompensateCacheIfNeeded();
			int value;
			if (!this.SpiloverCompensateCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x0600C96C RID: 51564 RVA: 0x002FC838 File Offset: 0x002FAA38
		private void EnsureExchangeConsumeCacheIfNeeded()
		{
			if (this.ExchangeConsumeCache != null)
			{
				return;
			}
			this.ExchangeConsumeCache = this.ExchangeConsumeIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x0600C96D RID: 51565 RVA: 0x002FC8A0 File Offset: 0x002FAAA0
		private void EnsureSpilloverItemCacheIfNeeded()
		{
			if (this.SpilloverItemCache != null)
			{
				return;
			}
			this.SpilloverItemCache = this.SpilloverItemIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x0600C96E RID: 51566 RVA: 0x002FC908 File Offset: 0x002FAB08
		private void EnsureSpiloverCompensateCacheIfNeeded()
		{
			if (this.SpiloverCompensateCache != null)
			{
				return;
			}
			this.SpiloverCompensateCache = this.SpiloverCompensateIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x0600C96F RID: 51567 RVA: 0x002FC96E File Offset: 0x002FAB6E
		[NullableContext(2)]
		public FrozenDictionary<int, int> GetExchangeConsumeFrozenDict(int key)
		{
			this.EnsureExchangeConsumeCacheIfNeeded();
			return this.ExchangeConsumeCache;
		}

		// Token: 0x0600C970 RID: 51568 RVA: 0x002FC97C File Offset: 0x002FAB7C
		[NullableContext(2)]
		public FrozenDictionary<int, int> GetSpilloverItemFrozenDict(int key)
		{
			this.EnsureSpilloverItemCacheIfNeeded();
			return this.SpilloverItemCache;
		}

		// Token: 0x0600C971 RID: 51569 RVA: 0x002FC98A File Offset: 0x002FAB8A
		[NullableContext(2)]
		public FrozenDictionary<int, int> GetSpiloverCompensateFrozenDict(int key)
		{
			this.EnsureSpiloverCompensateCacheIfNeeded();
			return this.SpiloverCompensateCache;
		}

		// Token: 0x0400514E RID: 20814
		private Table __p;

		// Token: 0x0400514F RID: 20815
		[Nullable(2)]
		private FrozenDictionary<int, int> ExchangeConsumeCache;

		// Token: 0x04005150 RID: 20816
		[Nullable(2)]
		private FrozenDictionary<int, int> SpilloverItemCache;

		// Token: 0x04005151 RID: 20817
		[Nullable(2)]
		private FrozenDictionary<int, int> SpiloverCompensateCache;
	}
}
