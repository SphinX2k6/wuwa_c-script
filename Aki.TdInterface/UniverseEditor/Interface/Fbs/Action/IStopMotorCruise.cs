using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020071D8 RID: 29144
	public struct IStopMotorCruise : IFlatbufferObject
	{
		// Token: 0x1700D87F RID: 55423
		// (get) Token: 0x06033B1F RID: 211743 RVA: 0x006F5DA6 File Offset: 0x006F3FA6
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06033B20 RID: 211744 RVA: 0x006F5DB3 File Offset: 0x006F3FB3
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06033B21 RID: 211745 RVA: 0x006F5DBC File Offset: 0x006F3FBC
		public static IStopMotorCruise GetRootAsIStopMotorCruise(ByteBuffer _bb)
		{
			return IStopMotorCruise.GetRootAsIStopMotorCruise(_bb, default(IStopMotorCruise));
		}

		// Token: 0x06033B22 RID: 211746 RVA: 0x006F5DD8 File Offset: 0x006F3FD8
		public static IStopMotorCruise GetRootAsIStopMotorCruise(ByteBuffer _bb, IStopMotorCruise obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06033B23 RID: 211747 RVA: 0x006F5DF5 File Offset: 0x006F3FF5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06033B24 RID: 211748 RVA: 0x006F5E04 File Offset: 0x006F4004
		public IStopMotorCruise __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x06033B25 RID: 211749 RVA: 0x006F5E14 File Offset: 0x006F4014
		public static void StartIStopMotorCruise(FlatBufferBuilder builder)
		{
			builder.StartTable(0);
		}

		// Token: 0x06033B26 RID: 211750 RVA: 0x006F5E1D File Offset: 0x006F401D
		public static Offset<IStopMotorCruise> EndIStopMotorCruise(FlatBufferBuilder builder)
		{
			return new Offset<IStopMotorCruise>(builder.EndTable());
		}

		// Token: 0x06033B27 RID: 211751 RVA: 0x006F5E2C File Offset: 0x006F402C
		public IStopMotorCruiseT UnPack()
		{
			IStopMotorCruiseT stopMotorCruiseT = new IStopMotorCruiseT();
			this.UnPackTo(stopMotorCruiseT);
			return stopMotorCruiseT;
		}

		// Token: 0x06033B28 RID: 211752 RVA: 0x006F5E47 File Offset: 0x006F4047
		public void UnPackTo(IStopMotorCruiseT _o)
		{
		}

		// Token: 0x06033B29 RID: 211753 RVA: 0x006F5E4C File Offset: 0x006F404C
		public static Offset<IStopMotorCruise> Pack(FlatBufferBuilder builder, IStopMotorCruiseT _o)
		{
			if (_o == null)
			{
				return default(Offset<IStopMotorCruise>);
			}
			IStopMotorCruise.StartIStopMotorCruise(builder);
			return IStopMotorCruise.EndIStopMotorCruise(builder);
		}

		// Token: 0x04011CBB RID: 72891
		private Table __p;
	}
}
