using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020010DE RID: 4318
	public struct SpecialDamageParam : IFlatbufferObject
	{
		// Token: 0x170037C8 RID: 14280
		// (get) Token: 0x0600D7CB RID: 55243 RVA: 0x0031DC54 File Offset: 0x0031BE54
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600D7CC RID: 55244 RVA: 0x0031DC61 File Offset: 0x0031BE61
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600D7CD RID: 55245 RVA: 0x0031DC68 File Offset: 0x0031BE68
		public static SpecialDamageParam GetRootAsSpecialDamageParam(ByteBuffer _bb)
		{
			return SpecialDamageParam.GetRootAsSpecialDamageParam(_bb, default(SpecialDamageParam));
		}

		// Token: 0x0600D7CE RID: 55246 RVA: 0x0031DC84 File Offset: 0x0031BE84
		public static SpecialDamageParam GetRootAsSpecialDamageParam(ByteBuffer _bb, SpecialDamageParam obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600D7CF RID: 55247 RVA: 0x0031DCA1 File Offset: 0x0031BEA1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600D7D0 RID: 55248 RVA: 0x0031DCB0 File Offset: 0x0031BEB0
		public SpecialDamageParam __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170037C9 RID: 14281
		// (get) Token: 0x0600D7D1 RID: 55249 RVA: 0x0031DCC0 File Offset: 0x0031BEC0
		public int Level
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

		// Token: 0x170037CA RID: 14282
		// (get) Token: 0x0600D7D2 RID: 55250 RVA: 0x0031DCFC File Offset: 0x0031BEFC
		public int Resonance
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

		// Token: 0x04005211 RID: 21009
		private Table __p;
	}
}
