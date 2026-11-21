using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020012C9 RID: 4809
	public struct WeaponExpItem : IFlatbufferObject
	{
		// Token: 0x17004144 RID: 16708
		// (get) Token: 0x0600F538 RID: 62776 RVA: 0x0036D314 File Offset: 0x0036B514
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600F539 RID: 62777 RVA: 0x0036D321 File Offset: 0x0036B521
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600F53A RID: 62778 RVA: 0x0036D328 File Offset: 0x0036B528
		public static WeaponExpItem GetRootAsWeaponExpItem(ByteBuffer _bb)
		{
			return WeaponExpItem.GetRootAsWeaponExpItem(_bb, default(WeaponExpItem));
		}

		// Token: 0x0600F53B RID: 62779 RVA: 0x0036D344 File Offset: 0x0036B544
		public static WeaponExpItem GetRootAsWeaponExpItem(ByteBuffer _bb, WeaponExpItem obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600F53C RID: 62780 RVA: 0x0036D361 File Offset: 0x0036B561
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600F53D RID: 62781 RVA: 0x0036D370 File Offset: 0x0036B570
		public WeaponExpItem __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17004145 RID: 16709
		// (get) Token: 0x0600F53E RID: 62782 RVA: 0x0036D380 File Offset: 0x0036B580
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

		// Token: 0x17004146 RID: 16710
		// (get) Token: 0x0600F53F RID: 62783 RVA: 0x0036D3BC File Offset: 0x0036B5BC
		public int Cost
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

		// Token: 0x17004147 RID: 16711
		// (get) Token: 0x0600F540 RID: 62784 RVA: 0x0036D3F8 File Offset: 0x0036B5F8
		public int BasicExp
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

		// Token: 0x04005921 RID: 22817
		private Table __p;
	}
}
