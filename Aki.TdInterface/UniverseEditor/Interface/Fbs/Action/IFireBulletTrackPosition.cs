using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020067B9 RID: 26553
	public struct IFireBulletTrackPosition : IFlatbufferObject
	{
		// Token: 0x1700C517 RID: 50455
		// (get) Token: 0x0602E364 RID: 189284 RVA: 0x0064F920 File Offset: 0x0064DB20
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602E365 RID: 189285 RVA: 0x0064F92D File Offset: 0x0064DB2D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602E366 RID: 189286 RVA: 0x0064F934 File Offset: 0x0064DB34
		public static IFireBulletTrackPosition GetRootAsIFireBulletTrackPosition(ByteBuffer _bb)
		{
			return IFireBulletTrackPosition.GetRootAsIFireBulletTrackPosition(_bb, default(IFireBulletTrackPosition));
		}

		// Token: 0x0602E367 RID: 189287 RVA: 0x0064F950 File Offset: 0x0064DB50
		public static IFireBulletTrackPosition GetRootAsIFireBulletTrackPosition(ByteBuffer _bb, IFireBulletTrackPosition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602E368 RID: 189288 RVA: 0x0064F96D File Offset: 0x0064DB6D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602E369 RID: 189289 RVA: 0x0064F97C File Offset: 0x0064DB7C
		public IFireBulletTrackPosition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C518 RID: 50456
		// (get) Token: 0x0602E36A RID: 189290 RVA: 0x0064F98C File Offset: 0x0064DB8C
		public EFireBulletType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EFireBulletType.TrackTarget;
				}
				return (EFireBulletType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700C519 RID: 50457
		// (get) Token: 0x0602E36B RID: 189291 RVA: 0x0064F9C8 File Offset: 0x0064DBC8
		public long BulletId
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0L;
				}
				return this.__p.bb.GetLong(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700C51A RID: 50458
		// (get) Token: 0x0602E36C RID: 189292 RVA: 0x0064FA08 File Offset: 0x0064DC08
		public TTargetEntity LauncherType
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return TTargetEntity.NONE;
				}
				return (TTargetEntity)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602E36D RID: 189293 RVA: 0x0064FA44 File Offset: 0x0064DC44
		public TTable? Launcher<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0602E36E RID: 189294 RVA: 0x0064FA8C File Offset: 0x0064DC8C
		public IPlayerEntity LauncherAsIPlayerEntity()
		{
			return this.Launcher<IPlayerEntity>().Value;
		}

		// Token: 0x0602E36F RID: 189295 RVA: 0x0064FAA8 File Offset: 0x0064DCA8
		public ISelfEntity LauncherAsISelfEntity()
		{
			return this.Launcher<ISelfEntity>().Value;
		}

		// Token: 0x0602E370 RID: 189296 RVA: 0x0064FAC4 File Offset: 0x0064DCC4
		public ITargetEntity LauncherAsITargetEntity()
		{
			return this.Launcher<ITargetEntity>().Value;
		}

		// Token: 0x0602E371 RID: 189297 RVA: 0x0064FAE0 File Offset: 0x0064DCE0
		public ITriggeredEntity LauncherAsITriggeredEntity()
		{
			return this.Launcher<ITriggeredEntity>().Value;
		}

		// Token: 0x0602E372 RID: 189298 RVA: 0x0064FAFC File Offset: 0x0064DCFC
		public IVehicleEntity LauncherAsIVehicleEntity()
		{
			return this.Launcher<IVehicleEntity>().Value;
		}

		// Token: 0x1700C51B RID: 50459
		// (get) Token: 0x0602E373 RID: 189299 RVA: 0x0064FB18 File Offset: 0x0064DD18
		public int PositionEntityId
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602E374 RID: 189300 RVA: 0x0064FB55 File Offset: 0x0064DD55
		public static Offset<IFireBulletTrackPosition> CreateIFireBulletTrackPosition(FlatBufferBuilder builder, EFireBulletType Type = EFireBulletType.TrackTarget, long BulletId = 0L, TTargetEntity Launcher_type = TTargetEntity.NONE, int LauncherOffset = 0, int PositionEntityId = 0)
		{
			builder.StartTable(5);
			IFireBulletTrackPosition.AddBulletId(builder, BulletId);
			IFireBulletTrackPosition.AddPositionEntityId(builder, PositionEntityId);
			IFireBulletTrackPosition.AddLauncher(builder, LauncherOffset);
			IFireBulletTrackPosition.AddLauncherType(builder, Launcher_type);
			IFireBulletTrackPosition.AddType(builder, Type);
			return IFireBulletTrackPosition.EndIFireBulletTrackPosition(builder);
		}

		// Token: 0x0602E375 RID: 189301 RVA: 0x0064FB89 File Offset: 0x0064DD89
		public static void StartIFireBulletTrackPosition(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x0602E376 RID: 189302 RVA: 0x0064FB92 File Offset: 0x0064DD92
		public static void AddType(FlatBufferBuilder builder, EFireBulletType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602E377 RID: 189303 RVA: 0x0064FB9D File Offset: 0x0064DD9D
		public static void AddBulletId(FlatBufferBuilder builder, long bulletId)
		{
			builder.AddLong(1, bulletId, 0L);
		}

		// Token: 0x0602E378 RID: 189304 RVA: 0x0064FBA9 File Offset: 0x0064DDA9
		public static void AddLauncherType(FlatBufferBuilder builder, TTargetEntity launcherType)
		{
			builder.AddByte(2, (byte)launcherType, 0);
		}

		// Token: 0x0602E379 RID: 189305 RVA: 0x0064FBB4 File Offset: 0x0064DDB4
		public static void AddLauncher(FlatBufferBuilder builder, int launcherOffset)
		{
			builder.AddOffset(3, launcherOffset, 0);
		}

		// Token: 0x0602E37A RID: 189306 RVA: 0x0064FBBF File Offset: 0x0064DDBF
		public static void AddPositionEntityId(FlatBufferBuilder builder, int positionEntityId)
		{
			builder.AddInt(4, positionEntityId, 0);
		}

		// Token: 0x0602E37B RID: 189307 RVA: 0x0064FBCA File Offset: 0x0064DDCA
		public static Offset<IFireBulletTrackPosition> EndIFireBulletTrackPosition(FlatBufferBuilder builder)
		{
			return new Offset<IFireBulletTrackPosition>(builder.EndTable());
		}

		// Token: 0x0602E37C RID: 189308 RVA: 0x0064FBD8 File Offset: 0x0064DDD8
		public IFireBulletTrackPositionT UnPack()
		{
			IFireBulletTrackPositionT fireBulletTrackPositionT = new IFireBulletTrackPositionT();
			this.UnPackTo(fireBulletTrackPositionT);
			return fireBulletTrackPositionT;
		}

		// Token: 0x0602E37D RID: 189309 RVA: 0x0064FBF4 File Offset: 0x0064DDF4
		public void UnPackTo(IFireBulletTrackPositionT _o)
		{
			_o.Type = this.Type;
			_o.BulletId = this.BulletId;
			_o.Launcher = new TTargetEntityUnion();
			_o.Launcher.Type = this.LauncherType;
			switch (this.LauncherType)
			{
			case TTargetEntity.IPlayerEntity:
				_o.Launcher.Value = ((this.Launcher<IPlayerEntity>() != null) ? this.Launcher<IPlayerEntity>().Value.UnPack() : null);
				break;
			case TTargetEntity.ISelfEntity:
				_o.Launcher.Value = ((this.Launcher<ISelfEntity>() != null) ? this.Launcher<ISelfEntity>().Value.UnPack() : null);
				break;
			case TTargetEntity.ITargetEntity:
				_o.Launcher.Value = ((this.Launcher<ITargetEntity>() != null) ? this.Launcher<ITargetEntity>().Value.UnPack() : null);
				break;
			case TTargetEntity.ITriggeredEntity:
				_o.Launcher.Value = ((this.Launcher<ITriggeredEntity>() != null) ? this.Launcher<ITriggeredEntity>().Value.UnPack() : null);
				break;
			case TTargetEntity.IVehicleEntity:
				_o.Launcher.Value = ((this.Launcher<IVehicleEntity>() != null) ? this.Launcher<IVehicleEntity>().Value.UnPack() : null);
				break;
			}
			_o.PositionEntityId = this.PositionEntityId;
		}

		// Token: 0x0602E37E RID: 189310 RVA: 0x0064FD88 File Offset: 0x0064DF88
		public static Offset<IFireBulletTrackPosition> Pack(FlatBufferBuilder builder, IFireBulletTrackPositionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFireBulletTrackPosition>);
			}
			TTargetEntity launcher_type = (_o.Launcher == null) ? TTargetEntity.NONE : _o.Launcher.Type;
			int launcherOffset = (_o.Launcher == null) ? 0 : TTargetEntityUnion.Pack(builder, _o.Launcher);
			return IFireBulletTrackPosition.CreateIFireBulletTrackPosition(builder, _o.Type, _o.BulletId, launcher_type, launcherOffset, _o.PositionEntityId);
		}

		// Token: 0x04010EC9 RID: 69321
		private Table __p;
	}
}
