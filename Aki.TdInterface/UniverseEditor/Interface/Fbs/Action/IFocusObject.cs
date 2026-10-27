using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006837 RID: 26679
	public struct IFocusObject : IFlatbufferObject
	{
		// Token: 0x1700C62E RID: 50734
		// (get) Token: 0x0602E835 RID: 190517 RVA: 0x00658CA6 File Offset: 0x00656EA6
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602E836 RID: 190518 RVA: 0x00658CB3 File Offset: 0x00656EB3
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602E837 RID: 190519 RVA: 0x00658CBC File Offset: 0x00656EBC
		public static IFocusObject GetRootAsIFocusObject(ByteBuffer _bb)
		{
			return IFocusObject.GetRootAsIFocusObject(_bb, default(IFocusObject));
		}

		// Token: 0x0602E838 RID: 190520 RVA: 0x00658CD8 File Offset: 0x00656ED8
		public static IFocusObject GetRootAsIFocusObject(ByteBuffer _bb, IFocusObject obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602E839 RID: 190521 RVA: 0x00658CF5 File Offset: 0x00656EF5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602E83A RID: 190522 RVA: 0x00658D04 File Offset: 0x00656F04
		public IFocusObject __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C62F RID: 50735
		// (get) Token: 0x0602E83B RID: 190523 RVA: 0x00658D14 File Offset: 0x00656F14
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

		// Token: 0x1700C630 RID: 50736
		// (get) Token: 0x0602E83C RID: 190524 RVA: 0x00658D74 File Offset: 0x00656F74
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

		// Token: 0x1700C631 RID: 50737
		// (get) Token: 0x0602E83D RID: 190525 RVA: 0x00658DD4 File Offset: 0x00656FD4
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

		// Token: 0x1700C632 RID: 50738
		// (get) Token: 0x0602E83E RID: 190526 RVA: 0x00658E10 File Offset: 0x00657010
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

		// Token: 0x0602E83F RID: 190527 RVA: 0x00658E4D File Offset: 0x0065704D
		public static Offset<IFocusObject> CreateIFocusObject(FlatBufferBuilder builder, Offset<IFocusObjectRotationConfig> RotationConfigOffset = default(Offset<IFocusObjectRotationConfig>), Offset<IFocusObjectCameraConfig> CameraConfigOffset = default(Offset<IFocusObjectCameraConfig>), int LeaveIndex = 0, byte NullMask = 0)
		{
			builder.StartTable(4);
			IFocusObject.AddLeaveIndex(builder, LeaveIndex);
			IFocusObject.AddCameraConfig(builder, CameraConfigOffset);
			IFocusObject.AddRotationConfig(builder, RotationConfigOffset);
			IFocusObject.AddNullMask(builder, NullMask);
			return IFocusObject.EndIFocusObject(builder);
		}

		// Token: 0x0602E840 RID: 190528 RVA: 0x00658E79 File Offset: 0x00657079
		public static void StartIFocusObject(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0602E841 RID: 190529 RVA: 0x00658E82 File Offset: 0x00657082
		public static void AddRotationConfig(FlatBufferBuilder builder, Offset<IFocusObjectRotationConfig> rotationConfigOffset)
		{
			builder.AddOffset(0, rotationConfigOffset.Value, 0);
		}

		// Token: 0x0602E842 RID: 190530 RVA: 0x00658E92 File Offset: 0x00657092
		public static void AddCameraConfig(FlatBufferBuilder builder, Offset<IFocusObjectCameraConfig> cameraConfigOffset)
		{
			builder.AddOffset(1, cameraConfigOffset.Value, 0);
		}

		// Token: 0x0602E843 RID: 190531 RVA: 0x00658EA2 File Offset: 0x006570A2
		public static void AddLeaveIndex(FlatBufferBuilder builder, int leaveIndex)
		{
			builder.AddInt(2, leaveIndex, 0);
		}

		// Token: 0x0602E844 RID: 190532 RVA: 0x00658EAD File Offset: 0x006570AD
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x0602E845 RID: 190533 RVA: 0x00658EB8 File Offset: 0x006570B8
		public static Offset<IFocusObject> EndIFocusObject(FlatBufferBuilder builder)
		{
			return new Offset<IFocusObject>(builder.EndTable());
		}

		// Token: 0x0602E846 RID: 190534 RVA: 0x00658EC8 File Offset: 0x006570C8
		public IFocusObjectT UnPack()
		{
			IFocusObjectT focusObjectT = new IFocusObjectT();
			this.UnPackTo(focusObjectT);
			return focusObjectT;
		}

		// Token: 0x0602E847 RID: 190535 RVA: 0x00658EE4 File Offset: 0x006570E4
		public void UnPackTo(IFocusObjectT _o)
		{
			_o.RotationConfig = ((this.RotationConfig != null) ? this.RotationConfig.Value.UnPack() : null);
			_o.CameraConfig = ((this.CameraConfig != null) ? this.CameraConfig.Value.UnPack() : null);
			_o.LeaveIndex = this.LeaveIndex;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602E848 RID: 190536 RVA: 0x00658F68 File Offset: 0x00657168
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

		// Token: 0x04010F7D RID: 69501
		private Table __p;
	}
}
