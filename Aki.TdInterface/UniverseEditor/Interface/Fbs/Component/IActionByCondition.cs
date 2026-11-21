using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005352 RID: 21330
	public struct IActionByCondition : IFlatbufferObject
	{
		// Token: 0x17009696 RID: 38550
		// (get) Token: 0x0602132F RID: 135983 RVA: 0x00494E3E File Offset: 0x0049303E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06021330 RID: 135984 RVA: 0x00494E4B File Offset: 0x0049304B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06021331 RID: 135985 RVA: 0x00494E54 File Offset: 0x00493054
		public static IActionByCondition GetRootAsIActionByCondition(ByteBuffer _bb)
		{
			return IActionByCondition.GetRootAsIActionByCondition(_bb, default(IActionByCondition));
		}

		// Token: 0x06021332 RID: 135986 RVA: 0x00494E70 File Offset: 0x00493070
		public static IActionByCondition GetRootAsIActionByCondition(ByteBuffer _bb, IActionByCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06021333 RID: 135987 RVA: 0x00494E8D File Offset: 0x0049308D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06021334 RID: 135988 RVA: 0x00494E9C File Offset: 0x0049309C
		public IActionByCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009697 RID: 38551
		// (get) Token: 0x06021335 RID: 135989 RVA: 0x00494EAC File Offset: 0x004930AC
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

		// Token: 0x06021336 RID: 135990 RVA: 0x00494F0C File Offset: 0x0049310C
		public IActionInfo? ActiveActions(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17009698 RID: 38552
		// (get) Token: 0x06021337 RID: 135991 RVA: 0x00494F6C File Offset: 0x0049316C
		public int ActiveActionsLength
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

		// Token: 0x06021338 RID: 135992 RVA: 0x00494F97 File Offset: 0x00493197
		public static Offset<IActionByCondition> CreateIActionByCondition(FlatBufferBuilder builder, Offset<IConditionGroup> ConditionOffset = default(Offset<IConditionGroup>), VectorOffset ActiveActionsOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			IActionByCondition.AddActiveActions(builder, ActiveActionsOffset);
			IActionByCondition.AddCondition(builder, ConditionOffset);
			return IActionByCondition.EndIActionByCondition(builder);
		}

		// Token: 0x06021339 RID: 135993 RVA: 0x00494FB4 File Offset: 0x004931B4
		public static void StartIActionByCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602133A RID: 135994 RVA: 0x00494FBD File Offset: 0x004931BD
		public static void AddCondition(FlatBufferBuilder builder, Offset<IConditionGroup> conditionOffset)
		{
			builder.AddOffset(0, conditionOffset.Value, 0);
		}

		// Token: 0x0602133B RID: 135995 RVA: 0x00494FCD File Offset: 0x004931CD
		public static void AddActiveActions(FlatBufferBuilder builder, VectorOffset activeActionsOffset)
		{
			builder.AddOffset(1, activeActionsOffset.Value, 0);
		}

		// Token: 0x0602133C RID: 135996 RVA: 0x00494FE0 File Offset: 0x004931E0
		public static VectorOffset CreateActiveActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0602133D RID: 135997 RVA: 0x00495020 File Offset: 0x00493220
		public static VectorOffset CreateActiveActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602133E RID: 135998 RVA: 0x0049503A File Offset: 0x0049323A
		public static VectorOffset CreateActiveActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602133F RID: 135999 RVA: 0x00495058 File Offset: 0x00493258
		public static VectorOffset CreateActiveActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06021340 RID: 136000 RVA: 0x00495071 File Offset: 0x00493271
		public static void StartActiveActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06021341 RID: 136001 RVA: 0x0049507C File Offset: 0x0049327C
		public static Offset<IActionByCondition> EndIActionByCondition(FlatBufferBuilder builder)
		{
			return new Offset<IActionByCondition>(builder.EndTable());
		}

		// Token: 0x06021342 RID: 136002 RVA: 0x0049508C File Offset: 0x0049328C
		public IActionByConditionT UnPack()
		{
			IActionByConditionT actionByConditionT = new IActionByConditionT();
			this.UnPackTo(actionByConditionT);
			return actionByConditionT;
		}

		// Token: 0x06021343 RID: 136003 RVA: 0x004950A8 File Offset: 0x004932A8
		public void UnPackTo(IActionByConditionT _o)
		{
			_o.Condition = ((this.Condition != null) ? this.Condition.Value.UnPack() : null);
			_o.ActiveActions = new List<IActionInfoT>();
			for (int i = 0; i < this.ActiveActionsLength; i++)
			{
				_o.ActiveActions.Add((this.ActiveActions(i) != null) ? this.ActiveActions(i).Value.UnPack() : null);
			}
		}

		// Token: 0x06021344 RID: 136004 RVA: 0x00495138 File Offset: 0x00493338
		public static Offset<IActionByCondition> Pack(FlatBufferBuilder builder, IActionByConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IActionByCondition>);
			}
			Offset<IConditionGroup> conditionOffset = (_o.Condition == null) ? default(Offset<IConditionGroup>) : IConditionGroup.Pack(builder, _o.Condition);
			VectorOffset activeActionsOffset = default(VectorOffset);
			if (_o.ActiveActions != null)
			{
				Offset<IActionInfo>[] array = new Offset<IActionInfo>[_o.ActiveActions.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IActionInfo.Pack(builder, _o.ActiveActions[i]);
				}
				activeActionsOffset = IActionByCondition.CreateActiveActionsVector(builder, array);
			}
			return IActionByCondition.CreateIActionByCondition(builder, conditionOffset, activeActionsOffset);
		}

		// Token: 0x0400E755 RID: 59221
		private Table __p;
	}
}
