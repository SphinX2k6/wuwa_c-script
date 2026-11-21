using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007C62 RID: 31842
	public struct ITriggerActions : IFlatbufferObject
	{
		// Token: 0x1700EE57 RID: 61015
		// (get) Token: 0x0603964F RID: 235087 RVA: 0x007BF842 File Offset: 0x007BDA42
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06039650 RID: 235088 RVA: 0x007BF84F File Offset: 0x007BDA4F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06039651 RID: 235089 RVA: 0x007BF858 File Offset: 0x007BDA58
		public static ITriggerActions GetRootAsITriggerActions(ByteBuffer _bb)
		{
			return ITriggerActions.GetRootAsITriggerActions(_bb, default(ITriggerActions));
		}

		// Token: 0x06039652 RID: 235090 RVA: 0x007BF874 File Offset: 0x007BDA74
		public static ITriggerActions GetRootAsITriggerActions(ByteBuffer _bb, ITriggerActions obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06039653 RID: 235091 RVA: 0x007BF891 File Offset: 0x007BDA91
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06039654 RID: 235092 RVA: 0x007BF8A0 File Offset: 0x007BDAA0
		public ITriggerActions __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x06039655 RID: 235093 RVA: 0x007BF8B0 File Offset: 0x007BDAB0
		public IActionInfo? Actions(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700EE58 RID: 61016
		// (get) Token: 0x06039656 RID: 235094 RVA: 0x007BF910 File Offset: 0x007BDB10
		public int ActionsLength
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06039657 RID: 235095 RVA: 0x007BF93B File Offset: 0x007BDB3B
		public static Offset<ITriggerActions> CreateITriggerActions(FlatBufferBuilder builder, VectorOffset ActionsOffset = default(VectorOffset))
		{
			builder.StartTable(1);
			ITriggerActions.AddActions(builder, ActionsOffset);
			return ITriggerActions.EndITriggerActions(builder);
		}

		// Token: 0x06039658 RID: 235096 RVA: 0x007BF951 File Offset: 0x007BDB51
		public static void StartITriggerActions(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06039659 RID: 235097 RVA: 0x007BF95A File Offset: 0x007BDB5A
		public static void AddActions(FlatBufferBuilder builder, VectorOffset actionsOffset)
		{
			builder.AddOffset(0, actionsOffset.Value, 0);
		}

		// Token: 0x0603965A RID: 235098 RVA: 0x007BF96C File Offset: 0x007BDB6C
		public static VectorOffset CreateActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0603965B RID: 235099 RVA: 0x007BF9AC File Offset: 0x007BDBAC
		public static VectorOffset CreateActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x0603965C RID: 235100 RVA: 0x007BF9C6 File Offset: 0x007BDBC6
		public static VectorOffset CreateActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x0603965D RID: 235101 RVA: 0x007BF9E4 File Offset: 0x007BDBE4
		public static VectorOffset CreateActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0603965E RID: 235102 RVA: 0x007BF9FD File Offset: 0x007BDBFD
		public static void StartActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0603965F RID: 235103 RVA: 0x007BFA08 File Offset: 0x007BDC08
		public static Offset<ITriggerActions> EndITriggerActions(FlatBufferBuilder builder)
		{
			return new Offset<ITriggerActions>(builder.EndTable());
		}

		// Token: 0x06039660 RID: 235104 RVA: 0x007BFA18 File Offset: 0x007BDC18
		public ITriggerActionsT UnPack()
		{
			ITriggerActionsT triggerActionsT = new ITriggerActionsT();
			this.UnPackTo(triggerActionsT);
			return triggerActionsT;
		}

		// Token: 0x06039661 RID: 235105 RVA: 0x007BFA34 File Offset: 0x007BDC34
		public void UnPackTo(ITriggerActionsT _o)
		{
			_o.Actions = new List<IActionInfoT>();
			for (int i = 0; i < this.ActionsLength; i++)
			{
				_o.Actions.Add((this.Actions(i) != null) ? this.Actions(i).Value.UnPack() : null);
			}
		}

		// Token: 0x06039662 RID: 235106 RVA: 0x007BFA94 File Offset: 0x007BDC94
		public static Offset<ITriggerActions> Pack(FlatBufferBuilder builder, ITriggerActionsT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITriggerActions>);
			}
			VectorOffset actionsOffset = default(VectorOffset);
			if (_o.Actions != null)
			{
				Offset<IActionInfo>[] array = new Offset<IActionInfo>[_o.Actions.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IActionInfo.Pack(builder, _o.Actions[i]);
				}
				actionsOffset = ITriggerActions.CreateActionsVector(builder, array);
			}
			return ITriggerActions.CreateITriggerActions(builder, actionsOffset);
		}

		// Token: 0x04013322 RID: 78626
		private Table __p;
	}
}
