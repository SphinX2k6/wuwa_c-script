using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200690D RID: 26893
	public struct ICameraPosAndRot : IFlatbufferObject
	{
		// Token: 0x1700C5F4 RID: 50676
		// (get) Token: 0x0602E134 RID: 188724 RVA: 0x0064BEF6 File Offset: 0x0064A0F6
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602E135 RID: 188725 RVA: 0x0064BF03 File Offset: 0x0064A103
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602E136 RID: 188726 RVA: 0x0064BF0C File Offset: 0x0064A10C
		public static ICameraPosAndRot GetRootAsICameraPosAndRot(ByteBuffer _bb)
		{
			return ICameraPosAndRot.GetRootAsICameraPosAndRot(_bb, default(ICameraPosAndRot));
		}

		// Token: 0x0602E137 RID: 188727 RVA: 0x0064BF28 File Offset: 0x0064A128
		public static ICameraPosAndRot GetRootAsICameraPosAndRot(ByteBuffer _bb, ICameraPosAndRot obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602E138 RID: 188728 RVA: 0x0064BF45 File Offset: 0x0064A145
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602E139 RID: 188729 RVA: 0x0064BF54 File Offset: 0x0064A154
		public ICameraPosAndRot __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C5F5 RID: 50677
		// (get) Token: 0x0602E13A RID: 188730 RVA: 0x0064BF64 File Offset: 0x0064A164
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

		// Token: 0x1700C5F6 RID: 50678
		// (get) Token: 0x0602E13B RID: 188731 RVA: 0x0064BFC4 File Offset: 0x0064A1C4
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

		// Token: 0x0602E13C RID: 188732 RVA: 0x0064C021 File Offset: 0x0064A221
		public static Offset<ICameraPosAndRot> CreateICameraPosAndRot(FlatBufferBuilder builder, Offset<IVectorInfo> CameraOffsetOffset = default(Offset<IVectorInfo>), Offset<IVectorInfo> CameraRotateOffset = default(Offset<IVectorInfo>))
		{
			builder.StartTable(2);
			ICameraPosAndRot.AddCameraRotate(builder, CameraRotateOffset);
			ICameraPosAndRot.AddCameraOffset(builder, CameraOffsetOffset);
			return ICameraPosAndRot.EndICameraPosAndRot(builder);
		}

		// Token: 0x0602E13D RID: 188733 RVA: 0x0064C03E File Offset: 0x0064A23E
		public static void StartICameraPosAndRot(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602E13E RID: 188734 RVA: 0x0064C047 File Offset: 0x0064A247
		public static void AddCameraOffset(FlatBufferBuilder builder, Offset<IVectorInfo> cameraOffsetOffset)
		{
			builder.AddOffset(0, cameraOffsetOffset.Value, 0);
		}

		// Token: 0x0602E13F RID: 188735 RVA: 0x0064C057 File Offset: 0x0064A257
		public static void AddCameraRotate(FlatBufferBuilder builder, Offset<IVectorInfo> cameraRotateOffset)
		{
			builder.AddOffset(1, cameraRotateOffset.Value, 0);
		}

		// Token: 0x0602E140 RID: 188736 RVA: 0x0064C067 File Offset: 0x0064A267
		public static Offset<ICameraPosAndRot> EndICameraPosAndRot(FlatBufferBuilder builder)
		{
			return new Offset<ICameraPosAndRot>(builder.EndTable());
		}

		// Token: 0x0602E141 RID: 188737 RVA: 0x0064C074 File Offset: 0x0064A274
		public ICameraPosAndRotT UnPack()
		{
			ICameraPosAndRotT cameraPosAndRotT = new ICameraPosAndRotT();
			this.UnPackTo(cameraPosAndRotT);
			return cameraPosAndRotT;
		}

		// Token: 0x0602E142 RID: 188738 RVA: 0x0064C090 File Offset: 0x0064A290
		public void UnPackTo(ICameraPosAndRotT _o)
		{
			_o.CameraOffset = ((this.CameraOffset != null) ? this.CameraOffset.Value.UnPack() : null);
			_o.CameraRotate = ((this.CameraRotate != null) ? this.CameraRotate.Value.UnPack() : null);
		}

		// Token: 0x0602E143 RID: 188739 RVA: 0x0064C0FC File Offset: 0x0064A2FC
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

		// Token: 0x04011644 RID: 71236
		private Table __p;
	}
}
