using System;
using Aki.UniverseEditor.Interface.Fbs.Shape;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020057F3 RID: 22515
	public struct IFollowDecorationChairConfig : IFlatbufferObject
	{
		// Token: 0x1700A2ED RID: 41709
		// (get) Token: 0x06024677 RID: 149111 RVA: 0x00500A05 File Offset: 0x004FEC05
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06024678 RID: 149112 RVA: 0x00500A12 File Offset: 0x004FEC12
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06024679 RID: 149113 RVA: 0x00500A1C File Offset: 0x004FEC1C
		public static IFollowDecorationChairConfig GetRootAsIFollowDecorationChairConfig(ByteBuffer _bb)
		{
			return IFollowDecorationChairConfig.GetRootAsIFollowDecorationChairConfig(_bb, default(IFollowDecorationChairConfig));
		}

		// Token: 0x0602467A RID: 149114 RVA: 0x00500A38 File Offset: 0x004FEC38
		public static IFollowDecorationChairConfig GetRootAsIFollowDecorationChairConfig(ByteBuffer _bb, IFollowDecorationChairConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602467B RID: 149115 RVA: 0x00500A55 File Offset: 0x004FEC55
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602467C RID: 149116 RVA: 0x00500A64 File Offset: 0x004FEC64
		public IFollowDecorationChairConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A2EE RID: 41710
		// (get) Token: 0x0602467D RID: 149117 RVA: 0x00500A74 File Offset: 0x004FEC74
		public EFollowDecorationType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EFollowDecorationType.Chair;
				}
				return (EFollowDecorationType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700A2EF RID: 41711
		// (get) Token: 0x0602467E RID: 149118 RVA: 0x00500AB0 File Offset: 0x004FECB0
		public string Config
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602467F RID: 149119 RVA: 0x00500AE7 File Offset: 0x004FECE7
		public Span<byte> GetConfigBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06024680 RID: 149120 RVA: 0x00500AF6 File Offset: 0x004FECF6
		public byte[] GetConfigArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x1700A2F0 RID: 41712
		// (get) Token: 0x06024681 RID: 149121 RVA: 0x00500B04 File Offset: 0x004FED04
		public TTriggerShape CollisionDetectionRangeType
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return TTriggerShape.NONE;
				}
				return (TTriggerShape)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06024682 RID: 149122 RVA: 0x00500B40 File Offset: 0x004FED40
		public TTable? CollisionDetectionRange<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06024683 RID: 149123 RVA: 0x00500B88 File Offset: 0x004FED88
		public IActorCollisionTriggerShape CollisionDetectionRangeAsIActorCollisionTriggerShape()
		{
			return this.CollisionDetectionRange<IActorCollisionTriggerShape>().Value;
		}

		// Token: 0x06024684 RID: 149124 RVA: 0x00500BA4 File Offset: 0x004FEDA4
		public IActorRefVolume CollisionDetectionRangeAsIActorRefVolume()
		{
			return this.CollisionDetectionRange<IActorRefVolume>().Value;
		}

		// Token: 0x06024685 RID: 149125 RVA: 0x00500BC0 File Offset: 0x004FEDC0
		public IBoxTriggerShape CollisionDetectionRangeAsIBoxTriggerShape()
		{
			return this.CollisionDetectionRange<IBoxTriggerShape>().Value;
		}

		// Token: 0x06024686 RID: 149126 RVA: 0x00500BDC File Offset: 0x004FEDDC
		public ICombinationTriggerShape CollisionDetectionRangeAsICombinationTriggerShape()
		{
			return this.CollisionDetectionRange<ICombinationTriggerShape>().Value;
		}

		// Token: 0x06024687 RID: 149127 RVA: 0x00500BF8 File Offset: 0x004FEDF8
		public IConeTriggerShape CollisionDetectionRangeAsIConeTriggerShape()
		{
			return this.CollisionDetectionRange<IConeTriggerShape>().Value;
		}

		// Token: 0x06024688 RID: 149128 RVA: 0x00500C14 File Offset: 0x004FEE14
		public ICylinderTriggerShape CollisionDetectionRangeAsICylinderTriggerShape()
		{
			return this.CollisionDetectionRange<ICylinderTriggerShape>().Value;
		}

		// Token: 0x06024689 RID: 149129 RVA: 0x00500C30 File Offset: 0x004FEE30
		public IHollowCylinderTriggerShape CollisionDetectionRangeAsIHollowCylinderTriggerShape()
		{
			return this.CollisionDetectionRange<IHollowCylinderTriggerShape>().Value;
		}

		// Token: 0x0602468A RID: 149130 RVA: 0x00500C4C File Offset: 0x004FEE4C
		public IHollowSphereTriggerShape CollisionDetectionRangeAsIHollowSphereTriggerShape()
		{
			return this.CollisionDetectionRange<IHollowSphereTriggerShape>().Value;
		}

		// Token: 0x0602468B RID: 149131 RVA: 0x00500C68 File Offset: 0x004FEE68
		public ISphereTriggerShape CollisionDetectionRangeAsISphereTriggerShape()
		{
			return this.CollisionDetectionRange<ISphereTriggerShape>().Value;
		}

		// Token: 0x0602468C RID: 149132 RVA: 0x00500C84 File Offset: 0x004FEE84
		public ISpotlightTriggerShape CollisionDetectionRangeAsISpotlightTriggerShape()
		{
			return this.CollisionDetectionRange<ISpotlightTriggerShape>().Value;
		}

		// Token: 0x0602468D RID: 149133 RVA: 0x00500CA0 File Offset: 0x004FEEA0
		public IVolumeTriggerShape CollisionDetectionRangeAsIVolumeTriggerShape()
		{
			return this.CollisionDetectionRange<IVolumeTriggerShape>().Value;
		}

		// Token: 0x0602468E RID: 149134 RVA: 0x00500CBB File Offset: 0x004FEEBB
		public static Offset<IFollowDecorationChairConfig> CreateIFollowDecorationChairConfig(FlatBufferBuilder builder, EFollowDecorationType Type = EFollowDecorationType.Chair, StringOffset ConfigOffset = default(StringOffset), TTriggerShape CollisionDetectionRange_type = TTriggerShape.NONE, int CollisionDetectionRangeOffset = 0)
		{
			builder.StartTable(4);
			IFollowDecorationChairConfig.AddCollisionDetectionRange(builder, CollisionDetectionRangeOffset);
			IFollowDecorationChairConfig.AddConfig(builder, ConfigOffset);
			IFollowDecorationChairConfig.AddCollisionDetectionRangeType(builder, CollisionDetectionRange_type);
			IFollowDecorationChairConfig.AddType(builder, Type);
			return IFollowDecorationChairConfig.EndIFollowDecorationChairConfig(builder);
		}

		// Token: 0x0602468F RID: 149135 RVA: 0x00500CE7 File Offset: 0x004FEEE7
		public static void StartIFollowDecorationChairConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06024690 RID: 149136 RVA: 0x00500CF0 File Offset: 0x004FEEF0
		public static void AddType(FlatBufferBuilder builder, EFollowDecorationType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06024691 RID: 149137 RVA: 0x00500CFB File Offset: 0x004FEEFB
		public static void AddConfig(FlatBufferBuilder builder, StringOffset configOffset)
		{
			builder.AddOffset(1, configOffset.Value, 0);
		}

		// Token: 0x06024692 RID: 149138 RVA: 0x00500D0B File Offset: 0x004FEF0B
		public static void AddCollisionDetectionRangeType(FlatBufferBuilder builder, TTriggerShape collisionDetectionRangeType)
		{
			builder.AddByte(2, (byte)collisionDetectionRangeType, 0);
		}

		// Token: 0x06024693 RID: 149139 RVA: 0x00500D16 File Offset: 0x004FEF16
		public static void AddCollisionDetectionRange(FlatBufferBuilder builder, int collisionDetectionRangeOffset)
		{
			builder.AddOffset(3, collisionDetectionRangeOffset, 0);
		}

		// Token: 0x06024694 RID: 149140 RVA: 0x00500D21 File Offset: 0x004FEF21
		public static Offset<IFollowDecorationChairConfig> EndIFollowDecorationChairConfig(FlatBufferBuilder builder)
		{
			return new Offset<IFollowDecorationChairConfig>(builder.EndTable());
		}

		// Token: 0x06024695 RID: 149141 RVA: 0x00500D30 File Offset: 0x004FEF30
		public IFollowDecorationChairConfigT UnPack()
		{
			IFollowDecorationChairConfigT followDecorationChairConfigT = new IFollowDecorationChairConfigT();
			this.UnPackTo(followDecorationChairConfigT);
			return followDecorationChairConfigT;
		}

		// Token: 0x06024696 RID: 149142 RVA: 0x00500D4C File Offset: 0x004FEF4C
		public void UnPackTo(IFollowDecorationChairConfigT _o)
		{
			_o.Type = this.Type;
			_o.Config = this.Config;
			_o.CollisionDetectionRange = new TTriggerShapeUnion();
			_o.CollisionDetectionRange.Type = this.CollisionDetectionRangeType;
			switch (this.CollisionDetectionRangeType)
			{
			case TTriggerShape.IActorCollisionTriggerShape:
				_o.CollisionDetectionRange.Value = ((this.CollisionDetectionRange<IActorCollisionTriggerShape>() != null) ? this.CollisionDetectionRange<IActorCollisionTriggerShape>().Value.UnPack() : null);
				return;
			case TTriggerShape.IActorRefVolume:
				_o.CollisionDetectionRange.Value = ((this.CollisionDetectionRange<IActorRefVolume>() != null) ? this.CollisionDetectionRange<IActorRefVolume>().Value.UnPack() : null);
				return;
			case TTriggerShape.IBoxTriggerShape:
				_o.CollisionDetectionRange.Value = ((this.CollisionDetectionRange<IBoxTriggerShape>() != null) ? this.CollisionDetectionRange<IBoxTriggerShape>().Value.UnPack() : null);
				return;
			case TTriggerShape.ICombinationTriggerShape:
				_o.CollisionDetectionRange.Value = ((this.CollisionDetectionRange<ICombinationTriggerShape>() != null) ? this.CollisionDetectionRange<ICombinationTriggerShape>().Value.UnPack() : null);
				return;
			case TTriggerShape.IConeTriggerShape:
				_o.CollisionDetectionRange.Value = ((this.CollisionDetectionRange<IConeTriggerShape>() != null) ? this.CollisionDetectionRange<IConeTriggerShape>().Value.UnPack() : null);
				return;
			case TTriggerShape.ICylinderTriggerShape:
				_o.CollisionDetectionRange.Value = ((this.CollisionDetectionRange<ICylinderTriggerShape>() != null) ? this.CollisionDetectionRange<ICylinderTriggerShape>().Value.UnPack() : null);
				return;
			case TTriggerShape.IHollowCylinderTriggerShape:
				_o.CollisionDetectionRange.Value = ((this.CollisionDetectionRange<IHollowCylinderTriggerShape>() != null) ? this.CollisionDetectionRange<IHollowCylinderTriggerShape>().Value.UnPack() : null);
				return;
			case TTriggerShape.IHollowSphereTriggerShape:
				_o.CollisionDetectionRange.Value = ((this.CollisionDetectionRange<IHollowSphereTriggerShape>() != null) ? this.CollisionDetectionRange<IHollowSphereTriggerShape>().Value.UnPack() : null);
				return;
			case TTriggerShape.ISphereTriggerShape:
				_o.CollisionDetectionRange.Value = ((this.CollisionDetectionRange<ISphereTriggerShape>() != null) ? this.CollisionDetectionRange<ISphereTriggerShape>().Value.UnPack() : null);
				return;
			case TTriggerShape.ISpotlightTriggerShape:
				_o.CollisionDetectionRange.Value = ((this.CollisionDetectionRange<ISpotlightTriggerShape>() != null) ? this.CollisionDetectionRange<ISpotlightTriggerShape>().Value.UnPack() : null);
				return;
			case TTriggerShape.IVolumeTriggerShape:
				_o.CollisionDetectionRange.Value = ((this.CollisionDetectionRange<IVolumeTriggerShape>() != null) ? this.CollisionDetectionRange<IVolumeTriggerShape>().Value.UnPack() : null);
				return;
			default:
				return;
			}
		}

		// Token: 0x06024697 RID: 149143 RVA: 0x0050102C File Offset: 0x004FF22C
		public static Offset<IFollowDecorationChairConfig> Pack(FlatBufferBuilder builder, IFollowDecorationChairConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFollowDecorationChairConfig>);
			}
			StringOffset configOffset = (_o.Config == null) ? default(StringOffset) : builder.CreateString(_o.Config);
			TTriggerShape collisionDetectionRange_type = (_o.CollisionDetectionRange == null) ? TTriggerShape.NONE : _o.CollisionDetectionRange.Type;
			int collisionDetectionRangeOffset = (_o.CollisionDetectionRange == null) ? 0 : TTriggerShapeUnion.Pack(builder, _o.CollisionDetectionRange);
			return IFollowDecorationChairConfig.CreateIFollowDecorationChairConfig(builder, _o.Type, configOffset, collisionDetectionRange_type, collisionDetectionRangeOffset);
		}

		// Token: 0x0400EFFD RID: 61437
		private Table __p;
	}
}
