using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005380 RID: 21376
	public struct IHitBulletTypePlayerOrThrenodianAttack : IFlatbufferObject
	{
		// Token: 0x17009D0D RID: 40205
		// (get) Token: 0x06022FC4 RID: 143300 RVA: 0x004D7F7D File Offset: 0x004D617D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06022FC5 RID: 143301 RVA: 0x004D7F8A File Offset: 0x004D618A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06022FC6 RID: 143302 RVA: 0x004D7F94 File Offset: 0x004D6194
		public static IHitBulletTypePlayerOrThrenodianAttack GetRootAsIHitBulletTypePlayerOrThrenodianAttack(ByteBuffer _bb)
		{
			return IHitBulletTypePlayerOrThrenodianAttack.GetRootAsIHitBulletTypePlayerOrThrenodianAttack(_bb, default(IHitBulletTypePlayerOrThrenodianAttack));
		}

		// Token: 0x06022FC7 RID: 143303 RVA: 0x004D7FB0 File Offset: 0x004D61B0
		public static IHitBulletTypePlayerOrThrenodianAttack GetRootAsIHitBulletTypePlayerOrThrenodianAttack(ByteBuffer _bb, IHitBulletTypePlayerOrThrenodianAttack obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06022FC8 RID: 143304 RVA: 0x004D7FCD File Offset: 0x004D61CD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06022FC9 RID: 143305 RVA: 0x004D7FDC File Offset: 0x004D61DC
		public IHitBulletTypePlayerOrThrenodianAttack __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009D0E RID: 40206
		// (get) Token: 0x06022FCA RID: 143306 RVA: 0x004D7FEC File Offset: 0x004D61EC
		public EHitBulletType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EHitBulletType.OnlyDropAttack;
				}
				return (EHitBulletType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06022FCB RID: 143307 RVA: 0x004D8028 File Offset: 0x004D6228
		public static Offset<IHitBulletTypePlayerOrThrenodianAttack> CreateIHitBulletTypePlayerOrThrenodianAttack(FlatBufferBuilder builder, EHitBulletType Type = EHitBulletType.OnlyDropAttack)
		{
			builder.StartTable(1);
			IHitBulletTypePlayerOrThrenodianAttack.AddType(builder, Type);
			return IHitBulletTypePlayerOrThrenodianAttack.EndIHitBulletTypePlayerOrThrenodianAttack(builder);
		}

		// Token: 0x06022FCC RID: 143308 RVA: 0x004D803E File Offset: 0x004D623E
		public static void StartIHitBulletTypePlayerOrThrenodianAttack(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06022FCD RID: 143309 RVA: 0x004D8047 File Offset: 0x004D6247
		public static void AddType(FlatBufferBuilder builder, EHitBulletType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06022FCE RID: 143310 RVA: 0x004D8052 File Offset: 0x004D6252
		public static Offset<IHitBulletTypePlayerOrThrenodianAttack> EndIHitBulletTypePlayerOrThrenodianAttack(FlatBufferBuilder builder)
		{
			return new Offset<IHitBulletTypePlayerOrThrenodianAttack>(builder.EndTable());
		}

		// Token: 0x06022FCF RID: 143311 RVA: 0x004D8060 File Offset: 0x004D6260
		public IHitBulletTypePlayerOrThrenodianAttackT UnPack()
		{
			IHitBulletTypePlayerOrThrenodianAttackT hitBulletTypePlayerOrThrenodianAttackT = new IHitBulletTypePlayerOrThrenodianAttackT();
			this.UnPackTo(hitBulletTypePlayerOrThrenodianAttackT);
			return hitBulletTypePlayerOrThrenodianAttackT;
		}

		// Token: 0x06022FD0 RID: 143312 RVA: 0x004D807B File Offset: 0x004D627B
		public void UnPackTo(IHitBulletTypePlayerOrThrenodianAttackT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06022FD1 RID: 143313 RVA: 0x004D808C File Offset: 0x004D628C
		public static Offset<IHitBulletTypePlayerOrThrenodianAttack> Pack(FlatBufferBuilder builder, IHitBulletTypePlayerOrThrenodianAttackT _o)
		{
			if (_o == null)
			{
				return default(Offset<IHitBulletTypePlayerOrThrenodianAttack>);
			}
			return IHitBulletTypePlayerOrThrenodianAttack.CreateIHitBulletTypePlayerOrThrenodianAttack(builder, _o.Type);
		}

		// Token: 0x0400E55C RID: 58716
		private Table __p;
	}
}
