using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000CB1 RID: 3249
	public struct DangoBrawlRole : IFlatbufferObject
	{
		// Token: 0x17000BB8 RID: 3000
		// (get) Token: 0x060064EF RID: 25839 RVA: 0x0022C031 File Offset: 0x0022A231
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060064F0 RID: 25840 RVA: 0x0022C03E File Offset: 0x0022A23E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060064F1 RID: 25841 RVA: 0x0022C048 File Offset: 0x0022A248
		public static DangoBrawlRole GetRootAsDangoBrawlRole(ByteBuffer _bb)
		{
			return DangoBrawlRole.GetRootAsDangoBrawlRole(_bb, default(DangoBrawlRole));
		}

		// Token: 0x060064F2 RID: 25842 RVA: 0x0022C064 File Offset: 0x0022A264
		public static DangoBrawlRole GetRootAsDangoBrawlRole(ByteBuffer _bb, DangoBrawlRole obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060064F3 RID: 25843 RVA: 0x0022C081 File Offset: 0x0022A281
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060064F4 RID: 25844 RVA: 0x0022C090 File Offset: 0x0022A290
		public DangoBrawlRole __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000BB9 RID: 3001
		// (get) Token: 0x060064F5 RID: 25845 RVA: 0x0022C0A0 File Offset: 0x0022A2A0
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

		// Token: 0x17000BBA RID: 3002
		// (get) Token: 0x060064F6 RID: 25846 RVA: 0x0022C0DC File Offset: 0x0022A2DC
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

		// Token: 0x17000BBB RID: 3003
		// (get) Token: 0x060064F7 RID: 25847 RVA: 0x0022C118 File Offset: 0x0022A318
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

		// Token: 0x17000BBC RID: 3004
		// (get) Token: 0x060064F8 RID: 25848 RVA: 0x0022C154 File Offset: 0x0022A354
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

		// Token: 0x17000BBD RID: 3005
		// (get) Token: 0x060064F9 RID: 25849 RVA: 0x0022C194 File Offset: 0x0022A394
		public bool NoSpeItemLimit
		{
			get
			{
				int num = this.__p.__offset(12);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17000BBE RID: 3006
		// (get) Token: 0x060064FA RID: 25850 RVA: 0x0022C1D4 File Offset: 0x0022A3D4
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

		// Token: 0x17000BBF RID: 3007
		// (get) Token: 0x060064FB RID: 25851 RVA: 0x0022C214 File Offset: 0x0022A414
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

		// Token: 0x17000BC0 RID: 3008
		// (get) Token: 0x060064FC RID: 25852 RVA: 0x0022C254 File Offset: 0x0022A454
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

		// Token: 0x060064FD RID: 25853 RVA: 0x0022C28C File Offset: 0x0022A48C
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x060064FE RID: 25854 RVA: 0x0022C29C File Offset: 0x0022A49C
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x17000BC1 RID: 3009
		// (get) Token: 0x060064FF RID: 25855 RVA: 0x0022C2B4 File Offset: 0x0022A4B4
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

		// Token: 0x06006500 RID: 25856 RVA: 0x0022C2EC File Offset: 0x0022A4EC
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x06006501 RID: 25857 RVA: 0x0022C2FC File Offset: 0x0022A4FC
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x17000BC2 RID: 3010
		// (get) Token: 0x06006502 RID: 25858 RVA: 0x0022C314 File Offset: 0x0022A514
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

		// Token: 0x06006503 RID: 25859 RVA: 0x0022C34C File Offset: 0x0022A54C
		public Span<byte> GetUnlockCondDescBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x06006504 RID: 25860 RVA: 0x0022C35C File Offset: 0x0022A55C
		public byte[] GetUnlockCondDescArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x17000BC3 RID: 3011
		// (get) Token: 0x06006505 RID: 25861 RVA: 0x0022C374 File Offset: 0x0022A574
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

		// Token: 0x06006506 RID: 25862 RVA: 0x0022C3AC File Offset: 0x0022A5AC
		public Span<byte> GetRoleIconBytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x06006507 RID: 25863 RVA: 0x0022C3BC File Offset: 0x0022A5BC
		public byte[] GetRoleIconArray()
		{
			return this.__p.__vector_as_array<byte>(24) ?? Array.Empty<byte>();
		}

		// Token: 0x17000BC4 RID: 3012
		// (get) Token: 0x06006508 RID: 25864 RVA: 0x0022C3D4 File Offset: 0x0022A5D4
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

		// Token: 0x06006509 RID: 25865 RVA: 0x0022C40C File Offset: 0x0022A60C
		public Span<byte> GetRoleHoldIconBytes()
		{
			return this.__p.__vector_as_span<byte>(26, 1);
		}

		// Token: 0x0600650A RID: 25866 RVA: 0x0022C41C File Offset: 0x0022A61C
		public byte[] GetRoleHoldIconArray()
		{
			return this.__p.__vector_as_array<byte>(26) ?? Array.Empty<byte>();
		}

		// Token: 0x17000BC5 RID: 3013
		// (get) Token: 0x0600650B RID: 25867 RVA: 0x0022C434 File Offset: 0x0022A634
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

		// Token: 0x0600650C RID: 25868 RVA: 0x0022C46C File Offset: 0x0022A66C
		public Span<byte> GetRoleSelIconBytes()
		{
			return this.__p.__vector_as_span<byte>(28, 1);
		}

		// Token: 0x0600650D RID: 25869 RVA: 0x0022C47C File Offset: 0x0022A67C
		public byte[] GetRoleSelIconArray()
		{
			return this.__p.__vector_as_array<byte>(28) ?? Array.Empty<byte>();
		}

		// Token: 0x17000BC6 RID: 3014
		// (get) Token: 0x0600650E RID: 25870 RVA: 0x0022C494 File Offset: 0x0022A694
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

		// Token: 0x0600650F RID: 25871 RVA: 0x0022C4CC File Offset: 0x0022A6CC
		public Span<byte> GetRoleBigIconBytes()
		{
			return this.__p.__vector_as_span<byte>(30, 1);
		}

		// Token: 0x06006510 RID: 25872 RVA: 0x0022C4DC File Offset: 0x0022A6DC
		public byte[] GetRoleBigIconArray()
		{
			return this.__p.__vector_as_array<byte>(30) ?? Array.Empty<byte>();
		}

		// Token: 0x17000BC7 RID: 3015
		// (get) Token: 0x06006511 RID: 25873 RVA: 0x0022C4F4 File Offset: 0x0022A6F4
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

		// Token: 0x06006512 RID: 25874 RVA: 0x0022C52C File Offset: 0x0022A72C
		public Span<byte> GetRoleBuffIconBytes()
		{
			return this.__p.__vector_as_span<byte>(32, 1);
		}

		// Token: 0x06006513 RID: 25875 RVA: 0x0022C53C File Offset: 0x0022A73C
		public byte[] GetRoleBuffIconArray()
		{
			return this.__p.__vector_as_array<byte>(32) ?? Array.Empty<byte>();
		}

		// Token: 0x17000BC8 RID: 3016
		// (get) Token: 0x06006514 RID: 25876 RVA: 0x0022C554 File Offset: 0x0022A754
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

		// Token: 0x06006515 RID: 25877 RVA: 0x0022C58C File Offset: 0x0022A78C
		public Span<byte> GetRoleUnlockIconBytes()
		{
			return this.__p.__vector_as_span<byte>(34, 1);
		}

		// Token: 0x06006516 RID: 25878 RVA: 0x0022C59C File Offset: 0x0022A79C
		public byte[] GetRoleUnlockIconArray()
		{
			return this.__p.__vector_as_array<byte>(34) ?? Array.Empty<byte>();
		}

		// Token: 0x17000BC9 RID: 3017
		// (get) Token: 0x06006517 RID: 25879 RVA: 0x0022C5B4 File Offset: 0x0022A7B4
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

		// Token: 0x06006518 RID: 25880 RVA: 0x0022C5EC File Offset: 0x0022A7EC
		public Span<byte> GetBagIconBytes()
		{
			return this.__p.__vector_as_span<byte>(36, 1);
		}

		// Token: 0x06006519 RID: 25881 RVA: 0x0022C5FC File Offset: 0x0022A7FC
		public byte[] GetBagIconArray()
		{
			return this.__p.__vector_as_array<byte>(36) ?? Array.Empty<byte>();
		}

		// Token: 0x17000BCA RID: 3018
		// (get) Token: 0x0600651A RID: 25882 RVA: 0x0022C614 File Offset: 0x0022A814
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

		// Token: 0x0600651B RID: 25883 RVA: 0x0022C64C File Offset: 0x0022A84C
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(38, 1);
		}

		// Token: 0x0600651C RID: 25884 RVA: 0x0022C65C File Offset: 0x0022A85C
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(38) ?? Array.Empty<byte>();
		}

		// Token: 0x17000BCB RID: 3019
		// (get) Token: 0x0600651D RID: 25885 RVA: 0x0022C674 File Offset: 0x0022A874
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

		// Token: 0x0600651E RID: 25886 RVA: 0x0022C6AC File Offset: 0x0022A8AC
		public Span<byte> GetLogIconBytes()
		{
			return this.__p.__vector_as_span<byte>(40, 1);
		}

		// Token: 0x0600651F RID: 25887 RVA: 0x0022C6BC File Offset: 0x0022A8BC
		public byte[] GetLogIconArray()
		{
			return this.__p.__vector_as_array<byte>(40) ?? Array.Empty<byte>();
		}

		// Token: 0x17000BCC RID: 3020
		// (get) Token: 0x06006520 RID: 25888 RVA: 0x0022C6D4 File Offset: 0x0022A8D4
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

		// Token: 0x17000BCD RID: 3021
		// (get) Token: 0x06006521 RID: 25889 RVA: 0x0022C714 File Offset: 0x0022A914
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

		// Token: 0x06006522 RID: 25890 RVA: 0x0022C74C File Offset: 0x0022A94C
		public Span<byte> GetAttributesDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(44, 1);
		}

		// Token: 0x06006523 RID: 25891 RVA: 0x0022C75C File Offset: 0x0022A95C
		public byte[] GetAttributesDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(44) ?? Array.Empty<byte>();
		}

		// Token: 0x17000BCE RID: 3022
		// (get) Token: 0x06006524 RID: 25892 RVA: 0x0022C774 File Offset: 0x0022A974
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

		// Token: 0x06006525 RID: 25893 RVA: 0x0022C7AC File Offset: 0x0022A9AC
		public Span<byte> GetSpineAtlasPathBytes()
		{
			return this.__p.__vector_as_span<byte>(46, 1);
		}

		// Token: 0x06006526 RID: 25894 RVA: 0x0022C7BC File Offset: 0x0022A9BC
		public byte[] GetSpineAtlasPathArray()
		{
			return this.__p.__vector_as_array<byte>(46) ?? Array.Empty<byte>();
		}

		// Token: 0x17000BCF RID: 3023
		// (get) Token: 0x06006527 RID: 25895 RVA: 0x0022C7D4 File Offset: 0x0022A9D4
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

		// Token: 0x06006528 RID: 25896 RVA: 0x0022C80C File Offset: 0x0022AA0C
		public Span<byte> GetSpineSkeletonDataPathBytes()
		{
			return this.__p.__vector_as_span<byte>(48, 1);
		}

		// Token: 0x06006529 RID: 25897 RVA: 0x0022C81C File Offset: 0x0022AA1C
		public byte[] GetSpineSkeletonDataPathArray()
		{
			return this.__p.__vector_as_array<byte>(48) ?? Array.Empty<byte>();
		}

		// Token: 0x17000BD0 RID: 3024
		// (get) Token: 0x0600652A RID: 25898 RVA: 0x0022C834 File Offset: 0x0022AA34
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

		// Token: 0x0600652B RID: 25899 RVA: 0x0022C86C File Offset: 0x0022AA6C
		public Span<byte> GetUnlockSpineAtlasPathBytes()
		{
			return this.__p.__vector_as_span<byte>(50, 1);
		}

		// Token: 0x0600652C RID: 25900 RVA: 0x0022C87C File Offset: 0x0022AA7C
		public byte[] GetUnlockSpineAtlasPathArray()
		{
			return this.__p.__vector_as_array<byte>(50) ?? Array.Empty<byte>();
		}

		// Token: 0x17000BD1 RID: 3025
		// (get) Token: 0x0600652D RID: 25901 RVA: 0x0022C894 File Offset: 0x0022AA94
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

		// Token: 0x0600652E RID: 25902 RVA: 0x0022C8CC File Offset: 0x0022AACC
		public Span<byte> GetUnlockSpineSkeletonDataPathBytes()
		{
			return this.__p.__vector_as_span<byte>(52, 1);
		}

		// Token: 0x0600652F RID: 25903 RVA: 0x0022C8DC File Offset: 0x0022AADC
		public byte[] GetUnlockSpineSkeletonDataPathArray()
		{
			return this.__p.__vector_as_array<byte>(52) ?? Array.Empty<byte>();
		}

		// Token: 0x17000BD2 RID: 3026
		// (get) Token: 0x06006530 RID: 25904 RVA: 0x0022C8F4 File Offset: 0x0022AAF4
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

		// Token: 0x06006531 RID: 25905 RVA: 0x0022C92C File Offset: 0x0022AB2C
		public Span<byte> GetUnlockSpineAnimBytes()
		{
			return this.__p.__vector_as_span<byte>(54, 1);
		}

		// Token: 0x06006532 RID: 25906 RVA: 0x0022C93C File Offset: 0x0022AB3C
		public byte[] GetUnlockSpineAnimArray()
		{
			return this.__p.__vector_as_array<byte>(54) ?? Array.Empty<byte>();
		}

		// Token: 0x17000BD3 RID: 3027
		// (get) Token: 0x06006533 RID: 25907 RVA: 0x0022C954 File Offset: 0x0022AB54
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

		// Token: 0x17000BD4 RID: 3028
		// (get) Token: 0x06006534 RID: 25908 RVA: 0x0022C994 File Offset: 0x0022AB94
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

		// Token: 0x06006535 RID: 25909 RVA: 0x0022C9CC File Offset: 0x0022ABCC
		public Span<byte> GetBlueprintPathBytes()
		{
			return this.__p.__vector_as_span<byte>(58, 1);
		}

		// Token: 0x06006536 RID: 25910 RVA: 0x0022C9DC File Offset: 0x0022ABDC
		public byte[] GetBlueprintPathArray()
		{
			return this.__p.__vector_as_array<byte>(58) ?? Array.Empty<byte>();
		}

		// Token: 0x17000BD5 RID: 3029
		// (get) Token: 0x06006537 RID: 25911 RVA: 0x0022C9F4 File Offset: 0x0022ABF4
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

		// Token: 0x06006538 RID: 25912 RVA: 0x0022CA2C File Offset: 0x0022AC2C
		public Span<byte> GetABpPathBytes()
		{
			return this.__p.__vector_as_span<byte>(60, 1);
		}

		// Token: 0x06006539 RID: 25913 RVA: 0x0022CA3C File Offset: 0x0022AC3C
		public byte[] GetABpPathArray()
		{
			return this.__p.__vector_as_array<byte>(60) ?? Array.Empty<byte>();
		}

		// Token: 0x17000BD6 RID: 3030
		// (get) Token: 0x0600653A RID: 25914 RVA: 0x0022CA54 File Offset: 0x0022AC54
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

		// Token: 0x0600653B RID: 25915 RVA: 0x0022CA8C File Offset: 0x0022AC8C
		public Span<byte> GetMontageIdleBytes()
		{
			return this.__p.__vector_as_span<byte>(62, 1);
		}

		// Token: 0x0600653C RID: 25916 RVA: 0x0022CA9C File Offset: 0x0022AC9C
		public byte[] GetMontageIdleArray()
		{
			return this.__p.__vector_as_array<byte>(62) ?? Array.Empty<byte>();
		}

		// Token: 0x17000BD7 RID: 3031
		// (get) Token: 0x0600653D RID: 25917 RVA: 0x0022CAB4 File Offset: 0x0022ACB4
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

		// Token: 0x0600653E RID: 25918 RVA: 0x0022CAEC File Offset: 0x0022ACEC
		public Span<byte> GetMontageAttackBytes()
		{
			return this.__p.__vector_as_span<byte>(64, 1);
		}

		// Token: 0x0600653F RID: 25919 RVA: 0x0022CAFC File Offset: 0x0022ACFC
		public byte[] GetMontageAttackArray()
		{
			return this.__p.__vector_as_array<byte>(64) ?? Array.Empty<byte>();
		}

		// Token: 0x17000BD8 RID: 3032
		// (get) Token: 0x06006540 RID: 25920 RVA: 0x0022CB14 File Offset: 0x0022AD14
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

		// Token: 0x06006541 RID: 25921 RVA: 0x0022CB4C File Offset: 0x0022AD4C
		public Span<byte> GetMontageAttackLoopBytes()
		{
			return this.__p.__vector_as_span<byte>(66, 1);
		}

		// Token: 0x06006542 RID: 25922 RVA: 0x0022CB5C File Offset: 0x0022AD5C
		public byte[] GetMontageAttackLoopArray()
		{
			return this.__p.__vector_as_array<byte>(66) ?? Array.Empty<byte>();
		}

		// Token: 0x17000BD9 RID: 3033
		// (get) Token: 0x06006543 RID: 25923 RVA: 0x0022CB74 File Offset: 0x0022AD74
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

		// Token: 0x06006544 RID: 25924 RVA: 0x0022CBAC File Offset: 0x0022ADAC
		public Span<byte> GetMontageAttackEndBytes()
		{
			return this.__p.__vector_as_span<byte>(68, 1);
		}

		// Token: 0x06006545 RID: 25925 RVA: 0x0022CBBC File Offset: 0x0022ADBC
		public byte[] GetMontageAttackEndArray()
		{
			return this.__p.__vector_as_array<byte>(68) ?? Array.Empty<byte>();
		}

		// Token: 0x17000BDA RID: 3034
		// (get) Token: 0x06006546 RID: 25926 RVA: 0x0022CBD4 File Offset: 0x0022ADD4
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

		// Token: 0x06006547 RID: 25927 RVA: 0x0022CC0C File Offset: 0x0022AE0C
		public Span<byte> GetMontageSuccessBytes()
		{
			return this.__p.__vector_as_span<byte>(70, 1);
		}

		// Token: 0x06006548 RID: 25928 RVA: 0x0022CC1C File Offset: 0x0022AE1C
		public byte[] GetMontageSuccessArray()
		{
			return this.__p.__vector_as_array<byte>(70) ?? Array.Empty<byte>();
		}

		// Token: 0x17000BDB RID: 3035
		// (get) Token: 0x06006549 RID: 25929 RVA: 0x0022CC34 File Offset: 0x0022AE34
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

		// Token: 0x0600654A RID: 25930 RVA: 0x0022CC6C File Offset: 0x0022AE6C
		public Span<byte> GetMontageFailBytes()
		{
			return this.__p.__vector_as_span<byte>(72, 1);
		}

		// Token: 0x0600654B RID: 25931 RVA: 0x0022CC7C File Offset: 0x0022AE7C
		public byte[] GetMontageFailArray()
		{
			return this.__p.__vector_as_array<byte>(72) ?? Array.Empty<byte>();
		}

		// Token: 0x0600654C RID: 25932 RVA: 0x0022CC94 File Offset: 0x0022AE94
		public int TrashTalkIdList(int j)
		{
			int num = this.__p.__offset(74);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000BDC RID: 3036
		// (get) Token: 0x0600654D RID: 25933 RVA: 0x0022CCD4 File Offset: 0x0022AED4
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

		// Token: 0x0600654E RID: 25934 RVA: 0x0022CD00 File Offset: 0x0022AF00
		public Span<int> GetTrashTalkIdListBytes()
		{
			return this.__p.__vector_as_span<int>(74, 4);
		}

		// Token: 0x0600654F RID: 25935 RVA: 0x0022CD10 File Offset: 0x0022AF10
		public int[] GetTrashTalkIdListArray()
		{
			return this.__p.__vector_as_array<int>(74) ?? Array.Empty<int>();
		}

		// Token: 0x17000BDD RID: 3037
		// (get) Token: 0x06006550 RID: 25936 RVA: 0x0022CD28 File Offset: 0x0022AF28
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

		// Token: 0x06006551 RID: 25937 RVA: 0x0022CD60 File Offset: 0x0022AF60
		public Span<byte> GetShopIdleSpineAnimBytes()
		{
			return this.__p.__vector_as_span<byte>(76, 1);
		}

		// Token: 0x06006552 RID: 25938 RVA: 0x0022CD70 File Offset: 0x0022AF70
		public byte[] GetShopIdleSpineAnimArray()
		{
			return this.__p.__vector_as_array<byte>(76) ?? Array.Empty<byte>();
		}

		// Token: 0x06006553 RID: 25939 RVA: 0x0022CD88 File Offset: 0x0022AF88
		public int ShopTipsTalkIdList(int j)
		{
			int num = this.__p.__offset(78);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000BDE RID: 3038
		// (get) Token: 0x06006554 RID: 25940 RVA: 0x0022CDC8 File Offset: 0x0022AFC8
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

		// Token: 0x06006555 RID: 25941 RVA: 0x0022CDF4 File Offset: 0x0022AFF4
		public Span<int> GetShopTipsTalkIdListBytes()
		{
			return this.__p.__vector_as_span<int>(78, 4);
		}

		// Token: 0x06006556 RID: 25942 RVA: 0x0022CE04 File Offset: 0x0022B004
		public int[] GetShopTipsTalkIdListArray()
		{
			return this.__p.__vector_as_array<int>(78) ?? Array.Empty<int>();
		}

		// Token: 0x17000BDF RID: 3039
		// (get) Token: 0x06006557 RID: 25943 RVA: 0x0022CE1C File Offset: 0x0022B01C
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

		// Token: 0x06006558 RID: 25944 RVA: 0x0022CE54 File Offset: 0x0022B054
		public Span<byte> GetShopTipsTalkSpineAnimBytes()
		{
			return this.__p.__vector_as_span<byte>(80, 1);
		}

		// Token: 0x06006559 RID: 25945 RVA: 0x0022CE64 File Offset: 0x0022B064
		public byte[] GetShopTipsTalkSpineAnimArray()
		{
			return this.__p.__vector_as_array<byte>(80) ?? Array.Empty<byte>();
		}

		// Token: 0x0600655A RID: 25946 RVA: 0x0022CE7C File Offset: 0x0022B07C
		public int ShopTrashTalkIdList(int j)
		{
			int num = this.__p.__offset(82);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000BE0 RID: 3040
		// (get) Token: 0x0600655B RID: 25947 RVA: 0x0022CEBC File Offset: 0x0022B0BC
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

		// Token: 0x0600655C RID: 25948 RVA: 0x0022CEE8 File Offset: 0x0022B0E8
		public Span<int> GetShopTrashTalkIdListBytes()
		{
			return this.__p.__vector_as_span<int>(82, 4);
		}

		// Token: 0x0600655D RID: 25949 RVA: 0x0022CEF8 File Offset: 0x0022B0F8
		public int[] GetShopTrashTalkIdListArray()
		{
			return this.__p.__vector_as_array<int>(82) ?? Array.Empty<int>();
		}

		// Token: 0x17000BE1 RID: 3041
		// (get) Token: 0x0600655E RID: 25950 RVA: 0x0022CF10 File Offset: 0x0022B110
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

		// Token: 0x0600655F RID: 25951 RVA: 0x0022CF48 File Offset: 0x0022B148
		public Span<byte> GetShopTrashTalkSpineAnimBytes()
		{
			return this.__p.__vector_as_span<byte>(84, 1);
		}

		// Token: 0x06006560 RID: 25952 RVA: 0x0022CF58 File Offset: 0x0022B158
		public byte[] GetShopTrashTalkSpineAnimArray()
		{
			return this.__p.__vector_as_array<byte>(84) ?? Array.Empty<byte>();
		}

		// Token: 0x06006561 RID: 25953 RVA: 0x0022CF70 File Offset: 0x0022B170
		public int ShopWeaponTalkIdList(int j)
		{
			int num = this.__p.__offset(86);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000BE2 RID: 3042
		// (get) Token: 0x06006562 RID: 25954 RVA: 0x0022CFB0 File Offset: 0x0022B1B0
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

		// Token: 0x06006563 RID: 25955 RVA: 0x0022CFDC File Offset: 0x0022B1DC
		public Span<int> GetShopWeaponTalkIdListBytes()
		{
			return this.__p.__vector_as_span<int>(86, 4);
		}

		// Token: 0x06006564 RID: 25956 RVA: 0x0022CFEC File Offset: 0x0022B1EC
		public int[] GetShopWeaponTalkIdListArray()
		{
			return this.__p.__vector_as_array<int>(86) ?? Array.Empty<int>();
		}

		// Token: 0x17000BE3 RID: 3043
		// (get) Token: 0x06006565 RID: 25957 RVA: 0x0022D004 File Offset: 0x0022B204
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

		// Token: 0x06006566 RID: 25958 RVA: 0x0022D03C File Offset: 0x0022B23C
		public Span<byte> GetShopWeaponTalkSpineAnimBytes()
		{
			return this.__p.__vector_as_span<byte>(88, 1);
		}

		// Token: 0x06006567 RID: 25959 RVA: 0x0022D04C File Offset: 0x0022B24C
		public byte[] GetShopWeaponTalkSpineAnimArray()
		{
			return this.__p.__vector_as_array<byte>(88) ?? Array.Empty<byte>();
		}

		// Token: 0x06006568 RID: 25960 RVA: 0x0022D064 File Offset: 0x0022B264
		public int ShopCostUpTalkIdList(int j)
		{
			int num = this.__p.__offset(90);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000BE4 RID: 3044
		// (get) Token: 0x06006569 RID: 25961 RVA: 0x0022D0A4 File Offset: 0x0022B2A4
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

		// Token: 0x0600656A RID: 25962 RVA: 0x0022D0D0 File Offset: 0x0022B2D0
		public Span<int> GetShopCostUpTalkIdListBytes()
		{
			return this.__p.__vector_as_span<int>(90, 4);
		}

		// Token: 0x0600656B RID: 25963 RVA: 0x0022D0E0 File Offset: 0x0022B2E0
		public int[] GetShopCostUpTalkIdListArray()
		{
			return this.__p.__vector_as_array<int>(90) ?? Array.Empty<int>();
		}

		// Token: 0x17000BE5 RID: 3045
		// (get) Token: 0x0600656C RID: 25964 RVA: 0x0022D0F8 File Offset: 0x0022B2F8
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

		// Token: 0x0600656D RID: 25965 RVA: 0x0022D130 File Offset: 0x0022B330
		public Span<byte> GetShopCostUpTalkSpineAnimBytes()
		{
			return this.__p.__vector_as_span<byte>(92, 1);
		}

		// Token: 0x0600656E RID: 25966 RVA: 0x0022D140 File Offset: 0x0022B340
		public byte[] GetShopCostUpTalkSpineAnimArray()
		{
			return this.__p.__vector_as_array<byte>(92) ?? Array.Empty<byte>();
		}

		// Token: 0x17000BE6 RID: 3046
		// (get) Token: 0x0600656F RID: 25967 RVA: 0x0022D158 File Offset: 0x0022B358
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

		// Token: 0x06006570 RID: 25968 RVA: 0x0022D190 File Offset: 0x0022B390
		public Span<byte> GetWinFlowListNameBytes()
		{
			return this.__p.__vector_as_span<byte>(94, 1);
		}

		// Token: 0x06006571 RID: 25969 RVA: 0x0022D1A0 File Offset: 0x0022B3A0
		public byte[] GetWinFlowListNameArray()
		{
			return this.__p.__vector_as_array<byte>(94) ?? Array.Empty<byte>();
		}

		// Token: 0x17000BE7 RID: 3047
		// (get) Token: 0x06006572 RID: 25970 RVA: 0x0022D1B8 File Offset: 0x0022B3B8
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

		// Token: 0x17000BE8 RID: 3048
		// (get) Token: 0x06006573 RID: 25971 RVA: 0x0022D1F8 File Offset: 0x0022B3F8
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

		// Token: 0x17000BE9 RID: 3049
		// (get) Token: 0x06006574 RID: 25972 RVA: 0x0022D238 File Offset: 0x0022B438
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

		// Token: 0x06006575 RID: 25973 RVA: 0x0022D270 File Offset: 0x0022B470
		public Span<byte> GetLoseFlowListNameBytes()
		{
			return this.__p.__vector_as_span<byte>(100, 1);
		}

		// Token: 0x06006576 RID: 25974 RVA: 0x0022D280 File Offset: 0x0022B480
		public byte[] GetLoseFlowListNameArray()
		{
			return this.__p.__vector_as_array<byte>(100) ?? Array.Empty<byte>();
		}

		// Token: 0x17000BEA RID: 3050
		// (get) Token: 0x06006577 RID: 25975 RVA: 0x0022D298 File Offset: 0x0022B498
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

		// Token: 0x17000BEB RID: 3051
		// (get) Token: 0x06006578 RID: 25976 RVA: 0x0022D2D8 File Offset: 0x0022B4D8
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

		// Token: 0x17000BEC RID: 3052
		// (get) Token: 0x06006579 RID: 25977 RVA: 0x0022D318 File Offset: 0x0022B518
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

		// Token: 0x0600657A RID: 25978 RVA: 0x0022D350 File Offset: 0x0022B550
		public Span<byte> GetAudioRoleSelectBytes()
		{
			return this.__p.__vector_as_span<byte>(106, 1);
		}

		// Token: 0x0600657B RID: 25979 RVA: 0x0022D360 File Offset: 0x0022B560
		public byte[] GetAudioRoleSelectArray()
		{
			return this.__p.__vector_as_array<byte>(106) ?? Array.Empty<byte>();
		}

		// Token: 0x17000BED RID: 3053
		// (get) Token: 0x0600657C RID: 25980 RVA: 0x0022D378 File Offset: 0x0022B578
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

		// Token: 0x0600657D RID: 25981 RVA: 0x0022D3B0 File Offset: 0x0022B5B0
		public Span<byte> GetAudioAttackStartBytes()
		{
			return this.__p.__vector_as_span<byte>(108, 1);
		}

		// Token: 0x0600657E RID: 25982 RVA: 0x0022D3C0 File Offset: 0x0022B5C0
		public byte[] GetAudioAttackStartArray()
		{
			return this.__p.__vector_as_array<byte>(108) ?? Array.Empty<byte>();
		}

		// Token: 0x17000BEE RID: 3054
		// (get) Token: 0x0600657F RID: 25983 RVA: 0x0022D3D8 File Offset: 0x0022B5D8
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

		// Token: 0x06006580 RID: 25984 RVA: 0x0022D410 File Offset: 0x0022B610
		public Span<byte> GetAudioRoundWinBytes()
		{
			return this.__p.__vector_as_span<byte>(110, 1);
		}

		// Token: 0x06006581 RID: 25985 RVA: 0x0022D420 File Offset: 0x0022B620
		public byte[] GetAudioRoundWinArray()
		{
			return this.__p.__vector_as_array<byte>(110) ?? Array.Empty<byte>();
		}

		// Token: 0x17000BEF RID: 3055
		// (get) Token: 0x06006582 RID: 25986 RVA: 0x0022D438 File Offset: 0x0022B638
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

		// Token: 0x06006583 RID: 25987 RVA: 0x0022D470 File Offset: 0x0022B670
		public Span<byte> GetAudioSettleDefeatedBytes()
		{
			return this.__p.__vector_as_span<byte>(112, 1);
		}

		// Token: 0x06006584 RID: 25988 RVA: 0x0022D480 File Offset: 0x0022B680
		public byte[] GetAudioSettleDefeatedArray()
		{
			return this.__p.__vector_as_array<byte>(112) ?? Array.Empty<byte>();
		}

		// Token: 0x17000BF0 RID: 3056
		// (get) Token: 0x06006585 RID: 25989 RVA: 0x0022D498 File Offset: 0x0022B698
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

		// Token: 0x06006586 RID: 25990 RVA: 0x0022D4D0 File Offset: 0x0022B6D0
		public Span<byte> GetHitDAPathBytes()
		{
			return this.__p.__vector_as_span<byte>(114, 1);
		}

		// Token: 0x06006587 RID: 25991 RVA: 0x0022D4E0 File Offset: 0x0022B6E0
		public byte[] GetHitDAPathArray()
		{
			return this.__p.__vector_as_array<byte>(114) ?? Array.Empty<byte>();
		}

		// Token: 0x06006588 RID: 25992 RVA: 0x0022D4F8 File Offset: 0x0022B6F8
		[NullableContext(1)]
		public int[] ShopCostUpTalkIdList()
		{
			return this.GetShopCostUpTalkIdListArray();
		}

		// Token: 0x06006589 RID: 25993 RVA: 0x0022D500 File Offset: 0x0022B700
		[NullableContext(1)]
		public IEnumerable<int> ShopCostUpTalkIdListIter()
		{
			DangoBrawlRole.<ShopCostUpTalkIdListIter>d__212 <ShopCostUpTalkIdListIter>d__ = new DangoBrawlRole.<ShopCostUpTalkIdListIter>d__212(-2);
			<ShopCostUpTalkIdListIter>d__.<>3__<>4__this = this;
			return <ShopCostUpTalkIdListIter>d__;
		}

		// Token: 0x0600658A RID: 25994 RVA: 0x0022D515 File Offset: 0x0022B715
		[NullableContext(1)]
		public int[] ShopTipsTalkIdList()
		{
			return this.GetShopTipsTalkIdListArray();
		}

		// Token: 0x0600658B RID: 25995 RVA: 0x0022D51D File Offset: 0x0022B71D
		[NullableContext(1)]
		public IEnumerable<int> ShopTipsTalkIdListIter()
		{
			DangoBrawlRole.<ShopTipsTalkIdListIter>d__214 <ShopTipsTalkIdListIter>d__ = new DangoBrawlRole.<ShopTipsTalkIdListIter>d__214(-2);
			<ShopTipsTalkIdListIter>d__.<>3__<>4__this = this;
			return <ShopTipsTalkIdListIter>d__;
		}

		// Token: 0x0600658C RID: 25996 RVA: 0x0022D532 File Offset: 0x0022B732
		[NullableContext(1)]
		public int[] ShopTrashTalkIdList()
		{
			return this.GetShopTrashTalkIdListArray();
		}

		// Token: 0x0600658D RID: 25997 RVA: 0x0022D53A File Offset: 0x0022B73A
		[NullableContext(1)]
		public IEnumerable<int> ShopTrashTalkIdListIter()
		{
			DangoBrawlRole.<ShopTrashTalkIdListIter>d__216 <ShopTrashTalkIdListIter>d__ = new DangoBrawlRole.<ShopTrashTalkIdListIter>d__216(-2);
			<ShopTrashTalkIdListIter>d__.<>3__<>4__this = this;
			return <ShopTrashTalkIdListIter>d__;
		}

		// Token: 0x0600658E RID: 25998 RVA: 0x0022D54F File Offset: 0x0022B74F
		[NullableContext(1)]
		public int[] ShopWeaponTalkIdList()
		{
			return this.GetShopWeaponTalkIdListArray();
		}

		// Token: 0x0600658F RID: 25999 RVA: 0x0022D557 File Offset: 0x0022B757
		[NullableContext(1)]
		public IEnumerable<int> ShopWeaponTalkIdListIter()
		{
			DangoBrawlRole.<ShopWeaponTalkIdListIter>d__218 <ShopWeaponTalkIdListIter>d__ = new DangoBrawlRole.<ShopWeaponTalkIdListIter>d__218(-2);
			<ShopWeaponTalkIdListIter>d__.<>3__<>4__this = this;
			return <ShopWeaponTalkIdListIter>d__;
		}

		// Token: 0x06006590 RID: 26000 RVA: 0x0022D56C File Offset: 0x0022B76C
		[NullableContext(1)]
		public int[] TrashTalkIdList()
		{
			return this.GetTrashTalkIdListArray();
		}

		// Token: 0x06006591 RID: 26001 RVA: 0x0022D574 File Offset: 0x0022B774
		[NullableContext(1)]
		public IEnumerable<int> TrashTalkIdListIter()
		{
			DangoBrawlRole.<TrashTalkIdListIter>d__220 <TrashTalkIdListIter>d__ = new DangoBrawlRole.<TrashTalkIdListIter>d__220(-2);
			<TrashTalkIdListIter>d__.<>3__<>4__this = this;
			return <TrashTalkIdListIter>d__;
		}

		// Token: 0x040051DB RID: 20955
		private Table __p;
	}
}
