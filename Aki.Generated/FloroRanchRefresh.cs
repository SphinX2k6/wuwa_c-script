using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000CAE RID: 3246
	public struct FloroRanchRefresh : IFlatbufferObject
	{
		// Token: 0x1700130D RID: 4877
		// (get) Token: 0x060073B1 RID: 29617 RVA: 0x0023BCEC File Offset: 0x00239EEC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060073B2 RID: 29618 RVA: 0x0023BCF9 File Offset: 0x00239EF9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060073B3 RID: 29619 RVA: 0x0023BD00 File Offset: 0x00239F00
		public static FloroRanchRefresh GetRootAsFloroRanchRefresh(ByteBuffer _bb)
		{
			return FloroRanchRefresh.GetRootAsFloroRanchRefresh(_bb, default(FloroRanchRefresh));
		}

		// Token: 0x060073B4 RID: 29620 RVA: 0x0023BD1C File Offset: 0x00239F1C
		public static FloroRanchRefresh GetRootAsFloroRanchRefresh(ByteBuffer _bb, FloroRanchRefresh obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060073B5 RID: 29621 RVA: 0x0023BD39 File Offset: 0x00239F39
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060073B6 RID: 29622 RVA: 0x0023BD48 File Offset: 0x00239F48
		public FloroRanchRefresh __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700130E RID: 4878
		// (get) Token: 0x060073B7 RID: 29623 RVA: 0x0023BD58 File Offset: 0x00239F58
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

		// Token: 0x04004D12 RID: 19730
		private Table __p;
	}
}
