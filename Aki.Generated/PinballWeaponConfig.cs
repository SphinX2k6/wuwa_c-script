using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F3D RID: 3901
	public struct PinballWeaponConfig : IFlatbufferObject
	{
		// Token: 0x170029F6 RID: 10742
		// (get) Token: 0x0600B09E RID: 45214 RVA: 0x002C588D File Offset: 0x002C3A8D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600B09F RID: 45215 RVA: 0x002C589A File Offset: 0x002C3A9A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600B0A0 RID: 45216 RVA: 0x002C58A4 File Offset: 0x002C3AA4
		public static PinballWeaponConfig GetRootAsPinballWeaponConfig(ByteBuffer _bb)
		{
			return PinballWeaponConfig.GetRootAsPinballWeaponConfig(_bb, default(PinballWeaponConfig));
		}

		// Token: 0x0600B0A1 RID: 45217 RVA: 0x002C58C0 File Offset: 0x002C3AC0
		public static PinballWeaponConfig GetRootAsPinballWeaponConfig(ByteBuffer _bb, PinballWeaponConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600B0A2 RID: 45218 RVA: 0x002C58DD File Offset: 0x002C3ADD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600B0A3 RID: 45219 RVA: 0x002C58EC File Offset: 0x002C3AEC
		public PinballWeaponConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170029F7 RID: 10743
		// (get) Token: 0x0600B0A4 RID: 45220 RVA: 0x002C58FC File Offset: 0x002C3AFC
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

		// Token: 0x170029F8 RID: 10744
		// (get) Token: 0x0600B0A5 RID: 45221 RVA: 0x002C5938 File Offset: 0x002C3B38
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

		// Token: 0x170029F9 RID: 10745
		// (get) Token: 0x0600B0A6 RID: 45222 RVA: 0x002C5974 File Offset: 0x002C3B74
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

		// Token: 0x170029FA RID: 10746
		// (get) Token: 0x0600B0A7 RID: 45223 RVA: 0x002C59B0 File Offset: 0x002C3BB0
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

		// Token: 0x170029FB RID: 10747
		// (get) Token: 0x0600B0A8 RID: 45224 RVA: 0x002C59F0 File Offset: 0x002C3BF0
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

		// Token: 0x0600B0A9 RID: 45225 RVA: 0x002C5A30 File Offset: 0x002C3C30
		public int PropList(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170029FC RID: 10748
		// (get) Token: 0x0600B0AA RID: 45226 RVA: 0x002C5A70 File Offset: 0x002C3C70
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

		// Token: 0x0600B0AB RID: 45227 RVA: 0x002C5A9C File Offset: 0x002C3C9C
		public Span<int> GetPropListBytes()
		{
			return this.__p.__vector_as_span<int>(14, 4);
		}

		// Token: 0x0600B0AC RID: 45228 RVA: 0x002C5AAC File Offset: 0x002C3CAC
		public int[] GetPropListArray()
		{
			return this.__p.__vector_as_array<int>(14) ?? Array.Empty<int>();
		}

		// Token: 0x170029FD RID: 10749
		// (get) Token: 0x0600B0AD RID: 45229 RVA: 0x002C5AC4 File Offset: 0x002C3CC4
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

		// Token: 0x170029FE RID: 10750
		// (get) Token: 0x0600B0AE RID: 45230 RVA: 0x002C5B04 File Offset: 0x002C3D04
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

		// Token: 0x0600B0AF RID: 45231 RVA: 0x002C5B3C File Offset: 0x002C3D3C
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0600B0B0 RID: 45232 RVA: 0x002C5B4C File Offset: 0x002C3D4C
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x170029FF RID: 10751
		// (get) Token: 0x0600B0B1 RID: 45233 RVA: 0x002C5B64 File Offset: 0x002C3D64
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

		// Token: 0x0600B0B2 RID: 45234 RVA: 0x002C5B9C File Offset: 0x002C3D9C
		public Span<byte> GetAttributesDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x0600B0B3 RID: 45235 RVA: 0x002C5BAC File Offset: 0x002C3DAC
		public byte[] GetAttributesDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x17002A00 RID: 10752
		// (get) Token: 0x0600B0B4 RID: 45236 RVA: 0x002C5BC4 File Offset: 0x002C3DC4
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

		// Token: 0x0600B0B5 RID: 45237 RVA: 0x002C5BFC File Offset: 0x002C3DFC
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x0600B0B6 RID: 45238 RVA: 0x002C5C0C File Offset: 0x002C3E0C
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x17002A01 RID: 10753
		// (get) Token: 0x0600B0B7 RID: 45239 RVA: 0x002C5C24 File Offset: 0x002C3E24
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

		// Token: 0x17002A02 RID: 10754
		// (get) Token: 0x0600B0B8 RID: 45240 RVA: 0x002C5C64 File Offset: 0x002C3E64
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

		// Token: 0x0600B0B9 RID: 45241 RVA: 0x002C5CA4 File Offset: 0x002C3EA4
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用PropListIter()或GetPropListBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] PropList()
		{
			PinballWeaponConfig pinballWeaponConfig = this;
			return pinballWeaponConfig.GetPropListArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600B0BA RID: 45242 RVA: 0x002C5CC8 File Offset: 0x002C3EC8
		[NullableContext(1)]
		public readonly IEnumerable<int> PropListIter()
		{
			PinballWeaponConfig.<PropListIter>d__42 <PropListIter>d__ = new PinballWeaponConfig.<PropListIter>d__42(-2);
			<PropListIter>d__.<>3__<>4__this = this;
			return <PropListIter>d__;
		}

		// Token: 0x04005007 RID: 20487
		private Table __p;
	}
}
