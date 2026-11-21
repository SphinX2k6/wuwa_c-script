using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E0F RID: 3599
	public struct HiddenQuestWhite : IFlatbufferObject
	{
		// Token: 0x1700176F RID: 5999
		// (get) Token: 0x06008494 RID: 33940 RVA: 0x00272848 File Offset: 0x00270A48
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06008495 RID: 33941 RVA: 0x00272855 File Offset: 0x00270A55
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06008496 RID: 33942 RVA: 0x0027285C File Offset: 0x00270A5C
		public static HiddenQuestWhite GetRootAsHiddenQuestWhite(ByteBuffer _bb)
		{
			return HiddenQuestWhite.GetRootAsHiddenQuestWhite(_bb, default(HiddenQuestWhite));
		}

		// Token: 0x06008497 RID: 33943 RVA: 0x00272878 File Offset: 0x00270A78
		public static HiddenQuestWhite GetRootAsHiddenQuestWhite(ByteBuffer _bb, HiddenQuestWhite obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06008498 RID: 33944 RVA: 0x00272895 File Offset: 0x00270A95
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06008499 RID: 33945 RVA: 0x002728A4 File Offset: 0x00270AA4
		public HiddenQuestWhite __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001770 RID: 6000
		// (get) Token: 0x0600849A RID: 33946 RVA: 0x002728B4 File Offset: 0x00270AB4
		public int QuestId
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

		// Token: 0x04005387 RID: 21383
		private Table __p;
	}
}
