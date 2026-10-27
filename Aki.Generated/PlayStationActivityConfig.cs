using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F49 RID: 3913
	public struct PlayStationActivityConfig : IFlatbufferObject
	{
		// Token: 0x17002A81 RID: 10881
		// (get) Token: 0x0600B21A RID: 45594 RVA: 0x002C8D58 File Offset: 0x002C6F58
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600B21B RID: 45595 RVA: 0x002C8D65 File Offset: 0x002C6F65
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600B21C RID: 45596 RVA: 0x002C8D6C File Offset: 0x002C6F6C
		public static PlayStationActivityConfig GetRootAsPlayStationActivityConfig(ByteBuffer _bb)
		{
			return PlayStationActivityConfig.GetRootAsPlayStationActivityConfig(_bb, default(PlayStationActivityConfig));
		}

		// Token: 0x0600B21D RID: 45597 RVA: 0x002C8D88 File Offset: 0x002C6F88
		public static PlayStationActivityConfig GetRootAsPlayStationActivityConfig(ByteBuffer _bb, PlayStationActivityConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600B21E RID: 45598 RVA: 0x002C8DA5 File Offset: 0x002C6FA5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600B21F RID: 45599 RVA: 0x002C8DB4 File Offset: 0x002C6FB4
		public PlayStationActivityConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002A82 RID: 10882
		// (get) Token: 0x0600B220 RID: 45600 RVA: 0x002C8DC4 File Offset: 0x002C6FC4
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

		// Token: 0x17002A83 RID: 10883
		// (get) Token: 0x0600B221 RID: 45601 RVA: 0x002C8E00 File Offset: 0x002C7000
		public string ActivityStringId
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

		// Token: 0x0600B222 RID: 45602 RVA: 0x002C8E37 File Offset: 0x002C7037
		public Span<byte> GetActivityStringIdBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600B223 RID: 45603 RVA: 0x002C8E46 File Offset: 0x002C7046
		public byte[] GetActivityStringIdArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17002A84 RID: 10884
		// (get) Token: 0x0600B224 RID: 45604 RVA: 0x002C8E60 File Offset: 0x002C7060
		public int QuestId
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

		// Token: 0x04005016 RID: 20502
		private Table __p;
	}
}
