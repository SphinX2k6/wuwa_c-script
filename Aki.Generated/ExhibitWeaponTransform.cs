using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C48 RID: 3144
	public struct ExhibitWeaponTransform : IFlatbufferObject
	{
		// Token: 0x17000F9A RID: 3994
		// (get) Token: 0x06006ADE RID: 27358 RVA: 0x00226E15 File Offset: 0x00225015
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06006ADF RID: 27359 RVA: 0x00226E22 File Offset: 0x00225022
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06006AE0 RID: 27360 RVA: 0x00226E2C File Offset: 0x0022502C
		public static ExhibitWeaponTransform GetRootAsExhibitWeaponTransform(ByteBuffer _bb)
		{
			return ExhibitWeaponTransform.GetRootAsExhibitWeaponTransform(_bb, default(ExhibitWeaponTransform));
		}

		// Token: 0x06006AE1 RID: 27361 RVA: 0x00226E48 File Offset: 0x00225048
		public static ExhibitWeaponTransform GetRootAsExhibitWeaponTransform(ByteBuffer _bb, ExhibitWeaponTransform obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06006AE2 RID: 27362 RVA: 0x00226E65 File Offset: 0x00225065
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06006AE3 RID: 27363 RVA: 0x00226E74 File Offset: 0x00225074
		public ExhibitWeaponTransform __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000F9B RID: 3995
		// (get) Token: 0x06006AE4 RID: 27364 RVA: 0x00226E84 File Offset: 0x00225084
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

		// Token: 0x17000F9C RID: 3996
		// (get) Token: 0x06006AE5 RID: 27365 RVA: 0x00226EC0 File Offset: 0x002250C0
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

		// Token: 0x17000F9D RID: 3997
		// (get) Token: 0x06006AE6 RID: 27366 RVA: 0x00226F20 File Offset: 0x00225120
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

		// Token: 0x17000F9E RID: 3998
		// (get) Token: 0x06006AE7 RID: 27367 RVA: 0x00226F80 File Offset: 0x00225180
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

		// Token: 0x17000F9F RID: 3999
		// (get) Token: 0x06006AE8 RID: 27368 RVA: 0x00226FC4 File Offset: 0x002251C4
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

		// Token: 0x17000FA0 RID: 4000
		// (get) Token: 0x06006AE9 RID: 27369 RVA: 0x00227004 File Offset: 0x00225204
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

		// Token: 0x17000FA1 RID: 4001
		// (get) Token: 0x06006AEA RID: 27370 RVA: 0x00227064 File Offset: 0x00225264
		public bool ShowScabbard
		{
			get
			{
				int num = this.__p.__offset(16);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17000FA2 RID: 4002
		// (get) Token: 0x06006AEB RID: 27371 RVA: 0x002270A4 File Offset: 0x002252A4
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

		// Token: 0x17000FA3 RID: 4003
		// (get) Token: 0x06006AEC RID: 27372 RVA: 0x00227104 File Offset: 0x00225304
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

		// Token: 0x04004C8D RID: 19597
		private Table __p;
	}
}
