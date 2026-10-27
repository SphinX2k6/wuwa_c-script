using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003E2D RID: 15917
	public struct IFinishArcadeGameplay : IFlatbufferObject
	{
		// Token: 0x17006E0C RID: 28172
		// (get) Token: 0x060164E3 RID: 91363 RVA: 0x00338611 File Offset: 0x00336811
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060164E4 RID: 91364 RVA: 0x0033861E File Offset: 0x0033681E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060164E5 RID: 91365 RVA: 0x00338628 File Offset: 0x00336828
		public static IFinishArcadeGameplay GetRootAsIFinishArcadeGameplay(ByteBuffer _bb)
		{
			return IFinishArcadeGameplay.GetRootAsIFinishArcadeGameplay(_bb, default(IFinishArcadeGameplay));
		}

		// Token: 0x060164E6 RID: 91366 RVA: 0x00338644 File Offset: 0x00336844
		public static IFinishArcadeGameplay GetRootAsIFinishArcadeGameplay(ByteBuffer _bb, IFinishArcadeGameplay obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060164E7 RID: 91367 RVA: 0x00338661 File Offset: 0x00336861
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060164E8 RID: 91368 RVA: 0x00338670 File Offset: 0x00336870
		public IFinishArcadeGameplay __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006E0D RID: 28173
		// (get) Token: 0x060164E9 RID: 91369 RVA: 0x00338680 File Offset: 0x00336880
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

		// Token: 0x17006E0E RID: 28174
		// (get) Token: 0x060164EA RID: 91370 RVA: 0x003386BC File Offset: 0x003368BC
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

		// Token: 0x17006E0F RID: 28175
		// (get) Token: 0x060164EB RID: 91371 RVA: 0x0033871C File Offset: 0x0033691C
		public TArcadeGameplay ArcadeGameplayType
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return TArcadeGameplay.NONE;
				}
				return (TArcadeGameplay)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060164EC RID: 91372 RVA: 0x00338758 File Offset: 0x00336958
		public TTable? ArcadeGameplay<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x060164ED RID: 91373 RVA: 0x003387A0 File Offset: 0x003369A0
		public IArcadeGameplayDropCatch ArcadeGameplayAsIArcadeGameplayDropCatch()
		{
			return this.ArcadeGameplay<IArcadeGameplayDropCatch>().Value;
		}

		// Token: 0x060164EE RID: 91374 RVA: 0x003387BC File Offset: 0x003369BC
		public IArcadeGameplayTetrisBoardGame ArcadeGameplayAsIArcadeGameplayTetrisBoardGame()
		{
			return this.ArcadeGameplay<IArcadeGameplayTetrisBoardGame>().Value;
		}

		// Token: 0x060164EF RID: 91375 RVA: 0x003387D7 File Offset: 0x003369D7
		public static Offset<IFinishArcadeGameplay> CreateIFinishArcadeGameplay(FlatBufferBuilder builder, EChildQuest Type = EChildQuest.DoInteract, Offset<IConditionGroup> PreConditionsOffset = default(Offset<IConditionGroup>), TArcadeGameplay ArcadeGameplay_type = TArcadeGameplay.NONE, int ArcadeGameplayOffset = 0)
		{
			builder.StartTable(4);
			IFinishArcadeGameplay.AddArcadeGameplay(builder, ArcadeGameplayOffset);
			IFinishArcadeGameplay.AddPreConditions(builder, PreConditionsOffset);
			IFinishArcadeGameplay.AddArcadeGameplayType(builder, ArcadeGameplay_type);
			IFinishArcadeGameplay.AddType(builder, Type);
			return IFinishArcadeGameplay.EndIFinishArcadeGameplay(builder);
		}

		// Token: 0x060164F0 RID: 91376 RVA: 0x00338803 File Offset: 0x00336A03
		public static void StartIFinishArcadeGameplay(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x060164F1 RID: 91377 RVA: 0x0033880C File Offset: 0x00336A0C
		public static void AddType(FlatBufferBuilder builder, EChildQuest type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060164F2 RID: 91378 RVA: 0x00338817 File Offset: 0x00336A17
		public static void AddPreConditions(FlatBufferBuilder builder, Offset<IConditionGroup> preConditionsOffset)
		{
			builder.AddOffset(1, preConditionsOffset.Value, 0);
		}

		// Token: 0x060164F3 RID: 91379 RVA: 0x00338827 File Offset: 0x00336A27
		public static void AddArcadeGameplayType(FlatBufferBuilder builder, TArcadeGameplay arcadeGameplayType)
		{
			builder.AddByte(2, (byte)arcadeGameplayType, 0);
		}

		// Token: 0x060164F4 RID: 91380 RVA: 0x00338832 File Offset: 0x00336A32
		public static void AddArcadeGameplay(FlatBufferBuilder builder, int arcadeGameplayOffset)
		{
			builder.AddOffset(3, arcadeGameplayOffset, 0);
		}

		// Token: 0x060164F5 RID: 91381 RVA: 0x0033883D File Offset: 0x00336A3D
		public static Offset<IFinishArcadeGameplay> EndIFinishArcadeGameplay(FlatBufferBuilder builder)
		{
			return new Offset<IFinishArcadeGameplay>(builder.EndTable());
		}

		// Token: 0x060164F6 RID: 91382 RVA: 0x0033884C File Offset: 0x00336A4C
		public IFinishArcadeGameplayT UnPack()
		{
			IFinishArcadeGameplayT finishArcadeGameplayT = new IFinishArcadeGameplayT();
			this.UnPackTo(finishArcadeGameplayT);
			return finishArcadeGameplayT;
		}

		// Token: 0x060164F7 RID: 91383 RVA: 0x00338868 File Offset: 0x00336A68
		public void UnPackTo(IFinishArcadeGameplayT _o)
		{
			_o.Type = this.Type;
			_o.PreConditions = ((this.PreConditions != null) ? this.PreConditions.Value.UnPack() : null);
			_o.ArcadeGameplay = new TArcadeGameplayUnion();
			_o.ArcadeGameplay.Type = this.ArcadeGameplayType;
			TArcadeGameplay arcadeGameplayType = this.ArcadeGameplayType;
			if (arcadeGameplayType == TArcadeGameplay.IArcadeGameplayDropCatch)
			{
				_o.ArcadeGameplay.Value = ((this.ArcadeGameplay<IArcadeGameplayDropCatch>() != null) ? this.ArcadeGameplay<IArcadeGameplayDropCatch>().Value.UnPack() : null);
				return;
			}
			if (arcadeGameplayType != TArcadeGameplay.IArcadeGameplayTetrisBoardGame)
			{
				return;
			}
			_o.ArcadeGameplay.Value = ((this.ArcadeGameplay<IArcadeGameplayTetrisBoardGame>() != null) ? this.ArcadeGameplay<IArcadeGameplayTetrisBoardGame>().Value.UnPack() : null);
		}

		// Token: 0x060164F8 RID: 91384 RVA: 0x0033894C File Offset: 0x00336B4C
		public static Offset<IFinishArcadeGameplay> Pack(FlatBufferBuilder builder, IFinishArcadeGameplayT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFinishArcadeGameplay>);
			}
			Offset<IConditionGroup> preConditionsOffset = (_o.PreConditions == null) ? default(Offset<IConditionGroup>) : IConditionGroup.Pack(builder, _o.PreConditions);
			TArcadeGameplay arcadeGameplay_type = (_o.ArcadeGameplay == null) ? TArcadeGameplay.NONE : _o.ArcadeGameplay.Type;
			int arcadeGameplayOffset = (_o.ArcadeGameplay == null) ? 0 : TArcadeGameplayUnion.Pack(builder, _o.ArcadeGameplay);
			return IFinishArcadeGameplay.CreateIFinishArcadeGameplay(builder, _o.Type, preConditionsOffset, arcadeGameplay_type, arcadeGameplayOffset);
		}

		// Token: 0x0400B7B1 RID: 47025
		private Table __p;
	}
}
