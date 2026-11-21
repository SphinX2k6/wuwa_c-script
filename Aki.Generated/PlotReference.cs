using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001033 RID: 4147
	public struct PlotReference : IFlatbufferObject
	{
		// Token: 0x17002B04 RID: 11012
		// (get) Token: 0x0600B88A RID: 47242 RVA: 0x002E5F75 File Offset: 0x002E4175
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600B88B RID: 47243 RVA: 0x002E5F82 File Offset: 0x002E4182
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600B88C RID: 47244 RVA: 0x002E5F8C File Offset: 0x002E418C
		public static PlotReference GetRootAsPlotReference(ByteBuffer _bb)
		{
			return PlotReference.GetRootAsPlotReference(_bb, default(PlotReference));
		}

		// Token: 0x0600B88D RID: 47245 RVA: 0x002E5FA8 File Offset: 0x002E41A8
		public static PlotReference GetRootAsPlotReference(ByteBuffer _bb, PlotReference obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600B88E RID: 47246 RVA: 0x002E5FC5 File Offset: 0x002E41C5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600B88F RID: 47247 RVA: 0x002E5FD4 File Offset: 0x002E41D4
		public PlotReference __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002B05 RID: 11013
		// (get) Token: 0x0600B890 RID: 47248 RVA: 0x002E5FE4 File Offset: 0x002E41E4
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

		// Token: 0x17002B06 RID: 11014
		// (get) Token: 0x0600B891 RID: 47249 RVA: 0x002E6020 File Offset: 0x002E4220
		public string Plot
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

		// Token: 0x0600B892 RID: 47250 RVA: 0x002E6057 File Offset: 0x002E4257
		public Span<byte> GetPlotBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600B893 RID: 47251 RVA: 0x002E6066 File Offset: 0x002E4266
		public byte[] GetPlotArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x04005600 RID: 22016
		private Table __p;
	}
}
