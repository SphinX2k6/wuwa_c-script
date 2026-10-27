using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001004 RID: 4100
	public struct RogueResEventStep : IFlatbufferObject
	{
		// Token: 0x17003050 RID: 12368
		// (get) Token: 0x0600C26B RID: 49771 RVA: 0x002EC620 File Offset: 0x002EA820
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600C26C RID: 49772 RVA: 0x002EC62D File Offset: 0x002EA82D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600C26D RID: 49773 RVA: 0x002EC634 File Offset: 0x002EA834
		public static RogueResEventStep GetRootAsRogueResEventStep(ByteBuffer _bb)
		{
			return RogueResEventStep.GetRootAsRogueResEventStep(_bb, default(RogueResEventStep));
		}

		// Token: 0x0600C26E RID: 49774 RVA: 0x002EC650 File Offset: 0x002EA850
		public static RogueResEventStep GetRootAsRogueResEventStep(ByteBuffer _bb, RogueResEventStep obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600C26F RID: 49775 RVA: 0x002EC66D File Offset: 0x002EA86D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600C270 RID: 49776 RVA: 0x002EC67C File Offset: 0x002EA87C
		public RogueResEventStep __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003051 RID: 12369
		// (get) Token: 0x0600C271 RID: 49777 RVA: 0x002EC68C File Offset: 0x002EA88C
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

		// Token: 0x17003052 RID: 12370
		// (get) Token: 0x0600C272 RID: 49778 RVA: 0x002EC6C8 File Offset: 0x002EA8C8
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

		// Token: 0x17003053 RID: 12371
		// (get) Token: 0x0600C273 RID: 49779 RVA: 0x002EC704 File Offset: 0x002EA904
		public string TitleKey
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

		// Token: 0x0600C274 RID: 49780 RVA: 0x002EC73B File Offset: 0x002EA93B
		public Span<byte> GetTitleKeyBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600C275 RID: 49781 RVA: 0x002EC74A File Offset: 0x002EA94A
		public byte[] GetTitleKeyArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17003054 RID: 12372
		// (get) Token: 0x0600C276 RID: 49782 RVA: 0x002EC764 File Offset: 0x002EA964
		public string TagColor
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600C277 RID: 49783 RVA: 0x002EC79C File Offset: 0x002EA99C
		public Span<byte> GetTagColorBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600C278 RID: 49784 RVA: 0x002EC7AC File Offset: 0x002EA9AC
		public byte[] GetTagColorArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17003055 RID: 12373
		// (get) Token: 0x0600C279 RID: 49785 RVA: 0x002EC7C4 File Offset: 0x002EA9C4
		public string TextKey
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

		// Token: 0x0600C27A RID: 49786 RVA: 0x002EC7FC File Offset: 0x002EA9FC
		public Span<byte> GetTextKeyBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600C27B RID: 49787 RVA: 0x002EC80C File Offset: 0x002EAA0C
		public byte[] GetTextKeyArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17003056 RID: 12374
		// (get) Token: 0x0600C27C RID: 49788 RVA: 0x002EC824 File Offset: 0x002EAA24
		public string Icon
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

		// Token: 0x0600C27D RID: 49789 RVA: 0x002EC85C File Offset: 0x002EAA5C
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600C27E RID: 49790 RVA: 0x002EC86C File Offset: 0x002EAA6C
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17003057 RID: 12375
		// (get) Token: 0x0600C27F RID: 49791 RVA: 0x002EC884 File Offset: 0x002EAA84
		public int ProgressType
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17003058 RID: 12376
		// (get) Token: 0x0600C280 RID: 49792 RVA: 0x002EC8C4 File Offset: 0x002EAAC4
		public string ProcessText
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600C281 RID: 49793 RVA: 0x002EC8FC File Offset: 0x002EAAFC
		public Span<byte> GetProcessTextBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0600C282 RID: 49794 RVA: 0x002EC90C File Offset: 0x002EAB0C
		public byte[] GetProcessTextArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x040050EC RID: 20716
		private Table __p;
	}
}
