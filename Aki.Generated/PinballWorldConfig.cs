using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001027 RID: 4135
	public struct PinballWorldConfig : IFlatbufferObject
	{
		// Token: 0x17002A82 RID: 10882
		// (get) Token: 0x0600B721 RID: 46881 RVA: 0x002E2E50 File Offset: 0x002E1050
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600B722 RID: 46882 RVA: 0x002E2E5D File Offset: 0x002E105D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600B723 RID: 46883 RVA: 0x002E2E64 File Offset: 0x002E1064
		public static PinballWorldConfig GetRootAsPinballWorldConfig(ByteBuffer _bb)
		{
			return PinballWorldConfig.GetRootAsPinballWorldConfig(_bb, default(PinballWorldConfig));
		}

		// Token: 0x0600B724 RID: 46884 RVA: 0x002E2E80 File Offset: 0x002E1080
		public static PinballWorldConfig GetRootAsPinballWorldConfig(ByteBuffer _bb, PinballWorldConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600B725 RID: 46885 RVA: 0x002E2E9D File Offset: 0x002E109D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600B726 RID: 46886 RVA: 0x002E2EAC File Offset: 0x002E10AC
		public PinballWorldConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002A83 RID: 10883
		// (get) Token: 0x0600B727 RID: 46887 RVA: 0x002E2EBC File Offset: 0x002E10BC
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

		// Token: 0x17002A84 RID: 10884
		// (get) Token: 0x0600B728 RID: 46888 RVA: 0x002E2EF8 File Offset: 0x002E10F8
		public int MapId
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

		// Token: 0x17002A85 RID: 10885
		// (get) Token: 0x0600B729 RID: 46889 RVA: 0x002E2F34 File Offset: 0x002E1134
		public string ShapeWorldDaPath
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

		// Token: 0x0600B72A RID: 46890 RVA: 0x002E2F6B File Offset: 0x002E116B
		public Span<byte> GetShapeWorldDaPathBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600B72B RID: 46891 RVA: 0x002E2F7A File Offset: 0x002E117A
		public byte[] GetShapeWorldDaPathArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17002A86 RID: 10886
		// (get) Token: 0x0600B72C RID: 46892 RVA: 0x002E2F94 File Offset: 0x002E1194
		public string ShapeWorldBoundsDaPath
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

		// Token: 0x0600B72D RID: 46893 RVA: 0x002E2FCC File Offset: 0x002E11CC
		public Span<byte> GetShapeWorldBoundsDaPathBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600B72E RID: 46894 RVA: 0x002E2FDC File Offset: 0x002E11DC
		public byte[] GetShapeWorldBoundsDaPathArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17002A87 RID: 10887
		// (get) Token: 0x0600B72F RID: 46895 RVA: 0x002E2FF4 File Offset: 0x002E11F4
		public string ShapeMaterialDtPath
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

		// Token: 0x0600B730 RID: 46896 RVA: 0x002E302C File Offset: 0x002E122C
		public Span<byte> GetShapeMaterialDtPathBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600B731 RID: 46897 RVA: 0x002E303C File Offset: 0x002E123C
		public byte[] GetShapeMaterialDtPathArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17002A88 RID: 10888
		// (get) Token: 0x0600B732 RID: 46898 RVA: 0x002E3054 File Offset: 0x002E1254
		public string EntityDtPath
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

		// Token: 0x0600B733 RID: 46899 RVA: 0x002E308C File Offset: 0x002E128C
		public Span<byte> GetEntityDtPathBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600B734 RID: 46900 RVA: 0x002E309C File Offset: 0x002E129C
		public byte[] GetEntityDtPathArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17002A89 RID: 10889
		// (get) Token: 0x0600B735 RID: 46901 RVA: 0x002E30B4 File Offset: 0x002E12B4
		public string BulletDtPath
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

		// Token: 0x0600B736 RID: 46902 RVA: 0x002E30EC File Offset: 0x002E12EC
		public Span<byte> GetBulletDtPathBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600B737 RID: 46903 RVA: 0x002E30FC File Offset: 0x002E12FC
		public byte[] GetBulletDtPathArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x17002A8A RID: 10890
		// (get) Token: 0x0600B738 RID: 46904 RVA: 0x002E3114 File Offset: 0x002E1314
		public string SkillDtPath
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

		// Token: 0x0600B739 RID: 46905 RVA: 0x002E314C File Offset: 0x002E134C
		public Span<byte> GetSkillDtPathBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0600B73A RID: 46906 RVA: 0x002E315C File Offset: 0x002E135C
		public byte[] GetSkillDtPathArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x17002A8B RID: 10891
		// (get) Token: 0x0600B73B RID: 46907 RVA: 0x002E3174 File Offset: 0x002E1374
		public Vector? CameraLocation
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return null;
				}
				return new Vector?(default(Vector).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17002A8C RID: 10892
		// (get) Token: 0x0600B73C RID: 46908 RVA: 0x002E31D4 File Offset: 0x002E13D4
		public Vector? CameraRotation
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return null;
				}
				return new Vector?(default(Vector).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17002A8D RID: 10893
		// (get) Token: 0x0600B73D RID: 46909 RVA: 0x002E3234 File Offset: 0x002E1434
		public int CameraFov
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

		// Token: 0x17002A8E RID: 10894
		// (get) Token: 0x0600B73E RID: 46910 RVA: 0x002E3274 File Offset: 0x002E1474
		public int LaunchSplineYOffset
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

		// Token: 0x17002A8F RID: 10895
		// (get) Token: 0x0600B73F RID: 46911 RVA: 0x002E32B4 File Offset: 0x002E14B4
		public int FeverBarYOffset
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

		// Token: 0x17002A90 RID: 10896
		// (get) Token: 0x0600B740 RID: 46912 RVA: 0x002E32F4 File Offset: 0x002E14F4
		public int ForceLaunchTime
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

		// Token: 0x0600B741 RID: 46913 RVA: 0x002E3334 File Offset: 0x002E1534
		public DicIntString? CommonBuffIconMap(int j)
		{
			int num = this.__p.__offset(32);
			if (num == 0)
			{
				return null;
			}
			return new DicIntString?(default(DicIntString).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17002A91 RID: 10897
		// (get) Token: 0x0600B742 RID: 46914 RVA: 0x002E3398 File Offset: 0x002E1598
		public int CommonBuffIconMapLength
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

		// Token: 0x0600B743 RID: 46915 RVA: 0x002E33C4 File Offset: 0x002E15C4
		public float FeverBarDissolveRange(int j)
		{
			int num = this.__p.__offset(34);
			if (num == 0)
			{
				return 0f;
			}
			return this.__p.bb.GetFloat(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002A92 RID: 10898
		// (get) Token: 0x0600B744 RID: 46916 RVA: 0x002E3408 File Offset: 0x002E1608
		public int FeverBarDissolveRangeLength
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

		// Token: 0x0600B745 RID: 46917 RVA: 0x002E3434 File Offset: 0x002E1634
		public Span<float> GetFeverBarDissolveRangeBytes()
		{
			return this.__p.__vector_as_span<float>(34, 4);
		}

		// Token: 0x0600B746 RID: 46918 RVA: 0x002E3444 File Offset: 0x002E1644
		public float[] GetFeverBarDissolveRangeArray()
		{
			return this.__p.__vector_as_array<float>(34) ?? Array.Empty<float>();
		}

		// Token: 0x17002A93 RID: 10899
		// (get) Token: 0x0600B747 RID: 46919 RVA: 0x002E345C File Offset: 0x002E165C
		public int DamageResultAttrRatio
		{
			get
			{
				int num = this.__p.__offset(36);
				if (num == 0)
				{
					return 1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600B748 RID: 46920 RVA: 0x002E349C File Offset: 0x002E169C
		public float DamageResultTeamRatios(int j)
		{
			int num = this.__p.__offset(38);
			if (num == 0)
			{
				return 0f;
			}
			return this.__p.bb.GetFloat(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002A94 RID: 10900
		// (get) Token: 0x0600B749 RID: 46921 RVA: 0x002E34E0 File Offset: 0x002E16E0
		public int DamageResultTeamRatiosLength
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

		// Token: 0x0600B74A RID: 46922 RVA: 0x002E350C File Offset: 0x002E170C
		public Span<float> GetDamageResultTeamRatiosBytes()
		{
			return this.__p.__vector_as_span<float>(38, 4);
		}

		// Token: 0x0600B74B RID: 46923 RVA: 0x002E351C File Offset: 0x002E171C
		public float[] GetDamageResultTeamRatiosArray()
		{
			return this.__p.__vector_as_array<float>(38) ?? Array.Empty<float>();
		}

		// Token: 0x0600B74C RID: 46924 RVA: 0x002E3534 File Offset: 0x002E1734
		public float DamageResultClassRatios(int j)
		{
			int num = this.__p.__offset(40);
			if (num == 0)
			{
				return 0f;
			}
			return this.__p.bb.GetFloat(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002A95 RID: 10901
		// (get) Token: 0x0600B74D RID: 46925 RVA: 0x002E3578 File Offset: 0x002E1778
		public int DamageResultClassRatiosLength
		{
			get
			{
				int num = this.__p.__offset(40);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600B74E RID: 46926 RVA: 0x002E35A4 File Offset: 0x002E17A4
		public Span<float> GetDamageResultClassRatiosBytes()
		{
			return this.__p.__vector_as_span<float>(40, 4);
		}

		// Token: 0x0600B74F RID: 46927 RVA: 0x002E35B4 File Offset: 0x002E17B4
		public float[] GetDamageResultClassRatiosArray()
		{
			return this.__p.__vector_as_array<float>(40) ?? Array.Empty<float>();
		}

		// Token: 0x17002A96 RID: 10902
		// (get) Token: 0x0600B750 RID: 46928 RVA: 0x002E35CC File Offset: 0x002E17CC
		public float DamageResultSkillRatio
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

		// Token: 0x0600B751 RID: 46929 RVA: 0x002E3610 File Offset: 0x002E1810
		public DicIntInt? TipsTime(int j)
		{
			int num = this.__p.__offset(44);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17002A97 RID: 10903
		// (get) Token: 0x0600B752 RID: 46930 RVA: 0x002E3674 File Offset: 0x002E1874
		public int TipsTimeLength
		{
			get
			{
				int num = this.__p.__offset(44);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x17002A98 RID: 10904
		// (get) Token: 0x0600B753 RID: 46931 RVA: 0x002E36A0 File Offset: 0x002E18A0
		public int RoleChargeMaxBuffId
		{
			get
			{
				int num = this.__p.__offset(46);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17002A99 RID: 10905
		// (get) Token: 0x0600B754 RID: 46932 RVA: 0x002E36E0 File Offset: 0x002E18E0
		public int SettleDelay
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

		// Token: 0x0600B755 RID: 46933 RVA: 0x002E3720 File Offset: 0x002E1920
		public DicIntFloat? ComboEfficiencyBuffs(int j)
		{
			int num = this.__p.__offset(50);
			if (num == 0)
			{
				return null;
			}
			return new DicIntFloat?(default(DicIntFloat).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17002A9A RID: 10906
		// (get) Token: 0x0600B756 RID: 46934 RVA: 0x002E3784 File Offset: 0x002E1984
		public int ComboEfficiencyBuffsLength
		{
			get
			{
				int num = this.__p.__offset(50);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600B757 RID: 46935 RVA: 0x002E37B0 File Offset: 0x002E19B0
		[NullableContext(1)]
		public Dictionary<int, float> ComboEfficiencyBuffs()
		{
			return this.ComboEfficiencyBuffsIter().ToDictionary((DicIntFloat element) => element.Key, (DicIntFloat element) => element.Value);
		}

		// Token: 0x0600B758 RID: 46936 RVA: 0x002E3806 File Offset: 0x002E1A06
		[NullableContext(1)]
		public IEnumerable<DicIntFloat> ComboEfficiencyBuffsIter()
		{
			PinballWorldConfig.<ComboEfficiencyBuffsIter>d__81 <ComboEfficiencyBuffsIter>d__ = new PinballWorldConfig.<ComboEfficiencyBuffsIter>d__81(-2);
			<ComboEfficiencyBuffsIter>d__.<>3__<>4__this = this;
			return <ComboEfficiencyBuffsIter>d__;
		}

		// Token: 0x0600B759 RID: 46937 RVA: 0x002E381C File Offset: 0x002E1A1C
		[NullableContext(1)]
		public Dictionary<int, string> CommonBuffIconMap()
		{
			return this.CommonBuffIconMapIter().ToDictionary((DicIntString element) => element.Key, (DicIntString element) => element.Value);
		}

		// Token: 0x0600B75A RID: 46938 RVA: 0x002E3872 File Offset: 0x002E1A72
		[NullableContext(1)]
		public IEnumerable<DicIntString> CommonBuffIconMapIter()
		{
			PinballWorldConfig.<CommonBuffIconMapIter>d__83 <CommonBuffIconMapIter>d__ = new PinballWorldConfig.<CommonBuffIconMapIter>d__83(-2);
			<CommonBuffIconMapIter>d__.<>3__<>4__this = this;
			return <CommonBuffIconMapIter>d__;
		}

		// Token: 0x0600B75B RID: 46939 RVA: 0x002E3887 File Offset: 0x002E1A87
		[NullableContext(1)]
		public float[] DamageResultClassRatios()
		{
			return this.GetDamageResultClassRatiosArray();
		}

		// Token: 0x0600B75C RID: 46940 RVA: 0x002E388F File Offset: 0x002E1A8F
		[NullableContext(1)]
		public IEnumerable<float> DamageResultClassRatiosIter()
		{
			PinballWorldConfig.<DamageResultClassRatiosIter>d__85 <DamageResultClassRatiosIter>d__ = new PinballWorldConfig.<DamageResultClassRatiosIter>d__85(-2);
			<DamageResultClassRatiosIter>d__.<>3__<>4__this = this;
			return <DamageResultClassRatiosIter>d__;
		}

		// Token: 0x0600B75D RID: 46941 RVA: 0x002E38A4 File Offset: 0x002E1AA4
		[NullableContext(1)]
		public float[] DamageResultTeamRatios()
		{
			return this.GetDamageResultTeamRatiosArray();
		}

		// Token: 0x0600B75E RID: 46942 RVA: 0x002E38AC File Offset: 0x002E1AAC
		[NullableContext(1)]
		public IEnumerable<float> DamageResultTeamRatiosIter()
		{
			PinballWorldConfig.<DamageResultTeamRatiosIter>d__87 <DamageResultTeamRatiosIter>d__ = new PinballWorldConfig.<DamageResultTeamRatiosIter>d__87(-2);
			<DamageResultTeamRatiosIter>d__.<>3__<>4__this = this;
			return <DamageResultTeamRatiosIter>d__;
		}

		// Token: 0x0600B75F RID: 46943 RVA: 0x002E38C1 File Offset: 0x002E1AC1
		[NullableContext(1)]
		public float[] FeverBarDissolveRange()
		{
			return this.GetFeverBarDissolveRangeArray();
		}

		// Token: 0x0600B760 RID: 46944 RVA: 0x002E38C9 File Offset: 0x002E1AC9
		[NullableContext(1)]
		public IEnumerable<float> FeverBarDissolveRangeIter()
		{
			PinballWorldConfig.<FeverBarDissolveRangeIter>d__89 <FeverBarDissolveRangeIter>d__ = new PinballWorldConfig.<FeverBarDissolveRangeIter>d__89(-2);
			<FeverBarDissolveRangeIter>d__.<>3__<>4__this = this;
			return <FeverBarDissolveRangeIter>d__;
		}

		// Token: 0x0600B761 RID: 46945 RVA: 0x002E38E0 File Offset: 0x002E1AE0
		[NullableContext(1)]
		public Dictionary<int, int> TipsTime()
		{
			return this.TipsTimeIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x0600B762 RID: 46946 RVA: 0x002E3936 File Offset: 0x002E1B36
		[NullableContext(1)]
		public IEnumerable<DicIntInt> TipsTimeIter()
		{
			PinballWorldConfig.<TipsTimeIter>d__91 <TipsTimeIter>d__ = new PinballWorldConfig.<TipsTimeIter>d__91(-2);
			<TipsTimeIter>d__.<>3__<>4__this = this;
			return <TipsTimeIter>d__;
		}

		// Token: 0x0600B763 RID: 46947 RVA: 0x002E394C File Offset: 0x002E1B4C
		public float? GetComboEfficiencyBuffs(int key)
		{
			this.EnsureComboEfficiencyBuffsCacheIfNeeded();
			float value;
			if (!this.ComboEfficiencyBuffsCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new float?(value);
		}

		// Token: 0x0600B764 RID: 46948 RVA: 0x002E3980 File Offset: 0x002E1B80
		[NullableContext(2)]
		public string GetCommonBuffIconMap(int key)
		{
			this.EnsureCommonBuffIconMapCacheIfNeeded();
			string result;
			if (!this.CommonBuffIconMapCache.TryGetValue(key, out result))
			{
				return null;
			}
			return result;
		}

		// Token: 0x0600B765 RID: 46949 RVA: 0x002E39A8 File Offset: 0x002E1BA8
		public int? GetTipsTime(int key)
		{
			this.EnsureTipsTimeCacheIfNeeded();
			int value;
			if (!this.TipsTimeCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x0600B766 RID: 46950 RVA: 0x002E39DC File Offset: 0x002E1BDC
		private void EnsureComboEfficiencyBuffsCacheIfNeeded()
		{
			if (this.ComboEfficiencyBuffsCache != null)
			{
				return;
			}
			this.ComboEfficiencyBuffsCache = this.ComboEfficiencyBuffsIter().ToFrozenDictionary((DicIntFloat kvp) => kvp.Key, (DicIntFloat kvp) => kvp.Value, null);
		}

		// Token: 0x0600B767 RID: 46951 RVA: 0x002E3A44 File Offset: 0x002E1C44
		private void EnsureCommonBuffIconMapCacheIfNeeded()
		{
			if (this.CommonBuffIconMapCache != null)
			{
				return;
			}
			this.CommonBuffIconMapCache = this.CommonBuffIconMapIter().ToFrozenDictionary((DicIntString kvp) => kvp.Key, (DicIntString kvp) => kvp.Value, null);
		}

		// Token: 0x0600B768 RID: 46952 RVA: 0x002E3AAC File Offset: 0x002E1CAC
		private void EnsureTipsTimeCacheIfNeeded()
		{
			if (this.TipsTimeCache != null)
			{
				return;
			}
			this.TipsTimeCache = this.TipsTimeIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x0600B769 RID: 46953 RVA: 0x002E3B12 File Offset: 0x002E1D12
		[NullableContext(1)]
		public FrozenDictionary<int, float> GetComboEfficiencyBuffsFrozenDict()
		{
			this.EnsureComboEfficiencyBuffsCacheIfNeeded();
			return this.ComboEfficiencyBuffsCache;
		}

		// Token: 0x0600B76A RID: 46954 RVA: 0x002E3B20 File Offset: 0x002E1D20
		[NullableContext(1)]
		public FrozenDictionary<int, string> GetCommonBuffIconMapFrozenDict()
		{
			this.EnsureCommonBuffIconMapCacheIfNeeded();
			return this.CommonBuffIconMapCache;
		}

		// Token: 0x0600B76B RID: 46955 RVA: 0x002E3B2E File Offset: 0x002E1D2E
		[NullableContext(1)]
		public FrozenDictionary<int, int> GetTipsTimeFrozenDict()
		{
			this.EnsureTipsTimeCacheIfNeeded();
			return this.TipsTimeCache;
		}

		// Token: 0x040055F1 RID: 22001
		private Table __p;

		// Token: 0x040055F2 RID: 22002
		[Nullable(2)]
		private FrozenDictionary<int, float> ComboEfficiencyBuffsCache;

		// Token: 0x040055F3 RID: 22003
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private FrozenDictionary<int, string> CommonBuffIconMapCache;

		// Token: 0x040055F4 RID: 22004
		[Nullable(2)]
		private FrozenDictionary<int, int> TipsTimeCache;
	}
}
