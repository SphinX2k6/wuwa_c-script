using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200672C RID: 26412
	public struct IExitVehicleLaunch : IFlatbufferObject
	{
		// Token: 0x1700C429 RID: 50217
		// (get) Token: 0x0602DF1B RID: 188187 RVA: 0x00647E62 File Offset: 0x00646062
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602DF1C RID: 188188 RVA: 0x00647E6F File Offset: 0x0064606F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602DF1D RID: 188189 RVA: 0x00647E78 File Offset: 0x00646078
		public static IExitVehicleLaunch GetRootAsIExitVehicleLaunch(ByteBuffer _bb)
		{
			return IExitVehicleLaunch.GetRootAsIExitVehicleLaunch(_bb, default(IExitVehicleLaunch));
		}

		// Token: 0x0602DF1E RID: 188190 RVA: 0x00647E94 File Offset: 0x00646094
		public static IExitVehicleLaunch GetRootAsIExitVehicleLaunch(ByteBuffer _bb, IExitVehicleLaunch obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602DF1F RID: 188191 RVA: 0x00647EB1 File Offset: 0x006460B1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602DF20 RID: 188192 RVA: 0x00647EC0 File Offset: 0x006460C0
		public IExitVehicleLaunch __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C42A RID: 50218
		// (get) Token: 0x0602DF21 RID: 188193 RVA: 0x00647ED0 File Offset: 0x006460D0
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

		// Token: 0x0602DF22 RID: 188194 RVA: 0x00647F0C File Offset: 0x0064610C
		public static Offset<IExitVehicleLaunch> CreateIExitVehicleLaunch(FlatBufferBuilder builder, EExitVehicleType Type = EExitVehicleType.Launch)
		{
			builder.StartTable(1);
			IExitVehicleLaunch.AddType(builder, Type);
			return IExitVehicleLaunch.EndIExitVehicleLaunch(builder);
		}

		// Token: 0x0602DF23 RID: 188195 RVA: 0x00647F22 File Offset: 0x00646122
		public static void StartIExitVehicleLaunch(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602DF24 RID: 188196 RVA: 0x00647F2B File Offset: 0x0064612B
		public static void AddType(FlatBufferBuilder builder, EExitVehicleType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602DF25 RID: 188197 RVA: 0x00647F36 File Offset: 0x00646136
		public static Offset<IExitVehicleLaunch> EndIExitVehicleLaunch(FlatBufferBuilder builder)
		{
			return new Offset<IExitVehicleLaunch>(builder.EndTable());
		}

		// Token: 0x0602DF26 RID: 188198 RVA: 0x00647F44 File Offset: 0x00646144
		public IExitVehicleLaunchT UnPack()
		{
			IExitVehicleLaunchT exitVehicleLaunchT = new IExitVehicleLaunchT();
			this.UnPackTo(exitVehicleLaunchT);
			return exitVehicleLaunchT;
		}

		// Token: 0x0602DF27 RID: 188199 RVA: 0x00647F5F File Offset: 0x0064615F
		public void UnPackTo(IExitVehicleLaunchT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602DF28 RID: 188200 RVA: 0x00647F70 File Offset: 0x00646170
		public static Offset<IExitVehicleLaunch> Pack(FlatBufferBuilder builder, IExitVehicleLaunchT _o)
		{
			if (_o == null)
			{
				return default(Offset<IExitVehicleLaunch>);
			}
			return IExitVehicleLaunch.CreateIExitVehicleLaunch(builder, _o.Type);
		}

		// Token: 0x04010E11 RID: 69137
		private Table __p;
	}
}
