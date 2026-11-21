using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200417B RID: 16763
	public struct ICheckSpringFestivalGameplayCompleted : IFlatbufferObject
	{
		// Token: 0x17007194 RID: 29076
		// (get) Token: 0x0601711F RID: 94495 RVA: 0x00349F4E File Offset: 0x0034814E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06017120 RID: 94496 RVA: 0x00349F5B File Offset: 0x0034815B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06017121 RID: 94497 RVA: 0x00349F64 File Offset: 0x00348164
		public static ICheckSpringFestivalGameplayCompleted GetRootAsICheckSpringFestivalGameplayCompleted(ByteBuffer _bb)
		{
			return ICheckSpringFestivalGameplayCompleted.GetRootAsICheckSpringFestivalGameplayCompleted(_bb, default(ICheckSpringFestivalGameplayCompleted));
		}

		// Token: 0x06017122 RID: 94498 RVA: 0x00349F80 File Offset: 0x00348180
		public static ICheckSpringFestivalGameplayCompleted GetRootAsICheckSpringFestivalGameplayCompleted(ByteBuffer _bb, ICheckSpringFestivalGameplayCompleted obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06017123 RID: 94499 RVA: 0x00349F9D File Offset: 0x0034819D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06017124 RID: 94500 RVA: 0x00349FAC File Offset: 0x003481AC
		public ICheckSpringFestivalGameplayCompleted __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007195 RID: 29077
		// (get) Token: 0x06017125 RID: 94501 RVA: 0x00349FBC File Offset: 0x003481BC
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

		// Token: 0x17007196 RID: 29078
		// (get) Token: 0x06017126 RID: 94502 RVA: 0x00349FF8 File Offset: 0x003481F8
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

		// Token: 0x17007197 RID: 29079
		// (get) Token: 0x06017127 RID: 94503 RVA: 0x0034A058 File Offset: 0x00348258
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

		// Token: 0x06017128 RID: 94504 RVA: 0x0034A094 File Offset: 0x00348294
		public TTable? GameplayType<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06017129 RID: 94505 RVA: 0x0034A0DC File Offset: 0x003482DC
		public ICheckSpringFestivalGuessJokerCompleted GameplayTypeAsICheckSpringFestivalGuessJokerCompleted()
		{
			return this.GameplayType<ICheckSpringFestivalGuessJokerCompleted>().Value;
		}

		// Token: 0x0601712A RID: 94506 RVA: 0x0034A0F8 File Offset: 0x003482F8
		public ICheckSpringFestivalMixDrinksCompleted GameplayTypeAsICheckSpringFestivalMixDrinksCompleted()
		{
			return this.GameplayType<ICheckSpringFestivalMixDrinksCompleted>().Value;
		}

		// Token: 0x0601712B RID: 94507 RVA: 0x0034A113 File Offset: 0x00348313
		public static Offset<ICheckSpringFestivalGameplayCompleted> CreateICheckSpringFestivalGameplayCompleted(FlatBufferBuilder builder, EChildQuest Type = EChildQuest.DoInteract, Offset<IConditionGroup> PreConditionsOffset = default(Offset<IConditionGroup>), TCheckSpringFestivalGameplayType GameplayType_type = TCheckSpringFestivalGameplayType.NONE, int GameplayTypeOffset = 0)
		{
			builder.StartTable(4);
			ICheckSpringFestivalGameplayCompleted.AddGameplayType(builder, GameplayTypeOffset);
			ICheckSpringFestivalGameplayCompleted.AddPreConditions(builder, PreConditionsOffset);
			ICheckSpringFestivalGameplayCompleted.AddGameplayTypeType(builder, GameplayType_type);
			ICheckSpringFestivalGameplayCompleted.AddType(builder, Type);
			return ICheckSpringFestivalGameplayCompleted.EndICheckSpringFestivalGameplayCompleted(builder);
		}

		// Token: 0x0601712C RID: 94508 RVA: 0x0034A13F File Offset: 0x0034833F
		public static void StartICheckSpringFestivalGameplayCompleted(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0601712D RID: 94509 RVA: 0x0034A148 File Offset: 0x00348348
		public static void AddType(FlatBufferBuilder builder, EChildQuest type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601712E RID: 94510 RVA: 0x0034A153 File Offset: 0x00348353
		public static void AddPreConditions(FlatBufferBuilder builder, Offset<IConditionGroup> preConditionsOffset)
		{
			builder.AddOffset(1, preConditionsOffset.Value, 0);
		}

		// Token: 0x0601712F RID: 94511 RVA: 0x0034A163 File Offset: 0x00348363
		public static void AddGameplayTypeType(FlatBufferBuilder builder, TCheckSpringFestivalGameplayType gameplayTypeType)
		{
			builder.AddByte(2, (byte)gameplayTypeType, 0);
		}

		// Token: 0x06017130 RID: 94512 RVA: 0x0034A16E File Offset: 0x0034836E
		public static void AddGameplayType(FlatBufferBuilder builder, int gameplayTypeOffset)
		{
			builder.AddOffset(3, gameplayTypeOffset, 0);
		}

		// Token: 0x06017131 RID: 94513 RVA: 0x0034A179 File Offset: 0x00348379
		public static Offset<ICheckSpringFestivalGameplayCompleted> EndICheckSpringFestivalGameplayCompleted(FlatBufferBuilder builder)
		{
			return new Offset<ICheckSpringFestivalGameplayCompleted>(builder.EndTable());
		}

		// Token: 0x06017132 RID: 94514 RVA: 0x0034A188 File Offset: 0x00348388
		public ICheckSpringFestivalGameplayCompletedT UnPack()
		{
			ICheckSpringFestivalGameplayCompletedT checkSpringFestivalGameplayCompletedT = new ICheckSpringFestivalGameplayCompletedT();
			this.UnPackTo(checkSpringFestivalGameplayCompletedT);
			return checkSpringFestivalGameplayCompletedT;
		}

		// Token: 0x06017133 RID: 94515 RVA: 0x0034A1A4 File Offset: 0x003483A4
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

		// Token: 0x06017134 RID: 94516 RVA: 0x0034A288 File Offset: 0x00348488
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

		// Token: 0x0400BFF2 RID: 49138
		private Table __p;
	}
}
