using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000ED7 RID: 3799
	public struct MapPeriodicActivity : IFlatbufferObject
	{
		// Token: 0x17001E9F RID: 7839
		// (get) Token: 0x060097B9 RID: 38841 RVA: 0x0029DEC4 File Offset: 0x0029C0C4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060097BA RID: 38842 RVA: 0x0029DED1 File Offset: 0x0029C0D1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060097BB RID: 38843 RVA: 0x0029DED8 File Offset: 0x0029C0D8
		public static MapPeriodicActivity GetRootAsMapPeriodicActivity(ByteBuffer _bb)
		{
			return MapPeriodicActivity.GetRootAsMapPeriodicActivity(_bb, default(MapPeriodicActivity));
		}

		// Token: 0x060097BC RID: 38844 RVA: 0x0029DEF4 File Offset: 0x0029C0F4
		public static MapPeriodicActivity GetRootAsMapPeriodicActivity(ByteBuffer _bb, MapPeriodicActivity obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060097BD RID: 38845 RVA: 0x0029DF11 File Offset: 0x0029C111
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060097BE RID: 38846 RVA: 0x0029DF20 File Offset: 0x0029C120
		public MapPeriodicActivity __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001EA0 RID: 7840
		// (get) Token: 0x060097BF RID: 38847 RVA: 0x0029DF30 File Offset: 0x0029C130
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

		// Token: 0x17001EA1 RID: 7841
		// (get) Token: 0x060097C0 RID: 38848 RVA: 0x0029DF6C File Offset: 0x0029C16C
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

		// Token: 0x17001EA2 RID: 7842
		// (get) Token: 0x060097C1 RID: 38849 RVA: 0x0029DFA8 File Offset: 0x0029C1A8
		public string TitleKey
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

		// Token: 0x060097C2 RID: 38850 RVA: 0x0029DFDF File Offset: 0x0029C1DF
		public Span<byte> GetTitleKeyBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x060097C3 RID: 38851 RVA: 0x0029DFEE File Offset: 0x0029C1EE
		public byte[] GetTitleKeyArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17001EA3 RID: 7843
		// (get) Token: 0x060097C4 RID: 38852 RVA: 0x0029E008 File Offset: 0x0029C208
		public string DescriptionKey
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

		// Token: 0x060097C5 RID: 38853 RVA: 0x0029E040 File Offset: 0x0029C240
		public Span<byte> GetDescriptionKeyBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x060097C6 RID: 38854 RVA: 0x0029E050 File Offset: 0x0029C250
		public byte[] GetDescriptionKeyArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17001EA4 RID: 7844
		// (get) Token: 0x060097C7 RID: 38855 RVA: 0x0029E068 File Offset: 0x0029C268
		public string IconPath
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060097C8 RID: 38856 RVA: 0x0029E0A0 File Offset: 0x0029C2A0
		public Span<byte> GetIconPathBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x060097C9 RID: 38857 RVA: 0x0029E0B0 File Offset: 0x0029C2B0
		public byte[] GetIconPathArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17001EA5 RID: 7845
		// (get) Token: 0x060097CA RID: 38858 RVA: 0x0029E0C8 File Offset: 0x0029C2C8
		public int MarkId
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001EA6 RID: 7846
		// (get) Token: 0x060097CB RID: 38859 RVA: 0x0029E108 File Offset: 0x0029C308
		public int Priority
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x04005475 RID: 21621
		private Table __p;
	}
}
