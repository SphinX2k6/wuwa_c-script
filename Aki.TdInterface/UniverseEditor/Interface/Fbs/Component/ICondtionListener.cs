using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200555C RID: 21852
	public struct ICondtionListener : IFlatbufferObject
	{
		// Token: 0x17009C40 RID: 40000
		// (get) Token: 0x06022AEF RID: 142063 RVA: 0x004C706C File Offset: 0x004C526C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06022AF0 RID: 142064 RVA: 0x004C7079 File Offset: 0x004C5279
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06022AF1 RID: 142065 RVA: 0x004C7080 File Offset: 0x004C5280
		public static ICondtionListener GetRootAsICondtionListener(ByteBuffer _bb)
		{
			return ICondtionListener.GetRootAsICondtionListener(_bb, default(ICondtionListener));
		}

		// Token: 0x06022AF2 RID: 142066 RVA: 0x004C709C File Offset: 0x004C529C
		public static ICondtionListener GetRootAsICondtionListener(ByteBuffer _bb, ICondtionListener obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06022AF3 RID: 142067 RVA: 0x004C70B9 File Offset: 0x004C52B9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06022AF4 RID: 142068 RVA: 0x004C70C8 File Offset: 0x004C52C8
		public ICondtionListener __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009C41 RID: 40001
		// (get) Token: 0x06022AF5 RID: 142069 RVA: 0x004C70D8 File Offset: 0x004C52D8
		public IConditionGroup? Condition
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return new IConditionGroup?(default(IConditionGroup).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x06022AF6 RID: 142070 RVA: 0x004C7138 File Offset: 0x004C5338
		public IActionInfo? Actions(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17009C42 RID: 40002
		// (get) Token: 0x06022AF7 RID: 142071 RVA: 0x004C7198 File Offset: 0x004C5398
		public int ActionsLength
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

		// Token: 0x17009C43 RID: 40003
		// (get) Token: 0x06022AF8 RID: 142072 RVA: 0x004C71C4 File Offset: 0x004C53C4
		public bool PendingConditionAvailable
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x06022AF9 RID: 142073 RVA: 0x004C7204 File Offset: 0x004C5404
		public IConditionAction? ConditionAction(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new IConditionAction?(default(IConditionAction).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17009C44 RID: 40004
		// (get) Token: 0x06022AFA RID: 142074 RVA: 0x004C7268 File Offset: 0x004C5468
		public int ConditionActionLength
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x17009C45 RID: 40005
		// (get) Token: 0x06022AFB RID: 142075 RVA: 0x004C7294 File Offset: 0x004C5494
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06022AFC RID: 142076 RVA: 0x004C72D1 File Offset: 0x004C54D1
		public static Offset<ICondtionListener> CreateICondtionListener(FlatBufferBuilder builder, Offset<IConditionGroup> ConditionOffset = default(Offset<IConditionGroup>), VectorOffset ActionsOffset = default(VectorOffset), bool PendingConditionAvailable = false, VectorOffset ConditionActionOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(5);
			ICondtionListener.AddConditionAction(builder, ConditionActionOffset);
			ICondtionListener.AddActions(builder, ActionsOffset);
			ICondtionListener.AddCondition(builder, ConditionOffset);
			ICondtionListener.AddNullMask(builder, NullMask);
			ICondtionListener.AddPendingConditionAvailable(builder, PendingConditionAvailable);
			return ICondtionListener.EndICondtionListener(builder);
		}

		// Token: 0x06022AFD RID: 142077 RVA: 0x004C7305 File Offset: 0x004C5505
		public static void StartICondtionListener(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x06022AFE RID: 142078 RVA: 0x004C730E File Offset: 0x004C550E
		public static void AddCondition(FlatBufferBuilder builder, Offset<IConditionGroup> conditionOffset)
		{
			builder.AddOffset(0, conditionOffset.Value, 0);
		}

		// Token: 0x06022AFF RID: 142079 RVA: 0x004C731E File Offset: 0x004C551E
		public static void AddActions(FlatBufferBuilder builder, VectorOffset actionsOffset)
		{
			builder.AddOffset(1, actionsOffset.Value, 0);
		}

		// Token: 0x06022B00 RID: 142080 RVA: 0x004C7330 File Offset: 0x004C5530
		public static VectorOffset CreateActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06022B01 RID: 142081 RVA: 0x004C7370 File Offset: 0x004C5570
		public static VectorOffset CreateActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06022B02 RID: 142082 RVA: 0x004C738A File Offset: 0x004C558A
		public static VectorOffset CreateActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06022B03 RID: 142083 RVA: 0x004C73A8 File Offset: 0x004C55A8
		public static VectorOffset CreateActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06022B04 RID: 142084 RVA: 0x004C73C1 File Offset: 0x004C55C1
		public static void StartActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06022B05 RID: 142085 RVA: 0x004C73CC File Offset: 0x004C55CC
		public static void AddPendingConditionAvailable(FlatBufferBuilder builder, bool pendingConditionAvailable)
		{
			builder.AddBool(2, pendingConditionAvailable, false);
		}

		// Token: 0x06022B06 RID: 142086 RVA: 0x004C73D7 File Offset: 0x004C55D7
		public static void AddConditionAction(FlatBufferBuilder builder, VectorOffset conditionActionOffset)
		{
			builder.AddOffset(3, conditionActionOffset.Value, 0);
		}

		// Token: 0x06022B07 RID: 142087 RVA: 0x004C73E8 File Offset: 0x004C55E8
		public static VectorOffset CreateConditionActionVector(FlatBufferBuilder builder, Offset<IConditionAction>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06022B08 RID: 142088 RVA: 0x004C7428 File Offset: 0x004C5628
		public static VectorOffset CreateConditionActionVectorBlock(FlatBufferBuilder builder, Offset<IConditionAction>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IConditionAction>>(data);
			return builder.EndVector();
		}

		// Token: 0x06022B09 RID: 142089 RVA: 0x004C7442 File Offset: 0x004C5642
		public static VectorOffset CreateConditionActionVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IConditionAction>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IConditionAction>>(data);
			return builder.EndVector();
		}

		// Token: 0x06022B0A RID: 142090 RVA: 0x004C7460 File Offset: 0x004C5660
		public static VectorOffset CreateConditionActionVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IConditionAction>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06022B0B RID: 142091 RVA: 0x004C7479 File Offset: 0x004C5679
		public static void StartConditionActionVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06022B0C RID: 142092 RVA: 0x004C7484 File Offset: 0x004C5684
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x06022B0D RID: 142093 RVA: 0x004C748F File Offset: 0x004C568F
		public static Offset<ICondtionListener> EndICondtionListener(FlatBufferBuilder builder)
		{
			return new Offset<ICondtionListener>(builder.EndTable());
		}

		// Token: 0x06022B0E RID: 142094 RVA: 0x004C749C File Offset: 0x004C569C
		public ICondtionListenerT UnPack()
		{
			ICondtionListenerT condtionListenerT = new ICondtionListenerT();
			this.UnPackTo(condtionListenerT);
			return condtionListenerT;
		}

		// Token: 0x06022B0F RID: 142095 RVA: 0x004C74B8 File Offset: 0x004C56B8
		public void UnPackTo(ICondtionListenerT _o)
		{
			_o.Condition = ((this.Condition != null) ? this.Condition.Value.UnPack() : null);
			_o.Actions = new List<IActionInfoT>();
			for (int i = 0; i < this.ActionsLength; i++)
			{
				_o.Actions.Add((this.Actions(i) != null) ? this.Actions(i).Value.UnPack() : null);
			}
			_o.PendingConditionAvailable = this.PendingConditionAvailable;
			_o.ConditionAction = new List<IConditionActionT>();
			for (int j = 0; j < this.ConditionActionLength; j++)
			{
				_o.ConditionAction.Add((this.ConditionAction(j) != null) ? this.ConditionAction(j).Value.UnPack() : null);
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06022B10 RID: 142096 RVA: 0x004C75BC File Offset: 0x004C57BC
		public static Offset<ICondtionListener> Pack(FlatBufferBuilder builder, ICondtionListenerT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICondtionListener>);
			}
			Offset<IConditionGroup> conditionOffset = (_o.Condition == null) ? default(Offset<IConditionGroup>) : IConditionGroup.Pack(builder, _o.Condition);
			VectorOffset actionsOffset = default(VectorOffset);
			if (_o.Actions != null)
			{
				Offset<IActionInfo>[] array = new Offset<IActionInfo>[_o.Actions.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IActionInfo.Pack(builder, _o.Actions[i]);
				}
				actionsOffset = ICondtionListener.CreateActionsVector(builder, array);
			}
			VectorOffset conditionActionOffset = default(VectorOffset);
			if (_o.ConditionAction != null)
			{
				Offset<IConditionAction>[] array2 = new Offset<IConditionAction>[_o.ConditionAction.Count];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = IConditionAction.Pack(builder, _o.ConditionAction[j]);
				}
				conditionActionOffset = ICondtionListener.CreateConditionActionVector(builder, array2);
			}
			return ICondtionListener.CreateICondtionListener(builder, conditionOffset, actionsOffset, _o.PendingConditionAvailable, conditionActionOffset, _o.NullMask);
		}

		// Token: 0x0400EBB0 RID: 60336
		private Table __p;
	}
}
