using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E2B RID: 3627
	public struct HonamiStoryPluginTag : IFlatbufferObject
	{
		// Token: 0x1700186E RID: 6254
		// (get) Token: 0x060086F0 RID: 34544 RVA: 0x00277DBC File Offset: 0x00275FBC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060086F1 RID: 34545 RVA: 0x00277DC9 File Offset: 0x00275FC9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060086F2 RID: 34546 RVA: 0x00277DD0 File Offset: 0x00275FD0
		public static HonamiStoryPluginTag GetRootAsHonamiStoryPluginTag(ByteBuffer _bb)
		{
			return HonamiStoryPluginTag.GetRootAsHonamiStoryPluginTag(_bb, default(HonamiStoryPluginTag));
		}

		// Token: 0x060086F3 RID: 34547 RVA: 0x00277DEC File Offset: 0x00275FEC
		public static HonamiStoryPluginTag GetRootAsHonamiStoryPluginTag(ByteBuffer _bb, HonamiStoryPluginTag obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060086F4 RID: 34548 RVA: 0x00277E09 File Offset: 0x00276009
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060086F5 RID: 34549 RVA: 0x00277E18 File Offset: 0x00276018
		public HonamiStoryPluginTag __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700186F RID: 6255
		// (get) Token: 0x060086F6 RID: 34550 RVA: 0x00277E28 File Offset: 0x00276028
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

		// Token: 0x17001870 RID: 6256
		// (get) Token: 0x060086F7 RID: 34551 RVA: 0x00277E64 File Offset: 0x00276064
		public string Name
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

		// Token: 0x060086F8 RID: 34552 RVA: 0x00277E9B File Offset: 0x0027609B
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x060086F9 RID: 34553 RVA: 0x00277EAA File Offset: 0x002760AA
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17001871 RID: 6257
		// (get) Token: 0x060086FA RID: 34554 RVA: 0x00277EC4 File Offset: 0x002760C4
		public string Color
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060086FB RID: 34555 RVA: 0x00277EFB File Offset: 0x002760FB
		public Span<byte> GetColorBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x060086FC RID: 34556 RVA: 0x00277F0A File Offset: 0x0027610A
		public byte[] GetColorArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x040053A7 RID: 21415
		private Table __p;
	}
}
