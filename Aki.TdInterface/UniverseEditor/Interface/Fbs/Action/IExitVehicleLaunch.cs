using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006DAC RID: 28076
	public struct IExitVehicleLaunch : IFlatbufferObject
	{
		// Token: 0x1700CDDF RID: 52703
		// (get) Token: 0x06030761 RID: 198497 RVA: 0x006955A6 File Offset: 0x006937A6
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06030762 RID: 198498 RVA: 0x006955B3 File Offset: 0x006937B3
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06030763 RID: 198499 RVA: 0x006955BC File Offset: 0x006937BC
		public static IExitVehicleLaunch GetRootAsIExitVehicleLaunch(ByteBuffer _bb)
		{
			return IExitVehicleLaunch.GetRootAsIExitVehicleLaunch(_bb, default(IExitVehicleLaunch));
		}

		// Token: 0x06030764 RID: 198500 RVA: 0x006955D8 File Offset: 0x006937D8
		public static IExitVehicleLaunch GetRootAsIExitVehicleLaunch(ByteBuffer _bb, IExitVehicleLaunch obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06030765 RID: 198501 RVA: 0x006955F5 File Offset: 0x006937F5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06030766 RID: 198502 RVA: 0x00695604 File Offset: 0x00693804
		public IExitVehicleLaunch __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CDE0 RID: 52704
		// (get) Token: 0x06030767 RID: 198503 RVA: 0x00695614 File Offset: 0x00693814
		public EExitVehicleType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EExitVehicleType.Launch;
				}
				return (EExitVehicleType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06030768 RID: 198504 RVA: 0x00695650 File Offset: 0x00693850
		public static Offset<IExitVehicleLaunch> CreateIExitVehicleLaunch(FlatBufferBuilder builder, EExitVehicleType Type = EExitVehicleType.Launch)
		{
			builder.StartTable(1);
			IExitVehicleLaunch.AddType(builder, Type);
			return IExitVehicleLaunch.EndIExitVehicleLaunch(builder);
		}

		// Token: 0x06030769 RID: 198505 RVA: 0x00695666 File Offset: 0x00693866
		public static void StartIExitVehicleLaunch(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0603076A RID: 198506 RVA: 0x0069566F File Offset: 0x0069386F
		public static void AddType(FlatBufferBuilder builder, EExitVehicleType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0603076B RID: 198507 RVA: 0x0069567A File Offset: 0x0069387A
		public static Offset<IExitVehicleLaunch> EndIExitVehicleLaunch(FlatBufferBuilder builder)
		{
			return new Offset<IExitVehicleLaunch>(builder.EndTable());
		}

		// Token: 0x0603076C RID: 198508 RVA: 0x00695688 File Offset: 0x00693888
		public IExitVehicleLaunchT UnPack()
		{
			IExitVehicleLaunchT exitVehicleLaunchT = new IExitVehicleLaunchT();
			this.UnPackTo(exitVehicleLaunchT);
			return exitVehicleLaunchT;
		}

		// Token: 0x0603076D RID: 198509 RVA: 0x006956A3 File Offset: 0x006938A3
		public void UnPackTo(IExitVehicleLaunchT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0603076E RID: 198510 RVA: 0x006956B4 File Offset: 0x006938B4
		public static Offset<IExitVehicleLaunch> Pack(FlatBufferBuilder builder, IExitVehicleLaunchT _o)
		{
			if (_o == null)
			{
				return default(Offset<IExitVehicleLaunch>);
			}
			return IExitVehicleLaunch.CreateIExitVehicleLaunch(builder, _o.Type);
		}

		// Token: 0x04011C43 RID: 72771
		private Table __p;
	}
}
