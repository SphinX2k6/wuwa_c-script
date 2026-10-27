using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F3C RID: 3900
	public struct PinballWeaponAttr : IFlatbufferObject
	{
		// Token: 0x170029F1 RID: 10737
		// (get) Token: 0x0600B094 RID: 45204 RVA: 0x002C5729 File Offset: 0x002C3929
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600B095 RID: 45205 RVA: 0x002C5736 File Offset: 0x002C3936
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600B096 RID: 45206 RVA: 0x002C5740 File Offset: 0x002C3940
		public static PinballWeaponAttr GetRootAsPinballWeaponAttr(ByteBuffer _bb)
		{
			return PinballWeaponAttr.GetRootAsPinballWeaponAttr(_bb, default(PinballWeaponAttr));
		}

		// Token: 0x0600B097 RID: 45207 RVA: 0x002C575C File Offset: 0x002C395C
		public static PinballWeaponAttr GetRootAsPinballWeaponAttr(ByteBuffer _bb, PinballWeaponAttr obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600B098 RID: 45208 RVA: 0x002C5779 File Offset: 0x002C3979
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600B099 RID: 45209 RVA: 0x002C5788 File Offset: 0x002C3988
		public PinballWeaponAttr __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170029F2 RID: 10738
		// (get) Token: 0x0600B09A RID: 45210 RVA: 0x002C5798 File Offset: 0x002C3998
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

		// Token: 0x170029F3 RID: 10739
		// (get) Token: 0x0600B09B RID: 45211 RVA: 0x002C57D4 File Offset: 0x002C39D4
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

		// Token: 0x170029F4 RID: 10740
		// (get) Token: 0x0600B09C RID: 45212 RVA: 0x002C5810 File Offset: 0x002C3A10
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

		// Token: 0x170029F5 RID: 10741
		// (get) Token: 0x0600B09D RID: 45213 RVA: 0x002C584C File Offset: 0x002C3A4C
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

		// Token: 0x04005006 RID: 20486
		private Table __p;
	}
}
