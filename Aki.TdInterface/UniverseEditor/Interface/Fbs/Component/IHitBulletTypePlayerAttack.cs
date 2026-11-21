using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005903 RID: 22787
	public struct IHitBulletTypePlayerAttack : IFlatbufferObject
	{
		// Token: 0x1700A542 RID: 42306
		// (get) Token: 0x06025066 RID: 151654 RVA: 0x00514CD9 File Offset: 0x00512ED9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06025067 RID: 151655 RVA: 0x00514CE6 File Offset: 0x00512EE6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06025068 RID: 151656 RVA: 0x00514CF0 File Offset: 0x00512EF0
		public static IHitBulletTypePlayerAttack GetRootAsIHitBulletTypePlayerAttack(ByteBuffer _bb)
		{
			return IHitBulletTypePlayerAttack.GetRootAsIHitBulletTypePlayerAttack(_bb, default(IHitBulletTypePlayerAttack));
		}

		// Token: 0x06025069 RID: 151657 RVA: 0x00514D0C File Offset: 0x00512F0C
		public static IHitBulletTypePlayerAttack GetRootAsIHitBulletTypePlayerAttack(ByteBuffer _bb, IHitBulletTypePlayerAttack obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602506A RID: 151658 RVA: 0x00514D29 File Offset: 0x00512F29
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602506B RID: 151659 RVA: 0x00514D38 File Offset: 0x00512F38
		public IHitBulletTypePlayerAttack __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A543 RID: 42307
		// (get) Token: 0x0602506C RID: 151660 RVA: 0x00514D48 File Offset: 0x00512F48
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

		// Token: 0x0602506D RID: 151661 RVA: 0x00514D84 File Offset: 0x00512F84
		public static Offset<IHitBulletTypePlayerAttack> CreateIHitBulletTypePlayerAttack(FlatBufferBuilder builder, EHitBulletType Type = EHitBulletType.OnlyDropAttack)
		{
			builder.StartTable(1);
			IHitBulletTypePlayerAttack.AddType(builder, Type);
			return IHitBulletTypePlayerAttack.EndIHitBulletTypePlayerAttack(builder);
		}

		// Token: 0x0602506E RID: 151662 RVA: 0x00514D9A File Offset: 0x00512F9A
		public static void StartIHitBulletTypePlayerAttack(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602506F RID: 151663 RVA: 0x00514DA3 File Offset: 0x00512FA3
		public static void AddType(FlatBufferBuilder builder, EHitBulletType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06025070 RID: 151664 RVA: 0x00514DAE File Offset: 0x00512FAE
		public static Offset<IHitBulletTypePlayerAttack> EndIHitBulletTypePlayerAttack(FlatBufferBuilder builder)
		{
			return new Offset<IHitBulletTypePlayerAttack>(builder.EndTable());
		}

		// Token: 0x06025071 RID: 151665 RVA: 0x00514DBC File Offset: 0x00512FBC
		public IHitBulletTypePlayerAttackT UnPack()
		{
			IHitBulletTypePlayerAttackT hitBulletTypePlayerAttackT = new IHitBulletTypePlayerAttackT();
			this.UnPackTo(hitBulletTypePlayerAttackT);
			return hitBulletTypePlayerAttackT;
		}

		// Token: 0x06025072 RID: 151666 RVA: 0x00514DD7 File Offset: 0x00512FD7
		public void UnPackTo(IHitBulletTypePlayerAttackT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06025073 RID: 151667 RVA: 0x00514DE8 File Offset: 0x00512FE8
		public static Offset<IHitBulletTypePlayerAttack> Pack(FlatBufferBuilder builder, IHitBulletTypePlayerAttackT _o)
		{
			if (_o == null)
			{
				return default(Offset<IHitBulletTypePlayerAttack>);
			}
			return IHitBulletTypePlayerAttack.CreateIHitBulletTypePlayerAttack(builder, _o.Type);
		}

		// Token: 0x0400F18A RID: 61834
		private Table __p;
	}
}
