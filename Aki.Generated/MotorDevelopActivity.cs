using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E36 RID: 3638
	public struct MotorDevelopActivity : IFlatbufferObject
	{
		// Token: 0x17002055 RID: 8277
		// (get) Token: 0x06009772 RID: 38770 RVA: 0x0028C9C2 File Offset: 0x0028ABC2
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06009773 RID: 38771 RVA: 0x0028C9CF File Offset: 0x0028ABCF
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06009774 RID: 38772 RVA: 0x0028C9D8 File Offset: 0x0028ABD8
		public static MotorDevelopActivity GetRootAsMotorDevelopActivity(ByteBuffer _bb)
		{
			return MotorDevelopActivity.GetRootAsMotorDevelopActivity(_bb, default(MotorDevelopActivity));
		}

		// Token: 0x06009775 RID: 38773 RVA: 0x0028C9F4 File Offset: 0x0028ABF4
		public static MotorDevelopActivity GetRootAsMotorDevelopActivity(ByteBuffer _bb, MotorDevelopActivity obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06009776 RID: 38774 RVA: 0x0028CA11 File Offset: 0x0028AC11
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06009777 RID: 38775 RVA: 0x0028CA20 File Offset: 0x0028AC20
		public MotorDevelopActivity __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002056 RID: 8278
		// (get) Token: 0x06009778 RID: 38776 RVA: 0x0028CA30 File Offset: 0x0028AC30
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

		// Token: 0x17002057 RID: 8279
		// (get) Token: 0x06009779 RID: 38777 RVA: 0x0028CA6C File Offset: 0x0028AC6C
		public int SkillTreeId
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

		// Token: 0x04004EDC RID: 20188
		private Table __p;
	}
}
