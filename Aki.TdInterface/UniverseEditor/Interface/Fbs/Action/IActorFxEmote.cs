using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020060AA RID: 24746
	public struct IActorFxEmote : IFlatbufferObject
	{
		// Token: 0x1700B655 RID: 46677
		// (get) Token: 0x0602A3D4 RID: 173012 RVA: 0x005D2A1C File Offset: 0x005D0C1C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602A3D5 RID: 173013 RVA: 0x005D2A29 File Offset: 0x005D0C29
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602A3D6 RID: 173014 RVA: 0x005D2A30 File Offset: 0x005D0C30
		public static IActorFxEmote GetRootAsIActorFxEmote(ByteBuffer _bb)
		{
			return IActorFxEmote.GetRootAsIActorFxEmote(_bb, default(IActorFxEmote));
		}

		// Token: 0x0602A3D7 RID: 173015 RVA: 0x005D2A4C File Offset: 0x005D0C4C
		public static IActorFxEmote GetRootAsIActorFxEmote(ByteBuffer _bb, IActorFxEmote obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602A3D8 RID: 173016 RVA: 0x005D2A69 File Offset: 0x005D0C69
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602A3D9 RID: 173017 RVA: 0x005D2A78 File Offset: 0x005D0C78
		public IActorFxEmote __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B656 RID: 46678
		// (get) Token: 0x0602A3DA RID: 173018 RVA: 0x005D2A88 File Offset: 0x005D0C88
		public int ActorIndex
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700B657 RID: 46679
		// (get) Token: 0x0602A3DB RID: 173019 RVA: 0x005D2AC4 File Offset: 0x005D0CC4
		public TActorFxEmote FxEmoteType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return TActorFxEmote.NONE;
				}
				return (TActorFxEmote)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602A3DC RID: 173020 RVA: 0x005D2B00 File Offset: 0x005D0D00
		public TTable? FxEmote<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0602A3DD RID: 173021 RVA: 0x005D2B44 File Offset: 0x005D0D44
		public IActorFxEmotePlay FxEmoteAsIActorFxEmotePlay()
		{
			return this.FxEmote<IActorFxEmotePlay>().Value;
		}

		// Token: 0x0602A3DE RID: 173022 RVA: 0x005D2B60 File Offset: 0x005D0D60
		public IActorFxEmoteStop FxEmoteAsIActorFxEmoteStop()
		{
			return this.FxEmote<IActorFxEmoteStop>().Value;
		}

		// Token: 0x0602A3DF RID: 173023 RVA: 0x005D2B7B File Offset: 0x005D0D7B
		public static Offset<IActorFxEmote> CreateIActorFxEmote(FlatBufferBuilder builder, int ActorIndex = 0, TActorFxEmote FxEmote_type = TActorFxEmote.NONE, int FxEmoteOffset = 0)
		{
			builder.StartTable(3);
			IActorFxEmote.AddFxEmote(builder, FxEmoteOffset);
			IActorFxEmote.AddActorIndex(builder, ActorIndex);
			IActorFxEmote.AddFxEmoteType(builder, FxEmote_type);
			return IActorFxEmote.EndIActorFxEmote(builder);
		}

		// Token: 0x0602A3E0 RID: 173024 RVA: 0x005D2B9F File Offset: 0x005D0D9F
		public static void StartIActorFxEmote(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0602A3E1 RID: 173025 RVA: 0x005D2BA8 File Offset: 0x005D0DA8
		public static void AddActorIndex(FlatBufferBuilder builder, int actorIndex)
		{
			builder.AddInt(0, actorIndex, 0);
		}

		// Token: 0x0602A3E2 RID: 173026 RVA: 0x005D2BB3 File Offset: 0x005D0DB3
		public static void AddFxEmoteType(FlatBufferBuilder builder, TActorFxEmote fxEmoteType)
		{
			builder.AddByte(1, (byte)fxEmoteType, 0);
		}

		// Token: 0x0602A3E3 RID: 173027 RVA: 0x005D2BBE File Offset: 0x005D0DBE
		public static void AddFxEmote(FlatBufferBuilder builder, int fxEmoteOffset)
		{
			builder.AddOffset(2, fxEmoteOffset, 0);
		}

		// Token: 0x0602A3E4 RID: 173028 RVA: 0x005D2BC9 File Offset: 0x005D0DC9
		public static Offset<IActorFxEmote> EndIActorFxEmote(FlatBufferBuilder builder)
		{
			return new Offset<IActorFxEmote>(builder.EndTable());
		}

		// Token: 0x0602A3E5 RID: 173029 RVA: 0x005D2BD8 File Offset: 0x005D0DD8
		public IActorFxEmoteT UnPack()
		{
			IActorFxEmoteT actorFxEmoteT = new IActorFxEmoteT();
			this.UnPackTo(actorFxEmoteT);
			return actorFxEmoteT;
		}

		// Token: 0x0602A3E6 RID: 173030 RVA: 0x005D2BF4 File Offset: 0x005D0DF4
		public void UnPackTo(IActorFxEmoteT _o)
		{
			_o.ActorIndex = this.ActorIndex;
			_o.FxEmote = new TActorFxEmoteUnion();
			_o.FxEmote.Type = this.FxEmoteType;
			TActorFxEmote fxEmoteType = this.FxEmoteType;
			if (fxEmoteType == TActorFxEmote.IActorFxEmotePlay)
			{
				_o.FxEmote.Value = ((this.FxEmote<IActorFxEmotePlay>() != null) ? this.FxEmote<IActorFxEmotePlay>().Value.UnPack() : null);
				return;
			}
			if (fxEmoteType != TActorFxEmote.IActorFxEmoteStop)
			{
				return;
			}
			_o.FxEmote.Value = ((this.FxEmote<IActorFxEmoteStop>() != null) ? this.FxEmote<IActorFxEmoteStop>().Value.UnPack() : null);
		}

		// Token: 0x0602A3E7 RID: 173031 RVA: 0x005D2CA4 File Offset: 0x005D0EA4
		public static Offset<IActorFxEmote> Pack(FlatBufferBuilder builder, IActorFxEmoteT _o)
		{
			if (_o == null)
			{
				return default(Offset<IActorFxEmote>);
			}
			TActorFxEmote fxEmote_type = (_o.FxEmote == null) ? TActorFxEmote.NONE : _o.FxEmote.Type;
			int fxEmoteOffset = (_o.FxEmote == null) ? 0 : TActorFxEmoteUnion.Pack(builder, _o.FxEmote);
			return IActorFxEmote.CreateIActorFxEmote(builder, _o.ActorIndex, fxEmote_type, fxEmoteOffset);
		}

		// Token: 0x04010446 RID: 66630
		private Table __p;
	}
}
