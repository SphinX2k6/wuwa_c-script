using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02005166 RID: 20838
	public struct IPerfectDodgeCondition : IFlatbufferObject
	{
		// Token: 0x17009549 RID: 38217
		// (get) Token: 0x06020C7D RID: 134269 RVA: 0x0048A044 File Offset: 0x00488244
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06020C7E RID: 134270 RVA: 0x0048A051 File Offset: 0x00488251
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06020C7F RID: 134271 RVA: 0x0048A058 File Offset: 0x00488258
		public static IPerfectDodgeCondition GetRootAsIPerfectDodgeCondition(ByteBuffer _bb)
		{
			return IPerfectDodgeCondition.GetRootAsIPerfectDodgeCondition(_bb, default(IPerfectDodgeCondition));
		}

		// Token: 0x06020C80 RID: 134272 RVA: 0x0048A074 File Offset: 0x00488274
		public static IPerfectDodgeCondition GetRootAsIPerfectDodgeCondition(ByteBuffer _bb, IPerfectDodgeCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06020C81 RID: 134273 RVA: 0x0048A091 File Offset: 0x00488291
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06020C82 RID: 134274 RVA: 0x0048A0A0 File Offset: 0x004882A0
		public IPerfectDodgeCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700954A RID: 38218
		// (get) Token: 0x06020C83 RID: 134275 RVA: 0x0048A0B0 File Offset: 0x004882B0
		public EBattleConditionType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EBattleConditionType.BattleTag;
				}
				return (EBattleConditionType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700954B RID: 38219
		// (get) Token: 0x06020C84 RID: 134276 RVA: 0x0048A0EC File Offset: 0x004882EC
		public TOnlinePlayerConditionTarget OnlinePlayerConditionTargetOptionType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return TOnlinePlayerConditionTarget.NONE;
				}
				return (TOnlinePlayerConditionTarget)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06020C85 RID: 134277 RVA: 0x0048A128 File Offset: 0x00488328
		public TTable? OnlinePlayerConditionTargetOption<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06020C86 RID: 134278 RVA: 0x0048A16C File Offset: 0x0048836C
		public IOnlinePlayerConditionTargetHost OnlinePlayerConditionTargetOptionAsIOnlinePlayerConditionTargetHost()
		{
			return this.OnlinePlayerConditionTargetOption<IOnlinePlayerConditionTargetHost>().Value;
		}

		// Token: 0x06020C87 RID: 134279 RVA: 0x0048A188 File Offset: 0x00488388
		public IOnlinePlayerConditionTargetParticipator OnlinePlayerConditionTargetOptionAsIOnlinePlayerConditionTargetParticipator()
		{
			return this.OnlinePlayerConditionTargetOption<IOnlinePlayerConditionTargetParticipator>().Value;
		}

		// Token: 0x06020C88 RID: 134280 RVA: 0x0048A1A3 File Offset: 0x004883A3
		public static Offset<IPerfectDodgeCondition> CreateIPerfectDodgeCondition(FlatBufferBuilder builder, EBattleConditionType Type = EBattleConditionType.BattleTag, TOnlinePlayerConditionTarget OnlinePlayerConditionTargetOption_type = TOnlinePlayerConditionTarget.NONE, int OnlinePlayerConditionTargetOptionOffset = 0)
		{
			builder.StartTable(3);
			IPerfectDodgeCondition.AddOnlinePlayerConditionTargetOption(builder, OnlinePlayerConditionTargetOptionOffset);
			IPerfectDodgeCondition.AddOnlinePlayerConditionTargetOptionType(builder, OnlinePlayerConditionTargetOption_type);
			IPerfectDodgeCondition.AddType(builder, Type);
			return IPerfectDodgeCondition.EndIPerfectDodgeCondition(builder);
		}

		// Token: 0x06020C89 RID: 134281 RVA: 0x0048A1C7 File Offset: 0x004883C7
		public static void StartIPerfectDodgeCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06020C8A RID: 134282 RVA: 0x0048A1D0 File Offset: 0x004883D0
		public static void AddType(FlatBufferBuilder builder, EBattleConditionType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06020C8B RID: 134283 RVA: 0x0048A1DB File Offset: 0x004883DB
		public static void AddOnlinePlayerConditionTargetOptionType(FlatBufferBuilder builder, TOnlinePlayerConditionTarget onlinePlayerConditionTargetOptionType)
		{
			builder.AddByte(1, (byte)onlinePlayerConditionTargetOptionType, 0);
		}

		// Token: 0x06020C8C RID: 134284 RVA: 0x0048A1E6 File Offset: 0x004883E6
		public static void AddOnlinePlayerConditionTargetOption(FlatBufferBuilder builder, int onlinePlayerConditionTargetOptionOffset)
		{
			builder.AddOffset(2, onlinePlayerConditionTargetOptionOffset, 0);
		}

		// Token: 0x06020C8D RID: 134285 RVA: 0x0048A1F1 File Offset: 0x004883F1
		public static Offset<IPerfectDodgeCondition> EndIPerfectDodgeCondition(FlatBufferBuilder builder)
		{
			return new Offset<IPerfectDodgeCondition>(builder.EndTable());
		}

		// Token: 0x06020C8E RID: 134286 RVA: 0x0048A200 File Offset: 0x00488400
		public IPerfectDodgeConditionT UnPack()
		{
			IPerfectDodgeConditionT perfectDodgeConditionT = new IPerfectDodgeConditionT();
			this.UnPackTo(perfectDodgeConditionT);
			return perfectDodgeConditionT;
		}

		// Token: 0x06020C8F RID: 134287 RVA: 0x0048A21C File Offset: 0x0048841C
		public void UnPackTo(IPerfectDodgeConditionT _o)
		{
			_o.Type = this.Type;
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

		// Token: 0x06020C90 RID: 134288 RVA: 0x0048A2CC File Offset: 0x004884CC
		public static Offset<IPerfectDodgeCondition> Pack(FlatBufferBuilder builder, IPerfectDodgeConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPerfectDodgeCondition>);
			}
			TOnlinePlayerConditionTarget onlinePlayerConditionTargetOption_type = (_o.OnlinePlayerConditionTargetOption == null) ? TOnlinePlayerConditionTarget.NONE : _o.OnlinePlayerConditionTargetOption.Type;
			int onlinePlayerConditionTargetOptionOffset = (_o.OnlinePlayerConditionTargetOption == null) ? 0 : TOnlinePlayerConditionTargetUnion.Pack(builder, _o.OnlinePlayerConditionTargetOption);
			return IPerfectDodgeCondition.CreateIPerfectDodgeCondition(builder, _o.Type, onlinePlayerConditionTargetOption_type, onlinePlayerConditionTargetOptionOffset);
		}

		// Token: 0x0400E145 RID: 57669
		private Table __p;
	}
}
