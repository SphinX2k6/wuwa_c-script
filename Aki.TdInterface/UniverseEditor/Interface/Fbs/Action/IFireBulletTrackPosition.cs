using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006E39 RID: 28217
	public struct IFireBulletTrackPosition : IFlatbufferObject
	{
		// Token: 0x1700CECD RID: 52941
		// (get) Token: 0x06030BAA RID: 199594 RVA: 0x0069D064 File Offset: 0x0069B264
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06030BAB RID: 199595 RVA: 0x0069D071 File Offset: 0x0069B271
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06030BAC RID: 199596 RVA: 0x0069D078 File Offset: 0x0069B278
		public static IFireBulletTrackPosition GetRootAsIFireBulletTrackPosition(ByteBuffer _bb)
		{
			return IFireBulletTrackPosition.GetRootAsIFireBulletTrackPosition(_bb, default(IFireBulletTrackPosition));
		}

		// Token: 0x06030BAD RID: 199597 RVA: 0x0069D094 File Offset: 0x0069B294
		public static IFireBulletTrackPosition GetRootAsIFireBulletTrackPosition(ByteBuffer _bb, IFireBulletTrackPosition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06030BAE RID: 199598 RVA: 0x0069D0B1 File Offset: 0x0069B2B1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06030BAF RID: 199599 RVA: 0x0069D0C0 File Offset: 0x0069B2C0
		public IFireBulletTrackPosition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CECE RID: 52942
		// (get) Token: 0x06030BB0 RID: 199600 RVA: 0x0069D0D0 File Offset: 0x0069B2D0
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

		// Token: 0x1700CECF RID: 52943
		// (get) Token: 0x06030BB1 RID: 199601 RVA: 0x0069D10C File Offset: 0x0069B30C
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

		// Token: 0x1700CED0 RID: 52944
		// (get) Token: 0x06030BB2 RID: 199602 RVA: 0x0069D14C File Offset: 0x0069B34C
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

		// Token: 0x06030BB3 RID: 199603 RVA: 0x0069D188 File Offset: 0x0069B388
		public TTable? Launcher<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06030BB4 RID: 199604 RVA: 0x0069D1D0 File Offset: 0x0069B3D0
		public IPlayerEntity LauncherAsIPlayerEntity()
		{
			return this.Launcher<IPlayerEntity>().Value;
		}

		// Token: 0x06030BB5 RID: 199605 RVA: 0x0069D1EC File Offset: 0x0069B3EC
		public ISelfEntity LauncherAsISelfEntity()
		{
			return this.Launcher<ISelfEntity>().Value;
		}

		// Token: 0x06030BB6 RID: 199606 RVA: 0x0069D208 File Offset: 0x0069B408
		public ITargetEntity LauncherAsITargetEntity()
		{
			return this.Launcher<ITargetEntity>().Value;
		}

		// Token: 0x06030BB7 RID: 199607 RVA: 0x0069D224 File Offset: 0x0069B424
		public ITriggeredEntity LauncherAsITriggeredEntity()
		{
			return this.Launcher<ITriggeredEntity>().Value;
		}

		// Token: 0x06030BB8 RID: 199608 RVA: 0x0069D240 File Offset: 0x0069B440
		public IVehicleEntity LauncherAsIVehicleEntity()
		{
			return this.Launcher<IVehicleEntity>().Value;
		}

		// Token: 0x1700CED1 RID: 52945
		// (get) Token: 0x06030BB9 RID: 199609 RVA: 0x0069D25C File Offset: 0x0069B45C
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

		// Token: 0x06030BBA RID: 199610 RVA: 0x0069D299 File Offset: 0x0069B499
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

		// Token: 0x06030BBB RID: 199611 RVA: 0x0069D2CD File Offset: 0x0069B4CD
		public static void StartIFireBulletTrackPosition(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x06030BBC RID: 199612 RVA: 0x0069D2D6 File Offset: 0x0069B4D6
		public static void AddType(FlatBufferBuilder builder, EFireBulletType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06030BBD RID: 199613 RVA: 0x0069D2E1 File Offset: 0x0069B4E1
		public static void AddBulletId(FlatBufferBuilder builder, long bulletId)
		{
			builder.AddLong(1, bulletId, 0L);
		}

		// Token: 0x06030BBE RID: 199614 RVA: 0x0069D2ED File Offset: 0x0069B4ED
		public static void AddLauncherType(FlatBufferBuilder builder, TTargetEntity launcherType)
		{
			builder.AddByte(2, (byte)launcherType, 0);
		}

		// Token: 0x06030BBF RID: 199615 RVA: 0x0069D2F8 File Offset: 0x0069B4F8
		public static void AddLauncher(FlatBufferBuilder builder, int launcherOffset)
		{
			builder.AddOffset(3, launcherOffset, 0);
		}

		// Token: 0x06030BC0 RID: 199616 RVA: 0x0069D303 File Offset: 0x0069B503
		public static void AddPositionEntityId(FlatBufferBuilder builder, int positionEntityId)
		{
			builder.AddInt(4, positionEntityId, 0);
		}

		// Token: 0x06030BC1 RID: 199617 RVA: 0x0069D30E File Offset: 0x0069B50E
		public static Offset<IFireBulletTrackPosition> EndIFireBulletTrackPosition(FlatBufferBuilder builder)
		{
			return new Offset<IFireBulletTrackPosition>(builder.EndTable());
		}

		// Token: 0x06030BC2 RID: 199618 RVA: 0x0069D31C File Offset: 0x0069B51C
		public IFireBulletTrackPositionT UnPack()
		{
			IFireBulletTrackPositionT fireBulletTrackPositionT = new IFireBulletTrackPositionT();
			this.UnPackTo(fireBulletTrackPositionT);
			return fireBulletTrackPositionT;
		}

		// Token: 0x06030BC3 RID: 199619 RVA: 0x0069D338 File Offset: 0x0069B538
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

		// Token: 0x06030BC4 RID: 199620 RVA: 0x0069D4CC File Offset: 0x0069B6CC
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

		// Token: 0x04011CFB RID: 72955
		private Table __p;
	}
}
