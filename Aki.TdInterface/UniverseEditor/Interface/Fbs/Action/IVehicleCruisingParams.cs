using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007CF5 RID: 31989
	public struct IVehicleCruisingParams : IFlatbufferObject
	{
		// Token: 0x1700EF65 RID: 61285
		// (get) Token: 0x06039B6C RID: 236396 RVA: 0x007C90A4 File Offset: 0x007C72A4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06039B6D RID: 236397 RVA: 0x007C90B1 File Offset: 0x007C72B1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06039B6E RID: 236398 RVA: 0x007C90B8 File Offset: 0x007C72B8
		public static IVehicleCruisingParams GetRootAsIVehicleCruisingParams(ByteBuffer _bb)
		{
			return IVehicleCruisingParams.GetRootAsIVehicleCruisingParams(_bb, default(IVehicleCruisingParams));
		}

		// Token: 0x06039B6F RID: 236399 RVA: 0x007C90D4 File Offset: 0x007C72D4
		public static IVehicleCruisingParams GetRootAsIVehicleCruisingParams(ByteBuffer _bb, IVehicleCruisingParams obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06039B70 RID: 236400 RVA: 0x007C90F1 File Offset: 0x007C72F1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06039B71 RID: 236401 RVA: 0x007C9100 File Offset: 0x007C7300
		public IVehicleCruisingParams __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700EF66 RID: 61286
		// (get) Token: 0x06039B72 RID: 236402 RVA: 0x007C9110 File Offset: 0x007C7310
		public float ForwardSpeed
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

		// Token: 0x1700EF67 RID: 61287
		// (get) Token: 0x06039B73 RID: 236403 RVA: 0x007C9150 File Offset: 0x007C7350
		public float ForwardAcceleration
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

		// Token: 0x1700EF68 RID: 61288
		// (get) Token: 0x06039B74 RID: 236404 RVA: 0x007C9190 File Offset: 0x007C7390
		public bool DisableSprint
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700EF69 RID: 61289
		// (get) Token: 0x06039B75 RID: 236405 RVA: 0x007C91D0 File Offset: 0x007C73D0
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06039B76 RID: 236406 RVA: 0x007C920D File Offset: 0x007C740D
		public static Offset<IVehicleCruisingParams> CreateIVehicleCruisingParams(FlatBufferBuilder builder, float ForwardSpeed = 0f, float ForwardAcceleration = 0f, bool DisableSprint = false, byte NullMask = 0)
		{
			builder.StartTable(4);
			IVehicleCruisingParams.AddForwardAcceleration(builder, ForwardAcceleration);
			IVehicleCruisingParams.AddForwardSpeed(builder, ForwardSpeed);
			IVehicleCruisingParams.AddNullMask(builder, NullMask);
			IVehicleCruisingParams.AddDisableSprint(builder, DisableSprint);
			return IVehicleCruisingParams.EndIVehicleCruisingParams(builder);
		}

		// Token: 0x06039B77 RID: 236407 RVA: 0x007C9239 File Offset: 0x007C7439
		public static void StartIVehicleCruisingParams(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06039B78 RID: 236408 RVA: 0x007C9242 File Offset: 0x007C7442
		public static void AddForwardSpeed(FlatBufferBuilder builder, float forwardSpeed)
		{
			builder.AddFloat(0, forwardSpeed, 0.0);
		}

		// Token: 0x06039B79 RID: 236409 RVA: 0x007C9255 File Offset: 0x007C7455
		public static void AddForwardAcceleration(FlatBufferBuilder builder, float forwardAcceleration)
		{
			builder.AddFloat(1, forwardAcceleration, 0.0);
		}

		// Token: 0x06039B7A RID: 236410 RVA: 0x007C9268 File Offset: 0x007C7468
		public static void AddDisableSprint(FlatBufferBuilder builder, bool disableSprint)
		{
			builder.AddBool(2, disableSprint, false);
		}

		// Token: 0x06039B7B RID: 236411 RVA: 0x007C9273 File Offset: 0x007C7473
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x06039B7C RID: 236412 RVA: 0x007C927E File Offset: 0x007C747E
		public static Offset<IVehicleCruisingParams> EndIVehicleCruisingParams(FlatBufferBuilder builder)
		{
			return new Offset<IVehicleCruisingParams>(builder.EndTable());
		}

		// Token: 0x06039B7D RID: 236413 RVA: 0x007C928C File Offset: 0x007C748C
		public IVehicleCruisingParamsT UnPack()
		{
			IVehicleCruisingParamsT vehicleCruisingParamsT = new IVehicleCruisingParamsT();
			this.UnPackTo(vehicleCruisingParamsT);
			return vehicleCruisingParamsT;
		}

		// Token: 0x06039B7E RID: 236414 RVA: 0x007C92A7 File Offset: 0x007C74A7
		public void UnPackTo(IVehicleCruisingParamsT _o)
		{
			_o.ForwardSpeed = this.ForwardSpeed;
			_o.ForwardAcceleration = this.ForwardAcceleration;
			_o.DisableSprint = this.DisableSprint;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06039B7F RID: 236415 RVA: 0x007C92DC File Offset: 0x007C74DC
		public static Offset<IVehicleCruisingParams> Pack(FlatBufferBuilder builder, IVehicleCruisingParamsT _o)
		{
			if (_o == null)
			{
				return default(Offset<IVehicleCruisingParams>);
			}
			return IVehicleCruisingParams.CreateIVehicleCruisingParams(builder, _o.ForwardSpeed, _o.ForwardAcceleration, _o.DisableSprint, _o.NullMask);
		}

		// Token: 0x04013410 RID: 78864
		private Table __p;
	}
}
