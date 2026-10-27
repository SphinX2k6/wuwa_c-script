using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200672F RID: 26415
	public struct IExitVehicleSeatStandUp : IFlatbufferObject
	{
		// Token: 0x1700C42C RID: 50220
		// (get) Token: 0x0602DF2D RID: 188205 RVA: 0x00647FD9 File Offset: 0x006461D9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602DF2E RID: 188206 RVA: 0x00647FE6 File Offset: 0x006461E6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602DF2F RID: 188207 RVA: 0x00647FF0 File Offset: 0x006461F0
		public static IExitVehicleSeatStandUp GetRootAsIExitVehicleSeatStandUp(ByteBuffer _bb)
		{
			return IExitVehicleSeatStandUp.GetRootAsIExitVehicleSeatStandUp(_bb, default(IExitVehicleSeatStandUp));
		}

		// Token: 0x0602DF30 RID: 188208 RVA: 0x0064800C File Offset: 0x0064620C
		public static IExitVehicleSeatStandUp GetRootAsIExitVehicleSeatStandUp(ByteBuffer _bb, IExitVehicleSeatStandUp obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602DF31 RID: 188209 RVA: 0x00648029 File Offset: 0x00646229
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602DF32 RID: 188210 RVA: 0x00648038 File Offset: 0x00646238
		public IExitVehicleSeatStandUp __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C42D RID: 50221
		// (get) Token: 0x0602DF33 RID: 188211 RVA: 0x00648048 File Offset: 0x00646248
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

		// Token: 0x0602DF34 RID: 188212 RVA: 0x00648084 File Offset: 0x00646284
		public static Offset<IExitVehicleSeatStandUp> CreateIExitVehicleSeatStandUp(FlatBufferBuilder builder, EExitVehicleType Type = EExitVehicleType.Launch)
		{
			builder.StartTable(1);
			IExitVehicleSeatStandUp.AddType(builder, Type);
			return IExitVehicleSeatStandUp.EndIExitVehicleSeatStandUp(builder);
		}

		// Token: 0x0602DF35 RID: 188213 RVA: 0x0064809A File Offset: 0x0064629A
		public static void StartIExitVehicleSeatStandUp(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602DF36 RID: 188214 RVA: 0x006480A3 File Offset: 0x006462A3
		public static void AddType(FlatBufferBuilder builder, EExitVehicleType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602DF37 RID: 188215 RVA: 0x006480AE File Offset: 0x006462AE
		public static Offset<IExitVehicleSeatStandUp> EndIExitVehicleSeatStandUp(FlatBufferBuilder builder)
		{
			return new Offset<IExitVehicleSeatStandUp>(builder.EndTable());
		}

		// Token: 0x0602DF38 RID: 188216 RVA: 0x006480BC File Offset: 0x006462BC
		public IExitVehicleSeatStandUpT UnPack()
		{
			IExitVehicleSeatStandUpT exitVehicleSeatStandUpT = new IExitVehicleSeatStandUpT();
			this.UnPackTo(exitVehicleSeatStandUpT);
			return exitVehicleSeatStandUpT;
		}

		// Token: 0x0602DF39 RID: 188217 RVA: 0x006480D7 File Offset: 0x006462D7
		public void UnPackTo(IExitVehicleSeatStandUpT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602DF3A RID: 188218 RVA: 0x006480E8 File Offset: 0x006462E8
		public static Offset<IExitVehicleSeatStandUp> Pack(FlatBufferBuilder builder, IExitVehicleSeatStandUpT _o)
		{
			if (_o == null)
			{
				return default(Offset<IExitVehicleSeatStandUp>);
			}
			return IExitVehicleSeatStandUp.CreateIExitVehicleSeatStandUp(builder, _o.Type);
		}

		// Token: 0x04010E13 RID: 69139
		private Table __p;
	}
}
