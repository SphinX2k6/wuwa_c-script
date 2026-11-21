using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000CD8 RID: 3288
	public struct DollGrabItemsCsv : IFlatbufferObject
	{
		// Token: 0x17000D19 RID: 3353
		// (get) Token: 0x06006889 RID: 26761 RVA: 0x00233BAD File Offset: 0x00231DAD
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600688A RID: 26762 RVA: 0x00233BBA File Offset: 0x00231DBA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600688B RID: 26763 RVA: 0x00233BC4 File Offset: 0x00231DC4
		public static DollGrabItemsCsv GetRootAsDollGrabItemsCsv(ByteBuffer _bb)
		{
			return DollGrabItemsCsv.GetRootAsDollGrabItemsCsv(_bb, default(DollGrabItemsCsv));
		}

		// Token: 0x0600688C RID: 26764 RVA: 0x00233BE0 File Offset: 0x00231DE0
		public static DollGrabItemsCsv GetRootAsDollGrabItemsCsv(ByteBuffer _bb, DollGrabItemsCsv obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600688D RID: 26765 RVA: 0x00233BFD File Offset: 0x00231DFD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600688E RID: 26766 RVA: 0x00233C0C File Offset: 0x00231E0C
		public DollGrabItemsCsv __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000D1A RID: 3354
		// (get) Token: 0x0600688F RID: 26767 RVA: 0x00233C1C File Offset: 0x00231E1C
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

		// Token: 0x17000D1B RID: 3355
		// (get) Token: 0x06006890 RID: 26768 RVA: 0x00233C58 File Offset: 0x00231E58
		public string Name
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

		// Token: 0x06006891 RID: 26769 RVA: 0x00233C8F File Offset: 0x00231E8F
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06006892 RID: 26770 RVA: 0x00233C9E File Offset: 0x00231E9E
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17000D1C RID: 3356
		// (get) Token: 0x06006893 RID: 26771 RVA: 0x00233CB8 File Offset: 0x00231EB8
		public string ShowcaseBelongType
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

		// Token: 0x06006894 RID: 26772 RVA: 0x00233CEF File Offset: 0x00231EEF
		public Span<byte> GetShowcaseBelongTypeBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06006895 RID: 26773 RVA: 0x00233CFE File Offset: 0x00231EFE
		public byte[] GetShowcaseBelongTypeArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17000D1D RID: 3357
		// (get) Token: 0x06006896 RID: 26774 RVA: 0x00233D18 File Offset: 0x00231F18
		public string ItemBpPath
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

		// Token: 0x06006897 RID: 26775 RVA: 0x00233D50 File Offset: 0x00231F50
		public Span<byte> GetItemBpPathBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06006898 RID: 26776 RVA: 0x00233D60 File Offset: 0x00231F60
		public byte[] GetItemBpPathArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17000D1E RID: 3358
		// (get) Token: 0x06006899 RID: 26777 RVA: 0x00233D78 File Offset: 0x00231F78
		public int MaxGetCount
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

		// Token: 0x17000D1F RID: 3359
		// (get) Token: 0x0600689A RID: 26778 RVA: 0x00233DB8 File Offset: 0x00231FB8
		public int AddTime
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000D20 RID: 3360
		// (get) Token: 0x0600689B RID: 26779 RVA: 0x00233DF8 File Offset: 0x00231FF8
		public int DropId
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

		// Token: 0x17000D21 RID: 3361
		// (get) Token: 0x0600689C RID: 26780 RVA: 0x00233E38 File Offset: 0x00232038
		public int BindingItemId
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

		// Token: 0x17000D22 RID: 3362
		// (get) Token: 0x0600689D RID: 26781 RVA: 0x00233E78 File Offset: 0x00232078
		public int InfiniteModeScore
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

		// Token: 0x17000D23 RID: 3363
		// (get) Token: 0x0600689E RID: 26782 RVA: 0x00233EB8 File Offset: 0x002320B8
		public bool IsTouchGet
		{
			get
			{
				int num = this.__p.__offset(22);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17000D24 RID: 3364
		// (get) Token: 0x0600689F RID: 26783 RVA: 0x00233EF8 File Offset: 0x002320F8
		public string BindSkeletalMesh
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

		// Token: 0x060068A0 RID: 26784 RVA: 0x00233F30 File Offset: 0x00232130
		public Span<byte> GetBindSkeletalMeshBytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x060068A1 RID: 26785 RVA: 0x00233F40 File Offset: 0x00232140
		public byte[] GetBindSkeletalMeshArray()
		{
			return this.__p.__vector_as_array<byte>(24) ?? Array.Empty<byte>();
		}

		// Token: 0x17000D25 RID: 3365
		// (get) Token: 0x060068A2 RID: 26786 RVA: 0x00233F58 File Offset: 0x00232158
		public string PartSocketName
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

		// Token: 0x060068A3 RID: 26787 RVA: 0x00233F90 File Offset: 0x00232190
		public Span<byte> GetPartSocketNameBytes()
		{
			return this.__p.__vector_as_span<byte>(26, 1);
		}

		// Token: 0x060068A4 RID: 26788 RVA: 0x00233FA0 File Offset: 0x002321A0
		public byte[] GetPartSocketNameArray()
		{
			return this.__p.__vector_as_array<byte>(26) ?? Array.Empty<byte>();
		}

		// Token: 0x17000D26 RID: 3366
		// (get) Token: 0x060068A5 RID: 26789 RVA: 0x00233FB8 File Offset: 0x002321B8
		public string DollShowcaseIdleMontage
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

		// Token: 0x060068A6 RID: 26790 RVA: 0x00233FF0 File Offset: 0x002321F0
		public Span<byte> GetDollShowcaseIdleMontageBytes()
		{
			return this.__p.__vector_as_span<byte>(28, 1);
		}

		// Token: 0x060068A7 RID: 26791 RVA: 0x00234000 File Offset: 0x00232200
		public byte[] GetDollShowcaseIdleMontageArray()
		{
			return this.__p.__vector_as_array<byte>(28) ?? Array.Empty<byte>();
		}

		// Token: 0x17000D27 RID: 3367
		// (get) Token: 0x060068A8 RID: 26792 RVA: 0x00234018 File Offset: 0x00232218
		public string NotAchievedMaterial
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

		// Token: 0x060068A9 RID: 26793 RVA: 0x00234050 File Offset: 0x00232250
		public Span<byte> GetNotAchievedMaterialBytes()
		{
			return this.__p.__vector_as_span<byte>(30, 1);
		}

		// Token: 0x060068AA RID: 26794 RVA: 0x00234060 File Offset: 0x00232260
		public byte[] GetNotAchievedMaterialArray()
		{
			return this.__p.__vector_as_array<byte>(30) ?? Array.Empty<byte>();
		}

		// Token: 0x17000D28 RID: 3368
		// (get) Token: 0x060068AB RID: 26795 RVA: 0x00234078 File Offset: 0x00232278
		public string InfiniteModeMaterial
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

		// Token: 0x060068AC RID: 26796 RVA: 0x002340B0 File Offset: 0x002322B0
		public Span<byte> GetInfiniteModeMaterialBytes()
		{
			return this.__p.__vector_as_span<byte>(32, 1);
		}

		// Token: 0x060068AD RID: 26797 RVA: 0x002340C0 File Offset: 0x002322C0
		public byte[] GetInfiniteModeMaterialArray()
		{
			return this.__p.__vector_as_array<byte>(32) ?? Array.Empty<byte>();
		}

		// Token: 0x04005205 RID: 20997
		private Table __p;
	}
}
