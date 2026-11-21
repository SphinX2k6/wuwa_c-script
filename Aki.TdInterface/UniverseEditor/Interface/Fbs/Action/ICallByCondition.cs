using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020068E0 RID: 26848
	public struct ICallByCondition : IFlatbufferObject
	{
		// Token: 0x1700C551 RID: 50513
		// (get) Token: 0x0602DF30 RID: 188208 RVA: 0x00647C2F File Offset: 0x00645E2F
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602DF31 RID: 188209 RVA: 0x00647C3C File Offset: 0x00645E3C
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602DF32 RID: 188210 RVA: 0x00647C44 File Offset: 0x00645E44
		public static ICallByCondition GetRootAsICallByCondition(ByteBuffer _bb)
		{
			return ICallByCondition.GetRootAsICallByCondition(_bb, default(ICallByCondition));
		}

		// Token: 0x0602DF33 RID: 188211 RVA: 0x00647C60 File Offset: 0x00645E60
		public static ICallByCondition GetRootAsICallByCondition(ByteBuffer _bb, ICallByCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602DF34 RID: 188212 RVA: 0x00647C7D File Offset: 0x00645E7D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602DF35 RID: 188213 RVA: 0x00647C8C File Offset: 0x00645E8C
		public ICallByCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C552 RID: 50514
		// (get) Token: 0x0602DF36 RID: 188214 RVA: 0x00647C9C File Offset: 0x00645E9C
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

		// Token: 0x0602DF37 RID: 188215 RVA: 0x00647CFC File Offset: 0x00645EFC
		public IActionInfo? TrueActions(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700C553 RID: 50515
		// (get) Token: 0x0602DF38 RID: 188216 RVA: 0x00647D5C File Offset: 0x00645F5C
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

		// Token: 0x0602DF39 RID: 188217 RVA: 0x00647D88 File Offset: 0x00645F88
		public IActionInfo? FalseActions(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700C554 RID: 50516
		// (get) Token: 0x0602DF3A RID: 188218 RVA: 0x00647DE8 File Offset: 0x00645FE8
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

		// Token: 0x1700C555 RID: 50517
		// (get) Token: 0x0602DF3B RID: 188219 RVA: 0x00647E14 File Offset: 0x00646014
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

		// Token: 0x0602DF3C RID: 188220 RVA: 0x00647E51 File Offset: 0x00646051
		public static Offset<ICallByCondition> CreateICallByCondition(FlatBufferBuilder builder, Offset<IConditions> ConditionsOffset = default(Offset<IConditions>), VectorOffset TrueActionsOffset = default(VectorOffset), VectorOffset FalseActionsOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(4);
			ICallByCondition.AddFalseActions(builder, FalseActionsOffset);
			ICallByCondition.AddTrueActions(builder, TrueActionsOffset);
			ICallByCondition.AddConditions(builder, ConditionsOffset);
			ICallByCondition.AddNullMask(builder, NullMask);
			return ICallByCondition.EndICallByCondition(builder);
		}

		// Token: 0x0602DF3D RID: 188221 RVA: 0x00647E7D File Offset: 0x0064607D
		public static void StartICallByCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0602DF3E RID: 188222 RVA: 0x00647E86 File Offset: 0x00646086
		public static void AddConditions(FlatBufferBuilder builder, Offset<IConditions> conditionsOffset)
		{
			builder.AddOffset(0, conditionsOffset.Value, 0);
		}

		// Token: 0x0602DF3F RID: 188223 RVA: 0x00647E96 File Offset: 0x00646096
		public static void AddTrueActions(FlatBufferBuilder builder, VectorOffset trueActionsOffset)
		{
			builder.AddOffset(1, trueActionsOffset.Value, 0);
		}

		// Token: 0x0602DF40 RID: 188224 RVA: 0x00647EA8 File Offset: 0x006460A8
		public static VectorOffset CreateTrueActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0602DF41 RID: 188225 RVA: 0x00647EE8 File Offset: 0x006460E8
		public static VectorOffset CreateTrueActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602DF42 RID: 188226 RVA: 0x00647F02 File Offset: 0x00646102
		public static VectorOffset CreateTrueActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602DF43 RID: 188227 RVA: 0x00647F20 File Offset: 0x00646120
		public static VectorOffset CreateTrueActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602DF44 RID: 188228 RVA: 0x00647F39 File Offset: 0x00646139
		public static void StartTrueActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602DF45 RID: 188229 RVA: 0x00647F44 File Offset: 0x00646144
		public static void AddFalseActions(FlatBufferBuilder builder, VectorOffset falseActionsOffset)
		{
			builder.AddOffset(2, falseActionsOffset.Value, 0);
		}

		// Token: 0x0602DF46 RID: 188230 RVA: 0x00647F54 File Offset: 0x00646154
		public static VectorOffset CreateFalseActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0602DF47 RID: 188231 RVA: 0x00647F94 File Offset: 0x00646194
		public static VectorOffset CreateFalseActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602DF48 RID: 188232 RVA: 0x00647FAE File Offset: 0x006461AE
		public static VectorOffset CreateFalseActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602DF49 RID: 188233 RVA: 0x00647FCC File Offset: 0x006461CC
		public static VectorOffset CreateFalseActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602DF4A RID: 188234 RVA: 0x00647FE5 File Offset: 0x006461E5
		public static void StartFalseActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602DF4B RID: 188235 RVA: 0x00647FF0 File Offset: 0x006461F0
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x0602DF4C RID: 188236 RVA: 0x00647FFB File Offset: 0x006461FB
		public static Offset<ICallByCondition> EndICallByCondition(FlatBufferBuilder builder)
		{
			return new Offset<ICallByCondition>(builder.EndTable());
		}

		// Token: 0x0602DF4D RID: 188237 RVA: 0x00648008 File Offset: 0x00646208
		public ICallByConditionT UnPack()
		{
			ICallByConditionT callByConditionT = new ICallByConditionT();
			this.UnPackTo(callByConditionT);
			return callByConditionT;
		}

		// Token: 0x0602DF4E RID: 188238 RVA: 0x00648024 File Offset: 0x00646224
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

		// Token: 0x0602DF4F RID: 188239 RVA: 0x00648118 File Offset: 0x00646318
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

		// Token: 0x040115E0 RID: 71136
		private Table __p;
	}
}
