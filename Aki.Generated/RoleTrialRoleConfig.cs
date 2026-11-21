using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001160 RID: 4448
	public struct RoleTrialRoleConfig : IFlatbufferObject
	{
		// Token: 0x17003498 RID: 13464
		// (get) Token: 0x0600D36E RID: 54126 RVA: 0x00320CD4 File Offset: 0x0031EED4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600D36F RID: 54127 RVA: 0x00320CE1 File Offset: 0x0031EEE1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600D370 RID: 54128 RVA: 0x00320CE8 File Offset: 0x0031EEE8
		public static RoleTrialRoleConfig GetRootAsRoleTrialRoleConfig(ByteBuffer _bb)
		{
			return RoleTrialRoleConfig.GetRootAsRoleTrialRoleConfig(_bb, default(RoleTrialRoleConfig));
		}

		// Token: 0x0600D371 RID: 54129 RVA: 0x00320D04 File Offset: 0x0031EF04
		public static RoleTrialRoleConfig GetRootAsRoleTrialRoleConfig(ByteBuffer _bb, RoleTrialRoleConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600D372 RID: 54130 RVA: 0x00320D21 File Offset: 0x0031EF21
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600D373 RID: 54131 RVA: 0x00320D30 File Offset: 0x0031EF30
		public RoleTrialRoleConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003499 RID: 13465
		// (get) Token: 0x0600D374 RID: 54132 RVA: 0x00320D40 File Offset: 0x0031EF40
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

		// Token: 0x1700349A RID: 13466
		// (get) Token: 0x0600D375 RID: 54133 RVA: 0x00320D7C File Offset: 0x0031EF7C
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

		// Token: 0x0600D376 RID: 54134 RVA: 0x00320DB3 File Offset: 0x0031EFB3
		public Span<byte> GetRoleStandBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600D377 RID: 54135 RVA: 0x00320DC2 File Offset: 0x0031EFC2
		public byte[] GetRoleStandArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x1700349B RID: 13467
		// (get) Token: 0x0600D378 RID: 54136 RVA: 0x00320DDC File Offset: 0x0031EFDC
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

		// Token: 0x0600D379 RID: 54137 RVA: 0x00320E13 File Offset: 0x0031F013
		public Span<byte> GetRoleStand2Bytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600D37A RID: 54138 RVA: 0x00320E22 File Offset: 0x0031F022
		public byte[] GetRoleStand2Array()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x1700349C RID: 13468
		// (get) Token: 0x0600D37B RID: 54139 RVA: 0x00320E3C File Offset: 0x0031F03C
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

		// Token: 0x0600D37C RID: 54140 RVA: 0x00320E74 File Offset: 0x0031F074
		public Span<byte> GetRoleIconBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600D37D RID: 54141 RVA: 0x00320E84 File Offset: 0x0031F084
		public byte[] GetRoleIconArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x1700349D RID: 13469
		// (get) Token: 0x0600D37E RID: 54142 RVA: 0x00320E9C File Offset: 0x0031F09C
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

		// Token: 0x1700349E RID: 13470
		// (get) Token: 0x0600D37F RID: 54143 RVA: 0x00320EDC File Offset: 0x0031F0DC
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

		// Token: 0x0600D380 RID: 54144 RVA: 0x00320F14 File Offset: 0x0031F114
		public Span<byte> GetIntroductionBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600D381 RID: 54145 RVA: 0x00320F24 File Offset: 0x0031F124
		public byte[] GetIntroductionArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x1700349F RID: 13471
		// (get) Token: 0x0600D382 RID: 54146 RVA: 0x00320F3C File Offset: 0x0031F13C
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

		// Token: 0x0600D383 RID: 54147 RVA: 0x00320F74 File Offset: 0x0031F174
		public Span<byte> GetFormationSpineSkeletonDataBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600D384 RID: 54148 RVA: 0x00320F84 File Offset: 0x0031F184
		public byte[] GetFormationSpineSkeletonDataArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x170034A0 RID: 13472
		// (get) Token: 0x0600D385 RID: 54149 RVA: 0x00320F9C File Offset: 0x0031F19C
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

		// Token: 0x0600D386 RID: 54150 RVA: 0x00320FD4 File Offset: 0x0031F1D4
		public Span<byte> GetFormationSpineAtlasBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0600D387 RID: 54151 RVA: 0x00320FE4 File Offset: 0x0031F1E4
		public byte[] GetFormationSpineAtlasArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x0600D388 RID: 54152 RVA: 0x00320FFC File Offset: 0x0031F1FC
		public float SpineParam(int j)
		{
			int num = this.__p.__offset(20);
			if (num == 0)
			{
				return 0f;
			}
			return this.__p.bb.GetFloat(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170034A1 RID: 13473
		// (get) Token: 0x0600D389 RID: 54153 RVA: 0x00321040 File Offset: 0x0031F240
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

		// Token: 0x0600D38A RID: 54154 RVA: 0x0032106C File Offset: 0x0031F26C
		public Span<float> GetSpineParamBytes()
		{
			return this.__p.__vector_as_span<float>(20, 4);
		}

		// Token: 0x0600D38B RID: 54155 RVA: 0x0032107C File Offset: 0x0031F27C
		public float[] GetSpineParamArray()
		{
			return this.__p.__vector_as_array<float>(20) ?? Array.Empty<float>();
		}

		// Token: 0x0600D38C RID: 54156 RVA: 0x00321094 File Offset: 0x0031F294
		[NullableContext(1)]
		public float[] SpineParam()
		{
			return this.GetSpineParamArray();
		}

		// Token: 0x0600D38D RID: 54157 RVA: 0x0032109C File Offset: 0x0031F29C
		[NullableContext(1)]
		public IEnumerable<float> SpineParamIter()
		{
			RoleTrialRoleConfig.<SpineParamIter>d__42 <SpineParamIter>d__ = new RoleTrialRoleConfig.<SpineParamIter>d__42(-2);
			<SpineParamIter>d__.<>3__<>4__this = this;
			return <SpineParamIter>d__;
		}

		// Token: 0x04005769 RID: 22377
		private Table __p;
	}
}
