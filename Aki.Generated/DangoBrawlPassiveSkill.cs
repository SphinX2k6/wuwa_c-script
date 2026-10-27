using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000BCB RID: 3019
	public struct DangoBrawlPassiveSkill : IFlatbufferObject
	{
		// Token: 0x17000B5F RID: 2911
		// (get) Token: 0x06005EE8 RID: 24296 RVA: 0x0020C2D5 File Offset: 0x0020A4D5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06005EE9 RID: 24297 RVA: 0x0020C2E2 File Offset: 0x0020A4E2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06005EEA RID: 24298 RVA: 0x0020C2EC File Offset: 0x0020A4EC
		public static DangoBrawlPassiveSkill GetRootAsDangoBrawlPassiveSkill(ByteBuffer _bb)
		{
			return DangoBrawlPassiveSkill.GetRootAsDangoBrawlPassiveSkill(_bb, default(DangoBrawlPassiveSkill));
		}

		// Token: 0x06005EEB RID: 24299 RVA: 0x0020C308 File Offset: 0x0020A508
		public static DangoBrawlPassiveSkill GetRootAsDangoBrawlPassiveSkill(ByteBuffer _bb, DangoBrawlPassiveSkill obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06005EEC RID: 24300 RVA: 0x0020C325 File Offset: 0x0020A525
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06005EED RID: 24301 RVA: 0x0020C334 File Offset: 0x0020A534
		public DangoBrawlPassiveSkill __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000B60 RID: 2912
		// (get) Token: 0x06005EEE RID: 24302 RVA: 0x0020C344 File Offset: 0x0020A544
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

		// Token: 0x17000B61 RID: 2913
		// (get) Token: 0x06005EEF RID: 24303 RVA: 0x0020C380 File Offset: 0x0020A580
		public bool IsOnly
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17000B62 RID: 2914
		// (get) Token: 0x06005EF0 RID: 24304 RVA: 0x0020C3C0 File Offset: 0x0020A5C0
		public int PlayEffectId
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x04004BF5 RID: 19445
		private Table __p;
	}
}
