using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000AFB RID: 2811
	public struct AlertAreaConfig : IFlatbufferObject
	{
		// Token: 0x170002E6 RID: 742
		// (get) Token: 0x060047AD RID: 18349 RVA: 0x001D5AB1 File Offset: 0x001D3CB1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060047AE RID: 18350 RVA: 0x001D5ABE File Offset: 0x001D3CBE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060047AF RID: 18351 RVA: 0x001D5AC8 File Offset: 0x001D3CC8
		public static AlertAreaConfig GetRootAsAlertAreaConfig(ByteBuffer _bb)
		{
			return AlertAreaConfig.GetRootAsAlertAreaConfig(_bb, default(AlertAreaConfig));
		}

		// Token: 0x060047B0 RID: 18352 RVA: 0x001D5AE4 File Offset: 0x001D3CE4
		public static AlertAreaConfig GetRootAsAlertAreaConfig(ByteBuffer _bb, AlertAreaConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060047B1 RID: 18353 RVA: 0x001D5B01 File Offset: 0x001D3D01
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060047B2 RID: 18354 RVA: 0x001D5B10 File Offset: 0x001D3D10
		public AlertAreaConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170002E7 RID: 743
		// (get) Token: 0x060047B3 RID: 18355 RVA: 0x001D5B20 File Offset: 0x001D3D20
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

		// Token: 0x170002E8 RID: 744
		// (get) Token: 0x060047B4 RID: 18356 RVA: 0x001D5B5C File Offset: 0x001D3D5C
		public string Description
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

		// Token: 0x060047B5 RID: 18357 RVA: 0x001D5B93 File Offset: 0x001D3D93
		public Span<byte> GetDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x060047B6 RID: 18358 RVA: 0x001D5BA2 File Offset: 0x001D3DA2
		public byte[] GetDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x170002E9 RID: 745
		// (get) Token: 0x060047B7 RID: 18359 RVA: 0x001D5BBC File Offset: 0x001D3DBC
		public int CreatorId
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

		// Token: 0x170002EA RID: 746
		// (get) Token: 0x060047B8 RID: 18360 RVA: 0x001D5BF8 File Offset: 0x001D3DF8
		public float MinValue
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170002EB RID: 747
		// (get) Token: 0x060047B9 RID: 18361 RVA: 0x001D5C3C File Offset: 0x001D3E3C
		public float MaxValue
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 100f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x04004ADC RID: 19164
		private Table __p;
	}
}
