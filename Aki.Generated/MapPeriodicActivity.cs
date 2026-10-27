using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000DF2 RID: 3570
	public struct MapPeriodicActivity : IFlatbufferObject
	{
		// Token: 0x17001E3B RID: 7739
		// (get) Token: 0x0600919D RID: 37277 RVA: 0x0027FD58 File Offset: 0x0027DF58
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600919E RID: 37278 RVA: 0x0027FD65 File Offset: 0x0027DF65
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600919F RID: 37279 RVA: 0x0027FD6C File Offset: 0x0027DF6C
		public static MapPeriodicActivity GetRootAsMapPeriodicActivity(ByteBuffer _bb)
		{
			return MapPeriodicActivity.GetRootAsMapPeriodicActivity(_bb, default(MapPeriodicActivity));
		}

		// Token: 0x060091A0 RID: 37280 RVA: 0x0027FD88 File Offset: 0x0027DF88
		public static MapPeriodicActivity GetRootAsMapPeriodicActivity(ByteBuffer _bb, MapPeriodicActivity obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060091A1 RID: 37281 RVA: 0x0027FDA5 File Offset: 0x0027DFA5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060091A2 RID: 37282 RVA: 0x0027FDB4 File Offset: 0x0027DFB4
		public MapPeriodicActivity __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001E3C RID: 7740
		// (get) Token: 0x060091A3 RID: 37283 RVA: 0x0027FDC4 File Offset: 0x0027DFC4
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

		// Token: 0x17001E3D RID: 7741
		// (get) Token: 0x060091A4 RID: 37284 RVA: 0x0027FE00 File Offset: 0x0027E000
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

		// Token: 0x17001E3E RID: 7742
		// (get) Token: 0x060091A5 RID: 37285 RVA: 0x0027FE3C File Offset: 0x0027E03C
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

		// Token: 0x060091A6 RID: 37286 RVA: 0x0027FE73 File Offset: 0x0027E073
		public Span<byte> GetTitleKeyBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x060091A7 RID: 37287 RVA: 0x0027FE82 File Offset: 0x0027E082
		public byte[] GetTitleKeyArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17001E3F RID: 7743
		// (get) Token: 0x060091A8 RID: 37288 RVA: 0x0027FE9C File Offset: 0x0027E09C
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

		// Token: 0x060091A9 RID: 37289 RVA: 0x0027FED4 File Offset: 0x0027E0D4
		public Span<byte> GetDescriptionKeyBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x060091AA RID: 37290 RVA: 0x0027FEE4 File Offset: 0x0027E0E4
		public byte[] GetDescriptionKeyArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17001E40 RID: 7744
		// (get) Token: 0x060091AB RID: 37291 RVA: 0x0027FEFC File Offset: 0x0027E0FC
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

		// Token: 0x060091AC RID: 37292 RVA: 0x0027FF34 File Offset: 0x0027E134
		public Span<byte> GetIconPathBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x060091AD RID: 37293 RVA: 0x0027FF44 File Offset: 0x0027E144
		public byte[] GetIconPathArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17001E41 RID: 7745
		// (get) Token: 0x060091AE RID: 37294 RVA: 0x0027FF5C File Offset: 0x0027E15C
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

		// Token: 0x17001E42 RID: 7746
		// (get) Token: 0x060091AF RID: 37295 RVA: 0x0027FF9C File Offset: 0x0027E19C
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

		// Token: 0x04004E90 RID: 20112
		private Table __p;
	}
}
