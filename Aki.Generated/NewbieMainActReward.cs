using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F67 RID: 3943
	public struct NewbieMainActReward : IFlatbufferObject
	{
		// Token: 0x1700235E RID: 9054
		// (get) Token: 0x0600A489 RID: 42121 RVA: 0x002B9889 File Offset: 0x002B7A89
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600A48A RID: 42122 RVA: 0x002B9896 File Offset: 0x002B7A96
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600A48B RID: 42123 RVA: 0x002B98A0 File Offset: 0x002B7AA0
		public static NewbieMainActReward GetRootAsNewbieMainActReward(ByteBuffer _bb)
		{
			return NewbieMainActReward.GetRootAsNewbieMainActReward(_bb, default(NewbieMainActReward));
		}

		// Token: 0x0600A48C RID: 42124 RVA: 0x002B98BC File Offset: 0x002B7ABC
		public static NewbieMainActReward GetRootAsNewbieMainActReward(ByteBuffer _bb, NewbieMainActReward obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600A48D RID: 42125 RVA: 0x002B98D9 File Offset: 0x002B7AD9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600A48E RID: 42126 RVA: 0x002B98E8 File Offset: 0x002B7AE8
		public NewbieMainActReward __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700235F RID: 9055
		// (get) Token: 0x0600A48F RID: 42127 RVA: 0x002B98F8 File Offset: 0x002B7AF8
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

		// Token: 0x17002360 RID: 9056
		// (get) Token: 0x0600A490 RID: 42128 RVA: 0x002B9934 File Offset: 0x002B7B34
		public int ActivityId
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

		// Token: 0x17002361 RID: 9057
		// (get) Token: 0x0600A491 RID: 42129 RVA: 0x002B9970 File Offset: 0x002B7B70
		public int Score
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

		// Token: 0x17002362 RID: 9058
		// (get) Token: 0x0600A492 RID: 42130 RVA: 0x002B99AC File Offset: 0x002B7BAC
		public int DropId
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x04005515 RID: 21781
		private Table __p;
	}
}
