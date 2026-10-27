using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000EBA RID: 3770
	public struct PersonProgressCurve : IFlatbufferObject
	{
		// Token: 0x170024F9 RID: 9465
		// (get) Token: 0x0600A3CD RID: 41933 RVA: 0x002A813C File Offset: 0x002A633C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600A3CE RID: 41934 RVA: 0x002A8149 File Offset: 0x002A6349
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600A3CF RID: 41935 RVA: 0x002A8150 File Offset: 0x002A6350
		public static PersonProgressCurve GetRootAsPersonProgressCurve(ByteBuffer _bb)
		{
			return PersonProgressCurve.GetRootAsPersonProgressCurve(_bb, default(PersonProgressCurve));
		}

		// Token: 0x0600A3D0 RID: 41936 RVA: 0x002A816C File Offset: 0x002A636C
		public static PersonProgressCurve GetRootAsPersonProgressCurve(ByteBuffer _bb, PersonProgressCurve obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600A3D1 RID: 41937 RVA: 0x002A8189 File Offset: 0x002A6389
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600A3D2 RID: 41938 RVA: 0x002A8198 File Offset: 0x002A6398
		public PersonProgressCurve __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170024FA RID: 9466
		// (get) Token: 0x0600A3D3 RID: 41939 RVA: 0x002A81A8 File Offset: 0x002A63A8
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

		// Token: 0x170024FB RID: 9467
		// (get) Token: 0x0600A3D4 RID: 41940 RVA: 0x002A81E4 File Offset: 0x002A63E4
		public int Progress
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

		// Token: 0x170024FC RID: 9468
		// (get) Token: 0x0600A3D5 RID: 41941 RVA: 0x002A8220 File Offset: 0x002A6420
		public int DropId
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

		// Token: 0x170024FD RID: 9469
		// (get) Token: 0x0600A3D6 RID: 41942 RVA: 0x002A825C File Offset: 0x002A645C
		public int MotorPreviewId
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

		// Token: 0x170024FE RID: 9470
		// (get) Token: 0x0600A3D7 RID: 41943 RVA: 0x002A829C File Offset: 0x002A649C
		public bool ShowEffect
		{
			get
			{
				int num = this.__p.__offset(12);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x04004F70 RID: 20336
		private Table __p;
	}
}
