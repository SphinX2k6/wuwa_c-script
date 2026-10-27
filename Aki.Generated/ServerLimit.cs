using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001096 RID: 4246
	public struct ServerLimit : IFlatbufferObject
	{
		// Token: 0x17003525 RID: 13605
		// (get) Token: 0x0600D029 RID: 53289 RVA: 0x0030B35D File Offset: 0x0030955D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600D02A RID: 53290 RVA: 0x0030B36A File Offset: 0x0030956A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600D02B RID: 53291 RVA: 0x0030B374 File Offset: 0x00309574
		public static ServerLimit GetRootAsServerLimit(ByteBuffer _bb)
		{
			return ServerLimit.GetRootAsServerLimit(_bb, default(ServerLimit));
		}

		// Token: 0x0600D02C RID: 53292 RVA: 0x0030B390 File Offset: 0x00309590
		public static ServerLimit GetRootAsServerLimit(ByteBuffer _bb, ServerLimit obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600D02D RID: 53293 RVA: 0x0030B3AD File Offset: 0x003095AD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600D02E RID: 53294 RVA: 0x0030B3BC File Offset: 0x003095BC
		public ServerLimit __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003526 RID: 13606
		// (get) Token: 0x0600D02F RID: 53295 RVA: 0x0030B3CC File Offset: 0x003095CC
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

		// Token: 0x0600D030 RID: 53296 RVA: 0x0030B403 File Offset: 0x00309603
		public Span<byte> GetIdBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0600D031 RID: 53297 RVA: 0x0030B412 File Offset: 0x00309612
		public byte[] GetIdArray()
		{
			return this.__p.__vector_as_array<byte>(4) ?? Array.Empty<byte>();
		}

		// Token: 0x17003527 RID: 13607
		// (get) Token: 0x0600D032 RID: 53298 RVA: 0x0030B42C File Offset: 0x0030962C
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

		// Token: 0x0600D033 RID: 53299 RVA: 0x0030B463 File Offset: 0x00309663
		public Span<byte> GetCountryCodesBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600D034 RID: 53300 RVA: 0x0030B472 File Offset: 0x00309672
		public byte[] GetCountryCodesArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x040051A3 RID: 20899
		private Table __p;
	}
}
