using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200128C RID: 4748
	public struct TrapDefenseBaseConfig : IFlatbufferObject
	{
		// Token: 0x17003F26 RID: 16166
		// (get) Token: 0x0600EFDC RID: 61404 RVA: 0x0036132D File Offset: 0x0035F52D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600EFDD RID: 61405 RVA: 0x0036133A File Offset: 0x0035F53A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600EFDE RID: 61406 RVA: 0x00361344 File Offset: 0x0035F544
		public static TrapDefenseBaseConfig GetRootAsTrapDefenseBaseConfig(ByteBuffer _bb)
		{
			return TrapDefenseBaseConfig.GetRootAsTrapDefenseBaseConfig(_bb, default(TrapDefenseBaseConfig));
		}

		// Token: 0x0600EFDF RID: 61407 RVA: 0x00361360 File Offset: 0x0035F560
		public static TrapDefenseBaseConfig GetRootAsTrapDefenseBaseConfig(ByteBuffer _bb, TrapDefenseBaseConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600EFE0 RID: 61408 RVA: 0x0036137D File Offset: 0x0035F57D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600EFE1 RID: 61409 RVA: 0x0036138C File Offset: 0x0035F58C
		public TrapDefenseBaseConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003F27 RID: 16167
		// (get) Token: 0x0600EFE2 RID: 61410 RVA: 0x0036139C File Offset: 0x0035F59C
		public int ActivityId
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

		// Token: 0x17003F28 RID: 16168
		// (get) Token: 0x0600EFE3 RID: 61411 RVA: 0x003613D8 File Offset: 0x0035F5D8
		public int TechPointItem
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

		// Token: 0x17003F29 RID: 16169
		// (get) Token: 0x0600EFE4 RID: 61412 RVA: 0x00361414 File Offset: 0x0035F614
		public int ShopId
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

		// Token: 0x17003F2A RID: 16170
		// (get) Token: 0x0600EFE5 RID: 61413 RVA: 0x00361450 File Offset: 0x0035F650
		public int ShopItemId
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

		// Token: 0x040058DE RID: 22750
		private Table __p;
	}
}
