using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001177 RID: 4471
	public struct RoverRogueIncreaseType : IFlatbufferObject
	{
		// Token: 0x1700355C RID: 13660
		// (get) Token: 0x0600D5AC RID: 54700 RVA: 0x003259A5 File Offset: 0x00323BA5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600D5AD RID: 54701 RVA: 0x003259B2 File Offset: 0x00323BB2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600D5AE RID: 54702 RVA: 0x003259BC File Offset: 0x00323BBC
		public static RoverRogueIncreaseType GetRootAsRoverRogueIncreaseType(ByteBuffer _bb)
		{
			return RoverRogueIncreaseType.GetRootAsRoverRogueIncreaseType(_bb, default(RoverRogueIncreaseType));
		}

		// Token: 0x0600D5AF RID: 54703 RVA: 0x003259D8 File Offset: 0x00323BD8
		public static RoverRogueIncreaseType GetRootAsRoverRogueIncreaseType(ByteBuffer _bb, RoverRogueIncreaseType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600D5B0 RID: 54704 RVA: 0x003259F5 File Offset: 0x00323BF5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600D5B1 RID: 54705 RVA: 0x00325A04 File Offset: 0x00323C04
		public RoverRogueIncreaseType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700355D RID: 13661
		// (get) Token: 0x0600D5B2 RID: 54706 RVA: 0x00325A14 File Offset: 0x00323C14
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

		// Token: 0x1700355E RID: 13662
		// (get) Token: 0x0600D5B3 RID: 54707 RVA: 0x00325A50 File Offset: 0x00323C50
		public string Icon
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600D5B4 RID: 54708 RVA: 0x00325A87 File Offset: 0x00323C87
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600D5B5 RID: 54709 RVA: 0x00325A96 File Offset: 0x00323C96
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x04005785 RID: 22405
		private Table __p;
	}
}
