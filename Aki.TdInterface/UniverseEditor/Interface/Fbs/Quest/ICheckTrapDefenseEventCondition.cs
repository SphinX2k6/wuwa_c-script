using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003D7F RID: 15743
	public struct ICheckTrapDefenseEventCondition : IFlatbufferObject
	{
		// Token: 0x17006C06 RID: 27654
		// (get) Token: 0x06015CB9 RID: 89273 RVA: 0x003244E0 File Offset: 0x003226E0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06015CBA RID: 89274 RVA: 0x003244ED File Offset: 0x003226ED
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06015CBB RID: 89275 RVA: 0x003244F4 File Offset: 0x003226F4
		public static ICheckTrapDefenseEventCondition GetRootAsICheckTrapDefenseEventCondition(ByteBuffer _bb)
		{
			return ICheckTrapDefenseEventCondition.GetRootAsICheckTrapDefenseEventCondition(_bb, default(ICheckTrapDefenseEventCondition));
		}

		// Token: 0x06015CBC RID: 89276 RVA: 0x00324510 File Offset: 0x00322710
		public static ICheckTrapDefenseEventCondition GetRootAsICheckTrapDefenseEventCondition(ByteBuffer _bb, ICheckTrapDefenseEventCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06015CBD RID: 89277 RVA: 0x0032452D File Offset: 0x0032272D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06015CBE RID: 89278 RVA: 0x0032453C File Offset: 0x0032273C
		public ICheckTrapDefenseEventCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006C07 RID: 27655
		// (get) Token: 0x06015CBF RID: 89279 RVA: 0x0032454C File Offset: 0x0032274C
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

		// Token: 0x17006C08 RID: 27656
		// (get) Token: 0x06015CC0 RID: 89280 RVA: 0x00324588 File Offset: 0x00322788
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

		// Token: 0x17006C09 RID: 27657
		// (get) Token: 0x06015CC1 RID: 89281 RVA: 0x003245E8 File Offset: 0x003227E8
		public TCheckTrapDefenseEvent ConfigType
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return TCheckTrapDefenseEvent.NONE;
				}
				return (TCheckTrapDefenseEvent)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06015CC2 RID: 89282 RVA: 0x00324624 File Offset: 0x00322824
		public TTable? Config<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06015CC3 RID: 89283 RVA: 0x0032466C File Offset: 0x0032286C
		public ICheckTrapDefenseBdBuffQualityUp ConfigAsICheckTrapDefenseBdBuffQualityUp()
		{
			return this.Config<ICheckTrapDefenseBdBuffQualityUp>().Value;
		}

		// Token: 0x06015CC4 RID: 89284 RVA: 0x00324688 File Offset: 0x00322888
		public ICheckTrapDefenseEventMonsterKilled ConfigAsICheckTrapDefenseEventMonsterKilled()
		{
			return this.Config<ICheckTrapDefenseEventMonsterKilled>().Value;
		}

		// Token: 0x06015CC5 RID: 89285 RVA: 0x003246A3 File Offset: 0x003228A3
		public static Offset<ICheckTrapDefenseEventCondition> CreateICheckTrapDefenseEventCondition(FlatBufferBuilder builder, EChildQuest Type = EChildQuest.DoInteract, Offset<IConditionGroup> PreConditionsOffset = default(Offset<IConditionGroup>), TCheckTrapDefenseEvent Config_type = TCheckTrapDefenseEvent.NONE, int ConfigOffset = 0)
		{
			builder.StartTable(4);
			ICheckTrapDefenseEventCondition.AddConfig(builder, ConfigOffset);
			ICheckTrapDefenseEventCondition.AddPreConditions(builder, PreConditionsOffset);
			ICheckTrapDefenseEventCondition.AddConfigType(builder, Config_type);
			ICheckTrapDefenseEventCondition.AddType(builder, Type);
			return ICheckTrapDefenseEventCondition.EndICheckTrapDefenseEventCondition(builder);
		}

		// Token: 0x06015CC6 RID: 89286 RVA: 0x003246CF File Offset: 0x003228CF
		public static void StartICheckTrapDefenseEventCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06015CC7 RID: 89287 RVA: 0x003246D8 File Offset: 0x003228D8
		public static void AddType(FlatBufferBuilder builder, EChildQuest type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06015CC8 RID: 89288 RVA: 0x003246E3 File Offset: 0x003228E3
		public static void AddPreConditions(FlatBufferBuilder builder, Offset<IConditionGroup> preConditionsOffset)
		{
			builder.AddOffset(1, preConditionsOffset.Value, 0);
		}

		// Token: 0x06015CC9 RID: 89289 RVA: 0x003246F3 File Offset: 0x003228F3
		public static void AddConfigType(FlatBufferBuilder builder, TCheckTrapDefenseEvent configType)
		{
			builder.AddByte(2, (byte)configType, 0);
		}

		// Token: 0x06015CCA RID: 89290 RVA: 0x003246FE File Offset: 0x003228FE
		public static void AddConfig(FlatBufferBuilder builder, int configOffset)
		{
			builder.AddOffset(3, configOffset, 0);
		}

		// Token: 0x06015CCB RID: 89291 RVA: 0x00324709 File Offset: 0x00322909
		public static Offset<ICheckTrapDefenseEventCondition> EndICheckTrapDefenseEventCondition(FlatBufferBuilder builder)
		{
			return new Offset<ICheckTrapDefenseEventCondition>(builder.EndTable());
		}

		// Token: 0x06015CCC RID: 89292 RVA: 0x00324718 File Offset: 0x00322918
		public ICheckTrapDefenseEventConditionT UnPack()
		{
			ICheckTrapDefenseEventConditionT checkTrapDefenseEventConditionT = new ICheckTrapDefenseEventConditionT();
			this.UnPackTo(checkTrapDefenseEventConditionT);
			return checkTrapDefenseEventConditionT;
		}

		// Token: 0x06015CCD RID: 89293 RVA: 0x00324734 File Offset: 0x00322934
		public void UnPackTo(ICheckTrapDefenseEventConditionT _o)
		{
			_o.Type = this.Type;
			_o.PreConditions = ((this.PreConditions != null) ? this.PreConditions.Value.UnPack() : null);
			_o.Config = new TCheckTrapDefenseEventUnion();
			_o.Config.Type = this.ConfigType;
			TCheckTrapDefenseEvent configType = this.ConfigType;
			if (configType == TCheckTrapDefenseEvent.ICheckTrapDefenseBdBuffQualityUp)
			{
				_o.Config.Value = ((this.Config<ICheckTrapDefenseBdBuffQualityUp>() != null) ? this.Config<ICheckTrapDefenseBdBuffQualityUp>().Value.UnPack() : null);
				return;
			}
			if (configType != TCheckTrapDefenseEvent.ICheckTrapDefenseEventMonsterKilled)
			{
				return;
			}
			_o.Config.Value = ((this.Config<ICheckTrapDefenseEventMonsterKilled>() != null) ? this.Config<ICheckTrapDefenseEventMonsterKilled>().Value.UnPack() : null);
		}

		// Token: 0x06015CCE RID: 89294 RVA: 0x00324818 File Offset: 0x00322A18
		public static Offset<ICheckTrapDefenseEventCondition> Pack(FlatBufferBuilder builder, ICheckTrapDefenseEventConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckTrapDefenseEventCondition>);
			}
			Offset<IConditionGroup> preConditionsOffset = (_o.PreConditions == null) ? default(Offset<IConditionGroup>) : IConditionGroup.Pack(builder, _o.PreConditions);
			TCheckTrapDefenseEvent config_type = (_o.Config == null) ? TCheckTrapDefenseEvent.NONE : _o.Config.Type;
			int configOffset = (_o.Config == null) ? 0 : TCheckTrapDefenseEventUnion.Pack(builder, _o.Config);
			return ICheckTrapDefenseEventCondition.CreateICheckTrapDefenseEventCondition(builder, _o.Type, preConditionsOffset, config_type, configOffset);
		}

		// Token: 0x0400B66A RID: 46698
		private Table __p;
	}
}
