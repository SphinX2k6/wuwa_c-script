using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003EF6 RID: 16118
	public struct ILeaveDungeonCondition : IFlatbufferObject
	{
		// Token: 0x17006FCE RID: 28622
		// (get) Token: 0x06016CE4 RID: 93412 RVA: 0x0034A254 File Offset: 0x00348454
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06016CE5 RID: 93413 RVA: 0x0034A261 File Offset: 0x00348461
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06016CE6 RID: 93414 RVA: 0x0034A268 File Offset: 0x00348468
		public static ILeaveDungeonCondition GetRootAsILeaveDungeonCondition(ByteBuffer _bb)
		{
			return ILeaveDungeonCondition.GetRootAsILeaveDungeonCondition(_bb, default(ILeaveDungeonCondition));
		}

		// Token: 0x06016CE7 RID: 93415 RVA: 0x0034A284 File Offset: 0x00348484
		public static ILeaveDungeonCondition GetRootAsILeaveDungeonCondition(ByteBuffer _bb, ILeaveDungeonCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06016CE8 RID: 93416 RVA: 0x0034A2A1 File Offset: 0x003484A1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06016CE9 RID: 93417 RVA: 0x0034A2B0 File Offset: 0x003484B0
		public ILeaveDungeonCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006FCF RID: 28623
		// (get) Token: 0x06016CEA RID: 93418 RVA: 0x0034A2C0 File Offset: 0x003484C0
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

		// Token: 0x17006FD0 RID: 28624
		// (get) Token: 0x06016CEB RID: 93419 RVA: 0x0034A2FC File Offset: 0x003484FC
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

		// Token: 0x06016CEC RID: 93420 RVA: 0x0034A359 File Offset: 0x00348559
		public static Offset<ILeaveDungeonCondition> CreateILeaveDungeonCondition(FlatBufferBuilder builder, EChildQuest Type = EChildQuest.DoInteract, Offset<IConditionGroup> PreConditionsOffset = default(Offset<IConditionGroup>))
		{
			builder.StartTable(2);
			ILeaveDungeonCondition.AddPreConditions(builder, PreConditionsOffset);
			ILeaveDungeonCondition.AddType(builder, Type);
			return ILeaveDungeonCondition.EndILeaveDungeonCondition(builder);
		}

		// Token: 0x06016CED RID: 93421 RVA: 0x0034A376 File Offset: 0x00348576
		public static void StartILeaveDungeonCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06016CEE RID: 93422 RVA: 0x0034A37F File Offset: 0x0034857F
		public static void AddType(FlatBufferBuilder builder, EChildQuest type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06016CEF RID: 93423 RVA: 0x0034A38A File Offset: 0x0034858A
		public static void AddPreConditions(FlatBufferBuilder builder, Offset<IConditionGroup> preConditionsOffset)
		{
			builder.AddOffset(1, preConditionsOffset.Value, 0);
		}

		// Token: 0x06016CF0 RID: 93424 RVA: 0x0034A39A File Offset: 0x0034859A
		public static Offset<ILeaveDungeonCondition> EndILeaveDungeonCondition(FlatBufferBuilder builder)
		{
			return new Offset<ILeaveDungeonCondition>(builder.EndTable());
		}

		// Token: 0x06016CF1 RID: 93425 RVA: 0x0034A3A8 File Offset: 0x003485A8
		public ILeaveDungeonConditionT UnPack()
		{
			ILeaveDungeonConditionT leaveDungeonConditionT = new ILeaveDungeonConditionT();
			this.UnPackTo(leaveDungeonConditionT);
			return leaveDungeonConditionT;
		}

		// Token: 0x06016CF2 RID: 93426 RVA: 0x0034A3C4 File Offset: 0x003485C4
		public void UnPackTo(ILeaveDungeonConditionT _o)
		{
			_o.Type = this.Type;
			_o.PreConditions = ((this.PreConditions != null) ? this.PreConditions.Value.UnPack() : null);
		}

		// Token: 0x06016CF3 RID: 93427 RVA: 0x0034A40C File Offset: 0x0034860C
		public static Offset<ILeaveDungeonCondition> Pack(FlatBufferBuilder builder, ILeaveDungeonConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<ILeaveDungeonCondition>);
			}
			Offset<IConditionGroup> preConditionsOffset = (_o.PreConditions == null) ? default(Offset<IConditionGroup>) : IConditionGroup.Pack(builder, _o.PreConditions);
			return ILeaveDungeonCondition.CreateILeaveDungeonCondition(builder, _o.Type, preConditionsOffset);
		}

		// Token: 0x0400B8D3 RID: 47315
		private Table __p;
	}
}
