using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02006494 RID: 25748
	public struct IReignsEndingCondition : IFlatbufferObject
	{
		// Token: 0x1700BDFC RID: 48636
		// (get) Token: 0x0602BC3D RID: 179261 RVA: 0x005F43CD File Offset: 0x005F25CD
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602BC3E RID: 179262 RVA: 0x005F43DA File Offset: 0x005F25DA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602BC3F RID: 179263 RVA: 0x005F43E4 File Offset: 0x005F25E4
		public static IReignsEndingCondition GetRootAsIReignsEndingCondition(ByteBuffer _bb)
		{
			return IReignsEndingCondition.GetRootAsIReignsEndingCondition(_bb, default(IReignsEndingCondition));
		}

		// Token: 0x0602BC40 RID: 179264 RVA: 0x005F4400 File Offset: 0x005F2600
		public static IReignsEndingCondition GetRootAsIReignsEndingCondition(ByteBuffer _bb, IReignsEndingCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602BC41 RID: 179265 RVA: 0x005F441D File Offset: 0x005F261D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602BC42 RID: 179266 RVA: 0x005F442C File Offset: 0x005F262C
		public IReignsEndingCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BDFD RID: 48637
		// (get) Token: 0x0602BC43 RID: 179267 RVA: 0x005F443C File Offset: 0x005F263C
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

		// Token: 0x0602BC44 RID: 179268 RVA: 0x005F4478 File Offset: 0x005F2678
		public ICompareReignsProperty? Conditions(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new ICompareReignsProperty?(default(ICompareReignsProperty).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700BDFE RID: 48638
		// (get) Token: 0x0602BC45 RID: 179269 RVA: 0x005F44D8 File Offset: 0x005F26D8
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

		// Token: 0x0602BC46 RID: 179270 RVA: 0x005F4503 File Offset: 0x005F2703
		public static Offset<IReignsEndingCondition> CreateIReignsEndingCondition(FlatBufferBuilder builder, EReignsEndingConditionType ConditionType = EReignsEndingConditionType.All, VectorOffset ConditionsOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			IReignsEndingCondition.AddConditions(builder, ConditionsOffset);
			IReignsEndingCondition.AddConditionType(builder, ConditionType);
			return IReignsEndingCondition.EndIReignsEndingCondition(builder);
		}

		// Token: 0x0602BC47 RID: 179271 RVA: 0x005F4520 File Offset: 0x005F2720
		public static void StartIReignsEndingCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602BC48 RID: 179272 RVA: 0x005F4529 File Offset: 0x005F2729
		public static void AddConditionType(FlatBufferBuilder builder, EReignsEndingConditionType conditionType)
		{
			builder.AddByte(0, (byte)conditionType, 0);
		}

		// Token: 0x0602BC49 RID: 179273 RVA: 0x005F4534 File Offset: 0x005F2734
		public static void AddConditions(FlatBufferBuilder builder, VectorOffset conditionsOffset)
		{
			builder.AddOffset(1, conditionsOffset.Value, 0);
		}

		// Token: 0x0602BC4A RID: 179274 RVA: 0x005F4544 File Offset: 0x005F2744
		public static VectorOffset CreateConditionsVector(FlatBufferBuilder builder, Offset<ICompareReignsProperty>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0602BC4B RID: 179275 RVA: 0x005F4584 File Offset: 0x005F2784
		public static VectorOffset CreateConditionsVectorBlock(FlatBufferBuilder builder, Offset<ICompareReignsProperty>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<ICompareReignsProperty>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602BC4C RID: 179276 RVA: 0x005F459E File Offset: 0x005F279E
		public static VectorOffset CreateConditionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<ICompareReignsProperty>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<ICompareReignsProperty>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602BC4D RID: 179277 RVA: 0x005F45BC File Offset: 0x005F27BC
		public static VectorOffset CreateConditionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<ICompareReignsProperty>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602BC4E RID: 179278 RVA: 0x005F45D5 File Offset: 0x005F27D5
		public static void StartConditionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602BC4F RID: 179279 RVA: 0x005F45E0 File Offset: 0x005F27E0
		public static Offset<IReignsEndingCondition> EndIReignsEndingCondition(FlatBufferBuilder builder)
		{
			return new Offset<IReignsEndingCondition>(builder.EndTable());
		}

		// Token: 0x0602BC50 RID: 179280 RVA: 0x005F45F0 File Offset: 0x005F27F0
		public IReignsEndingConditionT UnPack()
		{
			IReignsEndingConditionT reignsEndingConditionT = new IReignsEndingConditionT();
			this.UnPackTo(reignsEndingConditionT);
			return reignsEndingConditionT;
		}

		// Token: 0x0602BC51 RID: 179281 RVA: 0x005F460C File Offset: 0x005F280C
		public void UnPackTo(IReignsEndingConditionT _o)
		{
			_o.ConditionType = this.ConditionType;
			_o.Conditions = new List<ICompareReignsPropertyT>();
			for (int i = 0; i < this.ConditionsLength; i++)
			{
				_o.Conditions.Add((this.Conditions(i) != null) ? this.Conditions(i).Value.UnPack() : null);
			}
		}

		// Token: 0x0602BC52 RID: 179282 RVA: 0x005F4678 File Offset: 0x005F2878
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

		// Token: 0x040105BB RID: 67003
		private Table __p;
	}
}
