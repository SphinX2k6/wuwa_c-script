using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001138 RID: 4408
	public struct RoleInfo : IFlatbufferObject
	{
		// Token: 0x170032FB RID: 13051
		// (get) Token: 0x0600CF15 RID: 53013 RVA: 0x00316A0E File Offset: 0x00314C0E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600CF16 RID: 53014 RVA: 0x00316A1B File Offset: 0x00314C1B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600CF17 RID: 53015 RVA: 0x00316A24 File Offset: 0x00314C24
		public static RoleInfo GetRootAsRoleInfo(ByteBuffer _bb)
		{
			return RoleInfo.GetRootAsRoleInfo(_bb, default(RoleInfo));
		}

		// Token: 0x0600CF18 RID: 53016 RVA: 0x00316A40 File Offset: 0x00314C40
		public static RoleInfo GetRootAsRoleInfo(ByteBuffer _bb, RoleInfo obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600CF19 RID: 53017 RVA: 0x00316A5D File Offset: 0x00314C5D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600CF1A RID: 53018 RVA: 0x00316A6C File Offset: 0x00314C6C
		public RoleInfo __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170032FC RID: 13052
		// (get) Token: 0x0600CF1B RID: 53019 RVA: 0x00316A7C File Offset: 0x00314C7C
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

		// Token: 0x170032FD RID: 13053
		// (get) Token: 0x0600CF1C RID: 53020 RVA: 0x00316AB8 File Offset: 0x00314CB8
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

		// Token: 0x170032FE RID: 13054
		// (get) Token: 0x0600CF1D RID: 53021 RVA: 0x00316AF4 File Offset: 0x00314CF4
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

		// Token: 0x170032FF RID: 13055
		// (get) Token: 0x0600CF1E RID: 53022 RVA: 0x00316B30 File Offset: 0x00314D30
		public bool IsTrial
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17003300 RID: 13056
		// (get) Token: 0x0600CF1F RID: 53023 RVA: 0x00316B70 File Offset: 0x00314D70
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

		// Token: 0x0600CF20 RID: 53024 RVA: 0x00316BA8 File Offset: 0x00314DA8
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600CF21 RID: 53025 RVA: 0x00316BB8 File Offset: 0x00314DB8
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17003301 RID: 13057
		// (get) Token: 0x0600CF22 RID: 53026 RVA: 0x00316BD0 File Offset: 0x00314DD0
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

		// Token: 0x0600CF23 RID: 53027 RVA: 0x00316C08 File Offset: 0x00314E08
		public Span<byte> GetNickNameBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600CF24 RID: 53028 RVA: 0x00316C18 File Offset: 0x00314E18
		public byte[] GetNickNameArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17003302 RID: 13058
		// (get) Token: 0x0600CF25 RID: 53029 RVA: 0x00316C30 File Offset: 0x00314E30
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

		// Token: 0x0600CF26 RID: 53030 RVA: 0x00316C68 File Offset: 0x00314E68
		public Span<byte> GetIntroductionBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600CF27 RID: 53031 RVA: 0x00316C78 File Offset: 0x00314E78
		public byte[] GetIntroductionArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x0600CF28 RID: 53032 RVA: 0x00316C90 File Offset: 0x00314E90
		public int Tag(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003303 RID: 13059
		// (get) Token: 0x0600CF29 RID: 53033 RVA: 0x00316CD0 File Offset: 0x00314ED0
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

		// Token: 0x0600CF2A RID: 53034 RVA: 0x00316CFC File Offset: 0x00314EFC
		public Span<int> GetTagBytes()
		{
			return this.__p.__vector_as_span<int>(18, 4);
		}

		// Token: 0x0600CF2B RID: 53035 RVA: 0x00316D0C File Offset: 0x00314F0C
		public int[] GetTagArray()
		{
			return this.__p.__vector_as_array<int>(18) ?? Array.Empty<int>();
		}

		// Token: 0x17003304 RID: 13060
		// (get) Token: 0x0600CF2C RID: 53036 RVA: 0x00316D24 File Offset: 0x00314F24
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

		// Token: 0x17003305 RID: 13061
		// (get) Token: 0x0600CF2D RID: 53037 RVA: 0x00316D64 File Offset: 0x00314F64
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

		// Token: 0x17003306 RID: 13062
		// (get) Token: 0x0600CF2E RID: 53038 RVA: 0x00316DA4 File Offset: 0x00314FA4
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

		// Token: 0x0600CF2F RID: 53039 RVA: 0x00316DE4 File Offset: 0x00314FE4
		public int ShowProperty(int j)
		{
			int num = this.__p.__offset(26);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003307 RID: 13063
		// (get) Token: 0x0600CF30 RID: 53040 RVA: 0x00316E24 File Offset: 0x00315024
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

		// Token: 0x0600CF31 RID: 53041 RVA: 0x00316E50 File Offset: 0x00315050
		public Span<int> GetShowPropertyBytes()
		{
			return this.__p.__vector_as_span<int>(26, 4);
		}

		// Token: 0x0600CF32 RID: 53042 RVA: 0x00316E60 File Offset: 0x00315060
		public int[] GetShowPropertyArray()
		{
			return this.__p.__vector_as_array<int>(26) ?? Array.Empty<int>();
		}

		// Token: 0x17003308 RID: 13064
		// (get) Token: 0x0600CF33 RID: 53043 RVA: 0x00316E78 File Offset: 0x00315078
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

		// Token: 0x17003309 RID: 13065
		// (get) Token: 0x0600CF34 RID: 53044 RVA: 0x00316EB8 File Offset: 0x003150B8
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

		// Token: 0x1700330A RID: 13066
		// (get) Token: 0x0600CF35 RID: 53045 RVA: 0x00316EF8 File Offset: 0x003150F8
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

		// Token: 0x0600CF36 RID: 53046 RVA: 0x00316F30 File Offset: 0x00315130
		public Span<byte> GetRoleHeadIconCircleBytes()
		{
			return this.__p.__vector_as_span<byte>(32, 1);
		}

		// Token: 0x0600CF37 RID: 53047 RVA: 0x00316F40 File Offset: 0x00315140
		public byte[] GetRoleHeadIconCircleArray()
		{
			return this.__p.__vector_as_array<byte>(32) ?? Array.Empty<byte>();
		}

		// Token: 0x1700330B RID: 13067
		// (get) Token: 0x0600CF38 RID: 53048 RVA: 0x00316F58 File Offset: 0x00315158
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

		// Token: 0x0600CF39 RID: 53049 RVA: 0x00316F90 File Offset: 0x00315190
		public Span<byte> GetRoleHeadIconLargeBytes()
		{
			return this.__p.__vector_as_span<byte>(34, 1);
		}

		// Token: 0x0600CF3A RID: 53050 RVA: 0x00316FA0 File Offset: 0x003151A0
		public byte[] GetRoleHeadIconLargeArray()
		{
			return this.__p.__vector_as_array<byte>(34) ?? Array.Empty<byte>();
		}

		// Token: 0x1700330C RID: 13068
		// (get) Token: 0x0600CF3B RID: 53051 RVA: 0x00316FB8 File Offset: 0x003151B8
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

		// Token: 0x0600CF3C RID: 53052 RVA: 0x00316FF0 File Offset: 0x003151F0
		public Span<byte> GetRoleHeadIconBigBytes()
		{
			return this.__p.__vector_as_span<byte>(36, 1);
		}

		// Token: 0x0600CF3D RID: 53053 RVA: 0x00317000 File Offset: 0x00315200
		public byte[] GetRoleHeadIconBigArray()
		{
			return this.__p.__vector_as_array<byte>(36) ?? Array.Empty<byte>();
		}

		// Token: 0x1700330D RID: 13069
		// (get) Token: 0x0600CF3E RID: 53054 RVA: 0x00317018 File Offset: 0x00315218
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

		// Token: 0x0600CF3F RID: 53055 RVA: 0x00317050 File Offset: 0x00315250
		public Span<byte> GetCardBytes()
		{
			return this.__p.__vector_as_span<byte>(38, 1);
		}

		// Token: 0x0600CF40 RID: 53056 RVA: 0x00317060 File Offset: 0x00315260
		public byte[] GetCardArray()
		{
			return this.__p.__vector_as_array<byte>(38) ?? Array.Empty<byte>();
		}

		// Token: 0x1700330E RID: 13070
		// (get) Token: 0x0600CF41 RID: 53057 RVA: 0x00317078 File Offset: 0x00315278
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

		// Token: 0x0600CF42 RID: 53058 RVA: 0x003170B0 File Offset: 0x003152B0
		public Span<byte> GetRoleHeadIconBytes()
		{
			return this.__p.__vector_as_span<byte>(40, 1);
		}

		// Token: 0x0600CF43 RID: 53059 RVA: 0x003170C0 File Offset: 0x003152C0
		public byte[] GetRoleHeadIconArray()
		{
			return this.__p.__vector_as_array<byte>(40) ?? Array.Empty<byte>();
		}

		// Token: 0x1700330F RID: 13071
		// (get) Token: 0x0600CF44 RID: 53060 RVA: 0x003170D8 File Offset: 0x003152D8
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

		// Token: 0x0600CF45 RID: 53061 RVA: 0x00317110 File Offset: 0x00315310
		public Span<byte> GetFormationRoleCardBytes()
		{
			return this.__p.__vector_as_span<byte>(42, 1);
		}

		// Token: 0x0600CF46 RID: 53062 RVA: 0x00317120 File Offset: 0x00315320
		public byte[] GetFormationRoleCardArray()
		{
			return this.__p.__vector_as_array<byte>(42) ?? Array.Empty<byte>();
		}

		// Token: 0x17003310 RID: 13072
		// (get) Token: 0x0600CF47 RID: 53063 RVA: 0x00317138 File Offset: 0x00315338
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

		// Token: 0x0600CF48 RID: 53064 RVA: 0x00317170 File Offset: 0x00315370
		public Span<byte> GetRoleStandBytes()
		{
			return this.__p.__vector_as_span<byte>(44, 1);
		}

		// Token: 0x0600CF49 RID: 53065 RVA: 0x00317180 File Offset: 0x00315380
		public byte[] GetRoleStandArray()
		{
			return this.__p.__vector_as_array<byte>(44) ?? Array.Empty<byte>();
		}

		// Token: 0x17003311 RID: 13073
		// (get) Token: 0x0600CF4A RID: 53066 RVA: 0x00317198 File Offset: 0x00315398
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

		// Token: 0x0600CF4B RID: 53067 RVA: 0x003171D0 File Offset: 0x003153D0
		public Span<byte> GetRolePortraitBytes()
		{
			return this.__p.__vector_as_span<byte>(46, 1);
		}

		// Token: 0x0600CF4C RID: 53068 RVA: 0x003171E0 File Offset: 0x003153E0
		public byte[] GetRolePortraitArray()
		{
			return this.__p.__vector_as_array<byte>(46) ?? Array.Empty<byte>();
		}

		// Token: 0x0600CF4D RID: 53069 RVA: 0x003171F8 File Offset: 0x003153F8
		public DicIntInt? SpilloverItem(int j)
		{
			int num = this.__p.__offset(48);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17003312 RID: 13074
		// (get) Token: 0x0600CF4E RID: 53070 RVA: 0x0031725C File Offset: 0x0031545C
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

		// Token: 0x17003313 RID: 13075
		// (get) Token: 0x0600CF4F RID: 53071 RVA: 0x00317288 File Offset: 0x00315488
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

		// Token: 0x17003314 RID: 13076
		// (get) Token: 0x0600CF50 RID: 53072 RVA: 0x003172C8 File Offset: 0x003154C8
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

		// Token: 0x17003315 RID: 13077
		// (get) Token: 0x0600CF51 RID: 53073 RVA: 0x00317308 File Offset: 0x00315508
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

		// Token: 0x0600CF52 RID: 53074 RVA: 0x00317340 File Offset: 0x00315540
		public Span<byte> GetRoleBodyBytes()
		{
			return this.__p.__vector_as_span<byte>(54, 1);
		}

		// Token: 0x0600CF53 RID: 53075 RVA: 0x00317350 File Offset: 0x00315550
		public byte[] GetRoleBodyArray()
		{
			return this.__p.__vector_as_array<byte>(54) ?? Array.Empty<byte>();
		}

		// Token: 0x17003316 RID: 13078
		// (get) Token: 0x0600CF54 RID: 53076 RVA: 0x00317368 File Offset: 0x00315568
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

		// Token: 0x17003317 RID: 13079
		// (get) Token: 0x0600CF55 RID: 53077 RVA: 0x003173A8 File Offset: 0x003155A8
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

		// Token: 0x17003318 RID: 13080
		// (get) Token: 0x0600CF56 RID: 53078 RVA: 0x003173E8 File Offset: 0x003155E8
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

		// Token: 0x0600CF57 RID: 53079 RVA: 0x00317420 File Offset: 0x00315620
		public Span<byte> GetCameraConfigBytes()
		{
			return this.__p.__vector_as_span<byte>(60, 1);
		}

		// Token: 0x0600CF58 RID: 53080 RVA: 0x00317430 File Offset: 0x00315630
		public byte[] GetCameraConfigArray()
		{
			return this.__p.__vector_as_array<byte>(60) ?? Array.Empty<byte>();
		}

		// Token: 0x17003319 RID: 13081
		// (get) Token: 0x0600CF59 RID: 53081 RVA: 0x00317448 File Offset: 0x00315648
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

		// Token: 0x1700331A RID: 13082
		// (get) Token: 0x0600CF5A RID: 53082 RVA: 0x0031748C File Offset: 0x0031568C
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

		// Token: 0x1700331B RID: 13083
		// (get) Token: 0x0600CF5B RID: 53083 RVA: 0x003174CC File Offset: 0x003156CC
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

		// Token: 0x1700331C RID: 13084
		// (get) Token: 0x0600CF5C RID: 53084 RVA: 0x0031750C File Offset: 0x0031570C
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

		// Token: 0x1700331D RID: 13085
		// (get) Token: 0x0600CF5D RID: 53085 RVA: 0x0031754C File Offset: 0x0031574C
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

		// Token: 0x1700331E RID: 13086
		// (get) Token: 0x0600CF5E RID: 53086 RVA: 0x0031758C File Offset: 0x0031578C
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

		// Token: 0x1700331F RID: 13087
		// (get) Token: 0x0600CF5F RID: 53087 RVA: 0x003175CC File Offset: 0x003157CC
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

		// Token: 0x17003320 RID: 13088
		// (get) Token: 0x0600CF60 RID: 53088 RVA: 0x0031760C File Offset: 0x0031580C
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

		// Token: 0x17003321 RID: 13089
		// (get) Token: 0x0600CF61 RID: 53089 RVA: 0x0031764C File Offset: 0x0031584C
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

		// Token: 0x0600CF62 RID: 53090 RVA: 0x0031768C File Offset: 0x0031588C
		public int SkillBranchIds(int j)
		{
			int num = this.__p.__offset(80);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003322 RID: 13090
		// (get) Token: 0x0600CF63 RID: 53091 RVA: 0x003176CC File Offset: 0x003158CC
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

		// Token: 0x0600CF64 RID: 53092 RVA: 0x003176F8 File Offset: 0x003158F8
		public Span<int> GetSkillBranchIdsBytes()
		{
			return this.__p.__vector_as_span<int>(80, 4);
		}

		// Token: 0x0600CF65 RID: 53093 RVA: 0x00317708 File Offset: 0x00315908
		public int[] GetSkillBranchIdsArray()
		{
			return this.__p.__vector_as_array<int>(80) ?? Array.Empty<int>();
		}

		// Token: 0x17003323 RID: 13091
		// (get) Token: 0x0600CF66 RID: 53094 RVA: 0x00317720 File Offset: 0x00315920
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

		// Token: 0x17003324 RID: 13092
		// (get) Token: 0x0600CF67 RID: 53095 RVA: 0x00317760 File Offset: 0x00315960
		public bool IsShow
		{
			get
			{
				int num = this.__p.__offset(84);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0600CF68 RID: 53096 RVA: 0x003177A0 File Offset: 0x003159A0
		public DicIntInt? ExchangeConsume(int j)
		{
			int num = this.__p.__offset(86);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17003325 RID: 13093
		// (get) Token: 0x0600CF69 RID: 53097 RVA: 0x00317804 File Offset: 0x00315A04
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

		// Token: 0x17003326 RID: 13094
		// (get) Token: 0x0600CF6A RID: 53098 RVA: 0x00317830 File Offset: 0x00315A30
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

		// Token: 0x17003327 RID: 13095
		// (get) Token: 0x0600CF6B RID: 53099 RVA: 0x00317870 File Offset: 0x00315A70
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

		// Token: 0x17003328 RID: 13096
		// (get) Token: 0x0600CF6C RID: 53100 RVA: 0x003178B0 File Offset: 0x00315AB0
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

		// Token: 0x0600CF6D RID: 53101 RVA: 0x003178E8 File Offset: 0x00315AE8
		public Span<byte> GetSkillDAPathBytes()
		{
			return this.__p.__vector_as_span<byte>(92, 1);
		}

		// Token: 0x0600CF6E RID: 53102 RVA: 0x003178F8 File Offset: 0x00315AF8
		public byte[] GetSkillDAPathArray()
		{
			return this.__p.__vector_as_array<byte>(92) ?? Array.Empty<byte>();
		}

		// Token: 0x17003329 RID: 13097
		// (get) Token: 0x0600CF6F RID: 53103 RVA: 0x00317910 File Offset: 0x00315B10
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

		// Token: 0x0600CF70 RID: 53104 RVA: 0x00317948 File Offset: 0x00315B48
		public Span<byte> GetSkillLockDAPathBytes()
		{
			return this.__p.__vector_as_span<byte>(94, 1);
		}

		// Token: 0x0600CF71 RID: 53105 RVA: 0x00317958 File Offset: 0x00315B58
		public byte[] GetSkillLockDAPathArray()
		{
			return this.__p.__vector_as_array<byte>(94) ?? Array.Empty<byte>();
		}

		// Token: 0x1700332A RID: 13098
		// (get) Token: 0x0600CF72 RID: 53106 RVA: 0x00317970 File Offset: 0x00315B70
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

		// Token: 0x0600CF73 RID: 53107 RVA: 0x003179A8 File Offset: 0x00315BA8
		public Span<byte> GetUiScenePerformanceABPBytes()
		{
			return this.__p.__vector_as_span<byte>(96, 1);
		}

		// Token: 0x0600CF74 RID: 53108 RVA: 0x003179B8 File Offset: 0x00315BB8
		public byte[] GetUiScenePerformanceABPArray()
		{
			return this.__p.__vector_as_array<byte>(96) ?? Array.Empty<byte>();
		}

		// Token: 0x1700332B RID: 13099
		// (get) Token: 0x0600CF75 RID: 53109 RVA: 0x003179D0 File Offset: 0x00315BD0
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

		// Token: 0x1700332C RID: 13100
		// (get) Token: 0x0600CF76 RID: 53110 RVA: 0x00317A10 File Offset: 0x00315C10
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

		// Token: 0x1700332D RID: 13101
		// (get) Token: 0x0600CF77 RID: 53111 RVA: 0x00317A50 File Offset: 0x00315C50
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

		// Token: 0x0600CF78 RID: 53112 RVA: 0x00317A88 File Offset: 0x00315C88
		public Span<byte> GetSkillEffectDABytes()
		{
			return this.__p.__vector_as_span<byte>(102, 1);
		}

		// Token: 0x0600CF79 RID: 53113 RVA: 0x00317A98 File Offset: 0x00315C98
		public byte[] GetSkillEffectDAArray()
		{
			return this.__p.__vector_as_array<byte>(102) ?? Array.Empty<byte>();
		}

		// Token: 0x1700332E RID: 13102
		// (get) Token: 0x0600CF7A RID: 53114 RVA: 0x00317AB0 File Offset: 0x00315CB0
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

		// Token: 0x0600CF7B RID: 53115 RVA: 0x00317AE8 File Offset: 0x00315CE8
		public Span<byte> GetFootStepStateBytes()
		{
			return this.__p.__vector_as_span<byte>(104, 1);
		}

		// Token: 0x0600CF7C RID: 53116 RVA: 0x00317AF8 File Offset: 0x00315CF8
		public byte[] GetFootStepStateArray()
		{
			return this.__p.__vector_as_array<byte>(104) ?? Array.Empty<byte>();
		}

		// Token: 0x1700332F RID: 13103
		// (get) Token: 0x0600CF7D RID: 53117 RVA: 0x00317B10 File Offset: 0x00315D10
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

		// Token: 0x17003330 RID: 13104
		// (get) Token: 0x0600CF7E RID: 53118 RVA: 0x00317B50 File Offset: 0x00315D50
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

		// Token: 0x0600CF7F RID: 53119 RVA: 0x00317B88 File Offset: 0x00315D88
		public Span<byte> GetAttributesDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(108, 1);
		}

		// Token: 0x0600CF80 RID: 53120 RVA: 0x00317B98 File Offset: 0x00315D98
		public byte[] GetAttributesDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(108) ?? Array.Empty<byte>();
		}

		// Token: 0x17003331 RID: 13105
		// (get) Token: 0x0600CF81 RID: 53121 RVA: 0x00317BB0 File Offset: 0x00315DB0
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

		// Token: 0x0600CF82 RID: 53122 RVA: 0x00317BE8 File Offset: 0x00315DE8
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(110, 1);
		}

		// Token: 0x0600CF83 RID: 53123 RVA: 0x00317BF8 File Offset: 0x00315DF8
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(110) ?? Array.Empty<byte>();
		}

		// Token: 0x17003332 RID: 13106
		// (get) Token: 0x0600CF84 RID: 53124 RVA: 0x00317C10 File Offset: 0x00315E10
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

		// Token: 0x17003333 RID: 13107
		// (get) Token: 0x0600CF85 RID: 53125 RVA: 0x00317C50 File Offset: 0x00315E50
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

		// Token: 0x0600CF86 RID: 53126 RVA: 0x00317C88 File Offset: 0x00315E88
		public Span<byte> GetObtainedShowDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(114, 1);
		}

		// Token: 0x0600CF87 RID: 53127 RVA: 0x00317C98 File Offset: 0x00315E98
		public byte[] GetObtainedShowDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(114) ?? Array.Empty<byte>();
		}

		// Token: 0x17003334 RID: 13108
		// (get) Token: 0x0600CF88 RID: 53128 RVA: 0x00317CB0 File Offset: 0x00315EB0
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

		// Token: 0x17003335 RID: 13109
		// (get) Token: 0x0600CF89 RID: 53129 RVA: 0x00317CF0 File Offset: 0x00315EF0
		public bool ShowInBag
		{
			get
			{
				int num = this.__p.__offset(118);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0600CF8A RID: 53130 RVA: 0x00317D30 File Offset: 0x00315F30
		public float WeaponScale(int j)
		{
			int num = this.__p.__offset(120);
			if (num == 0)
			{
				return 0f;
			}
			return this.__p.bb.GetFloat(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003336 RID: 13110
		// (get) Token: 0x0600CF8B RID: 53131 RVA: 0x00317D74 File Offset: 0x00315F74
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

		// Token: 0x0600CF8C RID: 53132 RVA: 0x00317DA0 File Offset: 0x00315FA0
		public Span<float> GetWeaponScaleBytes()
		{
			return this.__p.__vector_as_span<float>(120, 4);
		}

		// Token: 0x0600CF8D RID: 53133 RVA: 0x00317DB0 File Offset: 0x00315FB0
		public float[] GetWeaponScaleArray()
		{
			return this.__p.__vector_as_array<float>(120) ?? Array.Empty<float>();
		}

		// Token: 0x17003337 RID: 13111
		// (get) Token: 0x0600CF8E RID: 53134 RVA: 0x00317DC8 File Offset: 0x00315FC8
		public bool Intervene
		{
			get
			{
				int num = this.__p.__offset(122);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17003338 RID: 13112
		// (get) Token: 0x0600CF8F RID: 53135 RVA: 0x00317E08 File Offset: 0x00316008
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

		// Token: 0x0600CF90 RID: 53136 RVA: 0x00317E40 File Offset: 0x00316040
		public Span<byte> GetCharacterVoiceBytes()
		{
			return this.__p.__vector_as_span<byte>(124, 1);
		}

		// Token: 0x0600CF91 RID: 53137 RVA: 0x00317E50 File Offset: 0x00316050
		public byte[] GetCharacterVoiceArray()
		{
			return this.__p.__vector_as_array<byte>(124) ?? Array.Empty<byte>();
		}

		// Token: 0x17003339 RID: 13113
		// (get) Token: 0x0600CF92 RID: 53138 RVA: 0x00317E68 File Offset: 0x00316068
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

		// Token: 0x1700333A RID: 13114
		// (get) Token: 0x0600CF93 RID: 53139 RVA: 0x00317EA8 File Offset: 0x003160A8
		public bool IsAim
		{
			get
			{
				int num = this.__p.__offset(128);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700333B RID: 13115
		// (get) Token: 0x0600CF94 RID: 53140 RVA: 0x00317EEC File Offset: 0x003160EC
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

		// Token: 0x1700333C RID: 13116
		// (get) Token: 0x0600CF95 RID: 53141 RVA: 0x00317F2C File Offset: 0x0031612C
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

		// Token: 0x0600CF96 RID: 53142 RVA: 0x00317F6C File Offset: 0x0031616C
		public string SkinDamage(int j)
		{
			int num = this.__p.__offset(134);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700333D RID: 13117
		// (get) Token: 0x0600CF97 RID: 53143 RVA: 0x00317FAC File Offset: 0x003161AC
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

		// Token: 0x1700333E RID: 13118
		// (get) Token: 0x0600CF98 RID: 53144 RVA: 0x00317FDC File Offset: 0x003161DC
		public bool HideHuLu
		{
			get
			{
				int num = this.__p.__offset(136);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700333F RID: 13119
		// (get) Token: 0x0600CF99 RID: 53145 RVA: 0x00318020 File Offset: 0x00316220
		public bool EnableOperateSelfBgm
		{
			get
			{
				int num = this.__p.__offset(138);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17003340 RID: 13120
		// (get) Token: 0x0600CF9A RID: 53146 RVA: 0x00318064 File Offset: 0x00316264
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

		// Token: 0x0600CF9B RID: 53147 RVA: 0x0031809F File Offset: 0x0031629F
		public Span<byte> GetFormationSpineSkeletonDataBytes()
		{
			return this.__p.__vector_as_span<byte>(140, 1);
		}

		// Token: 0x0600CF9C RID: 53148 RVA: 0x003180B2 File Offset: 0x003162B2
		public byte[] GetFormationSpineSkeletonDataArray()
		{
			return this.__p.__vector_as_array<byte>(140) ?? Array.Empty<byte>();
		}

		// Token: 0x17003341 RID: 13121
		// (get) Token: 0x0600CF9D RID: 53149 RVA: 0x003180D0 File Offset: 0x003162D0
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

		// Token: 0x0600CF9E RID: 53150 RVA: 0x0031810B File Offset: 0x0031630B
		public Span<byte> GetFormationSpineAtlasBytes()
		{
			return this.__p.__vector_as_span<byte>(142, 1);
		}

		// Token: 0x0600CF9F RID: 53151 RVA: 0x0031811E File Offset: 0x0031631E
		public byte[] GetFormationSpineAtlasArray()
		{
			return this.__p.__vector_as_array<byte>(142) ?? Array.Empty<byte>();
		}

		// Token: 0x0600CFA0 RID: 53152 RVA: 0x0031813C File Offset: 0x0031633C
		public DicIntInt? SpiloverCompensate(int j)
		{
			int num = this.__p.__offset(144);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17003342 RID: 13122
		// (get) Token: 0x0600CFA1 RID: 53153 RVA: 0x003181A0 File Offset: 0x003163A0
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

		// Token: 0x17003343 RID: 13123
		// (get) Token: 0x0600CFA2 RID: 53154 RVA: 0x003181D0 File Offset: 0x003163D0
		public bool InstantAttributeBlend
		{
			get
			{
				int num = this.__p.__offset(146);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0600CFA3 RID: 53155 RVA: 0x00318214 File Offset: 0x00316414
		public int RoleSubType(int j)
		{
			int num = this.__p.__offset(148);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003344 RID: 13124
		// (get) Token: 0x0600CFA4 RID: 53156 RVA: 0x00318258 File Offset: 0x00316458
		public int RoleSubTypeLength
		{
			get
			{
				int num = this.__p.__offset(148);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600CFA5 RID: 53157 RVA: 0x00318287 File Offset: 0x00316487
		public Span<int> GetRoleSubTypeBytes()
		{
			return this.__p.__vector_as_span<int>(148, 4);
		}

		// Token: 0x0600CFA6 RID: 53158 RVA: 0x0031829A File Offset: 0x0031649A
		public int[] GetRoleSubTypeArray()
		{
			return this.__p.__vector_as_array<int>(148) ?? Array.Empty<int>();
		}

		// Token: 0x0600CFA7 RID: 53159 RVA: 0x003182B8 File Offset: 0x003164B8
		[NullableContext(1)]
		public Dictionary<int, int> ExchangeConsume()
		{
			return this.ExchangeConsumeIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x0600CFA8 RID: 53160 RVA: 0x0031830E File Offset: 0x0031650E
		[NullableContext(1)]
		public IEnumerable<DicIntInt> ExchangeConsumeIter()
		{
			RoleInfo.<ExchangeConsumeIter>d__222 <ExchangeConsumeIter>d__ = new RoleInfo.<ExchangeConsumeIter>d__222(-2);
			<ExchangeConsumeIter>d__.<>3__<>4__this = this;
			return <ExchangeConsumeIter>d__;
		}

		// Token: 0x0600CFA9 RID: 53161 RVA: 0x00318323 File Offset: 0x00316523
		[NullableContext(1)]
		public int[] RoleSubType()
		{
			return this.GetRoleSubTypeArray();
		}

		// Token: 0x0600CFAA RID: 53162 RVA: 0x0031832B File Offset: 0x0031652B
		[NullableContext(1)]
		public IEnumerable<int> RoleSubTypeIter()
		{
			RoleInfo.<RoleSubTypeIter>d__224 <RoleSubTypeIter>d__ = new RoleInfo.<RoleSubTypeIter>d__224(-2);
			<RoleSubTypeIter>d__.<>3__<>4__this = this;
			return <RoleSubTypeIter>d__;
		}

		// Token: 0x0600CFAB RID: 53163 RVA: 0x00318340 File Offset: 0x00316540
		[NullableContext(1)]
		public int[] ShowProperty()
		{
			return this.GetShowPropertyArray();
		}

		// Token: 0x0600CFAC RID: 53164 RVA: 0x00318348 File Offset: 0x00316548
		[NullableContext(1)]
		public IEnumerable<int> ShowPropertyIter()
		{
			RoleInfo.<ShowPropertyIter>d__226 <ShowPropertyIter>d__ = new RoleInfo.<ShowPropertyIter>d__226(-2);
			<ShowPropertyIter>d__.<>3__<>4__this = this;
			return <ShowPropertyIter>d__;
		}

		// Token: 0x0600CFAD RID: 53165 RVA: 0x0031835D File Offset: 0x0031655D
		[NullableContext(1)]
		public int[] SkillBranchIds()
		{
			return this.GetSkillBranchIdsArray();
		}

		// Token: 0x0600CFAE RID: 53166 RVA: 0x00318365 File Offset: 0x00316565
		[NullableContext(1)]
		public IEnumerable<int> SkillBranchIdsIter()
		{
			RoleInfo.<SkillBranchIdsIter>d__228 <SkillBranchIdsIter>d__ = new RoleInfo.<SkillBranchIdsIter>d__228(-2);
			<SkillBranchIdsIter>d__.<>3__<>4__this = this;
			return <SkillBranchIdsIter>d__;
		}

		// Token: 0x0600CFAF RID: 53167 RVA: 0x0031837A File Offset: 0x0031657A
		[NullableContext(1)]
		public string[] SkinDamage()
		{
			return this.SkinDamageIter().ToArray<string>();
		}

		// Token: 0x0600CFB0 RID: 53168 RVA: 0x00318387 File Offset: 0x00316587
		[NullableContext(1)]
		public IEnumerable<string> SkinDamageIter()
		{
			RoleInfo.<SkinDamageIter>d__230 <SkinDamageIter>d__ = new RoleInfo.<SkinDamageIter>d__230(-2);
			<SkinDamageIter>d__.<>3__<>4__this = this;
			return <SkinDamageIter>d__;
		}

		// Token: 0x0600CFB1 RID: 53169 RVA: 0x0031839C File Offset: 0x0031659C
		[NullableContext(1)]
		public Dictionary<int, int> SpilloverItem()
		{
			return this.SpilloverItemIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x0600CFB2 RID: 53170 RVA: 0x003183F2 File Offset: 0x003165F2
		[NullableContext(1)]
		public IEnumerable<DicIntInt> SpilloverItemIter()
		{
			RoleInfo.<SpilloverItemIter>d__232 <SpilloverItemIter>d__ = new RoleInfo.<SpilloverItemIter>d__232(-2);
			<SpilloverItemIter>d__.<>3__<>4__this = this;
			return <SpilloverItemIter>d__;
		}

		// Token: 0x0600CFB3 RID: 53171 RVA: 0x00318408 File Offset: 0x00316608
		[NullableContext(1)]
		public Dictionary<int, int> SpiloverCompensate()
		{
			return this.SpiloverCompensateIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x0600CFB4 RID: 53172 RVA: 0x0031845E File Offset: 0x0031665E
		[NullableContext(1)]
		public IEnumerable<DicIntInt> SpiloverCompensateIter()
		{
			RoleInfo.<SpiloverCompensateIter>d__234 <SpiloverCompensateIter>d__ = new RoleInfo.<SpiloverCompensateIter>d__234(-2);
			<SpiloverCompensateIter>d__.<>3__<>4__this = this;
			return <SpiloverCompensateIter>d__;
		}

		// Token: 0x0600CFB5 RID: 53173 RVA: 0x00318473 File Offset: 0x00316673
		[NullableContext(1)]
		public int[] Tag()
		{
			return this.GetTagArray();
		}

		// Token: 0x0600CFB6 RID: 53174 RVA: 0x0031847B File Offset: 0x0031667B
		[NullableContext(1)]
		public IEnumerable<int> TagIter()
		{
			RoleInfo.<TagIter>d__236 <TagIter>d__ = new RoleInfo.<TagIter>d__236(-2);
			<TagIter>d__.<>3__<>4__this = this;
			return <TagIter>d__;
		}

		// Token: 0x0600CFB7 RID: 53175 RVA: 0x00318490 File Offset: 0x00316690
		[NullableContext(1)]
		public float[] WeaponScale()
		{
			return this.GetWeaponScaleArray();
		}

		// Token: 0x0600CFB8 RID: 53176 RVA: 0x00318498 File Offset: 0x00316698
		[NullableContext(1)]
		public IEnumerable<float> WeaponScaleIter()
		{
			RoleInfo.<WeaponScaleIter>d__238 <WeaponScaleIter>d__ = new RoleInfo.<WeaponScaleIter>d__238(-2);
			<WeaponScaleIter>d__.<>3__<>4__this = this;
			return <WeaponScaleIter>d__;
		}

		// Token: 0x0600CFB9 RID: 53177 RVA: 0x003184B0 File Offset: 0x003166B0
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

		// Token: 0x0600CFBA RID: 53178 RVA: 0x003184E4 File Offset: 0x003166E4
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

		// Token: 0x0600CFBB RID: 53179 RVA: 0x00318518 File Offset: 0x00316718
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

		// Token: 0x0600CFBC RID: 53180 RVA: 0x0031854C File Offset: 0x0031674C
		private void EnsureExchangeConsumeCacheIfNeeded()
		{
			if (this.ExchangeConsumeCache != null)
			{
				return;
			}
			this.ExchangeConsumeCache = this.ExchangeConsumeIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x0600CFBD RID: 53181 RVA: 0x003185B4 File Offset: 0x003167B4
		private void EnsureSpilloverItemCacheIfNeeded()
		{
			if (this.SpilloverItemCache != null)
			{
				return;
			}
			this.SpilloverItemCache = this.SpilloverItemIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x0600CFBE RID: 53182 RVA: 0x0031861C File Offset: 0x0031681C
		private void EnsureSpiloverCompensateCacheIfNeeded()
		{
			if (this.SpiloverCompensateCache != null)
			{
				return;
			}
			this.SpiloverCompensateCache = this.SpiloverCompensateIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x0600CFBF RID: 53183 RVA: 0x00318682 File Offset: 0x00316882
		[NullableContext(1)]
		public FrozenDictionary<int, int> GetExchangeConsumeFrozenDict()
		{
			this.EnsureExchangeConsumeCacheIfNeeded();
			return this.ExchangeConsumeCache;
		}

		// Token: 0x0600CFC0 RID: 53184 RVA: 0x00318690 File Offset: 0x00316890
		[NullableContext(1)]
		public FrozenDictionary<int, int> GetSpilloverItemFrozenDict()
		{
			this.EnsureSpilloverItemCacheIfNeeded();
			return this.SpilloverItemCache;
		}

		// Token: 0x0600CFC1 RID: 53185 RVA: 0x0031869E File Offset: 0x0031689E
		[NullableContext(1)]
		public FrozenDictionary<int, int> GetSpiloverCompensateFrozenDict()
		{
			this.EnsureSpiloverCompensateCacheIfNeeded();
			return this.SpiloverCompensateCache;
		}

		// Token: 0x04005736 RID: 22326
		private Table __p;

		// Token: 0x04005737 RID: 22327
		[Nullable(2)]
		private FrozenDictionary<int, int> ExchangeConsumeCache;

		// Token: 0x04005738 RID: 22328
		[Nullable(2)]
		private FrozenDictionary<int, int> SpilloverItemCache;

		// Token: 0x04005739 RID: 22329
		[Nullable(2)]
		private FrozenDictionary<int, int> SpiloverCompensateCache;
	}
}
