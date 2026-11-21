using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200103D RID: 4157
	public struct PreheatVote : IFlatbufferObject
	{
		// Token: 0x17002B45 RID: 11077
		// (get) Token: 0x0600B93B RID: 47419 RVA: 0x002E7514 File Offset: 0x002E5714
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600B93C RID: 47420 RVA: 0x002E7521 File Offset: 0x002E5721
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600B93D RID: 47421 RVA: 0x002E7528 File Offset: 0x002E5728
		public static PreheatVote GetRootAsPreheatVote(ByteBuffer _bb)
		{
			return PreheatVote.GetRootAsPreheatVote(_bb, default(PreheatVote));
		}

		// Token: 0x0600B93E RID: 47422 RVA: 0x002E7544 File Offset: 0x002E5744
		public static PreheatVote GetRootAsPreheatVote(ByteBuffer _bb, PreheatVote obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600B93F RID: 47423 RVA: 0x002E7561 File Offset: 0x002E5761
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600B940 RID: 47424 RVA: 0x002E7570 File Offset: 0x002E5770
		public PreheatVote __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002B46 RID: 11078
		// (get) Token: 0x0600B941 RID: 47425 RVA: 0x002E7580 File Offset: 0x002E5780
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

		// Token: 0x17002B47 RID: 11079
		// (get) Token: 0x0600B942 RID: 47426 RVA: 0x002E75BC File Offset: 0x002E57BC
		public string Title
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600B943 RID: 47427 RVA: 0x002E75F3 File Offset: 0x002E57F3
		public Span<byte> GetTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600B944 RID: 47428 RVA: 0x002E7602 File Offset: 0x002E5802
		public byte[] GetTitleArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17002B48 RID: 11080
		// (get) Token: 0x0600B945 RID: 47429 RVA: 0x002E761C File Offset: 0x002E581C
		public string Content
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

		// Token: 0x0600B946 RID: 47430 RVA: 0x002E7653 File Offset: 0x002E5853
		public Span<byte> GetContentBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600B947 RID: 47431 RVA: 0x002E7662 File Offset: 0x002E5862
		public byte[] GetContentArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17002B49 RID: 11081
		// (get) Token: 0x0600B948 RID: 47432 RVA: 0x002E767C File Offset: 0x002E587C
		public string Option1
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

		// Token: 0x0600B949 RID: 47433 RVA: 0x002E76B4 File Offset: 0x002E58B4
		public Span<byte> GetOption1Bytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600B94A RID: 47434 RVA: 0x002E76C4 File Offset: 0x002E58C4
		public byte[] GetOption1Array()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17002B4A RID: 11082
		// (get) Token: 0x0600B94B RID: 47435 RVA: 0x002E76DC File Offset: 0x002E58DC
		public string Option2
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

		// Token: 0x0600B94C RID: 47436 RVA: 0x002E7714 File Offset: 0x002E5914
		public Span<byte> GetOption2Bytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600B94D RID: 47437 RVA: 0x002E7724 File Offset: 0x002E5924
		public byte[] GetOption2Array()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17002B4B RID: 11083
		// (get) Token: 0x0600B94E RID: 47438 RVA: 0x002E773C File Offset: 0x002E593C
		public string NpcIconPath
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

		// Token: 0x0600B94F RID: 47439 RVA: 0x002E7774 File Offset: 0x002E5974
		public Span<byte> GetNpcIconPathBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600B950 RID: 47440 RVA: 0x002E7784 File Offset: 0x002E5984
		public byte[] GetNpcIconPathArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17002B4C RID: 11084
		// (get) Token: 0x0600B951 RID: 47441 RVA: 0x002E779C File Offset: 0x002E599C
		public string NpcContent
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

		// Token: 0x0600B952 RID: 47442 RVA: 0x002E77D4 File Offset: 0x002E59D4
		public Span<byte> GetNpcContentBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600B953 RID: 47443 RVA: 0x002E77E4 File Offset: 0x002E59E4
		public byte[] GetNpcContentArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x17002B4D RID: 11085
		// (get) Token: 0x0600B954 RID: 47444 RVA: 0x002E77FC File Offset: 0x002E59FC
		public string OptionContent1
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

		// Token: 0x0600B955 RID: 47445 RVA: 0x002E7834 File Offset: 0x002E5A34
		public Span<byte> GetOptionContent1Bytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0600B956 RID: 47446 RVA: 0x002E7844 File Offset: 0x002E5A44
		public byte[] GetOptionContent1Array()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x17002B4E RID: 11086
		// (get) Token: 0x0600B957 RID: 47447 RVA: 0x002E785C File Offset: 0x002E5A5C
		public string OptionContent2
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

		// Token: 0x0600B958 RID: 47448 RVA: 0x002E7894 File Offset: 0x002E5A94
		public Span<byte> GetOptionContent2Bytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x0600B959 RID: 47449 RVA: 0x002E78A4 File Offset: 0x002E5AA4
		public byte[] GetOptionContent2Array()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x17002B4F RID: 11087
		// (get) Token: 0x0600B95A RID: 47450 RVA: 0x002E78BC File Offset: 0x002E5ABC
		public string OptionTheme1
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

		// Token: 0x0600B95B RID: 47451 RVA: 0x002E78F4 File Offset: 0x002E5AF4
		public Span<byte> GetOptionTheme1Bytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x0600B95C RID: 47452 RVA: 0x002E7904 File Offset: 0x002E5B04
		public byte[] GetOptionTheme1Array()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x17002B50 RID: 11088
		// (get) Token: 0x0600B95D RID: 47453 RVA: 0x002E791C File Offset: 0x002E5B1C
		public string OptionTheme2
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600B95E RID: 47454 RVA: 0x002E7954 File Offset: 0x002E5B54
		public Span<byte> GetOptionTheme2Bytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x0600B95F RID: 47455 RVA: 0x002E7964 File Offset: 0x002E5B64
		public byte[] GetOptionTheme2Array()
		{
			return this.__p.__vector_as_array<byte>(24) ?? Array.Empty<byte>();
		}

		// Token: 0x0400560A RID: 22026
		private Table __p;
	}
}
