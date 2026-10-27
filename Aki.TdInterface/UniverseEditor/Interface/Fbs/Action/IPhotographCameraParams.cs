using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006CB4 RID: 27828
	public struct IPhotographCameraParams : IFlatbufferObject
	{
		// Token: 0x1700CF2C RID: 53036
		// (get) Token: 0x0603109F RID: 200863 RVA: 0x006A7DF8 File Offset: 0x006A5FF8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060310A0 RID: 200864 RVA: 0x006A7E05 File Offset: 0x006A6005
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060310A1 RID: 200865 RVA: 0x006A7E0C File Offset: 0x006A600C
		public static IPhotographCameraParams GetRootAsIPhotographCameraParams(ByteBuffer _bb)
		{
			return IPhotographCameraParams.GetRootAsIPhotographCameraParams(_bb, default(IPhotographCameraParams));
		}

		// Token: 0x060310A2 RID: 200866 RVA: 0x006A7E28 File Offset: 0x006A6028
		public static IPhotographCameraParams GetRootAsIPhotographCameraParams(ByteBuffer _bb, IPhotographCameraParams obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060310A3 RID: 200867 RVA: 0x006A7E45 File Offset: 0x006A6045
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060310A4 RID: 200868 RVA: 0x006A7E54 File Offset: 0x006A6054
		public IPhotographCameraParams __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CF2D RID: 53037
		// (get) Token: 0x060310A5 RID: 200869 RVA: 0x006A7E64 File Offset: 0x006A6064
		public IPhotographCameraTransformAbsolute? CameraTransform
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return new IPhotographCameraTransformAbsolute?(default(IPhotographCameraTransformAbsolute).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700CF2E RID: 53038
		// (get) Token: 0x060310A6 RID: 200870 RVA: 0x006A7EC4 File Offset: 0x006A60C4
		public float Fov
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700CF2F RID: 53039
		// (get) Token: 0x060310A7 RID: 200871 RVA: 0x006A7F04 File Offset: 0x006A6104
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060310A8 RID: 200872 RVA: 0x006A7F40 File Offset: 0x006A6140
		public static Offset<IPhotographCameraParams> CreateIPhotographCameraParams(FlatBufferBuilder builder, Offset<IPhotographCameraTransformAbsolute> CameraTransformOffset = default(Offset<IPhotographCameraTransformAbsolute>), float Fov = 0f, byte NullMask = 0)
		{
			builder.StartTable(3);
			IPhotographCameraParams.AddFov(builder, Fov);
			IPhotographCameraParams.AddCameraTransform(builder, CameraTransformOffset);
			IPhotographCameraParams.AddNullMask(builder, NullMask);
			return IPhotographCameraParams.EndIPhotographCameraParams(builder);
		}

		// Token: 0x060310A9 RID: 200873 RVA: 0x006A7F64 File Offset: 0x006A6164
		public static void StartIPhotographCameraParams(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x060310AA RID: 200874 RVA: 0x006A7F6D File Offset: 0x006A616D
		public static void AddCameraTransform(FlatBufferBuilder builder, Offset<IPhotographCameraTransformAbsolute> cameraTransformOffset)
		{
			builder.AddOffset(0, cameraTransformOffset.Value, 0);
		}

		// Token: 0x060310AB RID: 200875 RVA: 0x006A7F7D File Offset: 0x006A617D
		public static void AddFov(FlatBufferBuilder builder, float fov)
		{
			builder.AddFloat(1, fov, 0.0);
		}

		// Token: 0x060310AC RID: 200876 RVA: 0x006A7F90 File Offset: 0x006A6190
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x060310AD RID: 200877 RVA: 0x006A7F9B File Offset: 0x006A619B
		public static Offset<IPhotographCameraParams> EndIPhotographCameraParams(FlatBufferBuilder builder)
		{
			return new Offset<IPhotographCameraParams>(builder.EndTable());
		}

		// Token: 0x060310AE RID: 200878 RVA: 0x006A7FA8 File Offset: 0x006A61A8
		public IPhotographCameraParamsT UnPack()
		{
			IPhotographCameraParamsT photographCameraParamsT = new IPhotographCameraParamsT();
			this.UnPackTo(photographCameraParamsT);
			return photographCameraParamsT;
		}

		// Token: 0x060310AF RID: 200879 RVA: 0x006A7FC4 File Offset: 0x006A61C4
		public void UnPackTo(IPhotographCameraParamsT _o)
		{
			_o.CameraTransform = ((this.CameraTransform != null) ? this.CameraTransform.Value.UnPack() : null);
			_o.Fov = this.Fov;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x060310B0 RID: 200880 RVA: 0x006A8018 File Offset: 0x006A6218
		public static Offset<IPhotographCameraParams> Pack(FlatBufferBuilder builder, IPhotographCameraParamsT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPhotographCameraParams>);
			}
			Offset<IPhotographCameraTransformAbsolute> cameraTransformOffset = (_o.CameraTransform == null) ? default(Offset<IPhotographCameraTransformAbsolute>) : IPhotographCameraTransformAbsolute.Pack(builder, _o.CameraTransform);
			return IPhotographCameraParams.CreateIPhotographCameraParams(builder, cameraTransformOffset, _o.Fov, _o.NullMask);
		}

		// Token: 0x04011612 RID: 71186
		private Table __p;
	}
}
