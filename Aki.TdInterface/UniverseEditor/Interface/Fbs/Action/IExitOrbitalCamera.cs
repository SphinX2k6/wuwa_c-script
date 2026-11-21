using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006DA9 RID: 28073
	public struct IExitOrbitalCamera : IFlatbufferObject
	{
		// Token: 0x1700CDDE RID: 52702
		// (get) Token: 0x06030754 RID: 198484 RVA: 0x006954BE File Offset: 0x006936BE
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06030755 RID: 198485 RVA: 0x006954CB File Offset: 0x006936CB
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06030756 RID: 198486 RVA: 0x006954D4 File Offset: 0x006936D4
		public static IExitOrbitalCamera GetRootAsIExitOrbitalCamera(ByteBuffer _bb)
		{
			return IExitOrbitalCamera.GetRootAsIExitOrbitalCamera(_bb, default(IExitOrbitalCamera));
		}

		// Token: 0x06030757 RID: 198487 RVA: 0x006954F0 File Offset: 0x006936F0
		public static IExitOrbitalCamera GetRootAsIExitOrbitalCamera(ByteBuffer _bb, IExitOrbitalCamera obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06030758 RID: 198488 RVA: 0x0069550D File Offset: 0x0069370D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06030759 RID: 198489 RVA: 0x0069551C File Offset: 0x0069371C
		public IExitOrbitalCamera __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x0603075A RID: 198490 RVA: 0x0069552C File Offset: 0x0069372C
		public static void StartIExitOrbitalCamera(FlatBufferBuilder builder)
		{
			builder.StartTable(0);
		}

		// Token: 0x0603075B RID: 198491 RVA: 0x00695535 File Offset: 0x00693735
		public static Offset<IExitOrbitalCamera> EndIExitOrbitalCamera(FlatBufferBuilder builder)
		{
			return new Offset<IExitOrbitalCamera>(builder.EndTable());
		}

		// Token: 0x0603075C RID: 198492 RVA: 0x00695544 File Offset: 0x00693744
		public IExitOrbitalCameraT UnPack()
		{
			IExitOrbitalCameraT exitOrbitalCameraT = new IExitOrbitalCameraT();
			this.UnPackTo(exitOrbitalCameraT);
			return exitOrbitalCameraT;
		}

		// Token: 0x0603075D RID: 198493 RVA: 0x0069555F File Offset: 0x0069375F
		public void UnPackTo(IExitOrbitalCameraT _o)
		{
		}

		// Token: 0x0603075E RID: 198494 RVA: 0x00695564 File Offset: 0x00693764
		public static Offset<IExitOrbitalCamera> Pack(FlatBufferBuilder builder, IExitOrbitalCameraT _o)
		{
			if (_o == null)
			{
				return default(Offset<IExitOrbitalCamera>);
			}
			IExitOrbitalCamera.StartIExitOrbitalCamera(builder);
			return IExitOrbitalCamera.EndIExitOrbitalCamera(builder);
		}

		// Token: 0x04011C42 RID: 72770
		private Table __p;
	}
}
