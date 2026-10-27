using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020067B0 RID: 26544
	public struct IFireBullet : IFlatbufferObject
	{
		// Token: 0x1700C4FC RID: 50428
		// (get) Token: 0x0602E2FE RID: 189182 RVA: 0x0064EB4E File Offset: 0x0064CD4E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602E2FF RID: 189183 RVA: 0x0064EB5B File Offset: 0x0064CD5B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602E300 RID: 189184 RVA: 0x0064EB64 File Offset: 0x0064CD64
		public static IFireBullet GetRootAsIFireBullet(ByteBuffer _bb)
		{
			return IFireBullet.GetRootAsIFireBullet(_bb, default(IFireBullet));
		}

		// Token: 0x0602E301 RID: 189185 RVA: 0x0064EB80 File Offset: 0x0064CD80
		public static IFireBullet GetRootAsIFireBullet(ByteBuffer _bb, IFireBullet obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602E302 RID: 189186 RVA: 0x0064EB9D File Offset: 0x0064CD9D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602E303 RID: 189187 RVA: 0x0064EBAC File Offset: 0x0064CDAC
		public IFireBullet __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C4FD RID: 50429
		// (get) Token: 0x0602E304 RID: 189188 RVA: 0x0064EBBC File Offset: 0x0064CDBC
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

		// Token: 0x0602E305 RID: 189189 RVA: 0x0064EBF8 File Offset: 0x0064CDF8
		public TTable? Type<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0602E306 RID: 189190 RVA: 0x0064EC3C File Offset: 0x0064CE3C
		public IFireBulletForwardFront TypeAsIFireBulletForwardFront()
		{
			return this.Type<IFireBulletForwardFront>().Value;
		}

		// Token: 0x0602E307 RID: 189191 RVA: 0x0064EC58 File Offset: 0x0064CE58
		public IFireBulletTrackPosition TypeAsIFireBulletTrackPosition()
		{
			return this.Type<IFireBulletTrackPosition>().Value;
		}

		// Token: 0x0602E308 RID: 189192 RVA: 0x0064EC74 File Offset: 0x0064CE74
		public IFireBulletTrackTarget TypeAsIFireBulletTrackTarget()
		{
			return this.Type<IFireBulletTrackTarget>().Value;
		}

		// Token: 0x1700C4FE RID: 50430
		// (get) Token: 0x0602E309 RID: 189193 RVA: 0x0064EC90 File Offset: 0x0064CE90
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

		// Token: 0x1700C4FF RID: 50431
		// (get) Token: 0x0602E30A RID: 189194 RVA: 0x0064ECCC File Offset: 0x0064CECC
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

		// Token: 0x0602E30B RID: 189195 RVA: 0x0064ED09 File Offset: 0x0064CF09
		public static Offset<IFireBullet> CreateIFireBullet(FlatBufferBuilder builder, TFireBullet Type_type = TFireBullet.NONE, int TypeOffset = 0, EBulletLauncher Launcher = EBulletLauncher.Player, byte NullMask = 0)
		{
			builder.StartTable(4);
			IFireBullet.AddType(builder, TypeOffset);
			IFireBullet.AddNullMask(builder, NullMask);
			IFireBullet.AddLauncher(builder, Launcher);
			IFireBullet.AddTypeType(builder, Type_type);
			return IFireBullet.EndIFireBullet(builder);
		}

		// Token: 0x0602E30C RID: 189196 RVA: 0x0064ED35 File Offset: 0x0064CF35
		public static void StartIFireBullet(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0602E30D RID: 189197 RVA: 0x0064ED3E File Offset: 0x0064CF3E
		public static void AddTypeType(FlatBufferBuilder builder, TFireBullet typeType)
		{
			builder.AddByte(0, (byte)typeType, 0);
		}

		// Token: 0x0602E30E RID: 189198 RVA: 0x0064ED49 File Offset: 0x0064CF49
		public static void AddType(FlatBufferBuilder builder, int typeOffset)
		{
			builder.AddOffset(1, typeOffset, 0);
		}

		// Token: 0x0602E30F RID: 189199 RVA: 0x0064ED54 File Offset: 0x0064CF54
		public static void AddLauncher(FlatBufferBuilder builder, EBulletLauncher launcher)
		{
			builder.AddByte(2, (byte)launcher, 0);
		}

		// Token: 0x0602E310 RID: 189200 RVA: 0x0064ED5F File Offset: 0x0064CF5F
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x0602E311 RID: 189201 RVA: 0x0064ED6A File Offset: 0x0064CF6A
		public static Offset<IFireBullet> EndIFireBullet(FlatBufferBuilder builder)
		{
			return new Offset<IFireBullet>(builder.EndTable());
		}

		// Token: 0x0602E312 RID: 189202 RVA: 0x0064ED78 File Offset: 0x0064CF78
		public IFireBulletT UnPack()
		{
			IFireBulletT fireBulletT = new IFireBulletT();
			this.UnPackTo(fireBulletT);
			return fireBulletT;
		}

		// Token: 0x0602E313 RID: 189203 RVA: 0x0064ED94 File Offset: 0x0064CF94
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

		// Token: 0x0602E314 RID: 189204 RVA: 0x0064EE9C File Offset: 0x0064D09C
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

		// Token: 0x04010EBA RID: 69306
		private Table __p;
	}
}
