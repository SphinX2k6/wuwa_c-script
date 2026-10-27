using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020011A7 RID: 4519
	public struct WorldProgressCurve : IFlatbufferObject
	{
		// Token: 0x17003E7A RID: 15994
		// (get) Token: 0x0600E94D RID: 59725 RVA: 0x00345D68 File Offset: 0x00343F68
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600E94E RID: 59726 RVA: 0x00345D75 File Offset: 0x00343F75
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600E94F RID: 59727 RVA: 0x00345D7C File Offset: 0x00343F7C
		public static WorldProgressCurve GetRootAsWorldProgressCurve(ByteBuffer _bb)
		{
			return WorldProgressCurve.GetRootAsWorldProgressCurve(_bb, default(WorldProgressCurve));
		}

		// Token: 0x0600E950 RID: 59728 RVA: 0x00345D98 File Offset: 0x00343F98
		public static WorldProgressCurve GetRootAsWorldProgressCurve(ByteBuffer _bb, WorldProgressCurve obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600E951 RID: 59729 RVA: 0x00345DB5 File Offset: 0x00343FB5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600E952 RID: 59730 RVA: 0x00345DC4 File Offset: 0x00343FC4
		public WorldProgressCurve __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003E7B RID: 15995
		// (get) Token: 0x0600E953 RID: 59731 RVA: 0x00345DD4 File Offset: 0x00343FD4
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

		// Token: 0x17003E7C RID: 15996
		// (get) Token: 0x0600E954 RID: 59732 RVA: 0x00345E10 File Offset: 0x00344010
		public int OpenDay
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

		// Token: 0x17003E7D RID: 15997
		// (get) Token: 0x0600E955 RID: 59733 RVA: 0x00345E4C File Offset: 0x0034404C
		public int PersonalScore
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

		// Token: 0x17003E7E RID: 15998
		// (get) Token: 0x0600E956 RID: 59734 RVA: 0x00345E88 File Offset: 0x00344088
		public int Percent
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17003E7F RID: 15999
		// (get) Token: 0x0600E957 RID: 59735 RVA: 0x00345EC8 File Offset: 0x003440C8
		public int DropId
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

		// Token: 0x17003E80 RID: 16000
		// (get) Token: 0x0600E958 RID: 59736 RVA: 0x00345F08 File Offset: 0x00344108
		public int MotorPreviewId
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

		// Token: 0x040052F4 RID: 21236
		private Table __p;
	}
}
