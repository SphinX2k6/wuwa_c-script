using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001230 RID: 4656
	public struct SurvivorsEffect : IFlatbufferObject
	{
		// Token: 0x17003C14 RID: 15380
		// (get) Token: 0x0600E7AD RID: 59309 RVA: 0x0034EE18 File Offset: 0x0034D018
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600E7AE RID: 59310 RVA: 0x0034EE25 File Offset: 0x0034D025
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600E7AF RID: 59311 RVA: 0x0034EE2C File Offset: 0x0034D02C
		public static SurvivorsEffect GetRootAsSurvivorsEffect(ByteBuffer _bb)
		{
			return SurvivorsEffect.GetRootAsSurvivorsEffect(_bb, default(SurvivorsEffect));
		}

		// Token: 0x0600E7B0 RID: 59312 RVA: 0x0034EE48 File Offset: 0x0034D048
		public static SurvivorsEffect GetRootAsSurvivorsEffect(ByteBuffer _bb, SurvivorsEffect obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600E7B1 RID: 59313 RVA: 0x0034EE65 File Offset: 0x0034D065
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600E7B2 RID: 59314 RVA: 0x0034EE74 File Offset: 0x0034D074
		public SurvivorsEffect __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003C15 RID: 15381
		// (get) Token: 0x0600E7B3 RID: 59315 RVA: 0x0034EE84 File Offset: 0x0034D084
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

		// Token: 0x17003C16 RID: 15382
		// (get) Token: 0x0600E7B4 RID: 59316 RVA: 0x0034EEC0 File Offset: 0x0034D0C0
		public int DescIntParam
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

		// Token: 0x04005873 RID: 22643
		private Table __p;
	}
}
