using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020042CE RID: 17102
	public struct IHandInItemsCondition : IFlatbufferObject
	{
		// Token: 0x17007516 RID: 29974
		// (get) Token: 0x06017FE1 RID: 98273 RVA: 0x0036CC31 File Offset: 0x0036AE31
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06017FE2 RID: 98274 RVA: 0x0036CC3E File Offset: 0x0036AE3E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06017FE3 RID: 98275 RVA: 0x0036CC48 File Offset: 0x0036AE48
		public static IHandInItemsCondition GetRootAsIHandInItemsCondition(ByteBuffer _bb)
		{
			return IHandInItemsCondition.GetRootAsIHandInItemsCondition(_bb, default(IHandInItemsCondition));
		}

		// Token: 0x06017FE4 RID: 98276 RVA: 0x0036CC64 File Offset: 0x0036AE64
		public static IHandInItemsCondition GetRootAsIHandInItemsCondition(ByteBuffer _bb, IHandInItemsCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06017FE5 RID: 98277 RVA: 0x0036CC81 File Offset: 0x0036AE81
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06017FE6 RID: 98278 RVA: 0x0036CC90 File Offset: 0x0036AE90
		public IHandInItemsCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007517 RID: 29975
		// (get) Token: 0x06017FE7 RID: 98279 RVA: 0x0036CCA0 File Offset: 0x0036AEA0
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

		// Token: 0x17007518 RID: 29976
		// (get) Token: 0x06017FE8 RID: 98280 RVA: 0x0036CCDC File Offset: 0x0036AEDC
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

		// Token: 0x17007519 RID: 29977
		// (get) Token: 0x06017FE9 RID: 98281 RVA: 0x0036CD3C File Offset: 0x0036AF3C
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

		// Token: 0x06017FEA RID: 98282 RVA: 0x0036CD9C File Offset: 0x0036AF9C
		public TItemVariable ItemVarsType(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return TItemVariable.NONE;
			}
			return (TItemVariable)this.__p.bb.Get(this.__p.__vector(num) + j);
		}

		// Token: 0x1700751A RID: 29978
		// (get) Token: 0x06017FEB RID: 98283 RVA: 0x0036CDDC File Offset: 0x0036AFDC
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

		// Token: 0x06017FEC RID: 98284 RVA: 0x0036CE08 File Offset: 0x0036B008
		public Span<TItemVariable> GetItemVarsTypeBytes()
		{
			return this.__p.__vector_as_span<TItemVariable>(10, 1);
		}

		// Token: 0x06017FED RID: 98285 RVA: 0x0036CE18 File Offset: 0x0036B018
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

		// Token: 0x06017FEE RID: 98286 RVA: 0x0036CE84 File Offset: 0x0036B084
		public TTable? ItemVars<TTable>(int j) where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(this.__p.__vector(num) + j * 4));
		}

		// Token: 0x1700751B RID: 29979
		// (get) Token: 0x06017FEF RID: 98287 RVA: 0x0036CECC File Offset: 0x0036B0CC
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

		// Token: 0x1700751C RID: 29980
		// (get) Token: 0x06017FF0 RID: 98288 RVA: 0x0036CEF8 File Offset: 0x0036B0F8
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

		// Token: 0x1700751D RID: 29981
		// (get) Token: 0x06017FF1 RID: 98289 RVA: 0x0036CF58 File Offset: 0x0036B158
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

		// Token: 0x06017FF2 RID: 98290 RVA: 0x0036CF98 File Offset: 0x0036B198
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

		// Token: 0x06017FF3 RID: 98291 RVA: 0x0036CFE7 File Offset: 0x0036B1E7
		public static void StartIHandInItemsCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(7);
		}

		// Token: 0x06017FF4 RID: 98292 RVA: 0x0036CFF0 File Offset: 0x0036B1F0
		public static void AddType(FlatBufferBuilder builder, EChildQuest type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06017FF5 RID: 98293 RVA: 0x0036CFFB File Offset: 0x0036B1FB
		public static void AddPreConditions(FlatBufferBuilder builder, Offset<IConditionGroup> preConditionsOffset)
		{
			builder.AddOffset(1, preConditionsOffset.Value, 0);
		}

		// Token: 0x06017FF6 RID: 98294 RVA: 0x0036D00B File Offset: 0x0036B20B
		public static void AddHandInItems(FlatBufferBuilder builder, Offset<IHandInItems> handInItemsOffset)
		{
			builder.AddOffset(2, handInItemsOffset.Value, 0);
		}

		// Token: 0x06017FF7 RID: 98295 RVA: 0x0036D01B File Offset: 0x0036B21B
		public static void AddItemVarsType(FlatBufferBuilder builder, VectorOffset itemVarsTypeOffset)
		{
			builder.AddOffset(3, itemVarsTypeOffset.Value, 0);
		}

		// Token: 0x06017FF8 RID: 98296 RVA: 0x0036D02C File Offset: 0x0036B22C
		public static VectorOffset CreateItemVarsTypeVector(FlatBufferBuilder builder, TItemVariable[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddByte((byte)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06017FF9 RID: 98297 RVA: 0x0036D063 File Offset: 0x0036B263
		public static VectorOffset CreateItemVarsTypeVectorBlock(FlatBufferBuilder builder, TItemVariable[] data)
		{
			builder.StartVector(1, data.Length, 1);
			builder.Add<TItemVariable>(data);
			return builder.EndVector();
		}

		// Token: 0x06017FFA RID: 98298 RVA: 0x0036D07D File Offset: 0x0036B27D
		public static VectorOffset CreateItemVarsTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<TItemVariable> data)
		{
			builder.StartVector(1, data.Count, 1);
			builder.Add<TItemVariable>(data);
			return builder.EndVector();
		}

		// Token: 0x06017FFB RID: 98299 RVA: 0x0036D09B File Offset: 0x0036B29B
		public static VectorOffset CreateItemVarsTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<TItemVariable>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06017FFC RID: 98300 RVA: 0x0036D0B4 File Offset: 0x0036B2B4
		public static void StartItemVarsTypeVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x06017FFD RID: 98301 RVA: 0x0036D0BF File Offset: 0x0036B2BF
		public static void AddItemVars(FlatBufferBuilder builder, VectorOffset itemVarsOffset)
		{
			builder.AddOffset(4, itemVarsOffset.Value, 0);
		}

		// Token: 0x06017FFE RID: 98302 RVA: 0x0036D0D0 File Offset: 0x0036B2D0
		public static VectorOffset CreateItemVarsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06017FFF RID: 98303 RVA: 0x0036D107 File Offset: 0x0036B307
		public static VectorOffset CreateItemVarsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06018000 RID: 98304 RVA: 0x0036D121 File Offset: 0x0036B321
		public static VectorOffset CreateItemVarsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06018001 RID: 98305 RVA: 0x0036D13F File Offset: 0x0036B33F
		public static VectorOffset CreateItemVarsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06018002 RID: 98306 RVA: 0x0036D158 File Offset: 0x0036B358
		public static void StartItemVarsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06018003 RID: 98307 RVA: 0x0036D163 File Offset: 0x0036B363
		public static void AddAddOption(FlatBufferBuilder builder, Offset<IAddInteractOption> addOptionOffset)
		{
			builder.AddOffset(5, addOptionOffset.Value, 0);
		}

		// Token: 0x06018004 RID: 98308 RVA: 0x0036D173 File Offset: 0x0036B373
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(6, nullMask, 0);
		}

		// Token: 0x06018005 RID: 98309 RVA: 0x0036D17E File Offset: 0x0036B37E
		public static Offset<IHandInItemsCondition> EndIHandInItemsCondition(FlatBufferBuilder builder)
		{
			return new Offset<IHandInItemsCondition>(builder.EndTable());
		}

		// Token: 0x06018006 RID: 98310 RVA: 0x0036D18C File Offset: 0x0036B38C
		public IHandInItemsConditionT UnPack()
		{
			IHandInItemsConditionT handInItemsConditionT = new IHandInItemsConditionT();
			this.UnPackTo(handInItemsConditionT);
			return handInItemsConditionT;
		}

		// Token: 0x06018007 RID: 98311 RVA: 0x0036D1A8 File Offset: 0x0036B3A8
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

		// Token: 0x06018008 RID: 98312 RVA: 0x0036D32C File Offset: 0x0036B52C
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

		// Token: 0x0400C230 RID: 49712
		private Table __p;
	}
}
