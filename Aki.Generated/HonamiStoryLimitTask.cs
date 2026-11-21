using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E21 RID: 3617
	public struct HonamiStoryLimitTask : IFlatbufferObject
	{
		// Token: 0x1700182C RID: 6188
		// (get) Token: 0x0600864A RID: 34378 RVA: 0x002767C8 File Offset: 0x002749C8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600864B RID: 34379 RVA: 0x002767D5 File Offset: 0x002749D5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600864C RID: 34380 RVA: 0x002767DC File Offset: 0x002749DC
		public static HonamiStoryLimitTask GetRootAsHonamiStoryLimitTask(ByteBuffer _bb)
		{
			return HonamiStoryLimitTask.GetRootAsHonamiStoryLimitTask(_bb, default(HonamiStoryLimitTask));
		}

		// Token: 0x0600864D RID: 34381 RVA: 0x002767F8 File Offset: 0x002749F8
		public static HonamiStoryLimitTask GetRootAsHonamiStoryLimitTask(ByteBuffer _bb, HonamiStoryLimitTask obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600864E RID: 34382 RVA: 0x00276815 File Offset: 0x00274A15
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600864F RID: 34383 RVA: 0x00276824 File Offset: 0x00274A24
		public HonamiStoryLimitTask __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700182D RID: 6189
		// (get) Token: 0x06008650 RID: 34384 RVA: 0x00276834 File Offset: 0x00274A34
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

		// Token: 0x1700182E RID: 6190
		// (get) Token: 0x06008651 RID: 34385 RVA: 0x00276870 File Offset: 0x00274A70
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

		// Token: 0x1700182F RID: 6191
		// (get) Token: 0x06008652 RID: 34386 RVA: 0x002768AC File Offset: 0x00274AAC
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

		// Token: 0x17001830 RID: 6192
		// (get) Token: 0x06008653 RID: 34387 RVA: 0x002768E8 File Offset: 0x00274AE8
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

		// Token: 0x06008654 RID: 34388 RVA: 0x00276920 File Offset: 0x00274B20
		public Span<byte> GetRewardNameBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06008655 RID: 34389 RVA: 0x00276930 File Offset: 0x00274B30
		public byte[] GetRewardNameArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17001831 RID: 6193
		// (get) Token: 0x06008656 RID: 34390 RVA: 0x00276948 File Offset: 0x00274B48
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

		// Token: 0x0400539C RID: 21404
		private Table __p;
	}
}
