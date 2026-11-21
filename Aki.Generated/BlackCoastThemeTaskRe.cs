using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C18 RID: 3096
	public struct BlackCoastThemeTaskRe : IFlatbufferObject
	{
		// Token: 0x1700058A RID: 1418
		// (get) Token: 0x06005363 RID: 21347 RVA: 0x002049FC File Offset: 0x00202BFC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06005364 RID: 21348 RVA: 0x00204A09 File Offset: 0x00202C09
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06005365 RID: 21349 RVA: 0x00204A10 File Offset: 0x00202C10
		public static BlackCoastThemeTaskRe GetRootAsBlackCoastThemeTaskRe(ByteBuffer _bb)
		{
			return BlackCoastThemeTaskRe.GetRootAsBlackCoastThemeTaskRe(_bb, default(BlackCoastThemeTaskRe));
		}

		// Token: 0x06005366 RID: 21350 RVA: 0x00204A2C File Offset: 0x00202C2C
		public static BlackCoastThemeTaskRe GetRootAsBlackCoastThemeTaskRe(ByteBuffer _bb, BlackCoastThemeTaskRe obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06005367 RID: 21351 RVA: 0x00204A49 File Offset: 0x00202C49
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06005368 RID: 21352 RVA: 0x00204A58 File Offset: 0x00202C58
		public BlackCoastThemeTaskRe __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700058B RID: 1419
		// (get) Token: 0x06005369 RID: 21353 RVA: 0x00204A68 File Offset: 0x00202C68
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

		// Token: 0x1700058C RID: 1420
		// (get) Token: 0x0600536A RID: 21354 RVA: 0x00204AA4 File Offset: 0x00202CA4
		public int StageId
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

		// Token: 0x1700058D RID: 1421
		// (get) Token: 0x0600536B RID: 21355 RVA: 0x00204AE0 File Offset: 0x00202CE0
		public string TaskName
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600536C RID: 21356 RVA: 0x00204B17 File Offset: 0x00202D17
		public Span<byte> GetTaskNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600536D RID: 21357 RVA: 0x00204B26 File Offset: 0x00202D26
		public byte[] GetTaskNameArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x1700058E RID: 1422
		// (get) Token: 0x0600536E RID: 21358 RVA: 0x00204B40 File Offset: 0x00202D40
		public int SortId
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

		// Token: 0x1700058F RID: 1423
		// (get) Token: 0x0600536F RID: 21359 RVA: 0x00204B80 File Offset: 0x00202D80
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

		// Token: 0x17000590 RID: 1424
		// (get) Token: 0x06005370 RID: 21360 RVA: 0x00204BC0 File Offset: 0x00202DC0
		public int JumpId
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

		// Token: 0x04005113 RID: 20755
		private Table __p;
	}
}
