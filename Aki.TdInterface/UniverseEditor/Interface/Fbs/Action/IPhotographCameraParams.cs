using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200742A RID: 29738
	public struct IPhotographCameraParams : IFlatbufferObject
	{
		// Token: 0x1700DA69 RID: 55913
		// (get) Token: 0x06034076 RID: 213110 RVA: 0x0070302C File Offset: 0x0070122C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06034077 RID: 213111 RVA: 0x00703039 File Offset: 0x00701239
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06034078 RID: 213112 RVA: 0x00703040 File Offset: 0x00701240
		public static IPhotographCameraParams GetRootAsIPhotographCameraParams(ByteBuffer _bb)
		{
			return IPhotographCameraParams.GetRootAsIPhotographCameraParams(_bb, default(IPhotographCameraParams));
		}

		// Token: 0x06034079 RID: 213113 RVA: 0x0070305C File Offset: 0x0070125C
		public static IPhotographCameraParams GetRootAsIPhotographCameraParams(ByteBuffer _bb, IPhotographCameraParams obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603407A RID: 213114 RVA: 0x00703079 File Offset: 0x00701279
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603407B RID: 213115 RVA: 0x00703088 File Offset: 0x00701288
		public IPhotographCameraParams __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700DA6A RID: 55914
		// (get) Token: 0x0603407C RID: 213116 RVA: 0x00703098 File Offset: 0x00701298
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

		// Token: 0x1700DA6B RID: 55915
		// (get) Token: 0x0603407D RID: 213117 RVA: 0x007030F8 File Offset: 0x007012F8
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

		// Token: 0x1700DA6C RID: 55916
		// (get) Token: 0x0603407E RID: 213118 RVA: 0x00703138 File Offset: 0x00701338
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

		// Token: 0x0603407F RID: 213119 RVA: 0x00703174 File Offset: 0x00701374
		public static Offset<IPhotographCameraParams> CreateIPhotographCameraParams(FlatBufferBuilder builder, Offset<IPhotographCameraTransformAbsolute> CameraTransformOffset = default(Offset<IPhotographCameraTransformAbsolute>), float Fov = 0f, byte NullMask = 0)
		{
			builder.StartTable(3);
			IPhotographCameraParams.AddFov(builder, Fov);
			IPhotographCameraParams.AddCameraTransform(builder, CameraTransformOffset);
			IPhotographCameraParams.AddNullMask(builder, NullMask);
			return IPhotographCameraParams.EndIPhotographCameraParams(builder);
		}

		// Token: 0x06034080 RID: 213120 RVA: 0x00703198 File Offset: 0x00701398
		public static void StartIPhotographCameraParams(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06034081 RID: 213121 RVA: 0x007031A1 File Offset: 0x007013A1
		public static void AddCameraTransform(FlatBufferBuilder builder, Offset<IPhotographCameraTransformAbsolute> cameraTransformOffset)
		{
			builder.AddOffset(0, cameraTransformOffset.Value, 0);
		}

		// Token: 0x06034082 RID: 213122 RVA: 0x007031B1 File Offset: 0x007013B1
		public static void AddFov(FlatBufferBuilder builder, float fov)
		{
			builder.AddFloat(1, fov, 0.0);
		}

		// Token: 0x06034083 RID: 213123 RVA: 0x007031C4 File Offset: 0x007013C4
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x06034084 RID: 213124 RVA: 0x007031CF File Offset: 0x007013CF
		public static Offset<IPhotographCameraParams> EndIPhotographCameraParams(FlatBufferBuilder builder)
		{
			return new Offset<IPhotographCameraParams>(builder.EndTable());
		}

		// Token: 0x06034085 RID: 213125 RVA: 0x007031DC File Offset: 0x007013DC
		public IPhotographCameraParamsT UnPack()
		{
			IPhotographCameraParamsT photographCameraParamsT = new IPhotographCameraParamsT();
			this.UnPackTo(photographCameraParamsT);
			return photographCameraParamsT;
		}

		// Token: 0x06034086 RID: 213126 RVA: 0x007031F8 File Offset: 0x007013F8
		public void UnPackTo(IPhotographCameraParamsT _o)
		{
			_o.CameraTransform = ((this.CameraTransform != null) ? this.CameraTransform.Value.UnPack() : null);
			_o.Fov = this.Fov;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06034087 RID: 213127 RVA: 0x0070324C File Offset: 0x0070144C
		public static Offset<IPhotographCameraParams> Pack(FlatBufferBuilder builder, IPhotographCameraParamsT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPhotographCameraParams>);
			}
			Offset<IPhotographCameraTransformAbsolute> cameraTransformOffset = (_o.CameraTransform == null) ? default(Offset<IPhotographCameraTransformAbsolute>) : IPhotographCameraTransformAbsolute.Pack(builder, _o.CameraTransform);
			return IPhotographCameraParams.CreateIPhotographCameraParams(builder, cameraTransformOffset, _o.Fov, _o.NullMask);
		}

		// Token: 0x04012582 RID: 75138
		private Table __p;
	}
}
