using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006E30 RID: 28208
	public struct IFireBullet : IFlatbufferObject
	{
		// Token: 0x1700CEB2 RID: 52914
		// (get) Token: 0x06030B44 RID: 199492 RVA: 0x0069C292 File Offset: 0x0069A492
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06030B45 RID: 199493 RVA: 0x0069C29F File Offset: 0x0069A49F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06030B46 RID: 199494 RVA: 0x0069C2A8 File Offset: 0x0069A4A8
		public static IFireBullet GetRootAsIFireBullet(ByteBuffer _bb)
		{
			return IFireBullet.GetRootAsIFireBullet(_bb, default(IFireBullet));
		}

		// Token: 0x06030B47 RID: 199495 RVA: 0x0069C2C4 File Offset: 0x0069A4C4
		public static IFireBullet GetRootAsIFireBullet(ByteBuffer _bb, IFireBullet obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06030B48 RID: 199496 RVA: 0x0069C2E1 File Offset: 0x0069A4E1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06030B49 RID: 199497 RVA: 0x0069C2F0 File Offset: 0x0069A4F0
		public IFireBullet __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CEB3 RID: 52915
		// (get) Token: 0x06030B4A RID: 199498 RVA: 0x0069C300 File Offset: 0x0069A500
		public TFireBullet TypeType
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return TFireBullet.NONE;
				}
				return (TFireBullet)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06030B4B RID: 199499 RVA: 0x0069C33C File Offset: 0x0069A53C
		public TTable? Type<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06030B4C RID: 199500 RVA: 0x0069C380 File Offset: 0x0069A580
		public IFireBulletForwardFront TypeAsIFireBulletForwardFront()
		{
			return this.Type<IFireBulletForwardFront>().Value;
		}

		// Token: 0x06030B4D RID: 199501 RVA: 0x0069C39C File Offset: 0x0069A59C
		public IFireBulletTrackPosition TypeAsIFireBulletTrackPosition()
		{
			return this.Type<IFireBulletTrackPosition>().Value;
		}

		// Token: 0x06030B4E RID: 199502 RVA: 0x0069C3B8 File Offset: 0x0069A5B8
		public IFireBulletTrackTarget TypeAsIFireBulletTrackTarget()
		{
			return this.Type<IFireBulletTrackTarget>().Value;
		}

		// Token: 0x1700CEB4 RID: 52916
		// (get) Token: 0x06030B4F RID: 199503 RVA: 0x0069C3D4 File Offset: 0x0069A5D4
		public EBulletLauncher Launcher
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return EBulletLauncher.Player;
				}
				return (EBulletLauncher)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700CEB5 RID: 52917
		// (get) Token: 0x06030B50 RID: 199504 RVA: 0x0069C410 File Offset: 0x0069A610
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

		// Token: 0x06030B51 RID: 199505 RVA: 0x0069C44D File Offset: 0x0069A64D
		public static Offset<IFireBullet> CreateIFireBullet(FlatBufferBuilder builder, TFireBullet Type_type = TFireBullet.NONE, int TypeOffset = 0, EBulletLauncher Launcher = EBulletLauncher.Player, byte NullMask = 0)
		{
			builder.StartTable(4);
			IFireBullet.AddType(builder, TypeOffset);
			IFireBullet.AddNullMask(builder, NullMask);
			IFireBullet.AddLauncher(builder, Launcher);
			IFireBullet.AddTypeType(builder, Type_type);
			return IFireBullet.EndIFireBullet(builder);
		}

		// Token: 0x06030B52 RID: 199506 RVA: 0x0069C479 File Offset: 0x0069A679
		public static void StartIFireBullet(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06030B53 RID: 199507 RVA: 0x0069C482 File Offset: 0x0069A682
		public static void AddTypeType(FlatBufferBuilder builder, TFireBullet typeType)
		{
			builder.AddByte(0, (byte)typeType, 0);
		}

		// Token: 0x06030B54 RID: 199508 RVA: 0x0069C48D File Offset: 0x0069A68D
		public static void AddType(FlatBufferBuilder builder, int typeOffset)
		{
			builder.AddOffset(1, typeOffset, 0);
		}

		// Token: 0x06030B55 RID: 199509 RVA: 0x0069C498 File Offset: 0x0069A698
		public static void AddLauncher(FlatBufferBuilder builder, EBulletLauncher launcher)
		{
			builder.AddByte(2, (byte)launcher, 0);
		}

		// Token: 0x06030B56 RID: 199510 RVA: 0x0069C4A3 File Offset: 0x0069A6A3
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x06030B57 RID: 199511 RVA: 0x0069C4AE File Offset: 0x0069A6AE
		public static Offset<IFireBullet> EndIFireBullet(FlatBufferBuilder builder)
		{
			return new Offset<IFireBullet>(builder.EndTable());
		}

		// Token: 0x06030B58 RID: 199512 RVA: 0x0069C4BC File Offset: 0x0069A6BC
		public IFireBulletT UnPack()
		{
			IFireBulletT fireBulletT = new IFireBulletT();
			this.UnPackTo(fireBulletT);
			return fireBulletT;
		}

		// Token: 0x06030B59 RID: 199513 RVA: 0x0069C4D8 File Offset: 0x0069A6D8
		public void UnPackTo(IFireBulletT _o)
		{
			_o.Type = new TFireBulletUnion();
			_o.Type.Type = this.TypeType;
			switch (this.TypeType)
			{
			case TFireBullet.IFireBulletForwardFront:
				_o.Type.Value = ((this.Type<IFireBulletForwardFront>() != null) ? this.Type<IFireBulletForwardFront>().Value.UnPack() : null);
				break;
			case TFireBullet.IFireBulletTrackPosition:
				_o.Type.Value = ((this.Type<IFireBulletTrackPosition>() != null) ? this.Type<IFireBulletTrackPosition>().Value.UnPack() : null);
				break;
			case TFireBullet.IFireBulletTrackTarget:
				_o.Type.Value = ((this.Type<IFireBulletTrackTarget>() != null) ? this.Type<IFireBulletTrackTarget>().Value.UnPack() : null);
				break;
			}
			_o.Launcher = this.Launcher;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06030B5A RID: 199514 RVA: 0x0069C5E0 File Offset: 0x0069A7E0
		public static Offset<IFireBullet> Pack(FlatBufferBuilder builder, IFireBulletT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFireBullet>);
			}
			TFireBullet type_type = (_o.Type == null) ? TFireBullet.NONE : _o.Type.Type;
			int typeOffset = (_o.Type == null) ? 0 : TFireBulletUnion.Pack(builder, _o.Type);
			return IFireBullet.CreateIFireBullet(builder, type_type, typeOffset, _o.Launcher, _o.NullMask);
		}

		// Token: 0x04011CEC RID: 72940
		private Table __p;
	}
}
