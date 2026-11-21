using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D3C RID: 3388
	public struct ExtraDamageText : IFlatbufferObject
	{
		// Token: 0x1700108D RID: 4237
		// (get) Token: 0x0600726B RID: 29291 RVA: 0x00249B34 File Offset: 0x00247D34
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600726C RID: 29292 RVA: 0x00249B41 File Offset: 0x00247D41
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600726D RID: 29293 RVA: 0x00249B48 File Offset: 0x00247D48
		public static ExtraDamageText GetRootAsExtraDamageText(ByteBuffer _bb)
		{
			return ExtraDamageText.GetRootAsExtraDamageText(_bb, default(ExtraDamageText));
		}

		// Token: 0x0600726E RID: 29294 RVA: 0x00249B64 File Offset: 0x00247D64
		public static ExtraDamageText GetRootAsExtraDamageText(ByteBuffer _bb, ExtraDamageText obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600726F RID: 29295 RVA: 0x00249B81 File Offset: 0x00247D81
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06007270 RID: 29296 RVA: 0x00249B90 File Offset: 0x00247D90
		public ExtraDamageText __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700108E RID: 4238
		// (get) Token: 0x06007271 RID: 29297 RVA: 0x00249BA0 File Offset: 0x00247DA0
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

		// Token: 0x1700108F RID: 4239
		// (get) Token: 0x06007272 RID: 29298 RVA: 0x00249BDC File Offset: 0x00247DDC
		public int DamageTextId
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001090 RID: 4240
		// (get) Token: 0x06007273 RID: 29299 RVA: 0x00249C18 File Offset: 0x00247E18
		public int DamageTextAreaId
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x04005287 RID: 21127
		private Table __p;
	}
}
