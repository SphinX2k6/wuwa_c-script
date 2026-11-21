using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F9F RID: 3999
	public struct PersonProgressCurve : IFlatbufferObject
	{
		// Token: 0x1700255F RID: 9567
		// (get) Token: 0x0600A9EE RID: 43502 RVA: 0x002C547C File Offset: 0x002C367C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600A9EF RID: 43503 RVA: 0x002C5489 File Offset: 0x002C3689
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600A9F0 RID: 43504 RVA: 0x002C5490 File Offset: 0x002C3690
		public static PersonProgressCurve GetRootAsPersonProgressCurve(ByteBuffer _bb)
		{
			return PersonProgressCurve.GetRootAsPersonProgressCurve(_bb, default(PersonProgressCurve));
		}

		// Token: 0x0600A9F1 RID: 43505 RVA: 0x002C54AC File Offset: 0x002C36AC
		public static PersonProgressCurve GetRootAsPersonProgressCurve(ByteBuffer _bb, PersonProgressCurve obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600A9F2 RID: 43506 RVA: 0x002C54C9 File Offset: 0x002C36C9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600A9F3 RID: 43507 RVA: 0x002C54D8 File Offset: 0x002C36D8
		public PersonProgressCurve __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002560 RID: 9568
		// (get) Token: 0x0600A9F4 RID: 43508 RVA: 0x002C54E8 File Offset: 0x002C36E8
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

		// Token: 0x17002561 RID: 9569
		// (get) Token: 0x0600A9F5 RID: 43509 RVA: 0x002C5524 File Offset: 0x002C3724
		public int Progress
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

		// Token: 0x17002562 RID: 9570
		// (get) Token: 0x0600A9F6 RID: 43510 RVA: 0x002C5560 File Offset: 0x002C3760
		public int DropId
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

		// Token: 0x17002563 RID: 9571
		// (get) Token: 0x0600A9F7 RID: 43511 RVA: 0x002C559C File Offset: 0x002C379C
		public int MotorPreviewId
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

		// Token: 0x17002564 RID: 9572
		// (get) Token: 0x0600A9F8 RID: 43512 RVA: 0x002C55DC File Offset: 0x002C37DC
		public bool ShowEffect
		{
			get
			{
				int num = this.__p.__offset(12);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x04005555 RID: 21845
		private Table __p;
	}
}
