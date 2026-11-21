using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001021 RID: 4129
	public struct PinballWeaponAttr : IFlatbufferObject
	{
		// Token: 0x17002A57 RID: 10839
		// (get) Token: 0x0600B6B5 RID: 46773 RVA: 0x002E202A File Offset: 0x002E022A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600B6B6 RID: 46774 RVA: 0x002E2037 File Offset: 0x002E0237
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600B6B7 RID: 46775 RVA: 0x002E2040 File Offset: 0x002E0240
		public static PinballWeaponAttr GetRootAsPinballWeaponAttr(ByteBuffer _bb)
		{
			return PinballWeaponAttr.GetRootAsPinballWeaponAttr(_bb, default(PinballWeaponAttr));
		}

		// Token: 0x0600B6B8 RID: 46776 RVA: 0x002E205C File Offset: 0x002E025C
		public static PinballWeaponAttr GetRootAsPinballWeaponAttr(ByteBuffer _bb, PinballWeaponAttr obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600B6B9 RID: 46777 RVA: 0x002E2079 File Offset: 0x002E0279
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600B6BA RID: 46778 RVA: 0x002E2088 File Offset: 0x002E0288
		public PinballWeaponAttr __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002A58 RID: 10840
		// (get) Token: 0x0600B6BB RID: 46779 RVA: 0x002E2098 File Offset: 0x002E0298
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

		// Token: 0x17002A59 RID: 10841
		// (get) Token: 0x0600B6BC RID: 46780 RVA: 0x002E20D4 File Offset: 0x002E02D4
		public int ProperKey
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

		// Token: 0x17002A5A RID: 10842
		// (get) Token: 0x0600B6BD RID: 46781 RVA: 0x002E2110 File Offset: 0x002E0310
		public int KscAttrType
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

		// Token: 0x17002A5B RID: 10843
		// (get) Token: 0x0600B6BE RID: 46782 RVA: 0x002E214C File Offset: 0x002E034C
		public float ProperVal
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x040055EB RID: 21995
		private Table __p;
	}
}
