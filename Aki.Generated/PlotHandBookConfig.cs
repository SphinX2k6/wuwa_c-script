using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F4D RID: 3917
	public struct PlotHandBookConfig : IFlatbufferObject
	{
		// Token: 0x17002A9B RID: 10907
		// (get) Token: 0x0600B25F RID: 45663 RVA: 0x002C9621 File Offset: 0x002C7821
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600B260 RID: 45664 RVA: 0x002C962E File Offset: 0x002C782E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600B261 RID: 45665 RVA: 0x002C9638 File Offset: 0x002C7838
		public static PlotHandBookConfig GetRootAsPlotHandBookConfig(ByteBuffer _bb)
		{
			return PlotHandBookConfig.GetRootAsPlotHandBookConfig(_bb, default(PlotHandBookConfig));
		}

		// Token: 0x0600B262 RID: 45666 RVA: 0x002C9654 File Offset: 0x002C7854
		public static PlotHandBookConfig GetRootAsPlotHandBookConfig(ByteBuffer _bb, PlotHandBookConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600B263 RID: 45667 RVA: 0x002C9671 File Offset: 0x002C7871
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600B264 RID: 45668 RVA: 0x002C9680 File Offset: 0x002C7880
		public PlotHandBookConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002A9C RID: 10908
		// (get) Token: 0x0600B265 RID: 45669 RVA: 0x002C9690 File Offset: 0x002C7890
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

		// Token: 0x17002A9D RID: 10909
		// (get) Token: 0x0600B266 RID: 45670 RVA: 0x002C96CC File Offset: 0x002C78CC
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

		// Token: 0x0600B267 RID: 45671 RVA: 0x002C9703 File Offset: 0x002C7903
		public Span<byte> GetDataBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600B268 RID: 45672 RVA: 0x002C9712 File Offset: 0x002C7912
		public byte[] GetDataArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x0400501A RID: 20506
		private Table __p;
	}
}
