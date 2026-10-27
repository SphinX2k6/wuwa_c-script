using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F40 RID: 3904
	public struct PinballWeaponSubEntry : IFlatbufferObject
	{
		// Token: 0x17002A0F RID: 10767
		// (get) Token: 0x0600B0DC RID: 45276 RVA: 0x002C60F8 File Offset: 0x002C42F8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600B0DD RID: 45277 RVA: 0x002C6105 File Offset: 0x002C4305
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600B0DE RID: 45278 RVA: 0x002C610C File Offset: 0x002C430C
		public static PinballWeaponSubEntry GetRootAsPinballWeaponSubEntry(ByteBuffer _bb)
		{
			return PinballWeaponSubEntry.GetRootAsPinballWeaponSubEntry(_bb, default(PinballWeaponSubEntry));
		}

		// Token: 0x0600B0DF RID: 45279 RVA: 0x002C6128 File Offset: 0x002C4328
		public static PinballWeaponSubEntry GetRootAsPinballWeaponSubEntry(ByteBuffer _bb, PinballWeaponSubEntry obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600B0E0 RID: 45280 RVA: 0x002C6145 File Offset: 0x002C4345
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600B0E1 RID: 45281 RVA: 0x002C6154 File Offset: 0x002C4354
		public PinballWeaponSubEntry __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002A10 RID: 10768
		// (get) Token: 0x0600B0E2 RID: 45282 RVA: 0x002C6164 File Offset: 0x002C4364
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

		// Token: 0x17002A11 RID: 10769
		// (get) Token: 0x0600B0E3 RID: 45283 RVA: 0x002C61A0 File Offset: 0x002C43A0
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

		// Token: 0x0600B0E4 RID: 45284 RVA: 0x002C61D7 File Offset: 0x002C43D7
		public Span<byte> GetProperDescBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600B0E5 RID: 45285 RVA: 0x002C61E6 File Offset: 0x002C43E6
		public byte[] GetProperDescArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x0600B0E6 RID: 45286 RVA: 0x002C6200 File Offset: 0x002C4400
		public string ProperVal(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002A12 RID: 10770
		// (get) Token: 0x0600B0E7 RID: 45287 RVA: 0x002C623C File Offset: 0x002C443C
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

		// Token: 0x17002A13 RID: 10771
		// (get) Token: 0x0600B0E8 RID: 45288 RVA: 0x002C6268 File Offset: 0x002C4468
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

		// Token: 0x17002A14 RID: 10772
		// (get) Token: 0x0600B0E9 RID: 45289 RVA: 0x002C62A8 File Offset: 0x002C44A8
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

		// Token: 0x17002A15 RID: 10773
		// (get) Token: 0x0600B0EA RID: 45290 RVA: 0x002C62E8 File Offset: 0x002C44E8
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

		// Token: 0x0600B0EB RID: 45291 RVA: 0x002C6325 File Offset: 0x002C4525
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用ProperValIter()或GetProperValBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] ProperVal()
		{
			return this.ProperValIter().ToArray<string>();
		}

		// Token: 0x0600B0EC RID: 45292 RVA: 0x002C6332 File Offset: 0x002C4532
		[NullableContext(1)]
		public readonly IEnumerable<string> ProperValIter()
		{
			PinballWeaponSubEntry.<ProperValIter>d__24 <ProperValIter>d__ = new PinballWeaponSubEntry.<ProperValIter>d__24(-2);
			<ProperValIter>d__.<>3__<>4__this = this;
			return <ProperValIter>d__;
		}

		// Token: 0x0400500A RID: 20490
		private Table __p;
	}
}
