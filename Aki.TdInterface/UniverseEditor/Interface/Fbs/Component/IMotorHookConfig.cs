using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005B55 RID: 23381
	public struct IMotorHookConfig : IFlatbufferObject
	{
		// Token: 0x1700AAA8 RID: 43688
		// (get) Token: 0x06026786 RID: 157574 RVA: 0x005449AD File Offset: 0x00542BAD
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06026787 RID: 157575 RVA: 0x005449BA File Offset: 0x00542BBA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06026788 RID: 157576 RVA: 0x005449C4 File Offset: 0x00542BC4
		public static IMotorHookConfig GetRootAsIMotorHookConfig(ByteBuffer _bb)
		{
			return IMotorHookConfig.GetRootAsIMotorHookConfig(_bb, default(IMotorHookConfig));
		}

		// Token: 0x06026789 RID: 157577 RVA: 0x005449E0 File Offset: 0x00542BE0
		public static IMotorHookConfig GetRootAsIMotorHookConfig(ByteBuffer _bb, IMotorHookConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602678A RID: 157578 RVA: 0x005449FD File Offset: 0x00542BFD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602678B RID: 157579 RVA: 0x00544A0C File Offset: 0x00542C0C
		public IMotorHookConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700AAA9 RID: 43689
		// (get) Token: 0x0602678C RID: 157580 RVA: 0x00544A1C File Offset: 0x00542C1C
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

		// Token: 0x1700AAAA RID: 43690
		// (get) Token: 0x0602678D RID: 157581 RVA: 0x00544A7C File Offset: 0x00542C7C
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

		// Token: 0x1700AAAB RID: 43691
		// (get) Token: 0x0602678E RID: 157582 RVA: 0x00544ABC File Offset: 0x00542CBC
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

		// Token: 0x1700AAAC RID: 43692
		// (get) Token: 0x0602678F RID: 157583 RVA: 0x00544AFC File Offset: 0x00542CFC
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

		// Token: 0x1700AAAD RID: 43693
		// (get) Token: 0x06026790 RID: 157584 RVA: 0x00544B5C File Offset: 0x00542D5C
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

		// Token: 0x1700AAAE RID: 43694
		// (get) Token: 0x06026791 RID: 157585 RVA: 0x00544BBC File Offset: 0x00542DBC
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

		// Token: 0x06026792 RID: 157586 RVA: 0x00544BFC File Offset: 0x00542DFC
		public TTable? ScreenDetectType<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06026793 RID: 157587 RVA: 0x00544C44 File Offset: 0x00542E44
		public IHookLockScreenDetectTypeCentralEllipse ScreenDetectTypeAsIHookLockScreenDetectTypeCentralEllipse()
		{
			return this.ScreenDetectType<IHookLockScreenDetectTypeCentralEllipse>().Value;
		}

		// Token: 0x06026794 RID: 157588 RVA: 0x00544C60 File Offset: 0x00542E60
		public IHookLockScreenDetectTypeFullScreen ScreenDetectTypeAsIHookLockScreenDetectTypeFullScreen()
		{
			return this.ScreenDetectType<IHookLockScreenDetectTypeFullScreen>().Value;
		}

		// Token: 0x1700AAAF RID: 43695
		// (get) Token: 0x06026795 RID: 157589 RVA: 0x00544C7C File Offset: 0x00542E7C
		public bool AutoExit
		{
			get
			{
				int num = this.__p.__offset(18);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700AAB0 RID: 43696
		// (get) Token: 0x06026796 RID: 157590 RVA: 0x00544CBC File Offset: 0x00542EBC
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

		// Token: 0x1700AAB1 RID: 43697
		// (get) Token: 0x06026797 RID: 157591 RVA: 0x00544D1C File Offset: 0x00542F1C
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

		// Token: 0x06026798 RID: 157592 RVA: 0x00544D5C File Offset: 0x00542F5C
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

		// Token: 0x06026799 RID: 157593 RVA: 0x00544DC4 File Offset: 0x00542FC4
		public static void StartIMotorHookConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(10);
		}

		// Token: 0x0602679A RID: 157594 RVA: 0x00544DCE File Offset: 0x00542FCE
		public static void AddInteractConstraint(FlatBufferBuilder builder, Offset<IFaceToTargetMotorInteractConstraint> interactConstraintOffset)
		{
			builder.AddOffset(0, interactConstraintOffset.Value, 0);
		}

		// Token: 0x0602679B RID: 157595 RVA: 0x00544DDE File Offset: 0x00542FDE
		public static void AddRadius(FlatBufferBuilder builder, float radius)
		{
			builder.AddFloat(1, radius, 0.0);
		}

		// Token: 0x0602679C RID: 157596 RVA: 0x00544DF1 File Offset: 0x00542FF1
		public static void AddNonInteractiveInnerRadius(FlatBufferBuilder builder, float nonInteractiveInnerRadius)
		{
			builder.AddFloat(2, nonInteractiveInnerRadius, 0.0);
		}

		// Token: 0x0602679D RID: 157597 RVA: 0x00544E04 File Offset: 0x00543004
		public static void AddHookEndDir(FlatBufferBuilder builder, Offset<IMotorHookEndDir> hookEndDirOffset)
		{
			builder.AddOffset(3, hookEndDirOffset.Value, 0);
		}

		// Token: 0x0602679E RID: 157598 RVA: 0x00544E14 File Offset: 0x00543014
		public static void AddMotorHookAcceleration(FlatBufferBuilder builder, Offset<IMotorHookAcceleration> motorHookAccelerationOffset)
		{
			builder.AddOffset(4, motorHookAccelerationOffset.Value, 0);
		}

		// Token: 0x0602679F RID: 157599 RVA: 0x00544E24 File Offset: 0x00543024
		public static void AddScreenDetectTypeType(FlatBufferBuilder builder, THookLockScreenDetectType screenDetectTypeType)
		{
			builder.AddByte(5, (byte)screenDetectTypeType, 0);
		}

		// Token: 0x060267A0 RID: 157600 RVA: 0x00544E2F File Offset: 0x0054302F
		public static void AddScreenDetectType(FlatBufferBuilder builder, int screenDetectTypeOffset)
		{
			builder.AddOffset(6, screenDetectTypeOffset, 0);
		}

		// Token: 0x060267A1 RID: 157601 RVA: 0x00544E3A File Offset: 0x0054303A
		public static void AddAutoExit(FlatBufferBuilder builder, bool autoExit)
		{
			builder.AddBool(7, autoExit, false);
		}

		// Token: 0x060267A2 RID: 157602 RVA: 0x00544E45 File Offset: 0x00543045
		public static void AddMotorHookPerformanceConfig(FlatBufferBuilder builder, Offset<IMotorHookPerformanceConfig> motorHookPerformanceConfigOffset)
		{
			builder.AddOffset(8, motorHookPerformanceConfigOffset.Value, 0);
		}

		// Token: 0x060267A3 RID: 157603 RVA: 0x00544E55 File Offset: 0x00543055
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(9, nullMask, 0);
		}

		// Token: 0x060267A4 RID: 157604 RVA: 0x00544E61 File Offset: 0x00543061
		public static Offset<IMotorHookConfig> EndIMotorHookConfig(FlatBufferBuilder builder)
		{
			return new Offset<IMotorHookConfig>(builder.EndTable());
		}

		// Token: 0x060267A5 RID: 157605 RVA: 0x00544E70 File Offset: 0x00543070
		public IMotorHookConfigT UnPack()
		{
			IMotorHookConfigT motorHookConfigT = new IMotorHookConfigT();
			this.UnPackTo(motorHookConfigT);
			return motorHookConfigT;
		}

		// Token: 0x060267A6 RID: 157606 RVA: 0x00544E8C File Offset: 0x0054308C
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

		// Token: 0x060267A7 RID: 157607 RVA: 0x0054502C File Offset: 0x0054322C
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

		// Token: 0x0400F559 RID: 62809
		private Table __p;
	}
}
