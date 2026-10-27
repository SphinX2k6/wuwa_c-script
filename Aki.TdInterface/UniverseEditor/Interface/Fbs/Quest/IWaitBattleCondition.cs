using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004280 RID: 17024
	public struct IWaitBattleCondition : IFlatbufferObject
	{
		// Token: 0x170078D2 RID: 30930
		// (get) Token: 0x06019332 RID: 103218 RVA: 0x0039ECC6 File Offset: 0x0039CEC6
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06019333 RID: 103219 RVA: 0x0039ECD3 File Offset: 0x0039CED3
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06019334 RID: 103220 RVA: 0x0039ECDC File Offset: 0x0039CEDC
		public static IWaitBattleCondition GetRootAsIWaitBattleCondition(ByteBuffer _bb)
		{
			return IWaitBattleCondition.GetRootAsIWaitBattleCondition(_bb, default(IWaitBattleCondition));
		}

		// Token: 0x06019335 RID: 103221 RVA: 0x0039ECF8 File Offset: 0x0039CEF8
		public static IWaitBattleCondition GetRootAsIWaitBattleCondition(ByteBuffer _bb, IWaitBattleCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06019336 RID: 103222 RVA: 0x0039ED15 File Offset: 0x0039CF15
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06019337 RID: 103223 RVA: 0x0039ED24 File Offset: 0x0039CF24
		public IWaitBattleCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170078D3 RID: 30931
		// (get) Token: 0x06019338 RID: 103224 RVA: 0x0039ED34 File Offset: 0x0039CF34
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

		// Token: 0x170078D4 RID: 30932
		// (get) Token: 0x06019339 RID: 103225 RVA: 0x0039ED70 File Offset: 0x0039CF70
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

		// Token: 0x170078D5 RID: 30933
		// (get) Token: 0x0601933A RID: 103226 RVA: 0x0039EDD0 File Offset: 0x0039CFD0
		public EConditionCount Count
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return EConditionCount.All;
				}
				return (EConditionCount)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601933B RID: 103227 RVA: 0x0039EE0C File Offset: 0x0039D00C
		public TBattleCondition OptionType(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return TBattleCondition.NONE;
			}
			return (TBattleCondition)this.__p.bb.Get(this.__p.__vector(num) + j);
		}

		// Token: 0x170078D6 RID: 30934
		// (get) Token: 0x0601933C RID: 103228 RVA: 0x0039EE4C File Offset: 0x0039D04C
		public int OptionTypeLength
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

		// Token: 0x0601933D RID: 103229 RVA: 0x0039EE78 File Offset: 0x0039D078
		public Span<TBattleCondition> GetOptionTypeBytes()
		{
			return this.__p.__vector_as_span<TBattleCondition>(10, 1);
		}

		// Token: 0x0601933E RID: 103230 RVA: 0x0039EE88 File Offset: 0x0039D088
		public TBattleCondition[] GetOptionTypeArray()
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			int num2 = this.__p.__vector(num);
			int num3 = this.__p.__vector_len(num);
			TBattleCondition[] array = new TBattleCondition[num3];
			for (int i = 0; i < num3; i++)
			{
				array[i] = (TBattleCondition)this.__p.bb.Get(num2 + i);
			}
			return array;
		}

		// Token: 0x0601933F RID: 103231 RVA: 0x0039EEF4 File Offset: 0x0039D0F4
		public TTable? Option<TTable>(int j) where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(this.__p.__vector(num) + j * 4));
		}

		// Token: 0x170078D7 RID: 30935
		// (get) Token: 0x06019340 RID: 103232 RVA: 0x0039EF3C File Offset: 0x0039D13C
		public int OptionLength
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

		// Token: 0x06019341 RID: 103233 RVA: 0x0039EF68 File Offset: 0x0039D168
		public static Offset<IWaitBattleCondition> CreateIWaitBattleCondition(FlatBufferBuilder builder, EChildQuest Type = EChildQuest.DoInteract, Offset<IConditionGroup> PreConditionsOffset = default(Offset<IConditionGroup>), EConditionCount Count = EConditionCount.All, VectorOffset Option_typeOffset = default(VectorOffset), VectorOffset OptionOffset = default(VectorOffset))
		{
			builder.StartTable(5);
			IWaitBattleCondition.AddOption(builder, OptionOffset);
			IWaitBattleCondition.AddOptionType(builder, Option_typeOffset);
			IWaitBattleCondition.AddPreConditions(builder, PreConditionsOffset);
			IWaitBattleCondition.AddCount(builder, Count);
			IWaitBattleCondition.AddType(builder, Type);
			return IWaitBattleCondition.EndIWaitBattleCondition(builder);
		}

		// Token: 0x06019342 RID: 103234 RVA: 0x0039EF9C File Offset: 0x0039D19C
		public static void StartIWaitBattleCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x06019343 RID: 103235 RVA: 0x0039EFA5 File Offset: 0x0039D1A5
		public static void AddType(FlatBufferBuilder builder, EChildQuest type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06019344 RID: 103236 RVA: 0x0039EFB0 File Offset: 0x0039D1B0
		public static void AddPreConditions(FlatBufferBuilder builder, Offset<IConditionGroup> preConditionsOffset)
		{
			builder.AddOffset(1, preConditionsOffset.Value, 0);
		}

		// Token: 0x06019345 RID: 103237 RVA: 0x0039EFC0 File Offset: 0x0039D1C0
		public static void AddCount(FlatBufferBuilder builder, EConditionCount count)
		{
			builder.AddByte(2, (byte)count, 0);
		}

		// Token: 0x06019346 RID: 103238 RVA: 0x0039EFCB File Offset: 0x0039D1CB
		public static void AddOptionType(FlatBufferBuilder builder, VectorOffset optionTypeOffset)
		{
			builder.AddOffset(3, optionTypeOffset.Value, 0);
		}

		// Token: 0x06019347 RID: 103239 RVA: 0x0039EFDC File Offset: 0x0039D1DC
		public static VectorOffset CreateOptionTypeVector(FlatBufferBuilder builder, TBattleCondition[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddByte((byte)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06019348 RID: 103240 RVA: 0x0039F013 File Offset: 0x0039D213
		public static VectorOffset CreateOptionTypeVectorBlock(FlatBufferBuilder builder, TBattleCondition[] data)
		{
			builder.StartVector(1, data.Length, 1);
			builder.Add<TBattleCondition>(data);
			return builder.EndVector();
		}

		// Token: 0x06019349 RID: 103241 RVA: 0x0039F02D File Offset: 0x0039D22D
		public static VectorOffset CreateOptionTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<TBattleCondition> data)
		{
			builder.StartVector(1, data.Count, 1);
			builder.Add<TBattleCondition>(data);
			return builder.EndVector();
		}

		// Token: 0x0601934A RID: 103242 RVA: 0x0039F04B File Offset: 0x0039D24B
		public static VectorOffset CreateOptionTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<TBattleCondition>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601934B RID: 103243 RVA: 0x0039F064 File Offset: 0x0039D264
		public static void StartOptionTypeVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x0601934C RID: 103244 RVA: 0x0039F06F File Offset: 0x0039D26F
		public static void AddOption(FlatBufferBuilder builder, VectorOffset optionOffset)
		{
			builder.AddOffset(4, optionOffset.Value, 0);
		}

		// Token: 0x0601934D RID: 103245 RVA: 0x0039F080 File Offset: 0x0039D280
		public static VectorOffset CreateOptionVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0601934E RID: 103246 RVA: 0x0039F0B7 File Offset: 0x0039D2B7
		public static VectorOffset CreateOptionVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601934F RID: 103247 RVA: 0x0039F0D1 File Offset: 0x0039D2D1
		public static VectorOffset CreateOptionVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06019350 RID: 103248 RVA: 0x0039F0EF File Offset: 0x0039D2EF
		public static VectorOffset CreateOptionVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06019351 RID: 103249 RVA: 0x0039F108 File Offset: 0x0039D308
		public static void StartOptionVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06019352 RID: 103250 RVA: 0x0039F113 File Offset: 0x0039D313
		public static Offset<IWaitBattleCondition> EndIWaitBattleCondition(FlatBufferBuilder builder)
		{
			return new Offset<IWaitBattleCondition>(builder.EndTable());
		}

		// Token: 0x06019353 RID: 103251 RVA: 0x0039F120 File Offset: 0x0039D320
		public IWaitBattleConditionT UnPack()
		{
			IWaitBattleConditionT waitBattleConditionT = new IWaitBattleConditionT();
			this.UnPackTo(waitBattleConditionT);
			return waitBattleConditionT;
		}

		// Token: 0x06019354 RID: 103252 RVA: 0x0039F13C File Offset: 0x0039D33C
		public void UnPackTo(IWaitBattleConditionT _o)
		{
			_o.Type = this.Type;
			_o.PreConditions = ((this.PreConditions != null) ? this.PreConditions.Value.UnPack() : null);
			_o.Count = this.Count;
			_o.Option = new List<TBattleConditionUnion>();
			for (int i = 0; i < this.OptionLength; i++)
			{
				TBattleConditionUnion tbattleConditionUnion = new TBattleConditionUnion();
				tbattleConditionUnion.Type = this.OptionType(i);
				switch (this.OptionType(i))
				{
				case TBattleCondition.IBattleTagCondition:
					tbattleConditionUnion.Value = ((this.Option<IBattleTagCondition>(i) != null) ? this.Option<IBattleTagCondition>(i).Value.UnPack() : null);
					break;
				case TBattleCondition.ICounterAttackCondition:
					tbattleConditionUnion.Value = ((this.Option<ICounterAttackCondition>(i) != null) ? this.Option<ICounterAttackCondition>(i).Value.UnPack() : null);
					break;
				case TBattleCondition.IPerfectDodgeCondition:
					tbattleConditionUnion.Value = ((this.Option<IPerfectDodgeCondition>(i) != null) ? this.Option<IPerfectDodgeCondition>(i).Value.UnPack() : null);
					break;
				}
				_o.Option.Add(tbattleConditionUnion);
			}
		}

		// Token: 0x06019355 RID: 103253 RVA: 0x0039F294 File Offset: 0x0039D494
		public static Offset<IWaitBattleCondition> Pack(FlatBufferBuilder builder, IWaitBattleConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IWaitBattleCondition>);
			}
			Offset<IConditionGroup> preConditionsOffset = (_o.PreConditions == null) ? default(Offset<IConditionGroup>) : IConditionGroup.Pack(builder, _o.PreConditions);
			VectorOffset option_typeOffset = default(VectorOffset);
			if (_o.Option != null)
			{
				TBattleCondition[] array = new TBattleCondition[_o.Option.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = _o.Option[i].Type;
				}
				option_typeOffset = IWaitBattleCondition.CreateOptionTypeVector(builder, array);
			}
			VectorOffset optionOffset = default(VectorOffset);
			if (_o.Option != null)
			{
				int[] array2 = new int[_o.Option.Count];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = TBattleConditionUnion.Pack(builder, _o.Option[j]);
				}
				optionOffset = IWaitBattleCondition.CreateOptionVector(builder, array2);
			}
			return IWaitBattleCondition.CreateIWaitBattleCondition(builder, _o.Type, preConditionsOffset, _o.Count, option_typeOffset, optionOffset);
		}

		// Token: 0x0400BF16 RID: 48918
		private Table __p;
	}
}
