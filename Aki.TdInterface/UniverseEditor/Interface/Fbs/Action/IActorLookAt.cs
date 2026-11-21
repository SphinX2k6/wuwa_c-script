using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006733 RID: 26419
	public struct IActorLookAt : IFlatbufferObject
	{
		// Token: 0x1700C00D RID: 49165
		// (get) Token: 0x0602CC12 RID: 183314 RVA: 0x0061F5F8 File Offset: 0x0061D7F8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602CC13 RID: 183315 RVA: 0x0061F605 File Offset: 0x0061D805
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602CC14 RID: 183316 RVA: 0x0061F60C File Offset: 0x0061D80C
		public static IActorLookAt GetRootAsIActorLookAt(ByteBuffer _bb)
		{
			return IActorLookAt.GetRootAsIActorLookAt(_bb, default(IActorLookAt));
		}

		// Token: 0x0602CC15 RID: 183317 RVA: 0x0061F628 File Offset: 0x0061D828
		public static IActorLookAt GetRootAsIActorLookAt(ByteBuffer _bb, IActorLookAt obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602CC16 RID: 183318 RVA: 0x0061F645 File Offset: 0x0061D845
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602CC17 RID: 183319 RVA: 0x0061F654 File Offset: 0x0061D854
		public IActorLookAt __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C00E RID: 49166
		// (get) Token: 0x0602CC18 RID: 183320 RVA: 0x0061F664 File Offset: 0x0061D864
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

		// Token: 0x1700C00F RID: 49167
		// (get) Token: 0x0602CC19 RID: 183321 RVA: 0x0061F6A0 File Offset: 0x0061D8A0
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

		// Token: 0x0602CC1A RID: 183322 RVA: 0x0061F6DC File Offset: 0x0061D8DC
		public TTable? Target<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0602CC1B RID: 183323 RVA: 0x0061F720 File Offset: 0x0061D920
		public IActorLookAtEmptyData TargetAsIActorLookAtEmptyData()
		{
			return this.Target<IActorLookAtEmptyData>().Value;
		}

		// Token: 0x0602CC1C RID: 183324 RVA: 0x0061F73C File Offset: 0x0061D93C
		public IActorLookAtEntityData TargetAsIActorLookAtEntityData()
		{
			return this.Target<IActorLookAtEntityData>().Value;
		}

		// Token: 0x0602CC1D RID: 183325 RVA: 0x0061F758 File Offset: 0x0061D958
		public IActorLookAtOtherActor TargetAsIActorLookAtOtherActor()
		{
			return this.Target<IActorLookAtOtherActor>().Value;
		}

		// Token: 0x0602CC1E RID: 183326 RVA: 0x0061F774 File Offset: 0x0061D974
		public IActorLookAtPlayerData TargetAsIActorLookAtPlayerData()
		{
			return this.Target<IActorLookAtPlayerData>().Value;
		}

		// Token: 0x0602CC1F RID: 183327 RVA: 0x0061F790 File Offset: 0x0061D990
		public IActorLookAtPositionData TargetAsIActorLookAtPositionData()
		{
			return this.Target<IActorLookAtPositionData>().Value;
		}

		// Token: 0x0602CC20 RID: 183328 RVA: 0x0061F7AC File Offset: 0x0061D9AC
		public IActorLookAtTalkerData TargetAsIActorLookAtTalkerData()
		{
			return this.Target<IActorLookAtTalkerData>().Value;
		}

		// Token: 0x0602CC21 RID: 183329 RVA: 0x0061F7C8 File Offset: 0x0061D9C8
		public IActorLookAtUnLock TargetAsIActorLookAtUnLock()
		{
			return this.Target<IActorLookAtUnLock>().Value;
		}

		// Token: 0x1700C010 RID: 49168
		// (get) Token: 0x0602CC22 RID: 183330 RVA: 0x0061F7E4 File Offset: 0x0061D9E4
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

		// Token: 0x1700C011 RID: 49169
		// (get) Token: 0x0602CC23 RID: 183331 RVA: 0x0061F828 File Offset: 0x0061DA28
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

		// Token: 0x1700C012 RID: 49170
		// (get) Token: 0x0602CC24 RID: 183332 RVA: 0x0061F86C File Offset: 0x0061DA6C
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

		// Token: 0x0602CC25 RID: 183333 RVA: 0x0061F8A9 File Offset: 0x0061DAA9
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

		// Token: 0x0602CC26 RID: 183334 RVA: 0x0061F8E5 File Offset: 0x0061DAE5
		public static void StartIActorLookAt(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x0602CC27 RID: 183335 RVA: 0x0061F8EE File Offset: 0x0061DAEE
		public static void AddActorIndex(FlatBufferBuilder builder, int actorIndex)
		{
			builder.AddInt(0, actorIndex, 0);
		}

		// Token: 0x0602CC28 RID: 183336 RVA: 0x0061F8F9 File Offset: 0x0061DAF9
		public static void AddTargetType(FlatBufferBuilder builder, TActorLookAtData targetType)
		{
			builder.AddByte(1, (byte)targetType, 0);
		}

		// Token: 0x0602CC29 RID: 183337 RVA: 0x0061F904 File Offset: 0x0061DB04
		public static void AddTarget(FlatBufferBuilder builder, int targetOffset)
		{
			builder.AddOffset(2, targetOffset, 0);
		}

		// Token: 0x0602CC2A RID: 183338 RVA: 0x0061F90F File Offset: 0x0061DB0F
		public static void AddDelayTime(FlatBufferBuilder builder, float delayTime)
		{
			builder.AddFloat(3, delayTime, 0.0);
		}

		// Token: 0x0602CC2B RID: 183339 RVA: 0x0061F922 File Offset: 0x0061DB22
		public static void AddLookAtSpeedRate(FlatBufferBuilder builder, float lookAtSpeedRate)
		{
			builder.AddFloat(4, lookAtSpeedRate, 0.0);
		}

		// Token: 0x0602CC2C RID: 183340 RVA: 0x0061F935 File Offset: 0x0061DB35
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(5, nullMask, 0);
		}

		// Token: 0x0602CC2D RID: 183341 RVA: 0x0061F940 File Offset: 0x0061DB40
		public static Offset<IActorLookAt> EndIActorLookAt(FlatBufferBuilder builder)
		{
			return new Offset<IActorLookAt>(builder.EndTable());
		}

		// Token: 0x0602CC2E RID: 183342 RVA: 0x0061F950 File Offset: 0x0061DB50
		public IActorLookAtT UnPack()
		{
			IActorLookAtT actorLookAtT = new IActorLookAtT();
			this.UnPackTo(actorLookAtT);
			return actorLookAtT;
		}

		// Token: 0x0602CC2F RID: 183343 RVA: 0x0061F96C File Offset: 0x0061DB6C
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

		// Token: 0x0602CC30 RID: 183344 RVA: 0x0061FB8C File Offset: 0x0061DD8C
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

		// Token: 0x04011282 RID: 70274
		private Table __p;
	}
}
