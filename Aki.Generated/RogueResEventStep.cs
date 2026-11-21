using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020010EC RID: 4332
	public struct RogueResEventStep : IFlatbufferObject
	{
		// Token: 0x170030CB RID: 12491
		// (get) Token: 0x0600C8B5 RID: 51381 RVA: 0x0030884C File Offset: 0x00306A4C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600C8B6 RID: 51382 RVA: 0x00308859 File Offset: 0x00306A59
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600C8B7 RID: 51383 RVA: 0x00308860 File Offset: 0x00306A60
		public static RogueResEventStep GetRootAsRogueResEventStep(ByteBuffer _bb)
		{
			return RogueResEventStep.GetRootAsRogueResEventStep(_bb, default(RogueResEventStep));
		}

		// Token: 0x0600C8B8 RID: 51384 RVA: 0x0030887C File Offset: 0x00306A7C
		public static RogueResEventStep GetRootAsRogueResEventStep(ByteBuffer _bb, RogueResEventStep obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600C8B9 RID: 51385 RVA: 0x00308899 File Offset: 0x00306A99
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600C8BA RID: 51386 RVA: 0x003088A8 File Offset: 0x00306AA8
		public RogueResEventStep __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170030CC RID: 12492
		// (get) Token: 0x0600C8BB RID: 51387 RVA: 0x003088B8 File Offset: 0x00306AB8
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

		// Token: 0x170030CD RID: 12493
		// (get) Token: 0x0600C8BC RID: 51388 RVA: 0x003088F4 File Offset: 0x00306AF4
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

		// Token: 0x170030CE RID: 12494
		// (get) Token: 0x0600C8BD RID: 51389 RVA: 0x00308930 File Offset: 0x00306B30
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

		// Token: 0x0600C8BE RID: 51390 RVA: 0x00308967 File Offset: 0x00306B67
		public Span<byte> GetTitleKeyBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600C8BF RID: 51391 RVA: 0x00308976 File Offset: 0x00306B76
		public byte[] GetTitleKeyArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x170030CF RID: 12495
		// (get) Token: 0x0600C8C0 RID: 51392 RVA: 0x00308990 File Offset: 0x00306B90
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

		// Token: 0x0600C8C1 RID: 51393 RVA: 0x003089C8 File Offset: 0x00306BC8
		public Span<byte> GetTagColorBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600C8C2 RID: 51394 RVA: 0x003089D8 File Offset: 0x00306BD8
		public byte[] GetTagColorArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x170030D0 RID: 12496
		// (get) Token: 0x0600C8C3 RID: 51395 RVA: 0x003089F0 File Offset: 0x00306BF0
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

		// Token: 0x0600C8C4 RID: 51396 RVA: 0x00308A28 File Offset: 0x00306C28
		public Span<byte> GetTextKeyBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600C8C5 RID: 51397 RVA: 0x00308A38 File Offset: 0x00306C38
		public byte[] GetTextKeyArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x170030D1 RID: 12497
		// (get) Token: 0x0600C8C6 RID: 51398 RVA: 0x00308A50 File Offset: 0x00306C50
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

		// Token: 0x0600C8C7 RID: 51399 RVA: 0x00308A88 File Offset: 0x00306C88
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600C8C8 RID: 51400 RVA: 0x00308A98 File Offset: 0x00306C98
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x170030D2 RID: 12498
		// (get) Token: 0x0600C8C9 RID: 51401 RVA: 0x00308AB0 File Offset: 0x00306CB0
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

		// Token: 0x170030D3 RID: 12499
		// (get) Token: 0x0600C8CA RID: 51402 RVA: 0x00308AF0 File Offset: 0x00306CF0
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

		// Token: 0x0600C8CB RID: 51403 RVA: 0x00308B28 File Offset: 0x00306D28
		public Span<byte> GetProcessTextBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0600C8CC RID: 51404 RVA: 0x00308B38 File Offset: 0x00306D38
		public byte[] GetProcessTextArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x040056D4 RID: 22228
		private Table __p;
	}
}
