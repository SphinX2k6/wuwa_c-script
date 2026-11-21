using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200670C RID: 26380
	public struct IActorFxEmote : IFlatbufferObject
	{
		// Token: 0x1700BFC0 RID: 49088
		// (get) Token: 0x0602CAB5 RID: 182965 RVA: 0x0061C9C4 File Offset: 0x0061ABC4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602CAB6 RID: 182966 RVA: 0x0061C9D1 File Offset: 0x0061ABD1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602CAB7 RID: 182967 RVA: 0x0061C9D8 File Offset: 0x0061ABD8
		public static IActorFxEmote GetRootAsIActorFxEmote(ByteBuffer _bb)
		{
			return IActorFxEmote.GetRootAsIActorFxEmote(_bb, default(IActorFxEmote));
		}

		// Token: 0x0602CAB8 RID: 182968 RVA: 0x0061C9F4 File Offset: 0x0061ABF4
		public static IActorFxEmote GetRootAsIActorFxEmote(ByteBuffer _bb, IActorFxEmote obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602CAB9 RID: 182969 RVA: 0x0061CA11 File Offset: 0x0061AC11
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602CABA RID: 182970 RVA: 0x0061CA20 File Offset: 0x0061AC20
		public IActorFxEmote __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BFC1 RID: 49089
		// (get) Token: 0x0602CABB RID: 182971 RVA: 0x0061CA30 File Offset: 0x0061AC30
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

		// Token: 0x1700BFC2 RID: 49090
		// (get) Token: 0x0602CABC RID: 182972 RVA: 0x0061CA6C File Offset: 0x0061AC6C
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

		// Token: 0x0602CABD RID: 182973 RVA: 0x0061CAA8 File Offset: 0x0061ACA8
		public TTable? FxEmote<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0602CABE RID: 182974 RVA: 0x0061CAEC File Offset: 0x0061ACEC
		public IActorFxEmotePlay FxEmoteAsIActorFxEmotePlay()
		{
			return this.FxEmote<IActorFxEmotePlay>().Value;
		}

		// Token: 0x0602CABF RID: 182975 RVA: 0x0061CB08 File Offset: 0x0061AD08
		public IActorFxEmoteStop FxEmoteAsIActorFxEmoteStop()
		{
			return this.FxEmote<IActorFxEmoteStop>().Value;
		}

		// Token: 0x0602CAC0 RID: 182976 RVA: 0x0061CB23 File Offset: 0x0061AD23
		public static Offset<IActorFxEmote> CreateIActorFxEmote(FlatBufferBuilder builder, int ActorIndex = 0, TActorFxEmote FxEmote_type = TActorFxEmote.NONE, int FxEmoteOffset = 0)
		{
			builder.StartTable(3);
			IActorFxEmote.AddFxEmote(builder, FxEmoteOffset);
			IActorFxEmote.AddActorIndex(builder, ActorIndex);
			IActorFxEmote.AddFxEmoteType(builder, FxEmote_type);
			return IActorFxEmote.EndIActorFxEmote(builder);
		}

		// Token: 0x0602CAC1 RID: 182977 RVA: 0x0061CB47 File Offset: 0x0061AD47
		public static void StartIActorFxEmote(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0602CAC2 RID: 182978 RVA: 0x0061CB50 File Offset: 0x0061AD50
		public static void AddActorIndex(FlatBufferBuilder builder, int actorIndex)
		{
			builder.AddInt(0, actorIndex, 0);
		}

		// Token: 0x0602CAC3 RID: 182979 RVA: 0x0061CB5B File Offset: 0x0061AD5B
		public static void AddFxEmoteType(FlatBufferBuilder builder, TActorFxEmote fxEmoteType)
		{
			builder.AddByte(1, (byte)fxEmoteType, 0);
		}

		// Token: 0x0602CAC4 RID: 182980 RVA: 0x0061CB66 File Offset: 0x0061AD66
		public static void AddFxEmote(FlatBufferBuilder builder, int fxEmoteOffset)
		{
			builder.AddOffset(2, fxEmoteOffset, 0);
		}

		// Token: 0x0602CAC5 RID: 182981 RVA: 0x0061CB71 File Offset: 0x0061AD71
		public static Offset<IActorFxEmote> EndIActorFxEmote(FlatBufferBuilder builder)
		{
			return new Offset<IActorFxEmote>(builder.EndTable());
		}

		// Token: 0x0602CAC6 RID: 182982 RVA: 0x0061CB80 File Offset: 0x0061AD80
		public IActorFxEmoteT UnPack()
		{
			IActorFxEmoteT actorFxEmoteT = new IActorFxEmoteT();
			this.UnPackTo(actorFxEmoteT);
			return actorFxEmoteT;
		}

		// Token: 0x0602CAC7 RID: 182983 RVA: 0x0061CB9C File Offset: 0x0061AD9C
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

		// Token: 0x0602CAC8 RID: 182984 RVA: 0x0061CC4C File Offset: 0x0061AE4C
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

		// Token: 0x0401124A RID: 70218
		private Table __p;
	}
}
