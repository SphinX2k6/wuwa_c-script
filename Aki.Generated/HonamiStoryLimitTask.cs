using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D3C RID: 3388
	public struct HonamiStoryLimitTask : IFlatbufferObject
	{
		// Token: 0x170017C9 RID: 6089
		// (get) Token: 0x06008030 RID: 32816 RVA: 0x00257FCC File Offset: 0x002561CC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06008031 RID: 32817 RVA: 0x00257FD9 File Offset: 0x002561D9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06008032 RID: 32818 RVA: 0x00257FE0 File Offset: 0x002561E0
		public static HonamiStoryLimitTask GetRootAsHonamiStoryLimitTask(ByteBuffer _bb)
		{
			return HonamiStoryLimitTask.GetRootAsHonamiStoryLimitTask(_bb, default(HonamiStoryLimitTask));
		}

		// Token: 0x06008033 RID: 32819 RVA: 0x00257FFC File Offset: 0x002561FC
		public static HonamiStoryLimitTask GetRootAsHonamiStoryLimitTask(ByteBuffer _bb, HonamiStoryLimitTask obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06008034 RID: 32820 RVA: 0x00258019 File Offset: 0x00256219
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06008035 RID: 32821 RVA: 0x00258028 File Offset: 0x00256228
		public HonamiStoryLimitTask __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170017CA RID: 6090
		// (get) Token: 0x06008036 RID: 32822 RVA: 0x00258038 File Offset: 0x00256238
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

		// Token: 0x170017CB RID: 6091
		// (get) Token: 0x06008037 RID: 32823 RVA: 0x00258074 File Offset: 0x00256274
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

		// Token: 0x170017CC RID: 6092
		// (get) Token: 0x06008038 RID: 32824 RVA: 0x002580B0 File Offset: 0x002562B0
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

		// Token: 0x170017CD RID: 6093
		// (get) Token: 0x06008039 RID: 32825 RVA: 0x002580EC File Offset: 0x002562EC
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

		// Token: 0x0600803A RID: 32826 RVA: 0x00258124 File Offset: 0x00256324
		public Span<byte> GetRewardNameBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600803B RID: 32827 RVA: 0x00258134 File Offset: 0x00256334
		public byte[] GetRewardNameArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x170017CE RID: 6094
		// (get) Token: 0x0600803C RID: 32828 RVA: 0x0025814C File Offset: 0x0025634C
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

		// Token: 0x04004DB7 RID: 19895
		private Table __p;
	}
}
