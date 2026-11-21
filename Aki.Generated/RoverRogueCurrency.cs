using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001170 RID: 4464
	public struct RoverRogueCurrency : IFlatbufferObject
	{
		// Token: 0x17003535 RID: 13621
		// (get) Token: 0x0600D537 RID: 54583 RVA: 0x00324B98 File Offset: 0x00322D98
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600D538 RID: 54584 RVA: 0x00324BA5 File Offset: 0x00322DA5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600D539 RID: 54585 RVA: 0x00324BAC File Offset: 0x00322DAC
		public static RoverRogueCurrency GetRootAsRoverRogueCurrency(ByteBuffer _bb)
		{
			return RoverRogueCurrency.GetRootAsRoverRogueCurrency(_bb, default(RoverRogueCurrency));
		}

		// Token: 0x0600D53A RID: 54586 RVA: 0x00324BC8 File Offset: 0x00322DC8
		public static RoverRogueCurrency GetRootAsRoverRogueCurrency(ByteBuffer _bb, RoverRogueCurrency obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600D53B RID: 54587 RVA: 0x00324BE5 File Offset: 0x00322DE5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600D53C RID: 54588 RVA: 0x00324BF4 File Offset: 0x00322DF4
		public RoverRogueCurrency __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003536 RID: 13622
		// (get) Token: 0x0600D53D RID: 54589 RVA: 0x00324C04 File Offset: 0x00322E04
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

		// Token: 0x17003537 RID: 13623
		// (get) Token: 0x0600D53E RID: 54590 RVA: 0x00324C40 File Offset: 0x00322E40
		public int QualityId
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600D53F RID: 54591 RVA: 0x00324C7C File Offset: 0x00322E7C
		public int ItemAccess(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003538 RID: 13624
		// (get) Token: 0x0600D540 RID: 54592 RVA: 0x00324CBC File Offset: 0x00322EBC
		public int ItemAccessLength
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

		// Token: 0x0600D541 RID: 54593 RVA: 0x00324CE7 File Offset: 0x00322EE7
		public Span<int> GetItemAccessBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x0600D542 RID: 54594 RVA: 0x00324CF6 File Offset: 0x00322EF6
		public int[] GetItemAccessArray()
		{
			return this.__p.__vector_as_array<int>(8) ?? Array.Empty<int>();
		}

		// Token: 0x17003539 RID: 13625
		// (get) Token: 0x0600D543 RID: 54595 RVA: 0x00324D10 File Offset: 0x00322F10
		public string Icon
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

		// Token: 0x0600D544 RID: 54596 RVA: 0x00324D48 File Offset: 0x00322F48
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600D545 RID: 54597 RVA: 0x00324D58 File Offset: 0x00322F58
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x1700353A RID: 13626
		// (get) Token: 0x0600D546 RID: 54598 RVA: 0x00324D70 File Offset: 0x00322F70
		public string IconMiddle
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

		// Token: 0x0600D547 RID: 54599 RVA: 0x00324DA8 File Offset: 0x00322FA8
		public Span<byte> GetIconMiddleBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600D548 RID: 54600 RVA: 0x00324DB8 File Offset: 0x00322FB8
		public byte[] GetIconMiddleArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x1700353B RID: 13627
		// (get) Token: 0x0600D549 RID: 54601 RVA: 0x00324DD0 File Offset: 0x00322FD0
		public string IconSmall
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

		// Token: 0x0600D54A RID: 54602 RVA: 0x00324E08 File Offset: 0x00323008
		public Span<byte> GetIconSmallBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600D54B RID: 54603 RVA: 0x00324E18 File Offset: 0x00323018
		public byte[] GetIconSmallArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x0600D54C RID: 54604 RVA: 0x00324E30 File Offset: 0x00323030
		public int ShowTypes(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700353C RID: 13628
		// (get) Token: 0x0600D54D RID: 54605 RVA: 0x00324E70 File Offset: 0x00323070
		public int ShowTypesLength
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600D54E RID: 54606 RVA: 0x00324E9C File Offset: 0x0032309C
		public Span<int> GetShowTypesBytes()
		{
			return this.__p.__vector_as_span<int>(16, 4);
		}

		// Token: 0x0600D54F RID: 54607 RVA: 0x00324EAC File Offset: 0x003230AC
		public int[] GetShowTypesArray()
		{
			return this.__p.__vector_as_array<int>(16) ?? Array.Empty<int>();
		}

		// Token: 0x1700353D RID: 13629
		// (get) Token: 0x0600D550 RID: 54608 RVA: 0x00324EC4 File Offset: 0x003230C4
		public string Title
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

		// Token: 0x0600D551 RID: 54609 RVA: 0x00324EFC File Offset: 0x003230FC
		public Span<byte> GetTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0600D552 RID: 54610 RVA: 0x00324F0C File Offset: 0x0032310C
		public byte[] GetTitleArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x1700353E RID: 13630
		// (get) Token: 0x0600D553 RID: 54611 RVA: 0x00324F24 File Offset: 0x00323124
		public string AttributesDescription
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

		// Token: 0x0600D554 RID: 54612 RVA: 0x00324F5C File Offset: 0x0032315C
		public Span<byte> GetAttributesDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x0600D555 RID: 54613 RVA: 0x00324F6C File Offset: 0x0032316C
		public byte[] GetAttributesDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x1700353F RID: 13631
		// (get) Token: 0x0600D556 RID: 54614 RVA: 0x00324F84 File Offset: 0x00323184
		public string ObtainedShowDescription
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

		// Token: 0x0600D557 RID: 54615 RVA: 0x00324FBC File Offset: 0x003231BC
		public Span<byte> GetObtainedShowDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x0600D558 RID: 54616 RVA: 0x00324FCC File Offset: 0x003231CC
		public byte[] GetObtainedShowDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x17003540 RID: 13632
		// (get) Token: 0x0600D559 RID: 54617 RVA: 0x00324FE4 File Offset: 0x003231E4
		public string TypeDescription
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

		// Token: 0x0600D55A RID: 54618 RVA: 0x0032501C File Offset: 0x0032321C
		public Span<byte> GetTypeDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x0600D55B RID: 54619 RVA: 0x0032502C File Offset: 0x0032322C
		public byte[] GetTypeDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(24) ?? Array.Empty<byte>();
		}

		// Token: 0x17003541 RID: 13633
		// (get) Token: 0x0600D55C RID: 54620 RVA: 0x00325044 File Offset: 0x00323244
		public string BgDescription
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600D55D RID: 54621 RVA: 0x0032507C File Offset: 0x0032327C
		public Span<byte> GetBgDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(26, 1);
		}

		// Token: 0x0600D55E RID: 54622 RVA: 0x0032508C File Offset: 0x0032328C
		public byte[] GetBgDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(26) ?? Array.Empty<byte>();
		}

		// Token: 0x0600D55F RID: 54623 RVA: 0x003250A4 File Offset: 0x003232A4
		[NullableContext(1)]
		public int[] ItemAccess()
		{
			return this.GetItemAccessArray();
		}

		// Token: 0x0600D560 RID: 54624 RVA: 0x003250AC File Offset: 0x003232AC
		[NullableContext(1)]
		public IEnumerable<int> ItemAccessIter()
		{
			RoverRogueCurrency.<ItemAccessIter>d__55 <ItemAccessIter>d__ = new RoverRogueCurrency.<ItemAccessIter>d__55(-2);
			<ItemAccessIter>d__.<>3__<>4__this = this;
			return <ItemAccessIter>d__;
		}

		// Token: 0x0600D561 RID: 54625 RVA: 0x003250C1 File Offset: 0x003232C1
		[NullableContext(1)]
		public int[] ShowTypes()
		{
			return this.GetShowTypesArray();
		}

		// Token: 0x0600D562 RID: 54626 RVA: 0x003250C9 File Offset: 0x003232C9
		[NullableContext(1)]
		public IEnumerable<int> ShowTypesIter()
		{
			RoverRogueCurrency.<ShowTypesIter>d__57 <ShowTypesIter>d__ = new RoverRogueCurrency.<ShowTypesIter>d__57(-2);
			<ShowTypesIter>d__.<>3__<>4__this = this;
			return <ShowTypesIter>d__;
		}

		// Token: 0x0400577E RID: 22398
		private Table __p;
	}
}
