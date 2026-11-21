using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200109F RID: 4255
	public struct ReignsCard : IFlatbufferObject
	{
		// Token: 0x17002E5D RID: 11869
		// (get) Token: 0x0600C1BE RID: 49598 RVA: 0x002F978A File Offset: 0x002F798A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600C1BF RID: 49599 RVA: 0x002F9797 File Offset: 0x002F7997
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600C1C0 RID: 49600 RVA: 0x002F97A0 File Offset: 0x002F79A0
		public static ReignsCard GetRootAsReignsCard(ByteBuffer _bb)
		{
			return ReignsCard.GetRootAsReignsCard(_bb, default(ReignsCard));
		}

		// Token: 0x0600C1C1 RID: 49601 RVA: 0x002F97BC File Offset: 0x002F79BC
		public static ReignsCard GetRootAsReignsCard(ByteBuffer _bb, ReignsCard obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600C1C2 RID: 49602 RVA: 0x002F97D9 File Offset: 0x002F79D9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600C1C3 RID: 49603 RVA: 0x002F97E8 File Offset: 0x002F79E8
		public ReignsCard __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002E5E RID: 11870
		// (get) Token: 0x0600C1C4 RID: 49604 RVA: 0x002F97F8 File Offset: 0x002F79F8
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

		// Token: 0x17002E5F RID: 11871
		// (get) Token: 0x0600C1C5 RID: 49605 RVA: 0x002F9834 File Offset: 0x002F7A34
		public string CardType
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

		// Token: 0x0600C1C6 RID: 49606 RVA: 0x002F986B File Offset: 0x002F7A6B
		public Span<byte> GetCardTypeBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600C1C7 RID: 49607 RVA: 0x002F987A File Offset: 0x002F7A7A
		public byte[] GetCardTypeArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17002E60 RID: 11872
		// (get) Token: 0x0600C1C8 RID: 49608 RVA: 0x002F9894 File Offset: 0x002F7A94
		public string CardBackground
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

		// Token: 0x0600C1C9 RID: 49609 RVA: 0x002F98CB File Offset: 0x002F7ACB
		public Span<byte> GetCardBackgroundBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600C1CA RID: 49610 RVA: 0x002F98DA File Offset: 0x002F7ADA
		public byte[] GetCardBackgroundArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17002E61 RID: 11873
		// (get) Token: 0x0600C1CB RID: 49611 RVA: 0x002F98F4 File Offset: 0x002F7AF4
		public string CardIcon
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

		// Token: 0x0600C1CC RID: 49612 RVA: 0x002F992C File Offset: 0x002F7B2C
		public Span<byte> GetCardIconBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600C1CD RID: 49613 RVA: 0x002F993C File Offset: 0x002F7B3C
		public byte[] GetCardIconArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17002E62 RID: 11874
		// (get) Token: 0x0600C1CE RID: 49614 RVA: 0x002F9954 File Offset: 0x002F7B54
		public string CardTitle
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

		// Token: 0x0600C1CF RID: 49615 RVA: 0x002F998C File Offset: 0x002F7B8C
		public Span<byte> GetCardTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600C1D0 RID: 49616 RVA: 0x002F999C File Offset: 0x002F7B9C
		public byte[] GetCardTitleArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17002E63 RID: 11875
		// (get) Token: 0x0600C1D1 RID: 49617 RVA: 0x002F99B4 File Offset: 0x002F7BB4
		public string CardDescription
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

		// Token: 0x0600C1D2 RID: 49618 RVA: 0x002F99EC File Offset: 0x002F7BEC
		public Span<byte> GetCardDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600C1D3 RID: 49619 RVA: 0x002F99FC File Offset: 0x002F7BFC
		public byte[] GetCardDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17002E64 RID: 11876
		// (get) Token: 0x0600C1D4 RID: 49620 RVA: 0x002F9A14 File Offset: 0x002F7C14
		public string CardHeader
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

		// Token: 0x0600C1D5 RID: 49621 RVA: 0x002F9A4C File Offset: 0x002F7C4C
		public Span<byte> GetCardHeaderBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600C1D6 RID: 49622 RVA: 0x002F9A5C File Offset: 0x002F7C5C
		public byte[] GetCardHeaderArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x0600C1D7 RID: 49623 RVA: 0x002F9A74 File Offset: 0x002F7C74
		public string StaticImageFlow(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002E65 RID: 11877
		// (get) Token: 0x0600C1D8 RID: 49624 RVA: 0x002F9AB0 File Offset: 0x002F7CB0
		public int StaticImageFlowLength
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600C1D9 RID: 49625 RVA: 0x002F9ADC File Offset: 0x002F7CDC
		[NullableContext(1)]
		public string[] StaticImageFlow()
		{
			return this.StaticImageFlowIter().ToArray<string>();
		}

		// Token: 0x0600C1DA RID: 49626 RVA: 0x002F9AE9 File Offset: 0x002F7CE9
		[NullableContext(1)]
		public IEnumerable<string> StaticImageFlowIter()
		{
			ReignsCard.<StaticImageFlowIter>d__38 <StaticImageFlowIter>d__ = new ReignsCard.<StaticImageFlowIter>d__38(-2);
			<StaticImageFlowIter>d__.<>3__<>4__this = this;
			return <StaticImageFlowIter>d__;
		}

		// Token: 0x04005678 RID: 22136
		private Table __p;
	}
}
