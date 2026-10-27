using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B9E RID: 2974
	public struct CookFormula : IFlatbufferObject
	{
		// Token: 0x17000953 RID: 2387
		// (get) Token: 0x0600593D RID: 22845 RVA: 0x001FF4CC File Offset: 0x001FD6CC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600593E RID: 22846 RVA: 0x001FF4D9 File Offset: 0x001FD6D9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600593F RID: 22847 RVA: 0x001FF4E0 File Offset: 0x001FD6E0
		public static CookFormula GetRootAsCookFormula(ByteBuffer _bb)
		{
			return CookFormula.GetRootAsCookFormula(_bb, default(CookFormula));
		}

		// Token: 0x06005940 RID: 22848 RVA: 0x001FF4FC File Offset: 0x001FD6FC
		public static CookFormula GetRootAsCookFormula(ByteBuffer _bb, CookFormula obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06005941 RID: 22849 RVA: 0x001FF519 File Offset: 0x001FD719
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06005942 RID: 22850 RVA: 0x001FF528 File Offset: 0x001FD728
		public CookFormula __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000954 RID: 2388
		// (get) Token: 0x06005943 RID: 22851 RVA: 0x001FF538 File Offset: 0x001FD738
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

		// Token: 0x17000955 RID: 2389
		// (get) Token: 0x06005944 RID: 22852 RVA: 0x001FF574 File Offset: 0x001FD774
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

		// Token: 0x17000956 RID: 2390
		// (get) Token: 0x06005945 RID: 22853 RVA: 0x001FF5B0 File Offset: 0x001FD7B0
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

		// Token: 0x17000957 RID: 2391
		// (get) Token: 0x06005946 RID: 22854 RVA: 0x001FF5EC File Offset: 0x001FD7EC
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

		// Token: 0x17000958 RID: 2392
		// (get) Token: 0x06005947 RID: 22855 RVA: 0x001FF62C File Offset: 0x001FD82C
		public bool Unlock
		{
			get
			{
				int num = this.__p.__offset(12);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17000959 RID: 2393
		// (get) Token: 0x06005948 RID: 22856 RVA: 0x001FF66C File Offset: 0x001FD86C
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

		// Token: 0x06005949 RID: 22857 RVA: 0x001FF6A4 File Offset: 0x001FD8A4
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600594A RID: 22858 RVA: 0x001FF6B4 File Offset: 0x001FD8B4
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x0600594B RID: 22859 RVA: 0x001FF6CC File Offset: 0x001FD8CC
		public OneItemConfig? ConsumeItems(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return null;
			}
			return new OneItemConfig?(default(OneItemConfig).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700095A RID: 2394
		// (get) Token: 0x0600594C RID: 22860 RVA: 0x001FF730 File Offset: 0x001FD930
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

		// Token: 0x1700095B RID: 2395
		// (get) Token: 0x0600594D RID: 22861 RVA: 0x001FF75C File Offset: 0x001FD95C
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

		// Token: 0x1700095C RID: 2396
		// (get) Token: 0x0600594E RID: 22862 RVA: 0x001FF79C File Offset: 0x001FD99C
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

		// Token: 0x1700095D RID: 2397
		// (get) Token: 0x0600594F RID: 22863 RVA: 0x001FF7DC File Offset: 0x001FD9DC
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

		// Token: 0x06005950 RID: 22864 RVA: 0x001FF814 File Offset: 0x001FDA14
		public Span<byte> GetFoodContentBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x06005951 RID: 22865 RVA: 0x001FF824 File Offset: 0x001FDA24
		public byte[] GetFoodContentArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x1700095E RID: 2398
		// (get) Token: 0x06005952 RID: 22866 RVA: 0x001FF83C File Offset: 0x001FDA3C
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

		// Token: 0x06005953 RID: 22867 RVA: 0x001FF874 File Offset: 0x001FDA74
		public Span<byte> GetFoodBackgroundBytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x06005954 RID: 22868 RVA: 0x001FF884 File Offset: 0x001FDA84
		public byte[] GetFoodBackgroundArray()
		{
			return this.__p.__vector_as_array<byte>(24) ?? Array.Empty<byte>();
		}

		// Token: 0x06005955 RID: 22869 RVA: 0x001FF89C File Offset: 0x001FDA9C
		public int RoleList(int j)
		{
			int num = this.__p.__offset(26);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700095F RID: 2399
		// (get) Token: 0x06005956 RID: 22870 RVA: 0x001FF8DC File Offset: 0x001FDADC
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

		// Token: 0x06005957 RID: 22871 RVA: 0x001FF908 File Offset: 0x001FDB08
		public Span<int> GetRoleListBytes()
		{
			return this.__p.__vector_as_span<int>(26, 4);
		}

		// Token: 0x06005958 RID: 22872 RVA: 0x001FF918 File Offset: 0x001FDB18
		public int[] GetRoleListArray()
		{
			return this.__p.__vector_as_array<int>(26) ?? Array.Empty<int>();
		}

		// Token: 0x06005959 RID: 22873 RVA: 0x001FF930 File Offset: 0x001FDB30
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用ConsumeItemsIter()或GetConsumeItemsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly OneItemConfig[] ConsumeItems()
		{
			return this.ConsumeItemsIter().ToArray<OneItemConfig>();
		}

		// Token: 0x0600595A RID: 22874 RVA: 0x001FF93D File Offset: 0x001FDB3D
		[NullableContext(1)]
		public readonly IEnumerable<OneItemConfig> ConsumeItemsIter()
		{
			CookFormula.<ConsumeItemsIter>d__43 <ConsumeItemsIter>d__ = new CookFormula.<ConsumeItemsIter>d__43(-2);
			<ConsumeItemsIter>d__.<>3__<>4__this = this;
			return <ConsumeItemsIter>d__;
		}

		// Token: 0x0600595B RID: 22875 RVA: 0x001FF954 File Offset: 0x001FDB54
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用RoleListIter()或GetRoleListBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] RoleList()
		{
			CookFormula cookFormula = this;
			return cookFormula.GetRoleListArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600595C RID: 22876 RVA: 0x001FF978 File Offset: 0x001FDB78
		[NullableContext(1)]
		public readonly IEnumerable<int> RoleListIter()
		{
			CookFormula.<RoleListIter>d__45 <RoleListIter>d__ = new CookFormula.<RoleListIter>d__45(-2);
			<RoleListIter>d__.<>3__<>4__this = this;
			return <RoleListIter>d__;
		}

		// Token: 0x04004BC0 RID: 19392
		private Table __p;
	}
}
