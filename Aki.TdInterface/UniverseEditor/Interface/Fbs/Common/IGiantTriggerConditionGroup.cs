using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x0200641F RID: 25631
	public struct IGiantTriggerConditionGroup : IFlatbufferObject
	{
		// Token: 0x1700BD4B RID: 48459
		// (get) Token: 0x0602B8B6 RID: 178358 RVA: 0x005EDFB4 File Offset: 0x005EC1B4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602B8B7 RID: 178359 RVA: 0x005EDFC1 File Offset: 0x005EC1C1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602B8B8 RID: 178360 RVA: 0x005EDFC8 File Offset: 0x005EC1C8
		public static IGiantTriggerConditionGroup GetRootAsIGiantTriggerConditionGroup(ByteBuffer _bb)
		{
			return IGiantTriggerConditionGroup.GetRootAsIGiantTriggerConditionGroup(_bb, default(IGiantTriggerConditionGroup));
		}

		// Token: 0x0602B8B9 RID: 178361 RVA: 0x005EDFE4 File Offset: 0x005EC1E4
		public static IGiantTriggerConditionGroup GetRootAsIGiantTriggerConditionGroup(ByteBuffer _bb, IGiantTriggerConditionGroup obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602B8BA RID: 178362 RVA: 0x005EE001 File Offset: 0x005EC201
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602B8BB RID: 178363 RVA: 0x005EE010 File Offset: 0x005EC210
		public IGiantTriggerConditionGroup __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BD4C RID: 48460
		// (get) Token: 0x0602B8BC RID: 178364 RVA: 0x005EE020 File Offset: 0x005EC220
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

		// Token: 0x0602B8BD RID: 178365 RVA: 0x005EE05C File Offset: 0x005EC25C
		public TGiantTriggerCondition ConditionsType(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return TGiantTriggerCondition.NONE;
			}
			return (TGiantTriggerCondition)this.__p.bb.Get(this.__p.__vector(num) + j);
		}

		// Token: 0x1700BD4D RID: 48461
		// (get) Token: 0x0602B8BE RID: 178366 RVA: 0x005EE09C File Offset: 0x005EC29C
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

		// Token: 0x0602B8BF RID: 178367 RVA: 0x005EE0C7 File Offset: 0x005EC2C7
		public Span<TGiantTriggerCondition> GetConditionsTypeBytes()
		{
			return this.__p.__vector_as_span<TGiantTriggerCondition>(6, 1);
		}

		// Token: 0x0602B8C0 RID: 178368 RVA: 0x005EE0D8 File Offset: 0x005EC2D8
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

		// Token: 0x0602B8C1 RID: 178369 RVA: 0x005EE144 File Offset: 0x005EC344
		public TTable? Conditions<TTable>(int j) where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(this.__p.__vector(num) + j * 4));
		}

		// Token: 0x1700BD4E RID: 48462
		// (get) Token: 0x0602B8C2 RID: 178370 RVA: 0x005EE18C File Offset: 0x005EC38C
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

		// Token: 0x0602B8C3 RID: 178371 RVA: 0x005EE1B7 File Offset: 0x005EC3B7
		public static Offset<IGiantTriggerConditionGroup> CreateIGiantTriggerConditionGroup(FlatBufferBuilder builder, EGiantConditionCount Type = EGiantConditionCount.All, VectorOffset Conditions_typeOffset = default(VectorOffset), VectorOffset ConditionsOffset = default(VectorOffset))
		{
			builder.StartTable(3);
			IGiantTriggerConditionGroup.AddConditions(builder, ConditionsOffset);
			IGiantTriggerConditionGroup.AddConditionsType(builder, Conditions_typeOffset);
			IGiantTriggerConditionGroup.AddType(builder, Type);
			return IGiantTriggerConditionGroup.EndIGiantTriggerConditionGroup(builder);
		}

		// Token: 0x0602B8C4 RID: 178372 RVA: 0x005EE1DB File Offset: 0x005EC3DB
		public static void StartIGiantTriggerConditionGroup(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0602B8C5 RID: 178373 RVA: 0x005EE1E4 File Offset: 0x005EC3E4
		public static void AddType(FlatBufferBuilder builder, EGiantConditionCount type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602B8C6 RID: 178374 RVA: 0x005EE1EF File Offset: 0x005EC3EF
		public static void AddConditionsType(FlatBufferBuilder builder, VectorOffset conditionsTypeOffset)
		{
			builder.AddOffset(1, conditionsTypeOffset.Value, 0);
		}

		// Token: 0x0602B8C7 RID: 178375 RVA: 0x005EE200 File Offset: 0x005EC400
		public static VectorOffset CreateConditionsTypeVector(FlatBufferBuilder builder, TGiantTriggerCondition[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddByte((byte)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0602B8C8 RID: 178376 RVA: 0x005EE237 File Offset: 0x005EC437
		public static VectorOffset CreateConditionsTypeVectorBlock(FlatBufferBuilder builder, TGiantTriggerCondition[] data)
		{
			builder.StartVector(1, data.Length, 1);
			builder.Add<TGiantTriggerCondition>(data);
			return builder.EndVector();
		}

		// Token: 0x0602B8C9 RID: 178377 RVA: 0x005EE251 File Offset: 0x005EC451
		public static VectorOffset CreateConditionsTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<TGiantTriggerCondition> data)
		{
			builder.StartVector(1, data.Count, 1);
			builder.Add<TGiantTriggerCondition>(data);
			return builder.EndVector();
		}

		// Token: 0x0602B8CA RID: 178378 RVA: 0x005EE26F File Offset: 0x005EC46F
		public static VectorOffset CreateConditionsTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<TGiantTriggerCondition>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602B8CB RID: 178379 RVA: 0x005EE288 File Offset: 0x005EC488
		public static void StartConditionsTypeVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x0602B8CC RID: 178380 RVA: 0x005EE293 File Offset: 0x005EC493
		public static void AddConditions(FlatBufferBuilder builder, VectorOffset conditionsOffset)
		{
			builder.AddOffset(2, conditionsOffset.Value, 0);
		}

		// Token: 0x0602B8CD RID: 178381 RVA: 0x005EE2A4 File Offset: 0x005EC4A4
		public static VectorOffset CreateConditionsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0602B8CE RID: 178382 RVA: 0x005EE2DB File Offset: 0x005EC4DB
		public static VectorOffset CreateConditionsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602B8CF RID: 178383 RVA: 0x005EE2F5 File Offset: 0x005EC4F5
		public static VectorOffset CreateConditionsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602B8D0 RID: 178384 RVA: 0x005EE313 File Offset: 0x005EC513
		public static VectorOffset CreateConditionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602B8D1 RID: 178385 RVA: 0x005EE32C File Offset: 0x005EC52C
		public static void StartConditionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602B8D2 RID: 178386 RVA: 0x005EE337 File Offset: 0x005EC537
		public static Offset<IGiantTriggerConditionGroup> EndIGiantTriggerConditionGroup(FlatBufferBuilder builder)
		{
			return new Offset<IGiantTriggerConditionGroup>(builder.EndTable());
		}

		// Token: 0x0602B8D3 RID: 178387 RVA: 0x005EE344 File Offset: 0x005EC544
		public IGiantTriggerConditionGroupT UnPack()
		{
			IGiantTriggerConditionGroupT giantTriggerConditionGroupT = new IGiantTriggerConditionGroupT();
			this.UnPackTo(giantTriggerConditionGroupT);
			return giantTriggerConditionGroupT;
		}

		// Token: 0x0602B8D4 RID: 178388 RVA: 0x005EE360 File Offset: 0x005EC560
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

		// Token: 0x0602B8D5 RID: 178389 RVA: 0x005EE47C File Offset: 0x005EC67C
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

		// Token: 0x04010527 RID: 66855
		private Table __p;
	}
}
