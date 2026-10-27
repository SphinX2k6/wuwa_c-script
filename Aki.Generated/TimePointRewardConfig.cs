using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200112E RID: 4398
	public struct TimePointRewardConfig : IFlatbufferObject
	{
		// Token: 0x17003A74 RID: 14964
		// (get) Token: 0x0600DEE2 RID: 57058 RVA: 0x0032E088 File Offset: 0x0032C288
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600DEE3 RID: 57059 RVA: 0x0032E095 File Offset: 0x0032C295
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600DEE4 RID: 57060 RVA: 0x0032E09C File Offset: 0x0032C29C
		public static TimePointRewardConfig GetRootAsTimePointRewardConfig(ByteBuffer _bb)
		{
			return TimePointRewardConfig.GetRootAsTimePointRewardConfig(_bb, default(TimePointRewardConfig));
		}

		// Token: 0x0600DEE5 RID: 57061 RVA: 0x0032E0B8 File Offset: 0x0032C2B8
		public static TimePointRewardConfig GetRootAsTimePointRewardConfig(ByteBuffer _bb, TimePointRewardConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600DEE6 RID: 57062 RVA: 0x0032E0D5 File Offset: 0x0032C2D5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600DEE7 RID: 57063 RVA: 0x0032E0E4 File Offset: 0x0032C2E4
		public TimePointRewardConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003A75 RID: 14965
		// (get) Token: 0x0600DEE8 RID: 57064 RVA: 0x0032E0F4 File Offset: 0x0032C2F4
		public int ActivityId
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

		// Token: 0x17003A76 RID: 14966
		// (get) Token: 0x0600DEE9 RID: 57065 RVA: 0x0032E130 File Offset: 0x0032C330
		public string UiPrefab
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

		// Token: 0x0600DEEA RID: 57066 RVA: 0x0032E167 File Offset: 0x0032C367
		public Span<byte> GetUiPrefabBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600DEEB RID: 57067 RVA: 0x0032E176 File Offset: 0x0032C376
		public byte[] GetUiPrefabArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x0400526F RID: 21103
		private Table __p;
	}
}
