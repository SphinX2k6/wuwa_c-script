using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005900 RID: 22784
	public struct IHitBulletTypeOnlyDropAttack : IFlatbufferObject
	{
		// Token: 0x1700A53F RID: 42303
		// (get) Token: 0x06025054 RID: 151636 RVA: 0x00514B62 File Offset: 0x00512D62
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06025055 RID: 151637 RVA: 0x00514B6F File Offset: 0x00512D6F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06025056 RID: 151638 RVA: 0x00514B78 File Offset: 0x00512D78
		public static IHitBulletTypeOnlyDropAttack GetRootAsIHitBulletTypeOnlyDropAttack(ByteBuffer _bb)
		{
			return IHitBulletTypeOnlyDropAttack.GetRootAsIHitBulletTypeOnlyDropAttack(_bb, default(IHitBulletTypeOnlyDropAttack));
		}

		// Token: 0x06025057 RID: 151639 RVA: 0x00514B94 File Offset: 0x00512D94
		public static IHitBulletTypeOnlyDropAttack GetRootAsIHitBulletTypeOnlyDropAttack(ByteBuffer _bb, IHitBulletTypeOnlyDropAttack obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06025058 RID: 151640 RVA: 0x00514BB1 File Offset: 0x00512DB1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06025059 RID: 151641 RVA: 0x00514BC0 File Offset: 0x00512DC0
		public IHitBulletTypeOnlyDropAttack __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A540 RID: 42304
		// (get) Token: 0x0602505A RID: 151642 RVA: 0x00514BD0 File Offset: 0x00512DD0
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

		// Token: 0x0602505B RID: 151643 RVA: 0x00514C0C File Offset: 0x00512E0C
		public static Offset<IHitBulletTypeOnlyDropAttack> CreateIHitBulletTypeOnlyDropAttack(FlatBufferBuilder builder, EHitBulletType Type = EHitBulletType.OnlyDropAttack)
		{
			builder.StartTable(1);
			IHitBulletTypeOnlyDropAttack.AddType(builder, Type);
			return IHitBulletTypeOnlyDropAttack.EndIHitBulletTypeOnlyDropAttack(builder);
		}

		// Token: 0x0602505C RID: 151644 RVA: 0x00514C22 File Offset: 0x00512E22
		public static void StartIHitBulletTypeOnlyDropAttack(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602505D RID: 151645 RVA: 0x00514C2B File Offset: 0x00512E2B
		public static void AddType(FlatBufferBuilder builder, EHitBulletType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602505E RID: 151646 RVA: 0x00514C36 File Offset: 0x00512E36
		public static Offset<IHitBulletTypeOnlyDropAttack> EndIHitBulletTypeOnlyDropAttack(FlatBufferBuilder builder)
		{
			return new Offset<IHitBulletTypeOnlyDropAttack>(builder.EndTable());
		}

		// Token: 0x0602505F RID: 151647 RVA: 0x00514C44 File Offset: 0x00512E44
		public IHitBulletTypeOnlyDropAttackT UnPack()
		{
			IHitBulletTypeOnlyDropAttackT hitBulletTypeOnlyDropAttackT = new IHitBulletTypeOnlyDropAttackT();
			this.UnPackTo(hitBulletTypeOnlyDropAttackT);
			return hitBulletTypeOnlyDropAttackT;
		}

		// Token: 0x06025060 RID: 151648 RVA: 0x00514C5F File Offset: 0x00512E5F
		public void UnPackTo(IHitBulletTypeOnlyDropAttackT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06025061 RID: 151649 RVA: 0x00514C70 File Offset: 0x00512E70
		public static Offset<IHitBulletTypeOnlyDropAttack> Pack(FlatBufferBuilder builder, IHitBulletTypeOnlyDropAttackT _o)
		{
			if (_o == null)
			{
				return default(Offset<IHitBulletTypeOnlyDropAttack>);
			}
			return IHitBulletTypeOnlyDropAttack.CreateIHitBulletTypeOnlyDropAttack(builder, _o.Type);
		}

		// Token: 0x0400F188 RID: 61832
		private Table __p;
	}
}
