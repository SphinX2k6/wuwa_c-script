using System;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005448 RID: 21576
	public struct IBehaviorFlowComponent : IFlatbufferObject
	{
		// Token: 0x17009949 RID: 39241
		// (get) Token: 0x06021D98 RID: 138648 RVA: 0x004AAA67 File Offset: 0x004A8C67
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06021D99 RID: 138649 RVA: 0x004AAA74 File Offset: 0x004A8C74
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06021D9A RID: 138650 RVA: 0x004AAA7C File Offset: 0x004A8C7C
		public static IBehaviorFlowComponent GetRootAsIBehaviorFlowComponent(ByteBuffer _bb)
		{
			return IBehaviorFlowComponent.GetRootAsIBehaviorFlowComponent(_bb, default(IBehaviorFlowComponent));
		}

		// Token: 0x06021D9B RID: 138651 RVA: 0x004AAA98 File Offset: 0x004A8C98
		public static IBehaviorFlowComponent GetRootAsIBehaviorFlowComponent(ByteBuffer _bb, IBehaviorFlowComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06021D9C RID: 138652 RVA: 0x004AAAB5 File Offset: 0x004A8CB5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06021D9D RID: 138653 RVA: 0x004AAAC4 File Offset: 0x004A8CC4
		public IBehaviorFlowComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700994A RID: 39242
		// (get) Token: 0x06021D9E RID: 138654 RVA: 0x004AAAD4 File Offset: 0x004A8CD4
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700994B RID: 39243
		// (get) Token: 0x06021D9F RID: 138655 RVA: 0x004AAB14 File Offset: 0x004A8D14
		public bool _Folded
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700994C RID: 39244
		// (get) Token: 0x06021DA0 RID: 138656 RVA: 0x004AAB54 File Offset: 0x004A8D54
		public int InitStateId
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700994D RID: 39245
		// (get) Token: 0x06021DA1 RID: 138657 RVA: 0x004AAB90 File Offset: 0x004A8D90
		public IFlowInfo? FlowInfo
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return new IFlowInfo?(default(IFlowInfo).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700994E RID: 39246
		// (get) Token: 0x06021DA2 RID: 138658 RVA: 0x004AABF0 File Offset: 0x004A8DF0
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06021DA3 RID: 138659 RVA: 0x004AAC2D File Offset: 0x004A8E2D
		public static Offset<IBehaviorFlowComponent> CreateIBehaviorFlowComponent(FlatBufferBuilder builder, bool Disabled = false, bool _folded = false, int InitStateId = 0, Offset<IFlowInfo> FlowInfoOffset = default(Offset<IFlowInfo>), byte NullMask = 0)
		{
			builder.StartTable(5);
			IBehaviorFlowComponent.AddFlowInfo(builder, FlowInfoOffset);
			IBehaviorFlowComponent.AddInitStateId(builder, InitStateId);
			IBehaviorFlowComponent.AddNullMask(builder, NullMask);
			IBehaviorFlowComponent.Add_Folded(builder, _folded);
			IBehaviorFlowComponent.AddDisabled(builder, Disabled);
			return IBehaviorFlowComponent.EndIBehaviorFlowComponent(builder);
		}

		// Token: 0x06021DA4 RID: 138660 RVA: 0x004AAC61 File Offset: 0x004A8E61
		public static void StartIBehaviorFlowComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x06021DA5 RID: 138661 RVA: 0x004AAC6A File Offset: 0x004A8E6A
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x06021DA6 RID: 138662 RVA: 0x004AAC75 File Offset: 0x004A8E75
		public static void Add_Folded(FlatBufferBuilder builder, bool _Folded)
		{
			builder.AddBool(1, _Folded, false);
		}

		// Token: 0x06021DA7 RID: 138663 RVA: 0x004AAC80 File Offset: 0x004A8E80
		public static void AddInitStateId(FlatBufferBuilder builder, int initStateId)
		{
			builder.AddInt(2, initStateId, 0);
		}

		// Token: 0x06021DA8 RID: 138664 RVA: 0x004AAC8B File Offset: 0x004A8E8B
		public static void AddFlowInfo(FlatBufferBuilder builder, Offset<IFlowInfo> flowInfoOffset)
		{
			builder.AddOffset(3, flowInfoOffset.Value, 0);
		}

		// Token: 0x06021DA9 RID: 138665 RVA: 0x004AAC9B File Offset: 0x004A8E9B
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x06021DAA RID: 138666 RVA: 0x004AACA6 File Offset: 0x004A8EA6
		public static Offset<IBehaviorFlowComponent> EndIBehaviorFlowComponent(FlatBufferBuilder builder)
		{
			return new Offset<IBehaviorFlowComponent>(builder.EndTable());
		}

		// Token: 0x06021DAB RID: 138667 RVA: 0x004AACB4 File Offset: 0x004A8EB4
		public IBehaviorFlowComponentT UnPack()
		{
			IBehaviorFlowComponentT behaviorFlowComponentT = new IBehaviorFlowComponentT();
			this.UnPackTo(behaviorFlowComponentT);
			return behaviorFlowComponentT;
		}

		// Token: 0x06021DAC RID: 138668 RVA: 0x004AACD0 File Offset: 0x004A8ED0
		public void UnPackTo(IBehaviorFlowComponentT _o)
		{
			_o.Disabled = this.Disabled;
			_o._Folded = this._Folded;
			_o.InitStateId = this.InitStateId;
			_o.FlowInfo = ((this.FlowInfo != null) ? this.FlowInfo.Value.UnPack() : null);
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06021DAD RID: 138669 RVA: 0x004AAD3C File Offset: 0x004A8F3C
		public static Offset<IBehaviorFlowComponent> Pack(FlatBufferBuilder builder, IBehaviorFlowComponentT _o)
		{
			if (_o == null)
			{
				return default(Offset<IBehaviorFlowComponent>);
			}
			Offset<IFlowInfo> flowInfoOffset = (_o.FlowInfo == null) ? default(Offset<IFlowInfo>) : IFlowInfo.Pack(builder, _o.FlowInfo);
			return IBehaviorFlowComponent.CreateIBehaviorFlowComponent(builder, _o.Disabled, _o._Folded, _o.InitStateId, flowInfoOffset, _o.NullMask);
		}

		// Token: 0x0400E911 RID: 59665
		private Table __p;
	}
}
