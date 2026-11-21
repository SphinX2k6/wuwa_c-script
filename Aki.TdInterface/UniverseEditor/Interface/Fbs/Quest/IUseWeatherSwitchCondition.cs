using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020046BB RID: 18107
	public struct IUseWeatherSwitchCondition : IFlatbufferObject
	{
		// Token: 0x17007ED6 RID: 32470
		// (get) Token: 0x0601A9B9 RID: 108985 RVA: 0x003C8B6C File Offset: 0x003C6D6C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601A9BA RID: 108986 RVA: 0x003C8B79 File Offset: 0x003C6D79
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601A9BB RID: 108987 RVA: 0x003C8B80 File Offset: 0x003C6D80
		public static IUseWeatherSwitchCondition GetRootAsIUseWeatherSwitchCondition(ByteBuffer _bb)
		{
			return IUseWeatherSwitchCondition.GetRootAsIUseWeatherSwitchCondition(_bb, default(IUseWeatherSwitchCondition));
		}

		// Token: 0x0601A9BC RID: 108988 RVA: 0x003C8B9C File Offset: 0x003C6D9C
		public static IUseWeatherSwitchCondition GetRootAsIUseWeatherSwitchCondition(ByteBuffer _bb, IUseWeatherSwitchCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601A9BD RID: 108989 RVA: 0x003C8BB9 File Offset: 0x003C6DB9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601A9BE RID: 108990 RVA: 0x003C8BC8 File Offset: 0x003C6DC8
		public IUseWeatherSwitchCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007ED7 RID: 32471
		// (get) Token: 0x0601A9BF RID: 108991 RVA: 0x003C8BD8 File Offset: 0x003C6DD8
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

		// Token: 0x17007ED8 RID: 32472
		// (get) Token: 0x0601A9C0 RID: 108992 RVA: 0x003C8C14 File Offset: 0x003C6E14
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

		// Token: 0x17007ED9 RID: 32473
		// (get) Token: 0x0601A9C1 RID: 108993 RVA: 0x003C8C74 File Offset: 0x003C6E74
		public TUseWeatherSwitchCondition CheckTypeType
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return TUseWeatherSwitchCondition.NONE;
				}
				return (TUseWeatherSwitchCondition)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601A9C2 RID: 108994 RVA: 0x003C8CB0 File Offset: 0x003C6EB0
		public TTable? CheckType<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0601A9C3 RID: 108995 RVA: 0x003C8CF8 File Offset: 0x003C6EF8
		public IUseWeatherSwitchConditionAnyWeather CheckTypeAsIUseWeatherSwitchConditionAnyWeather()
		{
			return this.CheckType<IUseWeatherSwitchConditionAnyWeather>().Value;
		}

		// Token: 0x0601A9C4 RID: 108996 RVA: 0x003C8D14 File Offset: 0x003C6F14
		public IUseWeatherSwitchConditionSpecifiedWeather CheckTypeAsIUseWeatherSwitchConditionSpecifiedWeather()
		{
			return this.CheckType<IUseWeatherSwitchConditionSpecifiedWeather>().Value;
		}

		// Token: 0x0601A9C5 RID: 108997 RVA: 0x003C8D2F File Offset: 0x003C6F2F
		public static Offset<IUseWeatherSwitchCondition> CreateIUseWeatherSwitchCondition(FlatBufferBuilder builder, EChildQuest Type = EChildQuest.DoInteract, Offset<IConditionGroup> PreConditionsOffset = default(Offset<IConditionGroup>), TUseWeatherSwitchCondition CheckType_type = TUseWeatherSwitchCondition.NONE, int CheckTypeOffset = 0)
		{
			builder.StartTable(4);
			IUseWeatherSwitchCondition.AddCheckType(builder, CheckTypeOffset);
			IUseWeatherSwitchCondition.AddPreConditions(builder, PreConditionsOffset);
			IUseWeatherSwitchCondition.AddCheckTypeType(builder, CheckType_type);
			IUseWeatherSwitchCondition.AddType(builder, Type);
			return IUseWeatherSwitchCondition.EndIUseWeatherSwitchCondition(builder);
		}

		// Token: 0x0601A9C6 RID: 108998 RVA: 0x003C8D5B File Offset: 0x003C6F5B
		public static void StartIUseWeatherSwitchCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0601A9C7 RID: 108999 RVA: 0x003C8D64 File Offset: 0x003C6F64
		public static void AddType(FlatBufferBuilder builder, EChildQuest type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601A9C8 RID: 109000 RVA: 0x003C8D6F File Offset: 0x003C6F6F
		public static void AddPreConditions(FlatBufferBuilder builder, Offset<IConditionGroup> preConditionsOffset)
		{
			builder.AddOffset(1, preConditionsOffset.Value, 0);
		}

		// Token: 0x0601A9C9 RID: 109001 RVA: 0x003C8D7F File Offset: 0x003C6F7F
		public static void AddCheckTypeType(FlatBufferBuilder builder, TUseWeatherSwitchCondition checkTypeType)
		{
			builder.AddByte(2, (byte)checkTypeType, 0);
		}

		// Token: 0x0601A9CA RID: 109002 RVA: 0x003C8D8A File Offset: 0x003C6F8A
		public static void AddCheckType(FlatBufferBuilder builder, int checkTypeOffset)
		{
			builder.AddOffset(3, checkTypeOffset, 0);
		}

		// Token: 0x0601A9CB RID: 109003 RVA: 0x003C8D95 File Offset: 0x003C6F95
		public static Offset<IUseWeatherSwitchCondition> EndIUseWeatherSwitchCondition(FlatBufferBuilder builder)
		{
			return new Offset<IUseWeatherSwitchCondition>(builder.EndTable());
		}

		// Token: 0x0601A9CC RID: 109004 RVA: 0x003C8DA4 File Offset: 0x003C6FA4
		public IUseWeatherSwitchConditionT UnPack()
		{
			IUseWeatherSwitchConditionT useWeatherSwitchConditionT = new IUseWeatherSwitchConditionT();
			this.UnPackTo(useWeatherSwitchConditionT);
			return useWeatherSwitchConditionT;
		}

		// Token: 0x0601A9CD RID: 109005 RVA: 0x003C8DC0 File Offset: 0x003C6FC0
		public void UnPackTo(IUseWeatherSwitchConditionT _o)
		{
			_o.Type = this.Type;
			_o.PreConditions = ((this.PreConditions != null) ? this.PreConditions.Value.UnPack() : null);
			_o.CheckType = new TUseWeatherSwitchConditionUnion();
			_o.CheckType.Type = this.CheckTypeType;
			TUseWeatherSwitchCondition checkTypeType = this.CheckTypeType;
			if (checkTypeType == TUseWeatherSwitchCondition.IUseWeatherSwitchConditionAnyWeather)
			{
				_o.CheckType.Value = ((this.CheckType<IUseWeatherSwitchConditionAnyWeather>() != null) ? this.CheckType<IUseWeatherSwitchConditionAnyWeather>().Value.UnPack() : null);
				return;
			}
			if (checkTypeType != TUseWeatherSwitchCondition.IUseWeatherSwitchConditionSpecifiedWeather)
			{
				return;
			}
			_o.CheckType.Value = ((this.CheckType<IUseWeatherSwitchConditionSpecifiedWeather>() != null) ? this.CheckType<IUseWeatherSwitchConditionSpecifiedWeather>().Value.UnPack() : null);
		}

		// Token: 0x0601A9CE RID: 109006 RVA: 0x003C8EA4 File Offset: 0x003C70A4
		public static Offset<IUseWeatherSwitchCondition> Pack(FlatBufferBuilder builder, IUseWeatherSwitchConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IUseWeatherSwitchCondition>);
			}
			Offset<IConditionGroup> preConditionsOffset = (_o.PreConditions == null) ? default(Offset<IConditionGroup>) : IConditionGroup.Pack(builder, _o.PreConditions);
			TUseWeatherSwitchCondition checkType_type = (_o.CheckType == null) ? TUseWeatherSwitchCondition.NONE : _o.CheckType.Type;
			int checkTypeOffset = (_o.CheckType == null) ? 0 : TUseWeatherSwitchConditionUnion.Pack(builder, _o.CheckType);
			return IUseWeatherSwitchCondition.CreateIUseWeatherSwitchCondition(builder, _o.Type, preConditionsOffset, checkType_type, checkTypeOffset);
		}

		// Token: 0x0400C8FB RID: 51451
		private Table __p;
	}
}
