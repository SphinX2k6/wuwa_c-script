using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001191 RID: 4497
	public struct ServerLimit : IFlatbufferObject
	{
		// Token: 0x17003632 RID: 13874
		// (get) Token: 0x0600D7FC RID: 55292 RVA: 0x0032A8F5 File Offset: 0x00328AF5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600D7FD RID: 55293 RVA: 0x0032A902 File Offset: 0x00328B02
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600D7FE RID: 55294 RVA: 0x0032A90C File Offset: 0x00328B0C
		public static ServerLimit GetRootAsServerLimit(ByteBuffer _bb)
		{
			return ServerLimit.GetRootAsServerLimit(_bb, default(ServerLimit));
		}

		// Token: 0x0600D7FF RID: 55295 RVA: 0x0032A928 File Offset: 0x00328B28
		public static ServerLimit GetRootAsServerLimit(ByteBuffer _bb, ServerLimit obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600D800 RID: 55296 RVA: 0x0032A945 File Offset: 0x00328B45
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600D801 RID: 55297 RVA: 0x0032A954 File Offset: 0x00328B54
		public ServerLimit __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003633 RID: 13875
		// (get) Token: 0x0600D802 RID: 55298 RVA: 0x0032A964 File Offset: 0x00328B64
		public string Id
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

		// Token: 0x0600D803 RID: 55299 RVA: 0x0032A99B File Offset: 0x00328B9B
		public Span<byte> GetIdBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0600D804 RID: 55300 RVA: 0x0032A9AA File Offset: 0x00328BAA
		public byte[] GetIdArray()
		{
			return this.__p.__vector_as_array<byte>(4) ?? Array.Empty<byte>();
		}

		// Token: 0x17003634 RID: 13876
		// (get) Token: 0x0600D805 RID: 55301 RVA: 0x0032A9C4 File Offset: 0x00328BC4
		public string CountryCodes
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

		// Token: 0x0600D806 RID: 55302 RVA: 0x0032A9FB File Offset: 0x00328BFB
		public Span<byte> GetCountryCodesBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600D807 RID: 55303 RVA: 0x0032AA0A File Offset: 0x00328C0A
		public byte[] GetCountryCodesArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x040057A2 RID: 22434
		private Table __p;
	}
}
