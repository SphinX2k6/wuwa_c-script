using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020058F7 RID: 22775
	public struct IHitBulletTypeAllCharacterAttack : IFlatbufferObject
	{
		// Token: 0x1700A52E RID: 42286
		// (get) Token: 0x06025006 RID: 151558 RVA: 0x0051430D File Offset: 0x0051250D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06025007 RID: 151559 RVA: 0x0051431A File Offset: 0x0051251A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06025008 RID: 151560 RVA: 0x00514324 File Offset: 0x00512524
		public static IHitBulletTypeAllCharacterAttack GetRootAsIHitBulletTypeAllCharacterAttack(ByteBuffer _bb)
		{
			return IHitBulletTypeAllCharacterAttack.GetRootAsIHitBulletTypeAllCharacterAttack(_bb, default(IHitBulletTypeAllCharacterAttack));
		}

		// Token: 0x06025009 RID: 151561 RVA: 0x00514340 File Offset: 0x00512540
		public static IHitBulletTypeAllCharacterAttack GetRootAsIHitBulletTypeAllCharacterAttack(ByteBuffer _bb, IHitBulletTypeAllCharacterAttack obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602500A RID: 151562 RVA: 0x0051435D File Offset: 0x0051255D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602500B RID: 151563 RVA: 0x0051436C File Offset: 0x0051256C
		public IHitBulletTypeAllCharacterAttack __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A52F RID: 42287
		// (get) Token: 0x0602500C RID: 151564 RVA: 0x0051437C File Offset: 0x0051257C
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

		// Token: 0x0602500D RID: 151565 RVA: 0x005143B8 File Offset: 0x005125B8
		public static Offset<IHitBulletTypeAllCharacterAttack> CreateIHitBulletTypeAllCharacterAttack(FlatBufferBuilder builder, EHitBulletType Type = EHitBulletType.OnlyDropAttack)
		{
			builder.StartTable(1);
			IHitBulletTypeAllCharacterAttack.AddType(builder, Type);
			return IHitBulletTypeAllCharacterAttack.EndIHitBulletTypeAllCharacterAttack(builder);
		}

		// Token: 0x0602500E RID: 151566 RVA: 0x005143CE File Offset: 0x005125CE
		public static void StartIHitBulletTypeAllCharacterAttack(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602500F RID: 151567 RVA: 0x005143D7 File Offset: 0x005125D7
		public static void AddType(FlatBufferBuilder builder, EHitBulletType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06025010 RID: 151568 RVA: 0x005143E2 File Offset: 0x005125E2
		public static Offset<IHitBulletTypeAllCharacterAttack> EndIHitBulletTypeAllCharacterAttack(FlatBufferBuilder builder)
		{
			return new Offset<IHitBulletTypeAllCharacterAttack>(builder.EndTable());
		}

		// Token: 0x06025011 RID: 151569 RVA: 0x005143F0 File Offset: 0x005125F0
		public IHitBulletTypeAllCharacterAttackT UnPack()
		{
			IHitBulletTypeAllCharacterAttackT hitBulletTypeAllCharacterAttackT = new IHitBulletTypeAllCharacterAttackT();
			this.UnPackTo(hitBulletTypeAllCharacterAttackT);
			return hitBulletTypeAllCharacterAttackT;
		}

		// Token: 0x06025012 RID: 151570 RVA: 0x0051440B File Offset: 0x0051260B
		public void UnPackTo(IHitBulletTypeAllCharacterAttackT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06025013 RID: 151571 RVA: 0x0051441C File Offset: 0x0051261C
		public static Offset<IHitBulletTypeAllCharacterAttack> Pack(FlatBufferBuilder builder, IHitBulletTypeAllCharacterAttackT _o)
		{
			if (_o == null)
			{
				return default(Offset<IHitBulletTypeAllCharacterAttack>);
			}
			return IHitBulletTypeAllCharacterAttack.CreateIHitBulletTypeAllCharacterAttack(builder, _o.Type);
		}

		// Token: 0x0400F17E RID: 61822
		private Table __p;
	}
}
