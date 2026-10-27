using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004B02 RID: 19202
	public struct ICheckPlayerStateRestrictionCondition : IFlatbufferObject
	{
		// Token: 0x17008B46 RID: 35654
		// (get) Token: 0x0601E30A RID: 123658 RVA: 0x0043BD2C File Offset: 0x00439F2C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601E30B RID: 123659 RVA: 0x0043BD39 File Offset: 0x00439F39
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601E30C RID: 123660 RVA: 0x0043BD40 File Offset: 0x00439F40
		public static ICheckPlayerStateRestrictionCondition GetRootAsICheckPlayerStateRestrictionCondition(ByteBuffer _bb)
		{
			return ICheckPlayerStateRestrictionCondition.GetRootAsICheckPlayerStateRestrictionCondition(_bb, default(ICheckPlayerStateRestrictionCondition));
		}

		// Token: 0x0601E30D RID: 123661 RVA: 0x0043BD5C File Offset: 0x00439F5C
		public static ICheckPlayerStateRestrictionCondition GetRootAsICheckPlayerStateRestrictionCondition(ByteBuffer _bb, ICheckPlayerStateRestrictionCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601E30E RID: 123662 RVA: 0x0043BD79 File Offset: 0x00439F79
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601E30F RID: 123663 RVA: 0x0043BD88 File Offset: 0x00439F88
		public ICheckPlayerStateRestrictionCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008B47 RID: 35655
		// (get) Token: 0x0601E310 RID: 123664 RVA: 0x0043BD98 File Offset: 0x00439F98
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

		// Token: 0x17008B48 RID: 35656
		// (get) Token: 0x0601E311 RID: 123665 RVA: 0x0043BDD4 File Offset: 0x00439FD4
		public int RestrictionId
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17008B49 RID: 35657
		// (get) Token: 0x0601E312 RID: 123666 RVA: 0x0043BE10 File Offset: 0x0043A010
		public TOnlinePlayerConditionTarget OnlinePlayerConditionTargetOptionType
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return TOnlinePlayerConditionTarget.NONE;
				}
				return (TOnlinePlayerConditionTarget)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601E313 RID: 123667 RVA: 0x0043BE4C File Offset: 0x0043A04C
		public TTable? OnlinePlayerConditionTargetOption<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0601E314 RID: 123668 RVA: 0x0043BE94 File Offset: 0x0043A094
		public IOnlinePlayerConditionTargetHost OnlinePlayerConditionTargetOptionAsIOnlinePlayerConditionTargetHost()
		{
			return this.OnlinePlayerConditionTargetOption<IOnlinePlayerConditionTargetHost>().Value;
		}

		// Token: 0x0601E315 RID: 123669 RVA: 0x0043BEB0 File Offset: 0x0043A0B0
		public IOnlinePlayerConditionTargetParticipator OnlinePlayerConditionTargetOptionAsIOnlinePlayerConditionTargetParticipator()
		{
			return this.OnlinePlayerConditionTargetOption<IOnlinePlayerConditionTargetParticipator>().Value;
		}

		// Token: 0x0601E316 RID: 123670 RVA: 0x0043BECB File Offset: 0x0043A0CB
		public static Offset<ICheckPlayerStateRestrictionCondition> CreateICheckPlayerStateRestrictionCondition(FlatBufferBuilder builder, ECondition Type = ECondition.CompareVar, int RestrictionId = 0, TOnlinePlayerConditionTarget OnlinePlayerConditionTargetOption_type = TOnlinePlayerConditionTarget.NONE, int OnlinePlayerConditionTargetOptionOffset = 0)
		{
			builder.StartTable(4);
			ICheckPlayerStateRestrictionCondition.AddOnlinePlayerConditionTargetOption(builder, OnlinePlayerConditionTargetOptionOffset);
			ICheckPlayerStateRestrictionCondition.AddRestrictionId(builder, RestrictionId);
			ICheckPlayerStateRestrictionCondition.AddOnlinePlayerConditionTargetOptionType(builder, OnlinePlayerConditionTargetOption_type);
			ICheckPlayerStateRestrictionCondition.AddType(builder, Type);
			return ICheckPlayerStateRestrictionCondition.EndICheckPlayerStateRestrictionCondition(builder);
		}

		// Token: 0x0601E317 RID: 123671 RVA: 0x0043BEF7 File Offset: 0x0043A0F7
		public static void StartICheckPlayerStateRestrictionCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0601E318 RID: 123672 RVA: 0x0043BF00 File Offset: 0x0043A100
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601E319 RID: 123673 RVA: 0x0043BF0B File Offset: 0x0043A10B
		public static void AddRestrictionId(FlatBufferBuilder builder, int restrictionId)
		{
			builder.AddInt(1, restrictionId, 0);
		}

		// Token: 0x0601E31A RID: 123674 RVA: 0x0043BF16 File Offset: 0x0043A116
		public static void AddOnlinePlayerConditionTargetOptionType(FlatBufferBuilder builder, TOnlinePlayerConditionTarget onlinePlayerConditionTargetOptionType)
		{
			builder.AddByte(2, (byte)onlinePlayerConditionTargetOptionType, 0);
		}

		// Token: 0x0601E31B RID: 123675 RVA: 0x0043BF21 File Offset: 0x0043A121
		public static void AddOnlinePlayerConditionTargetOption(FlatBufferBuilder builder, int onlinePlayerConditionTargetOptionOffset)
		{
			builder.AddOffset(3, onlinePlayerConditionTargetOptionOffset, 0);
		}

		// Token: 0x0601E31C RID: 123676 RVA: 0x0043BF2C File Offset: 0x0043A12C
		public static Offset<ICheckPlayerStateRestrictionCondition> EndICheckPlayerStateRestrictionCondition(FlatBufferBuilder builder)
		{
			return new Offset<ICheckPlayerStateRestrictionCondition>(builder.EndTable());
		}

		// Token: 0x0601E31D RID: 123677 RVA: 0x0043BF3C File Offset: 0x0043A13C
		public ICheckPlayerStateRestrictionConditionT UnPack()
		{
			ICheckPlayerStateRestrictionConditionT checkPlayerStateRestrictionConditionT = new ICheckPlayerStateRestrictionConditionT();
			this.UnPackTo(checkPlayerStateRestrictionConditionT);
			return checkPlayerStateRestrictionConditionT;
		}

		// Token: 0x0601E31E RID: 123678 RVA: 0x0043BF58 File Offset: 0x0043A158
		public void UnPackTo(ICheckPlayerStateRestrictionConditionT _o)
		{
			_o.Type = this.Type;
			_o.RestrictionId = this.RestrictionId;
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

		// Token: 0x0601E31F RID: 123679 RVA: 0x0043C014 File Offset: 0x0043A214
		public static Offset<ICheckPlayerStateRestrictionCondition> Pack(FlatBufferBuilder builder, ICheckPlayerStateRestrictionConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckPlayerStateRestrictionCondition>);
			}
			TOnlinePlayerConditionTarget onlinePlayerConditionTargetOption_type = (_o.OnlinePlayerConditionTargetOption == null) ? TOnlinePlayerConditionTarget.NONE : _o.OnlinePlayerConditionTargetOption.Type;
			int onlinePlayerConditionTargetOptionOffset = (_o.OnlinePlayerConditionTargetOption == null) ? 0 : TOnlinePlayerConditionTargetUnion.Pack(builder, _o.OnlinePlayerConditionTargetOption);
			return ICheckPlayerStateRestrictionCondition.CreateICheckPlayerStateRestrictionCondition(builder, _o.Type, _o.RestrictionId, onlinePlayerConditionTargetOption_type, onlinePlayerConditionTargetOptionOffset);
		}

		// Token: 0x0400D39A RID: 54170
		private Table __p;
	}
}
