using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000CF1 RID: 3313
	public struct DropCatchRole : IFlatbufferObject
	{
		// Token: 0x17000E1B RID: 3611
		// (get) Token: 0x06006B8B RID: 27531 RVA: 0x0023AC64 File Offset: 0x00238E64
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06006B8C RID: 27532 RVA: 0x0023AC71 File Offset: 0x00238E71
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06006B8D RID: 27533 RVA: 0x0023AC78 File Offset: 0x00238E78
		public static DropCatchRole GetRootAsDropCatchRole(ByteBuffer _bb)
		{
			return DropCatchRole.GetRootAsDropCatchRole(_bb, default(DropCatchRole));
		}

		// Token: 0x06006B8E RID: 27534 RVA: 0x0023AC94 File Offset: 0x00238E94
		public static DropCatchRole GetRootAsDropCatchRole(ByteBuffer _bb, DropCatchRole obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06006B8F RID: 27535 RVA: 0x0023ACB1 File Offset: 0x00238EB1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06006B90 RID: 27536 RVA: 0x0023ACC0 File Offset: 0x00238EC0
		public DropCatchRole __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000E1C RID: 3612
		// (get) Token: 0x06006B91 RID: 27537 RVA: 0x0023ACD0 File Offset: 0x00238ED0
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

		// Token: 0x17000E1D RID: 3613
		// (get) Token: 0x06006B92 RID: 27538 RVA: 0x0023AD0C File Offset: 0x00238F0C
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

		// Token: 0x17000E1E RID: 3614
		// (get) Token: 0x06006B93 RID: 27539 RVA: 0x0023AD4C File Offset: 0x00238F4C
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

		// Token: 0x17000E1F RID: 3615
		// (get) Token: 0x06006B94 RID: 27540 RVA: 0x0023AD8C File Offset: 0x00238F8C
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

		// Token: 0x17000E20 RID: 3616
		// (get) Token: 0x06006B95 RID: 27541 RVA: 0x0023ADD0 File Offset: 0x00238FD0
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

		// Token: 0x06006B96 RID: 27542 RVA: 0x0023AE14 File Offset: 0x00239014
		public float RoleSize(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return 0f;
			}
			return this.__p.bb.GetFloat(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000E21 RID: 3617
		// (get) Token: 0x06006B97 RID: 27543 RVA: 0x0023AE58 File Offset: 0x00239058
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

		// Token: 0x06006B98 RID: 27544 RVA: 0x0023AE84 File Offset: 0x00239084
		public Span<float> GetRoleSizeBytes()
		{
			return this.__p.__vector_as_span<float>(14, 4);
		}

		// Token: 0x06006B99 RID: 27545 RVA: 0x0023AE94 File Offset: 0x00239094
		public float[] GetRoleSizeArray()
		{
			return this.__p.__vector_as_array<float>(14) ?? Array.Empty<float>();
		}

		// Token: 0x06006B9A RID: 27546 RVA: 0x0023AEAC File Offset: 0x002390AC
		public float RoleSizeBiasNew(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return 0f;
			}
			return this.__p.bb.GetFloat(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000E22 RID: 3618
		// (get) Token: 0x06006B9B RID: 27547 RVA: 0x0023AEF0 File Offset: 0x002390F0
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

		// Token: 0x06006B9C RID: 27548 RVA: 0x0023AF1C File Offset: 0x0023911C
		public Span<float> GetRoleSizeBiasNewBytes()
		{
			return this.__p.__vector_as_span<float>(16, 4);
		}

		// Token: 0x06006B9D RID: 27549 RVA: 0x0023AF2C File Offset: 0x0023912C
		public float[] GetRoleSizeBiasNewArray()
		{
			return this.__p.__vector_as_array<float>(16) ?? Array.Empty<float>();
		}

		// Token: 0x17000E23 RID: 3619
		// (get) Token: 0x06006B9E RID: 27550 RVA: 0x0023AF44 File Offset: 0x00239144
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

		// Token: 0x06006B9F RID: 27551 RVA: 0x0023AF88 File Offset: 0x00239188
		public float BowlSize(int j)
		{
			int num = this.__p.__offset(20);
			if (num == 0)
			{
				return 0f;
			}
			return this.__p.bb.GetFloat(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000E24 RID: 3620
		// (get) Token: 0x06006BA0 RID: 27552 RVA: 0x0023AFCC File Offset: 0x002391CC
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

		// Token: 0x06006BA1 RID: 27553 RVA: 0x0023AFF8 File Offset: 0x002391F8
		public Span<float> GetBowlSizeBytes()
		{
			return this.__p.__vector_as_span<float>(20, 4);
		}

		// Token: 0x06006BA2 RID: 27554 RVA: 0x0023B008 File Offset: 0x00239208
		public float[] GetBowlSizeArray()
		{
			return this.__p.__vector_as_array<float>(20) ?? Array.Empty<float>();
		}

		// Token: 0x06006BA3 RID: 27555 RVA: 0x0023B020 File Offset: 0x00239220
		public float BowlSizeBiasNew(int j)
		{
			int num = this.__p.__offset(22);
			if (num == 0)
			{
				return 0f;
			}
			return this.__p.bb.GetFloat(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000E25 RID: 3621
		// (get) Token: 0x06006BA4 RID: 27556 RVA: 0x0023B064 File Offset: 0x00239264
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

		// Token: 0x06006BA5 RID: 27557 RVA: 0x0023B090 File Offset: 0x00239290
		public Span<float> GetBowlSizeBiasNewBytes()
		{
			return this.__p.__vector_as_span<float>(22, 4);
		}

		// Token: 0x06006BA6 RID: 27558 RVA: 0x0023B0A0 File Offset: 0x002392A0
		public float[] GetBowlSizeBiasNewArray()
		{
			return this.__p.__vector_as_array<float>(22) ?? Array.Empty<float>();
		}

		// Token: 0x17000E26 RID: 3622
		// (get) Token: 0x06006BA7 RID: 27559 RVA: 0x0023B0B8 File Offset: 0x002392B8
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

		// Token: 0x17000E27 RID: 3623
		// (get) Token: 0x06006BA8 RID: 27560 RVA: 0x0023B0FC File Offset: 0x002392FC
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

		// Token: 0x17000E28 RID: 3624
		// (get) Token: 0x06006BA9 RID: 27561 RVA: 0x0023B140 File Offset: 0x00239340
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

		// Token: 0x06006BAA RID: 27562 RVA: 0x0023B178 File Offset: 0x00239378
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(28, 1);
		}

		// Token: 0x06006BAB RID: 27563 RVA: 0x0023B188 File Offset: 0x00239388
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(28) ?? Array.Empty<byte>();
		}

		// Token: 0x17000E29 RID: 3625
		// (get) Token: 0x06006BAC RID: 27564 RVA: 0x0023B1A0 File Offset: 0x002393A0
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

		// Token: 0x06006BAD RID: 27565 RVA: 0x0023B1D8 File Offset: 0x002393D8
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(30, 1);
		}

		// Token: 0x06006BAE RID: 27566 RVA: 0x0023B1E8 File Offset: 0x002393E8
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(30) ?? Array.Empty<byte>();
		}

		// Token: 0x17000E2A RID: 3626
		// (get) Token: 0x06006BAF RID: 27567 RVA: 0x0023B200 File Offset: 0x00239400
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

		// Token: 0x17000E2B RID: 3627
		// (get) Token: 0x06006BB0 RID: 27568 RVA: 0x0023B244 File Offset: 0x00239444
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

		// Token: 0x17000E2C RID: 3628
		// (get) Token: 0x06006BB1 RID: 27569 RVA: 0x0023B288 File Offset: 0x00239488
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

		// Token: 0x17000E2D RID: 3629
		// (get) Token: 0x06006BB2 RID: 27570 RVA: 0x0023B2CC File Offset: 0x002394CC
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

		// Token: 0x17000E2E RID: 3630
		// (get) Token: 0x06006BB3 RID: 27571 RVA: 0x0023B310 File Offset: 0x00239510
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

		// Token: 0x17000E2F RID: 3631
		// (get) Token: 0x06006BB4 RID: 27572 RVA: 0x0023B354 File Offset: 0x00239554
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

		// Token: 0x17000E30 RID: 3632
		// (get) Token: 0x06006BB5 RID: 27573 RVA: 0x0023B398 File Offset: 0x00239598
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

		// Token: 0x06006BB6 RID: 27574 RVA: 0x0023B3D0 File Offset: 0x002395D0
		public Span<byte> GetSilhouettePathBytes()
		{
			return this.__p.__vector_as_span<byte>(44, 1);
		}

		// Token: 0x06006BB7 RID: 27575 RVA: 0x0023B3E0 File Offset: 0x002395E0
		public byte[] GetSilhouettePathArray()
		{
			return this.__p.__vector_as_array<byte>(44) ?? Array.Empty<byte>();
		}

		// Token: 0x17000E31 RID: 3633
		// (get) Token: 0x06006BB8 RID: 27576 RVA: 0x0023B3F8 File Offset: 0x002395F8
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

		// Token: 0x06006BB9 RID: 27577 RVA: 0x0023B430 File Offset: 0x00239630
		public Span<byte> GetRoleTexturePathBytes()
		{
			return this.__p.__vector_as_span<byte>(46, 1);
		}

		// Token: 0x06006BBA RID: 27578 RVA: 0x0023B440 File Offset: 0x00239640
		public byte[] GetRoleTexturePathArray()
		{
			return this.__p.__vector_as_array<byte>(46) ?? Array.Empty<byte>();
		}

		// Token: 0x17000E32 RID: 3634
		// (get) Token: 0x06006BBB RID: 27579 RVA: 0x0023B458 File Offset: 0x00239658
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

		// Token: 0x06006BBC RID: 27580 RVA: 0x0023B490 File Offset: 0x00239690
		public Span<byte> GetSpineAtlasPathBytes()
		{
			return this.__p.__vector_as_span<byte>(48, 1);
		}

		// Token: 0x06006BBD RID: 27581 RVA: 0x0023B4A0 File Offset: 0x002396A0
		public byte[] GetSpineAtlasPathArray()
		{
			return this.__p.__vector_as_array<byte>(48) ?? Array.Empty<byte>();
		}

		// Token: 0x17000E33 RID: 3635
		// (get) Token: 0x06006BBE RID: 27582 RVA: 0x0023B4B8 File Offset: 0x002396B8
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

		// Token: 0x06006BBF RID: 27583 RVA: 0x0023B4F0 File Offset: 0x002396F0
		public Span<byte> GetSpineSkeletonDataPathBytes()
		{
			return this.__p.__vector_as_span<byte>(50, 1);
		}

		// Token: 0x06006BC0 RID: 27584 RVA: 0x0023B500 File Offset: 0x00239700
		public byte[] GetSpineSkeletonDataPathArray()
		{
			return this.__p.__vector_as_array<byte>(50) ?? Array.Empty<byte>();
		}

		// Token: 0x06006BC1 RID: 27585 RVA: 0x0023B518 File Offset: 0x00239718
		[NullableContext(1)]
		public float[] BowlSize()
		{
			return this.GetBowlSizeArray();
		}

		// Token: 0x06006BC2 RID: 27586 RVA: 0x0023B520 File Offset: 0x00239720
		[NullableContext(1)]
		public IEnumerable<float> BowlSizeIter()
		{
			DropCatchRole.<BowlSizeIter>d__81 <BowlSizeIter>d__ = new DropCatchRole.<BowlSizeIter>d__81(-2);
			<BowlSizeIter>d__.<>3__<>4__this = this;
			return <BowlSizeIter>d__;
		}

		// Token: 0x06006BC3 RID: 27587 RVA: 0x0023B535 File Offset: 0x00239735
		[NullableContext(1)]
		public float[] BowlSizeBiasNew()
		{
			return this.GetBowlSizeBiasNewArray();
		}

		// Token: 0x06006BC4 RID: 27588 RVA: 0x0023B53D File Offset: 0x0023973D
		[NullableContext(1)]
		public IEnumerable<float> BowlSizeBiasNewIter()
		{
			DropCatchRole.<BowlSizeBiasNewIter>d__83 <BowlSizeBiasNewIter>d__ = new DropCatchRole.<BowlSizeBiasNewIter>d__83(-2);
			<BowlSizeBiasNewIter>d__.<>3__<>4__this = this;
			return <BowlSizeBiasNewIter>d__;
		}

		// Token: 0x06006BC5 RID: 27589 RVA: 0x0023B552 File Offset: 0x00239752
		[NullableContext(1)]
		public float[] RoleSize()
		{
			return this.GetRoleSizeArray();
		}

		// Token: 0x06006BC6 RID: 27590 RVA: 0x0023B55A File Offset: 0x0023975A
		[NullableContext(1)]
		public IEnumerable<float> RoleSizeIter()
		{
			DropCatchRole.<RoleSizeIter>d__85 <RoleSizeIter>d__ = new DropCatchRole.<RoleSizeIter>d__85(-2);
			<RoleSizeIter>d__.<>3__<>4__this = this;
			return <RoleSizeIter>d__;
		}

		// Token: 0x06006BC7 RID: 27591 RVA: 0x0023B56F File Offset: 0x0023976F
		[NullableContext(1)]
		public float[] RoleSizeBiasNew()
		{
			return this.GetRoleSizeBiasNewArray();
		}

		// Token: 0x06006BC8 RID: 27592 RVA: 0x0023B577 File Offset: 0x00239777
		[NullableContext(1)]
		public IEnumerable<float> RoleSizeBiasNewIter()
		{
			DropCatchRole.<RoleSizeBiasNewIter>d__87 <RoleSizeBiasNewIter>d__ = new DropCatchRole.<RoleSizeBiasNewIter>d__87(-2);
			<RoleSizeBiasNewIter>d__.<>3__<>4__this = this;
			return <RoleSizeBiasNewIter>d__;
		}

		// Token: 0x0400522E RID: 21038
		private Table __p;
	}
}
