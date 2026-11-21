using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001011 RID: 4113
	public struct PinballEntityTest : IFlatbufferObject
	{
		// Token: 0x170029AA RID: 10666
		// (get) Token: 0x0600B501 RID: 46337 RVA: 0x002DE3A0 File Offset: 0x002DC5A0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600B502 RID: 46338 RVA: 0x002DE3AD File Offset: 0x002DC5AD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600B503 RID: 46339 RVA: 0x002DE3B4 File Offset: 0x002DC5B4
		public static PinballEntityTest GetRootAsPinballEntityTest(ByteBuffer _bb)
		{
			return PinballEntityTest.GetRootAsPinballEntityTest(_bb, default(PinballEntityTest));
		}

		// Token: 0x0600B504 RID: 46340 RVA: 0x002DE3D0 File Offset: 0x002DC5D0
		public static PinballEntityTest GetRootAsPinballEntityTest(ByteBuffer _bb, PinballEntityTest obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600B505 RID: 46341 RVA: 0x002DE3ED File Offset: 0x002DC5ED
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600B506 RID: 46342 RVA: 0x002DE3FC File Offset: 0x002DC5FC
		public PinballEntityTest __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170029AB RID: 10667
		// (get) Token: 0x0600B507 RID: 46343 RVA: 0x002DE40C File Offset: 0x002DC60C
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

		// Token: 0x170029AC RID: 10668
		// (get) Token: 0x0600B508 RID: 46344 RVA: 0x002DE448 File Offset: 0x002DC648
		public int MapId
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

		// Token: 0x170029AD RID: 10669
		// (get) Token: 0x0600B509 RID: 46345 RVA: 0x002DE484 File Offset: 0x002DC684
		public int KscEntityId
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

		// Token: 0x170029AE RID: 10670
		// (get) Token: 0x0600B50A RID: 46346 RVA: 0x002DE4C0 File Offset: 0x002DC6C0
		public Vector? Location
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return new Vector?(default(Vector).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x170029AF RID: 10671
		// (get) Token: 0x0600B50B RID: 46347 RVA: 0x002DE520 File Offset: 0x002DC720
		public Vector? Rotation
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return null;
				}
				return new Vector?(default(Vector).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x040055DA RID: 21978
		private Table __p;
	}
}
