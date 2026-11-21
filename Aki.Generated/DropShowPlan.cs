using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000CF6 RID: 3318
	public struct DropShowPlan : IFlatbufferObject
	{
		// Token: 0x17000E46 RID: 3654
		// (get) Token: 0x06006BF7 RID: 27639 RVA: 0x0023BC24 File Offset: 0x00239E24
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06006BF8 RID: 27640 RVA: 0x0023BC31 File Offset: 0x00239E31
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06006BF9 RID: 27641 RVA: 0x0023BC38 File Offset: 0x00239E38
		public static DropShowPlan GetRootAsDropShowPlan(ByteBuffer _bb)
		{
			return DropShowPlan.GetRootAsDropShowPlan(_bb, default(DropShowPlan));
		}

		// Token: 0x06006BFA RID: 27642 RVA: 0x0023BC54 File Offset: 0x00239E54
		public static DropShowPlan GetRootAsDropShowPlan(ByteBuffer _bb, DropShowPlan obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06006BFB RID: 27643 RVA: 0x0023BC71 File Offset: 0x00239E71
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06006BFC RID: 27644 RVA: 0x0023BC80 File Offset: 0x00239E80
		public DropShowPlan __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000E47 RID: 3655
		// (get) Token: 0x06006BFD RID: 27645 RVA: 0x0023BC90 File Offset: 0x00239E90
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

		// Token: 0x06006BFE RID: 27646 RVA: 0x0023BCCC File Offset: 0x00239ECC
		public int Force(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000E48 RID: 3656
		// (get) Token: 0x06006BFF RID: 27647 RVA: 0x0023BD0C File Offset: 0x00239F0C
		public int ForceLength
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

		// Token: 0x06006C00 RID: 27648 RVA: 0x0023BD37 File Offset: 0x00239F37
		public Span<int> GetForceBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x06006C01 RID: 27649 RVA: 0x0023BD46 File Offset: 0x00239F46
		public int[] GetForceArray()
		{
			return this.__p.__vector_as_array<int>(6) ?? Array.Empty<int>();
		}

		// Token: 0x06006C02 RID: 27650 RVA: 0x0023BD60 File Offset: 0x00239F60
		public int Angle(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000E49 RID: 3657
		// (get) Token: 0x06006C03 RID: 27651 RVA: 0x0023BDA0 File Offset: 0x00239FA0
		public int AngleLength
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06006C04 RID: 27652 RVA: 0x0023BDCB File Offset: 0x00239FCB
		public Span<int> GetAngleBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x06006C05 RID: 27653 RVA: 0x0023BDDA File Offset: 0x00239FDA
		public int[] GetAngleArray()
		{
			return this.__p.__vector_as_array<int>(8) ?? Array.Empty<int>();
		}

		// Token: 0x06006C06 RID: 27654 RVA: 0x0023BDF4 File Offset: 0x00239FF4
		public int VerticalAngle(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000E4A RID: 3658
		// (get) Token: 0x06006C07 RID: 27655 RVA: 0x0023BE34 File Offset: 0x0023A034
		public int VerticalAngleLength
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06006C08 RID: 27656 RVA: 0x0023BE60 File Offset: 0x0023A060
		public Span<int> GetVerticalAngleBytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x06006C09 RID: 27657 RVA: 0x0023BE70 File Offset: 0x0023A070
		public int[] GetVerticalAngleArray()
		{
			return this.__p.__vector_as_array<int>(10) ?? Array.Empty<int>();
		}

		// Token: 0x17000E4B RID: 3659
		// (get) Token: 0x06006C0A RID: 27658 RVA: 0x0023BE88 File Offset: 0x0023A088
		public int ShowBg
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

		// Token: 0x17000E4C RID: 3660
		// (get) Token: 0x06006C0B RID: 27659 RVA: 0x0023BEC8 File Offset: 0x0023A0C8
		public int ShowTime
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 3000;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000E4D RID: 3661
		// (get) Token: 0x06006C0C RID: 27660 RVA: 0x0023BF0C File Offset: 0x0023A10C
		public int ShowCout
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 7;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000E4E RID: 3662
		// (get) Token: 0x06006C0D RID: 27661 RVA: 0x0023BF4C File Offset: 0x0023A14C
		public int Adsorption
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

		// Token: 0x06006C0E RID: 27662 RVA: 0x0023BF89 File Offset: 0x0023A189
		[NullableContext(1)]
		public int[] Angle()
		{
			return this.GetAngleArray();
		}

		// Token: 0x06006C0F RID: 27663 RVA: 0x0023BF91 File Offset: 0x0023A191
		[NullableContext(1)]
		public IEnumerable<int> AngleIter()
		{
			DropShowPlan.<AngleIter>d__34 <AngleIter>d__ = new DropShowPlan.<AngleIter>d__34(-2);
			<AngleIter>d__.<>3__<>4__this = this;
			return <AngleIter>d__;
		}

		// Token: 0x06006C10 RID: 27664 RVA: 0x0023BFA6 File Offset: 0x0023A1A6
		[NullableContext(1)]
		public int[] Force()
		{
			return this.GetForceArray();
		}

		// Token: 0x06006C11 RID: 27665 RVA: 0x0023BFAE File Offset: 0x0023A1AE
		[NullableContext(1)]
		public IEnumerable<int> ForceIter()
		{
			DropShowPlan.<ForceIter>d__36 <ForceIter>d__ = new DropShowPlan.<ForceIter>d__36(-2);
			<ForceIter>d__.<>3__<>4__this = this;
			return <ForceIter>d__;
		}

		// Token: 0x06006C12 RID: 27666 RVA: 0x0023BFC3 File Offset: 0x0023A1C3
		[NullableContext(1)]
		public int[] VerticalAngle()
		{
			return this.GetVerticalAngleArray();
		}

		// Token: 0x06006C13 RID: 27667 RVA: 0x0023BFCB File Offset: 0x0023A1CB
		[NullableContext(1)]
		public IEnumerable<int> VerticalAngleIter()
		{
			DropShowPlan.<VerticalAngleIter>d__38 <VerticalAngleIter>d__ = new DropShowPlan.<VerticalAngleIter>d__38(-2);
			<VerticalAngleIter>d__.<>3__<>4__this = this;
			return <VerticalAngleIter>d__;
		}

		// Token: 0x04005234 RID: 21044
		private Table __p;
	}
}
