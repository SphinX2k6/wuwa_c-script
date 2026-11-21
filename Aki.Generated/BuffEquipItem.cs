using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C34 RID: 3124
	public struct BuffEquipItem : IFlatbufferObject
	{
		// Token: 0x170006A9 RID: 1705
		// (get) Token: 0x060056B5 RID: 22197 RVA: 0x0020BC5E File Offset: 0x00209E5E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060056B6 RID: 22198 RVA: 0x0020BC6B File Offset: 0x00209E6B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060056B7 RID: 22199 RVA: 0x0020BC74 File Offset: 0x00209E74
		public static BuffEquipItem GetRootAsBuffEquipItem(ByteBuffer _bb)
		{
			return BuffEquipItem.GetRootAsBuffEquipItem(_bb, default(BuffEquipItem));
		}

		// Token: 0x060056B8 RID: 22200 RVA: 0x0020BC90 File Offset: 0x00209E90
		public static BuffEquipItem GetRootAsBuffEquipItem(ByteBuffer _bb, BuffEquipItem obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060056B9 RID: 22201 RVA: 0x0020BCAD File Offset: 0x00209EAD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060056BA RID: 22202 RVA: 0x0020BCBC File Offset: 0x00209EBC
		public BuffEquipItem __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170006AA RID: 1706
		// (get) Token: 0x060056BB RID: 22203 RVA: 0x0020BCCC File Offset: 0x00209ECC
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

		// Token: 0x170006AB RID: 1707
		// (get) Token: 0x060056BC RID: 22204 RVA: 0x0020BD08 File Offset: 0x00209F08
		public int ItemId
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

		// Token: 0x170006AC RID: 1708
		// (get) Token: 0x060056BD RID: 22205 RVA: 0x0020BD44 File Offset: 0x00209F44
		public int RoleId
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

		// Token: 0x170006AD RID: 1709
		// (get) Token: 0x060056BE RID: 22206 RVA: 0x0020BD80 File Offset: 0x00209F80
		public int WearPos
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

		// Token: 0x060056BF RID: 22207 RVA: 0x0020BDC0 File Offset: 0x00209FC0
		public long Buffs(int j)
		{
			int num = this.__p.__offset(12);
			return (long)((num != 0) ? this.__p.bb.GetDouble(this.__p.__vector(num) + j * 8) : 0.0);
		}

		// Token: 0x170006AE RID: 1710
		// (get) Token: 0x060056C0 RID: 22208 RVA: 0x0020BE0C File Offset: 0x0020A00C
		public int BuffsLength
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

		// Token: 0x060056C1 RID: 22209 RVA: 0x0020BE38 File Offset: 0x0020A038
		public Span<long> GetBuffsBytes()
		{
			return MemoryMarshal.Cast<double, long>(this.__p.__vector_as_span<double>(12, 8));
		}

		// Token: 0x060056C2 RID: 22210 RVA: 0x0020BE4D File Offset: 0x0020A04D
		public long[] GetBuffsArray()
		{
			return Array.ConvertAll<double, long>(this.__p.__vector_as_array<double>(12) ?? Array.Empty<double>(), (double x) => (long)x);
		}

		// Token: 0x170006AF RID: 1711
		// (get) Token: 0x060056C3 RID: 22211 RVA: 0x0020BE8C File Offset: 0x0020A08C
		public string EquipTips
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

		// Token: 0x060056C4 RID: 22212 RVA: 0x0020BEC4 File Offset: 0x0020A0C4
		public Span<byte> GetEquipTipsBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x060056C5 RID: 22213 RVA: 0x0020BED4 File Offset: 0x0020A0D4
		public byte[] GetEquipTipsArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x170006B0 RID: 1712
		// (get) Token: 0x060056C6 RID: 22214 RVA: 0x0020BEEC File Offset: 0x0020A0EC
		public string UnEquipTips
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

		// Token: 0x060056C7 RID: 22215 RVA: 0x0020BF24 File Offset: 0x0020A124
		public Span<byte> GetUnEquipTipsBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x060056C8 RID: 22216 RVA: 0x0020BF34 File Offset: 0x0020A134
		public byte[] GetUnEquipTipsArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x170006B1 RID: 1713
		// (get) Token: 0x060056C9 RID: 22217 RVA: 0x0020BF4C File Offset: 0x0020A14C
		public bool EnableInUI
		{
			get
			{
				int num = this.__p.__offset(18);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x060056CA RID: 22218 RVA: 0x0020BF8C File Offset: 0x0020A18C
		[NullableContext(1)]
		public long[] Buffs()
		{
			return this.GetBuffsArray();
		}

		// Token: 0x060056CB RID: 22219 RVA: 0x0020BF94 File Offset: 0x0020A194
		[NullableContext(1)]
		public IEnumerable<long> BuffsIter()
		{
			BuffEquipItem.<BuffsIter>d__32 <BuffsIter>d__ = new BuffEquipItem.<BuffsIter>d__32(-2);
			<BuffsIter>d__.<>3__<>4__this = this;
			return <BuffsIter>d__;
		}

		// Token: 0x04005131 RID: 20785
		private Table __p;
	}
}
