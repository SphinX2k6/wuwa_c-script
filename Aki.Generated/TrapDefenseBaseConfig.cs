using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001156 RID: 4438
	public struct TrapDefenseBaseConfig : IFlatbufferObject
	{
		// Token: 0x17003BC2 RID: 15298
		// (get) Token: 0x0600E26E RID: 57966 RVA: 0x003361A1 File Offset: 0x003343A1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600E26F RID: 57967 RVA: 0x003361AE File Offset: 0x003343AE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600E270 RID: 57968 RVA: 0x003361B8 File Offset: 0x003343B8
		public static TrapDefenseBaseConfig GetRootAsTrapDefenseBaseConfig(ByteBuffer _bb)
		{
			return TrapDefenseBaseConfig.GetRootAsTrapDefenseBaseConfig(_bb, default(TrapDefenseBaseConfig));
		}

		// Token: 0x0600E271 RID: 57969 RVA: 0x003361D4 File Offset: 0x003343D4
		public static TrapDefenseBaseConfig GetRootAsTrapDefenseBaseConfig(ByteBuffer _bb, TrapDefenseBaseConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600E272 RID: 57970 RVA: 0x003361F1 File Offset: 0x003343F1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600E273 RID: 57971 RVA: 0x00336200 File Offset: 0x00334400
		public TrapDefenseBaseConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003BC3 RID: 15299
		// (get) Token: 0x0600E274 RID: 57972 RVA: 0x00336210 File Offset: 0x00334410
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

		// Token: 0x17003BC4 RID: 15300
		// (get) Token: 0x0600E275 RID: 57973 RVA: 0x0033624C File Offset: 0x0033444C
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

		// Token: 0x17003BC5 RID: 15301
		// (get) Token: 0x0600E276 RID: 57974 RVA: 0x00336288 File Offset: 0x00334488
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

		// Token: 0x17003BC6 RID: 15302
		// (get) Token: 0x0600E277 RID: 57975 RVA: 0x003362C4 File Offset: 0x003344C4
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

		// Token: 0x0400529B RID: 21147
		private Table __p;
	}
}
