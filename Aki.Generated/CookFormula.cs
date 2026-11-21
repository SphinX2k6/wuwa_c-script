using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C80 RID: 3200
	public struct CookFormula : IFlatbufferObject
	{
		// Token: 0x17000999 RID: 2457
		// (get) Token: 0x06005F16 RID: 24342 RVA: 0x0021F26C File Offset: 0x0021D46C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06005F17 RID: 24343 RVA: 0x0021F279 File Offset: 0x0021D479
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06005F18 RID: 24344 RVA: 0x0021F280 File Offset: 0x0021D480
		public static CookFormula GetRootAsCookFormula(ByteBuffer _bb)
		{
			return CookFormula.GetRootAsCookFormula(_bb, default(CookFormula));
		}

		// Token: 0x06005F19 RID: 24345 RVA: 0x0021F29C File Offset: 0x0021D49C
		public static CookFormula GetRootAsCookFormula(ByteBuffer _bb, CookFormula obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06005F1A RID: 24346 RVA: 0x0021F2B9 File Offset: 0x0021D4B9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06005F1B RID: 24347 RVA: 0x0021F2C8 File Offset: 0x0021D4C8
		public CookFormula __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700099A RID: 2458
		// (get) Token: 0x06005F1C RID: 24348 RVA: 0x0021F2D8 File Offset: 0x0021D4D8
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

		// Token: 0x1700099B RID: 2459
		// (get) Token: 0x06005F1D RID: 24349 RVA: 0x0021F314 File Offset: 0x0021D514
		public int FormulaItemId
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

		// Token: 0x1700099C RID: 2460
		// (get) Token: 0x06005F1E RID: 24350 RVA: 0x0021F350 File Offset: 0x0021D550
		public int FoodItemId
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

		// Token: 0x1700099D RID: 2461
		// (get) Token: 0x06005F1F RID: 24351 RVA: 0x0021F38C File Offset: 0x0021D58C
		public int TypeId
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

		// Token: 0x1700099E RID: 2462
		// (get) Token: 0x06005F20 RID: 24352 RVA: 0x0021F3CC File Offset: 0x0021D5CC
		public bool Unlock
		{
			get
			{
				int num = this.__p.__offset(12);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700099F RID: 2463
		// (get) Token: 0x06005F21 RID: 24353 RVA: 0x0021F40C File Offset: 0x0021D60C
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

		// Token: 0x06005F22 RID: 24354 RVA: 0x0021F444 File Offset: 0x0021D644
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x06005F23 RID: 24355 RVA: 0x0021F454 File Offset: 0x0021D654
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x06005F24 RID: 24356 RVA: 0x0021F46C File Offset: 0x0021D66C
		public OneItemConfig? ConsumeItems(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return null;
			}
			return new OneItemConfig?(default(OneItemConfig).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170009A0 RID: 2464
		// (get) Token: 0x06005F25 RID: 24357 RVA: 0x0021F4D0 File Offset: 0x0021D6D0
		public int ConsumeItemsLength
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

		// Token: 0x170009A1 RID: 2465
		// (get) Token: 0x06005F26 RID: 24358 RVA: 0x0021F4FC File Offset: 0x0021D6FC
		public int Proficiency
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

		// Token: 0x170009A2 RID: 2466
		// (get) Token: 0x06005F27 RID: 24359 RVA: 0x0021F53C File Offset: 0x0021D73C
		public int MaxProficiencyCount
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

		// Token: 0x170009A3 RID: 2467
		// (get) Token: 0x06005F28 RID: 24360 RVA: 0x0021F57C File Offset: 0x0021D77C
		public string FoodContent
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

		// Token: 0x06005F29 RID: 24361 RVA: 0x0021F5B4 File Offset: 0x0021D7B4
		public Span<byte> GetFoodContentBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x06005F2A RID: 24362 RVA: 0x0021F5C4 File Offset: 0x0021D7C4
		public byte[] GetFoodContentArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x170009A4 RID: 2468
		// (get) Token: 0x06005F2B RID: 24363 RVA: 0x0021F5DC File Offset: 0x0021D7DC
		public string FoodBackground
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

		// Token: 0x06005F2C RID: 24364 RVA: 0x0021F614 File Offset: 0x0021D814
		public Span<byte> GetFoodBackgroundBytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x06005F2D RID: 24365 RVA: 0x0021F624 File Offset: 0x0021D824
		public byte[] GetFoodBackgroundArray()
		{
			return this.__p.__vector_as_array<byte>(24) ?? Array.Empty<byte>();
		}

		// Token: 0x06005F2E RID: 24366 RVA: 0x0021F63C File Offset: 0x0021D83C
		public int RoleList(int j)
		{
			int num = this.__p.__offset(26);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170009A5 RID: 2469
		// (get) Token: 0x06005F2F RID: 24367 RVA: 0x0021F67C File Offset: 0x0021D87C
		public int RoleListLength
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06005F30 RID: 24368 RVA: 0x0021F6A8 File Offset: 0x0021D8A8
		public Span<int> GetRoleListBytes()
		{
			return this.__p.__vector_as_span<int>(26, 4);
		}

		// Token: 0x06005F31 RID: 24369 RVA: 0x0021F6B8 File Offset: 0x0021D8B8
		public int[] GetRoleListArray()
		{
			return this.__p.__vector_as_array<int>(26) ?? Array.Empty<int>();
		}

		// Token: 0x06005F32 RID: 24370 RVA: 0x0021F6D0 File Offset: 0x0021D8D0
		[NullableContext(1)]
		public OneItemConfig[] ConsumeItems()
		{
			return this.ConsumeItemsIter().ToArray<OneItemConfig>();
		}

		// Token: 0x06005F33 RID: 24371 RVA: 0x0021F6DD File Offset: 0x0021D8DD
		[NullableContext(1)]
		public IEnumerable<OneItemConfig> ConsumeItemsIter()
		{
			CookFormula.<ConsumeItemsIter>d__43 <ConsumeItemsIter>d__ = new CookFormula.<ConsumeItemsIter>d__43(-2);
			<ConsumeItemsIter>d__.<>3__<>4__this = this;
			return <ConsumeItemsIter>d__;
		}

		// Token: 0x06005F34 RID: 24372 RVA: 0x0021F6F2 File Offset: 0x0021D8F2
		[NullableContext(1)]
		public int[] RoleList()
		{
			return this.GetRoleListArray();
		}

		// Token: 0x06005F35 RID: 24373 RVA: 0x0021F6FA File Offset: 0x0021D8FA
		[NullableContext(1)]
		public IEnumerable<int> RoleListIter()
		{
			CookFormula.<RoleListIter>d__45 <RoleListIter>d__ = new CookFormula.<RoleListIter>d__45(-2);
			<RoleListIter>d__.<>3__<>4__this = this;
			return <RoleListIter>d__;
		}

		// Token: 0x040051A2 RID: 20898
		private Table __p;
	}
}
