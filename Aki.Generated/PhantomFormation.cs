using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000FCD RID: 4045
	public struct PhantomFormation : IFlatbufferObject
	{
		// Token: 0x17002736 RID: 10038
		// (get) Token: 0x0600AED1 RID: 44753 RVA: 0x002D06C0 File Offset: 0x002CE8C0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600AED2 RID: 44754 RVA: 0x002D06CD File Offset: 0x002CE8CD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600AED3 RID: 44755 RVA: 0x002D06D4 File Offset: 0x002CE8D4
		public static PhantomFormation GetRootAsPhantomFormation(ByteBuffer _bb)
		{
			return PhantomFormation.GetRootAsPhantomFormation(_bb, default(PhantomFormation));
		}

		// Token: 0x0600AED4 RID: 44756 RVA: 0x002D06F0 File Offset: 0x002CE8F0
		public static PhantomFormation GetRootAsPhantomFormation(ByteBuffer _bb, PhantomFormation obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600AED5 RID: 44757 RVA: 0x002D070D File Offset: 0x002CE90D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600AED6 RID: 44758 RVA: 0x002D071C File Offset: 0x002CE91C
		public PhantomFormation __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002737 RID: 10039
		// (get) Token: 0x0600AED7 RID: 44759 RVA: 0x002D072C File Offset: 0x002CE92C
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

		// Token: 0x0600AED8 RID: 44760 RVA: 0x002D0768 File Offset: 0x002CE968
		public int Roles(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002738 RID: 10040
		// (get) Token: 0x0600AED9 RID: 44761 RVA: 0x002D07A8 File Offset: 0x002CE9A8
		public int RolesLength
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600AEDA RID: 44762 RVA: 0x002D07D3 File Offset: 0x002CE9D3
		public Span<int> GetRolesBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x0600AEDB RID: 44763 RVA: 0x002D07E2 File Offset: 0x002CE9E2
		public int[] GetRolesArray()
		{
			return this.__p.__vector_as_array<int>(6) ?? Array.Empty<int>();
		}

		// Token: 0x0600AEDC RID: 44764 RVA: 0x002D07F9 File Offset: 0x002CE9F9
		[NullableContext(1)]
		public int[] Roles()
		{
			return this.GetRolesArray();
		}

		// Token: 0x0600AEDD RID: 44765 RVA: 0x002D0801 File Offset: 0x002CEA01
		[NullableContext(1)]
		public IEnumerable<int> RolesIter()
		{
			PhantomFormation.<RolesIter>d__16 <RolesIter>d__ = new PhantomFormation.<RolesIter>d__16(-2);
			<RolesIter>d__.<>3__<>4__this = this;
			return <RolesIter>d__;
		}

		// Token: 0x0400558F RID: 21903
		private Table __p;
	}
}
