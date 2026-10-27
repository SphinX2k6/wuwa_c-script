using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001056 RID: 4182
	public struct RolePropertyGrowth : IFlatbufferObject
	{
		// Token: 0x170032E5 RID: 13029
		// (get) Token: 0x0600C9BF RID: 51647 RVA: 0x002FD329 File Offset: 0x002FB529
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600C9C0 RID: 51648 RVA: 0x002FD336 File Offset: 0x002FB536
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600C9C1 RID: 51649 RVA: 0x002FD340 File Offset: 0x002FB540
		public static RolePropertyGrowth GetRootAsRolePropertyGrowth(ByteBuffer _bb)
		{
			return RolePropertyGrowth.GetRootAsRolePropertyGrowth(_bb, default(RolePropertyGrowth));
		}

		// Token: 0x0600C9C2 RID: 51650 RVA: 0x002FD35C File Offset: 0x002FB55C
		public static RolePropertyGrowth GetRootAsRolePropertyGrowth(ByteBuffer _bb, RolePropertyGrowth obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600C9C3 RID: 51651 RVA: 0x002FD379 File Offset: 0x002FB579
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600C9C4 RID: 51652 RVA: 0x002FD388 File Offset: 0x002FB588
		public RolePropertyGrowth __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170032E6 RID: 13030
		// (get) Token: 0x0600C9C5 RID: 51653 RVA: 0x002FD398 File Offset: 0x002FB598
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

		// Token: 0x170032E7 RID: 13031
		// (get) Token: 0x0600C9C6 RID: 51654 RVA: 0x002FD3D4 File Offset: 0x002FB5D4
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

		// Token: 0x170032E8 RID: 13032
		// (get) Token: 0x0600C9C7 RID: 51655 RVA: 0x002FD410 File Offset: 0x002FB610
		public int BreachLevel
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

		// Token: 0x170032E9 RID: 13033
		// (get) Token: 0x0600C9C8 RID: 51656 RVA: 0x002FD44C File Offset: 0x002FB64C
		public int LifeMaxRatio
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

		// Token: 0x170032EA RID: 13034
		// (get) Token: 0x0600C9C9 RID: 51657 RVA: 0x002FD48C File Offset: 0x002FB68C
		public int AtkRatio
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

		// Token: 0x170032EB RID: 13035
		// (get) Token: 0x0600C9CA RID: 51658 RVA: 0x002FD4CC File Offset: 0x002FB6CC
		public int DefRatio
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x04005157 RID: 20823
		private Table __p;
	}
}
