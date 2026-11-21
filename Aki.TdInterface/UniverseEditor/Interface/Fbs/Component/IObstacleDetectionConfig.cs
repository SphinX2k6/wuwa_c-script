using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Aki.UniverseEditor.Interface.Fbs.Shape;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005C33 RID: 23603
	public struct IObstacleDetectionConfig : IFlatbufferObject
	{
		// Token: 0x1700AD5A RID: 44378
		// (get) Token: 0x060271DA RID: 160218 RVA: 0x0055C08A File Offset: 0x0055A28A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060271DB RID: 160219 RVA: 0x0055C097 File Offset: 0x0055A297
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060271DC RID: 160220 RVA: 0x0055C0A0 File Offset: 0x0055A2A0
		public static IObstacleDetectionConfig GetRootAsIObstacleDetectionConfig(ByteBuffer _bb)
		{
			return IObstacleDetectionConfig.GetRootAsIObstacleDetectionConfig(_bb, default(IObstacleDetectionConfig));
		}

		// Token: 0x060271DD RID: 160221 RVA: 0x0055C0BC File Offset: 0x0055A2BC
		public static IObstacleDetectionConfig GetRootAsIObstacleDetectionConfig(ByteBuffer _bb, IObstacleDetectionConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060271DE RID: 160222 RVA: 0x0055C0D9 File Offset: 0x0055A2D9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060271DF RID: 160223 RVA: 0x0055C0E8 File Offset: 0x0055A2E8
		public IObstacleDetectionConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700AD5B RID: 44379
		// (get) Token: 0x060271E0 RID: 160224 RVA: 0x0055C0F8 File Offset: 0x0055A2F8
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

		// Token: 0x1700AD5C RID: 44380
		// (get) Token: 0x060271E1 RID: 160225 RVA: 0x0055C158 File Offset: 0x0055A358
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

		// Token: 0x060271E2 RID: 160226 RVA: 0x0055C194 File Offset: 0x0055A394
		public TTable? ExtraObstacleDetectionRange<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x060271E3 RID: 160227 RVA: 0x0055C1D8 File Offset: 0x0055A3D8
		public IActorCollisionTriggerShape ExtraObstacleDetectionRangeAsIActorCollisionTriggerShape()
		{
			return this.ExtraObstacleDetectionRange<IActorCollisionTriggerShape>().Value;
		}

		// Token: 0x060271E4 RID: 160228 RVA: 0x0055C1F4 File Offset: 0x0055A3F4
		public IActorRefVolume ExtraObstacleDetectionRangeAsIActorRefVolume()
		{
			return this.ExtraObstacleDetectionRange<IActorRefVolume>().Value;
		}

		// Token: 0x060271E5 RID: 160229 RVA: 0x0055C210 File Offset: 0x0055A410
		public IBoxTriggerShape ExtraObstacleDetectionRangeAsIBoxTriggerShape()
		{
			return this.ExtraObstacleDetectionRange<IBoxTriggerShape>().Value;
		}

		// Token: 0x060271E6 RID: 160230 RVA: 0x0055C22C File Offset: 0x0055A42C
		public ICombinationTriggerShape ExtraObstacleDetectionRangeAsICombinationTriggerShape()
		{
			return this.ExtraObstacleDetectionRange<ICombinationTriggerShape>().Value;
		}

		// Token: 0x060271E7 RID: 160231 RVA: 0x0055C248 File Offset: 0x0055A448
		public IConeTriggerShape ExtraObstacleDetectionRangeAsIConeTriggerShape()
		{
			return this.ExtraObstacleDetectionRange<IConeTriggerShape>().Value;
		}

		// Token: 0x060271E8 RID: 160232 RVA: 0x0055C264 File Offset: 0x0055A464
		public ICylinderTriggerShape ExtraObstacleDetectionRangeAsICylinderTriggerShape()
		{
			return this.ExtraObstacleDetectionRange<ICylinderTriggerShape>().Value;
		}

		// Token: 0x060271E9 RID: 160233 RVA: 0x0055C280 File Offset: 0x0055A480
		public IHollowCylinderTriggerShape ExtraObstacleDetectionRangeAsIHollowCylinderTriggerShape()
		{
			return this.ExtraObstacleDetectionRange<IHollowCylinderTriggerShape>().Value;
		}

		// Token: 0x060271EA RID: 160234 RVA: 0x0055C29C File Offset: 0x0055A49C
		public IHollowSphereTriggerShape ExtraObstacleDetectionRangeAsIHollowSphereTriggerShape()
		{
			return this.ExtraObstacleDetectionRange<IHollowSphereTriggerShape>().Value;
		}

		// Token: 0x060271EB RID: 160235 RVA: 0x0055C2B8 File Offset: 0x0055A4B8
		public ISphereTriggerShape ExtraObstacleDetectionRangeAsISphereTriggerShape()
		{
			return this.ExtraObstacleDetectionRange<ISphereTriggerShape>().Value;
		}

		// Token: 0x060271EC RID: 160236 RVA: 0x0055C2D4 File Offset: 0x0055A4D4
		public ISpotlightTriggerShape ExtraObstacleDetectionRangeAsISpotlightTriggerShape()
		{
			return this.ExtraObstacleDetectionRange<ISpotlightTriggerShape>().Value;
		}

		// Token: 0x060271ED RID: 160237 RVA: 0x0055C2F0 File Offset: 0x0055A4F0
		public IVolumeTriggerShape ExtraObstacleDetectionRangeAsIVolumeTriggerShape()
		{
			return this.ExtraObstacleDetectionRange<IVolumeTriggerShape>().Value;
		}

		// Token: 0x060271EE RID: 160238 RVA: 0x0055C30B File Offset: 0x0055A50B
		public static Offset<IObstacleDetectionConfig> CreateIObstacleDetectionConfig(FlatBufferBuilder builder, Offset<ITrafficMatchTarget> ObstacleDetectionTypeOffset = default(Offset<ITrafficMatchTarget>), TTriggerShape ExtraObstacleDetectionRange_type = TTriggerShape.NONE, int ExtraObstacleDetectionRangeOffset = 0)
		{
			builder.StartTable(3);
			IObstacleDetectionConfig.AddExtraObstacleDetectionRange(builder, ExtraObstacleDetectionRangeOffset);
			IObstacleDetectionConfig.AddObstacleDetectionType(builder, ObstacleDetectionTypeOffset);
			IObstacleDetectionConfig.AddExtraObstacleDetectionRangeType(builder, ExtraObstacleDetectionRange_type);
			return IObstacleDetectionConfig.EndIObstacleDetectionConfig(builder);
		}

		// Token: 0x060271EF RID: 160239 RVA: 0x0055C32F File Offset: 0x0055A52F
		public static void StartIObstacleDetectionConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x060271F0 RID: 160240 RVA: 0x0055C338 File Offset: 0x0055A538
		public static void AddObstacleDetectionType(FlatBufferBuilder builder, Offset<ITrafficMatchTarget> obstacleDetectionTypeOffset)
		{
			builder.AddOffset(0, obstacleDetectionTypeOffset.Value, 0);
		}

		// Token: 0x060271F1 RID: 160241 RVA: 0x0055C348 File Offset: 0x0055A548
		public static void AddExtraObstacleDetectionRangeType(FlatBufferBuilder builder, TTriggerShape extraObstacleDetectionRangeType)
		{
			builder.AddByte(1, (byte)extraObstacleDetectionRangeType, 0);
		}

		// Token: 0x060271F2 RID: 160242 RVA: 0x0055C353 File Offset: 0x0055A553
		public static void AddExtraObstacleDetectionRange(FlatBufferBuilder builder, int extraObstacleDetectionRangeOffset)
		{
			builder.AddOffset(2, extraObstacleDetectionRangeOffset, 0);
		}

		// Token: 0x060271F3 RID: 160243 RVA: 0x0055C35E File Offset: 0x0055A55E
		public static Offset<IObstacleDetectionConfig> EndIObstacleDetectionConfig(FlatBufferBuilder builder)
		{
			return new Offset<IObstacleDetectionConfig>(builder.EndTable());
		}

		// Token: 0x060271F4 RID: 160244 RVA: 0x0055C36C File Offset: 0x0055A56C
		public IObstacleDetectionConfigT UnPack()
		{
			IObstacleDetectionConfigT obstacleDetectionConfigT = new IObstacleDetectionConfigT();
			this.UnPackTo(obstacleDetectionConfigT);
			return obstacleDetectionConfigT;
		}

		// Token: 0x060271F5 RID: 160245 RVA: 0x0055C388 File Offset: 0x0055A588
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

		// Token: 0x060271F6 RID: 160246 RVA: 0x0055C684 File Offset: 0x0055A884
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

		// Token: 0x0400F71B RID: 63259
		private Table __p;
	}
}
