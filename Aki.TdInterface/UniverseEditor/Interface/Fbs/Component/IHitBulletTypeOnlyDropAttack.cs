using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200537A RID: 21370
	public struct IHitBulletTypeOnlyDropAttack : IFlatbufferObject
	{
		// Token: 0x17009D07 RID: 40199
		// (get) Token: 0x06022FA0 RID: 143264 RVA: 0x004D7C8E File Offset: 0x004D5E8E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06022FA1 RID: 143265 RVA: 0x004D7C9B File Offset: 0x004D5E9B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06022FA2 RID: 143266 RVA: 0x004D7CA4 File Offset: 0x004D5EA4
		public static IHitBulletTypeOnlyDropAttack GetRootAsIHitBulletTypeOnlyDropAttack(ByteBuffer _bb)
		{
			return IHitBulletTypeOnlyDropAttack.GetRootAsIHitBulletTypeOnlyDropAttack(_bb, default(IHitBulletTypeOnlyDropAttack));
		}

		// Token: 0x06022FA3 RID: 143267 RVA: 0x004D7CC0 File Offset: 0x004D5EC0
		public static IHitBulletTypeOnlyDropAttack GetRootAsIHitBulletTypeOnlyDropAttack(ByteBuffer _bb, IHitBulletTypeOnlyDropAttack obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06022FA4 RID: 143268 RVA: 0x004D7CDD File Offset: 0x004D5EDD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06022FA5 RID: 143269 RVA: 0x004D7CEC File Offset: 0x004D5EEC
		public IHitBulletTypeOnlyDropAttack __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009D08 RID: 40200
		// (get) Token: 0x06022FA6 RID: 143270 RVA: 0x004D7CFC File Offset: 0x004D5EFC
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

		// Token: 0x06022FA7 RID: 143271 RVA: 0x004D7D38 File Offset: 0x004D5F38
		public static Offset<IHitBulletTypeOnlyDropAttack> CreateIHitBulletTypeOnlyDropAttack(FlatBufferBuilder builder, EHitBulletType Type = EHitBulletType.OnlyDropAttack)
		{
			builder.StartTable(1);
			IHitBulletTypeOnlyDropAttack.AddType(builder, Type);
			return IHitBulletTypeOnlyDropAttack.EndIHitBulletTypeOnlyDropAttack(builder);
		}

		// Token: 0x06022FA8 RID: 143272 RVA: 0x004D7D4E File Offset: 0x004D5F4E
		public static void StartIHitBulletTypeOnlyDropAttack(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06022FA9 RID: 143273 RVA: 0x004D7D57 File Offset: 0x004D5F57
		public static void AddType(FlatBufferBuilder builder, EHitBulletType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06022FAA RID: 143274 RVA: 0x004D7D62 File Offset: 0x004D5F62
		public static Offset<IHitBulletTypeOnlyDropAttack> EndIHitBulletTypeOnlyDropAttack(FlatBufferBuilder builder)
		{
			return new Offset<IHitBulletTypeOnlyDropAttack>(builder.EndTable());
		}

		// Token: 0x06022FAB RID: 143275 RVA: 0x004D7D70 File Offset: 0x004D5F70
		public IHitBulletTypeOnlyDropAttackT UnPack()
		{
			IHitBulletTypeOnlyDropAttackT hitBulletTypeOnlyDropAttackT = new IHitBulletTypeOnlyDropAttackT();
			this.UnPackTo(hitBulletTypeOnlyDropAttackT);
			return hitBulletTypeOnlyDropAttackT;
		}

		// Token: 0x06022FAC RID: 143276 RVA: 0x004D7D8B File Offset: 0x004D5F8B
		public void UnPackTo(IHitBulletTypeOnlyDropAttackT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06022FAD RID: 143277 RVA: 0x004D7D9C File Offset: 0x004D5F9C
		public static Offset<IHitBulletTypeOnlyDropAttack> Pack(FlatBufferBuilder builder, IHitBulletTypeOnlyDropAttackT _o)
		{
			if (_o == null)
			{
				return default(Offset<IHitBulletTypeOnlyDropAttack>);
			}
			return IHitBulletTypeOnlyDropAttack.CreateIHitBulletTypeOnlyDropAttack(builder, _o.Type);
		}

		// Token: 0x0400E558 RID: 58712
		private Table __p;
	}
}
