using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.FixProcessor
{
	// Token: 0x0200475D RID: 18269
	public struct IGlobalFixActions : IFlatbufferObject
	{
		// Token: 0x17008315 RID: 33557
		// (get) Token: 0x0601C1F5 RID: 115189 RVA: 0x003FC044 File Offset: 0x003FA244
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601C1F6 RID: 115190 RVA: 0x003FC051 File Offset: 0x003FA251
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601C1F7 RID: 115191 RVA: 0x003FC058 File Offset: 0x003FA258
		public static IGlobalFixActions GetRootAsIGlobalFixActions(ByteBuffer _bb)
		{
			return IGlobalFixActions.GetRootAsIGlobalFixActions(_bb, default(IGlobalFixActions));
		}

		// Token: 0x0601C1F8 RID: 115192 RVA: 0x003FC074 File Offset: 0x003FA274
		public static IGlobalFixActions GetRootAsIGlobalFixActions(ByteBuffer _bb, IGlobalFixActions obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601C1F9 RID: 115193 RVA: 0x003FC091 File Offset: 0x003FA291
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601C1FA RID: 115194 RVA: 0x003FC0A0 File Offset: 0x003FA2A0
		public IGlobalFixActions __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x0601C1FB RID: 115195 RVA: 0x003FC0B0 File Offset: 0x003FA2B0
		public IActionInfo? ActionList(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17008316 RID: 33558
		// (get) Token: 0x0601C1FC RID: 115196 RVA: 0x003FC110 File Offset: 0x003FA310
		public int ActionListLength
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

		// Token: 0x0601C1FD RID: 115197 RVA: 0x003FC13B File Offset: 0x003FA33B
		public static Offset<IGlobalFixActions> CreateIGlobalFixActions(FlatBufferBuilder builder, VectorOffset ActionListOffset = default(VectorOffset))
		{
			builder.StartTable(1);
			IGlobalFixActions.AddActionList(builder, ActionListOffset);
			return IGlobalFixActions.EndIGlobalFixActions(builder);
		}

		// Token: 0x0601C1FE RID: 115198 RVA: 0x003FC151 File Offset: 0x003FA351
		public static void StartIGlobalFixActions(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601C1FF RID: 115199 RVA: 0x003FC15A File Offset: 0x003FA35A
		public static void AddActionList(FlatBufferBuilder builder, VectorOffset actionListOffset)
		{
			builder.AddOffset(0, actionListOffset.Value, 0);
		}

		// Token: 0x0601C200 RID: 115200 RVA: 0x003FC16C File Offset: 0x003FA36C
		public static VectorOffset CreateActionListVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601C201 RID: 115201 RVA: 0x003FC1AC File Offset: 0x003FA3AC
		public static VectorOffset CreateActionListVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601C202 RID: 115202 RVA: 0x003FC1C6 File Offset: 0x003FA3C6
		public static VectorOffset CreateActionListVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601C203 RID: 115203 RVA: 0x003FC1E4 File Offset: 0x003FA3E4
		public static VectorOffset CreateActionListVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601C204 RID: 115204 RVA: 0x003FC1FD File Offset: 0x003FA3FD
		public static void StartActionListVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601C205 RID: 115205 RVA: 0x003FC208 File Offset: 0x003FA408
		public static Offset<IGlobalFixActions> EndIGlobalFixActions(FlatBufferBuilder builder)
		{
			return new Offset<IGlobalFixActions>(builder.EndTable());
		}

		// Token: 0x0601C206 RID: 115206 RVA: 0x003FC218 File Offset: 0x003FA418
		public IGlobalFixActionsT UnPack()
		{
			IGlobalFixActionsT globalFixActionsT = new IGlobalFixActionsT();
			this.UnPackTo(globalFixActionsT);
			return globalFixActionsT;
		}

		// Token: 0x0601C207 RID: 115207 RVA: 0x003FC234 File Offset: 0x003FA434
		public void UnPackTo(IGlobalFixActionsT _o)
		{
			_o.ActionList = new List<IActionInfoT>();
			for (int i = 0; i < this.ActionListLength; i++)
			{
				_o.ActionList.Add((this.ActionList(i) != null) ? this.ActionList(i).Value.UnPack() : null);
			}
		}

		// Token: 0x0601C208 RID: 115208 RVA: 0x003FC294 File Offset: 0x003FA494
		public static Offset<IGlobalFixActions> Pack(FlatBufferBuilder builder, IGlobalFixActionsT _o)
		{
			if (_o == null)
			{
				return default(Offset<IGlobalFixActions>);
			}
			VectorOffset actionListOffset = default(VectorOffset);
			if (_o.ActionList != null)
			{
				Offset<IActionInfo>[] array = new Offset<IActionInfo>[_o.ActionList.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IActionInfo.Pack(builder, _o.ActionList[i]);
				}
				actionListOffset = IGlobalFixActions.CreateActionListVector(builder, array);
			}
			return IGlobalFixActions.CreateIGlobalFixActions(builder, actionListOffset);
		}

		// Token: 0x0400CA5E RID: 51806
		private Table __p;
	}
}
