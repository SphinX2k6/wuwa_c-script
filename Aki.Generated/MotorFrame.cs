using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E54 RID: 3668
	public struct MotorFrame : IFlatbufferObject
	{
		// Token: 0x1700215A RID: 8538
		// (get) Token: 0x060099D0 RID: 39376 RVA: 0x002922C9 File Offset: 0x002904C9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060099D1 RID: 39377 RVA: 0x002922D6 File Offset: 0x002904D6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060099D2 RID: 39378 RVA: 0x002922E0 File Offset: 0x002904E0
		public static MotorFrame GetRootAsMotorFrame(ByteBuffer _bb)
		{
			return MotorFrame.GetRootAsMotorFrame(_bb, default(MotorFrame));
		}

		// Token: 0x060099D3 RID: 39379 RVA: 0x002922FC File Offset: 0x002904FC
		public static MotorFrame GetRootAsMotorFrame(ByteBuffer _bb, MotorFrame obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060099D4 RID: 39380 RVA: 0x00292319 File Offset: 0x00290519
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060099D5 RID: 39381 RVA: 0x00292328 File Offset: 0x00290528
		public MotorFrame __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700215B RID: 8539
		// (get) Token: 0x060099D6 RID: 39382 RVA: 0x00292338 File Offset: 0x00290538
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

		// Token: 0x1700215C RID: 8540
		// (get) Token: 0x060099D7 RID: 39383 RVA: 0x00292374 File Offset: 0x00290574
		public bool DefaultFlag
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700215D RID: 8541
		// (get) Token: 0x060099D8 RID: 39384 RVA: 0x002923B4 File Offset: 0x002905B4
		public bool Show
		{
			get
			{
				int num = this.__p.__offset(8);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700215E RID: 8542
		// (get) Token: 0x060099D9 RID: 39385 RVA: 0x002923F4 File Offset: 0x002905F4
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

		// Token: 0x1700215F RID: 8543
		// (get) Token: 0x060099DA RID: 39386 RVA: 0x00292434 File Offset: 0x00290634
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

		// Token: 0x17002160 RID: 8544
		// (get) Token: 0x060099DB RID: 39387 RVA: 0x00292474 File Offset: 0x00290674
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

		// Token: 0x17002161 RID: 8545
		// (get) Token: 0x060099DC RID: 39388 RVA: 0x002924B4 File Offset: 0x002906B4
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

		// Token: 0x17002162 RID: 8546
		// (get) Token: 0x060099DD RID: 39389 RVA: 0x002924F4 File Offset: 0x002906F4
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

		// Token: 0x060099DE RID: 39390 RVA: 0x00292534 File Offset: 0x00290734
		public long ModelBuff(int j)
		{
			int num = this.__p.__offset(20);
			return (long)((num != 0) ? this.__p.bb.GetDouble(this.__p.__vector(num) + j * 8) : 0.0);
		}

		// Token: 0x17002163 RID: 8547
		// (get) Token: 0x060099DF RID: 39391 RVA: 0x00292580 File Offset: 0x00290780
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

		// Token: 0x060099E0 RID: 39392 RVA: 0x002925AC File Offset: 0x002907AC
		public Span<long> GetModelBuffBytes()
		{
			return MemoryMarshal.Cast<double, long>(this.__p.__vector_as_span<double>(20, 8));
		}

		// Token: 0x060099E1 RID: 39393 RVA: 0x002925C1 File Offset: 0x002907C1
		public long[] GetModelBuffArray()
		{
			return Array.ConvertAll<double, long>(this.__p.__vector_as_array<double>(20) ?? Array.Empty<double>(), (double x) => (long)x);
		}

		// Token: 0x17002164 RID: 8548
		// (get) Token: 0x060099E2 RID: 39394 RVA: 0x00292600 File Offset: 0x00290800
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

		// Token: 0x060099E3 RID: 39395 RVA: 0x00292638 File Offset: 0x00290838
		public Span<byte> GetModelAnimBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x060099E4 RID: 39396 RVA: 0x00292648 File Offset: 0x00290848
		public byte[] GetModelAnimArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x17002165 RID: 8549
		// (get) Token: 0x060099E5 RID: 39397 RVA: 0x00292660 File Offset: 0x00290860
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

		// Token: 0x060099E6 RID: 39398 RVA: 0x00292698 File Offset: 0x00290898
		public Span<byte> GetModelIconPathBytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x060099E7 RID: 39399 RVA: 0x002926A8 File Offset: 0x002908A8
		public byte[] GetModelIconPathArray()
		{
			return this.__p.__vector_as_array<byte>(24) ?? Array.Empty<byte>();
		}

		// Token: 0x17002166 RID: 8550
		// (get) Token: 0x060099E8 RID: 39400 RVA: 0x002926C0 File Offset: 0x002908C0
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

		// Token: 0x060099E9 RID: 39401 RVA: 0x002926F8 File Offset: 0x002908F8
		public Span<byte> GetIconBigBytes()
		{
			return this.__p.__vector_as_span<byte>(26, 1);
		}

		// Token: 0x060099EA RID: 39402 RVA: 0x00292708 File Offset: 0x00290908
		public byte[] GetIconBigArray()
		{
			return this.__p.__vector_as_array<byte>(26) ?? Array.Empty<byte>();
		}

		// Token: 0x17002167 RID: 8551
		// (get) Token: 0x060099EB RID: 39403 RVA: 0x00292720 File Offset: 0x00290920
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

		// Token: 0x060099EC RID: 39404 RVA: 0x00292758 File Offset: 0x00290958
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(28, 1);
		}

		// Token: 0x060099ED RID: 39405 RVA: 0x00292768 File Offset: 0x00290968
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(28) ?? Array.Empty<byte>();
		}

		// Token: 0x17002168 RID: 8552
		// (get) Token: 0x060099EE RID: 39406 RVA: 0x00292780 File Offset: 0x00290980
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

		// Token: 0x060099EF RID: 39407 RVA: 0x002927B8 File Offset: 0x002909B8
		public Span<byte> GetPresetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(30, 1);
		}

		// Token: 0x060099F0 RID: 39408 RVA: 0x002927C8 File Offset: 0x002909C8
		public byte[] GetPresetIconArray()
		{
			return this.__p.__vector_as_array<byte>(30) ?? Array.Empty<byte>();
		}

		// Token: 0x17002169 RID: 8553
		// (get) Token: 0x060099F1 RID: 39409 RVA: 0x002927E0 File Offset: 0x002909E0
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

		// Token: 0x060099F2 RID: 39410 RVA: 0x00292818 File Offset: 0x00290A18
		public Span<byte> GetIconMiddleBytes()
		{
			return this.__p.__vector_as_span<byte>(32, 1);
		}

		// Token: 0x060099F3 RID: 39411 RVA: 0x00292828 File Offset: 0x00290A28
		public byte[] GetIconMiddleArray()
		{
			return this.__p.__vector_as_array<byte>(32) ?? Array.Empty<byte>();
		}

		// Token: 0x1700216A RID: 8554
		// (get) Token: 0x060099F4 RID: 39412 RVA: 0x00292840 File Offset: 0x00290A40
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

		// Token: 0x060099F5 RID: 39413 RVA: 0x00292878 File Offset: 0x00290A78
		public Span<byte> GetIconSmallBytes()
		{
			return this.__p.__vector_as_span<byte>(34, 1);
		}

		// Token: 0x060099F6 RID: 39414 RVA: 0x00292888 File Offset: 0x00290A88
		public byte[] GetIconSmallArray()
		{
			return this.__p.__vector_as_array<byte>(34) ?? Array.Empty<byte>();
		}

		// Token: 0x1700216B RID: 8555
		// (get) Token: 0x060099F7 RID: 39415 RVA: 0x002928A0 File Offset: 0x00290AA0
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

		// Token: 0x060099F8 RID: 39416 RVA: 0x002928D8 File Offset: 0x00290AD8
		public Span<byte> GetTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(36, 1);
		}

		// Token: 0x060099F9 RID: 39417 RVA: 0x002928E8 File Offset: 0x00290AE8
		public byte[] GetTitleArray()
		{
			return this.__p.__vector_as_array<byte>(36) ?? Array.Empty<byte>();
		}

		// Token: 0x1700216C RID: 8556
		// (get) Token: 0x060099FA RID: 39418 RVA: 0x00292900 File Offset: 0x00290B00
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

		// Token: 0x060099FB RID: 39419 RVA: 0x00292938 File Offset: 0x00290B38
		public Span<byte> GetSubTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(38, 1);
		}

		// Token: 0x060099FC RID: 39420 RVA: 0x00292948 File Offset: 0x00290B48
		public byte[] GetSubTitleArray()
		{
			return this.__p.__vector_as_array<byte>(38) ?? Array.Empty<byte>();
		}

		// Token: 0x1700216D RID: 8557
		// (get) Token: 0x060099FD RID: 39421 RVA: 0x00292960 File Offset: 0x00290B60
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

		// Token: 0x060099FE RID: 39422 RVA: 0x00292998 File Offset: 0x00290B98
		public Span<byte> GetTypeDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(40, 1);
		}

		// Token: 0x060099FF RID: 39423 RVA: 0x002929A8 File Offset: 0x00290BA8
		public byte[] GetTypeDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(40) ?? Array.Empty<byte>();
		}

		// Token: 0x1700216E RID: 8558
		// (get) Token: 0x06009A00 RID: 39424 RVA: 0x002929C0 File Offset: 0x00290BC0
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

		// Token: 0x06009A01 RID: 39425 RVA: 0x002929F8 File Offset: 0x00290BF8
		public Span<byte> GetBgDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(42, 1);
		}

		// Token: 0x06009A02 RID: 39426 RVA: 0x00292A08 File Offset: 0x00290C08
		public byte[] GetBgDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(42) ?? Array.Empty<byte>();
		}

		// Token: 0x1700216F RID: 8559
		// (get) Token: 0x06009A03 RID: 39427 RVA: 0x00292A20 File Offset: 0x00290C20
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

		// Token: 0x06009A04 RID: 39428 RVA: 0x00292A58 File Offset: 0x00290C58
		public Span<byte> GetAttributesDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(44, 1);
		}

		// Token: 0x06009A05 RID: 39429 RVA: 0x00292A68 File Offset: 0x00290C68
		public byte[] GetAttributesDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(44) ?? Array.Empty<byte>();
		}

		// Token: 0x06009A06 RID: 39430 RVA: 0x00292A80 File Offset: 0x00290C80
		public int ItemAccess(int j)
		{
			int num = this.__p.__offset(46);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002170 RID: 8560
		// (get) Token: 0x06009A07 RID: 39431 RVA: 0x00292AC0 File Offset: 0x00290CC0
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

		// Token: 0x06009A08 RID: 39432 RVA: 0x00292AEC File Offset: 0x00290CEC
		public Span<int> GetItemAccessBytes()
		{
			return this.__p.__vector_as_span<int>(46, 4);
		}

		// Token: 0x06009A09 RID: 39433 RVA: 0x00292AFC File Offset: 0x00290CFC
		public int[] GetItemAccessArray()
		{
			return this.__p.__vector_as_array<int>(46) ?? Array.Empty<int>();
		}

		// Token: 0x17002171 RID: 8561
		// (get) Token: 0x06009A0A RID: 39434 RVA: 0x00292B14 File Offset: 0x00290D14
		public bool ShowInBag
		{
			get
			{
				int num = this.__p.__offset(48);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17002172 RID: 8562
		// (get) Token: 0x06009A0B RID: 39435 RVA: 0x00292B54 File Offset: 0x00290D54
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

		// Token: 0x06009A0C RID: 39436 RVA: 0x00292B8C File Offset: 0x00290D8C
		public Span<byte> GetObtainedShowDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(50, 1);
		}

		// Token: 0x06009A0D RID: 39437 RVA: 0x00292B9C File Offset: 0x00290D9C
		public byte[] GetObtainedShowDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(50) ?? Array.Empty<byte>();
		}

		// Token: 0x06009A0E RID: 39438 RVA: 0x00292BB4 File Offset: 0x00290DB4
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用ItemAccessIter()或GetItemAccessBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] ItemAccess()
		{
			MotorFrame motorFrame = this;
			return motorFrame.GetItemAccessArray() ?? Array.Empty<int>();
		}

		// Token: 0x06009A0F RID: 39439 RVA: 0x00292BD8 File Offset: 0x00290DD8
		[NullableContext(1)]
		public readonly IEnumerable<int> ItemAccessIter()
		{
			MotorFrame.<ItemAccessIter>d__89 <ItemAccessIter>d__ = new MotorFrame.<ItemAccessIter>d__89(-2);
			<ItemAccessIter>d__.<>3__<>4__this = this;
			return <ItemAccessIter>d__;
		}

		// Token: 0x06009A10 RID: 39440 RVA: 0x00292BF0 File Offset: 0x00290DF0
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用ModelBuffIter()或GetModelBuffBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly long[] ModelBuff()
		{
			MotorFrame motorFrame = this;
			return motorFrame.GetModelBuffArray() ?? Array.Empty<long>();
		}

		// Token: 0x06009A11 RID: 39441 RVA: 0x00292C14 File Offset: 0x00290E14
		[NullableContext(1)]
		public readonly IEnumerable<long> ModelBuffIter()
		{
			MotorFrame.<ModelBuffIter>d__91 <ModelBuffIter>d__ = new MotorFrame.<ModelBuffIter>d__91(-2);
			<ModelBuffIter>d__.<>3__<>4__this = this;
			return <ModelBuffIter>d__;
		}

		// Token: 0x04004EFD RID: 20221
		private Table __p;
	}
}
