using System;
using Aki.UniverseEditor.Interface.Fbs.Quest;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.GameStatusDefine
{
	// Token: 0x020046EE RID: 18158
	public struct IGameCurrBreakNodeEventInfo : IFlatbufferObject
	{
		// Token: 0x170081CA RID: 33226
		// (get) Token: 0x0601BC93 RID: 113811 RVA: 0x003F0684 File Offset: 0x003EE884
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601BC94 RID: 113812 RVA: 0x003F0691 File Offset: 0x003EE891
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601BC95 RID: 113813 RVA: 0x003F0698 File Offset: 0x003EE898
		public static IGameCurrBreakNodeEventInfo GetRootAsIGameCurrBreakNodeEventInfo(ByteBuffer _bb)
		{
			return IGameCurrBreakNodeEventInfo.GetRootAsIGameCurrBreakNodeEventInfo(_bb, default(IGameCurrBreakNodeEventInfo));
		}

		// Token: 0x0601BC96 RID: 113814 RVA: 0x003F06B4 File Offset: 0x003EE8B4
		public static IGameCurrBreakNodeEventInfo GetRootAsIGameCurrBreakNodeEventInfo(ByteBuffer _bb, IGameCurrBreakNodeEventInfo obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601BC97 RID: 113815 RVA: 0x003F06D1 File Offset: 0x003EE8D1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601BC98 RID: 113816 RVA: 0x003F06E0 File Offset: 0x003EE8E0
		public IGameCurrBreakNodeEventInfo __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170081CB RID: 33227
		// (get) Token: 0x0601BC99 RID: 113817 RVA: 0x003F06F0 File Offset: 0x003EE8F0
		public long BtConfigId
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0L;
				}
				return this.__p.bb.GetLong(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170081CC RID: 33228
		// (get) Token: 0x0601BC9A RID: 113818 RVA: 0x003F0730 File Offset: 0x003EE930
		public TBehaviorTreeType BtEditorType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return TBehaviorTreeType.BehaviorTreeFragment;
				}
				return (TBehaviorTreeType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170081CD RID: 33229
		// (get) Token: 0x0601BC9B RID: 113819 RVA: 0x003F076C File Offset: 0x003EE96C
		public int NodeId
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

		// Token: 0x170081CE RID: 33230
		// (get) Token: 0x0601BC9C RID: 113820 RVA: 0x003F07A8 File Offset: 0x003EE9A8
		public ENodeBreakMoment BreakMoment
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return ENodeBreakMoment.Null;
				}
				return (ENodeBreakMoment)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601BC9D RID: 113821 RVA: 0x003F07E5 File Offset: 0x003EE9E5
		public static Offset<IGameCurrBreakNodeEventInfo> CreateIGameCurrBreakNodeEventInfo(FlatBufferBuilder builder, long BtConfigId = 0L, TBehaviorTreeType BtEditorType = TBehaviorTreeType.BehaviorTreeFragment, int NodeId = 0, ENodeBreakMoment BreakMoment = ENodeBreakMoment.Null)
		{
			builder.StartTable(4);
			IGameCurrBreakNodeEventInfo.AddBtConfigId(builder, BtConfigId);
			IGameCurrBreakNodeEventInfo.AddNodeId(builder, NodeId);
			IGameCurrBreakNodeEventInfo.AddBreakMoment(builder, BreakMoment);
			IGameCurrBreakNodeEventInfo.AddBtEditorType(builder, BtEditorType);
			return IGameCurrBreakNodeEventInfo.EndIGameCurrBreakNodeEventInfo(builder);
		}

		// Token: 0x0601BC9E RID: 113822 RVA: 0x003F0811 File Offset: 0x003EEA11
		public static void StartIGameCurrBreakNodeEventInfo(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0601BC9F RID: 113823 RVA: 0x003F081A File Offset: 0x003EEA1A
		public static void AddBtConfigId(FlatBufferBuilder builder, long btConfigId)
		{
			builder.AddLong(0, btConfigId, 0L);
		}

		// Token: 0x0601BCA0 RID: 113824 RVA: 0x003F0826 File Offset: 0x003EEA26
		public static void AddBtEditorType(FlatBufferBuilder builder, TBehaviorTreeType btEditorType)
		{
			builder.AddByte(1, (byte)btEditorType, 0);
		}

		// Token: 0x0601BCA1 RID: 113825 RVA: 0x003F0831 File Offset: 0x003EEA31
		public static void AddNodeId(FlatBufferBuilder builder, int nodeId)
		{
			builder.AddInt(2, nodeId, 0);
		}

		// Token: 0x0601BCA2 RID: 113826 RVA: 0x003F083C File Offset: 0x003EEA3C
		public static void AddBreakMoment(FlatBufferBuilder builder, ENodeBreakMoment breakMoment)
		{
			builder.AddByte(3, (byte)breakMoment, 0);
		}

		// Token: 0x0601BCA3 RID: 113827 RVA: 0x003F0847 File Offset: 0x003EEA47
		public static Offset<IGameCurrBreakNodeEventInfo> EndIGameCurrBreakNodeEventInfo(FlatBufferBuilder builder)
		{
			return new Offset<IGameCurrBreakNodeEventInfo>(builder.EndTable());
		}

		// Token: 0x0601BCA4 RID: 113828 RVA: 0x003F0854 File Offset: 0x003EEA54
		public IGameCurrBreakNodeEventInfoT UnPack()
		{
			IGameCurrBreakNodeEventInfoT gameCurrBreakNodeEventInfoT = new IGameCurrBreakNodeEventInfoT();
			this.UnPackTo(gameCurrBreakNodeEventInfoT);
			return gameCurrBreakNodeEventInfoT;
		}

		// Token: 0x0601BCA5 RID: 113829 RVA: 0x003F086F File Offset: 0x003EEA6F
		public void UnPackTo(IGameCurrBreakNodeEventInfoT _o)
		{
			_o.BtConfigId = this.BtConfigId;
			_o.BtEditorType = this.BtEditorType;
			_o.NodeId = this.NodeId;
			_o.BreakMoment = this.BreakMoment;
		}

		// Token: 0x0601BCA6 RID: 113830 RVA: 0x003F08A4 File Offset: 0x003EEAA4
		public static Offset<IGameCurrBreakNodeEventInfo> Pack(FlatBufferBuilder builder, IGameCurrBreakNodeEventInfoT _o)
		{
			if (_o == null)
			{
				return default(Offset<IGameCurrBreakNodeEventInfo>);
			}
			return IGameCurrBreakNodeEventInfo.CreateIGameCurrBreakNodeEventInfo(builder, _o.BtConfigId, _o.BtEditorType, _o.NodeId, _o.BreakMoment);
		}

		// Token: 0x0400C995 RID: 51605
		private Table __p;
	}
}
