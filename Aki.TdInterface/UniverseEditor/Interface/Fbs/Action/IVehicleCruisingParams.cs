using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020074FF RID: 29951
	public struct IVehicleCruisingParams : IFlatbufferObject
	{
		// Token: 0x1700E33B RID: 58171
		// (get) Token: 0x06036757 RID: 223063 RVA: 0x00765E54 File Offset: 0x00764054
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06036758 RID: 223064 RVA: 0x00765E61 File Offset: 0x00764061
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06036759 RID: 223065 RVA: 0x00765E68 File Offset: 0x00764068
		public static IVehicleCruisingParams GetRootAsIVehicleCruisingParams(ByteBuffer _bb)
		{
			return IVehicleCruisingParams.GetRootAsIVehicleCruisingParams(_bb, default(IVehicleCruisingParams));
		}

		// Token: 0x0603675A RID: 223066 RVA: 0x00765E84 File Offset: 0x00764084
		public static IVehicleCruisingParams GetRootAsIVehicleCruisingParams(ByteBuffer _bb, IVehicleCruisingParams obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603675B RID: 223067 RVA: 0x00765EA1 File Offset: 0x007640A1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603675C RID: 223068 RVA: 0x00765EB0 File Offset: 0x007640B0
		public IVehicleCruisingParams __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E33C RID: 58172
		// (get) Token: 0x0603675D RID: 223069 RVA: 0x00765EC0 File Offset: 0x007640C0
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

		// Token: 0x1700E33D RID: 58173
		// (get) Token: 0x0603675E RID: 223070 RVA: 0x00765F00 File Offset: 0x00764100
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

		// Token: 0x1700E33E RID: 58174
		// (get) Token: 0x0603675F RID: 223071 RVA: 0x00765F40 File Offset: 0x00764140
		public bool DisableSprint
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700E33F RID: 58175
		// (get) Token: 0x06036760 RID: 223072 RVA: 0x00765F80 File Offset: 0x00764180
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

		// Token: 0x06036761 RID: 223073 RVA: 0x00765FBD File Offset: 0x007641BD
		public static Offset<IVehicleCruisingParams> CreateIVehicleCruisingParams(FlatBufferBuilder builder, float ForwardSpeed = 0f, float ForwardAcceleration = 0f, bool DisableSprint = false, byte NullMask = 0)
		{
			builder.StartTable(4);
			IVehicleCruisingParams.AddForwardAcceleration(builder, ForwardAcceleration);
			IVehicleCruisingParams.AddForwardSpeed(builder, ForwardSpeed);
			IVehicleCruisingParams.AddNullMask(builder, NullMask);
			IVehicleCruisingParams.AddDisableSprint(builder, DisableSprint);
			return IVehicleCruisingParams.EndIVehicleCruisingParams(builder);
		}

		// Token: 0x06036762 RID: 223074 RVA: 0x00765FE9 File Offset: 0x007641E9
		public static void StartIVehicleCruisingParams(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06036763 RID: 223075 RVA: 0x00765FF2 File Offset: 0x007641F2
		public static void AddForwardSpeed(FlatBufferBuilder builder, float forwardSpeed)
		{
			builder.AddFloat(0, forwardSpeed, 0.0);
		}

		// Token: 0x06036764 RID: 223076 RVA: 0x00766005 File Offset: 0x00764205
		public static void AddForwardAcceleration(FlatBufferBuilder builder, float forwardAcceleration)
		{
			builder.AddFloat(1, forwardAcceleration, 0.0);
		}

		// Token: 0x06036765 RID: 223077 RVA: 0x00766018 File Offset: 0x00764218
		public static void AddDisableSprint(FlatBufferBuilder builder, bool disableSprint)
		{
			builder.AddBool(2, disableSprint, false);
		}

		// Token: 0x06036766 RID: 223078 RVA: 0x00766023 File Offset: 0x00764223
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x06036767 RID: 223079 RVA: 0x0076602E File Offset: 0x0076422E
		public static Offset<IVehicleCruisingParams> EndIVehicleCruisingParams(FlatBufferBuilder builder)
		{
			return new Offset<IVehicleCruisingParams>(builder.EndTable());
		}

		// Token: 0x06036768 RID: 223080 RVA: 0x0076603C File Offset: 0x0076423C
		public IVehicleCruisingParamsT UnPack()
		{
			IVehicleCruisingParamsT vehicleCruisingParamsT = new IVehicleCruisingParamsT();
			this.UnPackTo(vehicleCruisingParamsT);
			return vehicleCruisingParamsT;
		}

		// Token: 0x06036769 RID: 223081 RVA: 0x00766057 File Offset: 0x00764257
		public void UnPackTo(IVehicleCruisingParamsT _o)
		{
			_o.ForwardSpeed = this.ForwardSpeed;
			_o.ForwardAcceleration = this.ForwardAcceleration;
			_o.DisableSprint = this.DisableSprint;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0603676A RID: 223082 RVA: 0x0076608C File Offset: 0x0076428C
		public static Offset<IVehicleCruisingParams> Pack(FlatBufferBuilder builder, IVehicleCruisingParamsT _o)
		{
			if (_o == null)
			{
				return default(Offset<IVehicleCruisingParams>);
			}
			return IVehicleCruisingParams.CreateIVehicleCruisingParams(builder, _o.ForwardSpeed, _o.ForwardAcceleration, _o.DisableSprint, _o.NullMask);
		}

		// Token: 0x040123DF RID: 74719
		private Table __p;
	}
}
