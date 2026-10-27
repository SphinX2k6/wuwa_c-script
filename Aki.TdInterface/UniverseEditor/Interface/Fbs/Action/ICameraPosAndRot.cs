using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200629C RID: 25244
	public struct ICameraPosAndRot : IFlatbufferObject
	{
		// Token: 0x1700BC6C RID: 48236
		// (get) Token: 0x0602B9D3 RID: 178643 RVA: 0x006010EE File Offset: 0x005FF2EE
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602B9D4 RID: 178644 RVA: 0x006010FB File Offset: 0x005FF2FB
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602B9D5 RID: 178645 RVA: 0x00601104 File Offset: 0x005FF304
		public static ICameraPosAndRot GetRootAsICameraPosAndRot(ByteBuffer _bb)
		{
			return ICameraPosAndRot.GetRootAsICameraPosAndRot(_bb, default(ICameraPosAndRot));
		}

		// Token: 0x0602B9D6 RID: 178646 RVA: 0x00601120 File Offset: 0x005FF320
		public static ICameraPosAndRot GetRootAsICameraPosAndRot(ByteBuffer _bb, ICameraPosAndRot obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602B9D7 RID: 178647 RVA: 0x0060113D File Offset: 0x005FF33D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602B9D8 RID: 178648 RVA: 0x0060114C File Offset: 0x005FF34C
		public ICameraPosAndRot __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BC6D RID: 48237
		// (get) Token: 0x0602B9D9 RID: 178649 RVA: 0x0060115C File Offset: 0x005FF35C
		public IVectorInfo? CameraOffset
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return new IVectorInfo?(default(IVectorInfo).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700BC6E RID: 48238
		// (get) Token: 0x0602B9DA RID: 178650 RVA: 0x006011BC File Offset: 0x005FF3BC
		public IVectorInfo? CameraRotate
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IVectorInfo?(default(IVectorInfo).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x0602B9DB RID: 178651 RVA: 0x00601219 File Offset: 0x005FF419
		public static Offset<ICameraPosAndRot> CreateICameraPosAndRot(FlatBufferBuilder builder, Offset<IVectorInfo> CameraOffsetOffset = default(Offset<IVectorInfo>), Offset<IVectorInfo> CameraRotateOffset = default(Offset<IVectorInfo>))
		{
			builder.StartTable(2);
			ICameraPosAndRot.AddCameraRotate(builder, CameraRotateOffset);
			ICameraPosAndRot.AddCameraOffset(builder, CameraOffsetOffset);
			return ICameraPosAndRot.EndICameraPosAndRot(builder);
		}

		// Token: 0x0602B9DC RID: 178652 RVA: 0x00601236 File Offset: 0x005FF436
		public static void StartICameraPosAndRot(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602B9DD RID: 178653 RVA: 0x0060123F File Offset: 0x005FF43F
		public static void AddCameraOffset(FlatBufferBuilder builder, Offset<IVectorInfo> cameraOffsetOffset)
		{
			builder.AddOffset(0, cameraOffsetOffset.Value, 0);
		}

		// Token: 0x0602B9DE RID: 178654 RVA: 0x0060124F File Offset: 0x005FF44F
		public static void AddCameraRotate(FlatBufferBuilder builder, Offset<IVectorInfo> cameraRotateOffset)
		{
			builder.AddOffset(1, cameraRotateOffset.Value, 0);
		}

		// Token: 0x0602B9DF RID: 178655 RVA: 0x0060125F File Offset: 0x005FF45F
		public static Offset<ICameraPosAndRot> EndICameraPosAndRot(FlatBufferBuilder builder)
		{
			return new Offset<ICameraPosAndRot>(builder.EndTable());
		}

		// Token: 0x0602B9E0 RID: 178656 RVA: 0x0060126C File Offset: 0x005FF46C
		public ICameraPosAndRotT UnPack()
		{
			ICameraPosAndRotT cameraPosAndRotT = new ICameraPosAndRotT();
			this.UnPackTo(cameraPosAndRotT);
			return cameraPosAndRotT;
		}

		// Token: 0x0602B9E1 RID: 178657 RVA: 0x00601288 File Offset: 0x005FF488
		public void UnPackTo(ICameraPosAndRotT _o)
		{
			_o.CameraOffset = ((this.CameraOffset != null) ? this.CameraOffset.Value.UnPack() : null);
			_o.CameraRotate = ((this.CameraRotate != null) ? this.CameraRotate.Value.UnPack() : null);
		}

		// Token: 0x0602B9E2 RID: 178658 RVA: 0x006012F4 File Offset: 0x005FF4F4
		public static Offset<ICameraPosAndRot> Pack(FlatBufferBuilder builder, ICameraPosAndRotT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICameraPosAndRot>);
			}
			Offset<IVectorInfo> cameraOffsetOffset = (_o.CameraOffset == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.CameraOffset);
			Offset<IVectorInfo> cameraRotateOffset = (_o.CameraRotate == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.CameraRotate);
			return ICameraPosAndRot.CreateICameraPosAndRot(builder, cameraOffsetOffset, cameraRotateOffset);
		}

		// Token: 0x0401082F RID: 67631
		private Table __p;
	}
}
