using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020045BC RID: 17852
	public struct ITakePhoto2BeforeYourEyesMode : IFlatbufferObject
	{
		// Token: 0x17007CBC RID: 31932
		// (get) Token: 0x0601A0AD RID: 106669 RVA: 0x003B60BE File Offset: 0x003B42BE
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601A0AE RID: 106670 RVA: 0x003B60CB File Offset: 0x003B42CB
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601A0AF RID: 106671 RVA: 0x003B60D4 File Offset: 0x003B42D4
		public static ITakePhoto2BeforeYourEyesMode GetRootAsITakePhoto2BeforeYourEyesMode(ByteBuffer _bb)
		{
			return ITakePhoto2BeforeYourEyesMode.GetRootAsITakePhoto2BeforeYourEyesMode(_bb, default(ITakePhoto2BeforeYourEyesMode));
		}

		// Token: 0x0601A0B0 RID: 106672 RVA: 0x003B60F0 File Offset: 0x003B42F0
		public static ITakePhoto2BeforeYourEyesMode GetRootAsITakePhoto2BeforeYourEyesMode(ByteBuffer _bb, ITakePhoto2BeforeYourEyesMode obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601A0B1 RID: 106673 RVA: 0x003B610D File Offset: 0x003B430D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601A0B2 RID: 106674 RVA: 0x003B611C File Offset: 0x003B431C
		public ITakePhoto2BeforeYourEyesMode __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007CBD RID: 31933
		// (get) Token: 0x0601A0B3 RID: 106675 RVA: 0x003B612C File Offset: 0x003B432C
		public ETakePhoto2Mode Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ETakePhoto2Mode.BeforeYourEyes;
				}
				return (ETakePhoto2Mode)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17007CBE RID: 31934
		// (get) Token: 0x0601A0B4 RID: 106676 RVA: 0x003B6168 File Offset: 0x003B4368
		public TTakePhoto2SuccessCameraBehavior SuccessCameraBehaviorType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return TTakePhoto2SuccessCameraBehavior.NONE;
				}
				return (TTakePhoto2SuccessCameraBehavior)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601A0B5 RID: 106677 RVA: 0x003B61A4 File Offset: 0x003B43A4
		public TTable? SuccessCameraBehavior<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0601A0B6 RID: 106678 RVA: 0x003B61E8 File Offset: 0x003B43E8
		public ITakePhoto2CloseCameraAfterFinishActions SuccessCameraBehaviorAsITakePhoto2CloseCameraAfterFinishActions()
		{
			return this.SuccessCameraBehavior<ITakePhoto2CloseCameraAfterFinishActions>().Value;
		}

		// Token: 0x0601A0B7 RID: 106679 RVA: 0x003B6204 File Offset: 0x003B4404
		public ITakePhoto2KeepCameraOpen SuccessCameraBehaviorAsITakePhoto2KeepCameraOpen()
		{
			return this.SuccessCameraBehavior<ITakePhoto2KeepCameraOpen>().Value;
		}

		// Token: 0x0601A0B8 RID: 106680 RVA: 0x003B621F File Offset: 0x003B441F
		public static Offset<ITakePhoto2BeforeYourEyesMode> CreateITakePhoto2BeforeYourEyesMode(FlatBufferBuilder builder, ETakePhoto2Mode Type = ETakePhoto2Mode.BeforeYourEyes, TTakePhoto2SuccessCameraBehavior SuccessCameraBehavior_type = TTakePhoto2SuccessCameraBehavior.NONE, int SuccessCameraBehaviorOffset = 0)
		{
			builder.StartTable(3);
			ITakePhoto2BeforeYourEyesMode.AddSuccessCameraBehavior(builder, SuccessCameraBehaviorOffset);
			ITakePhoto2BeforeYourEyesMode.AddSuccessCameraBehaviorType(builder, SuccessCameraBehavior_type);
			ITakePhoto2BeforeYourEyesMode.AddType(builder, Type);
			return ITakePhoto2BeforeYourEyesMode.EndITakePhoto2BeforeYourEyesMode(builder);
		}

		// Token: 0x0601A0B9 RID: 106681 RVA: 0x003B6243 File Offset: 0x003B4443
		public static void StartITakePhoto2BeforeYourEyesMode(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601A0BA RID: 106682 RVA: 0x003B624C File Offset: 0x003B444C
		public static void AddType(FlatBufferBuilder builder, ETakePhoto2Mode type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601A0BB RID: 106683 RVA: 0x003B6257 File Offset: 0x003B4457
		public static void AddSuccessCameraBehaviorType(FlatBufferBuilder builder, TTakePhoto2SuccessCameraBehavior successCameraBehaviorType)
		{
			builder.AddByte(1, (byte)successCameraBehaviorType, 0);
		}

		// Token: 0x0601A0BC RID: 106684 RVA: 0x003B6262 File Offset: 0x003B4462
		public static void AddSuccessCameraBehavior(FlatBufferBuilder builder, int successCameraBehaviorOffset)
		{
			builder.AddOffset(2, successCameraBehaviorOffset, 0);
		}

		// Token: 0x0601A0BD RID: 106685 RVA: 0x003B626D File Offset: 0x003B446D
		public static Offset<ITakePhoto2BeforeYourEyesMode> EndITakePhoto2BeforeYourEyesMode(FlatBufferBuilder builder)
		{
			return new Offset<ITakePhoto2BeforeYourEyesMode>(builder.EndTable());
		}

		// Token: 0x0601A0BE RID: 106686 RVA: 0x003B627C File Offset: 0x003B447C
		public ITakePhoto2BeforeYourEyesModeT UnPack()
		{
			ITakePhoto2BeforeYourEyesModeT takePhoto2BeforeYourEyesModeT = new ITakePhoto2BeforeYourEyesModeT();
			this.UnPackTo(takePhoto2BeforeYourEyesModeT);
			return takePhoto2BeforeYourEyesModeT;
		}

		// Token: 0x0601A0BF RID: 106687 RVA: 0x003B6298 File Offset: 0x003B4498
		public void UnPackTo(ITakePhoto2BeforeYourEyesModeT _o)
		{
			_o.Type = this.Type;
			_o.SuccessCameraBehavior = new TTakePhoto2SuccessCameraBehaviorUnion();
			_o.SuccessCameraBehavior.Type = this.SuccessCameraBehaviorType;
			TTakePhoto2SuccessCameraBehavior successCameraBehaviorType = this.SuccessCameraBehaviorType;
			if (successCameraBehaviorType == TTakePhoto2SuccessCameraBehavior.ITakePhoto2CloseCameraAfterFinishActions)
			{
				_o.SuccessCameraBehavior.Value = ((this.SuccessCameraBehavior<ITakePhoto2CloseCameraAfterFinishActions>() != null) ? this.SuccessCameraBehavior<ITakePhoto2CloseCameraAfterFinishActions>().Value.UnPack() : null);
				return;
			}
			if (successCameraBehaviorType != TTakePhoto2SuccessCameraBehavior.ITakePhoto2KeepCameraOpen)
			{
				return;
			}
			_o.SuccessCameraBehavior.Value = ((this.SuccessCameraBehavior<ITakePhoto2KeepCameraOpen>() != null) ? this.SuccessCameraBehavior<ITakePhoto2KeepCameraOpen>().Value.UnPack() : null);
		}

		// Token: 0x0601A0C0 RID: 106688 RVA: 0x003B6348 File Offset: 0x003B4548
		public static Offset<ITakePhoto2BeforeYourEyesMode> Pack(FlatBufferBuilder builder, ITakePhoto2BeforeYourEyesModeT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITakePhoto2BeforeYourEyesMode>);
			}
			TTakePhoto2SuccessCameraBehavior successCameraBehavior_type = (_o.SuccessCameraBehavior == null) ? TTakePhoto2SuccessCameraBehavior.NONE : _o.SuccessCameraBehavior.Type;
			int successCameraBehaviorOffset = (_o.SuccessCameraBehavior == null) ? 0 : TTakePhoto2SuccessCameraBehaviorUnion.Pack(builder, _o.SuccessCameraBehavior);
			return ITakePhoto2BeforeYourEyesMode.CreateITakePhoto2BeforeYourEyesMode(builder, _o.Type, successCameraBehavior_type, successCameraBehaviorOffset);
		}

		// Token: 0x0400C783 RID: 51075
		private Table __p;
	}
}
