using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000CE4 RID: 3300
	public struct DrinksDrinkMix : IFlatbufferObject
	{
		// Token: 0x17000D82 RID: 3458
		// (get) Token: 0x060069C4 RID: 27076 RVA: 0x00236AEC File Offset: 0x00234CEC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060069C5 RID: 27077 RVA: 0x00236AF9 File Offset: 0x00234CF9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060069C6 RID: 27078 RVA: 0x00236B00 File Offset: 0x00234D00
		public static DrinksDrinkMix GetRootAsDrinksDrinkMix(ByteBuffer _bb)
		{
			return DrinksDrinkMix.GetRootAsDrinksDrinkMix(_bb, default(DrinksDrinkMix));
		}

		// Token: 0x060069C7 RID: 27079 RVA: 0x00236B1C File Offset: 0x00234D1C
		public static DrinksDrinkMix GetRootAsDrinksDrinkMix(ByteBuffer _bb, DrinksDrinkMix obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060069C8 RID: 27080 RVA: 0x00236B39 File Offset: 0x00234D39
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060069C9 RID: 27081 RVA: 0x00236B48 File Offset: 0x00234D48
		public DrinksDrinkMix __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000D83 RID: 3459
		// (get) Token: 0x060069CA RID: 27082 RVA: 0x00236B58 File Offset: 0x00234D58
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

		// Token: 0x17000D84 RID: 3460
		// (get) Token: 0x060069CB RID: 27083 RVA: 0x00236B94 File Offset: 0x00234D94
		public string Name
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060069CC RID: 27084 RVA: 0x00236BCB File Offset: 0x00234DCB
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x060069CD RID: 27085 RVA: 0x00236BDA File Offset: 0x00234DDA
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17000D85 RID: 3461
		// (get) Token: 0x060069CE RID: 27086 RVA: 0x00236BF4 File Offset: 0x00234DF4
		public string Desc
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060069CF RID: 27087 RVA: 0x00236C2B File Offset: 0x00234E2B
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x060069D0 RID: 27088 RVA: 0x00236C3A File Offset: 0x00234E3A
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x060069D1 RID: 27089 RVA: 0x00236C54 File Offset: 0x00234E54
		public int MixArray(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000D86 RID: 3462
		// (get) Token: 0x060069D2 RID: 27090 RVA: 0x00236C94 File Offset: 0x00234E94
		public int MixArrayLength
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

		// Token: 0x060069D3 RID: 27091 RVA: 0x00236CC0 File Offset: 0x00234EC0
		public Span<int> GetMixArrayBytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x060069D4 RID: 27092 RVA: 0x00236CD0 File Offset: 0x00234ED0
		public int[] GetMixArrayArray()
		{
			return this.__p.__vector_as_array<int>(10) ?? Array.Empty<int>();
		}

		// Token: 0x17000D87 RID: 3463
		// (get) Token: 0x060069D5 RID: 27093 RVA: 0x00236CE8 File Offset: 0x00234EE8
		public string Icon
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060069D6 RID: 27094 RVA: 0x00236D20 File Offset: 0x00234F20
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x060069D7 RID: 27095 RVA: 0x00236D30 File Offset: 0x00234F30
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17000D88 RID: 3464
		// (get) Token: 0x060069D8 RID: 27096 RVA: 0x00236D48 File Offset: 0x00234F48
		public int EffectId
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

		// Token: 0x060069D9 RID: 27097 RVA: 0x00236D85 File Offset: 0x00234F85
		[NullableContext(1)]
		public int[] MixArray()
		{
			return this.GetMixArrayArray();
		}

		// Token: 0x060069DA RID: 27098 RVA: 0x00236D8D File Offset: 0x00234F8D
		[NullableContext(1)]
		public IEnumerable<int> MixArrayIter()
		{
			DrinksDrinkMix.<MixArrayIter>d__30 <MixArrayIter>d__ = new DrinksDrinkMix.<MixArrayIter>d__30(-2);
			<MixArrayIter>d__.<>3__<>4__this = this;
			return <MixArrayIter>d__;
		}

		// Token: 0x0400521A RID: 21018
		private Table __p;
	}
}
