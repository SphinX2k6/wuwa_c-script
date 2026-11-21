using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004268 RID: 17000
	public struct IFinishArcadeGameplay : IFlatbufferObject
	{
		// Token: 0x170073F2 RID: 29682
		// (get) Token: 0x06017B10 RID: 97040 RVA: 0x00361209 File Offset: 0x0035F409
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06017B11 RID: 97041 RVA: 0x00361216 File Offset: 0x0035F416
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06017B12 RID: 97042 RVA: 0x00361220 File Offset: 0x0035F420
		public static IFinishArcadeGameplay GetRootAsIFinishArcadeGameplay(ByteBuffer _bb)
		{
			return IFinishArcadeGameplay.GetRootAsIFinishArcadeGameplay(_bb, default(IFinishArcadeGameplay));
		}

		// Token: 0x06017B13 RID: 97043 RVA: 0x0036123C File Offset: 0x0035F43C
		public static IFinishArcadeGameplay GetRootAsIFinishArcadeGameplay(ByteBuffer _bb, IFinishArcadeGameplay obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06017B14 RID: 97044 RVA: 0x00361259 File Offset: 0x0035F459
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06017B15 RID: 97045 RVA: 0x00361268 File Offset: 0x0035F468
		public IFinishArcadeGameplay __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170073F3 RID: 29683
		// (get) Token: 0x06017B16 RID: 97046 RVA: 0x00361278 File Offset: 0x0035F478
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

		// Token: 0x170073F4 RID: 29684
		// (get) Token: 0x06017B17 RID: 97047 RVA: 0x003612B4 File Offset: 0x0035F4B4
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

		// Token: 0x170073F5 RID: 29685
		// (get) Token: 0x06017B18 RID: 97048 RVA: 0x00361314 File Offset: 0x0035F514
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

		// Token: 0x06017B19 RID: 97049 RVA: 0x00361350 File Offset: 0x0035F550
		public TTable? ArcadeGameplay<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06017B1A RID: 97050 RVA: 0x00361398 File Offset: 0x0035F598
		public IArcadeGameplayDropCatch ArcadeGameplayAsIArcadeGameplayDropCatch()
		{
			return this.ArcadeGameplay<IArcadeGameplayDropCatch>().Value;
		}

		// Token: 0x06017B1B RID: 97051 RVA: 0x003613B4 File Offset: 0x0035F5B4
		public IArcadeGameplayTetrisBoardGame ArcadeGameplayAsIArcadeGameplayTetrisBoardGame()
		{
			return this.ArcadeGameplay<IArcadeGameplayTetrisBoardGame>().Value;
		}

		// Token: 0x06017B1C RID: 97052 RVA: 0x003613CF File Offset: 0x0035F5CF
		public static Offset<IFinishArcadeGameplay> CreateIFinishArcadeGameplay(FlatBufferBuilder builder, EChildQuest Type = EChildQuest.DoInteract, Offset<IConditionGroup> PreConditionsOffset = default(Offset<IConditionGroup>), TArcadeGameplay ArcadeGameplay_type = TArcadeGameplay.NONE, int ArcadeGameplayOffset = 0)
		{
			builder.StartTable(4);
			IFinishArcadeGameplay.AddArcadeGameplay(builder, ArcadeGameplayOffset);
			IFinishArcadeGameplay.AddPreConditions(builder, PreConditionsOffset);
			IFinishArcadeGameplay.AddArcadeGameplayType(builder, ArcadeGameplay_type);
			IFinishArcadeGameplay.AddType(builder, Type);
			return IFinishArcadeGameplay.EndIFinishArcadeGameplay(builder);
		}

		// Token: 0x06017B1D RID: 97053 RVA: 0x003613FB File Offset: 0x0035F5FB
		public static void StartIFinishArcadeGameplay(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06017B1E RID: 97054 RVA: 0x00361404 File Offset: 0x0035F604
		public static void AddType(FlatBufferBuilder builder, EChildQuest type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06017B1F RID: 97055 RVA: 0x0036140F File Offset: 0x0035F60F
		public static void AddPreConditions(FlatBufferBuilder builder, Offset<IConditionGroup> preConditionsOffset)
		{
			builder.AddOffset(1, preConditionsOffset.Value, 0);
		}

		// Token: 0x06017B20 RID: 97056 RVA: 0x0036141F File Offset: 0x0035F61F
		public static void AddArcadeGameplayType(FlatBufferBuilder builder, TArcadeGameplay arcadeGameplayType)
		{
			builder.AddByte(2, (byte)arcadeGameplayType, 0);
		}

		// Token: 0x06017B21 RID: 97057 RVA: 0x0036142A File Offset: 0x0035F62A
		public static void AddArcadeGameplay(FlatBufferBuilder builder, int arcadeGameplayOffset)
		{
			builder.AddOffset(3, arcadeGameplayOffset, 0);
		}

		// Token: 0x06017B22 RID: 97058 RVA: 0x00361435 File Offset: 0x0035F635
		public static Offset<IFinishArcadeGameplay> EndIFinishArcadeGameplay(FlatBufferBuilder builder)
		{
			return new Offset<IFinishArcadeGameplay>(builder.EndTable());
		}

		// Token: 0x06017B23 RID: 97059 RVA: 0x00361444 File Offset: 0x0035F644
		public IFinishArcadeGameplayT UnPack()
		{
			IFinishArcadeGameplayT finishArcadeGameplayT = new IFinishArcadeGameplayT();
			this.UnPackTo(finishArcadeGameplayT);
			return finishArcadeGameplayT;
		}

		// Token: 0x06017B24 RID: 97060 RVA: 0x00361460 File Offset: 0x0035F660
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

		// Token: 0x06017B25 RID: 97061 RVA: 0x00361544 File Offset: 0x0035F744
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

		// Token: 0x0400C189 RID: 49545
		private Table __p;
	}
}
