using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020067B3 RID: 26547
	public struct IFireBulletEffect : IFlatbufferObject
	{
		// Token: 0x1700C503 RID: 50435
		// (get) Token: 0x0602E31D RID: 189213 RVA: 0x0064EFC0 File Offset: 0x0064D1C0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602E31E RID: 189214 RVA: 0x0064EFCD File Offset: 0x0064D1CD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602E31F RID: 189215 RVA: 0x0064EFD4 File Offset: 0x0064D1D4
		public static IFireBulletEffect GetRootAsIFireBulletEffect(ByteBuffer _bb)
		{
			return IFireBulletEffect.GetRootAsIFireBulletEffect(_bb, default(IFireBulletEffect));
		}

		// Token: 0x0602E320 RID: 189216 RVA: 0x0064EFF0 File Offset: 0x0064D1F0
		public static IFireBulletEffect GetRootAsIFireBulletEffect(ByteBuffer _bb, IFireBulletEffect obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602E321 RID: 189217 RVA: 0x0064F00D File Offset: 0x0064D20D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602E322 RID: 189218 RVA: 0x0064F01C File Offset: 0x0064D21C
		public IFireBulletEffect __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C504 RID: 50436
		// (get) Token: 0x0602E323 RID: 189219 RVA: 0x0064F02C File Offset: 0x0064D22C
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

		// Token: 0x1700C505 RID: 50437
		// (get) Token: 0x0602E324 RID: 189220 RVA: 0x0064F068 File Offset: 0x0064D268
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

		// Token: 0x1700C506 RID: 50438
		// (get) Token: 0x0602E325 RID: 189221 RVA: 0x0064F0A4 File Offset: 0x0064D2A4
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

		// Token: 0x1700C507 RID: 50439
		// (get) Token: 0x0602E326 RID: 189222 RVA: 0x0064F0E0 File Offset: 0x0064D2E0
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

		// Token: 0x1700C508 RID: 50440
		// (get) Token: 0x0602E327 RID: 189223 RVA: 0x0064F120 File Offset: 0x0064D320
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

		// Token: 0x1700C509 RID: 50441
		// (get) Token: 0x0602E328 RID: 189224 RVA: 0x0064F160 File Offset: 0x0064D360
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

		// Token: 0x0602E329 RID: 189225 RVA: 0x0064F19D File Offset: 0x0064D39D
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

		// Token: 0x0602E32A RID: 189226 RVA: 0x0064F1D9 File Offset: 0x0064D3D9
		public static void StartIFireBulletEffect(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x0602E32B RID: 189227 RVA: 0x0064F1E2 File Offset: 0x0064D3E2
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(0, id, 0);
		}

		// Token: 0x0602E32C RID: 189228 RVA: 0x0064F1ED File Offset: 0x0064D3ED
		public static void AddX(FlatBufferBuilder builder, int x)
		{
			builder.AddInt(1, x, 0);
		}

		// Token: 0x0602E32D RID: 189229 RVA: 0x0064F1F8 File Offset: 0x0064D3F8
		public static void AddY(FlatBufferBuilder builder, int y)
		{
			builder.AddInt(2, y, 0);
		}

		// Token: 0x0602E32E RID: 189230 RVA: 0x0064F203 File Offset: 0x0064D403
		public static void AddZ(FlatBufferBuilder builder, int z)
		{
			builder.AddInt(3, z, 0);
		}

		// Token: 0x0602E32F RID: 189231 RVA: 0x0064F20E File Offset: 0x0064D40E
		public static void AddLauncher(FlatBufferBuilder builder, EBulletLauncher launcher)
		{
			builder.AddByte(4, (byte)launcher, 0);
		}

		// Token: 0x0602E330 RID: 189232 RVA: 0x0064F219 File Offset: 0x0064D419
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(5, nullMask, 0);
		}

		// Token: 0x0602E331 RID: 189233 RVA: 0x0064F224 File Offset: 0x0064D424
		public static Offset<IFireBulletEffect> EndIFireBulletEffect(FlatBufferBuilder builder)
		{
			return new Offset<IFireBulletEffect>(builder.EndTable());
		}

		// Token: 0x0602E332 RID: 189234 RVA: 0x0064F234 File Offset: 0x0064D434
		public IFireBulletEffectT UnPack()
		{
			IFireBulletEffectT fireBulletEffectT = new IFireBulletEffectT();
			this.UnPackTo(fireBulletEffectT);
			return fireBulletEffectT;
		}

		// Token: 0x0602E333 RID: 189235 RVA: 0x0064F250 File Offset: 0x0064D450
		public void UnPackTo(IFireBulletEffectT _o)
		{
			_o.Id = this.Id;
			_o.X = this.X;
			_o.Y = this.Y;
			_o.Z = this.Z;
			_o.Launcher = this.Launcher;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602E334 RID: 189236 RVA: 0x0064F2A8 File Offset: 0x0064D4A8
		public static Offset<IFireBulletEffect> Pack(FlatBufferBuilder builder, IFireBulletEffectT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFireBulletEffect>);
			}
			return IFireBulletEffect.CreateIFireBulletEffect(builder, _o.Id, _o.X, _o.Y, _o.Z, _o.Launcher, _o.NullMask);
		}

		// Token: 0x04010EBE RID: 69310
		private Table __p;
	}
}
