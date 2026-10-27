using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200615E RID: 24926
	public struct IAdjustFixedLookAtTargetRangeEntity : IFlatbufferObject
	{
		// Token: 0x1700B913 RID: 47379
		// (get) Token: 0x0602AD06 RID: 175366 RVA: 0x005E70C6 File Offset: 0x005E52C6
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602AD07 RID: 175367 RVA: 0x005E70D3 File Offset: 0x005E52D3
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602AD08 RID: 175368 RVA: 0x005E70DC File Offset: 0x005E52DC
		public static IAdjustFixedLookAtTargetRangeEntity GetRootAsIAdjustFixedLookAtTargetRangeEntity(ByteBuffer _bb)
		{
			return IAdjustFixedLookAtTargetRangeEntity.GetRootAsIAdjustFixedLookAtTargetRangeEntity(_bb, default(IAdjustFixedLookAtTargetRangeEntity));
		}

		// Token: 0x0602AD09 RID: 175369 RVA: 0x005E70F8 File Offset: 0x005E52F8
		public static IAdjustFixedLookAtTargetRangeEntity GetRootAsIAdjustFixedLookAtTargetRangeEntity(ByteBuffer _bb, IAdjustFixedLookAtTargetRangeEntity obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602AD0A RID: 175370 RVA: 0x005E7115 File Offset: 0x005E5315
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602AD0B RID: 175371 RVA: 0x005E7124 File Offset: 0x005E5324
		public IAdjustFixedLookAtTargetRangeEntity __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B914 RID: 47380
		// (get) Token: 0x0602AD0C RID: 175372 RVA: 0x005E7134 File Offset: 0x005E5334
		public EFixedLookAtTargetType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EFixedLookAtTargetType.RangeEntity;
				}
				return (EFixedLookAtTargetType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700B915 RID: 47381
		// (get) Token: 0x0602AD0D RID: 175373 RVA: 0x005E7170 File Offset: 0x005E5370
		public int EntityId
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700B916 RID: 47382
		// (get) Token: 0x0602AD0E RID: 175374 RVA: 0x005E71AC File Offset: 0x005E53AC
		public IMovingCameraTimeParams? MovingTimeParams
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return new IMovingCameraTimeParams?(default(IMovingCameraTimeParams).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700B917 RID: 47383
		// (get) Token: 0x0602AD0F RID: 175375 RVA: 0x005E720C File Offset: 0x005E540C
		public IPlayFlow? MovingFlow
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return new IPlayFlow?(default(IPlayFlow).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700B918 RID: 47384
		// (get) Token: 0x0602AD10 RID: 175376 RVA: 0x005E726C File Offset: 0x005E546C
		public ICutCameraConfig? CutCameraConfig
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return null;
				}
				return new ICutCameraConfig?(default(ICutCameraConfig).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x0602AD11 RID: 175377 RVA: 0x005E72CA File Offset: 0x005E54CA
		public static Offset<IAdjustFixedLookAtTargetRangeEntity> CreateIAdjustFixedLookAtTargetRangeEntity(FlatBufferBuilder builder, EFixedLookAtTargetType Type = EFixedLookAtTargetType.RangeEntity, int EntityId = 0, Offset<IMovingCameraTimeParams> MovingTimeParamsOffset = default(Offset<IMovingCameraTimeParams>), Offset<IPlayFlow> MovingFlowOffset = default(Offset<IPlayFlow>), Offset<ICutCameraConfig> CutCameraConfigOffset = default(Offset<ICutCameraConfig>))
		{
			builder.StartTable(5);
			IAdjustFixedLookAtTargetRangeEntity.AddCutCameraConfig(builder, CutCameraConfigOffset);
			IAdjustFixedLookAtTargetRangeEntity.AddMovingFlow(builder, MovingFlowOffset);
			IAdjustFixedLookAtTargetRangeEntity.AddMovingTimeParams(builder, MovingTimeParamsOffset);
			IAdjustFixedLookAtTargetRangeEntity.AddEntityId(builder, EntityId);
			IAdjustFixedLookAtTargetRangeEntity.AddType(builder, Type);
			return IAdjustFixedLookAtTargetRangeEntity.EndIAdjustFixedLookAtTargetRangeEntity(builder);
		}

		// Token: 0x0602AD12 RID: 175378 RVA: 0x005E72FE File Offset: 0x005E54FE
		public static void StartIAdjustFixedLookAtTargetRangeEntity(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x0602AD13 RID: 175379 RVA: 0x005E7307 File Offset: 0x005E5507
		public static void AddType(FlatBufferBuilder builder, EFixedLookAtTargetType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602AD14 RID: 175380 RVA: 0x005E7312 File Offset: 0x005E5512
		public static void AddEntityId(FlatBufferBuilder builder, int entityId)
		{
			builder.AddInt(1, entityId, 0);
		}

		// Token: 0x0602AD15 RID: 175381 RVA: 0x005E731D File Offset: 0x005E551D
		public static void AddMovingTimeParams(FlatBufferBuilder builder, Offset<IMovingCameraTimeParams> movingTimeParamsOffset)
		{
			builder.AddOffset(2, movingTimeParamsOffset.Value, 0);
		}

		// Token: 0x0602AD16 RID: 175382 RVA: 0x005E732D File Offset: 0x005E552D
		public static void AddMovingFlow(FlatBufferBuilder builder, Offset<IPlayFlow> movingFlowOffset)
		{
			builder.AddOffset(3, movingFlowOffset.Value, 0);
		}

		// Token: 0x0602AD17 RID: 175383 RVA: 0x005E733D File Offset: 0x005E553D
		public static void AddCutCameraConfig(FlatBufferBuilder builder, Offset<ICutCameraConfig> cutCameraConfigOffset)
		{
			builder.AddOffset(4, cutCameraConfigOffset.Value, 0);
		}

		// Token: 0x0602AD18 RID: 175384 RVA: 0x005E734D File Offset: 0x005E554D
		public static Offset<IAdjustFixedLookAtTargetRangeEntity> EndIAdjustFixedLookAtTargetRangeEntity(FlatBufferBuilder builder)
		{
			return new Offset<IAdjustFixedLookAtTargetRangeEntity>(builder.EndTable());
		}

		// Token: 0x0602AD19 RID: 175385 RVA: 0x005E735C File Offset: 0x005E555C
		public IAdjustFixedLookAtTargetRangeEntityT UnPack()
		{
			IAdjustFixedLookAtTargetRangeEntityT adjustFixedLookAtTargetRangeEntityT = new IAdjustFixedLookAtTargetRangeEntityT();
			this.UnPackTo(adjustFixedLookAtTargetRangeEntityT);
			return adjustFixedLookAtTargetRangeEntityT;
		}

		// Token: 0x0602AD1A RID: 175386 RVA: 0x005E7378 File Offset: 0x005E5578
		public void UnPackTo(IAdjustFixedLookAtTargetRangeEntityT _o)
		{
			_o.Type = this.Type;
			_o.EntityId = this.EntityId;
			_o.MovingTimeParams = ((this.MovingTimeParams != null) ? this.MovingTimeParams.Value.UnPack() : null);
			_o.MovingFlow = ((this.MovingFlow != null) ? this.MovingFlow.Value.UnPack() : null);
			_o.CutCameraConfig = ((this.CutCameraConfig != null) ? this.CutCameraConfig.Value.UnPack() : null);
		}

		// Token: 0x0602AD1B RID: 175387 RVA: 0x005E7430 File Offset: 0x005E5630
		public static Offset<IAdjustFixedLookAtTargetRangeEntity> Pack(FlatBufferBuilder builder, IAdjustFixedLookAtTargetRangeEntityT _o)
		{
			if (_o == null)
			{
				return default(Offset<IAdjustFixedLookAtTargetRangeEntity>);
			}
			Offset<IMovingCameraTimeParams> movingTimeParamsOffset = (_o.MovingTimeParams == null) ? default(Offset<IMovingCameraTimeParams>) : IMovingCameraTimeParams.Pack(builder, _o.MovingTimeParams);
			Offset<IPlayFlow> movingFlowOffset = (_o.MovingFlow == null) ? default(Offset<IPlayFlow>) : IPlayFlow.Pack(builder, _o.MovingFlow);
			Offset<ICutCameraConfig> cutCameraConfigOffset = (_o.CutCameraConfig == null) ? default(Offset<ICutCameraConfig>) : ICutCameraConfig.Pack(builder, _o.CutCameraConfig);
			return IAdjustFixedLookAtTargetRangeEntity.CreateIAdjustFixedLookAtTargetRangeEntity(builder, _o.Type, _o.EntityId, movingTimeParamsOffset, movingFlowOffset, cutCameraConfigOffset);
		}

		// Token: 0x040105EB RID: 67051
		private Table __p;
	}
}
