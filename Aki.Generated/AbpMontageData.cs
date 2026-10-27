using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000AA9 RID: 2729
	public struct AbpMontageData : IFlatbufferObject
	{
		// Token: 0x17000019 RID: 25
		// (get) Token: 0x06004017 RID: 16407 RVA: 0x001C46FC File Offset: 0x001C28FC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06004018 RID: 16408 RVA: 0x001C4709 File Offset: 0x001C2909
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06004019 RID: 16409 RVA: 0x001C4710 File Offset: 0x001C2910
		public static AbpMontageData GetRootAsAbpMontageData(ByteBuffer _bb)
		{
			return AbpMontageData.GetRootAsAbpMontageData(_bb, default(AbpMontageData));
		}

		// Token: 0x0600401A RID: 16410 RVA: 0x001C472C File Offset: 0x001C292C
		public static AbpMontageData GetRootAsAbpMontageData(ByteBuffer _bb, AbpMontageData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600401B RID: 16411 RVA: 0x001C4749 File Offset: 0x001C2949
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600401C RID: 16412 RVA: 0x001C4758 File Offset: 0x001C2958
		public AbpMontageData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x0600401D RID: 16413 RVA: 0x001C4768 File Offset: 0x001C2968
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

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x0600401E RID: 16414 RVA: 0x001C47A4 File Offset: 0x001C29A4
		public string Montage
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

		// Token: 0x0600401F RID: 16415 RVA: 0x001C47DB File Offset: 0x001C29DB
		public Span<byte> GetMontageBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06004020 RID: 16416 RVA: 0x001C47EA File Offset: 0x001C29EA
		public byte[] GetMontageArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x06004021 RID: 16417 RVA: 0x001C4804 File Offset: 0x001C2A04
		public string MaleVariant
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

		// Token: 0x06004022 RID: 16418 RVA: 0x001C483B File Offset: 0x001C2A3B
		public Span<byte> GetMaleVariantBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06004023 RID: 16419 RVA: 0x001C484A File Offset: 0x001C2A4A
		public byte[] GetMaleVariantArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x06004024 RID: 16420 RVA: 0x001C4864 File Offset: 0x001C2A64
		public string InitState
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

		// Token: 0x06004025 RID: 16421 RVA: 0x001C489C File Offset: 0x001C2A9C
		public Span<byte> GetInitStateBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06004026 RID: 16422 RVA: 0x001C48AC File Offset: 0x001C2AAC
		public byte[] GetInitStateArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x06004027 RID: 16423 RVA: 0x001C48C4 File Offset: 0x001C2AC4
		public string EndState
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

		// Token: 0x06004028 RID: 16424 RVA: 0x001C48FC File Offset: 0x001C2AFC
		public Span<byte> GetEndStateBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06004029 RID: 16425 RVA: 0x001C490C File Offset: 0x001C2B0C
		public byte[] GetEndStateArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x0600402A RID: 16426 RVA: 0x001C4924 File Offset: 0x001C2B24
		public bool DisableBlinkCurve
		{
			get
			{
				int num = this.__p.__offset(14);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x04004A79 RID: 19065
		private Table __p;
	}
}
