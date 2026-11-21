using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020073F7 RID: 29687
	public struct IPerformerRangeBoundaryActionTrigger : IFlatbufferObject
	{
		// Token: 0x1700DA0F RID: 55823
		// (get) Token: 0x06033EEA RID: 212714 RVA: 0x007005FE File Offset: 0x006FE7FE
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06033EEB RID: 212715 RVA: 0x0070060B File Offset: 0x006FE80B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06033EEC RID: 212716 RVA: 0x00700614 File Offset: 0x006FE814
		public static IPerformerRangeBoundaryActionTrigger GetRootAsIPerformerRangeBoundaryActionTrigger(ByteBuffer _bb)
		{
			return IPerformerRangeBoundaryActionTrigger.GetRootAsIPerformerRangeBoundaryActionTrigger(_bb, default(IPerformerRangeBoundaryActionTrigger));
		}

		// Token: 0x06033EED RID: 212717 RVA: 0x00700630 File Offset: 0x006FE830
		public static IPerformerRangeBoundaryActionTrigger GetRootAsIPerformerRangeBoundaryActionTrigger(ByteBuffer _bb, IPerformerRangeBoundaryActionTrigger obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06033EEE RID: 212718 RVA: 0x0070064D File Offset: 0x006FE84D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06033EEF RID: 212719 RVA: 0x0070065C File Offset: 0x006FE85C
		public IPerformerRangeBoundaryActionTrigger __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700DA10 RID: 55824
		// (get) Token: 0x06033EF0 RID: 212720 RVA: 0x0070066C File Offset: 0x006FE86C
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

		// Token: 0x06033EF1 RID: 212721 RVA: 0x007006A8 File Offset: 0x006FE8A8
		public IActionInfo? Actions(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700DA11 RID: 55825
		// (get) Token: 0x06033EF2 RID: 212722 RVA: 0x00700708 File Offset: 0x006FE908
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

		// Token: 0x06033EF3 RID: 212723 RVA: 0x00700733 File Offset: 0x006FE933
		public static Offset<IPerformerRangeBoundaryActionTrigger> CreateIPerformerRangeBoundaryActionTrigger(FlatBufferBuilder builder, int Range = 0, VectorOffset ActionsOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			IPerformerRangeBoundaryActionTrigger.AddActions(builder, ActionsOffset);
			IPerformerRangeBoundaryActionTrigger.AddRange(builder, Range);
			return IPerformerRangeBoundaryActionTrigger.EndIPerformerRangeBoundaryActionTrigger(builder);
		}

		// Token: 0x06033EF4 RID: 212724 RVA: 0x00700750 File Offset: 0x006FE950
		public static void StartIPerformerRangeBoundaryActionTrigger(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06033EF5 RID: 212725 RVA: 0x00700759 File Offset: 0x006FE959
		public static void AddRange(FlatBufferBuilder builder, int range)
		{
			builder.AddInt(0, range, 0);
		}

		// Token: 0x06033EF6 RID: 212726 RVA: 0x00700764 File Offset: 0x006FE964
		public static void AddActions(FlatBufferBuilder builder, VectorOffset actionsOffset)
		{
			builder.AddOffset(1, actionsOffset.Value, 0);
		}

		// Token: 0x06033EF7 RID: 212727 RVA: 0x00700774 File Offset: 0x006FE974
		public static VectorOffset CreateActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06033EF8 RID: 212728 RVA: 0x007007B4 File Offset: 0x006FE9B4
		public static VectorOffset CreateActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06033EF9 RID: 212729 RVA: 0x007007CE File Offset: 0x006FE9CE
		public static VectorOffset CreateActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06033EFA RID: 212730 RVA: 0x007007EC File Offset: 0x006FE9EC
		public static VectorOffset CreateActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06033EFB RID: 212731 RVA: 0x00700805 File Offset: 0x006FEA05
		public static void StartActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06033EFC RID: 212732 RVA: 0x00700810 File Offset: 0x006FEA10
		public static Offset<IPerformerRangeBoundaryActionTrigger> EndIPerformerRangeBoundaryActionTrigger(FlatBufferBuilder builder)
		{
			return new Offset<IPerformerRangeBoundaryActionTrigger>(builder.EndTable());
		}

		// Token: 0x06033EFD RID: 212733 RVA: 0x00700820 File Offset: 0x006FEA20
		public IPerformerRangeBoundaryActionTriggerT UnPack()
		{
			IPerformerRangeBoundaryActionTriggerT performerRangeBoundaryActionTriggerT = new IPerformerRangeBoundaryActionTriggerT();
			this.UnPackTo(performerRangeBoundaryActionTriggerT);
			return performerRangeBoundaryActionTriggerT;
		}

		// Token: 0x06033EFE RID: 212734 RVA: 0x0070083C File Offset: 0x006FEA3C
		public void UnPackTo(IPerformerRangeBoundaryActionTriggerT _o)
		{
			_o.Range = this.Range;
			_o.Actions = new List<IActionInfoT>();
			for (int i = 0; i < this.ActionsLength; i++)
			{
				_o.Actions.Add((this.Actions(i) != null) ? this.Actions(i).Value.UnPack() : null);
			}
		}

		// Token: 0x06033EFF RID: 212735 RVA: 0x007008A8 File Offset: 0x006FEAA8
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

		// Token: 0x0401253C RID: 75068
		private Table __p;
	}
}
