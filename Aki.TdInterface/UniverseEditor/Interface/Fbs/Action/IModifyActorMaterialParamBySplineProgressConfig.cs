using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020071D7 RID: 29143
	public struct IModifyActorMaterialParamBySplineProgressConfig : IFlatbufferObject
	{
		// Token: 0x1700D55D RID: 54621
		// (get) Token: 0x06032B10 RID: 207632 RVA: 0x006D9069 File Offset: 0x006D7269
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06032B11 RID: 207633 RVA: 0x006D9076 File Offset: 0x006D7276
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06032B12 RID: 207634 RVA: 0x006D9080 File Offset: 0x006D7280
		public static IModifyActorMaterialParamBySplineProgressConfig GetRootAsIModifyActorMaterialParamBySplineProgressConfig(ByteBuffer _bb)
		{
			return IModifyActorMaterialParamBySplineProgressConfig.GetRootAsIModifyActorMaterialParamBySplineProgressConfig(_bb, default(IModifyActorMaterialParamBySplineProgressConfig));
		}

		// Token: 0x06032B13 RID: 207635 RVA: 0x006D909C File Offset: 0x006D729C
		public static IModifyActorMaterialParamBySplineProgressConfig GetRootAsIModifyActorMaterialParamBySplineProgressConfig(ByteBuffer _bb, IModifyActorMaterialParamBySplineProgressConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06032B14 RID: 207636 RVA: 0x006D90B9 File Offset: 0x006D72B9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06032B15 RID: 207637 RVA: 0x006D90C8 File Offset: 0x006D72C8
		public IModifyActorMaterialParamBySplineProgressConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D55E RID: 54622
		// (get) Token: 0x06032B16 RID: 207638 RVA: 0x006D90D8 File Offset: 0x006D72D8
		public EModifyActorMaterialParamBySplineProgressType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EModifyActorMaterialParamBySplineProgressType.EnterSpline;
				}
				return (EModifyActorMaterialParamBySplineProgressType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700D55F RID: 54623
		// (get) Token: 0x06032B17 RID: 207639 RVA: 0x006D9114 File Offset: 0x006D7314
		public TModifyActorMaterialParamBySplineProgressTarget MoveTargetType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return TModifyActorMaterialParamBySplineProgressTarget.NONE;
				}
				return (TModifyActorMaterialParamBySplineProgressTarget)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06032B18 RID: 207640 RVA: 0x006D9150 File Offset: 0x006D7350
		public TTable? MoveTarget<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06032B19 RID: 207641 RVA: 0x006D9194 File Offset: 0x006D7394
		public IModifyActorMaterialParamByEntitySplineProgress MoveTargetAsIModifyActorMaterialParamByEntitySplineProgress()
		{
			return this.MoveTarget<IModifyActorMaterialParamByEntitySplineProgress>().Value;
		}

		// Token: 0x06032B1A RID: 207642 RVA: 0x006D91B0 File Offset: 0x006D73B0
		public IModifyActorMaterialParamByPlayerSplineProgress MoveTargetAsIModifyActorMaterialParamByPlayerSplineProgress()
		{
			return this.MoveTarget<IModifyActorMaterialParamByPlayerSplineProgress>().Value;
		}

		// Token: 0x1700D560 RID: 54624
		// (get) Token: 0x06032B1B RID: 207643 RVA: 0x006D91CC File Offset: 0x006D73CC
		public int SplineEntityId
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06032B1C RID: 207644 RVA: 0x006D9209 File Offset: 0x006D7409
		public static Offset<IModifyActorMaterialParamBySplineProgressConfig> CreateIModifyActorMaterialParamBySplineProgressConfig(FlatBufferBuilder builder, EModifyActorMaterialParamBySplineProgressType Type = EModifyActorMaterialParamBySplineProgressType.EnterSpline, TModifyActorMaterialParamBySplineProgressTarget MoveTarget_type = TModifyActorMaterialParamBySplineProgressTarget.NONE, int MoveTargetOffset = 0, int SplineEntityId = 0)
		{
			builder.StartTable(4);
			IModifyActorMaterialParamBySplineProgressConfig.AddSplineEntityId(builder, SplineEntityId);
			IModifyActorMaterialParamBySplineProgressConfig.AddMoveTarget(builder, MoveTargetOffset);
			IModifyActorMaterialParamBySplineProgressConfig.AddMoveTargetType(builder, MoveTarget_type);
			IModifyActorMaterialParamBySplineProgressConfig.AddType(builder, Type);
			return IModifyActorMaterialParamBySplineProgressConfig.EndIModifyActorMaterialParamBySplineProgressConfig(builder);
		}

		// Token: 0x06032B1D RID: 207645 RVA: 0x006D9235 File Offset: 0x006D7435
		public static void StartIModifyActorMaterialParamBySplineProgressConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06032B1E RID: 207646 RVA: 0x006D923E File Offset: 0x006D743E
		public static void AddType(FlatBufferBuilder builder, EModifyActorMaterialParamBySplineProgressType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06032B1F RID: 207647 RVA: 0x006D9249 File Offset: 0x006D7449
		public static void AddMoveTargetType(FlatBufferBuilder builder, TModifyActorMaterialParamBySplineProgressTarget moveTargetType)
		{
			builder.AddByte(1, (byte)moveTargetType, 0);
		}

		// Token: 0x06032B20 RID: 207648 RVA: 0x006D9254 File Offset: 0x006D7454
		public static void AddMoveTarget(FlatBufferBuilder builder, int moveTargetOffset)
		{
			builder.AddOffset(2, moveTargetOffset, 0);
		}

		// Token: 0x06032B21 RID: 207649 RVA: 0x006D925F File Offset: 0x006D745F
		public static void AddSplineEntityId(FlatBufferBuilder builder, int splineEntityId)
		{
			builder.AddInt(3, splineEntityId, 0);
		}

		// Token: 0x06032B22 RID: 207650 RVA: 0x006D926A File Offset: 0x006D746A
		public static Offset<IModifyActorMaterialParamBySplineProgressConfig> EndIModifyActorMaterialParamBySplineProgressConfig(FlatBufferBuilder builder)
		{
			return new Offset<IModifyActorMaterialParamBySplineProgressConfig>(builder.EndTable());
		}

		// Token: 0x06032B23 RID: 207651 RVA: 0x006D9278 File Offset: 0x006D7478
		public IModifyActorMaterialParamBySplineProgressConfigT UnPack()
		{
			IModifyActorMaterialParamBySplineProgressConfigT modifyActorMaterialParamBySplineProgressConfigT = new IModifyActorMaterialParamBySplineProgressConfigT();
			this.UnPackTo(modifyActorMaterialParamBySplineProgressConfigT);
			return modifyActorMaterialParamBySplineProgressConfigT;
		}

		// Token: 0x06032B24 RID: 207652 RVA: 0x006D9294 File Offset: 0x006D7494
		public void UnPackTo(IModifyActorMaterialParamBySplineProgressConfigT _o)
		{
			_o.Type = this.Type;
			_o.MoveTarget = new TModifyActorMaterialParamBySplineProgressTargetUnion();
			_o.MoveTarget.Type = this.MoveTargetType;
			TModifyActorMaterialParamBySplineProgressTarget moveTargetType = this.MoveTargetType;
			if (moveTargetType != TModifyActorMaterialParamBySplineProgressTarget.IModifyActorMaterialParamByEntitySplineProgress)
			{
				if (moveTargetType == TModifyActorMaterialParamBySplineProgressTarget.IModifyActorMaterialParamByPlayerSplineProgress)
				{
					_o.MoveTarget.Value = ((this.MoveTarget<IModifyActorMaterialParamByPlayerSplineProgress>() != null) ? this.MoveTarget<IModifyActorMaterialParamByPlayerSplineProgress>().Value.UnPack() : null);
				}
			}
			else
			{
				_o.MoveTarget.Value = ((this.MoveTarget<IModifyActorMaterialParamByEntitySplineProgress>() != null) ? this.MoveTarget<IModifyActorMaterialParamByEntitySplineProgress>().Value.UnPack() : null);
			}
			_o.SplineEntityId = this.SplineEntityId;
		}

		// Token: 0x06032B25 RID: 207653 RVA: 0x006D9354 File Offset: 0x006D7554
		public static Offset<IModifyActorMaterialParamBySplineProgressConfig> Pack(FlatBufferBuilder builder, IModifyActorMaterialParamBySplineProgressConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IModifyActorMaterialParamBySplineProgressConfig>);
			}
			TModifyActorMaterialParamBySplineProgressTarget moveTarget_type = (_o.MoveTarget == null) ? TModifyActorMaterialParamBySplineProgressTarget.NONE : _o.MoveTarget.Type;
			int moveTargetOffset = (_o.MoveTarget == null) ? 0 : TModifyActorMaterialParamBySplineProgressTargetUnion.Pack(builder, _o.MoveTarget);
			return IModifyActorMaterialParamBySplineProgressConfig.CreateIModifyActorMaterialParamBySplineProgressConfig(builder, _o.Type, moveTarget_type, moveTargetOffset, _o.SplineEntityId);
		}

		// Token: 0x040121E7 RID: 74215
		private Table __p;
	}
}
