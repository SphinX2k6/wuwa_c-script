using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020058CA RID: 22730
	public struct ISceneItemMovementComponent : IFlatbufferObject
	{
		// Token: 0x1700AA32 RID: 43570
		// (get) Token: 0x060265C0 RID: 157120 RVA: 0x00549522 File Offset: 0x00547722
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060265C1 RID: 157121 RVA: 0x0054952F File Offset: 0x0054772F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060265C2 RID: 157122 RVA: 0x00549538 File Offset: 0x00547738
		public static ISceneItemMovementComponent GetRootAsISceneItemMovementComponent(ByteBuffer _bb)
		{
			return ISceneItemMovementComponent.GetRootAsISceneItemMovementComponent(_bb, default(ISceneItemMovementComponent));
		}

		// Token: 0x060265C3 RID: 157123 RVA: 0x00549554 File Offset: 0x00547754
		public static ISceneItemMovementComponent GetRootAsISceneItemMovementComponent(ByteBuffer _bb, ISceneItemMovementComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060265C4 RID: 157124 RVA: 0x00549571 File Offset: 0x00547771
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060265C5 RID: 157125 RVA: 0x00549580 File Offset: 0x00547780
		public ISceneItemMovementComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700AA33 RID: 43571
		// (get) Token: 0x060265C6 RID: 157126 RVA: 0x00549590 File Offset: 0x00547790
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700AA34 RID: 43572
		// (get) Token: 0x060265C7 RID: 157127 RVA: 0x005495D0 File Offset: 0x005477D0
		public ISplineMove? Patrol
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new ISplineMove?(default(ISplineMove).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700AA35 RID: 43573
		// (get) Token: 0x060265C8 RID: 157128 RVA: 0x00549630 File Offset: 0x00547830
		public IMovementPlatformConfig? PlatformConfig
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return new IMovementPlatformConfig?(default(IMovementPlatformConfig).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700AA36 RID: 43574
		// (get) Token: 0x060265C9 RID: 157129 RVA: 0x00549690 File Offset: 0x00547890
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

		// Token: 0x060265CA RID: 157130 RVA: 0x005496CD File Offset: 0x005478CD
		public static Offset<ISceneItemMovementComponent> CreateISceneItemMovementComponent(FlatBufferBuilder builder, bool Disabled = false, Offset<ISplineMove> PatrolOffset = default(Offset<ISplineMove>), Offset<IMovementPlatformConfig> PlatformConfigOffset = default(Offset<IMovementPlatformConfig>), byte NullMask = 0)
		{
			builder.StartTable(4);
			ISceneItemMovementComponent.AddPlatformConfig(builder, PlatformConfigOffset);
			ISceneItemMovementComponent.AddPatrol(builder, PatrolOffset);
			ISceneItemMovementComponent.AddNullMask(builder, NullMask);
			ISceneItemMovementComponent.AddDisabled(builder, Disabled);
			return ISceneItemMovementComponent.EndISceneItemMovementComponent(builder);
		}

		// Token: 0x060265CB RID: 157131 RVA: 0x005496F9 File Offset: 0x005478F9
		public static void StartISceneItemMovementComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x060265CC RID: 157132 RVA: 0x00549702 File Offset: 0x00547902
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x060265CD RID: 157133 RVA: 0x0054970D File Offset: 0x0054790D
		public static void AddPatrol(FlatBufferBuilder builder, Offset<ISplineMove> patrolOffset)
		{
			builder.AddOffset(1, patrolOffset.Value, 0);
		}

		// Token: 0x060265CE RID: 157134 RVA: 0x0054971D File Offset: 0x0054791D
		public static void AddPlatformConfig(FlatBufferBuilder builder, Offset<IMovementPlatformConfig> platformConfigOffset)
		{
			builder.AddOffset(2, platformConfigOffset.Value, 0);
		}

		// Token: 0x060265CF RID: 157135 RVA: 0x0054972D File Offset: 0x0054792D
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x060265D0 RID: 157136 RVA: 0x00549738 File Offset: 0x00547938
		public static Offset<ISceneItemMovementComponent> EndISceneItemMovementComponent(FlatBufferBuilder builder)
		{
			return new Offset<ISceneItemMovementComponent>(builder.EndTable());
		}

		// Token: 0x060265D1 RID: 157137 RVA: 0x00549748 File Offset: 0x00547948
		public ISceneItemMovementComponentT UnPack()
		{
			ISceneItemMovementComponentT sceneItemMovementComponentT = new ISceneItemMovementComponentT();
			this.UnPackTo(sceneItemMovementComponentT);
			return sceneItemMovementComponentT;
		}

		// Token: 0x060265D2 RID: 157138 RVA: 0x00549764 File Offset: 0x00547964
		public void UnPackTo(ISceneItemMovementComponentT _o)
		{
			_o.Disabled = this.Disabled;
			_o.Patrol = ((this.Patrol != null) ? this.Patrol.Value.UnPack() : null);
			_o.PlatformConfig = ((this.PlatformConfig != null) ? this.PlatformConfig.Value.UnPack() : null);
			_o.NullMask = this.NullMask;
		}

		// Token: 0x060265D3 RID: 157139 RVA: 0x005497E8 File Offset: 0x005479E8
		public static Offset<ISceneItemMovementComponent> Pack(FlatBufferBuilder builder, ISceneItemMovementComponentT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISceneItemMovementComponent>);
			}
			Offset<ISplineMove> patrolOffset = (_o.Patrol == null) ? default(Offset<ISplineMove>) : ISplineMove.Pack(builder, _o.Patrol);
			Offset<IMovementPlatformConfig> platformConfigOffset = (_o.PlatformConfig == null) ? default(Offset<IMovementPlatformConfig>) : IMovementPlatformConfig.Pack(builder, _o.PlatformConfig);
			return ISceneItemMovementComponent.CreateISceneItemMovementComponent(builder, _o.Disabled, patrolOffset, platformConfigOffset, _o.NullMask);
		}

		// Token: 0x0400EE42 RID: 60994
		private Table __p;
	}
}
