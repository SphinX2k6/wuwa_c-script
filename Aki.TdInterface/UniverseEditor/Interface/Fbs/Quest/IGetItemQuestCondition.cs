using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003E78 RID: 15992
	public struct IGetItemQuestCondition : IFlatbufferObject
	{
		// Token: 0x17006EE5 RID: 28389
		// (get) Token: 0x06016877 RID: 92279 RVA: 0x003416E5 File Offset: 0x0033F8E5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06016878 RID: 92280 RVA: 0x003416F2 File Offset: 0x0033F8F2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06016879 RID: 92281 RVA: 0x003416FC File Offset: 0x0033F8FC
		public static IGetItemQuestCondition GetRootAsIGetItemQuestCondition(ByteBuffer _bb)
		{
			return IGetItemQuestCondition.GetRootAsIGetItemQuestCondition(_bb, default(IGetItemQuestCondition));
		}

		// Token: 0x0601687A RID: 92282 RVA: 0x00341718 File Offset: 0x0033F918
		public static IGetItemQuestCondition GetRootAsIGetItemQuestCondition(ByteBuffer _bb, IGetItemQuestCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601687B RID: 92283 RVA: 0x00341735 File Offset: 0x0033F935
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601687C RID: 92284 RVA: 0x00341744 File Offset: 0x0033F944
		public IGetItemQuestCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006EE6 RID: 28390
		// (get) Token: 0x0601687D RID: 92285 RVA: 0x00341754 File Offset: 0x0033F954
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

		// Token: 0x17006EE7 RID: 28391
		// (get) Token: 0x0601687E RID: 92286 RVA: 0x00341790 File Offset: 0x0033F990
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

		// Token: 0x0601687F RID: 92287 RVA: 0x003417F0 File Offset: 0x0033F9F0
		public IItemConfig? Items(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new IItemConfig?(default(IItemConfig).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17006EE8 RID: 28392
		// (get) Token: 0x06016880 RID: 92288 RVA: 0x00341850 File Offset: 0x0033FA50
		public int ItemsLength
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06016881 RID: 92289 RVA: 0x0034187B File Offset: 0x0033FA7B
		public static Offset<IGetItemQuestCondition> CreateIGetItemQuestCondition(FlatBufferBuilder builder, EChildQuest Type = EChildQuest.DoInteract, Offset<IConditionGroup> PreConditionsOffset = default(Offset<IConditionGroup>), VectorOffset ItemsOffset = default(VectorOffset))
		{
			builder.StartTable(3);
			IGetItemQuestCondition.AddItems(builder, ItemsOffset);
			IGetItemQuestCondition.AddPreConditions(builder, PreConditionsOffset);
			IGetItemQuestCondition.AddType(builder, Type);
			return IGetItemQuestCondition.EndIGetItemQuestCondition(builder);
		}

		// Token: 0x06016882 RID: 92290 RVA: 0x0034189F File Offset: 0x0033FA9F
		public static void StartIGetItemQuestCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06016883 RID: 92291 RVA: 0x003418A8 File Offset: 0x0033FAA8
		public static void AddType(FlatBufferBuilder builder, EChildQuest type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06016884 RID: 92292 RVA: 0x003418B3 File Offset: 0x0033FAB3
		public static void AddPreConditions(FlatBufferBuilder builder, Offset<IConditionGroup> preConditionsOffset)
		{
			builder.AddOffset(1, preConditionsOffset.Value, 0);
		}

		// Token: 0x06016885 RID: 92293 RVA: 0x003418C3 File Offset: 0x0033FAC3
		public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset)
		{
			builder.AddOffset(2, itemsOffset.Value, 0);
		}

		// Token: 0x06016886 RID: 92294 RVA: 0x003418D4 File Offset: 0x0033FAD4
		public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<IItemConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06016887 RID: 92295 RVA: 0x00341914 File Offset: 0x0033FB14
		public static VectorOffset CreateItemsVectorBlock(FlatBufferBuilder builder, Offset<IItemConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IItemConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x06016888 RID: 92296 RVA: 0x0034192E File Offset: 0x0033FB2E
		public static VectorOffset CreateItemsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IItemConfig>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IItemConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x06016889 RID: 92297 RVA: 0x0034194C File Offset: 0x0033FB4C
		public static VectorOffset CreateItemsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IItemConfig>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601688A RID: 92298 RVA: 0x00341965 File Offset: 0x0033FB65
		public static void StartItemsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601688B RID: 92299 RVA: 0x00341970 File Offset: 0x0033FB70
		public static Offset<IGetItemQuestCondition> EndIGetItemQuestCondition(FlatBufferBuilder builder)
		{
			return new Offset<IGetItemQuestCondition>(builder.EndTable());
		}

		// Token: 0x0601688C RID: 92300 RVA: 0x00341980 File Offset: 0x0033FB80
		public IGetItemQuestConditionT UnPack()
		{
			IGetItemQuestConditionT getItemQuestConditionT = new IGetItemQuestConditionT();
			this.UnPackTo(getItemQuestConditionT);
			return getItemQuestConditionT;
		}

		// Token: 0x0601688D RID: 92301 RVA: 0x0034199C File Offset: 0x0033FB9C
		public void UnPackTo(IGetItemQuestConditionT _o)
		{
			_o.Type = this.Type;
			_o.PreConditions = ((this.PreConditions != null) ? this.PreConditions.Value.UnPack() : null);
			_o.Items = new List<IItemConfigT>();
			for (int i = 0; i < this.ItemsLength; i++)
			{
				_o.Items.Add((this.Items(i) != null) ? this.Items(i).Value.UnPack() : null);
			}
		}

		// Token: 0x0601688E RID: 92302 RVA: 0x00341A38 File Offset: 0x0033FC38
		public static Offset<IGetItemQuestCondition> Pack(FlatBufferBuilder builder, IGetItemQuestConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IGetItemQuestCondition>);
			}
			Offset<IConditionGroup> preConditionsOffset = (_o.PreConditions == null) ? default(Offset<IConditionGroup>) : IConditionGroup.Pack(builder, _o.PreConditions);
			VectorOffset itemsOffset = default(VectorOffset);
			if (_o.Items != null)
			{
				Offset<IItemConfig>[] array = new Offset<IItemConfig>[_o.Items.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IItemConfig.Pack(builder, _o.Items[i]);
				}
				itemsOffset = IGetItemQuestCondition.CreateItemsVector(builder, array);
			}
			return IGetItemQuestCondition.CreateIGetItemQuestCondition(builder, _o.Type, preConditionsOffset, itemsOffset);
		}

		// Token: 0x0400B82E RID: 47150
		private Table __p;
	}
}
