using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.CommonBt
{
	// Token: 0x020064EE RID: 25838
	public struct ICommonBtConditionGroup : IFlatbufferObject
	{
		// Token: 0x1700BE85 RID: 48773
		// (get) Token: 0x0602BEF4 RID: 179956 RVA: 0x005F92FF File Offset: 0x005F74FF
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602BEF5 RID: 179957 RVA: 0x005F930C File Offset: 0x005F750C
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602BEF6 RID: 179958 RVA: 0x005F9314 File Offset: 0x005F7514
		public static ICommonBtConditionGroup GetRootAsICommonBtConditionGroup(ByteBuffer _bb)
		{
			return ICommonBtConditionGroup.GetRootAsICommonBtConditionGroup(_bb, default(ICommonBtConditionGroup));
		}

		// Token: 0x0602BEF7 RID: 179959 RVA: 0x005F9330 File Offset: 0x005F7530
		public static ICommonBtConditionGroup GetRootAsICommonBtConditionGroup(ByteBuffer _bb, ICommonBtConditionGroup obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602BEF8 RID: 179960 RVA: 0x005F934D File Offset: 0x005F754D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602BEF9 RID: 179961 RVA: 0x005F935C File Offset: 0x005F755C
		public ICommonBtConditionGroup __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BE86 RID: 48774
		// (get) Token: 0x0602BEFA RID: 179962 RVA: 0x005F936C File Offset: 0x005F756C
		public EConditionCount Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EConditionCount.All;
				}
				return (EConditionCount)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602BEFB RID: 179963 RVA: 0x005F93A8 File Offset: 0x005F75A8
		public ICommonBtConditionInfo? Conditions(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new ICommonBtConditionInfo?(default(ICommonBtConditionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700BE87 RID: 48775
		// (get) Token: 0x0602BEFC RID: 179964 RVA: 0x005F9408 File Offset: 0x005F7608
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

		// Token: 0x0602BEFD RID: 179965 RVA: 0x005F9433 File Offset: 0x005F7633
		public static Offset<ICommonBtConditionGroup> CreateICommonBtConditionGroup(FlatBufferBuilder builder, EConditionCount Type = EConditionCount.All, VectorOffset ConditionsOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			ICommonBtConditionGroup.AddConditions(builder, ConditionsOffset);
			ICommonBtConditionGroup.AddType(builder, Type);
			return ICommonBtConditionGroup.EndICommonBtConditionGroup(builder);
		}

		// Token: 0x0602BEFE RID: 179966 RVA: 0x005F9450 File Offset: 0x005F7650
		public static void StartICommonBtConditionGroup(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602BEFF RID: 179967 RVA: 0x005F9459 File Offset: 0x005F7659
		public static void AddType(FlatBufferBuilder builder, EConditionCount type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602BF00 RID: 179968 RVA: 0x005F9464 File Offset: 0x005F7664
		public static void AddConditions(FlatBufferBuilder builder, VectorOffset conditionsOffset)
		{
			builder.AddOffset(1, conditionsOffset.Value, 0);
		}

		// Token: 0x0602BF01 RID: 179969 RVA: 0x005F9474 File Offset: 0x005F7674
		public static VectorOffset CreateConditionsVector(FlatBufferBuilder builder, Offset<ICommonBtConditionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0602BF02 RID: 179970 RVA: 0x005F94B4 File Offset: 0x005F76B4
		public static VectorOffset CreateConditionsVectorBlock(FlatBufferBuilder builder, Offset<ICommonBtConditionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<ICommonBtConditionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602BF03 RID: 179971 RVA: 0x005F94CE File Offset: 0x005F76CE
		public static VectorOffset CreateConditionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<ICommonBtConditionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<ICommonBtConditionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602BF04 RID: 179972 RVA: 0x005F94EC File Offset: 0x005F76EC
		public static VectorOffset CreateConditionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<ICommonBtConditionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602BF05 RID: 179973 RVA: 0x005F9505 File Offset: 0x005F7705
		public static void StartConditionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602BF06 RID: 179974 RVA: 0x005F9510 File Offset: 0x005F7710
		public static Offset<ICommonBtConditionGroup> EndICommonBtConditionGroup(FlatBufferBuilder builder)
		{
			return new Offset<ICommonBtConditionGroup>(builder.EndTable());
		}

		// Token: 0x0602BF07 RID: 179975 RVA: 0x005F9520 File Offset: 0x005F7720
		public ICommonBtConditionGroupT UnPack()
		{
			ICommonBtConditionGroupT commonBtConditionGroupT = new ICommonBtConditionGroupT();
			this.UnPackTo(commonBtConditionGroupT);
			return commonBtConditionGroupT;
		}

		// Token: 0x0602BF08 RID: 179976 RVA: 0x005F953C File Offset: 0x005F773C
		public void UnPackTo(ICommonBtConditionGroupT _o)
		{
			_o.Type = this.Type;
			_o.Conditions = new List<ICommonBtConditionInfoT>();
			for (int i = 0; i < this.ConditionsLength; i++)
			{
				_o.Conditions.Add((this.Conditions(i) != null) ? this.Conditions(i).Value.UnPack() : null);
			}
		}

		// Token: 0x0602BF09 RID: 179977 RVA: 0x005F95A8 File Offset: 0x005F77A8
		public static Offset<ICommonBtConditionGroup> Pack(FlatBufferBuilder builder, ICommonBtConditionGroupT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICommonBtConditionGroup>);
			}
			VectorOffset conditionsOffset = default(VectorOffset);
			if (_o.Conditions != null)
			{
				Offset<ICommonBtConditionInfo>[] array = new Offset<ICommonBtConditionInfo>[_o.Conditions.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = ICommonBtConditionInfo.Pack(builder, _o.Conditions[i]);
				}
				conditionsOffset = ICommonBtConditionGroup.CreateConditionsVector(builder, array);
			}
			return ICommonBtConditionGroup.CreateICommonBtConditionGroup(builder, _o.Type, conditionsOffset);
		}

		// Token: 0x0401067F RID: 67199
		private Table __p;
	}
}
