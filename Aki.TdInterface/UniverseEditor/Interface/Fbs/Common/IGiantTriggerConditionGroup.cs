using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005DE2 RID: 24034
	public struct IGiantTriggerConditionGroup : IFlatbufferObject
	{
		// Token: 0x1700B3E5 RID: 46053
		// (get) Token: 0x0602922C RID: 168492 RVA: 0x005A5284 File Offset: 0x005A3484
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602922D RID: 168493 RVA: 0x005A5291 File Offset: 0x005A3491
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602922E RID: 168494 RVA: 0x005A5298 File Offset: 0x005A3498
		public static IGiantTriggerConditionGroup GetRootAsIGiantTriggerConditionGroup(ByteBuffer _bb)
		{
			return IGiantTriggerConditionGroup.GetRootAsIGiantTriggerConditionGroup(_bb, default(IGiantTriggerConditionGroup));
		}

		// Token: 0x0602922F RID: 168495 RVA: 0x005A52B4 File Offset: 0x005A34B4
		public static IGiantTriggerConditionGroup GetRootAsIGiantTriggerConditionGroup(ByteBuffer _bb, IGiantTriggerConditionGroup obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06029230 RID: 168496 RVA: 0x005A52D1 File Offset: 0x005A34D1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06029231 RID: 168497 RVA: 0x005A52E0 File Offset: 0x005A34E0
		public IGiantTriggerConditionGroup __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B3E6 RID: 46054
		// (get) Token: 0x06029232 RID: 168498 RVA: 0x005A52F0 File Offset: 0x005A34F0
		public EGiantConditionCount Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EGiantConditionCount.All;
				}
				return (EGiantConditionCount)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06029233 RID: 168499 RVA: 0x005A532C File Offset: 0x005A352C
		public TGiantTriggerCondition ConditionsType(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return TGiantTriggerCondition.NONE;
			}
			return (TGiantTriggerCondition)this.__p.bb.Get(this.__p.__vector(num) + j);
		}

		// Token: 0x1700B3E7 RID: 46055
		// (get) Token: 0x06029234 RID: 168500 RVA: 0x005A536C File Offset: 0x005A356C
		public int ConditionsTypeLength
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06029235 RID: 168501 RVA: 0x005A5397 File Offset: 0x005A3597
		public Span<TGiantTriggerCondition> GetConditionsTypeBytes()
		{
			return this.__p.__vector_as_span<TGiantTriggerCondition>(6, 1);
		}

		// Token: 0x06029236 RID: 168502 RVA: 0x005A53A8 File Offset: 0x005A35A8
		public TGiantTriggerCondition[] GetConditionsTypeArray()
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			int num2 = this.__p.__vector(num);
			int num3 = this.__p.__vector_len(num);
			TGiantTriggerCondition[] array = new TGiantTriggerCondition[num3];
			for (int i = 0; i < num3; i++)
			{
				array[i] = (TGiantTriggerCondition)this.__p.bb.Get(num2 + i);
			}
			return array;
		}

		// Token: 0x06029237 RID: 168503 RVA: 0x005A5414 File Offset: 0x005A3614
		public TTable? Conditions<TTable>(int j) where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(this.__p.__vector(num) + j * 4));
		}

		// Token: 0x1700B3E8 RID: 46056
		// (get) Token: 0x06029238 RID: 168504 RVA: 0x005A545C File Offset: 0x005A365C
		public int ConditionsLength
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

		// Token: 0x06029239 RID: 168505 RVA: 0x005A5487 File Offset: 0x005A3687
		public static Offset<IGiantTriggerConditionGroup> CreateIGiantTriggerConditionGroup(FlatBufferBuilder builder, EGiantConditionCount Type = EGiantConditionCount.All, VectorOffset Conditions_typeOffset = default(VectorOffset), VectorOffset ConditionsOffset = default(VectorOffset))
		{
			builder.StartTable(3);
			IGiantTriggerConditionGroup.AddConditions(builder, ConditionsOffset);
			IGiantTriggerConditionGroup.AddConditionsType(builder, Conditions_typeOffset);
			IGiantTriggerConditionGroup.AddType(builder, Type);
			return IGiantTriggerConditionGroup.EndIGiantTriggerConditionGroup(builder);
		}

		// Token: 0x0602923A RID: 168506 RVA: 0x005A54AB File Offset: 0x005A36AB
		public static void StartIGiantTriggerConditionGroup(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0602923B RID: 168507 RVA: 0x005A54B4 File Offset: 0x005A36B4
		public static void AddType(FlatBufferBuilder builder, EGiantConditionCount type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602923C RID: 168508 RVA: 0x005A54BF File Offset: 0x005A36BF
		public static void AddConditionsType(FlatBufferBuilder builder, VectorOffset conditionsTypeOffset)
		{
			builder.AddOffset(1, conditionsTypeOffset.Value, 0);
		}

		// Token: 0x0602923D RID: 168509 RVA: 0x005A54D0 File Offset: 0x005A36D0
		public static VectorOffset CreateConditionsTypeVector(FlatBufferBuilder builder, TGiantTriggerCondition[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddByte((byte)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0602923E RID: 168510 RVA: 0x005A5507 File Offset: 0x005A3707
		public static VectorOffset CreateConditionsTypeVectorBlock(FlatBufferBuilder builder, TGiantTriggerCondition[] data)
		{
			builder.StartVector(1, data.Length, 1);
			builder.Add<TGiantTriggerCondition>(data);
			return builder.EndVector();
		}

		// Token: 0x0602923F RID: 168511 RVA: 0x005A5521 File Offset: 0x005A3721
		public static VectorOffset CreateConditionsTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<TGiantTriggerCondition> data)
		{
			builder.StartVector(1, data.Count, 1);
			builder.Add<TGiantTriggerCondition>(data);
			return builder.EndVector();
		}

		// Token: 0x06029240 RID: 168512 RVA: 0x005A553F File Offset: 0x005A373F
		public static VectorOffset CreateConditionsTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<TGiantTriggerCondition>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06029241 RID: 168513 RVA: 0x005A5558 File Offset: 0x005A3758
		public static void StartConditionsTypeVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x06029242 RID: 168514 RVA: 0x005A5563 File Offset: 0x005A3763
		public static void AddConditions(FlatBufferBuilder builder, VectorOffset conditionsOffset)
		{
			builder.AddOffset(2, conditionsOffset.Value, 0);
		}

		// Token: 0x06029243 RID: 168515 RVA: 0x005A5574 File Offset: 0x005A3774
		public static VectorOffset CreateConditionsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06029244 RID: 168516 RVA: 0x005A55AB File Offset: 0x005A37AB
		public static VectorOffset CreateConditionsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06029245 RID: 168517 RVA: 0x005A55C5 File Offset: 0x005A37C5
		public static VectorOffset CreateConditionsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06029246 RID: 168518 RVA: 0x005A55E3 File Offset: 0x005A37E3
		public static VectorOffset CreateConditionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06029247 RID: 168519 RVA: 0x005A55FC File Offset: 0x005A37FC
		public static void StartConditionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06029248 RID: 168520 RVA: 0x005A5607 File Offset: 0x005A3807
		public static Offset<IGiantTriggerConditionGroup> EndIGiantTriggerConditionGroup(FlatBufferBuilder builder)
		{
			return new Offset<IGiantTriggerConditionGroup>(builder.EndTable());
		}

		// Token: 0x06029249 RID: 168521 RVA: 0x005A5614 File Offset: 0x005A3814
		public IGiantTriggerConditionGroupT UnPack()
		{
			IGiantTriggerConditionGroupT giantTriggerConditionGroupT = new IGiantTriggerConditionGroupT();
			this.UnPackTo(giantTriggerConditionGroupT);
			return giantTriggerConditionGroupT;
		}

		// Token: 0x0602924A RID: 168522 RVA: 0x005A5630 File Offset: 0x005A3830
		public void UnPackTo(IGiantTriggerConditionGroupT _o)
		{
			_o.Type = this.Type;
			_o.Conditions = new List<TGiantTriggerConditionUnion>();
			for (int i = 0; i < this.ConditionsLength; i++)
			{
				TGiantTriggerConditionUnion tgiantTriggerConditionUnion = new TGiantTriggerConditionUnion();
				tgiantTriggerConditionUnion.Type = this.ConditionsType(i);
				switch (this.ConditionsType(i))
				{
				case TGiantTriggerCondition.IGiantTriggerEnterArea:
					tgiantTriggerConditionUnion.Value = ((this.Conditions<IGiantTriggerEnterArea>(i) != null) ? this.Conditions<IGiantTriggerEnterArea>(i).Value.UnPack() : null);
					break;
				case TGiantTriggerCondition.IGiantTriggerRoleState:
					tgiantTriggerConditionUnion.Value = ((this.Conditions<IGiantTriggerRoleState>(i) != null) ? this.Conditions<IGiantTriggerRoleState>(i).Value.UnPack() : null);
					break;
				case TGiantTriggerCondition.IGiantTriggerStableValue:
					tgiantTriggerConditionUnion.Value = ((this.Conditions<IGiantTriggerStableValue>(i) != null) ? this.Conditions<IGiantTriggerStableValue>(i).Value.UnPack() : null);
					break;
				}
				_o.Conditions.Add(tgiantTriggerConditionUnion);
			}
		}

		// Token: 0x0602924B RID: 168523 RVA: 0x005A574C File Offset: 0x005A394C
		public static Offset<IGiantTriggerConditionGroup> Pack(FlatBufferBuilder builder, IGiantTriggerConditionGroupT _o)
		{
			if (_o == null)
			{
				return default(Offset<IGiantTriggerConditionGroup>);
			}
			VectorOffset conditions_typeOffset = default(VectorOffset);
			if (_o.Conditions != null)
			{
				TGiantTriggerCondition[] array = new TGiantTriggerCondition[_o.Conditions.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = _o.Conditions[i].Type;
				}
				conditions_typeOffset = IGiantTriggerConditionGroup.CreateConditionsTypeVector(builder, array);
			}
			VectorOffset conditionsOffset = default(VectorOffset);
			if (_o.Conditions != null)
			{
				int[] array2 = new int[_o.Conditions.Count];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = TGiantTriggerConditionUnion.Pack(builder, _o.Conditions[j]);
				}
				conditionsOffset = IGiantTriggerConditionGroup.CreateConditionsVector(builder, array2);
			}
			return IGiantTriggerConditionGroup.CreateIGiantTriggerConditionGroup(builder, _o.Type, conditions_typeOffset, conditionsOffset);
		}

		// Token: 0x0400F7CC RID: 63436
		private Table __p;
	}
}
