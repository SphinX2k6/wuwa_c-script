using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020012BF RID: 4799
	public struct UiWeaponVisibleConfig : IFlatbufferObject
	{
		// Token: 0x170040DC RID: 16604
		// (get) Token: 0x0600F443 RID: 62531 RVA: 0x0036AE3C File Offset: 0x0036903C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600F444 RID: 62532 RVA: 0x0036AE49 File Offset: 0x00369049
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600F445 RID: 62533 RVA: 0x0036AE50 File Offset: 0x00369050
		public static UiWeaponVisibleConfig GetRootAsUiWeaponVisibleConfig(ByteBuffer _bb)
		{
			return UiWeaponVisibleConfig.GetRootAsUiWeaponVisibleConfig(_bb, default(UiWeaponVisibleConfig));
		}

		// Token: 0x0600F446 RID: 62534 RVA: 0x0036AE6C File Offset: 0x0036906C
		public static UiWeaponVisibleConfig GetRootAsUiWeaponVisibleConfig(ByteBuffer _bb, UiWeaponVisibleConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600F447 RID: 62535 RVA: 0x0036AE89 File Offset: 0x00369089
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600F448 RID: 62536 RVA: 0x0036AE98 File Offset: 0x00369098
		public UiWeaponVisibleConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170040DD RID: 16605
		// (get) Token: 0x0600F449 RID: 62537 RVA: 0x0036AEA8 File Offset: 0x003690A8
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

		// Token: 0x0600F44A RID: 62538 RVA: 0x0036AEE4 File Offset: 0x003690E4
		public bool VisibleList(int j)
		{
			int num = this.__p.__offset(6);
			return num != 0 && this.__p.bb.Get(this.__p.__vector(num) + j) > 0;
		}

		// Token: 0x170040DE RID: 16606
		// (get) Token: 0x0600F44B RID: 62539 RVA: 0x0036AF24 File Offset: 0x00369124
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

		// Token: 0x0600F44C RID: 62540 RVA: 0x0036AF4F File Offset: 0x0036914F
		public Span<bool> GetVisibleListBytes()
		{
			return this.__p.__vector_as_span<bool>(6, 1);
		}

		// Token: 0x0600F44D RID: 62541 RVA: 0x0036AF5E File Offset: 0x0036915E
		public bool[] GetVisibleListArray()
		{
			return this.__p.__vector_as_array<bool>(6) ?? Array.Empty<bool>();
		}

		// Token: 0x0600F44E RID: 62542 RVA: 0x0036AF75 File Offset: 0x00369175
		[NullableContext(1)]
		public bool[] VisibleList()
		{
			return this.GetVisibleListArray();
		}

		// Token: 0x0600F44F RID: 62543 RVA: 0x0036AF7D File Offset: 0x0036917D
		[NullableContext(1)]
		public IEnumerable<bool> VisibleListIter()
		{
			UiWeaponVisibleConfig.<VisibleListIter>d__16 <VisibleListIter>d__ = new UiWeaponVisibleConfig.<VisibleListIter>d__16(-2);
			<VisibleListIter>d__.<>3__<>4__this = this;
			return <VisibleListIter>d__;
		}

		// Token: 0x04005915 RID: 22805
		private Table __p;
	}
}
