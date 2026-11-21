using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001214 RID: 4628
	public struct SpecialDamageParam : IFlatbufferObject
	{
		// Token: 0x17003B1E RID: 15134
		// (get) Token: 0x0600E516 RID: 58646 RVA: 0x003492C8 File Offset: 0x003474C8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600E517 RID: 58647 RVA: 0x003492D5 File Offset: 0x003474D5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600E518 RID: 58648 RVA: 0x003492DC File Offset: 0x003474DC
		public static SpecialDamageParam GetRootAsSpecialDamageParam(ByteBuffer _bb)
		{
			return SpecialDamageParam.GetRootAsSpecialDamageParam(_bb, default(SpecialDamageParam));
		}

		// Token: 0x0600E519 RID: 58649 RVA: 0x003492F8 File Offset: 0x003474F8
		public static SpecialDamageParam GetRootAsSpecialDamageParam(ByteBuffer _bb, SpecialDamageParam obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600E51A RID: 58650 RVA: 0x00349315 File Offset: 0x00347515
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600E51B RID: 58651 RVA: 0x00349324 File Offset: 0x00347524
		public SpecialDamageParam __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003B1F RID: 15135
		// (get) Token: 0x0600E51C RID: 58652 RVA: 0x00349334 File Offset: 0x00347534
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

		// Token: 0x17003B20 RID: 15136
		// (get) Token: 0x0600E51D RID: 58653 RVA: 0x00349370 File Offset: 0x00347570
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

		// Token: 0x04005854 RID: 22612
		private Table __p;
	}
}
