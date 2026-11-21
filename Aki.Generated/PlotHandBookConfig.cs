using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001032 RID: 4146
	public struct PlotHandBookConfig : IFlatbufferObject
	{
		// Token: 0x17002B01 RID: 11009
		// (get) Token: 0x0600B880 RID: 47232 RVA: 0x002E5E6D File Offset: 0x002E406D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600B881 RID: 47233 RVA: 0x002E5E7A File Offset: 0x002E407A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600B882 RID: 47234 RVA: 0x002E5E84 File Offset: 0x002E4084
		public static PlotHandBookConfig GetRootAsPlotHandBookConfig(ByteBuffer _bb)
		{
			return PlotHandBookConfig.GetRootAsPlotHandBookConfig(_bb, default(PlotHandBookConfig));
		}

		// Token: 0x0600B883 RID: 47235 RVA: 0x002E5EA0 File Offset: 0x002E40A0
		public static PlotHandBookConfig GetRootAsPlotHandBookConfig(ByteBuffer _bb, PlotHandBookConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600B884 RID: 47236 RVA: 0x002E5EBD File Offset: 0x002E40BD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600B885 RID: 47237 RVA: 0x002E5ECC File Offset: 0x002E40CC
		public PlotHandBookConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002B02 RID: 11010
		// (get) Token: 0x0600B886 RID: 47238 RVA: 0x002E5EDC File Offset: 0x002E40DC
		public int QuestId
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

		// Token: 0x17002B03 RID: 11011
		// (get) Token: 0x0600B887 RID: 47239 RVA: 0x002E5F18 File Offset: 0x002E4118
		public string Data
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

		// Token: 0x0600B888 RID: 47240 RVA: 0x002E5F4F File Offset: 0x002E414F
		public Span<byte> GetDataBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600B889 RID: 47241 RVA: 0x002E5F5E File Offset: 0x002E415E
		public byte[] GetDataArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x040055FF RID: 22015
		private Table __p;
	}
}
