using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000DB1 RID: 3505
	public struct FormationMotion : IFlatbufferObject
	{
		// Token: 0x17001469 RID: 5225
		// (get) Token: 0x06007C95 RID: 31893 RVA: 0x0026123D File Offset: 0x0025F43D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06007C96 RID: 31894 RVA: 0x0026124A File Offset: 0x0025F44A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06007C97 RID: 31895 RVA: 0x00261254 File Offset: 0x0025F454
		public static FormationMotion GetRootAsFormationMotion(ByteBuffer _bb)
		{
			return FormationMotion.GetRootAsFormationMotion(_bb, default(FormationMotion));
		}

		// Token: 0x06007C98 RID: 31896 RVA: 0x00261270 File Offset: 0x0025F470
		public static FormationMotion GetRootAsFormationMotion(ByteBuffer _bb, FormationMotion obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06007C99 RID: 31897 RVA: 0x0026128D File Offset: 0x0025F48D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06007C9A RID: 31898 RVA: 0x0026129C File Offset: 0x0025F49C
		public FormationMotion __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700146A RID: 5226
		// (get) Token: 0x06007C9B RID: 31899 RVA: 0x002612AC File Offset: 0x0025F4AC
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

		// Token: 0x1700146B RID: 5227
		// (get) Token: 0x06007C9C RID: 31900 RVA: 0x002612E8 File Offset: 0x0025F4E8
		public int RoleId
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

		// Token: 0x1700146C RID: 5228
		// (get) Token: 0x06007C9D RID: 31901 RVA: 0x00261324 File Offset: 0x0025F524
		public int SkinId
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

		// Token: 0x1700146D RID: 5229
		// (get) Token: 0x06007C9E RID: 31902 RVA: 0x00261360 File Offset: 0x0025F560
		public int Position
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

		// Token: 0x1700146E RID: 5230
		// (get) Token: 0x06007C9F RID: 31903 RVA: 0x002613A0 File Offset: 0x0025F5A0
		public Vector? FocusPos
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return null;
				}
				return new Vector?(default(Vector).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700146F RID: 5231
		// (get) Token: 0x06007CA0 RID: 31904 RVA: 0x00261400 File Offset: 0x0025F600
		public Vector? Offset
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return null;
				}
				return new Vector?(default(Vector).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17001470 RID: 5232
		// (get) Token: 0x06007CA1 RID: 31905 RVA: 0x00261460 File Offset: 0x0025F660
		public Vector? OffsetRotation
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return null;
				}
				return new Vector?(default(Vector).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x06007CA2 RID: 31906 RVA: 0x002614C0 File Offset: 0x0025F6C0
		public int OffsetTopUI(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001471 RID: 5233
		// (get) Token: 0x06007CA3 RID: 31907 RVA: 0x00261500 File Offset: 0x0025F700
		public int OffsetTopUILength
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

		// Token: 0x06007CA4 RID: 31908 RVA: 0x0026152C File Offset: 0x0025F72C
		public Span<int> GetOffsetTopUIBytes()
		{
			return this.__p.__vector_as_span<int>(18, 4);
		}

		// Token: 0x06007CA5 RID: 31909 RVA: 0x0026153C File Offset: 0x0025F73C
		public int[] GetOffsetTopUIArray()
		{
			return this.__p.__vector_as_array<int>(18) ?? Array.Empty<int>();
		}

		// Token: 0x06007CA6 RID: 31910 RVA: 0x00261554 File Offset: 0x0025F754
		public int OffsetBottomUI(int j)
		{
			int num = this.__p.__offset(20);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001472 RID: 5234
		// (get) Token: 0x06007CA7 RID: 31911 RVA: 0x00261594 File Offset: 0x0025F794
		public int OffsetBottomUILength
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06007CA8 RID: 31912 RVA: 0x002615C0 File Offset: 0x0025F7C0
		public Span<int> GetOffsetBottomUIBytes()
		{
			return this.__p.__vector_as_span<int>(20, 4);
		}

		// Token: 0x06007CA9 RID: 31913 RVA: 0x002615D0 File Offset: 0x0025F7D0
		public int[] GetOffsetBottomUIArray()
		{
			return this.__p.__vector_as_array<int>(20) ?? Array.Empty<int>();
		}

		// Token: 0x06007CAA RID: 31914 RVA: 0x002615E8 File Offset: 0x0025F7E8
		[NullableContext(1)]
		public int[] OffsetBottomUI()
		{
			return this.GetOffsetBottomUIArray();
		}

		// Token: 0x06007CAB RID: 31915 RVA: 0x002615F0 File Offset: 0x0025F7F0
		[NullableContext(1)]
		public IEnumerable<int> OffsetBottomUIIter()
		{
			FormationMotion.<OffsetBottomUIIter>d__33 <OffsetBottomUIIter>d__ = new FormationMotion.<OffsetBottomUIIter>d__33(-2);
			<OffsetBottomUIIter>d__.<>3__<>4__this = this;
			return <OffsetBottomUIIter>d__;
		}

		// Token: 0x06007CAC RID: 31916 RVA: 0x00261605 File Offset: 0x0025F805
		[NullableContext(1)]
		public int[] OffsetTopUI()
		{
			return this.GetOffsetTopUIArray();
		}

		// Token: 0x06007CAD RID: 31917 RVA: 0x0026160D File Offset: 0x0025F80D
		[NullableContext(1)]
		public IEnumerable<int> OffsetTopUIIter()
		{
			FormationMotion.<OffsetTopUIIter>d__35 <OffsetTopUIIter>d__ = new FormationMotion.<OffsetTopUIIter>d__35(-2);
			<OffsetTopUIIter>d__.<>3__<>4__this = this;
			return <OffsetTopUIIter>d__;
		}

		// Token: 0x04005321 RID: 21281
		private Table __p;
	}
}
