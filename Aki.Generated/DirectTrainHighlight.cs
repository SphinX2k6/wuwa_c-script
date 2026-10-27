using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000BF2 RID: 3058
	public struct DirectTrainHighlight : IFlatbufferObject
	{
		// Token: 0x17000CBF RID: 3263
		// (get) Token: 0x06006276 RID: 25206 RVA: 0x00213EF9 File Offset: 0x002120F9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06006277 RID: 25207 RVA: 0x00213F06 File Offset: 0x00212106
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06006278 RID: 25208 RVA: 0x00213F10 File Offset: 0x00212110
		public static DirectTrainHighlight GetRootAsDirectTrainHighlight(ByteBuffer _bb)
		{
			return DirectTrainHighlight.GetRootAsDirectTrainHighlight(_bb, default(DirectTrainHighlight));
		}

		// Token: 0x06006279 RID: 25209 RVA: 0x00213F2C File Offset: 0x0021212C
		public static DirectTrainHighlight GetRootAsDirectTrainHighlight(ByteBuffer _bb, DirectTrainHighlight obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600627A RID: 25210 RVA: 0x00213F49 File Offset: 0x00212149
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600627B RID: 25211 RVA: 0x00213F58 File Offset: 0x00212158
		public DirectTrainHighlight __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000CC0 RID: 3264
		// (get) Token: 0x0600627C RID: 25212 RVA: 0x00213F68 File Offset: 0x00212168
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

		// Token: 0x17000CC1 RID: 3265
		// (get) Token: 0x0600627D RID: 25213 RVA: 0x00213FA4 File Offset: 0x002121A4
		public string TabTitle
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

		// Token: 0x0600627E RID: 25214 RVA: 0x00213FDB File Offset: 0x002121DB
		public Span<byte> GetTabTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600627F RID: 25215 RVA: 0x00213FEA File Offset: 0x002121EA
		public byte[] GetTabTitleArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17000CC2 RID: 3266
		// (get) Token: 0x06006280 RID: 25216 RVA: 0x00214004 File Offset: 0x00212204
		public string FeatureDesc
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

		// Token: 0x06006281 RID: 25217 RVA: 0x0021403B File Offset: 0x0021223B
		public Span<byte> GetFeatureDescBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06006282 RID: 25218 RVA: 0x0021404A File Offset: 0x0021224A
		public byte[] GetFeatureDescArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x04004C1F RID: 19487
		private Table __p;
	}
}
