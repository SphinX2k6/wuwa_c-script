using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003EA8 RID: 16040
	public struct IInformationViewCheckCondition : IFlatbufferObject
	{
		// Token: 0x17006F59 RID: 28505
		// (get) Token: 0x06016A62 RID: 92770 RVA: 0x003454E6 File Offset: 0x003436E6
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06016A63 RID: 92771 RVA: 0x003454F3 File Offset: 0x003436F3
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06016A64 RID: 92772 RVA: 0x003454FC File Offset: 0x003436FC
		public static IInformationViewCheckCondition GetRootAsIInformationViewCheckCondition(ByteBuffer _bb)
		{
			return IInformationViewCheckCondition.GetRootAsIInformationViewCheckCondition(_bb, default(IInformationViewCheckCondition));
		}

		// Token: 0x06016A65 RID: 92773 RVA: 0x00345518 File Offset: 0x00343718
		public static IInformationViewCheckCondition GetRootAsIInformationViewCheckCondition(ByteBuffer _bb, IInformationViewCheckCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06016A66 RID: 92774 RVA: 0x00345535 File Offset: 0x00343735
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06016A67 RID: 92775 RVA: 0x00345544 File Offset: 0x00343744
		public IInformationViewCheckCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006F5A RID: 28506
		// (get) Token: 0x06016A68 RID: 92776 RVA: 0x00345554 File Offset: 0x00343754
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

		// Token: 0x17006F5B RID: 28507
		// (get) Token: 0x06016A69 RID: 92777 RVA: 0x00345590 File Offset: 0x00343790
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

		// Token: 0x17006F5C RID: 28508
		// (get) Token: 0x06016A6A RID: 92778 RVA: 0x003455F0 File Offset: 0x003437F0
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

		// Token: 0x06016A6B RID: 92779 RVA: 0x0034562C File Offset: 0x0034382C
		public static Offset<IInformationViewCheckCondition> CreateIInformationViewCheckCondition(FlatBufferBuilder builder, EChildQuest Type = EChildQuest.DoInteract, Offset<IConditionGroup> PreConditionsOffset = default(Offset<IConditionGroup>), int InformationViewId = 0)
		{
			builder.StartTable(3);
			IInformationViewCheckCondition.AddInformationViewId(builder, InformationViewId);
			IInformationViewCheckCondition.AddPreConditions(builder, PreConditionsOffset);
			IInformationViewCheckCondition.AddType(builder, Type);
			return IInformationViewCheckCondition.EndIInformationViewCheckCondition(builder);
		}

		// Token: 0x06016A6C RID: 92780 RVA: 0x00345650 File Offset: 0x00343850
		public static void StartIInformationViewCheckCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06016A6D RID: 92781 RVA: 0x00345659 File Offset: 0x00343859
		public static void AddType(FlatBufferBuilder builder, EChildQuest type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06016A6E RID: 92782 RVA: 0x00345664 File Offset: 0x00343864
		public static void AddPreConditions(FlatBufferBuilder builder, Offset<IConditionGroup> preConditionsOffset)
		{
			builder.AddOffset(1, preConditionsOffset.Value, 0);
		}

		// Token: 0x06016A6F RID: 92783 RVA: 0x00345674 File Offset: 0x00343874
		public static void AddInformationViewId(FlatBufferBuilder builder, int informationViewId)
		{
			builder.AddInt(2, informationViewId, 0);
		}

		// Token: 0x06016A70 RID: 92784 RVA: 0x0034567F File Offset: 0x0034387F
		public static Offset<IInformationViewCheckCondition> EndIInformationViewCheckCondition(FlatBufferBuilder builder)
		{
			return new Offset<IInformationViewCheckCondition>(builder.EndTable());
		}

		// Token: 0x06016A71 RID: 92785 RVA: 0x0034568C File Offset: 0x0034388C
		public IInformationViewCheckConditionT UnPack()
		{
			IInformationViewCheckConditionT informationViewCheckConditionT = new IInformationViewCheckConditionT();
			this.UnPackTo(informationViewCheckConditionT);
			return informationViewCheckConditionT;
		}

		// Token: 0x06016A72 RID: 92786 RVA: 0x003456A8 File Offset: 0x003438A8
		public void UnPackTo(IInformationViewCheckConditionT _o)
		{
			_o.Type = this.Type;
			_o.PreConditions = ((this.PreConditions != null) ? this.PreConditions.Value.UnPack() : null);
			_o.InformationViewId = this.InformationViewId;
		}

		// Token: 0x06016A73 RID: 92787 RVA: 0x003456FC File Offset: 0x003438FC
		public static Offset<IInformationViewCheckCondition> Pack(FlatBufferBuilder builder, IInformationViewCheckConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IInformationViewCheckCondition>);
			}
			Offset<IConditionGroup> preConditionsOffset = (_o.PreConditions == null) ? default(Offset<IConditionGroup>) : IConditionGroup.Pack(builder, _o.PreConditions);
			return IInformationViewCheckCondition.CreateIInformationViewCheckCondition(builder, _o.Type, preConditionsOffset, _o.InformationViewId);
		}

		// Token: 0x0400B874 RID: 47220
		private Table __p;
	}
}
