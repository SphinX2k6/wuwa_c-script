using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020010B0 RID: 4272
	public struct RhythmTaskTab : IFlatbufferObject
	{
		// Token: 0x17002EEB RID: 12011
		// (get) Token: 0x0600C354 RID: 50004 RVA: 0x002FCD1D File Offset: 0x002FAF1D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600C355 RID: 50005 RVA: 0x002FCD2A File Offset: 0x002FAF2A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600C356 RID: 50006 RVA: 0x002FCD34 File Offset: 0x002FAF34
		public static RhythmTaskTab GetRootAsRhythmTaskTab(ByteBuffer _bb)
		{
			return RhythmTaskTab.GetRootAsRhythmTaskTab(_bb, default(RhythmTaskTab));
		}

		// Token: 0x0600C357 RID: 50007 RVA: 0x002FCD50 File Offset: 0x002FAF50
		public static RhythmTaskTab GetRootAsRhythmTaskTab(ByteBuffer _bb, RhythmTaskTab obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600C358 RID: 50008 RVA: 0x002FCD6D File Offset: 0x002FAF6D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600C359 RID: 50009 RVA: 0x002FCD7C File Offset: 0x002FAF7C
		public RhythmTaskTab __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002EEC RID: 12012
		// (get) Token: 0x0600C35A RID: 50010 RVA: 0x002FCD8C File Offset: 0x002FAF8C
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

		// Token: 0x17002EED RID: 12013
		// (get) Token: 0x0600C35B RID: 50011 RVA: 0x002FCDC8 File Offset: 0x002FAFC8
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

		// Token: 0x0600C35C RID: 50012 RVA: 0x002FCDFF File Offset: 0x002FAFFF
		public Span<byte> GetTabNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600C35D RID: 50013 RVA: 0x002FCE0E File Offset: 0x002FB00E
		public byte[] GetTabNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x0400568B RID: 22155
		private Table __p;
	}
}
