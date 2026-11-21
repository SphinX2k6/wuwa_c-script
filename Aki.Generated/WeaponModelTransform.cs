using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020012CD RID: 4813
	public struct WeaponModelTransform : IFlatbufferObject
	{
		// Token: 0x17004155 RID: 16725
		// (get) Token: 0x0600F560 RID: 62816 RVA: 0x0036D825 File Offset: 0x0036BA25
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600F561 RID: 62817 RVA: 0x0036D832 File Offset: 0x0036BA32
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600F562 RID: 62818 RVA: 0x0036D83C File Offset: 0x0036BA3C
		public static WeaponModelTransform GetRootAsWeaponModelTransform(ByteBuffer _bb)
		{
			return WeaponModelTransform.GetRootAsWeaponModelTransform(_bb, default(WeaponModelTransform));
		}

		// Token: 0x0600F563 RID: 62819 RVA: 0x0036D858 File Offset: 0x0036BA58
		public static WeaponModelTransform GetRootAsWeaponModelTransform(ByteBuffer _bb, WeaponModelTransform obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600F564 RID: 62820 RVA: 0x0036D875 File Offset: 0x0036BA75
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600F565 RID: 62821 RVA: 0x0036D884 File Offset: 0x0036BA84
		public WeaponModelTransform __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17004156 RID: 16726
		// (get) Token: 0x0600F566 RID: 62822 RVA: 0x0036D894 File Offset: 0x0036BA94
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

		// Token: 0x17004157 RID: 16727
		// (get) Token: 0x0600F567 RID: 62823 RVA: 0x0036D8D0 File Offset: 0x0036BAD0
		public Vector? Location
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new Vector?(default(Vector).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17004158 RID: 16728
		// (get) Token: 0x0600F568 RID: 62824 RVA: 0x0036D930 File Offset: 0x0036BB30
		public Vector? Rotation
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return new Vector?(default(Vector).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17004159 RID: 16729
		// (get) Token: 0x0600F569 RID: 62825 RVA: 0x0036D990 File Offset: 0x0036BB90
		public float Size
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 1f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700415A RID: 16730
		// (get) Token: 0x0600F56A RID: 62826 RVA: 0x0036D9D4 File Offset: 0x0036BBD4
		public int RotateTime
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

		// Token: 0x1700415B RID: 16731
		// (get) Token: 0x0600F56B RID: 62827 RVA: 0x0036DA14 File Offset: 0x0036BC14
		public Vector? ScabbardOffset
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return null;
				}
				return new Vector?(default(Vector).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700415C RID: 16732
		// (get) Token: 0x0600F56C RID: 62828 RVA: 0x0036DA74 File Offset: 0x0036BC74
		public bool ShowScabbard
		{
			get
			{
				int num = this.__p.__offset(16);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700415D RID: 16733
		// (get) Token: 0x0600F56D RID: 62829 RVA: 0x0036DAB4 File Offset: 0x0036BCB4
		public Vector? AxisRotate
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return null;
				}
				return new Vector?(default(Vector).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700415E RID: 16734
		// (get) Token: 0x0600F56E RID: 62830 RVA: 0x0036DB14 File Offset: 0x0036BD14
		public Vector? ScabbardRotationOffset
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return null;
				}
				return new Vector?(default(Vector).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x04005925 RID: 22821
		private Table __p;
	}
}
