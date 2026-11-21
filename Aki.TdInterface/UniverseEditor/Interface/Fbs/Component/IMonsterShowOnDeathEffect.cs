using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005B3D RID: 23357
	public struct IMonsterShowOnDeathEffect : IFlatbufferObject
	{
		// Token: 0x1700AA6B RID: 43627
		// (get) Token: 0x06026690 RID: 157328 RVA: 0x00542A46 File Offset: 0x00540C46
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06026691 RID: 157329 RVA: 0x00542A53 File Offset: 0x00540C53
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06026692 RID: 157330 RVA: 0x00542A5C File Offset: 0x00540C5C
		public static IMonsterShowOnDeathEffect GetRootAsIMonsterShowOnDeathEffect(ByteBuffer _bb)
		{
			return IMonsterShowOnDeathEffect.GetRootAsIMonsterShowOnDeathEffect(_bb, default(IMonsterShowOnDeathEffect));
		}

		// Token: 0x06026693 RID: 157331 RVA: 0x00542A78 File Offset: 0x00540C78
		public static IMonsterShowOnDeathEffect GetRootAsIMonsterShowOnDeathEffect(ByteBuffer _bb, IMonsterShowOnDeathEffect obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06026694 RID: 157332 RVA: 0x00542A95 File Offset: 0x00540C95
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06026695 RID: 157333 RVA: 0x00542AA4 File Offset: 0x00540CA4
		public IMonsterShowOnDeathEffect __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700AA6C RID: 43628
		// (get) Token: 0x06026696 RID: 157334 RVA: 0x00542AB4 File Offset: 0x00540CB4
		public EMonsterShowOnDeathType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EMonsterShowOnDeathType.Effect;
				}
				return (EMonsterShowOnDeathType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700AA6D RID: 43629
		// (get) Token: 0x06026697 RID: 157335 RVA: 0x00542AF0 File Offset: 0x00540CF0
		public int EffectId
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

		// Token: 0x06026698 RID: 157336 RVA: 0x00542B2C File Offset: 0x00540D2C
		public static Offset<IMonsterShowOnDeathEffect> CreateIMonsterShowOnDeathEffect(FlatBufferBuilder builder, EMonsterShowOnDeathType Type = EMonsterShowOnDeathType.Effect, int EffectId = 0)
		{
			builder.StartTable(2);
			IMonsterShowOnDeathEffect.AddEffectId(builder, EffectId);
			IMonsterShowOnDeathEffect.AddType(builder, Type);
			return IMonsterShowOnDeathEffect.EndIMonsterShowOnDeathEffect(builder);
		}

		// Token: 0x06026699 RID: 157337 RVA: 0x00542B49 File Offset: 0x00540D49
		public static void StartIMonsterShowOnDeathEffect(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602669A RID: 157338 RVA: 0x00542B52 File Offset: 0x00540D52
		public static void AddType(FlatBufferBuilder builder, EMonsterShowOnDeathType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602669B RID: 157339 RVA: 0x00542B5D File Offset: 0x00540D5D
		public static void AddEffectId(FlatBufferBuilder builder, int effectId)
		{
			builder.AddInt(1, effectId, 0);
		}

		// Token: 0x0602669C RID: 157340 RVA: 0x00542B68 File Offset: 0x00540D68
		public static Offset<IMonsterShowOnDeathEffect> EndIMonsterShowOnDeathEffect(FlatBufferBuilder builder)
		{
			return new Offset<IMonsterShowOnDeathEffect>(builder.EndTable());
		}

		// Token: 0x0602669D RID: 157341 RVA: 0x00542B78 File Offset: 0x00540D78
		public IMonsterShowOnDeathEffectT UnPack()
		{
			IMonsterShowOnDeathEffectT monsterShowOnDeathEffectT = new IMonsterShowOnDeathEffectT();
			this.UnPackTo(monsterShowOnDeathEffectT);
			return monsterShowOnDeathEffectT;
		}

		// Token: 0x0602669E RID: 157342 RVA: 0x00542B93 File Offset: 0x00540D93
		public void UnPackTo(IMonsterShowOnDeathEffectT _o)
		{
			_o.Type = this.Type;
			_o.EffectId = this.EffectId;
		}

		// Token: 0x0602669F RID: 157343 RVA: 0x00542BB0 File Offset: 0x00540DB0
		public static Offset<IMonsterShowOnDeathEffect> Pack(FlatBufferBuilder builder, IMonsterShowOnDeathEffectT _o)
		{
			if (_o == null)
			{
				return default(Offset<IMonsterShowOnDeathEffect>);
			}
			return IMonsterShowOnDeathEffect.CreateIMonsterShowOnDeathEffect(builder, _o.Type, _o.EffectId);
		}

		// Token: 0x0400F531 RID: 62769
		private Table __p;
	}
}
