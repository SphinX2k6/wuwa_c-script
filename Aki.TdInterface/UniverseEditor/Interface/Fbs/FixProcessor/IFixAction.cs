using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.FixProcessor
{
	// Token: 0x02004BBC RID: 19388
	public struct IFixAction : IFlatbufferObject
	{
		// Token: 0x17008939 RID: 35129
		// (get) Token: 0x0601D95E RID: 121182 RVA: 0x004273DC File Offset: 0x004255DC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601D95F RID: 121183 RVA: 0x004273E9 File Offset: 0x004255E9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601D960 RID: 121184 RVA: 0x004273F0 File Offset: 0x004255F0
		public static IFixAction GetRootAsIFixAction(ByteBuffer _bb)
		{
			return IFixAction.GetRootAsIFixAction(_bb, default(IFixAction));
		}

		// Token: 0x0601D961 RID: 121185 RVA: 0x0042740C File Offset: 0x0042560C
		public static IFixAction GetRootAsIFixAction(ByteBuffer _bb, IFixAction obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601D962 RID: 121186 RVA: 0x00427429 File Offset: 0x00425629
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601D963 RID: 121187 RVA: 0x00427438 File Offset: 0x00425638
		public IFixAction __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700893A RID: 35130
		// (get) Token: 0x0601D964 RID: 121188 RVA: 0x00427448 File Offset: 0x00425648
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

		// Token: 0x0601D965 RID: 121189 RVA: 0x0042747F File Offset: 0x0042567F
		public Span<byte> GetTimingBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0601D966 RID: 121190 RVA: 0x0042748E File Offset: 0x0042568E
		public byte[] GetTimingArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x1700893B RID: 35131
		// (get) Token: 0x0601D967 RID: 121191 RVA: 0x0042749C File Offset: 0x0042569C
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

		// Token: 0x0601D968 RID: 121192 RVA: 0x004274FC File Offset: 0x004256FC
		public IActionInfo? ThenActions(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700893C RID: 35132
		// (get) Token: 0x0601D969 RID: 121193 RVA: 0x0042755C File Offset: 0x0042575C
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

		// Token: 0x1700893D RID: 35133
		// (get) Token: 0x0601D96A RID: 121194 RVA: 0x00427588 File Offset: 0x00425788
		public bool Period
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700893E RID: 35134
		// (get) Token: 0x0601D96B RID: 121195 RVA: 0x004275C8 File Offset: 0x004257C8
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

		// Token: 0x1700893F RID: 35135
		// (get) Token: 0x0601D96C RID: 121196 RVA: 0x0042760C File Offset: 0x0042580C
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

		// Token: 0x0601D96D RID: 121197 RVA: 0x00427649 File Offset: 0x00425849
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

		// Token: 0x0601D96E RID: 121198 RVA: 0x00427685 File Offset: 0x00425885
		public static void StartIFixAction(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x0601D96F RID: 121199 RVA: 0x0042768E File Offset: 0x0042588E
		public static void AddTiming(FlatBufferBuilder builder, StringOffset timingOffset)
		{
			builder.AddOffset(0, timingOffset.Value, 0);
		}

		// Token: 0x0601D970 RID: 121200 RVA: 0x0042769E File Offset: 0x0042589E
		public static void AddCondition(FlatBufferBuilder builder, Offset<IConditionGroup> conditionOffset)
		{
			builder.AddOffset(1, conditionOffset.Value, 0);
		}

		// Token: 0x0601D971 RID: 121201 RVA: 0x004276AE File Offset: 0x004258AE
		public static void AddThenActions(FlatBufferBuilder builder, VectorOffset thenActionsOffset)
		{
			builder.AddOffset(2, thenActionsOffset.Value, 0);
		}

		// Token: 0x0601D972 RID: 121202 RVA: 0x004276C0 File Offset: 0x004258C0
		public static VectorOffset CreateThenActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601D973 RID: 121203 RVA: 0x00427700 File Offset: 0x00425900
		public static VectorOffset CreateThenActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601D974 RID: 121204 RVA: 0x0042771A File Offset: 0x0042591A
		public static VectorOffset CreateThenActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601D975 RID: 121205 RVA: 0x00427738 File Offset: 0x00425938
		public static VectorOffset CreateThenActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601D976 RID: 121206 RVA: 0x00427751 File Offset: 0x00425951
		public static void StartThenActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601D977 RID: 121207 RVA: 0x0042775C File Offset: 0x0042595C
		public static void AddPeriod(FlatBufferBuilder builder, bool period)
		{
			builder.AddBool(3, period, false);
		}

		// Token: 0x0601D978 RID: 121208 RVA: 0x00427767 File Offset: 0x00425967
		public static void AddCheckPeriod(FlatBufferBuilder builder, float checkPeriod)
		{
			builder.AddFloat(4, checkPeriod, 0.0);
		}

		// Token: 0x0601D979 RID: 121209 RVA: 0x0042777A File Offset: 0x0042597A
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(5, nullMask, 0);
		}

		// Token: 0x0601D97A RID: 121210 RVA: 0x00427785 File Offset: 0x00425985
		public static Offset<IFixAction> EndIFixAction(FlatBufferBuilder builder)
		{
			return new Offset<IFixAction>(builder.EndTable());
		}

		// Token: 0x0601D97B RID: 121211 RVA: 0x00427794 File Offset: 0x00425994
		public IFixActionT UnPack()
		{
			IFixActionT fixActionT = new IFixActionT();
			this.UnPackTo(fixActionT);
			return fixActionT;
		}

		// Token: 0x0601D97C RID: 121212 RVA: 0x004277B0 File Offset: 0x004259B0
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

		// Token: 0x0601D97D RID: 121213 RVA: 0x00427870 File Offset: 0x00425A70
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

		// Token: 0x0400D47D RID: 54397
		private Table __p;
	}
}
