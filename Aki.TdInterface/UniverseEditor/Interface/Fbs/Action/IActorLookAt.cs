using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020060D1 RID: 24785
	public struct IActorLookAt : IFlatbufferObject
	{
		// Token: 0x1700B6A2 RID: 46754
		// (get) Token: 0x0602A531 RID: 173361 RVA: 0x005D5650 File Offset: 0x005D3850
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602A532 RID: 173362 RVA: 0x005D565D File Offset: 0x005D385D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602A533 RID: 173363 RVA: 0x005D5664 File Offset: 0x005D3864
		public static IActorLookAt GetRootAsIActorLookAt(ByteBuffer _bb)
		{
			return IActorLookAt.GetRootAsIActorLookAt(_bb, default(IActorLookAt));
		}

		// Token: 0x0602A534 RID: 173364 RVA: 0x005D5680 File Offset: 0x005D3880
		public static IActorLookAt GetRootAsIActorLookAt(ByteBuffer _bb, IActorLookAt obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602A535 RID: 173365 RVA: 0x005D569D File Offset: 0x005D389D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602A536 RID: 173366 RVA: 0x005D56AC File Offset: 0x005D38AC
		public IActorLookAt __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B6A3 RID: 46755
		// (get) Token: 0x0602A537 RID: 173367 RVA: 0x005D56BC File Offset: 0x005D38BC
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

		// Token: 0x1700B6A4 RID: 46756
		// (get) Token: 0x0602A538 RID: 173368 RVA: 0x005D56F8 File Offset: 0x005D38F8
		public TActorLookAtData TargetType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return TActorLookAtData.NONE;
				}
				return (TActorLookAtData)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602A539 RID: 173369 RVA: 0x005D5734 File Offset: 0x005D3934
		public TTable? Target<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0602A53A RID: 173370 RVA: 0x005D5778 File Offset: 0x005D3978
		public IActorLookAtEmptyData TargetAsIActorLookAtEmptyData()
		{
			return this.Target<IActorLookAtEmptyData>().Value;
		}

		// Token: 0x0602A53B RID: 173371 RVA: 0x005D5794 File Offset: 0x005D3994
		public IActorLookAtEntityData TargetAsIActorLookAtEntityData()
		{
			return this.Target<IActorLookAtEntityData>().Value;
		}

		// Token: 0x0602A53C RID: 173372 RVA: 0x005D57B0 File Offset: 0x005D39B0
		public IActorLookAtOtherActor TargetAsIActorLookAtOtherActor()
		{
			return this.Target<IActorLookAtOtherActor>().Value;
		}

		// Token: 0x0602A53D RID: 173373 RVA: 0x005D57CC File Offset: 0x005D39CC
		public IActorLookAtPlayerData TargetAsIActorLookAtPlayerData()
		{
			return this.Target<IActorLookAtPlayerData>().Value;
		}

		// Token: 0x0602A53E RID: 173374 RVA: 0x005D57E8 File Offset: 0x005D39E8
		public IActorLookAtPositionData TargetAsIActorLookAtPositionData()
		{
			return this.Target<IActorLookAtPositionData>().Value;
		}

		// Token: 0x0602A53F RID: 173375 RVA: 0x005D5804 File Offset: 0x005D3A04
		public IActorLookAtTalkerData TargetAsIActorLookAtTalkerData()
		{
			return this.Target<IActorLookAtTalkerData>().Value;
		}

		// Token: 0x0602A540 RID: 173376 RVA: 0x005D5820 File Offset: 0x005D3A20
		public IActorLookAtUnLock TargetAsIActorLookAtUnLock()
		{
			return this.Target<IActorLookAtUnLock>().Value;
		}

		// Token: 0x1700B6A5 RID: 46757
		// (get) Token: 0x0602A541 RID: 173377 RVA: 0x005D583C File Offset: 0x005D3A3C
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

		// Token: 0x1700B6A6 RID: 46758
		// (get) Token: 0x0602A542 RID: 173378 RVA: 0x005D5880 File Offset: 0x005D3A80
		public float LookAtSpeedRate
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700B6A7 RID: 46759
		// (get) Token: 0x0602A543 RID: 173379 RVA: 0x005D58C4 File Offset: 0x005D3AC4
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602A544 RID: 173380 RVA: 0x005D5901 File Offset: 0x005D3B01
		public static Offset<IActorLookAt> CreateIActorLookAt(FlatBufferBuilder builder, int ActorIndex = 0, TActorLookAtData Target_type = TActorLookAtData.NONE, int TargetOffset = 0, float DelayTime = 0f, float LookAtSpeedRate = 0f, byte NullMask = 0)
		{
			builder.StartTable(6);
			IActorLookAt.AddLookAtSpeedRate(builder, LookAtSpeedRate);
			IActorLookAt.AddDelayTime(builder, DelayTime);
			IActorLookAt.AddTarget(builder, TargetOffset);
			IActorLookAt.AddActorIndex(builder, ActorIndex);
			IActorLookAt.AddNullMask(builder, NullMask);
			IActorLookAt.AddTargetType(builder, Target_type);
			return IActorLookAt.EndIActorLookAt(builder);
		}

		// Token: 0x0602A545 RID: 173381 RVA: 0x005D593D File Offset: 0x005D3B3D
		public static void StartIActorLookAt(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x0602A546 RID: 173382 RVA: 0x005D5946 File Offset: 0x005D3B46
		public static void AddActorIndex(FlatBufferBuilder builder, int actorIndex)
		{
			builder.AddInt(0, actorIndex, 0);
		}

		// Token: 0x0602A547 RID: 173383 RVA: 0x005D5951 File Offset: 0x005D3B51
		public static void AddTargetType(FlatBufferBuilder builder, TActorLookAtData targetType)
		{
			builder.AddByte(1, (byte)targetType, 0);
		}

		// Token: 0x0602A548 RID: 173384 RVA: 0x005D595C File Offset: 0x005D3B5C
		public static void AddTarget(FlatBufferBuilder builder, int targetOffset)
		{
			builder.AddOffset(2, targetOffset, 0);
		}

		// Token: 0x0602A549 RID: 173385 RVA: 0x005D5967 File Offset: 0x005D3B67
		public static void AddDelayTime(FlatBufferBuilder builder, float delayTime)
		{
			builder.AddFloat(3, delayTime, 0.0);
		}

		// Token: 0x0602A54A RID: 173386 RVA: 0x005D597A File Offset: 0x005D3B7A
		public static void AddLookAtSpeedRate(FlatBufferBuilder builder, float lookAtSpeedRate)
		{
			builder.AddFloat(4, lookAtSpeedRate, 0.0);
		}

		// Token: 0x0602A54B RID: 173387 RVA: 0x005D598D File Offset: 0x005D3B8D
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(5, nullMask, 0);
		}

		// Token: 0x0602A54C RID: 173388 RVA: 0x005D5998 File Offset: 0x005D3B98
		public static Offset<IActorLookAt> EndIActorLookAt(FlatBufferBuilder builder)
		{
			return new Offset<IActorLookAt>(builder.EndTable());
		}

		// Token: 0x0602A54D RID: 173389 RVA: 0x005D59A8 File Offset: 0x005D3BA8
		public IActorLookAtT UnPack()
		{
			IActorLookAtT actorLookAtT = new IActorLookAtT();
			this.UnPackTo(actorLookAtT);
			return actorLookAtT;
		}

		// Token: 0x0602A54E RID: 173390 RVA: 0x005D59C4 File Offset: 0x005D3BC4
		public void UnPackTo(IActorLookAtT _o)
		{
			_o.ActorIndex = this.ActorIndex;
			_o.Target = new TActorLookAtDataUnion();
			_o.Target.Type = this.TargetType;
			switch (this.TargetType)
			{
			case TActorLookAtData.IActorLookAtEmptyData:
				_o.Target.Value = ((this.Target<IActorLookAtEmptyData>() != null) ? this.Target<IActorLookAtEmptyData>().Value.UnPack() : null);
				break;
			case TActorLookAtData.IActorLookAtEntityData:
				_o.Target.Value = ((this.Target<IActorLookAtEntityData>() != null) ? this.Target<IActorLookAtEntityData>().Value.UnPack() : null);
				break;
			case TActorLookAtData.IActorLookAtOtherActor:
				_o.Target.Value = ((this.Target<IActorLookAtOtherActor>() != null) ? this.Target<IActorLookAtOtherActor>().Value.UnPack() : null);
				break;
			case TActorLookAtData.IActorLookAtPlayerData:
				_o.Target.Value = ((this.Target<IActorLookAtPlayerData>() != null) ? this.Target<IActorLookAtPlayerData>().Value.UnPack() : null);
				break;
			case TActorLookAtData.IActorLookAtPositionData:
				_o.Target.Value = ((this.Target<IActorLookAtPositionData>() != null) ? this.Target<IActorLookAtPositionData>().Value.UnPack() : null);
				break;
			case TActorLookAtData.IActorLookAtTalkerData:
				_o.Target.Value = ((this.Target<IActorLookAtTalkerData>() != null) ? this.Target<IActorLookAtTalkerData>().Value.UnPack() : null);
				break;
			case TActorLookAtData.IActorLookAtUnLock:
				_o.Target.Value = ((this.Target<IActorLookAtUnLock>() != null) ? this.Target<IActorLookAtUnLock>().Value.UnPack() : null);
				break;
			}
			_o.DelayTime = this.DelayTime;
			_o.LookAtSpeedRate = this.LookAtSpeedRate;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602A54F RID: 173391 RVA: 0x005D5BE4 File Offset: 0x005D3DE4
		public static Offset<IActorLookAt> Pack(FlatBufferBuilder builder, IActorLookAtT _o)
		{
			if (_o == null)
			{
				return default(Offset<IActorLookAt>);
			}
			TActorLookAtData target_type = (_o.Target == null) ? TActorLookAtData.NONE : _o.Target.Type;
			int targetOffset = (_o.Target == null) ? 0 : TActorLookAtDataUnion.Pack(builder, _o.Target);
			return IActorLookAt.CreateIActorLookAt(builder, _o.ActorIndex, target_type, targetOffset, _o.DelayTime, _o.LookAtSpeedRate, _o.NullMask);
		}

		// Token: 0x0401047E RID: 66686
		private Table __p;
	}
}
