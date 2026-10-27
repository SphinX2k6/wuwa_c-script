using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005E54 RID: 24148
	public struct IReignsEndingCondition : IFlatbufferObject
	{
		// Token: 0x1700B493 RID: 46227
		// (get) Token: 0x060295A1 RID: 169377 RVA: 0x005AB525 File Offset: 0x005A9725
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060295A2 RID: 169378 RVA: 0x005AB532 File Offset: 0x005A9732
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060295A3 RID: 169379 RVA: 0x005AB53C File Offset: 0x005A973C
		public static IReignsEndingCondition GetRootAsIReignsEndingCondition(ByteBuffer _bb)
		{
			return IReignsEndingCondition.GetRootAsIReignsEndingCondition(_bb, default(IReignsEndingCondition));
		}

		// Token: 0x060295A4 RID: 169380 RVA: 0x005AB558 File Offset: 0x005A9758
		public static IReignsEndingCondition GetRootAsIReignsEndingCondition(ByteBuffer _bb, IReignsEndingCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060295A5 RID: 169381 RVA: 0x005AB575 File Offset: 0x005A9775
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060295A6 RID: 169382 RVA: 0x005AB584 File Offset: 0x005A9784
		public IReignsEndingCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B494 RID: 46228
		// (get) Token: 0x060295A7 RID: 169383 RVA: 0x005AB594 File Offset: 0x005A9794
		public EReignsEndingConditionType ConditionType
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EReignsEndingConditionType.All;
				}
				return (EReignsEndingConditionType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060295A8 RID: 169384 RVA: 0x005AB5D0 File Offset: 0x005A97D0
		public ICompareReignsProperty? Conditions(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new ICompareReignsProperty?(default(ICompareReignsProperty).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700B495 RID: 46229
		// (get) Token: 0x060295A9 RID: 169385 RVA: 0x005AB630 File Offset: 0x005A9830
		public int ConditionsLength
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

		// Token: 0x060295AA RID: 169386 RVA: 0x005AB65B File Offset: 0x005A985B
		public static Offset<IReignsEndingCondition> CreateIReignsEndingCondition(FlatBufferBuilder builder, EReignsEndingConditionType ConditionType = EReignsEndingConditionType.All, VectorOffset ConditionsOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			IReignsEndingCondition.AddConditions(builder, ConditionsOffset);
			IReignsEndingCondition.AddConditionType(builder, ConditionType);
			return IReignsEndingCondition.EndIReignsEndingCondition(builder);
		}

		// Token: 0x060295AB RID: 169387 RVA: 0x005AB678 File Offset: 0x005A9878
		public static void StartIReignsEndingCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060295AC RID: 169388 RVA: 0x005AB681 File Offset: 0x005A9881
		public static void AddConditionType(FlatBufferBuilder builder, EReignsEndingConditionType conditionType)
		{
			builder.AddByte(0, (byte)conditionType, 0);
		}

		// Token: 0x060295AD RID: 169389 RVA: 0x005AB68C File Offset: 0x005A988C
		public static void AddConditions(FlatBufferBuilder builder, VectorOffset conditionsOffset)
		{
			builder.AddOffset(1, conditionsOffset.Value, 0);
		}

		// Token: 0x060295AE RID: 169390 RVA: 0x005AB69C File Offset: 0x005A989C
		public static VectorOffset CreateConditionsVector(FlatBufferBuilder builder, Offset<ICompareReignsProperty>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x060295AF RID: 169391 RVA: 0x005AB6DC File Offset: 0x005A98DC
		public static VectorOffset CreateConditionsVectorBlock(FlatBufferBuilder builder, Offset<ICompareReignsProperty>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<ICompareReignsProperty>>(data);
			return builder.EndVector();
		}

		// Token: 0x060295B0 RID: 169392 RVA: 0x005AB6F6 File Offset: 0x005A98F6
		public static VectorOffset CreateConditionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<ICompareReignsProperty>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<ICompareReignsProperty>>(data);
			return builder.EndVector();
		}

		// Token: 0x060295B1 RID: 169393 RVA: 0x005AB714 File Offset: 0x005A9914
		public static VectorOffset CreateConditionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<ICompareReignsProperty>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060295B2 RID: 169394 RVA: 0x005AB72D File Offset: 0x005A992D
		public static void StartConditionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060295B3 RID: 169395 RVA: 0x005AB738 File Offset: 0x005A9938
		public static Offset<IReignsEndingCondition> EndIReignsEndingCondition(FlatBufferBuilder builder)
		{
			return new Offset<IReignsEndingCondition>(builder.EndTable());
		}

		// Token: 0x060295B4 RID: 169396 RVA: 0x005AB748 File Offset: 0x005A9948
		public IReignsEndingConditionT UnPack()
		{
			IReignsEndingConditionT reignsEndingConditionT = new IReignsEndingConditionT();
			this.UnPackTo(reignsEndingConditionT);
			return reignsEndingConditionT;
		}

		// Token: 0x060295B5 RID: 169397 RVA: 0x005AB764 File Offset: 0x005A9964
		public void UnPackTo(IReignsEndingConditionT _o)
		{
			_o.ConditionType = this.ConditionType;
			_o.Conditions = new List<ICompareReignsPropertyT>();
			for (int i = 0; i < this.ConditionsLength; i++)
			{
				_o.Conditions.Add((this.Conditions(i) != null) ? this.Conditions(i).Value.UnPack() : null);
			}
		}

		// Token: 0x060295B6 RID: 169398 RVA: 0x005AB7D0 File Offset: 0x005A99D0
		public static Offset<IReignsEndingCondition> Pack(FlatBufferBuilder builder, IReignsEndingConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IReignsEndingCondition>);
			}
			VectorOffset conditionsOffset = default(VectorOffset);
			if (_o.Conditions != null)
			{
				Offset<ICompareReignsProperty>[] array = new Offset<ICompareReignsProperty>[_o.Conditions.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = ICompareReignsProperty.Pack(builder, _o.Conditions[i]);
				}
				conditionsOffset = IReignsEndingCondition.CreateConditionsVector(builder, array);
			}
			return IReignsEndingCondition.CreateIReignsEndingCondition(builder, _o.ConditionType, conditionsOffset);
		}

		// Token: 0x0400F85E RID: 63582
		private Table __p;
	}
}
