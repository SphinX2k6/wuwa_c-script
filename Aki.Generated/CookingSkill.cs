using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C81 RID: 3201
	public struct CookingSkill : IFlatbufferObject
	{
		// Token: 0x170009A6 RID: 2470
		// (get) Token: 0x06005F36 RID: 24374 RVA: 0x0021F70F File Offset: 0x0021D90F
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06005F37 RID: 24375 RVA: 0x0021F71C File Offset: 0x0021D91C
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06005F38 RID: 24376 RVA: 0x0021F724 File Offset: 0x0021D924
		public static CookingSkill GetRootAsCookingSkill(ByteBuffer _bb)
		{
			return CookingSkill.GetRootAsCookingSkill(_bb, default(CookingSkill));
		}

		// Token: 0x06005F39 RID: 24377 RVA: 0x0021F740 File Offset: 0x0021D940
		public static CookingSkill GetRootAsCookingSkill(ByteBuffer _bb, CookingSkill obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06005F3A RID: 24378 RVA: 0x0021F75D File Offset: 0x0021D95D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06005F3B RID: 24379 RVA: 0x0021F76C File Offset: 0x0021D96C
		public CookingSkill __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170009A7 RID: 2471
		// (get) Token: 0x06005F3C RID: 24380 RVA: 0x0021F77C File Offset: 0x0021D97C
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

		// Token: 0x170009A8 RID: 2472
		// (get) Token: 0x06005F3D RID: 24381 RVA: 0x0021F7B8 File Offset: 0x0021D9B8
		public int ExtraItemId
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

		// Token: 0x170009A9 RID: 2473
		// (get) Token: 0x06005F3E RID: 24382 RVA: 0x0021F7F4 File Offset: 0x0021D9F4
		public int EffectiveProbability
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

		// Token: 0x170009AA RID: 2474
		// (get) Token: 0x06005F3F RID: 24383 RVA: 0x0021F830 File Offset: 0x0021DA30
		public int Typeld
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

		// Token: 0x170009AB RID: 2475
		// (get) Token: 0x06005F40 RID: 24384 RVA: 0x0021F870 File Offset: 0x0021DA70
		public int SkillDescription
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

		// Token: 0x040051A3 RID: 20899
		private Table __p;
	}
}
