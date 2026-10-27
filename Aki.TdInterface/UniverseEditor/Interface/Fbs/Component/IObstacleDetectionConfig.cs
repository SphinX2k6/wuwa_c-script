using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Aki.UniverseEditor.Interface.Fbs.Shape;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005692 RID: 22162
	public struct IObstacleDetectionConfig : IFlatbufferObject
	{
		// Token: 0x1700A4CB RID: 42187
		// (get) Token: 0x06024FA1 RID: 151457 RVA: 0x0051B4EE File Offset: 0x005196EE
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06024FA2 RID: 151458 RVA: 0x0051B4FB File Offset: 0x005196FB
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06024FA3 RID: 151459 RVA: 0x0051B504 File Offset: 0x00519704
		public static IObstacleDetectionConfig GetRootAsIObstacleDetectionConfig(ByteBuffer _bb)
		{
			return IObstacleDetectionConfig.GetRootAsIObstacleDetectionConfig(_bb, default(IObstacleDetectionConfig));
		}

		// Token: 0x06024FA4 RID: 151460 RVA: 0x0051B520 File Offset: 0x00519720
		public static IObstacleDetectionConfig GetRootAsIObstacleDetectionConfig(ByteBuffer _bb, IObstacleDetectionConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06024FA5 RID: 151461 RVA: 0x0051B53D File Offset: 0x0051973D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06024FA6 RID: 151462 RVA: 0x0051B54C File Offset: 0x0051974C
		public IObstacleDetectionConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A4CC RID: 42188
		// (get) Token: 0x06024FA7 RID: 151463 RVA: 0x0051B55C File Offset: 0x0051975C
		public ITrafficMatchTarget? ObstacleDetectionType
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return new ITrafficMatchTarget?(default(ITrafficMatchTarget).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700A4CD RID: 42189
		// (get) Token: 0x06024FA8 RID: 151464 RVA: 0x0051B5BC File Offset: 0x005197BC
		public TTriggerShape ExtraObstacleDetectionRangeType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return TTriggerShape.NONE;
				}
				return (TTriggerShape)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06024FA9 RID: 151465 RVA: 0x0051B5F8 File Offset: 0x005197F8
		public TTable? ExtraObstacleDetectionRange<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06024FAA RID: 151466 RVA: 0x0051B63C File Offset: 0x0051983C
		public IActorCollisionTriggerShape ExtraObstacleDetectionRangeAsIActorCollisionTriggerShape()
		{
			return this.ExtraObstacleDetectionRange<IActorCollisionTriggerShape>().Value;
		}

		// Token: 0x06024FAB RID: 151467 RVA: 0x0051B658 File Offset: 0x00519858
		public IActorRefVolume ExtraObstacleDetectionRangeAsIActorRefVolume()
		{
			return this.ExtraObstacleDetectionRange<IActorRefVolume>().Value;
		}

		// Token: 0x06024FAC RID: 151468 RVA: 0x0051B674 File Offset: 0x00519874
		public IBoxTriggerShape ExtraObstacleDetectionRangeAsIBoxTriggerShape()
		{
			return this.ExtraObstacleDetectionRange<IBoxTriggerShape>().Value;
		}

		// Token: 0x06024FAD RID: 151469 RVA: 0x0051B690 File Offset: 0x00519890
		public ICombinationTriggerShape ExtraObstacleDetectionRangeAsICombinationTriggerShape()
		{
			return this.ExtraObstacleDetectionRange<ICombinationTriggerShape>().Value;
		}

		// Token: 0x06024FAE RID: 151470 RVA: 0x0051B6AC File Offset: 0x005198AC
		public IConeTriggerShape ExtraObstacleDetectionRangeAsIConeTriggerShape()
		{
			return this.ExtraObstacleDetectionRange<IConeTriggerShape>().Value;
		}

		// Token: 0x06024FAF RID: 151471 RVA: 0x0051B6C8 File Offset: 0x005198C8
		public ICylinderTriggerShape ExtraObstacleDetectionRangeAsICylinderTriggerShape()
		{
			return this.ExtraObstacleDetectionRange<ICylinderTriggerShape>().Value;
		}

		// Token: 0x06024FB0 RID: 151472 RVA: 0x0051B6E4 File Offset: 0x005198E4
		public IHollowCylinderTriggerShape ExtraObstacleDetectionRangeAsIHollowCylinderTriggerShape()
		{
			return this.ExtraObstacleDetectionRange<IHollowCylinderTriggerShape>().Value;
		}

		// Token: 0x06024FB1 RID: 151473 RVA: 0x0051B700 File Offset: 0x00519900
		public IHollowSphereTriggerShape ExtraObstacleDetectionRangeAsIHollowSphereTriggerShape()
		{
			return this.ExtraObstacleDetectionRange<IHollowSphereTriggerShape>().Value;
		}

		// Token: 0x06024FB2 RID: 151474 RVA: 0x0051B71C File Offset: 0x0051991C
		public ISphereTriggerShape ExtraObstacleDetectionRangeAsISphereTriggerShape()
		{
			return this.ExtraObstacleDetectionRange<ISphereTriggerShape>().Value;
		}

		// Token: 0x06024FB3 RID: 151475 RVA: 0x0051B738 File Offset: 0x00519938
		public ISpotlightTriggerShape ExtraObstacleDetectionRangeAsISpotlightTriggerShape()
		{
			return this.ExtraObstacleDetectionRange<ISpotlightTriggerShape>().Value;
		}

		// Token: 0x06024FB4 RID: 151476 RVA: 0x0051B754 File Offset: 0x00519954
		public IVolumeTriggerShape ExtraObstacleDetectionRangeAsIVolumeTriggerShape()
		{
			return this.ExtraObstacleDetectionRange<IVolumeTriggerShape>().Value;
		}

		// Token: 0x06024FB5 RID: 151477 RVA: 0x0051B76F File Offset: 0x0051996F
		public static Offset<IObstacleDetectionConfig> CreateIObstacleDetectionConfig(FlatBufferBuilder builder, Offset<ITrafficMatchTarget> ObstacleDetectionTypeOffset = default(Offset<ITrafficMatchTarget>), TTriggerShape ExtraObstacleDetectionRange_type = TTriggerShape.NONE, int ExtraObstacleDetectionRangeOffset = 0)
		{
			builder.StartTable(3);
			IObstacleDetectionConfig.AddExtraObstacleDetectionRange(builder, ExtraObstacleDetectionRangeOffset);
			IObstacleDetectionConfig.AddObstacleDetectionType(builder, ObstacleDetectionTypeOffset);
			IObstacleDetectionConfig.AddExtraObstacleDetectionRangeType(builder, ExtraObstacleDetectionRange_type);
			return IObstacleDetectionConfig.EndIObstacleDetectionConfig(builder);
		}

		// Token: 0x06024FB6 RID: 151478 RVA: 0x0051B793 File Offset: 0x00519993
		public static void StartIObstacleDetectionConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06024FB7 RID: 151479 RVA: 0x0051B79C File Offset: 0x0051999C
		public static void AddObstacleDetectionType(FlatBufferBuilder builder, Offset<ITrafficMatchTarget> obstacleDetectionTypeOffset)
		{
			builder.AddOffset(0, obstacleDetectionTypeOffset.Value, 0);
		}

		// Token: 0x06024FB8 RID: 151480 RVA: 0x0051B7AC File Offset: 0x005199AC
		public static void AddExtraObstacleDetectionRangeType(FlatBufferBuilder builder, TTriggerShape extraObstacleDetectionRangeType)
		{
			builder.AddByte(1, (byte)extraObstacleDetectionRangeType, 0);
		}

		// Token: 0x06024FB9 RID: 151481 RVA: 0x0051B7B7 File Offset: 0x005199B7
		public static void AddExtraObstacleDetectionRange(FlatBufferBuilder builder, int extraObstacleDetectionRangeOffset)
		{
			builder.AddOffset(2, extraObstacleDetectionRangeOffset, 0);
		}

		// Token: 0x06024FBA RID: 151482 RVA: 0x0051B7C2 File Offset: 0x005199C2
		public static Offset<IObstacleDetectionConfig> EndIObstacleDetectionConfig(FlatBufferBuilder builder)
		{
			return new Offset<IObstacleDetectionConfig>(builder.EndTable());
		}

		// Token: 0x06024FBB RID: 151483 RVA: 0x0051B7D0 File Offset: 0x005199D0
		public IObstacleDetectionConfigT UnPack()
		{
			IObstacleDetectionConfigT obstacleDetectionConfigT = new IObstacleDetectionConfigT();
			this.UnPackTo(obstacleDetectionConfigT);
			return obstacleDetectionConfigT;
		}

		// Token: 0x06024FBC RID: 151484 RVA: 0x0051B7EC File Offset: 0x005199EC
		public void UnPackTo(IObstacleDetectionConfigT _o)
		{
			_o.ObstacleDetectionType = ((this.ObstacleDetectionType != null) ? this.ObstacleDetectionType.Value.UnPack() : null);
			_o.ExtraObstacleDetectionRange = new TTriggerShapeUnion();
			_o.ExtraObstacleDetectionRange.Type = this.ExtraObstacleDetectionRangeType;
			switch (this.ExtraObstacleDetectionRangeType)
			{
			case TTriggerShape.IActorCollisionTriggerShape:
				_o.ExtraObstacleDetectionRange.Value = ((this.ExtraObstacleDetectionRange<IActorCollisionTriggerShape>() != null) ? this.ExtraObstacleDetectionRange<IActorCollisionTriggerShape>().Value.UnPack() : null);
				return;
			case TTriggerShape.IActorRefVolume:
				_o.ExtraObstacleDetectionRange.Value = ((this.ExtraObstacleDetectionRange<IActorRefVolume>() != null) ? this.ExtraObstacleDetectionRange<IActorRefVolume>().Value.UnPack() : null);
				return;
			case TTriggerShape.IBoxTriggerShape:
				_o.ExtraObstacleDetectionRange.Value = ((this.ExtraObstacleDetectionRange<IBoxTriggerShape>() != null) ? this.ExtraObstacleDetectionRange<IBoxTriggerShape>().Value.UnPack() : null);
				return;
			case TTriggerShape.ICombinationTriggerShape:
				_o.ExtraObstacleDetectionRange.Value = ((this.ExtraObstacleDetectionRange<ICombinationTriggerShape>() != null) ? this.ExtraObstacleDetectionRange<ICombinationTriggerShape>().Value.UnPack() : null);
				return;
			case TTriggerShape.IConeTriggerShape:
				_o.ExtraObstacleDetectionRange.Value = ((this.ExtraObstacleDetectionRange<IConeTriggerShape>() != null) ? this.ExtraObstacleDetectionRange<IConeTriggerShape>().Value.UnPack() : null);
				return;
			case TTriggerShape.ICylinderTriggerShape:
				_o.ExtraObstacleDetectionRange.Value = ((this.ExtraObstacleDetectionRange<ICylinderTriggerShape>() != null) ? this.ExtraObstacleDetectionRange<ICylinderTriggerShape>().Value.UnPack() : null);
				return;
			case TTriggerShape.IHollowCylinderTriggerShape:
				_o.ExtraObstacleDetectionRange.Value = ((this.ExtraObstacleDetectionRange<IHollowCylinderTriggerShape>() != null) ? this.ExtraObstacleDetectionRange<IHollowCylinderTriggerShape>().Value.UnPack() : null);
				return;
			case TTriggerShape.IHollowSphereTriggerShape:
				_o.ExtraObstacleDetectionRange.Value = ((this.ExtraObstacleDetectionRange<IHollowSphereTriggerShape>() != null) ? this.ExtraObstacleDetectionRange<IHollowSphereTriggerShape>().Value.UnPack() : null);
				return;
			case TTriggerShape.ISphereTriggerShape:
				_o.ExtraObstacleDetectionRange.Value = ((this.ExtraObstacleDetectionRange<ISphereTriggerShape>() != null) ? this.ExtraObstacleDetectionRange<ISphereTriggerShape>().Value.UnPack() : null);
				return;
			case TTriggerShape.ISpotlightTriggerShape:
				_o.ExtraObstacleDetectionRange.Value = ((this.ExtraObstacleDetectionRange<ISpotlightTriggerShape>() != null) ? this.ExtraObstacleDetectionRange<ISpotlightTriggerShape>().Value.UnPack() : null);
				return;
			case TTriggerShape.IVolumeTriggerShape:
				_o.ExtraObstacleDetectionRange.Value = ((this.ExtraObstacleDetectionRange<IVolumeTriggerShape>() != null) ? this.ExtraObstacleDetectionRange<IVolumeTriggerShape>().Value.UnPack() : null);
				return;
			default:
				return;
			}
		}

		// Token: 0x06024FBD RID: 151485 RVA: 0x0051BAE8 File Offset: 0x00519CE8
		public static Offset<IObstacleDetectionConfig> Pack(FlatBufferBuilder builder, IObstacleDetectionConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IObstacleDetectionConfig>);
			}
			Offset<ITrafficMatchTarget> obstacleDetectionTypeOffset = (_o.ObstacleDetectionType == null) ? default(Offset<ITrafficMatchTarget>) : ITrafficMatchTarget.Pack(builder, _o.ObstacleDetectionType);
			TTriggerShape extraObstacleDetectionRange_type = (_o.ExtraObstacleDetectionRange == null) ? TTriggerShape.NONE : _o.ExtraObstacleDetectionRange.Type;
			int extraObstacleDetectionRangeOffset = (_o.ExtraObstacleDetectionRange == null) ? 0 : TTriggerShapeUnion.Pack(builder, _o.ExtraObstacleDetectionRange);
			return IObstacleDetectionConfig.CreateIObstacleDetectionConfig(builder, obstacleDetectionTypeOffset, extraObstacleDetectionRange_type, extraObstacleDetectionRangeOffset);
		}

		// Token: 0x0400EAB2 RID: 60082
		private Table __p;
	}
}
