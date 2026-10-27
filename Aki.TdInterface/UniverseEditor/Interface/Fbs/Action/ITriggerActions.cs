using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200746F RID: 29807
	public struct ITriggerActions : IFlatbufferObject
	{
		// Token: 0x1700E23A RID: 57914
		// (get) Token: 0x06036266 RID: 221798 RVA: 0x0075CB16 File Offset: 0x0075AD16
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06036267 RID: 221799 RVA: 0x0075CB23 File Offset: 0x0075AD23
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06036268 RID: 221800 RVA: 0x0075CB2C File Offset: 0x0075AD2C
		public static ITriggerActions GetRootAsITriggerActions(ByteBuffer _bb)
		{
			return ITriggerActions.GetRootAsITriggerActions(_bb, default(ITriggerActions));
		}

		// Token: 0x06036269 RID: 221801 RVA: 0x0075CB48 File Offset: 0x0075AD48
		public static ITriggerActions GetRootAsITriggerActions(ByteBuffer _bb, ITriggerActions obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603626A RID: 221802 RVA: 0x0075CB65 File Offset: 0x0075AD65
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603626B RID: 221803 RVA: 0x0075CB74 File Offset: 0x0075AD74
		public ITriggerActions __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x0603626C RID: 221804 RVA: 0x0075CB84 File Offset: 0x0075AD84
		public IActionInfo? Actions(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700E23B RID: 57915
		// (get) Token: 0x0603626D RID: 221805 RVA: 0x0075CBE4 File Offset: 0x0075ADE4
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

		// Token: 0x0603626E RID: 221806 RVA: 0x0075CC0F File Offset: 0x0075AE0F
		public static Offset<ITriggerActions> CreateITriggerActions(FlatBufferBuilder builder, VectorOffset ActionsOffset = default(VectorOffset))
		{
			builder.StartTable(1);
			ITriggerActions.AddActions(builder, ActionsOffset);
			return ITriggerActions.EndITriggerActions(builder);
		}

		// Token: 0x0603626F RID: 221807 RVA: 0x0075CC25 File Offset: 0x0075AE25
		public static void StartITriggerActions(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06036270 RID: 221808 RVA: 0x0075CC2E File Offset: 0x0075AE2E
		public static void AddActions(FlatBufferBuilder builder, VectorOffset actionsOffset)
		{
			builder.AddOffset(0, actionsOffset.Value, 0);
		}

		// Token: 0x06036271 RID: 221809 RVA: 0x0075CC40 File Offset: 0x0075AE40
		public static VectorOffset CreateActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06036272 RID: 221810 RVA: 0x0075CC80 File Offset: 0x0075AE80
		public static VectorOffset CreateActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06036273 RID: 221811 RVA: 0x0075CC9A File Offset: 0x0075AE9A
		public static VectorOffset CreateActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06036274 RID: 221812 RVA: 0x0075CCB8 File Offset: 0x0075AEB8
		public static VectorOffset CreateActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06036275 RID: 221813 RVA: 0x0075CCD1 File Offset: 0x0075AED1
		public static void StartActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06036276 RID: 221814 RVA: 0x0075CCDC File Offset: 0x0075AEDC
		public static Offset<ITriggerActions> EndITriggerActions(FlatBufferBuilder builder)
		{
			return new Offset<ITriggerActions>(builder.EndTable());
		}

		// Token: 0x06036277 RID: 221815 RVA: 0x0075CCEC File Offset: 0x0075AEEC
		public ITriggerActionsT UnPack()
		{
			ITriggerActionsT triggerActionsT = new ITriggerActionsT();
			this.UnPackTo(triggerActionsT);
			return triggerActionsT;
		}

		// Token: 0x06036278 RID: 221816 RVA: 0x0075CD08 File Offset: 0x0075AF08
		public void UnPackTo(ITriggerActionsT _o)
		{
			_o.Actions = new List<IActionInfoT>();
			for (int i = 0; i < this.ActionsLength; i++)
			{
				_o.Actions.Add((this.Actions(i) != null) ? this.Actions(i).Value.UnPack() : null);
			}
		}

		// Token: 0x06036279 RID: 221817 RVA: 0x0075CD68 File Offset: 0x0075AF68
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

		// Token: 0x040122FB RID: 74491
		private Table __p;
	}
}
