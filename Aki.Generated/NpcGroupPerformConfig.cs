using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E9B RID: 3739
	public struct NpcGroupPerformConfig : IFlatbufferObject
	{
		// Token: 0x170023CF RID: 9167
		// (get) Token: 0x0600A0AE RID: 41134 RVA: 0x002A1375 File Offset: 0x0029F575
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600A0AF RID: 41135 RVA: 0x002A1382 File Offset: 0x0029F582
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600A0B0 RID: 41136 RVA: 0x002A138C File Offset: 0x0029F58C
		public static NpcGroupPerformConfig GetRootAsNpcGroupPerformConfig(ByteBuffer _bb)
		{
			return NpcGroupPerformConfig.GetRootAsNpcGroupPerformConfig(_bb, default(NpcGroupPerformConfig));
		}

		// Token: 0x0600A0B1 RID: 41137 RVA: 0x002A13A8 File Offset: 0x0029F5A8
		public static NpcGroupPerformConfig GetRootAsNpcGroupPerformConfig(ByteBuffer _bb, NpcGroupPerformConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600A0B2 RID: 41138 RVA: 0x002A13C5 File Offset: 0x0029F5C5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600A0B3 RID: 41139 RVA: 0x002A13D4 File Offset: 0x0029F5D4
		public NpcGroupPerformConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170023D0 RID: 9168
		// (get) Token: 0x0600A0B4 RID: 41140 RVA: 0x002A13E4 File Offset: 0x0029F5E4
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

		// Token: 0x170023D1 RID: 9169
		// (get) Token: 0x0600A0B5 RID: 41141 RVA: 0x002A1420 File Offset: 0x0029F620
		public string PerformMark
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

		// Token: 0x0600A0B6 RID: 41142 RVA: 0x002A1457 File Offset: 0x0029F657
		public Span<byte> GetPerformMarkBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600A0B7 RID: 41143 RVA: 0x002A1466 File Offset: 0x0029F666
		public byte[] GetPerformMarkArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x170023D2 RID: 9170
		// (get) Token: 0x0600A0B8 RID: 41144 RVA: 0x002A1480 File Offset: 0x0029F680
		public int PerformType
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

		// Token: 0x170023D3 RID: 9171
		// (get) Token: 0x0600A0B9 RID: 41145 RVA: 0x002A14BC File Offset: 0x0029F6BC
		public int RoleId
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

		// Token: 0x170023D4 RID: 9172
		// (get) Token: 0x0600A0BA RID: 41146 RVA: 0x002A14FC File Offset: 0x0029F6FC
		public string NpcType
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

		// Token: 0x0600A0BB RID: 41147 RVA: 0x002A1534 File Offset: 0x0029F734
		public Span<byte> GetNpcTypeBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600A0BC RID: 41148 RVA: 0x002A1544 File Offset: 0x0029F744
		public byte[] GetNpcTypeArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x170023D5 RID: 9173
		// (get) Token: 0x0600A0BD RID: 41149 RVA: 0x002A155C File Offset: 0x0029F75C
		public string RoleMontage
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

		// Token: 0x0600A0BE RID: 41150 RVA: 0x002A1594 File Offset: 0x0029F794
		public Span<byte> GetRoleMontageBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600A0BF RID: 41151 RVA: 0x002A15A4 File Offset: 0x0029F7A4
		public byte[] GetRoleMontageArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x170023D6 RID: 9174
		// (get) Token: 0x0600A0C0 RID: 41152 RVA: 0x002A15BC File Offset: 0x0029F7BC
		public string MaleVariantMontage
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

		// Token: 0x0600A0C1 RID: 41153 RVA: 0x002A15F4 File Offset: 0x0029F7F4
		public Span<byte> GetMaleVariantMontageBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600A0C2 RID: 41154 RVA: 0x002A1604 File Offset: 0x0029F804
		public byte[] GetMaleVariantMontageArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x170023D7 RID: 9175
		// (get) Token: 0x0600A0C3 RID: 41155 RVA: 0x002A161C File Offset: 0x0029F81C
		public string NpcAbp
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

		// Token: 0x0600A0C4 RID: 41156 RVA: 0x002A1654 File Offset: 0x0029F854
		public Span<byte> GetNpcAbpBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0600A0C5 RID: 41157 RVA: 0x002A1664 File Offset: 0x0029F864
		public byte[] GetNpcAbpArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x170023D8 RID: 9176
		// (get) Token: 0x0600A0C6 RID: 41158 RVA: 0x002A167C File Offset: 0x0029F87C
		public int NpcAbpMontageId
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

		// Token: 0x170023D9 RID: 9177
		// (get) Token: 0x0600A0C7 RID: 41159 RVA: 0x002A16BC File Offset: 0x0029F8BC
		public string NpcMontage
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

		// Token: 0x0600A0C8 RID: 41160 RVA: 0x002A16F4 File Offset: 0x0029F8F4
		public Span<byte> GetNpcMontageBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x0600A0C9 RID: 41161 RVA: 0x002A1704 File Offset: 0x0029F904
		public byte[] GetNpcMontageArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x0600A0CA RID: 41162 RVA: 0x002A171C File Offset: 0x0029F91C
		public float RelativeOffset(int j)
		{
			int num = this.__p.__offset(24);
			if (num == 0)
			{
				return 0f;
			}
			return this.__p.bb.GetFloat(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170023DA RID: 9178
		// (get) Token: 0x0600A0CB RID: 41163 RVA: 0x002A1760 File Offset: 0x0029F960
		public int RelativeOffsetLength
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600A0CC RID: 41164 RVA: 0x002A178C File Offset: 0x0029F98C
		public Span<float> GetRelativeOffsetBytes()
		{
			return this.__p.__vector_as_span<float>(24, 4);
		}

		// Token: 0x0600A0CD RID: 41165 RVA: 0x002A179C File Offset: 0x0029F99C
		public float[] GetRelativeOffsetArray()
		{
			return this.__p.__vector_as_array<float>(24) ?? Array.Empty<float>();
		}

		// Token: 0x170023DB RID: 9179
		// (get) Token: 0x0600A0CE RID: 41166 RVA: 0x002A17B4 File Offset: 0x0029F9B4
		public float RelativeZRotation
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return 180f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600A0CF RID: 41167 RVA: 0x002A17F8 File Offset: 0x0029F9F8
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用RelativeOffsetIter()或GetRelativeOffsetBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly float[] RelativeOffset()
		{
			NpcGroupPerformConfig npcGroupPerformConfig = this;
			return npcGroupPerformConfig.GetRelativeOffsetArray() ?? Array.Empty<float>();
		}

		// Token: 0x0600A0D0 RID: 41168 RVA: 0x002A181C File Offset: 0x0029FA1C
		[NullableContext(1)]
		public readonly IEnumerable<float> RelativeOffsetIter()
		{
			NpcGroupPerformConfig.<RelativeOffsetIter>d__48 <RelativeOffsetIter>d__ = new NpcGroupPerformConfig.<RelativeOffsetIter>d__48(-2);
			<RelativeOffsetIter>d__.<>3__<>4__this = this;
			return <RelativeOffsetIter>d__;
		}

		// Token: 0x04004F4F RID: 20303
		private Table __p;
	}
}
