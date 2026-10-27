using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C0F RID: 3087
	public struct DropCatchRole : IFlatbufferObject
	{
		// Token: 0x17000DCF RID: 3535
		// (get) Token: 0x060065AC RID: 26028 RVA: 0x0021B914 File Offset: 0x00219B14
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060065AD RID: 26029 RVA: 0x0021B921 File Offset: 0x00219B21
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060065AE RID: 26030 RVA: 0x0021B928 File Offset: 0x00219B28
		public static DropCatchRole GetRootAsDropCatchRole(ByteBuffer _bb)
		{
			return DropCatchRole.GetRootAsDropCatchRole(_bb, default(DropCatchRole));
		}

		// Token: 0x060065AF RID: 26031 RVA: 0x0021B944 File Offset: 0x00219B44
		public static DropCatchRole GetRootAsDropCatchRole(ByteBuffer _bb, DropCatchRole obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060065B0 RID: 26032 RVA: 0x0021B961 File Offset: 0x00219B61
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060065B1 RID: 26033 RVA: 0x0021B970 File Offset: 0x00219B70
		public DropCatchRole __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000DD0 RID: 3536
		// (get) Token: 0x060065B2 RID: 26034 RVA: 0x0021B980 File Offset: 0x00219B80
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

		// Token: 0x17000DD1 RID: 3537
		// (get) Token: 0x060065B3 RID: 26035 RVA: 0x0021B9BC File Offset: 0x00219BBC
		public float MoveSpeed
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000DD2 RID: 3538
		// (get) Token: 0x060065B4 RID: 26036 RVA: 0x0021B9FC File Offset: 0x00219BFC
		public float EnergyGetRate
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000DD3 RID: 3539
		// (get) Token: 0x060065B5 RID: 26037 RVA: 0x0021BA3C File Offset: 0x00219C3C
		public float EnergySelfRecover
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000DD4 RID: 3540
		// (get) Token: 0x060065B6 RID: 26038 RVA: 0x0021BA80 File Offset: 0x00219C80
		public float MaxEnergy
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060065B7 RID: 26039 RVA: 0x0021BAC4 File Offset: 0x00219CC4
		public float RoleSize(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return 0f;
			}
			return this.__p.bb.GetFloat(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000DD5 RID: 3541
		// (get) Token: 0x060065B8 RID: 26040 RVA: 0x0021BB08 File Offset: 0x00219D08
		public int RoleSizeLength
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x060065B9 RID: 26041 RVA: 0x0021BB34 File Offset: 0x00219D34
		public Span<float> GetRoleSizeBytes()
		{
			return this.__p.__vector_as_span<float>(14, 4);
		}

		// Token: 0x060065BA RID: 26042 RVA: 0x0021BB44 File Offset: 0x00219D44
		public float[] GetRoleSizeArray()
		{
			return this.__p.__vector_as_array<float>(14) ?? Array.Empty<float>();
		}

		// Token: 0x060065BB RID: 26043 RVA: 0x0021BB5C File Offset: 0x00219D5C
		public float RoleSizeBiasNew(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return 0f;
			}
			return this.__p.bb.GetFloat(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000DD6 RID: 3542
		// (get) Token: 0x060065BC RID: 26044 RVA: 0x0021BBA0 File Offset: 0x00219DA0
		public int RoleSizeBiasNewLength
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x060065BD RID: 26045 RVA: 0x0021BBCC File Offset: 0x00219DCC
		public Span<float> GetRoleSizeBiasNewBytes()
		{
			return this.__p.__vector_as_span<float>(16, 4);
		}

		// Token: 0x060065BE RID: 26046 RVA: 0x0021BBDC File Offset: 0x00219DDC
		public float[] GetRoleSizeBiasNewArray()
		{
			return this.__p.__vector_as_array<float>(16) ?? Array.Empty<float>();
		}

		// Token: 0x17000DD7 RID: 3543
		// (get) Token: 0x060065BF RID: 26047 RVA: 0x0021BBF4 File Offset: 0x00219DF4
		public float RoleSizeBias
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060065C0 RID: 26048 RVA: 0x0021BC38 File Offset: 0x00219E38
		public float BowlSize(int j)
		{
			int num = this.__p.__offset(20);
			if (num == 0)
			{
				return 0f;
			}
			return this.__p.bb.GetFloat(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000DD8 RID: 3544
		// (get) Token: 0x060065C1 RID: 26049 RVA: 0x0021BC7C File Offset: 0x00219E7C
		public int BowlSizeLength
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x060065C2 RID: 26050 RVA: 0x0021BCA8 File Offset: 0x00219EA8
		public Span<float> GetBowlSizeBytes()
		{
			return this.__p.__vector_as_span<float>(20, 4);
		}

		// Token: 0x060065C3 RID: 26051 RVA: 0x0021BCB8 File Offset: 0x00219EB8
		public float[] GetBowlSizeArray()
		{
			return this.__p.__vector_as_array<float>(20) ?? Array.Empty<float>();
		}

		// Token: 0x060065C4 RID: 26052 RVA: 0x0021BCD0 File Offset: 0x00219ED0
		public float BowlSizeBiasNew(int j)
		{
			int num = this.__p.__offset(22);
			if (num == 0)
			{
				return 0f;
			}
			return this.__p.bb.GetFloat(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000DD9 RID: 3545
		// (get) Token: 0x060065C5 RID: 26053 RVA: 0x0021BD14 File Offset: 0x00219F14
		public int BowlSizeBiasNewLength
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x060065C6 RID: 26054 RVA: 0x0021BD40 File Offset: 0x00219F40
		public Span<float> GetBowlSizeBiasNewBytes()
		{
			return this.__p.__vector_as_span<float>(22, 4);
		}

		// Token: 0x060065C7 RID: 26055 RVA: 0x0021BD50 File Offset: 0x00219F50
		public float[] GetBowlSizeBiasNewArray()
		{
			return this.__p.__vector_as_array<float>(22) ?? Array.Empty<float>();
		}

		// Token: 0x17000DDA RID: 3546
		// (get) Token: 0x060065C8 RID: 26056 RVA: 0x0021BD68 File Offset: 0x00219F68
		public float BowlSizeBias
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000DDB RID: 3547
		// (get) Token: 0x060065C9 RID: 26057 RVA: 0x0021BDAC File Offset: 0x00219FAC
		public float BowlSpineScaleX
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000DDC RID: 3548
		// (get) Token: 0x060065CA RID: 26058 RVA: 0x0021BDF0 File Offset: 0x00219FF0
		public string Name
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

		// Token: 0x060065CB RID: 26059 RVA: 0x0021BE28 File Offset: 0x0021A028
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(28, 1);
		}

		// Token: 0x060065CC RID: 26060 RVA: 0x0021BE38 File Offset: 0x0021A038
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(28) ?? Array.Empty<byte>();
		}

		// Token: 0x17000DDD RID: 3549
		// (get) Token: 0x060065CD RID: 26061 RVA: 0x0021BE50 File Offset: 0x0021A050
		public string Desc
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

		// Token: 0x060065CE RID: 26062 RVA: 0x0021BE88 File Offset: 0x0021A088
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(30, 1);
		}

		// Token: 0x060065CF RID: 26063 RVA: 0x0021BE98 File Offset: 0x0021A098
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(30) ?? Array.Empty<byte>();
		}

		// Token: 0x17000DDE RID: 3550
		// (get) Token: 0x060065D0 RID: 26064 RVA: 0x0021BEB0 File Offset: 0x0021A0B0
		public float SkillReduceEnergy
		{
			get
			{
				int num = this.__p.__offset(32);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000DDF RID: 3551
		// (get) Token: 0x060065D1 RID: 26065 RVA: 0x0021BEF4 File Offset: 0x0021A0F4
		public float SkillReduceEnergyRateInterval
		{
			get
			{
				int num = this.__p.__offset(34);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000DE0 RID: 3552
		// (get) Token: 0x060065D2 RID: 26066 RVA: 0x0021BF38 File Offset: 0x0021A138
		public float SkillReduceEnergyRate
		{
			get
			{
				int num = this.__p.__offset(36);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000DE1 RID: 3553
		// (get) Token: 0x060065D3 RID: 26067 RVA: 0x0021BF7C File Offset: 0x0021A17C
		public float ReceiveRange
		{
			get
			{
				int num = this.__p.__offset(38);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000DE2 RID: 3554
		// (get) Token: 0x060065D4 RID: 26068 RVA: 0x0021BFC0 File Offset: 0x0021A1C0
		public float GuideMoveSpeed
		{
			get
			{
				int num = this.__p.__offset(40);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000DE3 RID: 3555
		// (get) Token: 0x060065D5 RID: 26069 RVA: 0x0021C004 File Offset: 0x0021A204
		public float GuideEnergyGetRate
		{
			get
			{
				int num = this.__p.__offset(42);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000DE4 RID: 3556
		// (get) Token: 0x060065D6 RID: 26070 RVA: 0x0021C048 File Offset: 0x0021A248
		public string SilhouettePath
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

		// Token: 0x060065D7 RID: 26071 RVA: 0x0021C080 File Offset: 0x0021A280
		public Span<byte> GetSilhouettePathBytes()
		{
			return this.__p.__vector_as_span<byte>(44, 1);
		}

		// Token: 0x060065D8 RID: 26072 RVA: 0x0021C090 File Offset: 0x0021A290
		public byte[] GetSilhouettePathArray()
		{
			return this.__p.__vector_as_array<byte>(44) ?? Array.Empty<byte>();
		}

		// Token: 0x17000DE5 RID: 3557
		// (get) Token: 0x060065D9 RID: 26073 RVA: 0x0021C0A8 File Offset: 0x0021A2A8
		public string RoleTexturePath
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

		// Token: 0x060065DA RID: 26074 RVA: 0x0021C0E0 File Offset: 0x0021A2E0
		public Span<byte> GetRoleTexturePathBytes()
		{
			return this.__p.__vector_as_span<byte>(46, 1);
		}

		// Token: 0x060065DB RID: 26075 RVA: 0x0021C0F0 File Offset: 0x0021A2F0
		public byte[] GetRoleTexturePathArray()
		{
			return this.__p.__vector_as_array<byte>(46) ?? Array.Empty<byte>();
		}

		// Token: 0x17000DE6 RID: 3558
		// (get) Token: 0x060065DC RID: 26076 RVA: 0x0021C108 File Offset: 0x0021A308
		public string SpineAtlasPath
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

		// Token: 0x060065DD RID: 26077 RVA: 0x0021C140 File Offset: 0x0021A340
		public Span<byte> GetSpineAtlasPathBytes()
		{
			return this.__p.__vector_as_span<byte>(48, 1);
		}

		// Token: 0x060065DE RID: 26078 RVA: 0x0021C150 File Offset: 0x0021A350
		public byte[] GetSpineAtlasPathArray()
		{
			return this.__p.__vector_as_array<byte>(48) ?? Array.Empty<byte>();
		}

		// Token: 0x17000DE7 RID: 3559
		// (get) Token: 0x060065DF RID: 26079 RVA: 0x0021C168 File Offset: 0x0021A368
		public string SpineSkeletonDataPath
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

		// Token: 0x060065E0 RID: 26080 RVA: 0x0021C1A0 File Offset: 0x0021A3A0
		public Span<byte> GetSpineSkeletonDataPathBytes()
		{
			return this.__p.__vector_as_span<byte>(50, 1);
		}

		// Token: 0x060065E1 RID: 26081 RVA: 0x0021C1B0 File Offset: 0x0021A3B0
		public byte[] GetSpineSkeletonDataPathArray()
		{
			return this.__p.__vector_as_array<byte>(50) ?? Array.Empty<byte>();
		}

		// Token: 0x060065E2 RID: 26082 RVA: 0x0021C1C8 File Offset: 0x0021A3C8
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用BowlSizeIter()或GetBowlSizeBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly float[] BowlSize()
		{
			DropCatchRole dropCatchRole = this;
			return dropCatchRole.GetBowlSizeArray() ?? Array.Empty<float>();
		}

		// Token: 0x060065E3 RID: 26083 RVA: 0x0021C1EC File Offset: 0x0021A3EC
		[NullableContext(1)]
		public readonly IEnumerable<float> BowlSizeIter()
		{
			DropCatchRole.<BowlSizeIter>d__81 <BowlSizeIter>d__ = new DropCatchRole.<BowlSizeIter>d__81(-2);
			<BowlSizeIter>d__.<>3__<>4__this = this;
			return <BowlSizeIter>d__;
		}

		// Token: 0x060065E4 RID: 26084 RVA: 0x0021C204 File Offset: 0x0021A404
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用BowlSizeBiasNewIter()或GetBowlSizeBiasNewBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly float[] BowlSizeBiasNew()
		{
			DropCatchRole dropCatchRole = this;
			return dropCatchRole.GetBowlSizeBiasNewArray() ?? Array.Empty<float>();
		}

		// Token: 0x060065E5 RID: 26085 RVA: 0x0021C228 File Offset: 0x0021A428
		[NullableContext(1)]
		public readonly IEnumerable<float> BowlSizeBiasNewIter()
		{
			DropCatchRole.<BowlSizeBiasNewIter>d__83 <BowlSizeBiasNewIter>d__ = new DropCatchRole.<BowlSizeBiasNewIter>d__83(-2);
			<BowlSizeBiasNewIter>d__.<>3__<>4__this = this;
			return <BowlSizeBiasNewIter>d__;
		}

		// Token: 0x060065E6 RID: 26086 RVA: 0x0021C240 File Offset: 0x0021A440
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用RoleSizeIter()或GetRoleSizeBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly float[] RoleSize()
		{
			DropCatchRole dropCatchRole = this;
			return dropCatchRole.GetRoleSizeArray() ?? Array.Empty<float>();
		}

		// Token: 0x060065E7 RID: 26087 RVA: 0x0021C264 File Offset: 0x0021A464
		[NullableContext(1)]
		public readonly IEnumerable<float> RoleSizeIter()
		{
			DropCatchRole.<RoleSizeIter>d__85 <RoleSizeIter>d__ = new DropCatchRole.<RoleSizeIter>d__85(-2);
			<RoleSizeIter>d__.<>3__<>4__this = this;
			return <RoleSizeIter>d__;
		}

		// Token: 0x060065E8 RID: 26088 RVA: 0x0021C27C File Offset: 0x0021A47C
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用RoleSizeBiasNewIter()或GetRoleSizeBiasNewBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly float[] RoleSizeBiasNew()
		{
			DropCatchRole dropCatchRole = this;
			return dropCatchRole.GetRoleSizeBiasNewArray() ?? Array.Empty<float>();
		}

		// Token: 0x060065E9 RID: 26089 RVA: 0x0021C2A0 File Offset: 0x0021A4A0
		[NullableContext(1)]
		public readonly IEnumerable<float> RoleSizeBiasNewIter()
		{
			DropCatchRole.<RoleSizeBiasNewIter>d__87 <RoleSizeBiasNewIter>d__ = new DropCatchRole.<RoleSizeBiasNewIter>d__87(-2);
			<RoleSizeBiasNewIter>d__.<>3__<>4__this = this;
			return <RoleSizeBiasNewIter>d__;
		}

		// Token: 0x04004C4C RID: 19532
		private Table __p;
	}
}
