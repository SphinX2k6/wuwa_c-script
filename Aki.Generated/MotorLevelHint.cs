using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E58 RID: 3672
	public struct MotorLevelHint : IFlatbufferObject
	{
		// Token: 0x1700218F RID: 8591
		// (get) Token: 0x06009A6D RID: 39533 RVA: 0x00293788 File Offset: 0x00291988
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06009A6E RID: 39534 RVA: 0x00293795 File Offset: 0x00291995
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06009A6F RID: 39535 RVA: 0x0029379C File Offset: 0x0029199C
		public static MotorLevelHint GetRootAsMotorLevelHint(ByteBuffer _bb)
		{
			return MotorLevelHint.GetRootAsMotorLevelHint(_bb, default(MotorLevelHint));
		}

		// Token: 0x06009A70 RID: 39536 RVA: 0x002937B8 File Offset: 0x002919B8
		public static MotorLevelHint GetRootAsMotorLevelHint(ByteBuffer _bb, MotorLevelHint obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06009A71 RID: 39537 RVA: 0x002937D5 File Offset: 0x002919D5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06009A72 RID: 39538 RVA: 0x002937E4 File Offset: 0x002919E4
		public MotorLevelHint __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002190 RID: 8592
		// (get) Token: 0x06009A73 RID: 39539 RVA: 0x002937F4 File Offset: 0x002919F4
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

		// Token: 0x17002191 RID: 8593
		// (get) Token: 0x06009A74 RID: 39540 RVA: 0x00293830 File Offset: 0x00291A30
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

		// Token: 0x06009A75 RID: 39541 RVA: 0x0029386C File Offset: 0x00291A6C
		public int JumpTaskList(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002192 RID: 8594
		// (get) Token: 0x06009A76 RID: 39542 RVA: 0x002938AC File Offset: 0x00291AAC
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

		// Token: 0x06009A77 RID: 39543 RVA: 0x002938D7 File Offset: 0x00291AD7
		public Span<int> GetJumpTaskListBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x06009A78 RID: 39544 RVA: 0x002938E6 File Offset: 0x00291AE6
		public int[] GetJumpTaskListArray()
		{
			return this.__p.__vector_as_array<int>(8) ?? Array.Empty<int>();
		}

		// Token: 0x17002193 RID: 8595
		// (get) Token: 0x06009A79 RID: 39545 RVA: 0x00293900 File Offset: 0x00291B00
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

		// Token: 0x17002194 RID: 8596
		// (get) Token: 0x06009A7A RID: 39546 RVA: 0x00293940 File Offset: 0x00291B40
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

		// Token: 0x06009A7B RID: 39547 RVA: 0x00293978 File Offset: 0x00291B78
		public Span<byte> GetTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06009A7C RID: 39548 RVA: 0x00293988 File Offset: 0x00291B88
		public byte[] GetTitleArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x06009A7D RID: 39549 RVA: 0x002939A0 File Offset: 0x00291BA0
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用JumpTaskListIter()或GetJumpTaskListBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] JumpTaskList()
		{
			MotorLevelHint motorLevelHint = this;
			return motorLevelHint.GetJumpTaskListArray() ?? Array.Empty<int>();
		}

		// Token: 0x06009A7E RID: 39550 RVA: 0x002939C4 File Offset: 0x00291BC4
		[NullableContext(1)]
		public readonly IEnumerable<int> JumpTaskListIter()
		{
			MotorLevelHint.<JumpTaskListIter>d__24 <JumpTaskListIter>d__ = new MotorLevelHint.<JumpTaskListIter>d__24(-2);
			<JumpTaskListIter>d__.<>3__<>4__this = this;
			return <JumpTaskListIter>d__;
		}

		// Token: 0x04004F01 RID: 20225
		private Table __p;
	}
}
