using System;
using Aki.UniverseEditor.Interface.Fbs.Quest;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.GameStatusDefine
{
	// Token: 0x02004B56 RID: 19286
	public struct IGameCurrBreakNodeEventInfo : IFlatbufferObject
	{
		// Token: 0x1700880B RID: 34827
		// (get) Token: 0x0601D468 RID: 119912 RVA: 0x0041C920 File Offset: 0x0041AB20
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601D469 RID: 119913 RVA: 0x0041C92D File Offset: 0x0041AB2D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601D46A RID: 119914 RVA: 0x0041C934 File Offset: 0x0041AB34
		public static IGameCurrBreakNodeEventInfo GetRootAsIGameCurrBreakNodeEventInfo(ByteBuffer _bb)
		{
			return IGameCurrBreakNodeEventInfo.GetRootAsIGameCurrBreakNodeEventInfo(_bb, default(IGameCurrBreakNodeEventInfo));
		}

		// Token: 0x0601D46B RID: 119915 RVA: 0x0041C950 File Offset: 0x0041AB50
		public static IGameCurrBreakNodeEventInfo GetRootAsIGameCurrBreakNodeEventInfo(ByteBuffer _bb, IGameCurrBreakNodeEventInfo obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601D46C RID: 119916 RVA: 0x0041C96D File Offset: 0x0041AB6D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601D46D RID: 119917 RVA: 0x0041C97C File Offset: 0x0041AB7C
		public IGameCurrBreakNodeEventInfo __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700880C RID: 34828
		// (get) Token: 0x0601D46E RID: 119918 RVA: 0x0041C98C File Offset: 0x0041AB8C
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

		// Token: 0x1700880D RID: 34829
		// (get) Token: 0x0601D46F RID: 119919 RVA: 0x0041C9CC File Offset: 0x0041ABCC
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

		// Token: 0x1700880E RID: 34830
		// (get) Token: 0x0601D470 RID: 119920 RVA: 0x0041CA08 File Offset: 0x0041AC08
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

		// Token: 0x1700880F RID: 34831
		// (get) Token: 0x0601D471 RID: 119921 RVA: 0x0041CA44 File Offset: 0x0041AC44
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

		// Token: 0x0601D472 RID: 119922 RVA: 0x0041CA81 File Offset: 0x0041AC81
		public static Offset<IGameCurrBreakNodeEventInfo> CreateIGameCurrBreakNodeEventInfo(FlatBufferBuilder builder, long BtConfigId = 0L, TBehaviorTreeType BtEditorType = TBehaviorTreeType.BehaviorTreeFragment, int NodeId = 0, ENodeBreakMoment BreakMoment = ENodeBreakMoment.Null)
		{
			builder.StartTable(4);
			IGameCurrBreakNodeEventInfo.AddBtConfigId(builder, BtConfigId);
			IGameCurrBreakNodeEventInfo.AddNodeId(builder, NodeId);
			IGameCurrBreakNodeEventInfo.AddBreakMoment(builder, BreakMoment);
			IGameCurrBreakNodeEventInfo.AddBtEditorType(builder, BtEditorType);
			return IGameCurrBreakNodeEventInfo.EndIGameCurrBreakNodeEventInfo(builder);
		}

		// Token: 0x0601D473 RID: 119923 RVA: 0x0041CAAD File Offset: 0x0041ACAD
		public static void StartIGameCurrBreakNodeEventInfo(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0601D474 RID: 119924 RVA: 0x0041CAB6 File Offset: 0x0041ACB6
		public static void AddBtConfigId(FlatBufferBuilder builder, long btConfigId)
		{
			builder.AddLong(0, btConfigId, 0L);
		}

		// Token: 0x0601D475 RID: 119925 RVA: 0x0041CAC2 File Offset: 0x0041ACC2
		public static void AddBtEditorType(FlatBufferBuilder builder, TBehaviorTreeType btEditorType)
		{
			builder.AddByte(1, (byte)btEditorType, 0);
		}

		// Token: 0x0601D476 RID: 119926 RVA: 0x0041CACD File Offset: 0x0041ACCD
		public static void AddNodeId(FlatBufferBuilder builder, int nodeId)
		{
			builder.AddInt(2, nodeId, 0);
		}

		// Token: 0x0601D477 RID: 119927 RVA: 0x0041CAD8 File Offset: 0x0041ACD8
		public static void AddBreakMoment(FlatBufferBuilder builder, ENodeBreakMoment breakMoment)
		{
			builder.AddByte(3, (byte)breakMoment, 0);
		}

		// Token: 0x0601D478 RID: 119928 RVA: 0x0041CAE3 File Offset: 0x0041ACE3
		public static Offset<IGameCurrBreakNodeEventInfo> EndIGameCurrBreakNodeEventInfo(FlatBufferBuilder builder)
		{
			return new Offset<IGameCurrBreakNodeEventInfo>(builder.EndTable());
		}

		// Token: 0x0601D479 RID: 119929 RVA: 0x0041CAF0 File Offset: 0x0041ACF0
		public IGameCurrBreakNodeEventInfoT UnPack()
		{
			IGameCurrBreakNodeEventInfoT gameCurrBreakNodeEventInfoT = new IGameCurrBreakNodeEventInfoT();
			this.UnPackTo(gameCurrBreakNodeEventInfoT);
			return gameCurrBreakNodeEventInfoT;
		}

		// Token: 0x0601D47A RID: 119930 RVA: 0x0041CB0B File Offset: 0x0041AD0B
		public void UnPackTo(IGameCurrBreakNodeEventInfoT _o)
		{
			_o.BtConfigId = this.BtConfigId;
			_o.BtEditorType = this.BtEditorType;
			_o.NodeId = this.NodeId;
			_o.BreakMoment = this.BreakMoment;
		}

		// Token: 0x0601D47B RID: 119931 RVA: 0x0041CB40 File Offset: 0x0041AD40
		public static Offset<IGameCurrBreakNodeEventInfo> Pack(FlatBufferBuilder builder, IGameCurrBreakNodeEventInfoT _o)
		{
			if (_o == null)
			{
				return default(Offset<IGameCurrBreakNodeEventInfo>);
			}
			return IGameCurrBreakNodeEventInfo.CreateIGameCurrBreakNodeEventInfo(builder, _o.BtConfigId, _o.BtEditorType, _o.NodeId, _o.BreakMoment);
		}

		// Token: 0x0400D3C4 RID: 54212
		private Table __p;
	}
}
