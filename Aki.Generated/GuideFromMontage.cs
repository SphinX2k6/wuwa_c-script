using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D19 RID: 3353
	public struct GuideFromMontage : IFlatbufferObject
	{
		// Token: 0x17001677 RID: 5751
		// (get) Token: 0x06007CE8 RID: 31976 RVA: 0x00250915 File Offset: 0x0024EB15
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06007CE9 RID: 31977 RVA: 0x00250922 File Offset: 0x0024EB22
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06007CEA RID: 31978 RVA: 0x0025092C File Offset: 0x0024EB2C
		public static GuideFromMontage GetRootAsGuideFromMontage(ByteBuffer _bb)
		{
			return GuideFromMontage.GetRootAsGuideFromMontage(_bb, default(GuideFromMontage));
		}

		// Token: 0x06007CEB RID: 31979 RVA: 0x00250948 File Offset: 0x0024EB48
		public static GuideFromMontage GetRootAsGuideFromMontage(ByteBuffer _bb, GuideFromMontage obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06007CEC RID: 31980 RVA: 0x00250965 File Offset: 0x0024EB65
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06007CED RID: 31981 RVA: 0x00250974 File Offset: 0x0024EB74
		public GuideFromMontage __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001678 RID: 5752
		// (get) Token: 0x06007CEE RID: 31982 RVA: 0x00250984 File Offset: 0x0024EB84
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

		// Token: 0x17001679 RID: 5753
		// (get) Token: 0x06007CEF RID: 31983 RVA: 0x002509C0 File Offset: 0x0024EBC0
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

		// Token: 0x04004D91 RID: 19857
		private Table __p;
	}
}
