using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004AD2 RID: 19154
	public struct ICheckOnlinePlayer : IFlatbufferObject
	{
		// Token: 0x17008ADF RID: 35551
		// (get) Token: 0x0601E144 RID: 123204 RVA: 0x004383DC File Offset: 0x004365DC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601E145 RID: 123205 RVA: 0x004383E9 File Offset: 0x004365E9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601E146 RID: 123206 RVA: 0x004383F0 File Offset: 0x004365F0
		public static ICheckOnlinePlayer GetRootAsICheckOnlinePlayer(ByteBuffer _bb)
		{
			return ICheckOnlinePlayer.GetRootAsICheckOnlinePlayer(_bb, default(ICheckOnlinePlayer));
		}

		// Token: 0x0601E147 RID: 123207 RVA: 0x0043840C File Offset: 0x0043660C
		public static ICheckOnlinePlayer GetRootAsICheckOnlinePlayer(ByteBuffer _bb, ICheckOnlinePlayer obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601E148 RID: 123208 RVA: 0x00438429 File Offset: 0x00436629
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601E149 RID: 123209 RVA: 0x00438438 File Offset: 0x00436638
		public ICheckOnlinePlayer __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008AE0 RID: 35552
		// (get) Token: 0x0601E14A RID: 123210 RVA: 0x00438448 File Offset: 0x00436648
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

		// Token: 0x17008AE1 RID: 35553
		// (get) Token: 0x0601E14B RID: 123211 RVA: 0x00438484 File Offset: 0x00436684
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

		// Token: 0x0601E14C RID: 123212 RVA: 0x004384C0 File Offset: 0x004366C0
		public TTable? OnlinePlayerConditionTargetOption<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0601E14D RID: 123213 RVA: 0x00438504 File Offset: 0x00436704
		public IOnlinePlayerConditionTargetHost OnlinePlayerConditionTargetOptionAsIOnlinePlayerConditionTargetHost()
		{
			return this.OnlinePlayerConditionTargetOption<IOnlinePlayerConditionTargetHost>().Value;
		}

		// Token: 0x0601E14E RID: 123214 RVA: 0x00438520 File Offset: 0x00436720
		public IOnlinePlayerConditionTargetParticipator OnlinePlayerConditionTargetOptionAsIOnlinePlayerConditionTargetParticipator()
		{
			return this.OnlinePlayerConditionTargetOption<IOnlinePlayerConditionTargetParticipator>().Value;
		}

		// Token: 0x0601E14F RID: 123215 RVA: 0x0043853B File Offset: 0x0043673B
		public static Offset<ICheckOnlinePlayer> CreateICheckOnlinePlayer(FlatBufferBuilder builder, ECheckEntity Type = ECheckEntity.OnlinePlayer, TOnlinePlayerConditionTarget OnlinePlayerConditionTargetOption_type = TOnlinePlayerConditionTarget.NONE, int OnlinePlayerConditionTargetOptionOffset = 0)
		{
			builder.StartTable(3);
			ICheckOnlinePlayer.AddOnlinePlayerConditionTargetOption(builder, OnlinePlayerConditionTargetOptionOffset);
			ICheckOnlinePlayer.AddOnlinePlayerConditionTargetOptionType(builder, OnlinePlayerConditionTargetOption_type);
			ICheckOnlinePlayer.AddType(builder, Type);
			return ICheckOnlinePlayer.EndICheckOnlinePlayer(builder);
		}

		// Token: 0x0601E150 RID: 123216 RVA: 0x0043855F File Offset: 0x0043675F
		public static void StartICheckOnlinePlayer(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601E151 RID: 123217 RVA: 0x00438568 File Offset: 0x00436768
		public static void AddType(FlatBufferBuilder builder, ECheckEntity type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601E152 RID: 123218 RVA: 0x00438573 File Offset: 0x00436773
		public static void AddOnlinePlayerConditionTargetOptionType(FlatBufferBuilder builder, TOnlinePlayerConditionTarget onlinePlayerConditionTargetOptionType)
		{
			builder.AddByte(1, (byte)onlinePlayerConditionTargetOptionType, 0);
		}

		// Token: 0x0601E153 RID: 123219 RVA: 0x0043857E File Offset: 0x0043677E
		public static void AddOnlinePlayerConditionTargetOption(FlatBufferBuilder builder, int onlinePlayerConditionTargetOptionOffset)
		{
			builder.AddOffset(2, onlinePlayerConditionTargetOptionOffset, 0);
		}

		// Token: 0x0601E154 RID: 123220 RVA: 0x00438589 File Offset: 0x00436789
		public static Offset<ICheckOnlinePlayer> EndICheckOnlinePlayer(FlatBufferBuilder builder)
		{
			return new Offset<ICheckOnlinePlayer>(builder.EndTable());
		}

		// Token: 0x0601E155 RID: 123221 RVA: 0x00438598 File Offset: 0x00436798
		public ICheckOnlinePlayerT UnPack()
		{
			ICheckOnlinePlayerT checkOnlinePlayerT = new ICheckOnlinePlayerT();
			this.UnPackTo(checkOnlinePlayerT);
			return checkOnlinePlayerT;
		}

		// Token: 0x0601E156 RID: 123222 RVA: 0x004385B4 File Offset: 0x004367B4
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

		// Token: 0x0601E157 RID: 123223 RVA: 0x00438664 File Offset: 0x00436864
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

		// Token: 0x0400D35B RID: 54107
		private Table __p;
	}
}
