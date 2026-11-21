using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200799E RID: 31134
	public struct IStopCameraLookAt : IFlatbufferObject
	{
		// Token: 0x1700E46A RID: 58474
		// (get) Token: 0x06036DCE RID: 224718 RVA: 0x007569A8 File Offset: 0x00754BA8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06036DCF RID: 224719 RVA: 0x007569B5 File Offset: 0x00754BB5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06036DD0 RID: 224720 RVA: 0x007569BC File Offset: 0x00754BBC
		public static IStopCameraLookAt GetRootAsIStopCameraLookAt(ByteBuffer _bb)
		{
			return IStopCameraLookAt.GetRootAsIStopCameraLookAt(_bb, default(IStopCameraLookAt));
		}

		// Token: 0x06036DD1 RID: 224721 RVA: 0x007569D8 File Offset: 0x00754BD8
		public static IStopCameraLookAt GetRootAsIStopCameraLookAt(ByteBuffer _bb, IStopCameraLookAt obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06036DD2 RID: 224722 RVA: 0x007569F5 File Offset: 0x00754BF5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06036DD3 RID: 224723 RVA: 0x00756A04 File Offset: 0x00754C04
		public IStopCameraLookAt __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x06036DD4 RID: 224724 RVA: 0x00756A14 File Offset: 0x00754C14
		public static void StartIStopCameraLookAt(FlatBufferBuilder builder)
		{
			builder.StartTable(0);
		}

		// Token: 0x06036DD5 RID: 224725 RVA: 0x00756A1D File Offset: 0x00754C1D
		public static Offset<IStopCameraLookAt> EndIStopCameraLookAt(FlatBufferBuilder builder)
		{
			return new Offset<IStopCameraLookAt>(builder.EndTable());
		}

		// Token: 0x06036DD6 RID: 224726 RVA: 0x00756A2C File Offset: 0x00754C2C
		public IStopCameraLookAtT UnPack()
		{
			IStopCameraLookAtT stopCameraLookAtT = new IStopCameraLookAtT();
			this.UnPackTo(stopCameraLookAtT);
			return stopCameraLookAtT;
		}

		// Token: 0x06036DD7 RID: 224727 RVA: 0x00756A47 File Offset: 0x00754C47
		public void UnPackTo(IStopCameraLookAtT _o)
		{
		}

		// Token: 0x06036DD8 RID: 224728 RVA: 0x00756A4C File Offset: 0x00754C4C
		public static Offset<IStopCameraLookAt> Pack(FlatBufferBuilder builder, IStopCameraLookAtT _o)
		{
			if (_o == null)
			{
				return default(Offset<IStopCameraLookAt>);
			}
			IStopCameraLookAt.StartIStopCameraLookAt(builder);
			return IStopCameraLookAt.EndIStopCameraLookAt(builder);
		}

		// Token: 0x04012CAF RID: 76975
		private Table __p;
	}
}
