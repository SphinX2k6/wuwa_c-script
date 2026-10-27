using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200425F RID: 16991
	public struct IUseWeatherSwitchCondition : IFlatbufferObject
	{
		// Token: 0x170078A5 RID: 30885
		// (get) Token: 0x0601924D RID: 102989 RVA: 0x0039D494 File Offset: 0x0039B694
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601924E RID: 102990 RVA: 0x0039D4A1 File Offset: 0x0039B6A1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601924F RID: 102991 RVA: 0x0039D4A8 File Offset: 0x0039B6A8
		public static IUseWeatherSwitchCondition GetRootAsIUseWeatherSwitchCondition(ByteBuffer _bb)
		{
			return IUseWeatherSwitchCondition.GetRootAsIUseWeatherSwitchCondition(_bb, default(IUseWeatherSwitchCondition));
		}

		// Token: 0x06019250 RID: 102992 RVA: 0x0039D4C4 File Offset: 0x0039B6C4
		public static IUseWeatherSwitchCondition GetRootAsIUseWeatherSwitchCondition(ByteBuffer _bb, IUseWeatherSwitchCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06019251 RID: 102993 RVA: 0x0039D4E1 File Offset: 0x0039B6E1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06019252 RID: 102994 RVA: 0x0039D4F0 File Offset: 0x0039B6F0
		public IUseWeatherSwitchCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170078A6 RID: 30886
		// (get) Token: 0x06019253 RID: 102995 RVA: 0x0039D500 File Offset: 0x0039B700
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

		// Token: 0x170078A7 RID: 30887
		// (get) Token: 0x06019254 RID: 102996 RVA: 0x0039D53C File Offset: 0x0039B73C
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

		// Token: 0x170078A8 RID: 30888
		// (get) Token: 0x06019255 RID: 102997 RVA: 0x0039D59C File Offset: 0x0039B79C
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

		// Token: 0x06019256 RID: 102998 RVA: 0x0039D5D8 File Offset: 0x0039B7D8
		public TTable? CheckType<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06019257 RID: 102999 RVA: 0x0039D620 File Offset: 0x0039B820
		public IUseWeatherSwitchConditionAnyWeather CheckTypeAsIUseWeatherSwitchConditionAnyWeather()
		{
			return this.CheckType<IUseWeatherSwitchConditionAnyWeather>().Value;
		}

		// Token: 0x06019258 RID: 103000 RVA: 0x0039D63C File Offset: 0x0039B83C
		public IUseWeatherSwitchConditionSpecifiedWeather CheckTypeAsIUseWeatherSwitchConditionSpecifiedWeather()
		{
			return this.CheckType<IUseWeatherSwitchConditionSpecifiedWeather>().Value;
		}

		// Token: 0x06019259 RID: 103001 RVA: 0x0039D657 File Offset: 0x0039B857
		public static Offset<IUseWeatherSwitchCondition> CreateIUseWeatherSwitchCondition(FlatBufferBuilder builder, EChildQuest Type = EChildQuest.DoInteract, Offset<IConditionGroup> PreConditionsOffset = default(Offset<IConditionGroup>), TUseWeatherSwitchCondition CheckType_type = TUseWeatherSwitchCondition.NONE, int CheckTypeOffset = 0)
		{
			builder.StartTable(4);
			IUseWeatherSwitchCondition.AddCheckType(builder, CheckTypeOffset);
			IUseWeatherSwitchCondition.AddPreConditions(builder, PreConditionsOffset);
			IUseWeatherSwitchCondition.AddCheckTypeType(builder, CheckType_type);
			IUseWeatherSwitchCondition.AddType(builder, Type);
			return IUseWeatherSwitchCondition.EndIUseWeatherSwitchCondition(builder);
		}

		// Token: 0x0601925A RID: 103002 RVA: 0x0039D683 File Offset: 0x0039B883
		public static void StartIUseWeatherSwitchCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0601925B RID: 103003 RVA: 0x0039D68C File Offset: 0x0039B88C
		public static void AddType(FlatBufferBuilder builder, EChildQuest type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601925C RID: 103004 RVA: 0x0039D697 File Offset: 0x0039B897
		public static void AddPreConditions(FlatBufferBuilder builder, Offset<IConditionGroup> preConditionsOffset)
		{
			builder.AddOffset(1, preConditionsOffset.Value, 0);
		}

		// Token: 0x0601925D RID: 103005 RVA: 0x0039D6A7 File Offset: 0x0039B8A7
		public static void AddCheckTypeType(FlatBufferBuilder builder, TUseWeatherSwitchCondition checkTypeType)
		{
			builder.AddByte(2, (byte)checkTypeType, 0);
		}

		// Token: 0x0601925E RID: 103006 RVA: 0x0039D6B2 File Offset: 0x0039B8B2
		public static void AddCheckType(FlatBufferBuilder builder, int checkTypeOffset)
		{
			builder.AddOffset(3, checkTypeOffset, 0);
		}

		// Token: 0x0601925F RID: 103007 RVA: 0x0039D6BD File Offset: 0x0039B8BD
		public static Offset<IUseWeatherSwitchCondition> EndIUseWeatherSwitchCondition(FlatBufferBuilder builder)
		{
			return new Offset<IUseWeatherSwitchCondition>(builder.EndTable());
		}

		// Token: 0x06019260 RID: 103008 RVA: 0x0039D6CC File Offset: 0x0039B8CC
		public IUseWeatherSwitchConditionT UnPack()
		{
			IUseWeatherSwitchConditionT useWeatherSwitchConditionT = new IUseWeatherSwitchConditionT();
			this.UnPackTo(useWeatherSwitchConditionT);
			return useWeatherSwitchConditionT;
		}

		// Token: 0x06019261 RID: 103009 RVA: 0x0039D6E8 File Offset: 0x0039B8E8
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

		// Token: 0x06019262 RID: 103010 RVA: 0x0039D7CC File Offset: 0x0039B9CC
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

		// Token: 0x0400BEEE RID: 48878
		private Table __p;
	}
}
