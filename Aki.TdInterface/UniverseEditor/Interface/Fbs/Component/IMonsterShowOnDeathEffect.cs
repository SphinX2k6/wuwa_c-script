using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200559F RID: 21919
	public struct IMonsterShowOnDeathEffect : IFlatbufferObject
	{
		// Token: 0x1700A1E3 RID: 41443
		// (get) Token: 0x06024483 RID: 148611 RVA: 0x005024CE File Offset: 0x005006CE
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06024484 RID: 148612 RVA: 0x005024DB File Offset: 0x005006DB
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06024485 RID: 148613 RVA: 0x005024E4 File Offset: 0x005006E4
		public static IMonsterShowOnDeathEffect GetRootAsIMonsterShowOnDeathEffect(ByteBuffer _bb)
		{
			return IMonsterShowOnDeathEffect.GetRootAsIMonsterShowOnDeathEffect(_bb, default(IMonsterShowOnDeathEffect));
		}

		// Token: 0x06024486 RID: 148614 RVA: 0x00502500 File Offset: 0x00500700
		public static IMonsterShowOnDeathEffect GetRootAsIMonsterShowOnDeathEffect(ByteBuffer _bb, IMonsterShowOnDeathEffect obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06024487 RID: 148615 RVA: 0x0050251D File Offset: 0x0050071D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06024488 RID: 148616 RVA: 0x0050252C File Offset: 0x0050072C
		public IMonsterShowOnDeathEffect __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A1E4 RID: 41444
		// (get) Token: 0x06024489 RID: 148617 RVA: 0x0050253C File Offset: 0x0050073C
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

		// Token: 0x1700A1E5 RID: 41445
		// (get) Token: 0x0602448A RID: 148618 RVA: 0x00502578 File Offset: 0x00500778
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

		// Token: 0x0602448B RID: 148619 RVA: 0x005025B4 File Offset: 0x005007B4
		public static Offset<IMonsterShowOnDeathEffect> CreateIMonsterShowOnDeathEffect(FlatBufferBuilder builder, EMonsterShowOnDeathType Type = EMonsterShowOnDeathType.Effect, int EffectId = 0)
		{
			builder.StartTable(2);
			IMonsterShowOnDeathEffect.AddEffectId(builder, EffectId);
			IMonsterShowOnDeathEffect.AddType(builder, Type);
			return IMonsterShowOnDeathEffect.EndIMonsterShowOnDeathEffect(builder);
		}

		// Token: 0x0602448C RID: 148620 RVA: 0x005025D1 File Offset: 0x005007D1
		public static void StartIMonsterShowOnDeathEffect(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602448D RID: 148621 RVA: 0x005025DA File Offset: 0x005007DA
		public static void AddType(FlatBufferBuilder builder, EMonsterShowOnDeathType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602448E RID: 148622 RVA: 0x005025E5 File Offset: 0x005007E5
		public static void AddEffectId(FlatBufferBuilder builder, int effectId)
		{
			builder.AddInt(1, effectId, 0);
		}

		// Token: 0x0602448F RID: 148623 RVA: 0x005025F0 File Offset: 0x005007F0
		public static Offset<IMonsterShowOnDeathEffect> EndIMonsterShowOnDeathEffect(FlatBufferBuilder builder)
		{
			return new Offset<IMonsterShowOnDeathEffect>(builder.EndTable());
		}

		// Token: 0x06024490 RID: 148624 RVA: 0x00502600 File Offset: 0x00500800
		public IMonsterShowOnDeathEffectT UnPack()
		{
			IMonsterShowOnDeathEffectT monsterShowOnDeathEffectT = new IMonsterShowOnDeathEffectT();
			this.UnPackTo(monsterShowOnDeathEffectT);
			return monsterShowOnDeathEffectT;
		}

		// Token: 0x06024491 RID: 148625 RVA: 0x0050261B File Offset: 0x0050081B
		public void UnPackTo(IMonsterShowOnDeathEffectT _o)
		{
			_o.Type = this.Type;
			_o.EffectId = this.EffectId;
		}

		// Token: 0x06024492 RID: 148626 RVA: 0x00502638 File Offset: 0x00500838
		public static Offset<IMonsterShowOnDeathEffect> Pack(FlatBufferBuilder builder, IMonsterShowOnDeathEffectT _o)
		{
			if (_o == null)
			{
				return default(Offset<IMonsterShowOnDeathEffect>);
			}
			return IMonsterShowOnDeathEffect.CreateIMonsterShowOnDeathEffect(builder, _o.Type, _o.EffectId);
		}

		// Token: 0x0400E8CF RID: 59599
		private Table __p;
	}
}
