using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004FA4 RID: 20388
	public struct ICheckOnlinePlayer : IFlatbufferObject
	{
		// Token: 0x170091D1 RID: 37329
		// (get) Token: 0x0601FC43 RID: 130115 RVA: 0x00469E88 File Offset: 0x00468088
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601FC44 RID: 130116 RVA: 0x00469E95 File Offset: 0x00468095
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601FC45 RID: 130117 RVA: 0x00469E9C File Offset: 0x0046809C
		public static ICheckOnlinePlayer GetRootAsICheckOnlinePlayer(ByteBuffer _bb)
		{
			return ICheckOnlinePlayer.GetRootAsICheckOnlinePlayer(_bb, default(ICheckOnlinePlayer));
		}

		// Token: 0x0601FC46 RID: 130118 RVA: 0x00469EB8 File Offset: 0x004680B8
		public static ICheckOnlinePlayer GetRootAsICheckOnlinePlayer(ByteBuffer _bb, ICheckOnlinePlayer obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601FC47 RID: 130119 RVA: 0x00469ED5 File Offset: 0x004680D5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601FC48 RID: 130120 RVA: 0x00469EE4 File Offset: 0x004680E4
		public ICheckOnlinePlayer __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170091D2 RID: 37330
		// (get) Token: 0x0601FC49 RID: 130121 RVA: 0x00469EF4 File Offset: 0x004680F4
		public ECheckEntity Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECheckEntity.OnlinePlayer;
				}
				return (ECheckEntity)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170091D3 RID: 37331
		// (get) Token: 0x0601FC4A RID: 130122 RVA: 0x00469F30 File Offset: 0x00468130
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

		// Token: 0x0601FC4B RID: 130123 RVA: 0x00469F6C File Offset: 0x0046816C
		public TTable? OnlinePlayerConditionTargetOption<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0601FC4C RID: 130124 RVA: 0x00469FB0 File Offset: 0x004681B0
		public IOnlinePlayerConditionTargetHost OnlinePlayerConditionTargetOptionAsIOnlinePlayerConditionTargetHost()
		{
			return this.OnlinePlayerConditionTargetOption<IOnlinePlayerConditionTargetHost>().Value;
		}

		// Token: 0x0601FC4D RID: 130125 RVA: 0x00469FCC File Offset: 0x004681CC
		public IOnlinePlayerConditionTargetParticipator OnlinePlayerConditionTargetOptionAsIOnlinePlayerConditionTargetParticipator()
		{
			return this.OnlinePlayerConditionTargetOption<IOnlinePlayerConditionTargetParticipator>().Value;
		}

		// Token: 0x0601FC4E RID: 130126 RVA: 0x00469FE7 File Offset: 0x004681E7
		public static Offset<ICheckOnlinePlayer> CreateICheckOnlinePlayer(FlatBufferBuilder builder, ECheckEntity Type = ECheckEntity.OnlinePlayer, TOnlinePlayerConditionTarget OnlinePlayerConditionTargetOption_type = TOnlinePlayerConditionTarget.NONE, int OnlinePlayerConditionTargetOptionOffset = 0)
		{
			builder.StartTable(3);
			ICheckOnlinePlayer.AddOnlinePlayerConditionTargetOption(builder, OnlinePlayerConditionTargetOptionOffset);
			ICheckOnlinePlayer.AddOnlinePlayerConditionTargetOptionType(builder, OnlinePlayerConditionTargetOption_type);
			ICheckOnlinePlayer.AddType(builder, Type);
			return ICheckOnlinePlayer.EndICheckOnlinePlayer(builder);
		}

		// Token: 0x0601FC4F RID: 130127 RVA: 0x0046A00B File Offset: 0x0046820B
		public static void StartICheckOnlinePlayer(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601FC50 RID: 130128 RVA: 0x0046A014 File Offset: 0x00468214
		public static void AddType(FlatBufferBuilder builder, ECheckEntity type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601FC51 RID: 130129 RVA: 0x0046A01F File Offset: 0x0046821F
		public static void AddOnlinePlayerConditionTargetOptionType(FlatBufferBuilder builder, TOnlinePlayerConditionTarget onlinePlayerConditionTargetOptionType)
		{
			builder.AddByte(1, (byte)onlinePlayerConditionTargetOptionType, 0);
		}

		// Token: 0x0601FC52 RID: 130130 RVA: 0x0046A02A File Offset: 0x0046822A
		public static void AddOnlinePlayerConditionTargetOption(FlatBufferBuilder builder, int onlinePlayerConditionTargetOptionOffset)
		{
			builder.AddOffset(2, onlinePlayerConditionTargetOptionOffset, 0);
		}

		// Token: 0x0601FC53 RID: 130131 RVA: 0x0046A035 File Offset: 0x00468235
		public static Offset<ICheckOnlinePlayer> EndICheckOnlinePlayer(FlatBufferBuilder builder)
		{
			return new Offset<ICheckOnlinePlayer>(builder.EndTable());
		}

		// Token: 0x0601FC54 RID: 130132 RVA: 0x0046A044 File Offset: 0x00468244
		public ICheckOnlinePlayerT UnPack()
		{
			ICheckOnlinePlayerT checkOnlinePlayerT = new ICheckOnlinePlayerT();
			this.UnPackTo(checkOnlinePlayerT);
			return checkOnlinePlayerT;
		}

		// Token: 0x0601FC55 RID: 130133 RVA: 0x0046A060 File Offset: 0x00468260
		public void UnPackTo(ICheckOnlinePlayerT _o)
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

		// Token: 0x0601FC56 RID: 130134 RVA: 0x0046A110 File Offset: 0x00468310
		public static Offset<ICheckOnlinePlayer> Pack(FlatBufferBuilder builder, ICheckOnlinePlayerT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckOnlinePlayer>);
			}
			TOnlinePlayerConditionTarget onlinePlayerConditionTargetOption_type = (_o.OnlinePlayerConditionTargetOption == null) ? TOnlinePlayerConditionTarget.NONE : _o.OnlinePlayerConditionTargetOption.Type;
			int onlinePlayerConditionTargetOptionOffset = (_o.OnlinePlayerConditionTargetOption == null) ? 0 : TOnlinePlayerConditionTargetUnion.Pack(builder, _o.OnlinePlayerConditionTargetOption);
			return ICheckOnlinePlayer.CreateICheckOnlinePlayer(builder, _o.Type, onlinePlayerConditionTargetOption_type, onlinePlayerConditionTargetOptionOffset);
		}

		// Token: 0x0400DE43 RID: 56899
		private Table __p;
	}
}
