using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200537D RID: 21373
	public struct IHitBulletTypePlayerAttack : IFlatbufferObject
	{
		// Token: 0x17009D0A RID: 40202
		// (get) Token: 0x06022FB2 RID: 143282 RVA: 0x004D7E05 File Offset: 0x004D6005
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06022FB3 RID: 143283 RVA: 0x004D7E12 File Offset: 0x004D6012
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06022FB4 RID: 143284 RVA: 0x004D7E1C File Offset: 0x004D601C
		public static IHitBulletTypePlayerAttack GetRootAsIHitBulletTypePlayerAttack(ByteBuffer _bb)
		{
			return IHitBulletTypePlayerAttack.GetRootAsIHitBulletTypePlayerAttack(_bb, default(IHitBulletTypePlayerAttack));
		}

		// Token: 0x06022FB5 RID: 143285 RVA: 0x004D7E38 File Offset: 0x004D6038
		public static IHitBulletTypePlayerAttack GetRootAsIHitBulletTypePlayerAttack(ByteBuffer _bb, IHitBulletTypePlayerAttack obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06022FB6 RID: 143286 RVA: 0x004D7E55 File Offset: 0x004D6055
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06022FB7 RID: 143287 RVA: 0x004D7E64 File Offset: 0x004D6064
		public IHitBulletTypePlayerAttack __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009D0B RID: 40203
		// (get) Token: 0x06022FB8 RID: 143288 RVA: 0x004D7E74 File Offset: 0x004D6074
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

		// Token: 0x06022FB9 RID: 143289 RVA: 0x004D7EB0 File Offset: 0x004D60B0
		public static Offset<IHitBulletTypePlayerAttack> CreateIHitBulletTypePlayerAttack(FlatBufferBuilder builder, EHitBulletType Type = EHitBulletType.OnlyDropAttack)
		{
			builder.StartTable(1);
			IHitBulletTypePlayerAttack.AddType(builder, Type);
			return IHitBulletTypePlayerAttack.EndIHitBulletTypePlayerAttack(builder);
		}

		// Token: 0x06022FBA RID: 143290 RVA: 0x004D7EC6 File Offset: 0x004D60C6
		public static void StartIHitBulletTypePlayerAttack(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06022FBB RID: 143291 RVA: 0x004D7ECF File Offset: 0x004D60CF
		public static void AddType(FlatBufferBuilder builder, EHitBulletType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06022FBC RID: 143292 RVA: 0x004D7EDA File Offset: 0x004D60DA
		public static Offset<IHitBulletTypePlayerAttack> EndIHitBulletTypePlayerAttack(FlatBufferBuilder builder)
		{
			return new Offset<IHitBulletTypePlayerAttack>(builder.EndTable());
		}

		// Token: 0x06022FBD RID: 143293 RVA: 0x004D7EE8 File Offset: 0x004D60E8
		public IHitBulletTypePlayerAttackT UnPack()
		{
			IHitBulletTypePlayerAttackT hitBulletTypePlayerAttackT = new IHitBulletTypePlayerAttackT();
			this.UnPackTo(hitBulletTypePlayerAttackT);
			return hitBulletTypePlayerAttackT;
		}

		// Token: 0x06022FBE RID: 143294 RVA: 0x004D7F03 File Offset: 0x004D6103
		public void UnPackTo(IHitBulletTypePlayerAttackT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06022FBF RID: 143295 RVA: 0x004D7F14 File Offset: 0x004D6114
		public static Offset<IHitBulletTypePlayerAttack> Pack(FlatBufferBuilder builder, IHitBulletTypePlayerAttackT _o)
		{
			if (_o == null)
			{
				return default(Offset<IHitBulletTypePlayerAttack>);
			}
			return IHitBulletTypePlayerAttack.CreateIHitBulletTypePlayerAttack(builder, _o.Type);
		}

		// Token: 0x0400E55A RID: 58714
		private Table __p;
	}
}
