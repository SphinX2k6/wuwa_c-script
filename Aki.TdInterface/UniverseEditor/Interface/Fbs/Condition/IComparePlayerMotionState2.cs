using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x020050A9 RID: 20649
	public struct IComparePlayerMotionState2 : IFlatbufferObject
	{
		// Token: 0x170093E7 RID: 37863
		// (get) Token: 0x06020526 RID: 132390 RVA: 0x00479FF5 File Offset: 0x004781F5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06020527 RID: 132391 RVA: 0x0047A002 File Offset: 0x00478202
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06020528 RID: 132392 RVA: 0x0047A00C File Offset: 0x0047820C
		public static IComparePlayerMotionState2 GetRootAsIComparePlayerMotionState2(ByteBuffer _bb)
		{
			return IComparePlayerMotionState2.GetRootAsIComparePlayerMotionState2(_bb, default(IComparePlayerMotionState2));
		}

		// Token: 0x06020529 RID: 132393 RVA: 0x0047A028 File Offset: 0x00478228
		public static IComparePlayerMotionState2 GetRootAsIComparePlayerMotionState2(ByteBuffer _bb, IComparePlayerMotionState2 obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602052A RID: 132394 RVA: 0x0047A045 File Offset: 0x00478245
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602052B RID: 132395 RVA: 0x0047A054 File Offset: 0x00478254
		public IComparePlayerMotionState2 __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170093E8 RID: 37864
		// (get) Token: 0x0602052C RID: 132396 RVA: 0x0047A064 File Offset: 0x00478264
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

		// Token: 0x170093E9 RID: 37865
		// (get) Token: 0x0602052D RID: 132397 RVA: 0x0047A0A0 File Offset: 0x004782A0
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

		// Token: 0x170093EA RID: 37866
		// (get) Token: 0x0602052E RID: 132398 RVA: 0x0047A0DC File Offset: 0x004782DC
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

		// Token: 0x170093EB RID: 37867
		// (get) Token: 0x0602052F RID: 132399 RVA: 0x0047A118 File Offset: 0x00478318
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

		// Token: 0x06020530 RID: 132400 RVA: 0x0047A158 File Offset: 0x00478358
		public TTable? OnlinePlayerConditionTargetOption<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06020531 RID: 132401 RVA: 0x0047A1A0 File Offset: 0x004783A0
		public IOnlinePlayerConditionTargetHost OnlinePlayerConditionTargetOptionAsIOnlinePlayerConditionTargetHost()
		{
			return this.OnlinePlayerConditionTargetOption<IOnlinePlayerConditionTargetHost>().Value;
		}

		// Token: 0x06020532 RID: 132402 RVA: 0x0047A1BC File Offset: 0x004783BC
		public IOnlinePlayerConditionTargetParticipator OnlinePlayerConditionTargetOptionAsIOnlinePlayerConditionTargetParticipator()
		{
			return this.OnlinePlayerConditionTargetOption<IOnlinePlayerConditionTargetParticipator>().Value;
		}

		// Token: 0x06020533 RID: 132403 RVA: 0x0047A1D7 File Offset: 0x004783D7
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

		// Token: 0x06020534 RID: 132404 RVA: 0x0047A20B File Offset: 0x0047840B
		public static void StartIComparePlayerMotionState2(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x06020535 RID: 132405 RVA: 0x0047A214 File Offset: 0x00478414
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06020536 RID: 132406 RVA: 0x0047A21F File Offset: 0x0047841F
		public static void AddMotionState(FlatBufferBuilder builder, EPlayerMotionState motionState)
		{
			builder.AddByte(1, (byte)motionState, 0);
		}

		// Token: 0x06020537 RID: 132407 RVA: 0x0047A22A File Offset: 0x0047842A
		public static void AddCompare(FlatBufferBuilder builder, ECompare compare)
		{
			builder.AddByte(2, (byte)compare, 0);
		}

		// Token: 0x06020538 RID: 132408 RVA: 0x0047A235 File Offset: 0x00478435
		public static void AddOnlinePlayerConditionTargetOptionType(FlatBufferBuilder builder, TOnlinePlayerConditionTarget onlinePlayerConditionTargetOptionType)
		{
			builder.AddByte(3, (byte)onlinePlayerConditionTargetOptionType, 0);
		}

		// Token: 0x06020539 RID: 132409 RVA: 0x0047A240 File Offset: 0x00478440
		public static void AddOnlinePlayerConditionTargetOption(FlatBufferBuilder builder, int onlinePlayerConditionTargetOptionOffset)
		{
			builder.AddOffset(4, onlinePlayerConditionTargetOptionOffset, 0);
		}

		// Token: 0x0602053A RID: 132410 RVA: 0x0047A24B File Offset: 0x0047844B
		public static Offset<IComparePlayerMotionState2> EndIComparePlayerMotionState2(FlatBufferBuilder builder)
		{
			return new Offset<IComparePlayerMotionState2>(builder.EndTable());
		}

		// Token: 0x0602053B RID: 132411 RVA: 0x0047A258 File Offset: 0x00478458
		public IComparePlayerMotionState2T UnPack()
		{
			IComparePlayerMotionState2T comparePlayerMotionState2T = new IComparePlayerMotionState2T();
			this.UnPackTo(comparePlayerMotionState2T);
			return comparePlayerMotionState2T;
		}

		// Token: 0x0602053C RID: 132412 RVA: 0x0047A274 File Offset: 0x00478474
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

		// Token: 0x0602053D RID: 132413 RVA: 0x0047A33C File Offset: 0x0047853C
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

		// Token: 0x0400DFAC RID: 57260
		private Table __p;
	}
}
