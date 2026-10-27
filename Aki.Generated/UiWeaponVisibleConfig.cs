using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001189 RID: 4489
	public struct UiWeaponVisibleConfig : IFlatbufferObject
	{
		// Token: 0x17003D78 RID: 15736
		// (get) Token: 0x0600E6D5 RID: 59093 RVA: 0x00340044 File Offset: 0x0033E244
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600E6D6 RID: 59094 RVA: 0x00340051 File Offset: 0x0033E251
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600E6D7 RID: 59095 RVA: 0x00340058 File Offset: 0x0033E258
		public static UiWeaponVisibleConfig GetRootAsUiWeaponVisibleConfig(ByteBuffer _bb)
		{
			return UiWeaponVisibleConfig.GetRootAsUiWeaponVisibleConfig(_bb, default(UiWeaponVisibleConfig));
		}

		// Token: 0x0600E6D8 RID: 59096 RVA: 0x00340074 File Offset: 0x0033E274
		public static UiWeaponVisibleConfig GetRootAsUiWeaponVisibleConfig(ByteBuffer _bb, UiWeaponVisibleConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600E6D9 RID: 59097 RVA: 0x00340091 File Offset: 0x0033E291
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600E6DA RID: 59098 RVA: 0x003400A0 File Offset: 0x0033E2A0
		public UiWeaponVisibleConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003D79 RID: 15737
		// (get) Token: 0x0600E6DB RID: 59099 RVA: 0x003400B0 File Offset: 0x0033E2B0
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

		// Token: 0x0600E6DC RID: 59100 RVA: 0x003400EC File Offset: 0x0033E2EC
		public bool VisibleList(int j)
		{
			int num = this.__p.__offset(6);
			return num != 0 && this.__p.bb.Get(this.__p.__vector(num) + j) > 0;
		}

		// Token: 0x17003D7A RID: 15738
		// (get) Token: 0x0600E6DD RID: 59101 RVA: 0x0034012C File Offset: 0x0033E32C
		public int VisibleListLength
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600E6DE RID: 59102 RVA: 0x00340157 File Offset: 0x0033E357
		public Span<bool> GetVisibleListBytes()
		{
			return this.__p.__vector_as_span<bool>(6, 1);
		}

		// Token: 0x0600E6DF RID: 59103 RVA: 0x00340166 File Offset: 0x0033E366
		public bool[] GetVisibleListArray()
		{
			return this.__p.__vector_as_array<bool>(6) ?? Array.Empty<bool>();
		}

		// Token: 0x0600E6E0 RID: 59104 RVA: 0x00340180 File Offset: 0x0033E380
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用VisibleListIter()或GetVisibleListBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly bool[] VisibleList()
		{
			UiWeaponVisibleConfig uiWeaponVisibleConfig = this;
			return uiWeaponVisibleConfig.GetVisibleListArray() ?? Array.Empty<bool>();
		}

		// Token: 0x0600E6E1 RID: 59105 RVA: 0x003401A4 File Offset: 0x0033E3A4
		[NullableContext(1)]
		public readonly IEnumerable<bool> VisibleListIter()
		{
			UiWeaponVisibleConfig.<VisibleListIter>d__16 <VisibleListIter>d__ = new UiWeaponVisibleConfig.<VisibleListIter>d__16(-2);
			<VisibleListIter>d__.<>3__<>4__this = this;
			return <VisibleListIter>d__;
		}

		// Token: 0x040052D2 RID: 21202
		private Table __p;
	}
}
