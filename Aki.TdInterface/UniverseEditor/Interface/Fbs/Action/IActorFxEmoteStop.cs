using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020060B3 RID: 24755
	public struct IActorFxEmoteStop : IFlatbufferObject
	{
		// Token: 0x1700B672 RID: 46706
		// (get) Token: 0x0602A438 RID: 173112 RVA: 0x005D37DE File Offset: 0x005D19DE
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602A439 RID: 173113 RVA: 0x005D37EB File Offset: 0x005D19EB
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602A43A RID: 173114 RVA: 0x005D37F4 File Offset: 0x005D19F4
		public static IActorFxEmoteStop GetRootAsIActorFxEmoteStop(ByteBuffer _bb)
		{
			return IActorFxEmoteStop.GetRootAsIActorFxEmoteStop(_bb, default(IActorFxEmoteStop));
		}

		// Token: 0x0602A43B RID: 173115 RVA: 0x005D3810 File Offset: 0x005D1A10
		public static IActorFxEmoteStop GetRootAsIActorFxEmoteStop(ByteBuffer _bb, IActorFxEmoteStop obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602A43C RID: 173116 RVA: 0x005D382D File Offset: 0x005D1A2D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602A43D RID: 173117 RVA: 0x005D383C File Offset: 0x005D1A3C
		public IActorFxEmoteStop __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B673 RID: 46707
		// (get) Token: 0x0602A43E RID: 173118 RVA: 0x005D384C File Offset: 0x005D1A4C
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

		// Token: 0x1700B674 RID: 46708
		// (get) Token: 0x0602A43F RID: 173119 RVA: 0x005D3888 File Offset: 0x005D1A88
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

		// Token: 0x0602A440 RID: 173120 RVA: 0x005D38C4 File Offset: 0x005D1AC4
		public TTable? StopType<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0602A441 RID: 173121 RVA: 0x005D3908 File Offset: 0x005D1B08
		public IActorFxEmoteStopAll StopTypeAsIActorFxEmoteStopAll()
		{
			return this.StopType<IActorFxEmoteStopAll>().Value;
		}

		// Token: 0x0602A442 RID: 173122 RVA: 0x005D3924 File Offset: 0x005D1B24
		public IActorFxEmoteStopSockets StopTypeAsIActorFxEmoteStopSockets()
		{
			return this.StopType<IActorFxEmoteStopSockets>().Value;
		}

		// Token: 0x1700B675 RID: 46709
		// (get) Token: 0x0602A443 RID: 173123 RVA: 0x005D3940 File Offset: 0x005D1B40
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

		// Token: 0x1700B676 RID: 46710
		// (get) Token: 0x0602A444 RID: 173124 RVA: 0x005D3984 File Offset: 0x005D1B84
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

		// Token: 0x0602A445 RID: 173125 RVA: 0x005D39C1 File Offset: 0x005D1BC1
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

		// Token: 0x0602A446 RID: 173126 RVA: 0x005D39F5 File Offset: 0x005D1BF5
		public static void StartIActorFxEmoteStop(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x0602A447 RID: 173127 RVA: 0x005D39FE File Offset: 0x005D1BFE
		public static void AddType(FlatBufferBuilder builder, EActorFxEmoteType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602A448 RID: 173128 RVA: 0x005D3A09 File Offset: 0x005D1C09
		public static void AddStopTypeType(FlatBufferBuilder builder, TActorFxEmoteStopSubType stopTypeType)
		{
			builder.AddByte(1, (byte)stopTypeType, 0);
		}

		// Token: 0x0602A449 RID: 173129 RVA: 0x005D3A14 File Offset: 0x005D1C14
		public static void AddStopType(FlatBufferBuilder builder, int stopTypeOffset)
		{
			builder.AddOffset(2, stopTypeOffset, 0);
		}

		// Token: 0x0602A44A RID: 173130 RVA: 0x005D3A1F File Offset: 0x005D1C1F
		public static void AddDelayTime(FlatBufferBuilder builder, float delayTime)
		{
			builder.AddFloat(3, delayTime, 0.0);
		}

		// Token: 0x0602A44B RID: 173131 RVA: 0x005D3A32 File Offset: 0x005D1C32
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x0602A44C RID: 173132 RVA: 0x005D3A3D File Offset: 0x005D1C3D
		public static Offset<IActorFxEmoteStop> EndIActorFxEmoteStop(FlatBufferBuilder builder)
		{
			return new Offset<IActorFxEmoteStop>(builder.EndTable());
		}

		// Token: 0x0602A44D RID: 173133 RVA: 0x005D3A4C File Offset: 0x005D1C4C
		public IActorFxEmoteStopT UnPack()
		{
			IActorFxEmoteStopT actorFxEmoteStopT = new IActorFxEmoteStopT();
			this.UnPackTo(actorFxEmoteStopT);
			return actorFxEmoteStopT;
		}

		// Token: 0x0602A44E RID: 173134 RVA: 0x005D3A68 File Offset: 0x005D1C68
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

		// Token: 0x0602A44F RID: 173135 RVA: 0x005D3B34 File Offset: 0x005D1D34
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

		// Token: 0x04010456 RID: 66646
		private Table __p;
	}
}
