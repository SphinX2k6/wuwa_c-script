using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006715 RID: 26389
	public struct IActorFxEmoteStop : IFlatbufferObject
	{
		// Token: 0x1700BFDD RID: 49117
		// (get) Token: 0x0602CB19 RID: 183065 RVA: 0x0061D786 File Offset: 0x0061B986
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602CB1A RID: 183066 RVA: 0x0061D793 File Offset: 0x0061B993
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602CB1B RID: 183067 RVA: 0x0061D79C File Offset: 0x0061B99C
		public static IActorFxEmoteStop GetRootAsIActorFxEmoteStop(ByteBuffer _bb)
		{
			return IActorFxEmoteStop.GetRootAsIActorFxEmoteStop(_bb, default(IActorFxEmoteStop));
		}

		// Token: 0x0602CB1C RID: 183068 RVA: 0x0061D7B8 File Offset: 0x0061B9B8
		public static IActorFxEmoteStop GetRootAsIActorFxEmoteStop(ByteBuffer _bb, IActorFxEmoteStop obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602CB1D RID: 183069 RVA: 0x0061D7D5 File Offset: 0x0061B9D5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602CB1E RID: 183070 RVA: 0x0061D7E4 File Offset: 0x0061B9E4
		public IActorFxEmoteStop __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BFDE RID: 49118
		// (get) Token: 0x0602CB1F RID: 183071 RVA: 0x0061D7F4 File Offset: 0x0061B9F4
		public EActorFxEmoteType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EActorFxEmoteType.Play;
				}
				return (EActorFxEmoteType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700BFDF RID: 49119
		// (get) Token: 0x0602CB20 RID: 183072 RVA: 0x0061D830 File Offset: 0x0061BA30
		public TActorFxEmoteStopSubType StopTypeType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return TActorFxEmoteStopSubType.NONE;
				}
				return (TActorFxEmoteStopSubType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602CB21 RID: 183073 RVA: 0x0061D86C File Offset: 0x0061BA6C
		public TTable? StopType<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0602CB22 RID: 183074 RVA: 0x0061D8B0 File Offset: 0x0061BAB0
		public IActorFxEmoteStopAll StopTypeAsIActorFxEmoteStopAll()
		{
			return this.StopType<IActorFxEmoteStopAll>().Value;
		}

		// Token: 0x0602CB23 RID: 183075 RVA: 0x0061D8CC File Offset: 0x0061BACC
		public IActorFxEmoteStopSockets StopTypeAsIActorFxEmoteStopSockets()
		{
			return this.StopType<IActorFxEmoteStopSockets>().Value;
		}

		// Token: 0x1700BFE0 RID: 49120
		// (get) Token: 0x0602CB24 RID: 183076 RVA: 0x0061D8E8 File Offset: 0x0061BAE8
		public float DelayTime
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700BFE1 RID: 49121
		// (get) Token: 0x0602CB25 RID: 183077 RVA: 0x0061D92C File Offset: 0x0061BB2C
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602CB26 RID: 183078 RVA: 0x0061D969 File Offset: 0x0061BB69
		public static Offset<IActorFxEmoteStop> CreateIActorFxEmoteStop(FlatBufferBuilder builder, EActorFxEmoteType Type = EActorFxEmoteType.Play, TActorFxEmoteStopSubType StopType_type = TActorFxEmoteStopSubType.NONE, int StopTypeOffset = 0, float DelayTime = 0f, byte NullMask = 0)
		{
			builder.StartTable(5);
			IActorFxEmoteStop.AddDelayTime(builder, DelayTime);
			IActorFxEmoteStop.AddStopType(builder, StopTypeOffset);
			IActorFxEmoteStop.AddNullMask(builder, NullMask);
			IActorFxEmoteStop.AddStopTypeType(builder, StopType_type);
			IActorFxEmoteStop.AddType(builder, Type);
			return IActorFxEmoteStop.EndIActorFxEmoteStop(builder);
		}

		// Token: 0x0602CB27 RID: 183079 RVA: 0x0061D99D File Offset: 0x0061BB9D
		public static void StartIActorFxEmoteStop(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x0602CB28 RID: 183080 RVA: 0x0061D9A6 File Offset: 0x0061BBA6
		public static void AddType(FlatBufferBuilder builder, EActorFxEmoteType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602CB29 RID: 183081 RVA: 0x0061D9B1 File Offset: 0x0061BBB1
		public static void AddStopTypeType(FlatBufferBuilder builder, TActorFxEmoteStopSubType stopTypeType)
		{
			builder.AddByte(1, (byte)stopTypeType, 0);
		}

		// Token: 0x0602CB2A RID: 183082 RVA: 0x0061D9BC File Offset: 0x0061BBBC
		public static void AddStopType(FlatBufferBuilder builder, int stopTypeOffset)
		{
			builder.AddOffset(2, stopTypeOffset, 0);
		}

		// Token: 0x0602CB2B RID: 183083 RVA: 0x0061D9C7 File Offset: 0x0061BBC7
		public static void AddDelayTime(FlatBufferBuilder builder, float delayTime)
		{
			builder.AddFloat(3, delayTime, 0.0);
		}

		// Token: 0x0602CB2C RID: 183084 RVA: 0x0061D9DA File Offset: 0x0061BBDA
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x0602CB2D RID: 183085 RVA: 0x0061D9E5 File Offset: 0x0061BBE5
		public static Offset<IActorFxEmoteStop> EndIActorFxEmoteStop(FlatBufferBuilder builder)
		{
			return new Offset<IActorFxEmoteStop>(builder.EndTable());
		}

		// Token: 0x0602CB2E RID: 183086 RVA: 0x0061D9F4 File Offset: 0x0061BBF4
		public IActorFxEmoteStopT UnPack()
		{
			IActorFxEmoteStopT actorFxEmoteStopT = new IActorFxEmoteStopT();
			this.UnPackTo(actorFxEmoteStopT);
			return actorFxEmoteStopT;
		}

		// Token: 0x0602CB2F RID: 183087 RVA: 0x0061DA10 File Offset: 0x0061BC10
		public void UnPackTo(IActorFxEmoteStopT _o)
		{
			_o.Type = this.Type;
			_o.StopType = new TActorFxEmoteStopSubTypeUnion();
			_o.StopType.Type = this.StopTypeType;
			TActorFxEmoteStopSubType stopTypeType = this.StopTypeType;
			if (stopTypeType != TActorFxEmoteStopSubType.IActorFxEmoteStopAll)
			{
				if (stopTypeType == TActorFxEmoteStopSubType.IActorFxEmoteStopSockets)
				{
					_o.StopType.Value = ((this.StopType<IActorFxEmoteStopSockets>() != null) ? this.StopType<IActorFxEmoteStopSockets>().Value.UnPack() : null);
				}
			}
			else
			{
				_o.StopType.Value = ((this.StopType<IActorFxEmoteStopAll>() != null) ? this.StopType<IActorFxEmoteStopAll>().Value.UnPack() : null);
			}
			_o.DelayTime = this.DelayTime;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602CB30 RID: 183088 RVA: 0x0061DADC File Offset: 0x0061BCDC
		public static Offset<IActorFxEmoteStop> Pack(FlatBufferBuilder builder, IActorFxEmoteStopT _o)
		{
			if (_o == null)
			{
				return default(Offset<IActorFxEmoteStop>);
			}
			TActorFxEmoteStopSubType stopType_type = (_o.StopType == null) ? TActorFxEmoteStopSubType.NONE : _o.StopType.Type;
			int stopTypeOffset = (_o.StopType == null) ? 0 : TActorFxEmoteStopSubTypeUnion.Pack(builder, _o.StopType);
			return IActorFxEmoteStop.CreateIActorFxEmoteStop(builder, _o.Type, stopType_type, stopTypeOffset, _o.DelayTime, _o.NullMask);
		}

		// Token: 0x0401125A RID: 70234
		private Table __p;
	}
}
