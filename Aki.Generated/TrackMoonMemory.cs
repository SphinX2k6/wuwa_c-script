using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001280 RID: 4736
	public struct TrackMoonMemory : IFlatbufferObject
	{
		// Token: 0x17003E9B RID: 16027
		// (get) Token: 0x0600EE5F RID: 61023 RVA: 0x0035DF14 File Offset: 0x0035C114
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600EE60 RID: 61024 RVA: 0x0035DF21 File Offset: 0x0035C121
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600EE61 RID: 61025 RVA: 0x0035DF28 File Offset: 0x0035C128
		public static TrackMoonMemory GetRootAsTrackMoonMemory(ByteBuffer _bb)
		{
			return TrackMoonMemory.GetRootAsTrackMoonMemory(_bb, default(TrackMoonMemory));
		}

		// Token: 0x0600EE62 RID: 61026 RVA: 0x0035DF44 File Offset: 0x0035C144
		public static TrackMoonMemory GetRootAsTrackMoonMemory(ByteBuffer _bb, TrackMoonMemory obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600EE63 RID: 61027 RVA: 0x0035DF61 File Offset: 0x0035C161
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600EE64 RID: 61028 RVA: 0x0035DF70 File Offset: 0x0035C170
		public TrackMoonMemory __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003E9C RID: 16028
		// (get) Token: 0x0600EE65 RID: 61029 RVA: 0x0035DF80 File Offset: 0x0035C180
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

		// Token: 0x17003E9D RID: 16029
		// (get) Token: 0x0600EE66 RID: 61030 RVA: 0x0035DFBC File Offset: 0x0035C1BC
		public int Classify
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

		// Token: 0x17003E9E RID: 16030
		// (get) Token: 0x0600EE67 RID: 61031 RVA: 0x0035DFF8 File Offset: 0x0035C1F8
		public string Title
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

		// Token: 0x0600EE68 RID: 61032 RVA: 0x0035E02F File Offset: 0x0035C22F
		public Span<byte> GetTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600EE69 RID: 61033 RVA: 0x0035E03E File Offset: 0x0035C23E
		public byte[] GetTitleArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17003E9F RID: 16031
		// (get) Token: 0x0600EE6A RID: 61034 RVA: 0x0035E058 File Offset: 0x0035C258
		public string IconPath
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

		// Token: 0x0600EE6B RID: 61035 RVA: 0x0035E090 File Offset: 0x0035C290
		public Span<byte> GetIconPathBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600EE6C RID: 61036 RVA: 0x0035E0A0 File Offset: 0x0035C2A0
		public byte[] GetIconPathArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17003EA0 RID: 16032
		// (get) Token: 0x0600EE6D RID: 61037 RVA: 0x0035E0B8 File Offset: 0x0035C2B8
		public int Sort
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x040058D2 RID: 22738
		private Table __p;
	}
}
