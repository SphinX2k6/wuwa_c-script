using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020012CA RID: 4810
	public struct WeaponHandBook : IFlatbufferObject
	{
		// Token: 0x17004148 RID: 16712
		// (get) Token: 0x0600F541 RID: 62785 RVA: 0x0036D434 File Offset: 0x0036B634
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600F542 RID: 62786 RVA: 0x0036D441 File Offset: 0x0036B641
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600F543 RID: 62787 RVA: 0x0036D448 File Offset: 0x0036B648
		public static WeaponHandBook GetRootAsWeaponHandBook(ByteBuffer _bb)
		{
			return WeaponHandBook.GetRootAsWeaponHandBook(_bb, default(WeaponHandBook));
		}

		// Token: 0x0600F544 RID: 62788 RVA: 0x0036D464 File Offset: 0x0036B664
		public static WeaponHandBook GetRootAsWeaponHandBook(ByteBuffer _bb, WeaponHandBook obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600F545 RID: 62789 RVA: 0x0036D481 File Offset: 0x0036B681
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600F546 RID: 62790 RVA: 0x0036D490 File Offset: 0x0036B690
		public WeaponHandBook __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17004149 RID: 16713
		// (get) Token: 0x0600F547 RID: 62791 RVA: 0x0036D4A0 File Offset: 0x0036B6A0
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

		// Token: 0x1700414A RID: 16714
		// (get) Token: 0x0600F548 RID: 62792 RVA: 0x0036D4DC File Offset: 0x0036B6DC
		public int Level
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

		// Token: 0x1700414B RID: 16715
		// (get) Token: 0x0600F549 RID: 62793 RVA: 0x0036D518 File Offset: 0x0036B718
		public int Breach
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

		// Token: 0x1700414C RID: 16716
		// (get) Token: 0x0600F54A RID: 62794 RVA: 0x0036D554 File Offset: 0x0036B754
		public int Resonance
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

		// Token: 0x04005922 RID: 22818
		private Table __p;
	}
}
