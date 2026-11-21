using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D8A RID: 3466
	public struct FloroRanchChoiceType : IFlatbufferObject
	{
		// Token: 0x17001333 RID: 4915
		// (get) Token: 0x0600791A RID: 31002 RVA: 0x002595D9 File Offset: 0x002577D9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600791B RID: 31003 RVA: 0x002595E6 File Offset: 0x002577E6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600791C RID: 31004 RVA: 0x002595F0 File Offset: 0x002577F0
		public static FloroRanchChoiceType GetRootAsFloroRanchChoiceType(ByteBuffer _bb)
		{
			return FloroRanchChoiceType.GetRootAsFloroRanchChoiceType(_bb, default(FloroRanchChoiceType));
		}

		// Token: 0x0600791D RID: 31005 RVA: 0x0025960C File Offset: 0x0025780C
		public static FloroRanchChoiceType GetRootAsFloroRanchChoiceType(ByteBuffer _bb, FloroRanchChoiceType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600791E RID: 31006 RVA: 0x00259629 File Offset: 0x00257829
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600791F RID: 31007 RVA: 0x00259638 File Offset: 0x00257838
		public FloroRanchChoiceType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001334 RID: 4916
		// (get) Token: 0x06007920 RID: 31008 RVA: 0x00259648 File Offset: 0x00257848
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

		// Token: 0x040052EC RID: 21228
		private Table __p;
	}
}
