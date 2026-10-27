using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005371 RID: 21361
	public struct IHitBulletTypeAllCharacterAttack : IFlatbufferObject
	{
		// Token: 0x17009CF6 RID: 40182
		// (get) Token: 0x06022F52 RID: 143186 RVA: 0x004D7439 File Offset: 0x004D5639
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06022F53 RID: 143187 RVA: 0x004D7446 File Offset: 0x004D5646
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06022F54 RID: 143188 RVA: 0x004D7450 File Offset: 0x004D5650
		public static IHitBulletTypeAllCharacterAttack GetRootAsIHitBulletTypeAllCharacterAttack(ByteBuffer _bb)
		{
			return IHitBulletTypeAllCharacterAttack.GetRootAsIHitBulletTypeAllCharacterAttack(_bb, default(IHitBulletTypeAllCharacterAttack));
		}

		// Token: 0x06022F55 RID: 143189 RVA: 0x004D746C File Offset: 0x004D566C
		public static IHitBulletTypeAllCharacterAttack GetRootAsIHitBulletTypeAllCharacterAttack(ByteBuffer _bb, IHitBulletTypeAllCharacterAttack obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06022F56 RID: 143190 RVA: 0x004D7489 File Offset: 0x004D5689
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06022F57 RID: 143191 RVA: 0x004D7498 File Offset: 0x004D5698
		public IHitBulletTypeAllCharacterAttack __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009CF7 RID: 40183
		// (get) Token: 0x06022F58 RID: 143192 RVA: 0x004D74A8 File Offset: 0x004D56A8
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

		// Token: 0x06022F59 RID: 143193 RVA: 0x004D74E4 File Offset: 0x004D56E4
		public static Offset<IHitBulletTypeAllCharacterAttack> CreateIHitBulletTypeAllCharacterAttack(FlatBufferBuilder builder, EHitBulletType Type = EHitBulletType.OnlyDropAttack)
		{
			builder.StartTable(1);
			IHitBulletTypeAllCharacterAttack.AddType(builder, Type);
			return IHitBulletTypeAllCharacterAttack.EndIHitBulletTypeAllCharacterAttack(builder);
		}

		// Token: 0x06022F5A RID: 143194 RVA: 0x004D74FA File Offset: 0x004D56FA
		public static void StartIHitBulletTypeAllCharacterAttack(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06022F5B RID: 143195 RVA: 0x004D7503 File Offset: 0x004D5703
		public static void AddType(FlatBufferBuilder builder, EHitBulletType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06022F5C RID: 143196 RVA: 0x004D750E File Offset: 0x004D570E
		public static Offset<IHitBulletTypeAllCharacterAttack> EndIHitBulletTypeAllCharacterAttack(FlatBufferBuilder builder)
		{
			return new Offset<IHitBulletTypeAllCharacterAttack>(builder.EndTable());
		}

		// Token: 0x06022F5D RID: 143197 RVA: 0x004D751C File Offset: 0x004D571C
		public IHitBulletTypeAllCharacterAttackT UnPack()
		{
			IHitBulletTypeAllCharacterAttackT hitBulletTypeAllCharacterAttackT = new IHitBulletTypeAllCharacterAttackT();
			this.UnPackTo(hitBulletTypeAllCharacterAttackT);
			return hitBulletTypeAllCharacterAttackT;
		}

		// Token: 0x06022F5E RID: 143198 RVA: 0x004D7537 File Offset: 0x004D5737
		public void UnPackTo(IHitBulletTypeAllCharacterAttackT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06022F5F RID: 143199 RVA: 0x004D7548 File Offset: 0x004D5748
		public static Offset<IHitBulletTypeAllCharacterAttack> Pack(FlatBufferBuilder builder, IHitBulletTypeAllCharacterAttackT _o)
		{
			if (_o == null)
			{
				return default(Offset<IHitBulletTypeAllCharacterAttack>);
			}
			return IHitBulletTypeAllCharacterAttack.CreateIHitBulletTypeAllCharacterAttack(builder, _o.Type);
		}

		// Token: 0x0400E54E RID: 58702
		private Table __p;
	}
}
