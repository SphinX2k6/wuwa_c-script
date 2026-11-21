using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B7F RID: 2943
	public struct AbpState : IFlatbufferObject
	{
		// Token: 0x17000020 RID: 32
		// (get) Token: 0x06004529 RID: 17705 RVA: 0x001E3CF8 File Offset: 0x001E1EF8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600452A RID: 17706 RVA: 0x001E3D05 File Offset: 0x001E1F05
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600452B RID: 17707 RVA: 0x001E3D0C File Offset: 0x001E1F0C
		public static AbpState GetRootAsAbpState(ByteBuffer _bb)
		{
			return AbpState.GetRootAsAbpState(_bb, default(AbpState));
		}

		// Token: 0x0600452C RID: 17708 RVA: 0x001E3D28 File Offset: 0x001E1F28
		public static AbpState GetRootAsAbpState(ByteBuffer _bb, AbpState obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600452D RID: 17709 RVA: 0x001E3D45 File Offset: 0x001E1F45
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600452E RID: 17710 RVA: 0x001E3D54 File Offset: 0x001E1F54
		public AbpState __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x0600452F RID: 17711 RVA: 0x001E3D64 File Offset: 0x001E1F64
		public string Abp
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06004530 RID: 17712 RVA: 0x001E3D9B File Offset: 0x001E1F9B
		public Span<byte> GetAbpBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x06004531 RID: 17713 RVA: 0x001E3DAA File Offset: 0x001E1FAA
		public byte[] GetAbpArray()
		{
			return this.__p.__vector_as_array<byte>(4) ?? Array.Empty<byte>();
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x06004532 RID: 17714 RVA: 0x001E3DC4 File Offset: 0x001E1FC4
		public string State1
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

		// Token: 0x06004533 RID: 17715 RVA: 0x001E3DFB File Offset: 0x001E1FFB
		public Span<byte> GetState1Bytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06004534 RID: 17716 RVA: 0x001E3E0A File Offset: 0x001E200A
		public byte[] GetState1Array()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x06004535 RID: 17717 RVA: 0x001E3E24 File Offset: 0x001E2024
		public string State2
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

		// Token: 0x06004536 RID: 17718 RVA: 0x001E3E5B File Offset: 0x001E205B
		public Span<byte> GetState2Bytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06004537 RID: 17719 RVA: 0x001E3E6A File Offset: 0x001E206A
		public byte[] GetState2Array()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x0400504D RID: 20557
		private Table __p;
	}
}
