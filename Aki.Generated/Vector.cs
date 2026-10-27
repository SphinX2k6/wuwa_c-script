using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020011EA RID: 4586
	public struct Vector : IFlatbufferObject
	{
		// Token: 0x17003F53 RID: 16211
		// (get) Token: 0x0600EBDB RID: 60379 RVA: 0x0034B1BC File Offset: 0x003493BC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600EBDC RID: 60380 RVA: 0x0034B1C9 File Offset: 0x003493C9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600EBDD RID: 60381 RVA: 0x0034B1D0 File Offset: 0x003493D0
		public static Vector GetRootAsVector(ByteBuffer _bb)
		{
			return Vector.GetRootAsVector(_bb, default(Vector));
		}

		// Token: 0x0600EBDE RID: 60382 RVA: 0x0034B1EC File Offset: 0x003493EC
		public static Vector GetRootAsVector(ByteBuffer _bb, Vector obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600EBDF RID: 60383 RVA: 0x0034B209 File Offset: 0x00349409
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600EBE0 RID: 60384 RVA: 0x0034B218 File Offset: 0x00349418
		public Vector __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003F54 RID: 16212
		// (get) Token: 0x0600EBE1 RID: 60385 RVA: 0x0034B228 File Offset: 0x00349428
		public float X
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17003F55 RID: 16213
		// (get) Token: 0x0600EBE2 RID: 60386 RVA: 0x0034B268 File Offset: 0x00349468
		public float Y
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17003F56 RID: 16214
		// (get) Token: 0x0600EBE3 RID: 60387 RVA: 0x0034B2A8 File Offset: 0x003494A8
		public float Z
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x04005363 RID: 21347
		private Table __p;
	}
}
