using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E07 RID: 3591
	public struct MenuConfig : IFlatbufferObject
	{
		// Token: 0x17001ED5 RID: 7893
		// (get) Token: 0x06009373 RID: 37747 RVA: 0x00283D45 File Offset: 0x00281F45
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06009374 RID: 37748 RVA: 0x00283D52 File Offset: 0x00281F52
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06009375 RID: 37749 RVA: 0x00283D5C File Offset: 0x00281F5C
		public static MenuConfig GetRootAsMenuConfig(ByteBuffer _bb)
		{
			return MenuConfig.GetRootAsMenuConfig(_bb, default(MenuConfig));
		}

		// Token: 0x06009376 RID: 37750 RVA: 0x00283D78 File Offset: 0x00281F78
		public static MenuConfig GetRootAsMenuConfig(ByteBuffer _bb, MenuConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06009377 RID: 37751 RVA: 0x00283D95 File Offset: 0x00281F95
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06009378 RID: 37752 RVA: 0x00283DA4 File Offset: 0x00281FA4
		public MenuConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001ED6 RID: 7894
		// (get) Token: 0x06009379 RID: 37753 RVA: 0x00283DB4 File Offset: 0x00281FB4
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

		// Token: 0x17001ED7 RID: 7895
		// (get) Token: 0x0600937A RID: 37754 RVA: 0x00283DF0 File Offset: 0x00281FF0
		public int FunctionId
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

		// Token: 0x17001ED8 RID: 7896
		// (get) Token: 0x0600937B RID: 37755 RVA: 0x00283E2C File Offset: 0x0028202C
		public float SliderDefault
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

		// Token: 0x17001ED9 RID: 7897
		// (get) Token: 0x0600937C RID: 37756 RVA: 0x00283E6C File Offset: 0x0028206C
		public int OptionsDefault
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

		// Token: 0x17001EDA RID: 7898
		// (get) Token: 0x0600937D RID: 37757 RVA: 0x00283EAC File Offset: 0x002820AC
		public int MainType
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

		// Token: 0x17001EDB RID: 7899
		// (get) Token: 0x0600937E RID: 37758 RVA: 0x00283EEC File Offset: 0x002820EC
		public string SubName
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

		// Token: 0x0600937F RID: 37759 RVA: 0x00283F24 File Offset: 0x00282124
		public Span<byte> GetSubNameBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x06009380 RID: 37760 RVA: 0x00283F34 File Offset: 0x00282134
		public byte[] GetSubNameArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17001EDC RID: 7900
		// (get) Token: 0x06009381 RID: 37761 RVA: 0x00283F4C File Offset: 0x0028214C
		public int SubType
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

		// Token: 0x17001EDD RID: 7901
		// (get) Token: 0x06009382 RID: 37762 RVA: 0x00283F8C File Offset: 0x0028218C
		public bool NeedScale
		{
			get
			{
				int num = this.__p.__offset(18);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17001EDE RID: 7902
		// (get) Token: 0x06009383 RID: 37763 RVA: 0x00283FCC File Offset: 0x002821CC
		public int SubSort
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001EDF RID: 7903
		// (get) Token: 0x06009384 RID: 37764 RVA: 0x0028400C File Offset: 0x0028220C
		public string SubImage
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

		// Token: 0x06009385 RID: 37765 RVA: 0x00284044 File Offset: 0x00282244
		public Span<byte> GetSubImageBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x06009386 RID: 37766 RVA: 0x00284054 File Offset: 0x00282254
		public byte[] GetSubImageArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x17001EE0 RID: 7904
		// (get) Token: 0x06009387 RID: 37767 RVA: 0x0028406C File Offset: 0x0028226C
		public string Name
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06009388 RID: 37768 RVA: 0x002840A4 File Offset: 0x002822A4
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x06009389 RID: 37769 RVA: 0x002840B4 File Offset: 0x002822B4
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(24) ?? Array.Empty<byte>();
		}

		// Token: 0x17001EE1 RID: 7905
		// (get) Token: 0x0600938A RID: 37770 RVA: 0x002840CC File Offset: 0x002822CC
		public int Platform
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001EE2 RID: 7906
		// (get) Token: 0x0600938B RID: 37771 RVA: 0x0028410C File Offset: 0x0028230C
		public string Device
		{
			get
			{
				int num = this.__p.__offset(28);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600938C RID: 37772 RVA: 0x00284144 File Offset: 0x00282344
		public Span<byte> GetDeviceBytes()
		{
			return this.__p.__vector_as_span<byte>(28, 1);
		}

		// Token: 0x0600938D RID: 37773 RVA: 0x00284154 File Offset: 0x00282354
		public byte[] GetDeviceArray()
		{
			return this.__p.__vector_as_array<byte>(28) ?? Array.Empty<byte>();
		}

		// Token: 0x17001EE3 RID: 7907
		// (get) Token: 0x0600938E RID: 37774 RVA: 0x0028416C File Offset: 0x0028236C
		public int FunctionSort
		{
			get
			{
				int num = this.__p.__offset(30);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001EE4 RID: 7908
		// (get) Token: 0x0600938F RID: 37775 RVA: 0x002841AC File Offset: 0x002823AC
		public string FunctionImage
		{
			get
			{
				int num = this.__p.__offset(32);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06009390 RID: 37776 RVA: 0x002841E4 File Offset: 0x002823E4
		public Span<byte> GetFunctionImageBytes()
		{
			return this.__p.__vector_as_span<byte>(32, 1);
		}

		// Token: 0x06009391 RID: 37777 RVA: 0x002841F4 File Offset: 0x002823F4
		public byte[] GetFunctionImageArray()
		{
			return this.__p.__vector_as_array<byte>(32) ?? Array.Empty<byte>();
		}

		// Token: 0x17001EE5 RID: 7909
		// (get) Token: 0x06009392 RID: 37778 RVA: 0x0028420C File Offset: 0x0028240C
		public int SetType
		{
			get
			{
				int num = this.__p.__offset(34);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001EE6 RID: 7910
		// (get) Token: 0x06009393 RID: 37779 RVA: 0x0028424C File Offset: 0x0028244C
		public bool IsDataCache
		{
			get
			{
				int num = this.__p.__offset(36);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x06009394 RID: 37780 RVA: 0x0028428C File Offset: 0x0028248C
		public float SliderRange(int j)
		{
			int num = this.__p.__offset(38);
			if (num == 0)
			{
				return 0f;
			}
			return this.__p.bb.GetFloat(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001EE7 RID: 7911
		// (get) Token: 0x06009395 RID: 37781 RVA: 0x002842D0 File Offset: 0x002824D0
		public int SliderRangeLength
		{
			get
			{
				int num = this.__p.__offset(38);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06009396 RID: 37782 RVA: 0x002842FC File Offset: 0x002824FC
		public Span<float> GetSliderRangeBytes()
		{
			return this.__p.__vector_as_span<float>(38, 4);
		}

		// Token: 0x06009397 RID: 37783 RVA: 0x0028430C File Offset: 0x0028250C
		public float[] GetSliderRangeArray()
		{
			return this.__p.__vector_as_array<float>(38) ?? Array.Empty<float>();
		}

		// Token: 0x06009398 RID: 37784 RVA: 0x00284324 File Offset: 0x00282524
		public float SliderRangeDisplay(int j)
		{
			int num = this.__p.__offset(40);
			if (num == 0)
			{
				return 0f;
			}
			return this.__p.bb.GetFloat(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001EE8 RID: 7912
		// (get) Token: 0x06009399 RID: 37785 RVA: 0x00284368 File Offset: 0x00282568
		public int SliderRangeDisplayLength
		{
			get
			{
				int num = this.__p.__offset(40);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600939A RID: 37786 RVA: 0x00284394 File Offset: 0x00282594
		public Span<float> GetSliderRangeDisplayBytes()
		{
			return this.__p.__vector_as_span<float>(40, 4);
		}

		// Token: 0x0600939B RID: 37787 RVA: 0x002843A4 File Offset: 0x002825A4
		public float[] GetSliderRangeDisplayArray()
		{
			return this.__p.__vector_as_array<float>(40) ?? Array.Empty<float>();
		}

		// Token: 0x17001EE9 RID: 7913
		// (get) Token: 0x0600939C RID: 37788 RVA: 0x002843BC File Offset: 0x002825BC
		public int Digits
		{
			get
			{
				int num = this.__p.__offset(42);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600939D RID: 37789 RVA: 0x002843FC File Offset: 0x002825FC
		public string OptionsName(int j)
		{
			int num = this.__p.__offset(44);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001EEA RID: 7914
		// (get) Token: 0x0600939E RID: 37790 RVA: 0x00284438 File Offset: 0x00282638
		public int OptionsNameLength
		{
			get
			{
				int num = this.__p.__offset(44);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600939F RID: 37791 RVA: 0x00284464 File Offset: 0x00282664
		public int OptionsValue(int j)
		{
			int num = this.__p.__offset(46);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001EEB RID: 7915
		// (get) Token: 0x060093A0 RID: 37792 RVA: 0x002844A4 File Offset: 0x002826A4
		public int OptionsValueLength
		{
			get
			{
				int num = this.__p.__offset(46);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x060093A1 RID: 37793 RVA: 0x002844D0 File Offset: 0x002826D0
		public Span<int> GetOptionsValueBytes()
		{
			return this.__p.__vector_as_span<int>(46, 4);
		}

		// Token: 0x060093A2 RID: 37794 RVA: 0x002844E0 File Offset: 0x002826E0
		public int[] GetOptionsValueArray()
		{
			return this.__p.__vector_as_array<int>(46) ?? Array.Empty<int>();
		}

		// Token: 0x17001EEC RID: 7916
		// (get) Token: 0x060093A3 RID: 37795 RVA: 0x002844F8 File Offset: 0x002826F8
		public string KeyMap
		{
			get
			{
				int num = this.__p.__offset(48);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060093A4 RID: 37796 RVA: 0x00284530 File Offset: 0x00282730
		public Span<byte> GetKeyMapBytes()
		{
			return this.__p.__vector_as_span<byte>(48, 1);
		}

		// Token: 0x060093A5 RID: 37797 RVA: 0x00284540 File Offset: 0x00282740
		public byte[] GetKeyMapArray()
		{
			return this.__p.__vector_as_array<byte>(48) ?? Array.Empty<byte>();
		}

		// Token: 0x17001EED RID: 7917
		// (get) Token: 0x060093A6 RID: 37798 RVA: 0x00284558 File Offset: 0x00282758
		public string ButtonText
		{
			get
			{
				int num = this.__p.__offset(50);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060093A7 RID: 37799 RVA: 0x00284590 File Offset: 0x00282790
		public Span<byte> GetButtonTextBytes()
		{
			return this.__p.__vector_as_span<byte>(50, 1);
		}

		// Token: 0x060093A8 RID: 37800 RVA: 0x002845A0 File Offset: 0x002827A0
		public byte[] GetButtonTextArray()
		{
			return this.__p.__vector_as_array<byte>(50) ?? Array.Empty<byte>();
		}

		// Token: 0x17001EEE RID: 7918
		// (get) Token: 0x060093A9 RID: 37801 RVA: 0x002845B8 File Offset: 0x002827B8
		public string BtnDisableTips
		{
			get
			{
				int num = this.__p.__offset(52);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060093AA RID: 37802 RVA: 0x002845F0 File Offset: 0x002827F0
		public Span<byte> GetBtnDisableTipsBytes()
		{
			return this.__p.__vector_as_span<byte>(52, 1);
		}

		// Token: 0x060093AB RID: 37803 RVA: 0x00284600 File Offset: 0x00282800
		public byte[] GetBtnDisableTipsArray()
		{
			return this.__p.__vector_as_array<byte>(52) ?? Array.Empty<byte>();
		}

		// Token: 0x17001EEF RID: 7919
		// (get) Token: 0x060093AC RID: 37804 RVA: 0x00284618 File Offset: 0x00282818
		public bool BtnDisableTipsEnable
		{
			get
			{
				int num = this.__p.__offset(54);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17001EF0 RID: 7920
		// (get) Token: 0x060093AD RID: 37805 RVA: 0x00284658 File Offset: 0x00282858
		public string OpenView
		{
			get
			{
				int num = this.__p.__offset(56);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060093AE RID: 37806 RVA: 0x00284690 File Offset: 0x00282890
		public Span<byte> GetOpenViewBytes()
		{
			return this.__p.__vector_as_span<byte>(56, 1);
		}

		// Token: 0x060093AF RID: 37807 RVA: 0x002846A0 File Offset: 0x002828A0
		public byte[] GetOpenViewArray()
		{
			return this.__p.__vector_as_array<byte>(56) ?? Array.Empty<byte>();
		}

		// Token: 0x060093B0 RID: 37808 RVA: 0x002846B8 File Offset: 0x002828B8
		public int RelationFunction(int j)
		{
			int num = this.__p.__offset(58);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001EF1 RID: 7921
		// (get) Token: 0x060093B1 RID: 37809 RVA: 0x002846F8 File Offset: 0x002828F8
		public int RelationFunctionLength
		{
			get
			{
				int num = this.__p.__offset(58);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x060093B2 RID: 37810 RVA: 0x00284724 File Offset: 0x00282924
		public Span<int> GetRelationFunctionBytes()
		{
			return this.__p.__vector_as_span<int>(58, 4);
		}

		// Token: 0x060093B3 RID: 37811 RVA: 0x00284734 File Offset: 0x00282934
		public int[] GetRelationFunctionArray()
		{
			return this.__p.__vector_as_array<int>(58) ?? Array.Empty<int>();
		}

		// Token: 0x060093B4 RID: 37812 RVA: 0x0028474C File Offset: 0x0028294C
		public int DisableValue(int j)
		{
			int num = this.__p.__offset(60);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001EF2 RID: 7922
		// (get) Token: 0x060093B5 RID: 37813 RVA: 0x0028478C File Offset: 0x0028298C
		public int DisableValueLength
		{
			get
			{
				int num = this.__p.__offset(60);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x060093B6 RID: 37814 RVA: 0x002847B8 File Offset: 0x002829B8
		public Span<int> GetDisableValueBytes()
		{
			return this.__p.__vector_as_span<int>(60, 4);
		}

		// Token: 0x060093B7 RID: 37815 RVA: 0x002847C8 File Offset: 0x002829C8
		public int[] GetDisableValueArray()
		{
			return this.__p.__vector_as_array<int>(60) ?? Array.Empty<int>();
		}

		// Token: 0x060093B8 RID: 37816 RVA: 0x002847E0 File Offset: 0x002829E0
		public int DisableFunction(int j)
		{
			int num = this.__p.__offset(62);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001EF3 RID: 7923
		// (get) Token: 0x060093B9 RID: 37817 RVA: 0x00284820 File Offset: 0x00282A20
		public int DisableFunctionLength
		{
			get
			{
				int num = this.__p.__offset(62);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x060093BA RID: 37818 RVA: 0x0028484C File Offset: 0x00282A4C
		public Span<int> GetDisableFunctionBytes()
		{
			return this.__p.__vector_as_span<int>(62, 4);
		}

		// Token: 0x060093BB RID: 37819 RVA: 0x0028485C File Offset: 0x00282A5C
		public int[] GetDisableFunctionArray()
		{
			return this.__p.__vector_as_array<int>(62) ?? Array.Empty<int>();
		}

		// Token: 0x060093BC RID: 37820 RVA: 0x00284874 File Offset: 0x00282A74
		public DicIntString? DisableOverrideText(int j)
		{
			int num = this.__p.__offset(64);
			if (num == 0)
			{
				return null;
			}
			return new DicIntString?(default(DicIntString).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17001EF4 RID: 7924
		// (get) Token: 0x060093BD RID: 37821 RVA: 0x002848D8 File Offset: 0x00282AD8
		public int DisableOverrideTextLength
		{
			get
			{
				int num = this.__p.__offset(64);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x060093BE RID: 37822 RVA: 0x00284904 File Offset: 0x00282B04
		public int AffectedValue(int j)
		{
			int num = this.__p.__offset(66);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001EF5 RID: 7925
		// (get) Token: 0x060093BF RID: 37823 RVA: 0x00284944 File Offset: 0x00282B44
		public int AffectedValueLength
		{
			get
			{
				int num = this.__p.__offset(66);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x060093C0 RID: 37824 RVA: 0x00284970 File Offset: 0x00282B70
		public Span<int> GetAffectedValueBytes()
		{
			return this.__p.__vector_as_span<int>(66, 4);
		}

		// Token: 0x060093C1 RID: 37825 RVA: 0x00284980 File Offset: 0x00282B80
		public int[] GetAffectedValueArray()
		{
			return this.__p.__vector_as_array<int>(66) ?? Array.Empty<int>();
		}

		// Token: 0x060093C2 RID: 37826 RVA: 0x00284998 File Offset: 0x00282B98
		public DicIntInt? AffectedFunction(int j)
		{
			int num = this.__p.__offset(68);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17001EF6 RID: 7926
		// (get) Token: 0x060093C3 RID: 37827 RVA: 0x002849FC File Offset: 0x00282BFC
		public int AffectedFunctionLength
		{
			get
			{
				int num = this.__p.__offset(68);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x060093C4 RID: 37828 RVA: 0x00284A28 File Offset: 0x00282C28
		public DicIntString? ValueTipsMap(int j)
		{
			int num = this.__p.__offset(70);
			if (num == 0)
			{
				return null;
			}
			return new DicIntString?(default(DicIntString).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17001EF7 RID: 7927
		// (get) Token: 0x060093C5 RID: 37829 RVA: 0x00284A8C File Offset: 0x00282C8C
		public int ValueTipsMapLength
		{
			get
			{
				int num = this.__p.__offset(70);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x060093C6 RID: 37830 RVA: 0x00284AB8 File Offset: 0x00282CB8
		public DicIntInt? ClickedTipsMap(int j)
		{
			int num = this.__p.__offset(72);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17001EF8 RID: 7928
		// (get) Token: 0x060093C7 RID: 37831 RVA: 0x00284B1C File Offset: 0x00282D1C
		public int ClickedTipsMapLength
		{
			get
			{
				int num = this.__p.__offset(72);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x17001EF9 RID: 7929
		// (get) Token: 0x060093C8 RID: 37832 RVA: 0x00284B48 File Offset: 0x00282D48
		public string ClickedTips
		{
			get
			{
				int num = this.__p.__offset(74);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060093C9 RID: 37833 RVA: 0x00284B80 File Offset: 0x00282D80
		public Span<byte> GetClickedTipsBytes()
		{
			return this.__p.__vector_as_span<byte>(74, 1);
		}

		// Token: 0x060093CA RID: 37834 RVA: 0x00284B90 File Offset: 0x00282D90
		public byte[] GetClickedTipsArray()
		{
			return this.__p.__vector_as_array<byte>(74) ?? Array.Empty<byte>();
		}

		// Token: 0x17001EFA RID: 7930
		// (get) Token: 0x060093CB RID: 37835 RVA: 0x00284BA8 File Offset: 0x00282DA8
		public bool BlockOnIosCheckServer
		{
			get
			{
				int num = this.__p.__offset(76);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17001EFB RID: 7931
		// (get) Token: 0x060093CC RID: 37836 RVA: 0x00284BE8 File Offset: 0x00282DE8
		public string DetailText
		{
			get
			{
				int num = this.__p.__offset(78);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060093CD RID: 37837 RVA: 0x00284C20 File Offset: 0x00282E20
		public Span<byte> GetDetailTextBytes()
		{
			return this.__p.__vector_as_span<byte>(78, 1);
		}

		// Token: 0x060093CE RID: 37838 RVA: 0x00284C30 File Offset: 0x00282E30
		public byte[] GetDetailTextArray()
		{
			return this.__p.__vector_as_array<byte>(78) ?? Array.Empty<byte>();
		}

		// Token: 0x17001EFC RID: 7932
		// (get) Token: 0x060093CF RID: 37839 RVA: 0x00284C48 File Offset: 0x00282E48
		public int DetailPop
		{
			get
			{
				int num = this.__p.__offset(80);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001EFD RID: 7933
		// (get) Token: 0x060093D0 RID: 37840 RVA: 0x00284C88 File Offset: 0x00282E88
		public bool CanDisableDetailShow
		{
			get
			{
				int num = this.__p.__offset(82);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17001EFE RID: 7934
		// (get) Token: 0x060093D1 RID: 37841 RVA: 0x00284CC8 File Offset: 0x00282EC8
		public int ConditionGroup
		{
			get
			{
				int num = this.__p.__offset(84);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001EFF RID: 7935
		// (get) Token: 0x060093D2 RID: 37842 RVA: 0x00284D08 File Offset: 0x00282F08
		public int Ps5Hide
		{
			get
			{
				int num = this.__p.__offset(86);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001F00 RID: 7936
		// (get) Token: 0x060093D3 RID: 37843 RVA: 0x00284D48 File Offset: 0x00282F48
		public bool CanShowInLogin
		{
			get
			{
				int num = this.__p.__offset(88);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17001F01 RID: 7937
		// (get) Token: 0x060093D4 RID: 37844 RVA: 0x00284D88 File Offset: 0x00282F88
		public int XboxHide
		{
			get
			{
				int num = this.__p.__offset(90);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001F02 RID: 7938
		// (get) Token: 0x060093D5 RID: 37845 RVA: 0x00284DC8 File Offset: 0x00282FC8
		public int WinGDKHide
		{
			get
			{
				int num = this.__p.__offset(92);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060093D6 RID: 37846 RVA: 0x00284E08 File Offset: 0x00283008
		[NullableContext(1)]
		[Obsolete("已废弃，请使用AffectedFunctionFrozenDict()缓存字典，遍历请使用AffectedFunctionIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, int> AffectedFunction()
		{
			return this.AffectedFunctionIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x060093D7 RID: 37847 RVA: 0x00284E5E File Offset: 0x0028305E
		[NullableContext(1)]
		public readonly IEnumerable<DicIntInt> AffectedFunctionIter()
		{
			MenuConfig.<AffectedFunctionIter>d__147 <AffectedFunctionIter>d__ = new MenuConfig.<AffectedFunctionIter>d__147(-2);
			<AffectedFunctionIter>d__.<>3__<>4__this = this;
			return <AffectedFunctionIter>d__;
		}

		// Token: 0x060093D8 RID: 37848 RVA: 0x00284E74 File Offset: 0x00283074
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用AffectedValueIter()或GetAffectedValueBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] AffectedValue()
		{
			MenuConfig menuConfig = this;
			return menuConfig.GetAffectedValueArray() ?? Array.Empty<int>();
		}

		// Token: 0x060093D9 RID: 37849 RVA: 0x00284E98 File Offset: 0x00283098
		[NullableContext(1)]
		public readonly IEnumerable<int> AffectedValueIter()
		{
			MenuConfig.<AffectedValueIter>d__149 <AffectedValueIter>d__ = new MenuConfig.<AffectedValueIter>d__149(-2);
			<AffectedValueIter>d__.<>3__<>4__this = this;
			return <AffectedValueIter>d__;
		}

		// Token: 0x060093DA RID: 37850 RVA: 0x00284EB0 File Offset: 0x002830B0
		[NullableContext(1)]
		[Obsolete("已废弃，请使用ClickedTipsMapFrozenDict()缓存字典，遍历请使用ClickedTipsMapIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, int> ClickedTipsMap()
		{
			return this.ClickedTipsMapIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x060093DB RID: 37851 RVA: 0x00284F06 File Offset: 0x00283106
		[NullableContext(1)]
		public readonly IEnumerable<DicIntInt> ClickedTipsMapIter()
		{
			MenuConfig.<ClickedTipsMapIter>d__151 <ClickedTipsMapIter>d__ = new MenuConfig.<ClickedTipsMapIter>d__151(-2);
			<ClickedTipsMapIter>d__.<>3__<>4__this = this;
			return <ClickedTipsMapIter>d__;
		}

		// Token: 0x060093DC RID: 37852 RVA: 0x00284F1C File Offset: 0x0028311C
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用DisableFunctionIter()或GetDisableFunctionBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] DisableFunction()
		{
			MenuConfig menuConfig = this;
			return menuConfig.GetDisableFunctionArray() ?? Array.Empty<int>();
		}

		// Token: 0x060093DD RID: 37853 RVA: 0x00284F40 File Offset: 0x00283140
		[NullableContext(1)]
		public readonly IEnumerable<int> DisableFunctionIter()
		{
			MenuConfig.<DisableFunctionIter>d__153 <DisableFunctionIter>d__ = new MenuConfig.<DisableFunctionIter>d__153(-2);
			<DisableFunctionIter>d__.<>3__<>4__this = this;
			return <DisableFunctionIter>d__;
		}

		// Token: 0x060093DE RID: 37854 RVA: 0x00284F58 File Offset: 0x00283158
		[NullableContext(1)]
		[Obsolete("已废弃，请使用DisableOverrideTextFrozenDict()缓存字典，遍历请使用DisableOverrideTextIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, string> DisableOverrideText()
		{
			return this.DisableOverrideTextIter().ToDictionary((DicIntString element) => element.Key, (DicIntString element) => element.Value);
		}

		// Token: 0x060093DF RID: 37855 RVA: 0x00284FAE File Offset: 0x002831AE
		[NullableContext(1)]
		public readonly IEnumerable<DicIntString> DisableOverrideTextIter()
		{
			MenuConfig.<DisableOverrideTextIter>d__155 <DisableOverrideTextIter>d__ = new MenuConfig.<DisableOverrideTextIter>d__155(-2);
			<DisableOverrideTextIter>d__.<>3__<>4__this = this;
			return <DisableOverrideTextIter>d__;
		}

		// Token: 0x060093E0 RID: 37856 RVA: 0x00284FC4 File Offset: 0x002831C4
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用DisableValueIter()或GetDisableValueBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] DisableValue()
		{
			MenuConfig menuConfig = this;
			return menuConfig.GetDisableValueArray() ?? Array.Empty<int>();
		}

		// Token: 0x060093E1 RID: 37857 RVA: 0x00284FE8 File Offset: 0x002831E8
		[NullableContext(1)]
		public readonly IEnumerable<int> DisableValueIter()
		{
			MenuConfig.<DisableValueIter>d__157 <DisableValueIter>d__ = new MenuConfig.<DisableValueIter>d__157(-2);
			<DisableValueIter>d__.<>3__<>4__this = this;
			return <DisableValueIter>d__;
		}

		// Token: 0x060093E2 RID: 37858 RVA: 0x00284FFD File Offset: 0x002831FD
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用OptionsNameIter()或GetOptionsNameBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] OptionsName()
		{
			return this.OptionsNameIter().ToArray<string>();
		}

		// Token: 0x060093E3 RID: 37859 RVA: 0x0028500A File Offset: 0x0028320A
		[NullableContext(1)]
		public readonly IEnumerable<string> OptionsNameIter()
		{
			MenuConfig.<OptionsNameIter>d__159 <OptionsNameIter>d__ = new MenuConfig.<OptionsNameIter>d__159(-2);
			<OptionsNameIter>d__.<>3__<>4__this = this;
			return <OptionsNameIter>d__;
		}

		// Token: 0x060093E4 RID: 37860 RVA: 0x00285020 File Offset: 0x00283220
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用OptionsValueIter()或GetOptionsValueBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] OptionsValue()
		{
			MenuConfig menuConfig = this;
			return menuConfig.GetOptionsValueArray() ?? Array.Empty<int>();
		}

		// Token: 0x060093E5 RID: 37861 RVA: 0x00285044 File Offset: 0x00283244
		[NullableContext(1)]
		public readonly IEnumerable<int> OptionsValueIter()
		{
			MenuConfig.<OptionsValueIter>d__161 <OptionsValueIter>d__ = new MenuConfig.<OptionsValueIter>d__161(-2);
			<OptionsValueIter>d__.<>3__<>4__this = this;
			return <OptionsValueIter>d__;
		}

		// Token: 0x060093E6 RID: 37862 RVA: 0x0028505C File Offset: 0x0028325C
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用RelationFunctionIter()或GetRelationFunctionBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] RelationFunction()
		{
			MenuConfig menuConfig = this;
			return menuConfig.GetRelationFunctionArray() ?? Array.Empty<int>();
		}

		// Token: 0x060093E7 RID: 37863 RVA: 0x00285080 File Offset: 0x00283280
		[NullableContext(1)]
		public readonly IEnumerable<int> RelationFunctionIter()
		{
			MenuConfig.<RelationFunctionIter>d__163 <RelationFunctionIter>d__ = new MenuConfig.<RelationFunctionIter>d__163(-2);
			<RelationFunctionIter>d__.<>3__<>4__this = this;
			return <RelationFunctionIter>d__;
		}

		// Token: 0x060093E8 RID: 37864 RVA: 0x00285098 File Offset: 0x00283298
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用SliderRangeIter()或GetSliderRangeBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly float[] SliderRange()
		{
			MenuConfig menuConfig = this;
			return menuConfig.GetSliderRangeArray() ?? Array.Empty<float>();
		}

		// Token: 0x060093E9 RID: 37865 RVA: 0x002850BC File Offset: 0x002832BC
		[NullableContext(1)]
		public readonly IEnumerable<float> SliderRangeIter()
		{
			MenuConfig.<SliderRangeIter>d__165 <SliderRangeIter>d__ = new MenuConfig.<SliderRangeIter>d__165(-2);
			<SliderRangeIter>d__.<>3__<>4__this = this;
			return <SliderRangeIter>d__;
		}

		// Token: 0x060093EA RID: 37866 RVA: 0x002850D4 File Offset: 0x002832D4
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用SliderRangeDisplayIter()或GetSliderRangeDisplayBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly float[] SliderRangeDisplay()
		{
			MenuConfig menuConfig = this;
			return menuConfig.GetSliderRangeDisplayArray() ?? Array.Empty<float>();
		}

		// Token: 0x060093EB RID: 37867 RVA: 0x002850F8 File Offset: 0x002832F8
		[NullableContext(1)]
		public readonly IEnumerable<float> SliderRangeDisplayIter()
		{
			MenuConfig.<SliderRangeDisplayIter>d__167 <SliderRangeDisplayIter>d__ = new MenuConfig.<SliderRangeDisplayIter>d__167(-2);
			<SliderRangeDisplayIter>d__.<>3__<>4__this = this;
			return <SliderRangeDisplayIter>d__;
		}

		// Token: 0x060093EC RID: 37868 RVA: 0x00285110 File Offset: 0x00283310
		[NullableContext(1)]
		[Obsolete("已废弃，请使用ValueTipsMapFrozenDict()缓存字典，遍历请使用ValueTipsMapIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, string> ValueTipsMap()
		{
			return this.ValueTipsMapIter().ToDictionary((DicIntString element) => element.Key, (DicIntString element) => element.Value);
		}

		// Token: 0x060093ED RID: 37869 RVA: 0x00285166 File Offset: 0x00283366
		[NullableContext(1)]
		public readonly IEnumerable<DicIntString> ValueTipsMapIter()
		{
			MenuConfig.<ValueTipsMapIter>d__169 <ValueTipsMapIter>d__ = new MenuConfig.<ValueTipsMapIter>d__169(-2);
			<ValueTipsMapIter>d__.<>3__<>4__this = this;
			return <ValueTipsMapIter>d__;
		}

		// Token: 0x060093EE RID: 37870 RVA: 0x0028517C File Offset: 0x0028337C
		public int? GetAffectedFunction(int key)
		{
			this.EnsureAffectedFunctionCacheIfNeeded();
			int value;
			if (!this.AffectedFunctionCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x060093EF RID: 37871 RVA: 0x002851B0 File Offset: 0x002833B0
		public int? GetClickedTipsMap(int key)
		{
			this.EnsureClickedTipsMapCacheIfNeeded();
			int value;
			if (!this.ClickedTipsMapCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x060093F0 RID: 37872 RVA: 0x002851E4 File Offset: 0x002833E4
		[NullableContext(2)]
		public string GetDisableOverrideText(int key)
		{
			this.EnsureDisableOverrideTextCacheIfNeeded();
			string result;
			if (!this.DisableOverrideTextCache.TryGetValue(key, out result))
			{
				return null;
			}
			return result;
		}

		// Token: 0x060093F1 RID: 37873 RVA: 0x0028520C File Offset: 0x0028340C
		[NullableContext(2)]
		public string GetValueTipsMap(int key)
		{
			this.EnsureValueTipsMapCacheIfNeeded();
			string result;
			if (!this.ValueTipsMapCache.TryGetValue(key, out result))
			{
				return null;
			}
			return result;
		}

		// Token: 0x060093F2 RID: 37874 RVA: 0x00285234 File Offset: 0x00283434
		private void EnsureAffectedFunctionCacheIfNeeded()
		{
			if (this.AffectedFunctionCache != null)
			{
				return;
			}
			this.AffectedFunctionCache = this.AffectedFunctionIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x060093F3 RID: 37875 RVA: 0x0028529C File Offset: 0x0028349C
		private void EnsureClickedTipsMapCacheIfNeeded()
		{
			if (this.ClickedTipsMapCache != null)
			{
				return;
			}
			this.ClickedTipsMapCache = this.ClickedTipsMapIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x060093F4 RID: 37876 RVA: 0x00285304 File Offset: 0x00283504
		private void EnsureDisableOverrideTextCacheIfNeeded()
		{
			if (this.DisableOverrideTextCache != null)
			{
				return;
			}
			this.DisableOverrideTextCache = this.DisableOverrideTextIter().ToFrozenDictionary((DicIntString kvp) => kvp.Key, (DicIntString kvp) => kvp.Value, null);
		}

		// Token: 0x060093F5 RID: 37877 RVA: 0x0028536C File Offset: 0x0028356C
		private void EnsureValueTipsMapCacheIfNeeded()
		{
			if (this.ValueTipsMapCache != null)
			{
				return;
			}
			this.ValueTipsMapCache = this.ValueTipsMapIter().ToFrozenDictionary((DicIntString kvp) => kvp.Key, (DicIntString kvp) => kvp.Value, null);
		}

		// Token: 0x060093F6 RID: 37878 RVA: 0x002853D2 File Offset: 0x002835D2
		[NullableContext(2)]
		public FrozenDictionary<int, int> GetAffectedFunctionFrozenDict(int key)
		{
			this.EnsureAffectedFunctionCacheIfNeeded();
			return this.AffectedFunctionCache;
		}

		// Token: 0x060093F7 RID: 37879 RVA: 0x002853E0 File Offset: 0x002835E0
		[NullableContext(2)]
		public FrozenDictionary<int, int> GetClickedTipsMapFrozenDict(int key)
		{
			this.EnsureClickedTipsMapCacheIfNeeded();
			return this.ClickedTipsMapCache;
		}

		// Token: 0x060093F8 RID: 37880 RVA: 0x002853EE File Offset: 0x002835EE
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public FrozenDictionary<int, string> GetDisableOverrideTextFrozenDict(int key)
		{
			this.EnsureDisableOverrideTextCacheIfNeeded();
			return this.DisableOverrideTextCache;
		}

		// Token: 0x060093F9 RID: 37881 RVA: 0x002853FC File Offset: 0x002835FC
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public FrozenDictionary<int, string> GetValueTipsMapFrozenDict(int key)
		{
			this.EnsureValueTipsMapCacheIfNeeded();
			return this.ValueTipsMapCache;
		}

		// Token: 0x04004EA8 RID: 20136
		private Table __p;

		// Token: 0x04004EA9 RID: 20137
		[Nullable(2)]
		private FrozenDictionary<int, int> AffectedFunctionCache;

		// Token: 0x04004EAA RID: 20138
		[Nullable(2)]
		private FrozenDictionary<int, int> ClickedTipsMapCache;

		// Token: 0x04004EAB RID: 20139
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private FrozenDictionary<int, string> DisableOverrideTextCache;

		// Token: 0x04004EAC RID: 20140
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private FrozenDictionary<int, string> ValueTipsMapCache;
	}
}
