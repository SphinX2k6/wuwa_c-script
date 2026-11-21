using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020012E5 RID: 4837
	public struct BlackScreenLang : IFlatbufferObject
	{
		// Token: 0x1700420C RID: 16908
		// (get) Token: 0x0600F72A RID: 63274 RVA: 0x003717E1 File Offset: 0x0036F9E1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600F72B RID: 63275 RVA: 0x003717EE File Offset: 0x0036F9EE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600F72C RID: 63276 RVA: 0x003717F8 File Offset: 0x0036F9F8
		public static BlackScreenLang GetRootAsBlackScreenLang(ByteBuffer _bb)
		{
			return BlackScreenLang.GetRootAsBlackScreenLang(_bb, default(BlackScreenLang));
		}

		// Token: 0x0600F72D RID: 63277 RVA: 0x00371814 File Offset: 0x0036FA14
		public static BlackScreenLang GetRootAsBlackScreenLang(ByteBuffer _bb, BlackScreenLang obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600F72E RID: 63278 RVA: 0x00371831 File Offset: 0x0036FA31
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600F72F RID: 63279 RVA: 0x00371840 File Offset: 0x0036FA40
		public BlackScreenLang __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700420D RID: 16909
		// (get) Token: 0x0600F730 RID: 63280 RVA: 0x00371850 File Offset: 0x0036FA50
		public int ShowAnimName
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

		// Token: 0x1700420E RID: 16910
		// (get) Token: 0x0600F731 RID: 63281 RVA: 0x0037188C File Offset: 0x0036FA8C
		public int HideAnimName
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

		// Token: 0x0400593F RID: 22847
		private Table __p;
	}
}
