using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x020050A6 RID: 20646
	public struct IComparePlayerMotionState : IFlatbufferObject
	{
		// Token: 0x170093DE RID: 37854
		// (get) Token: 0x06020504 RID: 132356 RVA: 0x00479B60 File Offset: 0x00477D60
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06020505 RID: 132357 RVA: 0x00479B6D File Offset: 0x00477D6D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06020506 RID: 132358 RVA: 0x00479B74 File Offset: 0x00477D74
		public static IComparePlayerMotionState GetRootAsIComparePlayerMotionState(ByteBuffer _bb)
		{
			return IComparePlayerMotionState.GetRootAsIComparePlayerMotionState(_bb, default(IComparePlayerMotionState));
		}

		// Token: 0x06020507 RID: 132359 RVA: 0x00479B90 File Offset: 0x00477D90
		public static IComparePlayerMotionState GetRootAsIComparePlayerMotionState(ByteBuffer _bb, IComparePlayerMotionState obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06020508 RID: 132360 RVA: 0x00479BAD File Offset: 0x00477DAD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06020509 RID: 132361 RVA: 0x00479BBC File Offset: 0x00477DBC
		public IComparePlayerMotionState __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170093DF RID: 37855
		// (get) Token: 0x0602050A RID: 132362 RVA: 0x00479BCC File Offset: 0x00477DCC
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

		// Token: 0x170093E0 RID: 37856
		// (get) Token: 0x0602050B RID: 132363 RVA: 0x00479C08 File Offset: 0x00477E08
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

		// Token: 0x170093E1 RID: 37857
		// (get) Token: 0x0602050C RID: 132364 RVA: 0x00479C44 File Offset: 0x00477E44
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

		// Token: 0x170093E2 RID: 37858
		// (get) Token: 0x0602050D RID: 132365 RVA: 0x00479C80 File Offset: 0x00477E80
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

		// Token: 0x0602050E RID: 132366 RVA: 0x00479CC0 File Offset: 0x00477EC0
		public TTable? OnlinePlayerConditionTargetOption<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0602050F RID: 132367 RVA: 0x00479D08 File Offset: 0x00477F08
		public IOnlinePlayerConditionTargetHost OnlinePlayerConditionTargetOptionAsIOnlinePlayerConditionTargetHost()
		{
			return this.OnlinePlayerConditionTargetOption<IOnlinePlayerConditionTargetHost>().Value;
		}

		// Token: 0x06020510 RID: 132368 RVA: 0x00479D24 File Offset: 0x00477F24
		public IOnlinePlayerConditionTargetParticipator OnlinePlayerConditionTargetOptionAsIOnlinePlayerConditionTargetParticipator()
		{
			return this.OnlinePlayerConditionTargetOption<IOnlinePlayerConditionTargetParticipator>().Value;
		}

		// Token: 0x06020511 RID: 132369 RVA: 0x00479D3F File Offset: 0x00477F3F
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

		// Token: 0x06020512 RID: 132370 RVA: 0x00479D73 File Offset: 0x00477F73
		public static void StartIComparePlayerMotionState(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x06020513 RID: 132371 RVA: 0x00479D7C File Offset: 0x00477F7C
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06020514 RID: 132372 RVA: 0x00479D87 File Offset: 0x00477F87
		public static void AddMotionState(FlatBufferBuilder builder, EPlayerMotionState motionState)
		{
			builder.AddByte(1, (byte)motionState, 0);
		}

		// Token: 0x06020515 RID: 132373 RVA: 0x00479D92 File Offset: 0x00477F92
		public static void AddCompare(FlatBufferBuilder builder, ECompare compare)
		{
			builder.AddByte(2, (byte)compare, 0);
		}

		// Token: 0x06020516 RID: 132374 RVA: 0x00479D9D File Offset: 0x00477F9D
		public static void AddOnlinePlayerConditionTargetOptionType(FlatBufferBuilder builder, TOnlinePlayerConditionTarget onlinePlayerConditionTargetOptionType)
		{
			builder.AddByte(3, (byte)onlinePlayerConditionTargetOptionType, 0);
		}

		// Token: 0x06020517 RID: 132375 RVA: 0x00479DA8 File Offset: 0x00477FA8
		public static void AddOnlinePlayerConditionTargetOption(FlatBufferBuilder builder, int onlinePlayerConditionTargetOptionOffset)
		{
			builder.AddOffset(4, onlinePlayerConditionTargetOptionOffset, 0);
		}

		// Token: 0x06020518 RID: 132376 RVA: 0x00479DB3 File Offset: 0x00477FB3
		public static Offset<IComparePlayerMotionState> EndIComparePlayerMotionState(FlatBufferBuilder builder)
		{
			return new Offset<IComparePlayerMotionState>(builder.EndTable());
		}

		// Token: 0x06020519 RID: 132377 RVA: 0x00479DC0 File Offset: 0x00477FC0
		public IComparePlayerMotionStateT UnPack()
		{
			IComparePlayerMotionStateT comparePlayerMotionStateT = new IComparePlayerMotionStateT();
			this.UnPackTo(comparePlayerMotionStateT);
			return comparePlayerMotionStateT;
		}

		// Token: 0x0602051A RID: 132378 RVA: 0x00479DDC File Offset: 0x00477FDC
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

		// Token: 0x0602051B RID: 132379 RVA: 0x00479EA4 File Offset: 0x004780A4
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

		// Token: 0x0400DFA7 RID: 57255
		private Table __p;
	}
}
