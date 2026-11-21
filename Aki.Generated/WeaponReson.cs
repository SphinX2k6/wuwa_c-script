using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020012D0 RID: 4816
	public struct WeaponReson : IFlatbufferObject
	{
		// Token: 0x1700416C RID: 16748
		// (get) Token: 0x0600F58A RID: 62858 RVA: 0x0036DF39 File Offset: 0x0036C139
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600F58B RID: 62859 RVA: 0x0036DF46 File Offset: 0x0036C146
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600F58C RID: 62860 RVA: 0x0036DF50 File Offset: 0x0036C150
		public static WeaponReson GetRootAsWeaponReson(ByteBuffer _bb)
		{
			return WeaponReson.GetRootAsWeaponReson(_bb, default(WeaponReson));
		}

		// Token: 0x0600F58D RID: 62861 RVA: 0x0036DF6C File Offset: 0x0036C16C
		public static WeaponReson GetRootAsWeaponReson(ByteBuffer _bb, WeaponReson obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600F58E RID: 62862 RVA: 0x0036DF89 File Offset: 0x0036C189
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600F58F RID: 62863 RVA: 0x0036DF98 File Offset: 0x0036C198
		public WeaponReson __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700416D RID: 16749
		// (get) Token: 0x0600F590 RID: 62864 RVA: 0x0036DFA8 File Offset: 0x0036C1A8
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

		// Token: 0x1700416E RID: 16750
		// (get) Token: 0x0600F591 RID: 62865 RVA: 0x0036DFE4 File Offset: 0x0036C1E4
		public int ResonId
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

		// Token: 0x1700416F RID: 16751
		// (get) Token: 0x0600F592 RID: 62866 RVA: 0x0036E020 File Offset: 0x0036C220
		public int Level
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

		// Token: 0x17004170 RID: 16752
		// (get) Token: 0x0600F593 RID: 62867 RVA: 0x0036E05C File Offset: 0x0036C25C
		public string Name
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600F594 RID: 62868 RVA: 0x0036E094 File Offset: 0x0036C294
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600F595 RID: 62869 RVA: 0x0036E0A4 File Offset: 0x0036C2A4
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x0600F596 RID: 62870 RVA: 0x0036E0BC File Offset: 0x0036C2BC
		public long Effect(int j)
		{
			int num = this.__p.__offset(12);
			return (long)((num != 0) ? this.__p.bb.GetDouble(this.__p.__vector(num) + j * 8) : 0.0);
		}

		// Token: 0x17004171 RID: 16753
		// (get) Token: 0x0600F597 RID: 62871 RVA: 0x0036E108 File Offset: 0x0036C308
		public int EffectLength
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

		// Token: 0x0600F598 RID: 62872 RVA: 0x0036E134 File Offset: 0x0036C334
		public Span<long> GetEffectBytes()
		{
			return MemoryMarshal.Cast<double, long>(this.__p.__vector_as_span<double>(12, 8));
		}

		// Token: 0x0600F599 RID: 62873 RVA: 0x0036E149 File Offset: 0x0036C349
		public long[] GetEffectArray()
		{
			return Array.ConvertAll<double, long>(this.__p.__vector_as_array<double>(12) ?? Array.Empty<double>(), (double x) => (long)x);
		}

		// Token: 0x17004172 RID: 16754
		// (get) Token: 0x0600F59A RID: 62874 RVA: 0x0036E188 File Offset: 0x0036C388
		public int Consume
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

		// Token: 0x17004173 RID: 16755
		// (get) Token: 0x0600F59B RID: 62875 RVA: 0x0036E1C8 File Offset: 0x0036C3C8
		public int GoldConsume
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

		// Token: 0x17004174 RID: 16756
		// (get) Token: 0x0600F59C RID: 62876 RVA: 0x0036E208 File Offset: 0x0036C408
		public int MaterialPlaceType
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

		// Token: 0x0600F59D RID: 62877 RVA: 0x0036E248 File Offset: 0x0036C448
		public int AlternativeConsume(int j)
		{
			int num = this.__p.__offset(20);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17004175 RID: 16757
		// (get) Token: 0x0600F59E RID: 62878 RVA: 0x0036E288 File Offset: 0x0036C488
		public int AlternativeConsumeLength
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

		// Token: 0x0600F59F RID: 62879 RVA: 0x0036E2B4 File Offset: 0x0036C4B4
		public Span<int> GetAlternativeConsumeBytes()
		{
			return this.__p.__vector_as_span<int>(20, 4);
		}

		// Token: 0x0600F5A0 RID: 62880 RVA: 0x0036E2C4 File Offset: 0x0036C4C4
		public int[] GetAlternativeConsumeArray()
		{
			return this.__p.__vector_as_array<int>(20) ?? Array.Empty<int>();
		}

		// Token: 0x0600F5A1 RID: 62881 RVA: 0x0036E2DC File Offset: 0x0036C4DC
		[NullableContext(1)]
		public int[] AlternativeConsume()
		{
			return this.GetAlternativeConsumeArray();
		}

		// Token: 0x0600F5A2 RID: 62882 RVA: 0x0036E2E4 File Offset: 0x0036C4E4
		[NullableContext(1)]
		public IEnumerable<int> AlternativeConsumeIter()
		{
			WeaponReson.<AlternativeConsumeIter>d__35 <AlternativeConsumeIter>d__ = new WeaponReson.<AlternativeConsumeIter>d__35(-2);
			<AlternativeConsumeIter>d__.<>3__<>4__this = this;
			return <AlternativeConsumeIter>d__;
		}

		// Token: 0x0600F5A3 RID: 62883 RVA: 0x0036E2F9 File Offset: 0x0036C4F9
		[NullableContext(1)]
		public long[] Effect()
		{
			return this.GetEffectArray();
		}

		// Token: 0x0600F5A4 RID: 62884 RVA: 0x0036E301 File Offset: 0x0036C501
		[NullableContext(1)]
		public IEnumerable<long> EffectIter()
		{
			WeaponReson.<EffectIter>d__37 <EffectIter>d__ = new WeaponReson.<EffectIter>d__37(-2);
			<EffectIter>d__.<>3__<>4__this = this;
			return <EffectIter>d__;
		}

		// Token: 0x04005928 RID: 22824
		private Table __p;
	}
}
