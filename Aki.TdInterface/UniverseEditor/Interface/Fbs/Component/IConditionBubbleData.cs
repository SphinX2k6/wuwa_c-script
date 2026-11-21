using System;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200554D RID: 21837
	public struct IConditionBubbleData : IFlatbufferObject
	{
		// Token: 0x17009C1D RID: 39965
		// (get) Token: 0x06022A55 RID: 141909 RVA: 0x004C59DB File Offset: 0x004C3BDB
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06022A56 RID: 141910 RVA: 0x004C59E8 File Offset: 0x004C3BE8
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06022A57 RID: 141911 RVA: 0x004C59F0 File Offset: 0x004C3BF0
		public static IConditionBubbleData GetRootAsIConditionBubbleData(ByteBuffer _bb)
		{
			return IConditionBubbleData.GetRootAsIConditionBubbleData(_bb, default(IConditionBubbleData));
		}

		// Token: 0x06022A58 RID: 141912 RVA: 0x004C5A0C File Offset: 0x004C3C0C
		public static IConditionBubbleData GetRootAsIConditionBubbleData(ByteBuffer _bb, IConditionBubbleData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06022A59 RID: 141913 RVA: 0x004C5A29 File Offset: 0x004C3C29
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06022A5A RID: 141914 RVA: 0x004C5A38 File Offset: 0x004C3C38
		public IConditionBubbleData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009C1E RID: 39966
		// (get) Token: 0x06022A5B RID: 141915 RVA: 0x004C5A48 File Offset: 0x004C3C48
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

		// Token: 0x17009C1F RID: 39967
		// (get) Token: 0x06022A5C RID: 141916 RVA: 0x004C5AA8 File Offset: 0x004C3CA8
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

		// Token: 0x06022A5D RID: 141917 RVA: 0x004C5B05 File Offset: 0x004C3D05
		public static Offset<IConditionBubbleData> CreateIConditionBubbleData(FlatBufferBuilder builder, Offset<IConditionGroup> ConditionOffset = default(Offset<IConditionGroup>), Offset<IBubbleData> FlowOffset = default(Offset<IBubbleData>))
		{
			builder.StartTable(2);
			IConditionBubbleData.AddFlow(builder, FlowOffset);
			IConditionBubbleData.AddCondition(builder, ConditionOffset);
			return IConditionBubbleData.EndIConditionBubbleData(builder);
		}

		// Token: 0x06022A5E RID: 141918 RVA: 0x004C5B22 File Offset: 0x004C3D22
		public static void StartIConditionBubbleData(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06022A5F RID: 141919 RVA: 0x004C5B2B File Offset: 0x004C3D2B
		public static void AddCondition(FlatBufferBuilder builder, Offset<IConditionGroup> conditionOffset)
		{
			builder.AddOffset(0, conditionOffset.Value, 0);
		}

		// Token: 0x06022A60 RID: 141920 RVA: 0x004C5B3B File Offset: 0x004C3D3B
		public static void AddFlow(FlatBufferBuilder builder, Offset<IBubbleData> flowOffset)
		{
			builder.AddOffset(1, flowOffset.Value, 0);
		}

		// Token: 0x06022A61 RID: 141921 RVA: 0x004C5B4B File Offset: 0x004C3D4B
		public static Offset<IConditionBubbleData> EndIConditionBubbleData(FlatBufferBuilder builder)
		{
			return new Offset<IConditionBubbleData>(builder.EndTable());
		}

		// Token: 0x06022A62 RID: 141922 RVA: 0x004C5B58 File Offset: 0x004C3D58
		public IConditionBubbleDataT UnPack()
		{
			IConditionBubbleDataT conditionBubbleDataT = new IConditionBubbleDataT();
			this.UnPackTo(conditionBubbleDataT);
			return conditionBubbleDataT;
		}

		// Token: 0x06022A63 RID: 141923 RVA: 0x004C5B74 File Offset: 0x004C3D74
		public void UnPackTo(IConditionBubbleDataT _o)
		{
			_o.Condition = ((this.Condition != null) ? this.Condition.Value.UnPack() : null);
			_o.Flow = ((this.Flow != null) ? this.Flow.Value.UnPack() : null);
		}

		// Token: 0x06022A64 RID: 141924 RVA: 0x004C5BE0 File Offset: 0x004C3DE0
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

		// Token: 0x0400EB9C RID: 60316
		private Table __p;
	}
}
