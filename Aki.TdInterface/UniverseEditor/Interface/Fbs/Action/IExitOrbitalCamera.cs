using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006729 RID: 26409
	public struct IExitOrbitalCamera : IFlatbufferObject
	{
		// Token: 0x1700C428 RID: 50216
		// (get) Token: 0x0602DF0E RID: 188174 RVA: 0x00647D7A File Offset: 0x00645F7A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602DF0F RID: 188175 RVA: 0x00647D87 File Offset: 0x00645F87
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602DF10 RID: 188176 RVA: 0x00647D90 File Offset: 0x00645F90
		public static IExitOrbitalCamera GetRootAsIExitOrbitalCamera(ByteBuffer _bb)
		{
			return IExitOrbitalCamera.GetRootAsIExitOrbitalCamera(_bb, default(IExitOrbitalCamera));
		}

		// Token: 0x0602DF11 RID: 188177 RVA: 0x00647DAC File Offset: 0x00645FAC
		public static IExitOrbitalCamera GetRootAsIExitOrbitalCamera(ByteBuffer _bb, IExitOrbitalCamera obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602DF12 RID: 188178 RVA: 0x00647DC9 File Offset: 0x00645FC9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602DF13 RID: 188179 RVA: 0x00647DD8 File Offset: 0x00645FD8
		public IExitOrbitalCamera __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x0602DF14 RID: 188180 RVA: 0x00647DE8 File Offset: 0x00645FE8
		public static void StartIExitOrbitalCamera(FlatBufferBuilder builder)
		{
			builder.StartTable(0);
		}

		// Token: 0x0602DF15 RID: 188181 RVA: 0x00647DF1 File Offset: 0x00645FF1
		public static Offset<IExitOrbitalCamera> EndIExitOrbitalCamera(FlatBufferBuilder builder)
		{
			return new Offset<IExitOrbitalCamera>(builder.EndTable());
		}

		// Token: 0x0602DF16 RID: 188182 RVA: 0x00647E00 File Offset: 0x00646000
		public IExitOrbitalCameraT UnPack()
		{
			IExitOrbitalCameraT exitOrbitalCameraT = new IExitOrbitalCameraT();
			this.UnPackTo(exitOrbitalCameraT);
			return exitOrbitalCameraT;
		}

		// Token: 0x0602DF17 RID: 188183 RVA: 0x00647E1B File Offset: 0x0064601B
		public void UnPackTo(IExitOrbitalCameraT _o)
		{
		}

		// Token: 0x0602DF18 RID: 188184 RVA: 0x00647E20 File Offset: 0x00646020
		public static Offset<IExitOrbitalCamera> Pack(FlatBufferBuilder builder, IExitOrbitalCameraT _o)
		{
			if (_o == null)
			{
				return default(Offset<IExitOrbitalCamera>);
			}
			IExitOrbitalCamera.StartIExitOrbitalCamera(builder);
			return IExitOrbitalCamera.EndIExitOrbitalCamera(builder);
		}

		// Token: 0x04010E10 RID: 69136
		private Table __p;
	}
}
