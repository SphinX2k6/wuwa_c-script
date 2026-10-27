using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000CC4 RID: 3268
	public struct FlowTemplateData : IFlatbufferObject
	{
		// Token: 0x1700139E RID: 5022
		// (get) Token: 0x06007573 RID: 30067 RVA: 0x0023FF94 File Offset: 0x0023E194
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06007574 RID: 30068 RVA: 0x0023FFA1 File Offset: 0x0023E1A1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06007575 RID: 30069 RVA: 0x0023FFA8 File Offset: 0x0023E1A8
		public static FlowTemplateData GetRootAsFlowTemplateData(ByteBuffer _bb)
		{
			return FlowTemplateData.GetRootAsFlowTemplateData(_bb, default(FlowTemplateData));
		}

		// Token: 0x06007576 RID: 30070 RVA: 0x0023FFC4 File Offset: 0x0023E1C4
		public static FlowTemplateData GetRootAsFlowTemplateData(ByteBuffer _bb, FlowTemplateData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06007577 RID: 30071 RVA: 0x0023FFE1 File Offset: 0x0023E1E1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06007578 RID: 30072 RVA: 0x0023FFF0 File Offset: 0x0023E1F0
		public FlowTemplateData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700139F RID: 5023
		// (get) Token: 0x06007579 RID: 30073 RVA: 0x00240000 File Offset: 0x0023E200
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

		// Token: 0x170013A0 RID: 5024
		// (get) Token: 0x0600757A RID: 30074 RVA: 0x0024003C File Offset: 0x0023E23C
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

		// Token: 0x0600757B RID: 30075 RVA: 0x00240073 File Offset: 0x0023E273
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600757C RID: 30076 RVA: 0x00240082 File Offset: 0x0023E282
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x170013A1 RID: 5025
		// (get) Token: 0x0600757D RID: 30077 RVA: 0x0024009C File Offset: 0x0023E29C
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

		// Token: 0x170013A2 RID: 5026
		// (get) Token: 0x0600757E RID: 30078 RVA: 0x002400D8 File Offset: 0x0023E2D8
		public bool Enable
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170013A3 RID: 5027
		// (get) Token: 0x0600757F RID: 30079 RVA: 0x00240118 File Offset: 0x0023E318
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

		// Token: 0x06007580 RID: 30080 RVA: 0x00240150 File Offset: 0x0023E350
		public Span<byte> GetTemplateBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06007581 RID: 30081 RVA: 0x00240160 File Offset: 0x0023E360
		public byte[] GetTemplateArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x170013A4 RID: 5028
		// (get) Token: 0x06007582 RID: 30082 RVA: 0x00240178 File Offset: 0x0023E378
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

		// Token: 0x06007583 RID: 30083 RVA: 0x002401B0 File Offset: 0x0023E3B0
		public Span<byte> GetCameraTypeBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x06007584 RID: 30084 RVA: 0x002401C0 File Offset: 0x0023E3C0
		public byte[] GetCameraTypeArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x170013A5 RID: 5029
		// (get) Token: 0x06007585 RID: 30085 RVA: 0x002401D8 File Offset: 0x0023E3D8
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

		// Token: 0x06007586 RID: 30086 RVA: 0x00240210 File Offset: 0x0023E410
		public Span<byte> GetActorDataArrayBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x06007587 RID: 30087 RVA: 0x00240220 File Offset: 0x0023E420
		public byte[] GetActorDataArrayArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x170013A6 RID: 5030
		// (get) Token: 0x06007588 RID: 30088 RVA: 0x00240238 File Offset: 0x0023E438
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

		// Token: 0x06007589 RID: 30089 RVA: 0x00240270 File Offset: 0x0023E470
		public Span<byte> GetCameraDataBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0600758A RID: 30090 RVA: 0x00240280 File Offset: 0x0023E480
		public byte[] GetCameraDataArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x04004D34 RID: 19764
		private Table __p;
	}
}
