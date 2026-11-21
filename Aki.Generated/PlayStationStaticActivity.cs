using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200102F RID: 4143
	public struct PlayStationStaticActivity : IFlatbufferObject
	{
		// Token: 0x17002AEB RID: 10987
		// (get) Token: 0x0600B846 RID: 47174 RVA: 0x002E5704 File Offset: 0x002E3904
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600B847 RID: 47175 RVA: 0x002E5711 File Offset: 0x002E3911
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600B848 RID: 47176 RVA: 0x002E5718 File Offset: 0x002E3918
		public static PlayStationStaticActivity GetRootAsPlayStationStaticActivity(ByteBuffer _bb)
		{
			return PlayStationStaticActivity.GetRootAsPlayStationStaticActivity(_bb, default(PlayStationStaticActivity));
		}

		// Token: 0x0600B849 RID: 47177 RVA: 0x002E5734 File Offset: 0x002E3934
		public static PlayStationStaticActivity GetRootAsPlayStationStaticActivity(ByteBuffer _bb, PlayStationStaticActivity obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600B84A RID: 47178 RVA: 0x002E5751 File Offset: 0x002E3951
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600B84B RID: 47179 RVA: 0x002E5760 File Offset: 0x002E3960
		public PlayStationStaticActivity __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002AEC RID: 10988
		// (get) Token: 0x0600B84C RID: 47180 RVA: 0x002E5770 File Offset: 0x002E3970
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

		// Token: 0x17002AED RID: 10989
		// (get) Token: 0x0600B84D RID: 47181 RVA: 0x002E57AC File Offset: 0x002E39AC
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

		// Token: 0x0600B84E RID: 47182 RVA: 0x002E57E3 File Offset: 0x002E39E3
		public Span<byte> GetActivityStringIdBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600B84F RID: 47183 RVA: 0x002E57F2 File Offset: 0x002E39F2
		public byte[] GetActivityStringIdArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17002AEE RID: 10990
		// (get) Token: 0x0600B850 RID: 47184 RVA: 0x002E580C File Offset: 0x002E3A0C
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

		// Token: 0x040055FC RID: 22012
		private Table __p;
	}
}
