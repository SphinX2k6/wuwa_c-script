using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001034 RID: 4148
	public struct PlotType : IFlatbufferObject
	{
		// Token: 0x17002B07 RID: 11015
		// (get) Token: 0x0600B894 RID: 47252 RVA: 0x002E607D File Offset: 0x002E427D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600B895 RID: 47253 RVA: 0x002E608A File Offset: 0x002E428A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600B896 RID: 47254 RVA: 0x002E6094 File Offset: 0x002E4294
		public static PlotType GetRootAsPlotType(ByteBuffer _bb)
		{
			return PlotType.GetRootAsPlotType(_bb, default(PlotType));
		}

		// Token: 0x0600B897 RID: 47255 RVA: 0x002E60B0 File Offset: 0x002E42B0
		public static PlotType GetRootAsPlotType(ByteBuffer _bb, PlotType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600B898 RID: 47256 RVA: 0x002E60CD File Offset: 0x002E42CD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600B899 RID: 47257 RVA: 0x002E60DC File Offset: 0x002E42DC
		public PlotType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002B08 RID: 11016
		// (get) Token: 0x0600B89A RID: 47258 RVA: 0x002E60EC File Offset: 0x002E42EC
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

		// Token: 0x17002B09 RID: 11017
		// (get) Token: 0x0600B89B RID: 47259 RVA: 0x002E6128 File Offset: 0x002E4328
		public string TypeDescription
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

		// Token: 0x0600B89C RID: 47260 RVA: 0x002E615F File Offset: 0x002E435F
		public Span<byte> GetTypeDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600B89D RID: 47261 RVA: 0x002E616E File Offset: 0x002E436E
		public byte[] GetTypeDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17002B0A RID: 11018
		// (get) Token: 0x0600B89E RID: 47262 RVA: 0x002E6188 File Offset: 0x002E4388
		public int Type
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

		// Token: 0x04005601 RID: 22017
		private Table __p;
	}
}
