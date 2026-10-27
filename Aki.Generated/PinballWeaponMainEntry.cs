using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F3E RID: 3902
	public struct PinballWeaponMainEntry : IFlatbufferObject
	{
		// Token: 0x17002A03 RID: 10755
		// (get) Token: 0x0600B0BB RID: 45243 RVA: 0x002C5CDD File Offset: 0x002C3EDD
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600B0BC RID: 45244 RVA: 0x002C5CEA File Offset: 0x002C3EEA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600B0BD RID: 45245 RVA: 0x002C5CF4 File Offset: 0x002C3EF4
		public static PinballWeaponMainEntry GetRootAsPinballWeaponMainEntry(ByteBuffer _bb)
		{
			return PinballWeaponMainEntry.GetRootAsPinballWeaponMainEntry(_bb, default(PinballWeaponMainEntry));
		}

		// Token: 0x0600B0BE RID: 45246 RVA: 0x002C5D10 File Offset: 0x002C3F10
		public static PinballWeaponMainEntry GetRootAsPinballWeaponMainEntry(ByteBuffer _bb, PinballWeaponMainEntry obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600B0BF RID: 45247 RVA: 0x002C5D2D File Offset: 0x002C3F2D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600B0C0 RID: 45248 RVA: 0x002C5D3C File Offset: 0x002C3F3C
		public PinballWeaponMainEntry __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002A04 RID: 10756
		// (get) Token: 0x0600B0C1 RID: 45249 RVA: 0x002C5D4C File Offset: 0x002C3F4C
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

		// Token: 0x17002A05 RID: 10757
		// (get) Token: 0x0600B0C2 RID: 45250 RVA: 0x002C5D88 File Offset: 0x002C3F88
		public string ProperDesc
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

		// Token: 0x0600B0C3 RID: 45251 RVA: 0x002C5DBF File Offset: 0x002C3FBF
		public Span<byte> GetProperDescBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600B0C4 RID: 45252 RVA: 0x002C5DCE File Offset: 0x002C3FCE
		public byte[] GetProperDescArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x0600B0C5 RID: 45253 RVA: 0x002C5DE8 File Offset: 0x002C3FE8
		public string ProperVal(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002A06 RID: 10758
		// (get) Token: 0x0600B0C6 RID: 45254 RVA: 0x002C5E24 File Offset: 0x002C4024
		public int ProperValLength
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x17002A07 RID: 10759
		// (get) Token: 0x0600B0C7 RID: 45255 RVA: 0x002C5E50 File Offset: 0x002C4050
		public int Buff
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

		// Token: 0x17002A08 RID: 10760
		// (get) Token: 0x0600B0C8 RID: 45256 RVA: 0x002C5E90 File Offset: 0x002C4090
		public int KscAttrType
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

		// Token: 0x17002A09 RID: 10761
		// (get) Token: 0x0600B0C9 RID: 45257 RVA: 0x002C5ED0 File Offset: 0x002C40D0
		public int KscAttrValue
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

		// Token: 0x0600B0CA RID: 45258 RVA: 0x002C5F0D File Offset: 0x002C410D
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用ProperValIter()或GetProperValBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] ProperVal()
		{
			return this.ProperValIter().ToArray<string>();
		}

		// Token: 0x0600B0CB RID: 45259 RVA: 0x002C5F1A File Offset: 0x002C411A
		[NullableContext(1)]
		public readonly IEnumerable<string> ProperValIter()
		{
			PinballWeaponMainEntry.<ProperValIter>d__24 <ProperValIter>d__ = new PinballWeaponMainEntry.<ProperValIter>d__24(-2);
			<ProperValIter>d__.<>3__<>4__this = this;
			return <ProperValIter>d__;
		}

		// Token: 0x04005008 RID: 20488
		private Table __p;
	}
}
