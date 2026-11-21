using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006E36 RID: 28214
	public struct IFireBulletForwardFront : IFlatbufferObject
	{
		// Token: 0x1700CEC6 RID: 52934
		// (get) Token: 0x06030B89 RID: 199561 RVA: 0x0069CB44 File Offset: 0x0069AD44
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06030B8A RID: 199562 RVA: 0x0069CB51 File Offset: 0x0069AD51
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06030B8B RID: 199563 RVA: 0x0069CB58 File Offset: 0x0069AD58
		public static IFireBulletForwardFront GetRootAsIFireBulletForwardFront(ByteBuffer _bb)
		{
			return IFireBulletForwardFront.GetRootAsIFireBulletForwardFront(_bb, default(IFireBulletForwardFront));
		}

		// Token: 0x06030B8C RID: 199564 RVA: 0x0069CB74 File Offset: 0x0069AD74
		public static IFireBulletForwardFront GetRootAsIFireBulletForwardFront(ByteBuffer _bb, IFireBulletForwardFront obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06030B8D RID: 199565 RVA: 0x0069CB91 File Offset: 0x0069AD91
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06030B8E RID: 199566 RVA: 0x0069CBA0 File Offset: 0x0069ADA0
		public IFireBulletForwardFront __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CEC7 RID: 52935
		// (get) Token: 0x06030B8F RID: 199567 RVA: 0x0069CBB0 File Offset: 0x0069ADB0
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

		// Token: 0x1700CEC8 RID: 52936
		// (get) Token: 0x06030B90 RID: 199568 RVA: 0x0069CBEC File Offset: 0x0069ADEC
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

		// Token: 0x1700CEC9 RID: 52937
		// (get) Token: 0x06030B91 RID: 199569 RVA: 0x0069CC2C File Offset: 0x0069AE2C
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

		// Token: 0x06030B92 RID: 199570 RVA: 0x0069CC68 File Offset: 0x0069AE68
		public TTable? Launcher<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06030B93 RID: 199571 RVA: 0x0069CCB0 File Offset: 0x0069AEB0
		public IPlayerEntity LauncherAsIPlayerEntity()
		{
			return this.Launcher<IPlayerEntity>().Value;
		}

		// Token: 0x06030B94 RID: 199572 RVA: 0x0069CCCC File Offset: 0x0069AECC
		public ISelfEntity LauncherAsISelfEntity()
		{
			return this.Launcher<ISelfEntity>().Value;
		}

		// Token: 0x06030B95 RID: 199573 RVA: 0x0069CCE8 File Offset: 0x0069AEE8
		public ITargetEntity LauncherAsITargetEntity()
		{
			return this.Launcher<ITargetEntity>().Value;
		}

		// Token: 0x06030B96 RID: 199574 RVA: 0x0069CD04 File Offset: 0x0069AF04
		public ITriggeredEntity LauncherAsITriggeredEntity()
		{
			return this.Launcher<ITriggeredEntity>().Value;
		}

		// Token: 0x06030B97 RID: 199575 RVA: 0x0069CD20 File Offset: 0x0069AF20
		public IVehicleEntity LauncherAsIVehicleEntity()
		{
			return this.Launcher<IVehicleEntity>().Value;
		}

		// Token: 0x06030B98 RID: 199576 RVA: 0x0069CD3B File Offset: 0x0069AF3B
		public static Offset<IFireBulletForwardFront> CreateIFireBulletForwardFront(FlatBufferBuilder builder, EFireBulletType Type = EFireBulletType.TrackTarget, long BulletId = 0L, TTargetEntity Launcher_type = TTargetEntity.NONE, int LauncherOffset = 0)
		{
			builder.StartTable(4);
			IFireBulletForwardFront.AddBulletId(builder, BulletId);
			IFireBulletForwardFront.AddLauncher(builder, LauncherOffset);
			IFireBulletForwardFront.AddLauncherType(builder, Launcher_type);
			IFireBulletForwardFront.AddType(builder, Type);
			return IFireBulletForwardFront.EndIFireBulletForwardFront(builder);
		}

		// Token: 0x06030B99 RID: 199577 RVA: 0x0069CD67 File Offset: 0x0069AF67
		public static void StartIFireBulletForwardFront(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06030B9A RID: 199578 RVA: 0x0069CD70 File Offset: 0x0069AF70
		public static void AddType(FlatBufferBuilder builder, EFireBulletType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06030B9B RID: 199579 RVA: 0x0069CD7B File Offset: 0x0069AF7B
		public static void AddBulletId(FlatBufferBuilder builder, long bulletId)
		{
			builder.AddLong(1, bulletId, 0L);
		}

		// Token: 0x06030B9C RID: 199580 RVA: 0x0069CD87 File Offset: 0x0069AF87
		public static void AddLauncherType(FlatBufferBuilder builder, TTargetEntity launcherType)
		{
			builder.AddByte(2, (byte)launcherType, 0);
		}

		// Token: 0x06030B9D RID: 199581 RVA: 0x0069CD92 File Offset: 0x0069AF92
		public static void AddLauncher(FlatBufferBuilder builder, int launcherOffset)
		{
			builder.AddOffset(3, launcherOffset, 0);
		}

		// Token: 0x06030B9E RID: 199582 RVA: 0x0069CD9D File Offset: 0x0069AF9D
		public static Offset<IFireBulletForwardFront> EndIFireBulletForwardFront(FlatBufferBuilder builder)
		{
			return new Offset<IFireBulletForwardFront>(builder.EndTable());
		}

		// Token: 0x06030B9F RID: 199583 RVA: 0x0069CDAC File Offset: 0x0069AFAC
		public IFireBulletForwardFrontT UnPack()
		{
			IFireBulletForwardFrontT fireBulletForwardFrontT = new IFireBulletForwardFrontT();
			this.UnPackTo(fireBulletForwardFrontT);
			return fireBulletForwardFrontT;
		}

		// Token: 0x06030BA0 RID: 199584 RVA: 0x0069CDC8 File Offset: 0x0069AFC8
		public void UnPackTo(IFireBulletForwardFrontT _o)
		{
			_o.Type = this.Type;
			_o.BulletId = this.BulletId;
			_o.Launcher = new TTargetEntityUnion();
			_o.Launcher.Type = this.LauncherType;
			switch (this.LauncherType)
			{
			case TTargetEntity.IPlayerEntity:
				_o.Launcher.Value = ((this.Launcher<IPlayerEntity>() != null) ? this.Launcher<IPlayerEntity>().Value.UnPack() : null);
				return;
			case TTargetEntity.ISelfEntity:
				_o.Launcher.Value = ((this.Launcher<ISelfEntity>() != null) ? this.Launcher<ISelfEntity>().Value.UnPack() : null);
				return;
			case TTargetEntity.ITargetEntity:
				_o.Launcher.Value = ((this.Launcher<ITargetEntity>() != null) ? this.Launcher<ITargetEntity>().Value.UnPack() : null);
				return;
			case TTargetEntity.ITriggeredEntity:
				_o.Launcher.Value = ((this.Launcher<ITriggeredEntity>() != null) ? this.Launcher<ITriggeredEntity>().Value.UnPack() : null);
				return;
			case TTargetEntity.IVehicleEntity:
				_o.Launcher.Value = ((this.Launcher<IVehicleEntity>() != null) ? this.Launcher<IVehicleEntity>().Value.UnPack() : null);
				return;
			default:
				return;
			}
		}

		// Token: 0x06030BA1 RID: 199585 RVA: 0x0069CF40 File Offset: 0x0069B140
		public static Offset<IFireBulletForwardFront> Pack(FlatBufferBuilder builder, IFireBulletForwardFrontT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFireBulletForwardFront>);
			}
			TTargetEntity launcher_type = (_o.Launcher == null) ? TTargetEntity.NONE : _o.Launcher.Type;
			int launcherOffset = (_o.Launcher == null) ? 0 : TTargetEntityUnion.Pack(builder, _o.Launcher);
			return IFireBulletForwardFront.CreateIFireBulletForwardFront(builder, _o.Type, _o.BulletId, launcher_type, launcherOffset);
		}

		// Token: 0x04011CF7 RID: 72951
		private Table __p;
	}
}
