using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000CFE RID: 3326
	public struct GiantResponse : IFlatbufferObject
	{
		// Token: 0x170015A4 RID: 5540
		// (get) Token: 0x06007A9D RID: 31389 RVA: 0x0024B809 File Offset: 0x00249A09
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06007A9E RID: 31390 RVA: 0x0024B816 File Offset: 0x00249A16
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06007A9F RID: 31391 RVA: 0x0024B820 File Offset: 0x00249A20
		public static GiantResponse GetRootAsGiantResponse(ByteBuffer _bb)
		{
			return GiantResponse.GetRootAsGiantResponse(_bb, default(GiantResponse));
		}

		// Token: 0x06007AA0 RID: 31392 RVA: 0x0024B83C File Offset: 0x00249A3C
		public static GiantResponse GetRootAsGiantResponse(ByteBuffer _bb, GiantResponse obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06007AA1 RID: 31393 RVA: 0x0024B859 File Offset: 0x00249A59
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06007AA2 RID: 31394 RVA: 0x0024B868 File Offset: 0x00249A68
		public GiantResponse __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170015A5 RID: 5541
		// (get) Token: 0x06007AA3 RID: 31395 RVA: 0x0024B878 File Offset: 0x00249A78
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

		// Token: 0x170015A6 RID: 5542
		// (get) Token: 0x06007AA4 RID: 31396 RVA: 0x0024B8B4 File Offset: 0x00249AB4
		public string Desc
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

		// Token: 0x06007AA5 RID: 31397 RVA: 0x0024B8EB File Offset: 0x00249AEB
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06007AA6 RID: 31398 RVA: 0x0024B8FA File Offset: 0x00249AFA
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x170015A7 RID: 5543
		// (get) Token: 0x06007AA7 RID: 31399 RVA: 0x0024B914 File Offset: 0x00249B14
		public string TriggerConditions
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

		// Token: 0x06007AA8 RID: 31400 RVA: 0x0024B94B File Offset: 0x00249B4B
		public Span<byte> GetTriggerConditionsBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06007AA9 RID: 31401 RVA: 0x0024B95A File Offset: 0x00249B5A
		public byte[] GetTriggerConditionsArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x170015A8 RID: 5544
		// (get) Token: 0x06007AAA RID: 31402 RVA: 0x0024B974 File Offset: 0x00249B74
		public string ResponseFunctions
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

		// Token: 0x06007AAB RID: 31403 RVA: 0x0024B9AC File Offset: 0x00249BAC
		public Span<byte> GetResponseFunctionsBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06007AAC RID: 31404 RVA: 0x0024B9BC File Offset: 0x00249BBC
		public byte[] GetResponseFunctionsArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x04004D72 RID: 19826
		private Table __p;
	}
}
