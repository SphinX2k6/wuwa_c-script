using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F4E RID: 3918
	public struct PlotReference : IFlatbufferObject
	{
		// Token: 0x17002A9E RID: 10910
		// (get) Token: 0x0600B269 RID: 45673 RVA: 0x002C9729 File Offset: 0x002C7929
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600B26A RID: 45674 RVA: 0x002C9736 File Offset: 0x002C7936
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600B26B RID: 45675 RVA: 0x002C9740 File Offset: 0x002C7940
		public static PlotReference GetRootAsPlotReference(ByteBuffer _bb)
		{
			return PlotReference.GetRootAsPlotReference(_bb, default(PlotReference));
		}

		// Token: 0x0600B26C RID: 45676 RVA: 0x002C975C File Offset: 0x002C795C
		public static PlotReference GetRootAsPlotReference(ByteBuffer _bb, PlotReference obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600B26D RID: 45677 RVA: 0x002C9779 File Offset: 0x002C7979
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600B26E RID: 45678 RVA: 0x002C9788 File Offset: 0x002C7988
		public PlotReference __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002A9F RID: 10911
		// (get) Token: 0x0600B26F RID: 45679 RVA: 0x002C9798 File Offset: 0x002C7998
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

		// Token: 0x17002AA0 RID: 10912
		// (get) Token: 0x0600B270 RID: 45680 RVA: 0x002C97D4 File Offset: 0x002C79D4
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

		// Token: 0x0600B271 RID: 45681 RVA: 0x002C980B File Offset: 0x002C7A0B
		public Span<byte> GetPlotBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600B272 RID: 45682 RVA: 0x002C981A File Offset: 0x002C7A1A
		public byte[] GetPlotArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x0400501B RID: 20507
		private Table __p;
	}
}
