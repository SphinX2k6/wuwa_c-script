using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Aki.UniverseEditor.Interface.Fbs.Shape;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020053B3 RID: 21427
	public struct IHookFetchComponent : IFlatbufferObject
	{
		// Token: 0x17009D76 RID: 40310
		// (get) Token: 0x060231B2 RID: 143794 RVA: 0x004DC092 File Offset: 0x004DA292
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060231B3 RID: 143795 RVA: 0x004DC09F File Offset: 0x004DA29F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060231B4 RID: 143796 RVA: 0x004DC0A8 File Offset: 0x004DA2A8
		public static IHookFetchComponent GetRootAsIHookFetchComponent(ByteBuffer _bb)
		{
			return IHookFetchComponent.GetRootAsIHookFetchComponent(_bb, default(IHookFetchComponent));
		}

		// Token: 0x060231B5 RID: 143797 RVA: 0x004DC0C4 File Offset: 0x004DA2C4
		public static IHookFetchComponent GetRootAsIHookFetchComponent(ByteBuffer _bb, IHookFetchComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060231B6 RID: 143798 RVA: 0x004DC0E1 File Offset: 0x004DA2E1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060231B7 RID: 143799 RVA: 0x004DC0F0 File Offset: 0x004DA2F0
		public IHookFetchComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009D77 RID: 40311
		// (get) Token: 0x060231B8 RID: 143800 RVA: 0x004DC100 File Offset: 0x004DA300
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17009D78 RID: 40312
		// (get) Token: 0x060231B9 RID: 143801 RVA: 0x004DC140 File Offset: 0x004DA340
		public ISphereTriggerShape? Range
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new ISphereTriggerShape?(default(ISphereTriggerShape).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17009D79 RID: 40313
		// (get) Token: 0x060231BA RID: 143802 RVA: 0x004DC1A0 File Offset: 0x004DA3A0
		public bool UseRangeComponent
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17009D7A RID: 40314
		// (get) Token: 0x060231BB RID: 143803 RVA: 0x004DC1E0 File Offset: 0x004DA3E0
		public IHookFetchMoveUniform? MoveMode
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return new IHookFetchMoveUniform?(default(IHookFetchMoveUniform).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17009D7B RID: 40315
		// (get) Token: 0x060231BC RID: 143804 RVA: 0x004DC240 File Offset: 0x004DA440
		public IConditionGroup? HookEnableCondition
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return null;
				}
				return new IConditionGroup?(default(IConditionGroup).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x060231BD RID: 143805 RVA: 0x004DC2A0 File Offset: 0x004DA4A0
		public IActionInfo? HookActions(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17009D7C RID: 40316
		// (get) Token: 0x060231BE RID: 143806 RVA: 0x004DC304 File Offset: 0x004DA504
		public int HookActionsLength
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x060231BF RID: 143807 RVA: 0x004DC330 File Offset: 0x004DA530
		public IActionInfo? FinishActions(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17009D7D RID: 40317
		// (get) Token: 0x060231C0 RID: 143808 RVA: 0x004DC394 File Offset: 0x004DA594
		public int FinishActionsLength
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x17009D7E RID: 40318
		// (get) Token: 0x060231C1 RID: 143809 RVA: 0x004DC3C0 File Offset: 0x004DA5C0
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060231C2 RID: 143810 RVA: 0x004DC400 File Offset: 0x004DA600
		public static Offset<IHookFetchComponent> CreateIHookFetchComponent(FlatBufferBuilder builder, bool Disabled = false, Offset<ISphereTriggerShape> RangeOffset = default(Offset<ISphereTriggerShape>), bool UseRangeComponent = false, Offset<IHookFetchMoveUniform> MoveModeOffset = default(Offset<IHookFetchMoveUniform>), Offset<IConditionGroup> HookEnableConditionOffset = default(Offset<IConditionGroup>), VectorOffset HookActionsOffset = default(VectorOffset), VectorOffset FinishActionsOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(8);
			IHookFetchComponent.AddFinishActions(builder, FinishActionsOffset);
			IHookFetchComponent.AddHookActions(builder, HookActionsOffset);
			IHookFetchComponent.AddHookEnableCondition(builder, HookEnableConditionOffset);
			IHookFetchComponent.AddMoveMode(builder, MoveModeOffset);
			IHookFetchComponent.AddRange(builder, RangeOffset);
			IHookFetchComponent.AddNullMask(builder, NullMask);
			IHookFetchComponent.AddUseRangeComponent(builder, UseRangeComponent);
			IHookFetchComponent.AddDisabled(builder, Disabled);
			return IHookFetchComponent.EndIHookFetchComponent(builder);
		}

		// Token: 0x060231C3 RID: 143811 RVA: 0x004DC457 File Offset: 0x004DA657
		public static void StartIHookFetchComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(8);
		}

		// Token: 0x060231C4 RID: 143812 RVA: 0x004DC460 File Offset: 0x004DA660
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x060231C5 RID: 143813 RVA: 0x004DC46B File Offset: 0x004DA66B
		public static void AddRange(FlatBufferBuilder builder, Offset<ISphereTriggerShape> rangeOffset)
		{
			builder.AddOffset(1, rangeOffset.Value, 0);
		}

		// Token: 0x060231C6 RID: 143814 RVA: 0x004DC47B File Offset: 0x004DA67B
		public static void AddUseRangeComponent(FlatBufferBuilder builder, bool useRangeComponent)
		{
			builder.AddBool(2, useRangeComponent, false);
		}

		// Token: 0x060231C7 RID: 143815 RVA: 0x004DC486 File Offset: 0x004DA686
		public static void AddMoveMode(FlatBufferBuilder builder, Offset<IHookFetchMoveUniform> moveModeOffset)
		{
			builder.AddOffset(3, moveModeOffset.Value, 0);
		}

		// Token: 0x060231C8 RID: 143816 RVA: 0x004DC496 File Offset: 0x004DA696
		public static void AddHookEnableCondition(FlatBufferBuilder builder, Offset<IConditionGroup> hookEnableConditionOffset)
		{
			builder.AddOffset(4, hookEnableConditionOffset.Value, 0);
		}

		// Token: 0x060231C9 RID: 143817 RVA: 0x004DC4A6 File Offset: 0x004DA6A6
		public static void AddHookActions(FlatBufferBuilder builder, VectorOffset hookActionsOffset)
		{
			builder.AddOffset(5, hookActionsOffset.Value, 0);
		}

		// Token: 0x060231CA RID: 143818 RVA: 0x004DC4B8 File Offset: 0x004DA6B8
		public static VectorOffset CreateHookActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x060231CB RID: 143819 RVA: 0x004DC4F8 File Offset: 0x004DA6F8
		public static VectorOffset CreateHookActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x060231CC RID: 143820 RVA: 0x004DC512 File Offset: 0x004DA712
		public static VectorOffset CreateHookActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x060231CD RID: 143821 RVA: 0x004DC530 File Offset: 0x004DA730
		public static VectorOffset CreateHookActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060231CE RID: 143822 RVA: 0x004DC549 File Offset: 0x004DA749
		public static void StartHookActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060231CF RID: 143823 RVA: 0x004DC554 File Offset: 0x004DA754
		public static void AddFinishActions(FlatBufferBuilder builder, VectorOffset finishActionsOffset)
		{
			builder.AddOffset(6, finishActionsOffset.Value, 0);
		}

		// Token: 0x060231D0 RID: 143824 RVA: 0x004DC564 File Offset: 0x004DA764
		public static VectorOffset CreateFinishActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x060231D1 RID: 143825 RVA: 0x004DC5A4 File Offset: 0x004DA7A4
		public static VectorOffset CreateFinishActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x060231D2 RID: 143826 RVA: 0x004DC5BE File Offset: 0x004DA7BE
		public static VectorOffset CreateFinishActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x060231D3 RID: 143827 RVA: 0x004DC5DC File Offset: 0x004DA7DC
		public static VectorOffset CreateFinishActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060231D4 RID: 143828 RVA: 0x004DC5F5 File Offset: 0x004DA7F5
		public static void StartFinishActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060231D5 RID: 143829 RVA: 0x004DC600 File Offset: 0x004DA800
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(7, nullMask, 0);
		}

		// Token: 0x060231D6 RID: 143830 RVA: 0x004DC60B File Offset: 0x004DA80B
		public static Offset<IHookFetchComponent> EndIHookFetchComponent(FlatBufferBuilder builder)
		{
			return new Offset<IHookFetchComponent>(builder.EndTable());
		}

		// Token: 0x060231D7 RID: 143831 RVA: 0x004DC618 File Offset: 0x004DA818
		public IHookFetchComponentT UnPack()
		{
			IHookFetchComponentT hookFetchComponentT = new IHookFetchComponentT();
			this.UnPackTo(hookFetchComponentT);
			return hookFetchComponentT;
		}

		// Token: 0x060231D8 RID: 143832 RVA: 0x004DC634 File Offset: 0x004DA834
		public void UnPackTo(IHookFetchComponentT _o)
		{
			_o.Disabled = this.Disabled;
			_o.Range = ((this.Range != null) ? this.Range.Value.UnPack() : null);
			_o.UseRangeComponent = this.UseRangeComponent;
			_o.MoveMode = ((this.MoveMode != null) ? this.MoveMode.Value.UnPack() : null);
			_o.HookEnableCondition = ((this.HookEnableCondition != null) ? this.HookEnableCondition.Value.UnPack() : null);
			_o.HookActions = new List<IActionInfoT>();
			for (int i = 0; i < this.HookActionsLength; i++)
			{
				_o.HookActions.Add((this.HookActions(i) != null) ? this.HookActions(i).Value.UnPack() : null);
			}
			_o.FinishActions = new List<IActionInfoT>();
			for (int j = 0; j < this.FinishActionsLength; j++)
			{
				_o.FinishActions.Add((this.FinishActions(j) != null) ? this.FinishActions(j).Value.UnPack() : null);
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x060231D9 RID: 143833 RVA: 0x004DC7AC File Offset: 0x004DA9AC
		public static Offset<IHookFetchComponent> Pack(FlatBufferBuilder builder, IHookFetchComponentT _o)
		{
			if (_o == null)
			{
				return default(Offset<IHookFetchComponent>);
			}
			Offset<ISphereTriggerShape> rangeOffset = (_o.Range == null) ? default(Offset<ISphereTriggerShape>) : ISphereTriggerShape.Pack(builder, _o.Range);
			Offset<IHookFetchMoveUniform> moveModeOffset = (_o.MoveMode == null) ? default(Offset<IHookFetchMoveUniform>) : IHookFetchMoveUniform.Pack(builder, _o.MoveMode);
			Offset<IConditionGroup> hookEnableConditionOffset = (_o.HookEnableCondition == null) ? default(Offset<IConditionGroup>) : IConditionGroup.Pack(builder, _o.HookEnableCondition);
			VectorOffset hookActionsOffset = default(VectorOffset);
			if (_o.HookActions != null)
			{
				Offset<IActionInfo>[] array = new Offset<IActionInfo>[_o.HookActions.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IActionInfo.Pack(builder, _o.HookActions[i]);
				}
				hookActionsOffset = IHookFetchComponent.CreateHookActionsVector(builder, array);
			}
			VectorOffset finishActionsOffset = default(VectorOffset);
			if (_o.FinishActions != null)
			{
				Offset<IActionInfo>[] array2 = new Offset<IActionInfo>[_o.FinishActions.Count];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = IActionInfo.Pack(builder, _o.FinishActions[j]);
				}
				finishActionsOffset = IHookFetchComponent.CreateFinishActionsVector(builder, array2);
			}
			return IHookFetchComponent.CreateIHookFetchComponent(builder, _o.Disabled, rangeOffset, _o.UseRangeComponent, moveModeOffset, hookEnableConditionOffset, hookActionsOffset, finishActionsOffset, _o.NullMask);
		}

		// Token: 0x0400E5AD RID: 58797
		private Table __p;
	}
}
