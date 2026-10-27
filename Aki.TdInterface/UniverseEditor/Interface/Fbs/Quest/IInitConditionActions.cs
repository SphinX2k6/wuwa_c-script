using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003EB4 RID: 16052
	public struct IInitConditionActions : IFlatbufferObject
	{
		// Token: 0x17006F68 RID: 28520
		// (get) Token: 0x06016AB5 RID: 92853 RVA: 0x00345E5A File Offset: 0x0034405A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06016AB6 RID: 92854 RVA: 0x00345E67 File Offset: 0x00344067
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06016AB7 RID: 92855 RVA: 0x00345E70 File Offset: 0x00344070
		public static IInitConditionActions GetRootAsIInitConditionActions(ByteBuffer _bb)
		{
			return IInitConditionActions.GetRootAsIInitConditionActions(_bb, default(IInitConditionActions));
		}

		// Token: 0x06016AB8 RID: 92856 RVA: 0x00345E8C File Offset: 0x0034408C
		public static IInitConditionActions GetRootAsIInitConditionActions(ByteBuffer _bb, IInitConditionActions obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06016AB9 RID: 92857 RVA: 0x00345EA9 File Offset: 0x003440A9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06016ABA RID: 92858 RVA: 0x00345EB8 File Offset: 0x003440B8
		public IInitConditionActions __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006F69 RID: 28521
		// (get) Token: 0x06016ABB RID: 92859 RVA: 0x00345EC8 File Offset: 0x003440C8
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

		// Token: 0x06016ABC RID: 92860 RVA: 0x00345F28 File Offset: 0x00344128
		public IActionInfo? Action(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17006F6A RID: 28522
		// (get) Token: 0x06016ABD RID: 92861 RVA: 0x00345F88 File Offset: 0x00344188
		public int ActionLength
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

		// Token: 0x06016ABE RID: 92862 RVA: 0x00345FB3 File Offset: 0x003441B3
		public static Offset<IInitConditionActions> CreateIInitConditionActions(FlatBufferBuilder builder, Offset<IConditionGroup> ConditionOffset = default(Offset<IConditionGroup>), VectorOffset ActionOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			IInitConditionActions.AddAction(builder, ActionOffset);
			IInitConditionActions.AddCondition(builder, ConditionOffset);
			return IInitConditionActions.EndIInitConditionActions(builder);
		}

		// Token: 0x06016ABF RID: 92863 RVA: 0x00345FD0 File Offset: 0x003441D0
		public static void StartIInitConditionActions(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06016AC0 RID: 92864 RVA: 0x00345FD9 File Offset: 0x003441D9
		public static void AddCondition(FlatBufferBuilder builder, Offset<IConditionGroup> conditionOffset)
		{
			builder.AddOffset(0, conditionOffset.Value, 0);
		}

		// Token: 0x06016AC1 RID: 92865 RVA: 0x00345FE9 File Offset: 0x003441E9
		public static void AddAction(FlatBufferBuilder builder, VectorOffset actionOffset)
		{
			builder.AddOffset(1, actionOffset.Value, 0);
		}

		// Token: 0x06016AC2 RID: 92866 RVA: 0x00345FFC File Offset: 0x003441FC
		public static VectorOffset CreateActionVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06016AC3 RID: 92867 RVA: 0x0034603C File Offset: 0x0034423C
		public static VectorOffset CreateActionVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06016AC4 RID: 92868 RVA: 0x00346056 File Offset: 0x00344256
		public static VectorOffset CreateActionVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06016AC5 RID: 92869 RVA: 0x00346074 File Offset: 0x00344274
		public static VectorOffset CreateActionVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06016AC6 RID: 92870 RVA: 0x0034608D File Offset: 0x0034428D
		public static void StartActionVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06016AC7 RID: 92871 RVA: 0x00346098 File Offset: 0x00344298
		public static Offset<IInitConditionActions> EndIInitConditionActions(FlatBufferBuilder builder)
		{
			return new Offset<IInitConditionActions>(builder.EndTable());
		}

		// Token: 0x06016AC8 RID: 92872 RVA: 0x003460A8 File Offset: 0x003442A8
		public IInitConditionActionsT UnPack()
		{
			IInitConditionActionsT initConditionActionsT = new IInitConditionActionsT();
			this.UnPackTo(initConditionActionsT);
			return initConditionActionsT;
		}

		// Token: 0x06016AC9 RID: 92873 RVA: 0x003460C4 File Offset: 0x003442C4
		public void UnPackTo(IInitConditionActionsT _o)
		{
			_o.Condition = ((this.Condition != null) ? this.Condition.Value.UnPack() : null);
			_o.Action = new List<IActionInfoT>();
			for (int i = 0; i < this.ActionLength; i++)
			{
				_o.Action.Add((this.Action(i) != null) ? this.Action(i).Value.UnPack() : null);
			}
		}

		// Token: 0x06016ACA RID: 92874 RVA: 0x00346154 File Offset: 0x00344354
		public static Offset<IInitConditionActions> Pack(FlatBufferBuilder builder, IInitConditionActionsT _o)
		{
			if (_o == null)
			{
				return default(Offset<IInitConditionActions>);
			}
			Offset<IConditionGroup> conditionOffset = (_o.Condition == null) ? default(Offset<IConditionGroup>) : IConditionGroup.Pack(builder, _o.Condition);
			VectorOffset actionOffset = default(VectorOffset);
			if (_o.Action != null)
			{
				Offset<IActionInfo>[] array = new Offset<IActionInfo>[_o.Action.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IActionInfo.Pack(builder, _o.Action[i]);
				}
				actionOffset = IInitConditionActions.CreateActionVector(builder, array);
			}
			return IInitConditionActions.CreateIInitConditionActions(builder, conditionOffset, actionOffset);
		}

		// Token: 0x0400B884 RID: 47236
		private Table __p;
	}
}
