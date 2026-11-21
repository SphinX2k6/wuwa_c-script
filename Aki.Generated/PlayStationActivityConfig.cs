using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200102E RID: 4142
	public struct PlayStationActivityConfig : IFlatbufferObject
	{
		// Token: 0x17002AE7 RID: 10983
		// (get) Token: 0x0600B83B RID: 47163 RVA: 0x002E55C0 File Offset: 0x002E37C0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600B83C RID: 47164 RVA: 0x002E55CD File Offset: 0x002E37CD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600B83D RID: 47165 RVA: 0x002E55D4 File Offset: 0x002E37D4
		public static PlayStationActivityConfig GetRootAsPlayStationActivityConfig(ByteBuffer _bb)
		{
			return PlayStationActivityConfig.GetRootAsPlayStationActivityConfig(_bb, default(PlayStationActivityConfig));
		}

		// Token: 0x0600B83E RID: 47166 RVA: 0x002E55F0 File Offset: 0x002E37F0
		public static PlayStationActivityConfig GetRootAsPlayStationActivityConfig(ByteBuffer _bb, PlayStationActivityConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600B83F RID: 47167 RVA: 0x002E560D File Offset: 0x002E380D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600B840 RID: 47168 RVA: 0x002E561C File Offset: 0x002E381C
		public PlayStationActivityConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002AE8 RID: 10984
		// (get) Token: 0x0600B841 RID: 47169 RVA: 0x002E562C File Offset: 0x002E382C
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

		// Token: 0x17002AE9 RID: 10985
		// (get) Token: 0x0600B842 RID: 47170 RVA: 0x002E5668 File Offset: 0x002E3868
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

		// Token: 0x0600B843 RID: 47171 RVA: 0x002E569F File Offset: 0x002E389F
		public Span<byte> GetActivityStringIdBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600B844 RID: 47172 RVA: 0x002E56AE File Offset: 0x002E38AE
		public byte[] GetActivityStringIdArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17002AEA RID: 10986
		// (get) Token: 0x0600B845 RID: 47173 RVA: 0x002E56C8 File Offset: 0x002E38C8
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

		// Token: 0x040055FB RID: 22011
		private Table __p;
	}
}
