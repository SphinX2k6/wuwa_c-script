using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020012CB RID: 4811
	public struct WeaponHideConfig : IFlatbufferObject
	{
		// Token: 0x1700414D RID: 16717
		// (get) Token: 0x0600F54B RID: 62795 RVA: 0x0036D591 File Offset: 0x0036B791
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600F54C RID: 62796 RVA: 0x0036D59E File Offset: 0x0036B79E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600F54D RID: 62797 RVA: 0x0036D5A8 File Offset: 0x0036B7A8
		public static WeaponHideConfig GetRootAsWeaponHideConfig(ByteBuffer _bb)
		{
			return WeaponHideConfig.GetRootAsWeaponHideConfig(_bb, default(WeaponHideConfig));
		}

		// Token: 0x0600F54E RID: 62798 RVA: 0x0036D5C4 File Offset: 0x0036B7C4
		public static WeaponHideConfig GetRootAsWeaponHideConfig(ByteBuffer _bb, WeaponHideConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600F54F RID: 62799 RVA: 0x0036D5E1 File Offset: 0x0036B7E1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600F550 RID: 62800 RVA: 0x0036D5F0 File Offset: 0x0036B7F0
		public WeaponHideConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700414E RID: 16718
		// (get) Token: 0x0600F551 RID: 62801 RVA: 0x0036D600 File Offset: 0x0036B800
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

		// Token: 0x0600F552 RID: 62802 RVA: 0x0036D63C File Offset: 0x0036B83C
		public string HideWeaponTags(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700414F RID: 16719
		// (get) Token: 0x0600F553 RID: 62803 RVA: 0x0036D678 File Offset: 0x0036B878
		public int HideWeaponTagsLength
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

		// Token: 0x0600F554 RID: 62804 RVA: 0x0036D6A3 File Offset: 0x0036B8A3
		[NullableContext(1)]
		public string[] HideWeaponTags()
		{
			return this.HideWeaponTagsIter().ToArray<string>();
		}

		// Token: 0x0600F555 RID: 62805 RVA: 0x0036D6B0 File Offset: 0x0036B8B0
		[NullableContext(1)]
		public IEnumerable<string> HideWeaponTagsIter()
		{
			WeaponHideConfig.<HideWeaponTagsIter>d__14 <HideWeaponTagsIter>d__ = new WeaponHideConfig.<HideWeaponTagsIter>d__14(-2);
			<HideWeaponTagsIter>d__.<>3__<>4__this = this;
			return <HideWeaponTagsIter>d__;
		}

		// Token: 0x04005923 RID: 22819
		private Table __p;
	}
}
