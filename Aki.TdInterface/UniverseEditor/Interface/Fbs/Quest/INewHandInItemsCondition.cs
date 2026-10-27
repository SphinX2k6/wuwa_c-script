using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003F56 RID: 16214
	public struct INewHandInItemsCondition : IFlatbufferObject
	{
		// Token: 0x170070BC RID: 28860
		// (get) Token: 0x060170DE RID: 94430 RVA: 0x00352DE2 File Offset: 0x00350FE2
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060170DF RID: 94431 RVA: 0x00352DEF File Offset: 0x00350FEF
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060170E0 RID: 94432 RVA: 0x00352DF8 File Offset: 0x00350FF8
		public static INewHandInItemsCondition GetRootAsINewHandInItemsCondition(ByteBuffer _bb)
		{
			return INewHandInItemsCondition.GetRootAsINewHandInItemsCondition(_bb, default(INewHandInItemsCondition));
		}

		// Token: 0x060170E1 RID: 94433 RVA: 0x00352E14 File Offset: 0x00351014
		public static INewHandInItemsCondition GetRootAsINewHandInItemsCondition(ByteBuffer _bb, INewHandInItemsCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060170E2 RID: 94434 RVA: 0x00352E31 File Offset: 0x00351031
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060170E3 RID: 94435 RVA: 0x00352E40 File Offset: 0x00351040
		public INewHandInItemsCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170070BD RID: 28861
		// (get) Token: 0x060170E4 RID: 94436 RVA: 0x00352E50 File Offset: 0x00351050
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

		// Token: 0x170070BE RID: 28862
		// (get) Token: 0x060170E5 RID: 94437 RVA: 0x00352E8C File Offset: 0x0035108C
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

		// Token: 0x170070BF RID: 28863
		// (get) Token: 0x060170E6 RID: 94438 RVA: 0x00352EEC File Offset: 0x003510EC
		public INewHandInItemsProjectionMachine? HandIn
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return new INewHandInItemsProjectionMachine?(default(INewHandInItemsProjectionMachine).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x060170E7 RID: 94439 RVA: 0x00352F49 File Offset: 0x00351149
		public static Offset<INewHandInItemsCondition> CreateINewHandInItemsCondition(FlatBufferBuilder builder, EChildQuest Type = EChildQuest.DoInteract, Offset<IConditionGroup> PreConditionsOffset = default(Offset<IConditionGroup>), Offset<INewHandInItemsProjectionMachine> HandInOffset = default(Offset<INewHandInItemsProjectionMachine>))
		{
			builder.StartTable(3);
			INewHandInItemsCondition.AddHandIn(builder, HandInOffset);
			INewHandInItemsCondition.AddPreConditions(builder, PreConditionsOffset);
			INewHandInItemsCondition.AddType(builder, Type);
			return INewHandInItemsCondition.EndINewHandInItemsCondition(builder);
		}

		// Token: 0x060170E8 RID: 94440 RVA: 0x00352F6D File Offset: 0x0035116D
		public static void StartINewHandInItemsCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x060170E9 RID: 94441 RVA: 0x00352F76 File Offset: 0x00351176
		public static void AddType(FlatBufferBuilder builder, EChildQuest type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060170EA RID: 94442 RVA: 0x00352F81 File Offset: 0x00351181
		public static void AddPreConditions(FlatBufferBuilder builder, Offset<IConditionGroup> preConditionsOffset)
		{
			builder.AddOffset(1, preConditionsOffset.Value, 0);
		}

		// Token: 0x060170EB RID: 94443 RVA: 0x00352F91 File Offset: 0x00351191
		public static void AddHandIn(FlatBufferBuilder builder, Offset<INewHandInItemsProjectionMachine> handInOffset)
		{
			builder.AddOffset(2, handInOffset.Value, 0);
		}

		// Token: 0x060170EC RID: 94444 RVA: 0x00352FA1 File Offset: 0x003511A1
		public static Offset<INewHandInItemsCondition> EndINewHandInItemsCondition(FlatBufferBuilder builder)
		{
			return new Offset<INewHandInItemsCondition>(builder.EndTable());
		}

		// Token: 0x060170ED RID: 94445 RVA: 0x00352FB0 File Offset: 0x003511B0
		public INewHandInItemsConditionT UnPack()
		{
			INewHandInItemsConditionT newHandInItemsConditionT = new INewHandInItemsConditionT();
			this.UnPackTo(newHandInItemsConditionT);
			return newHandInItemsConditionT;
		}

		// Token: 0x060170EE RID: 94446 RVA: 0x00352FCC File Offset: 0x003511CC
		public void UnPackTo(INewHandInItemsConditionT _o)
		{
			_o.Type = this.Type;
			_o.PreConditions = ((this.PreConditions != null) ? this.PreConditions.Value.UnPack() : null);
			_o.HandIn = ((this.HandIn != null) ? this.HandIn.Value.UnPack() : null);
		}

		// Token: 0x060170EF RID: 94447 RVA: 0x00353044 File Offset: 0x00351244
		public static Offset<INewHandInItemsCondition> Pack(FlatBufferBuilder builder, INewHandInItemsConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<INewHandInItemsCondition>);
			}
			Offset<IConditionGroup> preConditionsOffset = (_o.PreConditions == null) ? default(Offset<IConditionGroup>) : IConditionGroup.Pack(builder, _o.PreConditions);
			Offset<INewHandInItemsProjectionMachine> handInOffset = (_o.HandIn == null) ? default(Offset<INewHandInItemsProjectionMachine>) : INewHandInItemsProjectionMachine.Pack(builder, _o.HandIn);
			return INewHandInItemsCondition.CreateINewHandInItemsCondition(builder, _o.Type, preConditionsOffset, handInOffset);
		}

		// Token: 0x0400B969 RID: 47465
		private Table __p;
	}
}
