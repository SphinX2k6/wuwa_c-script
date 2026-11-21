using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005ED7 RID: 24279
	public struct ISceneItemMovementComponent : IFlatbufferObject
	{
		// Token: 0x1700B362 RID: 45922
		// (get) Token: 0x06028B22 RID: 166690 RVA: 0x0059006E File Offset: 0x0058E26E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06028B23 RID: 166691 RVA: 0x0059007B File Offset: 0x0058E27B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06028B24 RID: 166692 RVA: 0x00590084 File Offset: 0x0058E284
		public static ISceneItemMovementComponent GetRootAsISceneItemMovementComponent(ByteBuffer _bb)
		{
			return ISceneItemMovementComponent.GetRootAsISceneItemMovementComponent(_bb, default(ISceneItemMovementComponent));
		}

		// Token: 0x06028B25 RID: 166693 RVA: 0x005900A0 File Offset: 0x0058E2A0
		public static ISceneItemMovementComponent GetRootAsISceneItemMovementComponent(ByteBuffer _bb, ISceneItemMovementComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06028B26 RID: 166694 RVA: 0x005900BD File Offset: 0x0058E2BD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06028B27 RID: 166695 RVA: 0x005900CC File Offset: 0x0058E2CC
		public ISceneItemMovementComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B363 RID: 45923
		// (get) Token: 0x06028B28 RID: 166696 RVA: 0x005900DC File Offset: 0x0058E2DC
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700B364 RID: 45924
		// (get) Token: 0x06028B29 RID: 166697 RVA: 0x0059011C File Offset: 0x0058E31C
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

		// Token: 0x1700B365 RID: 45925
		// (get) Token: 0x06028B2A RID: 166698 RVA: 0x0059017C File Offset: 0x0058E37C
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

		// Token: 0x1700B366 RID: 45926
		// (get) Token: 0x06028B2B RID: 166699 RVA: 0x005901DC File Offset: 0x0058E3DC
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

		// Token: 0x06028B2C RID: 166700 RVA: 0x00590219 File Offset: 0x0058E419
		public static Offset<ISceneItemMovementComponent> CreateISceneItemMovementComponent(FlatBufferBuilder builder, bool Disabled = false, Offset<ISplineMove> PatrolOffset = default(Offset<ISplineMove>), Offset<IMovementPlatformConfig> PlatformConfigOffset = default(Offset<IMovementPlatformConfig>), byte NullMask = 0)
		{
			builder.StartTable(4);
			ISceneItemMovementComponent.AddPlatformConfig(builder, PlatformConfigOffset);
			ISceneItemMovementComponent.AddPatrol(builder, PatrolOffset);
			ISceneItemMovementComponent.AddNullMask(builder, NullMask);
			ISceneItemMovementComponent.AddDisabled(builder, Disabled);
			return ISceneItemMovementComponent.EndISceneItemMovementComponent(builder);
		}

		// Token: 0x06028B2D RID: 166701 RVA: 0x00590245 File Offset: 0x0058E445
		public static void StartISceneItemMovementComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06028B2E RID: 166702 RVA: 0x0059024E File Offset: 0x0058E44E
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x06028B2F RID: 166703 RVA: 0x00590259 File Offset: 0x0058E459
		public static void AddPatrol(FlatBufferBuilder builder, Offset<ISplineMove> patrolOffset)
		{
			builder.AddOffset(1, patrolOffset.Value, 0);
		}

		// Token: 0x06028B30 RID: 166704 RVA: 0x00590269 File Offset: 0x0058E469
		public static void AddPlatformConfig(FlatBufferBuilder builder, Offset<IMovementPlatformConfig> platformConfigOffset)
		{
			builder.AddOffset(2, platformConfigOffset.Value, 0);
		}

		// Token: 0x06028B31 RID: 166705 RVA: 0x00590279 File Offset: 0x0058E479
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x06028B32 RID: 166706 RVA: 0x00590284 File Offset: 0x0058E484
		public static Offset<ISceneItemMovementComponent> EndISceneItemMovementComponent(FlatBufferBuilder builder)
		{
			return new Offset<ISceneItemMovementComponent>(builder.EndTable());
		}

		// Token: 0x06028B33 RID: 166707 RVA: 0x00590294 File Offset: 0x0058E494
		public ISceneItemMovementComponentT UnPack()
		{
			ISceneItemMovementComponentT sceneItemMovementComponentT = new ISceneItemMovementComponentT();
			this.UnPackTo(sceneItemMovementComponentT);
			return sceneItemMovementComponentT;
		}

		// Token: 0x06028B34 RID: 166708 RVA: 0x005902B0 File Offset: 0x0058E4B0
		public void UnPackTo(ISceneItemMovementComponentT _o)
		{
			_o.Disabled = this.Disabled;
			_o.Patrol = ((this.Patrol != null) ? this.Patrol.Value.UnPack() : null);
			_o.PlatformConfig = ((this.PlatformConfig != null) ? this.PlatformConfig.Value.UnPack() : null);
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06028B35 RID: 166709 RVA: 0x00590334 File Offset: 0x0058E534
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

		// Token: 0x0400FB35 RID: 64309
		private Table __p;
	}
}
