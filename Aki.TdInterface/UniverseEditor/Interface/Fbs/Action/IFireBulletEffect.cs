using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006E33 RID: 28211
	public struct IFireBulletEffect : IFlatbufferObject
	{
		// Token: 0x1700CEB9 RID: 52921
		// (get) Token: 0x06030B63 RID: 199523 RVA: 0x0069C704 File Offset: 0x0069A904
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06030B64 RID: 199524 RVA: 0x0069C711 File Offset: 0x0069A911
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06030B65 RID: 199525 RVA: 0x0069C718 File Offset: 0x0069A918
		public static IFireBulletEffect GetRootAsIFireBulletEffect(ByteBuffer _bb)
		{
			return IFireBulletEffect.GetRootAsIFireBulletEffect(_bb, default(IFireBulletEffect));
		}

		// Token: 0x06030B66 RID: 199526 RVA: 0x0069C734 File Offset: 0x0069A934
		public static IFireBulletEffect GetRootAsIFireBulletEffect(ByteBuffer _bb, IFireBulletEffect obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06030B67 RID: 199527 RVA: 0x0069C751 File Offset: 0x0069A951
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06030B68 RID: 199528 RVA: 0x0069C760 File Offset: 0x0069A960
		public IFireBulletEffect __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CEBA RID: 52922
		// (get) Token: 0x06030B69 RID: 199529 RVA: 0x0069C770 File Offset: 0x0069A970
		public int Id
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700CEBB RID: 52923
		// (get) Token: 0x06030B6A RID: 199530 RVA: 0x0069C7AC File Offset: 0x0069A9AC
		public int X
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700CEBC RID: 52924
		// (get) Token: 0x06030B6B RID: 199531 RVA: 0x0069C7E8 File Offset: 0x0069A9E8
		public int Y
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700CEBD RID: 52925
		// (get) Token: 0x06030B6C RID: 199532 RVA: 0x0069C824 File Offset: 0x0069AA24
		public int Z
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700CEBE RID: 52926
		// (get) Token: 0x06030B6D RID: 199533 RVA: 0x0069C864 File Offset: 0x0069AA64
		public EBulletLauncher Launcher
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return EBulletLauncher.Player;
				}
				return (EBulletLauncher)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700CEBF RID: 52927
		// (get) Token: 0x06030B6E RID: 199534 RVA: 0x0069C8A4 File Offset: 0x0069AAA4
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06030B6F RID: 199535 RVA: 0x0069C8E1 File Offset: 0x0069AAE1
		public static Offset<IFireBulletEffect> CreateIFireBulletEffect(FlatBufferBuilder builder, int Id = 0, int X = 0, int Y = 0, int Z = 0, EBulletLauncher Launcher = EBulletLauncher.Player, byte NullMask = 0)
		{
			builder.StartTable(6);
			IFireBulletEffect.AddZ(builder, Z);
			IFireBulletEffect.AddY(builder, Y);
			IFireBulletEffect.AddX(builder, X);
			IFireBulletEffect.AddId(builder, Id);
			IFireBulletEffect.AddNullMask(builder, NullMask);
			IFireBulletEffect.AddLauncher(builder, Launcher);
			return IFireBulletEffect.EndIFireBulletEffect(builder);
		}

		// Token: 0x06030B70 RID: 199536 RVA: 0x0069C91D File Offset: 0x0069AB1D
		public static void StartIFireBulletEffect(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x06030B71 RID: 199537 RVA: 0x0069C926 File Offset: 0x0069AB26
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(0, id, 0);
		}

		// Token: 0x06030B72 RID: 199538 RVA: 0x0069C931 File Offset: 0x0069AB31
		public static void AddX(FlatBufferBuilder builder, int x)
		{
			builder.AddInt(1, x, 0);
		}

		// Token: 0x06030B73 RID: 199539 RVA: 0x0069C93C File Offset: 0x0069AB3C
		public static void AddY(FlatBufferBuilder builder, int y)
		{
			builder.AddInt(2, y, 0);
		}

		// Token: 0x06030B74 RID: 199540 RVA: 0x0069C947 File Offset: 0x0069AB47
		public static void AddZ(FlatBufferBuilder builder, int z)
		{
			builder.AddInt(3, z, 0);
		}

		// Token: 0x06030B75 RID: 199541 RVA: 0x0069C952 File Offset: 0x0069AB52
		public static void AddLauncher(FlatBufferBuilder builder, EBulletLauncher launcher)
		{
			builder.AddByte(4, (byte)launcher, 0);
		}

		// Token: 0x06030B76 RID: 199542 RVA: 0x0069C95D File Offset: 0x0069AB5D
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(5, nullMask, 0);
		}

		// Token: 0x06030B77 RID: 199543 RVA: 0x0069C968 File Offset: 0x0069AB68
		public static Offset<IFireBulletEffect> EndIFireBulletEffect(FlatBufferBuilder builder)
		{
			return new Offset<IFireBulletEffect>(builder.EndTable());
		}

		// Token: 0x06030B78 RID: 199544 RVA: 0x0069C978 File Offset: 0x0069AB78
		public IFireBulletEffectT UnPack()
		{
			IFireBulletEffectT fireBulletEffectT = new IFireBulletEffectT();
			this.UnPackTo(fireBulletEffectT);
			return fireBulletEffectT;
		}

		// Token: 0x06030B79 RID: 199545 RVA: 0x0069C994 File Offset: 0x0069AB94
		public void UnPackTo(IFireBulletEffectT _o)
		{
			_o.Id = this.Id;
			_o.X = this.X;
			_o.Y = this.Y;
			_o.Z = this.Z;
			_o.Launcher = this.Launcher;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06030B7A RID: 199546 RVA: 0x0069C9EC File Offset: 0x0069ABEC
		public static Offset<IFireBulletEffect> Pack(FlatBufferBuilder builder, IFireBulletEffectT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFireBulletEffect>);
			}
			return IFireBulletEffect.CreateIFireBulletEffect(builder, _o.Id, _o.X, _o.Y, _o.Z, _o.Launcher, _o.NullMask);
		}

		// Token: 0x04011CF0 RID: 72944
		private Table __p;
	}
}
