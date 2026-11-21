using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F80 RID: 3968
	public struct NpcGroupPerformConfig : IFlatbufferObject
	{
		// Token: 0x17002434 RID: 9268
		// (get) Token: 0x0600A6CE RID: 42702 RVA: 0x002BE89D File Offset: 0x002BCA9D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600A6CF RID: 42703 RVA: 0x002BE8AA File Offset: 0x002BCAAA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600A6D0 RID: 42704 RVA: 0x002BE8B4 File Offset: 0x002BCAB4
		public static NpcGroupPerformConfig GetRootAsNpcGroupPerformConfig(ByteBuffer _bb)
		{
			return NpcGroupPerformConfig.GetRootAsNpcGroupPerformConfig(_bb, default(NpcGroupPerformConfig));
		}

		// Token: 0x0600A6D1 RID: 42705 RVA: 0x002BE8D0 File Offset: 0x002BCAD0
		public static NpcGroupPerformConfig GetRootAsNpcGroupPerformConfig(ByteBuffer _bb, NpcGroupPerformConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600A6D2 RID: 42706 RVA: 0x002BE8ED File Offset: 0x002BCAED
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600A6D3 RID: 42707 RVA: 0x002BE8FC File Offset: 0x002BCAFC
		public NpcGroupPerformConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002435 RID: 9269
		// (get) Token: 0x0600A6D4 RID: 42708 RVA: 0x002BE90C File Offset: 0x002BCB0C
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

		// Token: 0x17002436 RID: 9270
		// (get) Token: 0x0600A6D5 RID: 42709 RVA: 0x002BE948 File Offset: 0x002BCB48
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

		// Token: 0x0600A6D6 RID: 42710 RVA: 0x002BE97F File Offset: 0x002BCB7F
		public Span<byte> GetPerformMarkBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600A6D7 RID: 42711 RVA: 0x002BE98E File Offset: 0x002BCB8E
		public byte[] GetPerformMarkArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17002437 RID: 9271
		// (get) Token: 0x0600A6D8 RID: 42712 RVA: 0x002BE9A8 File Offset: 0x002BCBA8
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

		// Token: 0x17002438 RID: 9272
		// (get) Token: 0x0600A6D9 RID: 42713 RVA: 0x002BE9E4 File Offset: 0x002BCBE4
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

		// Token: 0x17002439 RID: 9273
		// (get) Token: 0x0600A6DA RID: 42714 RVA: 0x002BEA24 File Offset: 0x002BCC24
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

		// Token: 0x0600A6DB RID: 42715 RVA: 0x002BEA5C File Offset: 0x002BCC5C
		public Span<byte> GetNpcTypeBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600A6DC RID: 42716 RVA: 0x002BEA6C File Offset: 0x002BCC6C
		public byte[] GetNpcTypeArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x1700243A RID: 9274
		// (get) Token: 0x0600A6DD RID: 42717 RVA: 0x002BEA84 File Offset: 0x002BCC84
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

		// Token: 0x0600A6DE RID: 42718 RVA: 0x002BEABC File Offset: 0x002BCCBC
		public Span<byte> GetRoleMontageBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600A6DF RID: 42719 RVA: 0x002BEACC File Offset: 0x002BCCCC
		public byte[] GetRoleMontageArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x1700243B RID: 9275
		// (get) Token: 0x0600A6E0 RID: 42720 RVA: 0x002BEAE4 File Offset: 0x002BCCE4
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

		// Token: 0x0600A6E1 RID: 42721 RVA: 0x002BEB1C File Offset: 0x002BCD1C
		public Span<byte> GetMaleVariantMontageBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600A6E2 RID: 42722 RVA: 0x002BEB2C File Offset: 0x002BCD2C
		public byte[] GetMaleVariantMontageArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x1700243C RID: 9276
		// (get) Token: 0x0600A6E3 RID: 42723 RVA: 0x002BEB44 File Offset: 0x002BCD44
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

		// Token: 0x0600A6E4 RID: 42724 RVA: 0x002BEB7C File Offset: 0x002BCD7C
		public Span<byte> GetNpcAbpBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0600A6E5 RID: 42725 RVA: 0x002BEB8C File Offset: 0x002BCD8C
		public byte[] GetNpcAbpArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x1700243D RID: 9277
		// (get) Token: 0x0600A6E6 RID: 42726 RVA: 0x002BEBA4 File Offset: 0x002BCDA4
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

		// Token: 0x1700243E RID: 9278
		// (get) Token: 0x0600A6E7 RID: 42727 RVA: 0x002BEBE4 File Offset: 0x002BCDE4
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

		// Token: 0x0600A6E8 RID: 42728 RVA: 0x002BEC1C File Offset: 0x002BCE1C
		public Span<byte> GetNpcMontageBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x0600A6E9 RID: 42729 RVA: 0x002BEC2C File Offset: 0x002BCE2C
		public byte[] GetNpcMontageArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x0600A6EA RID: 42730 RVA: 0x002BEC44 File Offset: 0x002BCE44
		public float RelativeOffset(int j)
		{
			int num = this.__p.__offset(24);
			if (num == 0)
			{
				return 0f;
			}
			return this.__p.bb.GetFloat(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700243F RID: 9279
		// (get) Token: 0x0600A6EB RID: 42731 RVA: 0x002BEC88 File Offset: 0x002BCE88
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

		// Token: 0x0600A6EC RID: 42732 RVA: 0x002BECB4 File Offset: 0x002BCEB4
		public Span<float> GetRelativeOffsetBytes()
		{
			return this.__p.__vector_as_span<float>(24, 4);
		}

		// Token: 0x0600A6ED RID: 42733 RVA: 0x002BECC4 File Offset: 0x002BCEC4
		public float[] GetRelativeOffsetArray()
		{
			return this.__p.__vector_as_array<float>(24) ?? Array.Empty<float>();
		}

		// Token: 0x17002440 RID: 9280
		// (get) Token: 0x0600A6EE RID: 42734 RVA: 0x002BECDC File Offset: 0x002BCEDC
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

		// Token: 0x0600A6EF RID: 42735 RVA: 0x002BED1D File Offset: 0x002BCF1D
		[NullableContext(1)]
		public float[] RelativeOffset()
		{
			return this.GetRelativeOffsetArray();
		}

		// Token: 0x0600A6F0 RID: 42736 RVA: 0x002BED25 File Offset: 0x002BCF25
		[NullableContext(1)]
		public IEnumerable<float> RelativeOffsetIter()
		{
			NpcGroupPerformConfig.<RelativeOffsetIter>d__48 <RelativeOffsetIter>d__ = new NpcGroupPerformConfig.<RelativeOffsetIter>d__48(-2);
			<RelativeOffsetIter>d__.<>3__<>4__this = this;
			return <RelativeOffsetIter>d__;
		}

		// Token: 0x04005534 RID: 21812
		private Table __p;
	}
}
