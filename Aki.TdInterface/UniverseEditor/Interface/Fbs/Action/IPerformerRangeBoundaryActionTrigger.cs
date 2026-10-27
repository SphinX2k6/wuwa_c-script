using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006C90 RID: 27792
	public struct IPerformerRangeBoundaryActionTrigger : IFlatbufferObject
	{
		// Token: 0x1700CEF4 RID: 52980
		// (get) Token: 0x06030F8F RID: 200591 RVA: 0x006A60FE File Offset: 0x006A42FE
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06030F90 RID: 200592 RVA: 0x006A610B File Offset: 0x006A430B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06030F91 RID: 200593 RVA: 0x006A6114 File Offset: 0x006A4314
		public static IPerformerRangeBoundaryActionTrigger GetRootAsIPerformerRangeBoundaryActionTrigger(ByteBuffer _bb)
		{
			return IPerformerRangeBoundaryActionTrigger.GetRootAsIPerformerRangeBoundaryActionTrigger(_bb, default(IPerformerRangeBoundaryActionTrigger));
		}

		// Token: 0x06030F92 RID: 200594 RVA: 0x006A6130 File Offset: 0x006A4330
		public static IPerformerRangeBoundaryActionTrigger GetRootAsIPerformerRangeBoundaryActionTrigger(ByteBuffer _bb, IPerformerRangeBoundaryActionTrigger obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06030F93 RID: 200595 RVA: 0x006A614D File Offset: 0x006A434D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06030F94 RID: 200596 RVA: 0x006A615C File Offset: 0x006A435C
		public IPerformerRangeBoundaryActionTrigger __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CEF5 RID: 52981
		// (get) Token: 0x06030F95 RID: 200597 RVA: 0x006A616C File Offset: 0x006A436C
		public int Range
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06030F96 RID: 200598 RVA: 0x006A61A8 File Offset: 0x006A43A8
		public IActionInfo? Actions(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700CEF6 RID: 52982
		// (get) Token: 0x06030F97 RID: 200599 RVA: 0x006A6208 File Offset: 0x006A4408
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

		// Token: 0x06030F98 RID: 200600 RVA: 0x006A6233 File Offset: 0x006A4433
		public static Offset<IPerformerRangeBoundaryActionTrigger> CreateIPerformerRangeBoundaryActionTrigger(FlatBufferBuilder builder, int Range = 0, VectorOffset ActionsOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			IPerformerRangeBoundaryActionTrigger.AddActions(builder, ActionsOffset);
			IPerformerRangeBoundaryActionTrigger.AddRange(builder, Range);
			return IPerformerRangeBoundaryActionTrigger.EndIPerformerRangeBoundaryActionTrigger(builder);
		}

		// Token: 0x06030F99 RID: 200601 RVA: 0x006A6250 File Offset: 0x006A4450
		public static void StartIPerformerRangeBoundaryActionTrigger(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06030F9A RID: 200602 RVA: 0x006A6259 File Offset: 0x006A4459
		public static void AddRange(FlatBufferBuilder builder, int range)
		{
			builder.AddInt(0, range, 0);
		}

		// Token: 0x06030F9B RID: 200603 RVA: 0x006A6264 File Offset: 0x006A4464
		public static void AddActions(FlatBufferBuilder builder, VectorOffset actionsOffset)
		{
			builder.AddOffset(1, actionsOffset.Value, 0);
		}

		// Token: 0x06030F9C RID: 200604 RVA: 0x006A6274 File Offset: 0x006A4474
		public static VectorOffset CreateActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06030F9D RID: 200605 RVA: 0x006A62B4 File Offset: 0x006A44B4
		public static VectorOffset CreateActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06030F9E RID: 200606 RVA: 0x006A62CE File Offset: 0x006A44CE
		public static VectorOffset CreateActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06030F9F RID: 200607 RVA: 0x006A62EC File Offset: 0x006A44EC
		public static VectorOffset CreateActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06030FA0 RID: 200608 RVA: 0x006A6305 File Offset: 0x006A4505
		public static void StartActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06030FA1 RID: 200609 RVA: 0x006A6310 File Offset: 0x006A4510
		public static Offset<IPerformerRangeBoundaryActionTrigger> EndIPerformerRangeBoundaryActionTrigger(FlatBufferBuilder builder)
		{
			return new Offset<IPerformerRangeBoundaryActionTrigger>(builder.EndTable());
		}

		// Token: 0x06030FA2 RID: 200610 RVA: 0x006A6320 File Offset: 0x006A4520
		public IPerformerRangeBoundaryActionTriggerT UnPack()
		{
			IPerformerRangeBoundaryActionTriggerT performerRangeBoundaryActionTriggerT = new IPerformerRangeBoundaryActionTriggerT();
			this.UnPackTo(performerRangeBoundaryActionTriggerT);
			return performerRangeBoundaryActionTriggerT;
		}

		// Token: 0x06030FA3 RID: 200611 RVA: 0x006A633C File Offset: 0x006A453C
		public void UnPackTo(IPerformerRangeBoundaryActionTriggerT _o)
		{
			_o.Range = this.Range;
			_o.Actions = new List<IActionInfoT>();
			for (int i = 0; i < this.ActionsLength; i++)
			{
				_o.Actions.Add((this.Actions(i) != null) ? this.Actions(i).Value.UnPack() : null);
			}
		}

		// Token: 0x06030FA4 RID: 200612 RVA: 0x006A63A8 File Offset: 0x006A45A8
		public static Offset<IPerformerRangeBoundaryActionTrigger> Pack(FlatBufferBuilder builder, IPerformerRangeBoundaryActionTriggerT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPerformerRangeBoundaryActionTrigger>);
			}
			VectorOffset actionsOffset = default(VectorOffset);
			if (_o.Actions != null)
			{
				Offset<IActionInfo>[] array = new Offset<IActionInfo>[_o.Actions.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IActionInfo.Pack(builder, _o.Actions[i]);
				}
				actionsOffset = IPerformerRangeBoundaryActionTrigger.CreateActionsVector(builder, array);
			}
			return IPerformerRangeBoundaryActionTrigger.CreateIPerformerRangeBoundaryActionTrigger(builder, _o.Range, actionsOffset);
		}

		// Token: 0x040115E4 RID: 71140
		private Table __p;
	}
}
