using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Aki.UniverseEditor.Interface.Fbs.Shape;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005939 RID: 22841
	public struct IHookFetchComponent : IFlatbufferObject
	{
		// Token: 0x1700A5AE RID: 42414
		// (get) Token: 0x06025266 RID: 152166 RVA: 0x00518F66 File Offset: 0x00517166
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06025267 RID: 152167 RVA: 0x00518F73 File Offset: 0x00517173
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06025268 RID: 152168 RVA: 0x00518F7C File Offset: 0x0051717C
		public static IHookFetchComponent GetRootAsIHookFetchComponent(ByteBuffer _bb)
		{
			return IHookFetchComponent.GetRootAsIHookFetchComponent(_bb, default(IHookFetchComponent));
		}

		// Token: 0x06025269 RID: 152169 RVA: 0x00518F98 File Offset: 0x00517198
		public static IHookFetchComponent GetRootAsIHookFetchComponent(ByteBuffer _bb, IHookFetchComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602526A RID: 152170 RVA: 0x00518FB5 File Offset: 0x005171B5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602526B RID: 152171 RVA: 0x00518FC4 File Offset: 0x005171C4
		public IHookFetchComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A5AF RID: 42415
		// (get) Token: 0x0602526C RID: 152172 RVA: 0x00518FD4 File Offset: 0x005171D4
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700A5B0 RID: 42416
		// (get) Token: 0x0602526D RID: 152173 RVA: 0x00519014 File Offset: 0x00517214
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

		// Token: 0x1700A5B1 RID: 42417
		// (get) Token: 0x0602526E RID: 152174 RVA: 0x00519074 File Offset: 0x00517274
		public bool UseRangeComponent
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700A5B2 RID: 42418
		// (get) Token: 0x0602526F RID: 152175 RVA: 0x005190B4 File Offset: 0x005172B4
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

		// Token: 0x1700A5B3 RID: 42419
		// (get) Token: 0x06025270 RID: 152176 RVA: 0x00519114 File Offset: 0x00517314
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

		// Token: 0x06025271 RID: 152177 RVA: 0x00519174 File Offset: 0x00517374
		public IActionInfo? HookActions(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700A5B4 RID: 42420
		// (get) Token: 0x06025272 RID: 152178 RVA: 0x005191D8 File Offset: 0x005173D8
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

		// Token: 0x06025273 RID: 152179 RVA: 0x00519204 File Offset: 0x00517404
		public IActionInfo? FinishActions(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700A5B5 RID: 42421
		// (get) Token: 0x06025274 RID: 152180 RVA: 0x00519268 File Offset: 0x00517468
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

		// Token: 0x1700A5B6 RID: 42422
		// (get) Token: 0x06025275 RID: 152181 RVA: 0x00519294 File Offset: 0x00517494
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

		// Token: 0x06025276 RID: 152182 RVA: 0x005192D4 File Offset: 0x005174D4
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

		// Token: 0x06025277 RID: 152183 RVA: 0x0051932B File Offset: 0x0051752B
		public static void StartIHookFetchComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(8);
		}

		// Token: 0x06025278 RID: 152184 RVA: 0x00519334 File Offset: 0x00517534
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x06025279 RID: 152185 RVA: 0x0051933F File Offset: 0x0051753F
		public static void AddRange(FlatBufferBuilder builder, Offset<ISphereTriggerShape> rangeOffset)
		{
			builder.AddOffset(1, rangeOffset.Value, 0);
		}

		// Token: 0x0602527A RID: 152186 RVA: 0x0051934F File Offset: 0x0051754F
		public static void AddUseRangeComponent(FlatBufferBuilder builder, bool useRangeComponent)
		{
			builder.AddBool(2, useRangeComponent, false);
		}

		// Token: 0x0602527B RID: 152187 RVA: 0x0051935A File Offset: 0x0051755A
		public static void AddMoveMode(FlatBufferBuilder builder, Offset<IHookFetchMoveUniform> moveModeOffset)
		{
			builder.AddOffset(3, moveModeOffset.Value, 0);
		}

		// Token: 0x0602527C RID: 152188 RVA: 0x0051936A File Offset: 0x0051756A
		public static void AddHookEnableCondition(FlatBufferBuilder builder, Offset<IConditionGroup> hookEnableConditionOffset)
		{
			builder.AddOffset(4, hookEnableConditionOffset.Value, 0);
		}

		// Token: 0x0602527D RID: 152189 RVA: 0x0051937A File Offset: 0x0051757A
		public static void AddHookActions(FlatBufferBuilder builder, VectorOffset hookActionsOffset)
		{
			builder.AddOffset(5, hookActionsOffset.Value, 0);
		}

		// Token: 0x0602527E RID: 152190 RVA: 0x0051938C File Offset: 0x0051758C
		public static VectorOffset CreateHookActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0602527F RID: 152191 RVA: 0x005193CC File Offset: 0x005175CC
		public static VectorOffset CreateHookActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06025280 RID: 152192 RVA: 0x005193E6 File Offset: 0x005175E6
		public static VectorOffset CreateHookActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06025281 RID: 152193 RVA: 0x00519404 File Offset: 0x00517604
		public static VectorOffset CreateHookActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06025282 RID: 152194 RVA: 0x0051941D File Offset: 0x0051761D
		public static void StartHookActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06025283 RID: 152195 RVA: 0x00519428 File Offset: 0x00517628
		public static void AddFinishActions(FlatBufferBuilder builder, VectorOffset finishActionsOffset)
		{
			builder.AddOffset(6, finishActionsOffset.Value, 0);
		}

		// Token: 0x06025284 RID: 152196 RVA: 0x00519438 File Offset: 0x00517638
		public static VectorOffset CreateFinishActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06025285 RID: 152197 RVA: 0x00519478 File Offset: 0x00517678
		public static VectorOffset CreateFinishActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06025286 RID: 152198 RVA: 0x00519492 File Offset: 0x00517692
		public static VectorOffset CreateFinishActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06025287 RID: 152199 RVA: 0x005194B0 File Offset: 0x005176B0
		public static VectorOffset CreateFinishActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06025288 RID: 152200 RVA: 0x005194C9 File Offset: 0x005176C9
		public static void StartFinishActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06025289 RID: 152201 RVA: 0x005194D4 File Offset: 0x005176D4
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(7, nullMask, 0);
		}

		// Token: 0x0602528A RID: 152202 RVA: 0x005194DF File Offset: 0x005176DF
		public static Offset<IHookFetchComponent> EndIHookFetchComponent(FlatBufferBuilder builder)
		{
			return new Offset<IHookFetchComponent>(builder.EndTable());
		}

		// Token: 0x0602528B RID: 152203 RVA: 0x005194EC File Offset: 0x005176EC
		public IHookFetchComponentT UnPack()
		{
			IHookFetchComponentT hookFetchComponentT = new IHookFetchComponentT();
			this.UnPackTo(hookFetchComponentT);
			return hookFetchComponentT;
		}

		// Token: 0x0602528C RID: 152204 RVA: 0x00519508 File Offset: 0x00517708
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

		// Token: 0x0602528D RID: 152205 RVA: 0x00519680 File Offset: 0x00517880
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

		// Token: 0x0400F1DD RID: 61917
		private Table __p;
	}
}
