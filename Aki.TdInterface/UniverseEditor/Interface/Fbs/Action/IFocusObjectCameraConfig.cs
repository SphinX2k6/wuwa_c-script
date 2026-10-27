using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200683A RID: 26682
	public struct IFocusObjectCameraConfig : IFlatbufferObject
	{
		// Token: 0x1700C637 RID: 50743
		// (get) Token: 0x0602E853 RID: 190547 RVA: 0x006590CA File Offset: 0x006572CA
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602E854 RID: 190548 RVA: 0x006590D7 File Offset: 0x006572D7
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602E855 RID: 190549 RVA: 0x006590E0 File Offset: 0x006572E0
		public static IFocusObjectCameraConfig GetRootAsIFocusObjectCameraConfig(ByteBuffer _bb)
		{
			return IFocusObjectCameraConfig.GetRootAsIFocusObjectCameraConfig(_bb, default(IFocusObjectCameraConfig));
		}

		// Token: 0x0602E856 RID: 190550 RVA: 0x006590FC File Offset: 0x006572FC
		public static IFocusObjectCameraConfig GetRootAsIFocusObjectCameraConfig(ByteBuffer _bb, IFocusObjectCameraConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602E857 RID: 190551 RVA: 0x00659119 File Offset: 0x00657319
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602E858 RID: 190552 RVA: 0x00659128 File Offset: 0x00657328
		public IFocusObjectCameraConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C638 RID: 50744
		// (get) Token: 0x0602E859 RID: 190553 RVA: 0x00659138 File Offset: 0x00657338
		public ICameraParams? CameraConfig
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return new ICameraParams?(default(ICameraParams).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700C639 RID: 50745
		// (get) Token: 0x0602E85A RID: 190554 RVA: 0x00659198 File Offset: 0x00657398
		public float BlendInTime
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

		// Token: 0x1700C63A RID: 50746
		// (get) Token: 0x0602E85B RID: 190555 RVA: 0x006591D8 File Offset: 0x006573D8
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

		// Token: 0x0602E85C RID: 190556 RVA: 0x00659214 File Offset: 0x00657414
		public static Offset<IFocusObjectCameraConfig> CreateIFocusObjectCameraConfig(FlatBufferBuilder builder, Offset<ICameraParams> CameraConfigOffset = default(Offset<ICameraParams>), float BlendInTime = 0f, byte NullMask = 0)
		{
			builder.StartTable(3);
			IFocusObjectCameraConfig.AddBlendInTime(builder, BlendInTime);
			IFocusObjectCameraConfig.AddCameraConfig(builder, CameraConfigOffset);
			IFocusObjectCameraConfig.AddNullMask(builder, NullMask);
			return IFocusObjectCameraConfig.EndIFocusObjectCameraConfig(builder);
		}

		// Token: 0x0602E85D RID: 190557 RVA: 0x00659238 File Offset: 0x00657438
		public static void StartIFocusObjectCameraConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0602E85E RID: 190558 RVA: 0x00659241 File Offset: 0x00657441
		public static void AddCameraConfig(FlatBufferBuilder builder, Offset<ICameraParams> cameraConfigOffset)
		{
			builder.AddOffset(0, cameraConfigOffset.Value, 0);
		}

		// Token: 0x0602E85F RID: 190559 RVA: 0x00659251 File Offset: 0x00657451
		public static void AddBlendInTime(FlatBufferBuilder builder, float blendInTime)
		{
			builder.AddFloat(1, blendInTime, 0.0);
		}

		// Token: 0x0602E860 RID: 190560 RVA: 0x00659264 File Offset: 0x00657464
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x0602E861 RID: 190561 RVA: 0x0065926F File Offset: 0x0065746F
		public static Offset<IFocusObjectCameraConfig> EndIFocusObjectCameraConfig(FlatBufferBuilder builder)
		{
			return new Offset<IFocusObjectCameraConfig>(builder.EndTable());
		}

		// Token: 0x0602E862 RID: 190562 RVA: 0x0065927C File Offset: 0x0065747C
		public IFocusObjectCameraConfigT UnPack()
		{
			IFocusObjectCameraConfigT focusObjectCameraConfigT = new IFocusObjectCameraConfigT();
			this.UnPackTo(focusObjectCameraConfigT);
			return focusObjectCameraConfigT;
		}

		// Token: 0x0602E863 RID: 190563 RVA: 0x00659298 File Offset: 0x00657498
		public void UnPackTo(IFocusObjectCameraConfigT _o)
		{
			_o.CameraConfig = ((this.CameraConfig != null) ? this.CameraConfig.Value.UnPack() : null);
			_o.BlendInTime = this.BlendInTime;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602E864 RID: 190564 RVA: 0x006592EC File Offset: 0x006574EC
		public static Offset<IFocusObjectCameraConfig> Pack(FlatBufferBuilder builder, IFocusObjectCameraConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFocusObjectCameraConfig>);
			}
			Offset<ICameraParams> cameraConfigOffset = (_o.CameraConfig == null) ? default(Offset<ICameraParams>) : ICameraParams.Pack(builder, _o.CameraConfig);
			return IFocusObjectCameraConfig.CreateIFocusObjectCameraConfig(builder, cameraConfigOffset, _o.BlendInTime, _o.NullMask);
		}

		// Token: 0x04010F82 RID: 69506
		private Table __p;
	}
}
