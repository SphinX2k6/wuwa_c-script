using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F3D RID: 3901
	public struct MotorLevelHint : IFlatbufferObject
	{
		// Token: 0x170021F4 RID: 8692
		// (get) Token: 0x0600A08D RID: 41101 RVA: 0x002B11C8 File Offset: 0x002AF3C8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600A08E RID: 41102 RVA: 0x002B11D5 File Offset: 0x002AF3D5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600A08F RID: 41103 RVA: 0x002B11DC File Offset: 0x002AF3DC
		public static MotorLevelHint GetRootAsMotorLevelHint(ByteBuffer _bb)
		{
			return MotorLevelHint.GetRootAsMotorLevelHint(_bb, default(MotorLevelHint));
		}

		// Token: 0x0600A090 RID: 41104 RVA: 0x002B11F8 File Offset: 0x002AF3F8
		public static MotorLevelHint GetRootAsMotorLevelHint(ByteBuffer _bb, MotorLevelHint obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600A091 RID: 41105 RVA: 0x002B1215 File Offset: 0x002AF415
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600A092 RID: 41106 RVA: 0x002B1224 File Offset: 0x002AF424
		public MotorLevelHint __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170021F5 RID: 8693
		// (get) Token: 0x0600A093 RID: 41107 RVA: 0x002B1234 File Offset: 0x002AF434
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

		// Token: 0x170021F6 RID: 8694
		// (get) Token: 0x0600A094 RID: 41108 RVA: 0x002B1270 File Offset: 0x002AF470
		public int Type
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

		// Token: 0x0600A095 RID: 41109 RVA: 0x002B12AC File Offset: 0x002AF4AC
		public int JumpTaskList(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170021F7 RID: 8695
		// (get) Token: 0x0600A096 RID: 41110 RVA: 0x002B12EC File Offset: 0x002AF4EC
		public int JumpTaskListLength
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600A097 RID: 41111 RVA: 0x002B1317 File Offset: 0x002AF517
		public Span<int> GetJumpTaskListBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x0600A098 RID: 41112 RVA: 0x002B1326 File Offset: 0x002AF526
		public int[] GetJumpTaskListArray()
		{
			return this.__p.__vector_as_array<int>(8) ?? Array.Empty<int>();
		}

		// Token: 0x170021F8 RID: 8696
		// (get) Token: 0x0600A099 RID: 41113 RVA: 0x002B1340 File Offset: 0x002AF540
		public int AccessId
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

		// Token: 0x170021F9 RID: 8697
		// (get) Token: 0x0600A09A RID: 41114 RVA: 0x002B1380 File Offset: 0x002AF580
		public string Title
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600A09B RID: 41115 RVA: 0x002B13B8 File Offset: 0x002AF5B8
		public Span<byte> GetTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600A09C RID: 41116 RVA: 0x002B13C8 File Offset: 0x002AF5C8
		public byte[] GetTitleArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x0600A09D RID: 41117 RVA: 0x002B13E0 File Offset: 0x002AF5E0
		[NullableContext(1)]
		public int[] JumpTaskList()
		{
			return this.GetJumpTaskListArray();
		}

		// Token: 0x0600A09E RID: 41118 RVA: 0x002B13E8 File Offset: 0x002AF5E8
		[NullableContext(1)]
		public IEnumerable<int> JumpTaskListIter()
		{
			MotorLevelHint.<JumpTaskListIter>d__24 <JumpTaskListIter>d__ = new MotorLevelHint.<JumpTaskListIter>d__24(-2);
			<JumpTaskListIter>d__.<>3__<>4__this = this;
			return <JumpTaskListIter>d__;
		}

		// Token: 0x040054E6 RID: 21734
		private Table __p;
	}
}
