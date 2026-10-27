using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020067B6 RID: 26550
	public struct IFireBulletForwardFront : IFlatbufferObject
	{
		// Token: 0x1700C510 RID: 50448
		// (get) Token: 0x0602E343 RID: 189251 RVA: 0x0064F400 File Offset: 0x0064D600
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602E344 RID: 189252 RVA: 0x0064F40D File Offset: 0x0064D60D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602E345 RID: 189253 RVA: 0x0064F414 File Offset: 0x0064D614
		public static IFireBulletForwardFront GetRootAsIFireBulletForwardFront(ByteBuffer _bb)
		{
			return IFireBulletForwardFront.GetRootAsIFireBulletForwardFront(_bb, default(IFireBulletForwardFront));
		}

		// Token: 0x0602E346 RID: 189254 RVA: 0x0064F430 File Offset: 0x0064D630
		public static IFireBulletForwardFront GetRootAsIFireBulletForwardFront(ByteBuffer _bb, IFireBulletForwardFront obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602E347 RID: 189255 RVA: 0x0064F44D File Offset: 0x0064D64D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602E348 RID: 189256 RVA: 0x0064F45C File Offset: 0x0064D65C
		public IFireBulletForwardFront __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C511 RID: 50449
		// (get) Token: 0x0602E349 RID: 189257 RVA: 0x0064F46C File Offset: 0x0064D66C
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

		// Token: 0x1700C512 RID: 50450
		// (get) Token: 0x0602E34A RID: 189258 RVA: 0x0064F4A8 File Offset: 0x0064D6A8
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

		// Token: 0x1700C513 RID: 50451
		// (get) Token: 0x0602E34B RID: 189259 RVA: 0x0064F4E8 File Offset: 0x0064D6E8
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

		// Token: 0x0602E34C RID: 189260 RVA: 0x0064F524 File Offset: 0x0064D724
		public TTable? Launcher<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0602E34D RID: 189261 RVA: 0x0064F56C File Offset: 0x0064D76C
		public IPlayerEntity LauncherAsIPlayerEntity()
		{
			return this.Launcher<IPlayerEntity>().Value;
		}

		// Token: 0x0602E34E RID: 189262 RVA: 0x0064F588 File Offset: 0x0064D788
		public ISelfEntity LauncherAsISelfEntity()
		{
			return this.Launcher<ISelfEntity>().Value;
		}

		// Token: 0x0602E34F RID: 189263 RVA: 0x0064F5A4 File Offset: 0x0064D7A4
		public ITargetEntity LauncherAsITargetEntity()
		{
			return this.Launcher<ITargetEntity>().Value;
		}

		// Token: 0x0602E350 RID: 189264 RVA: 0x0064F5C0 File Offset: 0x0064D7C0
		public ITriggeredEntity LauncherAsITriggeredEntity()
		{
			return this.Launcher<ITriggeredEntity>().Value;
		}

		// Token: 0x0602E351 RID: 189265 RVA: 0x0064F5DC File Offset: 0x0064D7DC
		public IVehicleEntity LauncherAsIVehicleEntity()
		{
			return this.Launcher<IVehicleEntity>().Value;
		}

		// Token: 0x0602E352 RID: 189266 RVA: 0x0064F5F7 File Offset: 0x0064D7F7
		public static Offset<IFireBulletForwardFront> CreateIFireBulletForwardFront(FlatBufferBuilder builder, EFireBulletType Type = EFireBulletType.TrackTarget, long BulletId = 0L, TTargetEntity Launcher_type = TTargetEntity.NONE, int LauncherOffset = 0)
		{
			builder.StartTable(4);
			IFireBulletForwardFront.AddBulletId(builder, BulletId);
			IFireBulletForwardFront.AddLauncher(builder, LauncherOffset);
			IFireBulletForwardFront.AddLauncherType(builder, Launcher_type);
			IFireBulletForwardFront.AddType(builder, Type);
			return IFireBulletForwardFront.EndIFireBulletForwardFront(builder);
		}

		// Token: 0x0602E353 RID: 189267 RVA: 0x0064F623 File Offset: 0x0064D823
		public static void StartIFireBulletForwardFront(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0602E354 RID: 189268 RVA: 0x0064F62C File Offset: 0x0064D82C
		public static void AddType(FlatBufferBuilder builder, EFireBulletType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602E355 RID: 189269 RVA: 0x0064F637 File Offset: 0x0064D837
		public static void AddBulletId(FlatBufferBuilder builder, long bulletId)
		{
			builder.AddLong(1, bulletId, 0L);
		}

		// Token: 0x0602E356 RID: 189270 RVA: 0x0064F643 File Offset: 0x0064D843
		public static void AddLauncherType(FlatBufferBuilder builder, TTargetEntity launcherType)
		{
			builder.AddByte(2, (byte)launcherType, 0);
		}

		// Token: 0x0602E357 RID: 189271 RVA: 0x0064F64E File Offset: 0x0064D84E
		public static void AddLauncher(FlatBufferBuilder builder, int launcherOffset)
		{
			builder.AddOffset(3, launcherOffset, 0);
		}

		// Token: 0x0602E358 RID: 189272 RVA: 0x0064F659 File Offset: 0x0064D859
		public static Offset<IFireBulletForwardFront> EndIFireBulletForwardFront(FlatBufferBuilder builder)
		{
			return new Offset<IFireBulletForwardFront>(builder.EndTable());
		}

		// Token: 0x0602E359 RID: 189273 RVA: 0x0064F668 File Offset: 0x0064D868
		public IFireBulletForwardFrontT UnPack()
		{
			IFireBulletForwardFrontT fireBulletForwardFrontT = new IFireBulletForwardFrontT();
			this.UnPackTo(fireBulletForwardFrontT);
			return fireBulletForwardFrontT;
		}

		// Token: 0x0602E35A RID: 189274 RVA: 0x0064F684 File Offset: 0x0064D884
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

		// Token: 0x0602E35B RID: 189275 RVA: 0x0064F7FC File Offset: 0x0064D9FC
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

		// Token: 0x04010EC5 RID: 69317
		private Table __p;
	}
}
