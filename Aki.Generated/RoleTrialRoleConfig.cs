using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001065 RID: 4197
	public struct RoleTrialRoleConfig : IFlatbufferObject
	{
		// Token: 0x1700338B RID: 13195
		// (get) Token: 0x0600CB9B RID: 52123 RVA: 0x00301400 File Offset: 0x002FF600
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600CB9C RID: 52124 RVA: 0x0030140D File Offset: 0x002FF60D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600CB9D RID: 52125 RVA: 0x00301414 File Offset: 0x002FF614
		public static RoleTrialRoleConfig GetRootAsRoleTrialRoleConfig(ByteBuffer _bb)
		{
			return RoleTrialRoleConfig.GetRootAsRoleTrialRoleConfig(_bb, default(RoleTrialRoleConfig));
		}

		// Token: 0x0600CB9E RID: 52126 RVA: 0x00301430 File Offset: 0x002FF630
		public static RoleTrialRoleConfig GetRootAsRoleTrialRoleConfig(ByteBuffer _bb, RoleTrialRoleConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600CB9F RID: 52127 RVA: 0x0030144D File Offset: 0x002FF64D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600CBA0 RID: 52128 RVA: 0x0030145C File Offset: 0x002FF65C
		public RoleTrialRoleConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700338C RID: 13196
		// (get) Token: 0x0600CBA1 RID: 52129 RVA: 0x0030146C File Offset: 0x002FF66C
		public int RoleId
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

		// Token: 0x1700338D RID: 13197
		// (get) Token: 0x0600CBA2 RID: 52130 RVA: 0x003014A8 File Offset: 0x002FF6A8
		public string RoleStand
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600CBA3 RID: 52131 RVA: 0x003014DF File Offset: 0x002FF6DF
		public Span<byte> GetRoleStandBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600CBA4 RID: 52132 RVA: 0x003014EE File Offset: 0x002FF6EE
		public byte[] GetRoleStandArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x1700338E RID: 13198
		// (get) Token: 0x0600CBA5 RID: 52133 RVA: 0x00301508 File Offset: 0x002FF708
		public string RoleStand2
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

		// Token: 0x0600CBA6 RID: 52134 RVA: 0x0030153F File Offset: 0x002FF73F
		public Span<byte> GetRoleStand2Bytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600CBA7 RID: 52135 RVA: 0x0030154E File Offset: 0x002FF74E
		public byte[] GetRoleStand2Array()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x1700338F RID: 13199
		// (get) Token: 0x0600CBA8 RID: 52136 RVA: 0x00301568 File Offset: 0x002FF768
		public string RoleIcon
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

		// Token: 0x0600CBA9 RID: 52137 RVA: 0x003015A0 File Offset: 0x002FF7A0
		public Span<byte> GetRoleIconBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600CBAA RID: 52138 RVA: 0x003015B0 File Offset: 0x002FF7B0
		public byte[] GetRoleIconArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17003390 RID: 13200
		// (get) Token: 0x0600CBAB RID: 52139 RVA: 0x003015C8 File Offset: 0x002FF7C8
		public int UiConfigId
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

		// Token: 0x17003391 RID: 13201
		// (get) Token: 0x0600CBAC RID: 52140 RVA: 0x00301608 File Offset: 0x002FF808
		public string Introduction
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

		// Token: 0x0600CBAD RID: 52141 RVA: 0x00301640 File Offset: 0x002FF840
		public Span<byte> GetIntroductionBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600CBAE RID: 52142 RVA: 0x00301650 File Offset: 0x002FF850
		public byte[] GetIntroductionArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17003392 RID: 13202
		// (get) Token: 0x0600CBAF RID: 52143 RVA: 0x00301668 File Offset: 0x002FF868
		public string FormationSpineSkeletonData
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

		// Token: 0x0600CBB0 RID: 52144 RVA: 0x003016A0 File Offset: 0x002FF8A0
		public Span<byte> GetFormationSpineSkeletonDataBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600CBB1 RID: 52145 RVA: 0x003016B0 File Offset: 0x002FF8B0
		public byte[] GetFormationSpineSkeletonDataArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x17003393 RID: 13203
		// (get) Token: 0x0600CBB2 RID: 52146 RVA: 0x003016C8 File Offset: 0x002FF8C8
		public string FormationSpineAtlas
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

		// Token: 0x0600CBB3 RID: 52147 RVA: 0x00301700 File Offset: 0x002FF900
		public Span<byte> GetFormationSpineAtlasBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0600CBB4 RID: 52148 RVA: 0x00301710 File Offset: 0x002FF910
		public byte[] GetFormationSpineAtlasArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x0600CBB5 RID: 52149 RVA: 0x00301728 File Offset: 0x002FF928
		public float SpineParam(int j)
		{
			int num = this.__p.__offset(20);
			if (num == 0)
			{
				return 0f;
			}
			return this.__p.bb.GetFloat(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003394 RID: 13204
		// (get) Token: 0x0600CBB6 RID: 52150 RVA: 0x0030176C File Offset: 0x002FF96C
		public int SpineParamLength
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

		// Token: 0x0600CBB7 RID: 52151 RVA: 0x00301798 File Offset: 0x002FF998
		public Span<float> GetSpineParamBytes()
		{
			return this.__p.__vector_as_span<float>(20, 4);
		}

		// Token: 0x0600CBB8 RID: 52152 RVA: 0x003017A8 File Offset: 0x002FF9A8
		public float[] GetSpineParamArray()
		{
			return this.__p.__vector_as_array<float>(20) ?? Array.Empty<float>();
		}

		// Token: 0x0600CBB9 RID: 52153 RVA: 0x003017C0 File Offset: 0x002FF9C0
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用SpineParamIter()或GetSpineParamBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly float[] SpineParam()
		{
			RoleTrialRoleConfig roleTrialRoleConfig = this;
			return roleTrialRoleConfig.GetSpineParamArray() ?? Array.Empty<float>();
		}

		// Token: 0x0600CBBA RID: 52154 RVA: 0x003017E4 File Offset: 0x002FF9E4
		[NullableContext(1)]
		public readonly IEnumerable<float> SpineParamIter()
		{
			RoleTrialRoleConfig.<SpineParamIter>d__42 <SpineParamIter>d__ = new RoleTrialRoleConfig.<SpineParamIter>d__42(-2);
			<SpineParamIter>d__.<>3__<>4__this = this;
			return <SpineParamIter>d__;
		}

		// Token: 0x0400516A RID: 20842
		private Table __p;
	}
}
