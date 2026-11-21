using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200691F RID: 26911
	public struct ICaptureElementalBox : IFlatbufferObject
	{
		// Token: 0x1700C61B RID: 50715
		// (get) Token: 0x0602E1C8 RID: 188872 RVA: 0x0064CF4C File Offset: 0x0064B14C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602E1C9 RID: 188873 RVA: 0x0064CF59 File Offset: 0x0064B159
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602E1CA RID: 188874 RVA: 0x0064CF60 File Offset: 0x0064B160
		public static ICaptureElementalBox GetRootAsICaptureElementalBox(ByteBuffer _bb)
		{
			return ICaptureElementalBox.GetRootAsICaptureElementalBox(_bb, default(ICaptureElementalBox));
		}

		// Token: 0x0602E1CB RID: 188875 RVA: 0x0064CF7C File Offset: 0x0064B17C
		public static ICaptureElementalBox GetRootAsICaptureElementalBox(ByteBuffer _bb, ICaptureElementalBox obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602E1CC RID: 188876 RVA: 0x0064CF99 File Offset: 0x0064B199
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602E1CD RID: 188877 RVA: 0x0064CFA8 File Offset: 0x0064B1A8
		public ICaptureElementalBox __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C61C RID: 50716
		// (get) Token: 0x0602E1CE RID: 188878 RVA: 0x0064CFB8 File Offset: 0x0064B1B8
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

		// Token: 0x0602E1CF RID: 188879 RVA: 0x0064CFF4 File Offset: 0x0064B1F4
		public TTable? CtrlConfig<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0602E1D0 RID: 188880 RVA: 0x0064D038 File Offset: 0x0064B238
		public IControlElementalBoxCapture CtrlConfigAsIControlElementalBoxCapture()
		{
			return this.CtrlConfig<IControlElementalBoxCapture>().Value;
		}

		// Token: 0x0602E1D1 RID: 188881 RVA: 0x0064D054 File Offset: 0x0064B254
		public IControlElementalBoxReturn CtrlConfigAsIControlElementalBoxReturn()
		{
			return this.CtrlConfig<IControlElementalBoxReturn>().Value;
		}

		// Token: 0x1700C61D RID: 50717
		// (get) Token: 0x0602E1D2 RID: 188882 RVA: 0x0064D070 File Offset: 0x0064B270
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

		// Token: 0x0602E1D3 RID: 188883 RVA: 0x0064D0AC File Offset: 0x0064B2AC
		public TTable? TargetPosConfig<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0602E1D4 RID: 188884 RVA: 0x0064D0F4 File Offset: 0x0064B2F4
		public IElementalBoxTargetPrefabPos TargetPosConfigAsIElementalBoxTargetPrefabPos()
		{
			return this.TargetPosConfig<IElementalBoxTargetPrefabPos>().Value;
		}

		// Token: 0x0602E1D5 RID: 188885 RVA: 0x0064D110 File Offset: 0x0064B310
		public IElementalBoxTargetRelativePos TargetPosConfigAsIElementalBoxTargetRelativePos()
		{
			return this.TargetPosConfig<IElementalBoxTargetRelativePos>().Value;
		}

		// Token: 0x1700C61E RID: 50718
		// (get) Token: 0x0602E1D6 RID: 188886 RVA: 0x0064D12C File Offset: 0x0064B32C
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

		// Token: 0x0602E1D7 RID: 188887 RVA: 0x0064D16D File Offset: 0x0064B36D
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

		// Token: 0x0602E1D8 RID: 188888 RVA: 0x0064D1A1 File Offset: 0x0064B3A1
		public static void StartICaptureElementalBox(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x0602E1D9 RID: 188889 RVA: 0x0064D1AA File Offset: 0x0064B3AA
		public static void AddCtrlConfigType(FlatBufferBuilder builder, TControlElementalBoxType ctrlConfigType)
		{
			builder.AddByte(0, (byte)ctrlConfigType, 0);
		}

		// Token: 0x0602E1DA RID: 188890 RVA: 0x0064D1B5 File Offset: 0x0064B3B5
		public static void AddCtrlConfig(FlatBufferBuilder builder, int ctrlConfigOffset)
		{
			builder.AddOffset(1, ctrlConfigOffset, 0);
		}

		// Token: 0x0602E1DB RID: 188891 RVA: 0x0064D1C0 File Offset: 0x0064B3C0
		public static void AddTargetPosConfigType(FlatBufferBuilder builder, TElementalBoxTargetPosType targetPosConfigType)
		{
			builder.AddByte(2, (byte)targetPosConfigType, 0);
		}

		// Token: 0x0602E1DC RID: 188892 RVA: 0x0064D1CB File Offset: 0x0064B3CB
		public static void AddTargetPosConfig(FlatBufferBuilder builder, int targetPosConfigOffset)
		{
			builder.AddOffset(3, targetPosConfigOffset, 0);
		}

		// Token: 0x0602E1DD RID: 188893 RVA: 0x0064D1D6 File Offset: 0x0064B3D6
		public static void AddMoveSpeed(FlatBufferBuilder builder, float moveSpeed)
		{
			builder.AddFloat(4, moveSpeed, 0.0);
		}

		// Token: 0x0602E1DE RID: 188894 RVA: 0x0064D1E9 File Offset: 0x0064B3E9
		public static Offset<ICaptureElementalBox> EndICaptureElementalBox(FlatBufferBuilder builder)
		{
			return new Offset<ICaptureElementalBox>(builder.EndTable());
		}

		// Token: 0x0602E1DF RID: 188895 RVA: 0x0064D1F8 File Offset: 0x0064B3F8
		public ICaptureElementalBoxT UnPack()
		{
			ICaptureElementalBoxT captureElementalBoxT = new ICaptureElementalBoxT();
			this.UnPackTo(captureElementalBoxT);
			return captureElementalBoxT;
		}

		// Token: 0x0602E1E0 RID: 188896 RVA: 0x0064D214 File Offset: 0x0064B414
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

		// Token: 0x0602E1E1 RID: 188897 RVA: 0x0064D368 File Offset: 0x0064B568
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

		// Token: 0x04011660 RID: 71264
		private Table __p;
	}
}
