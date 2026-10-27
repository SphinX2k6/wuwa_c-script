using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003D5E RID: 15710
	public struct ICheckPlayerInputCondition : IFlatbufferObject
	{
		// Token: 0x17006BCE RID: 27598
		// (get) Token: 0x06015BB7 RID: 89015 RVA: 0x0032273E File Offset: 0x0032093E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06015BB8 RID: 89016 RVA: 0x0032274B File Offset: 0x0032094B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06015BB9 RID: 89017 RVA: 0x00322754 File Offset: 0x00320954
		public static ICheckPlayerInputCondition GetRootAsICheckPlayerInputCondition(ByteBuffer _bb)
		{
			return ICheckPlayerInputCondition.GetRootAsICheckPlayerInputCondition(_bb, default(ICheckPlayerInputCondition));
		}

		// Token: 0x06015BBA RID: 89018 RVA: 0x00322770 File Offset: 0x00320970
		public static ICheckPlayerInputCondition GetRootAsICheckPlayerInputCondition(ByteBuffer _bb, ICheckPlayerInputCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06015BBB RID: 89019 RVA: 0x0032278D File Offset: 0x0032098D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06015BBC RID: 89020 RVA: 0x0032279C File Offset: 0x0032099C
		public ICheckPlayerInputCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006BCF RID: 27599
		// (get) Token: 0x06015BBD RID: 89021 RVA: 0x003227AC File Offset: 0x003209AC
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

		// Token: 0x17006BD0 RID: 27600
		// (get) Token: 0x06015BBE RID: 89022 RVA: 0x003227E8 File Offset: 0x003209E8
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

		// Token: 0x17006BD1 RID: 27601
		// (get) Token: 0x06015BBF RID: 89023 RVA: 0x00322848 File Offset: 0x00320A48
		public ICheckPlayerPressButton? CheckInput
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return new ICheckPlayerPressButton?(default(ICheckPlayerPressButton).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x06015BC0 RID: 89024 RVA: 0x003228A5 File Offset: 0x00320AA5
		public static Offset<ICheckPlayerInputCondition> CreateICheckPlayerInputCondition(FlatBufferBuilder builder, EChildQuest Type = EChildQuest.DoInteract, Offset<IConditionGroup> PreConditionsOffset = default(Offset<IConditionGroup>), Offset<ICheckPlayerPressButton> CheckInputOffset = default(Offset<ICheckPlayerPressButton>))
		{
			builder.StartTable(3);
			ICheckPlayerInputCondition.AddCheckInput(builder, CheckInputOffset);
			ICheckPlayerInputCondition.AddPreConditions(builder, PreConditionsOffset);
			ICheckPlayerInputCondition.AddType(builder, Type);
			return ICheckPlayerInputCondition.EndICheckPlayerInputCondition(builder);
		}

		// Token: 0x06015BC1 RID: 89025 RVA: 0x003228C9 File Offset: 0x00320AC9
		public static void StartICheckPlayerInputCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06015BC2 RID: 89026 RVA: 0x003228D2 File Offset: 0x00320AD2
		public static void AddType(FlatBufferBuilder builder, EChildQuest type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06015BC3 RID: 89027 RVA: 0x003228DD File Offset: 0x00320ADD
		public static void AddPreConditions(FlatBufferBuilder builder, Offset<IConditionGroup> preConditionsOffset)
		{
			builder.AddOffset(1, preConditionsOffset.Value, 0);
		}

		// Token: 0x06015BC4 RID: 89028 RVA: 0x003228ED File Offset: 0x00320AED
		public static void AddCheckInput(FlatBufferBuilder builder, Offset<ICheckPlayerPressButton> checkInputOffset)
		{
			builder.AddOffset(2, checkInputOffset.Value, 0);
		}

		// Token: 0x06015BC5 RID: 89029 RVA: 0x003228FD File Offset: 0x00320AFD
		public static Offset<ICheckPlayerInputCondition> EndICheckPlayerInputCondition(FlatBufferBuilder builder)
		{
			return new Offset<ICheckPlayerInputCondition>(builder.EndTable());
		}

		// Token: 0x06015BC6 RID: 89030 RVA: 0x0032290C File Offset: 0x00320B0C
		public ICheckPlayerInputConditionT UnPack()
		{
			ICheckPlayerInputConditionT checkPlayerInputConditionT = new ICheckPlayerInputConditionT();
			this.UnPackTo(checkPlayerInputConditionT);
			return checkPlayerInputConditionT;
		}

		// Token: 0x06015BC7 RID: 89031 RVA: 0x00322928 File Offset: 0x00320B28
		public void UnPackTo(ICheckPlayerInputConditionT _o)
		{
			_o.Type = this.Type;
			_o.PreConditions = ((this.PreConditions != null) ? this.PreConditions.Value.UnPack() : null);
			_o.CheckInput = ((this.CheckInput != null) ? this.CheckInput.Value.UnPack() : null);
		}

		// Token: 0x06015BC8 RID: 89032 RVA: 0x003229A0 File Offset: 0x00320BA0
		public static Offset<ICheckPlayerInputCondition> Pack(FlatBufferBuilder builder, ICheckPlayerInputConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckPlayerInputCondition>);
			}
			Offset<IConditionGroup> preConditionsOffset = (_o.PreConditions == null) ? default(Offset<IConditionGroup>) : IConditionGroup.Pack(builder, _o.PreConditions);
			Offset<ICheckPlayerPressButton> checkInputOffset = (_o.CheckInput == null) ? default(Offset<ICheckPlayerPressButton>) : ICheckPlayerPressButton.Pack(builder, _o.CheckInput);
			return ICheckPlayerInputCondition.CreateICheckPlayerInputCondition(builder, _o.Type, preConditionsOffset, checkInputOffset);
		}

		// Token: 0x0400B63E RID: 46654
		private Table __p;
	}
}
