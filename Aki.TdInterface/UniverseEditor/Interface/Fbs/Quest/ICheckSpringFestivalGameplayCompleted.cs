using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003D64 RID: 15716
	public struct ICheckSpringFestivalGameplayCompleted : IFlatbufferObject
	{
		// Token: 0x17006BDA RID: 27610
		// (get) Token: 0x06015BE7 RID: 89063 RVA: 0x00322CD6 File Offset: 0x00320ED6
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06015BE8 RID: 89064 RVA: 0x00322CE3 File Offset: 0x00320EE3
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06015BE9 RID: 89065 RVA: 0x00322CEC File Offset: 0x00320EEC
		public static ICheckSpringFestivalGameplayCompleted GetRootAsICheckSpringFestivalGameplayCompleted(ByteBuffer _bb)
		{
			return ICheckSpringFestivalGameplayCompleted.GetRootAsICheckSpringFestivalGameplayCompleted(_bb, default(ICheckSpringFestivalGameplayCompleted));
		}

		// Token: 0x06015BEA RID: 89066 RVA: 0x00322D08 File Offset: 0x00320F08
		public static ICheckSpringFestivalGameplayCompleted GetRootAsICheckSpringFestivalGameplayCompleted(ByteBuffer _bb, ICheckSpringFestivalGameplayCompleted obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06015BEB RID: 89067 RVA: 0x00322D25 File Offset: 0x00320F25
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06015BEC RID: 89068 RVA: 0x00322D34 File Offset: 0x00320F34
		public ICheckSpringFestivalGameplayCompleted __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006BDB RID: 27611
		// (get) Token: 0x06015BED RID: 89069 RVA: 0x00322D44 File Offset: 0x00320F44
		public EChildQuest Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EChildQuest.DoInteract;
				}
				return (EChildQuest)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17006BDC RID: 27612
		// (get) Token: 0x06015BEE RID: 89070 RVA: 0x00322D80 File Offset: 0x00320F80
		public IConditionGroup? PreConditions
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IConditionGroup?(default(IConditionGroup).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17006BDD RID: 27613
		// (get) Token: 0x06015BEF RID: 89071 RVA: 0x00322DE0 File Offset: 0x00320FE0
		public TCheckSpringFestivalGameplayType GameplayTypeType
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return TCheckSpringFestivalGameplayType.NONE;
				}
				return (TCheckSpringFestivalGameplayType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06015BF0 RID: 89072 RVA: 0x00322E1C File Offset: 0x0032101C
		public TTable? GameplayType<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06015BF1 RID: 89073 RVA: 0x00322E64 File Offset: 0x00321064
		public ICheckSpringFestivalGuessJokerCompleted GameplayTypeAsICheckSpringFestivalGuessJokerCompleted()
		{
			return this.GameplayType<ICheckSpringFestivalGuessJokerCompleted>().Value;
		}

		// Token: 0x06015BF2 RID: 89074 RVA: 0x00322E80 File Offset: 0x00321080
		public ICheckSpringFestivalMixDrinksCompleted GameplayTypeAsICheckSpringFestivalMixDrinksCompleted()
		{
			return this.GameplayType<ICheckSpringFestivalMixDrinksCompleted>().Value;
		}

		// Token: 0x06015BF3 RID: 89075 RVA: 0x00322E9B File Offset: 0x0032109B
		public static Offset<ICheckSpringFestivalGameplayCompleted> CreateICheckSpringFestivalGameplayCompleted(FlatBufferBuilder builder, EChildQuest Type = EChildQuest.DoInteract, Offset<IConditionGroup> PreConditionsOffset = default(Offset<IConditionGroup>), TCheckSpringFestivalGameplayType GameplayType_type = TCheckSpringFestivalGameplayType.NONE, int GameplayTypeOffset = 0)
		{
			builder.StartTable(4);
			ICheckSpringFestivalGameplayCompleted.AddGameplayType(builder, GameplayTypeOffset);
			ICheckSpringFestivalGameplayCompleted.AddPreConditions(builder, PreConditionsOffset);
			ICheckSpringFestivalGameplayCompleted.AddGameplayTypeType(builder, GameplayType_type);
			ICheckSpringFestivalGameplayCompleted.AddType(builder, Type);
			return ICheckSpringFestivalGameplayCompleted.EndICheckSpringFestivalGameplayCompleted(builder);
		}

		// Token: 0x06015BF4 RID: 89076 RVA: 0x00322EC7 File Offset: 0x003210C7
		public static void StartICheckSpringFestivalGameplayCompleted(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06015BF5 RID: 89077 RVA: 0x00322ED0 File Offset: 0x003210D0
		public static void AddType(FlatBufferBuilder builder, EChildQuest type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06015BF6 RID: 89078 RVA: 0x00322EDB File Offset: 0x003210DB
		public static void AddPreConditions(FlatBufferBuilder builder, Offset<IConditionGroup> preConditionsOffset)
		{
			builder.AddOffset(1, preConditionsOffset.Value, 0);
		}

		// Token: 0x06015BF7 RID: 89079 RVA: 0x00322EEB File Offset: 0x003210EB
		public static void AddGameplayTypeType(FlatBufferBuilder builder, TCheckSpringFestivalGameplayType gameplayTypeType)
		{
			builder.AddByte(2, (byte)gameplayTypeType, 0);
		}

		// Token: 0x06015BF8 RID: 89080 RVA: 0x00322EF6 File Offset: 0x003210F6
		public static void AddGameplayType(FlatBufferBuilder builder, int gameplayTypeOffset)
		{
			builder.AddOffset(3, gameplayTypeOffset, 0);
		}

		// Token: 0x06015BF9 RID: 89081 RVA: 0x00322F01 File Offset: 0x00321101
		public static Offset<ICheckSpringFestivalGameplayCompleted> EndICheckSpringFestivalGameplayCompleted(FlatBufferBuilder builder)
		{
			return new Offset<ICheckSpringFestivalGameplayCompleted>(builder.EndTable());
		}

		// Token: 0x06015BFA RID: 89082 RVA: 0x00322F10 File Offset: 0x00321110
		public ICheckSpringFestivalGameplayCompletedT UnPack()
		{
			ICheckSpringFestivalGameplayCompletedT checkSpringFestivalGameplayCompletedT = new ICheckSpringFestivalGameplayCompletedT();
			this.UnPackTo(checkSpringFestivalGameplayCompletedT);
			return checkSpringFestivalGameplayCompletedT;
		}

		// Token: 0x06015BFB RID: 89083 RVA: 0x00322F2C File Offset: 0x0032112C
		public void UnPackTo(ICheckSpringFestivalGameplayCompletedT _o)
		{
			_o.Type = this.Type;
			_o.PreConditions = ((this.PreConditions != null) ? this.PreConditions.Value.UnPack() : null);
			_o.GameplayType = new TCheckSpringFestivalGameplayTypeUnion();
			_o.GameplayType.Type = this.GameplayTypeType;
			TCheckSpringFestivalGameplayType gameplayTypeType = this.GameplayTypeType;
			if (gameplayTypeType == TCheckSpringFestivalGameplayType.ICheckSpringFestivalGuessJokerCompleted)
			{
				_o.GameplayType.Value = ((this.GameplayType<ICheckSpringFestivalGuessJokerCompleted>() != null) ? this.GameplayType<ICheckSpringFestivalGuessJokerCompleted>().Value.UnPack() : null);
				return;
			}
			if (gameplayTypeType != TCheckSpringFestivalGameplayType.ICheckSpringFestivalMixDrinksCompleted)
			{
				return;
			}
			_o.GameplayType.Value = ((this.GameplayType<ICheckSpringFestivalMixDrinksCompleted>() != null) ? this.GameplayType<ICheckSpringFestivalMixDrinksCompleted>().Value.UnPack() : null);
		}

		// Token: 0x06015BFC RID: 89084 RVA: 0x00323010 File Offset: 0x00321210
		public static Offset<ICheckSpringFestivalGameplayCompleted> Pack(FlatBufferBuilder builder, ICheckSpringFestivalGameplayCompletedT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckSpringFestivalGameplayCompleted>);
			}
			Offset<IConditionGroup> preConditionsOffset = (_o.PreConditions == null) ? default(Offset<IConditionGroup>) : IConditionGroup.Pack(builder, _o.PreConditions);
			TCheckSpringFestivalGameplayType gameplayType_type = (_o.GameplayType == null) ? TCheckSpringFestivalGameplayType.NONE : _o.GameplayType.Type;
			int gameplayTypeOffset = (_o.GameplayType == null) ? 0 : TCheckSpringFestivalGameplayTypeUnion.Pack(builder, _o.GameplayType);
			return ICheckSpringFestivalGameplayCompleted.CreateICheckSpringFestivalGameplayCompleted(builder, _o.Type, preConditionsOffset, gameplayType_type, gameplayTypeOffset);
		}

		// Token: 0x0400B645 RID: 46661
		private Table __p;
	}
}
