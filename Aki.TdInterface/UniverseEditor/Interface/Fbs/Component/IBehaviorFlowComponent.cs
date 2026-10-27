using System;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004F16 RID: 20246
	public struct IBehaviorFlowComponent : IFlatbufferObject
	{
		// Token: 0x170091C7 RID: 37319
		// (get) Token: 0x06020028 RID: 131112 RVA: 0x004746D3 File Offset: 0x004728D3
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06020029 RID: 131113 RVA: 0x004746E0 File Offset: 0x004728E0
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602002A RID: 131114 RVA: 0x004746E8 File Offset: 0x004728E8
		public static IBehaviorFlowComponent GetRootAsIBehaviorFlowComponent(ByteBuffer _bb)
		{
			return IBehaviorFlowComponent.GetRootAsIBehaviorFlowComponent(_bb, default(IBehaviorFlowComponent));
		}

		// Token: 0x0602002B RID: 131115 RVA: 0x00474704 File Offset: 0x00472904
		public static IBehaviorFlowComponent GetRootAsIBehaviorFlowComponent(ByteBuffer _bb, IBehaviorFlowComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602002C RID: 131116 RVA: 0x00474721 File Offset: 0x00472921
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602002D RID: 131117 RVA: 0x00474730 File Offset: 0x00472930
		public IBehaviorFlowComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170091C8 RID: 37320
		// (get) Token: 0x0602002E RID: 131118 RVA: 0x00474740 File Offset: 0x00472940
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170091C9 RID: 37321
		// (get) Token: 0x0602002F RID: 131119 RVA: 0x00474780 File Offset: 0x00472980
		public bool _Folded
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170091CA RID: 37322
		// (get) Token: 0x06020030 RID: 131120 RVA: 0x004747C0 File Offset: 0x004729C0
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

		// Token: 0x170091CB RID: 37323
		// (get) Token: 0x06020031 RID: 131121 RVA: 0x004747FC File Offset: 0x004729FC
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

		// Token: 0x170091CC RID: 37324
		// (get) Token: 0x06020032 RID: 131122 RVA: 0x0047485C File Offset: 0x00472A5C
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

		// Token: 0x06020033 RID: 131123 RVA: 0x00474899 File Offset: 0x00472A99
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

		// Token: 0x06020034 RID: 131124 RVA: 0x004748CD File Offset: 0x00472ACD
		public static void StartIBehaviorFlowComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x06020035 RID: 131125 RVA: 0x004748D6 File Offset: 0x00472AD6
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x06020036 RID: 131126 RVA: 0x004748E1 File Offset: 0x00472AE1
		public static void Add_Folded(FlatBufferBuilder builder, bool _Folded)
		{
			builder.AddBool(1, _Folded, false);
		}

		// Token: 0x06020037 RID: 131127 RVA: 0x004748EC File Offset: 0x00472AEC
		public static void AddInitStateId(FlatBufferBuilder builder, int initStateId)
		{
			builder.AddInt(2, initStateId, 0);
		}

		// Token: 0x06020038 RID: 131128 RVA: 0x004748F7 File Offset: 0x00472AF7
		public static void AddFlowInfo(FlatBufferBuilder builder, Offset<IFlowInfo> flowInfoOffset)
		{
			builder.AddOffset(3, flowInfoOffset.Value, 0);
		}

		// Token: 0x06020039 RID: 131129 RVA: 0x00474907 File Offset: 0x00472B07
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x0602003A RID: 131130 RVA: 0x00474912 File Offset: 0x00472B12
		public static Offset<IBehaviorFlowComponent> EndIBehaviorFlowComponent(FlatBufferBuilder builder)
		{
			return new Offset<IBehaviorFlowComponent>(builder.EndTable());
		}

		// Token: 0x0602003B RID: 131131 RVA: 0x00474920 File Offset: 0x00472B20
		public IBehaviorFlowComponentT UnPack()
		{
			IBehaviorFlowComponentT behaviorFlowComponentT = new IBehaviorFlowComponentT();
			this.UnPackTo(behaviorFlowComponentT);
			return behaviorFlowComponentT;
		}

		// Token: 0x0602003C RID: 131132 RVA: 0x0047493C File Offset: 0x00472B3C
		public void UnPackTo(IBehaviorFlowComponentT _o)
		{
			_o.Disabled = this.Disabled;
			_o._Folded = this._Folded;
			_o.InitStateId = this.InitStateId;
			_o.FlowInfo = ((this.FlowInfo != null) ? this.FlowInfo.Value.UnPack() : null);
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602003D RID: 131133 RVA: 0x004749A8 File Offset: 0x00472BA8
		public static Offset<IBehaviorFlowComponent> Pack(FlatBufferBuilder builder, IBehaviorFlowComponentT _o)
		{
			if (_o == null)
			{
				return default(Offset<IBehaviorFlowComponent>);
			}
			Offset<IFlowInfo> flowInfoOffset = (_o.FlowInfo == null) ? default(Offset<IFlowInfo>) : IFlowInfo.Pack(builder, _o.FlowInfo);
			return IBehaviorFlowComponent.CreateIBehaviorFlowComponent(builder, _o.Disabled, _o._Folded, _o.InitStateId, flowInfoOffset, _o.NullMask);
		}

		// Token: 0x0400DD62 RID: 56674
		private Table __p;
	}
}
