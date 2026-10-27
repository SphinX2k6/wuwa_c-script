using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000CCB RID: 3275
	public struct ForgeFormula : IFlatbufferObject
	{
		// Token: 0x170013FA RID: 5114
		// (get) Token: 0x06007660 RID: 30304 RVA: 0x00241FA5 File Offset: 0x002401A5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06007661 RID: 30305 RVA: 0x00241FB2 File Offset: 0x002401B2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06007662 RID: 30306 RVA: 0x00241FBC File Offset: 0x002401BC
		public static ForgeFormula GetRootAsForgeFormula(ByteBuffer _bb)
		{
			return ForgeFormula.GetRootAsForgeFormula(_bb, default(ForgeFormula));
		}

		// Token: 0x06007663 RID: 30307 RVA: 0x00241FD8 File Offset: 0x002401D8
		public static ForgeFormula GetRootAsForgeFormula(ByteBuffer _bb, ForgeFormula obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06007664 RID: 30308 RVA: 0x00241FF5 File Offset: 0x002401F5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06007665 RID: 30309 RVA: 0x00242004 File Offset: 0x00240204
		public ForgeFormula __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170013FB RID: 5115
		// (get) Token: 0x06007666 RID: 30310 RVA: 0x00242014 File Offset: 0x00240214
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

		// Token: 0x170013FC RID: 5116
		// (get) Token: 0x06007667 RID: 30311 RVA: 0x00242050 File Offset: 0x00240250
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

		// Token: 0x170013FD RID: 5117
		// (get) Token: 0x06007668 RID: 30312 RVA: 0x0024208C File Offset: 0x0024028C
		public int ItemId
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

		// Token: 0x170013FE RID: 5118
		// (get) Token: 0x06007669 RID: 30313 RVA: 0x002420C8 File Offset: 0x002402C8
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

		// Token: 0x170013FF RID: 5119
		// (get) Token: 0x0600766A RID: 30314 RVA: 0x00242108 File Offset: 0x00240308
		public bool Unlock
		{
			get
			{
				int num = this.__p.__offset(12);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17001400 RID: 5120
		// (get) Token: 0x0600766B RID: 30315 RVA: 0x00242148 File Offset: 0x00240348
		public int SortId
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

		// Token: 0x17001401 RID: 5121
		// (get) Token: 0x0600766C RID: 30316 RVA: 0x00242188 File Offset: 0x00240388
		public string Name
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

		// Token: 0x0600766D RID: 30317 RVA: 0x002421C0 File Offset: 0x002403C0
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600766E RID: 30318 RVA: 0x002421D0 File Offset: 0x002403D0
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x0600766F RID: 30319 RVA: 0x002421E8 File Offset: 0x002403E8
		public OneItemConfig? ConsumeItems(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return null;
			}
			return new OneItemConfig?(default(OneItemConfig).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17001402 RID: 5122
		// (get) Token: 0x06007670 RID: 30320 RVA: 0x0024224C File Offset: 0x0024044C
		public int ConsumeItemsLength
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

		// Token: 0x17001403 RID: 5123
		// (get) Token: 0x06007671 RID: 30321 RVA: 0x00242278 File Offset: 0x00240478
		public string ForgeContent
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

		// Token: 0x06007672 RID: 30322 RVA: 0x002422B0 File Offset: 0x002404B0
		public Span<byte> GetForgeContentBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x06007673 RID: 30323 RVA: 0x002422C0 File Offset: 0x002404C0
		public byte[] GetForgeContentArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x17001404 RID: 5124
		// (get) Token: 0x06007674 RID: 30324 RVA: 0x002422D8 File Offset: 0x002404D8
		public string Background
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

		// Token: 0x06007675 RID: 30325 RVA: 0x00242310 File Offset: 0x00240510
		public Span<byte> GetBackgroundBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x06007676 RID: 30326 RVA: 0x00242320 File Offset: 0x00240520
		public byte[] GetBackgroundArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x06007677 RID: 30327 RVA: 0x00242338 File Offset: 0x00240538
		public int RoleList(int j)
		{
			int num = this.__p.__offset(24);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001405 RID: 5125
		// (get) Token: 0x06007678 RID: 30328 RVA: 0x00242378 File Offset: 0x00240578
		public int RoleListLength
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06007679 RID: 30329 RVA: 0x002423A4 File Offset: 0x002405A4
		public Span<int> GetRoleListBytes()
		{
			return this.__p.__vector_as_span<int>(24, 4);
		}

		// Token: 0x0600767A RID: 30330 RVA: 0x002423B4 File Offset: 0x002405B4
		public int[] GetRoleListArray()
		{
			return this.__p.__vector_as_array<int>(24) ?? Array.Empty<int>();
		}

		// Token: 0x0600767B RID: 30331 RVA: 0x002423CC File Offset: 0x002405CC
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用ConsumeItemsIter()或GetConsumeItemsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly OneItemConfig[] ConsumeItems()
		{
			return this.ConsumeItemsIter().ToArray<OneItemConfig>();
		}

		// Token: 0x0600767C RID: 30332 RVA: 0x002423D9 File Offset: 0x002405D9
		[NullableContext(1)]
		public readonly IEnumerable<OneItemConfig> ConsumeItemsIter()
		{
			ForgeFormula.<ConsumeItemsIter>d__41 <ConsumeItemsIter>d__ = new ForgeFormula.<ConsumeItemsIter>d__41(-2);
			<ConsumeItemsIter>d__.<>3__<>4__this = this;
			return <ConsumeItemsIter>d__;
		}

		// Token: 0x0600767D RID: 30333 RVA: 0x002423F0 File Offset: 0x002405F0
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用RoleListIter()或GetRoleListBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] RoleList()
		{
			ForgeFormula forgeFormula = this;
			return forgeFormula.GetRoleListArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600767E RID: 30334 RVA: 0x00242414 File Offset: 0x00240614
		[NullableContext(1)]
		public readonly IEnumerable<int> RoleListIter()
		{
			ForgeFormula.<RoleListIter>d__43 <RoleListIter>d__ = new ForgeFormula.<RoleListIter>d__43(-2);
			<RoleListIter>d__.<>3__<>4__this = this;
			return <RoleListIter>d__;
		}

		// Token: 0x04004D3B RID: 19771
		private Table __p;
	}
}
