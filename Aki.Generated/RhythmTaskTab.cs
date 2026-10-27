using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000FC8 RID: 4040
	public struct RhythmTaskTab : IFlatbufferObject
	{
		// Token: 0x17002E70 RID: 11888
		// (get) Token: 0x0600BD0A RID: 48394 RVA: 0x002E06D5 File Offset: 0x002DE8D5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600BD0B RID: 48395 RVA: 0x002E06E2 File Offset: 0x002DE8E2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600BD0C RID: 48396 RVA: 0x002E06EC File Offset: 0x002DE8EC
		public static RhythmTaskTab GetRootAsRhythmTaskTab(ByteBuffer _bb)
		{
			return RhythmTaskTab.GetRootAsRhythmTaskTab(_bb, default(RhythmTaskTab));
		}

		// Token: 0x0600BD0D RID: 48397 RVA: 0x002E0708 File Offset: 0x002DE908
		public static RhythmTaskTab GetRootAsRhythmTaskTab(ByteBuffer _bb, RhythmTaskTab obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600BD0E RID: 48398 RVA: 0x002E0725 File Offset: 0x002DE925
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600BD0F RID: 48399 RVA: 0x002E0734 File Offset: 0x002DE934
		public RhythmTaskTab __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002E71 RID: 11889
		// (get) Token: 0x0600BD10 RID: 48400 RVA: 0x002E0744 File Offset: 0x002DE944
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

		// Token: 0x17002E72 RID: 11890
		// (get) Token: 0x0600BD11 RID: 48401 RVA: 0x002E0780 File Offset: 0x002DE980
		public string TabName
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

		// Token: 0x0600BD12 RID: 48402 RVA: 0x002E07B7 File Offset: 0x002DE9B7
		public Span<byte> GetTabNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600BD13 RID: 48403 RVA: 0x002E07C6 File Offset: 0x002DE9C6
		public byte[] GetTabNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x040050A3 RID: 20643
		private Table __p;
	}
}
