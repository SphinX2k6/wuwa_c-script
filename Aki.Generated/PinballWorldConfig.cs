using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F42 RID: 3906
	public struct PinballWorldConfig : IFlatbufferObject
	{
		// Token: 0x17002A1C RID: 10780
		// (get) Token: 0x0600B100 RID: 45312 RVA: 0x002C6570 File Offset: 0x002C4770
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600B101 RID: 45313 RVA: 0x002C657D File Offset: 0x002C477D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600B102 RID: 45314 RVA: 0x002C6584 File Offset: 0x002C4784
		public static PinballWorldConfig GetRootAsPinballWorldConfig(ByteBuffer _bb)
		{
			return PinballWorldConfig.GetRootAsPinballWorldConfig(_bb, default(PinballWorldConfig));
		}

		// Token: 0x0600B103 RID: 45315 RVA: 0x002C65A0 File Offset: 0x002C47A0
		public static PinballWorldConfig GetRootAsPinballWorldConfig(ByteBuffer _bb, PinballWorldConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600B104 RID: 45316 RVA: 0x002C65BD File Offset: 0x002C47BD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600B105 RID: 45317 RVA: 0x002C65CC File Offset: 0x002C47CC
		public PinballWorldConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002A1D RID: 10781
		// (get) Token: 0x0600B106 RID: 45318 RVA: 0x002C65DC File Offset: 0x002C47DC
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

		// Token: 0x17002A1E RID: 10782
		// (get) Token: 0x0600B107 RID: 45319 RVA: 0x002C6618 File Offset: 0x002C4818
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

		// Token: 0x17002A1F RID: 10783
		// (get) Token: 0x0600B108 RID: 45320 RVA: 0x002C6654 File Offset: 0x002C4854
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

		// Token: 0x0600B109 RID: 45321 RVA: 0x002C668B File Offset: 0x002C488B
		public Span<byte> GetShapeWorldDaPathBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600B10A RID: 45322 RVA: 0x002C669A File Offset: 0x002C489A
		public byte[] GetShapeWorldDaPathArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17002A20 RID: 10784
		// (get) Token: 0x0600B10B RID: 45323 RVA: 0x002C66B4 File Offset: 0x002C48B4
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

		// Token: 0x0600B10C RID: 45324 RVA: 0x002C66EC File Offset: 0x002C48EC
		public Span<byte> GetShapeWorldBoundsDaPathBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600B10D RID: 45325 RVA: 0x002C66FC File Offset: 0x002C48FC
		public byte[] GetShapeWorldBoundsDaPathArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17002A21 RID: 10785
		// (get) Token: 0x0600B10E RID: 45326 RVA: 0x002C6714 File Offset: 0x002C4914
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

		// Token: 0x0600B10F RID: 45327 RVA: 0x002C674C File Offset: 0x002C494C
		public Span<byte> GetShapeMaterialDtPathBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600B110 RID: 45328 RVA: 0x002C675C File Offset: 0x002C495C
		public byte[] GetShapeMaterialDtPathArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17002A22 RID: 10786
		// (get) Token: 0x0600B111 RID: 45329 RVA: 0x002C6774 File Offset: 0x002C4974
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

		// Token: 0x0600B112 RID: 45330 RVA: 0x002C67AC File Offset: 0x002C49AC
		public Span<byte> GetEntityDtPathBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600B113 RID: 45331 RVA: 0x002C67BC File Offset: 0x002C49BC
		public byte[] GetEntityDtPathArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17002A23 RID: 10787
		// (get) Token: 0x0600B114 RID: 45332 RVA: 0x002C67D4 File Offset: 0x002C49D4
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

		// Token: 0x0600B115 RID: 45333 RVA: 0x002C680C File Offset: 0x002C4A0C
		public Span<byte> GetBulletDtPathBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600B116 RID: 45334 RVA: 0x002C681C File Offset: 0x002C4A1C
		public byte[] GetBulletDtPathArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x17002A24 RID: 10788
		// (get) Token: 0x0600B117 RID: 45335 RVA: 0x002C6834 File Offset: 0x002C4A34
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

		// Token: 0x0600B118 RID: 45336 RVA: 0x002C686C File Offset: 0x002C4A6C
		public Span<byte> GetSkillDtPathBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0600B119 RID: 45337 RVA: 0x002C687C File Offset: 0x002C4A7C
		public byte[] GetSkillDtPathArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x17002A25 RID: 10789
		// (get) Token: 0x0600B11A RID: 45338 RVA: 0x002C6894 File Offset: 0x002C4A94
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

		// Token: 0x17002A26 RID: 10790
		// (get) Token: 0x0600B11B RID: 45339 RVA: 0x002C68F4 File Offset: 0x002C4AF4
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

		// Token: 0x17002A27 RID: 10791
		// (get) Token: 0x0600B11C RID: 45340 RVA: 0x002C6954 File Offset: 0x002C4B54
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

		// Token: 0x17002A28 RID: 10792
		// (get) Token: 0x0600B11D RID: 45341 RVA: 0x002C6994 File Offset: 0x002C4B94
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

		// Token: 0x17002A29 RID: 10793
		// (get) Token: 0x0600B11E RID: 45342 RVA: 0x002C69D4 File Offset: 0x002C4BD4
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

		// Token: 0x17002A2A RID: 10794
		// (get) Token: 0x0600B11F RID: 45343 RVA: 0x002C6A14 File Offset: 0x002C4C14
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

		// Token: 0x0600B120 RID: 45344 RVA: 0x002C6A54 File Offset: 0x002C4C54
		public DicIntString? CommonBuffIconMap(int j)
		{
			int num = this.__p.__offset(32);
			if (num == 0)
			{
				return null;
			}
			return new DicIntString?(default(DicIntString).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17002A2B RID: 10795
		// (get) Token: 0x0600B121 RID: 45345 RVA: 0x002C6AB8 File Offset: 0x002C4CB8
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

		// Token: 0x0600B122 RID: 45346 RVA: 0x002C6AE4 File Offset: 0x002C4CE4
		public float FeverBarDissolveRange(int j)
		{
			int num = this.__p.__offset(34);
			if (num == 0)
			{
				return 0f;
			}
			return this.__p.bb.GetFloat(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002A2C RID: 10796
		// (get) Token: 0x0600B123 RID: 45347 RVA: 0x002C6B28 File Offset: 0x002C4D28
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

		// Token: 0x0600B124 RID: 45348 RVA: 0x002C6B54 File Offset: 0x002C4D54
		public Span<float> GetFeverBarDissolveRangeBytes()
		{
			return this.__p.__vector_as_span<float>(34, 4);
		}

		// Token: 0x0600B125 RID: 45349 RVA: 0x002C6B64 File Offset: 0x002C4D64
		public float[] GetFeverBarDissolveRangeArray()
		{
			return this.__p.__vector_as_array<float>(34) ?? Array.Empty<float>();
		}

		// Token: 0x17002A2D RID: 10797
		// (get) Token: 0x0600B126 RID: 45350 RVA: 0x002C6B7C File Offset: 0x002C4D7C
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

		// Token: 0x0600B127 RID: 45351 RVA: 0x002C6BBC File Offset: 0x002C4DBC
		public float DamageResultTeamRatios(int j)
		{
			int num = this.__p.__offset(38);
			if (num == 0)
			{
				return 0f;
			}
			return this.__p.bb.GetFloat(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002A2E RID: 10798
		// (get) Token: 0x0600B128 RID: 45352 RVA: 0x002C6C00 File Offset: 0x002C4E00
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

		// Token: 0x0600B129 RID: 45353 RVA: 0x002C6C2C File Offset: 0x002C4E2C
		public Span<float> GetDamageResultTeamRatiosBytes()
		{
			return this.__p.__vector_as_span<float>(38, 4);
		}

		// Token: 0x0600B12A RID: 45354 RVA: 0x002C6C3C File Offset: 0x002C4E3C
		public float[] GetDamageResultTeamRatiosArray()
		{
			return this.__p.__vector_as_array<float>(38) ?? Array.Empty<float>();
		}

		// Token: 0x0600B12B RID: 45355 RVA: 0x002C6C54 File Offset: 0x002C4E54
		public float DamageResultClassRatios(int j)
		{
			int num = this.__p.__offset(40);
			if (num == 0)
			{
				return 0f;
			}
			return this.__p.bb.GetFloat(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002A2F RID: 10799
		// (get) Token: 0x0600B12C RID: 45356 RVA: 0x002C6C98 File Offset: 0x002C4E98
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

		// Token: 0x0600B12D RID: 45357 RVA: 0x002C6CC4 File Offset: 0x002C4EC4
		public Span<float> GetDamageResultClassRatiosBytes()
		{
			return this.__p.__vector_as_span<float>(40, 4);
		}

		// Token: 0x0600B12E RID: 45358 RVA: 0x002C6CD4 File Offset: 0x002C4ED4
		public float[] GetDamageResultClassRatiosArray()
		{
			return this.__p.__vector_as_array<float>(40) ?? Array.Empty<float>();
		}

		// Token: 0x17002A30 RID: 10800
		// (get) Token: 0x0600B12F RID: 45359 RVA: 0x002C6CEC File Offset: 0x002C4EEC
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

		// Token: 0x0600B130 RID: 45360 RVA: 0x002C6D30 File Offset: 0x002C4F30
		public DicIntInt? TipsTime(int j)
		{
			int num = this.__p.__offset(44);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17002A31 RID: 10801
		// (get) Token: 0x0600B131 RID: 45361 RVA: 0x002C6D94 File Offset: 0x002C4F94
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

		// Token: 0x17002A32 RID: 10802
		// (get) Token: 0x0600B132 RID: 45362 RVA: 0x002C6DC0 File Offset: 0x002C4FC0
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

		// Token: 0x17002A33 RID: 10803
		// (get) Token: 0x0600B133 RID: 45363 RVA: 0x002C6E00 File Offset: 0x002C5000
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

		// Token: 0x0600B134 RID: 45364 RVA: 0x002C6E40 File Offset: 0x002C5040
		public DicIntFloat? ComboEfficiencyBuffs(int j)
		{
			int num = this.__p.__offset(50);
			if (num == 0)
			{
				return null;
			}
			return new DicIntFloat?(default(DicIntFloat).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17002A34 RID: 10804
		// (get) Token: 0x0600B135 RID: 45365 RVA: 0x002C6EA4 File Offset: 0x002C50A4
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

		// Token: 0x0600B136 RID: 45366 RVA: 0x002C6ED0 File Offset: 0x002C50D0
		[NullableContext(1)]
		[Obsolete("已废弃，请使用ComboEfficiencyBuffsFrozenDict()缓存字典，遍历请使用ComboEfficiencyBuffsIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, float> ComboEfficiencyBuffs()
		{
			return this.ComboEfficiencyBuffsIter().ToDictionary((DicIntFloat element) => element.Key, (DicIntFloat element) => element.Value);
		}

		// Token: 0x0600B137 RID: 45367 RVA: 0x002C6F26 File Offset: 0x002C5126
		[NullableContext(1)]
		public readonly IEnumerable<DicIntFloat> ComboEfficiencyBuffsIter()
		{
			PinballWorldConfig.<ComboEfficiencyBuffsIter>d__81 <ComboEfficiencyBuffsIter>d__ = new PinballWorldConfig.<ComboEfficiencyBuffsIter>d__81(-2);
			<ComboEfficiencyBuffsIter>d__.<>3__<>4__this = this;
			return <ComboEfficiencyBuffsIter>d__;
		}

		// Token: 0x0600B138 RID: 45368 RVA: 0x002C6F3C File Offset: 0x002C513C
		[NullableContext(1)]
		[Obsolete("已废弃，请使用CommonBuffIconMapFrozenDict()缓存字典，遍历请使用CommonBuffIconMapIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, string> CommonBuffIconMap()
		{
			return this.CommonBuffIconMapIter().ToDictionary((DicIntString element) => element.Key, (DicIntString element) => element.Value);
		}

		// Token: 0x0600B139 RID: 45369 RVA: 0x002C6F92 File Offset: 0x002C5192
		[NullableContext(1)]
		public readonly IEnumerable<DicIntString> CommonBuffIconMapIter()
		{
			PinballWorldConfig.<CommonBuffIconMapIter>d__83 <CommonBuffIconMapIter>d__ = new PinballWorldConfig.<CommonBuffIconMapIter>d__83(-2);
			<CommonBuffIconMapIter>d__.<>3__<>4__this = this;
			return <CommonBuffIconMapIter>d__;
		}

		// Token: 0x0600B13A RID: 45370 RVA: 0x002C6FA8 File Offset: 0x002C51A8
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用DamageResultClassRatiosIter()或GetDamageResultClassRatiosBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly float[] DamageResultClassRatios()
		{
			PinballWorldConfig pinballWorldConfig = this;
			return pinballWorldConfig.GetDamageResultClassRatiosArray() ?? Array.Empty<float>();
		}

		// Token: 0x0600B13B RID: 45371 RVA: 0x002C6FCC File Offset: 0x002C51CC
		[NullableContext(1)]
		public readonly IEnumerable<float> DamageResultClassRatiosIter()
		{
			PinballWorldConfig.<DamageResultClassRatiosIter>d__85 <DamageResultClassRatiosIter>d__ = new PinballWorldConfig.<DamageResultClassRatiosIter>d__85(-2);
			<DamageResultClassRatiosIter>d__.<>3__<>4__this = this;
			return <DamageResultClassRatiosIter>d__;
		}

		// Token: 0x0600B13C RID: 45372 RVA: 0x002C6FE4 File Offset: 0x002C51E4
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用DamageResultTeamRatiosIter()或GetDamageResultTeamRatiosBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly float[] DamageResultTeamRatios()
		{
			PinballWorldConfig pinballWorldConfig = this;
			return pinballWorldConfig.GetDamageResultTeamRatiosArray() ?? Array.Empty<float>();
		}

		// Token: 0x0600B13D RID: 45373 RVA: 0x002C7008 File Offset: 0x002C5208
		[NullableContext(1)]
		public readonly IEnumerable<float> DamageResultTeamRatiosIter()
		{
			PinballWorldConfig.<DamageResultTeamRatiosIter>d__87 <DamageResultTeamRatiosIter>d__ = new PinballWorldConfig.<DamageResultTeamRatiosIter>d__87(-2);
			<DamageResultTeamRatiosIter>d__.<>3__<>4__this = this;
			return <DamageResultTeamRatiosIter>d__;
		}

		// Token: 0x0600B13E RID: 45374 RVA: 0x002C7020 File Offset: 0x002C5220
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用FeverBarDissolveRangeIter()或GetFeverBarDissolveRangeBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly float[] FeverBarDissolveRange()
		{
			PinballWorldConfig pinballWorldConfig = this;
			return pinballWorldConfig.GetFeverBarDissolveRangeArray() ?? Array.Empty<float>();
		}

		// Token: 0x0600B13F RID: 45375 RVA: 0x002C7044 File Offset: 0x002C5244
		[NullableContext(1)]
		public readonly IEnumerable<float> FeverBarDissolveRangeIter()
		{
			PinballWorldConfig.<FeverBarDissolveRangeIter>d__89 <FeverBarDissolveRangeIter>d__ = new PinballWorldConfig.<FeverBarDissolveRangeIter>d__89(-2);
			<FeverBarDissolveRangeIter>d__.<>3__<>4__this = this;
			return <FeverBarDissolveRangeIter>d__;
		}

		// Token: 0x0600B140 RID: 45376 RVA: 0x002C705C File Offset: 0x002C525C
		[NullableContext(1)]
		[Obsolete("已废弃，请使用TipsTimeFrozenDict()缓存字典，遍历请使用TipsTimeIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, int> TipsTime()
		{
			return this.TipsTimeIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x0600B141 RID: 45377 RVA: 0x002C70B2 File Offset: 0x002C52B2
		[NullableContext(1)]
		public readonly IEnumerable<DicIntInt> TipsTimeIter()
		{
			PinballWorldConfig.<TipsTimeIter>d__91 <TipsTimeIter>d__ = new PinballWorldConfig.<TipsTimeIter>d__91(-2);
			<TipsTimeIter>d__.<>3__<>4__this = this;
			return <TipsTimeIter>d__;
		}

		// Token: 0x0600B142 RID: 45378 RVA: 0x002C70C8 File Offset: 0x002C52C8
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

		// Token: 0x0600B143 RID: 45379 RVA: 0x002C70FC File Offset: 0x002C52FC
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

		// Token: 0x0600B144 RID: 45380 RVA: 0x002C7124 File Offset: 0x002C5324
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

		// Token: 0x0600B145 RID: 45381 RVA: 0x002C7158 File Offset: 0x002C5358
		private void EnsureComboEfficiencyBuffsCacheIfNeeded()
		{
			if (this.ComboEfficiencyBuffsCache != null)
			{
				return;
			}
			this.ComboEfficiencyBuffsCache = this.ComboEfficiencyBuffsIter().ToFrozenDictionary((DicIntFloat kvp) => kvp.Key, (DicIntFloat kvp) => kvp.Value, null);
		}

		// Token: 0x0600B146 RID: 45382 RVA: 0x002C71C0 File Offset: 0x002C53C0
		private void EnsureCommonBuffIconMapCacheIfNeeded()
		{
			if (this.CommonBuffIconMapCache != null)
			{
				return;
			}
			this.CommonBuffIconMapCache = this.CommonBuffIconMapIter().ToFrozenDictionary((DicIntString kvp) => kvp.Key, (DicIntString kvp) => kvp.Value, null);
		}

		// Token: 0x0600B147 RID: 45383 RVA: 0x002C7228 File Offset: 0x002C5428
		private void EnsureTipsTimeCacheIfNeeded()
		{
			if (this.TipsTimeCache != null)
			{
				return;
			}
			this.TipsTimeCache = this.TipsTimeIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x0600B148 RID: 45384 RVA: 0x002C728E File Offset: 0x002C548E
		[NullableContext(2)]
		public FrozenDictionary<int, float> GetComboEfficiencyBuffsFrozenDict(int key)
		{
			this.EnsureComboEfficiencyBuffsCacheIfNeeded();
			return this.ComboEfficiencyBuffsCache;
		}

		// Token: 0x0600B149 RID: 45385 RVA: 0x002C729C File Offset: 0x002C549C
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public FrozenDictionary<int, string> GetCommonBuffIconMapFrozenDict(int key)
		{
			this.EnsureCommonBuffIconMapCacheIfNeeded();
			return this.CommonBuffIconMapCache;
		}

		// Token: 0x0600B14A RID: 45386 RVA: 0x002C72AA File Offset: 0x002C54AA
		[NullableContext(2)]
		public FrozenDictionary<int, int> GetTipsTimeFrozenDict(int key)
		{
			this.EnsureTipsTimeCacheIfNeeded();
			return this.TipsTimeCache;
		}

		// Token: 0x0400500C RID: 20492
		private Table __p;

		// Token: 0x0400500D RID: 20493
		[Nullable(2)]
		private FrozenDictionary<int, float> ComboEfficiencyBuffsCache;

		// Token: 0x0400500E RID: 20494
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private FrozenDictionary<int, string> CommonBuffIconMapCache;

		// Token: 0x0400500F RID: 20495
		[Nullable(2)]
		private FrozenDictionary<int, int> TipsTimeCache;
	}
}
