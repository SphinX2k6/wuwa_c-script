using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003E93 RID: 16019
	public struct IHandInItemsCondition : IFlatbufferObject
	{
		// Token: 0x17006F2E RID: 28462
		// (get) Token: 0x060169AA RID: 92586 RVA: 0x00343EAD File Offset: 0x003420AD
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060169AB RID: 92587 RVA: 0x00343EBA File Offset: 0x003420BA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060169AC RID: 92588 RVA: 0x00343EC4 File Offset: 0x003420C4
		public static IHandInItemsCondition GetRootAsIHandInItemsCondition(ByteBuffer _bb)
		{
			return IHandInItemsCondition.GetRootAsIHandInItemsCondition(_bb, default(IHandInItemsCondition));
		}

		// Token: 0x060169AD RID: 92589 RVA: 0x00343EE0 File Offset: 0x003420E0
		public static IHandInItemsCondition GetRootAsIHandInItemsCondition(ByteBuffer _bb, IHandInItemsCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060169AE RID: 92590 RVA: 0x00343EFD File Offset: 0x003420FD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060169AF RID: 92591 RVA: 0x00343F0C File Offset: 0x0034210C
		public IHandInItemsCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006F2F RID: 28463
		// (get) Token: 0x060169B0 RID: 92592 RVA: 0x00343F1C File Offset: 0x0034211C
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

		// Token: 0x17006F30 RID: 28464
		// (get) Token: 0x060169B1 RID: 92593 RVA: 0x00343F58 File Offset: 0x00342158
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

		// Token: 0x17006F31 RID: 28465
		// (get) Token: 0x060169B2 RID: 92594 RVA: 0x00343FB8 File Offset: 0x003421B8
		public IHandInItems? HandInItems
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return new IHandInItems?(default(IHandInItems).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x060169B3 RID: 92595 RVA: 0x00344018 File Offset: 0x00342218
		public TItemVariable ItemVarsType(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return TItemVariable.NONE;
			}
			return (TItemVariable)this.__p.bb.Get(this.__p.__vector(num) + j);
		}

		// Token: 0x17006F32 RID: 28466
		// (get) Token: 0x060169B4 RID: 92596 RVA: 0x00344058 File Offset: 0x00342258
		public int ItemVarsTypeLength
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x060169B5 RID: 92597 RVA: 0x00344084 File Offset: 0x00342284
		public Span<TItemVariable> GetItemVarsTypeBytes()
		{
			return this.__p.__vector_as_span<TItemVariable>(10, 1);
		}

		// Token: 0x060169B6 RID: 92598 RVA: 0x00344094 File Offset: 0x00342294
		public TItemVariable[] GetItemVarsTypeArray()
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			int num2 = this.__p.__vector(num);
			int num3 = this.__p.__vector_len(num);
			TItemVariable[] array = new TItemVariable[num3];
			for (int i = 0; i < num3; i++)
			{
				array[i] = (TItemVariable)this.__p.bb.Get(num2 + i);
			}
			return array;
		}

		// Token: 0x060169B7 RID: 92599 RVA: 0x00344100 File Offset: 0x00342300
		public TTable? ItemVars<TTable>(int j) where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(this.__p.__vector(num) + j * 4));
		}

		// Token: 0x17006F33 RID: 28467
		// (get) Token: 0x060169B8 RID: 92600 RVA: 0x00344148 File Offset: 0x00342348
		public int ItemVarsLength
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x17006F34 RID: 28468
		// (get) Token: 0x060169B9 RID: 92601 RVA: 0x00344174 File Offset: 0x00342374
		public IAddInteractOption? AddOption
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return null;
				}
				return new IAddInteractOption?(default(IAddInteractOption).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17006F35 RID: 28469
		// (get) Token: 0x060169BA RID: 92602 RVA: 0x003441D4 File Offset: 0x003423D4
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060169BB RID: 92603 RVA: 0x00344214 File Offset: 0x00342414
		public static Offset<IHandInItemsCondition> CreateIHandInItemsCondition(FlatBufferBuilder builder, EChildQuest Type = EChildQuest.DoInteract, Offset<IConditionGroup> PreConditionsOffset = default(Offset<IConditionGroup>), Offset<IHandInItems> HandInItemsOffset = default(Offset<IHandInItems>), VectorOffset ItemVars_typeOffset = default(VectorOffset), VectorOffset ItemVarsOffset = default(VectorOffset), Offset<IAddInteractOption> AddOptionOffset = default(Offset<IAddInteractOption>), byte NullMask = 0)
		{
			builder.StartTable(7);
			IHandInItemsCondition.AddAddOption(builder, AddOptionOffset);
			IHandInItemsCondition.AddItemVars(builder, ItemVarsOffset);
			IHandInItemsCondition.AddItemVarsType(builder, ItemVars_typeOffset);
			IHandInItemsCondition.AddHandInItems(builder, HandInItemsOffset);
			IHandInItemsCondition.AddPreConditions(builder, PreConditionsOffset);
			IHandInItemsCondition.AddNullMask(builder, NullMask);
			IHandInItemsCondition.AddType(builder, Type);
			return IHandInItemsCondition.EndIHandInItemsCondition(builder);
		}

		// Token: 0x060169BC RID: 92604 RVA: 0x00344263 File Offset: 0x00342463
		public static void StartIHandInItemsCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(7);
		}

		// Token: 0x060169BD RID: 92605 RVA: 0x0034426C File Offset: 0x0034246C
		public static void AddType(FlatBufferBuilder builder, EChildQuest type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060169BE RID: 92606 RVA: 0x00344277 File Offset: 0x00342477
		public static void AddPreConditions(FlatBufferBuilder builder, Offset<IConditionGroup> preConditionsOffset)
		{
			builder.AddOffset(1, preConditionsOffset.Value, 0);
		}

		// Token: 0x060169BF RID: 92607 RVA: 0x00344287 File Offset: 0x00342487
		public static void AddHandInItems(FlatBufferBuilder builder, Offset<IHandInItems> handInItemsOffset)
		{
			builder.AddOffset(2, handInItemsOffset.Value, 0);
		}

		// Token: 0x060169C0 RID: 92608 RVA: 0x00344297 File Offset: 0x00342497
		public static void AddItemVarsType(FlatBufferBuilder builder, VectorOffset itemVarsTypeOffset)
		{
			builder.AddOffset(3, itemVarsTypeOffset.Value, 0);
		}

		// Token: 0x060169C1 RID: 92609 RVA: 0x003442A8 File Offset: 0x003424A8
		public static VectorOffset CreateItemVarsTypeVector(FlatBufferBuilder builder, TItemVariable[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddByte((byte)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x060169C2 RID: 92610 RVA: 0x003442DF File Offset: 0x003424DF
		public static VectorOffset CreateItemVarsTypeVectorBlock(FlatBufferBuilder builder, TItemVariable[] data)
		{
			builder.StartVector(1, data.Length, 1);
			builder.Add<TItemVariable>(data);
			return builder.EndVector();
		}

		// Token: 0x060169C3 RID: 92611 RVA: 0x003442F9 File Offset: 0x003424F9
		public static VectorOffset CreateItemVarsTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<TItemVariable> data)
		{
			builder.StartVector(1, data.Count, 1);
			builder.Add<TItemVariable>(data);
			return builder.EndVector();
		}

		// Token: 0x060169C4 RID: 92612 RVA: 0x00344317 File Offset: 0x00342517
		public static VectorOffset CreateItemVarsTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<TItemVariable>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060169C5 RID: 92613 RVA: 0x00344330 File Offset: 0x00342530
		public static void StartItemVarsTypeVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x060169C6 RID: 92614 RVA: 0x0034433B File Offset: 0x0034253B
		public static void AddItemVars(FlatBufferBuilder builder, VectorOffset itemVarsOffset)
		{
			builder.AddOffset(4, itemVarsOffset.Value, 0);
		}

		// Token: 0x060169C7 RID: 92615 RVA: 0x0034434C File Offset: 0x0034254C
		public static VectorOffset CreateItemVarsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x060169C8 RID: 92616 RVA: 0x00344383 File Offset: 0x00342583
		public static VectorOffset CreateItemVarsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x060169C9 RID: 92617 RVA: 0x0034439D File Offset: 0x0034259D
		public static VectorOffset CreateItemVarsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x060169CA RID: 92618 RVA: 0x003443BB File Offset: 0x003425BB
		public static VectorOffset CreateItemVarsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060169CB RID: 92619 RVA: 0x003443D4 File Offset: 0x003425D4
		public static void StartItemVarsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060169CC RID: 92620 RVA: 0x003443DF File Offset: 0x003425DF
		public static void AddAddOption(FlatBufferBuilder builder, Offset<IAddInteractOption> addOptionOffset)
		{
			builder.AddOffset(5, addOptionOffset.Value, 0);
		}

		// Token: 0x060169CD RID: 92621 RVA: 0x003443EF File Offset: 0x003425EF
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(6, nullMask, 0);
		}

		// Token: 0x060169CE RID: 92622 RVA: 0x003443FA File Offset: 0x003425FA
		public static Offset<IHandInItemsCondition> EndIHandInItemsCondition(FlatBufferBuilder builder)
		{
			return new Offset<IHandInItemsCondition>(builder.EndTable());
		}

		// Token: 0x060169CF RID: 92623 RVA: 0x00344408 File Offset: 0x00342608
		public IHandInItemsConditionT UnPack()
		{
			IHandInItemsConditionT handInItemsConditionT = new IHandInItemsConditionT();
			this.UnPackTo(handInItemsConditionT);
			return handInItemsConditionT;
		}

		// Token: 0x060169D0 RID: 92624 RVA: 0x00344424 File Offset: 0x00342624
		public void UnPackTo(IHandInItemsConditionT _o)
		{
			_o.Type = this.Type;
			_o.PreConditions = ((this.PreConditions != null) ? this.PreConditions.Value.UnPack() : null);
			_o.HandInItems = ((this.HandInItems != null) ? this.HandInItems.Value.UnPack() : null);
			_o.ItemVars = new List<TItemVariableUnion>();
			for (int i = 0; i < this.ItemVarsLength; i++)
			{
				TItemVariableUnion titemVariableUnion = new TItemVariableUnion();
				titemVariableUnion.Type = this.ItemVarsType(i);
				TItemVariable titemVariable = this.ItemVarsType(i);
				if (titemVariable != TItemVariable.IItemIdVariable)
				{
					if (titemVariable == TItemVariable.IItemTypeVariable)
					{
						titemVariableUnion.Value = ((this.ItemVars<IItemTypeVariable>(i) != null) ? this.ItemVars<IItemTypeVariable>(i).Value.UnPack() : null);
					}
				}
				else
				{
					titemVariableUnion.Value = ((this.ItemVars<IItemIdVariable>(i) != null) ? this.ItemVars<IItemIdVariable>(i).Value.UnPack() : null);
				}
				_o.ItemVars.Add(titemVariableUnion);
			}
			_o.AddOption = ((this.AddOption != null) ? this.AddOption.Value.UnPack() : null);
			_o.NullMask = this.NullMask;
		}

		// Token: 0x060169D1 RID: 92625 RVA: 0x003445A8 File Offset: 0x003427A8
		public static Offset<IHandInItemsCondition> Pack(FlatBufferBuilder builder, IHandInItemsConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IHandInItemsCondition>);
			}
			Offset<IConditionGroup> preConditionsOffset = (_o.PreConditions == null) ? default(Offset<IConditionGroup>) : IConditionGroup.Pack(builder, _o.PreConditions);
			Offset<IHandInItems> handInItemsOffset = (_o.HandInItems == null) ? default(Offset<IHandInItems>) : IHandInItems.Pack(builder, _o.HandInItems);
			VectorOffset itemVars_typeOffset = default(VectorOffset);
			if (_o.ItemVars != null)
			{
				TItemVariable[] array = new TItemVariable[_o.ItemVars.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = _o.ItemVars[i].Type;
				}
				itemVars_typeOffset = IHandInItemsCondition.CreateItemVarsTypeVector(builder, array);
			}
			VectorOffset itemVarsOffset = default(VectorOffset);
			if (_o.ItemVars != null)
			{
				int[] array2 = new int[_o.ItemVars.Count];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = TItemVariableUnion.Pack(builder, _o.ItemVars[j]);
				}
				itemVarsOffset = IHandInItemsCondition.CreateItemVarsVector(builder, array2);
			}
			Offset<IAddInteractOption> addOptionOffset = (_o.AddOption == null) ? default(Offset<IAddInteractOption>) : IAddInteractOption.Pack(builder, _o.AddOption);
			return IHandInItemsCondition.CreateIHandInItemsCondition(builder, _o.Type, preConditionsOffset, handInItemsOffset, itemVars_typeOffset, itemVarsOffset, addOptionOffset, _o.NullMask);
		}

		// Token: 0x0400B857 RID: 47191
		private Table __p;
	}
}
