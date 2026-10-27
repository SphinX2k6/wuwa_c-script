using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.FixProcessor
{
	// Token: 0x02004754 RID: 18260
	public struct IFixAction : IFlatbufferObject
	{
		// Token: 0x170082F8 RID: 33528
		// (get) Token: 0x0601C189 RID: 115081 RVA: 0x003FB140 File Offset: 0x003F9340
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601C18A RID: 115082 RVA: 0x003FB14D File Offset: 0x003F934D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601C18B RID: 115083 RVA: 0x003FB154 File Offset: 0x003F9354
		public static IFixAction GetRootAsIFixAction(ByteBuffer _bb)
		{
			return IFixAction.GetRootAsIFixAction(_bb, default(IFixAction));
		}

		// Token: 0x0601C18C RID: 115084 RVA: 0x003FB170 File Offset: 0x003F9370
		public static IFixAction GetRootAsIFixAction(ByteBuffer _bb, IFixAction obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601C18D RID: 115085 RVA: 0x003FB18D File Offset: 0x003F938D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601C18E RID: 115086 RVA: 0x003FB19C File Offset: 0x003F939C
		public IFixAction __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170082F9 RID: 33529
		// (get) Token: 0x0601C18F RID: 115087 RVA: 0x003FB1AC File Offset: 0x003F93AC
		public string Timing
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

		// Token: 0x0601C190 RID: 115088 RVA: 0x003FB1E3 File Offset: 0x003F93E3
		public Span<byte> GetTimingBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0601C191 RID: 115089 RVA: 0x003FB1F2 File Offset: 0x003F93F2
		public byte[] GetTimingArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x170082FA RID: 33530
		// (get) Token: 0x0601C192 RID: 115090 RVA: 0x003FB200 File Offset: 0x003F9400
		public IConditionGroup? Condition
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

		// Token: 0x0601C193 RID: 115091 RVA: 0x003FB260 File Offset: 0x003F9460
		public IActionInfo? ThenActions(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170082FB RID: 33531
		// (get) Token: 0x0601C194 RID: 115092 RVA: 0x003FB2C0 File Offset: 0x003F94C0
		public int ThenActionsLength
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

		// Token: 0x170082FC RID: 33532
		// (get) Token: 0x0601C195 RID: 115093 RVA: 0x003FB2EC File Offset: 0x003F94EC
		public bool Period
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170082FD RID: 33533
		// (get) Token: 0x0601C196 RID: 115094 RVA: 0x003FB32C File Offset: 0x003F952C
		public float CheckPeriod
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170082FE RID: 33534
		// (get) Token: 0x0601C197 RID: 115095 RVA: 0x003FB370 File Offset: 0x003F9570
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601C198 RID: 115096 RVA: 0x003FB3AD File Offset: 0x003F95AD
		public static Offset<IFixAction> CreateIFixAction(FlatBufferBuilder builder, StringOffset TimingOffset = default(StringOffset), Offset<IConditionGroup> ConditionOffset = default(Offset<IConditionGroup>), VectorOffset ThenActionsOffset = default(VectorOffset), bool Period = false, float CheckPeriod = 0f, byte NullMask = 0)
		{
			builder.StartTable(6);
			IFixAction.AddCheckPeriod(builder, CheckPeriod);
			IFixAction.AddThenActions(builder, ThenActionsOffset);
			IFixAction.AddCondition(builder, ConditionOffset);
			IFixAction.AddTiming(builder, TimingOffset);
			IFixAction.AddNullMask(builder, NullMask);
			IFixAction.AddPeriod(builder, Period);
			return IFixAction.EndIFixAction(builder);
		}

		// Token: 0x0601C199 RID: 115097 RVA: 0x003FB3E9 File Offset: 0x003F95E9
		public static void StartIFixAction(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x0601C19A RID: 115098 RVA: 0x003FB3F2 File Offset: 0x003F95F2
		public static void AddTiming(FlatBufferBuilder builder, StringOffset timingOffset)
		{
			builder.AddOffset(0, timingOffset.Value, 0);
		}

		// Token: 0x0601C19B RID: 115099 RVA: 0x003FB402 File Offset: 0x003F9602
		public static void AddCondition(FlatBufferBuilder builder, Offset<IConditionGroup> conditionOffset)
		{
			builder.AddOffset(1, conditionOffset.Value, 0);
		}

		// Token: 0x0601C19C RID: 115100 RVA: 0x003FB412 File Offset: 0x003F9612
		public static void AddThenActions(FlatBufferBuilder builder, VectorOffset thenActionsOffset)
		{
			builder.AddOffset(2, thenActionsOffset.Value, 0);
		}

		// Token: 0x0601C19D RID: 115101 RVA: 0x003FB424 File Offset: 0x003F9624
		public static VectorOffset CreateThenActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601C19E RID: 115102 RVA: 0x003FB464 File Offset: 0x003F9664
		public static VectorOffset CreateThenActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601C19F RID: 115103 RVA: 0x003FB47E File Offset: 0x003F967E
		public static VectorOffset CreateThenActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601C1A0 RID: 115104 RVA: 0x003FB49C File Offset: 0x003F969C
		public static VectorOffset CreateThenActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601C1A1 RID: 115105 RVA: 0x003FB4B5 File Offset: 0x003F96B5
		public static void StartThenActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601C1A2 RID: 115106 RVA: 0x003FB4C0 File Offset: 0x003F96C0
		public static void AddPeriod(FlatBufferBuilder builder, bool period)
		{
			builder.AddBool(3, period, false);
		}

		// Token: 0x0601C1A3 RID: 115107 RVA: 0x003FB4CB File Offset: 0x003F96CB
		public static void AddCheckPeriod(FlatBufferBuilder builder, float checkPeriod)
		{
			builder.AddFloat(4, checkPeriod, 0.0);
		}

		// Token: 0x0601C1A4 RID: 115108 RVA: 0x003FB4DE File Offset: 0x003F96DE
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(5, nullMask, 0);
		}

		// Token: 0x0601C1A5 RID: 115109 RVA: 0x003FB4E9 File Offset: 0x003F96E9
		public static Offset<IFixAction> EndIFixAction(FlatBufferBuilder builder)
		{
			return new Offset<IFixAction>(builder.EndTable());
		}

		// Token: 0x0601C1A6 RID: 115110 RVA: 0x003FB4F8 File Offset: 0x003F96F8
		public IFixActionT UnPack()
		{
			IFixActionT fixActionT = new IFixActionT();
			this.UnPackTo(fixActionT);
			return fixActionT;
		}

		// Token: 0x0601C1A7 RID: 115111 RVA: 0x003FB514 File Offset: 0x003F9714
		public void UnPackTo(IFixActionT _o)
		{
			_o.Timing = this.Timing;
			_o.Condition = ((this.Condition != null) ? this.Condition.Value.UnPack() : null);
			_o.ThenActions = new List<IActionInfoT>();
			for (int i = 0; i < this.ThenActionsLength; i++)
			{
				_o.ThenActions.Add((this.ThenActions(i) != null) ? this.ThenActions(i).Value.UnPack() : null);
			}
			_o.Period = this.Period;
			_o.CheckPeriod = this.CheckPeriod;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0601C1A8 RID: 115112 RVA: 0x003FB5D4 File Offset: 0x003F97D4
		public static Offset<IFixAction> Pack(FlatBufferBuilder builder, IFixActionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFixAction>);
			}
			StringOffset timingOffset = (_o.Timing == null) ? default(StringOffset) : builder.CreateString(_o.Timing);
			Offset<IConditionGroup> conditionOffset = (_o.Condition == null) ? default(Offset<IConditionGroup>) : IConditionGroup.Pack(builder, _o.Condition);
			VectorOffset thenActionsOffset = default(VectorOffset);
			if (_o.ThenActions != null)
			{
				Offset<IActionInfo>[] array = new Offset<IActionInfo>[_o.ThenActions.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IActionInfo.Pack(builder, _o.ThenActions[i]);
				}
				thenActionsOffset = IFixAction.CreateThenActionsVector(builder, array);
			}
			return IFixAction.CreateIFixAction(builder, timingOffset, conditionOffset, thenActionsOffset, _o.Period, _o.CheckPeriod, _o.NullMask);
		}

		// Token: 0x0400CA4E RID: 51790
		private Table __p;
	}
}
