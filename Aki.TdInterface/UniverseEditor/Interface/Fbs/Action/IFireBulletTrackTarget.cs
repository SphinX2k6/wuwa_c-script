using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006E3C RID: 28220
	public struct IFireBulletTrackTarget : IFlatbufferObject
	{
		// Token: 0x1700CED6 RID: 52950
		// (get) Token: 0x06030BCF RID: 199631 RVA: 0x0069D61C File Offset: 0x0069B81C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06030BD0 RID: 199632 RVA: 0x0069D629 File Offset: 0x0069B829
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06030BD1 RID: 199633 RVA: 0x0069D630 File Offset: 0x0069B830
		public static IFireBulletTrackTarget GetRootAsIFireBulletTrackTarget(ByteBuffer _bb)
		{
			return IFireBulletTrackTarget.GetRootAsIFireBulletTrackTarget(_bb, default(IFireBulletTrackTarget));
		}

		// Token: 0x06030BD2 RID: 199634 RVA: 0x0069D64C File Offset: 0x0069B84C
		public static IFireBulletTrackTarget GetRootAsIFireBulletTrackTarget(ByteBuffer _bb, IFireBulletTrackTarget obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06030BD3 RID: 199635 RVA: 0x0069D669 File Offset: 0x0069B869
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06030BD4 RID: 199636 RVA: 0x0069D678 File Offset: 0x0069B878
		public IFireBulletTrackTarget __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CED7 RID: 52951
		// (get) Token: 0x06030BD5 RID: 199637 RVA: 0x0069D688 File Offset: 0x0069B888
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

		// Token: 0x1700CED8 RID: 52952
		// (get) Token: 0x06030BD6 RID: 199638 RVA: 0x0069D6C4 File Offset: 0x0069B8C4
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

		// Token: 0x1700CED9 RID: 52953
		// (get) Token: 0x06030BD7 RID: 199639 RVA: 0x0069D704 File Offset: 0x0069B904
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

		// Token: 0x06030BD8 RID: 199640 RVA: 0x0069D740 File Offset: 0x0069B940
		public TTable? Launcher<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06030BD9 RID: 199641 RVA: 0x0069D788 File Offset: 0x0069B988
		public IPlayerEntity LauncherAsIPlayerEntity()
		{
			return this.Launcher<IPlayerEntity>().Value;
		}

		// Token: 0x06030BDA RID: 199642 RVA: 0x0069D7A4 File Offset: 0x0069B9A4
		public ISelfEntity LauncherAsISelfEntity()
		{
			return this.Launcher<ISelfEntity>().Value;
		}

		// Token: 0x06030BDB RID: 199643 RVA: 0x0069D7C0 File Offset: 0x0069B9C0
		public ITargetEntity LauncherAsITargetEntity()
		{
			return this.Launcher<ITargetEntity>().Value;
		}

		// Token: 0x06030BDC RID: 199644 RVA: 0x0069D7DC File Offset: 0x0069B9DC
		public ITriggeredEntity LauncherAsITriggeredEntity()
		{
			return this.Launcher<ITriggeredEntity>().Value;
		}

		// Token: 0x06030BDD RID: 199645 RVA: 0x0069D7F8 File Offset: 0x0069B9F8
		public IVehicleEntity LauncherAsIVehicleEntity()
		{
			return this.Launcher<IVehicleEntity>().Value;
		}

		// Token: 0x1700CEDA RID: 52954
		// (get) Token: 0x06030BDE RID: 199646 RVA: 0x0069D814 File Offset: 0x0069BA14
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

		// Token: 0x06030BDF RID: 199647 RVA: 0x0069D854 File Offset: 0x0069BA54
		public TTable? Target<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06030BE0 RID: 199648 RVA: 0x0069D89C File Offset: 0x0069BA9C
		public IPlayerEntity TargetAsIPlayerEntity()
		{
			return this.Target<IPlayerEntity>().Value;
		}

		// Token: 0x06030BE1 RID: 199649 RVA: 0x0069D8B8 File Offset: 0x0069BAB8
		public ISelfEntity TargetAsISelfEntity()
		{
			return this.Target<ISelfEntity>().Value;
		}

		// Token: 0x06030BE2 RID: 199650 RVA: 0x0069D8D4 File Offset: 0x0069BAD4
		public ITargetEntity TargetAsITargetEntity()
		{
			return this.Target<ITargetEntity>().Value;
		}

		// Token: 0x06030BE3 RID: 199651 RVA: 0x0069D8F0 File Offset: 0x0069BAF0
		public ITriggeredEntity TargetAsITriggeredEntity()
		{
			return this.Target<ITriggeredEntity>().Value;
		}

		// Token: 0x06030BE4 RID: 199652 RVA: 0x0069D90C File Offset: 0x0069BB0C
		public IVehicleEntity TargetAsIVehicleEntity()
		{
			return this.Target<IVehicleEntity>().Value;
		}

		// Token: 0x1700CEDB RID: 52955
		// (get) Token: 0x06030BE5 RID: 199653 RVA: 0x0069D928 File Offset: 0x0069BB28
		public bool WaitDestroy
		{
			get
			{
				int num = this.__p.__offset(16);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700CEDC RID: 52956
		// (get) Token: 0x06030BE6 RID: 199654 RVA: 0x0069D968 File Offset: 0x0069BB68
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

		// Token: 0x06030BE7 RID: 199655 RVA: 0x0069D9A8 File Offset: 0x0069BBA8
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

		// Token: 0x06030BE8 RID: 199656 RVA: 0x0069D9FF File Offset: 0x0069BBFF
		public static void StartIFireBulletTrackTarget(FlatBufferBuilder builder)
		{
			builder.StartTable(8);
		}

		// Token: 0x06030BE9 RID: 199657 RVA: 0x0069DA08 File Offset: 0x0069BC08
		public static void AddType(FlatBufferBuilder builder, EFireBulletType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06030BEA RID: 199658 RVA: 0x0069DA13 File Offset: 0x0069BC13
		public static void AddBulletId(FlatBufferBuilder builder, long bulletId)
		{
			builder.AddLong(1, bulletId, 0L);
		}

		// Token: 0x06030BEB RID: 199659 RVA: 0x0069DA1F File Offset: 0x0069BC1F
		public static void AddLauncherType(FlatBufferBuilder builder, TTargetEntity launcherType)
		{
			builder.AddByte(2, (byte)launcherType, 0);
		}

		// Token: 0x06030BEC RID: 199660 RVA: 0x0069DA2A File Offset: 0x0069BC2A
		public static void AddLauncher(FlatBufferBuilder builder, int launcherOffset)
		{
			builder.AddOffset(3, launcherOffset, 0);
		}

		// Token: 0x06030BED RID: 199661 RVA: 0x0069DA35 File Offset: 0x0069BC35
		public static void AddTargetType(FlatBufferBuilder builder, TTargetEntity targetType)
		{
			builder.AddByte(4, (byte)targetType, 0);
		}

		// Token: 0x06030BEE RID: 199662 RVA: 0x0069DA40 File Offset: 0x0069BC40
		public static void AddTarget(FlatBufferBuilder builder, int targetOffset)
		{
			builder.AddOffset(5, targetOffset, 0);
		}

		// Token: 0x06030BEF RID: 199663 RVA: 0x0069DA4B File Offset: 0x0069BC4B
		public static void AddWaitDestroy(FlatBufferBuilder builder, bool waitDestroy)
		{
			builder.AddBool(6, waitDestroy, false);
		}

		// Token: 0x06030BF0 RID: 199664 RVA: 0x0069DA56 File Offset: 0x0069BC56
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(7, nullMask, 0);
		}

		// Token: 0x06030BF1 RID: 199665 RVA: 0x0069DA61 File Offset: 0x0069BC61
		public static Offset<IFireBulletTrackTarget> EndIFireBulletTrackTarget(FlatBufferBuilder builder)
		{
			return new Offset<IFireBulletTrackTarget>(builder.EndTable());
		}

		// Token: 0x06030BF2 RID: 199666 RVA: 0x0069DA70 File Offset: 0x0069BC70
		public IFireBulletTrackTargetT UnPack()
		{
			IFireBulletTrackTargetT fireBulletTrackTargetT = new IFireBulletTrackTargetT();
			this.UnPackTo(fireBulletTrackTargetT);
			return fireBulletTrackTargetT;
		}

		// Token: 0x06030BF3 RID: 199667 RVA: 0x0069DA8C File Offset: 0x0069BC8C
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

		// Token: 0x06030BF4 RID: 199668 RVA: 0x0069DD8C File Offset: 0x0069BF8C
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

		// Token: 0x04011D00 RID: 72960
		private Table __p;
	}
}
