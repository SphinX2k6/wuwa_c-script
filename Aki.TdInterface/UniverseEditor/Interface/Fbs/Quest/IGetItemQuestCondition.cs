using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020042B3 RID: 17075
	public struct IGetItemQuestCondition : IFlatbufferObject
	{
		// Token: 0x170074CD RID: 29901
		// (get) Token: 0x06017EAE RID: 97966 RVA: 0x0036A469 File Offset: 0x00368669
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06017EAF RID: 97967 RVA: 0x0036A476 File Offset: 0x00368676
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06017EB0 RID: 97968 RVA: 0x0036A480 File Offset: 0x00368680
		public static IGetItemQuestCondition GetRootAsIGetItemQuestCondition(ByteBuffer _bb)
		{
			return IGetItemQuestCondition.GetRootAsIGetItemQuestCondition(_bb, default(IGetItemQuestCondition));
		}

		// Token: 0x06017EB1 RID: 97969 RVA: 0x0036A49C File Offset: 0x0036869C
		public static IGetItemQuestCondition GetRootAsIGetItemQuestCondition(ByteBuffer _bb, IGetItemQuestCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06017EB2 RID: 97970 RVA: 0x0036A4B9 File Offset: 0x003686B9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06017EB3 RID: 97971 RVA: 0x0036A4C8 File Offset: 0x003686C8
		public IGetItemQuestCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170074CE RID: 29902
		// (get) Token: 0x06017EB4 RID: 97972 RVA: 0x0036A4D8 File Offset: 0x003686D8
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

		// Token: 0x170074CF RID: 29903
		// (get) Token: 0x06017EB5 RID: 97973 RVA: 0x0036A514 File Offset: 0x00368714
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

		// Token: 0x06017EB6 RID: 97974 RVA: 0x0036A574 File Offset: 0x00368774
		public IItemConfig? Items(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new IItemConfig?(default(IItemConfig).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170074D0 RID: 29904
		// (get) Token: 0x06017EB7 RID: 97975 RVA: 0x0036A5D4 File Offset: 0x003687D4
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

		// Token: 0x06017EB8 RID: 97976 RVA: 0x0036A5FF File Offset: 0x003687FF
		public static Offset<IGetItemQuestCondition> CreateIGetItemQuestCondition(FlatBufferBuilder builder, EChildQuest Type = EChildQuest.DoInteract, Offset<IConditionGroup> PreConditionsOffset = default(Offset<IConditionGroup>), VectorOffset ItemsOffset = default(VectorOffset))
		{
			builder.StartTable(3);
			IGetItemQuestCondition.AddItems(builder, ItemsOffset);
			IGetItemQuestCondition.AddPreConditions(builder, PreConditionsOffset);
			IGetItemQuestCondition.AddType(builder, Type);
			return IGetItemQuestCondition.EndIGetItemQuestCondition(builder);
		}

		// Token: 0x06017EB9 RID: 97977 RVA: 0x0036A623 File Offset: 0x00368823
		public static void StartIGetItemQuestCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06017EBA RID: 97978 RVA: 0x0036A62C File Offset: 0x0036882C
		public static void AddType(FlatBufferBuilder builder, EChildQuest type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06017EBB RID: 97979 RVA: 0x0036A637 File Offset: 0x00368837
		public static void AddPreConditions(FlatBufferBuilder builder, Offset<IConditionGroup> preConditionsOffset)
		{
			builder.AddOffset(1, preConditionsOffset.Value, 0);
		}

		// Token: 0x06017EBC RID: 97980 RVA: 0x0036A647 File Offset: 0x00368847
		public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset)
		{
			builder.AddOffset(2, itemsOffset.Value, 0);
		}

		// Token: 0x06017EBD RID: 97981 RVA: 0x0036A658 File Offset: 0x00368858
		public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<IItemConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06017EBE RID: 97982 RVA: 0x0036A698 File Offset: 0x00368898
		public static VectorOffset CreateItemsVectorBlock(FlatBufferBuilder builder, Offset<IItemConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IItemConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x06017EBF RID: 97983 RVA: 0x0036A6B2 File Offset: 0x003688B2
		public static VectorOffset CreateItemsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IItemConfig>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IItemConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x06017EC0 RID: 97984 RVA: 0x0036A6D0 File Offset: 0x003688D0
		public static VectorOffset CreateItemsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IItemConfig>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06017EC1 RID: 97985 RVA: 0x0036A6E9 File Offset: 0x003688E9
		public static void StartItemsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06017EC2 RID: 97986 RVA: 0x0036A6F4 File Offset: 0x003688F4
		public static Offset<IGetItemQuestCondition> EndIGetItemQuestCondition(FlatBufferBuilder builder)
		{
			return new Offset<IGetItemQuestCondition>(builder.EndTable());
		}

		// Token: 0x06017EC3 RID: 97987 RVA: 0x0036A704 File Offset: 0x00368904
		public IGetItemQuestConditionT UnPack()
		{
			IGetItemQuestConditionT getItemQuestConditionT = new IGetItemQuestConditionT();
			this.UnPackTo(getItemQuestConditionT);
			return getItemQuestConditionT;
		}

		// Token: 0x06017EC4 RID: 97988 RVA: 0x0036A720 File Offset: 0x00368920
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

		// Token: 0x06017EC5 RID: 97989 RVA: 0x0036A7BC File Offset: 0x003689BC
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

		// Token: 0x0400C207 RID: 49671
		private Table __p;
	}
}
