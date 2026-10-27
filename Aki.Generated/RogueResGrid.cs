using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001006 RID: 4102
	public struct RogueResGrid : IFlatbufferObject
	{
		// Token: 0x1700306A RID: 12394
		// (get) Token: 0x0600C2CE RID: 49870 RVA: 0x002ED355 File Offset: 0x002EB555
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600C2CF RID: 49871 RVA: 0x002ED362 File Offset: 0x002EB562
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600C2D0 RID: 49872 RVA: 0x002ED36C File Offset: 0x002EB56C
		public static RogueResGrid GetRootAsRogueResGrid(ByteBuffer _bb)
		{
			return RogueResGrid.GetRootAsRogueResGrid(_bb, default(RogueResGrid));
		}

		// Token: 0x0600C2D1 RID: 49873 RVA: 0x002ED388 File Offset: 0x002EB588
		public static RogueResGrid GetRootAsRogueResGrid(ByteBuffer _bb, RogueResGrid obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600C2D2 RID: 49874 RVA: 0x002ED3A5 File Offset: 0x002EB5A5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600C2D3 RID: 49875 RVA: 0x002ED3B4 File Offset: 0x002EB5B4
		public RogueResGrid __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700306B RID: 12395
		// (get) Token: 0x0600C2D4 RID: 49876 RVA: 0x002ED3C4 File Offset: 0x002EB5C4
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

		// Token: 0x040050EE RID: 20718
		private Table __p;
	}
}
