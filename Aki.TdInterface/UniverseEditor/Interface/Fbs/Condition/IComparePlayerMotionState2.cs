using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004BBF RID: 19391
	public struct IComparePlayerMotionState2 : IFlatbufferObject
	{
		// Token: 0x17008CCE RID: 36046
		// (get) Token: 0x0601E97A RID: 125306 RVA: 0x00447491 File Offset: 0x00445691
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601E97B RID: 125307 RVA: 0x0044749E File Offset: 0x0044569E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601E97C RID: 125308 RVA: 0x004474A8 File Offset: 0x004456A8
		public static IComparePlayerMotionState2 GetRootAsIComparePlayerMotionState2(ByteBuffer _bb)
		{
			return IComparePlayerMotionState2.GetRootAsIComparePlayerMotionState2(_bb, default(IComparePlayerMotionState2));
		}

		// Token: 0x0601E97D RID: 125309 RVA: 0x004474C4 File Offset: 0x004456C4
		public static IComparePlayerMotionState2 GetRootAsIComparePlayerMotionState2(ByteBuffer _bb, IComparePlayerMotionState2 obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601E97E RID: 125310 RVA: 0x004474E1 File Offset: 0x004456E1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601E97F RID: 125311 RVA: 0x004474F0 File Offset: 0x004456F0
		public IComparePlayerMotionState2 __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008CCF RID: 36047
		// (get) Token: 0x0601E980 RID: 125312 RVA: 0x00447500 File Offset: 0x00445700
		public ECondition Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECondition.CompareVar;
				}
				return (ECondition)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17008CD0 RID: 36048
		// (get) Token: 0x0601E981 RID: 125313 RVA: 0x0044753C File Offset: 0x0044573C
		public EPlayerMotionState MotionState
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return EPlayerMotionState.Ground;
				}
				return (EPlayerMotionState)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17008CD1 RID: 36049
		// (get) Token: 0x0601E982 RID: 125314 RVA: 0x00447578 File Offset: 0x00445778
		public ECompare Compare
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return ECompare.Eq;
				}
				return (ECompare)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17008CD2 RID: 36050
		// (get) Token: 0x0601E983 RID: 125315 RVA: 0x004475B4 File Offset: 0x004457B4
		public TOnlinePlayerConditionTarget OnlinePlayerConditionTargetOptionType
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return TOnlinePlayerConditionTarget.NONE;
				}
				return (TOnlinePlayerConditionTarget)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601E984 RID: 125316 RVA: 0x004475F4 File Offset: 0x004457F4
		public TTable? OnlinePlayerConditionTargetOption<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0601E985 RID: 125317 RVA: 0x0044763C File Offset: 0x0044583C
		public IOnlinePlayerConditionTargetHost OnlinePlayerConditionTargetOptionAsIOnlinePlayerConditionTargetHost()
		{
			return this.OnlinePlayerConditionTargetOption<IOnlinePlayerConditionTargetHost>().Value;
		}

		// Token: 0x0601E986 RID: 125318 RVA: 0x00447658 File Offset: 0x00445858
		public IOnlinePlayerConditionTargetParticipator OnlinePlayerConditionTargetOptionAsIOnlinePlayerConditionTargetParticipator()
		{
			return this.OnlinePlayerConditionTargetOption<IOnlinePlayerConditionTargetParticipator>().Value;
		}

		// Token: 0x0601E987 RID: 125319 RVA: 0x00447673 File Offset: 0x00445873
		public static Offset<IComparePlayerMotionState2> CreateIComparePlayerMotionState2(FlatBufferBuilder builder, ECondition Type = ECondition.CompareVar, EPlayerMotionState MotionState = EPlayerMotionState.Ground, ECompare Compare = ECompare.Eq, TOnlinePlayerConditionTarget OnlinePlayerConditionTargetOption_type = TOnlinePlayerConditionTarget.NONE, int OnlinePlayerConditionTargetOptionOffset = 0)
		{
			builder.StartTable(5);
			IComparePlayerMotionState2.AddOnlinePlayerConditionTargetOption(builder, OnlinePlayerConditionTargetOptionOffset);
			IComparePlayerMotionState2.AddOnlinePlayerConditionTargetOptionType(builder, OnlinePlayerConditionTargetOption_type);
			IComparePlayerMotionState2.AddCompare(builder, Compare);
			IComparePlayerMotionState2.AddMotionState(builder, MotionState);
			IComparePlayerMotionState2.AddType(builder, Type);
			return IComparePlayerMotionState2.EndIComparePlayerMotionState2(builder);
		}

		// Token: 0x0601E988 RID: 125320 RVA: 0x004476A7 File Offset: 0x004458A7
		public static void StartIComparePlayerMotionState2(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x0601E989 RID: 125321 RVA: 0x004476B0 File Offset: 0x004458B0
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601E98A RID: 125322 RVA: 0x004476BB File Offset: 0x004458BB
		public static void AddMotionState(FlatBufferBuilder builder, EPlayerMotionState motionState)
		{
			builder.AddByte(1, (byte)motionState, 0);
		}

		// Token: 0x0601E98B RID: 125323 RVA: 0x004476C6 File Offset: 0x004458C6
		public static void AddCompare(FlatBufferBuilder builder, ECompare compare)
		{
			builder.AddByte(2, (byte)compare, 0);
		}

		// Token: 0x0601E98C RID: 125324 RVA: 0x004476D1 File Offset: 0x004458D1
		public static void AddOnlinePlayerConditionTargetOptionType(FlatBufferBuilder builder, TOnlinePlayerConditionTarget onlinePlayerConditionTargetOptionType)
		{
			builder.AddByte(3, (byte)onlinePlayerConditionTargetOptionType, 0);
		}

		// Token: 0x0601E98D RID: 125325 RVA: 0x004476DC File Offset: 0x004458DC
		public static void AddOnlinePlayerConditionTargetOption(FlatBufferBuilder builder, int onlinePlayerConditionTargetOptionOffset)
		{
			builder.AddOffset(4, onlinePlayerConditionTargetOptionOffset, 0);
		}

		// Token: 0x0601E98E RID: 125326 RVA: 0x004476E7 File Offset: 0x004458E7
		public static Offset<IComparePlayerMotionState2> EndIComparePlayerMotionState2(FlatBufferBuilder builder)
		{
			return new Offset<IComparePlayerMotionState2>(builder.EndTable());
		}

		// Token: 0x0601E98F RID: 125327 RVA: 0x004476F4 File Offset: 0x004458F4
		public IComparePlayerMotionState2T UnPack()
		{
			IComparePlayerMotionState2T comparePlayerMotionState2T = new IComparePlayerMotionState2T();
			this.UnPackTo(comparePlayerMotionState2T);
			return comparePlayerMotionState2T;
		}

		// Token: 0x0601E990 RID: 125328 RVA: 0x00447710 File Offset: 0x00445910
		public void UnPackTo(IComparePlayerMotionState2T _o)
		{
			_o.Type = this.Type;
			_o.MotionState = this.MotionState;
			_o.Compare = this.Compare;
			_o.OnlinePlayerConditionTargetOption = new TOnlinePlayerConditionTargetUnion();
			_o.OnlinePlayerConditionTargetOption.Type = this.OnlinePlayerConditionTargetOptionType;
			TOnlinePlayerConditionTarget onlinePlayerConditionTargetOptionType = this.OnlinePlayerConditionTargetOptionType;
			if (onlinePlayerConditionTargetOptionType == TOnlinePlayerConditionTarget.IOnlinePlayerConditionTargetHost)
			{
				_o.OnlinePlayerConditionTargetOption.Value = ((this.OnlinePlayerConditionTargetOption<IOnlinePlayerConditionTargetHost>() != null) ? this.OnlinePlayerConditionTargetOption<IOnlinePlayerConditionTargetHost>().Value.UnPack() : null);
				return;
			}
			if (onlinePlayerConditionTargetOptionType != TOnlinePlayerConditionTarget.IOnlinePlayerConditionTargetParticipator)
			{
				return;
			}
			_o.OnlinePlayerConditionTargetOption.Value = ((this.OnlinePlayerConditionTargetOption<IOnlinePlayerConditionTargetParticipator>() != null) ? this.OnlinePlayerConditionTargetOption<IOnlinePlayerConditionTargetParticipator>().Value.UnPack() : null);
		}

		// Token: 0x0601E991 RID: 125329 RVA: 0x004477D8 File Offset: 0x004459D8
		public static Offset<IComparePlayerMotionState2> Pack(FlatBufferBuilder builder, IComparePlayerMotionState2T _o)
		{
			if (_o == null)
			{
				return default(Offset<IComparePlayerMotionState2>);
			}
			TOnlinePlayerConditionTarget onlinePlayerConditionTargetOption_type = (_o.OnlinePlayerConditionTargetOption == null) ? TOnlinePlayerConditionTarget.NONE : _o.OnlinePlayerConditionTargetOption.Type;
			int onlinePlayerConditionTargetOptionOffset = (_o.OnlinePlayerConditionTargetOption == null) ? 0 : TOnlinePlayerConditionTargetUnion.Pack(builder, _o.OnlinePlayerConditionTargetOption);
			return IComparePlayerMotionState2.CreateIComparePlayerMotionState2(builder, _o.Type, _o.MotionState, _o.Compare, onlinePlayerConditionTargetOption_type, onlinePlayerConditionTargetOptionOffset);
		}

		// Token: 0x0400D4A7 RID: 54439
		private Table __p;
	}
}
