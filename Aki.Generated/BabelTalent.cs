using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B1A RID: 2842
	public struct BabelTalent : IFlatbufferObject
	{
		// Token: 0x170003DA RID: 986
		// (get) Token: 0x06004A6C RID: 19052 RVA: 0x001DC20C File Offset: 0x001DA40C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06004A6D RID: 19053 RVA: 0x001DC219 File Offset: 0x001DA419
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06004A6E RID: 19054 RVA: 0x001DC220 File Offset: 0x001DA420
		public static BabelTalent GetRootAsBabelTalent(ByteBuffer _bb)
		{
			return BabelTalent.GetRootAsBabelTalent(_bb, default(BabelTalent));
		}

		// Token: 0x06004A6F RID: 19055 RVA: 0x001DC23C File Offset: 0x001DA43C
		public static BabelTalent GetRootAsBabelTalent(ByteBuffer _bb, BabelTalent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06004A70 RID: 19056 RVA: 0x001DC259 File Offset: 0x001DA459
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06004A71 RID: 19057 RVA: 0x001DC268 File Offset: 0x001DA468
		public BabelTalent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170003DB RID: 987
		// (get) Token: 0x06004A72 RID: 19058 RVA: 0x001DC278 File Offset: 0x001DA478
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

		// Token: 0x04004B09 RID: 19209
		private Table __p;
	}
}
