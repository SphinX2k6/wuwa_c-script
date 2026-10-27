using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004BBC RID: 19388
	public struct IComparePlayerMotionState : IFlatbufferObject
	{
		// Token: 0x17008CC5 RID: 36037
		// (get) Token: 0x0601E958 RID: 125272 RVA: 0x00446FFC File Offset: 0x004451FC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601E959 RID: 125273 RVA: 0x00447009 File Offset: 0x00445209
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601E95A RID: 125274 RVA: 0x00447010 File Offset: 0x00445210
		public static IComparePlayerMotionState GetRootAsIComparePlayerMotionState(ByteBuffer _bb)
		{
			return IComparePlayerMotionState.GetRootAsIComparePlayerMotionState(_bb, default(IComparePlayerMotionState));
		}

		// Token: 0x0601E95B RID: 125275 RVA: 0x0044702C File Offset: 0x0044522C
		public static IComparePlayerMotionState GetRootAsIComparePlayerMotionState(ByteBuffer _bb, IComparePlayerMotionState obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601E95C RID: 125276 RVA: 0x00447049 File Offset: 0x00445249
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601E95D RID: 125277 RVA: 0x00447058 File Offset: 0x00445258
		public IComparePlayerMotionState __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008CC6 RID: 36038
		// (get) Token: 0x0601E95E RID: 125278 RVA: 0x00447068 File Offset: 0x00445268
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

		// Token: 0x17008CC7 RID: 36039
		// (get) Token: 0x0601E95F RID: 125279 RVA: 0x004470A4 File Offset: 0x004452A4
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

		// Token: 0x17008CC8 RID: 36040
		// (get) Token: 0x0601E960 RID: 125280 RVA: 0x004470E0 File Offset: 0x004452E0
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

		// Token: 0x17008CC9 RID: 36041
		// (get) Token: 0x0601E961 RID: 125281 RVA: 0x0044711C File Offset: 0x0044531C
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

		// Token: 0x0601E962 RID: 125282 RVA: 0x0044715C File Offset: 0x0044535C
		public TTable? OnlinePlayerConditionTargetOption<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0601E963 RID: 125283 RVA: 0x004471A4 File Offset: 0x004453A4
		public IOnlinePlayerConditionTargetHost OnlinePlayerConditionTargetOptionAsIOnlinePlayerConditionTargetHost()
		{
			return this.OnlinePlayerConditionTargetOption<IOnlinePlayerConditionTargetHost>().Value;
		}

		// Token: 0x0601E964 RID: 125284 RVA: 0x004471C0 File Offset: 0x004453C0
		public IOnlinePlayerConditionTargetParticipator OnlinePlayerConditionTargetOptionAsIOnlinePlayerConditionTargetParticipator()
		{
			return this.OnlinePlayerConditionTargetOption<IOnlinePlayerConditionTargetParticipator>().Value;
		}

		// Token: 0x0601E965 RID: 125285 RVA: 0x004471DB File Offset: 0x004453DB
		public static Offset<IComparePlayerMotionState> CreateIComparePlayerMotionState(FlatBufferBuilder builder, ECondition Type = ECondition.CompareVar, EPlayerMotionState MotionState = EPlayerMotionState.Ground, ECompare Compare = ECompare.Eq, TOnlinePlayerConditionTarget OnlinePlayerConditionTargetOption_type = TOnlinePlayerConditionTarget.NONE, int OnlinePlayerConditionTargetOptionOffset = 0)
		{
			builder.StartTable(5);
			IComparePlayerMotionState.AddOnlinePlayerConditionTargetOption(builder, OnlinePlayerConditionTargetOptionOffset);
			IComparePlayerMotionState.AddOnlinePlayerConditionTargetOptionType(builder, OnlinePlayerConditionTargetOption_type);
			IComparePlayerMotionState.AddCompare(builder, Compare);
			IComparePlayerMotionState.AddMotionState(builder, MotionState);
			IComparePlayerMotionState.AddType(builder, Type);
			return IComparePlayerMotionState.EndIComparePlayerMotionState(builder);
		}

		// Token: 0x0601E966 RID: 125286 RVA: 0x0044720F File Offset: 0x0044540F
		public static void StartIComparePlayerMotionState(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x0601E967 RID: 125287 RVA: 0x00447218 File Offset: 0x00445418
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601E968 RID: 125288 RVA: 0x00447223 File Offset: 0x00445423
		public static void AddMotionState(FlatBufferBuilder builder, EPlayerMotionState motionState)
		{
			builder.AddByte(1, (byte)motionState, 0);
		}

		// Token: 0x0601E969 RID: 125289 RVA: 0x0044722E File Offset: 0x0044542E
		public static void AddCompare(FlatBufferBuilder builder, ECompare compare)
		{
			builder.AddByte(2, (byte)compare, 0);
		}

		// Token: 0x0601E96A RID: 125290 RVA: 0x00447239 File Offset: 0x00445439
		public static void AddOnlinePlayerConditionTargetOptionType(FlatBufferBuilder builder, TOnlinePlayerConditionTarget onlinePlayerConditionTargetOptionType)
		{
			builder.AddByte(3, (byte)onlinePlayerConditionTargetOptionType, 0);
		}

		// Token: 0x0601E96B RID: 125291 RVA: 0x00447244 File Offset: 0x00445444
		public static void AddOnlinePlayerConditionTargetOption(FlatBufferBuilder builder, int onlinePlayerConditionTargetOptionOffset)
		{
			builder.AddOffset(4, onlinePlayerConditionTargetOptionOffset, 0);
		}

		// Token: 0x0601E96C RID: 125292 RVA: 0x0044724F File Offset: 0x0044544F
		public static Offset<IComparePlayerMotionState> EndIComparePlayerMotionState(FlatBufferBuilder builder)
		{
			return new Offset<IComparePlayerMotionState>(builder.EndTable());
		}

		// Token: 0x0601E96D RID: 125293 RVA: 0x0044725C File Offset: 0x0044545C
		public IComparePlayerMotionStateT UnPack()
		{
			IComparePlayerMotionStateT comparePlayerMotionStateT = new IComparePlayerMotionStateT();
			this.UnPackTo(comparePlayerMotionStateT);
			return comparePlayerMotionStateT;
		}

		// Token: 0x0601E96E RID: 125294 RVA: 0x00447278 File Offset: 0x00445478
		public void UnPackTo(IComparePlayerMotionStateT _o)
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

		// Token: 0x0601E96F RID: 125295 RVA: 0x00447340 File Offset: 0x00445540
		public static Offset<IComparePlayerMotionState> Pack(FlatBufferBuilder builder, IComparePlayerMotionStateT _o)
		{
			if (_o == null)
			{
				return default(Offset<IComparePlayerMotionState>);
			}
			TOnlinePlayerConditionTarget onlinePlayerConditionTargetOption_type = (_o.OnlinePlayerConditionTargetOption == null) ? TOnlinePlayerConditionTarget.NONE : _o.OnlinePlayerConditionTargetOption.Type;
			int onlinePlayerConditionTargetOptionOffset = (_o.OnlinePlayerConditionTargetOption == null) ? 0 : TOnlinePlayerConditionTargetUnion.Pack(builder, _o.OnlinePlayerConditionTargetOption);
			return IComparePlayerMotionState.CreateIComparePlayerMotionState(builder, _o.Type, _o.MotionState, _o.Compare, onlinePlayerConditionTargetOption_type, onlinePlayerConditionTargetOptionOffset);
		}

		// Token: 0x0400D4A2 RID: 54434
		private Table __p;
	}
}
