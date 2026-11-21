using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001022 RID: 4130
	public struct PinballWeaponConfig : IFlatbufferObject
	{
		// Token: 0x17002A5C RID: 10844
		// (get) Token: 0x0600B6BF RID: 46783 RVA: 0x002E218D File Offset: 0x002E038D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600B6C0 RID: 46784 RVA: 0x002E219A File Offset: 0x002E039A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600B6C1 RID: 46785 RVA: 0x002E21A4 File Offset: 0x002E03A4
		public static PinballWeaponConfig GetRootAsPinballWeaponConfig(ByteBuffer _bb)
		{
			return PinballWeaponConfig.GetRootAsPinballWeaponConfig(_bb, default(PinballWeaponConfig));
		}

		// Token: 0x0600B6C2 RID: 46786 RVA: 0x002E21C0 File Offset: 0x002E03C0
		public static PinballWeaponConfig GetRootAsPinballWeaponConfig(ByteBuffer _bb, PinballWeaponConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600B6C3 RID: 46787 RVA: 0x002E21DD File Offset: 0x002E03DD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600B6C4 RID: 46788 RVA: 0x002E21EC File Offset: 0x002E03EC
		public PinballWeaponConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002A5D RID: 10845
		// (get) Token: 0x0600B6C5 RID: 46789 RVA: 0x002E21FC File Offset: 0x002E03FC
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

		// Token: 0x17002A5E RID: 10846
		// (get) Token: 0x0600B6C6 RID: 46790 RVA: 0x002E2238 File Offset: 0x002E0438
		public int ActivityId
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

		// Token: 0x17002A5F RID: 10847
		// (get) Token: 0x0600B6C7 RID: 46791 RVA: 0x002E2274 File Offset: 0x002E0474
		public int PersonType
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

		// Token: 0x17002A60 RID: 10848
		// (get) Token: 0x0600B6C8 RID: 46792 RVA: 0x002E22B0 File Offset: 0x002E04B0
		public int Type
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

		// Token: 0x17002A61 RID: 10849
		// (get) Token: 0x0600B6C9 RID: 46793 RVA: 0x002E22F0 File Offset: 0x002E04F0
		public int QualityId
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

		// Token: 0x0600B6CA RID: 46794 RVA: 0x002E2330 File Offset: 0x002E0530
		public int PropList(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002A62 RID: 10850
		// (get) Token: 0x0600B6CB RID: 46795 RVA: 0x002E2370 File Offset: 0x002E0570
		public int PropListLength
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600B6CC RID: 46796 RVA: 0x002E239C File Offset: 0x002E059C
		public Span<int> GetPropListBytes()
		{
			return this.__p.__vector_as_span<int>(14, 4);
		}

		// Token: 0x0600B6CD RID: 46797 RVA: 0x002E23AC File Offset: 0x002E05AC
		public int[] GetPropListArray()
		{
			return this.__p.__vector_as_array<int>(14) ?? Array.Empty<int>();
		}

		// Token: 0x17002A63 RID: 10851
		// (get) Token: 0x0600B6CE RID: 46798 RVA: 0x002E23C4 File Offset: 0x002E05C4
		public int MainEntry
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

		// Token: 0x17002A64 RID: 10852
		// (get) Token: 0x0600B6CF RID: 46799 RVA: 0x002E2404 File Offset: 0x002E0604
		public string Name
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600B6D0 RID: 46800 RVA: 0x002E243C File Offset: 0x002E063C
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0600B6D1 RID: 46801 RVA: 0x002E244C File Offset: 0x002E064C
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x17002A65 RID: 10853
		// (get) Token: 0x0600B6D2 RID: 46802 RVA: 0x002E2464 File Offset: 0x002E0664
		public string AttributesDescription
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

		// Token: 0x0600B6D3 RID: 46803 RVA: 0x002E249C File Offset: 0x002E069C
		public Span<byte> GetAttributesDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x0600B6D4 RID: 46804 RVA: 0x002E24AC File Offset: 0x002E06AC
		public byte[] GetAttributesDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x17002A66 RID: 10854
		// (get) Token: 0x0600B6D5 RID: 46805 RVA: 0x002E24C4 File Offset: 0x002E06C4
		public string Icon
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

		// Token: 0x0600B6D6 RID: 46806 RVA: 0x002E24FC File Offset: 0x002E06FC
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x0600B6D7 RID: 46807 RVA: 0x002E250C File Offset: 0x002E070C
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x17002A67 RID: 10855
		// (get) Token: 0x0600B6D8 RID: 46808 RVA: 0x002E2524 File Offset: 0x002E0724
		public int SortId
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17002A68 RID: 10856
		// (get) Token: 0x0600B6D9 RID: 46809 RVA: 0x002E2564 File Offset: 0x002E0764
		public int FragmentNum
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return 100;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600B6DA RID: 46810 RVA: 0x002E25A2 File Offset: 0x002E07A2
		[NullableContext(1)]
		public int[] PropList()
		{
			return this.GetPropListArray();
		}

		// Token: 0x0600B6DB RID: 46811 RVA: 0x002E25AA File Offset: 0x002E07AA
		[NullableContext(1)]
		public IEnumerable<int> PropListIter()
		{
			PinballWeaponConfig.<PropListIter>d__42 <PropListIter>d__ = new PinballWeaponConfig.<PropListIter>d__42(-2);
			<PropListIter>d__.<>3__<>4__this = this;
			return <PropListIter>d__;
		}

		// Token: 0x040055EC RID: 21996
		private Table __p;
	}
}
