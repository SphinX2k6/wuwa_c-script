using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020010F0 RID: 4336
	public struct RogueResGridEvent : IFlatbufferObject
	{
		// Token: 0x170030E9 RID: 12521
		// (get) Token: 0x0600C926 RID: 51494 RVA: 0x003095C0 File Offset: 0x003077C0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600C927 RID: 51495 RVA: 0x003095CD File Offset: 0x003077CD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600C928 RID: 51496 RVA: 0x003095D4 File Offset: 0x003077D4
		public static RogueResGridEvent GetRootAsRogueResGridEvent(ByteBuffer _bb)
		{
			return RogueResGridEvent.GetRootAsRogueResGridEvent(_bb, default(RogueResGridEvent));
		}

		// Token: 0x0600C929 RID: 51497 RVA: 0x003095F0 File Offset: 0x003077F0
		public static RogueResGridEvent GetRootAsRogueResGridEvent(ByteBuffer _bb, RogueResGridEvent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600C92A RID: 51498 RVA: 0x0030960D File Offset: 0x0030780D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600C92B RID: 51499 RVA: 0x0030961C File Offset: 0x0030781C
		public RogueResGridEvent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170030EA RID: 12522
		// (get) Token: 0x0600C92C RID: 51500 RVA: 0x0030962C File Offset: 0x0030782C
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

		// Token: 0x170030EB RID: 12523
		// (get) Token: 0x0600C92D RID: 51501 RVA: 0x00309668 File Offset: 0x00307868
		public int Plot
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

		// Token: 0x170030EC RID: 12524
		// (get) Token: 0x0600C92E RID: 51502 RVA: 0x003096A4 File Offset: 0x003078A4
		public int ProgressType
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

		// Token: 0x170030ED RID: 12525
		// (get) Token: 0x0600C92F RID: 51503 RVA: 0x003096E0 File Offset: 0x003078E0
		public string CondText
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

		// Token: 0x0600C930 RID: 51504 RVA: 0x00309718 File Offset: 0x00307918
		public Span<byte> GetCondTextBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600C931 RID: 51505 RVA: 0x00309728 File Offset: 0x00307928
		public byte[] GetCondTextArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x170030EE RID: 12526
		// (get) Token: 0x0600C932 RID: 51506 RVA: 0x00309740 File Offset: 0x00307940
		public int ShowType
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

		// Token: 0x170030EF RID: 12527
		// (get) Token: 0x0600C933 RID: 51507 RVA: 0x00309780 File Offset: 0x00307980
		public string Fx
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

		// Token: 0x0600C934 RID: 51508 RVA: 0x003097B8 File Offset: 0x003079B8
		public Span<byte> GetFxBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600C935 RID: 51509 RVA: 0x003097C8 File Offset: 0x003079C8
		public byte[] GetFxArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x170030F0 RID: 12528
		// (get) Token: 0x0600C936 RID: 51510 RVA: 0x003097E0 File Offset: 0x003079E0
		public int Star
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

		// Token: 0x170030F1 RID: 12529
		// (get) Token: 0x0600C937 RID: 51511 RVA: 0x00309820 File Offset: 0x00307A20
		public string Icon
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

		// Token: 0x0600C938 RID: 51512 RVA: 0x00309858 File Offset: 0x00307A58
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0600C939 RID: 51513 RVA: 0x00309868 File Offset: 0x00307A68
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x170030F2 RID: 12530
		// (get) Token: 0x0600C93A RID: 51514 RVA: 0x00309880 File Offset: 0x00307A80
		public string Title
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600C93B RID: 51515 RVA: 0x003098B8 File Offset: 0x00307AB8
		public Span<byte> GetTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x0600C93C RID: 51516 RVA: 0x003098C8 File Offset: 0x00307AC8
		public byte[] GetTitleArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x170030F3 RID: 12531
		// (get) Token: 0x0600C93D RID: 51517 RVA: 0x003098E0 File Offset: 0x00307AE0
		public string Desc
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600C93E RID: 51518 RVA: 0x00309918 File Offset: 0x00307B18
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x0600C93F RID: 51519 RVA: 0x00309928 File Offset: 0x00307B28
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x170030F4 RID: 12532
		// (get) Token: 0x0600C940 RID: 51520 RVA: 0x00309940 File Offset: 0x00307B40
		public int EventType
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x040056D8 RID: 22232
		private Table __p;
	}
}
