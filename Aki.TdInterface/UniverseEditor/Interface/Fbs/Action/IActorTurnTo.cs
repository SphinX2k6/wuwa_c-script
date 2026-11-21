using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200675A RID: 26458
	public struct IActorTurnTo : IFlatbufferObject
	{
		// Token: 0x1700C061 RID: 49249
		// (get) Token: 0x0602CD6B RID: 183659 RVA: 0x00621CD0 File Offset: 0x0061FED0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602CD6C RID: 183660 RVA: 0x00621CDD File Offset: 0x0061FEDD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602CD6D RID: 183661 RVA: 0x00621CE4 File Offset: 0x0061FEE4
		public static IActorTurnTo GetRootAsIActorTurnTo(ByteBuffer _bb)
		{
			return IActorTurnTo.GetRootAsIActorTurnTo(_bb, default(IActorTurnTo));
		}

		// Token: 0x0602CD6E RID: 183662 RVA: 0x00621D00 File Offset: 0x0061FF00
		public static IActorTurnTo GetRootAsIActorTurnTo(ByteBuffer _bb, IActorTurnTo obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602CD6F RID: 183663 RVA: 0x00621D1D File Offset: 0x0061FF1D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602CD70 RID: 183664 RVA: 0x00621D2C File Offset: 0x0061FF2C
		public IActorTurnTo __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C062 RID: 49250
		// (get) Token: 0x0602CD71 RID: 183665 RVA: 0x00621D3C File Offset: 0x0061FF3C
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

		// Token: 0x1700C063 RID: 49251
		// (get) Token: 0x0602CD72 RID: 183666 RVA: 0x00621D78 File Offset: 0x0061FF78
		public TActorTurnToData TargetType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return TActorTurnToData.NONE;
				}
				return (TActorTurnToData)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602CD73 RID: 183667 RVA: 0x00621DB4 File Offset: 0x0061FFB4
		public TTable? Target<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0602CD74 RID: 183668 RVA: 0x00621DF8 File Offset: 0x0061FFF8
		public IActorTurnToEmptyData TargetAsIActorTurnToEmptyData()
		{
			return this.Target<IActorTurnToEmptyData>().Value;
		}

		// Token: 0x0602CD75 RID: 183669 RVA: 0x00621E14 File Offset: 0x00620014
		public IActorTurnToEntityData TargetAsIActorTurnToEntityData()
		{
			return this.Target<IActorTurnToEntityData>().Value;
		}

		// Token: 0x0602CD76 RID: 183670 RVA: 0x00621E30 File Offset: 0x00620030
		public IActorTurnToPlayerData TargetAsIActorTurnToPlayerData()
		{
			return this.Target<IActorTurnToPlayerData>().Value;
		}

		// Token: 0x0602CD77 RID: 183671 RVA: 0x00621E4C File Offset: 0x0062004C
		public IActorTurnToPositionData TargetAsIActorTurnToPositionData()
		{
			return this.Target<IActorTurnToPositionData>().Value;
		}

		// Token: 0x0602CD78 RID: 183672 RVA: 0x00621E68 File Offset: 0x00620068
		public IActorTurnToTalkerData TargetAsIActorTurnToTalkerData()
		{
			return this.Target<IActorTurnToTalkerData>().Value;
		}

		// Token: 0x1700C064 RID: 49252
		// (get) Token: 0x0602CD79 RID: 183673 RVA: 0x00621E84 File Offset: 0x00620084
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

		// Token: 0x1700C065 RID: 49253
		// (get) Token: 0x0602CD7A RID: 183674 RVA: 0x00621EC8 File Offset: 0x006200C8
		public bool UseLookAtForSmallAngle
		{
			get
			{
				int num = this.__p.__offset(12);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700C066 RID: 49254
		// (get) Token: 0x0602CD7B RID: 183675 RVA: 0x00621F08 File Offset: 0x00620108
		public bool UpdatePosCache
		{
			get
			{
				int num = this.__p.__offset(14);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700C067 RID: 49255
		// (get) Token: 0x0602CD7C RID: 183676 RVA: 0x00621F48 File Offset: 0x00620148
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602CD7D RID: 183677 RVA: 0x00621F88 File Offset: 0x00620188
		public static Offset<IActorTurnTo> CreateIActorTurnTo(FlatBufferBuilder builder, int ActorIndex = 0, TActorTurnToData Target_type = TActorTurnToData.NONE, int TargetOffset = 0, float DelayTime = 0f, bool UseLookAtForSmallAngle = false, bool UpdatePosCache = false, byte NullMask = 0)
		{
			builder.StartTable(7);
			IActorTurnTo.AddDelayTime(builder, DelayTime);
			IActorTurnTo.AddTarget(builder, TargetOffset);
			IActorTurnTo.AddActorIndex(builder, ActorIndex);
			IActorTurnTo.AddNullMask(builder, NullMask);
			IActorTurnTo.AddUpdatePosCache(builder, UpdatePosCache);
			IActorTurnTo.AddUseLookAtForSmallAngle(builder, UseLookAtForSmallAngle);
			IActorTurnTo.AddTargetType(builder, Target_type);
			return IActorTurnTo.EndIActorTurnTo(builder);
		}

		// Token: 0x0602CD7E RID: 183678 RVA: 0x00621FD7 File Offset: 0x006201D7
		public static void StartIActorTurnTo(FlatBufferBuilder builder)
		{
			builder.StartTable(7);
		}

		// Token: 0x0602CD7F RID: 183679 RVA: 0x00621FE0 File Offset: 0x006201E0
		public static void AddActorIndex(FlatBufferBuilder builder, int actorIndex)
		{
			builder.AddInt(0, actorIndex, 0);
		}

		// Token: 0x0602CD80 RID: 183680 RVA: 0x00621FEB File Offset: 0x006201EB
		public static void AddTargetType(FlatBufferBuilder builder, TActorTurnToData targetType)
		{
			builder.AddByte(1, (byte)targetType, 0);
		}

		// Token: 0x0602CD81 RID: 183681 RVA: 0x00621FF6 File Offset: 0x006201F6
		public static void AddTarget(FlatBufferBuilder builder, int targetOffset)
		{
			builder.AddOffset(2, targetOffset, 0);
		}

		// Token: 0x0602CD82 RID: 183682 RVA: 0x00622001 File Offset: 0x00620201
		public static void AddDelayTime(FlatBufferBuilder builder, float delayTime)
		{
			builder.AddFloat(3, delayTime, 0.0);
		}

		// Token: 0x0602CD83 RID: 183683 RVA: 0x00622014 File Offset: 0x00620214
		public static void AddUseLookAtForSmallAngle(FlatBufferBuilder builder, bool useLookAtForSmallAngle)
		{
			builder.AddBool(4, useLookAtForSmallAngle, false);
		}

		// Token: 0x0602CD84 RID: 183684 RVA: 0x0062201F File Offset: 0x0062021F
		public static void AddUpdatePosCache(FlatBufferBuilder builder, bool updatePosCache)
		{
			builder.AddBool(5, updatePosCache, false);
		}

		// Token: 0x0602CD85 RID: 183685 RVA: 0x0062202A File Offset: 0x0062022A
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(6, nullMask, 0);
		}

		// Token: 0x0602CD86 RID: 183686 RVA: 0x00622035 File Offset: 0x00620235
		public static Offset<IActorTurnTo> EndIActorTurnTo(FlatBufferBuilder builder)
		{
			return new Offset<IActorTurnTo>(builder.EndTable());
		}

		// Token: 0x0602CD87 RID: 183687 RVA: 0x00622044 File Offset: 0x00620244
		public IActorTurnToT UnPack()
		{
			IActorTurnToT actorTurnToT = new IActorTurnToT();
			this.UnPackTo(actorTurnToT);
			return actorTurnToT;
		}

		// Token: 0x0602CD88 RID: 183688 RVA: 0x00622060 File Offset: 0x00620260
		public void UnPackTo(IActorTurnToT _o)
		{
			_o.ActorIndex = this.ActorIndex;
			_o.Target = new TActorTurnToDataUnion();
			_o.Target.Type = this.TargetType;
			switch (this.TargetType)
			{
			case TActorTurnToData.IActorTurnToEmptyData:
				_o.Target.Value = ((this.Target<IActorTurnToEmptyData>() != null) ? this.Target<IActorTurnToEmptyData>().Value.UnPack() : null);
				break;
			case TActorTurnToData.IActorTurnToEntityData:
				_o.Target.Value = ((this.Target<IActorTurnToEntityData>() != null) ? this.Target<IActorTurnToEntityData>().Value.UnPack() : null);
				break;
			case TActorTurnToData.IActorTurnToPlayerData:
				_o.Target.Value = ((this.Target<IActorTurnToPlayerData>() != null) ? this.Target<IActorTurnToPlayerData>().Value.UnPack() : null);
				break;
			case TActorTurnToData.IActorTurnToPositionData:
				_o.Target.Value = ((this.Target<IActorTurnToPositionData>() != null) ? this.Target<IActorTurnToPositionData>().Value.UnPack() : null);
				break;
			case TActorTurnToData.IActorTurnToTalkerData:
				_o.Target.Value = ((this.Target<IActorTurnToTalkerData>() != null) ? this.Target<IActorTurnToTalkerData>().Value.UnPack() : null);
				break;
			}
			_o.DelayTime = this.DelayTime;
			_o.UseLookAtForSmallAngle = this.UseLookAtForSmallAngle;
			_o.UpdatePosCache = this.UpdatePosCache;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602CD89 RID: 183689 RVA: 0x0062220C File Offset: 0x0062040C
		public static Offset<IActorTurnTo> Pack(FlatBufferBuilder builder, IActorTurnToT _o)
		{
			if (_o == null)
			{
				return default(Offset<IActorTurnTo>);
			}
			TActorTurnToData target_type = (_o.Target == null) ? TActorTurnToData.NONE : _o.Target.Type;
			int targetOffset = (_o.Target == null) ? 0 : TActorTurnToDataUnion.Pack(builder, _o.Target);
			return IActorTurnTo.CreateIActorTurnTo(builder, _o.ActorIndex, target_type, targetOffset, _o.DelayTime, _o.UseLookAtForSmallAngle, _o.UpdatePosCache, _o.NullMask);
		}

		// Token: 0x040112BE RID: 70334
		private Table __p;
	}
}
