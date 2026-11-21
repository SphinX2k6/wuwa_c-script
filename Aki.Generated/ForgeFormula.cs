using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000DAF RID: 3503
	public struct ForgeFormula : IFlatbufferObject
	{
		// Token: 0x17001457 RID: 5207
		// (get) Token: 0x06007C6B RID: 31851 RVA: 0x00260C3B File Offset: 0x0025EE3B
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06007C6C RID: 31852 RVA: 0x00260C48 File Offset: 0x0025EE48
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06007C6D RID: 31853 RVA: 0x00260C50 File Offset: 0x0025EE50
		public static ForgeFormula GetRootAsForgeFormula(ByteBuffer _bb)
		{
			return ForgeFormula.GetRootAsForgeFormula(_bb, default(ForgeFormula));
		}

		// Token: 0x06007C6E RID: 31854 RVA: 0x00260C6C File Offset: 0x0025EE6C
		public static ForgeFormula GetRootAsForgeFormula(ByteBuffer _bb, ForgeFormula obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06007C6F RID: 31855 RVA: 0x00260C89 File Offset: 0x0025EE89
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06007C70 RID: 31856 RVA: 0x00260C98 File Offset: 0x0025EE98
		public ForgeFormula __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001458 RID: 5208
		// (get) Token: 0x06007C71 RID: 31857 RVA: 0x00260CA8 File Offset: 0x0025EEA8
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

		// Token: 0x17001459 RID: 5209
		// (get) Token: 0x06007C72 RID: 31858 RVA: 0x00260CE4 File Offset: 0x0025EEE4
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

		// Token: 0x1700145A RID: 5210
		// (get) Token: 0x06007C73 RID: 31859 RVA: 0x00260D20 File Offset: 0x0025EF20
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

		// Token: 0x1700145B RID: 5211
		// (get) Token: 0x06007C74 RID: 31860 RVA: 0x00260D5C File Offset: 0x0025EF5C
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

		// Token: 0x1700145C RID: 5212
		// (get) Token: 0x06007C75 RID: 31861 RVA: 0x00260D9C File Offset: 0x0025EF9C
		public bool Unlock
		{
			get
			{
				int num = this.__p.__offset(12);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700145D RID: 5213
		// (get) Token: 0x06007C76 RID: 31862 RVA: 0x00260DDC File Offset: 0x0025EFDC
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

		// Token: 0x1700145E RID: 5214
		// (get) Token: 0x06007C77 RID: 31863 RVA: 0x00260E1C File Offset: 0x0025F01C
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

		// Token: 0x06007C78 RID: 31864 RVA: 0x00260E54 File Offset: 0x0025F054
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x06007C79 RID: 31865 RVA: 0x00260E64 File Offset: 0x0025F064
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x06007C7A RID: 31866 RVA: 0x00260E7C File Offset: 0x0025F07C
		public OneItemConfig? ConsumeItems(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return null;
			}
			return new OneItemConfig?(default(OneItemConfig).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700145F RID: 5215
		// (get) Token: 0x06007C7B RID: 31867 RVA: 0x00260EE0 File Offset: 0x0025F0E0
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

		// Token: 0x17001460 RID: 5216
		// (get) Token: 0x06007C7C RID: 31868 RVA: 0x00260F0C File Offset: 0x0025F10C
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

		// Token: 0x06007C7D RID: 31869 RVA: 0x00260F44 File Offset: 0x0025F144
		public Span<byte> GetForgeContentBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x06007C7E RID: 31870 RVA: 0x00260F54 File Offset: 0x0025F154
		public byte[] GetForgeContentArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x17001461 RID: 5217
		// (get) Token: 0x06007C7F RID: 31871 RVA: 0x00260F6C File Offset: 0x0025F16C
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

		// Token: 0x06007C80 RID: 31872 RVA: 0x00260FA4 File Offset: 0x0025F1A4
		public Span<byte> GetBackgroundBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x06007C81 RID: 31873 RVA: 0x00260FB4 File Offset: 0x0025F1B4
		public byte[] GetBackgroundArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x06007C82 RID: 31874 RVA: 0x00260FCC File Offset: 0x0025F1CC
		public int RoleList(int j)
		{
			int num = this.__p.__offset(24);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001462 RID: 5218
		// (get) Token: 0x06007C83 RID: 31875 RVA: 0x0026100C File Offset: 0x0025F20C
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

		// Token: 0x06007C84 RID: 31876 RVA: 0x00261038 File Offset: 0x0025F238
		public Span<int> GetRoleListBytes()
		{
			return this.__p.__vector_as_span<int>(24, 4);
		}

		// Token: 0x06007C85 RID: 31877 RVA: 0x00261048 File Offset: 0x0025F248
		public int[] GetRoleListArray()
		{
			return this.__p.__vector_as_array<int>(24) ?? Array.Empty<int>();
		}

		// Token: 0x06007C86 RID: 31878 RVA: 0x00261060 File Offset: 0x0025F260
		[NullableContext(1)]
		public OneItemConfig[] ConsumeItems()
		{
			return this.ConsumeItemsIter().ToArray<OneItemConfig>();
		}

		// Token: 0x06007C87 RID: 31879 RVA: 0x0026106D File Offset: 0x0025F26D
		[NullableContext(1)]
		public IEnumerable<OneItemConfig> ConsumeItemsIter()
		{
			ForgeFormula.<ConsumeItemsIter>d__41 <ConsumeItemsIter>d__ = new ForgeFormula.<ConsumeItemsIter>d__41(-2);
			<ConsumeItemsIter>d__.<>3__<>4__this = this;
			return <ConsumeItemsIter>d__;
		}

		// Token: 0x06007C88 RID: 31880 RVA: 0x00261082 File Offset: 0x0025F282
		[NullableContext(1)]
		public int[] RoleList()
		{
			return this.GetRoleListArray();
		}

		// Token: 0x06007C89 RID: 31881 RVA: 0x0026108A File Offset: 0x0025F28A
		[NullableContext(1)]
		public IEnumerable<int> RoleListIter()
		{
			ForgeFormula.<RoleListIter>d__43 <RoleListIter>d__ = new ForgeFormula.<RoleListIter>d__43(-2);
			<RoleListIter>d__.<>3__<>4__this = this;
			return <RoleListIter>d__;
		}

		// Token: 0x0400531F RID: 21279
		private Table __p;
	}
}
