using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006EBD RID: 28349
	public struct IFocusObject : IFlatbufferObject
	{
		// Token: 0x1700CFF2 RID: 53234
		// (get) Token: 0x060310BD RID: 200893 RVA: 0x006A6BE6 File Offset: 0x006A4DE6
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060310BE RID: 200894 RVA: 0x006A6BF3 File Offset: 0x006A4DF3
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060310BF RID: 200895 RVA: 0x006A6BFC File Offset: 0x006A4DFC
		public static IFocusObject GetRootAsIFocusObject(ByteBuffer _bb)
		{
			return IFocusObject.GetRootAsIFocusObject(_bb, default(IFocusObject));
		}

		// Token: 0x060310C0 RID: 200896 RVA: 0x006A6C18 File Offset: 0x006A4E18
		public static IFocusObject GetRootAsIFocusObject(ByteBuffer _bb, IFocusObject obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060310C1 RID: 200897 RVA: 0x006A6C35 File Offset: 0x006A4E35
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060310C2 RID: 200898 RVA: 0x006A6C44 File Offset: 0x006A4E44
		public IFocusObject __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CFF3 RID: 53235
		// (get) Token: 0x060310C3 RID: 200899 RVA: 0x006A6C54 File Offset: 0x006A4E54
		public IFocusObjectRotationConfig? RotationConfig
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return new IFocusObjectRotationConfig?(default(IFocusObjectRotationConfig).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700CFF4 RID: 53236
		// (get) Token: 0x060310C4 RID: 200900 RVA: 0x006A6CB4 File Offset: 0x006A4EB4
		public IFocusObjectCameraConfig? CameraConfig
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IFocusObjectCameraConfig?(default(IFocusObjectCameraConfig).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700CFF5 RID: 53237
		// (get) Token: 0x060310C5 RID: 200901 RVA: 0x006A6D14 File Offset: 0x006A4F14
		public int LeaveIndex
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700CFF6 RID: 53238
		// (get) Token: 0x060310C6 RID: 200902 RVA: 0x006A6D50 File Offset: 0x006A4F50
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060310C7 RID: 200903 RVA: 0x006A6D8D File Offset: 0x006A4F8D
		public static Offset<IFocusObject> CreateIFocusObject(FlatBufferBuilder builder, Offset<IFocusObjectRotationConfig> RotationConfigOffset = default(Offset<IFocusObjectRotationConfig>), Offset<IFocusObjectCameraConfig> CameraConfigOffset = default(Offset<IFocusObjectCameraConfig>), int LeaveIndex = 0, byte NullMask = 0)
		{
			builder.StartTable(4);
			IFocusObject.AddLeaveIndex(builder, LeaveIndex);
			IFocusObject.AddCameraConfig(builder, CameraConfigOffset);
			IFocusObject.AddRotationConfig(builder, RotationConfigOffset);
			IFocusObject.AddNullMask(builder, NullMask);
			return IFocusObject.EndIFocusObject(builder);
		}

		// Token: 0x060310C8 RID: 200904 RVA: 0x006A6DB9 File Offset: 0x006A4FB9
		public static void StartIFocusObject(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x060310C9 RID: 200905 RVA: 0x006A6DC2 File Offset: 0x006A4FC2
		public static void AddRotationConfig(FlatBufferBuilder builder, Offset<IFocusObjectRotationConfig> rotationConfigOffset)
		{
			builder.AddOffset(0, rotationConfigOffset.Value, 0);
		}

		// Token: 0x060310CA RID: 200906 RVA: 0x006A6DD2 File Offset: 0x006A4FD2
		public static void AddCameraConfig(FlatBufferBuilder builder, Offset<IFocusObjectCameraConfig> cameraConfigOffset)
		{
			builder.AddOffset(1, cameraConfigOffset.Value, 0);
		}

		// Token: 0x060310CB RID: 200907 RVA: 0x006A6DE2 File Offset: 0x006A4FE2
		public static void AddLeaveIndex(FlatBufferBuilder builder, int leaveIndex)
		{
			builder.AddInt(2, leaveIndex, 0);
		}

		// Token: 0x060310CC RID: 200908 RVA: 0x006A6DED File Offset: 0x006A4FED
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x060310CD RID: 200909 RVA: 0x006A6DF8 File Offset: 0x006A4FF8
		public static Offset<IFocusObject> EndIFocusObject(FlatBufferBuilder builder)
		{
			return new Offset<IFocusObject>(builder.EndTable());
		}

		// Token: 0x060310CE RID: 200910 RVA: 0x006A6E08 File Offset: 0x006A5008
		public IFocusObjectT UnPack()
		{
			IFocusObjectT focusObjectT = new IFocusObjectT();
			this.UnPackTo(focusObjectT);
			return focusObjectT;
		}

		// Token: 0x060310CF RID: 200911 RVA: 0x006A6E24 File Offset: 0x006A5024
		public void UnPackTo(IFocusObjectT _o)
		{
			_o.RotationConfig = ((this.RotationConfig != null) ? this.RotationConfig.Value.UnPack() : null);
			_o.CameraConfig = ((this.CameraConfig != null) ? this.CameraConfig.Value.UnPack() : null);
			_o.LeaveIndex = this.LeaveIndex;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x060310D0 RID: 200912 RVA: 0x006A6EA8 File Offset: 0x006A50A8
		public static Offset<IFocusObject> Pack(FlatBufferBuilder builder, IFocusObjectT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFocusObject>);
			}
			Offset<IFocusObjectRotationConfig> rotationConfigOffset = (_o.RotationConfig == null) ? default(Offset<IFocusObjectRotationConfig>) : IFocusObjectRotationConfig.Pack(builder, _o.RotationConfig);
			Offset<IFocusObjectCameraConfig> cameraConfigOffset = (_o.CameraConfig == null) ? default(Offset<IFocusObjectCameraConfig>) : IFocusObjectCameraConfig.Pack(builder, _o.CameraConfig);
			return IFocusObject.CreateIFocusObject(builder, rotationConfigOffset, cameraConfigOffset, _o.LeaveIndex, _o.NullMask);
		}

		// Token: 0x04011DB7 RID: 73143
		private Table __p;
	}
}
