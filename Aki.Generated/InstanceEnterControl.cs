using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E57 RID: 3671
	public struct InstanceEnterControl : IFlatbufferObject
	{
		// Token: 0x17001A18 RID: 6680
		// (get) Token: 0x06008B9C RID: 35740 RVA: 0x002824F1 File Offset: 0x002806F1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06008B9D RID: 35741 RVA: 0x002824FE File Offset: 0x002806FE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06008B9E RID: 35742 RVA: 0x00282508 File Offset: 0x00280708
		public static InstanceEnterControl GetRootAsInstanceEnterControl(ByteBuffer _bb)
		{
			return InstanceEnterControl.GetRootAsInstanceEnterControl(_bb, default(InstanceEnterControl));
		}

		// Token: 0x06008B9F RID: 35743 RVA: 0x00282524 File Offset: 0x00280724
		public static InstanceEnterControl GetRootAsInstanceEnterControl(ByteBuffer _bb, InstanceEnterControl obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06008BA0 RID: 35744 RVA: 0x00282541 File Offset: 0x00280741
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06008BA1 RID: 35745 RVA: 0x00282550 File Offset: 0x00280750
		public InstanceEnterControl __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001A19 RID: 6681
		// (get) Token: 0x06008BA2 RID: 35746 RVA: 0x00282560 File Offset: 0x00280760
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

		// Token: 0x17001A1A RID: 6682
		// (get) Token: 0x06008BA3 RID: 35747 RVA: 0x0028259C File Offset: 0x0028079C
		public int EnterCount
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

		// Token: 0x17001A1B RID: 6683
		// (get) Token: 0x06008BA4 RID: 35748 RVA: 0x002825D8 File Offset: 0x002807D8
		public int EnterCountConsumeType
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

		// Token: 0x040053DF RID: 21471
		private Table __p;
	}
}
