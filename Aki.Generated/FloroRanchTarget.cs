using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000CB5 RID: 3253
	public struct FloroRanchTarget : IFlatbufferObject
	{
		// Token: 0x17001344 RID: 4932
		// (get) Token: 0x06007476 RID: 29814 RVA: 0x0023DBAE File Offset: 0x0023BDAE
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06007477 RID: 29815 RVA: 0x0023DBBB File Offset: 0x0023BDBB
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06007478 RID: 29816 RVA: 0x0023DBC4 File Offset: 0x0023BDC4
		public static FloroRanchTarget GetRootAsFloroRanchTarget(ByteBuffer _bb)
		{
			return FloroRanchTarget.GetRootAsFloroRanchTarget(_bb, default(FloroRanchTarget));
		}

		// Token: 0x06007479 RID: 29817 RVA: 0x0023DBE0 File Offset: 0x0023BDE0
		public static FloroRanchTarget GetRootAsFloroRanchTarget(ByteBuffer _bb, FloroRanchTarget obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600747A RID: 29818 RVA: 0x0023DBFD File Offset: 0x0023BDFD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600747B RID: 29819 RVA: 0x0023DC0C File Offset: 0x0023BE0C
		public FloroRanchTarget __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001345 RID: 4933
		// (get) Token: 0x0600747C RID: 29820 RVA: 0x0023DC1C File Offset: 0x0023BE1C
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

		// Token: 0x04004D20 RID: 19744
		private Table __p;
	}
}
