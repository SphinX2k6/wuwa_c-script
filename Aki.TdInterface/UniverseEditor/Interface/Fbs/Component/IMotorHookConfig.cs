using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020055B7 RID: 21943
	public struct IMotorHookConfig : IFlatbufferObject
	{
		// Token: 0x1700A220 RID: 41504
		// (get) Token: 0x06024579 RID: 148857 RVA: 0x00504435 File Offset: 0x00502635
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602457A RID: 148858 RVA: 0x00504442 File Offset: 0x00502642
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602457B RID: 148859 RVA: 0x0050444C File Offset: 0x0050264C
		public static IMotorHookConfig GetRootAsIMotorHookConfig(ByteBuffer _bb)
		{
			return IMotorHookConfig.GetRootAsIMotorHookConfig(_bb, default(IMotorHookConfig));
		}

		// Token: 0x0602457C RID: 148860 RVA: 0x00504468 File Offset: 0x00502668
		public static IMotorHookConfig GetRootAsIMotorHookConfig(ByteBuffer _bb, IMotorHookConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602457D RID: 148861 RVA: 0x00504485 File Offset: 0x00502685
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602457E RID: 148862 RVA: 0x00504494 File Offset: 0x00502694
		public IMotorHookConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A221 RID: 41505
		// (get) Token: 0x0602457F RID: 148863 RVA: 0x005044A4 File Offset: 0x005026A4
		public IFaceToTargetMotorInteractConstraint? InteractConstraint
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return new IFaceToTargetMotorInteractConstraint?(default(IFaceToTargetMotorInteractConstraint).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700A222 RID: 41506
		// (get) Token: 0x06024580 RID: 148864 RVA: 0x00504504 File Offset: 0x00502704
		public float Radius
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

		// Token: 0x1700A223 RID: 41507
		// (get) Token: 0x06024581 RID: 148865 RVA: 0x00504544 File Offset: 0x00502744
		public float NonInteractiveInnerRadius
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700A224 RID: 41508
		// (get) Token: 0x06024582 RID: 148866 RVA: 0x00504584 File Offset: 0x00502784
		public IMotorHookEndDir? HookEndDir
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return new IMotorHookEndDir?(default(IMotorHookEndDir).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700A225 RID: 41509
		// (get) Token: 0x06024583 RID: 148867 RVA: 0x005045E4 File Offset: 0x005027E4
		public IMotorHookAcceleration? MotorHookAcceleration
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return null;
				}
				return new IMotorHookAcceleration?(default(IMotorHookAcceleration).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700A226 RID: 41510
		// (get) Token: 0x06024584 RID: 148868 RVA: 0x00504644 File Offset: 0x00502844
		public THookLockScreenDetectType ScreenDetectTypeType
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return THookLockScreenDetectType.NONE;
				}
				return (THookLockScreenDetectType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06024585 RID: 148869 RVA: 0x00504684 File Offset: 0x00502884
		public TTable? ScreenDetectType<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06024586 RID: 148870 RVA: 0x005046CC File Offset: 0x005028CC
		public IHookLockScreenDetectTypeCentralEllipse ScreenDetectTypeAsIHookLockScreenDetectTypeCentralEllipse()
		{
			return this.ScreenDetectType<IHookLockScreenDetectTypeCentralEllipse>().Value;
		}

		// Token: 0x06024587 RID: 148871 RVA: 0x005046E8 File Offset: 0x005028E8
		public IHookLockScreenDetectTypeFullScreen ScreenDetectTypeAsIHookLockScreenDetectTypeFullScreen()
		{
			return this.ScreenDetectType<IHookLockScreenDetectTypeFullScreen>().Value;
		}

		// Token: 0x1700A227 RID: 41511
		// (get) Token: 0x06024588 RID: 148872 RVA: 0x00504704 File Offset: 0x00502904
		public bool AutoExit
		{
			get
			{
				int num = this.__p.__offset(18);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700A228 RID: 41512
		// (get) Token: 0x06024589 RID: 148873 RVA: 0x00504744 File Offset: 0x00502944
		public IMotorHookPerformanceConfig? MotorHookPerformanceConfig
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return null;
				}
				return new IMotorHookPerformanceConfig?(default(IMotorHookPerformanceConfig).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700A229 RID: 41513
		// (get) Token: 0x0602458A RID: 148874 RVA: 0x005047A4 File Offset: 0x005029A4
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602458B RID: 148875 RVA: 0x005047E4 File Offset: 0x005029E4
		public static Offset<IMotorHookConfig> CreateIMotorHookConfig(FlatBufferBuilder builder, Offset<IFaceToTargetMotorInteractConstraint> InteractConstraintOffset = default(Offset<IFaceToTargetMotorInteractConstraint>), float Radius = 0f, float NonInteractiveInnerRadius = 0f, Offset<IMotorHookEndDir> HookEndDirOffset = default(Offset<IMotorHookEndDir>), Offset<IMotorHookAcceleration> MotorHookAccelerationOffset = default(Offset<IMotorHookAcceleration>), THookLockScreenDetectType ScreenDetectType_type = THookLockScreenDetectType.NONE, int ScreenDetectTypeOffset = 0, bool AutoExit = false, Offset<IMotorHookPerformanceConfig> MotorHookPerformanceConfigOffset = default(Offset<IMotorHookPerformanceConfig>), byte NullMask = 0)
		{
			builder.StartTable(10);
			IMotorHookConfig.AddMotorHookPerformanceConfig(builder, MotorHookPerformanceConfigOffset);
			IMotorHookConfig.AddScreenDetectType(builder, ScreenDetectTypeOffset);
			IMotorHookConfig.AddMotorHookAcceleration(builder, MotorHookAccelerationOffset);
			IMotorHookConfig.AddHookEndDir(builder, HookEndDirOffset);
			IMotorHookConfig.AddNonInteractiveInnerRadius(builder, NonInteractiveInnerRadius);
			IMotorHookConfig.AddRadius(builder, Radius);
			IMotorHookConfig.AddInteractConstraint(builder, InteractConstraintOffset);
			IMotorHookConfig.AddNullMask(builder, NullMask);
			IMotorHookConfig.AddAutoExit(builder, AutoExit);
			IMotorHookConfig.AddScreenDetectTypeType(builder, ScreenDetectType_type);
			return IMotorHookConfig.EndIMotorHookConfig(builder);
		}

		// Token: 0x0602458C RID: 148876 RVA: 0x0050484C File Offset: 0x00502A4C
		public static void StartIMotorHookConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(10);
		}

		// Token: 0x0602458D RID: 148877 RVA: 0x00504856 File Offset: 0x00502A56
		public static void AddInteractConstraint(FlatBufferBuilder builder, Offset<IFaceToTargetMotorInteractConstraint> interactConstraintOffset)
		{
			builder.AddOffset(0, interactConstraintOffset.Value, 0);
		}

		// Token: 0x0602458E RID: 148878 RVA: 0x00504866 File Offset: 0x00502A66
		public static void AddRadius(FlatBufferBuilder builder, float radius)
		{
			builder.AddFloat(1, radius, 0.0);
		}

		// Token: 0x0602458F RID: 148879 RVA: 0x00504879 File Offset: 0x00502A79
		public static void AddNonInteractiveInnerRadius(FlatBufferBuilder builder, float nonInteractiveInnerRadius)
		{
			builder.AddFloat(2, nonInteractiveInnerRadius, 0.0);
		}

		// Token: 0x06024590 RID: 148880 RVA: 0x0050488C File Offset: 0x00502A8C
		public static void AddHookEndDir(FlatBufferBuilder builder, Offset<IMotorHookEndDir> hookEndDirOffset)
		{
			builder.AddOffset(3, hookEndDirOffset.Value, 0);
		}

		// Token: 0x06024591 RID: 148881 RVA: 0x0050489C File Offset: 0x00502A9C
		public static void AddMotorHookAcceleration(FlatBufferBuilder builder, Offset<IMotorHookAcceleration> motorHookAccelerationOffset)
		{
			builder.AddOffset(4, motorHookAccelerationOffset.Value, 0);
		}

		// Token: 0x06024592 RID: 148882 RVA: 0x005048AC File Offset: 0x00502AAC
		public static void AddScreenDetectTypeType(FlatBufferBuilder builder, THookLockScreenDetectType screenDetectTypeType)
		{
			builder.AddByte(5, (byte)screenDetectTypeType, 0);
		}

		// Token: 0x06024593 RID: 148883 RVA: 0x005048B7 File Offset: 0x00502AB7
		public static void AddScreenDetectType(FlatBufferBuilder builder, int screenDetectTypeOffset)
		{
			builder.AddOffset(6, screenDetectTypeOffset, 0);
		}

		// Token: 0x06024594 RID: 148884 RVA: 0x005048C2 File Offset: 0x00502AC2
		public static void AddAutoExit(FlatBufferBuilder builder, bool autoExit)
		{
			builder.AddBool(7, autoExit, false);
		}

		// Token: 0x06024595 RID: 148885 RVA: 0x005048CD File Offset: 0x00502ACD
		public static void AddMotorHookPerformanceConfig(FlatBufferBuilder builder, Offset<IMotorHookPerformanceConfig> motorHookPerformanceConfigOffset)
		{
			builder.AddOffset(8, motorHookPerformanceConfigOffset.Value, 0);
		}

		// Token: 0x06024596 RID: 148886 RVA: 0x005048DD File Offset: 0x00502ADD
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(9, nullMask, 0);
		}

		// Token: 0x06024597 RID: 148887 RVA: 0x005048E9 File Offset: 0x00502AE9
		public static Offset<IMotorHookConfig> EndIMotorHookConfig(FlatBufferBuilder builder)
		{
			return new Offset<IMotorHookConfig>(builder.EndTable());
		}

		// Token: 0x06024598 RID: 148888 RVA: 0x005048F8 File Offset: 0x00502AF8
		public IMotorHookConfigT UnPack()
		{
			IMotorHookConfigT motorHookConfigT = new IMotorHookConfigT();
			this.UnPackTo(motorHookConfigT);
			return motorHookConfigT;
		}

		// Token: 0x06024599 RID: 148889 RVA: 0x00504914 File Offset: 0x00502B14
		public void UnPackTo(IMotorHookConfigT _o)
		{
			_o.InteractConstraint = ((this.InteractConstraint != null) ? this.InteractConstraint.Value.UnPack() : null);
			_o.Radius = this.Radius;
			_o.NonInteractiveInnerRadius = this.NonInteractiveInnerRadius;
			_o.HookEndDir = ((this.HookEndDir != null) ? this.HookEndDir.Value.UnPack() : null);
			_o.MotorHookAcceleration = ((this.MotorHookAcceleration != null) ? this.MotorHookAcceleration.Value.UnPack() : null);
			_o.ScreenDetectType = new THookLockScreenDetectTypeUnion();
			_o.ScreenDetectType.Type = this.ScreenDetectTypeType;
			THookLockScreenDetectType screenDetectTypeType = this.ScreenDetectTypeType;
			if (screenDetectTypeType != THookLockScreenDetectType.IHookLockScreenDetectTypeCentralEllipse)
			{
				if (screenDetectTypeType == THookLockScreenDetectType.IHookLockScreenDetectTypeFullScreen)
				{
					_o.ScreenDetectType.Value = ((this.ScreenDetectType<IHookLockScreenDetectTypeFullScreen>() != null) ? this.ScreenDetectType<IHookLockScreenDetectTypeFullScreen>().Value.UnPack() : null);
				}
			}
			else
			{
				_o.ScreenDetectType.Value = ((this.ScreenDetectType<IHookLockScreenDetectTypeCentralEllipse>() != null) ? this.ScreenDetectType<IHookLockScreenDetectTypeCentralEllipse>().Value.UnPack() : null);
			}
			_o.AutoExit = this.AutoExit;
			_o.MotorHookPerformanceConfig = ((this.MotorHookPerformanceConfig != null) ? this.MotorHookPerformanceConfig.Value.UnPack() : null);
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602459A RID: 148890 RVA: 0x00504AB4 File Offset: 0x00502CB4
		public static Offset<IMotorHookConfig> Pack(FlatBufferBuilder builder, IMotorHookConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IMotorHookConfig>);
			}
			Offset<IFaceToTargetMotorInteractConstraint> interactConstraintOffset = (_o.InteractConstraint == null) ? default(Offset<IFaceToTargetMotorInteractConstraint>) : IFaceToTargetMotorInteractConstraint.Pack(builder, _o.InteractConstraint);
			Offset<IMotorHookEndDir> hookEndDirOffset = (_o.HookEndDir == null) ? default(Offset<IMotorHookEndDir>) : IMotorHookEndDir.Pack(builder, _o.HookEndDir);
			Offset<IMotorHookAcceleration> motorHookAccelerationOffset = (_o.MotorHookAcceleration == null) ? default(Offset<IMotorHookAcceleration>) : IMotorHookAcceleration.Pack(builder, _o.MotorHookAcceleration);
			THookLockScreenDetectType screenDetectType_type = (_o.ScreenDetectType == null) ? THookLockScreenDetectType.NONE : _o.ScreenDetectType.Type;
			int screenDetectTypeOffset = (_o.ScreenDetectType == null) ? 0 : THookLockScreenDetectTypeUnion.Pack(builder, _o.ScreenDetectType);
			Offset<IMotorHookPerformanceConfig> motorHookPerformanceConfigOffset = (_o.MotorHookPerformanceConfig == null) ? default(Offset<IMotorHookPerformanceConfig>) : IMotorHookPerformanceConfig.Pack(builder, _o.MotorHookPerformanceConfig);
			return IMotorHookConfig.CreateIMotorHookConfig(builder, interactConstraintOffset, _o.Radius, _o.NonInteractiveInnerRadius, hookEndDirOffset, motorHookAccelerationOffset, screenDetectType_type, screenDetectTypeOffset, _o.AutoExit, motorHookPerformanceConfigOffset, _o.NullMask);
		}

		// Token: 0x0400E8F7 RID: 59639
		private Table __p;
	}
}
