using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001197 RID: 4503
	public struct WeaponModelTransform : IFlatbufferObject
	{
		// Token: 0x17003DF1 RID: 15857
		// (get) Token: 0x0600E7F2 RID: 59378 RVA: 0x00342AC9 File Offset: 0x00340CC9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600E7F3 RID: 59379 RVA: 0x00342AD6 File Offset: 0x00340CD6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600E7F4 RID: 59380 RVA: 0x00342AE0 File Offset: 0x00340CE0
		public static WeaponModelTransform GetRootAsWeaponModelTransform(ByteBuffer _bb)
		{
			return WeaponModelTransform.GetRootAsWeaponModelTransform(_bb, default(WeaponModelTransform));
		}

		// Token: 0x0600E7F5 RID: 59381 RVA: 0x00342AFC File Offset: 0x00340CFC
		public static WeaponModelTransform GetRootAsWeaponModelTransform(ByteBuffer _bb, WeaponModelTransform obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600E7F6 RID: 59382 RVA: 0x00342B19 File Offset: 0x00340D19
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600E7F7 RID: 59383 RVA: 0x00342B28 File Offset: 0x00340D28
		public WeaponModelTransform __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003DF2 RID: 15858
		// (get) Token: 0x0600E7F8 RID: 59384 RVA: 0x00342B38 File Offset: 0x00340D38
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

		// Token: 0x17003DF3 RID: 15859
		// (get) Token: 0x0600E7F9 RID: 59385 RVA: 0x00342B74 File Offset: 0x00340D74
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

		// Token: 0x17003DF4 RID: 15860
		// (get) Token: 0x0600E7FA RID: 59386 RVA: 0x00342BD4 File Offset: 0x00340DD4
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

		// Token: 0x17003DF5 RID: 15861
		// (get) Token: 0x0600E7FB RID: 59387 RVA: 0x00342C34 File Offset: 0x00340E34
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

		// Token: 0x17003DF6 RID: 15862
		// (get) Token: 0x0600E7FC RID: 59388 RVA: 0x00342C78 File Offset: 0x00340E78
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

		// Token: 0x17003DF7 RID: 15863
		// (get) Token: 0x0600E7FD RID: 59389 RVA: 0x00342CB8 File Offset: 0x00340EB8
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

		// Token: 0x17003DF8 RID: 15864
		// (get) Token: 0x0600E7FE RID: 59390 RVA: 0x00342D18 File Offset: 0x00340F18
		public bool ShowScabbard
		{
			get
			{
				int num = this.__p.__offset(16);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17003DF9 RID: 15865
		// (get) Token: 0x0600E7FF RID: 59391 RVA: 0x00342D58 File Offset: 0x00340F58
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

		// Token: 0x17003DFA RID: 15866
		// (get) Token: 0x0600E800 RID: 59392 RVA: 0x00342DB8 File Offset: 0x00340FB8
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

		// Token: 0x040052E2 RID: 21218
		private Table __p;
	}
}
