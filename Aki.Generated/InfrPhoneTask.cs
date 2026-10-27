using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D68 RID: 3432
	public struct InfrPhoneTask : IFlatbufferObject
	{
		// Token: 0x17001903 RID: 6403
		// (get) Token: 0x06008392 RID: 33682 RVA: 0x0025F2BD File Offset: 0x0025D4BD
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06008393 RID: 33683 RVA: 0x0025F2CA File Offset: 0x0025D4CA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06008394 RID: 33684 RVA: 0x0025F2D4 File Offset: 0x0025D4D4
		public static InfrPhoneTask GetRootAsInfrPhoneTask(ByteBuffer _bb)
		{
			return InfrPhoneTask.GetRootAsInfrPhoneTask(_bb, default(InfrPhoneTask));
		}

		// Token: 0x06008395 RID: 33685 RVA: 0x0025F2F0 File Offset: 0x0025D4F0
		public static InfrPhoneTask GetRootAsInfrPhoneTask(ByteBuffer _bb, InfrPhoneTask obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06008396 RID: 33686 RVA: 0x0025F30D File Offset: 0x0025D50D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06008397 RID: 33687 RVA: 0x0025F31C File Offset: 0x0025D51C
		public InfrPhoneTask __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001904 RID: 6404
		// (get) Token: 0x06008398 RID: 33688 RVA: 0x0025F32C File Offset: 0x0025D52C
		public int TaskId
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

		// Token: 0x17001905 RID: 6405
		// (get) Token: 0x06008399 RID: 33689 RVA: 0x0025F368 File Offset: 0x0025D568
		public int Target
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001906 RID: 6406
		// (get) Token: 0x0600839A RID: 33690 RVA: 0x0025F3A4 File Offset: 0x0025D5A4
		public int TaskReward
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

		// Token: 0x04004DE8 RID: 19944
		private Table __p;
	}
}
