using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000FA1 RID: 4001
	public struct PhantomBattleBadge : IFlatbufferObject
	{
		// Token: 0x1700258B RID: 9611
		// (get) Token: 0x0600AA58 RID: 43608 RVA: 0x002C68AC File Offset: 0x002C4AAC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600AA59 RID: 43609 RVA: 0x002C68B9 File Offset: 0x002C4AB9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600AA5A RID: 43610 RVA: 0x002C68C0 File Offset: 0x002C4AC0
		public static PhantomBattleBadge GetRootAsPhantomBattleBadge(ByteBuffer _bb)
		{
			return PhantomBattleBadge.GetRootAsPhantomBattleBadge(_bb, default(PhantomBattleBadge));
		}

		// Token: 0x0600AA5B RID: 43611 RVA: 0x002C68DC File Offset: 0x002C4ADC
		public static PhantomBattleBadge GetRootAsPhantomBattleBadge(ByteBuffer _bb, PhantomBattleBadge obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600AA5C RID: 43612 RVA: 0x002C68F9 File Offset: 0x002C4AF9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600AA5D RID: 43613 RVA: 0x002C6908 File Offset: 0x002C4B08
		public PhantomBattleBadge __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700258C RID: 9612
		// (get) Token: 0x0600AA5E RID: 43614 RVA: 0x002C6918 File Offset: 0x002C4B18
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

		// Token: 0x1700258D RID: 9613
		// (get) Token: 0x0600AA5F RID: 43615 RVA: 0x002C6954 File Offset: 0x002C4B54
		public int GroupId
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

		// Token: 0x1700258E RID: 9614
		// (get) Token: 0x0600AA60 RID: 43616 RVA: 0x002C6990 File Offset: 0x002C4B90
		public int ActivityId
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

		// Token: 0x1700258F RID: 9615
		// (get) Token: 0x0600AA61 RID: 43617 RVA: 0x002C69CC File Offset: 0x002C4BCC
		public int ItemType
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

		// Token: 0x17002590 RID: 9616
		// (get) Token: 0x0600AA62 RID: 43618 RVA: 0x002C6A0C File Offset: 0x002C4C0C
		public string ShowIcon
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

		// Token: 0x0600AA63 RID: 43619 RVA: 0x002C6A44 File Offset: 0x002C4C44
		public Span<byte> GetShowIconBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600AA64 RID: 43620 RVA: 0x002C6A54 File Offset: 0x002C4C54
		public byte[] GetShowIconArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17002591 RID: 9617
		// (get) Token: 0x0600AA65 RID: 43621 RVA: 0x002C6A6C File Offset: 0x002C4C6C
		public string Name
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

		// Token: 0x0600AA66 RID: 43622 RVA: 0x002C6AA4 File Offset: 0x002C4CA4
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600AA67 RID: 43623 RVA: 0x002C6AB4 File Offset: 0x002C4CB4
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17002592 RID: 9618
		// (get) Token: 0x0600AA68 RID: 43624 RVA: 0x002C6ACC File Offset: 0x002C4CCC
		public string Desc
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

		// Token: 0x0600AA69 RID: 43625 RVA: 0x002C6B04 File Offset: 0x002C4D04
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600AA6A RID: 43626 RVA: 0x002C6B14 File Offset: 0x002C4D14
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x17002593 RID: 9619
		// (get) Token: 0x0600AA6B RID: 43627 RVA: 0x002C6B2C File Offset: 0x002C4D2C
		public int ConditionGroup
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

		// Token: 0x17002594 RID: 9620
		// (get) Token: 0x0600AA6C RID: 43628 RVA: 0x002C6B6C File Offset: 0x002C4D6C
		public int QualityId
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

		// Token: 0x17002595 RID: 9621
		// (get) Token: 0x0600AA6D RID: 43629 RVA: 0x002C6BAC File Offset: 0x002C4DAC
		public string TypeDescription
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

		// Token: 0x0600AA6E RID: 43630 RVA: 0x002C6BE4 File Offset: 0x002C4DE4
		public Span<byte> GetTypeDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x0600AA6F RID: 43631 RVA: 0x002C6BF4 File Offset: 0x002C4DF4
		public byte[] GetTypeDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x17002596 RID: 9622
		// (get) Token: 0x0600AA70 RID: 43632 RVA: 0x002C6C0C File Offset: 0x002C4E0C
		public string AttributesDescription
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

		// Token: 0x0600AA71 RID: 43633 RVA: 0x002C6C44 File Offset: 0x002C4E44
		public Span<byte> GetAttributesDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x0600AA72 RID: 43634 RVA: 0x002C6C54 File Offset: 0x002C4E54
		public byte[] GetAttributesDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(24) ?? Array.Empty<byte>();
		}

		// Token: 0x17002597 RID: 9623
		// (get) Token: 0x0600AA73 RID: 43635 RVA: 0x002C6C6C File Offset: 0x002C4E6C
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

		// Token: 0x0600AA74 RID: 43636 RVA: 0x002C6CA4 File Offset: 0x002C4EA4
		public Span<byte> GetBgDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(26, 1);
		}

		// Token: 0x0600AA75 RID: 43637 RVA: 0x002C6CB4 File Offset: 0x002C4EB4
		public byte[] GetBgDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(26) ?? Array.Empty<byte>();
		}

		// Token: 0x17002598 RID: 9624
		// (get) Token: 0x0600AA76 RID: 43638 RVA: 0x002C6CCC File Offset: 0x002C4ECC
		public string Icon
		{
			get
			{
				int num = this.__p.__offset(28);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600AA77 RID: 43639 RVA: 0x002C6D04 File Offset: 0x002C4F04
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(28, 1);
		}

		// Token: 0x0600AA78 RID: 43640 RVA: 0x002C6D14 File Offset: 0x002C4F14
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(28) ?? Array.Empty<byte>();
		}

		// Token: 0x17002599 RID: 9625
		// (get) Token: 0x0600AA79 RID: 43641 RVA: 0x002C6D2C File Offset: 0x002C4F2C
		public string IconMiddle
		{
			get
			{
				int num = this.__p.__offset(30);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600AA7A RID: 43642 RVA: 0x002C6D64 File Offset: 0x002C4F64
		public Span<byte> GetIconMiddleBytes()
		{
			return this.__p.__vector_as_span<byte>(30, 1);
		}

		// Token: 0x0600AA7B RID: 43643 RVA: 0x002C6D74 File Offset: 0x002C4F74
		public byte[] GetIconMiddleArray()
		{
			return this.__p.__vector_as_array<byte>(30) ?? Array.Empty<byte>();
		}

		// Token: 0x1700259A RID: 9626
		// (get) Token: 0x0600AA7C RID: 43644 RVA: 0x002C6D8C File Offset: 0x002C4F8C
		public string IconSmall
		{
			get
			{
				int num = this.__p.__offset(32);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600AA7D RID: 43645 RVA: 0x002C6DC4 File Offset: 0x002C4FC4
		public Span<byte> GetIconSmallBytes()
		{
			return this.__p.__vector_as_span<byte>(32, 1);
		}

		// Token: 0x0600AA7E RID: 43646 RVA: 0x002C6DD4 File Offset: 0x002C4FD4
		public byte[] GetIconSmallArray()
		{
			return this.__p.__vector_as_array<byte>(32) ?? Array.Empty<byte>();
		}

		// Token: 0x1700259B RID: 9627
		// (get) Token: 0x0600AA7F RID: 43647 RVA: 0x002C6DEC File Offset: 0x002C4FEC
		public string Mesh
		{
			get
			{
				int num = this.__p.__offset(34);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600AA80 RID: 43648 RVA: 0x002C6E24 File Offset: 0x002C5024
		public Span<byte> GetMeshBytes()
		{
			return this.__p.__vector_as_span<byte>(34, 1);
		}

		// Token: 0x0600AA81 RID: 43649 RVA: 0x002C6E34 File Offset: 0x002C5034
		public byte[] GetMeshArray()
		{
			return this.__p.__vector_as_array<byte>(34) ?? Array.Empty<byte>();
		}

		// Token: 0x1700259C RID: 9628
		// (get) Token: 0x0600AA82 RID: 43650 RVA: 0x002C6E4C File Offset: 0x002C504C
		public string ObtainedShowDescription
		{
			get
			{
				int num = this.__p.__offset(36);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600AA83 RID: 43651 RVA: 0x002C6E84 File Offset: 0x002C5084
		public Span<byte> GetObtainedShowDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(36, 1);
		}

		// Token: 0x0600AA84 RID: 43652 RVA: 0x002C6E94 File Offset: 0x002C5094
		public byte[] GetObtainedShowDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(36) ?? Array.Empty<byte>();
		}

		// Token: 0x1700259D RID: 9629
		// (get) Token: 0x0600AA85 RID: 43653 RVA: 0x002C6EAC File Offset: 0x002C50AC
		public bool ShowInBag
		{
			get
			{
				int num = this.__p.__offset(38);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0600AA86 RID: 43654 RVA: 0x002C6EEC File Offset: 0x002C50EC
		public int ItemAccess(int j)
		{
			int num = this.__p.__offset(40);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700259E RID: 9630
		// (get) Token: 0x0600AA87 RID: 43655 RVA: 0x002C6F2C File Offset: 0x002C512C
		public int ItemAccessLength
		{
			get
			{
				int num = this.__p.__offset(40);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600AA88 RID: 43656 RVA: 0x002C6F58 File Offset: 0x002C5158
		public Span<int> GetItemAccessBytes()
		{
			return this.__p.__vector_as_span<int>(40, 4);
		}

		// Token: 0x0600AA89 RID: 43657 RVA: 0x002C6F68 File Offset: 0x002C5168
		public int[] GetItemAccessArray()
		{
			return this.__p.__vector_as_array<int>(40) ?? Array.Empty<int>();
		}

		// Token: 0x1700259F RID: 9631
		// (get) Token: 0x0600AA8A RID: 43658 RVA: 0x002C6F80 File Offset: 0x002C5180
		public int SortIndex
		{
			get
			{
				int num = this.__p.__offset(42);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170025A0 RID: 9632
		// (get) Token: 0x0600AA8B RID: 43659 RVA: 0x002C6FC0 File Offset: 0x002C51C0
		public int RedDotDisableRule
		{
			get
			{
				int num = this.__p.__offset(44);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600AA8C RID: 43660 RVA: 0x002C6FFD File Offset: 0x002C51FD
		[NullableContext(1)]
		public int[] ItemAccess()
		{
			return this.GetItemAccessArray();
		}

		// Token: 0x0600AA8D RID: 43661 RVA: 0x002C7005 File Offset: 0x002C5205
		[NullableContext(1)]
		public IEnumerable<int> ItemAccessIter()
		{
			PhantomBattleBadge.<ItemAccessIter>d__76 <ItemAccessIter>d__ = new PhantomBattleBadge.<ItemAccessIter>d__76(-2);
			<ItemAccessIter>d__.<>3__<>4__this = this;
			return <ItemAccessIter>d__;
		}

		// Token: 0x0400555C RID: 21852
		private Table __p;
	}
}
