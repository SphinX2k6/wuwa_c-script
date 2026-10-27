using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020071C9 RID: 29129
	public struct IStopCameraLookAt : IFlatbufferObject
	{
		// Token: 0x1700D871 RID: 55409
		// (get) Token: 0x06033ACC RID: 211660 RVA: 0x006F5648 File Offset: 0x006F3848
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06033ACD RID: 211661 RVA: 0x006F5655 File Offset: 0x006F3855
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06033ACE RID: 211662 RVA: 0x006F565C File Offset: 0x006F385C
		public static IStopCameraLookAt GetRootAsIStopCameraLookAt(ByteBuffer _bb)
		{
			return IStopCameraLookAt.GetRootAsIStopCameraLookAt(_bb, default(IStopCameraLookAt));
		}

		// Token: 0x06033ACF RID: 211663 RVA: 0x006F5678 File Offset: 0x006F3878
		public static IStopCameraLookAt GetRootAsIStopCameraLookAt(ByteBuffer _bb, IStopCameraLookAt obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06033AD0 RID: 211664 RVA: 0x006F5695 File Offset: 0x006F3895
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06033AD1 RID: 211665 RVA: 0x006F56A4 File Offset: 0x006F38A4
		public IStopCameraLookAt __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x06033AD2 RID: 211666 RVA: 0x006F56B4 File Offset: 0x006F38B4
		public static void StartIStopCameraLookAt(FlatBufferBuilder builder)
		{
			builder.StartTable(0);
		}

		// Token: 0x06033AD3 RID: 211667 RVA: 0x006F56BD File Offset: 0x006F38BD
		public static Offset<IStopCameraLookAt> EndIStopCameraLookAt(FlatBufferBuilder builder)
		{
			return new Offset<IStopCameraLookAt>(builder.EndTable());
		}

		// Token: 0x06033AD4 RID: 211668 RVA: 0x006F56CC File Offset: 0x006F38CC
		public IStopCameraLookAtT UnPack()
		{
			IStopCameraLookAtT stopCameraLookAtT = new IStopCameraLookAtT();
			this.UnPackTo(stopCameraLookAtT);
			return stopCameraLookAtT;
		}

		// Token: 0x06033AD5 RID: 211669 RVA: 0x006F56E7 File Offset: 0x006F38E7
		public void UnPackTo(IStopCameraLookAtT _o)
		{
		}

		// Token: 0x06033AD6 RID: 211670 RVA: 0x006F56EC File Offset: 0x006F38EC
		public static Offset<IStopCameraLookAt> Pack(FlatBufferBuilder builder, IStopCameraLookAtT _o)
		{
			if (_o == null)
			{
				return default(Offset<IStopCameraLookAt>);
			}
			IStopCameraLookAt.StartIStopCameraLookAt(builder);
			return IStopCameraLookAt.EndIStopCameraLookAt(builder);
		}

		// Token: 0x04011CAD RID: 72877
		private Table __p;
	}
}
