using System;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004FEE RID: 20462
	public struct IConditionBubbleData : IFlatbufferObject
	{
		// Token: 0x1700943C RID: 37948
		// (get) Token: 0x06020B35 RID: 133941 RVA: 0x0048BF8B File Offset: 0x0048A18B
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06020B36 RID: 133942 RVA: 0x0048BF98 File Offset: 0x0048A198
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06020B37 RID: 133943 RVA: 0x0048BFA0 File Offset: 0x0048A1A0
		public static IConditionBubbleData GetRootAsIConditionBubbleData(ByteBuffer _bb)
		{
			return IConditionBubbleData.GetRootAsIConditionBubbleData(_bb, default(IConditionBubbleData));
		}

		// Token: 0x06020B38 RID: 133944 RVA: 0x0048BFBC File Offset: 0x0048A1BC
		public static IConditionBubbleData GetRootAsIConditionBubbleData(ByteBuffer _bb, IConditionBubbleData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06020B39 RID: 133945 RVA: 0x0048BFD9 File Offset: 0x0048A1D9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06020B3A RID: 133946 RVA: 0x0048BFE8 File Offset: 0x0048A1E8
		public IConditionBubbleData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700943D RID: 37949
		// (get) Token: 0x06020B3B RID: 133947 RVA: 0x0048BFF8 File Offset: 0x0048A1F8
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

		// Token: 0x1700943E RID: 37950
		// (get) Token: 0x06020B3C RID: 133948 RVA: 0x0048C058 File Offset: 0x0048A258
		public IBubbleData? Flow
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IBubbleData?(default(IBubbleData).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x06020B3D RID: 133949 RVA: 0x0048C0B5 File Offset: 0x0048A2B5
		public static Offset<IConditionBubbleData> CreateIConditionBubbleData(FlatBufferBuilder builder, Offset<IConditionGroup> ConditionOffset = default(Offset<IConditionGroup>), Offset<IBubbleData> FlowOffset = default(Offset<IBubbleData>))
		{
			builder.StartTable(2);
			IConditionBubbleData.AddFlow(builder, FlowOffset);
			IConditionBubbleData.AddCondition(builder, ConditionOffset);
			return IConditionBubbleData.EndIConditionBubbleData(builder);
		}

		// Token: 0x06020B3E RID: 133950 RVA: 0x0048C0D2 File Offset: 0x0048A2D2
		public static void StartIConditionBubbleData(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06020B3F RID: 133951 RVA: 0x0048C0DB File Offset: 0x0048A2DB
		public static void AddCondition(FlatBufferBuilder builder, Offset<IConditionGroup> conditionOffset)
		{
			builder.AddOffset(0, conditionOffset.Value, 0);
		}

		// Token: 0x06020B40 RID: 133952 RVA: 0x0048C0EB File Offset: 0x0048A2EB
		public static void AddFlow(FlatBufferBuilder builder, Offset<IBubbleData> flowOffset)
		{
			builder.AddOffset(1, flowOffset.Value, 0);
		}

		// Token: 0x06020B41 RID: 133953 RVA: 0x0048C0FB File Offset: 0x0048A2FB
		public static Offset<IConditionBubbleData> EndIConditionBubbleData(FlatBufferBuilder builder)
		{
			return new Offset<IConditionBubbleData>(builder.EndTable());
		}

		// Token: 0x06020B42 RID: 133954 RVA: 0x0048C108 File Offset: 0x0048A308
		public IConditionBubbleDataT UnPack()
		{
			IConditionBubbleDataT conditionBubbleDataT = new IConditionBubbleDataT();
			this.UnPackTo(conditionBubbleDataT);
			return conditionBubbleDataT;
		}

		// Token: 0x06020B43 RID: 133955 RVA: 0x0048C124 File Offset: 0x0048A324
		public void UnPackTo(IConditionBubbleDataT _o)
		{
			_o.Condition = ((this.Condition != null) ? this.Condition.Value.UnPack() : null);
			_o.Flow = ((this.Flow != null) ? this.Flow.Value.UnPack() : null);
		}

		// Token: 0x06020B44 RID: 133956 RVA: 0x0048C190 File Offset: 0x0048A390
		public static Offset<IConditionBubbleData> Pack(FlatBufferBuilder builder, IConditionBubbleDataT _o)
		{
			if (_o == null)
			{
				return default(Offset<IConditionBubbleData>);
			}
			Offset<IConditionGroup> conditionOffset = (_o.Condition == null) ? default(Offset<IConditionGroup>) : IConditionGroup.Pack(builder, _o.Condition);
			Offset<IBubbleData> flowOffset = (_o.Flow == null) ? default(Offset<IBubbleData>) : IBubbleData.Pack(builder, _o.Flow);
			return IConditionBubbleData.CreateIConditionBubbleData(builder, conditionOffset, flowOffset);
		}

		// Token: 0x0400DFA6 RID: 57254
		private Table __p;
	}
}
