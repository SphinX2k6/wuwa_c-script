using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004394 RID: 17300
	public struct INewHandInItemsCondition : IFlatbufferObject
	{
		// Token: 0x170076AD RID: 30381
		// (get) Token: 0x06018740 RID: 100160 RVA: 0x0037C256 File Offset: 0x0037A456
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06018741 RID: 100161 RVA: 0x0037C263 File Offset: 0x0037A463
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06018742 RID: 100162 RVA: 0x0037C26C File Offset: 0x0037A46C
		public static INewHandInItemsCondition GetRootAsINewHandInItemsCondition(ByteBuffer _bb)
		{
			return INewHandInItemsCondition.GetRootAsINewHandInItemsCondition(_bb, default(INewHandInItemsCondition));
		}

		// Token: 0x06018743 RID: 100163 RVA: 0x0037C288 File Offset: 0x0037A488
		public static INewHandInItemsCondition GetRootAsINewHandInItemsCondition(ByteBuffer _bb, INewHandInItemsCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06018744 RID: 100164 RVA: 0x0037C2A5 File Offset: 0x0037A4A5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06018745 RID: 100165 RVA: 0x0037C2B4 File Offset: 0x0037A4B4
		public INewHandInItemsCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170076AE RID: 30382
		// (get) Token: 0x06018746 RID: 100166 RVA: 0x0037C2C4 File Offset: 0x0037A4C4
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

		// Token: 0x170076AF RID: 30383
		// (get) Token: 0x06018747 RID: 100167 RVA: 0x0037C300 File Offset: 0x0037A500
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

		// Token: 0x170076B0 RID: 30384
		// (get) Token: 0x06018748 RID: 100168 RVA: 0x0037C360 File Offset: 0x0037A560
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

		// Token: 0x06018749 RID: 100169 RVA: 0x0037C3BD File Offset: 0x0037A5BD
		public static Offset<INewHandInItemsCondition> CreateINewHandInItemsCondition(FlatBufferBuilder builder, EChildQuest Type = EChildQuest.DoInteract, Offset<IConditionGroup> PreConditionsOffset = default(Offset<IConditionGroup>), Offset<INewHandInItemsProjectionMachine> HandInOffset = default(Offset<INewHandInItemsProjectionMachine>))
		{
			builder.StartTable(3);
			INewHandInItemsCondition.AddHandIn(builder, HandInOffset);
			INewHandInItemsCondition.AddPreConditions(builder, PreConditionsOffset);
			INewHandInItemsCondition.AddType(builder, Type);
			return INewHandInItemsCondition.EndINewHandInItemsCondition(builder);
		}

		// Token: 0x0601874A RID: 100170 RVA: 0x0037C3E1 File Offset: 0x0037A5E1
		public static void StartINewHandInItemsCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601874B RID: 100171 RVA: 0x0037C3EA File Offset: 0x0037A5EA
		public static void AddType(FlatBufferBuilder builder, EChildQuest type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601874C RID: 100172 RVA: 0x0037C3F5 File Offset: 0x0037A5F5
		public static void AddPreConditions(FlatBufferBuilder builder, Offset<IConditionGroup> preConditionsOffset)
		{
			builder.AddOffset(1, preConditionsOffset.Value, 0);
		}

		// Token: 0x0601874D RID: 100173 RVA: 0x0037C405 File Offset: 0x0037A605
		public static void AddHandIn(FlatBufferBuilder builder, Offset<INewHandInItemsProjectionMachine> handInOffset)
		{
			builder.AddOffset(2, handInOffset.Value, 0);
		}

		// Token: 0x0601874E RID: 100174 RVA: 0x0037C415 File Offset: 0x0037A615
		public static Offset<INewHandInItemsCondition> EndINewHandInItemsCondition(FlatBufferBuilder builder)
		{
			return new Offset<INewHandInItemsCondition>(builder.EndTable());
		}

		// Token: 0x0601874F RID: 100175 RVA: 0x0037C424 File Offset: 0x0037A624
		public INewHandInItemsConditionT UnPack()
		{
			INewHandInItemsConditionT newHandInItemsConditionT = new INewHandInItemsConditionT();
			this.UnPackTo(newHandInItemsConditionT);
			return newHandInItemsConditionT;
		}

		// Token: 0x06018750 RID: 100176 RVA: 0x0037C440 File Offset: 0x0037A640
		public void UnPackTo(INewHandInItemsConditionT _o)
		{
			_o.Type = this.Type;
			_o.PreConditions = ((this.PreConditions != null) ? this.PreConditions.Value.UnPack() : null);
			_o.HandIn = ((this.HandIn != null) ? this.HandIn.Value.UnPack() : null);
		}

		// Token: 0x06018751 RID: 100177 RVA: 0x0037C4B8 File Offset: 0x0037A6B8
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

		// Token: 0x0400C347 RID: 49991
		private Table __p;
	}
}
