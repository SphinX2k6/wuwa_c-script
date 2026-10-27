using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020045C0 RID: 17856
	public struct ITrapDefenseSpawnMonsterConditionBase : IFlatbufferObject
	{
		// Token: 0x17007EEF RID: 32495
		// (get) Token: 0x0601B01F RID: 110623 RVA: 0x003D9B2D File Offset: 0x003D7D2D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601B020 RID: 110624 RVA: 0x003D9B3A File Offset: 0x003D7D3A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601B021 RID: 110625 RVA: 0x003D9B44 File Offset: 0x003D7D44
		public static ITrapDefenseSpawnMonsterConditionBase GetRootAsITrapDefenseSpawnMonsterConditionBase(ByteBuffer _bb)
		{
			return ITrapDefenseSpawnMonsterConditionBase.GetRootAsITrapDefenseSpawnMonsterConditionBase(_bb, default(ITrapDefenseSpawnMonsterConditionBase));
		}

		// Token: 0x0601B022 RID: 110626 RVA: 0x003D9B60 File Offset: 0x003D7D60
		public static ITrapDefenseSpawnMonsterConditionBase GetRootAsITrapDefenseSpawnMonsterConditionBase(ByteBuffer _bb, ITrapDefenseSpawnMonsterConditionBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601B023 RID: 110627 RVA: 0x003D9B7D File Offset: 0x003D7D7D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601B024 RID: 110628 RVA: 0x003D9B8C File Offset: 0x003D7D8C
		public ITrapDefenseSpawnMonsterConditionBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007EF0 RID: 32496
		// (get) Token: 0x0601B025 RID: 110629 RVA: 0x003D9B9C File Offset: 0x003D7D9C
		public ETrapDefenseSpawnMonsterCondition Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ETrapDefenseSpawnMonsterCondition.Completed;
				}
				return (ETrapDefenseSpawnMonsterCondition)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601B026 RID: 110630 RVA: 0x003D9BD8 File Offset: 0x003D7DD8
		public static Offset<ITrapDefenseSpawnMonsterConditionBase> CreateITrapDefenseSpawnMonsterConditionBase(FlatBufferBuilder builder, ETrapDefenseSpawnMonsterCondition Type = ETrapDefenseSpawnMonsterCondition.Completed)
		{
			builder.StartTable(1);
			ITrapDefenseSpawnMonsterConditionBase.AddType(builder, Type);
			return ITrapDefenseSpawnMonsterConditionBase.EndITrapDefenseSpawnMonsterConditionBase(builder);
		}

		// Token: 0x0601B027 RID: 110631 RVA: 0x003D9BEE File Offset: 0x003D7DEE
		public static void StartITrapDefenseSpawnMonsterConditionBase(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601B028 RID: 110632 RVA: 0x003D9BF7 File Offset: 0x003D7DF7
		public static void AddType(FlatBufferBuilder builder, ETrapDefenseSpawnMonsterCondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601B029 RID: 110633 RVA: 0x003D9C02 File Offset: 0x003D7E02
		public static Offset<ITrapDefenseSpawnMonsterConditionBase> EndITrapDefenseSpawnMonsterConditionBase(FlatBufferBuilder builder)
		{
			return new Offset<ITrapDefenseSpawnMonsterConditionBase>(builder.EndTable());
		}

		// Token: 0x0601B02A RID: 110634 RVA: 0x003D9C10 File Offset: 0x003D7E10
		public ITrapDefenseSpawnMonsterConditionBaseT UnPack()
		{
			ITrapDefenseSpawnMonsterConditionBaseT trapDefenseSpawnMonsterConditionBaseT = new ITrapDefenseSpawnMonsterConditionBaseT();
			this.UnPackTo(trapDefenseSpawnMonsterConditionBaseT);
			return trapDefenseSpawnMonsterConditionBaseT;
		}

		// Token: 0x0601B02B RID: 110635 RVA: 0x003D9C2B File Offset: 0x003D7E2B
		public void UnPackTo(ITrapDefenseSpawnMonsterConditionBaseT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0601B02C RID: 110636 RVA: 0x003D9C3C File Offset: 0x003D7E3C
		public static Offset<ITrapDefenseSpawnMonsterConditionBase> Pack(FlatBufferBuilder builder, ITrapDefenseSpawnMonsterConditionBaseT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITrapDefenseSpawnMonsterConditionBase>);
			}
			return ITrapDefenseSpawnMonsterConditionBase.CreateITrapDefenseSpawnMonsterConditionBase(builder, _o.Type);
		}

		// Token: 0x0400C68D RID: 50829
		private Table __p;
	}
}
