using System;
using Aki.UniverseEditor.Interface.Fbs.Shape;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200528B RID: 21131
	public struct IFollowDecorationChairConfig : IFlatbufferObject
	{
		// Token: 0x17009AEF RID: 39663
		// (get) Token: 0x060226DD RID: 141021 RVA: 0x004C5E95 File Offset: 0x004C4095
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060226DE RID: 141022 RVA: 0x004C5EA2 File Offset: 0x004C40A2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060226DF RID: 141023 RVA: 0x004C5EAC File Offset: 0x004C40AC
		public static IFollowDecorationChairConfig GetRootAsIFollowDecorationChairConfig(ByteBuffer _bb)
		{
			return IFollowDecorationChairConfig.GetRootAsIFollowDecorationChairConfig(_bb, default(IFollowDecorationChairConfig));
		}

		// Token: 0x060226E0 RID: 141024 RVA: 0x004C5EC8 File Offset: 0x004C40C8
		public static IFollowDecorationChairConfig GetRootAsIFollowDecorationChairConfig(ByteBuffer _bb, IFollowDecorationChairConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060226E1 RID: 141025 RVA: 0x004C5EE5 File Offset: 0x004C40E5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060226E2 RID: 141026 RVA: 0x004C5EF4 File Offset: 0x004C40F4
		public IFollowDecorationChairConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009AF0 RID: 39664
		// (get) Token: 0x060226E3 RID: 141027 RVA: 0x004C5F04 File Offset: 0x004C4104
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

		// Token: 0x17009AF1 RID: 39665
		// (get) Token: 0x060226E4 RID: 141028 RVA: 0x004C5F40 File Offset: 0x004C4140
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

		// Token: 0x060226E5 RID: 141029 RVA: 0x004C5F77 File Offset: 0x004C4177
		public Span<byte> GetConfigBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x060226E6 RID: 141030 RVA: 0x004C5F86 File Offset: 0x004C4186
		public byte[] GetConfigArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x17009AF2 RID: 39666
		// (get) Token: 0x060226E7 RID: 141031 RVA: 0x004C5F94 File Offset: 0x004C4194
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

		// Token: 0x060226E8 RID: 141032 RVA: 0x004C5FD0 File Offset: 0x004C41D0
		public TTable? CollisionDetectionRange<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x060226E9 RID: 141033 RVA: 0x004C6018 File Offset: 0x004C4218
		public IActorCollisionTriggerShape CollisionDetectionRangeAsIActorCollisionTriggerShape()
		{
			return this.CollisionDetectionRange<IActorCollisionTriggerShape>().Value;
		}

		// Token: 0x060226EA RID: 141034 RVA: 0x004C6034 File Offset: 0x004C4234
		public IActorRefVolume CollisionDetectionRangeAsIActorRefVolume()
		{
			return this.CollisionDetectionRange<IActorRefVolume>().Value;
		}

		// Token: 0x060226EB RID: 141035 RVA: 0x004C6050 File Offset: 0x004C4250
		public IBoxTriggerShape CollisionDetectionRangeAsIBoxTriggerShape()
		{
			return this.CollisionDetectionRange<IBoxTriggerShape>().Value;
		}

		// Token: 0x060226EC RID: 141036 RVA: 0x004C606C File Offset: 0x004C426C
		public ICombinationTriggerShape CollisionDetectionRangeAsICombinationTriggerShape()
		{
			return this.CollisionDetectionRange<ICombinationTriggerShape>().Value;
		}

		// Token: 0x060226ED RID: 141037 RVA: 0x004C6088 File Offset: 0x004C4288
		public IConeTriggerShape CollisionDetectionRangeAsIConeTriggerShape()
		{
			return this.CollisionDetectionRange<IConeTriggerShape>().Value;
		}

		// Token: 0x060226EE RID: 141038 RVA: 0x004C60A4 File Offset: 0x004C42A4
		public ICylinderTriggerShape CollisionDetectionRangeAsICylinderTriggerShape()
		{
			return this.CollisionDetectionRange<ICylinderTriggerShape>().Value;
		}

		// Token: 0x060226EF RID: 141039 RVA: 0x004C60C0 File Offset: 0x004C42C0
		public IHollowCylinderTriggerShape CollisionDetectionRangeAsIHollowCylinderTriggerShape()
		{
			return this.CollisionDetectionRange<IHollowCylinderTriggerShape>().Value;
		}

		// Token: 0x060226F0 RID: 141040 RVA: 0x004C60DC File Offset: 0x004C42DC
		public IHollowSphereTriggerShape CollisionDetectionRangeAsIHollowSphereTriggerShape()
		{
			return this.CollisionDetectionRange<IHollowSphereTriggerShape>().Value;
		}

		// Token: 0x060226F1 RID: 141041 RVA: 0x004C60F8 File Offset: 0x004C42F8
		public ISphereTriggerShape CollisionDetectionRangeAsISphereTriggerShape()
		{
			return this.CollisionDetectionRange<ISphereTriggerShape>().Value;
		}

		// Token: 0x060226F2 RID: 141042 RVA: 0x004C6114 File Offset: 0x004C4314
		public ISpotlightTriggerShape CollisionDetectionRangeAsISpotlightTriggerShape()
		{
			return this.CollisionDetectionRange<ISpotlightTriggerShape>().Value;
		}

		// Token: 0x060226F3 RID: 141043 RVA: 0x004C6130 File Offset: 0x004C4330
		public IVolumeTriggerShape CollisionDetectionRangeAsIVolumeTriggerShape()
		{
			return this.CollisionDetectionRange<IVolumeTriggerShape>().Value;
		}

		// Token: 0x060226F4 RID: 141044 RVA: 0x004C614B File Offset: 0x004C434B
		public static Offset<IFollowDecorationChairConfig> CreateIFollowDecorationChairConfig(FlatBufferBuilder builder, EFollowDecorationType Type = EFollowDecorationType.Chair, StringOffset ConfigOffset = default(StringOffset), TTriggerShape CollisionDetectionRange_type = TTriggerShape.NONE, int CollisionDetectionRangeOffset = 0)
		{
			builder.StartTable(4);
			IFollowDecorationChairConfig.AddCollisionDetectionRange(builder, CollisionDetectionRangeOffset);
			IFollowDecorationChairConfig.AddConfig(builder, ConfigOffset);
			IFollowDecorationChairConfig.AddCollisionDetectionRangeType(builder, CollisionDetectionRange_type);
			IFollowDecorationChairConfig.AddType(builder, Type);
			return IFollowDecorationChairConfig.EndIFollowDecorationChairConfig(builder);
		}

		// Token: 0x060226F5 RID: 141045 RVA: 0x004C6177 File Offset: 0x004C4377
		public static void StartIFollowDecorationChairConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x060226F6 RID: 141046 RVA: 0x004C6180 File Offset: 0x004C4380
		public static void AddType(FlatBufferBuilder builder, EFollowDecorationType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060226F7 RID: 141047 RVA: 0x004C618B File Offset: 0x004C438B
		public static void AddConfig(FlatBufferBuilder builder, StringOffset configOffset)
		{
			builder.AddOffset(1, configOffset.Value, 0);
		}

		// Token: 0x060226F8 RID: 141048 RVA: 0x004C619B File Offset: 0x004C439B
		public static void AddCollisionDetectionRangeType(FlatBufferBuilder builder, TTriggerShape collisionDetectionRangeType)
		{
			builder.AddByte(2, (byte)collisionDetectionRangeType, 0);
		}

		// Token: 0x060226F9 RID: 141049 RVA: 0x004C61A6 File Offset: 0x004C43A6
		public static void AddCollisionDetectionRange(FlatBufferBuilder builder, int collisionDetectionRangeOffset)
		{
			builder.AddOffset(3, collisionDetectionRangeOffset, 0);
		}

		// Token: 0x060226FA RID: 141050 RVA: 0x004C61B1 File Offset: 0x004C43B1
		public static Offset<IFollowDecorationChairConfig> EndIFollowDecorationChairConfig(FlatBufferBuilder builder)
		{
			return new Offset<IFollowDecorationChairConfig>(builder.EndTable());
		}

		// Token: 0x060226FB RID: 141051 RVA: 0x004C61C0 File Offset: 0x004C43C0
		public IFollowDecorationChairConfigT UnPack()
		{
			IFollowDecorationChairConfigT followDecorationChairConfigT = new IFollowDecorationChairConfigT();
			this.UnPackTo(followDecorationChairConfigT);
			return followDecorationChairConfigT;
		}

		// Token: 0x060226FC RID: 141052 RVA: 0x004C61DC File Offset: 0x004C43DC
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

		// Token: 0x060226FD RID: 141053 RVA: 0x004C64BC File Offset: 0x004C46BC
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

		// Token: 0x0400E3F6 RID: 58358
		private Table __p;
	}
}
