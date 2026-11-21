using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004196 RID: 16790
	public struct ICheckTrapDefenseEventCondition : IFlatbufferObject
	{
		// Token: 0x170071C0 RID: 29120
		// (get) Token: 0x060171F1 RID: 94705 RVA: 0x0034B758 File Offset: 0x00349958
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060171F2 RID: 94706 RVA: 0x0034B765 File Offset: 0x00349965
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060171F3 RID: 94707 RVA: 0x0034B76C File Offset: 0x0034996C
		public static ICheckTrapDefenseEventCondition GetRootAsICheckTrapDefenseEventCondition(ByteBuffer _bb)
		{
			return ICheckTrapDefenseEventCondition.GetRootAsICheckTrapDefenseEventCondition(_bb, default(ICheckTrapDefenseEventCondition));
		}

		// Token: 0x060171F4 RID: 94708 RVA: 0x0034B788 File Offset: 0x00349988
		public static ICheckTrapDefenseEventCondition GetRootAsICheckTrapDefenseEventCondition(ByteBuffer _bb, ICheckTrapDefenseEventCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060171F5 RID: 94709 RVA: 0x0034B7A5 File Offset: 0x003499A5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060171F6 RID: 94710 RVA: 0x0034B7B4 File Offset: 0x003499B4
		public ICheckTrapDefenseEventCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170071C1 RID: 29121
		// (get) Token: 0x060171F7 RID: 94711 RVA: 0x0034B7C4 File Offset: 0x003499C4
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

		// Token: 0x170071C2 RID: 29122
		// (get) Token: 0x060171F8 RID: 94712 RVA: 0x0034B800 File Offset: 0x00349A00
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

		// Token: 0x170071C3 RID: 29123
		// (get) Token: 0x060171F9 RID: 94713 RVA: 0x0034B860 File Offset: 0x00349A60
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

		// Token: 0x060171FA RID: 94714 RVA: 0x0034B89C File Offset: 0x00349A9C
		public TTable? Config<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x060171FB RID: 94715 RVA: 0x0034B8E4 File Offset: 0x00349AE4
		public ICheckTrapDefenseBdBuffQualityUp ConfigAsICheckTrapDefenseBdBuffQualityUp()
		{
			return this.Config<ICheckTrapDefenseBdBuffQualityUp>().Value;
		}

		// Token: 0x060171FC RID: 94716 RVA: 0x0034B900 File Offset: 0x00349B00
		public ICheckTrapDefenseEventMonsterKilled ConfigAsICheckTrapDefenseEventMonsterKilled()
		{
			return this.Config<ICheckTrapDefenseEventMonsterKilled>().Value;
		}

		// Token: 0x060171FD RID: 94717 RVA: 0x0034B91B File Offset: 0x00349B1B
		public static Offset<ICheckTrapDefenseEventCondition> CreateICheckTrapDefenseEventCondition(FlatBufferBuilder builder, EChildQuest Type = EChildQuest.DoInteract, Offset<IConditionGroup> PreConditionsOffset = default(Offset<IConditionGroup>), TCheckTrapDefenseEvent Config_type = TCheckTrapDefenseEvent.NONE, int ConfigOffset = 0)
		{
			builder.StartTable(4);
			ICheckTrapDefenseEventCondition.AddConfig(builder, ConfigOffset);
			ICheckTrapDefenseEventCondition.AddPreConditions(builder, PreConditionsOffset);
			ICheckTrapDefenseEventCondition.AddConfigType(builder, Config_type);
			ICheckTrapDefenseEventCondition.AddType(builder, Type);
			return ICheckTrapDefenseEventCondition.EndICheckTrapDefenseEventCondition(builder);
		}

		// Token: 0x060171FE RID: 94718 RVA: 0x0034B947 File Offset: 0x00349B47
		public static void StartICheckTrapDefenseEventCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x060171FF RID: 94719 RVA: 0x0034B950 File Offset: 0x00349B50
		public static void AddType(FlatBufferBuilder builder, EChildQuest type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06017200 RID: 94720 RVA: 0x0034B95B File Offset: 0x00349B5B
		public static void AddPreConditions(FlatBufferBuilder builder, Offset<IConditionGroup> preConditionsOffset)
		{
			builder.AddOffset(1, preConditionsOffset.Value, 0);
		}

		// Token: 0x06017201 RID: 94721 RVA: 0x0034B96B File Offset: 0x00349B6B
		public static void AddConfigType(FlatBufferBuilder builder, TCheckTrapDefenseEvent configType)
		{
			builder.AddByte(2, (byte)configType, 0);
		}

		// Token: 0x06017202 RID: 94722 RVA: 0x0034B976 File Offset: 0x00349B76
		public static void AddConfig(FlatBufferBuilder builder, int configOffset)
		{
			builder.AddOffset(3, configOffset, 0);
		}

		// Token: 0x06017203 RID: 94723 RVA: 0x0034B981 File Offset: 0x00349B81
		public static Offset<ICheckTrapDefenseEventCondition> EndICheckTrapDefenseEventCondition(FlatBufferBuilder builder)
		{
			return new Offset<ICheckTrapDefenseEventCondition>(builder.EndTable());
		}

		// Token: 0x06017204 RID: 94724 RVA: 0x0034B990 File Offset: 0x00349B90
		public ICheckTrapDefenseEventConditionT UnPack()
		{
			ICheckTrapDefenseEventConditionT checkTrapDefenseEventConditionT = new ICheckTrapDefenseEventConditionT();
			this.UnPackTo(checkTrapDefenseEventConditionT);
			return checkTrapDefenseEventConditionT;
		}

		// Token: 0x06017205 RID: 94725 RVA: 0x0034B9AC File Offset: 0x00349BAC
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

		// Token: 0x06017206 RID: 94726 RVA: 0x0034BA90 File Offset: 0x00349C90
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

		// Token: 0x0400C017 RID: 49175
		private Table __p;
	}
}
