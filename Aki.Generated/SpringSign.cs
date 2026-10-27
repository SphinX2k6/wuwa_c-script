using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020010F1 RID: 4337
	public struct SpringSign : IFlatbufferObject
	{
		// Token: 0x17003865 RID: 14437
		// (get) Token: 0x0600D95A RID: 55642 RVA: 0x003213FC File Offset: 0x0031F5FC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600D95B RID: 55643 RVA: 0x00321409 File Offset: 0x0031F609
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600D95C RID: 55644 RVA: 0x00321410 File Offset: 0x0031F610
		public static SpringSign GetRootAsSpringSign(ByteBuffer _bb)
		{
			return SpringSign.GetRootAsSpringSign(_bb, default(SpringSign));
		}

		// Token: 0x0600D95D RID: 55645 RVA: 0x0032142C File Offset: 0x0031F62C
		public static SpringSign GetRootAsSpringSign(ByteBuffer _bb, SpringSign obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600D95E RID: 55646 RVA: 0x00321449 File Offset: 0x0031F649
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600D95F RID: 55647 RVA: 0x00321458 File Offset: 0x0031F658
		public SpringSign __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003866 RID: 14438
		// (get) Token: 0x0600D960 RID: 55648 RVA: 0x00321468 File Offset: 0x0031F668
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

		// Token: 0x17003867 RID: 14439
		// (get) Token: 0x0600D961 RID: 55649 RVA: 0x003214A4 File Offset: 0x0031F6A4
		public int ActivityId
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

		// Token: 0x17003868 RID: 14440
		// (get) Token: 0x0600D962 RID: 55650 RVA: 0x003214E0 File Offset: 0x0031F6E0
		public int ResourceTypeId
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

		// Token: 0x04005225 RID: 21029
		private Table __p;
	}
}
