using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004175 RID: 16757
	public struct ICheckPlayerInputCondition : IFlatbufferObject
	{
		// Token: 0x17007188 RID: 29064
		// (get) Token: 0x060170EF RID: 94447 RVA: 0x003499B6 File Offset: 0x00347BB6
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060170F0 RID: 94448 RVA: 0x003499C3 File Offset: 0x00347BC3
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060170F1 RID: 94449 RVA: 0x003499CC File Offset: 0x00347BCC
		public static ICheckPlayerInputCondition GetRootAsICheckPlayerInputCondition(ByteBuffer _bb)
		{
			return ICheckPlayerInputCondition.GetRootAsICheckPlayerInputCondition(_bb, default(ICheckPlayerInputCondition));
		}

		// Token: 0x060170F2 RID: 94450 RVA: 0x003499E8 File Offset: 0x00347BE8
		public static ICheckPlayerInputCondition GetRootAsICheckPlayerInputCondition(ByteBuffer _bb, ICheckPlayerInputCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060170F3 RID: 94451 RVA: 0x00349A05 File Offset: 0x00347C05
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060170F4 RID: 94452 RVA: 0x00349A14 File Offset: 0x00347C14
		public ICheckPlayerInputCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007189 RID: 29065
		// (get) Token: 0x060170F5 RID: 94453 RVA: 0x00349A24 File Offset: 0x00347C24
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

		// Token: 0x1700718A RID: 29066
		// (get) Token: 0x060170F6 RID: 94454 RVA: 0x00349A60 File Offset: 0x00347C60
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

		// Token: 0x1700718B RID: 29067
		// (get) Token: 0x060170F7 RID: 94455 RVA: 0x00349AC0 File Offset: 0x00347CC0
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

		// Token: 0x060170F8 RID: 94456 RVA: 0x00349B1D File Offset: 0x00347D1D
		public static Offset<ICheckPlayerInputCondition> CreateICheckPlayerInputCondition(FlatBufferBuilder builder, EChildQuest Type = EChildQuest.DoInteract, Offset<IConditionGroup> PreConditionsOffset = default(Offset<IConditionGroup>), Offset<ICheckPlayerPressButton> CheckInputOffset = default(Offset<ICheckPlayerPressButton>))
		{
			builder.StartTable(3);
			ICheckPlayerInputCondition.AddCheckInput(builder, CheckInputOffset);
			ICheckPlayerInputCondition.AddPreConditions(builder, PreConditionsOffset);
			ICheckPlayerInputCondition.AddType(builder, Type);
			return ICheckPlayerInputCondition.EndICheckPlayerInputCondition(builder);
		}

		// Token: 0x060170F9 RID: 94457 RVA: 0x00349B41 File Offset: 0x00347D41
		public static void StartICheckPlayerInputCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x060170FA RID: 94458 RVA: 0x00349B4A File Offset: 0x00347D4A
		public static void AddType(FlatBufferBuilder builder, EChildQuest type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060170FB RID: 94459 RVA: 0x00349B55 File Offset: 0x00347D55
		public static void AddPreConditions(FlatBufferBuilder builder, Offset<IConditionGroup> preConditionsOffset)
		{
			builder.AddOffset(1, preConditionsOffset.Value, 0);
		}

		// Token: 0x060170FC RID: 94460 RVA: 0x00349B65 File Offset: 0x00347D65
		public static void AddCheckInput(FlatBufferBuilder builder, Offset<ICheckPlayerPressButton> checkInputOffset)
		{
			builder.AddOffset(2, checkInputOffset.Value, 0);
		}

		// Token: 0x060170FD RID: 94461 RVA: 0x00349B75 File Offset: 0x00347D75
		public static Offset<ICheckPlayerInputCondition> EndICheckPlayerInputCondition(FlatBufferBuilder builder)
		{
			return new Offset<ICheckPlayerInputCondition>(builder.EndTable());
		}

		// Token: 0x060170FE RID: 94462 RVA: 0x00349B84 File Offset: 0x00347D84
		public ICheckPlayerInputConditionT UnPack()
		{
			ICheckPlayerInputConditionT checkPlayerInputConditionT = new ICheckPlayerInputConditionT();
			this.UnPackTo(checkPlayerInputConditionT);
			return checkPlayerInputConditionT;
		}

		// Token: 0x060170FF RID: 94463 RVA: 0x00349BA0 File Offset: 0x00347DA0
		public void UnPackTo(ICheckPlayerInputConditionT _o)
		{
			_o.Type = this.Type;
			_o.PreConditions = ((this.PreConditions != null) ? this.PreConditions.Value.UnPack() : null);
			_o.CheckInput = ((this.CheckInput != null) ? this.CheckInput.Value.UnPack() : null);
		}

		// Token: 0x06017100 RID: 94464 RVA: 0x00349C18 File Offset: 0x00347E18
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

		// Token: 0x0400BFEB RID: 49131
		private Table __p;
	}
}
