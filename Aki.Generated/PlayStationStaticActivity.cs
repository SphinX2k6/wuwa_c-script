using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F4A RID: 3914
	public struct PlayStationStaticActivity : IFlatbufferObject
	{
		// Token: 0x17002A85 RID: 10885
		// (get) Token: 0x0600B225 RID: 45605 RVA: 0x002C8E9C File Offset: 0x002C709C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600B226 RID: 45606 RVA: 0x002C8EA9 File Offset: 0x002C70A9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600B227 RID: 45607 RVA: 0x002C8EB0 File Offset: 0x002C70B0
		public static PlayStationStaticActivity GetRootAsPlayStationStaticActivity(ByteBuffer _bb)
		{
			return PlayStationStaticActivity.GetRootAsPlayStationStaticActivity(_bb, default(PlayStationStaticActivity));
		}

		// Token: 0x0600B228 RID: 45608 RVA: 0x002C8ECC File Offset: 0x002C70CC
		public static PlayStationStaticActivity GetRootAsPlayStationStaticActivity(ByteBuffer _bb, PlayStationStaticActivity obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600B229 RID: 45609 RVA: 0x002C8EE9 File Offset: 0x002C70E9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600B22A RID: 45610 RVA: 0x002C8EF8 File Offset: 0x002C70F8
		public PlayStationStaticActivity __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002A86 RID: 10886
		// (get) Token: 0x0600B22B RID: 45611 RVA: 0x002C8F08 File Offset: 0x002C7108
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

		// Token: 0x17002A87 RID: 10887
		// (get) Token: 0x0600B22C RID: 45612 RVA: 0x002C8F44 File Offset: 0x002C7144
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

		// Token: 0x0600B22D RID: 45613 RVA: 0x002C8F7B File Offset: 0x002C717B
		public Span<byte> GetActivityStringIdBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600B22E RID: 45614 RVA: 0x002C8F8A File Offset: 0x002C718A
		public byte[] GetActivityStringIdArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17002A88 RID: 10888
		// (get) Token: 0x0600B22F RID: 45615 RVA: 0x002C8FA4 File Offset: 0x002C71A4
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

		// Token: 0x04005017 RID: 20503
		private Table __p;
	}
}
