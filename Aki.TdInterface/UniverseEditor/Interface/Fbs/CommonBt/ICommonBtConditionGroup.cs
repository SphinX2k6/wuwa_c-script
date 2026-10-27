using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.CommonBt
{
	// Token: 0x02005EAB RID: 24235
	public struct ICommonBtConditionGroup : IFlatbufferObject
	{
		// Token: 0x1700B51A RID: 46362
		// (get) Token: 0x0602984C RID: 170060 RVA: 0x005B035B File Offset: 0x005AE55B
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602984D RID: 170061 RVA: 0x005B0368 File Offset: 0x005AE568
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602984E RID: 170062 RVA: 0x005B0370 File Offset: 0x005AE570
		public static ICommonBtConditionGroup GetRootAsICommonBtConditionGroup(ByteBuffer _bb)
		{
			return ICommonBtConditionGroup.GetRootAsICommonBtConditionGroup(_bb, default(ICommonBtConditionGroup));
		}

		// Token: 0x0602984F RID: 170063 RVA: 0x005B038C File Offset: 0x005AE58C
		public static ICommonBtConditionGroup GetRootAsICommonBtConditionGroup(ByteBuffer _bb, ICommonBtConditionGroup obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06029850 RID: 170064 RVA: 0x005B03A9 File Offset: 0x005AE5A9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06029851 RID: 170065 RVA: 0x005B03B8 File Offset: 0x005AE5B8
		public ICommonBtConditionGroup __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B51B RID: 46363
		// (get) Token: 0x06029852 RID: 170066 RVA: 0x005B03C8 File Offset: 0x005AE5C8
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

		// Token: 0x06029853 RID: 170067 RVA: 0x005B0404 File Offset: 0x005AE604
		public ICommonBtConditionInfo? Conditions(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new ICommonBtConditionInfo?(default(ICommonBtConditionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700B51C RID: 46364
		// (get) Token: 0x06029854 RID: 170068 RVA: 0x005B0464 File Offset: 0x005AE664
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

		// Token: 0x06029855 RID: 170069 RVA: 0x005B048F File Offset: 0x005AE68F
		public static Offset<ICommonBtConditionGroup> CreateICommonBtConditionGroup(FlatBufferBuilder builder, EConditionCount Type = EConditionCount.All, VectorOffset ConditionsOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			ICommonBtConditionGroup.AddConditions(builder, ConditionsOffset);
			ICommonBtConditionGroup.AddType(builder, Type);
			return ICommonBtConditionGroup.EndICommonBtConditionGroup(builder);
		}

		// Token: 0x06029856 RID: 170070 RVA: 0x005B04AC File Offset: 0x005AE6AC
		public static void StartICommonBtConditionGroup(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06029857 RID: 170071 RVA: 0x005B04B5 File Offset: 0x005AE6B5
		public static void AddType(FlatBufferBuilder builder, EConditionCount type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06029858 RID: 170072 RVA: 0x005B04C0 File Offset: 0x005AE6C0
		public static void AddConditions(FlatBufferBuilder builder, VectorOffset conditionsOffset)
		{
			builder.AddOffset(1, conditionsOffset.Value, 0);
		}

		// Token: 0x06029859 RID: 170073 RVA: 0x005B04D0 File Offset: 0x005AE6D0
		public static VectorOffset CreateConditionsVector(FlatBufferBuilder builder, Offset<ICommonBtConditionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0602985A RID: 170074 RVA: 0x005B0510 File Offset: 0x005AE710
		public static VectorOffset CreateConditionsVectorBlock(FlatBufferBuilder builder, Offset<ICommonBtConditionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<ICommonBtConditionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602985B RID: 170075 RVA: 0x005B052A File Offset: 0x005AE72A
		public static VectorOffset CreateConditionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<ICommonBtConditionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<ICommonBtConditionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602985C RID: 170076 RVA: 0x005B0548 File Offset: 0x005AE748
		public static VectorOffset CreateConditionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<ICommonBtConditionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602985D RID: 170077 RVA: 0x005B0561 File Offset: 0x005AE761
		public static void StartConditionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602985E RID: 170078 RVA: 0x005B056C File Offset: 0x005AE76C
		public static Offset<ICommonBtConditionGroup> EndICommonBtConditionGroup(FlatBufferBuilder builder)
		{
			return new Offset<ICommonBtConditionGroup>(builder.EndTable());
		}

		// Token: 0x0602985F RID: 170079 RVA: 0x005B057C File Offset: 0x005AE77C
		public ICommonBtConditionGroupT UnPack()
		{
			ICommonBtConditionGroupT commonBtConditionGroupT = new ICommonBtConditionGroupT();
			this.UnPackTo(commonBtConditionGroupT);
			return commonBtConditionGroupT;
		}

		// Token: 0x06029860 RID: 170080 RVA: 0x005B0598 File Offset: 0x005AE798
		public void UnPackTo(ICommonBtConditionGroupT _o)
		{
			_o.Type = this.Type;
			_o.Conditions = new List<ICommonBtConditionInfoT>();
			for (int i = 0; i < this.ConditionsLength; i++)
			{
				_o.Conditions.Add((this.Conditions(i) != null) ? this.Conditions(i).Value.UnPack() : null);
			}
		}

		// Token: 0x06029861 RID: 170081 RVA: 0x005B0604 File Offset: 0x005AE804
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

		// Token: 0x0400F91C RID: 63772
		private Table __p;
	}
}
