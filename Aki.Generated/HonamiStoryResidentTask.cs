using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D4C RID: 3404
	public struct HonamiStoryResidentTask : IFlatbufferObject
	{
		// Token: 0x17001828 RID: 6184
		// (get) Token: 0x0600811A RID: 33050 RVA: 0x00259E9D File Offset: 0x0025809D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600811B RID: 33051 RVA: 0x00259EAA File Offset: 0x002580AA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600811C RID: 33052 RVA: 0x00259EB4 File Offset: 0x002580B4
		public static HonamiStoryResidentTask GetRootAsHonamiStoryResidentTask(ByteBuffer _bb)
		{
			return HonamiStoryResidentTask.GetRootAsHonamiStoryResidentTask(_bb, default(HonamiStoryResidentTask));
		}

		// Token: 0x0600811D RID: 33053 RVA: 0x00259ED0 File Offset: 0x002580D0
		public static HonamiStoryResidentTask GetRootAsHonamiStoryResidentTask(ByteBuffer _bb, HonamiStoryResidentTask obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600811E RID: 33054 RVA: 0x00259EED File Offset: 0x002580ED
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600811F RID: 33055 RVA: 0x00259EFC File Offset: 0x002580FC
		public HonamiStoryResidentTask __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001829 RID: 6185
		// (get) Token: 0x06008120 RID: 33056 RVA: 0x00259F0C File Offset: 0x0025810C
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

		// Token: 0x1700182A RID: 6186
		// (get) Token: 0x06008121 RID: 33057 RVA: 0x00259F48 File Offset: 0x00258148
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

		// Token: 0x1700182B RID: 6187
		// (get) Token: 0x06008122 RID: 33058 RVA: 0x00259F84 File Offset: 0x00258184
		public int DropId
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

		// Token: 0x1700182C RID: 6188
		// (get) Token: 0x06008123 RID: 33059 RVA: 0x00259FC0 File Offset: 0x002581C0
		public string RewardName
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06008124 RID: 33060 RVA: 0x00259FF8 File Offset: 0x002581F8
		public Span<byte> GetRewardNameBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06008125 RID: 33061 RVA: 0x0025A008 File Offset: 0x00258208
		public byte[] GetRewardNameArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x1700182D RID: 6189
		// (get) Token: 0x06008126 RID: 33062 RVA: 0x0025A020 File Offset: 0x00258220
		public int JumpId
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x04004DC8 RID: 19912
		private Table __p;
	}
}
