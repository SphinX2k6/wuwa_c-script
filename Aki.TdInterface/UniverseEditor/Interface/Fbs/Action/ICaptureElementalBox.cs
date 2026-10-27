using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020062AE RID: 25262
	public struct ICaptureElementalBox : IFlatbufferObject
	{
		// Token: 0x1700BC93 RID: 48275
		// (get) Token: 0x0602BA67 RID: 178791 RVA: 0x00602144 File Offset: 0x00600344
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602BA68 RID: 178792 RVA: 0x00602151 File Offset: 0x00600351
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602BA69 RID: 178793 RVA: 0x00602158 File Offset: 0x00600358
		public static ICaptureElementalBox GetRootAsICaptureElementalBox(ByteBuffer _bb)
		{
			return ICaptureElementalBox.GetRootAsICaptureElementalBox(_bb, default(ICaptureElementalBox));
		}

		// Token: 0x0602BA6A RID: 178794 RVA: 0x00602174 File Offset: 0x00600374
		public static ICaptureElementalBox GetRootAsICaptureElementalBox(ByteBuffer _bb, ICaptureElementalBox obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602BA6B RID: 178795 RVA: 0x00602191 File Offset: 0x00600391
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602BA6C RID: 178796 RVA: 0x006021A0 File Offset: 0x006003A0
		public ICaptureElementalBox __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BC94 RID: 48276
		// (get) Token: 0x0602BA6D RID: 178797 RVA: 0x006021B0 File Offset: 0x006003B0
		public TControlElementalBoxType CtrlConfigType
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return TControlElementalBoxType.NONE;
				}
				return (TControlElementalBoxType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602BA6E RID: 178798 RVA: 0x006021EC File Offset: 0x006003EC
		public TTable? CtrlConfig<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0602BA6F RID: 178799 RVA: 0x00602230 File Offset: 0x00600430
		public IControlElementalBoxCapture CtrlConfigAsIControlElementalBoxCapture()
		{
			return this.CtrlConfig<IControlElementalBoxCapture>().Value;
		}

		// Token: 0x0602BA70 RID: 178800 RVA: 0x0060224C File Offset: 0x0060044C
		public IControlElementalBoxReturn CtrlConfigAsIControlElementalBoxReturn()
		{
			return this.CtrlConfig<IControlElementalBoxReturn>().Value;
		}

		// Token: 0x1700BC95 RID: 48277
		// (get) Token: 0x0602BA71 RID: 178801 RVA: 0x00602268 File Offset: 0x00600468
		public TElementalBoxTargetPosType TargetPosConfigType
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return TElementalBoxTargetPosType.NONE;
				}
				return (TElementalBoxTargetPosType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602BA72 RID: 178802 RVA: 0x006022A4 File Offset: 0x006004A4
		public TTable? TargetPosConfig<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0602BA73 RID: 178803 RVA: 0x006022EC File Offset: 0x006004EC
		public IElementalBoxTargetPrefabPos TargetPosConfigAsIElementalBoxTargetPrefabPos()
		{
			return this.TargetPosConfig<IElementalBoxTargetPrefabPos>().Value;
		}

		// Token: 0x0602BA74 RID: 178804 RVA: 0x00602308 File Offset: 0x00600508
		public IElementalBoxTargetRelativePos TargetPosConfigAsIElementalBoxTargetRelativePos()
		{
			return this.TargetPosConfig<IElementalBoxTargetRelativePos>().Value;
		}

		// Token: 0x1700BC96 RID: 48278
		// (get) Token: 0x0602BA75 RID: 178805 RVA: 0x00602324 File Offset: 0x00600524
		public float MoveSpeed
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602BA76 RID: 178806 RVA: 0x00602365 File Offset: 0x00600565
		public static Offset<ICaptureElementalBox> CreateICaptureElementalBox(FlatBufferBuilder builder, TControlElementalBoxType CtrlConfig_type = TControlElementalBoxType.NONE, int CtrlConfigOffset = 0, TElementalBoxTargetPosType TargetPosConfig_type = TElementalBoxTargetPosType.NONE, int TargetPosConfigOffset = 0, float MoveSpeed = 0f)
		{
			builder.StartTable(5);
			ICaptureElementalBox.AddMoveSpeed(builder, MoveSpeed);
			ICaptureElementalBox.AddTargetPosConfig(builder, TargetPosConfigOffset);
			ICaptureElementalBox.AddCtrlConfig(builder, CtrlConfigOffset);
			ICaptureElementalBox.AddTargetPosConfigType(builder, TargetPosConfig_type);
			ICaptureElementalBox.AddCtrlConfigType(builder, CtrlConfig_type);
			return ICaptureElementalBox.EndICaptureElementalBox(builder);
		}

		// Token: 0x0602BA77 RID: 178807 RVA: 0x00602399 File Offset: 0x00600599
		public static void StartICaptureElementalBox(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x0602BA78 RID: 178808 RVA: 0x006023A2 File Offset: 0x006005A2
		public static void AddCtrlConfigType(FlatBufferBuilder builder, TControlElementalBoxType ctrlConfigType)
		{
			builder.AddByte(0, (byte)ctrlConfigType, 0);
		}

		// Token: 0x0602BA79 RID: 178809 RVA: 0x006023AD File Offset: 0x006005AD
		public static void AddCtrlConfig(FlatBufferBuilder builder, int ctrlConfigOffset)
		{
			builder.AddOffset(1, ctrlConfigOffset, 0);
		}

		// Token: 0x0602BA7A RID: 178810 RVA: 0x006023B8 File Offset: 0x006005B8
		public static void AddTargetPosConfigType(FlatBufferBuilder builder, TElementalBoxTargetPosType targetPosConfigType)
		{
			builder.AddByte(2, (byte)targetPosConfigType, 0);
		}

		// Token: 0x0602BA7B RID: 178811 RVA: 0x006023C3 File Offset: 0x006005C3
		public static void AddTargetPosConfig(FlatBufferBuilder builder, int targetPosConfigOffset)
		{
			builder.AddOffset(3, targetPosConfigOffset, 0);
		}

		// Token: 0x0602BA7C RID: 178812 RVA: 0x006023CE File Offset: 0x006005CE
		public static void AddMoveSpeed(FlatBufferBuilder builder, float moveSpeed)
		{
			builder.AddFloat(4, moveSpeed, 0.0);
		}

		// Token: 0x0602BA7D RID: 178813 RVA: 0x006023E1 File Offset: 0x006005E1
		public static Offset<ICaptureElementalBox> EndICaptureElementalBox(FlatBufferBuilder builder)
		{
			return new Offset<ICaptureElementalBox>(builder.EndTable());
		}

		// Token: 0x0602BA7E RID: 178814 RVA: 0x006023F0 File Offset: 0x006005F0
		public ICaptureElementalBoxT UnPack()
		{
			ICaptureElementalBoxT captureElementalBoxT = new ICaptureElementalBoxT();
			this.UnPackTo(captureElementalBoxT);
			return captureElementalBoxT;
		}

		// Token: 0x0602BA7F RID: 178815 RVA: 0x0060240C File Offset: 0x0060060C
		public void UnPackTo(ICaptureElementalBoxT _o)
		{
			_o.CtrlConfig = new TControlElementalBoxTypeUnion();
			_o.CtrlConfig.Type = this.CtrlConfigType;
			TControlElementalBoxType ctrlConfigType = this.CtrlConfigType;
			if (ctrlConfigType != TControlElementalBoxType.IControlElementalBoxCapture)
			{
				if (ctrlConfigType == TControlElementalBoxType.IControlElementalBoxReturn)
				{
					_o.CtrlConfig.Value = ((this.CtrlConfig<IControlElementalBoxReturn>() != null) ? this.CtrlConfig<IControlElementalBoxReturn>().Value.UnPack() : null);
				}
			}
			else
			{
				_o.CtrlConfig.Value = ((this.CtrlConfig<IControlElementalBoxCapture>() != null) ? this.CtrlConfig<IControlElementalBoxCapture>().Value.UnPack() : null);
			}
			_o.TargetPosConfig = new TElementalBoxTargetPosTypeUnion();
			_o.TargetPosConfig.Type = this.TargetPosConfigType;
			TElementalBoxTargetPosType targetPosConfigType = this.TargetPosConfigType;
			if (targetPosConfigType != TElementalBoxTargetPosType.IElementalBoxTargetPrefabPos)
			{
				if (targetPosConfigType == TElementalBoxTargetPosType.IElementalBoxTargetRelativePos)
				{
					_o.TargetPosConfig.Value = ((this.TargetPosConfig<IElementalBoxTargetRelativePos>() != null) ? this.TargetPosConfig<IElementalBoxTargetRelativePos>().Value.UnPack() : null);
				}
			}
			else
			{
				_o.TargetPosConfig.Value = ((this.TargetPosConfig<IElementalBoxTargetPrefabPos>() != null) ? this.TargetPosConfig<IElementalBoxTargetPrefabPos>().Value.UnPack() : null);
			}
			_o.MoveSpeed = this.MoveSpeed;
		}

		// Token: 0x0602BA80 RID: 178816 RVA: 0x00602560 File Offset: 0x00600760
		public static Offset<ICaptureElementalBox> Pack(FlatBufferBuilder builder, ICaptureElementalBoxT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICaptureElementalBox>);
			}
			TControlElementalBoxType ctrlConfig_type = (_o.CtrlConfig == null) ? TControlElementalBoxType.NONE : _o.CtrlConfig.Type;
			int ctrlConfigOffset = (_o.CtrlConfig == null) ? 0 : TControlElementalBoxTypeUnion.Pack(builder, _o.CtrlConfig);
			TElementalBoxTargetPosType targetPosConfig_type = (_o.TargetPosConfig == null) ? TElementalBoxTargetPosType.NONE : _o.TargetPosConfig.Type;
			int targetPosConfigOffset = (_o.TargetPosConfig == null) ? 0 : TElementalBoxTargetPosTypeUnion.Pack(builder, _o.TargetPosConfig);
			return ICaptureElementalBox.CreateICaptureElementalBox(builder, ctrlConfig_type, ctrlConfigOffset, targetPosConfig_type, targetPosConfigOffset, _o.MoveSpeed);
		}

		// Token: 0x0401084B RID: 67659
		private Table __p;
	}
}
