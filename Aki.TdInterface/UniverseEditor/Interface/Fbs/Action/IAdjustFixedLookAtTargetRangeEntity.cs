using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020067C3 RID: 26563
	public struct IAdjustFixedLookAtTargetRangeEntity : IFlatbufferObject
	{
		// Token: 0x1700C283 RID: 49795
		// (get) Token: 0x0602D3FF RID: 185343 RVA: 0x006312A2 File Offset: 0x0062F4A2
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602D400 RID: 185344 RVA: 0x006312AF File Offset: 0x0062F4AF
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602D401 RID: 185345 RVA: 0x006312B8 File Offset: 0x0062F4B8
		public static IAdjustFixedLookAtTargetRangeEntity GetRootAsIAdjustFixedLookAtTargetRangeEntity(ByteBuffer _bb)
		{
			return IAdjustFixedLookAtTargetRangeEntity.GetRootAsIAdjustFixedLookAtTargetRangeEntity(_bb, default(IAdjustFixedLookAtTargetRangeEntity));
		}

		// Token: 0x0602D402 RID: 185346 RVA: 0x006312D4 File Offset: 0x0062F4D4
		public static IAdjustFixedLookAtTargetRangeEntity GetRootAsIAdjustFixedLookAtTargetRangeEntity(ByteBuffer _bb, IAdjustFixedLookAtTargetRangeEntity obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602D403 RID: 185347 RVA: 0x006312F1 File Offset: 0x0062F4F1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602D404 RID: 185348 RVA: 0x00631300 File Offset: 0x0062F500
		public IAdjustFixedLookAtTargetRangeEntity __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C284 RID: 49796
		// (get) Token: 0x0602D405 RID: 185349 RVA: 0x00631310 File Offset: 0x0062F510
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

		// Token: 0x1700C285 RID: 49797
		// (get) Token: 0x0602D406 RID: 185350 RVA: 0x0063134C File Offset: 0x0062F54C
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

		// Token: 0x1700C286 RID: 49798
		// (get) Token: 0x0602D407 RID: 185351 RVA: 0x00631388 File Offset: 0x0062F588
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

		// Token: 0x1700C287 RID: 49799
		// (get) Token: 0x0602D408 RID: 185352 RVA: 0x006313E8 File Offset: 0x0062F5E8
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

		// Token: 0x1700C288 RID: 49800
		// (get) Token: 0x0602D409 RID: 185353 RVA: 0x00631448 File Offset: 0x0062F648
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

		// Token: 0x0602D40A RID: 185354 RVA: 0x006314A6 File Offset: 0x0062F6A6
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

		// Token: 0x0602D40B RID: 185355 RVA: 0x006314DA File Offset: 0x0062F6DA
		public static void StartIAdjustFixedLookAtTargetRangeEntity(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x0602D40C RID: 185356 RVA: 0x006314E3 File Offset: 0x0062F6E3
		public static void AddType(FlatBufferBuilder builder, EFixedLookAtTargetType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602D40D RID: 185357 RVA: 0x006314EE File Offset: 0x0062F6EE
		public static void AddEntityId(FlatBufferBuilder builder, int entityId)
		{
			builder.AddInt(1, entityId, 0);
		}

		// Token: 0x0602D40E RID: 185358 RVA: 0x006314F9 File Offset: 0x0062F6F9
		public static void AddMovingTimeParams(FlatBufferBuilder builder, Offset<IMovingCameraTimeParams> movingTimeParamsOffset)
		{
			builder.AddOffset(2, movingTimeParamsOffset.Value, 0);
		}

		// Token: 0x0602D40F RID: 185359 RVA: 0x00631509 File Offset: 0x0062F709
		public static void AddMovingFlow(FlatBufferBuilder builder, Offset<IPlayFlow> movingFlowOffset)
		{
			builder.AddOffset(3, movingFlowOffset.Value, 0);
		}

		// Token: 0x0602D410 RID: 185360 RVA: 0x00631519 File Offset: 0x0062F719
		public static void AddCutCameraConfig(FlatBufferBuilder builder, Offset<ICutCameraConfig> cutCameraConfigOffset)
		{
			builder.AddOffset(4, cutCameraConfigOffset.Value, 0);
		}

		// Token: 0x0602D411 RID: 185361 RVA: 0x00631529 File Offset: 0x0062F729
		public static Offset<IAdjustFixedLookAtTargetRangeEntity> EndIAdjustFixedLookAtTargetRangeEntity(FlatBufferBuilder builder)
		{
			return new Offset<IAdjustFixedLookAtTargetRangeEntity>(builder.EndTable());
		}

		// Token: 0x0602D412 RID: 185362 RVA: 0x00631538 File Offset: 0x0062F738
		public IAdjustFixedLookAtTargetRangeEntityT UnPack()
		{
			IAdjustFixedLookAtTargetRangeEntityT adjustFixedLookAtTargetRangeEntityT = new IAdjustFixedLookAtTargetRangeEntityT();
			this.UnPackTo(adjustFixedLookAtTargetRangeEntityT);
			return adjustFixedLookAtTargetRangeEntityT;
		}

		// Token: 0x0602D413 RID: 185363 RVA: 0x00631554 File Offset: 0x0062F754
		public void UnPackTo(IAdjustFixedLookAtTargetRangeEntityT _o)
		{
			_o.Type = this.Type;
			_o.EntityId = this.EntityId;
			_o.MovingTimeParams = ((this.MovingTimeParams != null) ? this.MovingTimeParams.Value.UnPack() : null);
			_o.MovingFlow = ((this.MovingFlow != null) ? this.MovingFlow.Value.UnPack() : null);
			_o.CutCameraConfig = ((this.CutCameraConfig != null) ? this.CutCameraConfig.Value.UnPack() : null);
		}

		// Token: 0x0602D414 RID: 185364 RVA: 0x0063160C File Offset: 0x0062F80C
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

		// Token: 0x040113F2 RID: 70642
		private Table __p;
	}
}
