using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020079AD RID: 31149
	public struct IStopMotorCruise : IFlatbufferObject
	{
		// Token: 0x1700E478 RID: 58488
		// (get) Token: 0x06036E21 RID: 224801 RVA: 0x00757106 File Offset: 0x00755306
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06036E22 RID: 224802 RVA: 0x00757113 File Offset: 0x00755313
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06036E23 RID: 224803 RVA: 0x0075711C File Offset: 0x0075531C
		public static IStopMotorCruise GetRootAsIStopMotorCruise(ByteBuffer _bb)
		{
			return IStopMotorCruise.GetRootAsIStopMotorCruise(_bb, default(IStopMotorCruise));
		}

		// Token: 0x06036E24 RID: 224804 RVA: 0x00757138 File Offset: 0x00755338
		public static IStopMotorCruise GetRootAsIStopMotorCruise(ByteBuffer _bb, IStopMotorCruise obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06036E25 RID: 224805 RVA: 0x00757155 File Offset: 0x00755355
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06036E26 RID: 224806 RVA: 0x00757164 File Offset: 0x00755364
		public IStopMotorCruise __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x06036E27 RID: 224807 RVA: 0x00757174 File Offset: 0x00755374
		public static void StartIStopMotorCruise(FlatBufferBuilder builder)
		{
			builder.StartTable(0);
		}

		// Token: 0x06036E28 RID: 224808 RVA: 0x0075717D File Offset: 0x0075537D
		public static Offset<IStopMotorCruise> EndIStopMotorCruise(FlatBufferBuilder builder)
		{
			return new Offset<IStopMotorCruise>(builder.EndTable());
		}

		// Token: 0x06036E29 RID: 224809 RVA: 0x0075718C File Offset: 0x0075538C
		public IStopMotorCruiseT UnPack()
		{
			IStopMotorCruiseT stopMotorCruiseT = new IStopMotorCruiseT();
			this.UnPackTo(stopMotorCruiseT);
			return stopMotorCruiseT;
		}

		// Token: 0x06036E2A RID: 224810 RVA: 0x007571A7 File Offset: 0x007553A7
		public void UnPackTo(IStopMotorCruiseT _o)
		{
		}

		// Token: 0x06036E2B RID: 224811 RVA: 0x007571AC File Offset: 0x007553AC
		public static Offset<IStopMotorCruise> Pack(FlatBufferBuilder builder, IStopMotorCruiseT _o)
		{
			if (_o == null)
			{
				return default(Offset<IStopMotorCruise>);
			}
			IStopMotorCruise.StartIStopMotorCruise(builder);
			return IStopMotorCruise.EndIStopMotorCruise(builder);
		}

		// Token: 0x04012CBD RID: 76989
		private Table __p;
	}
}
