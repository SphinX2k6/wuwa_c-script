using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000CF7 RID: 3319
	public struct DualSenseLightBar : IFlatbufferObject
	{
		// Token: 0x17000E4F RID: 3663
		// (get) Token: 0x06006C14 RID: 27668 RVA: 0x0023BFE0 File Offset: 0x0023A1E0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06006C15 RID: 27669 RVA: 0x0023BFED File Offset: 0x0023A1ED
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06006C16 RID: 27670 RVA: 0x0023BFF4 File Offset: 0x0023A1F4
		public static DualSenseLightBar GetRootAsDualSenseLightBar(ByteBuffer _bb)
		{
			return DualSenseLightBar.GetRootAsDualSenseLightBar(_bb, default(DualSenseLightBar));
		}

		// Token: 0x06006C17 RID: 27671 RVA: 0x0023C010 File Offset: 0x0023A210
		public static DualSenseLightBar GetRootAsDualSenseLightBar(ByteBuffer _bb, DualSenseLightBar obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06006C18 RID: 27672 RVA: 0x0023C02D File Offset: 0x0023A22D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06006C19 RID: 27673 RVA: 0x0023C03C File Offset: 0x0023A23C
		public DualSenseLightBar __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000E50 RID: 3664
		// (get) Token: 0x06006C1A RID: 27674 RVA: 0x0023C04C File Offset: 0x0023A24C
		public string Id
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06006C1B RID: 27675 RVA: 0x0023C083 File Offset: 0x0023A283
		public Span<byte> GetIdBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x06006C1C RID: 27676 RVA: 0x0023C092 File Offset: 0x0023A292
		public byte[] GetIdArray()
		{
			return this.__p.__vector_as_array<byte>(4) ?? Array.Empty<byte>();
		}

		// Token: 0x17000E51 RID: 3665
		// (get) Token: 0x06006C1D RID: 27677 RVA: 0x0023C0AC File Offset: 0x0023A2AC
		public int WaveType
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

		// Token: 0x17000E52 RID: 3666
		// (get) Token: 0x06006C1E RID: 27678 RVA: 0x0023C0E8 File Offset: 0x0023A2E8
		public float OnDuration
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000E53 RID: 3667
		// (get) Token: 0x06006C1F RID: 27679 RVA: 0x0023C128 File Offset: 0x0023A328
		public float OffDuration
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06006C20 RID: 27680 RVA: 0x0023C16C File Offset: 0x0023A36C
		public Color? Colors(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new Color?(default(Color).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17000E54 RID: 3668
		// (get) Token: 0x06006C21 RID: 27681 RVA: 0x0023C1D0 File Offset: 0x0023A3D0
		public int ColorsLength
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x17000E55 RID: 3669
		// (get) Token: 0x06006C22 RID: 27682 RVA: 0x0023C1FC File Offset: 0x0023A3FC
		public int Priority
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

		// Token: 0x17000E56 RID: 3670
		// (get) Token: 0x06006C23 RID: 27683 RVA: 0x0023C23C File Offset: 0x0023A43C
		public string ListenTag
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

		// Token: 0x06006C24 RID: 27684 RVA: 0x0023C274 File Offset: 0x0023A474
		public Span<byte> GetListenTagBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x06006C25 RID: 27685 RVA: 0x0023C284 File Offset: 0x0023A484
		public byte[] GetListenTagArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x06006C26 RID: 27686 RVA: 0x0023C29C File Offset: 0x0023A49C
		[NullableContext(1)]
		public Color[] Colors()
		{
			return this.ColorsIter().ToArray<Color>();
		}

		// Token: 0x06006C27 RID: 27687 RVA: 0x0023C2A9 File Offset: 0x0023A4A9
		[NullableContext(1)]
		public IEnumerable<Color> ColorsIter()
		{
			DualSenseLightBar.<ColorsIter>d__28 <ColorsIter>d__ = new DualSenseLightBar.<ColorsIter>d__28(-2);
			<ColorsIter>d__.<>3__<>4__this = this;
			return <ColorsIter>d__;
		}

		// Token: 0x04005235 RID: 21045
		private Table __p;
	}
}
