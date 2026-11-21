using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006B2A RID: 27434
	public struct IConditions : IFlatbufferObject
	{
		// Token: 0x1700C977 RID: 51575
		// (get) Token: 0x0602F334 RID: 193332 RVA: 0x00672247 File Offset: 0x00670447
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602F335 RID: 193333 RVA: 0x00672254 File Offset: 0x00670454
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602F336 RID: 193334 RVA: 0x0067225C File Offset: 0x0067045C
		public static IConditions GetRootAsIConditions(ByteBuffer _bb)
		{
			return IConditions.GetRootAsIConditions(_bb, default(IConditions));
		}

		// Token: 0x0602F337 RID: 193335 RVA: 0x00672278 File Offset: 0x00670478
		public static IConditions GetRootAsIConditions(ByteBuffer _bb, IConditions obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602F338 RID: 193336 RVA: 0x00672295 File Offset: 0x00670495
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602F339 RID: 193337 RVA: 0x006722A4 File Offset: 0x006704A4
		public IConditions __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C978 RID: 51576
		// (get) Token: 0x0602F33A RID: 193338 RVA: 0x006722B4 File Offset: 0x006704B4
		public string LogicOpType
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602F33B RID: 193339 RVA: 0x006722EB File Offset: 0x006704EB
		public Span<byte> GetLogicOpTypeBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0602F33C RID: 193340 RVA: 0x006722FA File Offset: 0x006704FA
		public byte[] GetLogicOpTypeArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x0602F33D RID: 193341 RVA: 0x00672308 File Offset: 0x00670508
		public ICondition? Conditions(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new ICondition?(default(ICondition).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700C979 RID: 51577
		// (get) Token: 0x0602F33E RID: 193342 RVA: 0x00672368 File Offset: 0x00670568
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

		// Token: 0x0602F33F RID: 193343 RVA: 0x00672393 File Offset: 0x00670593
		public static Offset<IConditions> CreateIConditions(FlatBufferBuilder builder, StringOffset LogicOpTypeOffset = default(StringOffset), VectorOffset ConditionsOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			IConditions.AddConditions(builder, ConditionsOffset);
			IConditions.AddLogicOpType(builder, LogicOpTypeOffset);
			return IConditions.EndIConditions(builder);
		}

		// Token: 0x0602F340 RID: 193344 RVA: 0x006723B0 File Offset: 0x006705B0
		public static void StartIConditions(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602F341 RID: 193345 RVA: 0x006723B9 File Offset: 0x006705B9
		public static void AddLogicOpType(FlatBufferBuilder builder, StringOffset logicOpTypeOffset)
		{
			builder.AddOffset(0, logicOpTypeOffset.Value, 0);
		}

		// Token: 0x0602F342 RID: 193346 RVA: 0x006723C9 File Offset: 0x006705C9
		public static void AddConditions(FlatBufferBuilder builder, VectorOffset conditionsOffset)
		{
			builder.AddOffset(1, conditionsOffset.Value, 0);
		}

		// Token: 0x0602F343 RID: 193347 RVA: 0x006723DC File Offset: 0x006705DC
		public static VectorOffset CreateConditionsVector(FlatBufferBuilder builder, Offset<ICondition>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0602F344 RID: 193348 RVA: 0x0067241C File Offset: 0x0067061C
		public static VectorOffset CreateConditionsVectorBlock(FlatBufferBuilder builder, Offset<ICondition>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<ICondition>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602F345 RID: 193349 RVA: 0x00672436 File Offset: 0x00670636
		public static VectorOffset CreateConditionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<ICondition>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<ICondition>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602F346 RID: 193350 RVA: 0x00672454 File Offset: 0x00670654
		public static VectorOffset CreateConditionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<ICondition>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602F347 RID: 193351 RVA: 0x0067246D File Offset: 0x0067066D
		public static void StartConditionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602F348 RID: 193352 RVA: 0x00672478 File Offset: 0x00670678
		public static Offset<IConditions> EndIConditions(FlatBufferBuilder builder)
		{
			return new Offset<IConditions>(builder.EndTable());
		}

		// Token: 0x0602F349 RID: 193353 RVA: 0x00672488 File Offset: 0x00670688
		public IConditionsT UnPack()
		{
			IConditionsT conditionsT = new IConditionsT();
			this.UnPackTo(conditionsT);
			return conditionsT;
		}

		// Token: 0x0602F34A RID: 193354 RVA: 0x006724A4 File Offset: 0x006706A4
		public void UnPackTo(IConditionsT _o)
		{
			_o.LogicOpType = this.LogicOpType;
			_o.Conditions = new List<IConditionT>();
			for (int i = 0; i < this.ConditionsLength; i++)
			{
				_o.Conditions.Add((this.Conditions(i) != null) ? this.Conditions(i).Value.UnPack() : null);
			}
		}

		// Token: 0x0602F34B RID: 193355 RVA: 0x00672510 File Offset: 0x00670710
		public static Offset<IConditions> Pack(FlatBufferBuilder builder, IConditionsT _o)
		{
			if (_o == null)
			{
				return default(Offset<IConditions>);
			}
			StringOffset logicOpTypeOffset = (_o.LogicOpType == null) ? default(StringOffset) : builder.CreateString(_o.LogicOpType);
			VectorOffset conditionsOffset = default(VectorOffset);
			if (_o.Conditions != null)
			{
				Offset<ICondition>[] array = new Offset<ICondition>[_o.Conditions.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = ICondition.Pack(builder, _o.Conditions[i]);
				}
				conditionsOffset = IConditions.CreateConditionsVector(builder, array);
			}
			return IConditions.CreateIConditions(builder, logicOpTypeOffset, conditionsOffset);
		}

		// Token: 0x04011908 RID: 71944
		private Table __p;
	}
}
