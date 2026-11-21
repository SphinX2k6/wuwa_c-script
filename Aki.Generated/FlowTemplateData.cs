using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000DA8 RID: 3496
	public struct FlowTemplateData : IFlatbufferObject
	{
		// Token: 0x170013FB RID: 5115
		// (get) Token: 0x06007B7E RID: 31614 RVA: 0x0025ECA0 File Offset: 0x0025CEA0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06007B7F RID: 31615 RVA: 0x0025ECAD File Offset: 0x0025CEAD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06007B80 RID: 31616 RVA: 0x0025ECB4 File Offset: 0x0025CEB4
		public static FlowTemplateData GetRootAsFlowTemplateData(ByteBuffer _bb)
		{
			return FlowTemplateData.GetRootAsFlowTemplateData(_bb, default(FlowTemplateData));
		}

		// Token: 0x06007B81 RID: 31617 RVA: 0x0025ECD0 File Offset: 0x0025CED0
		public static FlowTemplateData GetRootAsFlowTemplateData(ByteBuffer _bb, FlowTemplateData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06007B82 RID: 31618 RVA: 0x0025ECED File Offset: 0x0025CEED
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06007B83 RID: 31619 RVA: 0x0025ECFC File Offset: 0x0025CEFC
		public FlowTemplateData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170013FC RID: 5116
		// (get) Token: 0x06007B84 RID: 31620 RVA: 0x0025ED0C File Offset: 0x0025CF0C
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

		// Token: 0x170013FD RID: 5117
		// (get) Token: 0x06007B85 RID: 31621 RVA: 0x0025ED48 File Offset: 0x0025CF48
		public string Name
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

		// Token: 0x06007B86 RID: 31622 RVA: 0x0025ED7F File Offset: 0x0025CF7F
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06007B87 RID: 31623 RVA: 0x0025ED8E File Offset: 0x0025CF8E
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x170013FE RID: 5118
		// (get) Token: 0x06007B88 RID: 31624 RVA: 0x0025EDA8 File Offset: 0x0025CFA8
		public int Amount
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

		// Token: 0x170013FF RID: 5119
		// (get) Token: 0x06007B89 RID: 31625 RVA: 0x0025EDE4 File Offset: 0x0025CFE4
		public bool Enable
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17001400 RID: 5120
		// (get) Token: 0x06007B8A RID: 31626 RVA: 0x0025EE24 File Offset: 0x0025D024
		public string Template
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

		// Token: 0x06007B8B RID: 31627 RVA: 0x0025EE5C File Offset: 0x0025D05C
		public Span<byte> GetTemplateBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06007B8C RID: 31628 RVA: 0x0025EE6C File Offset: 0x0025D06C
		public byte[] GetTemplateArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17001401 RID: 5121
		// (get) Token: 0x06007B8D RID: 31629 RVA: 0x0025EE84 File Offset: 0x0025D084
		public string CameraType
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

		// Token: 0x06007B8E RID: 31630 RVA: 0x0025EEBC File Offset: 0x0025D0BC
		public Span<byte> GetCameraTypeBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x06007B8F RID: 31631 RVA: 0x0025EECC File Offset: 0x0025D0CC
		public byte[] GetCameraTypeArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17001402 RID: 5122
		// (get) Token: 0x06007B90 RID: 31632 RVA: 0x0025EEE4 File Offset: 0x0025D0E4
		public string ActorDataArray
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

		// Token: 0x06007B91 RID: 31633 RVA: 0x0025EF1C File Offset: 0x0025D11C
		public Span<byte> GetActorDataArrayBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x06007B92 RID: 31634 RVA: 0x0025EF2C File Offset: 0x0025D12C
		public byte[] GetActorDataArrayArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x17001403 RID: 5123
		// (get) Token: 0x06007B93 RID: 31635 RVA: 0x0025EF44 File Offset: 0x0025D144
		public string CameraData
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

		// Token: 0x06007B94 RID: 31636 RVA: 0x0025EF7C File Offset: 0x0025D17C
		public Span<byte> GetCameraDataBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x06007B95 RID: 31637 RVA: 0x0025EF8C File Offset: 0x0025D18C
		public byte[] GetCameraDataArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x04005318 RID: 21272
		private Table __p;
	}
}
