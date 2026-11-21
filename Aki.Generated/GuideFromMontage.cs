using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000DFE RID: 3582
	public struct GuideFromMontage : IFlatbufferObject
	{
		// Token: 0x170016D8 RID: 5848
		// (get) Token: 0x06008300 RID: 33536 RVA: 0x0026F29B File Offset: 0x0026D49B
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06008301 RID: 33537 RVA: 0x0026F2A8 File Offset: 0x0026D4A8
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06008302 RID: 33538 RVA: 0x0026F2B0 File Offset: 0x0026D4B0
		public static GuideFromMontage GetRootAsGuideFromMontage(ByteBuffer _bb)
		{
			return GuideFromMontage.GetRootAsGuideFromMontage(_bb, default(GuideFromMontage));
		}

		// Token: 0x06008303 RID: 33539 RVA: 0x0026F2CC File Offset: 0x0026D4CC
		public static GuideFromMontage GetRootAsGuideFromMontage(ByteBuffer _bb, GuideFromMontage obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06008304 RID: 33540 RVA: 0x0026F2E9 File Offset: 0x0026D4E9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06008305 RID: 33541 RVA: 0x0026F2F8 File Offset: 0x0026D4F8
		public GuideFromMontage __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170016D9 RID: 5849
		// (get) Token: 0x06008306 RID: 33542 RVA: 0x0026F308 File Offset: 0x0026D508
		public int EventGroupId
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

		// Token: 0x170016DA RID: 5850
		// (get) Token: 0x06008307 RID: 33543 RVA: 0x0026F344 File Offset: 0x0026D544
		public int GuideGroupId
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

		// Token: 0x04005376 RID: 21366
		private Table __p;
	}
}
