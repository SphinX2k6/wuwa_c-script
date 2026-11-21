using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006DAF RID: 28079
	public struct IExitVehicleSeatStandUp : IFlatbufferObject
	{
		// Token: 0x1700CDE2 RID: 52706
		// (get) Token: 0x06030773 RID: 198515 RVA: 0x0069571D File Offset: 0x0069391D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06030774 RID: 198516 RVA: 0x0069572A File Offset: 0x0069392A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06030775 RID: 198517 RVA: 0x00695734 File Offset: 0x00693934
		public static IExitVehicleSeatStandUp GetRootAsIExitVehicleSeatStandUp(ByteBuffer _bb)
		{
			return IExitVehicleSeatStandUp.GetRootAsIExitVehicleSeatStandUp(_bb, default(IExitVehicleSeatStandUp));
		}

		// Token: 0x06030776 RID: 198518 RVA: 0x00695750 File Offset: 0x00693950
		public static IExitVehicleSeatStandUp GetRootAsIExitVehicleSeatStandUp(ByteBuffer _bb, IExitVehicleSeatStandUp obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06030777 RID: 198519 RVA: 0x0069576D File Offset: 0x0069396D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06030778 RID: 198520 RVA: 0x0069577C File Offset: 0x0069397C
		public IExitVehicleSeatStandUp __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CDE3 RID: 52707
		// (get) Token: 0x06030779 RID: 198521 RVA: 0x0069578C File Offset: 0x0069398C
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

		// Token: 0x0603077A RID: 198522 RVA: 0x006957C8 File Offset: 0x006939C8
		public static Offset<IExitVehicleSeatStandUp> CreateIExitVehicleSeatStandUp(FlatBufferBuilder builder, EExitVehicleType Type = EExitVehicleType.Launch)
		{
			builder.StartTable(1);
			IExitVehicleSeatStandUp.AddType(builder, Type);
			return IExitVehicleSeatStandUp.EndIExitVehicleSeatStandUp(builder);
		}

		// Token: 0x0603077B RID: 198523 RVA: 0x006957DE File Offset: 0x006939DE
		public static void StartIExitVehicleSeatStandUp(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0603077C RID: 198524 RVA: 0x006957E7 File Offset: 0x006939E7
		public static void AddType(FlatBufferBuilder builder, EExitVehicleType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0603077D RID: 198525 RVA: 0x006957F2 File Offset: 0x006939F2
		public static Offset<IExitVehicleSeatStandUp> EndIExitVehicleSeatStandUp(FlatBufferBuilder builder)
		{
			return new Offset<IExitVehicleSeatStandUp>(builder.EndTable());
		}

		// Token: 0x0603077E RID: 198526 RVA: 0x00695800 File Offset: 0x00693A00
		public IExitVehicleSeatStandUpT UnPack()
		{
			IExitVehicleSeatStandUpT exitVehicleSeatStandUpT = new IExitVehicleSeatStandUpT();
			this.UnPackTo(exitVehicleSeatStandUpT);
			return exitVehicleSeatStandUpT;
		}

		// Token: 0x0603077F RID: 198527 RVA: 0x0069581B File Offset: 0x00693A1B
		public void UnPackTo(IExitVehicleSeatStandUpT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06030780 RID: 198528 RVA: 0x0069582C File Offset: 0x00693A2C
		public static Offset<IExitVehicleSeatStandUp> Pack(FlatBufferBuilder builder, IExitVehicleSeatStandUpT _o)
		{
			if (_o == null)
			{
				return default(Offset<IExitVehicleSeatStandUp>);
			}
			return IExitVehicleSeatStandUp.CreateIExitVehicleSeatStandUp(builder, _o.Type);
		}

		// Token: 0x04011C45 RID: 72773
		private Table __p;
	}
}
