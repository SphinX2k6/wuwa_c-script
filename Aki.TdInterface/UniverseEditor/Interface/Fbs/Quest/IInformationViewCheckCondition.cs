using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020042E6 RID: 17126
	public struct IInformationViewCheckCondition : IFlatbufferObject
	{
		// Token: 0x17007546 RID: 30022
		// (get) Token: 0x060180AF RID: 98479 RVA: 0x0036E46E File Offset: 0x0036C66E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060180B0 RID: 98480 RVA: 0x0036E47B File Offset: 0x0036C67B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060180B1 RID: 98481 RVA: 0x0036E484 File Offset: 0x0036C684
		public static IInformationViewCheckCondition GetRootAsIInformationViewCheckCondition(ByteBuffer _bb)
		{
			return IInformationViewCheckCondition.GetRootAsIInformationViewCheckCondition(_bb, default(IInformationViewCheckCondition));
		}

		// Token: 0x060180B2 RID: 98482 RVA: 0x0036E4A0 File Offset: 0x0036C6A0
		public static IInformationViewCheckCondition GetRootAsIInformationViewCheckCondition(ByteBuffer _bb, IInformationViewCheckCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060180B3 RID: 98483 RVA: 0x0036E4BD File Offset: 0x0036C6BD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060180B4 RID: 98484 RVA: 0x0036E4CC File Offset: 0x0036C6CC
		public IInformationViewCheckCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007547 RID: 30023
		// (get) Token: 0x060180B5 RID: 98485 RVA: 0x0036E4DC File Offset: 0x0036C6DC
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

		// Token: 0x17007548 RID: 30024
		// (get) Token: 0x060180B6 RID: 98486 RVA: 0x0036E518 File Offset: 0x0036C718
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

		// Token: 0x17007549 RID: 30025
		// (get) Token: 0x060180B7 RID: 98487 RVA: 0x0036E578 File Offset: 0x0036C778
		public int InformationViewId
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060180B8 RID: 98488 RVA: 0x0036E5B4 File Offset: 0x0036C7B4
		public static Offset<IInformationViewCheckCondition> CreateIInformationViewCheckCondition(FlatBufferBuilder builder, EChildQuest Type = EChildQuest.DoInteract, Offset<IConditionGroup> PreConditionsOffset = default(Offset<IConditionGroup>), int InformationViewId = 0)
		{
			builder.StartTable(3);
			IInformationViewCheckCondition.AddInformationViewId(builder, InformationViewId);
			IInformationViewCheckCondition.AddPreConditions(builder, PreConditionsOffset);
			IInformationViewCheckCondition.AddType(builder, Type);
			return IInformationViewCheckCondition.EndIInformationViewCheckCondition(builder);
		}

		// Token: 0x060180B9 RID: 98489 RVA: 0x0036E5D8 File Offset: 0x0036C7D8
		public static void StartIInformationViewCheckCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x060180BA RID: 98490 RVA: 0x0036E5E1 File Offset: 0x0036C7E1
		public static void AddType(FlatBufferBuilder builder, EChildQuest type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060180BB RID: 98491 RVA: 0x0036E5EC File Offset: 0x0036C7EC
		public static void AddPreConditions(FlatBufferBuilder builder, Offset<IConditionGroup> preConditionsOffset)
		{
			builder.AddOffset(1, preConditionsOffset.Value, 0);
		}

		// Token: 0x060180BC RID: 98492 RVA: 0x0036E5FC File Offset: 0x0036C7FC
		public static void AddInformationViewId(FlatBufferBuilder builder, int informationViewId)
		{
			builder.AddInt(2, informationViewId, 0);
		}

		// Token: 0x060180BD RID: 98493 RVA: 0x0036E607 File Offset: 0x0036C807
		public static Offset<IInformationViewCheckCondition> EndIInformationViewCheckCondition(FlatBufferBuilder builder)
		{
			return new Offset<IInformationViewCheckCondition>(builder.EndTable());
		}

		// Token: 0x060180BE RID: 98494 RVA: 0x0036E614 File Offset: 0x0036C814
		public IInformationViewCheckConditionT UnPack()
		{
			IInformationViewCheckConditionT informationViewCheckConditionT = new IInformationViewCheckConditionT();
			this.UnPackTo(informationViewCheckConditionT);
			return informationViewCheckConditionT;
		}

		// Token: 0x060180BF RID: 98495 RVA: 0x0036E630 File Offset: 0x0036C830
		public void UnPackTo(IInformationViewCheckConditionT _o)
		{
			_o.Type = this.Type;
			_o.PreConditions = ((this.PreConditions != null) ? this.PreConditions.Value.UnPack() : null);
			_o.InformationViewId = this.InformationViewId;
		}

		// Token: 0x060180C0 RID: 98496 RVA: 0x0036E684 File Offset: 0x0036C884
		public static Offset<IInformationViewCheckCondition> Pack(FlatBufferBuilder builder, IInformationViewCheckConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IInformationViewCheckCondition>);
			}
			Offset<IConditionGroup> preConditionsOffset = (_o.PreConditions == null) ? default(Offset<IConditionGroup>) : IConditionGroup.Pack(builder, _o.PreConditions);
			return IInformationViewCheckCondition.CreateIInformationViewCheckCondition(builder, _o.Type, preConditionsOffset, _o.InformationViewId);
		}

		// Token: 0x0400C250 RID: 49744
		private Table __p;
	}
}
