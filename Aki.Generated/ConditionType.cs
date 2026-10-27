using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B96 RID: 2966
	public struct ConditionType : IFlatbufferObject
	{
		// Token: 0x17000904 RID: 2308
		// (get) Token: 0x06005826 RID: 22566 RVA: 0x001FC4ED File Offset: 0x001FA6ED
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06005827 RID: 22567 RVA: 0x001FC4FA File Offset: 0x001FA6FA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06005828 RID: 22568 RVA: 0x001FC504 File Offset: 0x001FA704
		public static ConditionType GetRootAsConditionType(ByteBuffer _bb)
		{
			return ConditionType.GetRootAsConditionType(_bb, default(ConditionType));
		}

		// Token: 0x06005829 RID: 22569 RVA: 0x001FC520 File Offset: 0x001FA720
		public static ConditionType GetRootAsConditionType(ByteBuffer _bb, ConditionType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600582A RID: 22570 RVA: 0x001FC53D File Offset: 0x001FA73D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600582B RID: 22571 RVA: 0x001FC54C File Offset: 0x001FA74C
		public ConditionType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000905 RID: 2309
		// (get) Token: 0x0600582C RID: 22572 RVA: 0x001FC55C File Offset: 0x001FA75C
		public string Type
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

		// Token: 0x0600582D RID: 22573 RVA: 0x001FC593 File Offset: 0x001FA793
		public Span<byte> GetTypeBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0600582E RID: 22574 RVA: 0x001FC5A2 File Offset: 0x001FA7A2
		public byte[] GetTypeArray()
		{
			return this.__p.__vector_as_array<byte>(4) ?? Array.Empty<byte>();
		}

		// Token: 0x17000906 RID: 2310
		// (get) Token: 0x0600582F RID: 22575 RVA: 0x001FC5BC File Offset: 0x001FA7BC
		public bool IsClientTrigger
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17000907 RID: 2311
		// (get) Token: 0x06005830 RID: 22576 RVA: 0x001FC5FC File Offset: 0x001FA7FC
		public int SubType
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

		// Token: 0x06005831 RID: 22577 RVA: 0x001FC638 File Offset: 0x001FA838
		public int RegisterPlaces(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000908 RID: 2312
		// (get) Token: 0x06005832 RID: 22578 RVA: 0x001FC678 File Offset: 0x001FA878
		public int RegisterPlacesLength
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

		// Token: 0x06005833 RID: 22579 RVA: 0x001FC6A4 File Offset: 0x001FA8A4
		public Span<int> GetRegisterPlacesBytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x06005834 RID: 22580 RVA: 0x001FC6B4 File Offset: 0x001FA8B4
		public int[] GetRegisterPlacesArray()
		{
			return this.__p.__vector_as_array<int>(10) ?? Array.Empty<int>();
		}

		// Token: 0x06005835 RID: 22581 RVA: 0x001FC6CC File Offset: 0x001FA8CC
		public DicStringString? Param1(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new DicStringString?(default(DicStringString).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17000909 RID: 2313
		// (get) Token: 0x06005836 RID: 22582 RVA: 0x001FC730 File Offset: 0x001FA930
		public int Param1Length
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

		// Token: 0x1700090A RID: 2314
		// (get) Token: 0x06005837 RID: 22583 RVA: 0x001FC75C File Offset: 0x001FA95C
		public string DefaultParam1
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

		// Token: 0x06005838 RID: 22584 RVA: 0x001FC794 File Offset: 0x001FA994
		public Span<byte> GetDefaultParam1Bytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x06005839 RID: 22585 RVA: 0x001FC7A4 File Offset: 0x001FA9A4
		public byte[] GetDefaultParam1Array()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x0600583A RID: 22586 RVA: 0x001FC7BC File Offset: 0x001FA9BC
		public DicStringString? Param2(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return null;
			}
			return new DicStringString?(default(DicStringString).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700090B RID: 2315
		// (get) Token: 0x0600583B RID: 22587 RVA: 0x001FC820 File Offset: 0x001FAA20
		public int Param2Length
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x1700090C RID: 2316
		// (get) Token: 0x0600583C RID: 22588 RVA: 0x001FC84C File Offset: 0x001FAA4C
		public string DefaultParam2
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

		// Token: 0x0600583D RID: 22589 RVA: 0x001FC884 File Offset: 0x001FAA84
		public Span<byte> GetDefaultParam2Bytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0600583E RID: 22590 RVA: 0x001FC894 File Offset: 0x001FAA94
		public byte[] GetDefaultParam2Array()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x0600583F RID: 22591 RVA: 0x001FC8AC File Offset: 0x001FAAAC
		public DicStringString? Param3(int j)
		{
			int num = this.__p.__offset(20);
			if (num == 0)
			{
				return null;
			}
			return new DicStringString?(default(DicStringString).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700090D RID: 2317
		// (get) Token: 0x06005840 RID: 22592 RVA: 0x001FC910 File Offset: 0x001FAB10
		public int Param3Length
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

		// Token: 0x1700090E RID: 2318
		// (get) Token: 0x06005841 RID: 22593 RVA: 0x001FC93C File Offset: 0x001FAB3C
		public string DefaultParam3
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

		// Token: 0x06005842 RID: 22594 RVA: 0x001FC974 File Offset: 0x001FAB74
		public Span<byte> GetDefaultParam3Bytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x06005843 RID: 22595 RVA: 0x001FC984 File Offset: 0x001FAB84
		public byte[] GetDefaultParam3Array()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x06005844 RID: 22596 RVA: 0x001FC99C File Offset: 0x001FAB9C
		public DicStringString? Param4(int j)
		{
			int num = this.__p.__offset(24);
			if (num == 0)
			{
				return null;
			}
			return new DicStringString?(default(DicStringString).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700090F RID: 2319
		// (get) Token: 0x06005845 RID: 22597 RVA: 0x001FCA00 File Offset: 0x001FAC00
		public int Param4Length
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x17000910 RID: 2320
		// (get) Token: 0x06005846 RID: 22598 RVA: 0x001FCA2C File Offset: 0x001FAC2C
		public string DefaultParam4
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06005847 RID: 22599 RVA: 0x001FCA64 File Offset: 0x001FAC64
		public Span<byte> GetDefaultParam4Bytes()
		{
			return this.__p.__vector_as_span<byte>(26, 1);
		}

		// Token: 0x06005848 RID: 22600 RVA: 0x001FCA74 File Offset: 0x001FAC74
		public byte[] GetDefaultParam4Array()
		{
			return this.__p.__vector_as_array<byte>(26) ?? Array.Empty<byte>();
		}

		// Token: 0x06005849 RID: 22601 RVA: 0x001FCA8C File Offset: 0x001FAC8C
		public DicStringString? Param5(int j)
		{
			int num = this.__p.__offset(28);
			if (num == 0)
			{
				return null;
			}
			return new DicStringString?(default(DicStringString).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17000911 RID: 2321
		// (get) Token: 0x0600584A RID: 22602 RVA: 0x001FCAF0 File Offset: 0x001FACF0
		public int Param5Length
		{
			get
			{
				int num = this.__p.__offset(28);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x17000912 RID: 2322
		// (get) Token: 0x0600584B RID: 22603 RVA: 0x001FCB1C File Offset: 0x001FAD1C
		public string DefaultParam5
		{
			get
			{
				int num = this.__p.__offset(30);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600584C RID: 22604 RVA: 0x001FCB54 File Offset: 0x001FAD54
		public Span<byte> GetDefaultParam5Bytes()
		{
			return this.__p.__vector_as_span<byte>(30, 1);
		}

		// Token: 0x0600584D RID: 22605 RVA: 0x001FCB64 File Offset: 0x001FAD64
		public byte[] GetDefaultParam5Array()
		{
			return this.__p.__vector_as_array<byte>(30) ?? Array.Empty<byte>();
		}

		// Token: 0x0600584E RID: 22606 RVA: 0x001FCB7C File Offset: 0x001FAD7C
		public DicStringString? Param6(int j)
		{
			int num = this.__p.__offset(32);
			if (num == 0)
			{
				return null;
			}
			return new DicStringString?(default(DicStringString).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17000913 RID: 2323
		// (get) Token: 0x0600584F RID: 22607 RVA: 0x001FCBE0 File Offset: 0x001FADE0
		public int Param6Length
		{
			get
			{
				int num = this.__p.__offset(32);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x17000914 RID: 2324
		// (get) Token: 0x06005850 RID: 22608 RVA: 0x001FCC0C File Offset: 0x001FAE0C
		public string DefaultParam6
		{
			get
			{
				int num = this.__p.__offset(34);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06005851 RID: 22609 RVA: 0x001FCC44 File Offset: 0x001FAE44
		public Span<byte> GetDefaultParam6Bytes()
		{
			return this.__p.__vector_as_span<byte>(34, 1);
		}

		// Token: 0x06005852 RID: 22610 RVA: 0x001FCC54 File Offset: 0x001FAE54
		public byte[] GetDefaultParam6Array()
		{
			return this.__p.__vector_as_array<byte>(34) ?? Array.Empty<byte>();
		}

		// Token: 0x06005853 RID: 22611 RVA: 0x001FCC6C File Offset: 0x001FAE6C
		public DicStringString? Param7(int j)
		{
			int num = this.__p.__offset(36);
			if (num == 0)
			{
				return null;
			}
			return new DicStringString?(default(DicStringString).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17000915 RID: 2325
		// (get) Token: 0x06005854 RID: 22612 RVA: 0x001FCCD0 File Offset: 0x001FAED0
		public int Param7Length
		{
			get
			{
				int num = this.__p.__offset(36);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x17000916 RID: 2326
		// (get) Token: 0x06005855 RID: 22613 RVA: 0x001FCCFC File Offset: 0x001FAEFC
		public string DefaultParam7
		{
			get
			{
				int num = this.__p.__offset(38);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06005856 RID: 22614 RVA: 0x001FCD34 File Offset: 0x001FAF34
		public Span<byte> GetDefaultParam7Bytes()
		{
			return this.__p.__vector_as_span<byte>(38, 1);
		}

		// Token: 0x06005857 RID: 22615 RVA: 0x001FCD44 File Offset: 0x001FAF44
		public byte[] GetDefaultParam7Array()
		{
			return this.__p.__vector_as_array<byte>(38) ?? Array.Empty<byte>();
		}

		// Token: 0x06005858 RID: 22616 RVA: 0x001FCD5C File Offset: 0x001FAF5C
		public DicStringString? Param8(int j)
		{
			int num = this.__p.__offset(40);
			if (num == 0)
			{
				return null;
			}
			return new DicStringString?(default(DicStringString).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17000917 RID: 2327
		// (get) Token: 0x06005859 RID: 22617 RVA: 0x001FCDC0 File Offset: 0x001FAFC0
		public int Param8Length
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

		// Token: 0x17000918 RID: 2328
		// (get) Token: 0x0600585A RID: 22618 RVA: 0x001FCDEC File Offset: 0x001FAFEC
		public string DefaultParam8
		{
			get
			{
				int num = this.__p.__offset(42);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600585B RID: 22619 RVA: 0x001FCE24 File Offset: 0x001FB024
		public Span<byte> GetDefaultParam8Bytes()
		{
			return this.__p.__vector_as_span<byte>(42, 1);
		}

		// Token: 0x0600585C RID: 22620 RVA: 0x001FCE34 File Offset: 0x001FB034
		public byte[] GetDefaultParam8Array()
		{
			return this.__p.__vector_as_array<byte>(42) ?? Array.Empty<byte>();
		}

		// Token: 0x0600585D RID: 22621 RVA: 0x001FCE4C File Offset: 0x001FB04C
		public DicStringString? Param9(int j)
		{
			int num = this.__p.__offset(44);
			if (num == 0)
			{
				return null;
			}
			return new DicStringString?(default(DicStringString).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17000919 RID: 2329
		// (get) Token: 0x0600585E RID: 22622 RVA: 0x001FCEB0 File Offset: 0x001FB0B0
		public int Param9Length
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

		// Token: 0x1700091A RID: 2330
		// (get) Token: 0x0600585F RID: 22623 RVA: 0x001FCEDC File Offset: 0x001FB0DC
		public string DefaultParam9
		{
			get
			{
				int num = this.__p.__offset(46);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06005860 RID: 22624 RVA: 0x001FCF14 File Offset: 0x001FB114
		public Span<byte> GetDefaultParam9Bytes()
		{
			return this.__p.__vector_as_span<byte>(46, 1);
		}

		// Token: 0x06005861 RID: 22625 RVA: 0x001FCF24 File Offset: 0x001FB124
		public byte[] GetDefaultParam9Array()
		{
			return this.__p.__vector_as_array<byte>(46) ?? Array.Empty<byte>();
		}

		// Token: 0x06005862 RID: 22626 RVA: 0x001FCF3C File Offset: 0x001FB13C
		public DicStringString? Param10(int j)
		{
			int num = this.__p.__offset(48);
			if (num == 0)
			{
				return null;
			}
			return new DicStringString?(default(DicStringString).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700091B RID: 2331
		// (get) Token: 0x06005863 RID: 22627 RVA: 0x001FCFA0 File Offset: 0x001FB1A0
		public int Param10Length
		{
			get
			{
				int num = this.__p.__offset(48);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x1700091C RID: 2332
		// (get) Token: 0x06005864 RID: 22628 RVA: 0x001FCFCC File Offset: 0x001FB1CC
		public string DefaultParam10
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

		// Token: 0x06005865 RID: 22629 RVA: 0x001FD004 File Offset: 0x001FB204
		public Span<byte> GetDefaultParam10Bytes()
		{
			return this.__p.__vector_as_span<byte>(50, 1);
		}

		// Token: 0x06005866 RID: 22630 RVA: 0x001FD014 File Offset: 0x001FB214
		public byte[] GetDefaultParam10Array()
		{
			return this.__p.__vector_as_array<byte>(50) ?? Array.Empty<byte>();
		}

		// Token: 0x06005867 RID: 22631 RVA: 0x001FD02C File Offset: 0x001FB22C
		public DicStringString? Param11(int j)
		{
			int num = this.__p.__offset(52);
			if (num == 0)
			{
				return null;
			}
			return new DicStringString?(default(DicStringString).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700091D RID: 2333
		// (get) Token: 0x06005868 RID: 22632 RVA: 0x001FD090 File Offset: 0x001FB290
		public int Param11Length
		{
			get
			{
				int num = this.__p.__offset(52);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x1700091E RID: 2334
		// (get) Token: 0x06005869 RID: 22633 RVA: 0x001FD0BC File Offset: 0x001FB2BC
		public string DefaultParam11
		{
			get
			{
				int num = this.__p.__offset(54);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600586A RID: 22634 RVA: 0x001FD0F4 File Offset: 0x001FB2F4
		public Span<byte> GetDefaultParam11Bytes()
		{
			return this.__p.__vector_as_span<byte>(54, 1);
		}

		// Token: 0x0600586B RID: 22635 RVA: 0x001FD104 File Offset: 0x001FB304
		public byte[] GetDefaultParam11Array()
		{
			return this.__p.__vector_as_array<byte>(54) ?? Array.Empty<byte>();
		}

		// Token: 0x0600586C RID: 22636 RVA: 0x001FD11C File Offset: 0x001FB31C
		public DicStringString? Param12(int j)
		{
			int num = this.__p.__offset(56);
			if (num == 0)
			{
				return null;
			}
			return new DicStringString?(default(DicStringString).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700091F RID: 2335
		// (get) Token: 0x0600586D RID: 22637 RVA: 0x001FD180 File Offset: 0x001FB380
		public int Param12Length
		{
			get
			{
				int num = this.__p.__offset(56);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x17000920 RID: 2336
		// (get) Token: 0x0600586E RID: 22638 RVA: 0x001FD1AC File Offset: 0x001FB3AC
		public string DefaultParam12
		{
			get
			{
				int num = this.__p.__offset(58);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600586F RID: 22639 RVA: 0x001FD1E4 File Offset: 0x001FB3E4
		public Span<byte> GetDefaultParam12Bytes()
		{
			return this.__p.__vector_as_span<byte>(58, 1);
		}

		// Token: 0x06005870 RID: 22640 RVA: 0x001FD1F4 File Offset: 0x001FB3F4
		public byte[] GetDefaultParam12Array()
		{
			return this.__p.__vector_as_array<byte>(58) ?? Array.Empty<byte>();
		}

		// Token: 0x06005871 RID: 22641 RVA: 0x001FD20C File Offset: 0x001FB40C
		public DicStringString? Param13(int j)
		{
			int num = this.__p.__offset(60);
			if (num == 0)
			{
				return null;
			}
			return new DicStringString?(default(DicStringString).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17000921 RID: 2337
		// (get) Token: 0x06005872 RID: 22642 RVA: 0x001FD270 File Offset: 0x001FB470
		public int Param13Length
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

		// Token: 0x17000922 RID: 2338
		// (get) Token: 0x06005873 RID: 22643 RVA: 0x001FD29C File Offset: 0x001FB49C
		public string DefaultParam13
		{
			get
			{
				int num = this.__p.__offset(62);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06005874 RID: 22644 RVA: 0x001FD2D4 File Offset: 0x001FB4D4
		public Span<byte> GetDefaultParam13Bytes()
		{
			return this.__p.__vector_as_span<byte>(62, 1);
		}

		// Token: 0x06005875 RID: 22645 RVA: 0x001FD2E4 File Offset: 0x001FB4E4
		public byte[] GetDefaultParam13Array()
		{
			return this.__p.__vector_as_array<byte>(62) ?? Array.Empty<byte>();
		}

		// Token: 0x06005876 RID: 22646 RVA: 0x001FD2FC File Offset: 0x001FB4FC
		public DicStringString? Param14(int j)
		{
			int num = this.__p.__offset(64);
			if (num == 0)
			{
				return null;
			}
			return new DicStringString?(default(DicStringString).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17000923 RID: 2339
		// (get) Token: 0x06005877 RID: 22647 RVA: 0x001FD360 File Offset: 0x001FB560
		public int Param14Length
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

		// Token: 0x17000924 RID: 2340
		// (get) Token: 0x06005878 RID: 22648 RVA: 0x001FD38C File Offset: 0x001FB58C
		public string DefaultParam14
		{
			get
			{
				int num = this.__p.__offset(66);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06005879 RID: 22649 RVA: 0x001FD3C4 File Offset: 0x001FB5C4
		public Span<byte> GetDefaultParam14Bytes()
		{
			return this.__p.__vector_as_span<byte>(66, 1);
		}

		// Token: 0x0600587A RID: 22650 RVA: 0x001FD3D4 File Offset: 0x001FB5D4
		public byte[] GetDefaultParam14Array()
		{
			return this.__p.__vector_as_array<byte>(66) ?? Array.Empty<byte>();
		}

		// Token: 0x0600587B RID: 22651 RVA: 0x001FD3EC File Offset: 0x001FB5EC
		public DicStringString? Param15(int j)
		{
			int num = this.__p.__offset(68);
			if (num == 0)
			{
				return null;
			}
			return new DicStringString?(default(DicStringString).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17000925 RID: 2341
		// (get) Token: 0x0600587C RID: 22652 RVA: 0x001FD450 File Offset: 0x001FB650
		public int Param15Length
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

		// Token: 0x17000926 RID: 2342
		// (get) Token: 0x0600587D RID: 22653 RVA: 0x001FD47C File Offset: 0x001FB67C
		public string DefaultParam15
		{
			get
			{
				int num = this.__p.__offset(70);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600587E RID: 22654 RVA: 0x001FD4B4 File Offset: 0x001FB6B4
		public Span<byte> GetDefaultParam15Bytes()
		{
			return this.__p.__vector_as_span<byte>(70, 1);
		}

		// Token: 0x0600587F RID: 22655 RVA: 0x001FD4C4 File Offset: 0x001FB6C4
		public byte[] GetDefaultParam15Array()
		{
			return this.__p.__vector_as_array<byte>(70) ?? Array.Empty<byte>();
		}

		// Token: 0x06005880 RID: 22656 RVA: 0x001FD4DC File Offset: 0x001FB6DC
		public DicStringString? Param16(int j)
		{
			int num = this.__p.__offset(72);
			if (num == 0)
			{
				return null;
			}
			return new DicStringString?(default(DicStringString).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17000927 RID: 2343
		// (get) Token: 0x06005881 RID: 22657 RVA: 0x001FD540 File Offset: 0x001FB740
		public int Param16Length
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

		// Token: 0x17000928 RID: 2344
		// (get) Token: 0x06005882 RID: 22658 RVA: 0x001FD56C File Offset: 0x001FB76C
		public string DefaultParam16
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

		// Token: 0x06005883 RID: 22659 RVA: 0x001FD5A4 File Offset: 0x001FB7A4
		public Span<byte> GetDefaultParam16Bytes()
		{
			return this.__p.__vector_as_span<byte>(74, 1);
		}

		// Token: 0x06005884 RID: 22660 RVA: 0x001FD5B4 File Offset: 0x001FB7B4
		public byte[] GetDefaultParam16Array()
		{
			return this.__p.__vector_as_array<byte>(74) ?? Array.Empty<byte>();
		}

		// Token: 0x06005885 RID: 22661 RVA: 0x001FD5CC File Offset: 0x001FB7CC
		[NullableContext(1)]
		[Obsolete("已废弃，请使用Param1FrozenDict()缓存字典，遍历请使用Param1Iter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<string, string> Param1()
		{
			return this.Param1Iter().ToDictionary((DicStringString element) => element.Key, (DicStringString element) => element.Value);
		}

		// Token: 0x06005886 RID: 22662 RVA: 0x001FD622 File Offset: 0x001FB822
		[NullableContext(1)]
		public readonly IEnumerable<DicStringString> Param1Iter()
		{
			ConditionType.<Param1Iter>d__134 <Param1Iter>d__ = new ConditionType.<Param1Iter>d__134(-2);
			<Param1Iter>d__.<>3__<>4__this = this;
			return <Param1Iter>d__;
		}

		// Token: 0x06005887 RID: 22663 RVA: 0x001FD638 File Offset: 0x001FB838
		[NullableContext(1)]
		[Obsolete("已废弃，请使用Param10FrozenDict()缓存字典，遍历请使用Param10Iter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<string, string> Param10()
		{
			return this.Param10Iter().ToDictionary((DicStringString element) => element.Key, (DicStringString element) => element.Value);
		}

		// Token: 0x06005888 RID: 22664 RVA: 0x001FD68E File Offset: 0x001FB88E
		[NullableContext(1)]
		public readonly IEnumerable<DicStringString> Param10Iter()
		{
			ConditionType.<Param10Iter>d__136 <Param10Iter>d__ = new ConditionType.<Param10Iter>d__136(-2);
			<Param10Iter>d__.<>3__<>4__this = this;
			return <Param10Iter>d__;
		}

		// Token: 0x06005889 RID: 22665 RVA: 0x001FD6A4 File Offset: 0x001FB8A4
		[NullableContext(1)]
		[Obsolete("已废弃，请使用Param11FrozenDict()缓存字典，遍历请使用Param11Iter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<string, string> Param11()
		{
			return this.Param11Iter().ToDictionary((DicStringString element) => element.Key, (DicStringString element) => element.Value);
		}

		// Token: 0x0600588A RID: 22666 RVA: 0x001FD6FA File Offset: 0x001FB8FA
		[NullableContext(1)]
		public readonly IEnumerable<DicStringString> Param11Iter()
		{
			ConditionType.<Param11Iter>d__138 <Param11Iter>d__ = new ConditionType.<Param11Iter>d__138(-2);
			<Param11Iter>d__.<>3__<>4__this = this;
			return <Param11Iter>d__;
		}

		// Token: 0x0600588B RID: 22667 RVA: 0x001FD710 File Offset: 0x001FB910
		[NullableContext(1)]
		[Obsolete("已废弃，请使用Param12FrozenDict()缓存字典，遍历请使用Param12Iter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<string, string> Param12()
		{
			return this.Param12Iter().ToDictionary((DicStringString element) => element.Key, (DicStringString element) => element.Value);
		}

		// Token: 0x0600588C RID: 22668 RVA: 0x001FD766 File Offset: 0x001FB966
		[NullableContext(1)]
		public readonly IEnumerable<DicStringString> Param12Iter()
		{
			ConditionType.<Param12Iter>d__140 <Param12Iter>d__ = new ConditionType.<Param12Iter>d__140(-2);
			<Param12Iter>d__.<>3__<>4__this = this;
			return <Param12Iter>d__;
		}

		// Token: 0x0600588D RID: 22669 RVA: 0x001FD77C File Offset: 0x001FB97C
		[NullableContext(1)]
		[Obsolete("已废弃，请使用Param13FrozenDict()缓存字典，遍历请使用Param13Iter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<string, string> Param13()
		{
			return this.Param13Iter().ToDictionary((DicStringString element) => element.Key, (DicStringString element) => element.Value);
		}

		// Token: 0x0600588E RID: 22670 RVA: 0x001FD7D2 File Offset: 0x001FB9D2
		[NullableContext(1)]
		public readonly IEnumerable<DicStringString> Param13Iter()
		{
			ConditionType.<Param13Iter>d__142 <Param13Iter>d__ = new ConditionType.<Param13Iter>d__142(-2);
			<Param13Iter>d__.<>3__<>4__this = this;
			return <Param13Iter>d__;
		}

		// Token: 0x0600588F RID: 22671 RVA: 0x001FD7E8 File Offset: 0x001FB9E8
		[NullableContext(1)]
		[Obsolete("已废弃，请使用Param14FrozenDict()缓存字典，遍历请使用Param14Iter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<string, string> Param14()
		{
			return this.Param14Iter().ToDictionary((DicStringString element) => element.Key, (DicStringString element) => element.Value);
		}

		// Token: 0x06005890 RID: 22672 RVA: 0x001FD83E File Offset: 0x001FBA3E
		[NullableContext(1)]
		public readonly IEnumerable<DicStringString> Param14Iter()
		{
			ConditionType.<Param14Iter>d__144 <Param14Iter>d__ = new ConditionType.<Param14Iter>d__144(-2);
			<Param14Iter>d__.<>3__<>4__this = this;
			return <Param14Iter>d__;
		}

		// Token: 0x06005891 RID: 22673 RVA: 0x001FD854 File Offset: 0x001FBA54
		[NullableContext(1)]
		[Obsolete("已废弃，请使用Param15FrozenDict()缓存字典，遍历请使用Param15Iter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<string, string> Param15()
		{
			return this.Param15Iter().ToDictionary((DicStringString element) => element.Key, (DicStringString element) => element.Value);
		}

		// Token: 0x06005892 RID: 22674 RVA: 0x001FD8AA File Offset: 0x001FBAAA
		[NullableContext(1)]
		public readonly IEnumerable<DicStringString> Param15Iter()
		{
			ConditionType.<Param15Iter>d__146 <Param15Iter>d__ = new ConditionType.<Param15Iter>d__146(-2);
			<Param15Iter>d__.<>3__<>4__this = this;
			return <Param15Iter>d__;
		}

		// Token: 0x06005893 RID: 22675 RVA: 0x001FD8C0 File Offset: 0x001FBAC0
		[NullableContext(1)]
		[Obsolete("已废弃，请使用Param16FrozenDict()缓存字典，遍历请使用Param16Iter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<string, string> Param16()
		{
			return this.Param16Iter().ToDictionary((DicStringString element) => element.Key, (DicStringString element) => element.Value);
		}

		// Token: 0x06005894 RID: 22676 RVA: 0x001FD916 File Offset: 0x001FBB16
		[NullableContext(1)]
		public readonly IEnumerable<DicStringString> Param16Iter()
		{
			ConditionType.<Param16Iter>d__148 <Param16Iter>d__ = new ConditionType.<Param16Iter>d__148(-2);
			<Param16Iter>d__.<>3__<>4__this = this;
			return <Param16Iter>d__;
		}

		// Token: 0x06005895 RID: 22677 RVA: 0x001FD92C File Offset: 0x001FBB2C
		[NullableContext(1)]
		[Obsolete("已废弃，请使用Param2FrozenDict()缓存字典，遍历请使用Param2Iter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<string, string> Param2()
		{
			return this.Param2Iter().ToDictionary((DicStringString element) => element.Key, (DicStringString element) => element.Value);
		}

		// Token: 0x06005896 RID: 22678 RVA: 0x001FD982 File Offset: 0x001FBB82
		[NullableContext(1)]
		public readonly IEnumerable<DicStringString> Param2Iter()
		{
			ConditionType.<Param2Iter>d__150 <Param2Iter>d__ = new ConditionType.<Param2Iter>d__150(-2);
			<Param2Iter>d__.<>3__<>4__this = this;
			return <Param2Iter>d__;
		}

		// Token: 0x06005897 RID: 22679 RVA: 0x001FD998 File Offset: 0x001FBB98
		[NullableContext(1)]
		[Obsolete("已废弃，请使用Param3FrozenDict()缓存字典，遍历请使用Param3Iter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<string, string> Param3()
		{
			return this.Param3Iter().ToDictionary((DicStringString element) => element.Key, (DicStringString element) => element.Value);
		}

		// Token: 0x06005898 RID: 22680 RVA: 0x001FD9EE File Offset: 0x001FBBEE
		[NullableContext(1)]
		public readonly IEnumerable<DicStringString> Param3Iter()
		{
			ConditionType.<Param3Iter>d__152 <Param3Iter>d__ = new ConditionType.<Param3Iter>d__152(-2);
			<Param3Iter>d__.<>3__<>4__this = this;
			return <Param3Iter>d__;
		}

		// Token: 0x06005899 RID: 22681 RVA: 0x001FDA04 File Offset: 0x001FBC04
		[NullableContext(1)]
		[Obsolete("已废弃，请使用Param4FrozenDict()缓存字典，遍历请使用Param4Iter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<string, string> Param4()
		{
			return this.Param4Iter().ToDictionary((DicStringString element) => element.Key, (DicStringString element) => element.Value);
		}

		// Token: 0x0600589A RID: 22682 RVA: 0x001FDA5A File Offset: 0x001FBC5A
		[NullableContext(1)]
		public readonly IEnumerable<DicStringString> Param4Iter()
		{
			ConditionType.<Param4Iter>d__154 <Param4Iter>d__ = new ConditionType.<Param4Iter>d__154(-2);
			<Param4Iter>d__.<>3__<>4__this = this;
			return <Param4Iter>d__;
		}

		// Token: 0x0600589B RID: 22683 RVA: 0x001FDA70 File Offset: 0x001FBC70
		[NullableContext(1)]
		[Obsolete("已废弃，请使用Param5FrozenDict()缓存字典，遍历请使用Param5Iter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<string, string> Param5()
		{
			return this.Param5Iter().ToDictionary((DicStringString element) => element.Key, (DicStringString element) => element.Value);
		}

		// Token: 0x0600589C RID: 22684 RVA: 0x001FDAC6 File Offset: 0x001FBCC6
		[NullableContext(1)]
		public readonly IEnumerable<DicStringString> Param5Iter()
		{
			ConditionType.<Param5Iter>d__156 <Param5Iter>d__ = new ConditionType.<Param5Iter>d__156(-2);
			<Param5Iter>d__.<>3__<>4__this = this;
			return <Param5Iter>d__;
		}

		// Token: 0x0600589D RID: 22685 RVA: 0x001FDADC File Offset: 0x001FBCDC
		[NullableContext(1)]
		[Obsolete("已废弃，请使用Param6FrozenDict()缓存字典，遍历请使用Param6Iter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<string, string> Param6()
		{
			return this.Param6Iter().ToDictionary((DicStringString element) => element.Key, (DicStringString element) => element.Value);
		}

		// Token: 0x0600589E RID: 22686 RVA: 0x001FDB32 File Offset: 0x001FBD32
		[NullableContext(1)]
		public readonly IEnumerable<DicStringString> Param6Iter()
		{
			ConditionType.<Param6Iter>d__158 <Param6Iter>d__ = new ConditionType.<Param6Iter>d__158(-2);
			<Param6Iter>d__.<>3__<>4__this = this;
			return <Param6Iter>d__;
		}

		// Token: 0x0600589F RID: 22687 RVA: 0x001FDB48 File Offset: 0x001FBD48
		[NullableContext(1)]
		[Obsolete("已废弃，请使用Param7FrozenDict()缓存字典，遍历请使用Param7Iter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<string, string> Param7()
		{
			return this.Param7Iter().ToDictionary((DicStringString element) => element.Key, (DicStringString element) => element.Value);
		}

		// Token: 0x060058A0 RID: 22688 RVA: 0x001FDB9E File Offset: 0x001FBD9E
		[NullableContext(1)]
		public readonly IEnumerable<DicStringString> Param7Iter()
		{
			ConditionType.<Param7Iter>d__160 <Param7Iter>d__ = new ConditionType.<Param7Iter>d__160(-2);
			<Param7Iter>d__.<>3__<>4__this = this;
			return <Param7Iter>d__;
		}

		// Token: 0x060058A1 RID: 22689 RVA: 0x001FDBB4 File Offset: 0x001FBDB4
		[NullableContext(1)]
		[Obsolete("已废弃，请使用Param8FrozenDict()缓存字典，遍历请使用Param8Iter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<string, string> Param8()
		{
			return this.Param8Iter().ToDictionary((DicStringString element) => element.Key, (DicStringString element) => element.Value);
		}

		// Token: 0x060058A2 RID: 22690 RVA: 0x001FDC0A File Offset: 0x001FBE0A
		[NullableContext(1)]
		public readonly IEnumerable<DicStringString> Param8Iter()
		{
			ConditionType.<Param8Iter>d__162 <Param8Iter>d__ = new ConditionType.<Param8Iter>d__162(-2);
			<Param8Iter>d__.<>3__<>4__this = this;
			return <Param8Iter>d__;
		}

		// Token: 0x060058A3 RID: 22691 RVA: 0x001FDC20 File Offset: 0x001FBE20
		[NullableContext(1)]
		[Obsolete("已废弃，请使用Param9FrozenDict()缓存字典，遍历请使用Param9Iter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<string, string> Param9()
		{
			return this.Param9Iter().ToDictionary((DicStringString element) => element.Key, (DicStringString element) => element.Value);
		}

		// Token: 0x060058A4 RID: 22692 RVA: 0x001FDC76 File Offset: 0x001FBE76
		[NullableContext(1)]
		public readonly IEnumerable<DicStringString> Param9Iter()
		{
			ConditionType.<Param9Iter>d__164 <Param9Iter>d__ = new ConditionType.<Param9Iter>d__164(-2);
			<Param9Iter>d__.<>3__<>4__this = this;
			return <Param9Iter>d__;
		}

		// Token: 0x060058A5 RID: 22693 RVA: 0x001FDC8C File Offset: 0x001FBE8C
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用RegisterPlacesIter()或GetRegisterPlacesBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] RegisterPlaces()
		{
			ConditionType conditionType = this;
			return conditionType.GetRegisterPlacesArray() ?? Array.Empty<int>();
		}

		// Token: 0x060058A6 RID: 22694 RVA: 0x001FDCB0 File Offset: 0x001FBEB0
		[NullableContext(1)]
		public readonly IEnumerable<int> RegisterPlacesIter()
		{
			ConditionType.<RegisterPlacesIter>d__166 <RegisterPlacesIter>d__ = new ConditionType.<RegisterPlacesIter>d__166(-2);
			<RegisterPlacesIter>d__.<>3__<>4__this = this;
			return <RegisterPlacesIter>d__;
		}

		// Token: 0x060058A7 RID: 22695 RVA: 0x001FDCC8 File Offset: 0x001FBEC8
		[NullableContext(1)]
		[return: Nullable(2)]
		public string GetParam1(string key)
		{
			this.EnsureParam1CacheIfNeeded();
			string result;
			if (!this.Param1Cache.TryGetValue(key, out result))
			{
				return null;
			}
			return result;
		}

		// Token: 0x060058A8 RID: 22696 RVA: 0x001FDCF0 File Offset: 0x001FBEF0
		[NullableContext(1)]
		[return: Nullable(2)]
		public string GetParam10(string key)
		{
			this.EnsureParam10CacheIfNeeded();
			string result;
			if (!this.Param10Cache.TryGetValue(key, out result))
			{
				return null;
			}
			return result;
		}

		// Token: 0x060058A9 RID: 22697 RVA: 0x001FDD18 File Offset: 0x001FBF18
		[NullableContext(1)]
		[return: Nullable(2)]
		public string GetParam11(string key)
		{
			this.EnsureParam11CacheIfNeeded();
			string result;
			if (!this.Param11Cache.TryGetValue(key, out result))
			{
				return null;
			}
			return result;
		}

		// Token: 0x060058AA RID: 22698 RVA: 0x001FDD40 File Offset: 0x001FBF40
		[NullableContext(1)]
		[return: Nullable(2)]
		public string GetParam12(string key)
		{
			this.EnsureParam12CacheIfNeeded();
			string result;
			if (!this.Param12Cache.TryGetValue(key, out result))
			{
				return null;
			}
			return result;
		}

		// Token: 0x060058AB RID: 22699 RVA: 0x001FDD68 File Offset: 0x001FBF68
		[NullableContext(1)]
		[return: Nullable(2)]
		public string GetParam13(string key)
		{
			this.EnsureParam13CacheIfNeeded();
			string result;
			if (!this.Param13Cache.TryGetValue(key, out result))
			{
				return null;
			}
			return result;
		}

		// Token: 0x060058AC RID: 22700 RVA: 0x001FDD90 File Offset: 0x001FBF90
		[NullableContext(1)]
		[return: Nullable(2)]
		public string GetParam14(string key)
		{
			this.EnsureParam14CacheIfNeeded();
			string result;
			if (!this.Param14Cache.TryGetValue(key, out result))
			{
				return null;
			}
			return result;
		}

		// Token: 0x060058AD RID: 22701 RVA: 0x001FDDB8 File Offset: 0x001FBFB8
		[NullableContext(1)]
		[return: Nullable(2)]
		public string GetParam15(string key)
		{
			this.EnsureParam15CacheIfNeeded();
			string result;
			if (!this.Param15Cache.TryGetValue(key, out result))
			{
				return null;
			}
			return result;
		}

		// Token: 0x060058AE RID: 22702 RVA: 0x001FDDE0 File Offset: 0x001FBFE0
		[NullableContext(1)]
		[return: Nullable(2)]
		public string GetParam16(string key)
		{
			this.EnsureParam16CacheIfNeeded();
			string result;
			if (!this.Param16Cache.TryGetValue(key, out result))
			{
				return null;
			}
			return result;
		}

		// Token: 0x060058AF RID: 22703 RVA: 0x001FDE08 File Offset: 0x001FC008
		[NullableContext(1)]
		[return: Nullable(2)]
		public string GetParam2(string key)
		{
			this.EnsureParam2CacheIfNeeded();
			string result;
			if (!this.Param2Cache.TryGetValue(key, out result))
			{
				return null;
			}
			return result;
		}

		// Token: 0x060058B0 RID: 22704 RVA: 0x001FDE30 File Offset: 0x001FC030
		[NullableContext(1)]
		[return: Nullable(2)]
		public string GetParam3(string key)
		{
			this.EnsureParam3CacheIfNeeded();
			string result;
			if (!this.Param3Cache.TryGetValue(key, out result))
			{
				return null;
			}
			return result;
		}

		// Token: 0x060058B1 RID: 22705 RVA: 0x001FDE58 File Offset: 0x001FC058
		[NullableContext(1)]
		[return: Nullable(2)]
		public string GetParam4(string key)
		{
			this.EnsureParam4CacheIfNeeded();
			string result;
			if (!this.Param4Cache.TryGetValue(key, out result))
			{
				return null;
			}
			return result;
		}

		// Token: 0x060058B2 RID: 22706 RVA: 0x001FDE80 File Offset: 0x001FC080
		[NullableContext(1)]
		[return: Nullable(2)]
		public string GetParam5(string key)
		{
			this.EnsureParam5CacheIfNeeded();
			string result;
			if (!this.Param5Cache.TryGetValue(key, out result))
			{
				return null;
			}
			return result;
		}

		// Token: 0x060058B3 RID: 22707 RVA: 0x001FDEA8 File Offset: 0x001FC0A8
		[NullableContext(1)]
		[return: Nullable(2)]
		public string GetParam6(string key)
		{
			this.EnsureParam6CacheIfNeeded();
			string result;
			if (!this.Param6Cache.TryGetValue(key, out result))
			{
				return null;
			}
			return result;
		}

		// Token: 0x060058B4 RID: 22708 RVA: 0x001FDED0 File Offset: 0x001FC0D0
		[NullableContext(1)]
		[return: Nullable(2)]
		public string GetParam7(string key)
		{
			this.EnsureParam7CacheIfNeeded();
			string result;
			if (!this.Param7Cache.TryGetValue(key, out result))
			{
				return null;
			}
			return result;
		}

		// Token: 0x060058B5 RID: 22709 RVA: 0x001FDEF8 File Offset: 0x001FC0F8
		[NullableContext(1)]
		[return: Nullable(2)]
		public string GetParam8(string key)
		{
			this.EnsureParam8CacheIfNeeded();
			string result;
			if (!this.Param8Cache.TryGetValue(key, out result))
			{
				return null;
			}
			return result;
		}

		// Token: 0x060058B6 RID: 22710 RVA: 0x001FDF20 File Offset: 0x001FC120
		[NullableContext(1)]
		[return: Nullable(2)]
		public string GetParam9(string key)
		{
			this.EnsureParam9CacheIfNeeded();
			string result;
			if (!this.Param9Cache.TryGetValue(key, out result))
			{
				return null;
			}
			return result;
		}

		// Token: 0x060058B7 RID: 22711 RVA: 0x001FDF48 File Offset: 0x001FC148
		private void EnsureParam1CacheIfNeeded()
		{
			if (this.Param1Cache != null)
			{
				return;
			}
			this.Param1Cache = this.Param1Iter().ToFrozenDictionary((DicStringString kvp) => kvp.Key, (DicStringString kvp) => kvp.Value, null);
		}

		// Token: 0x060058B8 RID: 22712 RVA: 0x001FDFB0 File Offset: 0x001FC1B0
		private void EnsureParam10CacheIfNeeded()
		{
			if (this.Param10Cache != null)
			{
				return;
			}
			this.Param10Cache = this.Param10Iter().ToFrozenDictionary((DicStringString kvp) => kvp.Key, (DicStringString kvp) => kvp.Value, null);
		}

		// Token: 0x060058B9 RID: 22713 RVA: 0x001FE018 File Offset: 0x001FC218
		private void EnsureParam11CacheIfNeeded()
		{
			if (this.Param11Cache != null)
			{
				return;
			}
			this.Param11Cache = this.Param11Iter().ToFrozenDictionary((DicStringString kvp) => kvp.Key, (DicStringString kvp) => kvp.Value, null);
		}

		// Token: 0x060058BA RID: 22714 RVA: 0x001FE080 File Offset: 0x001FC280
		private void EnsureParam12CacheIfNeeded()
		{
			if (this.Param12Cache != null)
			{
				return;
			}
			this.Param12Cache = this.Param12Iter().ToFrozenDictionary((DicStringString kvp) => kvp.Key, (DicStringString kvp) => kvp.Value, null);
		}

		// Token: 0x060058BB RID: 22715 RVA: 0x001FE0E8 File Offset: 0x001FC2E8
		private void EnsureParam13CacheIfNeeded()
		{
			if (this.Param13Cache != null)
			{
				return;
			}
			this.Param13Cache = this.Param13Iter().ToFrozenDictionary((DicStringString kvp) => kvp.Key, (DicStringString kvp) => kvp.Value, null);
		}

		// Token: 0x060058BC RID: 22716 RVA: 0x001FE150 File Offset: 0x001FC350
		private void EnsureParam14CacheIfNeeded()
		{
			if (this.Param14Cache != null)
			{
				return;
			}
			this.Param14Cache = this.Param14Iter().ToFrozenDictionary((DicStringString kvp) => kvp.Key, (DicStringString kvp) => kvp.Value, null);
		}

		// Token: 0x060058BD RID: 22717 RVA: 0x001FE1B8 File Offset: 0x001FC3B8
		private void EnsureParam15CacheIfNeeded()
		{
			if (this.Param15Cache != null)
			{
				return;
			}
			this.Param15Cache = this.Param15Iter().ToFrozenDictionary((DicStringString kvp) => kvp.Key, (DicStringString kvp) => kvp.Value, null);
		}

		// Token: 0x060058BE RID: 22718 RVA: 0x001FE220 File Offset: 0x001FC420
		private void EnsureParam16CacheIfNeeded()
		{
			if (this.Param16Cache != null)
			{
				return;
			}
			this.Param16Cache = this.Param16Iter().ToFrozenDictionary((DicStringString kvp) => kvp.Key, (DicStringString kvp) => kvp.Value, null);
		}

		// Token: 0x060058BF RID: 22719 RVA: 0x001FE288 File Offset: 0x001FC488
		private void EnsureParam2CacheIfNeeded()
		{
			if (this.Param2Cache != null)
			{
				return;
			}
			this.Param2Cache = this.Param2Iter().ToFrozenDictionary((DicStringString kvp) => kvp.Key, (DicStringString kvp) => kvp.Value, null);
		}

		// Token: 0x060058C0 RID: 22720 RVA: 0x001FE2F0 File Offset: 0x001FC4F0
		private void EnsureParam3CacheIfNeeded()
		{
			if (this.Param3Cache != null)
			{
				return;
			}
			this.Param3Cache = this.Param3Iter().ToFrozenDictionary((DicStringString kvp) => kvp.Key, (DicStringString kvp) => kvp.Value, null);
		}

		// Token: 0x060058C1 RID: 22721 RVA: 0x001FE358 File Offset: 0x001FC558
		private void EnsureParam4CacheIfNeeded()
		{
			if (this.Param4Cache != null)
			{
				return;
			}
			this.Param4Cache = this.Param4Iter().ToFrozenDictionary((DicStringString kvp) => kvp.Key, (DicStringString kvp) => kvp.Value, null);
		}

		// Token: 0x060058C2 RID: 22722 RVA: 0x001FE3C0 File Offset: 0x001FC5C0
		private void EnsureParam5CacheIfNeeded()
		{
			if (this.Param5Cache != null)
			{
				return;
			}
			this.Param5Cache = this.Param5Iter().ToFrozenDictionary((DicStringString kvp) => kvp.Key, (DicStringString kvp) => kvp.Value, null);
		}

		// Token: 0x060058C3 RID: 22723 RVA: 0x001FE428 File Offset: 0x001FC628
		private void EnsureParam6CacheIfNeeded()
		{
			if (this.Param6Cache != null)
			{
				return;
			}
			this.Param6Cache = this.Param6Iter().ToFrozenDictionary((DicStringString kvp) => kvp.Key, (DicStringString kvp) => kvp.Value, null);
		}

		// Token: 0x060058C4 RID: 22724 RVA: 0x001FE490 File Offset: 0x001FC690
		private void EnsureParam7CacheIfNeeded()
		{
			if (this.Param7Cache != null)
			{
				return;
			}
			this.Param7Cache = this.Param7Iter().ToFrozenDictionary((DicStringString kvp) => kvp.Key, (DicStringString kvp) => kvp.Value, null);
		}

		// Token: 0x060058C5 RID: 22725 RVA: 0x001FE4F8 File Offset: 0x001FC6F8
		private void EnsureParam8CacheIfNeeded()
		{
			if (this.Param8Cache != null)
			{
				return;
			}
			this.Param8Cache = this.Param8Iter().ToFrozenDictionary((DicStringString kvp) => kvp.Key, (DicStringString kvp) => kvp.Value, null);
		}

		// Token: 0x060058C6 RID: 22726 RVA: 0x001FE560 File Offset: 0x001FC760
		private void EnsureParam9CacheIfNeeded()
		{
			if (this.Param9Cache != null)
			{
				return;
			}
			this.Param9Cache = this.Param9Iter().ToFrozenDictionary((DicStringString kvp) => kvp.Key, (DicStringString kvp) => kvp.Value, null);
		}

		// Token: 0x060058C7 RID: 22727 RVA: 0x001FE5C6 File Offset: 0x001FC7C6
		[NullableContext(1)]
		[return: Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		public FrozenDictionary<string, string> GetParam1FrozenDict(string key)
		{
			this.EnsureParam1CacheIfNeeded();
			return this.Param1Cache;
		}

		// Token: 0x060058C8 RID: 22728 RVA: 0x001FE5D4 File Offset: 0x001FC7D4
		[NullableContext(1)]
		[return: Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		public FrozenDictionary<string, string> GetParam10FrozenDict(string key)
		{
			this.EnsureParam10CacheIfNeeded();
			return this.Param10Cache;
		}

		// Token: 0x060058C9 RID: 22729 RVA: 0x001FE5E2 File Offset: 0x001FC7E2
		[NullableContext(1)]
		[return: Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		public FrozenDictionary<string, string> GetParam11FrozenDict(string key)
		{
			this.EnsureParam11CacheIfNeeded();
			return this.Param11Cache;
		}

		// Token: 0x060058CA RID: 22730 RVA: 0x001FE5F0 File Offset: 0x001FC7F0
		[NullableContext(1)]
		[return: Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		public FrozenDictionary<string, string> GetParam12FrozenDict(string key)
		{
			this.EnsureParam12CacheIfNeeded();
			return this.Param12Cache;
		}

		// Token: 0x060058CB RID: 22731 RVA: 0x001FE5FE File Offset: 0x001FC7FE
		[NullableContext(1)]
		[return: Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		public FrozenDictionary<string, string> GetParam13FrozenDict(string key)
		{
			this.EnsureParam13CacheIfNeeded();
			return this.Param13Cache;
		}

		// Token: 0x060058CC RID: 22732 RVA: 0x001FE60C File Offset: 0x001FC80C
		[NullableContext(1)]
		[return: Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		public FrozenDictionary<string, string> GetParam14FrozenDict(string key)
		{
			this.EnsureParam14CacheIfNeeded();
			return this.Param14Cache;
		}

		// Token: 0x060058CD RID: 22733 RVA: 0x001FE61A File Offset: 0x001FC81A
		[NullableContext(1)]
		[return: Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		public FrozenDictionary<string, string> GetParam15FrozenDict(string key)
		{
			this.EnsureParam15CacheIfNeeded();
			return this.Param15Cache;
		}

		// Token: 0x060058CE RID: 22734 RVA: 0x001FE628 File Offset: 0x001FC828
		[NullableContext(1)]
		[return: Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		public FrozenDictionary<string, string> GetParam16FrozenDict(string key)
		{
			this.EnsureParam16CacheIfNeeded();
			return this.Param16Cache;
		}

		// Token: 0x060058CF RID: 22735 RVA: 0x001FE636 File Offset: 0x001FC836
		[NullableContext(1)]
		[return: Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		public FrozenDictionary<string, string> GetParam2FrozenDict(string key)
		{
			this.EnsureParam2CacheIfNeeded();
			return this.Param2Cache;
		}

		// Token: 0x060058D0 RID: 22736 RVA: 0x001FE644 File Offset: 0x001FC844
		[NullableContext(1)]
		[return: Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		public FrozenDictionary<string, string> GetParam3FrozenDict(string key)
		{
			this.EnsureParam3CacheIfNeeded();
			return this.Param3Cache;
		}

		// Token: 0x060058D1 RID: 22737 RVA: 0x001FE652 File Offset: 0x001FC852
		[NullableContext(1)]
		[return: Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		public FrozenDictionary<string, string> GetParam4FrozenDict(string key)
		{
			this.EnsureParam4CacheIfNeeded();
			return this.Param4Cache;
		}

		// Token: 0x060058D2 RID: 22738 RVA: 0x001FE660 File Offset: 0x001FC860
		[NullableContext(1)]
		[return: Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		public FrozenDictionary<string, string> GetParam5FrozenDict(string key)
		{
			this.EnsureParam5CacheIfNeeded();
			return this.Param5Cache;
		}

		// Token: 0x060058D3 RID: 22739 RVA: 0x001FE66E File Offset: 0x001FC86E
		[NullableContext(1)]
		[return: Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		public FrozenDictionary<string, string> GetParam6FrozenDict(string key)
		{
			this.EnsureParam6CacheIfNeeded();
			return this.Param6Cache;
		}

		// Token: 0x060058D4 RID: 22740 RVA: 0x001FE67C File Offset: 0x001FC87C
		[NullableContext(1)]
		[return: Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		public FrozenDictionary<string, string> GetParam7FrozenDict(string key)
		{
			this.EnsureParam7CacheIfNeeded();
			return this.Param7Cache;
		}

		// Token: 0x060058D5 RID: 22741 RVA: 0x001FE68A File Offset: 0x001FC88A
		[NullableContext(1)]
		[return: Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		public FrozenDictionary<string, string> GetParam8FrozenDict(string key)
		{
			this.EnsureParam8CacheIfNeeded();
			return this.Param8Cache;
		}

		// Token: 0x060058D6 RID: 22742 RVA: 0x001FE698 File Offset: 0x001FC898
		[NullableContext(1)]
		[return: Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		public FrozenDictionary<string, string> GetParam9FrozenDict(string key)
		{
			this.EnsureParam9CacheIfNeeded();
			return this.Param9Cache;
		}

		// Token: 0x04004BA7 RID: 19367
		private Table __p;

		// Token: 0x04004BA8 RID: 19368
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private FrozenDictionary<string, string> Param1Cache;

		// Token: 0x04004BA9 RID: 19369
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private FrozenDictionary<string, string> Param10Cache;

		// Token: 0x04004BAA RID: 19370
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private FrozenDictionary<string, string> Param11Cache;

		// Token: 0x04004BAB RID: 19371
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private FrozenDictionary<string, string> Param12Cache;

		// Token: 0x04004BAC RID: 19372
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private FrozenDictionary<string, string> Param13Cache;

		// Token: 0x04004BAD RID: 19373
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private FrozenDictionary<string, string> Param14Cache;

		// Token: 0x04004BAE RID: 19374
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private FrozenDictionary<string, string> Param15Cache;

		// Token: 0x04004BAF RID: 19375
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private FrozenDictionary<string, string> Param16Cache;

		// Token: 0x04004BB0 RID: 19376
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private FrozenDictionary<string, string> Param2Cache;

		// Token: 0x04004BB1 RID: 19377
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private FrozenDictionary<string, string> Param3Cache;

		// Token: 0x04004BB2 RID: 19378
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private FrozenDictionary<string, string> Param4Cache;

		// Token: 0x04004BB3 RID: 19379
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private FrozenDictionary<string, string> Param5Cache;

		// Token: 0x04004BB4 RID: 19380
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private FrozenDictionary<string, string> Param6Cache;

		// Token: 0x04004BB5 RID: 19381
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private FrozenDictionary<string, string> Param7Cache;

		// Token: 0x04004BB6 RID: 19382
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private FrozenDictionary<string, string> Param8Cache;

		// Token: 0x04004BB7 RID: 19383
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private FrozenDictionary<string, string> Param9Cache;
	}
}
