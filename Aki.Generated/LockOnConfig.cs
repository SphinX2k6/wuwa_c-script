using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000DD7 RID: 3543
	public struct LockOnConfig : IFlatbufferObject
	{
		// Token: 0x17001D47 RID: 7495
		// (get) Token: 0x06008F40 RID: 36672 RVA: 0x0027A650 File Offset: 0x00278850
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06008F41 RID: 36673 RVA: 0x0027A65D File Offset: 0x0027885D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06008F42 RID: 36674 RVA: 0x0027A664 File Offset: 0x00278864
		public static LockOnConfig GetRootAsLockOnConfig(ByteBuffer _bb)
		{
			return LockOnConfig.GetRootAsLockOnConfig(_bb, default(LockOnConfig));
		}

		// Token: 0x06008F43 RID: 36675 RVA: 0x0027A680 File Offset: 0x00278880
		public static LockOnConfig GetRootAsLockOnConfig(ByteBuffer _bb, LockOnConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06008F44 RID: 36676 RVA: 0x0027A69D File Offset: 0x0027889D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06008F45 RID: 36677 RVA: 0x0027A6AC File Offset: 0x002788AC
		public LockOnConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001D48 RID: 7496
		// (get) Token: 0x06008F46 RID: 36678 RVA: 0x0027A6BC File Offset: 0x002788BC
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

		// Token: 0x17001D49 RID: 7497
		// (get) Token: 0x06008F47 RID: 36679 RVA: 0x0027A6F8 File Offset: 0x002788F8
		public int Distance
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

		// Token: 0x17001D4A RID: 7498
		// (get) Token: 0x06008F48 RID: 36680 RVA: 0x0027A734 File Offset: 0x00278934
		public int UpDistance
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 300;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001D4B RID: 7499
		// (get) Token: 0x06008F49 RID: 36681 RVA: 0x0027A774 File Offset: 0x00278974
		public int DownDistance
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 800;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001D4C RID: 7500
		// (get) Token: 0x06008F4A RID: 36682 RVA: 0x0027A7B8 File Offset: 0x002789B8
		public int SectorRadius
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001D4D RID: 7501
		// (get) Token: 0x06008F4B RID: 36683 RVA: 0x0027A7F8 File Offset: 0x002789F8
		public int SectorAngle
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001D4E RID: 7502
		// (get) Token: 0x06008F4C RID: 36684 RVA: 0x0027A838 File Offset: 0x00278A38
		public float ToleranceAngle
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 22.5f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x04004E72 RID: 20082
		private Table __p;
	}
}
