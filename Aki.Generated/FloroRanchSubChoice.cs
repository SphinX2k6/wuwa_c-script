using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000CB2 RID: 3250
	public struct FloroRanchSubChoice : IFlatbufferObject
	{
		// Token: 0x17001325 RID: 4901
		// (get) Token: 0x060073FB RID: 29691 RVA: 0x0023C938 File Offset: 0x0023AB38
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060073FC RID: 29692 RVA: 0x0023C945 File Offset: 0x0023AB45
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060073FD RID: 29693 RVA: 0x0023C94C File Offset: 0x0023AB4C
		public static FloroRanchSubChoice GetRootAsFloroRanchSubChoice(ByteBuffer _bb)
		{
			return FloroRanchSubChoice.GetRootAsFloroRanchSubChoice(_bb, default(FloroRanchSubChoice));
		}

		// Token: 0x060073FE RID: 29694 RVA: 0x0023C968 File Offset: 0x0023AB68
		public static FloroRanchSubChoice GetRootAsFloroRanchSubChoice(ByteBuffer _bb, FloroRanchSubChoice obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060073FF RID: 29695 RVA: 0x0023C985 File Offset: 0x0023AB85
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06007400 RID: 29696 RVA: 0x0023C994 File Offset: 0x0023AB94
		public FloroRanchSubChoice __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001326 RID: 4902
		// (get) Token: 0x06007401 RID: 29697 RVA: 0x0023C9A4 File Offset: 0x0023ABA4
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

		// Token: 0x04004D1A RID: 19738
		private Table __p;
	}
}
