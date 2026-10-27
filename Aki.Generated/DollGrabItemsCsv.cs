using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000BF6 RID: 3062
	public struct DollGrabItemsCsv : IFlatbufferObject
	{
		// Token: 0x17000CCE RID: 3278
		// (get) Token: 0x060062AB RID: 25259 RVA: 0x002144F5 File Offset: 0x002126F5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060062AC RID: 25260 RVA: 0x00214502 File Offset: 0x00212702
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060062AD RID: 25261 RVA: 0x0021450C File Offset: 0x0021270C
		public static DollGrabItemsCsv GetRootAsDollGrabItemsCsv(ByteBuffer _bb)
		{
			return DollGrabItemsCsv.GetRootAsDollGrabItemsCsv(_bb, default(DollGrabItemsCsv));
		}

		// Token: 0x060062AE RID: 25262 RVA: 0x00214528 File Offset: 0x00212728
		public static DollGrabItemsCsv GetRootAsDollGrabItemsCsv(ByteBuffer _bb, DollGrabItemsCsv obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060062AF RID: 25263 RVA: 0x00214545 File Offset: 0x00212745
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060062B0 RID: 25264 RVA: 0x00214554 File Offset: 0x00212754
		public DollGrabItemsCsv __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000CCF RID: 3279
		// (get) Token: 0x060062B1 RID: 25265 RVA: 0x00214564 File Offset: 0x00212764
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

		// Token: 0x17000CD0 RID: 3280
		// (get) Token: 0x060062B2 RID: 25266 RVA: 0x002145A0 File Offset: 0x002127A0
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

		// Token: 0x060062B3 RID: 25267 RVA: 0x002145D7 File Offset: 0x002127D7
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x060062B4 RID: 25268 RVA: 0x002145E6 File Offset: 0x002127E6
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17000CD1 RID: 3281
		// (get) Token: 0x060062B5 RID: 25269 RVA: 0x00214600 File Offset: 0x00212800
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

		// Token: 0x060062B6 RID: 25270 RVA: 0x00214637 File Offset: 0x00212837
		public Span<byte> GetShowcaseBelongTypeBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x060062B7 RID: 25271 RVA: 0x00214646 File Offset: 0x00212846
		public byte[] GetShowcaseBelongTypeArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17000CD2 RID: 3282
		// (get) Token: 0x060062B8 RID: 25272 RVA: 0x00214660 File Offset: 0x00212860
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

		// Token: 0x060062B9 RID: 25273 RVA: 0x00214698 File Offset: 0x00212898
		public Span<byte> GetItemBpPathBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x060062BA RID: 25274 RVA: 0x002146A8 File Offset: 0x002128A8
		public byte[] GetItemBpPathArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17000CD3 RID: 3283
		// (get) Token: 0x060062BB RID: 25275 RVA: 0x002146C0 File Offset: 0x002128C0
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

		// Token: 0x17000CD4 RID: 3284
		// (get) Token: 0x060062BC RID: 25276 RVA: 0x00214700 File Offset: 0x00212900
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

		// Token: 0x17000CD5 RID: 3285
		// (get) Token: 0x060062BD RID: 25277 RVA: 0x00214740 File Offset: 0x00212940
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

		// Token: 0x17000CD6 RID: 3286
		// (get) Token: 0x060062BE RID: 25278 RVA: 0x00214780 File Offset: 0x00212980
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

		// Token: 0x17000CD7 RID: 3287
		// (get) Token: 0x060062BF RID: 25279 RVA: 0x002147C0 File Offset: 0x002129C0
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

		// Token: 0x17000CD8 RID: 3288
		// (get) Token: 0x060062C0 RID: 25280 RVA: 0x00214800 File Offset: 0x00212A00
		public bool IsTouchGet
		{
			get
			{
				int num = this.__p.__offset(22);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17000CD9 RID: 3289
		// (get) Token: 0x060062C1 RID: 25281 RVA: 0x00214840 File Offset: 0x00212A40
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

		// Token: 0x060062C2 RID: 25282 RVA: 0x00214878 File Offset: 0x00212A78
		public Span<byte> GetBindSkeletalMeshBytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x060062C3 RID: 25283 RVA: 0x00214888 File Offset: 0x00212A88
		public byte[] GetBindSkeletalMeshArray()
		{
			return this.__p.__vector_as_array<byte>(24) ?? Array.Empty<byte>();
		}

		// Token: 0x17000CDA RID: 3290
		// (get) Token: 0x060062C4 RID: 25284 RVA: 0x002148A0 File Offset: 0x00212AA0
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

		// Token: 0x060062C5 RID: 25285 RVA: 0x002148D8 File Offset: 0x00212AD8
		public Span<byte> GetPartSocketNameBytes()
		{
			return this.__p.__vector_as_span<byte>(26, 1);
		}

		// Token: 0x060062C6 RID: 25286 RVA: 0x002148E8 File Offset: 0x00212AE8
		public byte[] GetPartSocketNameArray()
		{
			return this.__p.__vector_as_array<byte>(26) ?? Array.Empty<byte>();
		}

		// Token: 0x17000CDB RID: 3291
		// (get) Token: 0x060062C7 RID: 25287 RVA: 0x00214900 File Offset: 0x00212B00
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

		// Token: 0x060062C8 RID: 25288 RVA: 0x00214938 File Offset: 0x00212B38
		public Span<byte> GetDollShowcaseIdleMontageBytes()
		{
			return this.__p.__vector_as_span<byte>(28, 1);
		}

		// Token: 0x060062C9 RID: 25289 RVA: 0x00214948 File Offset: 0x00212B48
		public byte[] GetDollShowcaseIdleMontageArray()
		{
			return this.__p.__vector_as_array<byte>(28) ?? Array.Empty<byte>();
		}

		// Token: 0x17000CDC RID: 3292
		// (get) Token: 0x060062CA RID: 25290 RVA: 0x00214960 File Offset: 0x00212B60
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

		// Token: 0x060062CB RID: 25291 RVA: 0x00214998 File Offset: 0x00212B98
		public Span<byte> GetNotAchievedMaterialBytes()
		{
			return this.__p.__vector_as_span<byte>(30, 1);
		}

		// Token: 0x060062CC RID: 25292 RVA: 0x002149A8 File Offset: 0x00212BA8
		public byte[] GetNotAchievedMaterialArray()
		{
			return this.__p.__vector_as_array<byte>(30) ?? Array.Empty<byte>();
		}

		// Token: 0x17000CDD RID: 3293
		// (get) Token: 0x060062CD RID: 25293 RVA: 0x002149C0 File Offset: 0x00212BC0
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

		// Token: 0x060062CE RID: 25294 RVA: 0x002149F8 File Offset: 0x00212BF8
		public Span<byte> GetInfiniteModeMaterialBytes()
		{
			return this.__p.__vector_as_span<byte>(32, 1);
		}

		// Token: 0x060062CF RID: 25295 RVA: 0x00214A08 File Offset: 0x00212C08
		public byte[] GetInfiniteModeMaterialArray()
		{
			return this.__p.__vector_as_array<byte>(32) ?? Array.Empty<byte>();
		}

		// Token: 0x04004C23 RID: 19491
		private Table __p;
	}
}
