using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F39 RID: 3897
	public struct MotorFrame : IFlatbufferObject
	{
		// Token: 0x170021BF RID: 8639
		// (get) Token: 0x06009FF0 RID: 40944 RVA: 0x002AFD84 File Offset: 0x002ADF84
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06009FF1 RID: 40945 RVA: 0x002AFD91 File Offset: 0x002ADF91
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06009FF2 RID: 40946 RVA: 0x002AFD98 File Offset: 0x002ADF98
		public static MotorFrame GetRootAsMotorFrame(ByteBuffer _bb)
		{
			return MotorFrame.GetRootAsMotorFrame(_bb, default(MotorFrame));
		}

		// Token: 0x06009FF3 RID: 40947 RVA: 0x002AFDB4 File Offset: 0x002ADFB4
		public static MotorFrame GetRootAsMotorFrame(ByteBuffer _bb, MotorFrame obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06009FF4 RID: 40948 RVA: 0x002AFDD1 File Offset: 0x002ADFD1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06009FF5 RID: 40949 RVA: 0x002AFDE0 File Offset: 0x002ADFE0
		public MotorFrame __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170021C0 RID: 8640
		// (get) Token: 0x06009FF6 RID: 40950 RVA: 0x002AFDF0 File Offset: 0x002ADFF0
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

		// Token: 0x170021C1 RID: 8641
		// (get) Token: 0x06009FF7 RID: 40951 RVA: 0x002AFE2C File Offset: 0x002AE02C
		public bool DefaultFlag
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170021C2 RID: 8642
		// (get) Token: 0x06009FF8 RID: 40952 RVA: 0x002AFE6C File Offset: 0x002AE06C
		public bool Show
		{
			get
			{
				int num = this.__p.__offset(8);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170021C3 RID: 8643
		// (get) Token: 0x06009FF9 RID: 40953 RVA: 0x002AFEAC File Offset: 0x002AE0AC
		public int GroupId
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

		// Token: 0x170021C4 RID: 8644
		// (get) Token: 0x06009FFA RID: 40954 RVA: 0x002AFEEC File Offset: 0x002AE0EC
		public int QualityId
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170021C5 RID: 8645
		// (get) Token: 0x06009FFB RID: 40955 RVA: 0x002AFF2C File Offset: 0x002AE12C
		public int SortIndex
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

		// Token: 0x170021C6 RID: 8646
		// (get) Token: 0x06009FFC RID: 40956 RVA: 0x002AFF6C File Offset: 0x002AE16C
		public int ModelId
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

		// Token: 0x170021C7 RID: 8647
		// (get) Token: 0x06009FFD RID: 40957 RVA: 0x002AFFAC File Offset: 0x002AE1AC
		public int Wing
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

		// Token: 0x06009FFE RID: 40958 RVA: 0x002AFFEC File Offset: 0x002AE1EC
		public long ModelBuff(int j)
		{
			int num = this.__p.__offset(20);
			return (long)((num != 0) ? this.__p.bb.GetDouble(this.__p.__vector(num) + j * 8) : 0.0);
		}

		// Token: 0x170021C8 RID: 8648
		// (get) Token: 0x06009FFF RID: 40959 RVA: 0x002B0038 File Offset: 0x002AE238
		public int ModelBuffLength
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

		// Token: 0x0600A000 RID: 40960 RVA: 0x002B0064 File Offset: 0x002AE264
		public Span<long> GetModelBuffBytes()
		{
			return MemoryMarshal.Cast<double, long>(this.__p.__vector_as_span<double>(20, 8));
		}

		// Token: 0x0600A001 RID: 40961 RVA: 0x002B0079 File Offset: 0x002AE279
		public long[] GetModelBuffArray()
		{
			return Array.ConvertAll<double, long>(this.__p.__vector_as_array<double>(20) ?? Array.Empty<double>(), (double x) => (long)x);
		}

		// Token: 0x170021C9 RID: 8649
		// (get) Token: 0x0600A002 RID: 40962 RVA: 0x002B00B8 File Offset: 0x002AE2B8
		public string ModelAnim
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

		// Token: 0x0600A003 RID: 40963 RVA: 0x002B00F0 File Offset: 0x002AE2F0
		public Span<byte> GetModelAnimBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x0600A004 RID: 40964 RVA: 0x002B0100 File Offset: 0x002AE300
		public byte[] GetModelAnimArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x170021CA RID: 8650
		// (get) Token: 0x0600A005 RID: 40965 RVA: 0x002B0118 File Offset: 0x002AE318
		public string ModelIconPath
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

		// Token: 0x0600A006 RID: 40966 RVA: 0x002B0150 File Offset: 0x002AE350
		public Span<byte> GetModelIconPathBytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x0600A007 RID: 40967 RVA: 0x002B0160 File Offset: 0x002AE360
		public byte[] GetModelIconPathArray()
		{
			return this.__p.__vector_as_array<byte>(24) ?? Array.Empty<byte>();
		}

		// Token: 0x170021CB RID: 8651
		// (get) Token: 0x0600A008 RID: 40968 RVA: 0x002B0178 File Offset: 0x002AE378
		public string IconBig
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

		// Token: 0x0600A009 RID: 40969 RVA: 0x002B01B0 File Offset: 0x002AE3B0
		public Span<byte> GetIconBigBytes()
		{
			return this.__p.__vector_as_span<byte>(26, 1);
		}

		// Token: 0x0600A00A RID: 40970 RVA: 0x002B01C0 File Offset: 0x002AE3C0
		public byte[] GetIconBigArray()
		{
			return this.__p.__vector_as_array<byte>(26) ?? Array.Empty<byte>();
		}

		// Token: 0x170021CC RID: 8652
		// (get) Token: 0x0600A00B RID: 40971 RVA: 0x002B01D8 File Offset: 0x002AE3D8
		public string Icon
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

		// Token: 0x0600A00C RID: 40972 RVA: 0x002B0210 File Offset: 0x002AE410
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(28, 1);
		}

		// Token: 0x0600A00D RID: 40973 RVA: 0x002B0220 File Offset: 0x002AE420
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(28) ?? Array.Empty<byte>();
		}

		// Token: 0x170021CD RID: 8653
		// (get) Token: 0x0600A00E RID: 40974 RVA: 0x002B0238 File Offset: 0x002AE438
		public string PresetIcon
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

		// Token: 0x0600A00F RID: 40975 RVA: 0x002B0270 File Offset: 0x002AE470
		public Span<byte> GetPresetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(30, 1);
		}

		// Token: 0x0600A010 RID: 40976 RVA: 0x002B0280 File Offset: 0x002AE480
		public byte[] GetPresetIconArray()
		{
			return this.__p.__vector_as_array<byte>(30) ?? Array.Empty<byte>();
		}

		// Token: 0x170021CE RID: 8654
		// (get) Token: 0x0600A011 RID: 40977 RVA: 0x002B0298 File Offset: 0x002AE498
		public string IconMiddle
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

		// Token: 0x0600A012 RID: 40978 RVA: 0x002B02D0 File Offset: 0x002AE4D0
		public Span<byte> GetIconMiddleBytes()
		{
			return this.__p.__vector_as_span<byte>(32, 1);
		}

		// Token: 0x0600A013 RID: 40979 RVA: 0x002B02E0 File Offset: 0x002AE4E0
		public byte[] GetIconMiddleArray()
		{
			return this.__p.__vector_as_array<byte>(32) ?? Array.Empty<byte>();
		}

		// Token: 0x170021CF RID: 8655
		// (get) Token: 0x0600A014 RID: 40980 RVA: 0x002B02F8 File Offset: 0x002AE4F8
		public string IconSmall
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

		// Token: 0x0600A015 RID: 40981 RVA: 0x002B0330 File Offset: 0x002AE530
		public Span<byte> GetIconSmallBytes()
		{
			return this.__p.__vector_as_span<byte>(34, 1);
		}

		// Token: 0x0600A016 RID: 40982 RVA: 0x002B0340 File Offset: 0x002AE540
		public byte[] GetIconSmallArray()
		{
			return this.__p.__vector_as_array<byte>(34) ?? Array.Empty<byte>();
		}

		// Token: 0x170021D0 RID: 8656
		// (get) Token: 0x0600A017 RID: 40983 RVA: 0x002B0358 File Offset: 0x002AE558
		public string Title
		{
			get
			{
				int num = this.__p.__offset(36);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600A018 RID: 40984 RVA: 0x002B0390 File Offset: 0x002AE590
		public Span<byte> GetTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(36, 1);
		}

		// Token: 0x0600A019 RID: 40985 RVA: 0x002B03A0 File Offset: 0x002AE5A0
		public byte[] GetTitleArray()
		{
			return this.__p.__vector_as_array<byte>(36) ?? Array.Empty<byte>();
		}

		// Token: 0x170021D1 RID: 8657
		// (get) Token: 0x0600A01A RID: 40986 RVA: 0x002B03B8 File Offset: 0x002AE5B8
		public string SubTitle
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

		// Token: 0x0600A01B RID: 40987 RVA: 0x002B03F0 File Offset: 0x002AE5F0
		public Span<byte> GetSubTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(38, 1);
		}

		// Token: 0x0600A01C RID: 40988 RVA: 0x002B0400 File Offset: 0x002AE600
		public byte[] GetSubTitleArray()
		{
			return this.__p.__vector_as_array<byte>(38) ?? Array.Empty<byte>();
		}

		// Token: 0x170021D2 RID: 8658
		// (get) Token: 0x0600A01D RID: 40989 RVA: 0x002B0418 File Offset: 0x002AE618
		public string TypeDescription
		{
			get
			{
				int num = this.__p.__offset(40);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600A01E RID: 40990 RVA: 0x002B0450 File Offset: 0x002AE650
		public Span<byte> GetTypeDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(40, 1);
		}

		// Token: 0x0600A01F RID: 40991 RVA: 0x002B0460 File Offset: 0x002AE660
		public byte[] GetTypeDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(40) ?? Array.Empty<byte>();
		}

		// Token: 0x170021D3 RID: 8659
		// (get) Token: 0x0600A020 RID: 40992 RVA: 0x002B0478 File Offset: 0x002AE678
		public string BgDescription
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

		// Token: 0x0600A021 RID: 40993 RVA: 0x002B04B0 File Offset: 0x002AE6B0
		public Span<byte> GetBgDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(42, 1);
		}

		// Token: 0x0600A022 RID: 40994 RVA: 0x002B04C0 File Offset: 0x002AE6C0
		public byte[] GetBgDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(42) ?? Array.Empty<byte>();
		}

		// Token: 0x170021D4 RID: 8660
		// (get) Token: 0x0600A023 RID: 40995 RVA: 0x002B04D8 File Offset: 0x002AE6D8
		public string AttributesDescription
		{
			get
			{
				int num = this.__p.__offset(44);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600A024 RID: 40996 RVA: 0x002B0510 File Offset: 0x002AE710
		public Span<byte> GetAttributesDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(44, 1);
		}

		// Token: 0x0600A025 RID: 40997 RVA: 0x002B0520 File Offset: 0x002AE720
		public byte[] GetAttributesDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(44) ?? Array.Empty<byte>();
		}

		// Token: 0x0600A026 RID: 40998 RVA: 0x002B0538 File Offset: 0x002AE738
		public int ItemAccess(int j)
		{
			int num = this.__p.__offset(46);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170021D5 RID: 8661
		// (get) Token: 0x0600A027 RID: 40999 RVA: 0x002B0578 File Offset: 0x002AE778
		public int ItemAccessLength
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

		// Token: 0x0600A028 RID: 41000 RVA: 0x002B05A4 File Offset: 0x002AE7A4
		public Span<int> GetItemAccessBytes()
		{
			return this.__p.__vector_as_span<int>(46, 4);
		}

		// Token: 0x0600A029 RID: 41001 RVA: 0x002B05B4 File Offset: 0x002AE7B4
		public int[] GetItemAccessArray()
		{
			return this.__p.__vector_as_array<int>(46) ?? Array.Empty<int>();
		}

		// Token: 0x170021D6 RID: 8662
		// (get) Token: 0x0600A02A RID: 41002 RVA: 0x002B05CC File Offset: 0x002AE7CC
		public bool ShowInBag
		{
			get
			{
				int num = this.__p.__offset(48);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170021D7 RID: 8663
		// (get) Token: 0x0600A02B RID: 41003 RVA: 0x002B060C File Offset: 0x002AE80C
		public string ObtainedShowDescription
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

		// Token: 0x0600A02C RID: 41004 RVA: 0x002B0644 File Offset: 0x002AE844
		public Span<byte> GetObtainedShowDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(50, 1);
		}

		// Token: 0x0600A02D RID: 41005 RVA: 0x002B0654 File Offset: 0x002AE854
		public byte[] GetObtainedShowDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(50) ?? Array.Empty<byte>();
		}

		// Token: 0x0600A02E RID: 41006 RVA: 0x002B066C File Offset: 0x002AE86C
		[NullableContext(1)]
		public int[] ItemAccess()
		{
			return this.GetItemAccessArray();
		}

		// Token: 0x0600A02F RID: 41007 RVA: 0x002B0674 File Offset: 0x002AE874
		[NullableContext(1)]
		public IEnumerable<int> ItemAccessIter()
		{
			MotorFrame.<ItemAccessIter>d__89 <ItemAccessIter>d__ = new MotorFrame.<ItemAccessIter>d__89(-2);
			<ItemAccessIter>d__.<>3__<>4__this = this;
			return <ItemAccessIter>d__;
		}

		// Token: 0x0600A030 RID: 41008 RVA: 0x002B0689 File Offset: 0x002AE889
		[NullableContext(1)]
		public long[] ModelBuff()
		{
			return this.GetModelBuffArray();
		}

		// Token: 0x0600A031 RID: 41009 RVA: 0x002B0691 File Offset: 0x002AE891
		[NullableContext(1)]
		public IEnumerable<long> ModelBuffIter()
		{
			MotorFrame.<ModelBuffIter>d__91 <ModelBuffIter>d__ = new MotorFrame.<ModelBuffIter>d__91(-2);
			<ModelBuffIter>d__.<>3__<>4__this = this;
			return <ModelBuffIter>d__;
		}

		// Token: 0x040054E2 RID: 21730
		private Table __p;
	}
}
