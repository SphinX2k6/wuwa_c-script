using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200109A RID: 4250
	public struct RegressRecommend : IFlatbufferObject
	{
		// Token: 0x17002E3B RID: 11835
		// (get) Token: 0x0600C172 RID: 49522 RVA: 0x002F8D39 File Offset: 0x002F6F39
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600C173 RID: 49523 RVA: 0x002F8D46 File Offset: 0x002F6F46
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600C174 RID: 49524 RVA: 0x002F8D50 File Offset: 0x002F6F50
		public static RegressRecommend GetRootAsRegressRecommend(ByteBuffer _bb)
		{
			return RegressRecommend.GetRootAsRegressRecommend(_bb, default(RegressRecommend));
		}

		// Token: 0x0600C175 RID: 49525 RVA: 0x002F8D6C File Offset: 0x002F6F6C
		public static RegressRecommend GetRootAsRegressRecommend(ByteBuffer _bb, RegressRecommend obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600C176 RID: 49526 RVA: 0x002F8D89 File Offset: 0x002F6F89
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600C177 RID: 49527 RVA: 0x002F8D98 File Offset: 0x002F6F98
		public RegressRecommend __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002E3C RID: 11836
		// (get) Token: 0x0600C178 RID: 49528 RVA: 0x002F8DA8 File Offset: 0x002F6FA8
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

		// Token: 0x17002E3D RID: 11837
		// (get) Token: 0x0600C179 RID: 49529 RVA: 0x002F8DE4 File Offset: 0x002F6FE4
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

		// Token: 0x17002E3E RID: 11838
		// (get) Token: 0x0600C17A RID: 49530 RVA: 0x002F8E20 File Offset: 0x002F7020
		public int ActivityGroup
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

		// Token: 0x17002E3F RID: 11839
		// (get) Token: 0x0600C17B RID: 49531 RVA: 0x002F8E5C File Offset: 0x002F705C
		public int Sort
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

		// Token: 0x17002E40 RID: 11840
		// (get) Token: 0x0600C17C RID: 49532 RVA: 0x002F8E9C File Offset: 0x002F709C
		public string Icon
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

		// Token: 0x0600C17D RID: 49533 RVA: 0x002F8ED4 File Offset: 0x002F70D4
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600C17E RID: 49534 RVA: 0x002F8EE4 File Offset: 0x002F70E4
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17002E41 RID: 11841
		// (get) Token: 0x0600C17F RID: 49535 RVA: 0x002F8EFC File Offset: 0x002F70FC
		public string Title
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600C180 RID: 49536 RVA: 0x002F8F34 File Offset: 0x002F7134
		public Span<byte> GetTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600C181 RID: 49537 RVA: 0x002F8F44 File Offset: 0x002F7144
		public byte[] GetTitleArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17002E42 RID: 11842
		// (get) Token: 0x0600C182 RID: 49538 RVA: 0x002F8F5C File Offset: 0x002F715C
		public string TagIcon
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600C183 RID: 49539 RVA: 0x002F8F94 File Offset: 0x002F7194
		public Span<byte> GetTagIconBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600C184 RID: 49540 RVA: 0x002F8FA4 File Offset: 0x002F71A4
		public byte[] GetTagIconArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x17002E43 RID: 11843
		// (get) Token: 0x0600C185 RID: 49541 RVA: 0x002F8FBC File Offset: 0x002F71BC
		public int ShowReward
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17002E44 RID: 11844
		// (get) Token: 0x0600C186 RID: 49542 RVA: 0x002F8FFC File Offset: 0x002F71FC
		public int JumpParam
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x04005673 RID: 22131
		private Table __p;
	}
}
