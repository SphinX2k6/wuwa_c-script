using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000CD7 RID: 3287
	public struct Furniture : IFlatbufferObject
	{
		// Token: 0x17001466 RID: 5222
		// (get) Token: 0x06007773 RID: 30579 RVA: 0x002446F0 File Offset: 0x002428F0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06007774 RID: 30580 RVA: 0x002446FD File Offset: 0x002428FD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06007775 RID: 30581 RVA: 0x00244704 File Offset: 0x00242904
		public static Furniture GetRootAsFurniture(ByteBuffer _bb)
		{
			return Furniture.GetRootAsFurniture(_bb, default(Furniture));
		}

		// Token: 0x06007776 RID: 30582 RVA: 0x00244720 File Offset: 0x00242920
		public static Furniture GetRootAsFurniture(ByteBuffer _bb, Furniture obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06007777 RID: 30583 RVA: 0x0024473D File Offset: 0x0024293D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06007778 RID: 30584 RVA: 0x0024474C File Offset: 0x0024294C
		public Furniture __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001467 RID: 5223
		// (get) Token: 0x06007779 RID: 30585 RVA: 0x0024475C File Offset: 0x0024295C
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

		// Token: 0x17001468 RID: 5224
		// (get) Token: 0x0600777A RID: 30586 RVA: 0x00244798 File Offset: 0x00242998
		public int ActivityId
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

		// Token: 0x17001469 RID: 5225
		// (get) Token: 0x0600777B RID: 30587 RVA: 0x002447D4 File Offset: 0x002429D4
		public int TagId
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

		// Token: 0x1700146A RID: 5226
		// (get) Token: 0x0600777C RID: 30588 RVA: 0x00244810 File Offset: 0x00242A10
		public int GetWayId
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

		// Token: 0x1700146B RID: 5227
		// (get) Token: 0x0600777D RID: 30589 RVA: 0x00244850 File Offset: 0x00242A50
		public int SourceType
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

		// Token: 0x1700146C RID: 5228
		// (get) Token: 0x0600777E RID: 30590 RVA: 0x00244890 File Offset: 0x00242A90
		public bool IsEntityGroup
		{
			get
			{
				int num = this.__p.__offset(14);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700146D RID: 5229
		// (get) Token: 0x0600777F RID: 30591 RVA: 0x002448D0 File Offset: 0x00242AD0
		public int EntityId
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

		// Token: 0x1700146E RID: 5230
		// (get) Token: 0x06007780 RID: 30592 RVA: 0x00244910 File Offset: 0x00242B10
		public int Atmosphere
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

		// Token: 0x1700146F RID: 5231
		// (get) Token: 0x06007781 RID: 30593 RVA: 0x00244950 File Offset: 0x00242B50
		public string Name
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

		// Token: 0x06007782 RID: 30594 RVA: 0x00244988 File Offset: 0x00242B88
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x06007783 RID: 30595 RVA: 0x00244998 File Offset: 0x00242B98
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x17001470 RID: 5232
		// (get) Token: 0x06007784 RID: 30596 RVA: 0x002449B0 File Offset: 0x00242BB0
		public string Icon
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

		// Token: 0x06007785 RID: 30597 RVA: 0x002449E8 File Offset: 0x00242BE8
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x06007786 RID: 30598 RVA: 0x002449F8 File Offset: 0x00242BF8
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x17001471 RID: 5233
		// (get) Token: 0x06007787 RID: 30599 RVA: 0x00244A10 File Offset: 0x00242C10
		public string IconMiddle
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

		// Token: 0x06007788 RID: 30600 RVA: 0x00244A48 File Offset: 0x00242C48
		public Span<byte> GetIconMiddleBytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x06007789 RID: 30601 RVA: 0x00244A58 File Offset: 0x00242C58
		public byte[] GetIconMiddleArray()
		{
			return this.__p.__vector_as_array<byte>(24) ?? Array.Empty<byte>();
		}

		// Token: 0x17001472 RID: 5234
		// (get) Token: 0x0600778A RID: 30602 RVA: 0x00244A70 File Offset: 0x00242C70
		public string IconBig
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

		// Token: 0x0600778B RID: 30603 RVA: 0x00244AA8 File Offset: 0x00242CA8
		public Span<byte> GetIconBigBytes()
		{
			return this.__p.__vector_as_span<byte>(26, 1);
		}

		// Token: 0x0600778C RID: 30604 RVA: 0x00244AB8 File Offset: 0x00242CB8
		public byte[] GetIconBigArray()
		{
			return this.__p.__vector_as_array<byte>(26) ?? Array.Empty<byte>();
		}

		// Token: 0x17001473 RID: 5235
		// (get) Token: 0x0600778D RID: 30605 RVA: 0x00244AD0 File Offset: 0x00242CD0
		public string IconPath
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

		// Token: 0x0600778E RID: 30606 RVA: 0x00244B08 File Offset: 0x00242D08
		public Span<byte> GetIconPathBytes()
		{
			return this.__p.__vector_as_span<byte>(28, 1);
		}

		// Token: 0x0600778F RID: 30607 RVA: 0x00244B18 File Offset: 0x00242D18
		public byte[] GetIconPathArray()
		{
			return this.__p.__vector_as_array<byte>(28) ?? Array.Empty<byte>();
		}

		// Token: 0x17001474 RID: 5236
		// (get) Token: 0x06007790 RID: 30608 RVA: 0x00244B30 File Offset: 0x00242D30
		public string PrefabPath
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

		// Token: 0x06007791 RID: 30609 RVA: 0x00244B68 File Offset: 0x00242D68
		public Span<byte> GetPrefabPathBytes()
		{
			return this.__p.__vector_as_span<byte>(30, 1);
		}

		// Token: 0x06007792 RID: 30610 RVA: 0x00244B78 File Offset: 0x00242D78
		public byte[] GetPrefabPathArray()
		{
			return this.__p.__vector_as_array<byte>(30) ?? Array.Empty<byte>();
		}

		// Token: 0x17001475 RID: 5237
		// (get) Token: 0x06007793 RID: 30611 RVA: 0x00244B90 File Offset: 0x00242D90
		public int QualityId
		{
			get
			{
				int num = this.__p.__offset(32);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001476 RID: 5238
		// (get) Token: 0x06007794 RID: 30612 RVA: 0x00244BD0 File Offset: 0x00242DD0
		public int LimitCount
		{
			get
			{
				int num = this.__p.__offset(34);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001477 RID: 5239
		// (get) Token: 0x06007795 RID: 30613 RVA: 0x00244C10 File Offset: 0x00242E10
		public string SourceDesciption
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

		// Token: 0x06007796 RID: 30614 RVA: 0x00244C48 File Offset: 0x00242E48
		public Span<byte> GetSourceDesciptionBytes()
		{
			return this.__p.__vector_as_span<byte>(36, 1);
		}

		// Token: 0x06007797 RID: 30615 RVA: 0x00244C58 File Offset: 0x00242E58
		public byte[] GetSourceDesciptionArray()
		{
			return this.__p.__vector_as_array<byte>(36) ?? Array.Empty<byte>();
		}

		// Token: 0x17001478 RID: 5240
		// (get) Token: 0x06007798 RID: 30616 RVA: 0x00244C70 File Offset: 0x00242E70
		public string RoleIconPath
		{
			get
			{
				int num = this.__p.__offset(38);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06007799 RID: 30617 RVA: 0x00244CA8 File Offset: 0x00242EA8
		public Span<byte> GetRoleIconPathBytes()
		{
			return this.__p.__vector_as_span<byte>(38, 1);
		}

		// Token: 0x0600779A RID: 30618 RVA: 0x00244CB8 File Offset: 0x00242EB8
		public byte[] GetRoleIconPathArray()
		{
			return this.__p.__vector_as_array<byte>(38) ?? Array.Empty<byte>();
		}

		// Token: 0x17001479 RID: 5241
		// (get) Token: 0x0600779B RID: 30619 RVA: 0x00244CD0 File Offset: 0x00242ED0
		public string GiftDescription
		{
			get
			{
				int num = this.__p.__offset(40);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600779C RID: 30620 RVA: 0x00244D08 File Offset: 0x00242F08
		public Span<byte> GetGiftDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(40, 1);
		}

		// Token: 0x0600779D RID: 30621 RVA: 0x00244D18 File Offset: 0x00242F18
		public byte[] GetGiftDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(40) ?? Array.Empty<byte>();
		}

		// Token: 0x1700147A RID: 5242
		// (get) Token: 0x0600779E RID: 30622 RVA: 0x00244D30 File Offset: 0x00242F30
		public string Desciption
		{
			get
			{
				int num = this.__p.__offset(42);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600779F RID: 30623 RVA: 0x00244D68 File Offset: 0x00242F68
		public Span<byte> GetDesciptionBytes()
		{
			return this.__p.__vector_as_span<byte>(42, 1);
		}

		// Token: 0x060077A0 RID: 30624 RVA: 0x00244D78 File Offset: 0x00242F78
		public byte[] GetDesciptionArray()
		{
			return this.__p.__vector_as_array<byte>(42) ?? Array.Empty<byte>();
		}

		// Token: 0x1700147B RID: 5243
		// (get) Token: 0x060077A1 RID: 30625 RVA: 0x00244D90 File Offset: 0x00242F90
		public string AttributesDescription
		{
			get
			{
				int num = this.__p.__offset(44);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060077A2 RID: 30626 RVA: 0x00244DC8 File Offset: 0x00242FC8
		public Span<byte> GetAttributesDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(44, 1);
		}

		// Token: 0x060077A3 RID: 30627 RVA: 0x00244DD8 File Offset: 0x00242FD8
		public byte[] GetAttributesDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(44) ?? Array.Empty<byte>();
		}

		// Token: 0x04004D47 RID: 19783
		private Table __p;
	}
}
