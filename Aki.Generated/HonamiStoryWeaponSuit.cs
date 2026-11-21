using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E38 RID: 3640
	public struct HonamiStoryWeaponSuit : IFlatbufferObject
	{
		// Token: 0x170018D5 RID: 6357
		// (get) Token: 0x06008803 RID: 34819 RVA: 0x0027A404 File Offset: 0x00278604
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06008804 RID: 34820 RVA: 0x0027A411 File Offset: 0x00278611
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06008805 RID: 34821 RVA: 0x0027A418 File Offset: 0x00278618
		public static HonamiStoryWeaponSuit GetRootAsHonamiStoryWeaponSuit(ByteBuffer _bb)
		{
			return HonamiStoryWeaponSuit.GetRootAsHonamiStoryWeaponSuit(_bb, default(HonamiStoryWeaponSuit));
		}

		// Token: 0x06008806 RID: 34822 RVA: 0x0027A434 File Offset: 0x00278634
		public static HonamiStoryWeaponSuit GetRootAsHonamiStoryWeaponSuit(ByteBuffer _bb, HonamiStoryWeaponSuit obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06008807 RID: 34823 RVA: 0x0027A451 File Offset: 0x00278651
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06008808 RID: 34824 RVA: 0x0027A460 File Offset: 0x00278660
		public HonamiStoryWeaponSuit __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170018D6 RID: 6358
		// (get) Token: 0x06008809 RID: 34825 RVA: 0x0027A470 File Offset: 0x00278670
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

		// Token: 0x170018D7 RID: 6359
		// (get) Token: 0x0600880A RID: 34826 RVA: 0x0027A4AC File Offset: 0x002786AC
		public int WeaponPluginType
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

		// Token: 0x170018D8 RID: 6360
		// (get) Token: 0x0600880B RID: 34827 RVA: 0x0027A4E8 File Offset: 0x002786E8
		public int NeedNum
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

		// Token: 0x0600880C RID: 34828 RVA: 0x0027A524 File Offset: 0x00278724
		public int BuffTempId(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170018D9 RID: 6361
		// (get) Token: 0x0600880D RID: 34829 RVA: 0x0027A564 File Offset: 0x00278764
		public int BuffTempIdLength
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

		// Token: 0x0600880E RID: 34830 RVA: 0x0027A590 File Offset: 0x00278790
		public Span<int> GetBuffTempIdBytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x0600880F RID: 34831 RVA: 0x0027A5A0 File Offset: 0x002787A0
		public int[] GetBuffTempIdArray()
		{
			return this.__p.__vector_as_array<int>(10) ?? Array.Empty<int>();
		}

		// Token: 0x170018DA RID: 6362
		// (get) Token: 0x06008810 RID: 34832 RVA: 0x0027A5B8 File Offset: 0x002787B8
		public int EnhanceLevel
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

		// Token: 0x170018DB RID: 6363
		// (get) Token: 0x06008811 RID: 34833 RVA: 0x0027A5F8 File Offset: 0x002787F8
		public string Name
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

		// Token: 0x06008812 RID: 34834 RVA: 0x0027A630 File Offset: 0x00278830
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x06008813 RID: 34835 RVA: 0x0027A640 File Offset: 0x00278840
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x170018DC RID: 6364
		// (get) Token: 0x06008814 RID: 34836 RVA: 0x0027A658 File Offset: 0x00278858
		public string Desc
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

		// Token: 0x06008815 RID: 34837 RVA: 0x0027A690 File Offset: 0x00278890
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x06008816 RID: 34838 RVA: 0x0027A6A0 File Offset: 0x002788A0
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x06008817 RID: 34839 RVA: 0x0027A6B8 File Offset: 0x002788B8
		public string DescArgs(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170018DD RID: 6365
		// (get) Token: 0x06008818 RID: 34840 RVA: 0x0027A6F4 File Offset: 0x002788F4
		public int DescArgsLength
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

		// Token: 0x170018DE RID: 6366
		// (get) Token: 0x06008819 RID: 34841 RVA: 0x0027A720 File Offset: 0x00278920
		public string DescSimple
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

		// Token: 0x0600881A RID: 34842 RVA: 0x0027A758 File Offset: 0x00278958
		public Span<byte> GetDescSimpleBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x0600881B RID: 34843 RVA: 0x0027A768 File Offset: 0x00278968
		public byte[] GetDescSimpleArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x0600881C RID: 34844 RVA: 0x0027A780 File Offset: 0x00278980
		public string DescSimpleArgs(int j)
		{
			int num = this.__p.__offset(22);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170018DF RID: 6367
		// (get) Token: 0x0600881D RID: 34845 RVA: 0x0027A7BC File Offset: 0x002789BC
		public int DescSimpleArgsLength
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600881E RID: 34846 RVA: 0x0027A7E8 File Offset: 0x002789E8
		[NullableContext(1)]
		public int[] BuffTempId()
		{
			return this.GetBuffTempIdArray();
		}

		// Token: 0x0600881F RID: 34847 RVA: 0x0027A7F0 File Offset: 0x002789F0
		[NullableContext(1)]
		public IEnumerable<int> BuffTempIdIter()
		{
			HonamiStoryWeaponSuit.<BuffTempIdIter>d__40 <BuffTempIdIter>d__ = new HonamiStoryWeaponSuit.<BuffTempIdIter>d__40(-2);
			<BuffTempIdIter>d__.<>3__<>4__this = this;
			return <BuffTempIdIter>d__;
		}

		// Token: 0x06008820 RID: 34848 RVA: 0x0027A805 File Offset: 0x00278A05
		[NullableContext(1)]
		public string[] DescArgs()
		{
			return this.DescArgsIter().ToArray<string>();
		}

		// Token: 0x06008821 RID: 34849 RVA: 0x0027A812 File Offset: 0x00278A12
		[NullableContext(1)]
		public IEnumerable<string> DescArgsIter()
		{
			HonamiStoryWeaponSuit.<DescArgsIter>d__42 <DescArgsIter>d__ = new HonamiStoryWeaponSuit.<DescArgsIter>d__42(-2);
			<DescArgsIter>d__.<>3__<>4__this = this;
			return <DescArgsIter>d__;
		}

		// Token: 0x06008822 RID: 34850 RVA: 0x0027A827 File Offset: 0x00278A27
		[NullableContext(1)]
		public string[] DescSimpleArgs()
		{
			return this.DescSimpleArgsIter().ToArray<string>();
		}

		// Token: 0x06008823 RID: 34851 RVA: 0x0027A834 File Offset: 0x00278A34
		[NullableContext(1)]
		public IEnumerable<string> DescSimpleArgsIter()
		{
			HonamiStoryWeaponSuit.<DescSimpleArgsIter>d__44 <DescSimpleArgsIter>d__ = new HonamiStoryWeaponSuit.<DescSimpleArgsIter>d__44(-2);
			<DescSimpleArgsIter>d__.<>3__<>4__this = this;
			return <DescSimpleArgsIter>d__;
		}

		// Token: 0x040053B7 RID: 21431
		private Table __p;
	}
}
