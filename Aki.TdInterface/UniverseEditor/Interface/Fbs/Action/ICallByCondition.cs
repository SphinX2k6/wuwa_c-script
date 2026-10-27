using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200626F RID: 25199
	public struct ICallByCondition : IFlatbufferObject
	{
		// Token: 0x1700BBC9 RID: 48073
		// (get) Token: 0x0602B7CF RID: 178127 RVA: 0x005FCE27 File Offset: 0x005FB027
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602B7D0 RID: 178128 RVA: 0x005FCE34 File Offset: 0x005FB034
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602B7D1 RID: 178129 RVA: 0x005FCE3C File Offset: 0x005FB03C
		public static ICallByCondition GetRootAsICallByCondition(ByteBuffer _bb)
		{
			return ICallByCondition.GetRootAsICallByCondition(_bb, default(ICallByCondition));
		}

		// Token: 0x0602B7D2 RID: 178130 RVA: 0x005FCE58 File Offset: 0x005FB058
		public static ICallByCondition GetRootAsICallByCondition(ByteBuffer _bb, ICallByCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602B7D3 RID: 178131 RVA: 0x005FCE75 File Offset: 0x005FB075
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602B7D4 RID: 178132 RVA: 0x005FCE84 File Offset: 0x005FB084
		public ICallByCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BBCA RID: 48074
		// (get) Token: 0x0602B7D5 RID: 178133 RVA: 0x005FCE94 File Offset: 0x005FB094
		public IConditions? Conditions
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return new IConditions?(default(IConditions).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x0602B7D6 RID: 178134 RVA: 0x005FCEF4 File Offset: 0x005FB0F4
		public IActionInfo? TrueActions(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700BBCB RID: 48075
		// (get) Token: 0x0602B7D7 RID: 178135 RVA: 0x005FCF54 File Offset: 0x005FB154
		public int TrueActionsLength
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

		// Token: 0x0602B7D8 RID: 178136 RVA: 0x005FCF80 File Offset: 0x005FB180
		public IActionInfo? FalseActions(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700BBCC RID: 48076
		// (get) Token: 0x0602B7D9 RID: 178137 RVA: 0x005FCFE0 File Offset: 0x005FB1E0
		public int FalseActionsLength
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

		// Token: 0x1700BBCD RID: 48077
		// (get) Token: 0x0602B7DA RID: 178138 RVA: 0x005FD00C File Offset: 0x005FB20C
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602B7DB RID: 178139 RVA: 0x005FD049 File Offset: 0x005FB249
		public static Offset<ICallByCondition> CreateICallByCondition(FlatBufferBuilder builder, Offset<IConditions> ConditionsOffset = default(Offset<IConditions>), VectorOffset TrueActionsOffset = default(VectorOffset), VectorOffset FalseActionsOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(4);
			ICallByCondition.AddFalseActions(builder, FalseActionsOffset);
			ICallByCondition.AddTrueActions(builder, TrueActionsOffset);
			ICallByCondition.AddConditions(builder, ConditionsOffset);
			ICallByCondition.AddNullMask(builder, NullMask);
			return ICallByCondition.EndICallByCondition(builder);
		}

		// Token: 0x0602B7DC RID: 178140 RVA: 0x005FD075 File Offset: 0x005FB275
		public static void StartICallByCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0602B7DD RID: 178141 RVA: 0x005FD07E File Offset: 0x005FB27E
		public static void AddConditions(FlatBufferBuilder builder, Offset<IConditions> conditionsOffset)
		{
			builder.AddOffset(0, conditionsOffset.Value, 0);
		}

		// Token: 0x0602B7DE RID: 178142 RVA: 0x005FD08E File Offset: 0x005FB28E
		public static void AddTrueActions(FlatBufferBuilder builder, VectorOffset trueActionsOffset)
		{
			builder.AddOffset(1, trueActionsOffset.Value, 0);
		}

		// Token: 0x0602B7DF RID: 178143 RVA: 0x005FD0A0 File Offset: 0x005FB2A0
		public static VectorOffset CreateTrueActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0602B7E0 RID: 178144 RVA: 0x005FD0E0 File Offset: 0x005FB2E0
		public static VectorOffset CreateTrueActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602B7E1 RID: 178145 RVA: 0x005FD0FA File Offset: 0x005FB2FA
		public static VectorOffset CreateTrueActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602B7E2 RID: 178146 RVA: 0x005FD118 File Offset: 0x005FB318
		public static VectorOffset CreateTrueActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602B7E3 RID: 178147 RVA: 0x005FD131 File Offset: 0x005FB331
		public static void StartTrueActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602B7E4 RID: 178148 RVA: 0x005FD13C File Offset: 0x005FB33C
		public static void AddFalseActions(FlatBufferBuilder builder, VectorOffset falseActionsOffset)
		{
			builder.AddOffset(2, falseActionsOffset.Value, 0);
		}

		// Token: 0x0602B7E5 RID: 178149 RVA: 0x005FD14C File Offset: 0x005FB34C
		public static VectorOffset CreateFalseActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0602B7E6 RID: 178150 RVA: 0x005FD18C File Offset: 0x005FB38C
		public static VectorOffset CreateFalseActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602B7E7 RID: 178151 RVA: 0x005FD1A6 File Offset: 0x005FB3A6
		public static VectorOffset CreateFalseActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602B7E8 RID: 178152 RVA: 0x005FD1C4 File Offset: 0x005FB3C4
		public static VectorOffset CreateFalseActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602B7E9 RID: 178153 RVA: 0x005FD1DD File Offset: 0x005FB3DD
		public static void StartFalseActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602B7EA RID: 178154 RVA: 0x005FD1E8 File Offset: 0x005FB3E8
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x0602B7EB RID: 178155 RVA: 0x005FD1F3 File Offset: 0x005FB3F3
		public static Offset<ICallByCondition> EndICallByCondition(FlatBufferBuilder builder)
		{
			return new Offset<ICallByCondition>(builder.EndTable());
		}

		// Token: 0x0602B7EC RID: 178156 RVA: 0x005FD200 File Offset: 0x005FB400
		public ICallByConditionT UnPack()
		{
			ICallByConditionT callByConditionT = new ICallByConditionT();
			this.UnPackTo(callByConditionT);
			return callByConditionT;
		}

		// Token: 0x0602B7ED RID: 178157 RVA: 0x005FD21C File Offset: 0x005FB41C
		public void UnPackTo(ICallByConditionT _o)
		{
			_o.Conditions = ((this.Conditions != null) ? this.Conditions.Value.UnPack() : null);
			_o.TrueActions = new List<IActionInfoT>();
			for (int i = 0; i < this.TrueActionsLength; i++)
			{
				_o.TrueActions.Add((this.TrueActions(i) != null) ? this.TrueActions(i).Value.UnPack() : null);
			}
			_o.FalseActions = new List<IActionInfoT>();
			for (int j = 0; j < this.FalseActionsLength; j++)
			{
				_o.FalseActions.Add((this.FalseActions(j) != null) ? this.FalseActions(j).Value.UnPack() : null);
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602B7EE RID: 178158 RVA: 0x005FD310 File Offset: 0x005FB510
		public static Offset<ICallByCondition> Pack(FlatBufferBuilder builder, ICallByConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICallByCondition>);
			}
			Offset<IConditions> conditionsOffset = (_o.Conditions == null) ? default(Offset<IConditions>) : IConditions.Pack(builder, _o.Conditions);
			VectorOffset trueActionsOffset = default(VectorOffset);
			if (_o.TrueActions != null)
			{
				Offset<IActionInfo>[] array = new Offset<IActionInfo>[_o.TrueActions.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IActionInfo.Pack(builder, _o.TrueActions[i]);
				}
				trueActionsOffset = ICallByCondition.CreateTrueActionsVector(builder, array);
			}
			VectorOffset falseActionsOffset = default(VectorOffset);
			if (_o.FalseActions != null)
			{
				Offset<IActionInfo>[] array2 = new Offset<IActionInfo>[_o.FalseActions.Count];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = IActionInfo.Pack(builder, _o.FalseActions[j]);
				}
				falseActionsOffset = ICallByCondition.CreateFalseActionsVector(builder, array2);
			}
			return ICallByCondition.CreateICallByCondition(builder, conditionsOffset, trueActionsOffset, falseActionsOffset, _o.NullMask);
		}

		// Token: 0x040107CB RID: 67531
		private Table __p;
	}
}
