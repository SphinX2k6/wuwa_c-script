using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000CBE RID: 3262
	public struct FloroRanchUnitType : IFlatbufferObject
	{
		// Token: 0x17001381 RID: 4993
		// (get) Token: 0x06007520 RID: 29984 RVA: 0x0023F58C File Offset: 0x0023D78C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06007521 RID: 29985 RVA: 0x0023F599 File Offset: 0x0023D799
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06007522 RID: 29986 RVA: 0x0023F5A0 File Offset: 0x0023D7A0
		public static FloroRanchUnitType GetRootAsFloroRanchUnitType(ByteBuffer _bb)
		{
			return FloroRanchUnitType.GetRootAsFloroRanchUnitType(_bb, default(FloroRanchUnitType));
		}

		// Token: 0x06007523 RID: 29987 RVA: 0x0023F5BC File Offset: 0x0023D7BC
		public static FloroRanchUnitType GetRootAsFloroRanchUnitType(ByteBuffer _bb, FloroRanchUnitType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06007524 RID: 29988 RVA: 0x0023F5D9 File Offset: 0x0023D7D9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06007525 RID: 29989 RVA: 0x0023F5E8 File Offset: 0x0023D7E8
		public FloroRanchUnitType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001382 RID: 4994
		// (get) Token: 0x06007526 RID: 29990 RVA: 0x0023F5F8 File Offset: 0x0023D7F8
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

		// Token: 0x04004D2E RID: 19758
		private Table __p;
	}
}
