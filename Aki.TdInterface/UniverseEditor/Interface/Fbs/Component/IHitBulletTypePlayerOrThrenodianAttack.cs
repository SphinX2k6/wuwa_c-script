using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005906 RID: 22790
	public struct IHitBulletTypePlayerOrThrenodianAttack : IFlatbufferObject
	{
		// Token: 0x1700A545 RID: 42309
		// (get) Token: 0x06025078 RID: 151672 RVA: 0x00514E51 File Offset: 0x00513051
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06025079 RID: 151673 RVA: 0x00514E5E File Offset: 0x0051305E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602507A RID: 151674 RVA: 0x00514E68 File Offset: 0x00513068
		public static IHitBulletTypePlayerOrThrenodianAttack GetRootAsIHitBulletTypePlayerOrThrenodianAttack(ByteBuffer _bb)
		{
			return IHitBulletTypePlayerOrThrenodianAttack.GetRootAsIHitBulletTypePlayerOrThrenodianAttack(_bb, default(IHitBulletTypePlayerOrThrenodianAttack));
		}

		// Token: 0x0602507B RID: 151675 RVA: 0x00514E84 File Offset: 0x00513084
		public static IHitBulletTypePlayerOrThrenodianAttack GetRootAsIHitBulletTypePlayerOrThrenodianAttack(ByteBuffer _bb, IHitBulletTypePlayerOrThrenodianAttack obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602507C RID: 151676 RVA: 0x00514EA1 File Offset: 0x005130A1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602507D RID: 151677 RVA: 0x00514EB0 File Offset: 0x005130B0
		public IHitBulletTypePlayerOrThrenodianAttack __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A546 RID: 42310
		// (get) Token: 0x0602507E RID: 151678 RVA: 0x00514EC0 File Offset: 0x005130C0
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

		// Token: 0x0602507F RID: 151679 RVA: 0x00514EFC File Offset: 0x005130FC
		public static Offset<IHitBulletTypePlayerOrThrenodianAttack> CreateIHitBulletTypePlayerOrThrenodianAttack(FlatBufferBuilder builder, EHitBulletType Type = EHitBulletType.OnlyDropAttack)
		{
			builder.StartTable(1);
			IHitBulletTypePlayerOrThrenodianAttack.AddType(builder, Type);
			return IHitBulletTypePlayerOrThrenodianAttack.EndIHitBulletTypePlayerOrThrenodianAttack(builder);
		}

		// Token: 0x06025080 RID: 151680 RVA: 0x00514F12 File Offset: 0x00513112
		public static void StartIHitBulletTypePlayerOrThrenodianAttack(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06025081 RID: 151681 RVA: 0x00514F1B File Offset: 0x0051311B
		public static void AddType(FlatBufferBuilder builder, EHitBulletType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06025082 RID: 151682 RVA: 0x00514F26 File Offset: 0x00513126
		public static Offset<IHitBulletTypePlayerOrThrenodianAttack> EndIHitBulletTypePlayerOrThrenodianAttack(FlatBufferBuilder builder)
		{
			return new Offset<IHitBulletTypePlayerOrThrenodianAttack>(builder.EndTable());
		}

		// Token: 0x06025083 RID: 151683 RVA: 0x00514F34 File Offset: 0x00513134
		public IHitBulletTypePlayerOrThrenodianAttackT UnPack()
		{
			IHitBulletTypePlayerOrThrenodianAttackT hitBulletTypePlayerOrThrenodianAttackT = new IHitBulletTypePlayerOrThrenodianAttackT();
			this.UnPackTo(hitBulletTypePlayerOrThrenodianAttackT);
			return hitBulletTypePlayerOrThrenodianAttackT;
		}

		// Token: 0x06025084 RID: 151684 RVA: 0x00514F4F File Offset: 0x0051314F
		public void UnPackTo(IHitBulletTypePlayerOrThrenodianAttackT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06025085 RID: 151685 RVA: 0x00514F60 File Offset: 0x00513160
		public static Offset<IHitBulletTypePlayerOrThrenodianAttack> Pack(FlatBufferBuilder builder, IHitBulletTypePlayerOrThrenodianAttackT _o)
		{
			if (_o == null)
			{
				return default(Offset<IHitBulletTypePlayerOrThrenodianAttack>);
			}
			return IHitBulletTypePlayerOrThrenodianAttack.CreateIHitBulletTypePlayerOrThrenodianAttack(builder, _o.Type);
		}

		// Token: 0x0400F18C RID: 61836
		private Table __p;
	}
}
