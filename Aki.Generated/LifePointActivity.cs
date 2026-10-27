using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000DC5 RID: 3525
	public struct LifePointActivity : IFlatbufferObject
	{
		// Token: 0x17001CCC RID: 7372
		// (get) Token: 0x06008DC0 RID: 36288 RVA: 0x0027707D File Offset: 0x0027527D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06008DC1 RID: 36289 RVA: 0x0027708A File Offset: 0x0027528A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06008DC2 RID: 36290 RVA: 0x00277094 File Offset: 0x00275294
		public static LifePointActivity GetRootAsLifePointActivity(ByteBuffer _bb)
		{
			return LifePointActivity.GetRootAsLifePointActivity(_bb, default(LifePointActivity));
		}

		// Token: 0x06008DC3 RID: 36291 RVA: 0x002770B0 File Offset: 0x002752B0
		public static LifePointActivity GetRootAsLifePointActivity(ByteBuffer _bb, LifePointActivity obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06008DC4 RID: 36292 RVA: 0x002770CD File Offset: 0x002752CD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06008DC5 RID: 36293 RVA: 0x002770DC File Offset: 0x002752DC
		public LifePointActivity __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001CCD RID: 7373
		// (get) Token: 0x06008DC6 RID: 36294 RVA: 0x002770EC File Offset: 0x002752EC
		public int ActivityId
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

		// Token: 0x17001CCE RID: 7374
		// (get) Token: 0x06008DC7 RID: 36295 RVA: 0x00277128 File Offset: 0x00275328
		public int MarkId
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

		// Token: 0x04004E5B RID: 20059
		private Table __p;
	}
}
