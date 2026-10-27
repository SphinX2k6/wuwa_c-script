using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200512F RID: 20783
	public struct IElementalMatchActions : IFlatbufferObject
	{
		// Token: 0x17009780 RID: 38784
		// (get) Token: 0x0602184E RID: 137294 RVA: 0x004A7773 File Offset: 0x004A5973
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602184F RID: 137295 RVA: 0x004A7780 File Offset: 0x004A5980
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06021850 RID: 137296 RVA: 0x004A7788 File Offset: 0x004A5988
		public static IElementalMatchActions GetRootAsIElementalMatchActions(ByteBuffer _bb)
		{
			return IElementalMatchActions.GetRootAsIElementalMatchActions(_bb, default(IElementalMatchActions));
		}

		// Token: 0x06021851 RID: 137297 RVA: 0x004A77A4 File Offset: 0x004A59A4
		public static IElementalMatchActions GetRootAsIElementalMatchActions(ByteBuffer _bb, IElementalMatchActions obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06021852 RID: 137298 RVA: 0x004A77C1 File Offset: 0x004A59C1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06021853 RID: 137299 RVA: 0x004A77D0 File Offset: 0x004A59D0
		public IElementalMatchActions __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009781 RID: 38785
		// (get) Token: 0x06021854 RID: 137300 RVA: 0x004A77E0 File Offset: 0x004A59E0
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

		// Token: 0x06021855 RID: 137301 RVA: 0x004A7840 File Offset: 0x004A5A40
		public IActionInfo? Actions(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17009782 RID: 38786
		// (get) Token: 0x06021856 RID: 137302 RVA: 0x004A78A0 File Offset: 0x004A5AA0
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

		// Token: 0x17009783 RID: 38787
		// (get) Token: 0x06021857 RID: 137303 RVA: 0x004A78CC File Offset: 0x004A5ACC
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06021858 RID: 137304 RVA: 0x004A7908 File Offset: 0x004A5B08
		public static Offset<IElementalMatchActions> CreateIElementalMatchActions(FlatBufferBuilder builder, Offset<IConditionGroup> ConditionOffset = default(Offset<IConditionGroup>), VectorOffset ActionsOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(3);
			IElementalMatchActions.AddActions(builder, ActionsOffset);
			IElementalMatchActions.AddCondition(builder, ConditionOffset);
			IElementalMatchActions.AddNullMask(builder, NullMask);
			return IElementalMatchActions.EndIElementalMatchActions(builder);
		}

		// Token: 0x06021859 RID: 137305 RVA: 0x004A792C File Offset: 0x004A5B2C
		public static void StartIElementalMatchActions(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0602185A RID: 137306 RVA: 0x004A7935 File Offset: 0x004A5B35
		public static void AddCondition(FlatBufferBuilder builder, Offset<IConditionGroup> conditionOffset)
		{
			builder.AddOffset(0, conditionOffset.Value, 0);
		}

		// Token: 0x0602185B RID: 137307 RVA: 0x004A7945 File Offset: 0x004A5B45
		public static void AddActions(FlatBufferBuilder builder, VectorOffset actionsOffset)
		{
			builder.AddOffset(1, actionsOffset.Value, 0);
		}

		// Token: 0x0602185C RID: 137308 RVA: 0x004A7958 File Offset: 0x004A5B58
		public static VectorOffset CreateActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0602185D RID: 137309 RVA: 0x004A7998 File Offset: 0x004A5B98
		public static VectorOffset CreateActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602185E RID: 137310 RVA: 0x004A79B2 File Offset: 0x004A5BB2
		public static VectorOffset CreateActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602185F RID: 137311 RVA: 0x004A79D0 File Offset: 0x004A5BD0
		public static VectorOffset CreateActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06021860 RID: 137312 RVA: 0x004A79E9 File Offset: 0x004A5BE9
		public static void StartActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06021861 RID: 137313 RVA: 0x004A79F4 File Offset: 0x004A5BF4
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x06021862 RID: 137314 RVA: 0x004A79FF File Offset: 0x004A5BFF
		public static Offset<IElementalMatchActions> EndIElementalMatchActions(FlatBufferBuilder builder)
		{
			return new Offset<IElementalMatchActions>(builder.EndTable());
		}

		// Token: 0x06021863 RID: 137315 RVA: 0x004A7A0C File Offset: 0x004A5C0C
		public IElementalMatchActionsT UnPack()
		{
			IElementalMatchActionsT elementalMatchActionsT = new IElementalMatchActionsT();
			this.UnPackTo(elementalMatchActionsT);
			return elementalMatchActionsT;
		}

		// Token: 0x06021864 RID: 137316 RVA: 0x004A7A28 File Offset: 0x004A5C28
		public void UnPackTo(IElementalMatchActionsT _o)
		{
			_o.Condition = ((this.Condition != null) ? this.Condition.Value.UnPack() : null);
			_o.Actions = new List<IActionInfoT>();
			for (int i = 0; i < this.ActionsLength; i++)
			{
				_o.Actions.Add((this.Actions(i) != null) ? this.Actions(i).Value.UnPack() : null);
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06021865 RID: 137317 RVA: 0x004A7AC4 File Offset: 0x004A5CC4
		public static Offset<IElementalMatchActions> Pack(FlatBufferBuilder builder, IElementalMatchActionsT _o)
		{
			if (_o == null)
			{
				return default(Offset<IElementalMatchActions>);
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
				actionsOffset = IElementalMatchActions.CreateActionsVector(builder, array);
			}
			return IElementalMatchActions.CreateIElementalMatchActions(builder, conditionOffset, actionsOffset, _o.NullMask);
		}

		// Token: 0x0400E1B2 RID: 57778
		private Table __p;
	}
}
