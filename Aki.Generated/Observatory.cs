using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E9E RID: 3742
	public struct Observatory : IFlatbufferObject
	{
		// Token: 0x170023EC RID: 9196
		// (get) Token: 0x0600A102 RID: 41218 RVA: 0x002A1E31 File Offset: 0x002A0031
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600A103 RID: 41219 RVA: 0x002A1E3E File Offset: 0x002A003E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600A104 RID: 41220 RVA: 0x002A1E48 File Offset: 0x002A0048
		public static Observatory GetRootAsObservatory(ByteBuffer _bb)
		{
			return Observatory.GetRootAsObservatory(_bb, default(Observatory));
		}

		// Token: 0x0600A105 RID: 41221 RVA: 0x002A1E64 File Offset: 0x002A0064
		public static Observatory GetRootAsObservatory(ByteBuffer _bb, Observatory obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600A106 RID: 41222 RVA: 0x002A1E81 File Offset: 0x002A0081
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600A107 RID: 41223 RVA: 0x002A1E90 File Offset: 0x002A0090
		public Observatory __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170023ED RID: 9197
		// (get) Token: 0x0600A108 RID: 41224 RVA: 0x002A1EA0 File Offset: 0x002A00A0
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

		// Token: 0x170023EE RID: 9198
		// (get) Token: 0x0600A109 RID: 41225 RVA: 0x002A1EDC File Offset: 0x002A00DC
		public int AreaId
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

		// Token: 0x170023EF RID: 9199
		// (get) Token: 0x0600A10A RID: 41226 RVA: 0x002A1F18 File Offset: 0x002A0118
		public string FlowListName
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

		// Token: 0x0600A10B RID: 41227 RVA: 0x002A1F4F File Offset: 0x002A014F
		public Span<byte> GetFlowListNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600A10C RID: 41228 RVA: 0x002A1F5E File Offset: 0x002A015E
		public byte[] GetFlowListNameArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x170023F0 RID: 9200
		// (get) Token: 0x0600A10D RID: 41229 RVA: 0x002A1F78 File Offset: 0x002A0178
		public int FlowId
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

		// Token: 0x170023F1 RID: 9201
		// (get) Token: 0x0600A10E RID: 41230 RVA: 0x002A1FB8 File Offset: 0x002A01B8
		public int StateId
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

		// Token: 0x04004F52 RID: 20306
		private Table __p;
	}
}
