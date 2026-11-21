using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006EC0 RID: 28352
	public struct IFocusObjectCameraConfig : IFlatbufferObject
	{
		// Token: 0x1700CFFB RID: 53243
		// (get) Token: 0x060310DB RID: 200923 RVA: 0x006A700A File Offset: 0x006A520A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060310DC RID: 200924 RVA: 0x006A7017 File Offset: 0x006A5217
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060310DD RID: 200925 RVA: 0x006A7020 File Offset: 0x006A5220
		public static IFocusObjectCameraConfig GetRootAsIFocusObjectCameraConfig(ByteBuffer _bb)
		{
			return IFocusObjectCameraConfig.GetRootAsIFocusObjectCameraConfig(_bb, default(IFocusObjectCameraConfig));
		}

		// Token: 0x060310DE RID: 200926 RVA: 0x006A703C File Offset: 0x006A523C
		public static IFocusObjectCameraConfig GetRootAsIFocusObjectCameraConfig(ByteBuffer _bb, IFocusObjectCameraConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060310DF RID: 200927 RVA: 0x006A7059 File Offset: 0x006A5259
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060310E0 RID: 200928 RVA: 0x006A7068 File Offset: 0x006A5268
		public IFocusObjectCameraConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CFFC RID: 53244
		// (get) Token: 0x060310E1 RID: 200929 RVA: 0x006A7078 File Offset: 0x006A5278
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

		// Token: 0x1700CFFD RID: 53245
		// (get) Token: 0x060310E2 RID: 200930 RVA: 0x006A70D8 File Offset: 0x006A52D8
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

		// Token: 0x1700CFFE RID: 53246
		// (get) Token: 0x060310E3 RID: 200931 RVA: 0x006A7118 File Offset: 0x006A5318
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

		// Token: 0x060310E4 RID: 200932 RVA: 0x006A7154 File Offset: 0x006A5354
		public static Offset<IFocusObjectCameraConfig> CreateIFocusObjectCameraConfig(FlatBufferBuilder builder, Offset<ICameraParams> CameraConfigOffset = default(Offset<ICameraParams>), float BlendInTime = 0f, byte NullMask = 0)
		{
			builder.StartTable(3);
			IFocusObjectCameraConfig.AddBlendInTime(builder, BlendInTime);
			IFocusObjectCameraConfig.AddCameraConfig(builder, CameraConfigOffset);
			IFocusObjectCameraConfig.AddNullMask(builder, NullMask);
			return IFocusObjectCameraConfig.EndIFocusObjectCameraConfig(builder);
		}

		// Token: 0x060310E5 RID: 200933 RVA: 0x006A7178 File Offset: 0x006A5378
		public static void StartIFocusObjectCameraConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x060310E6 RID: 200934 RVA: 0x006A7181 File Offset: 0x006A5381
		public static void AddCameraConfig(FlatBufferBuilder builder, Offset<ICameraParams> cameraConfigOffset)
		{
			builder.AddOffset(0, cameraConfigOffset.Value, 0);
		}

		// Token: 0x060310E7 RID: 200935 RVA: 0x006A7191 File Offset: 0x006A5391
		public static void AddBlendInTime(FlatBufferBuilder builder, float blendInTime)
		{
			builder.AddFloat(1, blendInTime, 0.0);
		}

		// Token: 0x060310E8 RID: 200936 RVA: 0x006A71A4 File Offset: 0x006A53A4
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x060310E9 RID: 200937 RVA: 0x006A71AF File Offset: 0x006A53AF
		public static Offset<IFocusObjectCameraConfig> EndIFocusObjectCameraConfig(FlatBufferBuilder builder)
		{
			return new Offset<IFocusObjectCameraConfig>(builder.EndTable());
		}

		// Token: 0x060310EA RID: 200938 RVA: 0x006A71BC File Offset: 0x006A53BC
		public IFocusObjectCameraConfigT UnPack()
		{
			IFocusObjectCameraConfigT focusObjectCameraConfigT = new IFocusObjectCameraConfigT();
			this.UnPackTo(focusObjectCameraConfigT);
			return focusObjectCameraConfigT;
		}

		// Token: 0x060310EB RID: 200939 RVA: 0x006A71D8 File Offset: 0x006A53D8
		public void UnPackTo(IFocusObjectCameraConfigT _o)
		{
			_o.CameraConfig = ((this.CameraConfig != null) ? this.CameraConfig.Value.UnPack() : null);
			_o.BlendInTime = this.BlendInTime;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x060310EC RID: 200940 RVA: 0x006A722C File Offset: 0x006A542C
		public static Offset<IFocusObjectCameraConfig> Pack(FlatBufferBuilder builder, IFocusObjectCameraConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFocusObjectCameraConfig>);
			}
			Offset<ICameraParams> cameraConfigOffset = (_o.CameraConfig == null) ? default(Offset<ICameraParams>) : ICameraParams.Pack(builder, _o.CameraConfig);
			return IFocusObjectCameraConfig.CreateIFocusObjectCameraConfig(builder, cameraConfigOffset, _o.BlendInTime, _o.NullMask);
		}

		// Token: 0x04011DBC RID: 73148
		private Table __p;
	}
}
