using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020060F8 RID: 24824
	public struct IActorTurnTo : IFlatbufferObject
	{
		// Token: 0x1700B6F6 RID: 46838
		// (get) Token: 0x0602A68A RID: 173706 RVA: 0x005D7D28 File Offset: 0x005D5F28
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602A68B RID: 173707 RVA: 0x005D7D35 File Offset: 0x005D5F35
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602A68C RID: 173708 RVA: 0x005D7D3C File Offset: 0x005D5F3C
		public static IActorTurnTo GetRootAsIActorTurnTo(ByteBuffer _bb)
		{
			return IActorTurnTo.GetRootAsIActorTurnTo(_bb, default(IActorTurnTo));
		}

		// Token: 0x0602A68D RID: 173709 RVA: 0x005D7D58 File Offset: 0x005D5F58
		public static IActorTurnTo GetRootAsIActorTurnTo(ByteBuffer _bb, IActorTurnTo obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602A68E RID: 173710 RVA: 0x005D7D75 File Offset: 0x005D5F75
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602A68F RID: 173711 RVA: 0x005D7D84 File Offset: 0x005D5F84
		public IActorTurnTo __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B6F7 RID: 46839
		// (get) Token: 0x0602A690 RID: 173712 RVA: 0x005D7D94 File Offset: 0x005D5F94
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

		// Token: 0x1700B6F8 RID: 46840
		// (get) Token: 0x0602A691 RID: 173713 RVA: 0x005D7DD0 File Offset: 0x005D5FD0
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

		// Token: 0x0602A692 RID: 173714 RVA: 0x005D7E0C File Offset: 0x005D600C
		public TTable? Target<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0602A693 RID: 173715 RVA: 0x005D7E50 File Offset: 0x005D6050
		public IActorTurnToEmptyData TargetAsIActorTurnToEmptyData()
		{
			return this.Target<IActorTurnToEmptyData>().Value;
		}

		// Token: 0x0602A694 RID: 173716 RVA: 0x005D7E6C File Offset: 0x005D606C
		public IActorTurnToEntityData TargetAsIActorTurnToEntityData()
		{
			return this.Target<IActorTurnToEntityData>().Value;
		}

		// Token: 0x0602A695 RID: 173717 RVA: 0x005D7E88 File Offset: 0x005D6088
		public IActorTurnToPlayerData TargetAsIActorTurnToPlayerData()
		{
			return this.Target<IActorTurnToPlayerData>().Value;
		}

		// Token: 0x0602A696 RID: 173718 RVA: 0x005D7EA4 File Offset: 0x005D60A4
		public IActorTurnToPositionData TargetAsIActorTurnToPositionData()
		{
			return this.Target<IActorTurnToPositionData>().Value;
		}

		// Token: 0x0602A697 RID: 173719 RVA: 0x005D7EC0 File Offset: 0x005D60C0
		public IActorTurnToTalkerData TargetAsIActorTurnToTalkerData()
		{
			return this.Target<IActorTurnToTalkerData>().Value;
		}

		// Token: 0x1700B6F9 RID: 46841
		// (get) Token: 0x0602A698 RID: 173720 RVA: 0x005D7EDC File Offset: 0x005D60DC
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

		// Token: 0x1700B6FA RID: 46842
		// (get) Token: 0x0602A699 RID: 173721 RVA: 0x005D7F20 File Offset: 0x005D6120
		public bool UseLookAtForSmallAngle
		{
			get
			{
				int num = this.__p.__offset(12);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700B6FB RID: 46843
		// (get) Token: 0x0602A69A RID: 173722 RVA: 0x005D7F60 File Offset: 0x005D6160
		public bool UpdatePosCache
		{
			get
			{
				int num = this.__p.__offset(14);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700B6FC RID: 46844
		// (get) Token: 0x0602A69B RID: 173723 RVA: 0x005D7FA0 File Offset: 0x005D61A0
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

		// Token: 0x0602A69C RID: 173724 RVA: 0x005D7FE0 File Offset: 0x005D61E0
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

		// Token: 0x0602A69D RID: 173725 RVA: 0x005D802F File Offset: 0x005D622F
		public static void StartIActorTurnTo(FlatBufferBuilder builder)
		{
			builder.StartTable(7);
		}

		// Token: 0x0602A69E RID: 173726 RVA: 0x005D8038 File Offset: 0x005D6238
		public static void AddActorIndex(FlatBufferBuilder builder, int actorIndex)
		{
			builder.AddInt(0, actorIndex, 0);
		}

		// Token: 0x0602A69F RID: 173727 RVA: 0x005D8043 File Offset: 0x005D6243
		public static void AddTargetType(FlatBufferBuilder builder, TActorTurnToData targetType)
		{
			builder.AddByte(1, (byte)targetType, 0);
		}

		// Token: 0x0602A6A0 RID: 173728 RVA: 0x005D804E File Offset: 0x005D624E
		public static void AddTarget(FlatBufferBuilder builder, int targetOffset)
		{
			builder.AddOffset(2, targetOffset, 0);
		}

		// Token: 0x0602A6A1 RID: 173729 RVA: 0x005D8059 File Offset: 0x005D6259
		public static void AddDelayTime(FlatBufferBuilder builder, float delayTime)
		{
			builder.AddFloat(3, delayTime, 0.0);
		}

		// Token: 0x0602A6A2 RID: 173730 RVA: 0x005D806C File Offset: 0x005D626C
		public static void AddUseLookAtForSmallAngle(FlatBufferBuilder builder, bool useLookAtForSmallAngle)
		{
			builder.AddBool(4, useLookAtForSmallAngle, false);
		}

		// Token: 0x0602A6A3 RID: 173731 RVA: 0x005D8077 File Offset: 0x005D6277
		public static void AddUpdatePosCache(FlatBufferBuilder builder, bool updatePosCache)
		{
			builder.AddBool(5, updatePosCache, false);
		}

		// Token: 0x0602A6A4 RID: 173732 RVA: 0x005D8082 File Offset: 0x005D6282
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(6, nullMask, 0);
		}

		// Token: 0x0602A6A5 RID: 173733 RVA: 0x005D808D File Offset: 0x005D628D
		public static Offset<IActorTurnTo> EndIActorTurnTo(FlatBufferBuilder builder)
		{
			return new Offset<IActorTurnTo>(builder.EndTable());
		}

		// Token: 0x0602A6A6 RID: 173734 RVA: 0x005D809C File Offset: 0x005D629C
		public IActorTurnToT UnPack()
		{
			IActorTurnToT actorTurnToT = new IActorTurnToT();
			this.UnPackTo(actorTurnToT);
			return actorTurnToT;
		}

		// Token: 0x0602A6A7 RID: 173735 RVA: 0x005D80B8 File Offset: 0x005D62B8
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

		// Token: 0x0602A6A8 RID: 173736 RVA: 0x005D8264 File Offset: 0x005D6464
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

		// Token: 0x040104BA RID: 66746
		private Table __p;
	}
}
