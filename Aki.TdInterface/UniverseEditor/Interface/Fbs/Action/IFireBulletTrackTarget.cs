using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020067BC RID: 26556
	public struct IFireBulletTrackTarget : IFlatbufferObject
	{
		// Token: 0x1700C520 RID: 50464
		// (get) Token: 0x0602E389 RID: 189321 RVA: 0x0064FED8 File Offset: 0x0064E0D8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602E38A RID: 189322 RVA: 0x0064FEE5 File Offset: 0x0064E0E5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602E38B RID: 189323 RVA: 0x0064FEEC File Offset: 0x0064E0EC
		public static IFireBulletTrackTarget GetRootAsIFireBulletTrackTarget(ByteBuffer _bb)
		{
			return IFireBulletTrackTarget.GetRootAsIFireBulletTrackTarget(_bb, default(IFireBulletTrackTarget));
		}

		// Token: 0x0602E38C RID: 189324 RVA: 0x0064FF08 File Offset: 0x0064E108
		public static IFireBulletTrackTarget GetRootAsIFireBulletTrackTarget(ByteBuffer _bb, IFireBulletTrackTarget obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602E38D RID: 189325 RVA: 0x0064FF25 File Offset: 0x0064E125
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602E38E RID: 189326 RVA: 0x0064FF34 File Offset: 0x0064E134
		public IFireBulletTrackTarget __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C521 RID: 50465
		// (get) Token: 0x0602E38F RID: 189327 RVA: 0x0064FF44 File Offset: 0x0064E144
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

		// Token: 0x1700C522 RID: 50466
		// (get) Token: 0x0602E390 RID: 189328 RVA: 0x0064FF80 File Offset: 0x0064E180
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

		// Token: 0x1700C523 RID: 50467
		// (get) Token: 0x0602E391 RID: 189329 RVA: 0x0064FFC0 File Offset: 0x0064E1C0
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

		// Token: 0x0602E392 RID: 189330 RVA: 0x0064FFFC File Offset: 0x0064E1FC
		public TTable? Launcher<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0602E393 RID: 189331 RVA: 0x00650044 File Offset: 0x0064E244
		public IPlayerEntity LauncherAsIPlayerEntity()
		{
			return this.Launcher<IPlayerEntity>().Value;
		}

		// Token: 0x0602E394 RID: 189332 RVA: 0x00650060 File Offset: 0x0064E260
		public ISelfEntity LauncherAsISelfEntity()
		{
			return this.Launcher<ISelfEntity>().Value;
		}

		// Token: 0x0602E395 RID: 189333 RVA: 0x0065007C File Offset: 0x0064E27C
		public ITargetEntity LauncherAsITargetEntity()
		{
			return this.Launcher<ITargetEntity>().Value;
		}

		// Token: 0x0602E396 RID: 189334 RVA: 0x00650098 File Offset: 0x0064E298
		public ITriggeredEntity LauncherAsITriggeredEntity()
		{
			return this.Launcher<ITriggeredEntity>().Value;
		}

		// Token: 0x0602E397 RID: 189335 RVA: 0x006500B4 File Offset: 0x0064E2B4
		public IVehicleEntity LauncherAsIVehicleEntity()
		{
			return this.Launcher<IVehicleEntity>().Value;
		}

		// Token: 0x1700C524 RID: 50468
		// (get) Token: 0x0602E398 RID: 189336 RVA: 0x006500D0 File Offset: 0x0064E2D0
		public TTargetEntity TargetType
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return TTargetEntity.NONE;
				}
				return (TTargetEntity)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602E399 RID: 189337 RVA: 0x00650110 File Offset: 0x0064E310
		public TTable? Target<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0602E39A RID: 189338 RVA: 0x00650158 File Offset: 0x0064E358
		public IPlayerEntity TargetAsIPlayerEntity()
		{
			return this.Target<IPlayerEntity>().Value;
		}

		// Token: 0x0602E39B RID: 189339 RVA: 0x00650174 File Offset: 0x0064E374
		public ISelfEntity TargetAsISelfEntity()
		{
			return this.Target<ISelfEntity>().Value;
		}

		// Token: 0x0602E39C RID: 189340 RVA: 0x00650190 File Offset: 0x0064E390
		public ITargetEntity TargetAsITargetEntity()
		{
			return this.Target<ITargetEntity>().Value;
		}

		// Token: 0x0602E39D RID: 189341 RVA: 0x006501AC File Offset: 0x0064E3AC
		public ITriggeredEntity TargetAsITriggeredEntity()
		{
			return this.Target<ITriggeredEntity>().Value;
		}

		// Token: 0x0602E39E RID: 189342 RVA: 0x006501C8 File Offset: 0x0064E3C8
		public IVehicleEntity TargetAsIVehicleEntity()
		{
			return this.Target<IVehicleEntity>().Value;
		}

		// Token: 0x1700C525 RID: 50469
		// (get) Token: 0x0602E39F RID: 189343 RVA: 0x006501E4 File Offset: 0x0064E3E4
		public bool WaitDestroy
		{
			get
			{
				int num = this.__p.__offset(16);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700C526 RID: 50470
		// (get) Token: 0x0602E3A0 RID: 189344 RVA: 0x00650224 File Offset: 0x0064E424
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602E3A1 RID: 189345 RVA: 0x00650264 File Offset: 0x0064E464
		public static Offset<IFireBulletTrackTarget> CreateIFireBulletTrackTarget(FlatBufferBuilder builder, EFireBulletType Type = EFireBulletType.TrackTarget, long BulletId = 0L, TTargetEntity Launcher_type = TTargetEntity.NONE, int LauncherOffset = 0, TTargetEntity Target_type = TTargetEntity.NONE, int TargetOffset = 0, bool WaitDestroy = false, byte NullMask = 0)
		{
			builder.StartTable(8);
			IFireBulletTrackTarget.AddBulletId(builder, BulletId);
			IFireBulletTrackTarget.AddTarget(builder, TargetOffset);
			IFireBulletTrackTarget.AddLauncher(builder, LauncherOffset);
			IFireBulletTrackTarget.AddNullMask(builder, NullMask);
			IFireBulletTrackTarget.AddWaitDestroy(builder, WaitDestroy);
			IFireBulletTrackTarget.AddTargetType(builder, Target_type);
			IFireBulletTrackTarget.AddLauncherType(builder, Launcher_type);
			IFireBulletTrackTarget.AddType(builder, Type);
			return IFireBulletTrackTarget.EndIFireBulletTrackTarget(builder);
		}

		// Token: 0x0602E3A2 RID: 189346 RVA: 0x006502BB File Offset: 0x0064E4BB
		public static void StartIFireBulletTrackTarget(FlatBufferBuilder builder)
		{
			builder.StartTable(8);
		}

		// Token: 0x0602E3A3 RID: 189347 RVA: 0x006502C4 File Offset: 0x0064E4C4
		public static void AddType(FlatBufferBuilder builder, EFireBulletType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602E3A4 RID: 189348 RVA: 0x006502CF File Offset: 0x0064E4CF
		public static void AddBulletId(FlatBufferBuilder builder, long bulletId)
		{
			builder.AddLong(1, bulletId, 0L);
		}

		// Token: 0x0602E3A5 RID: 189349 RVA: 0x006502DB File Offset: 0x0064E4DB
		public static void AddLauncherType(FlatBufferBuilder builder, TTargetEntity launcherType)
		{
			builder.AddByte(2, (byte)launcherType, 0);
		}

		// Token: 0x0602E3A6 RID: 189350 RVA: 0x006502E6 File Offset: 0x0064E4E6
		public static void AddLauncher(FlatBufferBuilder builder, int launcherOffset)
		{
			builder.AddOffset(3, launcherOffset, 0);
		}

		// Token: 0x0602E3A7 RID: 189351 RVA: 0x006502F1 File Offset: 0x0064E4F1
		public static void AddTargetType(FlatBufferBuilder builder, TTargetEntity targetType)
		{
			builder.AddByte(4, (byte)targetType, 0);
		}

		// Token: 0x0602E3A8 RID: 189352 RVA: 0x006502FC File Offset: 0x0064E4FC
		public static void AddTarget(FlatBufferBuilder builder, int targetOffset)
		{
			builder.AddOffset(5, targetOffset, 0);
		}

		// Token: 0x0602E3A9 RID: 189353 RVA: 0x00650307 File Offset: 0x0064E507
		public static void AddWaitDestroy(FlatBufferBuilder builder, bool waitDestroy)
		{
			builder.AddBool(6, waitDestroy, false);
		}

		// Token: 0x0602E3AA RID: 189354 RVA: 0x00650312 File Offset: 0x0064E512
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(7, nullMask, 0);
		}

		// Token: 0x0602E3AB RID: 189355 RVA: 0x0065031D File Offset: 0x0064E51D
		public static Offset<IFireBulletTrackTarget> EndIFireBulletTrackTarget(FlatBufferBuilder builder)
		{
			return new Offset<IFireBulletTrackTarget>(builder.EndTable());
		}

		// Token: 0x0602E3AC RID: 189356 RVA: 0x0065032C File Offset: 0x0064E52C
		public IFireBulletTrackTargetT UnPack()
		{
			IFireBulletTrackTargetT fireBulletTrackTargetT = new IFireBulletTrackTargetT();
			this.UnPackTo(fireBulletTrackTargetT);
			return fireBulletTrackTargetT;
		}

		// Token: 0x0602E3AD RID: 189357 RVA: 0x00650348 File Offset: 0x0064E548
		public void UnPackTo(IFireBulletTrackTargetT _o)
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
			_o.Target = new TTargetEntityUnion();
			_o.Target.Type = this.TargetType;
			switch (this.TargetType)
			{
			case TTargetEntity.IPlayerEntity:
				_o.Target.Value = ((this.Target<IPlayerEntity>() != null) ? this.Target<IPlayerEntity>().Value.UnPack() : null);
				break;
			case TTargetEntity.ISelfEntity:
				_o.Target.Value = ((this.Target<ISelfEntity>() != null) ? this.Target<ISelfEntity>().Value.UnPack() : null);
				break;
			case TTargetEntity.ITargetEntity:
				_o.Target.Value = ((this.Target<ITargetEntity>() != null) ? this.Target<ITargetEntity>().Value.UnPack() : null);
				break;
			case TTargetEntity.ITriggeredEntity:
				_o.Target.Value = ((this.Target<ITriggeredEntity>() != null) ? this.Target<ITriggeredEntity>().Value.UnPack() : null);
				break;
			case TTargetEntity.IVehicleEntity:
				_o.Target.Value = ((this.Target<IVehicleEntity>() != null) ? this.Target<IVehicleEntity>().Value.UnPack() : null);
				break;
			}
			_o.WaitDestroy = this.WaitDestroy;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602E3AE RID: 189358 RVA: 0x00650648 File Offset: 0x0064E848
		public static Offset<IFireBulletTrackTarget> Pack(FlatBufferBuilder builder, IFireBulletTrackTargetT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFireBulletTrackTarget>);
			}
			TTargetEntity launcher_type = (_o.Launcher == null) ? TTargetEntity.NONE : _o.Launcher.Type;
			int launcherOffset = (_o.Launcher == null) ? 0 : TTargetEntityUnion.Pack(builder, _o.Launcher);
			TTargetEntity target_type = (_o.Target == null) ? TTargetEntity.NONE : _o.Target.Type;
			int targetOffset = (_o.Target == null) ? 0 : TTargetEntityUnion.Pack(builder, _o.Target);
			return IFireBulletTrackTarget.CreateIFireBulletTrackTarget(builder, _o.Type, _o.BulletId, launcher_type, launcherOffset, target_type, targetOffset, _o.WaitDestroy, _o.NullMask);
		}

		// Token: 0x04010ECE RID: 69326
		private Table __p;
	}
}
